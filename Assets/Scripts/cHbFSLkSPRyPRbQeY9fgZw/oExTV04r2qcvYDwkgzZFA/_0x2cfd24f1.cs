using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x2cfd24f1 : MonoBehaviour
{
    private float _0x75c23f78 = 0.6f;
    private float _0x765ccdfd;
    private TMP_Text _0x058ec4f4;
    private void Update()
    {
        int _0xc07644e1 = 1;
        if (this._0x1d0a968f.Count > 0)
        {
            string _0x1f5f3300 = this._0x058ec4f4.text;
            foreach (string _0xc1616424 in this._0x1d0a968f)
                while (_0x1f5f3300.Contains(_0xc1616424))
                    _0x1f5f3300 = _0x1f5f3300.Replace(_0xc1616424, "");
            _0xc07644e1 = _0x1f5f3300.Length;
        }
        else
        {
            _0xc07644e1 = this._0x058ec4f4.text.Length;
        }

        float _0x48d135c9 = Mathf.Clamp(this._0x765ccdfd + this._0x75c23f78 * _0xc07644e1, this._0x5cbbf4af, this._0xf1bc1512);
        if (!Mathf.Approximately(this._0x93c137de.aspectRatio, _0x48d135c9))
            this._0x93c137de.aspectRatio = _0x48d135c9;
    }

    private float _0xf1bc1512 = 4;
    private List<string> _0x1d0a968f = new();
    private float _0x5cbbf4af = 1.5f;
    private AspectRatioFitter _0x93c137de;
}