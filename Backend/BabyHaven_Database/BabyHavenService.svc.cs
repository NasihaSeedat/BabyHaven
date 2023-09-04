using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BabyHaven_Database
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BabyHavenService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BabyHavenService.svc or BabyHavenService.svc.cs at the Solution Explorer and start debugging.
    public class BabyHavenService : IBabyHavenService
    {
        BabyHavenDataContext db = new BabyHavenDataContext();

        public int Login(string email, string password)
        {
            var us = (from u in db.User_Tables
                      where u.Email.Equals(email) && u.Password.Equals(password)
                      select u).FirstOrDefault();

            if (us != null)
            {
                return us.User_Id;
            }
            else
            {
                return 0;
            }
        }

        public string Register(string email, string password, string name, string surname, string phoneno, string address, int usetype = 1)
        {
            var use = (from u in db.User_Tables
                       where u.Email.Equals(email)
                       select u).FirstOrDefault();

            if (use == null)
            {
                var newUser = new User_Table
                {
                    Email = email,
                    Password = password,
                    Name = name,
                    Surname = surname,
                    Phone_Number = phoneno,
                    Address = address,
                    Register_Date = DateTime.Today,
                    UserType = usetype
                };
                db.User_Tables.InsertOnSubmit(newUser);

                if (usetype == 0)
                {
                    Admin a = new Admin
                    {
                        U_Id = newUser.User_Id,
                        Surname = surname
                    };
                    db.Admins.InsertOnSubmit(a);
                }
                else
                {
                    Client c = new Client
                    {
                        U_Id = newUser.User_Id,
                        Email = email
                    };
                    db.Clients.InsertOnSubmit(c);

                }

                try
                {
                    db.SubmitChanges();
                    return "REGISTERED";
                }catch(Exception ex)
                {
                    ex.GetBaseException();
                    return "REGISTERING UNSUCCESSFUL";
                }
            }
            else
            {
                return "REGISTERING UNSUCCESSFUL";
            }
        }
    }
}
