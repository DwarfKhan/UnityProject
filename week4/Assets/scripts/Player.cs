using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float mSpeed;
    public float mRotateSpeed;
    public float mMissileForce;
    public GameObject missile;
  
	void Start () {
        mSpeed = 8f;
        mRotateSpeed = 3f;
        mMissileForce = 1f;
	}

    void Move()
    {
        transform.Translate(0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f);
        transform.Rotate(0f, 0f, -1 * mRotateSpeed * Input.GetAxis("Horizontal")); //rotates tank
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 newPosition = (transform.localPosition + (transform.up * 3));
            newPosition.z = 0;
            GameObject missileClone = Instantiate(missile, newPosition, transform.rotation);
          


        }
    }
	
	// Update is called once per frame
	void Update () {

        Attack();
        Move();
    }

}

