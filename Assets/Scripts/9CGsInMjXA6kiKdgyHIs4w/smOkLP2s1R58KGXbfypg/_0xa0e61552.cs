using UnityEngine;

public class _0xa0e61552 : MonoBehaviour
{
    private void _0x2d0114c5()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xa0e61552>();
            DontDestroyOnLoad(this.gameObject);
            this._0x2d0114c5();
        }
        else
        {
            this._0x154f030f();
            Destroy(this.gameObject);
        }
    }

    public static _0xa0e61552 Instance;
    public bool IsCheckScoreEnabled;
    private void _0x154f030f()
    {
    }

    public bool IsOnlyWinGameEndEnabled;
    public bool IsTutorialEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsBestScoreEnabled;
    public bool IsStoryEnabled;
    public bool IsTimerEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsLevelSelectorEnabled;
}