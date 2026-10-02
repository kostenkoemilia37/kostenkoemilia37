using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x56ac1de9 : MonoBehaviour
{
    private void _0x33991eae()
    {
        if (this.OuterBackground != null)
        {
            Image _0xc0e473bd = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xc0e473bd, true);
            _0xc0e473bd.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public void Show()
    {
        this._0x33991eae();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x2a281dda.Instance._0x753a5131(_0x2a281dda.Instance.CurrentPanelIndex);
            });
        }
    }

    public bool IsScaledDownOnAwake = true;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x016469e8();
    }

    public GameObject OuterBackground;
    public TMP_Text MainText;
    public void _0xc33de8e2()
    {
        this._0x8f345b41();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    private void _0x6ec272e1()
    {
        if (this.OuterBackground != null)
        {
            Image _0xc71aae4b = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xc71aae4b, true);
            _0xc71aae4b.DOFade(1f, 0f);
        }
    }

    private void _0x016469e8()
    {
        if (this.OuterBackground != null)
        {
            Image _0x5b61a135 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x5b61a135, true);
            _0x5b61a135.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public GameObject Content;
    public TMP_Text HeaderText;
    public float ScaleDuration = 0.4f;
    private void _0x8f345b41()
    {
        if (this.OuterBackground != null)
        {
            Image _0x56aba2c2 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x56aba2c2, true);
            _0x56aba2c2.DOFade(0f, this.ScaleDuration);
        }
    }

    public void _0x1d1a544a()
    {
        this._0x6ec272e1();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x2a281dda.Instance._0x753a5131(_0x2a281dda.Instance.CurrentPanelIndex);
    }

    public Ease Ease = Ease.OutSine;
    private bool _0xfe61bc8d => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;
}