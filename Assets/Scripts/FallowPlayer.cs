using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowPlayer : MonoBehaviour {

    //public GameObject player;
    public float velocity;

    void Start() {

    }

    void Update () {

        var player = GameObject.FindWithTag("Player");

        Vector3 fallow = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, fallow, velocity * Time.deltaTime);
        //transform.Translate(transform.position * velocity * Time.deltaTime, player.transform);
		
	}
}
