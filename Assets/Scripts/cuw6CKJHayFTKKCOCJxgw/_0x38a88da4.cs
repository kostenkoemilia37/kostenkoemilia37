using UnityEngine;

// Single source of colour for the whole game (CASINO_GOLD preset, accents retuned
// for the vault brief). Every text colour here is light on purpose: the TMP outline
// baked into "font SDF" is Deep (#12151E), so a dark face on a dark outline is a
// smudge (rule C.14). Red and Violet are FILL colours only - never text.
public static class _0x38a88da4
{
    public static Color _0x96816075
    {
        get
        {
            return Rgb(0xA8, 0x83, 0x2A, 1f);
        }
    }

    public static Color _0x0d81781e
    {
        get
        {
            return Rgb(0x65, 0x46, 0xB5, 1f);
        }
    }

    public static Color _0x689c1325
    {
        get
        {
            return Rgb(0xF5, 0xEB, 0xD8, 1f);
        }
    }

    public static Color _0x10d9b2ed
    {
        get
        {
            return Rgb(0x1A, 0x1F, 0x2E, 1f);
        }
    }

    public static Color _0x87400960
    {
        get
        {
            return Rgb(0xEF, 0xC2, 0x4E, 1f);
        }
    }

    public static Color _0xb491aef5
    {
        get
        {
            return Rgb(0x2A, 0x31, 0x45, 1f);
        }
    }

    public static Color _0x83d89fbf
    {
        get
        {
            return Rgb(0x23, 0x2A, 0x3C, 1f);
        }
    }

    public static Color Rgb(int _0x323aac01, int _0xcbde483d, int _0x11138ad9, float _0x060e00a0)
    {
        return new Color(_0x323aac01 / 255f, _0xcbde483d / 255f, _0x11138ad9 / 255f, _0x060e00a0);
    }

    public static Color _0xb3ad8789
    {
        get
        {
            return Rgb(0x30, 0xB9, 0xAA, 1f);
        }
    }

    public static Color _0x923ac702
    {
        get
        {
            return Rgb(0x12, 0x15, 0x1E, 1f);
        }
    }

    public static Color _0x18999b33
    {
        get
        {
            return Rgb(0xD9, 0x36, 0x4E, 1f);
        }
    }

    public static Color Fade(Color _0x7252e2d0, float _0x00c7ee35)
    {
        return new Color(_0x7252e2d0.r, _0x7252e2d0.g, _0x7252e2d0.b, _0x00c7ee35);
    }
}