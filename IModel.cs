using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._09._2023_Паттерн_MVP
{
    internal interface IModel {
        string Name { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string Search { get; set; }

        void AddInfo();
        void DeleteInfo();
        void ShowAllInfo();
        void SearchInfo();
    }
}
