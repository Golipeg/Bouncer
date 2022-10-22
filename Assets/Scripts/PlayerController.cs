using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private LayerMask _layer;
    [SerializeField] private float _rayLength=30f;

    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hitInfo, _rayLength,_layer))
        {
            if (Input.GetMouseButtonDown(0))
            {
                var point = hitInfo.point;
                _player.StartMove(point);
            }
        }
    }
}
