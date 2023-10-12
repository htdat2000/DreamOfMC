using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] protected float moveSpeed = 5;

        protected Rigidbody2D rb;

        protected void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        protected void FixedUpdate()
        {
            Move();            
        }

        protected void Move()
        {
            Vector2 moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            rb.velocity = moveDir.normalized * moveSpeed;        
        }
    }
}