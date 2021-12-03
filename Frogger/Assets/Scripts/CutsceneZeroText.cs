using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutsceneZeroText : MonoBehaviour
{

    private float timeToWait;

    private string[] dialog0 = new string[]
    {
        "In the grimdark grimdarkness of the far future there is only war, only destruction. There is no more man, only frog remain.",
        "Robots rule the world and an elite team of frog scientists come together to create a last ditch effort for survival: a time machine",
        "One frog would be sent back in time to stop the robots before their uprising began",
        "This frog is the last hope for frogkind",
        "This frog is the final chance for life to continue to exist on Earth",
        "This frog is the one and only Frogger"
    };

    // Start is called before the first frame update
    void Start()
    {
        Text txtToChange = GetComponent<Text>();
        StartCoroutine(waitToChangeText(txtToChange));
    }

    private IEnumerator waitToChangeText(Text txtToChange)
    {
        foreach (string text in dialog0)
        {
            timeToWait = text.Length * 0.1f;
            txtToChange.text = text;
            yield return new WaitForSeconds(timeToWait);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
