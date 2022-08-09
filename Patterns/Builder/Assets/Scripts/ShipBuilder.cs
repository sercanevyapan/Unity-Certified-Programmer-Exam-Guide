using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShipBuilder
{
    protected Ship spaceCraft;
    // Gets vehicle instance
    public Ship SpaceCraft
    {
        get { return spaceCraft; }
    }
    // Abstract build methods
    public abstract void BuildBoosters();
    public abstract void BuildWeapons();
    public abstract void BuildCargoSpace();
}
