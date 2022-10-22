using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    private Vector3 _target;// точка ,куда наш кубик будет двигаться
    private float _stoppingDistance = 0.1f;// расстояние до точки, на котором кубик должен будет остановиться
    private bool _isMoving;// будем проверять в движении наш кубик или нет

    public void StartMove(Vector3 target)
    {
        _isMoving = true;
        _target = new Vector3(target.x, transform.position.y, target.z);
        
        
    }
    private void Update()
    {
        if (!_isMoving)// если объект стоит , то ничего не делаем, выходим из метода.
        {
            return;
        }

        var destinationDistance = Vector3.Distance(_target, transform.position);// узнаем расстояние между объектом и точкой назначения
        var shouldStop = destinationDistance < _stoppingDistance;// флаг для остановки объекта. 
        if (shouldStop)
        {
            _isMoving = false;// меняем состояние объекта с движения на остановку .
            return;
        }

        var step = Time.deltaTime * _speed;//шаг,который кубик пройдёт за один update;
        transform.position = Vector3.MoveTowards(transform.position, _target, step);


    }
}
