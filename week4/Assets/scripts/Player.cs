using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float mSpeed;
    public float mRotateSpeed;
    public GameObject missile;
  
	void Start () {
        mSpeed = 8f;
        mRotateSpeed = 3f;

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
            GameObject missileClone = Instantiate(missile, transform.localPosition, transform.rotation);

        }
    }
	
	// Update is called once per frame
	void Update () {

        Attack();
        Move();
    }

}

