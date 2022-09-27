using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            //Game Over
            PlayerManager.gameOver = true;
            
            AudioManager.instance.Play("GameOver");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Gem"))
        {
            PlayerManager.gems++;
            AudioManager.instance.Play("Coin");
            Destroy(other.gameObject);
        }
    }
}
