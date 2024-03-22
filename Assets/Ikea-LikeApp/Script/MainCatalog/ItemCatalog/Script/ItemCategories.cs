using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IkeaLikeApp.Item
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "itemOption/ItemCategory")]
    public class ItemCategories : ScriptableObject
    {
        public Categories[] categories;
    }
}
