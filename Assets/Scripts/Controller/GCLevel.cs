using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class GCLevel : MonoBehaviour {

    public float part1;
    public float part2;
    public float partBoss;

    private float timeRecoverPoints;
    protected Status status;
    public GameObject recoverSouls;

    public PlayerBehaviour player;

    private bool inDead = true;

    private float currentTime;

    public GameObject bombs;
    public GameObject[] enemies;
    [Space(10)]
    public float changeSpawnBullet;
    public GameObject[] bullets;
    public GameObject boss;

    void Start(){

        enemies[0].SetActive(true);

    }

    void Update () {

        currentTime += Time.deltaTime;

        //Enemies
        if (currentTime >= part1) {//120
            enemies[1].SetActive(true);

        }
        if (currentTime >= part2) {//480
            enemies[2].SetActive(true);

        }
        if (currentTime > partBoss) {//600
            enemies[0].SetActive(false);
            enemies[1].SetActive(false);
            enemies[2].SetActive(false);

        }
        //Bullets
        if (currentTime < changeSpawnBullet) {//<480
            bullets[0].SetActive(true);
            bullets[1].SetActive(false);
        }
        if (currentTime >= changeSpawnBullet || player.bulletIII == true) {//>480
            bullets[1].SetActive(true);
            bullets[0].SetActive(false);
        }
        //Bombs
        if (currentTime >= 120) {
            bombs.SetActive(true);

        }

        status = player.getStatus();

        if (status.isDead()) {

            timeRecoverPoints = currentTime;

            if (!status.isDead() && currentTime == timeRecoverPoints) {
                recoverSouls.SetActive(true);

                timeRecoverPoints = 0;
            }

        }
        
	}

}
