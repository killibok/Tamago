using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public GameObject player;
    public GameObject fish;
    public GameObject ZZZ;
    public GameObject background;

    private Animator animator;
    private SpriteRenderer BGsprite;
    private SpriteRenderer Psprite;

    [SerializeField]
    private Color ForegroundColor, BackgroundColor;

    void Start()
    {
        animator = player.GetComponent<Animator>();
        BGsprite = background.GetComponent<SpriteRenderer>();
        Psprite = player.GetComponent<SpriteRenderer>();
    }

    public void Feed()
    {
        animator.SetBool("IsEating", true);
        fish.SetActive(true);
    }

    public void Sleep()
    {
        if (Attributes.Attr.sleeping)
        {
            ZZZ.SetActive(false);
            animator.SetBool("IsSleeping", false);
            BGsprite.color = BackgroundColor;
            Psprite.color = ForegroundColor;


            Attributes.Attr.decay /= 4;
            Attributes.Attr.sleeping = false;
        }
        else
        {
            ZZZ.SetActive(true);
            animator.SetBool("IsSleeping", true);
            BGsprite.color = ForegroundColor;
            Psprite.color = BackgroundColor;

            Attributes.Attr.decay *= 4;
            Attributes.Attr.sleeping = true;
        }
    }
}
