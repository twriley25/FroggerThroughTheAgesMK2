using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutsceneTwoText : MonoBehaviour
{

    private float timeToWait;

    private string[] dialog = new string[]
    {
        "Frogger: Wow I feel kinda dizzy",
        "Frogger: Time travel really takes a toll on my soul",
        "Frogger: Welp guess I gotta find another robot and steal their fuel cells to get back home",
        "Frogger: Well first issue there is that I can’t determine the difference between robots and humans",
        "Frogger: I guess I gotta kill as many influential people as I can until I find the one that is a robot",
        "Frogger: Hey that looks like Benito Mussolini, I gotta kill him and hope he’s a robot",
        "*Frogger kills Mussolini*",
        "Frogger: Whelp, he wasn’t a robot",
        "Frogger: Though, I did do the world a favor",
        "Frogger: Whoa is that Stalin!",
        "Frogger: Gotta kill him",
        "Stalin: Halt stupid little Frog, you look ugly",
        "Frogger: Wow that’s a rude thing to say to someone who gonna kill you",
        "Stalin: Haha you might’ve been able to kill regular human Stalin but...",
        "*Stalin reveals himself to be a robot*",
        "Robo-Stalin: You would never be able to defeat me! Robo-Stalin!",
        "Frogger: Oh yo nice, you’re a robot",
        "Frogger: I don’t have to go around randomly killing people anymore"
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
