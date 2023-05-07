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
