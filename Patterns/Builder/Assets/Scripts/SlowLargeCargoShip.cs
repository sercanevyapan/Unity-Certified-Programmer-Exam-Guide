using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowLargeCargoShip : ShipBuilder
{
    public SlowLargeCargoShip()
    {
        spaceCraft = new Ship("Slow Large Cargo Ship");
    }
    public override void BuildBoosters()
    {
        spaceCraft["boosters"] = "2";
    }
    public override void BuildWeapons()
    {
        spaceCraft["weapons"] = "Laser Cannons";
    }
    public override void BuildCargoSpace()
    {
        spaceCraft["cargo size"] = "500000";
    }
}
