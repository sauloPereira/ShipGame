using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour {

    public int damage;

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Equals("Player")) {
            var person = other.gameObject.GetComponent<IPersons>();
            person.ReceiveDamage(damage);

        }

    }

}
