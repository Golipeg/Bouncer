using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInstantiation : MonoBehaviour
{
    [SerializeField] private Sphere _spherePrefab;

    private void Start()
    {
        Instantiate(_spherePrefab);
    }
}
