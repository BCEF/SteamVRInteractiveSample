using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject prefab;
    public Transform targetTransform;
    public GameObject Inst;
    /// <summary>
    /// 在targetTransform位置生成一个prefab
    /// </summary>
    public void SpawnObject()
    {
        Inst=Instantiate(prefab, targetTransform.position,transform.rotation);
    }
}
