using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutscenePreThreeText : MonoBehaviour
{

    private float timeToWait;

    private string[] dialog = new string[]
    {
        "Frogger: Eyyyy, just killed Stalin",
        "Stalin: Oh no I’m dead",
        "Frogger: Wow I really killed like 5 people today",
        "Frogger: Nice!",
        "Frogger: Wow it looks like I have enough parts to fully repair my time machine",
        "Frogger: Time to go back to the year this robot uprising happened",
        "Frogger: The year 2020"
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
