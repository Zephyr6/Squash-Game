using UnityEngine;
using System.Collections;

public class SquampGrounded : MonoBehaviour {
    public Transform groundCheck;
    public bool IsGrounded = false;
    public float TimeToSquamp = 5;
    private float timer = 0;
    private Vector3 startPosition = new Vector3();
    private float fallSpeed = 100;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        IsGrounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
    }
}
