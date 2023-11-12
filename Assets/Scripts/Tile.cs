using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
 private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("You hit me");
    }
}
