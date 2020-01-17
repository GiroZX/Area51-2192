using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Manager : MonoBehaviour
{
    public Transform startPos;
    public HealthBarController healthBar;



    // Start is called before the first frame update
    void Start()
    {
        //Player.instance.transform.position = startPos.position;
        //Player.setPosition = startPos.position;
        Player.setPosition2 = startPos;
        Player.HealthBar = healthBar;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
