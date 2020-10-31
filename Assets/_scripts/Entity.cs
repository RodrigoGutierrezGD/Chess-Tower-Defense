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

    public interface ILife
    {
        void DoDamage(int amount);
        void DoHeal(int amount);
    }

    public interface IAttack
    {
        void DoAttack(int amount);
    }
    
    [Serializable]
    public class Attack : IAttack
    {
        public int Range;
        public int Damage;
        public int AttackSpeed;
        
        public void DoAttack(int amount)
        {
            
        }
    }
    
    public class Entity : MonoBehaviour
    {
        public LifeController LifeController;
        public LifeBarController LifeBarController;

        public void Awake()
        {
            LifeController = new LifeController();
            LifeBarController = new LifeBarController();

            LifeController.OnDamage += (damageTaken, totalLife) => 
            {
                LifeBarController.UpdateFill(totalLife);
            };
        }

        public void MyUpdate()
        {
            
        }

        private void OnTriggerEnter(Collider other)
        {
            
        }
    }

    public enum State
    {
        PAUSE,
        PLAYING,
    }
    
    public class GameController : MonoBehaviour
    {
        public List<Entity> Entities;

        public State GameState;
        
        // Object Pool
        
        // Interface - UI
        // Controlador do Jogo

        public void Update()
        {
            if (GameState == State.PLAYING)
            {
                foreach (var entity in Entities)
                {
                    entity.MyUpdate();
                }
            }
        }
    }

    [Serializable]
    public class Movement
    {
        // Cuida de toda movimentação
    }

    // public class Tower : MonoBehaviour
    // {
    //     // Life Controller
    //     // Movement Controller
    //     // Attack Controller
    // }

    public class TankTower : MonoBehaviour
    {
        // Life Controller
        
        private void OnTriggerEnter(Collider other)
        {
            // Tem buscar os inimigos
            // Forcar os inimigos 
            
            
        }
    }
}