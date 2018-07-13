using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenDead : MonoBehaviour {
    private float CameraXPos;
    [SerializeField] float cameraDeadPos = 20;
	// Update is called once per frame
	void Update () {
        if (CameraXPos > transform.position.x + cameraDeadPos) {
            Destroy(gameObject);
        }
	}
}
