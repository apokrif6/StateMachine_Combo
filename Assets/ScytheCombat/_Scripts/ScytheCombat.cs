using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScytheCombat : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _nextFireTime = 0f;
    
    
    public float cooldownTime = 2f;
    public static int numberOfClicks = 0;
    private float _lastClickedTime = 0;
    private float _maxComboDelay = 1f;
    private static readonly int Hit1 = Animator.StringToHash("Hit_1");
    private static readonly int Hit2 = Animator.StringToHash("Hit_2");

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f &&
            _animator.GetCurrentAnimatorStateInfo(0).IsName("Hit_1"))
        {
            _animator.SetBool(Hit1, false);
        }

        if (_animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f &&
            _animator.GetCurrentAnimatorStateInfo(0).IsName("Hit_2"))
        {
            _animator.SetBool(Hit2, false);
            numberOfClicks = 0;
        }
        
        if ((Time.time - _lastClickedTime) > _maxComboDelay)
        {
            numberOfClicks = 0;
        }
        
        if (Time.time > _nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayAnim();
            }
        }
    }

    void PlayAnim()
    {
        _lastClickedTime = Time.time;
        numberOfClicks++;
        
        if (numberOfClicks == 1)
        {
            _animator.SetTrigger("Hit_1");

//            _animator.SetBool("Hit_1", true);
        }

        numberOfClicks = Mathf.Clamp(numberOfClicks, 0, 2);

        if (numberOfClicks >= 2 && _animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f &&
            _animator.GetCurrentAnimatorStateInfo(0).IsName("Hit_1"))
        {
            //_animator.GetCurrentAnimatorStateInfo(0).length;
            /*_animator.SetBool("Hit_1", false);
            _animator.SetBool("Hit_2", true);*/
        }
    }
}
