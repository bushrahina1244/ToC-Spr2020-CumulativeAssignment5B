using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class palindromeLangandWorld : MonoBehaviour
{
    public void PalindromeLanguage()
    {
        SceneManager.LoadScene("palindrmoeLanguage");
    }

    public void PlayPalindromeWorld()
    {
        SceneManager.LoadScene("Palindrome_World");
    }

    public void Return()
    {
        SceneManager.LoadScene("ComputationalModelesMenu");
    }
}
