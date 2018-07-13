using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour {
    public GameObject[] obstacles;
    private GameObject obj;
    private float XPos = 0;
    private int number = 0;
    private float randomPosition = 0;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", 1.5f, 1.6f);
	}

    private void Spawn() {
        if (GameObject.Find("Player").GetComponent<PlayerControls>().isDead == false) {
            number = Random.Range(0, 7);
            randomPosition = Random.Range(16, 25);
            XPos = transform.position.x + randomPosition;
            obj = obstacles[number] as GameObject;
            Instantiate(obj, new Vector2(XPos, obj.transform.position.y), Quaternion.identity);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
