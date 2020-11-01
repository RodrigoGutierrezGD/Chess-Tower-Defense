using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class TowerController : MonoBehaviour //nao to usando esta classe
    {
        Tower[] Towers;
        
        void Awake()
        {
            Towers = new Tower[3];

            Tower bishopTower = new Tower();
            bishopTower.Life = 5;
            bishopTower.Range = 5;
            bishopTower.Attack = 1;
            bishopTower.AttackSpeed = 1;

            Tower knightTower = new Tower();
            knightTower.Life = 5;
            knightTower.Range = 3;
            knightTower.Attack = 2;
            knightTower.AttackSpeed = 1;

            Tower rockTower = new Tower();
            rockTower.Life = 10;
            rockTower.Range = 0;
            rockTower.Attack = 0;
            rockTower.AttackSpeed = 0;
        }
    }
}