using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public Transform playerTransform;
    public float triggerDistance;
    public float enemySpeed;

    private void Update()
    {
        float step = enemySpeed * Time.deltaTime;

        if (Vector2.Distance(gameObject.transform.position, playerTransform.position) < triggerDistance)
            transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, step);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == playerTransform.gameObject.name)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
