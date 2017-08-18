using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeProjectles : MonoBehaviour {

    public int lifeTime;

	void Update () {

        Destroy(gameObject, (int)lifeTime);

	}
}
