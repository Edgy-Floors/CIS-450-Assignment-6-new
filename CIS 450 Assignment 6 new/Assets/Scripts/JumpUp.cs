/*
 * EJ Flores
 * JumpUp.cs
 * Assignment 6
 * This script is a concrete class for the Powerups.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpUp : Powerup
{
    public override void ApplyPowerup()
    {
        p.jumpForce *= 2;
    }
}
