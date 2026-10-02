using UnityEngine;
using UnityEngine.EventSystems;

// The board's tap surface.
//
// The template's InputController cannot be used here: its Instance is a private static
// field and every Get*Touch* member is private, so calling it does not compile - not
// "it NREs", it does not build. Taking the tap from UGUI instead is both compilable and
// obfuscation-safe, and it rides the same EventSystem the buttons already use.
//
// The click arrives in SCREEN pixels. The gameplay lives in world space under the same
// camera, so ScreenToWorldPoint converts it directly; the panel's letterbox does not
// enter into it, because the camera sees the whole screen.
public sealed class _0xfede3e32 : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Camera _camera;
    private System.Action<Vector2> _0x3c9457d7;
    public void OnPointerClick(PointerEventData _0x860375d3)
    {
        if (this._camera == null || this._0x3c9457d7 == null)
            return;
        Vector3 _0x8cb17d38 = this._camera.ScreenToWorldPoint(new Vector3(_0x860375d3.position.x, _0x860375d3.position.y, 0f));
        this._0x3c9457d7.Invoke(new Vector2(_0x8cb17d38.x, _0x8cb17d38.y));
    }

    public void _0x32f0afb9(Camera _0x95c7b63c, System.Action<Vector2> _0xc118de97)
    {
        this._camera = _0x95c7b63c;
        this._0x3c9457d7 = _0xc118de97;
    }
}