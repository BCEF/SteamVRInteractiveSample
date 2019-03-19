using UnityEngine;
using UnityEngine.Events;
using Valve.VR;
/// <summary>
/// default手柄按键触发
/// </summary>
public class CustomDefaultHandle : MonoBehaviour
{
    public UnityEvent InteractUI;
    public UnityEvent Teleport;
    public UnityEvent GrabPinch;
    public UnityEvent GrabGrip;
    public UnityEvent HeadsetOnHead;
    public UnityEvent Menu;
    private void Update()
    {
        if (SteamVR_Actions.default_InteractUI.GetStateUp(SteamVR_Input_Sources.Any))
        {
            InteractUI.Invoke();
        }
        if (SteamVR_Actions.default_Teleport.GetStateUp(SteamVR_Input_Sources.Any))
        {
            Teleport.Invoke();
        }
        if (SteamVR_Actions.default_GrabPinch.GetStateUp(SteamVR_Input_Sources.Any))
        {
            GrabPinch.Invoke();
        }
        if (SteamVR_Actions.default_GrabGrip.GetStateUp(SteamVR_Input_Sources.Any))
        {
            GrabGrip.Invoke();
        }
        if (SteamVR_Actions.default_HeadsetOnHead.GetStateUp(SteamVR_Input_Sources.Any))
        {
            HeadsetOnHead.Invoke();
        }
        

    }
}
