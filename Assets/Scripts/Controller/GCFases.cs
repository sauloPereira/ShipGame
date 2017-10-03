using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GCFases : MonoBehaviour {



	void Start () {
		
	}

	void Update () {
		
	}

    public void fase1button() {
        SceneManager.LoadScene("Level1");
    }

    public void BackFases() {
        SceneManager.LoadScene("Main");

    }

}
