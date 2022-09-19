using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("moveX", moveX);

        bool isMoving = !Mathf.Approximately(moveX, 0f);

        animator.SetBool("isMoving", isMoving);
    }
}