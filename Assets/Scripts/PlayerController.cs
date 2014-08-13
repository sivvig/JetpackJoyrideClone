using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public enum MovingState
    {
        running,
        jumping
    }

    private MovingState movingState = MovingState.running;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movingState = MovingState.running;
        if (Input.GetKey("up"))
        {
            movingState = MovingState.jumping;
        }
    }
}