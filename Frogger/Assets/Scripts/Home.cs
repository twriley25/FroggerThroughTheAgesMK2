using UnityEngine;

public class Home : MonoBehaviour
{
    public GameObject homeFrog;

//    private SpriteRenderer spriteRenderer;
//    private AudioSource batterySound;

    /*
    private void start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        batterySound = GetComponent<AudioSource>();
    }
    */

    private void OnEnable()
    {
        homeFrog.SetActive(true);
    }

    private void OnDisable()
    {
        homeFrog.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
//            batterySound.Play();
            enabled = false;
            FindObjectOfType<GameManager>().HomeOccupied();
        }
    }
}
