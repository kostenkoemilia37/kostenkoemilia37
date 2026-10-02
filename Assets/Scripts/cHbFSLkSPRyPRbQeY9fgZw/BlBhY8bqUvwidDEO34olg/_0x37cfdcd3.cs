using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x37cfdcd3 : MonoBehaviour
{
    private static void ResolutionChanged()
    {
        _0xaf898daf.x = Screen.width;
        _0xaf898daf.y = Screen.height;
        _0x084ab696.Invoke();
    }

    private static void SafeAreaChanged()
    {
        _0x3e1ec9af = Screen.safeArea;
        for (int _0x11be0978 = 0; _0x11be0978 < _0x537432d4.Count; _0x11be0978++)
            _0x537432d4[_0x11be0978]._0xc28d74f5();
    }

    private static readonly List<_0x37cfdcd3> _0x537432d4 = new();
    private void Awake()
    {
        if (!_0x537432d4.Contains(this))
            _0x537432d4.Add(this);
        this._0xd274fbe7 = this.GetComponent<Canvas>();
        this._0xf9be3d4a = this.GetComponent<RectTransform>();
        this._0x57a68983 = this.transform.Find(_0xb6a90fbe._0xa6d98cd9(new byte[8] { 46, 28, 27, 24, 60, 15, 24, 28 }, 125)) as RectTransform;
        if (!_0x87fa78e8)
        {
            _0x3099afe6 = Screen.orientation;
            _0xaf898daf.x = Screen.width;
            _0xaf898daf.y = Screen.height;
            _0x3e1ec9af = Screen.safeArea;
            _0x87fa78e8 = true;
        }

        this._0xc28d74f5();
    }

    private RectTransform _0x57a68983;
    private static Vector2 _0xaf898daf = Vector2.zero;
    private static ScreenOrientation _0x3099afe6 = ScreenOrientation.LandscapeLeft;
    private void OnDestroy()
    {
        if (_0x537432d4 != null && _0x537432d4.Contains(this))
            _0x537432d4.Remove(this);
    }

    private static UnityEvent _0x084ab696 = new();
    private void Update()
    {
        if (_0x537432d4[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x3099afe6)
            OrientationChanged();
        if (Screen.safeArea != _0x3e1ec9af)
            SafeAreaChanged();
        if (Screen.width != _0xaf898daf.x || Screen.height != _0xaf898daf.y)
            ResolutionChanged();
    }

    private static void OrientationChanged()
    {
        _0x3099afe6 = Screen.orientation;
        _0xaf898daf.x = Screen.width;
        _0xaf898daf.y = Screen.height;
        _0x084ab696.Invoke();
    }

    private Canvas _0xd274fbe7;
    private static bool _0x87fa78e8;
    private RectTransform _0xf9be3d4a;
    private static Rect _0x3e1ec9af = Rect.zero;
    private void _0xc28d74f5()
    {
        if (this._0x57a68983 == null)
            return;
        Rect _0x2f341732 = Screen.safeArea;
        Vector2 _0xb64421d7 = _0x2f341732.position;
        Vector2 _0x8e829e4a = _0x2f341732.position + _0x2f341732.size;
        _0xb64421d7.x /= this._0xd274fbe7.pixelRect.width;
        _0xb64421d7.y /= this._0xd274fbe7.pixelRect.height;
        _0x8e829e4a.x /= this._0xd274fbe7.pixelRect.width;
        _0x8e829e4a.y /= this._0xd274fbe7.pixelRect.height;
        this._0x57a68983.anchorMin = _0xb64421d7;
        this._0x57a68983.anchorMax = _0x8e829e4a;
    }
}

internal static class _0xb6a90fbe
{
    internal static string _0xa6d98cd9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}