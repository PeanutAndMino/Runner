using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMovementController : MonoBehaviour
{
    // Inspector editable variables
    [SerializeField]
    private float runSpeed = 1.0f;

    // Component references
    private Rigidbody2D rb;

    void Awake(){
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

    void ConstantMovement(){
        Vector2 speedVector = new Vector2(runSpeed, 0.0f);
        rb.MovePosition(this.rb.position + speedVector * Time.deltaTime);
    }
}
