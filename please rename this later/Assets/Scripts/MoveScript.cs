using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	public InputScript Is = new InputScript();
	int inputDirection;
	int inputAttack;
	bool facingRight;
	bool grounded;
	bool canMove;
	bool applyGravity;

	float leftWalk;
	float rightWalk;
	float fWalk;
	float bWalk;
	float jumpHeight;
	float jumpVelocity;
	float gravity;

	// Use this for initialization
	void Start () {
		inputDirection = Is.finalInputDirection;
		inputAttack    = Is.finalInputAttack;
		facingRight    = true;
		grounded       = true;
		canMove        = true;
		applyGravity   = true;

		rightWalk  = .5f;
		leftWalk   = .4f;
		jumpHeight = .5f;
		gravity    = .01f;
	}
	
	// Update is called once per frame
	void Update () {
		inputDirection = Is.finalInputDirection;
		inputAttack = Is.finalInputAttack;

		if (canMove){
			if (facingRight){
				leftWalk = bWalk;
				rightWalk = fWalk;
			} else if (!facingRight){
				leftWalk = fWalk;
				rightWalk = bWalk;
			}

			if (inputDirection == 1){
				//crouch block
			}
			if (inputDirection == 2){
				//crouch
			}
			if (inputDirection == 3){
				//crouch
			}
			if (inputDirection == 4){
				//crouchblock
				if (grounded){
					transform.Translate(leftWalk, 0, 0);
				}
			}
			if (inputDirection == 5){
				//idle
			}
			if (inputDirection == 6){
				if (grounded){
					transform.Translate(rightWalk, 0, 0);
				}
			}
			if (inputDirection == 7){
				//airblock
				grounded = false;
				//jump()
			}
			if (inputDirection == 8){
				grounded = false;
				//jump()
			}
			if (inputDirection == 9){
				grounded = false;
				//jump()
			}
		}
		if (transform.position.y <= -.8f){
			transform.position = new Vector2(transform.position.x, -.8f);
			grounded = true;
		}
	}

	public void jump(){
		int jumpDirection = inputDirection;
		jumpHeight        = jumpVelocity;
		if (applyGravity){
			calcGravity(jumpDirection);
		}
	}

	public void calcGravity(int jumpDirection){
		if (jumpDirection == 7){
			transform.Translate(leftWalk * .85f, 0, 0);
		} 
		if (jumpDirection == 9){
			transform.Translate(rightWalk * .85f, 0, 0);
		}
		transform.Translate(0, jumpVelocity, 0);
		jumpVelocity = jumpVelocity - gravity;
	}
}
