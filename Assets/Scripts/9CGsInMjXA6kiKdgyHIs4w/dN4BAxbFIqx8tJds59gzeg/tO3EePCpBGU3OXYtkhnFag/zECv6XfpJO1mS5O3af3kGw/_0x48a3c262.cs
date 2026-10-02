using UnityEngine;
using UnityEngine.UI;

public class _0x48a3c262 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x7b6179ac.Instance._0xb565d280(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
}