using UnityEngine;

// Every world size in this game is DERIVED from the camera (rule C.0). Nothing is a
// literal: on a 19.5:9 phone the visible world is 10 units tall and about 4.61 wide,
// on a 20:9 one it is narrower, and a hardcoded board would spill off the sides.
//
// The sorting band is equally strict (rule C.21). Canvas and SpriteRenderer share ONE
// scale: the template's background canvas sits at -30 and the pop canvases at 10/15,
// so every sprite this game draws must live strictly inside -29..-1. The orders are
// named constants below, never numbers typed at the call site, and no two layers that
// overlap share one order.
public sealed class _0x1e0444d9
{
    public int _0xd7a76e09(int _0xb154820f)
    {
        if (_0xb154820f == 0)
            return GearOuterOrder;
        if (_0xb154820f == 1)
            return GearMidOrder;
        return GearInnerOrder;
    }

    public float _0x2729a4e4(int _0x35a07804)
    {
        float _0x22d40e23 = this._0x48cda72d(_0x35a07804);
        return this._0xb776bb40 * 2f * _0x22d40e23;
    }

    public float _0xe5e82e92
    {
        get
        {
            return this._0xb776bb40 * 0.17f;
        }
    }

    public const float MidRingFraction = 0.72f;
    public Vector2 _0x085a7cc2(float _0x81a8b7c3, float _0xba6b15fc)
    {
        float _0x07bab1f8 = _0xba6b15fc * Mathf.Deg2Rad;
        return this._0x3936b1c0 + new Vector2(Mathf.Sin(_0x07bab1f8) * _0x81a8b7c3, Mathf.Cos(_0x07bab1f8) * _0x81a8b7c3);
    }

    public const int SparkOrder = -2;
    public const int TargetGateOrder = -6;
    public const int GearInnerOrder = -9;
    private readonly float _0x2ac8bd1a;
    public float _0xe0df8bf8
    {
        get
        {
            return this._0xb776bb40 * 1.16f;
        }
    }

    public int _0xf80e861b(int _0xb6fd633e)
    {
        if (_0xb6fd633e == 0)
            return MarkerOuterOrder;
        if (_0xb6fd633e == 1)
            return MarkerMidOrder;
        return MarkerInnerOrder;
    }

    public Vector2 _0xd65a4b59
    {
        get
        {
            return this._0x3936b1c0;
        }
    }

    public const float CoreBandEdge = 0.24f;
    public float _0x513d8b30
    {
        get
        {
            return this._0x2ac8bd1a;
        }
    }

    public const int MarkerInnerOrder = -8;
    public const int GearOuterOrder = -13;
    public float _0x600e6fe5
    {
        get
        {
            return this._0xb776bb40;
        }
    }

    private float _0x48cda72d(int _0x377d810d)
    {
        if (_0x377d810d == 0)
            return OuterRingFraction;
        if (_0x377d810d == 1)
            return MidRingFraction;
        return InnerRingFraction;
    }

    public float _0x543a15b4
    {
        get
        {
            return this._0xb776bb40 * 0.48f;
        }
    }

    public const int CoreLockOrder = -5;
    public const int MarkerOuterOrder = -12;
    // Fractions of the board radius. The three rings occupy disjoint radial bands, so
    // a tap can be routed to a ring by its distance from the board centre alone.
    public const float OuterRingFraction = 1.00f;
    public float _0x013eeec8
    {
        get
        {
            return this._0xb776bb40 * 0.22f;
        }
    }

    public float _0x94ebd3b1
    {
        get
        {
            return this._0xb776bb40 * 2.16f;
        }
    }

    public const int GearMidOrder = -11;
    public const float InnerBandEdge = 0.50f;
    private readonly float _0xb776bb40;
    public const int MarkerMidOrder = -10;
    public const int KeyTokenOrder = -7;
    public float _0x00827b5d
    {
        get
        {
            return this._0xb776bb40 * 0.30f;
        }
    }

    public const float InnerRingFraction = 0.46f;
    public _0x1e0444d9(Camera _0x8113273e)
    {
        this._0xe8aaf16a = _0x8113273e != null ? _0x8113273e.orthographicSize : 5f;
        float _0x71cdecc6 = _0x8113273e != null && _0x8113273e.aspect > 0.01f ? _0x8113273e.aspect : 0.45f;
        this._0x2ac8bd1a = this._0xe8aaf16a * _0x71cdecc6;
        // 0.86 of the half width leaves a real margin on both sides at every aspect,
        // and the cap keeps the board from swallowing the key tray on a tall screen.
        this._0xb776bb40 = Mathf.Min(this._0x2ac8bd1a * 0.86f, this._0xe8aaf16a * 0.40f);
        this._0x3936b1c0 = new Vector2(0f, this._0xe8aaf16a * 0.11f);
    }

    public const float MidMarkerFraction = 0.63f;
    public float _0x3760e13d(int _0xa3b6bd8d)
    {
        if (_0xa3b6bd8d == 0)
            return this._0xb776bb40 * OuterMarkerFraction;
        if (_0xa3b6bd8d == 1)
            return this._0xb776bb40 * MidMarkerFraction;
        return this._0xb776bb40 * InnerMarkerFraction;
    }

    public const int SectionPipOrder = -16;
    public float _0x88f39a99
    {
        get
        {
            return this._0xb776bb40 * 0.16f;
        }
    }

    private readonly float _0xe8aaf16a;
    public float _0x53fe71ce
    {
        get
        {
            return this._0xb776bb40 * 0.21f;
        }
    }

    public const float OuterMarkerFraction = 0.89f;
    public const float InnerMarkerFraction = 0.37f;
    public const int PulseOrder = -4;
    public float _0xf822fe5a
    {
        get
        {
            return this._0xb776bb40 * 0.30f;
        }
    }

    public const float MidBandEdge = 0.76f;
    // Which ring a world point belongs to, or -1 when the tap is off the board.
    public int _0x4a02c570(Vector2 _0x06f569f2)
    {
        float _0xc61c85f1 = (_0x06f569f2 - this._0x3936b1c0).magnitude / this._0xb776bb40;
        if (_0xc61c85f1 <= CoreBandEdge)
            return -1;
        if (_0xc61c85f1 <= InnerBandEdge)
            return 2;
        if (_0xc61c85f1 <= MidBandEdge)
            return 1;
        if (_0xc61c85f1 <= OuterBandEdge)
            return 0;
        return -1;
    }

    public float _0x4daa9efe
    {
        get
        {
            return this._0x3936b1c0.y - this._0xb776bb40 - this._0xe8aaf16a * 0.13f;
        }
    }

    public const float OuterBandEdge = 1.08f;
    public float _0x49f87e55
    {
        get
        {
            return this._0xe8aaf16a;
        }
    }

    private readonly Vector2 _0x3936b1c0;
    // -19..-10 play field, -9..-4 actors, -3..-1 effects.
    public const int PlateOrder = -18;
}