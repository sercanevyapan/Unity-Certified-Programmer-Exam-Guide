using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class Cyclop : StrongEnemy
{
    public override void BeatUp(WeakEnemy h)
    {
        Debug.Log(this.GetType().Name + " bashes " +
        h.GetType().Name + " out of the way");
    }
}