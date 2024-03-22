using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace IkeaLikeApp.Item
{
    public class DetailItemController : MonoBehaviour
    {
        [Header("Item Data")]
        public ItemList itemList;
        public DetailObject detailObject;
        public GameObject settingPrefabs;

        //AR prefabs
        private GameObject itemPrefabs;
        private int idItem;
        public void SetItemDetail(int id)
        {
            foreach (Item data in itemList.listOfItem)
            {
                if (data.id == id)
                {
                    SetItemData(detailObject, data);
                }
            }
        }
        private void SetItemData(DetailObject itemObject, Item data)
        {
            itemObject.id = data.id;

            itemObject.itemImage.sprite = data.itemImage;
            itemObject.itemTitle.text = data.itemName;
            itemObject.itemPrice.text = data.itemPrice;
            itemObject.itemDescription.text = data.itemDescription;
            itemObject.ARViewBTN.onClick.AddListener(ViewInAR);

            //for this script
            itemPrefabs = data.itemPrefabs;
            idItem = data.id;
        }
        private void ViewInAR()
        {
            PlayerPrefs.SetInt("idItem", idItem);
            settingPrefabs.GetComponent<InitialData>().ShowPrefabInARView(itemPrefabs);
        }
    }
}
