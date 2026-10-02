using UnityEngine;

// Builds a vault section CONSTRUCTIVELY instead of rolling dice and praying (rule C.11).
//
// The naive shape - generate a random board, then test whether it can be solved inside
// the turn budget - throws most of its draws away and quietly ships the fallback when a
// catalogue row is unreachable. Here the solution comes FIRST: pick how many taps each
// ring should owe, then place its notch exactly that far from the corridor. Every layout
// is therefore solvable by construction, and IsSolvable below is an assertion rather
// than a filter.
//
// Two invariants the screenshot scenario and the difficulty curve both rely on:
//   section 0  - middle ring starts aligned, outer and inner owe exactly one tap each,
//                so "tap outer, tap inner, RUN PULSE" always opens the first section;
//   sections 1+ - at least three taps owed in total, so a pulse fired without rotating
//                anything is always a miss (three of them end the run, which is what
//                gives the capture album a real result card).
public sealed class _0xa5bda488
{
    public bool _0x610881cb(_0x9a061f9e _0x8b4917ba, int _0x424d9c3c)
    {
        int[] _0x1ce02575 = new int[_0x9a061f9e.RingCount];
        int _0x074afe09 = _0x8b4917ba._0xa3d7a8c6(_0x1ce02575);
        return _0x074afe09 > 0 && _0x074afe09 <= _0x424d9c3c;
    }

    public const int MaxPerRing = 5;
    public const int MinLaterTurns = 3;
    public const int FirstSectionTurns = 2;
    // Guaranteed reachable in two taps. Only reached if the budget maths above ever
    // goes wrong - a guarantee, not a hope.
    public _0x9a061f9e _0x9981a761(int _0x2ff0f553, int _0x8d06d62c)
    {
        _0x9a061f9e _0xd824cb50 = new _0x9a061f9e();
        _0xd824cb50.TargetStep = _0x2ff0f553;
        _0xd824cb50.NotchStep[0] = (_0x2ff0f553 - 1 + _0x9a061f9e.Teeth) % _0x9a061f9e.Teeth;
        _0xd824cb50.NotchStep[1] = _0x2ff0f553;
        _0xd824cb50.NotchStep[2] = (_0x2ff0f553 - 1 + _0x9a061f9e.Teeth) % _0x9a061f9e.Teeth;
        _0xd824cb50.KeyColourIndex = _0x8d06d62c;
        for (int _0xb5f9ecc4 = 0; _0xb5f9ecc4 < _0xd824cb50.TrayOrder.Length; _0xb5f9ecc4++)
            _0xd824cb50.TrayOrder[_0xb5f9ecc4] = _0xb5f9ecc4;
        return _0xd824cb50;
    }

    public const int MaxLaterTurns = 6;
    private int[] _0xf67cf0f5(System.Random _0xbabb634c, int _0x06cbdcd1, int _0x48f3f5f6)
    {
        int[] _0xc6029f67 = new int[_0x9a061f9e.RingCount];
        if (_0x06cbdcd1 <= 0)
        {
            _0xc6029f67[0] = 1;
            _0xc6029f67[1] = 0;
            _0xc6029f67[2] = 1;
            return _0xc6029f67;
        }

        int _0x272b9341 = MinLaterTurns + _0xbabb634c.Next(MaxLaterTurns - MinLaterTurns + 1);
        if (_0x272b9341 > _0x48f3f5f6)
            _0x272b9341 = Mathf.Max(1, _0x48f3f5f6);
        int left = _0x272b9341;
        for (int _0x1f10b5ff = 0; _0x1f10b5ff < _0x9a061f9e.RingCount && left > 0; _0x1f10b5ff++)
        {
            int _0x5f9aebeb = _0x9a061f9e.RingCount - _0x1f10b5ff - 1;
            int _0x9f213e2a = Mathf.Min(MaxPerRing, left);
            int _0xd72ec86b = Mathf.Max(0, left - _0x5f9aebeb * MaxPerRing);
            int take = _0xd72ec86b + _0xbabb634c.Next(_0x9f213e2a - _0xd72ec86b + 1);
            _0xc6029f67[_0x1f10b5ff] = take;
            left -= take;
        }

        if (left > 0)
            _0xc6029f67[_0x9a061f9e.RingCount - 1] += left;
        return _0xc6029f67;
    }

    public _0x9a061f9e _0xfae1fee0(System.Random _0x54b013a0, int _0x37139ea2, int _0x386ecc8d, int _0x30ea11be)
    {
        _0x9a061f9e _0xe2eb66c0 = new _0x9a061f9e();
        _0xe2eb66c0.TargetStep = _0x54b013a0.Next(_0x9a061f9e.Teeth);
        int[] _0x554ccd9c = this._0xf67cf0f5(_0x54b013a0, _0x37139ea2, _0x386ecc8d);
        for (int _0x948009d3 = 0; _0x948009d3 < _0x9a061f9e.RingCount; _0x948009d3++)
            _0xe2eb66c0.NotchStep[_0x948009d3] = (_0xe2eb66c0.TargetStep - _0x554ccd9c[_0x948009d3] + _0x9a061f9e.Teeth) % _0x9a061f9e.Teeth;
        // The key colour must CHANGE between sections: "every run is different" has to be
        // visible on screen, not only in a counter (rule C.11).
        int _0x567b0a9c = _0x54b013a0.Next(4);
        if (_0x567b0a9c == _0x30ea11be)
            _0x567b0a9c = (_0x567b0a9c + 1 + _0x54b013a0.Next(3)) % 4;
        _0xe2eb66c0.KeyColourIndex = _0x567b0a9c;
        for (int _0x6df19866 = 0; _0x6df19866 < _0xe2eb66c0.TrayOrder.Length; _0x6df19866++)
            _0xe2eb66c0.TrayOrder[_0x6df19866] = _0x6df19866;
        for (int _0x602125bf = _0xe2eb66c0.TrayOrder.Length - 1; _0x602125bf > 0; _0x602125bf--)
        {
            int _0x0ba6246e = _0x54b013a0.Next(_0x602125bf + 1);
            int _0xd30a9a95 = _0xe2eb66c0.TrayOrder[_0x602125bf];
            _0xe2eb66c0.TrayOrder[_0x602125bf] = _0xe2eb66c0.TrayOrder[_0x0ba6246e];
            _0xe2eb66c0.TrayOrder[_0x0ba6246e] = _0xd30a9a95;
        }

        if (!this._0x610881cb(_0xe2eb66c0, _0x386ecc8d))
            _0xe2eb66c0 = this._0x9981a761(_0xe2eb66c0.TargetStep, _0x567b0a9c);
        {
#if B_LOGS
            {
                Debug.Log(string.Format(_0x57649976._0xaf13e7ab(new byte[55] { 76, 97, 118, 98, 123, 99, 74, 55, 100, 114, 116, 99, 126, 120, 121, 42, 108, 39, 106, 55, 99, 118, 101, 112, 114, 99, 42, 108, 38, 106, 55, 120, 96, 114, 115, 42, 108, 37, 106, 56, 108, 36, 106, 56, 108, 35, 106, 55, 124, 114, 110, 42, 108, 34, 106 }, 23), _0x37139ea2, _0xe2eb66c0.TargetStep, _0x554ccd9c[0], _0x554ccd9c[1], _0x554ccd9c[2], _0xe2eb66c0.KeyColourIndex));
            }
#endif
        }

        return _0xe2eb66c0;
    }
}

internal static class _0x57649976
{
    internal static string _0xaf13e7ab(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}