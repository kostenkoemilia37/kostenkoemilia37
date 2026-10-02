using DG.Tweening;
using TMPro;
using UnityEngine;

// The game scene's director: turns, checks, sections, and the three result pops.
//
// There is no clock anywhere in this game, by design (rule C.5). Turns and checks are
// spent by the player's taps and by nothing else, so a run left completely alone stays
// on the board indefinitely - the capture pass always finds live gameplay in frame
// instead of a result card that fired while nobody was looking.
public sealed class _0xb46f0e52 : MonoBehaviour
{
    private void _0xd38d132b()
    {
        if (_0x7b6179ac.Instance != null)
            _0x7b6179ac.Instance.LoadSceneByIndex(_0xf90e3ec3._0xe768a878.SCENE_0);
    }

    private int _0x5d9a4edd()
    {
        if (this._0x6b20f428 <= 0)
            return 0;
        return Mathf.FloorToInt(this._0x39deb815 * 100f / this._0x6b20f428);
    }

    private int _0x39deb815;
    private void Start()
    {
        this._0xfc83c4a5 = Mathf.Abs(System.Environment.TickCount);
        // The camera lives inside the scene-template prefab instance, whose fileIDs are
        // remapped per variant and cannot be wired from the scene file; the tagged main
        // camera is the template's own contract for reaching it.
        if (this._camera == null)
            this._camera = Camera.main;
        this._0xcf1f5343 = new _0x1e0444d9(this._camera);
        // The menu's section picker is a real choice, not a label: it decides which
        // section the run starts on, and the ones before it count as already cracked.
        this._0x6fe9bff5 = Mathf.Clamp(_0x7b6179ac._0x1b74f841._0x0887efdd, 0, TotalSections - 1);
        this._0x39deb815 = this._0x6fe9bff5;
        _0x28f514a3 _0x4bd22157 = new _0x28f514a3();
        _0x2a281dda _0x3b24a5b3 = _0x2a281dda.Instance;
        Transform _0xed7b7469 = null;
        if (_0x3b24a5b3 != null && _0x3b24a5b3.Panels != null && _0xf90e3ec3._0x5f839e9d.DEFAULT < _0x3b24a5b3.Panels.Count)
        {
            _0x56ac1de9 _0xe5b5a79d = _0x3b24a5b3.Panels[_0xf90e3ec3._0x5f839e9d.DEFAULT];
            if (_0xe5b5a79d != null && _0xe5b5a79d.Content != null)
                _0xed7b7469 = _0xe5b5a79d.Content.transform;
        }

        _0x4bd22157._0x312d91ce(_0xed7b7469);
        if (_0x7b6179ac.Instance != null)
            _0x4bd22157._0x858f5f9a(_0x7b6179ac.Instance.RootGameObject, _0xed7b7469);
        _0x4bd22157._0x8091849a(_0x3b24a5b3, this._font);
        if (_0xed7b7469 == null)
            return;
        RectTransform _0x5b6ff1d3 = _0xb2ebacf9.Host(_0xed7b7469, _0x5ee07168._0x684e83c4(new byte[11] { 116, 67, 87, 78, 86, 101, 67, 79, 71, 119, 75 }, 34));
        this._board._0xaf5f53d4(this._0xcf1f5343);
        this._hud._0xfcd0d2f1(_0x5b6ff1d3, this._rounded, this._font, this._backIcon, this._pauseIcon, this._camera, CheckLimit, TotalSections, _0x985f5b2b => this._0x66bb6cb2(_0x985f5b2b), () => this._0xa203a35f(), () => this._0xd38d132b(), () => this._0x5b9679b8());
        this._0xf3db58da();
        this._0x76abc1c9();
        this._hud._0x718e81ab();
    }

    private int _0x90421567;
    private void _0x96ee60a4(bool _0x3785e316)
    {
        if (this._0x47870d3f == _0x71c2f39c.Over)
            return;
        this._0x47870d3f = _0x71c2f39c.Settling;
        if (_0x3785e316)
        {
            this._0x39deb815++;
            this._board._0x89649ea0();
            this._board._0xb1be3b1c(this._0x6fe9bff5, true, false);
            this._hud._0xd7127510(this._0x39deb815, TotalSections);
            if (this._0x39deb815 >= TotalSections)
            {
                this._0x47870d3f = _0x71c2f39c.Over;
                DOVirtual.DelayedCall(FinishDelay, () => this._0x8a8091db());
                return;
            }

            this._0x6fe9bff5++;
            DOVirtual.DelayedCall(ResolveDelay, () => this._0x76abc1c9());
            return;
        }

        this._0x90421567++;
        this._hud._0xf108fe9e(this._0x90421567, CheckLimit);
        this._hud._0x56a9a474();
        this._board._0x34a034f5();
        if (this._0x90421567 >= CheckLimit)
        {
            this._0x47870d3f = _0x71c2f39c.Over;
            DOVirtual.DelayedCall(FinishDelay, () => this._0x3f04b9b5());
            return;
        }

        this._0x47870d3f = _0x71c2f39c.Ready;
        this._hud._0xc2e73fd6(true);
    }

    [SerializeField]
    private Sprite _closeIcon;
    public const float FinishDelay = 0.85f;
    [SerializeField]
    private _0xd6016162 _pops;
    private void _0x8a8091db()
    {
        _0x18dbb4f6 _0xb7716c53 = _0x18dbb4f6.Instance;
        if (_0xb7716c53 == null)
            return;
        _0xbadb97db _0x25ac59cc = _0xb7716c53._0xae857e31(_0xf90e3ec3._0xbb03596b.WIN);
        if (_0x25ac59cc == null)
            return;
        this._0x3f18eb28();
        this._pops._0x54f11518(_0xd6016162.WinSlot, _0x5ee07168._0x684e83c4(new byte[10] { 113, 102, 114, 107, 115, 7, 104, 119, 98, 105 }, 39), this._0x39deb815 + _0x5ee07168._0x684e83c4(new byte[3] { 121, 118, 121 }, 89) + TotalSections, _0x5ee07168._0x684e83c4(new byte[9] { 62, 60, 60, 42, 45, 62, 60, 38, 95 }, 127) + this._0x5d9a4edd() + _0x5ee07168._0x684e83c4(new byte[1] { 197 }, 224));
        _0xb7716c53._0x7ac038f2(_0xf90e3ec3._0xbb03596b.WIN);
    }

    private int _0x97c9db5a = TurnBudget;
    // Sections cracked is the record the menu shows; credits are the carry-over reward.
    private void _0x3f18eb28()
    {
        if (this._0x39deb815 > _0x7b6179ac._0x1b74f841._0x1fcee557)
            _0x7b6179ac._0x1b74f841._0x1fcee557 = this._0x39deb815;
        int _0x8673b49b = this._0x39deb815 * 20;
        if (_0x8673b49b > _0xf90e3ec3._0xcd3fadf4._0x7dacd067)
            _0xf90e3ec3._0xcd3fadf4._0x7dacd067 = _0x8673b49b;
    }

    private int _0xfc83c4a5;
    private readonly int[] _0x768dff3c = new int[_0x9a061f9e.RingCount];
    public const int TotalSections = 5;
    public const float ResolveDelay = 0.75f;
    private _0x71c2f39c _0x47870d3f = _0x71c2f39c.Settling;
    private int _0x6b20f428;
    private void _0xa203a35f()
    {
        if (this._0x47870d3f != _0x71c2f39c.Ready)
            return;
        this._0x47870d3f = _0x71c2f39c.Checking;
        this._0x6b20f428++;
        bool _0x5bcb9aa6 = this._0xd958f662._0xa3d7a8c6(this._0x768dff3c) == 0;
        this._hud._0xc2e73fd6(false);
        this._board._0xad93725a(this._0xd958f662.TargetStep, _0x5bcb9aa6).OnComplete(() => this._0x96ee60a4(_0x5bcb9aa6));
    }

    public const int CheckLimit = 3;
    private void _0x10856b98()
    {
        if (_0x18dbb4f6.Instance != null)
            _0x18dbb4f6.Instance._0x2fdb41ad();
    }

    [SerializeField]
    private Sprite _backIcon;
    private void _0x73f41b3e()
    {
        if (this._0x47870d3f == _0x71c2f39c.Over)
            return;
        bool _0xbb37daf2 = this._0xd958f662._0xa3d7a8c6(this._0x768dff3c) == 0;
        if (this._0x97c9db5a <= 0 && !_0xbb37daf2)
        {
            this._0x47870d3f = _0x71c2f39c.Over;
            DOVirtual.DelayedCall(FinishDelay, () => this._0x3f04b9b5());
            return;
        }

        this._0x47870d3f = _0x71c2f39c.Ready;
        this._hud._0xc2e73fd6(true);
    }

    [SerializeField]
    private Sprite _rounded;
    private void _0xf3db58da()
    {
        _0x18dbb4f6 _0xddd70965 = _0x18dbb4f6.Instance;
        if (_0xddd70965 == null || _0xddd70965.Pops == null)
            return;
        _0xbadb97db _0xbe9896e6 = _0xddd70965._0xae857e31(_0xf90e3ec3._0xbb03596b.WIN);
        this._pops._0xe33e6ea6(_0xd6016162.WinSlot, _0xbe9896e6, this._rounded, this._closeIcon, this._font, _0x5ee07168._0x684e83c4(new byte[10] { 11, 28, 8, 17, 9, 125, 18, 13, 24, 19 }, 93), _0x38a88da4._0xb3ad8789, _0x5ee07168._0x684e83c4(new byte[10] { 204, 208, 221, 197, 188, 221, 219, 221, 213, 210 }, 156), _0x5ee07168._0x684e83c4(new byte[4] { 199, 207, 196, 223 }, 138), () => this._0x6244ac53(), () => this._0xd38d132b(), () => this._0xd38d132b());
        _0xbadb97db _0x9db991dc = _0xddd70965._0xae857e31(_0xf90e3ec3._0xbb03596b.LOSE);
        this._pops._0xe33e6ea6(_0xd6016162.LoseSlot, _0x9db991dc, this._rounded, this._closeIcon, this._font, _0x5ee07168._0x684e83c4(new byte[12] { 163, 180, 160, 185, 161, 213, 166, 176, 180, 185, 176, 177 }, 245), _0x38a88da4._0x87400960, _0x5ee07168._0x684e83c4(new byte[5] { 128, 151, 134, 128, 139 }, 210), _0x5ee07168._0x684e83c4(new byte[4] { 138, 130, 137, 146 }, 199), () => this._0x6244ac53(), () => this._0xd38d132b(), () => this._0xd38d132b());
        _0xbadb97db _0xc9f13837 = _0xddd70965._0xae857e31(_0xf90e3ec3._0xbb03596b.PAUSE);
        this._pops._0xe33e6ea6(_0xd6016162.PauseSlot, _0xc9f13837, this._rounded, this._closeIcon, this._font, _0x5ee07168._0x684e83c4(new byte[4] { 150, 145, 146, 154 }, 222), _0x38a88da4._0x87400960, _0x5ee07168._0x684e83c4(new byte[6] { 37, 50, 36, 34, 58, 50 }, 119), _0x5ee07168._0x684e83c4(new byte[4] { 232, 224, 235, 240 }, 165), () => this._0x10856b98(), () => this._0xd38d132b(), () => this._0x10856b98());
    }

    private void _0x3f04b9b5()
    {
        _0x18dbb4f6 _0x29f6245b = _0x18dbb4f6.Instance;
        if (_0x29f6245b == null)
            return;
        _0xbadb97db _0x263f5992 = _0x29f6245b._0xae857e31(_0xf90e3ec3._0xbb03596b.LOSE);
        if (_0x263f5992 == null)
            return;
        this._0x3f18eb28();
        this._pops._0x54f11518(_0xd6016162.LoseSlot, _0x5ee07168._0x684e83c4(new byte[12] { 108, 123, 111, 118, 110, 26, 105, 127, 123, 118, 127, 126 }, 58), this._0x39deb815 + _0x5ee07168._0x684e83c4(new byte[3] { 155, 148, 155 }, 187) + TotalSections, _0x5ee07168._0x684e83c4(new byte[9] { 76, 78, 78, 88, 95, 76, 78, 84, 45 }, 13) + this._0x5d9a4edd() + _0x5ee07168._0x684e83c4(new byte[1] { 119 }, 82));
        _0x29f6245b._0x7ac038f2(_0xf90e3ec3._0xbb03596b.LOSE);
    }

    [SerializeField]
    private _0xcb49bbcd _hud;
    public const int TurnBudget = 26;
    [SerializeField]
    private Sprite _pauseIcon;
    [SerializeField]
    private _0xbfcfaf0b _board;
    private void _0x66bb6cb2(Vector2 _0x5eba6606)
    {
        if (this._0x47870d3f != _0x71c2f39c.Ready || this._0x97c9db5a <= 0)
            return;
        int _0x7b792a6d = this._0xcf1f5343._0x4a02c570(_0x5eba6606);
        if (_0x7b792a6d < 0)
            return;
        this._0x768dff3c[_0x7b792a6d]++;
        this._0x97c9db5a--;
        this._0x47870d3f = _0x71c2f39c.Turning;
        this._hud._0x4b893660(this._0x97c9db5a);
        this._hud._0xc2e73fd6(false);
        this._board._0xc5fd6904(_0x7b792a6d, this._0x768dff3c[_0x7b792a6d]).OnComplete(() => this._0x73f41b3e());
    }

    private enum _0x71c2f39c
    {
        Ready,
        Turning,
        Checking,
        Settling,
        Over,
    }

    private void _0x76abc1c9()
    {
        // A fresh seed per section AND per launch: two runs never present the same
        // corridor, notch spread or key colour (rule C.11).
        int _0xb9d1b3c3 = (this._0x6fe9bff5 + 1) * 7919 ^ this._0xfc83c4a5 * 104729;
        System.Random _0x01b06fa7 = new System.Random(_0xb9d1b3c3);
        this._0xd958f662 = this._0xd3108a9b._0xfae1fee0(_0x01b06fa7, this._0x6fe9bff5, this._0x97c9db5a, this._0x39ff2205);
        this._0x39ff2205 = this._0xd958f662.KeyColourIndex;
        for (int _0xac403fcc = 0; _0xac403fcc < this._0x768dff3c.Length; _0xac403fcc++)
            this._0x768dff3c[_0xac403fcc] = 0;
        this._board._0x07b13e09(this._0xd958f662, this._0x768dff3c);
        for (int _0x4bac6b32 = 0; _0x4bac6b32 < TotalSections; _0x4bac6b32++)
            this._board._0xb1be3b1c(_0x4bac6b32, _0x4bac6b32 < this._0x39deb815, _0x4bac6b32 == this._0x6fe9bff5);
        this._hud._0x4b893660(this._0x97c9db5a);
        this._hud._0xf108fe9e(this._0x90421567, CheckLimit);
        this._hud._0xd7127510(this._0x39deb815, TotalSections);
        this._hud._0xc2e73fd6(true);
        this._0x47870d3f = _0x71c2f39c.Ready;
        // A short breath on all three rings when a section comes up: the board says it
        // is waiting for a tap without a word of text.
        for (int _0xbb79e6a2 = 0; _0xbb79e6a2 < _0x9a061f9e.RingCount; _0xbb79e6a2++)
            this._board._0x8faff915(_0xbb79e6a2);
    }

    private _0x1e0444d9 _0xcf1f5343;
    [SerializeField]
    private Camera _camera;
    private void _0x6244ac53()
    {
        if (_0x7b6179ac.Instance != null)
            _0x7b6179ac.Instance._0x90d3c07b();
    }

    private readonly _0xa5bda488 _0xd3108a9b = new _0xa5bda488();
    [SerializeField]
    private TMP_FontAsset _font;
    private _0x9a061f9e _0xd958f662;
    private void _0x5b9679b8()
    {
        if (this._0x47870d3f == _0x71c2f39c.Over)
            return;
        _0x18dbb4f6 _0xa8380603 = _0x18dbb4f6.Instance;
        if (_0xa8380603 == null)
            return;
        _0xbadb97db _0xf7b52e20 = _0xa8380603._0xae857e31(_0xf90e3ec3._0xbb03596b.PAUSE);
        if (_0xf7b52e20 == null)
            return;
        this._pops._0x54f11518(_0xd6016162.PauseSlot, _0x5ee07168._0x684e83c4(new byte[4] { 133, 130, 129, 137 }, 205), _0x5ee07168._0x684e83c4(new byte[11] { 28, 29, 26, 6, 27, 104, 4, 13, 14, 28, 104 }, 72) + this._0x97c9db5a, _0x5ee07168._0x684e83c4(new byte[7] { 7, 12, 1, 7, 15, 23, 100 }, 68) + this._0x90421567 + _0x5ee07168._0x684e83c4(new byte[3] { 111, 96, 111 }, 79) + CheckLimit);
        _0xa8380603._0x7ac038f2(_0xf90e3ec3._0xbb03596b.PAUSE);
    }

    private int _0x6fe9bff5;
    private int _0x39ff2205 = -1;
}

internal static class _0x5ee07168
{
    internal static string _0x684e83c4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}