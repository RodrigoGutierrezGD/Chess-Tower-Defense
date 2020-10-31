using System;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class KnightTower : MonoBehaviour
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

            // LifeController
            // Inicializar LifeController
        }
    }
}