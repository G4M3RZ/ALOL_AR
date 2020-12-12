using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Animator _animController;
    public AnimationClip _iddle, _jump;

    private void Awake()
    {
        _animController = GetComponent<Animator>();
    }
}