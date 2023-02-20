using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject GameOverMenu;
    // Start is called before the first frame update
    void Start()
    {
        GameOverMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerControl.lives==0){
            GameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }


    public void PlayAgain(){
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
        
    }

    public void Quit(){
        Application.Quit();
    }
}
