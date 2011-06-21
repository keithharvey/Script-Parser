using NUnit.Framework;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

using Installer.Model;
using System.IO;

namespace Tests
{
    [TestFixture]
    public class ScriptTests
    {
        [Test]
        public void ScriptHasAliases()
        {
            Script script = createScript();

            Assert.AreEqual(27, script.Content.Count);
        }

        [Test]
        public void ContentsTest()
        {
            Script script = createScript();

            Assert.AreEqual(5, script.Content.Count);
        }

        [Test]
        public void ToggleTest()
        {
            Script script = createScript();

            Assert.IsNotNull(script.Toggles);
            Assert.AreEqual(5, script.Toggles.Count);
        }
        
        Script createScript()
        {
            string path = Path.GetFullPath(
                "D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\files\\TeamFortress2\\scripts\\TestScript"
                );

            return new Script(path);
        }
    }
}
