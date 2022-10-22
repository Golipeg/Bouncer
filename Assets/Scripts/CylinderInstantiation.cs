using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderInstantiation : MonoBehaviour
{
    [SerializeField] private Cylinder _cylinderPrefab;
    [SerializeField] private float _cylinderQuantity;

    private void Start()
    {
        for (int i = 0; i < _cylinderQuantity; i++)
        {
            Instantiate(_cylinderPrefab);
        }
    }
}
