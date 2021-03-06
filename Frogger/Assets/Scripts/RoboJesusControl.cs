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
            //start tracking
            yield return new WaitForSeconds(1f);
            targetingSquare.SetActive(true);
            targetingSquare.transform.position = target.transform.position;
            targetingSquare.transform.SetParent(target.transform);
            //lock in target
            yield return new WaitForSeconds(.5f);
            spriteRenderer.sprite = RTFJesus;
            targetingSquare.transform.SetParent(null);
            //fire
            yield return new WaitForSeconds(.5f);
            beam.transform.position = targetingSquare.transform.position;
            beam.SetActive(true);
            //beam residue
            spriteRenderer.sprite = NJesus;
            targetingSquare.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            beam.SetActive(false);
        }
    }
}
