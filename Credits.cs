using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
