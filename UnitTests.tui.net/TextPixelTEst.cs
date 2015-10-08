using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tui.net;

namespace UnitTests.tui.net
{
    [TestClass]
    public class TextPixelTest
    {
        [TestMethod]
        public void Ctor_empty()
        {
            var pixel = new TextPixel();
            Assert.IsNull(pixel.Character);
            Assert.IsNull(pixel.BackgroundColor);
            Assert.IsNull(pixel.ForegroundColor);
        }
    }
}
