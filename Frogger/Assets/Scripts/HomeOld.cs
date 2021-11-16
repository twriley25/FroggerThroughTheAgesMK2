﻿using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class HomeOld : MonoBehaviour
{
    public GameObject frog;
    private BoxCollider2D boxCollider;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnEnable()
    {
        frog.SetActive(true);
        boxCollider.enabled = false;
    }

    private void OnDisable()
    {
        frog.SetActive(false);
        boxCollider.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!enabled && other.tag == "Player")
        {
            enabled = true;
            FindObjectOfType<GameManagerOld>().HomeOccupied();
        }
    }

}
