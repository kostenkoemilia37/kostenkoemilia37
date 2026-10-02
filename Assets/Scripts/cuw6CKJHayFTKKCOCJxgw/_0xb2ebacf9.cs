using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Stateless builders for the runtime UGUI. Everything the game draws on top of the
// template panels goes through here, so the surface treatment (SKEUOMORPHISM: real
// plates, brass frames, sharp-ish corners) is decided once.
//
// Two traps this kit exists to avoid:
//   * a fresh GameObject with a RectTransform is 100x100 anchored at the centre, so a
//     host created and left alone resolves every child anchor against 100x100 instead
//     of the 1242x2688 canvas. Stretch() runs on every node the moment it is parented.
//   * a fully transparent Image is CULLED by the raycaster, so a hit zone at alpha 0
//     silently swallows nothing. Hit zones use a hair of alpha and turn culling off.
public static class _0xb2ebacf9
{
    public static void SetAnchor(RectTransform _0x80665300, Vector2 _0x95a1753a)
    {
        _0x80665300.anchorMin = _0x95a1753a;
        _0x80665300.anchorMax = _0x95a1753a;
    }

    // A framed card: brass ring behind, dark body inset on top. Returns the body rect,
    // which is where content goes. Background first, content later - later siblings
    // draw ON TOP (rule C.13).
    public static RectTransform Card(RectTransform _0xa52db2c5, Sprite _0xd5617906, Color _0x8fb12594, Color _0x1ffd8268, float _0xfbae17fb, float _0xf814bdc0)
    {
        Plate(_0xa52db2c5, _0xd5617906, _0x8fb12594, _0xfbae17fb, false);
        RectTransform _0x918f219d = Host(_0xa52db2c5, _0x2fdfac1d._0x9f348ea8(new byte[8] { 95, 125, 110, 120, 94, 115, 120, 101 }, 28));
        _0x918f219d.offsetMin = new Vector2(_0xf814bdc0, _0xf814bdc0);
        _0x918f219d.offsetMax = new Vector2(-_0xf814bdc0, -_0xf814bdc0);
        Plate(_0x918f219d, _0xd5617906, _0x1ffd8268, _0xfbae17fb + 0.9f, false);
        return _0x918f219d;
    }

    public static RectTransform Host(Transform _0x99154c42, string _0x0e98638c)
    {
        GameObject _0xf1094dc2 = new GameObject(_0x0e98638c, typeof(RectTransform));
        RectTransform _0xdb6bf862 = _0xf1094dc2.GetComponent<RectTransform>();
        _0xdb6bf862.SetParent(_0x99154c42, false);
        return Stretch(_0xdb6bf862);
    }

    // TMP shrinks a non-fitting line down to fontSizeMin, so the MINIMUM is the size
    // that actually ships. 28 on a 1242-wide canvas is about 24px on a 1080 screen -
    // the readability floor of rule C.12. Lines are broken by hand, never by the engine.
    public const float MinFontSize = 28f;
    public static TextMeshProUGUI Caption(Transform _0x5765c775, string _0x97c69eda, TMP_FontAsset _0xa9b3ef3e, string _0xc8d04007, float _0xb513b391, Color _0xb55eb016, TextAlignmentOptions _0xc7f2ffaf)
    {
        GameObject _0xd33d21b2 = new GameObject(_0x97c69eda, typeof(RectTransform));
        RectTransform _0x1d5e5591 = _0xd33d21b2.GetComponent<RectTransform>();
        _0x1d5e5591.SetParent(_0x5765c775, false);
        Stretch(_0x1d5e5591);
        TextMeshProUGUI _0xa4214fc6 = _0xd33d21b2.AddComponent<TextMeshProUGUI>();
        if (_0xa9b3ef3e != null)
            _0xa4214fc6.font = _0xa9b3ef3e;
        _0xa4214fc6.text = _0xc8d04007;
        _0xa4214fc6.color = _0xb55eb016;
        _0xa4214fc6.alignment = _0xc7f2ffaf;
        _0xa4214fc6.raycastTarget = false;
        _0xa4214fc6.enableWordWrapping = false;
        _0xa4214fc6.enableAutoSizing = true;
        _0xa4214fc6.fontSizeMin = MinFontSize;
        _0xa4214fc6.fontSizeMax = _0xb513b391;
        _0xa4214fc6.fontSize = _0xb513b391;
        _0xa4214fc6.overflowMode = TextOverflowModes.Overflow;
        return _0xa4214fc6;
    }

    public static RectTransform Slot(Transform _0xe5625068, string _0x8456e0ec, Vector2 _0x8acf2995, Vector2 _0x690302c1)
    {
        GameObject _0x105a7008 = new GameObject(_0x8456e0ec, typeof(RectTransform));
        RectTransform _0x52a920d8 = _0x105a7008.GetComponent<RectTransform>();
        _0x52a920d8.SetParent(_0xe5625068, false);
        _0x52a920d8.anchorMin = _0x8acf2995;
        _0x52a920d8.anchorMax = _0x8acf2995;
        _0x52a920d8.pivot = new Vector2(0.5f, 0.5f);
        _0x52a920d8.sizeDelta = _0x690302c1;
        _0x52a920d8.anchoredPosition = Vector2.zero;
        _0x52a920d8.localScale = Vector3.one;
        return _0x52a920d8;
    }

    // A real button: visible fill, a label drawn after it, and press feedback that
    // multiplies the fill's own colour so a runtime palette change survives.
    public static Button ActionButton(Transform _0x10be880d, string _0x4ca551b1, Sprite _0x0ca84cfa, TMP_FontAsset _0x43311ef9, string _0xbfc9fe16, Vector2 _0x2370f029, Vector2 _0x307c6a2d, Color _0xba2ff861, Color _0x7a30fcbc, float _0x5efbf85d, float _0xa37b0ccb)
    {
        RectTransform _0x788f5b13 = Slot(_0x10be880d, _0x4ca551b1, _0x2370f029, _0x307c6a2d);
        Image _0x603d6c41 = Plate(_0x788f5b13, _0x0ca84cfa, _0xba2ff861, _0xa37b0ccb, true);
        _0x603d6c41.canvasRenderer.cullTransparentMesh = false;
        Caption(_0x788f5b13, _0x2fdfac1d._0x9f348ea8(new byte[7] { 49, 19, 2, 6, 27, 29, 28 }, 114), _0x43311ef9, _0xbfc9fe16, _0x5efbf85d, _0x7a30fcbc, TextAlignmentOptions.Center);
        Button _0xf413408c = _0x788f5b13.gameObject.AddComponent<Button>();
        _0xf413408c.targetGraphic = _0x603d6c41;
        ColorBlock _0xfed6a5a4 = _0xf413408c.colors;
        _0xfed6a5a4.normalColor = Color.white;
        _0xfed6a5a4.highlightedColor = Color.white;
        _0xfed6a5a4.pressedColor = new Color(0.72f, 0.72f, 0.72f, 1f);
        _0xfed6a5a4.selectedColor = Color.white;
        _0xfed6a5a4.disabledColor = new Color(0.55f, 0.55f, 0.55f, 0.6f);
        _0xfed6a5a4.fadeDuration = 0.08f;
        _0xf413408c.colors = _0xfed6a5a4;
        return _0xf413408c;
    }

    public static RectTransform Stretch(RectTransform _0x67c26884)
    {
        _0x67c26884.anchorMin = Vector2.zero;
        _0x67c26884.anchorMax = Vector2.one;
        _0x67c26884.sizeDelta = Vector2.zero;
        _0x67c26884.anchoredPosition = Vector2.zero;
        _0x67c26884.localScale = Vector3.one;
        return _0x67c26884;
    }

    // A themed surface: rounded sliced plate. m_PixelsPerUnitMultiplier drives the
    // corner radius - lower is rounder - so one sprite covers every card in the game.
    public static Image Plate(RectTransform _0x83ef51ad, Sprite _0x6a56ac2f, Color _0x1ef65cf1, float _0x3e3a89c0, bool _0x4246f75a)
    {
        Image _0x00d65482 = _0x83ef51ad.gameObject.AddComponent<Image>();
        _0x00d65482.sprite = _0x6a56ac2f;
        _0x00d65482.type = Image.Type.Sliced;
        _0x00d65482.pixelsPerUnitMultiplier = _0x3e3a89c0;
        _0x00d65482.color = _0x1ef65cf1;
        _0x00d65482.raycastTarget = _0x4246f75a;
        return _0x00d65482;
    }

    public static Image Icon(Transform _0x12e6b725, string _0x5cf29583, Sprite _0x4c665ea1, Vector2 _0x87257258, Color _0x066aef14)
    {
        GameObject _0x6923f11f = new GameObject(_0x5cf29583, typeof(RectTransform));
        RectTransform _0x58723fbe = _0x6923f11f.GetComponent<RectTransform>();
        _0x58723fbe.SetParent(_0x12e6b725, false);
        _0x58723fbe.anchorMin = new Vector2(0.5f, 0.5f);
        _0x58723fbe.anchorMax = new Vector2(0.5f, 0.5f);
        _0x58723fbe.sizeDelta = _0x87257258;
        _0x58723fbe.anchoredPosition = Vector2.zero;
        _0x58723fbe.localScale = Vector3.one;
        Image _0x157ed78c = _0x6923f11f.AddComponent<Image>();
        _0x157ed78c.sprite = _0x4c665ea1;
        _0x157ed78c.preserveAspect = true;
        _0x157ed78c.color = _0x066aef14;
        _0x157ed78c.raycastTarget = false;
        return _0x157ed78c;
    }

    // A tap surface that the GraphicRaycaster can actually see. Alpha 0 plus the
    // default cullTransparentMesh means no mesh is submitted and no click ever lands.
    public static Image HitZone(RectTransform _0x8220d513)
    {
        Image _0x65f9d028 = _0x8220d513.gameObject.AddComponent<Image>();
        _0x65f9d028.color = new Color(1f, 1f, 1f, 0.004f);
        _0x65f9d028.raycastTarget = true;
        _0x65f9d028.canvasRenderer.cullTransparentMesh = false;
        return _0x65f9d028;
    }
}

internal static class _0x2fdfac1d
{
    internal static string _0x9f348ea8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}