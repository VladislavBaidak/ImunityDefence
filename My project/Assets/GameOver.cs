using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameOver : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Escape))
            {
            SceneManager.LoadScene("menu");
        }
    }
    public void Back()
    {

        SceneManager.LoadScene("menu");

    }
}
