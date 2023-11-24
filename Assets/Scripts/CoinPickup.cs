using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] int scorePointPickup = 100;
    [SerializeField] AudioClip coinClipSFX;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            FindObjectOfType<GameSession>().AddToScore(scorePointPickup);
            AudioSource.PlayClipAtPoint(coinClipSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
