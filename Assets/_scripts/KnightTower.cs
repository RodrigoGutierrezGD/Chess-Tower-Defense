using System;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class KnightTower : MonoBehaviour
    {
        public LifeController LifeController;
        public LifeBarController LifeBarController;

        Tower Tower;

        public void Awake()
        {
            Tower = new Tower();
            Tower.Life = 5;
            Tower.Range = 3;
            Tower.Attack = 2;
            Tower.AttackSpeed = 1;

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