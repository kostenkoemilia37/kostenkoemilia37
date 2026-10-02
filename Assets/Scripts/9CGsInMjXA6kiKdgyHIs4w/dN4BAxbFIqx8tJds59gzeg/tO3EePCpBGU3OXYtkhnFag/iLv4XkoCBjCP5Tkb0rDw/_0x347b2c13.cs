using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x347b2c13 : MonoBehaviour
{
    public void _0xae9711bb()
    {
        this._0xa23ee102?.Play();
    }

    public static _0x347b2c13 Instance;
    private void _0x9b206279()
    {
        this.AnimationSlider.value = 0.05f;
        _0x6083dc40 = !_0x6083dc40;
        this._0xa23ee102 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x8007a8bf => this.AnimationSlider.value = _0x8007a8bf, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x6de4ac9a._0xd55456c5?._0xc4fd95cc();
        });
    }

    public void _0x43ddd955()
    {
        this._0x4826640d();
        bool _0x3cf8642a = _0x6083dc40;
        this._0xa23ee102 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x8007a8bf => this.AnimationSlider.value = _0x8007a8bf, _0x3cf8642a ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x6083dc40 = !_0x6083dc40;
    }

    public GameObject Error;
    private static bool _0x6083dc40 = false;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xf90e3ec3._0xe768a878.SCENE_0 && !_0x6083dc40)
        {
            this._0x9b206279();
        }
        else
        {
            this._0x43ddd955();
        }
    }

    private Sequence _0xa23ee102;
    public Slider AnimationSlider;
    public void _0x5271cd13()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xa23ee102?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x6083dc40 = false;
    }

    public float FirstAnimationTime = 10.0f;
    public GameObject Background;
    public float DefaultAnimationTime = 0.4f;
    public float SecondPassSliderValue = 0.5f;
    public void _0x561a731e()
    {
        this._0xa23ee102?.Pause();
    }

    public void _0x4826640d()
    {
        this._0xa23ee102?.Kill();
        this.AnimationSlider.value = _0x6083dc40 ? this.SecondPassSliderValue : 0.05f;
    }

    public GameObject Content;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x347b2c13>();
    }
}