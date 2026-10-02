using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xbadb97db : MonoBehaviour
{
    public static void HideAllPops()
    {
        _0x18dbb4f6.Instance._0x2fdb41ad();
    }

    public TMP_Text ContentHeaderText;
    public void _0xaded7b70()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private void _0xd7b5bb01()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public bool IsScaledDownOnAwake = true;
    public bool IsOnlyYScale;
    public Ease ease = Ease.OutSine;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public GameObject Content;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xd7b5bb01();
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    private bool _0xacf3bcf6 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public Image ContentImage;
    public float scaleDuration = 0.4f;
    public TMP_Text ContentMainText;
    public TMP_Text ContentAdditionalText;
}