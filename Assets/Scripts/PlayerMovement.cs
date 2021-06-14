using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField]
    private float objectSpeed;
    [SerializeField]
    Vector3 objectDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        ObjectMovement(objectDirection,objectSpeed);
    }

    // Update is called once per frame
    void ObjectMovement(Vector3 direction, float speed)
    {
        transform.Translate(direction*speed);
    }
}
