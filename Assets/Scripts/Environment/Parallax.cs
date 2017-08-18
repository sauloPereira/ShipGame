using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

    public float velocity;
    public Material texturMaterial;

	void Start () {
		
	}
	
	void Update () {

        texturMaterial.mainTextureOffset = new Vector2(0, Time.time * velocity);

	}
}
