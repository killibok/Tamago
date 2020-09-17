using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GameObject.FindWithTag("Player").GetComponent<Animator>();
    }

    public void FeedAnimation()
    {
        gameObject.SetActive(false);
        animator.SetBool("IsEating", false);

        Attributes.Attr.hunger++;

    }

}
