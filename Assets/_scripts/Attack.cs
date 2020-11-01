using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Attack : IAttack
{
    public int Range;
    public int Damage;
    public int AttackSpeed;

    public Action<int> OnAttack;

    public void DoAttack(int amount)
    {

    }
}