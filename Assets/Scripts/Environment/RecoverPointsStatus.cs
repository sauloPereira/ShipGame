using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoverPointsStatus : MonoBehaviour {

    public int points;
    public static RecoverPointsStatus instance;
    protected Status status;


    public void Awake () {

        if (instance == null) {
            instance = this;
        }
        else if (this != instance){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

    }

    public void Update() {
        //getAgainSouls();
        
    }

    
    void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag.Equals("Player")) {
            getAgainSouls();
        }

    }
    

    public void getAgainSouls() {

        var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
        status = person.getStatus();

        points = status.getCurrentPoints();

        person.recoverSouls(points);

        //PlayerPrefs.SetInt("countSouls" ,points);

    }

}
