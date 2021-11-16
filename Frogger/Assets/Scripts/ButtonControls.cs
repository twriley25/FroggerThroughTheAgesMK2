using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControls : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("version notes");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Title Screen");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("Credits");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
