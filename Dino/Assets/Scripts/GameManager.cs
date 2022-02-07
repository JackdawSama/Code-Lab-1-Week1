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
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Game");
    }

    public static GameManager GetInstance()                     //function to access the private variable instance
    {
        return instance;
    }
}
