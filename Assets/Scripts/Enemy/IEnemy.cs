using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy {

    Status getStatus();
    void receiveDamage(int damage);

}
