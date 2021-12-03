using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoboJesusControl : MonoBehaviour
{
    private GameObject beam;
    private GameObject targetingSquare;
    private GameObject target;
    private SpriteRenderer spriteRenderer;
    public Sprite RTFJesus;
    public Sprite NJesus;


    // Start is called before the first frame update
    void Start()
    {
        beam = GameObject.Find("Heaven Beam");
        targetingSquare = GameObject.Find("Heaven Beam Attack Indicator");
        target = GameObject.Find("Frogger");
        spriteRenderer = GetComponent<SpriteRenderer>();

        StartCoroutine(beamControl(beam, targetingSquare, target));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator beamControl(GameObject beam, GameObject targetingSquare, GameObject target)
    {
        int curScene = SceneManager.GetActiveScene().buildIndex;
        while (SceneManager.GetActiveScene().buildIndex == curScene)
        {
            yield return new WaitForSeconds(.5f);
            targetingSquare.SetActive(true);
            targetingSquare.transform.position = target.transform.position;
            targetingSquare.transform.SetParent(target.transform);
            yield return new WaitForSeconds(.5f);
            spriteRenderer.sprite = RTFJesus;
            targetingSquare.transform.SetParent(null);
            /*
            for (int i = 0; i < 5; i++)
            {
                targetingSquare.SetActive(true);
                yield return new WaitForSeconds(1);
                targetingSquare.SetActive(false);
            }
            */
            yield return new WaitForSeconds(.25f);
            beam.transform.position = targetingSquare.transform.position;
            beam.SetActive(true);
            
            spriteRenderer.sprite = NJesus;
            targetingSquare.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            beam.SetActive(false);
        }
    }
}
