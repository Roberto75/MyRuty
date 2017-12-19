using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Serialization;
using MyPasswords.Models;
using System.Collections.Generic;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            MyPasswords.MyPasswordManager manager = new MyPasswords.MyPasswordManager();

            for (int i = 0; i < 10; i++)
            {
                manager.add("user " + i, "password " + i);
            }

            



            XmlSerializer xmlSerializer = new XmlSerializer(manager.GetType());
            StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, manager);
            textWriter.Close();

            Console.WriteLine(textWriter.ToString());

        }
    }
}
