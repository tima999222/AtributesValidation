using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributesValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("af", "123fa");

            var e = user.ValidateUser();

            if (e.Count != 0)
            {
                foreach (var er in e)
                {
                    Console.WriteLine(er);
                }
            }
            else
            {
                Console.WriteLine("Пользователь пропущен");
            }

            User user1 = new User("", "123");
            var e1 = user1.ValidateUser();

            if (e1.Count != 0)
            {
                foreach (var er in e1)
                {
                    Console.WriteLine(er);
                }
            }
            else
            {
                Console.WriteLine("Пользователь пропущен");
            }
        }
    }
}
