/*
 * EJ Flores
 * AttributeFactory.cs
 * Assignment 6
 * This script is a concrete class for the PowerupFactory.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeFactory : PowerupFactory
{
    public override void updateUI()
    {
        spawndesc.text = "You spawned a Health upgrade and a Damage upgrade";
    }
}
