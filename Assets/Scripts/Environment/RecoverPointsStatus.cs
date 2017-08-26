using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoverPointsStatus : MonoBehaviour {

    public int points;
    protected Status status;

    public void Update() {
        getAgainSouls();
    }

    /*
    void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag.Equals("Player")) {
            getAgainSouls();
        }

    }
    */
    public void getAgainSouls() {

        var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
        status = person.getStatus();

        points = status.getCurrentPoints();

        person.recoverSouls(points);

        //PlayerPrefs.SetInt("countSouls" ,points);

    }

}
