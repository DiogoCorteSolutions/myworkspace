// <copyright file="Class1Test.cs">Copyright ©  2018</copyright>
using System;
using CertificatioTHREADS;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CertificatioTHREADS.Tests
{
    /// <summary>This class contains parameterized unit tests for Class1</summary>
    [PexClass(typeof(Class1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Class1Test
    {
        /// <summary>Test stub for Valida(String)</summary>
        [PexMethod]
        public bool ValidaTest([PexAssumeUnderTest]Class1 target, string cpf)
        {
            bool result = target.Valida(cpf);
            return result;
            // TODO: add assertions to method Class1Test.ValidaTest(Class1, String)
        }
    }
}
