using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DefaultNamespace
{
    [Serializable]
    public class RockTower : MonoBehaviour
    {
        public LifeController LifeController;
        public LifeBarController LifeBarController;

        Tower Tower;

        public void Awake()
        {
            Tower = new Tower();
            Tower.Life = 10;
            Tower.Range = 0;
            Tower.Attack = 0;
            Tower.AttackSpeed = 0;

            LifeController = new LifeController();
            LifeBarController = new LifeBarController();

            LifeController.OnDamage += OnDamage;
        }

        void OnDamage(int damageTaken, int totalLife)
        {
            //LifeBarController.UpdateFill(totalLife);
            LifeBarController.UpdateSprite(damageTaken, totalLife);
        }
    }
}