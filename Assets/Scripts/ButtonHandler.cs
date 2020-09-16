using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public void Feed()
    {
        Attributes.Attr.hunger++;
    }

    public void Sleep()
    {
        if (Attributes.Attr.sleeping)
        {
            Attributes.Attr.decay /= 4;
            Attributes.Attr.sleeping = false;
        }
        else
        {
            Attributes.Attr.decay *= 4;
            Attributes.Attr.sleeping = true;
        }
    }
}
