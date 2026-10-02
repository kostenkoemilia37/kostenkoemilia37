using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

// The world-space half of the game: the plate, the three gear rings, their notch
// markers, the target gate, the core lock, the key tray and the pulse/spark effects.
//
// Sizes come from VaultMetrics (camera-derived, rule C.0) and sorting orders from its
// named constants (rule C.21) - no literal ever reaches a transform here. Every
// DOScale is written against the size this object was actually built at, never a
// hardcoded 1.0.
public sealed class _0xbfcfaf0b : MonoBehaviour
{
    [SerializeField]
    private Sprite _gearMidSprite;
    public void _0x34a034f5()
    {
        DOTween.Kill(this._0x455df9a0, true);
        this._0x455df9a0.localPosition = Vector3.zero;
        this._0x455df9a0.DOShakePosition(0.25f, this._0x713fe5c2._0x600e6fe5 * 0.05f, 18, 90f);
    }

    private void _0xeaf52bfb()
    {
        for (int _0xef4da393 = 0; _0xef4da393 < SectionCount; _0xef4da393++)
        {
            float _0x7d094514 = _0xef4da393 * (360f / SectionCount);
            float _0x39cd6e85 = _0x7d094514 * Mathf.Deg2Rad;
            Vector2 _0x46707ed1 = new Vector2(Mathf.Sin(_0x39cd6e85), Mathf.Cos(_0x39cd6e85)) * this._0x713fe5c2._0xe0df8bf8;
            SpriteRenderer _0x08ab7acc = this.Spawn(this._pipPrefab, this._0x455df9a0, _0x46707ed1, this._0x713fe5c2._0xe5e82e92, _0x1e0444d9.SectionPipOrder);
            _0x08ab7acc.color = _0x38a88da4._0xb491aef5;
            this._0xf833517a.Add(_0x08ab7acc);
        }
    }

    public const float PulseSeconds = 1.1f;
    private readonly Transform[] _0x50957d52 = new Transform[_0x9a061f9e.RingCount];
    public Tween _0xc5fd6904(int _0x95fffc34, int _0xa575625a)
    {
        Transform _0xfcc89890 = this._0x50957d52[_0x95fffc34];
        DOTween.Kill(_0xfcc89890, true);
        return _0xfcc89890.DORotate(new Vector3(0f, 0f, -_0x9a061f9e.DegreesPerTooth * _0xa575625a), RotateSeconds).SetEase(Ease.OutBack);
    }

    private readonly List<SpriteRenderer> _0x68e99742 = new List<SpriteRenderer>();
    [SerializeField]
    private GameObject _pulsePrefab;
    // Sliced draw mode makes m_Size authoritative, so the object is exactly as big as
    // the camera maths says - never the sprite's native 640px/PPU100 = 6.4 units, which
    // is wider than the whole screen.
    private SpriteRenderer Spawn(GameObject _0xe1d896b6, Transform _0x525abcfa, Vector2 _0x86cc3cfc, float _0xda5931e3, int _0x55774195)
    {
        GameObject _0xc73a140b = Instantiate(_0xe1d896b6, _0x525abcfa);
        _0xc73a140b.transform.localPosition = new Vector3(_0x86cc3cfc.x, _0x86cc3cfc.y, 0f);
        _0xc73a140b.transform.localScale = Vector3.one;
        SpriteRenderer _0x34d81c4b = _0xc73a140b.GetComponent<SpriteRenderer>();
        _0x34d81c4b.drawMode = SpriteDrawMode.Sliced;
        _0x34d81c4b.size = new Vector2(_0xda5931e3, _0xda5931e3);
        _0x34d81c4b.sortingOrder = _0x55774195;
        return _0x34d81c4b;
    }

    private _0x1e0444d9 _0x713fe5c2;
    public const int SparkCount = 8;
    public void _0xaf5f53d4(_0x1e0444d9 _0x3f906568)
    {
        this._0x713fe5c2 = _0x3f906568;
        this._0x455df9a0 = new GameObject(_0xf9b74b5f._0x2bfb47c6(new byte[10] { 143, 184, 172, 181, 173, 155, 182, 184, 171, 189 }, 217)).transform;
        this._0x455df9a0.SetParent(this.transform, false);
        this._0x455df9a0.position = new Vector3(_0x3f906568._0xd65a4b59.x, _0x3f906568._0xd65a4b59.y, 0f);
        this._0x35ad12fe();
        this._0xeaf52bfb();
        this._0x49b4b102();
        this._0x0f7cb51d();
        this._0x2a47091a();
        this._0xe14c847c();
        this._0x726a228e();
        this._0x223431e6();
    }

    [SerializeField]
    private GameObject _platePrefab;
    [SerializeField]
    private Sprite _gearInnerSprite;
    private void _0x726a228e()
    {
        for (int _0x0170632d = 0; _0x0170632d < SparkCount; _0x0170632d++)
        {
            SpriteRenderer _0x0de459c7 = this.Spawn(this._sparkPrefab, this._0x455df9a0, Vector2.zero, this._0x713fe5c2._0x88f39a99, _0x1e0444d9.SparkOrder);
            _0x0de459c7.color = _0x38a88da4.Fade(_0x38a88da4._0xb3ad8789, 0f);
            this._0x5a870d3e.Add(_0x0de459c7);
        }
    }

    public Tween _0x8faff915(int _0x4e51bbbe)
    {
        Transform _0x8a4d00c3 = this._0x50957d52[_0x4e51bbbe];
        return _0x8a4d00c3.DOPunchScale(Vector3.one * 0.035f, 0.35f, 6, 0.6f);
    }

    [SerializeField]
    private GameObject _gearPrefab;
    public const float RotateSeconds = 0.32f;
    [SerializeField]
    private GameObject _keyPrefab;
    private SpriteRenderer _0x00f85c79;
    public Sequence _0xad93725a(int _0x6819cdda, bool _0xdca26e8e)
    {
        float _0xb898d4a2 = this._0x713fe5c2._0x600e6fe5 * 1.0f;
        Vector2 _0xc1daa78b = this._0x713fe5c2._0x085a7cc2(_0xb898d4a2, _0x6819cdda * _0x9a061f9e.DegreesPerTooth);
        Vector2 _0x245e4bb3 = this._0x713fe5c2._0xd65a4b59;
        Transform _0x53adf366 = this._0x3dcae67a.transform;
        _0x53adf366.position = new Vector3(_0xc1daa78b.x, _0xc1daa78b.y, 0f);
        _0x53adf366.rotation = Quaternion.Euler(0f, 0f, -_0x6819cdda * _0x9a061f9e.DegreesPerTooth);
        this._0x3dcae67a.color = _0x38a88da4.Fade(_0xdca26e8e ? _0x38a88da4._0xb3ad8789 : _0x38a88da4._0x18999b33, 0f);
        Sequence _0x0518366b = DOTween.Sequence();
        _0x0518366b.Append(this._0x3dcae67a.DOFade(1f, PulseSeconds * 0.25f));
        _0x0518366b.Join(_0x53adf366.DOMove(new Vector3(_0x245e4bb3.x, _0x245e4bb3.y, 0f), PulseSeconds).SetEase(Ease.InOutQuad));
        _0x0518366b.Append(this._0x3dcae67a.DOFade(0f, PulseSeconds * 0.2f));
        return _0x0518366b;
    }

    public void _0xb1be3b1c(int _0x6ea135ad, bool _0x0fe70850, bool _0x55c95599)
    {
        if (_0x6ea135ad < 0 || _0x6ea135ad >= this._0xf833517a.Count)
            return;
        SpriteRenderer _0xc8c88db7 = this._0xf833517a[_0x6ea135ad];
        if (_0x0fe70850)
            _0xc8c88db7.color = _0x38a88da4._0xb3ad8789;
        else if (_0x55c95599)
            _0xc8c88db7.color = _0x38a88da4._0x87400960;
        else
            _0xc8c88db7.color = _0x38a88da4._0xb491aef5;
        if (_0x0fe70850 || _0x55c95599)
            _0xc8c88db7.transform.DOPunchScale(Vector3.one * 0.14f, 0.3f, 6, 0.7f);
    }

    private SpriteRenderer _0x8810a6da;
    public const int SectionCount = 5;
    private readonly List<SpriteRenderer> _0x5a870d3e = new List<SpriteRenderer>();
    private readonly List<SpriteRenderer> _0xf833517a = new List<SpriteRenderer>();
    [SerializeField]
    private Sprite _targetGateSprite;
    private SpriteRenderer _0x3dcae67a;
    public static Color KeyColour(int _0xcb8b0c87)
    {
        if (_0xcb8b0c87 == 0)
            return _0x38a88da4._0x18999b33;
        if (_0xcb8b0c87 == 1)
            return _0x38a88da4._0x87400960;
        if (_0xcb8b0c87 == 2)
            return _0x38a88da4._0x0d81781e;
        return _0x38a88da4._0xb3ad8789;
    }

    private Sprite _0x1e3f2e51(int _0xd95e53fe)
    {
        if (_0xd95e53fe == 0)
            return this._gearOuterSprite;
        if (_0xd95e53fe == 1)
            return this._gearMidSprite;
        return this._gearInnerSprite;
    }

    [SerializeField]
    private Sprite _gearOuterSprite;
    private void _0xe14c847c()
    {
        this._0x3dcae67a = this.Spawn(this._pulsePrefab, this.transform, Vector2.zero, this._0x713fe5c2._0x013eeec8, _0x1e0444d9.PulseOrder);
        this._0x3dcae67a.color = _0x38a88da4.Fade(_0x38a88da4._0xb3ad8789, 0f);
    }

    private float _0xdf2b6ccb = 1f;
    [SerializeField]
    private GameObject _pipPrefab;
    public void _0x07b13e09(_0x9a061f9e _0xe6406562, int[] _0x6931f232)
    {
        for (int _0x7287331f = 0; _0x7287331f < _0x9a061f9e.RingCount; _0x7287331f++)
        {
            float _0x2e8cd817 = this._0x713fe5c2._0x3760e13d(_0x7287331f);
            float _0x96c99878 = _0xe6406562.NotchStep[_0x7287331f] * _0x9a061f9e.DegreesPerTooth;
            float _0x2036bd27 = _0x96c99878 * Mathf.Deg2Rad;
            this._0x798eb492[_0x7287331f].transform.localPosition = new Vector3(Mathf.Sin(_0x2036bd27) * _0x2e8cd817, Mathf.Cos(_0x2036bd27) * _0x2e8cd817, 0f);
            this._0x50957d52[_0x7287331f].localRotation = Quaternion.Euler(0f, 0f, -_0x9a061f9e.DegreesPerTooth * _0x6931f232[_0x7287331f]);
        }

        Color _0xd24af3f3 = KeyColour(_0xe6406562.KeyColourIndex);
        this._0x798eb492[0].color = _0xd24af3f3;
        this._0x798eb492[1].color = _0x38a88da4._0x689c1325;
        this._0x798eb492[2].color = _0xd24af3f3;
        this._0x8810a6da.color = _0xd24af3f3;
        Vector2 _0xdd8364d8 = this._0x713fe5c2._0x085a7cc2(this._0x713fe5c2._0x600e6fe5 * 1.02f, _0xe6406562.TargetStep * _0x9a061f9e.DegreesPerTooth);
        this._0x8810a6da.transform.position = new Vector3(_0xdd8364d8.x, _0xdd8364d8.y, 0f);
        // The gate art points DOWN at rest, i.e. at the board centre when it sits at
        // twelve o clock; rotating it with its tooth keeps it aiming at the core.
        this._0x8810a6da.transform.rotation = Quaternion.Euler(0f, 0f, -_0xe6406562.TargetStep * _0x9a061f9e.DegreesPerTooth);
        for (int _0x16230339 = 0; _0x16230339 < this._0x68e99742.Count; _0x16230339++)
        {
            int _0x5adca4de = _0xe6406562.TrayOrder[_0x16230339 % _0xe6406562.TrayOrder.Length];
            this._0x68e99742[_0x16230339].color = KeyColour(_0x5adca4de);
            float _0x5b85e110 = _0x5adca4de == _0xe6406562.KeyColourIndex ? 1f : 0.34f;
            this._0x68e99742[_0x16230339].color = _0x38a88da4.Fade(this._0x68e99742[_0x16230339].color, _0x5b85e110);
            float _0x02449db8 = _0x5adca4de == _0xe6406562.KeyColourIndex ? 1.18f : 0.9f;
            this._0x68e99742[_0x16230339].transform.localScale = Vector3.one * _0x02449db8;
        }

        // The core lock's art already carries its brass shell and violet slit, so it is
        // drawn untinted and only flashes teal when a section gives way.
        this._0x00f85c79.color = Color.white;
    }

    private void _0x223431e6()
    {
        float _0x14d3816a = this._0x713fe5c2._0x513d8b30 * 0.38f;
        float _0xb019bad4 = this._0x713fe5c2._0x4daa9efe;
        for (int _0x9f540e17 = 0; _0x9f540e17 < 4; _0x9f540e17++)
        {
            float _0xf9298d48 = (_0x9f540e17 - 1.5f) * _0x14d3816a;
            SpriteRenderer _0xeb9bd809 = this.Spawn(this._keyPrefab, this.transform, new Vector2(_0xf9298d48, _0xb019bad4), this._0x713fe5c2._0x00827b5d, _0x1e0444d9.KeyTokenOrder);
            this._0x68e99742.Add(_0xeb9bd809);
        }
    }

    private void _0x0f7cb51d()
    {
        this._0x8810a6da = this.Spawn(this._markerPrefab, this._0x455df9a0, Vector2.zero, this._0x713fe5c2._0xf822fe5a, _0x1e0444d9.TargetGateOrder);
        this._0x8810a6da.sprite = this._targetGateSprite;
    }

    private Transform _0x455df9a0;
    public void _0x89649ea0()
    {
        DOTween.Kill(this._0x00f85c79, true);
        this._0x00f85c79.DOColor(_0x38a88da4._0xb3ad8789, 0.24f).SetLoops(2, LoopType.Yoyo);
        this._0x00f85c79.transform.DOScale(this._0xdf2b6ccb * 1.22f, 0.22f).SetLoops(2, LoopType.Yoyo).SetEase(Ease.OutBack);
        for (int _0xd8ab153a = 0; _0xd8ab153a < this._0x5a870d3e.Count; _0xd8ab153a++)
        {
            SpriteRenderer _0x7fc545c3 = this._0x5a870d3e[_0xd8ab153a];
            float _0x424df925 = _0xd8ab153a * (360f / this._0x5a870d3e.Count);
            Vector2 _0x84d5f041 = this._0x713fe5c2._0x085a7cc2(this._0x713fe5c2._0x600e6fe5 * 0.62f, _0x424df925);
            _0x7fc545c3.transform.position = new Vector3(this._0x713fe5c2._0xd65a4b59.x, this._0x713fe5c2._0xd65a4b59.y, 0f);
            _0x7fc545c3.color = _0x38a88da4.Fade(_0x38a88da4._0xb3ad8789, 1f);
            DOTween.Kill(_0x7fc545c3.transform, true);
            _0x7fc545c3.transform.DOMove(new Vector3(_0x84d5f041.x, _0x84d5f041.y, 0f), 0.6f).SetEase(Ease.OutCubic);
            _0x7fc545c3.DOFade(0f, 0.6f);
        }
    }

    private readonly SpriteRenderer[] _0x10d88166 = new SpriteRenderer[_0x9a061f9e.RingCount];
    [SerializeField]
    private GameObject _markerPrefab;
    private readonly SpriteRenderer[] _0x798eb492 = new SpriteRenderer[_0x9a061f9e.RingCount];
    [SerializeField]
    private GameObject _sparkPrefab;
    private void _0x49b4b102()
    {
        for (int _0x24b39bfa = 0; _0x24b39bfa < _0x9a061f9e.RingCount; _0x24b39bfa++)
        {
            Transform _0x193e5354 = new GameObject(_0xf9b74b5f._0x2bfb47c6(new byte[9] { 150, 173, 170, 163, 148, 173, 178, 171, 176 }, 196)).transform;
            _0x193e5354.SetParent(this._0x455df9a0, false);
            _0x193e5354.localPosition = Vector3.zero;
            this._0x50957d52[_0x24b39bfa] = _0x193e5354;
            SpriteRenderer _0xa8364f73 = this.Spawn(this._gearPrefab, _0x193e5354, Vector2.zero, this._0x713fe5c2._0x2729a4e4(_0x24b39bfa), this._0x713fe5c2._0xd7a76e09(_0x24b39bfa));
            _0xa8364f73.sprite = this._0x1e3f2e51(_0x24b39bfa);
            _0xa8364f73.color = _0x24b39bfa == 1 ? new Color(0.82f, 0.82f, 0.82f, 1f) : Color.white;
            this._0x10d88166[_0x24b39bfa] = _0xa8364f73;
            SpriteRenderer _0x6937be3c = this.Spawn(this._markerPrefab, _0x193e5354, Vector2.zero, this._0x713fe5c2._0x53fe71ce, this._0x713fe5c2._0xf80e861b(_0x24b39bfa));
            this._0x798eb492[_0x24b39bfa] = _0x6937be3c;
        }
    }

    private void _0x35ad12fe()
    {
        SpriteRenderer _0x6428911b = this.Spawn(this._platePrefab, this._0x455df9a0, Vector2.zero, this._0x713fe5c2._0x94ebd3b1, _0x1e0444d9.PlateOrder);
        _0x6428911b.color = new Color(1f, 1f, 1f, 0.95f);
    }

    private void _0x2a47091a()
    {
        this._0x00f85c79 = this.Spawn(this._corePrefab, this._0x455df9a0, Vector2.zero, this._0x713fe5c2._0x543a15b4, _0x1e0444d9.CoreLockOrder);
        this._0xdf2b6ccb = this._0x00f85c79.transform.localScale.x;
    }

    [SerializeField]
    private GameObject _corePrefab;
}

internal static class _0xf9b74b5f
{
    internal static string _0x2bfb47c6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}