using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active_button : MonoBehaviour
{
    public GameObject SceneButton;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D hitCollider = Physics2D.OverlapPoint(clickPosition);

            if (hitCollider != null && hitCollider.gameObject == gameObject)
            {
                SceneButton.SetActive(true);
            }
        }
    }
}
