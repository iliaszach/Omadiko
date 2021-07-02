using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omadiko.RepositoryServices.RepositoryServises;
using Omadiko.Entities.Models;
using Omadiko.RepositoryServices;

namespace Omadiko.Console2
{
    class Program
    {
        static void Main(string[] args)
        {

           StudentRepository repos = new StudentRepository();

           var student = repos.GetById(2);
           Console.WriteLine(student.Name);
            
            //repos.Insert();

            //foreach (var item in repos.GetAll())
            //{
            //    Console.WriteLine(item.Name);
            //}




        }
    }
}
