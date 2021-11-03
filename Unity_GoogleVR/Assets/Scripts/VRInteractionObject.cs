using UnityEngine;

/// <summary>
/// VR 互動物件
/// 1. VR 注視點看到此物件 Enter
/// 2. VR 注視點看到後離開此物件 Exit
/// 3. VR 注視點看到此物件並點選互動按鈕 Click
/// </summary>

public class VR : MonoBehaviour
{
    /// <summary>
    /// VR 注視點看到此物件 Enter
    /// </summary>
    public void OnPoninterEnter()
    {
        print("注視點看到");
    }

    /// <summary>
    /// VR 注視點看到後離開此物件 Exit
    /// </summary>
    public void OnPoninterExit()
    {
        print("注視點離開");
    }

    /// <summary>
    /// VR 注視點看到此物件並點選互動按鈕 Click
    /// </summary>
    public void OnPoninterClick()
    {
        print("注視點點擊");
    }
}
