using UnityEngine;
using System.Collections;

public class Rueda1Control : MonoBehaviour {
	private float zAngle;
	float variable = 0.0f;

	void Start () {
		zAngle = transform.eulerAngles.z;
	}
	void Update () 
	{
		variable += 0.5f;
		zAngle += (Mathf.Cos(variable));
		transform.rotation = Quaternion.Euler (0,90, variable);
	}
}