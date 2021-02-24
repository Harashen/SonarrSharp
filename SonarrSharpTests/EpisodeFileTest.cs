using Microsoft.VisualStudio.TestTools.UnitTesting;

using SonarrSharp;

using SonarrSharpTests.Properties;

using System;
using System.Threading.Tasks;

namespace SonarrSharpUnitTest
{
	[TestClass]
    public class EpisodeFileTest
    {
        private readonly SonarrClient _sonarrClient = new SonarrClient(Resources.Host, int.Parse(Resources.Port), Resources.ApiKey, Resources.UrlBase) { WriteDebug = true };

        [TestMethod]
        public async Task DeleteEpisodeFile()
        {
            var episodeFiles = await _sonarrClient.EpisodeFile.GetEpisodeFiles(1);
            foreach (var episodeFile in episodeFiles)
            {
                Console.WriteLine($"{episodeFile.Id}: {episodeFile.Path}");
            }

            await _sonarrClient.EpisodeFile.DeleteEpisodeFile(1);
        }
    }
}
