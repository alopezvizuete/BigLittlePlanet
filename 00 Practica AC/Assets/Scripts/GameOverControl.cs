using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverControl : MonoBehaviour {

	public bool fin;
	public float restart = 5f;
	Animator anim;
	float restartTimer;

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (fin == true) {
			anim.SetTrigger ("GameOver");
			restartTimer += Time.deltaTime;
			if(restartTimer>=restart)
				SceneManager.LoadScene ("Scene01");
		}
	}
}
