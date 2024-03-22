using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IkeaLikeApp.Item
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "itemOption/ItemList")]
    [SerializeField]
    public class ItemList : ScriptableObject
    {
        public Item[] listOfItem;
    }
}
