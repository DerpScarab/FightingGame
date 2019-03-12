using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	InputScript Is    = GetComponent<InputScript>();
	StateCheck Sc     = GetComponent<StateCheck>();
	AttackManager Am  = GetComponent<AttackManager>();
	HitstunManager Hm = GetComponent<HitstunManager>();
	MoveData Md       = GetComponent<MoveData>();
	MovementScript Ms = GetComponent<MovementScript>();
	HitboxManager Bm  = GetComponent<HitboxManager>();
	UpdateState Us    = GetComponent<UpdateState>();
	int inputDirection;
	int inputButton;
	int state;

	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;
	}
	
	// Update is called once per frame
	void Update () {
		inputDirection = Is.getInputDirection();
		inputButton    = Is.getInputButton();
		state          = Sc.checkPlayerState();

		
		
	}
}
