using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int strength;
    //public int damage;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag.Equals("Enemy")) {
            var enemy = other.gameObject.GetComponent<IEnemy>();
            enemy.receiveDamage(strength);
            Destroy(gameObject);

        }
        
    }

}