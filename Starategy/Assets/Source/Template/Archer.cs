using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : ABaseEnemy
{
    private GameObject _bulletPref;
    private Transform _shootPoint;
    private float _reloadTime;
    private float _actualReloadTime;
    private bool _isShooting;

    public override Animator Animator { get; set; }
    public override int ID { get; set; }

    public override void Attack()
    {
        if (_actualReloadTime <= 0)
        {
            GameObject.Instantiate(_bulletPref, _shootPoint.position, Quaternion.identity);
            Animator.SetTrigger(ID);
            _actualReloadTime = _reloadTime;
        }
        _actualReloadTime -= Time.deltaTime;
    }

    public Archer(Animator _animator, string animName, GameObject bulletPref, Transform shootPoint, float reloadTime)
    {
        Animator = _animator;
        ID = Animator.StringToHash(animName);
        _bulletPref = bulletPref;
        _shootPoint = shootPoint;
        _reloadTime = reloadTime;
    }
}
