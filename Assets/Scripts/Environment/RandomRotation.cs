using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour {

    public float speedRotation;

	void Update ()
    {
        Rotate();

    }

    private void Rotate()
    {
        transform.RotateAroundLocal(Vector3.forward, speedRotation * Time.deltaTime);
    }
}
