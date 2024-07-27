using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject tutorialScene;
    public GameObject GameUI;
    public void changeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void openTutorial()
    {
            tutorialScene.SetActive(!tutorialScene.activeSelf);
        GameUI.SetActive(!GameUI.activeSelf);
    }

}
