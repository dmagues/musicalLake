﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicalLakeLibrary;

namespace MusicalLakeTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPlayExample1()
        {
            var play = Musical.Play("brr");
            Assert.AreEqual("fiu, cric-cric, brrah", play);
        }

        [TestMethod]
        public void TestPlayExample2()
        {
            var play = Musical.Play("birip");
            Assert.AreEqual("trri-trri, croac", play);
        }

        [TestMethod]
        public void TestPlayExample3()
        {
            var play = Musical.Play("plop");
            Assert.AreEqual("cric-cric, brrah", play);
        }

        [TestMethod]
        public void TestPlayExample4()
        {
            var play = Musical.Play("brrah");
            Assert.AreEqual(string.Empty, play);
        }

        [TestMethod]
        public void TestPlayNotExist()
        {
            var play = Musical.Play("xyz");
            Assert.AreEqual(string.Empty, play);
        }
    }
}
