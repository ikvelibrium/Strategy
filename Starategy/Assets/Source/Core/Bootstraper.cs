using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bootstraper : MonoBehaviour
{
    [SerializeField] private Animator _playerAnim;

    [SerializeField] private Button _firstAttackButton;
    [SerializeField] private Button _secondAttackButton;
    [SerializeField] private Button _thirdAttackButton;

    [SerializeField] private PlayerControler _player;


    void Start()
    {
        _player = new PlayerControler(_playerAnim);
        new AttackChange(_player, _firstAttackButton, _secondAttackButton, _thirdAttackButton);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _player.PerformAttack();
           
        }
    }
}
