using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x4066f705 : MonoBehaviour
{
    private static readonly List<_0x4066f705> _0x3e6f430f = new();
    private Canvas _0x0a46f90a;
    private static Vector2 _0x301f9d1d = Vector2.zero;
    private void OnDestroy()
    {
        if (_0x3e6f430f != null && _0x3e6f430f.Contains(this))
            _0x3e6f430f.Remove(this);
    }

    private static Rect _0xbb38e76f = Rect.zero;
    private static void OrientationChanged()
    {
        _0x7a130a53 = Screen.orientation;
        _0x301f9d1d.x = Screen.width;
        _0x301f9d1d.y = Screen.height;
        _0xbb38e76f = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xd1782b2c.Invoke();
    }

    private void Awake()
    {
        if (!_0x3e6f430f.Contains(this))
            _0x3e6f430f.Add(this);
        this._0x0a46f90a = this.GetComponent<Canvas>();
        this._0xeb9a204b = this.GetComponent<CanvasScaler>();
        if (this._0xeb9a204b != null)
            this._0x8f883483 = this._0xeb9a204b.referenceResolution;
        this._0xe08d6bf2 = this.GetComponent<RectTransform>();
        this._0x5e459862 = this.transform.Find(_0x29db3d3f._0x1f824130(new byte[8] { 67, 113, 118, 117, 81, 98, 117, 113 }, 16)) as RectTransform;
        if (!_0xf4522319)
        {
            _0x7a130a53 = Screen.orientation;
            _0x301f9d1d.x = Screen.width;
            _0x301f9d1d.y = Screen.height;
            _0xbb38e76f = Screen.safeArea;
            _0xf4522319 = true;
        }

        this._0xd4d124a5();
    }

    private static void ResolutionChanged()
    {
        _0x301f9d1d.x = Screen.width;
        _0x301f9d1d.y = Screen.height;
        _0xbb38e76f = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xd1782b2c.Invoke();
    }

    private static UnityEvent _0xd1782b2c = new();
    private Vector2 _0x8f883483;
    private static ScreenOrientation _0x7a130a53 = ScreenOrientation.LandscapeLeft;
    private RectTransform _0x5e459862;
    private RectTransform _0xe08d6bf2;
    private static void SafeAreaChanged()
    {
        _0xbb38e76f = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private void Start()
    {
    }

    private void _0xd4d124a5()
    {
        if (this._0x5e459862 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x959b521b = Screen.safeArea;
        Vector2 _0x7cdf9c17 = _0x959b521b.position;
        Vector2 _0x00ad3dc7 = _0x959b521b.position + _0x959b521b.size;
        _0x7cdf9c17.x /= screenWidth;
        _0x7cdf9c17.y /= screenHeight;
        _0x00ad3dc7.x /= screenWidth;
        _0x00ad3dc7.y /= screenHeight;
        this._0x5e459862.anchorMin = _0x7cdf9c17;
        this._0x5e459862.anchorMax = _0x00ad3dc7;
        this._0x5e459862.offsetMin = Vector2.zero;
        this._0x5e459862.offsetMax = Vector2.zero;
        if (this._0xeb9a204b == null)
            return;
        Vector2 _0x51a65098 = _0x00ad3dc7 - _0x7cdf9c17;
        float _0x1c274995 = 2f - _0x51a65098.x;
        float _0x3d531ff3 = 2f - _0x51a65098.y;
        this._0xeb9a204b.referenceResolution = this._0x8f883483 * new Vector2(_0x1c274995, _0x3d531ff3);
    }

    private void Update()
    {
        if (_0x3e6f430f.Count == 0 || _0x3e6f430f[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x7a130a53)
            OrientationChanged();
        if (Screen.safeArea != _0xbb38e76f)
            SafeAreaChanged();
        if (Screen.width != _0x301f9d1d.x || Screen.height != _0x301f9d1d.y)
            ResolutionChanged();
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0xad3ff724 = 0; _0xad3ff724 < _0x3e6f430f.Count; _0xad3ff724++)
            _0x3e6f430f[_0xad3ff724]._0xd4d124a5();
    }

    private CanvasScaler _0xeb9a204b;
    private static bool _0xf4522319;
}

internal static class _0x29db3d3f
{
    internal static string _0x1f824130(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}