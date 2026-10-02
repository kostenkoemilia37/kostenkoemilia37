using TMPro;
using UnityEngine;
using static _0xf90e3ec3;

public class _0xa7f7d855 : MonoBehaviour
{
    public void _0x9c8cd5ac()
    {
        this.MoneyCountText.text = _0xcd3fadf4._0x7dacd067.ToString();
    }

    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x6f734328;
            if (this.gameObject.TryGetComponent(out _0x6f734328))
                this.MoneyCountText = _0x6f734328;
        }

        this._0x9c8cd5ac();
    }
}