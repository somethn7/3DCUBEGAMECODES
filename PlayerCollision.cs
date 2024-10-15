using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public ParticleController particleSystem;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.gameObject.CompareTag("END"))
        {
            movement.enabled = false;
            Debug.Log("0000");

            if (!particleSystem.isPlaying) 
            {
                particleSystem.PlayParticle();
            }
            FindObjectOfType<GameManager>().NextLevel();
        }
    }
}










