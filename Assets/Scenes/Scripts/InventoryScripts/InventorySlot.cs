using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
//  InventorySlot.cs
//  Inventory Slot Script
//
//  Created by Kyo Matias on 00/00/2022.
//  Copyright © 2022 Kyo Matias. All rights reserved.
//

[System.Serializable]
public class InventorySlot
{
    [SerializeField] private InventoryItemData _itemData;
    [SerializeField] private int _stacksize;

    public InventoryItemData ItemData => _itemData;
    public int StackSize => _stacksize;

    public InventorySlot(InventoryItemData source, int amount)
    {
        _itemData = source;
        _stacksize = amount;
    }

    public InventorySlot()
    {
        _itemData = null;
        _stacksize = -1;
    }
}

