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
