using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//
//  InventoryItemData.cs
//  Inventory Item Data Script
//
//  Created by Kyo Matias on 10/04/2022.
//  Copyright © 2022 Kyo Matias. All rights reserved.
//

[CreateAssetMenu(menuName = "Inventory System/Inventory Item")]
public class Item : ScriptableObject
{
    
    [Header("Gameplay")]
    public string DisplayName;
    public string Description;
    [Header("Ui")]
    public bool Stackable;
    public Sprite Icon;
    [Header("Both")]
    public int ID;
    public int MaxStack;
    
}
