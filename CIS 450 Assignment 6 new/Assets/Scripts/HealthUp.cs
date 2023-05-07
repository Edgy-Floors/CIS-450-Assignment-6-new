using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : Powerup
{
    public override void ApplyPowerup()
    {
        p.health += 50;
    }
}
