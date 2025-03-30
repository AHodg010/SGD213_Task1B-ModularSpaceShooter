using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //lowered acceleration to 5, due to the lack of inertia 
     [SerializeField]
    private float acceleration = 5f;

    private Rigidbody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //new function applicabale to all moving components
    public void Move(Vector2 direction)
    {
      //movement with a consistent velocity
      rb.velocity = direction * acceleration; 
    }
}
