using System;
using NetMonads;
using NUnit.Framework;

namespace NetMonadsTests
{
    [TestFixture]
    public class MaybeExtensionsTest
    {
        [Test]
        public void TestGet()
        {
            var match = new Match
            {
                Team1 = new Team { Title = "Juventus" },
                Team2 = null
            };

            Assert.Throws<NullReferenceException>(() => { var a = match.Team2.Title; });
            Assert.IsNotNull(match.Get(x => x.Team1).Get(x => x.Title));
            Assert.IsNull(match.Get(x => x.Team2).Get(x => x.Title));
        }
    }

    public class Match
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
    }

    public class Team
    {
        public string Title { get; set; }
    }
}