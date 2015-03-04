using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	[Range(0,25)]
	public float _moveSpeed;	
	public float _forceRigidbody;
	
	[HideInInspector]
	public int score;
	
	[HideInInspector]
	public int posYgameOver = -4;
	
	float rapidityMove;
	string moveDirection = "z"; //top
	
	float posY;
	
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			if (moveDirection == "z") {
				moveDirection = "x";
			} else {
				moveDirection = "z";
			}			
			score++;
		}
		rapidityMove = Time.deltaTime * _moveSpeed;
		
		Vector3 position = this.transform.position;
		
		if (moveDirection == "z") {
			position.z += rapidityMove;
			position.x = this.transform.position.x;
		} else if (moveDirection == "x") {
			position.x += -rapidityMove;
			position.z = this.transform.position.z;
		}
		this.transform.position = position;
		this.transform.rotation = Quaternion.identity;
		
		//TODO: Change that for gameover
		if (position.y < posYgameOver){
			/* Game Over Screen */
			Application.LoadLevel("Level1");
		}
		
		/* TODO: Use this for mobile */
		if (Input.touchCount > 0) {
			/*Debug.Log (Input.touchCount);*/
		}
		
	
	}
}
