using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEnemy : MonoBehaviour {

    public GameObject prefabBulletEnemy;
    public GameObject gunEnemy;
    public int damageEnemy;
    public float fireRateTimeEnemy;
    private float currentFireRateTimeEnemy;
    private bool canFireEnemy;

  
    void Update()
    {

        currentFireRateTimeEnemy += Time.deltaTime; // count for rateFire

        if (currentFireRateTimeEnemy > fireRateTimeEnemy) {
            canFireEnemy = true;
            StartCoroutine(ShotEnemy());
            currentFireRateTimeEnemy = 0;
        }
        else {
            canFireEnemy = false;

        }

    }
    //Coroutine
    IEnumerator ShotEnemy() {

        InstancPrefabEnemy();
        yield return new WaitForSeconds(fireRateTimeEnemy);


    }

    void InstancPrefabEnemy() {

        Instantiate(prefabBulletEnemy, gunEnemy.transform.position, transform.rotation);

    }

}
