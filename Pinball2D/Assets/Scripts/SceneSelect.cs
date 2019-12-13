using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelect : MonoBehaviour
{
    /*
    Script for scene management
    */
    public void GoToInfo()
    {
        SceneManager.LoadScene("Info");
    }
    public void GotoLevel2Splash()
    {
        SceneManager.LoadScene("Level2Splash");
    }
    public void GotoLevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }
    public void GoToLevelThree()
    {
        SceneManager.LoadScene("LevelThree");
    }
    public void GoToLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
