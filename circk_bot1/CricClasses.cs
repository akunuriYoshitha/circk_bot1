using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace crick_bot1
{
    public class CricClasses
    {
    }

    public class Provider
    {
        public string source { get; set; }
        public string url { get; set; }
        public string pubDate { get; set; }
    }

    public class ManOfTheMatch
    {
        public string name { get; set; }
        public string pid { get; set; }
    }

    public class Score
    {
        public string name { get; set; }
        public int stumped { get; set; }
        public int bowled { get; set; }
        public int lbw { get; set; }
        public int @catch { get; set; }
        public string pid { get; set; }
    }

    public class Fielding
    {
        public string title { get; set; }
        public List<Score> scores { get; set; }
    }

    public class Score2
    {
        public string __invalid_name__6s { get; set; }
        public string __invalid_name__4s { get; set; }
        public string __invalid_name__0s { get; set; }
        public string Econ { get; set; }
        public string W { get; set; }
        public string R { get; set; }
        public string M { get; set; }
        public string O { get; set; }
        public string bowler { get; set; }
        public string pid { get; set; }
    }

    public class Bowling
    {
        public List<Score2> scores { get; set; }
        public string title { get; set; }
    }

    public class DismissalBy
    {
        public string name { get; set; }
        public string pid { get; set; }
    }

    public class Score3
    {
        public DismissalBy __invalid_name__dismissal_by { get; set; }
        public string dismissal { get; set; }
        public string SR { get; set; }
        public string __invalid_name__6s { get; set; }
        public string __invalid_name__4s { get; set; }
        public string B { get; set; }
        public string M { get; set; }
        public string R { get; set; }
        public string __invalid_name__dismissal_nfo { get; set; }
        public string batsman { get; set; }
        public string pid { get; set; }
    }

    public class Batting
    {
        public List<Score3> scores { get; set; }
        public string title { get; set; }
    }

    public class Player
    {
        public string name { get; set; }
        public string pid { get; set; }
    }

    public class Team
    {
        public List<Player> players { get; set; }
        public string name { get; set; }
    }

    public class Data
    {
        public ManOfTheMatch __invalid_name__man_of_the_Match { get; set; }
        public List<Fielding> fielding { get; set; }
        public List<Bowling> bowling { get; set; }
        public List<Batting> batting { get; set; }
        public bool matchStarted { get; set; }
        public List<Team> team { get; set; }
    }

    public class RootObject
    {
        public Provider provider { get; set; }
        public int ttl { get; set; }
        public string v { get; set; }
        public bool cache { get; set; }
        public string dateTimeGMT { get; set; }
        public string type { get; set; }
        public Data data { get; set; }
        public int creditsLeft { get; set; }
        public bool cache2 { get; set; }
    }
}
