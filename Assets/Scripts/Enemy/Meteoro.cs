using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour {

    private float velocityMeteoro = 2;

    private void Update() {
        transform.Translate(Vector3.up * velocityMeteoro * Time.deltaTime);

    }

}
