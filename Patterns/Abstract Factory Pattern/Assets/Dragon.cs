using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class Dragon : StrongEnemy
{
    public override void BeatUp(WeakEnemy h)
    {
        Debug.Log(this.GetType().Name +
          " breathes fire on " + h.GetType().Name);
    }
}