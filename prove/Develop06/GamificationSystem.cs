using System;
using System.Collections.Generic;
using System.IO;


public class GamificationSystem
{
    private int _score = 0;
    private int _level = 1;

    public void AddPoints(int points)
    {
        _score += points;
        Console.WriteLine($"You now have {_score} points!");

        if (_score >= _level * 1000)
        {
            _level++;
            Console.WriteLine($"🎉 Level up! You are now level {_level}.");
        }
    }

    public int GetScore() => _score;

    public int GetLevel() => _level;
}
