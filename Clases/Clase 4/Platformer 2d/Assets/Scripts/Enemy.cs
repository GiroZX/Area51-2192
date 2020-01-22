using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer{
public class Enemy : MonoBehaviour
{
    Animator animator;
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
            Destroy(bullet);
        }
    }

}
}