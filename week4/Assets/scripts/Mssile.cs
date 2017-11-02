using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Mssile : MonoBehaviour {

public float mMissileSpeed;

	// Use this for initialization
	void Start () {
        mMissileSpeed = 0.3f;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 force = this.transform.up * mMissileSpeed;
        force.z = 0f;
        this.transform.position += force;
	}
}
