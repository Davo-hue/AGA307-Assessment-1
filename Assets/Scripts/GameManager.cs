using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : Singleton<GameManager>
{

    public int score;
    private int scoreMultiplier = 1;

    public void AddScore(int _points)
    {
        score += _points * scoreMultiplier;
        
    }
}
