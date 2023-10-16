using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robber : ABaseEnemy
{
    public override Animator Animator { get; set; }
    public override int ID { get; set; }


    public override void Attack()
    {
        Animator.SetTrigger(ID);
    }

    public Robber(Animator _animator, string animName)
    {
        Animator = _animator;
        ID = Animator.StringToHash(animName);
    }
}
