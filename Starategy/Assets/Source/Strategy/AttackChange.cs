using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackChange 
{
    private PlayerControler _player;
    private EnemyControler _enemy;
    private Button _firstAttackButton;
    private Button _secondAttackButton;
    private Button _thirdAttackButton;

    public AttackChange(PlayerControler player, Button firstAttackButton, Button secondAttackButton, Button thirdAttackButton, EnemyControler enemy)
    {
        _player = player;
        _enemy = enemy;
        _firstAttackButton = firstAttackButton;
        _secondAttackButton = secondAttackButton;
        _thirdAttackButton = thirdAttackButton;
        BindButtons();
    }
    private void SetAttack(IAttackStrategy attack, Button attackButton, ABaseEnemy enemyClass)
    {
        
        _player.SetStrategy(attack);
        _enemy.EnemySpawn(enemyClass);
    }
    private void BindButtons()
    {
        _firstAttackButton.onClick.AddListener(() => SetAttack(new ThirstAttack("Attack1"), _firstAttackButton, _enemy.Wooder));
        _secondAttackButton.onClick.AddListener(() => SetAttack(new SecondAttack("Attack2"), _secondAttackButton, _enemy.Archer));
        _thirdAttackButton.onClick.AddListener(() => SetAttack(new ThirdAttack("Attack3"), _thirdAttackButton, _enemy.Robber));
        _firstAttackButton.onClick.Invoke();
    }
}
