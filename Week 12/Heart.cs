using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    // Start is called before the first frame update
   
    
        // Start is called before the first frame update
        void Start()
        {
            // Destroy the heart after 3 seconds
            Destroy(gameObject, 4f);
        }
         void Update()
        {
            // Move coin downward
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                LiveManager livesManager = FindObjectOfType<LiveManager>();

                if (livesManager!= null)
                {
                    livesManager.AddLives(1);
                    Destroy(gameObject);
                }
               
            }
        }
   
}
