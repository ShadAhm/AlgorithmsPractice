using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPractice.Problems.ImaginaryCodingInterview;

public class ImaginaryCodingInterviewSolver
{
    private const int MaxAllowedMinutes = 120;
    private const string Disqualified = "disqualified";
    private const string Qualified = "qualified";
    private readonly QuestionDifficulty[] QuestionDifficulties =
    {
        QuestionDifficulty.VeryEasy,
        QuestionDifficulty.VeryEasy,
        QuestionDifficulty.Easy,
        QuestionDifficulty.Easy,
        QuestionDifficulty.Medium,
        QuestionDifficulty.Medium,
        QuestionDifficulty.Hard,
        QuestionDifficulty.Hard
    };

    public string Solve(int[] timesTaken, int totalInterviewMinutes)
    {
        if(totalInterviewMinutes > MaxAllowedMinutes)
            return Disqualified;

        if (timesTaken.Length < QuestionDifficulties.Length)
            return Disqualified;

        for (int i = 0; i < timesTaken.Length; i++)
        {
            int maxAllowedMins = MaxAllowedTimeForDifficulty(QuestionDifficulties[i]);

            if(timesTaken[i] > maxAllowedMins)
                return Disqualified;
        }

        return Qualified; 
    }

    private int MaxAllowedTimeForDifficulty(QuestionDifficulty questionDifficulty)
    {
        switch (questionDifficulty)
        {
            case QuestionDifficulty.VeryEasy:
                return 5;
            case QuestionDifficulty.Easy:
                return 10;
            case QuestionDifficulty.Medium:
                return 15;
            default:
                return 20;
        }
    }

    private enum QuestionDifficulty
    {
        VeryEasy,
        Easy,
        Medium,
        Hard
    }
}
