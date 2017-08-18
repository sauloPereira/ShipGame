using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HUD : MonoBehaviour {

    public Slider sliderHP;
    public Slider sliderFuel;

    public Text pointsText;
    public Text bombsText;

    protected float fuel;
    protected float hp;

    protected Status status;
    protected PlayerBehaviour player;

	void Start () {

        var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
        status = person.getStatus();
        sliderHP.maxValue = status.getHPMax();
        sliderFuel.maxValue = status.getFuelMax();

        hp = status.getHP();
        fuel = status.getFuel();

    }
	
	void Update () {

        pointsText.text = "000000" + status.getCurrentPoints();

        sliderHP.value = status.getHP();
        sliderFuel.value = status.getFuel();

        //ConsumeFuel();  Script será corrigido depois para o uso da mecanica de COMBUSTIVEL


	}

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
