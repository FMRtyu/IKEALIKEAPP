using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace IkeaLikeApp.Item
{
    public class DetailObject : MonoBehaviour
    {
        public int id;
        public Image itemImage;
        public TextMeshProUGUI itemTitle;
        public TextMeshProUGUI itemPrice;
        public TextMeshProUGUI itemDescription;

        public Button ARViewBTN;
    }
}
