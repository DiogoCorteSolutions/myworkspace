using Microsoft.VisualStudio.TestTools.UnitTesting;
using CertificatioTHREADS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificatioTHREADS.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void ValidaTest()
        {
            Class1 clas = new Class1();
            Assert.IsTrue(clas.Valida("11772826405") == true);

        }

        [TestMethod()]
        public void ValidaAlgo()
        {
            Class1 clas = new Class1();
            string cpf = "000";
            string cpf = "56766";
                Assert.IsNull(cpf);

        }

    }
}