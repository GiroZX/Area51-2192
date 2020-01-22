using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer{
public class BulletLog : MonoBehaviour
{
    public enum Direction
    {
        left = -1,
        right = 1
    }
    public Direction direction = Direction.right;
    public float speed;
    public float lifeTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = ((int)direction * Vector3.right)
            * speed * Time.deltaTime;

        transform.position += pos;
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        Destroy(gameObject);
    }
    public void Init(float speed, Direction direction)
    {
        this.speed = speed;
        this.direction = direction;
    }
    // public void Init(Direction direction)
    // {
    //     this.direction = direction;
    // }

}
}