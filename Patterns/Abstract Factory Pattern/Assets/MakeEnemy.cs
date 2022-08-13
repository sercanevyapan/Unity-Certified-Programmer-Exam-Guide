class MakeEnemy
{
    private WeakEnemy _weakEnemy;
    private StrongEnemy _strongEnemy;
    // Constructor
    public MakeEnemy(EnemyFactory factory)
    {
        _strongEnemy = factory.MakeStrongEnemy();
        _weakEnemy = factory.MakeWeakEnemy();
    }
    public void CompareEnemyStrengths()
    {
        _strongEnemy.BeatUp(_weakEnemy);
    }
}