using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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


       public List<User_Table> GetAllUsers()
        {
            var u = new List<User_Table>();

            dynamic users = (from us in db.User_Tables
                             select us);

            foreach(User_Table n in users)
            {
                var use = GetUser(n.User_Id);
                u.Add(use);
            }

            return u;


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

        //CART
        public bool AddToCart(int uId, int pId)
        {
            var existingCartItem = (from c in db.Carts
                                    where c.U_Id == uId && c.P_Id == pId
                                    select c).FirstOrDefault();

            if (existingCartItem != null)
            {
                // Item already exists in the cart, increase quantity
                existingCartItem.Cart_Quantity += 1;
            }
            else
            {
                // Item does not exist in the cart, add it
                var product = (from p in db.Products
                               where p.Product_Id == pId
                               select p).FirstOrDefault();

                if (product != null)
                {
                    Cart newProduct = new Cart
                    {
                        U_Id = uId,
                        P_Id = pId,
                        Cart_Quantity = 1
                    };

                    db.Carts.InsertOnSubmit(newProduct);
                }
                else
                {
                    // Handle the case where the product does not exist
                    return false;
                }
            }

            // Submit changes before calculating the total cart price
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.GetBaseException());
                return false;
            }

            // Update Cart_Price for the entire cart
            var cartItems = (from c in db.Carts
                             where c.U_Id == uId
                             select c).ToList();

            decimal totalCartPrice = cartItems.Sum(c => c.Cart_Price);

            foreach (var cartItem in cartItems)
            {
                cartItem.Cart_Price = cartItem.Product.P_Price * cartItem.Cart_Quantity; // Calculate based on product price
            }

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.GetBaseException());
                return false;
            }
        }

        public List<Product> GetCartProducts(int id)
        {
            dynamic Pid = (from p in db.Carts
                           where p.U_Id == id
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

        public List<Product> Getallproducts()
        {
            var prods = new List<Product>();

            dynamic prod = (from t in db.Products
                            select t);

            foreach (Product p in prod)
            {
                var ps = getSingleProd(p.Product_Id);
                prods.Add(ps);
            }

            return prods;
        }

        public string Addproducts(string name, string description, string cat, int quantity, decimal price, bool active, int prodID, int admin)
        {
            var prod = (from p in db.Products
                        where p.P_Name.Equals(name)
                        select p).FirstOrDefault();

            var a = GetAdmin(admin);
            a.U_Id = admin;

            var pr = getSingleProd(prodID);
            pr.Product_Id = prodID;

            if (prod == null)
            {
                var newprod = new Product
                {
                    P_Name = name,
                    P_Description = description,
                    P_Category = cat,
                    P_Quantity = quantity,
                    P_Price = price,
                    isActive = active,
                    P_DateCreated = DateTime.Today,
                };
                db.Products.InsertOnSubmit(newprod);

                try
                {
                    db.SubmitChanges();
                    return "added";
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    return "not added";
                }
            }
            else
            {
                return "error";
            }
        }
    }
}
