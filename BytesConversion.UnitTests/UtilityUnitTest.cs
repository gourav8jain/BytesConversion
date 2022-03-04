using NUnit.Framework;

namespace BytesConversion.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConvertBytesToReadableFormat_ForBytes()
        {
            var expected = "255B";
            var actual = Utility.ConvertBytesToReadableFormat(255);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void ConvertBytesToReadableFormat_ForKiloBytes()
        {
            var expected = "1KB";
            var actual = Utility.ConvertBytesToReadableFormat(1024);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void ConvertBytesToReadableFormat_ForMebaBytes()
        {
            var expected = "1MB";
            var actual = Utility.ConvertBytesToReadableFormat(1048576);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void ConvertBytesToReadableFormat_ForGigaBytes()
        {
            var expected = "1.1GB";
            var actual = Utility.ConvertBytesToReadableFormat(1151022592);
            Assert.AreEqual(actual, expected);
        }
    }
}