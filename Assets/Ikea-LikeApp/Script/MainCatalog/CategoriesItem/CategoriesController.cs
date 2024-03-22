using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace IkeaLikeApp.Item
{
    public class CategoriesController : MonoBehaviour
    {
        [Header("item")]
        public ItemList itemList;
        public GameObject itemPrefabs;
        public Transform itemParent;
        public TextMeshProUGUI titleText;

        public GameObject catalogGroup;
        public GameObject categoriesGroup;

        private ItemController itemController;

        private void Start()
        {
            itemController = GetComponent<ItemController>();
        }
        public void SetCategoriesData(FurnitureCategory tag)
        {
            catalogGroup.SetActive(false);
            categoriesGroup.SetActive(true);
            titleText.text = "Product of " +  tag.ToString();
            foreach (Item data in itemList.listOfItem)
            {
                if (data.itemTag == tag)
                {
                    GameObject tempGameobject = Instantiate(itemPrefabs, itemParent);
                    SetItemData(tempGameobject.GetComponent<ItemObject>(), data);
                }
            }
        }
        private void SetItemData(ItemObject itemObject, Item data)
        {
            itemObject.id = data.id;

            itemObject.itemImage.sprite = data.itemImage;
            itemObject.itemTitle.text = data.itemName;
            itemObject.itemPrice.text = data.itemPrice;
            itemObject.itemDescription.text = data.itemDescription;

            itemObject.itemController = itemController;
        }
        public void BackToMenu()
        {
            catalogGroup.SetActive(true);
            categoriesGroup.SetActive(false);

            foreach (Transform child in itemParent)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
