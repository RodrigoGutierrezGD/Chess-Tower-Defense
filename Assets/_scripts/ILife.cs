using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILife
{
    void DoDamage(int amount);
    void DoHeal(int amount);
}