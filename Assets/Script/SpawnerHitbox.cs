using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerHitbox : MonoBehaviour {

	public GameObject[] cubes;
	public Transform[] points;

    // Insert the song's BPM
    public float beatPerMinute;

    // Timer for time progression
    private float timer;

    void Start()
    {
        beatPerMinute /= 210;   
    }

    // Update is called once per frame
    void Update () {
		if (timer > beatPerMinute){
			GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);
			cube.transform.localPosition = Vector3.zero;
			cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
			timer -= beatPerMinute;
		}

		timer += Time.deltaTime;
	}
}
