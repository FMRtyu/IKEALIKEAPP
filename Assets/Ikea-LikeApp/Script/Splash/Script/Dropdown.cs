using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IkeaLikeApp.Splash
{
    public class Dropdown : MonoBehaviour
    {
        public static void StartImageDown(RectTransform[] imageTransform, float dropTime)
        {
            MoveImageDown(imageTransform, dropTime);
        }
        private static void MoveImageDown(RectTransform[] imageTransform, float dropTime)
        {
            LeanTween.move(imageTransform[0], new Vector2(imageTransform[0].anchoredPosition.x, 0), dropTime)
            .setEase(LeanTweenType.easeOutBounce)
            .setOnComplete(() =>
            {
                LeanTween.move(imageTransform[1], new Vector2(imageTransform[1].anchoredPosition.x, 0), dropTime)
                .setEase(LeanTweenType.easeOutBounce)
                .setOnComplete(() =>
                {
                    LeanTween.move(imageTransform[2], new Vector2(imageTransform[2].anchoredPosition.x, 0), dropTime)
                    .setEase(LeanTweenType.easeOutBounce)
                    .setOnComplete(() =>
                    {
                        LeanTween.move(imageTransform[3], new Vector2(imageTransform[3].anchoredPosition.x, 0), dropTime)
                        .setEase(LeanTweenType.easeOutBounce)
                        .setOnComplete(() =>
                        {
                            LeanTween.move(imageTransform[4], new Vector2(imageTransform[4].anchoredPosition.x, 0), dropTime)
                            .setEase(LeanTweenType.easeOutBounce)
                            .setOnComplete(() =>
                            {
                                LeanTween.move(imageTransform[5], new Vector2(imageTransform[5].anchoredPosition.x, 0), dropTime)
                                .setEase(LeanTweenType.easeOutBounce).setOnComplete(() =>
                                {
                                    LeanTween.move(imageTransform[6], new Vector2(imageTransform[6].anchoredPosition.x, 0), dropTime)
                                   .setEase(LeanTweenType.easeOutBounce).setOnComplete(() =>
                                   {
                                       LeanTween.move(imageTransform[7], new Vector2(imageTransform[7].anchoredPosition.x, 0), dropTime)
                                       .setEase(LeanTweenType.easeOutBounce).setOnComplete(() =>
                                       {
                                           ShowTitle.StartShowTitle();
                                       });
                                   });
                                });
                            });
                        });
                    });
                });
            });
        }
    }
}
