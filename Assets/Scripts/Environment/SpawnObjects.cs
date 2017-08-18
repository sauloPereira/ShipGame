using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public float x;
    public float minWidth;
    public float medianWidth;
    public float maxWidth;
    public float rateSpawn;
    private int posicao;
    public GameObject prefab;

    private float currentRateSpawn;

	void Start () {

        currentRateSpawn = 0;

	}
	
	void Update () {

        currentRateSpawn += Time.deltaTime;

        if (currentRateSpawn >= rateSpawn) {
            currentRateSpawn = 0;

            GameObject timePrefab = Instantiate(prefab) as GameObject;
            posicao = Random.Range(0, 3);

            if (posicao == 0/*< 33*/)
            {
                x = minWidth;

            }
            if (posicao == 1/*> 33 && posicao < 66*/)
            {
                x = medianWidth;

            }
            if (posicao == 2/*> 66*/)
            {
                x = maxWidth;
            }


            timePrefab.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }

	}
}
