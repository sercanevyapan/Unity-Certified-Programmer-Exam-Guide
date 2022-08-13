class RunningEnemies : EnemyFactory
{
    public override WeakEnemy MakeWeakEnemy()
    {
        return new Imp();
    }
    public override StrongEnemy MakeStrongEnemy()
    {
        return new Cyclop();
    }
}