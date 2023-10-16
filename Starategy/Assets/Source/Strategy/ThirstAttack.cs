using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirstAttack : IAttackStrategy
{

    public int ID { get; set; }

    public ThirstAttack(string animName)
    {
        ID =  Animator.StringToHash(animName);
    }

    public void Atatck(Animator animator)
    {
        animator.SetTrigger(ID);
    }
}
