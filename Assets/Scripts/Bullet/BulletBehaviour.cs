using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public float velocity;
    public float limit;

	void Update () {

        transform.Translate(Vector3.up * velocity * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D other) {

        Destroy(gameObject);

    }



}
