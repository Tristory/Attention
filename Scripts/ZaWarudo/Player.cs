using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Movement")]
    private Rigidbody2D _Rigidbody2D;
    private Vector3 change;
    public float speed;
    private Animator animator;

    [Header("Attention")]
    public List<Distractor> distractors = new List<Distractor>();
    //public bool interactiveOn;
    public GameObject metaSense;

    [Header("Status")]
    public PlayerStatus playerStatus;

    // Start is called before the first frame update
    void Start()
    {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        if (change != Vector3.zero)
        {
            Movement();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }

        Sensing();
    }

    void Movement()
    {
        change.Normalize();
        _Rigidbody2D.MovePosition(transform.position + change * speed * Time.deltaTime);
    }

    void Sensing()
    {
        //bool interactiveOn;

        if(distractors.Count > 0)
        {
            //interactiveOn = true;
            MetaSenseManagement(true);
        }
        else
        {
            //interactiveOn = false;
            MetaSenseManagement(false);
        }

        //MetaSenseManagement();
    }

    void MetaSenseManagement(bool interactiveOn)
    {
        if(interactiveOn)
        {
            metaSense.SetActive(true);
        }
        else
        {
            metaSense.SetActive(false);
        }
    }
}
