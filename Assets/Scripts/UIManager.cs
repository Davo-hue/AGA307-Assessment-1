using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    public TMP_Text scoreText;
    public TMP_Text targetsCountText;
    public TMP_Text difficultyText;

    public void UpdateScore(int _points)
    {
        scoreText.text = "Score: " + _points;
    }

    public void UpdateTargetCount(int _count)
    {
        targetsCountText.text = "Target Count: " + _count;
        //enemyCountText.text = "Enemy Count: " + _count.ToString();
    }

    public void Difficulty (int _difficulty)
    {
        difficultyText.text = "Difficulty: " + _difficulty;
    }


}
