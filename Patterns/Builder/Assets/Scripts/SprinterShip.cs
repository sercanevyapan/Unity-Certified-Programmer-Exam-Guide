using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinterShip : ShipBuilder
{
    public SprinterShip()
    {
        spaceCraft = new Ship("Sprinter Ship");
    }
    public override void BuildBoosters()
    {
        spaceCraft["boosters"] = "6";
    }
    public override void BuildWeapons()
    {
        spaceCraft["weapons"] = "Electromagnetic Pulse";
    }
    public override void BuildCargoSpace()
    {
        spaceCraft["cargo size"] = "50";
    }
}
