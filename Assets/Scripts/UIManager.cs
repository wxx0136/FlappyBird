using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float fadeTime = 0.5f;

    public void ShowUI()
    {
        canvasGroup.DOFade(1, fadeTime);
    }

    public void HideUI()
    {
        canvasGroup.DOFade(0, fadeTime).onComplete = () => { gameObject.SetActive(false); };
    }
}