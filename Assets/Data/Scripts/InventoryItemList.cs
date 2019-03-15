using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryItemList", menuName = "Inventory/ItemList")]
public class InventoryItemList : ScriptableObject
{
    public List<InventoryItem> itemList;
}
