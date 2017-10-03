
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GCPause : MonoBehaviour {

    public GameObject pause;
    private static bool pausado = false;

    public static bool getPausado() {
        return pausado;
    }

    void Update () {
        if (Input.GetButtonDown("Cancel")){
            Time.timeScale = 0f;
            pause.SetActive(true);
            pausado = true;

        }
    }

    public void buttonBack() {
        Time.timeScale = 1f;
        pause.SetActive(false);
        pausado = false;

    }

    public void Home() {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1f;
    }

    public void Replay() {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }

    public void Pause() {}


}
