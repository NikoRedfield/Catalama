using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTransition : MonoBehaviour {

    public GameObject[] DeactivateElements;
    public GameObject MenuToDisplay;
    public GameObject TransitionAnimation;

    private AudioSource source;

    public void Start()
    {
        source = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (DeactivateElements[0].activeSelf)
        {
            AnyKeyPressedEnterMenu(MenuToDisplay);
        }
        
    }

    public void AnyKeyPressedEnterMenu(GameObject MenuToDisplay) //Engaging transition procedure on any input received
    {
        if (Input.anyKey)
        {
            TransitionAnimation.GetComponent<Animator>().SetTrigger("Transition"); //Engage the transition animation
            Deactivate();   // Hide the desired elements
            StartCoroutine(DisplayMenu());
        }
    }

    private void Deactivate() //Deactivate all specified gameobjects
    {
        foreach(GameObject element in DeactivateElements)
        {
            element.SetActive(false);
        }
    }

    private IEnumerator DisplayMenu()
    {
        source.Play();
        yield return new WaitForSeconds(1.4f);
        MenuToDisplay.SetActive(true); //Display the new desired elements
    }
}
