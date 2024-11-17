using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float groundDistance;
    public LayerMask terrainLayer;
    public Rigidbody rb;
    public SpriteRenderer sr;
    private Animator _animator;
    private Vector3 _moveDir;
    private float _speedMultiplier = 1.5f;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
    void FixedUpdate()
    {
        
        RaycastHit hit;
        Vector3 castPos = transform.position;
        /*if (Physics.Raycast(castPos, -transform.up, out hit, Mathf.Infinity, terrainLayer))
        {
            if (hit.collider != null)
            {
                Vector3 movePos = transform.position;
                movePos.y += hit.point.y + groundDistance;
                transform.position = movePos;
            }
        }
        */
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
            
        _moveDir = new Vector3(x,rb.velocity.y, y);
        rb.velocity = _moveDir * speed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _moveDir = new Vector3(x, 0, y);
            rb.velocity = _moveDir * speed * _speedMultiplier;
        }
       
        float movementMagnitude = _moveDir.magnitude;

        if (movementMagnitude > 0.1f)
        {
            // Determine if running or walking
            bool isRunning = Input.GetKey(KeyCode.LeftShift);
            _animator.SetBool("isRunning", isRunning);
            _animator.SetBool("isWalking", !isRunning);
        }
        else
        {
            // Player is idle
            _animator.SetBool("isWalking", false);
            _animator.SetBool("isRunning", false);
        }

        if (x != 0 && x < 0)
        {
            sr.flipX = false;
        }
        else if (x != 0 && x > 0)
        {
            sr.flipX = true;
        }
        
    }
    
    public AK.Wwise.Event walkSound;

    public void PlayWalkSound()
    {
        walkSound.Post(gameObject);
    }
    
    
}
