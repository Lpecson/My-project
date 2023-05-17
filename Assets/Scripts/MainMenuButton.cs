using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    [SerializeField] public GameInfo gameInfo;
    public void playGame()
    {
        gameInfo.InitGame();
        gameInfo.ResetHealth();
        SceneManager.LoadScene("CharacterSelect");
    }
    public void playAsCowboy()
    {
        gameInfo.PlayCowboy();
        SceneManager.LoadScene("Overworld");
    }
    public void playAsPirate()
    {
        gameInfo.PlayPirate();
        SceneManager.LoadScene("Overworld");
    }   
    public void resetSave()
    {
        gameInfo.InitGame();
    }
    public void continueRun()
    {
        SceneManager.LoadScene(gameInfo.currentLevel);
    }
    public void playAgain()
    {
        SceneManager.LoadScene("Start Menu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
