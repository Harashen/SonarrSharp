using Microsoft.VisualStudio.TestTools.UnitTesting;

using SonarrSharp;

using SonarrSharpTests.Properties;

using System;
using System.Threading.Tasks;

namespace SonarrSharpUnitTest
{
	[TestClass]
    public class CalendarTest
    {
        private readonly SonarrClient _sonarrClient = new SonarrClient(Resources.Host, int.Parse(Resources.Port), Resources.ApiKey, Resources.UrlBase) { WriteDebug = true };

        [TestMethod]
        public async Task GetCalendar()
        {
            var start = DateTime.Now;
            var end = DateTime.Now.AddDays(7);

            var obj = await _sonarrClient.Calendar.GetCalendar(start, end);

            Assert.IsNotNull(obj);
        }
    }
}
