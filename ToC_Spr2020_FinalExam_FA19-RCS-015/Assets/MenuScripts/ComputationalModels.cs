using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComputationalModels : MonoBehaviour
{
    public void PlayPalindromeWorld()
    {
        SceneManager.LoadScene("palindrom");
    }

    public void PlayMatchinParenthesisWorld()
    {
        SceneManager.LoadScene("MatchinPMenu");
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

