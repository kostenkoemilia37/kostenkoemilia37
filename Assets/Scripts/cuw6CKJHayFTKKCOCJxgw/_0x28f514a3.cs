using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Takes the template's own chrome off the screen before this game draws its own.
//
// The scene template ships a HUD for a different game: TopPanel with its two icon
// buttons, a timer plate, a coin pill and a score row. Left on, they sit behind the
// vault board as stray placeholders, and two of them (LEFT_BUTTON / RIGHT_BUTTON) point
// at icon sprites that are not in the project at all - white squares in the shipped
// build. Everything is reached BY TYPE through public template members, never by name,
// so it survives obfuscation.
public sealed class _0x28f514a3
{
    private bool Protected(Transform _0x1c051cc0)
    {
        if (this._0xe0190bff == null || _0x1c051cc0 == null)
            return false;
        return _0x1c051cc0 == this._0xe0190bff || this._0xe0190bff.IsChildOf(_0x1c051cc0);
    }

    // `keep` is the panel body this game builds its own UI into. A template HUD label can
    // be a DIRECT child of that body, and the "hide the container one level up" step below
    // would then switch off the whole panel - this game included. Nothing at or above
    // `keep` is ever touched.
    public void _0x858f5f9a(GameObject _0x6bf85a82, Transform _0x5edcd70f)
    {
        if (_0x6bf85a82 == null)
            return;
        this._0xe0190bff = _0x5edcd70f;
        _0xa7f7d855[] _0xad1c203d = _0x6bf85a82.GetComponentsInChildren<_0xa7f7d855>(true);
        for (int _0x64a9e9c2 = 0; _0x64a9e9c2 < _0xad1c203d.Length; _0x64a9e9c2++)
            this.HideOutsidePops(_0xad1c203d[_0x64a9e9c2].gameObject, false);
        _0x6bde820d _0x4f368225 = _0x6bf85a82.GetComponentInChildren<_0x6bde820d>(true);
        if (_0x4f368225 == null)
            return;
        this._0x94abf4ef(_0x4f368225.TimerText);
        this._0x94abf4ef(_0x4f368225.ScoreText);
        this._0x94abf4ef(_0x4f368225.SubtitleText);
        this._0x94abf4ef(_0x4f368225.LevelNumberText);
        this._0xe7bd9630(_0x4f368225.HomeButtons);
        this._0xe7bd9630(_0x4f368225.PauseButtons);
    }

    // Hiding the label alone leaves its plate behind, so for HUD rows the container one
    // level up goes off instead - that is what removes TopPanel and the timer plate.
    private void HideOutsidePops(GameObject _0xb761bcd0, bool _0xd28128fe)
    {
        if (_0xb761bcd0 == null)
            return;
        if (_0xb761bcd0.GetComponentInParent<_0xbadb97db>(true) != null)
            return;
        Transform _0x53b38212 = _0xb761bcd0.transform;
        if (this.Protected(_0x53b38212))
            return;
        if (_0xd28128fe && _0x53b38212.parent != null && _0x53b38212.parent.parent != null && !this.Protected(_0x53b38212.parent))
            _0x53b38212 = _0x53b38212.parent;
        if (_0x53b38212.GetComponentInChildren<_0xbadb97db>(true) != null)
            return;
        _0x53b38212.gameObject.SetActive(false);
    }

    private void _0x94abf4ef(System.Collections.Generic.List<TMP_Text> _0x9fae4c92)
    {
        if (_0x9fae4c92 == null)
            return;
        for (int _0xe838a3f1 = 0; _0xe838a3f1 < _0x9fae4c92.Count; _0xe838a3f1++)
            if (_0x9fae4c92[_0xe838a3f1] != null)
                this.HideOutsidePops(_0x9fae4c92[_0xe838a3f1].gameObject, true);
    }

    private void _0xe7bd9630(System.Collections.Generic.List<Button> _0xbbe1b400)
    {
        if (_0xbbe1b400 == null)
            return;
        for (int _0x2fccf663 = 0; _0x2fccf663 < _0xbbe1b400.Count; _0x2fccf663++)
            if (_0xbbe1b400[_0x2fccf663] != null)
                this.HideOutsidePops(_0xbbe1b400[_0x2fccf663].gameObject, false);
    }

    // Empty the panel body, but never touch a branch that carries a Pop: the win / lose
    // / pause cards live there and switching them off leaves the player with no result
    // screen at all.
    public void _0x312d91ce(Transform _0x03895bf8)
    {
        if (_0x03895bf8 == null)
            return;
        for (int _0x830f8e0e = _0x03895bf8.childCount - 1; _0x830f8e0e >= 0; _0x830f8e0e--)
        {
            Transform _0x66954c7d = _0x03895bf8.GetChild(_0x830f8e0e);
            if (_0x66954c7d.GetComponentInChildren<_0xbadb97db>(true) != null)
                continue;
            _0x66954c7d.gameObject.SetActive(false);
        }
    }

    public void _0x8091849a(_0x2a281dda _0xf2d17610, TMP_FontAsset _0x2bcb99f6)
    {
        if (_0xf2d17610 == null || _0xf2d17610.Panels == null)
            return;
        int[] _0xa528d312 = this._0x4bbc64ef();
        string[] _0x65db0bfb = new string[]
        {
            _0xef340a58._0x1c48e368(new byte[35] { 8, 29, 12, 124, 29, 124, 27, 25, 29, 14, 124, 14, 21, 18, 27, 124, 8, 19, 124, 8, 9, 14, 18, 124, 21, 8, 124, 19, 18, 25, 124, 15, 8, 25, 12 }, 92),
            _0xef340a58._0x1c48e368(new byte[51] { 158, 155, 156, 151, 242, 134, 154, 151, 242, 159, 147, 128, 153, 129, 242, 135, 130, 242, 133, 155, 134, 154, 242, 134, 154, 151, 242, 149, 147, 134, 151, 254, 216, 134, 154, 151, 156, 242, 134, 147, 130, 242, 128, 135, 156, 242, 130, 135, 158, 129, 151 }, 210),
            "",
            "",
            "",
            "",
            "",
        };
        for (int _0x49344557 = 0; _0x49344557 < _0xa528d312.Length; _0x49344557++)
        {
            int _0x8cd7f069 = _0xa528d312[_0x49344557];
            if (_0x8cd7f069 < 0 || _0x8cd7f069 >= _0xf2d17610.Panels.Count)
                continue;
            _0x56ac1de9 _0xbe0ebb65 = _0xf2d17610.Panels[_0x8cd7f069];
            if (_0xbe0ebb65 == null)
                continue;
            TMP_Text[] _0xb54b2090 = _0xbe0ebb65.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x5a09f4bf = 0; _0x5a09f4bf < _0xb54b2090.Length; _0x5a09f4bf++)
            {
                _0xb54b2090[_0x5a09f4bf].text = _0x5a09f4bf == 0 ? _0x65db0bfb[_0x49344557] : string.Empty;
                _0xb54b2090[_0x5a09f4bf].color = _0x38a88da4._0x689c1325;
                if (_0x2bcb99f6 != null)
                    _0xb54b2090[_0x5a09f4bf].font = _0x2bcb99f6;
            }
        }
    }

    // Panels the template declares for a tutorial flow this game does not run. They are
    // still blanked: an unused panel keeps the template's filler wording, and a filler
    // string that reaches a store build is exactly the ANDROID-3578 defect (rule C.15).
    public int[] _0x4bbc64ef()
    {
        return new int[]
        {
            _0xf90e3ec3._0x5f839e9d.TUTORIAL0,
            _0xf90e3ec3._0x5f839e9d.TUTORIAL1,
            _0xf90e3ec3._0x5f839e9d.TUTORIAL2,
            _0xf90e3ec3._0x5f839e9d.TUTORIAL3,
            _0xf90e3ec3._0x5f839e9d.TUTORIAL4,
            _0xf90e3ec3._0x5f839e9d.TUTORIAL5,
            _0xf90e3ec3._0x5f839e9d.TUTORIAL6,
        };
    }

    private Transform _0xe0190bff;
}

internal static class _0xef340a58
{
    internal static string _0x1c48e368(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}