using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeStatus : MonoBehaviour {

    public int hp;

    protected Status status;


    private void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag.Equals("Player")) {
            getLife();

        }

    }

    public void getLife() {

        var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
        status = person.getStatus();

        person.recoverHP(hp);
        Debug.Log("Recuperou Life " + hp);

    }

}
