using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The game screen's own UGUI: top bar (BACK / TURNS / PAUSE), two indicator chips, the
// permanent control hint and the RUN PULSE button.
//
// None of the template's HUD is reused - VaultTemplateDress switches it off - because
// its chrome belongs to a different game. Everything here is built at runtime inside
// the template's own DefaultPanel body, so it inherits the canvas, the scaler and the
// safe area without adding a second canvas (which would tie with the pops' order and
// bury them, rule C.3).
public sealed class _0xcb49bbcd : MonoBehaviour
{
    public const float ChipHeight = 110f;
    private void _0xdc1b6b02(RectTransform _0xbd9c7efe, Sprite _0xdb2d0e94, int _0x23163ca5, List<Image> _0x28e5d24a)
    {
        float _0x2d8724a2 = _0x23163ca5 > 1 ? GutterWidth / _0x23163ca5 : 0f;
        for (int _0x72d5d70a = 0; _0x72d5d70a < _0x23163ca5; _0x72d5d70a++)
        {
            float _0xc72c3398 = GutterCentre - ChipWidth * 0.5f + (_0x72d5d70a - (_0x23163ca5 - 1) * 0.5f) * _0x2d8724a2;
            RectTransform _0xee399396 = _0xb2ebacf9.Slot(_0xbd9c7efe, _0xc60ef990._0xa87924ba(new byte[3] { 12, 53, 44 }, 92), new Vector2(0.5f, 0.5f), new Vector2(PipSize, PipSize));
            _0xee399396.anchoredPosition = new Vector2(_0xc72c3398, 0f);
            Image _0x115cfbc7 = _0xb2ebacf9.Plate(_0xee399396, _0xdb2d0e94, _0x38a88da4._0xb491aef5, 1.45f, false);
            _0x28e5d24a.Add(_0x115cfbc7);
        }
    }

    // Rule C.25: the indicator column and the text column never share an x-band.
    // Chip body 520 wide: pips live in a 150-wide gutter centred 54 from the left edge,
    // text starts at 54 + 75 + 26 = 155 and runs 370 wide, ending at 525 - inside the
    // body with room to spare. Values are in the 1242x2688 canvas units.
    public const float ChipWidth = 520f;
    public const float GutterWidth = 150f;
    private void _0x81d75af7(RectTransform _0x9e731265, Sprite _0x2cf1c8ad, TMP_FontAsset _0x4702b559, Sprite _0x03f0ecf1, Sprite _0x7df286ef, System.Action _0x35d734c9, System.Action _0x1ae8466d)
    {
        this._0x9c78b986 = _0xb2ebacf9.Slot(_0x9e731265, _0xc60ef990._0xa87924ba(new byte[9] { 33, 0, 7, 27, 6, 54, 29, 28, 5 }, 117), new Vector2(0.5f, 0.952f), new Vector2(430f, 132f));
        RectTransform _0x28c7e02f = _0xb2ebacf9.Card(this._0x9c78b986, _0x2cf1c8ad, _0x38a88da4._0x87400960, _0x38a88da4._0x10d9b2ed, Roundness, 4f);
        RectTransform _0x773831f7 = _0xb2ebacf9.Slot(_0x28c7e02f, _0xc60ef990._0xa87924ba(new byte[5] { 103, 80, 93, 68, 84 }, 49), new Vector2(0.62f, 0.5f), new Vector2(200f, 76f));
        this._0xc9dcb29c = _0xb2ebacf9.Caption(_0x773831f7, _0xc60ef990._0xa87924ba(new byte[10] { 161, 128, 135, 155, 134, 163, 148, 153, 128, 144 }, 245), _0x4702b559, _0xc60ef990._0xa87924ba(new byte[1] { 109 }, 93), 56f, _0x38a88da4._0x87400960, TextAlignmentOptions.Left);
        RectTransform _0x4a9007f6 = _0xb2ebacf9.Slot(_0x28c7e02f, _0xc60ef990._0xa87924ba(new byte[5] { 231, 202, 201, 206, 199 }, 171), new Vector2(0.28f, 0.5f), new Vector2(190f, 48f));
        _0xb2ebacf9.Caption(_0x4a9007f6, _0xc60ef990._0xa87924ba(new byte[10] { 220, 253, 250, 230, 251, 196, 233, 234, 237, 228 }, 136), _0x4702b559, _0xc60ef990._0xa87924ba(new byte[5] { 21, 20, 19, 15, 18 }, 65), 30f, _0x38a88da4._0x689c1325, TextAlignmentOptions.Right);
        Button _0x108e917a = _0xb2ebacf9.ActionButton(_0x9e731265, _0xc60ef990._0xa87924ba(new byte[10] { 60, 31, 29, 21, 60, 11, 10, 10, 17, 16 }, 126), _0x2cf1c8ad, _0x4702b559, "", new Vector2(0.10f, 0.952f), new Vector2(132f, 132f), _0x38a88da4._0x83d89fbf, _0x38a88da4._0x689c1325, 34f, 2.6f);
        _0xb2ebacf9.Icon(_0x108e917a.transform, _0xc60ef990._0xa87924ba(new byte[8] { 218, 249, 251, 243, 209, 251, 247, 246 }, 152), _0x03f0ecf1, new Vector2(64f, 64f), Color.white);
        _0x108e917a.onClick.AddListener(() => _0x35d734c9.Invoke());
        Button _0x2aaa3fcc = _0xb2ebacf9.ActionButton(_0x9e731265, _0xc60ef990._0xa87924ba(new byte[11] { 73, 120, 108, 106, 124, 91, 108, 109, 109, 118, 119 }, 25), _0x2cf1c8ad, _0x4702b559, "", new Vector2(0.90f, 0.952f), new Vector2(132f, 132f), _0x38a88da4._0x83d89fbf, _0x38a88da4._0x689c1325, 34f, 2.6f);
        _0xb2ebacf9.Icon(_0x2aaa3fcc.transform, _0xc60ef990._0xa87924ba(new byte[9] { 109, 92, 72, 78, 88, 116, 94, 82, 83 }, 61), _0x7df286ef, new Vector2(60f, 60f), Color.white);
        _0x2aaa3fcc.onClick.AddListener(() => _0x1ae8466d.Invoke());
    }

    public void _0xd7127510(int _0xb5b30d55, int _0x4cdd7efd)
    {
        this._0xde4f2b9b.text = _0xb5b30d55 + _0xc60ef990._0xa87924ba(new byte[3] { 157, 146, 157 }, 189) + _0x4cdd7efd;
        for (int _0xf285a065 = 0; _0xf285a065 < this._0x3c221572.Count; _0xf285a065++)
            this._0x3c221572[_0xf285a065].color = _0xf285a065 < _0xb5b30d55 ? _0x38a88da4._0xb3ad8789 : _0x38a88da4._0xb491aef5;
    }

    private TextMeshProUGUI _0x399a7f05(RectTransform _0x2c219109, TMP_FontAsset _0xf93dbb2e, string _0x31e6ce5a)
    {
        RectTransform _0x443448b8 = _0xb2ebacf9.Slot(_0x2c219109, _0xc60ef990._0xa87924ba(new byte[5] { 81, 102, 107, 114, 98 }, 7), new Vector2(0.5f, 0.5f), new Vector2(TextWidth, 56f));
        _0x443448b8.anchoredPosition = new Vector2(TextLeft + TextWidth * 0.5f - ChipWidth * 0.5f, 0f);
        return _0xb2ebacf9.Caption(_0x443448b8, _0xc60ef990._0xa87924ba(new byte[9] { 176, 155, 154, 131, 165, 146, 159, 134, 150 }, 243), _0xf93dbb2e, _0x31e6ce5a, 34f, _0x38a88da4._0x689c1325, TextAlignmentOptions.Center);
    }

    public _0xfede3e32 _0xd9749dd2
    {
        get
        {
            return this._0x92eee1df;
        }
    }

    public void _0x4b893660(int _0x61e57e7d)
    {
        this._0xc9dcb29c.text = _0x61e57e7d.ToString();
        if (this._0x9c78b986 != null)
            this._0x9c78b986.DOPunchScale(Vector3.one * 0.08f, 0.2f, 6, 0.7f);
    }

    public const float TextWidth = 370f;
    private RectTransform _0x9c78b986;
    public const float TextLeft = 155f;
    private TextMeshProUGUI _0xde1aef23;
    private Button _0x7feeb19b;
    public void _0xf108fe9e(int _0x89024b7b, int _0x12f39ab8)
    {
        this._0xb1b5dcde.text = _0x89024b7b + _0xc60ef990._0xa87924ba(new byte[3] { 219, 212, 219 }, 251) + _0x12f39ab8;
        for (int _0x93c30c67 = 0; _0x93c30c67 < this._0xdf469199.Count; _0x93c30c67++)
            this._0xdf469199[_0x93c30c67].color = _0x93c30c67 < _0x89024b7b ? _0x38a88da4._0x18999b33 : _0x38a88da4._0xb491aef5;
    }

    private Image _0xf152fd40;
    public const float GutterCentre = 54f;
    private _0xfede3e32 _0x92eee1df;
    public const float Roundness = 3.2f;
    private void _0xe8a6aefa(RectTransform _0x4fd46f84, Sprite _0x20061f0f, TMP_FontAsset _0xa2f31ddd, int _0x76e1735e, int _0xa823eedc)
    {
        RectTransform _0xbf2c8f58 = _0xb2ebacf9.Slot(_0x4fd46f84, _0xc60ef990._0xa87924ba(new byte[10] { 111, 68, 73, 79, 71, 95, 111, 68, 69, 92 }, 44), new Vector2(0.272f, 0.878f), new Vector2(ChipWidth, ChipHeight));
        RectTransform _0x24518630 = _0xb2ebacf9.Card(_0xbf2c8f58, _0x20061f0f, _0x38a88da4.Fade(_0x38a88da4._0x87400960, 0.4f), _0x38a88da4._0x10d9b2ed, Roundness, 3f);
        this._0xdc1b6b02(_0x24518630, _0x20061f0f, _0x76e1735e, this._0xdf469199);
        this._0xb1b5dcde = this._0x399a7f05(_0x24518630, _0xa2f31ddd, _0xc60ef990._0xa87924ba(new byte[11] { 60, 55, 58, 60, 52, 44, 95, 79, 95, 80, 95 }, 127) + _0x76e1735e);
        RectTransform _0xb96ac178 = _0xb2ebacf9.Slot(_0x4fd46f84, _0xc60ef990._0xa87924ba(new byte[12] { 10, 60, 58, 45, 48, 54, 55, 42, 26, 49, 48, 41 }, 89), new Vector2(0.728f, 0.878f), new Vector2(ChipWidth, ChipHeight));
        RectTransform _0x5c6376c7 = _0xb2ebacf9.Card(_0xb96ac178, _0x20061f0f, _0x38a88da4.Fade(_0x38a88da4._0x87400960, 0.4f), _0x38a88da4._0x10d9b2ed, Roundness, 3f);
        this._0xdc1b6b02(_0x5c6376c7, _0x20061f0f, _0xa823eedc, this._0x3c221572);
        this._0xde4f2b9b = this._0x399a7f05(_0x5c6376c7, _0xa2f31ddd, _0xc60ef990._0xa87924ba(new byte[13] { 204, 218, 220, 203, 214, 208, 209, 204, 191, 175, 191, 176, 191 }, 159) + _0xa823eedc);
    }

    private Image _0x2a878995;
    public void _0x56a9a474()
    {
        if (this._0xf152fd40 == null)
            return;
        Image _0xabc69d37 = this._0xf152fd40;
        DOTween.Kill(_0xabc69d37, true);
        _0xabc69d37.color = _0x38a88da4.Fade(_0x38a88da4._0x18999b33, 0f);
        _0xabc69d37.DOFade(0.35f, 0.18f).SetLoops(2, LoopType.Yoyo);
    }

    private TextMeshProUGUI _0xb1b5dcde;
    public void _0xfcd0d2f1(RectTransform _0x61a62d53, Sprite _0x34f8cdc2, TMP_FontAsset _0xb6427a3a, Sprite _0x4f5dfa6b, Sprite _0xf7b9c737, Camera _0x0bf16eba, int _0x96d27646, int _0x79ce30e3, System.Action<Vector2> _0x7d3fcc0d, System.Action _0xc7c55cd0, System.Action _0xe4f35ee2, System.Action _0xefcc4fea)
    {
        // First child = lowest raycast priority, so every button added below wins its
        // own taps and only the leftovers reach the board.
        RectTransform _0x75314677 = _0xb2ebacf9.Host(_0x61a62d53, _0xc60ef990._0xa87924ba(new byte[13] { 41, 4, 10, 25, 15, 63, 10, 27, 45, 2, 14, 7, 15 }, 107));
        _0xb2ebacf9.HitZone(_0x75314677);
        this._0x92eee1df = _0x75314677.gameObject.AddComponent<_0xfede3e32>();
        this._0x92eee1df._0x32f0afb9(_0x0bf16eba, _0x7d3fcc0d);
        this._0x81d75af7(_0x61a62d53, _0x34f8cdc2, _0xb6427a3a, _0x4f5dfa6b, _0xf7b9c737, _0xe4f35ee2, _0xefcc4fea);
        this._0xe8a6aefa(_0x61a62d53, _0x34f8cdc2, _0xb6427a3a, _0x96d27646, _0x79ce30e3);
        this._0x6807a16a(_0x61a62d53, _0x34f8cdc2, _0xb6427a3a);
        this._0x5e500026(_0x61a62d53, _0x34f8cdc2, _0xb6427a3a, _0xc7c55cd0);
        // Added LAST so it covers everything, and with no raycast target so it swallows
        // nothing: hierarchy order IS draw order in UGUI (rule C.13).
        RectTransform _0xfafa48a4 = _0xb2ebacf9.Host(_0x61a62d53, _0xc60ef990._0xa87924ba(new byte[9] { 97, 70, 78, 75, 97, 75, 70, 84, 79 }, 39));
        this._0xf152fd40 = _0xfafa48a4.gameObject.AddComponent<Image>();
        this._0xf152fd40.color = _0x38a88da4.Fade(_0x38a88da4._0x18999b33, 0f);
        this._0xf152fd40.raycastTarget = false;
    }

    private readonly List<Image> _0x3c221572 = new List<Image>();
    private readonly List<Image> _0xdf469199 = new List<Image>();
    private TextMeshProUGUI _0xc9dcb29c;
    private TextMeshProUGUI _0xde4f2b9b;
    // The hint names the gesture AND its result, and it never leaves the screen - it
    // only settles back to a quieter alpha, so it is still in every review frame
    // (rule C.6).
    public void _0x718e81ab()
    {
        if (this._0xde1aef23 == null)
            return;
        TextMeshProUGUI _0x2ccf66f4 = this._0xde1aef23;
        DOTween.To(() => _0x2ccf66f4.alpha, _0x8007a8bf => _0x2ccf66f4.alpha = _0x8007a8bf, 0.55f, 0.6f).SetDelay(12f);
    }

    private void _0x5e500026(RectTransform _0x8be9156c, Sprite _0xfc0241b0, TMP_FontAsset _0x10060476, System.Action _0x2f488c7a)
    {
        this._0x7feeb19b = _0xb2ebacf9.ActionButton(_0x8be9156c, _0xc60ef990._0xa87924ba(new byte[14] { 246, 209, 202, 244, 209, 200, 215, 193, 230, 209, 208, 208, 203, 202 }, 164), _0xfc0241b0, _0x10060476, _0xc60ef990._0xa87924ba(new byte[9] { 122, 125, 102, 8, 120, 125, 100, 123, 109 }, 40), new Vector2(0.5f, 0.125f), new Vector2(820f, 176f), _0x38a88da4._0xb3ad8789, _0x38a88da4._0x689c1325, 58f, Roundness);
        this._0x2a878995 = this._0x7feeb19b.targetGraphic as Image;
        this._0x7feeb19b.onClick.AddListener(() => _0x2f488c7a.Invoke());
    }

    public const float PipSize = 26f;
    private void _0x6807a16a(RectTransform _0xb67f2861, Sprite _0x051fb32d, TMP_FontAsset _0x017d85d0)
    {
        RectTransform _0x851c44cc = _0xb2ebacf9.Slot(_0xb67f2861, _0xc60ef990._0xa87924ba(new byte[7] { 146, 179, 180, 174, 152, 187, 168 }, 218), new Vector2(0.5f, 0.205f), new Vector2(1040f, 78f));
        _0xb2ebacf9.Plate(_0x851c44cc, _0x051fb32d, _0x38a88da4.Fade(_0x38a88da4._0x923ac702, 0.62f), 2.6f, false);
        this._0xde1aef23 = _0xb2ebacf9.Caption(_0x851c44cc, _0xc60ef990._0xa87924ba(new byte[8] { 15, 46, 41, 51, 19, 34, 63, 51 }, 71), _0x017d85d0, _0xc60ef990._0xa87924ba(new byte[60] { 79, 90, 75, 59, 90, 59, 92, 94, 90, 73, 59, 73, 82, 85, 92, 59, 79, 84, 59, 79, 78, 73, 85, 59, 82, 79, 17, 87, 82, 85, 94, 59, 78, 75, 59, 79, 83, 94, 59, 86, 90, 73, 80, 72, 55, 59, 79, 83, 94, 85, 59, 73, 78, 85, 59, 75, 78, 87, 72, 94 }, 27), 38f, _0x38a88da4._0x689c1325, TextAlignmentOptions.Center);
    }

    public void _0xc2e73fd6(bool _0xa92d9225)
    {
        this._0x7feeb19b.interactable = _0xa92d9225;
        this._0x2a878995.color = _0xa92d9225 ? _0x38a88da4._0xb3ad8789 : _0x38a88da4.Fade(_0x38a88da4._0x96816075, 0.45f);
    }
}

internal static class _0xc60ef990
{
    internal static string _0xa87924ba(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}