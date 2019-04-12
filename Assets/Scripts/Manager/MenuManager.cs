using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{


    public AudioClip EnterSound;
    public string LevelToLoad = "Level01";
    public Button playbutton;

    private AudioSource source;
    

    void Awake()
    {
        Time.timeScale = 1;  //Make sure the time is not stopped so the buttons still work properly
        source = GetComponent<AudioSource>();
        source.clip = EnterSound;
        
    }


    //Launch new game
    public void NewGame()
    {
        StartCoroutine(PlaySoundThenLoad());
    }

    //Exit The Game
    public void QuitGame()
    {
        StartCoroutine(PlaySoundThenQuit());
    }


    //Plays the button sound effect before loading the next scene
    public IEnumerator PlaySoundThenLoad()
    {
        playbutton.interactable = false;
        source.Play();
        yield return new WaitForSeconds(1f);  //WaitForSeconds(5f)
        SceneManager.LoadScene(LevelToLoad);

    }

    //Plays the button sound effect before closing the game
    public IEnumerator PlaySoundThenQuit()
    {
        source.Play();
        yield return new WaitForSeconds(source.clip.length);
        Application.Quit();

    }

}
