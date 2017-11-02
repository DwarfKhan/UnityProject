using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Mssile : MonoBehaviour {

    public float mMissileForce;
    public float mDestroyTimer;
    public GameObject mMissile;


	// Use this for initialization
	void Start () {
        mMissileForce = 20f;
        mDestroyTimer = 10f;

        // so that the missile starts out moving
        Vector3 startingForce = this.transform.up * mMissileForce * 5;
        startingForce.z = 0f;
        this.GetComponent<Rigidbody2D>().AddForce(startingForce);
    }
	
	// Update is called once per frame
	void Update () {
        BlowUp(mDestroyTimer);
        mDestroyTimer -= Time.deltaTime;

        Vector3 force = this.transform.up * mMissileForce;
        force.z = 0f;

        this.GetComponent<Rigidbody2D>().AddForce(force);
	}

    void BlowUp(float timer)
    {
        if (false) //TODO: on collision blow up missile
        {
            Destroy(mMissile);
        }

        if(timer <= 0)
        {
            Destroy(mMissile);
        }

    }


}
