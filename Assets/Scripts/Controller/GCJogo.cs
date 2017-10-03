using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCJogo : MonoBehaviour {

    private GameStatus gameStatus;
    //private IPersons player;

	void Start () {

        gameStatus = new GameStatus();
        DontDestroyOnLoad(this.gameObject);

        if (FindObjectsOfType<GCJogo>().Length > 1)
            Destroy(gameObject);

	}

    public GameStatus getGameStatus() {
        return gameStatus;
    }


    public void newGame(Status statusPlayer, GameObject player) {
        
        gameStatus.enableLevel = 1;
        gameStatus.player = player.GetComponent<IPersons>();
        gameStatus.status = statusPlayer;

    }

    public void loadGame(GameStatus gameStatus) {
        this.gameStatus = gameStatus;

    }

}
