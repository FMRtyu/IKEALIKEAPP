using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IkeaLikeApp.Item
{
    public enum FurnitureCategory
    {
        Chair,
        Table,
        Decoration,
        // Add more categories as needed
    }
    [System.Serializable]
    public class Item
    {
        public int id;
        public Sprite itemImage;
        public GameObject itemPrefabs;
        public string itemName;
        public string itemPrice;
        public string itemDescription;
        public FurnitureCategory itemTag;
    }
}
