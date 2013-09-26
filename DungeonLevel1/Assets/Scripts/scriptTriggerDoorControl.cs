using UnityEngine;
using System.Collections;

public class scriptTriggerDoorControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter(Collider hit)
	{
		if (hit.collider.name=="Player")
		{
			//Debug.Log("Door Triggered");
			scriptActorDoor DoorSlide=GameObject.FindGameObjectWithTag("Door").GetComponent<scriptActorDoor>();
			DoorSlide.Play();
		}
		
	}
}
