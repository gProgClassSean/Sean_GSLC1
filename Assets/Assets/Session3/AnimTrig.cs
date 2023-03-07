using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimTrig : MonoBehaviour
{
    private Animator _anim;
    private bool _isWaiting = false;
    [SerializeField] private float _time;
    [SerializeField] private GameObject _videoPlayer;

    [SerializeField] private Text _countdownText;
    private float _countdownTimer;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _countdownTimer = _time;
        _countdownText.text = _countdownTimer.ToString("0");
    }

    private void Update()
    {
        if(_isWaiting)
        {
            _countdownTimer -= Time.deltaTime;
            _countdownText.text = _countdownTimer.ToString("0");

        }

    }

    public void TriggerAttack()
    {
        _anim.SetTrigger("Attack");

        if(!_isWaiting)
        {
            _countdownText.enabled = true;
            _isWaiting = true;
            StartCoroutine("StartVideo");
        }
    }

    private IEnumerator StartVideo()
    {
        yield return new WaitForSeconds(_time);

        _videoPlayer.SetActive(true);

    }
}
