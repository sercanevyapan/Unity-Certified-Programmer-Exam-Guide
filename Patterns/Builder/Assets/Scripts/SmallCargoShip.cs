using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCargoShip : ShipBuilder
{
    public SmallCargoShip()
    {
        spaceCraft = new Ship("Small Cargo Ship");
    }
    public override void BuildBoosters()
    {
        spaceCraft["boosters"] = "3";
    }
    public override void BuildWeapons()
    {
        spaceCraft["weapons"] = "none";
    }
    public override void BuildCargoSpace()
    {
        spaceCraft["cargo size"] = "3000";
    }
}
