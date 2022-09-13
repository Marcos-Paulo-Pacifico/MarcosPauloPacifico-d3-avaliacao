using MarcosPauloPacifico_d3_avaliacao.Interfaces;
using MarcosPauloPacifico_d3_avaliacao.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcosPauloPacifico_d3_avaliacao.Repositories
{
    internal class UserRepository : IUser
    {
        private readonly string stringConnection = "Server=labsoft.pcs.usp.br; Initial Catalog =db_17; User id=usuario_17; pwd=46773450829";

        private const string path = "database/users.txt";

        public string PrepareLineCSV(User user)
        {
            return $"O usuário {user.UserName}({user.IdUser}) acessou o sistema às {DateTime.Now.ToString()} do dia {DateTime.Now.Date.ToString()}";
        }

        public void Create(User newUser)
        {
            string[] line = { PrepareLineCSV(newUser) };
            File.AppendAllLines(path, line);
        }

        public void CreateFolderFile()
        {
            string folder = path.Split("/")[0];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        public List<User> ReadAll()
        {
            List<User> listUsers = new();

            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string querySelect = "SELECT * FROM Products";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        User user = new()
                        {
                            IdUser = rdr["IdUser"].ToString(),
                            UserName = rdr[1].ToString(),
                            Email = rdr[2].ToString(),
                            Password = rdr[3].ToString(),
                        };

                        listUsers.Add(user);
                    }
                }
            }

            return listUsers;
        }
    }
}
