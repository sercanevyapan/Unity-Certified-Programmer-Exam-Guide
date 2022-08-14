using UnityEngine;
public class GeoLocations : EnemyPointLocationPrototype
{
    float x;
    float y;
    float z;
    
    public GeoLocations(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public override EnemyPointLocationPrototype Clone()
    {
        Debug.Log("Enemy Point Location: " + " "+ x + " " + y + " " + z);
        return this.MemberwiseClone() as EnemyPointLocationPrototype;
    }
}
