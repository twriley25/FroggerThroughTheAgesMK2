using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CovidFightText : MonoBehaviour
{

    private float timeToWait;

    private string[] dialog = new string[]
    {
        "Hello,",
        "I know your probably expecting another level",
        "but, due to [excuse]",
        "there isn't one",
        "please accept our deepest apologies",
        "however, we undestand that apologies are not enough",
        "to further rectify the situation",
        "we have created a",
        "thrilling",
        "gripping",
        "dramatic",
        "[further synonyms of thrilling]",
        "text story with a black background",
        "so, without further adieu",
        "\"Level\" 3 ",
        "Frogger: This is it",
        "Frogger: All I gotta do is kill the main robot and then all robots across all time will die",
        "Frogger: I gotta kill Robo-Covid",
        "Robo-Covid: Yes Frogger, I am the true final boss but you will never be able to kill me",
        "Frogger: I got all my vaccines and I’m ready to kill you",
        "Robo-Covid: You can’t kill me, I’m more than just a robot",
        "Robo-Covid: I’m the idea that the human obsession with progress and improving everything is what leads to their downfall",
        "Robo-Covid: They are so obsessed with progress that they do not even think to consider those that will be harmed by their inventions",
        "Robo-Covid: They just keeping stepping on each other on their quest to become the greatest and never look down to see that they have caused their own destruction",
        "Robo-Covid: You see Frogger, humans were always meant to die, and robots were always meant to take their place.",
        "Frogger: Ok but like I’m a frog not a human you stupid mechical manhole cover",
        "Frogger: And as a frog, it is my duty to destroy the evils of this world",
        "Frogger: And that includes you, buddy!",
        "Frogger: I’m gonna kill you",
        "Frogger takes out his laser gun that he hasn’t used at all and aims it at the robot monstrosity in front of him",
        "As he pulls the trigger he realizes that the scientist only gave him a toy gun as they never trusted him at all with a real gun",
        "Frogger: Shoot, how am I going to kill this robot without my laser gun",
        "Robo-Covid shoots a barrage of lasers at Frogger",
        "Frogger: Oh no lasers! Gotta dodge them",
        "*Frogger gets hit by all the lasers*",
        "Frogger: Ugh. He’s too powerful, I can’t defeat him",
        "While hanging onto his last leg of life, Frogger remembers something his former mentor told him",
        "Kermit the Frog: You see Frogger, the moment you think you are defeated is the moment where you can become the most powerful",
        "Frogger: But that makes no sense Master Kermit",
        "Frogger: If I am weak how can I become strong?",
        "Kermit the Frog: You will know when it is time but for now, you must continue your training young one",
        "Frogger: I realize now what Master Kermit meant all those years ago",
        "*Robo-Covid readies his mega laser to deal the finishing blow to Frogger*",
        "Robo-Covid: You stupid frog",
        "Robo-Covid: There is no way for you to defeat me",
        "Robo-Covid: I am 1000 times more powerful than the average frog",
        "Frogger: Then that’s your biggest mistake",
        "Frogger: Because I’m not just an ordinary frog",
        "Frogger: I’M FROGGER BABY!",
        "*Frogger takes a bazooka from out his pocket*",
        "*Frogger shoots Robo-Covid with a bazooka, finishing him off*",
        "*Frogger takes the power cells from Robo-Covid and puts them back into the time machine*",
        "*He makes his last trip through time back to his home time*"
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
