using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HideButton : MonoBehaviour
{
    public Button buttonToHide;

    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
        {
            buttonToHide.gameObject.SetActive(false);
        }
    }
}
