using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace IkeaLikeApp.Item
{
    public class ItemObject : MonoBehaviour
    {
        public int id;
        public Image itemImage;
        public TextMeshProUGUI itemTitle;
        public TextMeshProUGUI itemPrice;
        public TextMeshProUGUI itemDescription;

        public ItemController itemController;

        Button btn;

        public void ShowItemDetail()
        {
            itemController.ViewItemDetail(id);
        }
    }
}
