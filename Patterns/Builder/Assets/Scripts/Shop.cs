using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop
{
    public void Construct(ShipBuilder vehicleBuilder)
    {
        vehicleBuilder.BuildBoosters();
        vehicleBuilder.BuildWeapons();
        vehicleBuilder.BuildCargoSpace();
    }
}
