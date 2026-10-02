using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xf90e3ec3;

public class _0x2a281dda : MonoBehaviour
{
    public int CurrentPanelIndex;
    public void _0x7cb2038e()
    {
        this.LastPanelIndexes.RemoveAll(_0xc1e598d2 => _0xc1e598d2 == this.CurrentPanelIndex);
        int _0x19494cff = this.LastPanelIndexes.Last();
        this._0x52b4ac24(_0x19494cff);
        this._0xae12e93e(_0x19494cff);
        this.CurrentPanelIndex = _0x19494cff;
        this.Panels[_0x19494cff].Show();
    }

    public bool IsShowSplashOnStart = true;
    public float ScaleDuration = 0.4f;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0xbf450ebc(int _0xcdbc5f62)
    {
        this.LastPanelIndexes.Add(_0xcdbc5f62);
        this.CurrentPanelIndex = _0xcdbc5f62;
        for (int _0x1f7a2011 = 0; _0x1f7a2011 < this.Panels.Count; _0x1f7a2011++)
            if (_0x1f7a2011 != _0xcdbc5f62 && this.Panels[_0x1f7a2011] != null)
                this.Panels[_0x1f7a2011]._0xc33de8e2();
    }

    public List<_0x56ac1de9> Panels;
    public static _0x2a281dda Instance;
    private _0x56ac1de9 _0x9f813584(int _0xa4ab6d16)
    {
        return this.Panels[_0xa4ab6d16];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x2a281dda>();
    }

    private void SwitchSplash()
    {
        if (_0xa0e61552.Instance.IsTutorialEnabled && !_0x7b6179ac._0x1b74f841._0x9c0858b9)
            this._0x4771d9b3(_0x5f839e9d.TUTORIAL0);
        else
            this._0x4771d9b3(_0x5f839e9d.DEFAULT);
    }

    private void _0xae12e93e(int _0xb1582e03)
    {
        this.LastPanelIndexes.Add(_0xb1582e03);
        this.CurrentPanelIndex = _0xb1582e03;
        for (int _0x7f0641d1 = 0; _0x7f0641d1 < this.Panels.Count; _0x7f0641d1++)
            if (_0x7f0641d1 != _0xb1582e03 && this.Panels[_0x7f0641d1] != null)
                this.Panels[_0x7f0641d1]._0xc33de8e2();
    }

    public void _0x4771d9b3(int _0x8907d878)
    {
        this._0xbf450ebc(_0x8907d878);
        this._0x52b4ac24(_0x8907d878);
        this.CurrentPanelIndex = _0x8907d878;
        this.Panels[_0x8907d878].Show();
    }

    private void Start()
    {
        this._0x5a147555();
    }

    public void _0x753a5131(int _0x235d8c6e)
    {
        if (_0x235d8c6e == _0x5f839e9d.SPLASH && _0x7b6179ac.Instance._0x46fe397e != _0xe768a878.SCENE_0)
            _0x347b2c13.Instance._0x43ddd955();
        if (_0x7b6179ac.Instance._0x46fe397e != _0xe768a878.SCENE_0)
        {
            if (_0x235d8c6e == _0x5f839e9d.SPLASH || _0x235d8c6e == _0x5f839e9d.TUTORIAL0)
                _0x7b6179ac.Instance._0xb565d280(false);
            else if (_0x235d8c6e == _0x5f839e9d.DEFAULT)
                _0x7b6179ac.Instance._0xb565d280(true);
        }
    }

    private void _0x5a147555()
    {
        this._0xf35dcd81(_0x5f839e9d.SPLASH);
        if (_0x7b6179ac.Instance._0x46fe397e == _0xe768a878.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x347b2c13.Instance.DefaultAnimationTime);
        }
    }

    private void _0xf35dcd81(int _0x37ff4d85)
    {
        this._0xbf450ebc(_0x37ff4d85);
        this._0x52b4ac24(_0x37ff4d85);
        this.CurrentPanelIndex = _0x37ff4d85;
        this.Panels[_0x37ff4d85]._0x1d1a544a();
    }

    public float StaticBlurMaterialInitialValue;
    private void _0x52b4ac24(int _0x367539b4)
    {
        if (_0x367539b4 == _0x5f839e9d.SPLASH)
            _0x347b2c13.Instance._0x4826640d();
        if (_0x7b6179ac.Instance._0x46fe397e == _0xe768a878.SCENE_0)
        {
        }
    }
}