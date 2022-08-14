using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBases
{
    [SerializeField]
    private Dictionary<int, EnemyPointLocationPrototype> points =
        new Dictionary<int, EnemyPointLocationPrototype>();
   
    public EnemyPointLocationPrototype this[int key]
    {
        get { return points[key]; }
        set { points.Add(key, value); }
    }
}
