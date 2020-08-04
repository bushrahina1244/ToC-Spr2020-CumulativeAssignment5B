using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayMLAgents()
    {
        SceneManager.LoadScene("MLAgents-Menu");
    } 


  public void PlayComputationalModels()
    {
        SceneManager.LoadScene("ComputationalModelesMenu");

    }

    public void PlayCourseItemList()
    {
        SceneManager.LoadScene("ItemList");

    }

    public void PlayInstructorWbLink()
    {
        SceneManager.LoadScene("instructorWbLink");

    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
