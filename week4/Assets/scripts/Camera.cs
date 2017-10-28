using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Quaternion baseRotation;
    public Vector3 baseTranslation;
    public Transform player;
        Vector3 newPosition;
    
    
	// Use this for initialization
	void Start () {
        baseRotation = transform.localRotation;
	}

    // Update is called once per frame
    void Update() {
        newPosition.x = player.transform.position.x;
        newPosition.y = player.transform.position.y;
        newPosition.z = (player.transform.position.z - 1);

        transform.SetPositionAndRotation(newPosition, baseRotation);
	}
}
