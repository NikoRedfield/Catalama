using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class PauseManager : MonoBehaviour {

    public GameObject menuToDisplay;
    public AudioClip pauseSound;
     

    private bool isActive = false;
    private string mainMenuScene = "Menu";
    private AudioSource source;


   void Awake()
    {
        source = GetComponent<AudioSource>();
        source.clip = pauseSound; 
    }

	// Update is called once per frame
	void Update () {

        if (isActive)   //the pause menu should be displayed
        {
            menuToDisplay.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;        
        }

        else
        {
            menuToDisplay.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 1;
        }

        if (CrossPlatformInputManager.GetButtonDown("Start"))
        {
            ResumeGame();
        }
        
	}

    public void ResumeGame()
    {
        source.Play();
        isActive = !isActive;
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(mainMenuScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}

