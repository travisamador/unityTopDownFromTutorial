using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int goldAmount = 5;
    protected override void OnCollect()
    {
        if (!collected)
        {
            base.OnCollect();
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            //Debug.Log($"Received {goldAmount} gold!");
            GameManager.instance.gold += goldAmount;
            GameManager.instance.ShowText($"+ {goldAmount} gold!", 25, Color.yellow, transform.position, Vector3.up * 25, 1.0f);
        }
    }
}
