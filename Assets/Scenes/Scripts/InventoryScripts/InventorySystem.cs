using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;



//
//  .cs
//  Script
//
//  Created by Kyo Matias on 00/00/2022.
//  Copyright © 2022 Kyo Matias. All rights reserved.
//
[System.Serializable]
public class InventorySystem : MonoBehaviour
{
    [SerializeField] private List<InventorySlot> _inventorySlots;

    public List<InventorySlot> InventorySlots => _inventorySlots;
    public int InventorySize => InventorySlots.Count;
    public UnityAction<InventorySlot> OnInventorySlotChanged;

    public InventorySystem(int size)
    {
        _inventorySlots = new List<InventorySlot>(size);

        for (int i = 1; i < size; i++)
        {
            _inventorySlots.Add(new InventorySlot());
        }
    }
}
