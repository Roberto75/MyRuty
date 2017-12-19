using MyPasswords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyPasswords
{
    [XmlRoot("root")]
    public class MyPasswordManager
    {
        [XmlArray("MyPasswords")]
        [XmlArrayItem("MyPassword", typeof(MyPassword))]
        public List<MyPassword> passwordsList;


        // Constructor
        public MyPasswordManager()
        {
            passwordsList = new List<MyPassword>();
        }


        /*public List<MyPassword> getPasswordsList()
        {
            return passwordsList;
        }*/


        public void add(String username, String password)
        {
            MyPassword myPassword = new MyPassword();
            myPassword.password = password;
            myPassword.user = username;

            passwordsList.Add(myPassword);

        }

    }
}
