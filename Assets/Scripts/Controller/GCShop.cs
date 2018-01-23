using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GCShop : MonoBehaviour {

    protected Status status;
    private GCPerson person;
    private PlayerBehaviour player;
    
    public GameObject hpPButton;
    public GameObject turbinePButton;
    public GameObject turbineSpeed;
    public GameObject endurencePButton;
    public GameObject cannonButton;
    public GameObject strengthPButton;
    public GameObject strengthForce;
    protected int valorStrength;

    //public Text perks;
    public Text souls, requered;
    public Text preHp, textHP;
    public Text preEndurence, textEndurence;
    public Text preSpeed, textSpeed;
    public Text preStrength;
    public Text textStrength;

    public bool inSpeed = false;
    public bool inEndurence = false;
    public bool inStrength = false;
    public bool ok = false;
    public bool canUp = false;

    public GameObject pConfirmation;

    protected GameStatus gameStatus;

	void Start () {
        
        var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
        status = person.getStatus();

        //var player - para incrementar a skill velocity.
        var player = GameObject.FindWithTag("Player").GetComponent<PlayerBehaviour>();

        textHP.text = status.getHPMax().ToString();
        textEndurence.text = status.getEndurence().ToString();
        textSpeed.text = player.velocity.ToString();
        textStrength.text = status.getAttack().ToString();


    }

    void Update() {

        souls.text = status.getCurrentPoints().ToString();
        requered.text = status.getRequired().ToString();

        upNivel();
    }

    public GCPerson getPerson() {
        return person;
    }

    public Status getStatus() {
        return status;
    }

    public GameStatus getGameStatus() {
        return gameStatus;
    }

    public void MainMenuButton() {

        SceneManager.LoadScene("Main");

    }

    //=============SKILLs=============================================

    public void Speed() {

        if(canUp == true) { 

            inSpeed = true;

            var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
            status = person.getStatus();

            var player = GameObject.FindWithTag("Player").GetComponent<PlayerBehaviour>();
 
            player.velocity += 0.2f;
            person.getStatus().setHPMax(status.getHPMax() + 3);

            preSpeed.text = /*player.velocity.ToString() + */"   ^" ;
            preHp.text = /*status.getHPMax().ToString() + */"   ^" ;

            textSpeed.text = player.velocity.ToString();
            textHP.text = status.getHPMax().ToString();

            turbineSpeed.SetActive(true);
            hpPButton.SetActive(true);
            pConfirmation.SetActive(true);

            textHP.color = new Color32(111, 179, 236, 255);
            textSpeed.color = new Color32(111, 179, 236, 255);//6FB3ECFF

        }

    }

    public void Endurence() {

        if (canUp == true)
        {

            inEndurence = true;

            var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
            status = person.getStatus();

            person.getStatus().setHPMax(status.getHPMax() + 3);
            person.getStatus().setEndurence(status.getEndurence() + 1);

            preHp.text = "   ^";
            preEndurence.text = "   ^";

            textHP.text = status.getHPMax().ToString();
            textEndurence.text = status.getEndurence().ToString();

            endurencePButton.SetActive(true);
            hpPButton.SetActive(true);
            pConfirmation.SetActive(true);

            textHP.color = new Color32(111, 179, 236, 255);
            textEndurence.color = new Color32(111, 179, 236, 255);

        }

    }

    public void Strength() {

        if (canUp == true) {

            inStrength = true;

            var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
            status = person.getStatus();

            person.getStatus().setHPMax(status.getHPMax() + 3);
            person.getStatus().setAttack(status.getAttack() + 3);

            preHp.text = /*status.getHPMax().ToString() + */"   ^";
            preStrength.text = /*status.getAttack().ToString() + */"    ^";
            //Geibim 988111785

            strengthPButton.SetActive(true);
            hpPButton.SetActive(true);
            pConfirmation.SetActive(true);

            textStrength.text = status.getAttack().ToString();
            textHP.text = status.getHPMax().ToString();

            textHP.color = new Color32(111, 179, 236, 255);
            textStrength.color = new Color32(111, 179, 236, 255);

        }

    }

    public void upNivel() {

        if (status.getCurrentPoints() < status.getRequired())
        {
            souls.color = Color.red;

            canUp = false;
        }

        else {
            canUp = true;
        }

    }

    public void Ok() {
        ok = true;

        preHp.text = null;
        preEndurence.text = null;
        preSpeed.text = null;
        preStrength.text = null;

        pConfirmation.SetActive(false);

        hpPButton.SetActive(false);
        turbineSpeed.SetActive(false);
        endurencePButton.SetActive(false);
        strengthPButton.SetActive(false);

        inSpeed = false;
        inStrength = false;
        inEndurence = false;

    }

    public void Cancel() {
        ok = false;
        pConfirmation.SetActive(false);

        preHp.text = null;
        preEndurence.text = null;
        preSpeed.text = null;
        preStrength.text = null;

        var person = GameObject.FindWithTag("Player").GetComponent<IPersons>();
        status = person.getStatus();
        var player = GameObject.FindWithTag("Player").GetComponent<PlayerBehaviour>();

        if (inSpeed) {
            player.velocity -= 0.2f;
            person.getStatus().setHPMax(status.getHPMax() - 3);

            textSpeed.text = player.velocity.ToString();
            textHP.text = status.getHPMax().ToString();

            textSpeed.color = Color.white;
            textHP.color = Color.white;

            turbineSpeed.SetActive(false);
            inSpeed = false;
        }
        if (inStrength) {
            person.getStatus().setHPMax(status.getHPMax() - 3);
            person.getStatus().setAttack(status.getAttack() - 3);

            textHP.text = status.getHPMax().ToString();
            textStrength.text = status.getAttack().ToString();

            textHP.color = Color.white;
            textStrength.color = Color.white;

            strengthPButton.SetActive(false);

            inStrength = false;

        }
        if (inEndurence) {
            person.getStatus().setHPMax(status.getHPMax() - 3);
            person.getStatus().setEndurence(status.getEndurence() - 1);

            textHP.text = status.getHPMax().ToString();
            textEndurence.text = status.getEndurence().ToString();

            textHP.color = Color.white;
            textEndurence.color = Color.white;

            endurencePButton.SetActive(false);

            inEndurence = false;

        }

        hpPButton.SetActive(false);

    }

     

}
