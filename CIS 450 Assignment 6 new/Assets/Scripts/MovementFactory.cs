using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFactory : PowerupFactory
{
    public override void updateUI()
    {
        spawndesc.text = "You have spanwed a Jupmp upgrade and a Speed upgrade.";
    }
}
