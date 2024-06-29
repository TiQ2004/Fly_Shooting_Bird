using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameTool;

public class Bird : MonoBehaviour
{
    private float jumpForces = 7f;
    private float cooldown = 0.5f;
    private float spawnDelay;    
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

        if(spawnDelay <= 0)
        {
            spawnDelay = cooldown;
            PoolingManager.Instance.GetObject(NamePrefabPool.Bulllet, null, transform.position);
        }
        else
        {
            spawnDelay -= Time.deltaTime;
        }
    }
}
