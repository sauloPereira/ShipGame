using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroStatus : EnemyBehaviour {


    protected override void Awake() {

        status = new Status(30, 0, 1, 0, 0);
        
    }

}
