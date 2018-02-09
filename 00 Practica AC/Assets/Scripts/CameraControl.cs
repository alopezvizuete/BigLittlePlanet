using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public GameObject player;
	float valueZ;
	float valueY;
	Vector3 newTransform;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		valueZ = player.transform.position.z;
		valueY = player.transform.position.y;
		newTransform = new Vector3(7.2f, valueY+2f, valueZ);
		transform.position = newTransform;
	}
}
