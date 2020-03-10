using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareActor : MonoBehaviour
{
    public Transform minPoint;
    public Transform maxPoint;

    SpriteRenderer[] spriteRenderer;

    private void Awake()
    {
        maxPoint = GetComponentsInChildren<Transform>()[1];
        minPoint = GetComponentsInChildren<Transform>()[2];

        spriteRenderer = GetComponentsInChildren<SpriteRenderer>();
    }

    public void ChangeColor(Color color)
    {
        foreach (var sprite in spriteRenderer)
        {
            sprite.color = color;
        }
    }
}
