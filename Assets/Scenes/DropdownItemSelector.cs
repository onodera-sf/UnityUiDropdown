using UnityEngine;
using UnityEngine.UI;

public class DropdownItemSelector : MonoBehaviour
{
  /// <summary>�h���b�v�_�E���őI�������A�C�e���̓��e��\������e�L�X�g�I�u�W�F�N�g�B</summary>
  [SerializeField] Text TextValueSetter;

  /// <summary>�l���擾����h���b�v�_�E���I�u�W�F�N�g�B</summary>
  [SerializeField] Dropdown Dropdown;

  /// <summary>�h���b�v�_�E���ŃA�C�e����I�������Ƃ��ɌĂ΂�܂��B</summary>
  public void OnSelectionChanged()
  {
    // �h���b�v�_�E���̑I��l�ƑI�����Ă���A�C�e���̃e�L�X�g��\��
    TextValueSetter.text = $"value={Dropdown.value}, options.text={Dropdown.options[Dropdown.value].text}";
  }
}
