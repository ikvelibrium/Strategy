using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdAttack : IAttackStrategy
{
    public int ID { get; set; }

    public ThirdAttack(string animName)
    {
        ID = Animator.StringToHash(animName);
       
    }
    public void Atatck(Animator animator)
    {
        animator.SetTrigger(ID);
    }
}
