using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelStatus : MonoBehaviour {

    public float fuel;

    protected Status status;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Equals("Player")) {
            GetFuel(); 
        
        }

    }

    public void GetFuel() {

        var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
        status = person.getStatus();

        person.recoverFuel(fuel);

        Debug.Log("Recuperou Combustivel " + fuel);
    }
}
