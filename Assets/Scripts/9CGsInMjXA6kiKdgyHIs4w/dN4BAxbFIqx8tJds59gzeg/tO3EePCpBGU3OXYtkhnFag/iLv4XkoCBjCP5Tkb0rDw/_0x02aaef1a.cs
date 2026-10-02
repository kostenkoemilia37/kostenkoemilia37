using UnityEngine;
using UnityEngine.UI;

public class _0x02aaef1a : MonoBehaviour
{
    public Button NextTutorialButton;
    public int EndTutorialPanelIndex = 1;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x2a281dda.Instance._0x4771d9b3(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x7b6179ac.Instance._0xabc1637d());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x2a281dda.Instance._0x4771d9b3(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x2a281dda.Instance._0x4771d9b3(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x7b6179ac.Instance._0xabc1637d());
        }
    }

    public int NextTutorialPanelIndex;
    public Button TutorialEndButton;
    public bool IsTutorialEndPanel;
}