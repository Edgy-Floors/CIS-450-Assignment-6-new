using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : MonoBehaviour
{
    public Player p;

    private void Start()
    {
        p = GameObject.Find("Player").GetComponent<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        ApplyPowerup();
    }


    public virtual void ApplyPowerup()
    {

    }
}
