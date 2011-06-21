using NUnit.Framework;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

using Installer.Model;
using System.IO;

namespace Tests
{
    [TestFixture]
    public class SourceMetaToggleTests
    {
        [Test]
        public void IsAValidFieldTest()
        {
            SourceMetaToggle metaToggle = new SourceMetaToggle();
            Assert.IsTrue(metaToggle.IsAValidField(0, "toggle", true));
            Assert.IsTrue(metaToggle.IsAValidField(1, "on", false));
            Assert.IsTrue(metaToggle.IsAValidField(2, "toggle_autoreload", false));
            Assert.IsTrue(metaToggle.IsAValidField(3, "Turns autoreload on.", false));
        }

    }
}
