using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x9e0b1280 : MonoBehaviour
{
    private void _0xab8acea8()
    {
        if (this._0xde477df8.canvasRenderer.GetColor() != this._0x57cce41b.canvasRenderer.GetColor())
            this._0x57cce41b.canvasRenderer.SetColor(this._0xde477df8.canvasRenderer.GetColor());
    }

    private TMP_Text _0x57cce41b;
    private Image _0xde477df8;
    private void Update()
    {
        this._0xab8acea8();
    }
}