using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBehaviourII : EnemyBehaviour {

    protected float currentTime;
    protected float waitTime;
    public bool inTime;

	protected void MoveEnemyStop () {

        currentTime += Time.deltaTime;

        if (!inTime) {
            MoveEnemy();

        }

        if (currentTime <= 1 && inTime == false) {
            MoveEnemy();
        }

        if (currentTime >= 1) {
            velocityEnemy = 0;
            inTime = true;

            if (velocityEnemy == 0 && inTime) {
                waitTime += Time.deltaTime;

            }
            if (waitTime >= 2) {
                currentTime = 0;
                inTime = false;
                velocityEnemy = 2;
                waitTime = 0;
            }


        }
        

	}
}
