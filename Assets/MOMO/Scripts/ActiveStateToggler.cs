using UnityEngine;
using System.Collections;

public class ActiveStateToggler : MonoBehaviour {

    /// <summary>
    /// 切换物体的激活状态
    /// </summary>
	public void ToggleActive () {
		gameObject.SetActive (!gameObject.activeSelf);
	}
}
