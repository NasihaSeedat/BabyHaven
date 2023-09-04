using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BabyHaven_Database
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBabyHavenService" in both code and config file together.
    [ServiceContract]
    public interface IBabyHavenService
    {
        [OperationContract]
        int Login(string email, string password);


        [OperationContract]
        string Register(string email, string password, string name, string surname, string phoneno, string address, int usetype = 1);

    }
}
