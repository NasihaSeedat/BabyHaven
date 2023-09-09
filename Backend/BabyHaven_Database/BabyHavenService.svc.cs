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

            // Submit changes before calculating and updating the total cart price
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.GetBaseException());
                return false;
            }

            // Calculate and update Cart_Price for the entire cart
            var cartItems = (from c in db.Carts
                             where c.U_Id == uId
                             select c).ToList();

            foreach (var cartItem in cartItems)
            {
                // Calculate Cart_Price based on the product's price
                var product = (from p in db.Products
                               where p.Product_Id == cartItem.P_Id
                               select p).FirstOrDefault();

                if (product != null)
                {
                    cartItem.Cart_Price = product.P_Price * cartItem.Cart_Quantity;
                }
                else
                {
                    Debug.WriteLine("Product does not exist");
                    return false;
                }
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

        public decimal GetTotalCartPrice(int clientId)
        {
            decimal totalCartPrice = db.Carts
                .Where(cart => cart.U_Id == clientId)
                .Sum(cart => cart.Cart_Price);

            return totalCartPrice;
        }

        // Returns all the items from a client
        public List<Cart> GetAllCartItemsForClient(int ClientID)
        {
            List<Cart> ShoppingCart = (from s in db.Carts
                                       where s.U_Id.Equals(ClientID)
                                       select s).ToList();

            return ShoppingCart;
        }

        public string GetProductImage(int productID)
        {
            // Find the product by ID
            Product product = db.Products.FirstOrDefault(p => p.Product_Id == productID);

            // Check if the product exists and return its name
            return product != null ? product.P_Image : string.Empty;
        }

        public string GetProductName(int productID)
        {
            // Find the product by ID
            Product product = db.Products.FirstOrDefault(p => p.Product_Id == productID);

            // Check if the product exists and return its name
            return product != null ? product.P_Name : string.Empty;
        }

        public decimal GetProductPrice(int productID)
        {
            // Find the product by ID
            Product product = db.Products.FirstOrDefault(p => p.Product_Id == productID);

            // Check if the product exists and return its price
            return product != null ? product.P_Price : 0.0M;
        }


        //-------------------------------------------PRODUCTS------------------------------------------------------//
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

        public void AddRemoveProductFromCart(int pID, int uID, string action, int amount)
        {
            var Pcart = (from p in db.Carts
                         where p.U_Id.Equals(uID) && p.P_Id.Equals(pID)
                         select p).FirstOrDefault();
            if (action.Equals("ADD"))
            {
                Pcart.Cart_Quantity += amount;
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                }

            }
            else if (action.Equals("REMOVE"))
            {
                if (Pcart.Cart_Quantity == 1)
                {
                    db.Carts.DeleteOnSubmit(Pcart);
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception e)
                    {
                        e.GetBaseException();
                    }
                }
                else if (Pcart.Cart_Quantity > 1)
                {
                    Pcart.Cart_Quantity -= amount;
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception e)
                    {
                        e.GetBaseException();
                    }
                }
            }
        }

        public void RemoveProductFromCart(int productId, int userId, int quantityToRemove)
        {
            // Retrieve the cart item for the specified product and user
            var cartItem = db.Carts.SingleOrDefault(c => c.P_Id == productId && c.U_Id == userId);

            if (cartItem != null)
            {
                // Check if the quantity to remove is less than or equal to the current cart quantity
                if (quantityToRemove >= cartItem.Cart_Quantity)
                {
                    // Remove the entire cart item if the quantity to remove is greater or equal
                    db.Carts.DeleteOnSubmit(cartItem);
                }
                else
                {
                    // Reduce the cart quantity by the specified amount
                    cartItem.Cart_Quantity -= quantityToRemove;
                }

                try
                {
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions (e.g., log or throw)
                    throw ex;
                }
            }
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

        public bool AddAdmin(User_Table user, string surname)
        {
            var ad = (from a in db.User_Tables
                      where a.User_Id.Equals(user.User_Id)
                      select a).FirstOrDefault();

            if (ad == null)
            {
                var newAd = new Admin()
                {
                    U_Id = user.User_Id,
                    Surname = surname
                };
                db.Admins.InsertOnSubmit(newAd);

                try
                {
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
                return false;
            }
        }

        public List<User_Table> SearchUsersByName(string searchQuery)
        {
            List<User_Table> searchResults = new List<User_Table>();

            // Use the connection string from the 'BabyHavenDatabaseConnectionString' name
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["BabyHavenDatabaseConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                string sqlQuery = "SELECT * FROM User_Table WHERE Name LIKE @SearchQuery";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create User_Table objects from the database results
                            User_Table user = new User_Table
                            {
                                User_Id = Convert.ToInt32(reader["User_Id"]),
                                Email = reader["Email"].ToString(),
                                Name = reader["Name"].ToString(),
                                Surname = reader["Surname"].ToString(),
                                Phone_Number = reader["Phone_Number"].ToString()
                                
                            };

                            searchResults.Add(user);
                        }
                    }
                }
            }

            return searchResults;
        }
    }
}
    

