using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerHitbox : MonoBehaviour
    {
        protected void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Game End");
            }
        }
    }
}