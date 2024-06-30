using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameTool;

public class Bird : MonoBehaviour
{
    private float jumpForces = 7f;
    private float cooldown = 0.5f;
    private float spawnDelay;
    private float boundTop = 4.2f;
    private float boundBot = -4.3f;
    [SerializeField] private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawnDelay = cooldown;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(0f, jumpForces);
        }

        if(transform.position.y >= boundTop)
        {
            transform.position = new Vector3(transform.position.x, boundTop, transform.position.z);
        }

        if(transform.position.y <= boundBot)
        {
            transform.position = new Vector3(transform.position.x, boundBot, transform.position.z);
        }

        if(spawnDelay <= 0)
        {
            spawnDelay = cooldown;
            PoolingManager.Instance.GetObject(NamePrefabPool.Bulllet, null, transform.position).Disable(1.5f);
        }
        else
        {
            spawnDelay -= Time.deltaTime;
        }
    }
}
