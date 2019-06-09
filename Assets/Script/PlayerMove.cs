using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    GameManager manager;

	// Use this for initialization
	void Start () {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * manager.Speed);
	}
}
