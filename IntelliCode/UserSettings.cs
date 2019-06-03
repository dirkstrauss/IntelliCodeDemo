using System;
using System.Security.Cryptography;
using System.Text;

namespace IntelliCodeDemo
{
    public static class UserSettings
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static DateTime DOB { get; set; }

        public static Guid GetUserGuid(string value)
        {            
            Guid GenerateGuid()
            {
                using (var md5 = MD5.Create())
                {
                    var hash = md5.ComputeHash(Encoding.Default.GetBytes(value));
                    return new Guid(hash);
                }                
            }

            return GenerateGuid();
        }

        public static string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public static int GetAge()
        {            
            var age = DateTime.Now - DOB;
            return (int)(age.Days / 365.25);
        }

    }
}
