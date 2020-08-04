using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MLAgentsMenu : MonoBehaviour
{
    public void PlayPenguins()
    {
        SceneManager.LoadScene("Penguins");
    }

    public void PlayHummingbirds()
    {
        SceneManager.LoadScene("FlowerIsland");
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

