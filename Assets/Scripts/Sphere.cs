using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Sphere : MonoBehaviour
{
   private Renderer _renderer;
   private Sphere _sphere;

   private void Awake()
   {
      _renderer = GetComponent<Renderer>();
   }
   private void Start()
   {
      GetRandomColor();
      GetRandomPosition();
      
   }
   private void OnTriggerEnter(Collider other)
   {
      Player _player = other.GetComponent<Player>();
      if (_player != null)
      {
         _player.Renderer.material.color = _renderer.material.color;
         GetRandomPosition();
         GetRandomColor();
      }
   }
   private void GetRandomPosition()
   {
      transform.position = new Vector3(Random.Range(9f, -9f), 0.5f, Random.Range(9f, -9f));
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
