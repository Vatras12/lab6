using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PortalScript : MonoBehaviour
{
    GameObject hero;
    FadeDOTweenScript fade;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            hero = GameObject.FindGameObjectWithTag("Player");
            fade = hero.GetComponent<FadeDOTweenScript>();
            if (PlayerPrefs.GetInt("CRYSTALS_AMOUNT") == 3) {
                PlayerPrefs.SetInt("CRYSTALS_AMOUNT", 0);
                SceneManager.LoadScene(0);
                
            }
        }
    }
}
