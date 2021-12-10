using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutscenePreOneText : MonoBehaviour
{

    private float timeToWait;

    private string[] dialog = new string[]
    {
        "After gathering the necessary fuel to power the time machine, disaster strikes!",
        "Robots attack the lab damaging the time machine’s time-selector sending Frogger",
        "hurling through time and space",
        "The damaged time machine left a time portal in its wake allowing the robots to follow Frogger in his quest throughout history",
        "The robots decide that the best course of action is to assassinate famous historical figures and pose as them in order to complete their mission of destroying all life along with Frogger"
    };

    // Start is called before the first frame update
    void Start()
    {
        Text txtToChange = GetComponent<Text>();
        StartCoroutine(waitToChangeText(txtToChange));
    }

    private IEnumerator waitToChangeText(Text txtToChange)
    {
        foreach (string text in dialog)
        {
            timeToWait = text.Length * 0.1f;
            txtToChange.text = text;
            yield return new WaitForSeconds(timeToWait);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
