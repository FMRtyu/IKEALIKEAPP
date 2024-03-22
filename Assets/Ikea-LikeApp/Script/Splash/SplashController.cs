using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

namespace IkeaLikeApp.Splash
{
    public class SplashController : MonoBehaviour
    {
        [Header("Splash Image")]
        public RectTransform[] SplashImages;
        public RectTransform titleTransform;
        private RectTransform canvasRectTransform;
        public float dropTime = 1f;
        public float titleTime = 1f;
        private static bool isSplashDone;

        public static bool IsSplashDone
        {
            set { isSplashDone = value; }
            get { return isSplashDone; }
        }
        private void Start()
        {
            canvasRectTransform = GetComponentInParent<Canvas>().GetComponent<RectTransform>();
            titleTransform.anchoredPosition = new Vector2(canvasRectTransform.rect.width, 0f);
            ShowTitle.SetTitle(titleTransform, titleTime);
            StartSplashAnimation();
            StartCoroutine(LoadNextScene());
        }
        private void StartSplashAnimation()
        {
            //move image above screen
            for (int i = 0; i < SplashImages.Length; i++)
            {
                SetImagePosition(SplashImages[i]);
            }
            Dropdown.StartImageDown(SplashImages, dropTime);

        }
        private void SetImagePosition(RectTransform imageTransform)
        {
            imageTransform.anchoredPosition = new Vector2(imageTransform.anchoredPosition.x, canvasRectTransform.rect.height);
        }

        private IEnumerator LoadNextScene()
        {
            while (!IsSplashDone)
            {
                yield return null;
            }
            yield return new WaitForSeconds(1f);
            MoveAllToSide();
        }
        private void MoveAllToSide()
        {
            for (int i = 0; i < SplashImages.Length; i++)
            {
                LeanTween.move(SplashImages[i], new Vector2(canvasRectTransform.rect.width, 0f), 0.3f);
            }
            LeanTween.move(titleTransform, new Vector2(canvasRectTransform.rect.width, 0f), 0.3f).setOnComplete(() =>
            {
                SceneManager.LoadScene(1);
            });
        }
    }
}

