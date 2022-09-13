using MarcosPauloPacifico_d3_avaliacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcosPauloPacifico_d3_avaliacao.Interfaces
{
    public interface IUser
    {
        List<User> ReadAll();

        string PrepareLineCSV(User user);

        void Create(User newUser);

        void CreateFolderFile();


    }
}
