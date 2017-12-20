using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.Model
{
    [Serializable()]
    public class MyPassword
    {
        public String user { get; set; }
        public String password { get; set; }
        //public Uri url { get; set; }
        public String url { get; set; }

        public String owner { get; set; }  //Angela, Roberto, Mamma, Papa

        public String note { get; set; }

        public MyPassword()
        {

        }

    }
}
