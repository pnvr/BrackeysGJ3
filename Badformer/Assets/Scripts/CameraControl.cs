﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    Transform target;
    float speed = 5f;
    //public Vector2 offset = new Vector2(-3f, 1.5f);
    void Start() {
        target = GameObject.Find("Player").transform;
    }

    void Update() {
        //transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, -7.5f);
        //transform.rotation = Quaternion.LookRotation(target.position - transform.position, Vector3.up);

        transform.position = new Vector3(target.position.x, target.position.y, -10);

        //float interpolation = speed * Time.deltaTime;

        //Vector3 position = transform.position;
        //position.x = target.transform.position.x;
        //position.y = target.transform.position.y;
        //position.y = Mathf.Lerp(transform.position.y, target.transform.position.y, interpolation);
        //transform.position = position;

    }
}
