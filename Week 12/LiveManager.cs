using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LiveManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int lives = 1;
    public TMP_Text livestext;

    // Start is called before the first frame update
    void Start()
    {
        UpdateLives();
    }

    public void AddLives(int amount)
    {

        lives = Mathf.Min(lives + amount, 3);
        UpdateLives();

    }
    void UpdateLives()
    {

        livestext.text = "Lives: " +lives;
    }
}
