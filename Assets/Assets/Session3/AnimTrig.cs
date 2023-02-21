using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrig : MonoBehaviour
{
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public void TriggerAttack()
    {
        _anim.SetTrigger("Attack");
    }
}
