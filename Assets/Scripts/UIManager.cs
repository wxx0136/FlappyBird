using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public void ShowUI()
    {
        canvasGroup.alpha = 1f;
    }

    public void HideUI()
    {
        canvasGroup.DOFade()
    }
}
