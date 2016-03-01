using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorServer
{
    class DatabaseConnections
    {
        DoctorEntitiesServer db = new DoctorEntitiesServer();
        User user = new User();

        public bool IsUserRegistered(string email)
        {
            return db.User.Any(i => i.UserName == email);
        }

        public void UserReg(string username, string email, int age, string password)
        {
            if (!IsUserRegistered(email))
            {
                username = user.UserName;
                email = user.Email;
                age = user.Age;
                password = user.Password;

                db.User.Add(user);
                db.SaveChanges();
            }
            else
                Console.WriteLine("Please choose another username");
        }

        public bool IsUserLoggedIn(string email)
        {
            return db.User.Any(i => i.Email == email);
        }

        public void UserLoggedIn (string email, string password)
        {
            if (!IsUserLoggedIn(email))
            {
                email = user.Email;
                password = user.Password;

                db.User.Add(user);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Email not exist");
            }
        }
    }
}
