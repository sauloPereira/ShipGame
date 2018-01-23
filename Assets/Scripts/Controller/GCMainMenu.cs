using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GCMainMenu : MonoBehaviour {

    public GameObject mainMenuP;
    public GameObject optionsP;
    public new GCCamera camera;

    public IPersons person;


    public void Start() {

        person = GetComponentInChildren<IPersons>();

    }

    public void NewGame() {
        /*
        var gcGame = FindObjectOfType<GCJogo>();
        

        var status = person.getStatus();
        var prefabPerson = person.getPerson();
        gcGame.newGame(status, prefabPerson);
        */
        SceneManager.LoadScene("FasesMenu");
        
    }

    public void Shop() {
        SceneManager.LoadScene("Shop");

    }

    public void Options() {
        mainMenuP.SetActive(false);
        optionsP.SetActive(true);

    }

    public void Volume() {



    }

    public void Back() {

        mainMenuP.SetActive(true);
        optionsP.SetActive(false);

    }

    public void Sair() {

        Application.Quit();


    }

}
