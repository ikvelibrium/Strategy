using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackStrategy 
{
   int ID { get; set; }

    void Atatck(Animator animator);
}
