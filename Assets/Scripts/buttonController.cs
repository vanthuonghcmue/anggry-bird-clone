using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour
{
    /*
       public void RestartButton()
       {
           SceneManager.LoadScene("SampleScene");
       }

       public void ExitButton()
       {

           SceneManager.LoadScene("main menu");
       }
       public void menu()
       {
           Debug.Log("ok");
       }
    */
    /*public void loadMenu()
     {
         SceneManager.LoadScene("Menu");
     }
     public void Menu()
     {
         Debug.Log("loading menu...");
     }*/
    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitButton()
    {

        SceneManager.LoadScene("main menu");
    }
    public void menu()
    {
        Debug.Log("ok");
    }
}

