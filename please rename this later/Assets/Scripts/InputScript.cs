using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class InputScript : MonoBehaviour {

	public bool  facingRight;
	public int   finalInputDirection;
	public int   finalInputAttack;
	public int   combinedInput;
	public int[] inputButton = new int[4];

	// Use this for initialization
	void Start () {
		facingRight = true;
	}
	
	// Update is called once per frame
	void Update () {
		finalInputDirection = getInputDirection(facingRight);
		finalInputAttack    = getAttackInput();
	}

	public int getInputDirection(bool facingRight){
		//creates inputDirection and sets it to the default value
		int  inputDirection = 5;

		//checks for left input
		if (Input.GetKey(KeyCode.A)){
			if (facingRight){
				inputDirection = 4;
			} else if (!facingRight) {
				inputDirection = 6;
			}
		}

		//checks for right input
		if (Input.GetKey(KeyCode.D)){
			if (facingRight){
				inputDirection = 6;
			} else if (!facingRight) {
				inputDirection = 4;
			}
		}

		//checks for crouch input
		if (Input.GetKey(KeyCode.S)){
			inputDirection = 2;
		} 
		if (Input.GetKey(KeyCode.S) &&
			Input.GetKey(KeyCode.A)){
			if (facingRight){
				inputDirection = 1;
			} else if (!facingRight) {
				inputDirection = 3;
			}
		} 
		if (Input.GetKey(KeyCode.S) &&
			Input.GetKey(KeyCode.D)){
			if (facingRight){
				inputDirection = 3;
			} else if (!facingRight) {
				inputDirection = 1;
			}
		}

		//checks for jump input
		if (Input.GetKey(KeyCode.W)){
			inputDirection = 8;
		}
		if (Input.GetKey(KeyCode.W) &&
			Input.GetKey(KeyCode.A)){
			if (facingRight){
				inputDirection = 7;
			} else if (!facingRight) {
				inputDirection = 9;
			}
		}
		if (Input.GetKey(KeyCode.W) &&
			Input.GetKey(KeyCode.D)){
			if (facingRight){
				inputDirection = 9;
			} else if (!facingRight) {
				inputDirection = 7;
			}
		}
		//returns the final input direction
		return inputDirection;
	}

	public int getAttackInput(){
		inputButton = getInputButton();
		int outputAttack = 0;

		//checks for light attacks
		if (inputButton[0] == 1){
			outputAttack = 1;
		}
		//checks for medium attacks
		if (inputButton[1] == 1){
			outputAttack = 2;
		}
		//checks for heavy attacks
		if (inputButton[2] == 1){
			outputAttack = 3;
		}
		//checks for special attacks (NOT SPECIAL MOVES)
		if (inputButton[3] == 1){
			outputAttack = 4;
		}
		
		//checks for multiple buttons
		combinedInput = inputButton[0] + inputButton[1] +
			inputButton[3] + inputButton[4];

		//returns throw if two buttons are pressed
		if (combinedInput == 2){
			outputAttack = 5;
		}
		//returns roman cancel if three buttons are pressed
		if (combinedInput == 3){
			outputAttack = 6;
		}
		//returns instant kill if four buttons are pressed
		if (combinedInput == 4){
			outputAttack = 7;
		}
		//returns the final attack output
		return outputAttack;
	}

	public int[] getInputButton(){
		int lightPressed   = 0;
		int medPressed     = 0;
		int heavyPressed   = 0;
		int specialPressed = 0;

		//checks the light attack button
		if (Input.GetKey(KeyCode.Y)){
			lightPressed = 1;
		}
		if (!Input.GetKey(KeyCode.Y)){
			lightPressed = 0;
		}
		
		//checks the medium attack button
		if (Input.GetKey(KeyCode.U)){
			medPressed = 1;
		}
		if (!Input.GetKey(KeyCode.U)){
			medPressed = 0;
		}

		//checks the heavy attack button
		if (Input.GetKey(KeyCode.I)){
			heavyPressed = 1;
		}
		if (!Input.GetKey(KeyCode.I)){
			heavyPressed = 0;
		}

		//checks the special attack button (NOT SPECIAL MOVES)
		if (Input.GetKey(KeyCode.H)){
			specialPressed = 1;
		}
		if (!Input.GetKey(KeyCode.H)){
			specialPressed = 0;
		}

		//collects inputs to be returned
		inputButton[0] = lightPressed;
		inputButton[1] = medPressed;
		inputButton[2] = heavyPressed;
		inputButton[3] = specialPressed;
		return inputButton;
	}
}
