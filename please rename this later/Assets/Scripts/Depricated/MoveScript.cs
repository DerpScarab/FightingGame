using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	public InputScript Is = new InputScript();
	int  inputDirection;
	int  inputAttack;
	bool facingRight;
	bool grounded;
	bool canAct;
	bool canMove;
	bool applyGravity;

	float leftWalk;
	float rightWalk;
	float fWalk;
	float bWalk;
	float jumpHeight;
	float jumpVelocity;
	float gravity;

	int action;

	// Use this for initialization
	void Start () {
		inputDirection = Is.finalInputDirection;
		inputAttack    = Is.finalInputAttack;
		facingRight    = true;
		grounded       = true;
		canAct        = true;
		applyGravity   = true;

		rightWalk  = .05f;
		leftWalk   = .04f;
		jumpHeight = .5f;
		gravity    = .01f;
	}
	
	// Update is called once per frame
	void Update () {
		if (canAct){

			if (facingRight){
				leftWalk = bWalk;
				rightWalk = fWalk;
			} else if (!facingRight){
				leftWalk = fWalk;
				rightWalk = bWalk;
			}


			//checks for movement
			if (canMove)
			{
				if (Is.finalInputDirection == 1){
					//crouch block
				}
				if (Is.finalInputDirection == 2){
					//crouch
				}
				if (Is.finalInputDirection == 3){
					//crouch
				}
				if (Is.finalInputDirection == 4){
					//block
					if (grounded){
						transform.Translate(leftWalk, 0, 0);
					}
				}
				if (Is.finalInputDirection == 5){
					//idle
				}
				if (Is.finalInputDirection == 6){
					if (grounded){
						transform.Translate(rightWalk, 0, 0);
					}
				}
			}
			if (Is.finalInputDirection == 7){
				//block
				grounded = false;
				//jump()
			}
			if (Is.finalInputDirection == 8){
				grounded = false;
				//jump()
			}
			if (Is.finalInputDirection == 9){
				grounded = false;
				//jump()
			}


			//checks for buttons
			if (Is.finalInputAttack == 1)
			{
				//standing light
				if (Is.finalInputDirection == 5)
					action = 1;
				//crouching light
				if (Is.finalInputDirection == 2)
					action = 2;
			}
			if (Is.finalInputAttack == 2)
			{
				//standing medium
				if (Is.finalInputDirection == 5)
					action = 3;
				//crouching medium
				if (Is.finalInputDirection == 2)
					action = 4;
			}
			if (Is.finalInputAttack == 3)
			{
				//standing heavy
				if (Is.finalInputDirection == 5)
					action = 5;
				//crouching heavy
				if (Is.finalInputDirection == 2)
					action = 6;
			}
			if (Is.finalInputAttack == 4)
			{
				//standing special
				if (Is.finalInputDirection == 5)
					action = 7;
				//crouching special
				if (Is.finalInputDirection == 2)
					action = 8;
			}
			if (Is.finalInputAttack == 5)
			{
				//throw
			}
			if (Is.finalInputAttack == 6)
			{
				//cancel
			}
			if (Is.finalInputAttack == 7)
			{
				//instant kill
			}

			//checks for special attacks

		}
		if (transform.position.y < -.8f){
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
