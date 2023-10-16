using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bootstraper : MonoBehaviour
{
    [SerializeField] private Animator _playerAnim;
    [SerializeField] private Animator _wooderAnim;
    [SerializeField] private Animator _archerAnim;
    [SerializeField] private Animator _robberAnim;

    [SerializeField] private Button _firstAttackButton;
    [SerializeField] private Button _secondAttackButton;
    [SerializeField] private Button _thirdAttackButton;

    [SerializeField] private GameObject _bulletPref;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private float _reloadTime;

    [SerializeField] private PlayerControler _player;
    [SerializeField] private EnemyControler _enemy;

    
    void Start()
    {
        _player = new PlayerControler(_playerAnim);
        _enemy = new EnemyControler(new Archer(_archerAnim, "Attack", _bulletPref, _shootPoint, _reloadTime), new Wooder(_wooderAnim, "Attack"), new Robber(_robberAnim, "Attack"));
        new AttackChange(_player, _firstAttackButton, _secondAttackButton, _thirdAttackButton, _enemy);
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _player.PerformAttack();
            _enemy.Robber.Attack();
        }
        if (_enemy.Archer.Animator.gameObject.activeSelf == true)
        {
            _enemy.Archer.Attack();
        }
    }
}
