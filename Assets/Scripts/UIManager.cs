using UnityEngine;
using TMPro;

public class UIManager : Singleton<UIManager>
{
    public TMP_Text scoreText;
    public TMP_Text enemyCountText;

    public void UpdateScore(int _score)
    {
        scoreText.text = "Score: " + _score;
    }

   
}
