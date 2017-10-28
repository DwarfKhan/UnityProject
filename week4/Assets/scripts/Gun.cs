using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public GameObject m_bullet = null;
    public float m_force = 100f;
	// Use this for initialization
	void Start () {
        Debug.Log("Game Object: " + m_bullet.name);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletClone = Instantiate(m_bullet.gameObject, transform.position, transform.rotation);
            Rigidbody rb = bulletClone.GetComponent<Rigidbody>();

            Vector3 force = rb.transform.forward * m_force;
            rb.AddForce(force);
        }
	}
}
