using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ABaseEnemy  
{
    public abstract Animator Animator { get; set; }
    public abstract int ID { get; set; }
    public abstract void Attack();
}
