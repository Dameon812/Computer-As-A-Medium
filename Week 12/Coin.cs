using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Destroy the coin after 4 seconds
        Destroy(gameObject, 4f);
    }
    private void Update()
    {
        // Move coin downward
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

            if (scoreManager != null)
            {
                scoreManager.AddScore(1);
                Destroy(gameObject);
            }
            else
            {
                Debug.LogError("ScoreManager not found!");
            }
        }
    }
}