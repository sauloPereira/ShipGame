using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCLevel : MonoBehaviour {

    public float part1;
    public float part2;
    public float partBoss;

    public float changeSpawnBullet;

    private float currentTime;

    public GameObject bombs;
    public GameObject[] enemies;
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
        if (currentTime >= changeSpawnBullet) {//>480
            bullets[1].SetActive(true);
            bullets[0].SetActive(false);
        }

        //Bombs
        if (currentTime >= 120) {


        }
		
	}
}
