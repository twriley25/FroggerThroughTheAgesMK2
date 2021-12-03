using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutscenePreTwoText : MonoBehaviour
{

    private float timeToWait;

    private string[] dialog = new string[]
    {
        "Robo-Jesus: Aghhhh! I’m dead for real this time",
        "Frogger: Hmm, So I’M the one who killed Jesus",
        "Frogger: Interesting ",
        "Frogger: Well time to find some fuel for the time machine",
        "Frogger: Wait I stole these power cells off of that robot replica of Jesus",
        "Frogger: I feel like these could somehow help me find some fuel",
        "Frogger: I’ve got it!",
        "Frogger: I can blow up these power cells to mine for oil!",
        "Frogger: Or I can just use them as fuel",
        "Frogger: That’s probably a good idea",
        "Frogger: I still can’t choose my next destination",
        "Frogger: Eh whatever, I’ll probably end up in a good location"
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
