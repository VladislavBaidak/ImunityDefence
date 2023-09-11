using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    void Update()
    {
        if (GetComponent<Character>().currentHealth < 5)
        {
            SceneManager.LoadScene("GameEnd");
        }
    }
}
