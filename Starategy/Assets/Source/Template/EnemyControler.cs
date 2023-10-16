using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler 
{
    public Archer Archer { get; set; }
    public Wooder Wooder { get; set; }
    public Robber Robber { get; set; }

    public EnemyControler(Archer _archer, Wooder _wooder, Robber _robber)
    {
        Archer = _archer;
        Wooder = _wooder;
        Robber = _robber;
    }

    public void EnemySpawn(ABaseEnemy _enemy)
    {
        EnemyTurnOff();
        _enemy.Animator.gameObject.SetActive(true);
        if (_enemy != Robber)
        {
            _enemy.Attack();
        }
    }

    public void EnemyTurnOff()
    {
        Archer.Animator.gameObject.SetActive(false);
        Wooder.Animator.gameObject.SetActive(false);
        Robber.Animator.gameObject.SetActive(false);
    }

}
