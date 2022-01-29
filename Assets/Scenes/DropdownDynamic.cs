using UnityEngine;
using UnityEngine.UI;

public class DropdownDynamic : MonoBehaviour
{
  /// <summary>�A�C�e���������s���h���b�v�_�E���I�u�W�F�N�g�B</summary>
  [SerializeField] Dropdown Dropdown;

  /// <summary>�ǉ��{�^�����N���b�N�����Ƃ��B</summary>
  public void OnClickAdd()
  {
    // �A�C�e����ǉ����܂�
    Dropdown.options.Add(new Dropdown.OptionData { text = $"Item {Dropdown.options.Count}" });

    // �h���b�v�_�E���̓��e���X�V���܂�
    Dropdown.RefreshShownValue();
  }

  /// <summary>�폜�{�^�����N���b�N�����Ƃ��B</summary>
  public void OnClickRemove()
  {
    // �A�C�e�����폜���܂�
    if (Dropdown.options.Count >= 1)
		{
      Dropdown.options.RemoveAt(Dropdown.options.Count - 1);
    }

    // �h���b�v�_�E���̓��e���X�V���܂�
    Dropdown.RefreshShownValue();
  }
}
