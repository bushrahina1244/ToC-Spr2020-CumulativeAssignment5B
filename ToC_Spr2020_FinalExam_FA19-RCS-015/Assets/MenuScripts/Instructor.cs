using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Instructor : MonoBehaviour
{
    public void WebLink()
    {
        Application.OpenURL("http://www.niazilab.com");
    }
    
    

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
