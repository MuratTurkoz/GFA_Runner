using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private Animator _playerAnim;
    void Update()
    {
        Debug.Log(_playerMovement.Velocity.z);
        _playerAnim.SetFloat("MoveSpeed", _playerMovement.Velocity.z);
    }
}
