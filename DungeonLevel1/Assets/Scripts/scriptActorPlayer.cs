using UnityEngine;
using System.Collections;

public class scriptActorPlayer : MonoBehaviour {
	
	// Public Variables
	public Transform fireball;
	public float spawnDistance = 5;
	
	// Private Variables
	private Rigidbody projectile;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonDown("Fire1"))
		{
			// Instantiates the chosen projectile at the players rotation and a bit in front of the player.
			projectile = (Rigidbody)Instantiate(fireball.rigidbody, transform.position + spawnDistance * transform.forward, transform.rotation);
			
		}
		
	}
	
	
}
