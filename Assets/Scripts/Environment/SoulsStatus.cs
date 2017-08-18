using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoulsStatus : MonoBehaviour {

    public int points;
    protected Status status;

    private void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag.Equals("Player")) {


        }

    }

    public int getSouls () {
        var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
        status = person.getStatus();

        person.addPoints(status.getCurrentPoints());

        return points;

	}
}
