using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	public static int movespeed = 10;
	public Vector3 userDirection = Vector3.forward;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(userDirection * movespeed * Time.deltaTime); 
	}


}
