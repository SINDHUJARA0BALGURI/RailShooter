using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField]
    GameObject deathEffect;
    private void OnTriggerEnter(Collider other)
    {
        PlayerDeath();
    }
     public  void PlayerDeath()
    {
        Debug.Log("Player is Dead");
        SendMessage("OnPlayerDeath");
    }
}
