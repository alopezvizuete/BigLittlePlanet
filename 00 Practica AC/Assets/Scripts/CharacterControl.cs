using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CharacterControl : MonoBehaviour {

	public float walkSpeed = 1.0f;
	public float turnSpeed = 90.0f;
	public float gravityValue = -9.81f;
	public float jumpSpeed = 5.0f;
	public int puntuacion = 1; 

	private float yAngle;
	private CharacterController controller;
	private float mySpeed;
	private float ySpeed = 0.0f;
	private Vector3 moveVector;
	private Vector3 mytransform;

	private Animator animator;
	private Animator gameOverAn;

	// Use this for initialization
	void Start () {
		yAngle = transform.eulerAngles.y;
		controller = GetComponent<CharacterController> ();
		animator = GetComponent<Animator> ();
		gameOverAn = GameObject.FindGameObjectWithTag ("UIGO").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//Movimiento
				yAngle += Input.GetAxis ("Horizontal") * Time.deltaTime * turnSpeed;
				transform.rotation = Quaternion.Euler (0, yAngle, 0);

				mySpeed = Input.GetAxis ("Vertical") * walkSpeed;

				ySpeed += gravityValue * Time.deltaTime;

				moveVector = transform.forward * mySpeed;
				moveVector += new Vector3 (0.0f, ySpeed, 0.0f);

				controller.Move (moveVector * Time.deltaTime);

				animator.SetFloat("speed", mySpeed);

				if (controller.isGrounded) 
				{
					ySpeed = 0.0f;
					if (Input.GetButtonDown ("Jump")) {
						ySpeed = jumpSpeed;
						animator.SetBool ("jump",true);
					} 
					else {
						ySpeed = 0.0f;
						animator.SetBool ("jump",false);
					}
				}
		if(Input.GetKey("r")){
			SceneManager.LoadScene ("Scene01");
		}
		if(Input.GetKey("escape")){
			Application.Quit ();
		}

	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Esfera"))
		{
			other.gameObject.SetActive (false);
			ScoreManager.score += puntuacion;
			ScoreFManager.score += puntuacion;
		}
		if (other.gameObject.CompareTag ("Lava"))
		{
			gameOverAn.SetTrigger ("GameOver");
		}
		if (other.gameObject.CompareTag ("Fin"))
		{
			gameOverAn.SetTrigger ("Win");
		}

	}
		
}
