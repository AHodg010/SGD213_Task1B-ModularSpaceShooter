using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Movement movement;
    private ShootingScript shooting;

    // Start is called before the first frame update
    void Start()
    {
       //cast to the movement and shooting scripts
      movement= GetComponent<Movement>();
      shooting= GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //code moved from the ShootingScript
        float input = Input.GetAxis("Horizontal");

        movement.Move(Vector2.right * input);

        if (Input.GetButton("Fire1"))
        {
            shooting.Shoot();
        }
    }
}
