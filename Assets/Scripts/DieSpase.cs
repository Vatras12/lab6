using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieSpase : MonoBehaviour
{
    public GameObject respawn;
    [SerializeField] private string life = "LIFE";
    void Start() {
        PlayerPrefs.SetFloat(life, 0);
    }

    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Player" && PlayerPrefs.GetFloat(life) == 0)
        {
            PlayerPrefs.SetFloat(life, 1);
            Destroy(GameObject.FindWithTag("Life"));
            other.transform.position = respawn.transform.position;
        }
        else if(other.tag == "Player" && PlayerPrefs.GetFloat(life) > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
}
