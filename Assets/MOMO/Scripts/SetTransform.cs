using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 设置物体位置
/// </summary>
public class SetTransform : MonoBehaviour
{
   
    public void SetValue(Transform transform)
    {
        this.transform.position = transform.position;
        this.transform.eulerAngles = transform.eulerAngles;
    }
}
