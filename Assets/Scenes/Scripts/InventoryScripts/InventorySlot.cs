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
        ClearSlot();
    }

    public void ClearSlot()
    {
        _itemData = null;
        _stacksize = -1;
    }

    public bool RoomLeftToStack(int amountToAdd, out int amountRemaining)
    {
        amountRemaining = _itemData.MaxStack - _stacksize;
        return RoomLeftInStack(amountToAdd);
    }

    public bool RoomLeftInStack(int amountToAdd)
    {
        if (_stacksize + amountToAdd <= _itemData.MaxStack) return true;
        else return false;
    }

    public void AddToStack(int amount)
    {
        _stacksize += amount;
    }

    public void RemoveFromStack(int amount)
    {
        _stacksize -= amount;
    }
}

