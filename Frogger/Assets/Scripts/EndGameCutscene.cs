using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameCutscene : MonoBehaviour
{

    private float timeToWait;

    private string[] dialog = new string[]
    {
        "*Frogger and the time machine appear in the time machine lab filled with scientists*",
        "Frog Scientist 1: Frogger you did it!",
        "Frog Scientist 1: You saved the world!",
        "Frogger: Yes I did",
        "Frogger: I feel like my soul is falling apart",
        "Frogger: Now I just want to go home to see my wife and kids",
        "Frogger struggles to walk back to his home to see his wife and kids for the last time",
        "Frogger opens the door to his home and is greeted by his family waiting for him",
        "He rests his head in his wife’s arms as his vision starts to fail him",
        "Frogger thinks about how much he has contributed to the world and is content with his legacy",
        "As his consciousness starts to fade away, Frogger realizes the most valuable lessons of them all",
        "That life is a gift that should always be cherished as you may never know when it will end",
        "...",
        "...",
        "...",
        "...",
        "...",
        "fin"
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
