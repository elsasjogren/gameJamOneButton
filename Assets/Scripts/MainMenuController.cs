using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   public void playEasyGame()
    {
        SceneManager.LoadScene("Elsa");
        //sneakyToast.speed to access in the main menu
        sneakyToast.speed = 0.2f;
       
    }


    public void playMediumGame()
    {
        SceneManager.LoadScene("Elsa");
        //sneakyToast.speed to access in the main menu
        sneakyToast.speed = 1f;

    }


    public void playHardGame()
    {
        SceneManager.LoadScene("Elsa");
        //sneakyToast.speed to access in the main menu
        sneakyToast.speed = 2f;

    }




}
