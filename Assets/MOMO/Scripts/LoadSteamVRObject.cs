using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 获取steamVR物体的位置
/// </summary>
public class LoadSteamVRObject : MonoBehaviour
{
    public Transform VRCamera;
    public Transform FollowHead;
    public Transform LeftHand;
    public Transform RightHand;
    Transform steamVR_VRCamera, steamVR_Follow, steamVR_LeftHand, steamVR_RightHand;
    private void OnEnable()
    {
        steamVR_VRCamera = GameObject.Find("VRCamera").transform;
        steamVR_Follow = GameObject.Find("FollowHead").transform;
        steamVR_LeftHand = GameObject.Find("LeftHand").transform;
        steamVR_RightHand = GameObject.Find("RightHand").transform;
    }
    private void Update()
    {
        VRCamera.position = steamVR_VRCamera.position;
        VRCamera.rotation = steamVR_VRCamera.rotation;
        FollowHead.position = steamVR_Follow.position;
        FollowHead.rotation = steamVR_Follow.rotation;
        LeftHand.position = steamVR_LeftHand.position;
        LeftHand.rotation = steamVR_LeftHand.rotation;
        RightHand.position = steamVR_RightHand.position;
        RightHand.rotation = steamVR_RightHand.rotation;
    }
}
