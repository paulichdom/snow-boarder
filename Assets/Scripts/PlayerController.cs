using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float torqueAmount = 10f;
    [SerializeField] float baseSpeed = 20f;
    [SerializeField] float boostSpeed = 30f;
    
    private Rigidbody2D _rigidBody2D;
    SurfaceEffector2D surfaceEffector2D;
    
    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RespondToBoost()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidBody2D.AddTorque(torqueAmount);
        } 
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidBody2D.AddTorque(-torqueAmount);
        }
    }
}