using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Cylinder : MonoBehaviour
{
    private Transform _transform;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        GetRandomPosition();
        GetRandomColor();
    }

    private void GetRandomPosition()
    {
        transform.position = new Vector3(Random.Range(9f, -9f), 1f, Random.Range(9f, -9f));
    }

    private void GetRandomColor()
    {
        int colorNumber = Random.Range(1, 4);
        switch (colorNumber)
        {
            case 1:
                _renderer.material.color = Color.red;
                break;
            case 2:
                _renderer.material.color = Color.green;
                break;
            case 3:
                _renderer.material.color = Color.yellow;
                break;
        }
    }
}