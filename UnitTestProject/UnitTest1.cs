using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using MyPasswords;
using System.Diagnostics;
using System.Xml;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void serializza()
        {

            MyPasswordManager manager = new MyPasswordManager();

            for (int i = 0; i < 10; i++)
            {
                manager.add("user " + i, "password " + i);
            }

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<MyPassword>));
            //XmlSerializer xmlSerializer = new XmlSerializer(manager.getPasswordsList().GetType());
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(MyPasswordManager));
            StringWriter textWriter = new StringWriterUtf8();

            xmlSerializer.Serialize(textWriter, manager);
            textWriter.Close();

            Debug.WriteLine(textWriter.ToString());

            //salvo il file ... 
            string desktop = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            System.IO.File.WriteAllText(desktop + "\\passwords.xml", textWriter.ToString());
        }





        [TestMethod]
        public void deserializza()
        {

            string desktop = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string content = System.IO.File.ReadAllText(desktop + "\\passwords.xml");

            FileStream fs = new FileStream(desktop + "\\passwords.xml", FileMode.Open);
            MyPasswordManager manager;
            try
            {
                XmlReader reader = XmlReader.Create(fs);
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(MyPasswordManager));
                manager = (MyPasswordManager)serializer.Deserialize(reader);
            }
            finally
            {
                fs.Close();
            }

            
            foreach ( MyPasswords.Model.MyPassword password in manager.passwordsList)
            {
                Debug.WriteLine("Password: " + password.user);
            }

        }
    }


    public class StringWriterUtf8 : System.IO.StringWriter
    {
        public override System.Text.Encoding Encoding
        {
            get
            {
                return System.Text.Encoding.UTF8;
            }
        }
    }
}
