using UnityEngine;
using UnityEngine.UI;

public class _0x1df5fd74 : MonoBehaviour
{
    private void Start()
    {
        if (this._0x3257499a)
            this._0x52cba1fd.onClick.AddListener(() => _0x2a281dda.Instance._0x7cb2038e());
        else
            this._0x52cba1fd.onClick.AddListener(() => _0x2a281dda.Instance._0x4771d9b3(this._0x63d9f5ae));
    }

    private Button _0x52cba1fd;
    private void Awake()
    {
        if (this._0x52cba1fd == null)
            if (!this.TryGetComponent(out this._0x52cba1fd))
                this._0x52cba1fd = this.GetComponentInChildren<Button>();
    }

    private int _0x63d9f5ae;
    private bool _0x3257499a;
}