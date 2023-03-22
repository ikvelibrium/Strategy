using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondAttck : IAttackStrategy
{
    public Color color { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public Animator attackAnim { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    

    
    public void buttonPicked()
    {
        attackAnim.SetBool("SecondAttack", true);


    }
}
