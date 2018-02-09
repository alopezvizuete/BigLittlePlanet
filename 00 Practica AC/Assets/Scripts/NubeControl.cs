using UnityEngine;
using System.Collections;

public class NubeControl : MonoBehaviour {

	float variable = 0.0f;
	void Update () 
	{
		variable += 0.000009f;
		transform.localPosition = new Vector3 (transform.position.x,transform.position.y,transform.position.z+variable);
	}
}