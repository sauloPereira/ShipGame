using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCCamera : MonoBehaviour {

	void Start () {

        if (PlayerPrefs.GetInt("volume") == 1)
            EnableSound();
        else
            DisableSound();
	
	}

    public void EnableSound() {
        AudioListener.volume = 1;

    }

    public void DisableSound() {
        AudioListener.volume = 0;

    }

}
