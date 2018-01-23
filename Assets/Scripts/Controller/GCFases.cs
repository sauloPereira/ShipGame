using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GCFases : MonoBehaviour {

    public Text souls, required;
    public Text textHP;
    public Text textEndurence;
    public Text textSpeed;
    public Text textStrength;
    protected Status status;

    void Start () {

        var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
        status = person.getStatus();
        var player = GameObject.FindWithTag("Player").GetComponent<PlayerBehaviour>();

        textHP.text = status.getHPMax().ToString();
        textEndurence.text = status.getEndurence().ToString();
        textSpeed.text = player.velocity.ToString();
        textStrength.text = status.getAttack().ToString();

    }

	void Update () {

        souls.text = status.getCurrentPoints().ToString();
        required.text = status.getNivel().ToString();

	}

    public void fase1button() {
        SceneManager.LoadScene("Level1");
    }

    public void BackFases() {
        SceneManager.LoadScene("Main");

    }

}
