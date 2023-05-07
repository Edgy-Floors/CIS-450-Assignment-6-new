/*
 * EJ Flores
 * PowerupFactory.cs
 * Assignment 6
 * This script acts as the base class for the factories. It contains functionality for spawning the powerups once a player is in range and presses Q.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public abstract class PowerupFactory : MonoBehaviour
{
    public GameObject[] g;
    public TextMeshProUGUI spawndesc;

    public void createPowerup(int i)
    {
        Instantiate(g[i]);
    }

    public virtual void updateUI(){}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < g.Length; i++)
            {
                createPowerup(i);
            }
            updateUI();
        }
    }
}
