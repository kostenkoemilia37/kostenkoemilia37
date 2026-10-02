using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x0307761a : MonoBehaviour
{
    public int LoadSceneId;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x7b6179ac.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x7b6179ac.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    public Button Button;
    public bool IsLoadCurrentScene;
}