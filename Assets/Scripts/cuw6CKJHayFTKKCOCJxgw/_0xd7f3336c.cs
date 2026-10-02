using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The menu screen.
//
// The PLAY control is the template's own button (an EMPTY_BASE_BUTTON carrying
// LoadSceneButton with LoadSceneId 1), found BY DRIVER TYPE rather than by name and
// resized to a real 760x172 slot in the scene file per rule G.3. This script only draws
// its face - as a CHILD of the button so UGUI bubbles the click up - and never calls
// LoadSceneByIndex itself, which would load the scene twice.
//
// There is no title anywhere: the brand mark is an abstract brass ring, and every word
// on screen is functional (PLAY, SECTIONS, CREDITS, HOW TO PLAY).
public sealed class _0xd7f3336c : MonoBehaviour
{
    [SerializeField]
    private Sprite _markSprite;
    // Rule C.7: the pick changes the card frame, punches it, retints the emblem core and
    // moves the progress row - four visible answers, not one relabelled string.
    private void _0xad63ea51(int _0x4943f220)
    {
        this._0x7df60406 = Mathf.Clamp(_0x4943f220, 0, SectionCount - 1);
        _0x7b6179ac._0x1b74f841._0x0887efdd = this._0x7df60406;
        this._overlay._0xe7e4c70b(this._0x7df60406);
        this._0xb9f04a73.color = _0xbfcfaf0b.KeyColour(this._0x7df60406 % 4);
        this._0xb9f04a73.rectTransform.DOPunchScale(Vector3.one * 0.12f, 0.3f, 6, 0.7f);
        this._0x4e9aff97();
    }

    private TextMeshProUGUI _0xbdc9d595;
    private void _0x45c1a613(RectTransform _0xbc866a1e)
    {
        RectTransform _0x47c58f4e = _0xb2ebacf9.Slot(_0xbc866a1e, _0xf263a010._0xc6c5c797(new byte[9] { 230, 209, 197, 220, 196, 253, 209, 194, 219 }, 176), new Vector2(0.5f, 0.64f), new Vector2(560f, 560f));
        Image _0x55925dfb = _0xb2ebacf9.Icon(_0x47c58f4e, _0xf263a010._0xc6c5c797(new byte[8] { 116, 88, 75, 82, 107, 80, 87, 94 }, 57), this._markSprite, new Vector2(560f, 560f), Color.white);
        _0x55925dfb.rectTransform.DOLocalRotate(new Vector3(0f, 0f, -360f), EmblemSpinSeconds, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        RectTransform _0x3ebda935 = _0xb2ebacf9.Slot(_0x47c58f4e, _0xf263a010._0xc6c5c797(new byte[8] { 132, 168, 187, 162, 138, 166, 187, 172 }, 201), new Vector2(0.5f, 0.5f), new Vector2(150f, 150f));
        this._0xb9f04a73 = _0xb2ebacf9.Plate(_0x3ebda935, this._rounded, _0x38a88da4._0x0d81781e, 1.3f, false);
        float _0x79e287fa = _0x3ebda935.localScale.x;
        _0x3ebda935.DOScale(_0x79e287fa * 1.08f, 1.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    private void _0x7b1b1025()
    {
        this._overlay._0xd66851f4(this._0x7df60406, _0x7b6179ac._0x1b74f841._0x1fcee557);
    }

    private void Start()
    {
        _0x2a281dda _0x0e1d9b27 = _0x2a281dda.Instance;
        if (_0x0e1d9b27 == null || _0x0e1d9b27.Panels == null || _0xf90e3ec3._0x5f839e9d.DEFAULT >= _0x0e1d9b27.Panels.Count)
            return;
        _0x56ac1de9 _0xdbcafca1 = _0x0e1d9b27.Panels[_0xf90e3ec3._0x5f839e9d.DEFAULT];
        if (_0xdbcafca1 == null || _0xdbcafca1.Content == null)
            return;
        Transform _0xe76f5d4c = _0xdbcafca1.Content.transform;
        _0x28f514a3 _0xd3d17bf7 = new _0x28f514a3();
        _0xd3d17bf7._0x8091849a(_0x0e1d9b27, this._font);
        if (_0x7b6179ac.Instance != null)
            _0xd3d17bf7._0x858f5f9a(_0x7b6179ac.Instance.RootGameObject, _0xe76f5d4c);
        this._0x7df60406 = Mathf.Clamp(_0x7b6179ac._0x1b74f841._0x0887efdd, 0, SectionCount - 1);
        this._0x6706601b(_0xe76f5d4c);
        RectTransform _0xda99e8aa = _0xb2ebacf9.Host(_0xe76f5d4c, _0xf263a010._0xc6c5c797(new byte[11] { 69, 114, 102, 127, 103, 94, 118, 125, 102, 70, 122 }, 19));
        this._0x3fae676d(_0xda99e8aa);
        this._0x45c1a613(_0xda99e8aa);
        this._0x659a21ed(_0xda99e8aa);
        this._0x2e7b3de9(_0xda99e8aa);
        this._overlay._0x5a3dc474(_0xda99e8aa, this._rounded, this._closeIcon, this._font, _0xaf4dd36c => this._0xad63ea51(_0xaf4dd36c));
        this._0x4e9aff97();
    }

    [SerializeField]
    private Sprite _closeIcon;
    public const float EmblemSpinSeconds = 14f;
    private readonly List<Image> _0x558200ab = new List<Image>();
    private void _0x4d1d1c5e()
    {
        this._overlay._0xd74fdac5();
    }

    private void _0x6706601b(Transform _0x3f907aac)
    {
        _0x0307761a[] _0x6d5debdd = _0x3f907aac.GetComponentsInChildren<_0x0307761a>(true);
        RectTransform _0x76ff4f74 = null;
        for (int _0x6b5952b8 = 0; _0x6b5952b8 < _0x6d5debdd.Length; _0x6b5952b8++)
        {
            if (_0x6d5debdd[_0x6b5952b8].IsLoadCurrentScene || _0x6d5debdd[_0x6b5952b8].LoadSceneId != _0xf90e3ec3._0xe768a878.SCENE_1)
                continue;
            _0x76ff4f74 = _0x6d5debdd[_0x6b5952b8].GetComponent<RectTransform>();
            break;
        }

        if (_0x76ff4f74 == null)
            return;
        RectTransform _0x37f893ca = _0xb2ebacf9.Host(_0x76ff4f74, _0xf263a010._0xc6c5c797(new byte[8] { 219, 231, 234, 242, 205, 234, 232, 238 }, 139));
        Image _0xf12a8284 = _0xb2ebacf9.Plate(_0x37f893ca, this._rounded, _0x38a88da4.Fade(_0x38a88da4._0x87400960, 0.9f), MenuRoundness, true);
        _0xf12a8284.canvasRenderer.cullTransparentMesh = false;
        RectTransform _0x3b99bb0e = _0xb2ebacf9.Host(_0x37f893ca, _0xf263a010._0xc6c5c797(new byte[12] { 239, 211, 222, 198, 249, 222, 220, 218, 253, 208, 219, 198 }, 191));
        _0x3b99bb0e.offsetMin = new Vector2(6f, 6f);
        _0x3b99bb0e.offsetMax = new Vector2(-6f, -6f);
        Image _0x1d35fa1e = _0xb2ebacf9.Plate(_0x3b99bb0e, this._rounded, _0x38a88da4._0x87400960, MenuRoundness + 0.9f, false);
        _0x1d35fa1e.color = _0x38a88da4._0x87400960;
        _0xb2ebacf9.Caption(_0x3b99bb0e, _0xf263a010._0xc6c5c797(new byte[9] { 193, 253, 240, 232, 221, 240, 243, 244, 253 }, 145), this._font, _0xf263a010._0xc6c5c797(new byte[4] { 28, 0, 13, 21 }, 76), 62f, _0x38a88da4._0x689c1325, TextAlignmentOptions.Center);
        float _0xe75f5ffe = _0x37f893ca.localScale.x;
        _0x37f893ca.DOScale(_0xe75f5ffe * 1.04f, 0.9f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    private TextMeshProUGUI _0x0bc2db35;
    private void _0x3fae676d(RectTransform _0xea043b61)
    {
        RectTransform _0x0b14a14d = _0xb2ebacf9.Slot(_0xea043b61, _0xf263a010._0xc6c5c797(new byte[11] { 39, 22, 1, 0, 13, 16, 23, 39, 12, 13, 20 }, 100), new Vector2(0.20f, 0.952f), new Vector2(330f, 120f));
        RectTransform _0xaf7a638d = _0xb2ebacf9.Card(_0x0b14a14d, this._rounded, _0x38a88da4.Fade(_0x38a88da4._0x87400960, 0.45f), _0x38a88da4._0x10d9b2ed, MenuRoundness, 4f);
        RectTransform _0x66f6ae03 = _0xb2ebacf9.Slot(_0xaf7a638d, _0xf263a010._0xc6c5c797(new byte[5] { 200, 255, 242, 235, 251 }, 158), new Vector2(0.5f, 0.64f), new Vector2(280f, 66f));
        this._0xbdc9d595 = _0xb2ebacf9.Caption(_0x66f6ae03, _0xf263a010._0xc6c5c797(new byte[12] { 34, 19, 4, 5, 8, 21, 18, 55, 0, 13, 20, 4 }, 97), this._font, _0xf90e3ec3._0xcd3fadf4._0x7dacd067.ToString(), 54f, _0x38a88da4._0x87400960, TextAlignmentOptions.Center);
        RectTransform _0x2f2f464b = _0xb2ebacf9.Slot(_0xaf7a638d, _0xf263a010._0xc6c5c797(new byte[5] { 250, 215, 212, 211, 218 }, 182), new Vector2(0.5f, 0.24f), new Vector2(280f, 40f));
        _0xb2ebacf9.Caption(_0x2f2f464b, _0xf263a010._0xc6c5c797(new byte[12] { 48, 1, 22, 23, 26, 7, 0, 63, 18, 17, 22, 31 }, 115), this._font, _0xf263a010._0xc6c5c797(new byte[7] { 235, 250, 237, 236, 225, 252, 251 }, 168), 30f, _0x38a88da4._0x689c1325, TextAlignmentOptions.Center);
        Button _0xae8484cc = _0xb2ebacf9.ActionButton(_0xea043b61, _0xf263a010._0xc6c5c797(new byte[14] { 179, 133, 148, 148, 137, 142, 135, 147, 162, 149, 148, 148, 143, 142 }, 224), this._rounded, this._font, "", new Vector2(0.90f, 0.952f), new Vector2(132f, 132f), _0x38a88da4._0x83d89fbf, _0x38a88da4._0x689c1325, 34f, 2.6f);
        _0xb2ebacf9.Icon(_0xae8484cc.transform, _0xf263a010._0xc6c5c797(new byte[12] { 245, 195, 210, 210, 207, 200, 193, 213, 239, 197, 201, 200 }, 166), this._gearIcon, new Vector2(64f, 64f), Color.white);
        _0xae8484cc.onClick.AddListener(() => this._0x7b1b1025());
    }

    private Image _0xb9f04a73;
    [SerializeField]
    private _0x0902580b _overlay;
    private int _0x7df60406;
    private void _0x4e9aff97()
    {
        int _0x37143d0d = Mathf.Clamp(_0x7b6179ac._0x1b74f841._0x1fcee557, 0, SectionCount);
        for (int _0xd54b0417 = 0; _0xd54b0417 < this._0x558200ab.Count; _0xd54b0417++)
        {
            if (_0xd54b0417 < _0x37143d0d)
                this._0x558200ab[_0xd54b0417].color = _0x38a88da4._0xb3ad8789;
            else if (_0xd54b0417 == this._0x7df60406)
                this._0x558200ab[_0xd54b0417].color = _0x38a88da4._0x87400960;
            else
                this._0x558200ab[_0xd54b0417].color = _0x38a88da4._0xb491aef5;
        }

        this._0x0bc2db35.text = _0xf263a010._0xc6c5c797(new byte[9] { 93, 75, 77, 90, 71, 65, 64, 93, 46 }, 14) + _0x37143d0d + _0xf263a010._0xc6c5c797(new byte[3] { 143, 128, 143 }, 175) + SectionCount;
        this._0xbdc9d595.text = _0xf90e3ec3._0xcd3fadf4._0x7dacd067.ToString();
        this._0xb9f04a73.color = _0xbfcfaf0b.KeyColour(this._0x7df60406 % 4);
    }

    private void _0x2e7b3de9(RectTransform _0x4877c711)
    {
        Button _0xdb3b8a28 = _0xb2ebacf9.ActionButton(_0x4877c711, _0xf263a010._0xc6c5c797(new byte[14] { 23, 33, 39, 48, 45, 43, 42, 55, 6, 49, 48, 48, 43, 42 }, 68), this._rounded, this._font, _0xf263a010._0xc6c5c797(new byte[8] { 59, 45, 43, 60, 33, 39, 38, 59 }, 104), new Vector2(0.5f, 0.125f), new Vector2(620f, 132f), _0x38a88da4._0x83d89fbf, _0x38a88da4._0x689c1325, 46f, MenuRoundness);
        _0xdb3b8a28.onClick.AddListener(() => this._0x7b1b1025());
        Button _0x19840ee4 = _0xb2ebacf9.ActionButton(_0x4877c711, _0xf263a010._0xc6c5c797(new byte[11] { 138, 173, 181, 150, 173, 128, 183, 182, 182, 173, 172 }, 194), this._rounded, this._font, _0xf263a010._0xc6c5c797(new byte[11] { 78, 73, 81, 38, 82, 73, 38, 86, 74, 71, 95 }, 6), new Vector2(0.5f, 0.045f), new Vector2(520f, 104f), _0x38a88da4.Fade(_0x38a88da4._0x83d89fbf, 0.85f), _0x38a88da4._0x689c1325, 38f, MenuRoundness);
        _0x19840ee4.onClick.AddListener(() => this._0x4d1d1c5e());
    }

    private void _0x659a21ed(RectTransform _0xb96d6876)
    {
        RectTransform _0x67e28cc5 = _0xb2ebacf9.Slot(_0xb96d6876, _0xf263a010._0xc6c5c797(new byte[11] { 62, 28, 1, 9, 28, 11, 29, 29, 60, 1, 25 }, 110), new Vector2(0.5f, 0.455f), new Vector2(900f, 84f));
        for (int _0xe079bcf7 = 0; _0xe079bcf7 < SectionCount; _0xe079bcf7++)
        {
            RectTransform _0x096aff2b = _0xb2ebacf9.Slot(_0x67e28cc5, _0xf263a010._0xc6c5c797(new byte[11] { 132, 166, 187, 179, 166, 177, 167, 167, 132, 189, 164 }, 212), new Vector2(0.5f, 0.5f), new Vector2(34f, 34f));
            _0x096aff2b.anchoredPosition = new Vector2(-330f + _0xe079bcf7 * 42f, 0f);
            this._0x558200ab.Add(_0xb2ebacf9.Plate(_0x096aff2b, this._rounded, _0x38a88da4._0xb491aef5, 1.45f, false));
        }

        RectTransform _0x97ebcf98 = _0xb2ebacf9.Slot(_0x67e28cc5, _0xf263a010._0xc6c5c797(new byte[13] { 82, 112, 109, 101, 112, 103, 113, 113, 78, 99, 96, 103, 110 }, 2), new Vector2(0.5f, 0.5f), new Vector2(520f, 60f));
        _0x97ebcf98.anchoredPosition = new Vector2(180f, 0f);
        this._0x0bc2db35 = _0xb2ebacf9.Caption(_0x97ebcf98, _0xf263a010._0xc6c5c797(new byte[12] { 221, 255, 226, 234, 255, 232, 254, 254, 217, 232, 245, 249 }, 141), this._font, _0xf263a010._0xc6c5c797(new byte[14] { 212, 194, 196, 211, 206, 200, 201, 212, 167, 183, 167, 168, 167, 178 }, 135), 40f, _0x38a88da4._0x689c1325, TextAlignmentOptions.Left);
        RectTransform _0xb15b46b4 = _0xb2ebacf9.Slot(_0xb96d6876, _0xf263a010._0xc6c5c797(new byte[9] { 222, 243, 251, 244, 242, 229, 248, 231, 244 }, 145), new Vector2(0.5f, 0.375f), new Vector2(980f, 76f));
        _0xb2ebacf9.Caption(_0xb15b46b4, _0xf263a010._0xc6c5c797(new byte[13] { 162, 143, 135, 136, 142, 153, 132, 155, 136, 185, 136, 149, 153 }, 237), this._font, _0xf263a010._0xc6c5c797(new byte[24] { 70, 89, 76, 71, 41, 79, 64, 95, 76, 41, 95, 72, 92, 69, 93, 41, 90, 76, 74, 93, 64, 70, 71, 90 }, 9), 40f, _0x38a88da4._0x689c1325, TextAlignmentOptions.Center);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    public const int SectionCount = 5;
    [SerializeField]
    private Sprite _gearIcon;
    public const float MenuRoundness = 3.2f;
    [SerializeField]
    private Sprite _rounded;
}

internal static class _0xf263a010
{
    internal static string _0xc6c5c797(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}