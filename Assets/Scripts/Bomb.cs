using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour {

    public GameObject prefabBullet;
    public GameObject gun;
    public GameObject particleBomb;
    public float fireRateTime;
    private float currentFireRateTime;
    public float lenghtPower;
    private bool canFire;


    void Start() {
        //StartCoroutine(Shot()); //forma de chamar metodo atraves de Courotine
        particleBomb.SetActive(false);
    }

    void Update() {

        //call script Player
        var player = GameObject.FindWithTag("Player").GetComponent<PlayerBehaviour>();

        // count for rateFire
        currentFireRateTime += Time.deltaTime;

        particleBomb.transform.position = new Vector3(gun.transform.position.x - 0.4f, gun.transform.position.y, 0);

        if (currentFireRateTime > fireRateTime && player.numBomb > 0) {
            canFire = true;

        }
        else {
            canFire = false;

        }

        if (Input.GetButton("Fire1") && canFire) {
            lenghtPower += Time.deltaTime;

            particleBomb.SetActive(true);
            StartCoroutine(Shot());
            currentFireRateTime = 0;
            
            if (lenghtPower <= 0 || lenghtPower > 0.4f)
            {
                particleBomb.SetActive(false);
                player.numBomb--;
                lenghtPower = 0;

            }

        }
        
        else if (Input.GetButtonUp("Fire1"))
        {
            particleBomb.SetActive(false);
        }
        
    }
    //Coroutine
    IEnumerator Shot() {

        InstancPrefab();
        yield return new WaitForSeconds(fireRateTime);

    }

    void InstancPrefab() {

        Instantiate(prefabBullet, transform.position, transform.rotation);
   
    }

}
