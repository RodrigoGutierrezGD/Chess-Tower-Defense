using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DefaultNamespace
{
    [Serializable]
    public class BishopTower : MonoBehaviour
    {
        //LifeController LifeController;

        Tower Tower;

        private void Awake()
        {
            Tower = new Tower();
            Tower.Life = 5;
            Tower.Range = 5;
            Tower.Attack = 1;
            Tower.AttackSpeed = 1;
        }

        private void OnTriggerEnter(Collider hit)
        {
            if(hit.gameObject.name.Contains("Enemy"))
            {

            }
        }
    }
}