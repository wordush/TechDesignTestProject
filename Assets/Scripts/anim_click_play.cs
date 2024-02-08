using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_click_play : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D hitCollider = Physics2D.OverlapPoint(clickPosition);

            if (hitCollider != null && hitCollider.gameObject == gameObject)
            {
                animator.SetTrigger("PlayAnimation");
            }
        }
    }
}
