using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace IkeaLikeApp.Item
{
    public class CategoriesObject : MonoBehaviour
    {
        public Image titleImage;
        public TextMeshProUGUI titleText;
        public FurnitureCategory category;
        public CategoriesController categoryController;
        public void OnClicked()
        {
            categoryController.SetCategoriesData(category);
        }
    }
}
