using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
    }
	
	void LateUpdate () {
        Vector3 tempPOS;
        tempPOS = player.transform.position;
        tempPOS.y = this.transform.position.y;
        tempPOS.z = this.transform.position.z;
        transform.position = tempPOS;
    }
}
