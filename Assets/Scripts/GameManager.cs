
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    public static GameManager gameBehavior;

    public UIManager uiManager;

    private void Awake()
    {
        gameBehavior = this;
    }

    public void GameOver()
    {
        print("Perdeu");
    }
}
