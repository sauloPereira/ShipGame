using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCPerson : MonoBehaviour {

    public void newGame() {

        var GCGame = FindObjectOfType<GCJogo>();
        var person = GetComponentInChildren<IPersons>();

        var status = person.getStatus();
        var player = person.getPerson();

        GCGame.newGame(status, player);

    }


}
