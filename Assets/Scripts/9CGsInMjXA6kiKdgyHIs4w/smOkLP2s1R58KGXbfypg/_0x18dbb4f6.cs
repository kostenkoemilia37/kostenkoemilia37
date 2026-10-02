using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xf90e3ec3;

public class _0x18dbb4f6 : MonoBehaviour
{
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xbadb97db _0x6e877eab in this.Pops)
            if (_0x6e877eab != null)
                _0x6e877eab.gameObject.SetActive(true);
    }

    public GameObject BlurBackground;
    public static _0x18dbb4f6 Instance;
    public void _0x7ac038f2(int _0x016daf02)
    {
        this.CurrentPopIndex = _0x016daf02;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xa3e5593c(true);
        this._0xec67956f();
        this.Pops[_0x016daf02].Show();
        foreach (GameObject _0x5b57e25c in this.GameObjectsToHide)
            _0x5b57e25c.SetActive(false);
    }

    public List<GameObject> GameObjectsToHide;
    public List<int> LastPopIndexes = new();
    public void _0x2fdb41ad()
    {
        this.LastPopIndexes.Clear();
        this._0xa3e5593c();
        foreach (GameObject _0x94b11d60 in this.GameObjectsToHide)
            if (_0x94b11d60 != null)
                _0x94b11d60.SetActive(true);
        this._0xd9f691ac();
    }

    public float ScaleDuration = 0.4f;
    public _0xbadb97db _0xae857e31(int _0x15bb9ffe)
    {
        return this.Pops[_0x15bb9ffe];
    }

    public List<_0xbadb97db> Pops;
    private void _0xd9f691ac()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    private void _0xa3e5593c(bool _0xf6d1263f = false)
    {
        for (int _0x2352843a = 0; _0x2352843a < this.Pops.Count; ++_0x2352843a)
            if (this.Pops[_0x2352843a] != null && !(_0x2352843a == this.CurrentPopIndex && _0xf6d1263f))
                this.Pops[_0x2352843a]._0xaded7b70();
    }

    private void _0xec67956f()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public void _0xa6972e1f()
    {
        this.LastPopIndexes.RemoveAll(_0xc1e598d2 => _0xc1e598d2 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x2fdb41ad();
        else
            this._0x7ac038f2(this.LastPopIndexes.Last());
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x18dbb4f6>();
    }

    public int CurrentPopIndex;
}