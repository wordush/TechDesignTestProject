using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_click_play : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip audioClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = audioClip;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D hitCollider = Physics2D.OverlapPoint(clickPosition);

            if (hitCollider != null && hitCollider.gameObject == gameObject)
            {
                audioSource.Play();
            }
        }
    }
}
