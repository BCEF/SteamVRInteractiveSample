using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomCollider : MonoBehaviour
{
    public string colliderTag = "Player";
    public UnityEvent OnTriggerIn;
    public UnityEvent OnTriggerOut;
    /// <summary>
    /// 进入碰撞体
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag==colliderTag)
            OnTriggerIn.Invoke();
    }
    /// <summary>
    /// 离开碰撞体
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == colliderTag)
            OnTriggerOut.Invoke();
    }
}
