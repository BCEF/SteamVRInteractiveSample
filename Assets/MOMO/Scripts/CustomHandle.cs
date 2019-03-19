using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR;

public class CustomHandle : MonoBehaviour
{
    public SteamVR_Action_Boolean HandleButton = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabPinch");
    public SteamVR_Input_Sources sources=SteamVR_Input_Sources.Any;
    public UnityEvent HandleEvent;
    public UnityEvent HandleEventUp;
    public UnityEvent HandleEventDown;
    // Start is called before the first frame update
    void Start()
    {
        HandleButton.actionSet.Activate();
    }

    // Update is called once per frame
    void Update()
    {
        if (HandleButton.GetState(sources))
        {
            HandleEvent.Invoke();
        }
        if (HandleButton.GetStateUp(sources))
        {
            HandleEventUp.Invoke();
        }
        if (HandleButton.GetStateDown(sources))
        {
            HandleEventDown.Invoke();
        }
    }
}
