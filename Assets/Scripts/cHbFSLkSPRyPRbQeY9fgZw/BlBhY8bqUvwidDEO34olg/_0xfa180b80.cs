using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xfa180b80 : MonoBehaviour
{
    private Vector3 _0xeeb7de1f { get; set; }
    private float _0x6cbf8d4d { get; set; }

    private new Camera _0xced625ba;
    //public bool executeInUpdate;
    private float _0x42bf58a8 { get; set; }

    private float _0x2cf32693 = 1;
    private Vector3 _0x9618c63f { get; set; }
    private Vector3 _0x35343f76 { get; set; }

    private Color _0x533bcfc5 = Color.white;
    private static _0xfa180b80 _0x281d855f;
    private void Awake()
    {
        this._0xced625ba = this.GetComponent<Camera>();
        _0x281d855f = this;
        this._0x06ea5608();
    }

    private void _0x06ea5608()
    {
        float _0xe99458c5, _0x7bd602cf, _0x7f1e4460, _0x51b20c38;
        if (this._0x8787b7ac == _0xa7fba03c.Landscape)
            this._0xced625ba.orthographicSize = 1f / this._0xced625ba.aspect * this._0x2cf32693 / 2f;
        else
            this._0xced625ba.orthographicSize = this._0x2cf32693 / 2f;
        this._0x6cbf8d4d = 2f * this._0xced625ba.orthographicSize;
        this._0x42bf58a8 = this._0x6cbf8d4d * this._0xced625ba.aspect;
        float _0xe6bd6fd5 = this._0xced625ba.transform.position.x;
        float _0x39bdb827 = this._0xced625ba.transform.position.y;
        _0xe99458c5 = _0xe6bd6fd5 - this._0x42bf58a8 / 2;
        _0x7bd602cf = _0xe6bd6fd5 + this._0x42bf58a8 / 2;
        _0x7f1e4460 = _0x39bdb827 + this._0x6cbf8d4d / 2;
        _0x51b20c38 = _0x39bdb827 - this._0x6cbf8d4d / 2;
        this._0xeeb7de1f = new Vector3(_0xe99458c5, _0x51b20c38, 0);
        this._0x9618c63f = new Vector3(_0xe6bd6fd5, _0x51b20c38, 0);
        this._0x5e5d00c0 = new Vector3(_0x7bd602cf, _0x51b20c38, 0);
        this._0xc758a2f6 = new Vector3(_0xe99458c5, _0x39bdb827, 0);
        this._0x2b07b111 = new Vector3(_0xe6bd6fd5, _0x39bdb827, 0);
        this._0xb6f91b5a = new Vector3(_0x7bd602cf, _0x39bdb827, 0);
        this._0x35343f76 = new Vector3(_0xe99458c5, _0x7f1e4460, 0);
        this._0xb45022d1 = new Vector3(_0xe6bd6fd5, _0x7f1e4460, 0);
        this._0x050bf5dd = new Vector3(_0x7bd602cf, _0x7f1e4460, 0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x533bcfc5;
        Matrix4x4 _0x60f2f3cf = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xced625ba.orthographic)
        {
            float _0x445fe599 = this._0xced625ba.farClipPlane - this._0xced625ba.nearClipPlane;
            float _0x36590058 = (this._0xced625ba.farClipPlane + this._0xced625ba.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x36590058), new Vector3(this._0xced625ba.orthographicSize * 2 * this._0xced625ba.aspect, this._0xced625ba.orthographicSize * 2, _0x445fe599));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xced625ba.fieldOfView, this._0xced625ba.farClipPlane, this._0xced625ba.nearClipPlane, this._0xced625ba.aspect);
        }

        Gizmos.matrix = _0x60f2f3cf;
    }

    private Vector3 _0x050bf5dd { get; set; }

    public enum _0xa7fba03c
    {
        Landscape,
        Portrait
    }

    private Vector3 _0x2b07b111 { get; set; }
    private Vector3 _0xb45022d1 { get; set; }
    private Vector3 _0xc758a2f6 { get; set; }
    private Vector3 _0x5e5d00c0 { get; set; }
    private Vector3 _0xb6f91b5a { get; set; }

    private _0xa7fba03c _0x8787b7ac = _0xa7fba03c.Portrait;
}