using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionPlayer : MonoBehaviour {

    private PlayerBehaviour player;
    private Status status;

    public void Start() {
        player.prefabExplosion.SetActive(false);
    }

    public void Update() {
        if (getDie()) {
            player.prefabExplosion.SetActive(true);
        }
    }

    public bool getDie() {

        status = player.GetComponent<IPersons>().getStatus();//getStatus();

        if (status.getHP() <= 0) {
            player.PrefabExplosion();
            player.GetComponent<IPersons>().isDead();
        }
        return true;
    }

}
