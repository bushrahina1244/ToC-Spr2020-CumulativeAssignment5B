using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MatchingPWorldLang : MonoBehaviour
{
    public void parenthesisLAnguage()
    {
        SceneManager.LoadScene("MPLanguage");
    }

    public void PlayMatchingParenthesisWorld()
    {
        SceneManager.LoadScene("Matching_Parenthesis_World");
    }

    public void Return()
    {
        SceneManager.LoadScene("ComputationalModelesMenu");
    }
}
