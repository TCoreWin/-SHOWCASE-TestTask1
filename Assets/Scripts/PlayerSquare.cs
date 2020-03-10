using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSquare : SquareActor
{
    [SerializeField] float speed = 2f;

    private void Update()
    {
        Vector2 moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.Translate(moveVector * Time.deltaTime * speed);

        CheckCollision();
    }

    void CheckCollision()
    {
        EnemySquare[] enemy = EnemySquareController.Instance.GetEnemySquares();

        for (int i = 0; i < enemy.Length; i++)
        {
            if (minPoint.position.x > enemy[i].minPoint.position.x &&
                minPoint.position.y > enemy[i].minPoint.position.y &&
                maxPoint.position.x < enemy[i].maxPoint.position.x &&
                maxPoint.position.y < enemy[i].maxPoint.position.y)
            {
                ChangeColor(Color.green);
                return;
            }
        }
        
        ChangeColor(Color.red);
    }
}
