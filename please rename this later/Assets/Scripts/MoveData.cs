using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveData : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	public class perFrame
	{
		public int moveID;               //
		public int[][] boxID;            //stores [hurtbox][hitbox]
	  //public int hurtboxID;            //main ID of the hurtbox
	  //public int hitboxID;             //main ID of the hitbox
		public int[] hitGatlings;        //
		public int[] blockGatlings;      //
		public int[] whiffGatlings;      //
		public float gatlingDisplacement;//the amount the next chained move goes forwards
		public float landingRecovery;    //
	}

	public class hitboxData
	{
		public int   hitboxID;           //main ID of the hitbox
		public int   subHitboxID;        //sub ID for multiple hitboxes per frame
		public float hitboxXSize;        //X size of the hitbox
		public float hitboxYSize;        //Y size of the hitbox
		public float hitboxXOffset;      //X offset of the hitbox
		public float hitboxYOffset;      //Y offset of the hitbox
		public int   active;             //frames before the hitbox deactivates
		public int   blockType;          //[High, Mid, Low, Unblockable]
		public int   attribute;          //[Head, Body, Foot, Throw, Projectile]
		public int   forcedState;        //state forced on ground hit [none, stand, crouch, launch]
		public int[] whiffState;         //states a move doesn't hit [none, stand, crouch, grounded, airborn]
		public int   damage;             //damage dealt by the move
		public int   level;              //level (dictates hitstun/blockstun etc.)
		public float chipMultiplier;     //adjusts the damage dealt if blocked
		public float hitstunBonus;       //adds this value to hitstun
		public float airHitstunBonus;    //adds this value to air hitstun
		public float meterMultiplier;    //multiplies meter gain by this value (0 for supers)
		public float minDamageMultiplier;//changes the minimum damage
		public int[] hitEffect;          //effect on hit (none, ground bounce, wall bounce, crumple, soft knockdown, hard knockdown)
		public int[] airHitEffect;       //effect on hit vs airborn (none, ground bounce, wall bounce, crumple, soft knockdown, hard knockdown)
		public int[] counterHitEffect;   //effect on counterhit (none, ground bounce, wall bounce, crumple, soft knockdown, hard knockdown)
		public int[] airCounterHitEffect;//effect on counterhit vs airborn (none, ground bounce, wall bounce, crumple, soft knockdown, hard knockdown)
		public int   groundSendAngle;    //knockback angle vs. ground
		public int   airSendAngle;       //knockback angle vs. air
		public int   groundKB;           //knockback vs. ground
		public int   airKB;              //knockback vs. air
		public int   transitionOnHit;    //transitions into a different animaiton on hit (like a throw)
	}

	public class hurtboxData
	{
		public int hurtboxID;         //main ID of the hurtbox
		public int subHurtboxID;      //sub ID for multiple hurtboxes per frame
		public bool[] invulnerability;//what the move doesn't check
		public int counterHit;        //if the move can be counter hit on that frame [no, normal, fatal]
		public float hurtboxXSize;    //X size of the hurtbox
		public float hurtboxYSize;    //Y size of the hurtbox
		public float hurtboxXOffset;  //X offset of the hurtbox
		public float hurtboxYOffset;  //Y offset of the hurtbox
		public float collisionXSize;  //X size of the collision box
		public float collisionYSize;  //Y size of the collision box
		public float collisionXOffset;//X offset of the collision box
		public float collisionYOffset;//Y offset of the collision box
		public float xMovement;       //X movement
		public float yMovement;       //Y movement
	}
}
