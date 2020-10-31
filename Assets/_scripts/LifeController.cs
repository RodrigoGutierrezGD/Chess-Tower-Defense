using System;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class LifeController : MonoBehaviour, ILife
    {
        public int Amount { get; private set; }
        
        public Action<int, int> OnDamage;
        public Action<int, int> OnHeal;

        public Action OnDead;
        
        public void DoDamage(int amount)
        {
            Amount -= amount;
            
            if (Amount <= 0)
                OnDead?.Invoke();
            else 
                OnDamage?.Invoke(amount, Amount);
        }
        
        public void DoHeal(int amount)
        {
            Amount += amount;
            OnHeal?.Invoke(amount, Amount);
        }
    }
}