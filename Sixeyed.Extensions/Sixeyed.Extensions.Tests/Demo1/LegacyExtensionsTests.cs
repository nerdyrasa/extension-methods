using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Samples.Demo1;

namespace Sixeyed.Extensions.Tests.Demo1
{
    /// <summary>
    /// Summary description for LegacyExtensionsTests
    /// </summary>
    [TestClass]
    public class LegacyExtensionsTests
    {

        [TestMethod]
        public void ToLegacyFormat_C20()
        {
            // December 31, 1920

            var DateTime = new DateTime(1913, 12, 31);
            // the first 0 means that it's a 20th century date
            // and then 20 for the year, 12 for the month and 31 for the day

            Assert.AreEqual("0131231", DateTime.ToLegacyFormat());
        }
        [TestMethod]
        public void ToLegacyFormat_C21()
        {
            // December 31, 1920

            var DateTime = new DateTime(2013, 12, 31);
            // the first 1 means that it's a 21st century date
            // and then 20 for the year, 12 for the month and 31 for the day

            Assert.AreEqual("1131231", DateTime.ToLegacyFormat());
        }

        [TestMethod]
        public void ToLegacyName()
        {
            var name = "Elton Stoneman";
            Assert.AreEqual("STONEMAN, ELTON", name.ToLegacyFormat());
        }
    }
}
