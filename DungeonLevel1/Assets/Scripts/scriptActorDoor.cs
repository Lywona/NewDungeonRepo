using UnityEngine;
using System.Collections;

public class scriptActorDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Play()
	{
		//Debug.Log("The Door Opened");
		animation.Play("Door Slide");
	}
}
