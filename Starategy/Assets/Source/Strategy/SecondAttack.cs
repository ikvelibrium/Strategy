using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondAttack : IAttackStrategy
{
    public int ID { get; set; }
    
    public SecondAttack(string animName)
    {
        ID = Animator.StringToHash(animName);
    }

    public void Atatck(Animator animator)
    {
        animator.SetTrigger(ID);
    }
}
