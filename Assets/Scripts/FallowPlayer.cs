using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowPlayer : MonoBehaviour {

    //public GameObject player;
    public float velocity;


    void Update () {

        var player = GameObject.FindWithTag("Player");

        if (player == enabled) {
            Vector3 fallow = player.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, fallow, velocity * Time.deltaTime);
            //transform.Translate(transform.position * velocity * Time.deltaTime, player.transform);
            
        }
        else {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);

        }

	}
}
