using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public interface IDamageble
{
    public void GetDamage(int damage);

    public void DoDamage(CardStats EnemyCard);
}

