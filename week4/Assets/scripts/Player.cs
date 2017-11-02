using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float mSpeed;
    public float mRotateSpeed;

    public float mMissileCooldown;
    public float mCooldownTimer;
    public GameObject missile;
  
	void Start () {
        mSpeed = 50f;
        mRotateSpeed = 24f;
        mMissileCooldown = 1f;
	}

    void Move()
    {
        Vector3 force = transform.up * mSpeed * Input.GetAxis("Vertical");

        this.GetComponent<Rigidbody2D>().AddForce(force);
        this.GetComponent<Rigidbody2D>().
            AddTorque(-1 * mRotateSpeed * Input.GetAxis("Horizontal"));

        // this way had tunneling issues
        // transform.Translate(0f, mSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f);
        //transform.Rotate(0f, 0f, -1 * mRotateSpeed * Input.GetAxis("Horizontal")); //rotates tank
    }

    void Attack()
    {
        mCooldownTimer -= Time.deltaTime;

        if (mCooldownTimer > 0)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            mCooldownTimer = mMissileCooldown;

            BoxCollider2D playerCollider = this.GetComponent<BoxCollider2D>();
            Vector3 newPosition = (transform.localPosition + (transform.up * playerCollider.size.y));
            newPosition.z = 0;

            GameObject missileClone = Instantiate(missile, newPosition, transform.rotation);
            missileClone.SetActive(true); 
            //The prefab is inactive because it would blow itself up
        }
    }
	
	// Update is called once per frame
	void Update () {

        Attack();
        Move();
    }

}

