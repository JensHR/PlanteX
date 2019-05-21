using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Button NewGameButton;

    public Button HowToPlay;

    public Button ExitGameButton;

    public string newGameSceneName;

    public GameObject HowToPlayCanvas;

    public void Awake(){
        NewGameButton.onClick.AddListener(NewGame);
        HowToPlay.onClick.AddListener(OpenHowToPlay);
        ExitGameButton.onClick.AddListener(ExitGame);
    }

    public void NewGame(){
        SceneManager.LoadScene(newGameSceneName);
    }
    public void OpenHowToPlay(){
        HowToPlayCanvas.SetActive(true);
    }

    public void ExitGame(){
        Debug.Log("trying to exit game. Doesn't work in editor.");
        Application.Quit();
    }
}
