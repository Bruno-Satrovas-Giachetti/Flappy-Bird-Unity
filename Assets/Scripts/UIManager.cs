using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Sprite[] scoreImages;
    public Image scoreDecimal;
    public Image scoreUnit;
    public Image gameOverImage;

    public static UIManager uiManager;

    public void UpdateScoreUI(int score)
    {
        int unit = score % 10;
        int decimalScore = score / 10;

        scoreDecimal.sprite = scoreImages[decimalScore];
        scoreUnit.sprite = scoreImages[unit];
    }
}
