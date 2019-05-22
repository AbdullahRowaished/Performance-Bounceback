using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviour {
    public bool isDebugging;
    public static DebugManager debugManager;

    void Start()
    {
        debugManager = this;
        isDebugging = true;
    }
    /// <summary>
    /// This takes a string `message` and passes it as a param for Debug.Log;
    /// this is a cleaner way of debugging since it affects performance if left unchecked.
    /// </summary>
    /// <param name="message"></param>
    public void Info(string message)
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
