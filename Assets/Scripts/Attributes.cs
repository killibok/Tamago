using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attributes : MonoBehaviour
{
    public DateTime Tstart;
    public long Tseconds;

    public int hunger, happiness, health, hygiene, energy;
    public int decay = 5;
    public bool sleeping;


    void Start()
    {
        sleeping = false;

        hunger = 10;
        happiness = 10;
        health = 10;
        hygiene = 10;
        energy = 10;

        Tstart = DateTime.Now;
        InvokeRepeating("UpdatePerSecond", 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        Tseconds = (DateTime.Now - Tstart).Seconds;
    }

    void UpdatePerSecond()
    {
        // Hunger ----------------------------------
        if (Tseconds % decay == 0 && hunger > 0)
            hunger--;

        // Energy ----------------------------------
        if (Tseconds % decay == 0)
        {
            if (!sleeping && Tseconds % (decay * 2) == 0)
                energy--;
            else
                energy++;
        }
    }


// Singleton
    public static Attributes Attr;

    void Awake()
   {
       if(Attr != null)
           GameObject.Destroy(Attr);
       else
           Attr = this;

       DontDestroyOnLoad(this);
   }
}
