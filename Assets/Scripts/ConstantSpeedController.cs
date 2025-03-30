using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeedController : MonoBehaviour
{
    [SerializeField]
    private Vector2 direction;

    private Movement movement;

    // Start is called before the first frame update
    void Start()
    {
        movement= GetComponent<Movement>();
    }

    // Update is called once per frame
    //allows for a movement direction to be set in unity
    void Update()
    {
        movement.Move(direction);
    }
}
