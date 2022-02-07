using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static int lives = 3;
    private static GameManager instance;

    private void Awake() 
    {
        if(instance != null && instance != this)            //checks for an instance and if the said instance is the same
        {
            Destroy(this);                                  //in case of both the conditions failing the instance is deleted
        }
        else 
        {
            instance = this;                                //in the case of both the conditions return true then the current instance is accepted to be the only instance
            DontDestroyOnLoad(gameObject);                  //ensures that the game object is not deleted when a different scene is loaded
        }
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);                      //ensures that the game object is not deleted when a different scene is loaded
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Game");                     //loads the Game Scene
    }

    public static GameManager GetInstance()                 //function to access the private variable instance
    {
        return instance;
    }
}
