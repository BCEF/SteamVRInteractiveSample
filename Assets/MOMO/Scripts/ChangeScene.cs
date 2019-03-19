using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class ChangeScene : MonoBehaviour
{
    /// <summary>
    /// 切换到另一个场景
    /// </summary>
    /// <param name="index"></param>
    public void ChangeLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}
