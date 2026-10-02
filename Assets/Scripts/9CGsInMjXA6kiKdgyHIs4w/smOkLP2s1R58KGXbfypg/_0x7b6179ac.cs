using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xf90e3ec3;

public class _0x7b6179ac : MonoBehaviour
{
    public static _0xdc37620b _0x1b74f841 => _0xdc37620b.ALL_SCENES_SETTING_SINGLETONS[Instance._0x46fe397e];

    public static bool IsAfterLevelComplete;
    public void _0x90d3c07b()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public Button DeleteProgressDataButton;
    public Button ShowResetTutorialButton;
    private static _0xdc37620b _0x8fb3e60c => _0xdc37620b.ALL_SCENES_SETTING_SINGLETONS[0];

    private static _0xdc37620b GAME_INDEX_SETTINGS(int _0xcfc85c2e)
    {
        return _0xdc37620b.ALL_SCENES_SETTING_SINGLETONS[_0xcfc85c2e];
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    private IEnumerator _0x63815d96(string _0x8176648a)
    {
        _0x2a281dda.Instance._0x4771d9b3(_0x5f839e9d.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x70b16394 = SceneManager.LoadSceneAsync(_0x8176648a);
        while (!_0x70b16394.isDone)
            yield return null;
    }

    private IEnumerator _0xdf4125d7(int _0x8b732ff9)
    {
        _0x2a281dda.Instance._0x4771d9b3(_0x5f839e9d.SPLASH);
        AsyncOperation _0x88d4bff1 = SceneManager.LoadSceneAsync(_0x8b732ff9);
        while (!_0x88d4bff1.isDone)
            yield return null;
    }

    public void _0x4ecf31de()
    {
        foreach (_0xa7f7d855 _0xea746f21 in this.MoneyCountContainers)
            _0xea746f21._0x9c8cd5ac();
    }

    [HideInInspector]
    public List<_0xa7f7d855> MoneyCountContainers = new();
    public bool _0xe54e2d3f { get; private set; }

    private static void MakeGrid(List<RectTransform> _0xbc28dd38, AspectRatioFitter _0x9cbf4978, float _0x449de9f1, int _0x4b0a255a, int _0x42e7128f)
    {
        _0x9cbf4978.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x9cbf4978.aspectRatio = _0x449de9f1;
        foreach (RectTransform _0x4df0082d in _0xbc28dd38)
        {
            int _0xe9ac0edb = _0x4df0082d.transform.GetSiblingIndex();
            _0x4df0082d.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xe9ac0edb % _0x4b0a255a) * (1f / _0x4b0a255a), (_0x42e7128f - (Mathf.FloorToInt((float)_0xe9ac0edb / _0x4b0a255a) % _0x42e7128f + 1f)) * (1f / _0x42e7128f));
            _0x4df0082d.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xe9ac0edb % _0x4b0a255a + 1f) * (1f / _0x4b0a255a), (_0x42e7128f - Mathf.FloorToInt((float)_0xe9ac0edb / _0x4b0a255a) % _0x42e7128f) * (1f / _0x42e7128f));
            _0x4df0082d.offsetMin = Vector2.zero;
            _0x4df0082d.offsetMax = Vector2.zero;
        }
    }

    public int _0x46fe397e => SceneManager.GetActiveScene().buildIndex;

    private void _0x5f54cdde(Transform _0xd1f8c874)
    {
        Transform[] _0xdd5b646f = _0xd1f8c874.GetComponentsInChildren<Transform>();
        foreach (Transform _0xcf133e18 in _0xdd5b646f)
            if (_0xcf133e18 != null && DOTween.IsTweening(_0xcf133e18))
            {
                if (this._0xe54e2d3f)
                    DOTween.Play(_0xcf133e18);
                else
                    DOTween.Pause(_0xcf133e18);
            }
    }

    public void _0xabc1637d()
    {
        _0x1b74f841._0x9c0858b9 = true;
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public Canvas MainCanvas;
    public static _0x7b6179ac Instance;
    public static bool IsAfterLevelFailed = false;
    public void _0xb565d280(bool _0xaef64b13)
    {
        this._0xe54e2d3f = _0xaef64b13;
        this._0x32517eb7(!this._0xe54e2d3f);
        Physics2D.simulationMode = this._0xe54e2d3f ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x5f54cdde(this.EnvironmentWithTweensToToggle);
    }

    private void _0x0cadaa0c()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0xe768a878.SCENE_0);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x7b6179ac>();
        this.RootGameObject = GameObject.FindWithTag(_0xf7d18d1f._0xc698bad7(new byte[4] { 48, 13, 13, 22 }, 98));
        if (this._0x46fe397e == _0xe768a878.SCENE_0)
            this._0xb565d280(true);
        else
            this._0xb565d280(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xa7f7d855>(true).ToList();
    }

    private void Start()
    {
        if (this._0x46fe397e != _0xe768a878.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0xe768a878.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x1b74f841._0x9c0858b9 = false;
            _0x18dbb4f6.Instance._0x2fdb41ad();
            _0x2a281dda.Instance._0x4771d9b3(_0x5f839e9d.TUTORIAL0);
        });
    }

    public Transform Environment;
    private void _0x32517eb7(bool _0x1217eaeb)
    {
        Rigidbody2D[] _0x042f006b = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x3016753a in _0x042f006b)
            if (_0x1217eaeb)
                _0x3016753a.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x3016753a.constraints = RigidbodyConstraints2D.None;
    }

    public void LoadSceneByIndex(int _0xe84ec8cb)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xdf4125d7(_0xe84ec8cb));
    }

    public Transform EnvironmentWithTweensToToggle;
}

internal static class _0xf7d18d1f
{
    internal static string _0xc698bad7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}