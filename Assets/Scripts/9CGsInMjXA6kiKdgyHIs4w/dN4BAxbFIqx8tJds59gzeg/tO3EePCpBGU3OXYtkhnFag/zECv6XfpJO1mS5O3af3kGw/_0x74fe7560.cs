using UnityEngine;
using UnityEngine.UI;

public class _0x74fe7560 : MonoBehaviour
{
    public Button Button;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x18dbb4f6.Instance._0xa6972e1f();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x18dbb4f6.Instance._0x2fdb41ad());
        else
            this.Button.onClick.AddListener(() => _0x18dbb4f6.Instance._0x7ac038f2(this.PopToShowIndex));
    }

    public int PopToShowIndex;
    public bool IsHideAllPops;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
}