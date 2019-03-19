using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CustomSpawnAttach2Hand : MonoBehaviour
{
    public SteamVR_Action_Boolean Grab = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabPinch");
    SpawnPrefab spawn;
    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        spawn = GetComponent<SpawnPrefab>();
    }

    // Update is called once per frame
    void Update()
    {


        if(Grab.GetState(SteamVR_Input_Sources.Any) || Grab.GetStateDown(SteamVR_Input_Sources.Any)&&spawn.Inst!=null)
        {
            obj =spawn.Inst;
            obj.transform.position = spawn.targetTransform.position;
            obj.transform.rotation = spawn.targetTransform.rotation;
        }
        if (Grab.GetStateUp(SteamVR_Input_Sources.Any))
        {
            spawn.Inst = null;
        }
       

    }
}
