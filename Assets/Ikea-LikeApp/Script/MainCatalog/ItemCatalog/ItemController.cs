using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace IkeaLikeApp.Item
{
    public class ItemController : MonoBehaviour
    {
        [Header("Item")]
        public ItemList itemList;
        public GameObject itemPrefabs;
        public Transform itemParent;
        public int maxItemShow;

        public GameObject catalogGroup;
        public GameObject detailGroup;

        [Header("Categories")]
        public ItemCategories category;
        public GameObject categoriesPrefabs;
        public RectTransform categoriesParent;

        private DetailItemController detailController;
        private CategoriesController categoriesController;
        private void Start()
        {
            detailController = GetComponent<DetailItemController>();
            categoriesController = GetComponent<CategoriesController>();
            ViewItemDetail(-1, true);
            ShowPopularItem();
            ShowCategories();
        }
        private void ShowPopularItem()
        {
            int itemShown = 0;
            List<int> itemShowned= new List<int>();

            for (int i = 0; i < maxItemShow; i++)
            {
                int temp;
                GameObject tempGameobject = Instantiate(itemPrefabs, itemParent);
                do
                {
                    temp = Random.Range(0, itemList.listOfItem.Length);
                    if (!itemShowned.Contains(temp))
                    {
                        itemShowned.Add(temp);
                        break;
                    }
                } while (true);
                SetItemData(tempGameobject.GetComponent<ItemObject>(), temp);
            }
        }

        private void ShowCategories()
        {
            foreach (Categories data in category.categories)
            {
                GameObject tempGameobject = Instantiate(categoriesPrefabs, categoriesParent);
                SetCategoryData(tempGameobject.GetComponent<CategoriesObject>(), data);
            }
        }
        private void SetItemData(ItemObject itemObject, int id)
        {
            itemObject.id = itemList.listOfItem[id].id;

            itemObject.itemImage.sprite = itemList.listOfItem[id].itemImage;
            itemObject.itemTitle.text = itemList.listOfItem[id].itemName;
            itemObject.itemPrice.text = itemList.listOfItem[id].itemPrice;
            itemObject.itemDescription.text = itemList.listOfItem[id].itemDescription;

            itemObject.itemController = this;
        }
        private void SetCategoryData(CategoriesObject categoriesObject, Categories data)
        {
            categoriesObject.titleImage.sprite = data.categoryImage;
            categoriesObject.titleText.text = data.categoriesName;
            categoriesObject.category = data.category;
            categoriesObject.categoryController = categoriesController;
        }

        public void ViewItemDetail(int id = 0, bool isInit = false)
        {
            if (isInit && PlayerPrefs.HasKey("idItem"))
            {
                catalogGroup.SetActive(false);
                detailGroup.SetActive(true);
                detailController.SetItemDetail(PlayerPrefs.GetInt("idItem"));
                PlayerPrefs.DeleteKey("idItem");
            }
            else if (id > -1)
            {
                categoriesController.categoriesGroup.SetActive(false);
                catalogGroup.SetActive(false);
                detailGroup.SetActive(true);
                detailController.SetItemDetail(id);
            }
        }
        public void BackToCatalog ()
        {
            catalogGroup.SetActive(true);
            detailGroup.SetActive(false);
            PlayerPrefs.DeleteKey("idItem");
        }
        private void OnApplicationQuit()
        {
            PlayerPrefs.DeleteKey("idItem");
        }
    }
}
