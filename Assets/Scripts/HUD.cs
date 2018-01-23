using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] // persistir no estado do 9objeto de alguma forma.
public class HUD : MonoBehaviour {

    public Slider sliderHP;
    public Slider sliderFuel;

    public Text pointsText;
    public Text bombsText;

    private GameObject pDead;

    protected float fuel;
    protected float hp;

    protected Status status;
    public PlayerBehaviour player;

	void Start () {

        pDead = GameObject.FindWithTag("PanelGameOver");

        var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
        player = FindObjectOfType<PlayerBehaviour>();
        status = person.getStatus();
        sliderHP.maxValue = status.getHPMax();
        sliderFuel.maxValue = status.getFuelMax();

        hp = status.getHP();
        fuel = status.getFuel();

        pDead.SetActive(false);

    }
	
	void Update () {

        pointsText.text = "" + status.getCurrentPoints();
        bombsText.text = "0" + player.numBomb;

        sliderHP.value = status.getHP();
        sliderFuel.value = status.getFuel();

        if (status.isDead()) {
            pDead.SetActive(true);
        }

	}
      //ConsumeFuel();  Metodo será corrigido depois para o uso da mecanica de COMBUSTIVEL
    public void ConsumeFuel() {
    
        fuel -= Time.deltaTime;

        sliderFuel.value = fuel;
        //fuel = sliderFuel.value;

        if (sliderFuel.value <= 0) {
            fuel = 0;
            sliderHP.value -= Time.deltaTime;

            hp = sliderHP.value;
            if (sliderHP.value == 0) {
                hp = 0;
                //player.isDead();
               // Debug.Log("Morreu");

            }

        }
  
    }

}
