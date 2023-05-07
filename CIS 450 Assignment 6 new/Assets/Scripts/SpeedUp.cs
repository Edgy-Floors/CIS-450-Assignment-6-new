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
