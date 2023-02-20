using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel")){
            PauseMenu.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }

    public void Resume(){
        PauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void Return(){
        SceneManager.LoadScene(0);
    }


}
