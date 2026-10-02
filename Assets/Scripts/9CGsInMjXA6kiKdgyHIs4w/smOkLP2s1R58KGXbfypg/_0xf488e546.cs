using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xf488e546 : MonoBehaviour
{
    private Touch? _0xf7c5ed97(Bounds _0xde21acb4)
    {
        if (!_0x7b6179ac.Instance._0xe54e2d3f)
            return null;
        foreach (Touch _0x4e914c8c in Touch.activeTouches)
            if (_0x4e914c8c.ended)
            {
                Vector3 _0xb604c3a6 = Camera.main.ScreenToWorldPoint(_0x4e914c8c.screenPosition);
                Vector3 _0x61e7abe8 = new(_0xb604c3a6.x, _0xb604c3a6.y, _0xde21acb4.center.z);
                if (_0xde21acb4.Contains(_0x61e7abe8) && this._0xb8f352f7(_0x4e914c8c))
                    return _0x4e914c8c;
            }

        return null;
    }

    private static _0xf488e546 _0xa66e48c6;
    private Touch? _0xd9315fd4()
    {
        if (!_0x7b6179ac.Instance._0xe54e2d3f)
            return null;
        foreach (Touch _0xd1038145 in Touch.activeTouches)
            if (!_0xd1038145.ended)
                if (this._0xb8f352f7(_0xd1038145))
                    return _0xd1038145;
        return null;
    }

    private bool _0xaa3179e9(Touch? _0xca7a16af, Bounds _0x66329d16, TouchPhase _0xaeb0ac17)
    {
        if (!_0x7b6179ac.Instance._0xe54e2d3f)
        {
            _0xca7a16af = null;
            return false;
        }

        if (_0xca7a16af != null)
            if (_0xca7a16af.Value.phase == _0xaeb0ac17)
            {
                Vector3 _0xce075e7e = Camera.main.ScreenToWorldPoint(_0xca7a16af.Value.screenPosition);
                Vector3 _0x25f804be = new(_0xce075e7e.x, _0xce075e7e.y, _0x66329d16.center.z);
                if (_0x66329d16.Contains(_0x25f804be) && this._0xb8f352f7(_0xca7a16af.Value))
                    return true;
            }

        return false;
    }

    private void _0xb1082f16(Touch? _0x27047789)
    {
        if (!_0x7b6179ac.Instance._0xe54e2d3f)
        {
            _0x27047789 = null;
            return;
        }

        int _0x3a7efc32 = _0x27047789.Value.touchId;
        _0x27047789 = Touch.activeTouches.FirstOrDefault(_0x909d82f0 => _0x909d82f0.touchId == _0x3a7efc32);
        if (!this._0xb8f352f7(_0x27047789.Value))
            _0x27047789 = null;
    }

    private bool _0xb8f352f7(Touch? _0x64f87ef5)
    {
        if (!_0x64f87ef5.HasValue)
            return false;
        Vector3 _0x6ff06778 = Camera.main.ScreenToWorldPoint(_0x64f87ef5.Value.screenPosition);
        Vector3 _0x779b0c79 = _0x6ff06778;
        _0x779b0c79.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x779b0c79))
            return true;
        _0x64f87ef5 = null;
        return false;
    }

    private Touch? _0xde273246(Bounds _0x704cc987, TouchPhase _0x9c39619f)
    {
        if (!_0x7b6179ac.Instance._0xe54e2d3f)
            return null;
        foreach (Touch _0xdc224c61 in Touch.activeTouches)
            if (_0xdc224c61.phase == _0x9c39619f)
            {
                Vector3 _0xe4d597b6 = Camera.main.ScreenToWorldPoint(_0xdc224c61.screenPosition);
                Vector3 _0x2cf0d2fa = new(_0xe4d597b6.x, _0xe4d597b6.y, _0x704cc987.center.z);
                if (_0x704cc987.Contains(_0x2cf0d2fa) && this._0xb8f352f7(_0xdc224c61))
                    return _0xdc224c61;
            }

        return null;
    }

    private Touch? _0xde8c6851()
    {
        if (!_0x7b6179ac.Instance._0xe54e2d3f)
            return null;
        foreach (Touch _0x9e5b87d6 in Touch.activeTouches)
            if (_0x9e5b87d6.ended)
                if (this._0xb8f352f7(_0x9e5b87d6))
                    return _0x9e5b87d6;
        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x5116d460(Bounds _0xa45b27fc)
    {
        if (!_0x7b6179ac.Instance._0xe54e2d3f)
            return null;
        foreach (Touch _0x99417f54 in Touch.activeTouches)
            if (!_0x99417f54.ended)
            {
                Vector3 _0xc6429d42 = Camera.main.ScreenToWorldPoint(_0x99417f54.screenPosition);
                Vector3 _0x9b6e5b70 = new(_0xc6429d42.x, _0xc6429d42.y, _0xa45b27fc.center.z);
                if (_0xa45b27fc.Contains(_0x9b6e5b70) && this._0xb8f352f7(_0x99417f54))
                    return _0x99417f54;
            }

        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0xa66e48c6 = this.gameObject.GetComponent<_0xf488e546>();
    }
}