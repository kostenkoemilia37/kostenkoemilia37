using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x03b4cd44 : MonoBehaviour
{
    private static _0x03b4cd44 _0x9e4e5e0c;
    private static float Ratio(Color _0x9dce3752, Color _0x1da559a6)
    {
        float _0x8cb47b8f = Luminance(_0x9dce3752);
        float _0xcbe1c2ad = Luminance(_0x1da559a6);
        return (Mathf.Max(_0x8cb47b8f, _0xcbe1c2ad) + 0.05f) / (Mathf.Min(_0x8cb47b8f, _0xcbe1c2ad) + 0.05f);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x9e4e5e0c != null)
            return;
        GameObject _0x888a446a = new GameObject(_0xa6d3a40f._0xf8b6ad20(new byte[16] { 133, 188, 161, 146, 190, 191, 165, 163, 176, 162, 165, 150, 164, 176, 163, 181 }, 209));
        _0x888a446a.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x888a446a);
        _0x9e4e5e0c = _0x888a446a.AddComponent<_0x03b4cd44>();
    }

    private readonly List<TMP_Text> _0xd20ed06e = new List<TMP_Text>();
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x96d9f821;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x868e46fa)
    {
        return 0.2126f * Linear(_0x868e46fa.r) + 0.7152f * Linear(_0x868e46fa.g) + 0.0722f * Linear(_0x868e46fa.b);
    }

    private const float MinOutlineWidth = 0.01f;
    private void OnDisable()
    {
        if (this._0x96d9f821 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x96d9f821);
    }

    private static float Linear(float _0x33c737f4)
    {
        _0x33c737f4 = Mathf.Clamp01(_0x33c737f4);
        return _0x33c737f4 <= 0.03928f ? _0x33c737f4 / 12.92f : Mathf.Pow((_0x33c737f4 + 0.055f) / 1.055f, 2.4f);
    }

    private static void Fix(TMP_Text _0xc057292f)
    {
        if (_0xc057292f == null || !_0xc057292f.isActiveAndEnabled)
            return;
        Material _0xb9a72f15 = _0xc057292f.fontSharedMaterial;
        if (_0xb9a72f15 == null || !_0xb9a72f15.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xb9a72f15.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xb9a72f15.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x08eff10e = _0xc057292f.color;
        if (_0x08eff10e.a <= 0f)
            return;
        Color _0x5326a282 = _0xb9a72f15.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x08eff10e, _0x5326a282) >= MinRatio)
            return;
        Color _0x55dcf676 = Luminance(_0x5326a282) < 0.5f ? Color.white : Color.black;
        Color _0x0e7e4546;
        if (Ratio(_0x55dcf676, _0x5326a282) < TargetRatio)
        {
            _0x0e7e4546 = _0x55dcf676;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x878cc5b4 = 0f;
            float _0x91c905d2 = 1f;
            for (int _0xb1c7bf04 = 0; _0xb1c7bf04 < 20; _0xb1c7bf04++)
            {
                float _0xb19b3c29 = (_0x878cc5b4 + _0x91c905d2) * 0.5f;
                if (Ratio(Color.Lerp(_0x08eff10e, _0x55dcf676, _0xb19b3c29), _0x5326a282) >= TargetRatio)
                    _0x91c905d2 = _0xb19b3c29;
                else
                    _0x878cc5b4 = _0xb19b3c29;
            }

            _0x0e7e4546 = Color.Lerp(_0x08eff10e, _0x55dcf676, _0x91c905d2);
        }

        _0x0e7e4546.a = _0x08eff10e.a;
        _0xc057292f.color = _0x0e7e4546;
    }

    private readonly HashSet<TMP_Text> _0x5f0545ae = new HashSet<TMP_Text>();
    private void LateUpdate()
    {
        if (this._0x5f0545ae.Count == 0)
            return;
        this._0xd20ed06e.Clear();
        this._0xd20ed06e.AddRange(this._0x5f0545ae);
        this._0x5f0545ae.Clear();
        for (int _0xcf2da0b1 = 0; _0xcf2da0b1 < this._0xd20ed06e.Count; _0xcf2da0b1++)
            Fix(this._0xd20ed06e[_0xcf2da0b1]);
    }

    private const float TargetRatio = 7f;
    private void OnEnable()
    {
        if (this._0x96d9f821 == null)
            this._0x96d9f821 = _0x59dad814 => this._0x9d64c369(_0x59dad814);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x96d9f821);
    }

    private const float MinRatio = 4.5f;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x9d64c369(Object _0x96c02a30)
    {
        TMP_Text _0x6839e53e = _0x96c02a30 as TMP_Text;
        if (_0x6839e53e != null)
            this._0x5f0545ae.Add(_0x6839e53e);
    }
}

internal static class _0xa6d3a40f
{
    internal static string _0xf8b6ad20(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}