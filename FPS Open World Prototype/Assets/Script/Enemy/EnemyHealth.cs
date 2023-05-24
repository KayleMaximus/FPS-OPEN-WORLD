using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float _hitPoints = 100f;
    Animator _animator;
    bool _isdead = false;

    [SerializeField] GameObject _ammo;

    public bool IsDead()
    {
        return _isdead;
    }

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void TakeDamage(float damage)
    {
        _hitPoints -= damage;
        BroadcastMessage("OnDamageTaken");
        Debug.Log("Damaged: "+ damage.ToString());
        if (_hitPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (_isdead) return;
        _isdead = true;
        Instantiate(_ammo, transform.position, Quaternion.identity);
        _animator.SetTrigger("die");

    }
}
