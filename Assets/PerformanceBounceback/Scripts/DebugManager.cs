using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviour {
    public static bool isDebugging = false;
    public static DebugManager debugManager;

    void Start()
    {
        debugManager = this;
    }

    /// <summary>
    /// This takes a string `message` and passes it as a param for Debug.Log;
    /// this is a cleaner way of debugging since it affects performance if left unchecked.
    /// </summary>
    /// <param name="message"></param>
    public static void Info(string message)
    {
        if (!isDebugging)
        {
            return;
        } else
        {
            Debug.Log(message);
        }
    }
}
