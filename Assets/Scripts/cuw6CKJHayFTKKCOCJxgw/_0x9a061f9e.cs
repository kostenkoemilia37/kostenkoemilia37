// One vault section as the player meets it: where the target corridor sits, where each
// ring's notch starts, which key colour is live and how the tray is ordered.
//
// Public on purpose: VaultLayoutGenerator hands it out from a public method, and an
// internal type in a public signature is CS0051 in the cloud build.
public sealed class _0x9a061f9e
{
    public const int DegreesPerTooth = 30;
    public const int RingCount = 3;
    public const int Teeth = 12;
    public int[] NotchStep = new int[RingCount];
    public int[] TrayOrder = new int[4];
    // Turns still owed on one ring: how many single-tooth taps until its notch sits on
    // the target corridor. Rotation is clockwise only, so the distance is cyclic.
    public int _0x9d62d41e(int _0xbd8aa60d, int _0xe10ca7de)
    {
        int _0xd033bd8c = (this.NotchStep[_0xbd8aa60d] + _0xe10ca7de) % Teeth;
        return (this.TargetStep - _0xd033bd8c + Teeth) % Teeth;
    }

    public int TargetStep;
    public int KeyColourIndex;
    public int _0xa3d7a8c6(int[] _0x06279d09)
    {
        int _0x91f3a490 = 0;
        for (int _0x008857e4 = 0; _0x008857e4 < RingCount; _0x008857e4++)
            _0x91f3a490 += this._0x9d62d41e(_0x008857e4, _0x06279d09[_0x008857e4]);
        return _0x91f3a490;
    }

    public bool _0x1e7b7d28(int _0x7163d7ac, int _0x4c3a87cb)
    {
        return this._0x9d62d41e(_0x7163d7ac, _0x4c3a87cb) == 0;
    }
}