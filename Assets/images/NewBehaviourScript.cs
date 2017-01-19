using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public float timer;

	//public GameObject theCamera;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (timer > 0) 
		{
			timer -= Time.fixedDeltaTime;
		} 
		else 
		{
			Application.LoadLevel ("MainMenu");
		
		}
	}
}
