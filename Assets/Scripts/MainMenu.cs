using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioClip clickSound;
    public AudioSource sound;

    // Function for when start button is pressed
    public void PlayGame() 
    {
        sound.PlayOneShot(clickSound); //Click sound effect
        SceneManager.LoadScene("Gameplay");
    }
        
}
