using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectableStars : ItemCollectableBase
{
   public Collider2D collider;

   protected override void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddStars();
        collider.enabled = false;
    }
}
