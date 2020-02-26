using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour {

	public LayerMask layer;
	private Vector3 previousPos;

    public GameManager gameManager;
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer)){
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 130)
            {
                gameManager.ScoreModify(3);
                Destroy(hit.transform.gameObject);
            }
            else
                gameManager.ScoreModify(1);            
        }	

		previousPos = transform.position;
	}
}
