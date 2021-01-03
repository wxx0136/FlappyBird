using UnityEngine;

public class Tools
{
    #region Singleton

    static Tools _instance;

    Tools()
    {
    }

    public static Tools Instance
    {
        get
        {
            if (_instance == null) _instance = new Tools();
            return _instance;
        }
    }

    #endregion

    public void ShowUI(GameObject uiObj)
    {
        uiObj.SetActive(true);
        uiObj.GetComponent<CanvasGroup>().alpha = 0;
        uiObj.GetComponent<UIManager>().ShowUI();
    }

    public void HideUI(GameObject uiObj)
    {
        uiObj.GetComponent<UIManager>().HideUI();
    }
}