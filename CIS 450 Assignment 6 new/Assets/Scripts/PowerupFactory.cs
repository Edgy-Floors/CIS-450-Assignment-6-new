using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerupFactory : MonoBehaviour
{
    public GameObject[] g;

    public void createPowerup(int i)
    {
        Instantiate(g[i]);
    }
}
