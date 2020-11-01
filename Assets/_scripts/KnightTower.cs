using System;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class KnightTower : MonoBehaviour
    {
        public LifeController LifeController;
        public LifeBarController LifeBarController;

        public Attack Attack;

        public Transform actualTarget;

        Tower Tower;

        public void Awake()
        {
            Tower = new Tower();
            Tower.Life = 5;
            Tower.Range = 6;
            Tower.Attack = 2;
            Tower.AttackSpeed = 1;

            LifeController = new LifeController();
            LifeBarController = new LifeBarController();
            Attack = new Attack();

            LifeController.OnDamage += OnDamage; //acho que nao eh aqui
        }

        void OnDamage(int damageTaken, int totalLife)
        {
            //LifeBarController.UpdateFill(totalLife);
            LifeBarController.UpdateSprite(damageTaken, totalLife);
        }

        void DoAttack(int damage, int enemyLife)
        {
            //actualTarget.
        }

        void OnDead()
        {
            Destroy(gameObject);
        }

        void OnDisable()
        {

        }

        private void OnTriggerEnter(Collider hit)
        {
            if (actualTarget == null && hit.gameObject.name.Contains("Enemy"))
            {
                actualTarget = hit.transform;
                Attack.OnAttack += DoAttack;
            }
        }
    }
}