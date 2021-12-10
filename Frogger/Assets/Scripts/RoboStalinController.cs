using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoboStalinController : MonoBehaviour
{
    private GameObject hammer;
    private GameObject[] targetingSquares = new GameObject[5];
    private Vector3 atkPos;
    private SpriteRenderer spriteRenderer;
    public Sprite RTFStalin;
    public Sprite NStalin;



    // Start is called before the first frame update
    void Start()
    {
        hammer = GameObject.Find("hammer");
        targetingSquares[0] = GameObject.Find("AttackIndicatorRow");
        targetingSquares[1] = GameObject.Find("AttackIndicatorRow (1)");
        targetingSquares[2] = GameObject.Find("AttackIndicatorRow (2)");
        targetingSquares[3] = GameObject.Find("AttackIndicatorRow (3)");
        targetingSquares[4] = GameObject.Find("AttackIndicatorRow (4)");
        spriteRenderer = GetComponent<SpriteRenderer>();

        StartCoroutine(hammerControl(hammer, targetingSquares));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator hammerControl(GameObject hammer, GameObject[] targetingSquare)
    {
        atkPos = new Vector3(-5, 1, 0);
        Vector3 startPosition = new Vector3(-5, 6, 0);
        Vector3 destination = new Vector3(-5, 1, 0) + Vector3.down;
        int curScene = SceneManager.GetActiveScene().buildIndex;
        
        while (SceneManager.GetActiveScene().buildIndex == curScene)
        {
            //highlight target row
            atkPos.x = -5;
            yield return new WaitForSeconds(1f);
            foreach (GameObject atkInd in targetingSquares)
            {
                yield return new WaitForSeconds(.4f);
                atkInd.SetActive(true);
                atkInd.transform.position = atkPos;
                atkPos.x += 2.5f;
            }
            //begin firing
            yield return new WaitForSeconds(.5f);
            spriteRenderer.sprite = RTFStalin;
            foreach (GameObject atkInd in targetingSquares)
            {
                atkInd.SetActive(false);
                hammer.SetActive(true);
                //hammer.transform.position = atkInd.transform.position;

                //controls hammer movement
                startPosition.Set(atkInd.transform.position.x, 6, 0);
                destination.Set(atkInd.transform.position.x, 1, 0);
                float elapsed = 0f; 
                float duration = 0.5f;
                while (elapsed < duration)
                {
                    float t = elapsed / duration;
                    hammer.transform.position = Vector3.Lerp(startPosition, destination, t);
                    elapsed += Time.deltaTime;
                    yield return null;
                }
                hammer.SetActive(false);
            }
            spriteRenderer.sprite = NStalin;
        }
    }
}
