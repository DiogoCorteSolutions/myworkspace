using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CertificatioTHREADS;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace CertificatioTHREADS.Tests
{
    public partial class Class1Test
    {

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
[PexRaisedException(typeof(NullReferenceException))]
public void ValidaTestThrowsNullReferenceException229()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest121()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest8()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "\0");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest867()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, ".");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest608()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "﻿");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
[PexRaisedException(typeof(FormatException))]
public void ValidaTestThrowsFormatException870()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, new string('\0', 11));
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
[PexRaisedException(typeof(FormatException))]
public void ValidaTestThrowsFormatException529()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "\0\0\0\0\0\0\0\0\0\0");
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
[PexRaisedException(typeof(FormatException))]
public void ValidaTestThrowsFormatException819()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "0\0\0\0\0\0\0\0\0\0\0");
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
[PexRaisedException(typeof(FormatException))]
public void ValidaTestThrowsFormatException727()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, ":\0\0\0\0\0\0\0\0\0\0");
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest660()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "\0﻿");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest881()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "\0　﻿");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
[PexRaisedException(typeof(FormatException))]
public void ValidaTestThrowsFormatException258()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "00\0\0\0\0\0\0\0\0\0");
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest984()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "000000000\0\0");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest942()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "000915009\0\0");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest242()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "420000245\0\0");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest872()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "092469309\0\0");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest62()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "﻿\0");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
public void ValidaTest982()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, "﻿﻿");
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(Class1Test))]
[PexRaisedException(typeof(FormatException))]
public void ValidaTestThrowsFormatException889()
{
    bool b;
    Class1 s0 = new Class1();
    b = this.ValidaTest(s0, new string('﻿', 11));
}
    }
}
