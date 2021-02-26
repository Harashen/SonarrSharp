using Microsoft.VisualStudio.TestTools.UnitTesting;

using SonarrSharp;

using SonarrSharpTests.Properties;

using System.Threading.Tasks;

namespace SonarrSharpUnitTest
{
	[TestClass]
    public class CommandTest
    {
        private readonly SonarrClient _sonarrClient = new SonarrClient(Resources.Host, int.Parse(Resources.Port), Resources.ApiKey, Resources.UrlBase) { WriteDebug = true };

        [TestMethod]
        public async Task GetCommands()
        {
            var obj = await _sonarrClient.Command.GetCommands();

            Assert.IsNotNull(obj);
        }

        [TestMethod]
        public async Task GetCutoffUnmet()
        {
            var obj = await _sonarrClient.Wanted.GetCutoffUnmet("title", 1, 5);

            Assert.IsNotNull(obj);
        }
    }
}
