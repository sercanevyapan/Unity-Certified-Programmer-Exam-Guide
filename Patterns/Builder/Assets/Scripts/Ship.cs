using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship
{
    private string _shipType;
    private Dictionary<string, string> _shipParts = new Dictionary<string, string>();
    
    // Constructor
    public Ship(string shipType)
    {
        this._shipType = shipType;
    }
    // Indexer
    public string this[string key]
    {
        get { return _shipParts[key]; }
        set { _shipParts[key] = value; }
    }
    public void Show()
    {
        Debug.Log("Vehicle: "+_shipType);
        Debug.Log("Boosters: "+ _shipParts["boosters"]);
        Debug.Log("Weapons: "+_shipParts["weapons"]);
        Debug.Log("Cargo Size: "+_shipParts["cargo size"]);
        Debug.Log("\n---------------------------");
    }
}
