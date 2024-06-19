using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public bool isCoins, isSpeedUp;
    public float speedDuration;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerControls pc = other.GetComponent<PlayerControls>();
            if (isCoins)
            {
                pc.score++;
                Destroy(gameObject);
            }
            if (isSpeedUp)
            {
                pc.moveSpeed += 1.5f;
            }
        }
    }
}
