using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IntelliCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            UserSettings.FirstName = "John";
            UserSettings.LastName = "Doe";
            UserSettings.DOB = DateTime.Now.AddYears(-25);

            WriteLine(UserSettings.FullName());
            WriteLine(UserSettings.GetAge());
            WriteLine(UserSettings.GetUserGuid(UserSettings.FullName()));
            _ = ReadLine();            

        }
    }
}
