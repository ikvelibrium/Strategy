using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackChange 
{
    private PlayerControler _player;
    private Button _firstAttackButton;
    private Button _secondAttackButton;
    private Button _thirdAttackButton;

    public AttackChange(PlayerControler player, Button firstAttackButton, Button secondAttackButton, Button thirdAttackButton)
    {
        _player = player;

        _firstAttackButton = firstAttackButton;
        _secondAttackButton = secondAttackButton;
        _thirdAttackButton = thirdAttackButton;
        BindButtons();
    }
    private void SetAttack(IAttackStrategy attack, Button attackButton)
    {
        
        _player.SetStrategy(attack);
       
    }
    private void BindButtons()
    {
        _firstAttackButton.onClick.AddListener(() => SetAttack(new ThirstAttack("Attack1"), _firstAttackButton));
        _secondAttackButton.onClick.AddListener(() => SetAttack(new SecondAttack("Attack2"), _secondAttackButton));
        _thirdAttackButton.onClick.AddListener(() => SetAttack(new ThirdAttack("Attack3"), _thirdAttackButton));
        _firstAttackButton.onClick.Invoke();
    }
}
