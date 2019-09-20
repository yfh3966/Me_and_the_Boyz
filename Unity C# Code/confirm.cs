using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Confirm : MonoBehaviour
{
    //this class is for the ConfirmationButton on the ConfirmationMenu

    public void Exit() //this method quits the game back to the main menu
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); //this line loads the build index 0, which should be the main menu.
    }
}
