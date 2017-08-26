using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehaviour : MonoBehaviour, IEnemy {

    protected float velocityEnemy = 2;
    protected Status status;
    public GameObject souls;
    
    protected virtual void Awake() {

        this.gameObject.tag = "Enemy";
        this.gameObject.layer = 9;

        //int points = souls.getSouls();

        status = new Status(20, 5, 0, 0); // HP | Force | Fuel | Souls(points)

    }

    protected void MoveEnemy () {

        transform.Translate(Vector3.up * velocityEnemy * Time.deltaTime);
	
	}

    public void receiveDamage(int damage) {

        status.inDamage(damage);
        if (status.isDead()) {
            Destroy(this.gameObject);

            Instantiate(souls, transform.position, transform.rotation);

        }
        else {
            GetComponent<SpriteRenderer>().color = Color.red;
            Invoke("colorNormal", 0.3f);
        }
    }

    void colorNormal() {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

     public Status getStatus() {
        return status;
    }

}