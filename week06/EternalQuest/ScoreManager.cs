using System;
using static System.Math;

public class ScoreManager
{ 
    private int _totalScore;
    public void AddPoints(int points)
    {
        _totalScore += points;
    }
    public int GetTotalScore()
    {
        return _totalScore;
    }
    public void ResetScore()
    {
        _totalScore = 0;
    }
}