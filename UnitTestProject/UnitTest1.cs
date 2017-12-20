using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using MyPasswords;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            MyPasswordManager manager = new MyPasswordManager();

            for (int i = 0; i < 10; i++)
            {
                manager.add("user " + i, "password " + i);
            }

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<MyPassword>));
            //XmlSerializer xmlSerializer = new XmlSerializer(manager.getPasswordsList().GetType());
            XmlSerializer xmlSerializer = new XmlSerializer(manager.GetType());
            StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, manager);
            textWriter.Close();

            Debug.WriteLine(textWriter.ToString());
        }
    }
}
