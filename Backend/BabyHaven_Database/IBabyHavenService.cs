using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;

namespace BabyHaven_Database
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBabyHavenService" in both code and config file together.
    [ServiceContract]
    public interface IBabyHavenService
    {
        //getting user
        [OperationContract]
        int Login(string email, string password);


        //getting the user from the table
        [OperationContract]
        User_Table GetUser(int id);


        //getting email
        [OperationContract]
        User_Table GetEmail(string email, int id);

        //getting admin
        [OperationContract]
        Admin GetAdmin(int id);

        //getting client
        [OperationContract]
        Client GetClient(int id);


        //getting all users
        [OperationContract]
        List<User_Table> GetAllUsers();

        [OperationContract]
        bool Register(string email, string password, string name, string surname, string phoneno, string address, int usetype = 1);

        //Adding Admin
        [OperationContract]
        bool AddAdmin(int user, string surname);

        //Searching Users
        [OperationContract]
        List<User_Table> SearchUsersByName(string searchQuery);

        //CART
        [OperationContract]
        bool AddToCart(int uId, int pId);

        [OperationContract]
        decimal GetTotalCartPrice(int clientId);

        [OperationContract]
        //Returns all the items from a client
        List<Cart> GetAllCartItemsForClient(int ClientID);

        [OperationContract]
        List<Product> GetCartProducts(int id);

        [OperationContract]
        int GetQuantity(int UserID, int ProductID);

        [OperationContract]
        void AddRemoveProductFromCart(int pID, int uID, string action, int amount);

        [OperationContract]
        void RemoveProductFromCart(int productId, int userId, int quantityToRemove);

        [OperationContract]
        string GetProductImage(int productID);

        [OperationContract]
        string GetProductName(int productID);

        [OperationContract]
        decimal GetProductPrice(int productID);

        //-------------------------------------------PRODUCTS------------------------------------------------------//
        [OperationContract]
        List<Product> Getallproducts();

        [OperationContract]
        List<Product> getProductCat(string cat);

        [OperationContract]
        Product getSingleProd(int id);

        [OperationContract]
        string Addproducts(string name, string description, string cat, int quantity, decimal price, bool active, int prodID, int admin);

        [OperationContract]
         int numDifferentProductsSold();

        [OperationContract]
        int numOnHand(int id);

        [OperationContract]
        int regperday();
    }
}
