using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DefaultNamespace
{
    [Serializable]
    public class BishopTower : MonoBehaviour
    {
        public LifeController LifeController;
        public LifeBarController LifeBarController;
        public Attack Attack;

        Tower Tower;

        private void Awake()
        {
            Tower = new Tower();
            Tower.Life = 5;
            Tower.Range = 5;
            Tower.Attack = 1;
            Tower.AttackSpeed = 1;

            LifeController = new LifeController();
            LifeBarController = new LifeBarController();
            Attack = new Attack();

            LifeController.OnDamage += OnDamage;
        }

        void OnDamage(int damageTaken, int totalLife)
        {
            //LifeBarController.UpdateFill(totalLife);
            LifeBarController.UpdateSprite(damageTaken, totalLife);
        }

        private void OnTriggerEnter(Collider hit)
        {
            if(hit.gameObject.name.Contains("Enemy"))
            {
                //if(hit.gameObject)
            }
        }
    }
}