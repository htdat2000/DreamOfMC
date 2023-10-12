using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class Ghost : MonoBehaviour
    {
        [SerializeField] protected float moveSpeed;

        protected GameObject player;
        protected bool hasReachedPlayer = false;

        protected void Start()
        {
            FindingPlayer();
        }
        protected void Update()
        {
            if(!hasReachedPlayer)
            {
                ChasingPlayer();
            }
        }
        protected void FindingPlayer()
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        protected void ChasingPlayer()
        {
            if(player == null)
            {
                return;
            }
            Vector3 moveDir = player.transform.position - this.gameObject.transform.position;
            transform.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
        }
        protected void OnCollisionEnter2D(Collision2D col)
        {
            if(col.gameObject.CompareTag("Player"))
            {
                hasReachedPlayer = true;
            }
        }
    }
}