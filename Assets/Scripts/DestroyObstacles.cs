using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to player
public class DestroyObstacles : MonoBehaviour {
    private GameObject obstacle;
    void Start()
    {
        obstacle = GameObject.FindWithTag("obstacle");
    }

    // Use this for initialization
    void Update () {
        obstacle = GameObject.FindWithTag("obstacle");
        if (transform.position.x > obstacle.transform.position.x + 5) {
            Destroy(obstacle);
        }
	}
	
}
