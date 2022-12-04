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
public class InventoryItemData : ScriptableObject
{
    public int ID;
    public string DisplayName;
    [TextArea(4, 4)]
    public string Description;
    public Sprite Icon;
    public int MaxStack;
}
