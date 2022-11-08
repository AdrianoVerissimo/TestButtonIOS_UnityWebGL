using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class ButtonController : MonoBehaviour
{
    public string url;

    // Importing "CallFunction"
    [DllImport("__Internal")]
    public static extern void OpenURL_CreateNode(string url, string target);

    [DllImport("__Internal")]
    public static extern void OpenURL_WindowOpen(string url);

    public void OpenURL_CreateNode_blank() => OpenURL_CreateNode(url, "_blank");
    public void OpenURL_CreateNode_parent() => OpenURL_CreateNode(url, "_parent");
    public void OpenURL_CreateNode_top() => OpenURL_CreateNode(url, "_top");

    public void OpenURL_WindowOpen_Unity()
    {
        OpenURL_WindowOpen(url);
    }

    public void ApplicationOpenURL()
    {
        Application.OpenURL(url);
    }
}
