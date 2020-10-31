using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace DefaultNamespace
{
    [Serializable]
    public class RockTower : MonoBehaviour
    {
        //LifeController LifeController;

        Tower Tower;

        // Attack Controller

        public void Awake()
        {
            Tower = new Tower();
            Tower.Life = 5;
            Tower.Range = 3;
            Tower.Attack = 2;
            Tower.AttackSpeed = 1;
        }
    }
}