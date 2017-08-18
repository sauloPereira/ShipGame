using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyContact : MonoBehaviour {

    public GameObject prefab;
    public GameObject prefabExplosion;


    public void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Enemy") {
            InstantPrefab();

        }

        if (other.tag == "bullet") {
            InstantPrefab();

        }

        if (other.tag == "laser") {
            InstantPrefab();

        }

        if (other.tag == "laserRed") {
            InstantPrefab();

        }

        if (other.tag == "blastB") {
            InstantPrefab();

        }

       // Destroy(other.gameObject);

    }

    public void InstantPrefab () {
        Instantiate(prefab, transform.position, transform.rotation);

    }
    public void PrefabExplosion() {
        Instantiate(prefabExplosion, transform.position, transform.rotation);

    }

}
