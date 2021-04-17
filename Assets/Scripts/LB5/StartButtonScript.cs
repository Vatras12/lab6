using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    JSONController json;

    private void OnStart() {
      
    }
    public void OnClick() {
        SceneManager.LoadScene(4);

        /*json = new JSONController();
        json.LoadField();
        if (json!= null && json.item.loggedIn == "true") {
            SceneManager.LoadScene(4);
        }
        else {
            SceneManager.LoadScene(2);
        */}
    }

