using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackStrategy 
{
    Color color { get; set; }
    Animator attackAnim { get; set; }
    
    void buttonPicked();


        
}
