using UnityEngine;



public enum GameState
{
    Ready,
    Playing,
    Paused,
    GameOver,
}

public enum Difficulty
{
    Easy, Medium, Hard
}

public class GameManager : Singleton<GameManager>
{
    public GameState gameState;
    public Difficulty difficulty;

    public int score;
    private int scoreMultiplier = 1;

    public void Start()
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                scoreMultiplier = 1;
                break;
            case Difficulty.Medium:
                scoreMultiplier = 2;
                break;
            case Difficulty.Hard:
                scoreMultiplier = 3;
                break;
        }
    }

    public void AddScore(int _points)
    {
        score += _points * scoreMultiplier;
        //cannot get working in singleton scripts
        //_UI.UpdateScore(score); 
        
    }
}
