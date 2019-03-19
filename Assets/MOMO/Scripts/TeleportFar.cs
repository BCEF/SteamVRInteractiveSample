using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class TeleportFar: MonoBehaviour
{
    public Transform player;
    public Transform VRCamera;
    public Transform destination;

    private void Start()
    {
        if (player == null)
        {
            player = GameObject.Find("Player").transform;
        }
        if (VRCamera == null)
        {
            VRCamera = Camera.main.transform;
        }
    }
    /// <summary>
    /// 将Player传送到destination位置
    /// </summary>
    public void transformObject()
    {
        SteamVR_Fade.View(Color.black,0);
        SteamVR_Fade.View(Color.clear, 2.0f);
        Vector3 tmp = destination.position - VRCamera.transform.localPosition;
        player.position = new Vector3(tmp.x,player.position.y,tmp.z);
    }
    
   
}
