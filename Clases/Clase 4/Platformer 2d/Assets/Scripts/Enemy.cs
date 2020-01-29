using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer{
public class Enemy : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        BulletLog bullet = 
        collision.gameObject.GetComponent<BulletLog>();

        if(bullet){
            animator.SetBool("isdeath", true);
             Destroy(GetComponent<CapsuleCollider2D>());
             Destroy(GetComponent<Rigidbody2D>());
            }
    }

        public void OnDeath() {
            Destroy(GetComponent<Animator>());
            SpawnController.Create();
            Destroy(GetComponent<Enemy>());
            //Destroy(gameObject);
        }
    }
}