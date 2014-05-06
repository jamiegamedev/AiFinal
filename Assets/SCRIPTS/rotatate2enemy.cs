﻿using UnityEngine;
using System.Collections;

public class rotatate2enemy : MonoBehaviour {


	private GameObject target;
	private Vector3 targetPoint;
	private Quaternion targetRotation;

	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag("Enemy");
	}
	
	// Update is called once per frame
	void Update () {
		targetPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z) - transform.position;
		targetRotation = Quaternion.LookRotation (-targetPoint, Vector3.up);
		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 0.8f);
	
	}
}


