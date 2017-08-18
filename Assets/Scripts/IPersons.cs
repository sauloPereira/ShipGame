using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPersons {

    Status getStatus();
    void ReceiveDamage(int damage);
    void recoverHP(int valor);
    void recoverFuel(float valor);
    void addPoints(int souls);
    void recoverSouls(int valor);
    void isDead();
    

}
