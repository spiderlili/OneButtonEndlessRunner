using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCamera : MonoBehaviour {
    [SerializeField]float cameraSpeed = 10;
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Player").GetComponent<PlayerControls>().isDead == false) {
            transform.Translate(transform.right * cameraSpeed * Time.deltaTime);
        }
	}
}
