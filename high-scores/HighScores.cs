using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> scoresList { get; set; }

    public HighScores(List<int> list)
    {
       scoresList = list;
    }

    public List<int> Scores()
    {
        return scoresList;
    }

    public int Latest()
    {
        return scoresList.Last();
    }

    public int PersonalBest()
    {
        return scoresList.Max();
    }

    public List<int> PersonalTopThree()
    {
        scoresList.Sort();
        scoresList.Reverse();        
        return scoresList.Count >= 3 ? scoresList.GetRange(0,3) : scoresList.GetRange(0,scoresList.Count);
    }
}