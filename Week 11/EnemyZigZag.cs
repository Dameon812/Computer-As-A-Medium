using System.Collections;
using System.Collections.Generic;
using UnityEngine;



   public class ZigzagEnemy : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        // Move downward
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);

        // Move side to side
        float sideMovement = Mathf.Sin(Time.time * 3f) * 2f;
        transform.position = new Vector3(sideMovement, transform.position.y, transform.position.z);

        // Destroy enemy at bottom of screen
        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}

