using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler 
{
    private IAttackStrategy _attack;
    private Animator _playerAnim;

    public PlayerControler(Animator playerAnim)
    {
        _playerAnim = playerAnim;
    }
    public void SetStrategy(IAttackStrategy attackType)
    {
        _attack = attackType;
    }

    public void PerformAttack()
    {
        _attack.Atatck(_playerAnim);
    }
}
