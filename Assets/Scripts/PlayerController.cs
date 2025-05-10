using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float torqueAmount = 10f;
    private Rigidbody2D _rigidBody2D;
    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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