using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreFManager : MonoBehaviour {
	public static int score;
	TextMesh text;

	void Awake ()
	{
		text = GetComponent <TextMesh> ();

		score = 0;
	}


	void Update ()
	{
		text.text = "Puntuacion: " + score;
	}
}
