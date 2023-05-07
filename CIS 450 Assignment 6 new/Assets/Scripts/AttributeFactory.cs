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
