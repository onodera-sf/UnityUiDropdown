using UnityEngine;
using UnityEngine.UI;

public class DropdownDynamic : MonoBehaviour
{
  /// <summary>アイテム処理を行うドロップダウンオブジェクト。</summary>
  [SerializeField] Dropdown Dropdown;

  /// <summary>追加ボタンをクリックしたとき。</summary>
  public void OnClickAdd()
  {
    // アイテムを追加します
    Dropdown.options.Add(new Dropdown.OptionData { text = $"Item {Dropdown.options.Count}" });

    // ドロップダウンの内容を更新します
    Dropdown.RefreshShownValue();
  }

  /// <summary>削除ボタンをクリックしたとき。</summary>
  public void OnClickRemove()
  {
    // アイテムを削除します
    if (Dropdown.options.Count >= 1)
		{
      Dropdown.options.RemoveAt(Dropdown.options.Count - 1);
    }

    // ドロップダウンの内容を更新します
    Dropdown.RefreshShownValue();
  }
}
