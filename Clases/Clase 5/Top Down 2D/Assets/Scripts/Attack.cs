using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDown{
public class Attack : MonoBehaviour{

    [Serializable]
    public struct Attacks {
        public ElementType type;
        public Projectile prefab;
    }
    public Attacks[] attacksArray;

    public Dictionary<ElementType, Projectile> attacks;
    private int currentAttack;

    // Start is called before the first frame update
    void Start()
    {
        attacks = new Dictionary<ElementType, Projectile>(){

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        Shoot(ElementType.fire);

        if (Input.GetKeyDown(KeyCode.A))
        currentAttack--;
        
        if (Input.GetKeyDown(KeyCode.S))
        currentAttack++;

        currentAttack = Mathf.Clamp(currentAttack, 0, attacks.count - 1);
    }

    public void Throw (Element type){
            Instantiate(attacks[type], transform.position, Quaternion.identity);
        }
    }
}
