using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyIII : EnemyBehaviour {

    public float speed;
    public float speedMove;
    public float posRight;
    public float posLeft;
    private bool inPosition = true;
    private Vector2 currentVectorPos;
    private float currentTimePos;


    void Update()
    {

        currentTimePos += Time.deltaTime;

        currentVectorPos = new Vector2(transform.position.x, 0);

        transform.Translate(Vector3.up * speedMove * Time.deltaTime);



        if (inPosition)
        {
            transform.Translate(Vector3.left * speedMove * Time.deltaTime);
            if (currentTimePos >= posLeft)
            {
                inPosition = false;
                currentTimePos = 0;
            }

        }

        if (!inPosition)
        {
            transform.Translate(Vector3.right * speedMove * Time.deltaTime);
            if (currentTimePos >= posRight)
            {
                inPosition = true;
                currentTimePos = 0;
            }

        }

    }
}
