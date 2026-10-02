using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Win / Lose / Pause are dressed WHOLE, not just re-texted (rule C.3).
//
// The template's pop body carries its own card, its static "Score:" / "Reward:" rows and
// a close button whose icon Image has no sprite - which Unity draws as a plain white
// square, the exact defect that shipped on ANDROID-3247. Emptying the body and building
// an own card inside it removes all three problems at once: no leftover labels, no white
// square, and the close cross gets a real brass icon.
public sealed class _0xd6016162 : MonoBehaviour
{
    public const int LoseSlot = 1;
    public const float CardHeight = 1020f;
    private readonly TextMeshProUGUI[] _0xa79c1851 = new TextMeshProUGUI[3];
    public const int PauseSlot = 2;
    public const float PopRoundness = 3.2f;
    public const int WinSlot = 0;
    private readonly TextMeshProUGUI[] _0xacc032ec = new TextMeshProUGUI[3];
    public void _0xe33e6ea6(int _0xb7fccaa9, _0xbadb97db _0xebc1806e, Sprite _0xc4849340, Sprite _0x5cd39a4e, TMP_FontAsset _0xff6f713d, string _0x51e4dd47, Color _0x7facd062, string _0xe91a61ac, string _0x08c24005, System.Action _0xb481f9b0, System.Action _0x21639298, System.Action _0x3eb8a22d)
    {
        if (_0xebc1806e == null || _0xebc1806e.Content == null)
            return;
        Transform _0x1adfcbc0 = _0xebc1806e.Content.transform;
        for (int _0x9da41dcd = _0x1adfcbc0.childCount - 1; _0x9da41dcd >= 0; _0x9da41dcd--)
            _0x1adfcbc0.GetChild(_0x9da41dcd).gameObject.SetActive(false);
        RectTransform _0x7a1d40c8 = _0xb2ebacf9.Slot(_0x1adfcbc0, _0x6f820640._0x21151191(new byte[12] { 112, 71, 83, 74, 82, 118, 73, 86, 101, 71, 84, 66 }, 38), new Vector2(0.5f, 0.5f), new Vector2(CardWidth, CardHeight));
        RectTransform _0x9e90f252 = _0xb2ebacf9.Card(_0x7a1d40c8, _0xc4849340, _0x38a88da4.Fade(_0x38a88da4._0x87400960, 0.55f), _0x38a88da4._0x10d9b2ed, PopRoundness, 5f);
        RectTransform _0xb4ad55e0 = _0xb2ebacf9.Slot(_0x9e90f252, _0x6f820640._0x21151191(new byte[6] { 17, 60, 56, 61, 60, 43 }, 89), new Vector2(0.5f, 0.80f), new Vector2(820f, 130f));
        this._0xa79c1851[_0xb7fccaa9] = _0xb2ebacf9.Caption(_0xb4ad55e0, _0x6f820640._0x21151191(new byte[10] { 137, 164, 160, 165, 164, 179, 149, 164, 185, 181 }, 193), _0xff6f713d, _0x51e4dd47, 90f, _0x7facd062, TextAlignmentOptions.Center);
        RectTransform _0xdf451d1d = _0xb2ebacf9.Slot(_0x9e90f252, _0x6f820640._0x21151191(new byte[4] { 170, 134, 142, 137 }, 231), new Vector2(0.5f, 0.615f), new Vector2(820f, 96f));
        this._0xf60b6944[_0xb7fccaa9] = _0xb2ebacf9.Caption(_0xdf451d1d, _0x6f820640._0x21151191(new byte[8] { 247, 219, 211, 212, 238, 223, 194, 206 }, 186), _0xff6f713d, _0x6f820640._0x21151191(new byte[5] { 50, 34, 45, 34, 55 }, 2), 60f, _0x38a88da4._0x87400960, TextAlignmentOptions.Center);
        RectTransform _0xb7a9be3b = _0xb2ebacf9.Slot(_0x9e90f252, _0x6f820640._0x21151191(new byte[5] { 55, 10, 6, 0, 19 }, 114), new Vector2(0.5f, 0.495f), new Vector2(820f, 72f));
        this._0xacc032ec[_0xb7fccaa9] = _0xb2ebacf9.Caption(_0xb7a9be3b, _0x6f820640._0x21151191(new byte[9] { 48, 13, 1, 7, 20, 33, 16, 13, 1 }, 117), _0xff6f713d, _0x6f820640._0x21151191(new byte[11] { 164, 166, 166, 176, 183, 164, 166, 188, 197, 213, 192 }, 229), 40f, _0x38a88da4._0x689c1325, TextAlignmentOptions.Center);
        Button _0x7f09c6b1 = _0xb2ebacf9.ActionButton(_0x9e90f252, _0x6f820640._0x21151191(new byte[13] { 119, 85, 78, 74, 70, 85, 94, 101, 82, 83, 83, 72, 73 }, 39), _0xc4849340, _0xff6f713d, _0xe91a61ac, new Vector2(0.5f, 0.285f), new Vector2(720f, 150f), _0x38a88da4._0x87400960, _0x38a88da4._0x923ac702, 54f, PopRoundness);
        _0x7f09c6b1.onClick.AddListener(() => _0xb481f9b0.Invoke());
        Button _0x3227d73b = _0xb2ebacf9.ActionButton(_0x9e90f252, _0x6f820640._0x21151191(new byte[15] { 66, 116, 114, 126, 127, 117, 112, 99, 104, 83, 100, 101, 101, 126, 127 }, 17), _0xc4849340, _0xff6f713d, _0x08c24005, new Vector2(0.5f, 0.125f), new Vector2(720f, 122f), _0x38a88da4._0x83d89fbf, _0x38a88da4._0x689c1325, 46f, PopRoundness);
        _0x3227d73b.onClick.AddListener(() => _0x21639298.Invoke());
        Button _0x6baf5115 = _0xb2ebacf9.ActionButton(_0x7a1d40c8, _0x6f820640._0x21151191(new byte[11] { 223, 240, 243, 239, 249, 222, 233, 232, 232, 243, 242 }, 156), _0xc4849340, _0xff6f713d, "", new Vector2(0.94f, 0.955f), new Vector2(104f, 104f), _0x38a88da4._0x83d89fbf, _0x38a88da4._0x689c1325, 34f, 2.2f);
        _0xb2ebacf9.Icon(_0x6baf5115.transform, _0x6f820640._0x21151191(new byte[9] { 91, 116, 119, 107, 125, 81, 123, 119, 118 }, 24), _0x5cd39a4e, new Vector2(48f, 48f), Color.white);
        _0x6baf5115.onClick.AddListener(() => _0x3eb8a22d.Invoke());
    }

    private readonly TextMeshProUGUI[] _0xf60b6944 = new TextMeshProUGUI[3];
    public void _0x54f11518(int _0xb91ffde2, string _0xeeb8539e, string _0xe9e9eeff, string _0x74e10497)
    {
        if (this._0xa79c1851[_0xb91ffde2] != null)
            this._0xa79c1851[_0xb91ffde2].text = _0xeeb8539e;
        if (this._0xf60b6944[_0xb91ffde2] != null)
            this._0xf60b6944[_0xb91ffde2].text = _0xe9e9eeff;
        if (this._0xacc032ec[_0xb91ffde2] != null)
            this._0xacc032ec[_0xb91ffde2].text = _0x74e10497;
    }

    public const float CardWidth = 940f;
}

internal static class _0x6f820640
{
    internal static string _0x21151191(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}