using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrototypePattern : MonoBehaviour
{
    private void Awake()
    {
        SetEnemyBaseLocations();
    }

    void SetEnemyBaseLocations()
    {
        EnemyBases enemyBasePointLocations = new EnemyBases();
        
        // Initialize base locations
        enemyBasePointLocations[1] = new GeoLocations(156, 342, 1002);
        enemyBasePointLocations[2] = new GeoLocations(2562, 20, 453);
        enemyBasePointLocations[3] = new GeoLocations(676, 4352, 543);
        
        // New data on locations
        enemyBasePointLocations[4] = new GeoLocations(563, 475, 4354);
        enemyBasePointLocations[5] = new GeoLocations(232, 437, 2345);
        enemyBasePointLocations[6] = new GeoLocations(111, 6634, 3422);
        
        // Selected bases
        GeoLocations site1 = enemyBasePointLocations[2].Clone() as GeoLocations;
        GeoLocations site2 = enemyBasePointLocations[3].Clone() as GeoLocations;
        GeoLocations site3 = enemyBasePointLocations[4].Clone() as GeoLocations;
    }
}
