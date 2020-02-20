using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHitbox : MonoBehaviour {

	public int speed = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Time.deltaTime * transform.forward * speed;	
	}
}
