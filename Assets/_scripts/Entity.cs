using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    /*    Entitidades:
     *     - Player
     *         - Vida
     *     - Torre
     *         - Vida
     *     - Inimigo
     *         - Vida
     *
     *     - Bispo
     *         - Vida
     *         - Ataque
     *         - Movimento
     *     - Peao
     *         - Vida
     *     - Cavalo
     *         - Vida
     *
     *     - Vida
     *         - Adicionar Vida
     *         - Retirar Vida
     *             - Quando acabar, a vida informa que acabou.

     */


    

    
    public class Entity : MonoBehaviour
    {
        public LifeController LifeController;
        public LifeBarController LifeBarController;

        public void Awake()
        {
            LifeController = new LifeController();
            LifeBarController = new LifeBarController();

            LifeController.OnDamage += OnDamage;
        }

        /*void OnDamage(int damageTaken, int totalLife)
        {
            LifeBarController.UpdateFill(totalLife);
        }*/

        void OnDamage(int damageTaken, int totalLife)
        {
            //LifeBarController.UpdateSprite(damageTaken);
        }
    }
}