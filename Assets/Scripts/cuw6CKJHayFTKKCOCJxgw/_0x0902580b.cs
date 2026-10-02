using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The menu's two overlays: pick a starting section, and how to play.
//
// Card layout follows rule C.25 - the indicator column and the text column never share
// an x-band. Card body is 930 wide: the lock column sits in a 42-wide gutter centred 62
// from the left edge, text starts at 62 + 21 + 46 = 129 and runs 700 wide, ending at
// 829, comfortably inside the body. Every number below is that arithmetic, not a guess.
public sealed class _0x0902580b : MonoBehaviour
{
    private GameObject _0xa32f5ac6;
    private void _0x70768379(RectTransform _0x8a3be3bb, Sprite _0xf05367fb, int _0xf8245d26)
    {
        int _0x5e40a662 = 3 + _0xf8245d26 % 3;
        float _0xc4ee247f = 30f;
        for (int _0x8c3decc9 = 0; _0x8c3decc9 < _0x5e40a662; _0x8c3decc9++)
        {
            RectTransform _0xa519bce4 = _0xb2ebacf9.Slot(_0x8a3be3bb, _0x71475a11._0x7391e0a6(new byte[8] { 184, 155, 151, 159, 167, 128, 129, 144 }, 244), new Vector2(0.5f, 0.5f), new Vector2(GutterWidth * 0.7f, GutterWidth * 0.7f));
            float _0x26fa85b2 = (_0x8c3decc9 - (_0x5e40a662 - 1) * 0.5f) * _0xc4ee247f;
            _0xa519bce4.anchoredPosition = new Vector2(GutterCentre - CardWidth * 0.5f, _0x26fa85b2);
            _0xb2ebacf9.Plate(_0xa519bce4, _0xf05367fb, _0x8c3decc9 <= _0xf8245d26 ? _0x38a88da4._0x87400960 : _0x38a88da4._0xb491aef5, 1.45f, false);
        }
    }

    private readonly List<Image> _0xb5357e2b = new List<Image>();
    private GameObject _0x5f122887;
    public const float CardHeight = 196f;
    public void _0x5a3dc474(RectTransform _0xf99f3b80, Sprite _0x3ff4719a, Sprite _0x6b4081b4, TMP_FontAsset _0x1f924bb3, System.Action<int> _0x79614bdd)
    {
        RectTransform _0xba9026ed = _0xb2ebacf9.Host(_0xf99f3b80, _0x71475a11._0x7391e0a6(new byte[14] { 44, 26, 28, 11, 22, 16, 17, 48, 9, 26, 13, 19, 30, 6 }, 127));
        this._0xcc0cdb60 = _0xba9026ed.gameObject;
        Image _0xb32ba158 = _0xb2ebacf9.Plate(_0xba9026ed, _0x3ff4719a, _0x38a88da4.Fade(_0x38a88da4._0x923ac702, 0.9f), 1.3f, true);
        _0xb32ba158.canvasRenderer.cullTransparentMesh = false;
        this._0xa32f5ac6 = _0xb2ebacf9.Host(_0xba9026ed, _0x71475a11._0x7391e0a6(new byte[11] { 183, 129, 135, 144, 141, 139, 138, 180, 133, 138, 129 }, 228)).gameObject;
        this._0x5f122887 = _0xb2ebacf9.Host(_0xba9026ed, _0x71475a11._0x7391e0a6(new byte[9] { 201, 238, 246, 213, 238, 209, 224, 239, 228 }, 129)).gameObject;
        this._0xc78577e0((RectTransform)this._0xa32f5ac6.transform, _0x3ff4719a, _0x1f924bb3, _0x79614bdd);
        this._0x3c0c3c34((RectTransform)this._0x5f122887.transform, _0x3ff4719a, _0x1f924bb3);
        Button _0x7f7ecf51 = _0xb2ebacf9.ActionButton(_0xba9026ed, _0x71475a11._0x7391e0a6(new byte[12] { 239, 192, 195, 223, 201, 227, 218, 201, 222, 192, 205, 213 }, 172), _0x3ff4719a, _0x1f924bb3, _0x71475a11._0x7391e0a6(new byte[5] { 60, 51, 48, 44, 58 }, 127), new Vector2(0.5f, 0.085f), new Vector2(580f, 120f), _0x38a88da4._0x83d89fbf, _0x38a88da4._0x689c1325, 46f, CardRoundness);
        _0xb2ebacf9.Icon(_0x7f7ecf51.transform, _0x71475a11._0x7391e0a6(new byte[10] { 209, 254, 253, 225, 247, 213, 254, 235, 226, 250 }, 146), _0x6b4081b4, new Vector2(40f, 40f), Color.white);
        _0x7f7ecf51.onClick.AddListener(() => this._0xd1b59f23());
        this._0xcc0cdb60.SetActive(false);
    }

    public const float CardWidth = 930f;
    public const float GutterWidth = 42f;
    private GameObject _0xcc0cdb60;
    private int _0xb64eee2a;
    public const float GutterCentre = 62f;
    private string _0x6423328b(int _0xf0c29445)
    {
        string _0x41217c5e = string.Empty;
        for (int _0x780ddf1f = 0; _0x780ddf1f < 4; _0x780ddf1f++)
            _0x41217c5e += _0x780ddf1f <= _0xf0c29445 % 4 ? _0x71475a11._0x7391e0a6(new byte[1] { 191 }, 148) : _0x71475a11._0x7391e0a6(new byte[1] { 63 }, 18);
        return _0x41217c5e;
    }

    public void _0xd66851f4(int _0x7fd825c5, int _0xb51b3a20)
    {
        this._0xb64eee2a = _0x7fd825c5;
        this._0xa32f5ac6.SetActive(true);
        this._0x5f122887.SetActive(false);
        this._0xcc0cdb60.SetActive(true);
        this._0xe7e4c70b(_0x7fd825c5);
        // Empty state: a records column with nothing in it gets a themed line, never a
        // blank strip.
        this._0x5a704645.gameObject.SetActive(_0xb51b3a20 <= 0);
        this._0x5a704645.text = _0x71475a11._0x7391e0a6(new byte[43] { 228, 229, 138, 248, 239, 233, 229, 248, 238, 249, 138, 243, 239, 254, 138, 135, 138, 233, 248, 235, 233, 225, 138, 235, 138, 249, 239, 233, 254, 227, 229, 228, 138, 254, 229, 138, 249, 239, 254, 138, 229, 228, 239 }, 170);
    }

    public const float CardRoundness = 3.2f;
    // Rule C.7: a choice has to LOOK chosen. The frame changes colour and thickens, the
    // card punches, and the caller retints the menu emblem to match.
    public void _0xe7e4c70b(int _0xccc1837e)
    {
        this._0xb64eee2a = _0xccc1837e;
        for (int _0xef377907 = 0; _0xef377907 < this._0xb5357e2b.Count; _0xef377907++)
        {
            bool _0xe23a3055 = _0xef377907 == _0xccc1837e;
            this._0xb5357e2b[_0xef377907].color = _0xe23a3055 ? _0x38a88da4._0xb3ad8789 : _0x38a88da4.Fade(_0x38a88da4._0x87400960, 0.45f);
            this._0xc8bcbce3[_0xef377907].color = _0xe23a3055 ? _0x38a88da4._0xb3ad8789 : _0x38a88da4._0x689c1325;
        }

        if (_0xccc1837e >= 0 && _0xccc1837e < this._0xb5357e2b.Count)
            this._0xb5357e2b[_0xccc1837e].rectTransform.DOPunchScale(Vector3.one * 0.04f, 0.25f, 6, 0.7f);
    }

    private void _0x3c0c3c34(RectTransform _0xbe635e33, Sprite _0xb4fdf71a, TMP_FontAsset _0x0356d60c)
    {
        RectTransform _0xab4a59f8 = _0xb2ebacf9.Slot(_0xbe635e33, _0x71475a11._0x7391e0a6(new byte[9] { 130, 165, 189, 158, 165, 137, 171, 184, 174 }, 202), new Vector2(0.5f, 0.56f), new Vector2(960f, 1080f));
        RectTransform _0xc677f48d = _0xb2ebacf9.Card(_0xab4a59f8, _0xb4fdf71a, _0x38a88da4.Fade(_0x38a88da4._0x87400960, 0.5f), _0x38a88da4._0x10d9b2ed, CardRoundness, 5f);
        RectTransform _0xe69e06e6 = _0xb2ebacf9.Slot(_0xc677f48d, _0x71475a11._0x7391e0a6(new byte[10] { 188, 155, 131, 160, 155, 160, 157, 128, 152, 145 }, 244), new Vector2(0.5f, 0.86f), new Vector2(840f, 110f));
        _0xb2ebacf9.Caption(_0xe69e06e6, _0x71475a11._0x7391e0a6(new byte[14] { 89, 126, 102, 69, 126, 69, 120, 101, 125, 116, 69, 116, 105, 101 }, 17), _0x0356d60c, _0x71475a11._0x7391e0a6(new byte[11] { 181, 178, 170, 221, 169, 178, 221, 173, 177, 188, 164 }, 253), 62f, _0x38a88da4._0x87400960, TextAlignmentOptions.Center);
        RectTransform _0x4059170d = _0xb2ebacf9.Slot(_0xc677f48d, _0x71475a11._0x7391e0a6(new byte[9] { 113, 86, 78, 109, 86, 123, 86, 93, 64 }, 57), new Vector2(0.5f, 0.46f), new Vector2(840f, 620f));
        _0xb2ebacf9.Caption(_0x4059170d, _0x71475a11._0x7391e0a6(new byte[13] { 73, 110, 118, 85, 110, 67, 110, 101, 120, 85, 100, 121, 117 }, 1), _0x0356d60c, _0x71475a11._0x7391e0a6(new byte[186] { 10, 31, 14, 126, 31, 126, 25, 27, 31, 12, 126, 12, 23, 16, 25, 126, 10, 17, 126, 10, 11, 12, 16, 126, 23, 10, 84, 17, 16, 27, 126, 13, 10, 27, 14, 126, 29, 18, 17, 29, 21, 9, 23, 13, 27, 84, 84, 27, 31, 29, 22, 126, 10, 11, 12, 16, 126, 29, 17, 13, 10, 13, 126, 17, 16, 27, 126, 10, 11, 12, 16, 84, 24, 12, 17, 19, 126, 10, 22, 27, 126, 28, 11, 26, 25, 27, 10, 84, 84, 18, 23, 16, 27, 126, 31, 18, 18, 126, 10, 22, 12, 27, 27, 126, 19, 31, 12, 21, 13, 126, 11, 14, 84, 9, 23, 10, 22, 126, 10, 22, 27, 126, 25, 18, 17, 9, 23, 16, 25, 126, 25, 31, 10, 27, 84, 84, 10, 31, 14, 126, 12, 11, 16, 126, 14, 11, 18, 13, 27, 126, 10, 17, 126, 29, 22, 27, 29, 21, 84, 10, 22, 12, 27, 27, 126, 19, 23, 13, 13, 27, 13, 126, 13, 27, 31, 18, 126, 10, 22, 27, 126, 8, 31, 11, 18, 10 }, 94), 40f, _0x38a88da4._0x689c1325, TextAlignmentOptions.Center);
    }

    public const int SectionCount = 5;
    public void _0xd74fdac5()
    {
        this._0xa32f5ac6.SetActive(false);
        this._0x5f122887.SetActive(true);
        this._0xcc0cdb60.SetActive(true);
    }

    public const float TextLeft = 129f;
    private void _0xc78577e0(RectTransform _0x12ec8574, Sprite _0x3814556e, TMP_FontAsset _0x1013ef15, System.Action<int> _0x00da5cff)
    {
        RectTransform _0xccfd6e81 = _0xb2ebacf9.Slot(_0x12ec8574, _0x71475a11._0x7391e0a6(new byte[9] { 11, 58, 53, 62, 15, 50, 47, 55, 62 }, 91), new Vector2(0.5f, 0.875f), new Vector2(900f, 110f));
        _0xb2ebacf9.Caption(_0xccfd6e81, _0x71475a11._0x7391e0a6(new byte[13] { 239, 222, 209, 218, 235, 214, 203, 211, 218, 235, 218, 199, 203 }, 191), _0x1013ef15, _0x71475a11._0x7391e0a6(new byte[14] { 186, 172, 165, 172, 170, 189, 201, 186, 172, 170, 189, 160, 166, 167 }, 233), 68f, _0x38a88da4._0x87400960, TextAlignmentOptions.Center);
        for (int _0x59049ba0 = 0; _0x59049ba0 < SectionCount; _0x59049ba0++)
        {
            float _0xb4d103ec = 0.775f - _0x59049ba0 * 0.082f;
            RectTransform _0xa1520691 = _0xb2ebacf9.Slot(_0x12ec8574, _0x71475a11._0x7391e0a6(new byte[11] { 91, 109, 107, 124, 97, 103, 102, 75, 105, 122, 108 }, 8), new Vector2(0.5f, _0xb4d103ec), new Vector2(CardWidth, CardHeight));
            Image _0x3b23f10e = _0xb2ebacf9.Plate(_0xa1520691, _0x3814556e, _0x38a88da4.Fade(_0x38a88da4._0x87400960, 0.45f), CardRoundness, true);
            _0x3b23f10e.canvasRenderer.cullTransparentMesh = false;
            this._0xb5357e2b.Add(_0x3b23f10e);
            RectTransform _0x198d876d = _0xb2ebacf9.Host(_0xa1520691, _0x71475a11._0x7391e0a6(new byte[8] { 222, 252, 239, 249, 223, 242, 249, 228 }, 157));
            _0x198d876d.offsetMin = new Vector2(4f, 4f);
            _0x198d876d.offsetMax = new Vector2(-4f, -4f);
            _0xb2ebacf9.Plate(_0x198d876d, _0x3814556e, _0x38a88da4._0x83d89fbf, CardRoundness + 0.9f, false);
            this._0x70768379(_0x198d876d, _0x3814556e, _0x59049ba0);
            RectTransform _0x089b7892 = _0xb2ebacf9.Slot(_0x198d876d, _0x71475a11._0x7391e0a6(new byte[8] { 182, 148, 135, 145, 161, 144, 141, 129 }, 245), new Vector2(0.5f, 0.66f), new Vector2(TextWidth, 58f));
            _0x089b7892.anchoredPosition = new Vector2(TextLeft + TextWidth * 0.5f - CardWidth * 0.5f, 0f);
            TextMeshProUGUI _0x9edd20b8 = _0xb2ebacf9.Caption(_0x089b7892, _0x71475a11._0x7391e0a6(new byte[9] { 146, 176, 163, 181, 133, 184, 165, 189, 180 }, 209), _0x1013ef15, _0x71475a11._0x7391e0a6(new byte[8] { 125, 107, 109, 122, 103, 97, 96, 14 }, 46) + (_0x59049ba0 + 1), 44f, _0x38a88da4._0x689c1325, TextAlignmentOptions.Left);
            this._0xc8bcbce3.Add(_0x9edd20b8);
            RectTransform _0x99b730a3 = _0xb2ebacf9.Slot(_0x198d876d, _0x71475a11._0x7391e0a6(new byte[7] { 206, 236, 255, 233, 222, 248, 239 }, 141), new Vector2(0.5f, 0.3f), new Vector2(TextWidth, 48f));
            _0x99b730a3.anchoredPosition = new Vector2(TextLeft + TextWidth * 0.5f - CardWidth * 0.5f, 0f);
            _0xb2ebacf9.Caption(_0x99b730a3, _0x71475a11._0x7391e0a6(new byte[11] { 158, 188, 175, 185, 142, 168, 191, 137, 184, 165, 169 }, 221), _0x1013ef15, _0x71475a11._0x7391e0a6(new byte[11] { 247, 250, 245, 245, 250, 240, 230, 255, 231, 234, 147 }, 179) + this._0x6423328b(_0x59049ba0), 32f, _0x38a88da4._0x87400960, TextAlignmentOptions.Left);
            Button _0xeaa059de = _0xa1520691.gameObject.AddComponent<Button>();
            _0xeaa059de.targetGraphic = _0x3b23f10e;
            ColorBlock _0x50c26835 = _0xeaa059de.colors;
            _0x50c26835.normalColor = Color.white;
            _0x50c26835.highlightedColor = Color.white;
            _0x50c26835.pressedColor = new Color(0.75f, 0.75f, 0.75f, 1f);
            _0x50c26835.selectedColor = Color.white;
            _0x50c26835.disabledColor = new Color(0.5f, 0.5f, 0.5f, 0.6f);
            _0xeaa059de.colors = _0x50c26835;
            int _0xc94ceb5b = _0x59049ba0;
            _0xeaa059de.onClick.AddListener(() => _0x00da5cff.Invoke(_0xc94ceb5b));
        }

        RectTransform _0x8ad95859 = _0xb2ebacf9.Slot(_0x12ec8574, _0x71475a11._0x7391e0a6(new byte[9] { 43, 3, 30, 26, 23, 32, 1, 26, 11 }, 110), new Vector2(0.5f, 0.2f), new Vector2(940f, 70f));
        this._0x5a704645 = _0xb2ebacf9.Caption(_0x8ad95859, _0x71475a11._0x7391e0a6(new byte[13] { 14, 38, 59, 63, 50, 5, 36, 63, 46, 31, 46, 51, 63 }, 75), _0x1013ef15, _0x71475a11._0x7391e0a6(new byte[43] { 129, 128, 239, 157, 138, 140, 128, 157, 139, 156, 239, 150, 138, 155, 239, 226, 239, 140, 157, 142, 140, 132, 239, 142, 239, 156, 138, 140, 155, 134, 128, 129, 239, 155, 128, 239, 156, 138, 155, 239, 128, 129, 138 }, 207), 34f, _0x38a88da4._0x689c1325, TextAlignmentOptions.Center);
    }

    private TextMeshProUGUI _0x5a704645;
    public void _0xd1b59f23()
    {
        if (this._0xcc0cdb60 != null)
            this._0xcc0cdb60.SetActive(false);
    }

    public const float TextWidth = 700f;
    private readonly List<TextMeshProUGUI> _0xc8bcbce3 = new List<TextMeshProUGUI>();
}

internal static class _0x71475a11
{
    internal static string _0x7391e0a6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}