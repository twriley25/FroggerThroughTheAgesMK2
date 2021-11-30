using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitToMoveScreen());
        /*
        Vector3 destination = transform.position + left;
        StartCoroutine(MoveText(destination));
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private IEnumerator waitToMoveScreen()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    /*
    private IEnumerator MoveText(Vector3 destination)
    {
        Vector3 startPosition = transform.position;
        float elapsed = 0f;
        float duration = 0.125f;

        while (elapsed < duration)
        {
            float t = elapsed / duration;
            transform.position = Vector3.Lerp(startPosition, destination, t);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.position = destination;
    }
    */
}
