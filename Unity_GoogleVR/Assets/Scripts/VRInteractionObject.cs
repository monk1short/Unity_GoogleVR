using UnityEngine;

/// <summary>
/// VR ���ʪ���
/// 1. VR �`���I�ݨ즹���� Enter
/// 2. VR �`���I�ݨ�����}������ Exit
/// 3. VR �`���I�ݨ즹������I�郎�ʫ��s Click
/// </summary>

public class VR : MonoBehaviour
{
    /// <summary>
    /// VR �`���I�ݨ즹���� Enter
    /// </summary>
    public void OnPoninterEnter()
    {
        print("�`���I�ݨ�");
    }

    /// <summary>
    /// VR �`���I�ݨ�����}������ Exit
    /// </summary>
    public void OnPoninterExit()
    {
        print("�`���I���}");
    }

    /// <summary>
    /// VR �`���I�ݨ즹������I�郎�ʫ��s Click
    /// </summary>
    public void OnPoninterClick()
    {
        print("�`���I�I��");
    }
}
