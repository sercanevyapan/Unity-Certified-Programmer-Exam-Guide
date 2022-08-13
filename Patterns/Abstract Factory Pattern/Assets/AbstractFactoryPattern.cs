using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractFactoryPattern : MonoBehaviour
{
    void Awake()
    {
        MakeEnemies();
    }

    void MakeEnemies()
    {
        EnemyFactory flyingEnemy = new FlyingEnemies();
        MakeEnemy flyer = new MakeEnemy(flyingEnemy);
        flyer.CompareEnemyStrengths();
     
        EnemyFactory runningEnemy = new RunningEnemies();
        MakeEnemy runner = new MakeEnemy(runningEnemy);
        runner.CompareEnemyStrengths();
    }
}
