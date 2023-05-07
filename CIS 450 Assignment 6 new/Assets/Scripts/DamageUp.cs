/*
 * EJ Flores
 * DamageUp.cs
 * Assignment 6
 * This script is a concrete class for the Powerups.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageUp : Powerup
{
    public override void ApplyPowerup()
    {
        p.damage += 5;
    }
}
