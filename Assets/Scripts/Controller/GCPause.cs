
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GCPause : MonoBehaviour {

    public GameObject pause;
    [Space(10)]
    public Text souls;
    public Text requered;
    public Text textHP;
    public Text textEndurence;
    public Text textSpeed;
    public Text textStrength;
    protected Status status;
    private static bool pausado = false;

    void Start() {

        var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
        status = person.getStatus();
        var player = GameObject.FindWithTag("Player").GetComponent<PlayerBehaviour>();


        textHP.text = status.getHPMax().ToString();
        textEndurence.text = status.getEndurence().ToString();
        textSpeed.text = player.velocity.ToString();
        textStrength.text = status.getAttack().ToString();
        
    }

    public static bool getPausado() {
        return pausado;
    }

    void Update () {
        if (Input.GetButtonDown("Cancel")) {
            Pause(); 

        }

        souls.text = status.getCurrentPoints().ToString();
        requered.text = status.getRequired().ToString();

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

    public void Pause() {
        Time.timeScale = 0f;
        pause.SetActive(true);
        pausado = true;
    }
    

}
