using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoSingleton<MainCharacterController>
{
    protected override MainCharacterController GetSingletonInstance { get { return this; } }

    // Inspector editable variables
    [SerializeField]
    private float runSpeed = 1.0f;
    [SerializeField]
    private float jumpForce = 1.0f;

    // Component references
    private Rigidbody2D rb;

    override protected void Awake()
    {
        base.Awake();
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.ConstantMovement();
    }

    /// <summary>
    /// Ensures the player is running at a constant speed forward
    /// </summary>
    void ConstantMovement()
    {
        Vector2 speedVector = new Vector2(runSpeed, 0.0f);
        rb.MovePosition(this.rb.position + speedVector * Time.deltaTime);
    }

    /// <summary>
    /// Basically this defines what happens on a basic action.
    /// By default that's a tap on screen.
    /// </summary>
    public void OnBasicAction()
    {
        Debug.Log("Basic action pressed");
        rb.AddForce(new Vector2(0.0f, this.jumpForce), ForceMode2D.Impulse);
    }
}
