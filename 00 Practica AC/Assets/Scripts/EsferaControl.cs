using UnityEngine;
using System.Collections;

public class EsferaControl : MonoBehaviour {
	float variable = 0.0f;
	void Update () 
	{
		variable += 0.1f;
		transform.localPosition = new Vector3 (transform.position.x,transform.position.y+(Mathf.Cos(variable)/100),transform.position.z);
	}
}