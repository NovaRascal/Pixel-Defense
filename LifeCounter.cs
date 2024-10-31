using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LifeCounter : MonoBehaviour
{
    public static LifeCounter instance;

    public Text lifeText;

    int life = 10;

    private void Awake()
    {
        instance = this;
    }
   
    void Start()
    {
        lifeText.text = "Life: " + life.ToString();
    }

  public void LosePoint()
    {
        life -= 1;
        lifeText.text = "Life: " + life.ToString();

        if (life == 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
