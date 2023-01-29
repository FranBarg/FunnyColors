using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public GameObject star1, star2, star3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("NumberStars") == 1)
        {
            star1.SetActive(true);
        } else if (PlayerPrefs.GetInt("NumberStars") == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
        } else if (PlayerPrefs.GetInt("NumberStars") == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
    }
}
