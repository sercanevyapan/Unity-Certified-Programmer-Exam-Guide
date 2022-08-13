class FlyingEnemies : EnemyFactory
{
    public override WeakEnemy MakeWeakEnemy()
    {
        return new Bat();
    }
    public override StrongEnemy MakeStrongEnemy()
    {
        return new Dragon();
    }
}