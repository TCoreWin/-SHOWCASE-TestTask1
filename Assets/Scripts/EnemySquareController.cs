using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySquareController : Singleton<EnemySquareController>
{
    EnemySquare[] enemySquares;

    private void Start()
    {
        enemySquares = FindObjectsOfType<EnemySquare>();
    }

    public EnemySquare[] GetEnemySquares()
    {
        if (enemySquares == null) return null;

        return enemySquares;
    }
}
