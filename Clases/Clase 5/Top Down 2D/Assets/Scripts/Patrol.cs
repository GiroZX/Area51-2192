using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDown{
public class Patrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //leer sobre Interpolacion e Interpolacion Cuadratica
    }

    private void OnDrawGizmos(){       
        Vector3 point = points[0];

        Debug.DrawLine(
            transform.position,
            transform.position + point,
            Color.cyan);

        for (int i = 0; i < points.Length; i++){
            Vector3 start = points[i-1];
            Vector3 end = transform.position + point;
        
            Debug.DrawLine(
                 start,
                 end,
                 Color.cyan);

        }
        
        }
}
}
