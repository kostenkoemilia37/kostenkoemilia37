using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x6bde820d : MonoBehaviour
{
    [HideInInspector]
    public int CurrentGameIndex;
    public void _0xa2455738(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x27f63f18();
            this._0xc2b2941b();
        }
    }

    [HideInInspector]
    public int TimeLeft;
    private void _0x27f63f18()
    {
        if (_0xa0e61552.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x2c735340 => _0x2c735340.text = $"{this.ScoreCurrent}/{this._0x18a2b2f5}");
        else
            this.ScoreText.ForEach(_0x2c735340 => _0x2c735340.text = $"{this.ScoreCurrent}");
    }

    public void _0xa2aa6652()
    {
        if (!this.IsGameEnd)
        {
            this._0x4cf4a60a();
            _0x7b6179ac.IsAfterLevelComplete = true;
            _0x7b6179ac.IsAfterLevelFailed = false;
            _0xbadb97db _0x19966ea0 = _0x18dbb4f6.Instance._0xae857e31(_0xf90e3ec3._0xbb03596b.WIN).GetComponent<_0xbadb97db>();
            if (_0xa0e61552.Instance.IsCheckScoreEnabled)
                _0x19966ea0.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x18a2b2f5}";
            else
                _0x19966ea0.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xa0e61552.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xf90e3ec3._0xcd3fadf4._0x7dacd067)
                    _0xf90e3ec3._0xcd3fadf4._0x7dacd067 = this.ScoreCurrent;
                _0x19966ea0.ContentAdditionalText.text = $"{_0xf90e3ec3._0xcd3fadf4._0x7dacd067}";
            }
            else
            {
                _0x19966ea0.ContentAdditionalText.text = $"{this._0x2aa07258}";
                _0xf90e3ec3._0xcd3fadf4._0x7dacd067 += this._0x2aa07258;
            }

            if (_0xa0e61552.Instance.IsLevelIncrementOnWin)
                ++_0x7b6179ac._0x1b74f841._0x0887efdd;
            _0x18dbb4f6.Instance._0x7ac038f2(_0xf90e3ec3._0xbb03596b.WIN);
        }
    }

    private void Awake()
    {
        _0x98cd7c4b = this.gameObject.GetComponent<_0x6bde820d>();
    }

    private void _0x4cf4a60a()
    {
        this.IsGameEnd = true;
        _0x7b6179ac.IsAfterLevelComplete = true;
    }

    public List<Button> PauseButtons = new();
    private void _0xc2b2941b()
    {
        if (this.ScoreCurrent > _0x7b6179ac._0x1b74f841._0x1fcee557)
            _0x7b6179ac._0x1b74f841._0x1fcee557 = this.ScoreCurrent;
        if (_0xa0e61552.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x18a2b2f5)
                this._0xa2aa6652();
    }

    private int _0x18a2b2f5 => this.CustomTargetScore + _0x7b6179ac._0x1b74f841._0x0887efdd * 10;

    private IEnumerator _0xdcafe51b()
    {
        this._0x7b9fe02e();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x7b6179ac.Instance._0x46fe397e == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x7b6179ac.Instance._0xe54e2d3f)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x7b9fe02e();
            }
        }

        if (!this.IsGameEnd)
            this._0x1aa828d0();
    }

    public int CustomTargetScore = 10;
    public List<TMP_Text> SubtitleText = new();
    private void _0xcbb94326()
    {
        if (this.ScoreCurrent >= this._0x18a2b2f5)
            this._0xa2aa6652();
        else
            this._0x1aa828d0();
    }

    public int CustomTimeInitial = 30;
    public List<TMP_Text> ScoreText = new();
    public List<Button> HomeButtons = new();
    public void _0x44b7e768()
    {
        _0x7b6179ac.Instance._0xb565d280(true);
        _0x7b6179ac.Instance.LoadSceneByIndex(_0xf90e3ec3._0xe768a878.SCENE_0);
    }

    private int _0x2aa07258 => this.ScoreCurrent;

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x78c0ab42;
        this.CurrentGameIndex = _0x7b6179ac.Instance._0x46fe397e;
        foreach (Button _0x1a5c691c in this.HomeButtons)
            _0x1a5c691c.onClick.AddListener(() =>
            {
                this._0x44b7e768();
            });
        foreach (Button _0x634938a5 in this.PauseButtons)
            _0x634938a5.onClick.AddListener(() =>
            {
                _0x7b6179ac.Instance._0xb565d280(false);
                _0x18dbb4f6.Instance._0x7ac038f2(_0xf90e3ec3._0xbb03596b.PAUSE);
            });
        this._0x27f63f18();
        this.LevelNumberText.ForEach(_0x2c735340 => _0x2c735340.text = $"LVL {_0x7b6179ac._0x1b74f841._0x0887efdd + 1}");
        if (_0xa0e61552.Instance.IsTimerEnabled)
        {
            this._0x7b9fe02e();
            this.StartCoroutine(this._0xdcafe51b());
        }
    }

    private int _0x78c0ab42 => this.CustomTimeInitial + _0x7b6179ac._0x1b74f841._0x0887efdd * 10;

    private static _0x6bde820d _0x98cd7c4b;
    public void _0x1aa828d0()
    {
        if (_0xa0e61552.Instance.IsOnlyWinGameEndEnabled)
            this._0xa2aa6652();
        if (!this.IsGameEnd)
        {
            this._0x4cf4a60a();
            _0x7b6179ac.IsAfterLevelComplete = false;
            _0x7b6179ac.IsAfterLevelFailed = true;
            _0xbadb97db _0x9f4bd88f = _0x18dbb4f6.Instance._0xae857e31(_0xf90e3ec3._0xbb03596b.LOSE).GetComponent<_0xbadb97db>();
            if (_0xa0e61552.Instance.IsCheckScoreEnabled)
                _0x9f4bd88f.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x18a2b2f5}";
            else
                _0x9f4bd88f.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x9f4bd88f.ContentAdditionalText.text = $"{0}";
            _0xf90e3ec3._0xcd3fadf4._0x7dacd067 += 0;
            _0x18dbb4f6.Instance._0x7ac038f2(_0xf90e3ec3._0xbb03596b.LOSE);
        }
    }

    public List<TMP_Text> TimerText = new();
    [HideInInspector]
    public bool IsGameEnd;
    private void _0x7b9fe02e()
    {
        this.TimerText.ForEach(_0x2c735340 => _0x2c735340.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xd755ec96._0x4bebdf62(new byte[6] { 132, 132, 181, 211, 154, 154 }, 233)));
    }

    public List<TMP_Text> LevelNumberText = new();
    [HideInInspector]
    public int ScoreCurrent;
}

internal static class _0xd755ec96
{
    internal static string _0x4bebdf62(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}