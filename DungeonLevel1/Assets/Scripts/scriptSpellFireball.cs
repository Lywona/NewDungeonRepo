using UnityEngine;
using System.Collections;

public class scriptSpellFireball : MonoBehaviour 
{
	// Public Variables
	public int force = 100;
	
	// Private Variables

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Gives the object a velocity in the forward direction that the player was facing when firing.
		// The coroutine handles the fireball's death 2 seconds after it is spawned.
		rigidbody.velocity = transform.TransformDirection (Vector3.forward * force);
		StartCoroutine(LifeTime(2.0f));
	}
	
	// Coroutine
	IEnumerator LifeTime (float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		Destroy(gameObject);
	}
}
