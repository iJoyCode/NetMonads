using System;
using iJoyMonads;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iJoyMonadsTests
{
    [TestClass]
    public class MaybeExtensionsTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestGet()
        {
            var match = new Match
            {
                Team1 = new Team { Title = "Juventus" },
                Team2 = null
            };

            var title = match.Team2.Title;

            Assert.IsNotNull(match.Get(x => x.Team1).Get(x => x.Title));
            Assert.IsNull(match.Get(x => x.Team2).Get(x => x.Title));

            
        }
    }

    #region Fixtures
    public class Match
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
    }

    public class Team
    {
        public string Title { get; set; }
    }
    #endregion
}