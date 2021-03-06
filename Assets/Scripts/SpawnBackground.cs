﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBackground : MonoBehaviour {
    private float XPos = 0;
    private float YPos = 0;
    [SerializeField] float backgroundOffset = 16;

    public GameObject prefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        XPos = transform.position.x;
        YPos = transform.position.y;
        Instantiate(prefab, new Vector2(XPos + backgroundOffset, YPos), Quaternion.identity);
    }
}
