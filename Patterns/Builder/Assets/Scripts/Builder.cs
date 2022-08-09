using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
        void Start()
        {
            ShipBuilder builder;
            Shop shop = new Shop();
        
            builder = new SmallCargoShip();
            shop.Construct(builder);
            builder.SpaceCraft.Show();

            builder = new SprinterShip();
            shop.Construct(builder);
            builder.SpaceCraft.Show();

            builder = new SlowLargeCargoShip();
            shop.Construct(builder);
            builder.SpaceCraft.Show();
        }
}
