using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GCJogo : MonoBehaviour {

    private GameStatus gameStatus;
    public IPersons person;

    private string filePath;

	void Start () {

        person = GetComponentInChildren<IPersons>();

        gameStatus = new GameStatus();
        DontDestroyOnLoad(this.gameObject);

        if (FindObjectsOfType<GCJogo>().Length > 1)
            Destroy(gameObject);

    }


    public GameStatus getGameStatus() {
        return gameStatus;
    }


    public void newGame(Status statusPlayer, string player) {
        
        gameStatus.enableLevel = 1;
        gameStatus.player = player;
        gameStatus.status = statusPlayer;

    }

    public void Save() {

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(filePath);
        


    }

    public void loadGame(GameStatus gameStatus) {
        this.gameStatus = gameStatus;

    }

}
