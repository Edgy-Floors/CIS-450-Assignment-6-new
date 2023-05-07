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

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            ApplyPowerup();
            Destroy(gameObject);
        }
    }

    public virtual void ApplyPowerup(){}
}
