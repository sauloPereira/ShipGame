using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public GameObject prefabBullet;
    public GameObject gun;
    public int damage;
    public float fireRateTime;
    private float currentFireRateTime;
    private bool canFire;

  
    void Start() {
        //StartCoroutine(Shot()); //forma de chamar metodo atraves de Courotine



    }
  
    void Update()
    {

        currentFireRateTime += Time.deltaTime; // count for rateFire

        if (currentFireRateTime > fireRateTime) {
            canFire = true;

        }
        else {
            canFire = false;

        }

        if (Input.GetButton("Jump") && canFire) {
            StartCoroutine(Shot());
            currentFireRateTime = 0;
        }

    }
    //Coroutine
    IEnumerator Shot() {

        InstancPrefab();
        yield return new WaitForSeconds(fireRateTime);
        //StartCoroutine(Shot());

    }

    void InstancPrefab() {
        /*
                var prefabBullet = Resources.Load("Prefabs/Projectiles/Bullet");
                var objBullet = GameObject.Instantiate(prefabBullet,
                    gun.transform.position, transform.rotation) as GameObject;
        */
        Instantiate(prefabBullet, gun.transform.position, transform.rotation);


    }

}
