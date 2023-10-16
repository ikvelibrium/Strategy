using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wooder : ABaseEnemy
{
    public override Animator Animator { get; set; }
    public override int ID { get; set; }

    public override void Attack()
    {
        
    }

    public Wooder(Animator _animator, string animName)
    {
        ID = Animator.StringToHash(animName);
        Animator = _animator;
    }
}
