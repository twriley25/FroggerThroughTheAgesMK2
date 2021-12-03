using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutsceneOneText : MonoBehaviour
{

    private float timeToWait;

    private string[] dialog1 = new string[]
    {
        "Frogger: Woah the time machine malfunctioned",
        "Frogger: I wonder when am I?",
        "Frogger: Hmm that looks like a traditional Roman aqueduct",
        "Frogger: And that looks like someone wearing a traditional Roman outfit",
        "Frogger: And that looks like Rome in the distance",
        "Frogger: I must be in the ancient Shang Dynasty of China",
        "Roman: No you idiot it’s Rome in 475",
        "Frogger: Wow a year before the fall of Rome and the Han Dynasty, super interesting",
        "Frogger: Welp my time machine’s out of fuel, gotta go find more",
        "*Jesus Appears*",
        "Jesus: Hello my young frog, I am here to help you",
        "Frogger: WOW it’s Jesus, and even 442 years after your death you still look good",
        "Frogger: Wait aren’t you supposed to be dead",
        "*Jesus reveals himself to be a robot imposter*",
        "Robo-Jesus: I’m not dead but you’re going to be soon",
        "Frogger: Yowza!"
    };

    // Start is called before the first frame update
    void Start()
    {
        Text txtToChange = GetComponent<Text>();
        StartCoroutine(waitToChangeText(txtToChange));
    }

    private IEnumerator waitToChangeText(Text txtToChange)
    {
        foreach (string text in dialog1)
        {
            timeToWait = text.Length * 0.1f;
            txtToChange.text = text;
            /*
            if (text.Equals("*Jesus reveals himself to be a robot imposter*"))
            {
                Image imageToChange = GameObject.Find("Canvas/CutsceneImage").GetComponent<Image>();
                Sprite imageToChangeTo = Resources.Load("Assets/Sprites/Jesus Robot Scene") as Sprite;
                imageToChange.sprite = imageToChangeTo;
            }
            */
            yield return new WaitForSeconds(timeToWait);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
