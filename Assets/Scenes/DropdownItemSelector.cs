using UnityEngine;
using UnityEngine.UI;

public class DropdownItemSelector : MonoBehaviour
{
  /// <summary>ドロップダウンで選択したアイテムの内容を表示するテキストオブジェクト。</summary>
  [SerializeField] Text TextValueSetter;

  /// <summary>値を取得するドロップダウンオブジェクト。</summary>
  [SerializeField] Dropdown Dropdown;

  /// <summary>ドロップダウンでアイテムを選択したときに呼ばれます。</summary>
  public void OnSelectionChanged()
  {
    // ドロップダウンの選択値と選択しているアイテムのテキストを表示
    TextValueSetter.text = $"value={Dropdown.value}, options.text={Dropdown.options[Dropdown.value].text}";
  }
}
