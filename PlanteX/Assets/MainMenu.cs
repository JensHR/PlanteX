using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Button newGameButton;

    public Button loadButton;

    public Button exitGameButton;

    public string newGameSceneName;

    public GameObject loadGameMenu;

    public void Awake(){
        newGameButton.onClick.AddListener(NewGame);
        loadButton.onClick.AddListener(OpenLoadGameMenu);
        exitGameButton.onClick.AddListener(ExitGame);
    }

    public void NewGame(){
        SceneManager.LoadScene(newGameSceneName);
    }
    public void OpenLoadGameMenu(){
        loadGameMenu.SetActive(true);
    }

    public void ExitGame(){
        Debug.Log("trying to exit game. Doesn't work in editor.");
        Application.Quit();
    }
}
