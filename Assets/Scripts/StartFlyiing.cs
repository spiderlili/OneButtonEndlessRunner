using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFlyiing : MonoBehaviour {
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        anim.SetTrigger("start");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
