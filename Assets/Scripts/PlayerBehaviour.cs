using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Limits {

    public float xMin, xMax, yMin, yMax;

}

public class PlayerBehaviour : MonoBehaviour, IPersons {

    public GameObject player;
    public float velocity;

    public Limits limits;

    protected Status status;
    protected SoulsStatus soulsStatus;

    public GameObject prefabImpacto;
    public GameObject prefabExplosion;

    public int bullet;
    public int laser;
    public int laserRed;
    public int blast;
    public GameObject bulletB;
    public GameObject bulletBII;
    public GameObject bulletBIII;
    public GameObject laserB;
    public GameObject laserBII;
    public GameObject laserBIII;
    public GameObject laserRedB;
    public GameObject laserRedBII;
    public GameObject laserRedBIII;
    public GameObject blastB;
    public GameObject blastBII;
    public GameObject blastBIII;
    [Space(10)]
    public GameObject bomb;
    public int numBomb;

    public bool bulletIII = false;

    void Awake() {

        status = new Status(50, 5, 20, 0);

    }

    void Start () {
    
        transform.position = new Vector3(0f, -3.96f, 0f);

	}

	void Update () {

        Move();

    }

    void Move() {

        float moveHorizontal = Input.GetAxis("Horizontal");// * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical");// * Time.deltaTime;


        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        GetComponent<Rigidbody2D>().velocity = movement * velocity;

        GetComponent<Rigidbody2D>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, limits.xMin, limits.xMax),
            Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, limits.yMin, limits.yMax),
            0f
        );

        /*
                transform.Translate(moveHorizontal * velocity, moveVertical * velocity, 0f);

                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, limits.xMin, limits.xMax),
                    Mathf.Clamp(transform.position.y, limits.yMin, limits.yMax),
                    0f
                );
        */
    }

    public void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "UpBullet") {
            laser = 0;
            laserRed = 0;
            blast = 0;
            bullet++;
            if (bullet <= 1) {
                bulletB.SetActive(true);
                bulletBII.SetActive(false);
                bulletBIII.SetActive(false);

                blastB.SetActive(false);
                blastBII.SetActive(false);
                blastBIII.SetActive(false);

                laserRedB.SetActive(false);
                laserRedBII.SetActive(false);
                laserRedBIII.SetActive(false);

                laserB.SetActive(false);
                laserBII.SetActive(false);
                laserBIII.SetActive(false);

            }
            else if (bullet <= 2) {
                bulletB.SetActive(false);
                bulletBII.SetActive(true);
                bulletBIII.SetActive(false);

                blastB.SetActive(false);
                blastBII.SetActive(false);
                blastBIII.SetActive(false);

                laserRedB.SetActive(false);
                laserRedBII.SetActive(false);
                laserRedBIII.SetActive(false);

                laserB.SetActive(false);
                laserBII.SetActive(false);
                laserBIII.SetActive(false);

            }
            else if (bullet >= 3) {
                
                bulletBIII.SetActive(true);
                bulletB.SetActive(false);
                bulletBII.SetActive(false);

                blastB.SetActive(false);
                blastBII.SetActive(false);
                blastBIII.SetActive(false);

                laserRedB.SetActive(false);
                laserRedBII.SetActive(false);
                laserRedBIII.SetActive(false);

                laserB.SetActive(false);
                laserBII.SetActive(false);
                laserBIII.SetActive(false);

                bulletIII = true;

            }


        }

        if (other.tag == "UpLaser") {
            bullet = 0;
            laserRed = 0;
            blast = 0;
            laser++;

            if (laser == 1)
            {
                laserB.SetActive(true);
                laserBII.SetActive(false);
                laserBIII.SetActive(false);

                blastB.SetActive(false);
                blastBII.SetActive(false);
                blastBIII.SetActive(false);

                bulletB.SetActive(false);
                bulletBII.SetActive(false);
                bulletBIII.SetActive(false);

                laserRedB.SetActive(false);
                laserRedBII.SetActive(false);
                laserRedBIII.SetActive(false);

            }
            else if (laser == 2)
            {
                laserB.SetActive(false);
                laserBII.SetActive(true);
                laserBIII.SetActive(false);

                blastBII.SetActive(false);
                blastB.SetActive(false);
                blastBIII.SetActive(false);

                bulletB.SetActive(false);
                bulletBII.SetActive(false);
                bulletBIII.SetActive(false);

                laserRedB.SetActive(false);
                laserRedBII.SetActive(false);
                laserRedBIII.SetActive(false);

            }
            else if (laser >= 3)
            {
                laserBIII.SetActive(true);
                laserB.SetActive(false);
                laserBII.SetActive(false);

                blastBIII.SetActive(false);
                blastBII.SetActive(false);
                blastB.SetActive(false);

                bulletBIII.SetActive(false);
                bulletB.SetActive(false);
                bulletBII.SetActive(false);

                laserRedB.SetActive(false);
                laserRedBII.SetActive(false);
                laserRedBIII.SetActive(false);

            }

        }

        if (other.tag == "UpLaserRed")
        {
            bullet = 0;
            laser = 0;
            blast = 0;

            laserRed++;

            if (laserRed == 1)
            {
                laserRedB.SetActive(true);
                laserRedBII.SetActive(false);
                laserRedBIII.SetActive(false);

                laserB.SetActive(false);
                laserBII.SetActive(false);
                laserBIII.SetActive(false);

                blastB.SetActive(false);
                blastBII.SetActive(false);
                blastBIII.SetActive(false);
  
                bulletB.SetActive(false);
                bulletBII.SetActive(false);
                bulletBIII.SetActive(false);

            }
            else if (laserRed == 2)
            {
                laserRedB.SetActive(false);
                laserRedBII.SetActive(true);
                laserRedBIII.SetActive(false);

                laserB.SetActive(false);
                laserBII.SetActive(false);
                laserBIII.SetActive(false);

                blastBII.SetActive(false);
                blastB.SetActive(false);
                blastBIII.SetActive(false);

                bulletB.SetActive(false);
                bulletBII.SetActive(false);
                bulletBIII.SetActive(false);

            }
            else if (laserRed >= 3)
            {
                laserRedBIII.SetActive(true);
                laserRedB.SetActive(false);
                laserRedBII.SetActive(false);

                laserBIII.SetActive(false);
                laserB.SetActive(false);
                laserBII.SetActive(false);

                blastBIII.SetActive(false);
                blastBII.SetActive(false);
                blastB.SetActive(false);

                bulletB.SetActive(false);
                bulletBII.SetActive(false);
                bulletBIII.SetActive(false);

            }

        }

        if (other.tag == "UpBlaster") {
            bullet = 0;
            laser = 0;
            laserRed = 0;
            blast++;
            
            if (blast == 1) {
                blastB.SetActive(true);
                blastBII.SetActive(false);
                blastBIII.SetActive(false);

                bulletB.SetActive(false);
                bulletBII.SetActive(false);
                bulletBIII.SetActive(false);

                laserRedB.SetActive(false);
                laserRedBII.SetActive(false);
                laserRedBIII.SetActive(false);

                laserB.SetActive(false);
                laserBII.SetActive(false);
                laserBIII.SetActive(false);

            }
            else if (blast == 2) {
                blastBII.SetActive(true);
                blastB.SetActive(false);
                blastBIII.SetActive(false);

                bulletB.SetActive(false);
                bulletBII.SetActive(false);
                bulletBIII.SetActive(false);

                laserRedB.SetActive(false);
                laserRedBII.SetActive(false);
                laserRedBIII.SetActive(false);

                laserB.SetActive(false);
                laserBII.SetActive(false);
                laserBIII.SetActive(false);

            }
            else if (blast == 3) {
                blastBIII.SetActive(true);
                blastBII.SetActive(false);
                blastB.SetActive(false);

                bulletB.SetActive(false);
                bulletBII.SetActive(false);
                bulletBIII.SetActive(false);

                laserRedB.SetActive(false);
                laserRedBII.SetActive(false);
                laserRedBIII.SetActive(false);

                laserB.SetActive(false);
                laserBII.SetActive(false);
                laserBIII.SetActive(false);

            }

        }

        if (other.tag == "points") {
            
        }

        if (other.tag == "bomb") {
            addBomb();

        }

        //==========Damage================

        if (other.tag == "Enemy") {
            ReceiveDamage(15);
        }

        Destroy(other.gameObject);

    }

    public Status getStatus() {
        return status;
    }

    public void ReceiveDamage(int damage) {
        status.inDamage(damage);

        if (status.isDead()) {
            isDead();

        }

        else {
            PrefabImpact();

        }

    }

    public int addBomb() {
        return numBomb++;
    }

    /*
    public void consumeFuel(float fuel) {
        status.consumeFuel(fuel);

        if () {
            status.isDead();
            isDead();
        }

    }
    */

    public void isDead() {
        if (status.isDead()) {
            //Destroy(player.gameObject);
            enabled = false;
            prefabExplosion.SetActive(true);
            PrefabExplosion();
        }
        player.SetActive(false);
        prefabExplosion.SetActive(false);

    }

    public void recoverHP(int valor) {
        status.recoverHP(valor);

    }

    public void recoverFuel(float valor) {
        status.recoverFuel(valor);

    }

    public void PrefabImpact() {
        Instantiate(prefabImpacto, transform.position, transform.rotation);

    }

    public void PrefabExplosion() {
        Instantiate(prefabExplosion, transform.position, transform.rotation);
        
    }

    public void addPoints(int souls) {
        status.addPoints(souls);
    }

    public void recoverSouls(int valor) {
        status.recoverPoints(valor);
    }

    public GameObject getPerson() {
        return player;
    }
}
