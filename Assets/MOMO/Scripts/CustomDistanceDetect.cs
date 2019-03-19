using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomDistanceDetect : MonoBehaviour
{
    public Transform Povit;
    public Transform target;
    public float Distance=5;
    /// <summary>
    /// target靠近povit
    /// </summary>
    public UnityEvent OnNear;
    /// <summary>
    /// target远离povit
    /// </summary>
    public UnityEvent OnFar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Povit.transform.position, target.transform.position) < Distance)
        {
            OnNear.Invoke();
        }
        if (Vector3.Distance(Povit.transform.position, target.transform.position) > Distance+1)
        {
            OnFar.Invoke();
        }

    }
}
