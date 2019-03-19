using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 跟随
/// </summary>
public class FollowTarget : MonoBehaviour
{
    [Header("Position Follow")]
    public Vector3bool position;
    [Header("Rotation Follow")]
    public Vector3bool rotation;
    [Header("Transform")]
    public Transform target;
    public Transform povit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (position.X)
        {
            target.position = new Vector3(povit.position.x,target.position.y, target.position.z);
        }
        if (position.Y)
        {
            target.position = new Vector3(target.position.x, povit.position.y,target.position.z);
        }
        if (position.Z)
        {
            target.position = new Vector3(target.position.x, target.position.y,povit.position.z);
        }
        if (rotation.X)
        {
            target.eulerAngles = new Vector3(povit.eulerAngles.x, target.eulerAngles.y, target.eulerAngles.z);
        }
        if (rotation.Y)
        {
            target.eulerAngles = new Vector3( target.eulerAngles.x, povit.eulerAngles.y, target.eulerAngles.z);
        }
        if (rotation.Z)
        {
            target.eulerAngles = new Vector3( target.eulerAngles.x, target.eulerAngles.y, povit.eulerAngles.z);
        }
    }
}
[System.Serializable]
public struct Vector3bool
{
    public bool X, Y, Z;
}
