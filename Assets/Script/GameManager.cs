using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Hitboxes
	public GameObject[] cubes;
    // spawnpoints
	public Transform[] points;
    // Song to play
    public AudioSource song;

    // Song's BPM
    public float beatPerMinute;

    // Timer for time progression
    private float timer;
    private bool isPlaying = false;
    private int score = 0;

    void Start()
    {
        PlaySaber();
    }

    void PlaySaber()
    {
        beatPerMinute /= 210;
        isPlaying = true;
        song.Play(0);
    }

    void FixedUpdate () {
        if (isPlaying)
        {
            if (timer > beatPerMinute && song.isPlaying)
            {
                GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);
                cube.transform.localPosition = Vector3.zero;
                cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
                timer -= beatPerMinute;
            }

            timer += Time.deltaTime;

            if (!song.isPlaying)
            {
                EndGame();
            }
        }
	}

    public void EndGame()
    {
        isPlaying = false;
        Debug.Log("Selesai coi, score: " + score);
    }

    public void ScoreModify(int n)
    {
        score += n;
    }
}
