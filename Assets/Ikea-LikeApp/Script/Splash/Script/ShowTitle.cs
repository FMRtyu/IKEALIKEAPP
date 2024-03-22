using IkeaLikeApp.Splash;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IkeaLikeApp.Splash
{
    public class ShowTitle : MonoBehaviour
    {
        private static RectTransform titleTransform;
        private static float titleTime;
        public static void SetTitle(RectTransform Transform, float Time)
        {
            titleTransform = Transform;
            titleTime = Time;
        }
        public static void StartShowTitle()
        {
            LeanTween.move(titleTransform, Vector2.zero, titleTime)
            .setEase(LeanTweenType.easeOutBounce).setOnComplete(() =>
            {
                SplashController.IsSplashDone = true;
            });
        }
    }
}
