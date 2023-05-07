/*
 * EJ Flores
 * Powerup.cs
 * Assignment 6
 * This script acts as the base class for all of the concrete powerups. It takes a reference to a player and applies a powerup when the player collides with a powerup.
 */

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
