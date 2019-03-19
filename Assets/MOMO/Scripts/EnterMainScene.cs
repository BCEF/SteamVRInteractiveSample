using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 程序启动时进入的场景
/// </summary>
public class EnterMainScene : MonoBehaviour
{
    public int enterIndex = 3;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(enterIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
