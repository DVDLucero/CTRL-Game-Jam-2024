using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditAI : MonoBehaviour
{
    public float speed = 200f;            // Speed at which the bandit moves
    public float detectionRange = 30f;  // Range within which the bandit will detect the player
    public Transform player;            // Reference to the player's transform

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Find the player in the scene (assuming the player has a tag "Player")
        if (player == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null)
                player = playerObj.transform;
        }
    }

    void Update()
    {
        if (player == null) return;

        // Check if the player is within detection range
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange)
        {
            // Move towards the player
            Vector3 direction = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }
    }
}