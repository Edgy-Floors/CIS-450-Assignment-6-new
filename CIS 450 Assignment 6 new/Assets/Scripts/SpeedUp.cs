/*
 * EJ Flores
 * SpeedUp.cs
 * Assignment 6
 * This script is a concrete class for the Powerups.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : Powerup
{
    public override void ApplyPowerup()
    {
        p.moveSpeed += 5.0f;       
    }
}
