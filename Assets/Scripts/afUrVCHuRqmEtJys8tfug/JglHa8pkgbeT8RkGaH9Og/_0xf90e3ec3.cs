using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xf90e3ec3
{
    public class _0xdc37620b
    {
        private static readonly _0xdc37620b _0xdefd5f21 = new();
        public static readonly _0xdc37620b[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xdefd5f21,
            _0xdefd5f21,
            _0xdefd5f21,
        };
        private int _0xdb9cbf2a => 0;
        private int _0xd40c0364 => 10;
        private string _0xaacab0b6 => _0x5383ddbe._0x6c1d4019(new byte[4] { 53, 29, 22, 13 }, 120);
        private string _0x5c338f94 => _0x5383ddbe._0x6c1d4019(new byte[8] { 23, 30, 13, 30, 23, 32, 107, 38 }, 91);

        private int _0x7c977670
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x5383ddbe._0x6c1d4019(new byte[25] { 141, 187, 188, 188, 171, 160, 186, 137, 162, 161, 172, 175, 162, 141, 166, 175, 190, 186, 171, 188, 135, 160, 170, 171, 182 }, 206)))
                    PlayerPrefs.SetInt(_0x5383ddbe._0x6c1d4019(new byte[25] { 158, 168, 175, 175, 184, 179, 169, 154, 177, 178, 191, 188, 177, 158, 181, 188, 173, 169, 184, 175, 148, 179, 185, 184, 165 }, 221), 0);
                return PlayerPrefs.GetInt(_0x5383ddbe._0x6c1d4019(new byte[25] { 21, 35, 36, 36, 51, 56, 34, 17, 58, 57, 52, 55, 58, 21, 62, 55, 38, 34, 51, 36, 31, 56, 50, 51, 46 }, 86));
            }

            set => PlayerPrefs.SetInt(_0x5383ddbe._0x6c1d4019(new byte[25] { 47, 25, 30, 30, 9, 2, 24, 43, 0, 3, 14, 13, 0, 47, 4, 13, 28, 24, 9, 30, 37, 2, 8, 9, 20 }, 108), value);
        }

        public int _0x0887efdd
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xaacab0b6}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xaacab0b6}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xaacab0b6}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xaacab0b6}CurrentLevelIndex", value);
        }

        public int _0x1fcee557
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xaacab0b6}BestScore"))
                    this._0x1fcee557 = 0;
                return PlayerPrefs.GetInt($"{this._0xaacab0b6}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xaacab0b6}BestScore", value);
        }

        public bool _0x9c0858b9
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xaacab0b6}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xaacab0b6}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xaacab0b6}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xaacab0b6}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xcd3fadf4
    {
        public static int _0x7dacd067
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x5383ddbe._0x6c1d4019(new byte[5] { 120, 84, 82, 85, 72 }, 59)))
                    PlayerPrefs.SetInt(_0x5383ddbe._0x6c1d4019(new byte[5] { 98, 78, 72, 79, 82 }, 33), 0);
                return PlayerPrefs.GetInt(_0x5383ddbe._0x6c1d4019(new byte[5] { 73, 101, 99, 100, 121 }, 10));
            }

            set
            {
                PlayerPrefs.SetInt(_0x5383ddbe._0x6c1d4019(new byte[5] { 31, 51, 53, 50, 47 }, 92), value);
                _0x7b6179ac.Instance._0x4ecf31de();
            }
        }
    }

    public static class _0xe768a878
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x5f839e9d
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0xbb03596b
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }
}

internal static class _0x5383ddbe
{
    internal static string _0x6c1d4019(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}