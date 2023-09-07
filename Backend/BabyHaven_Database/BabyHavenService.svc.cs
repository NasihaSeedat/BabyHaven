using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;

namespace BabyHaven_Database
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BabyHavenService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BabyHavenService.svc or BabyHavenService.svc.cs at the Solution Explorer and start debugging.
    public class BabyHavenService : IBabyHavenService
    {
        BabyHavenDataContext db = new BabyHavenDataContext();

        public Admin GetAdmin(int id)
        {
            var adm = (from a in db.Admins
                       where a.U_Id.Equals(id)
                       select a).FirstOrDefault();
            if (adm == null)
            {
                return null;
            }
            else
            {
                return adm;
            }
        }

        public Client GetClient(int id)
        {
            var cl = (from c in db.Clients
                      where c.U_Id.Equals(id)
                      select c).FirstOrDefault();

            if (cl == null)
            {
                return null;
            }
            else
            {
                return cl;
            }
        }

        public User_Table GetEmail(string email, int id)
        {
            var us = (from e in db.User_Tables
                      where e.Email.Equals(email) && e.User_Id != id
                      select e).FirstOrDefault();

            if (us == null)
            {
                return null;
            }
            else
            {
                return us;
            }
        }

        public User_Table GetUser(int id)
        {
            var us = (from u in db.User_Tables
                      where u.User_Id.Equals(id)
                      select u).FirstOrDefault();

            if (us != null)
            {
                return us;

            }
            else
            {
                return null;
            }
        }

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

        public bool Register(string email, string password, string name, string surname, string phoneno, string address, int usetype)
        {
            var use = (from u in db.User_Tables
                       where u.Email.Equals(email)
                       select u).FirstOrDefault();

            if (use == null)
            {
                try
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

               

               
                    db.SubmitChanges();
                    var userr = (from u in db.User_Tables
                                 where u.Email.Equals(email)
                                 select u).FirstOrDefault();
                    if (usetype == 0)
                    {
                        Admin a = new Admin
                        {
                            U_Id = userr.User_Id,
                            Surname = surname
                        };
                        db.Admins.InsertOnSubmit(a);
                    }
                    else
                    {
                        Client c = new Client
                        {
                            U_Id = userr.User_Id,
                            Email = email
                        };
                        db.Clients.InsertOnSubmit(c);

                    }
                    db.SubmitChanges();
                    return true;
                }catch(Exception ex)
                {
                    ex.GetBaseException();
                    return false;
                }
            }
            else
            {
                //already exists
                return false;
            }
        }

        public Product getSingleProd(int id)
        {
            var prod = (from p in db.Products
                        where p.Product_Id == id
                        select p).FirstOrDefault();
            if (prod != null)
            {
                return prod;
            }
            else
            {
                return null;
            }

        }

        public List<Product> GetCartProducts(int id)
        {
            dynamic Pid = (from p in db.Carts
                           where p.U_Id == id && p.P_Id != null
                           select p.P_Id).ToList();

            List<Product> products = new List<Product>();
            foreach (int productid in Pid)
            {
                Product pr = getSingleProd(productid);
                if (pr != null)
                    products.Add(pr);
            }

            return products;
        }

        public int GetQuantity(int UserID, int ProductID)
        {
            int Quantity = (from p in db.Carts
                            where p.U_Id == UserID && p.P_Id == ProductID
                            select p.Cart_Quantity).FirstOrDefault();
            return Quantity;
        }
    }
}
