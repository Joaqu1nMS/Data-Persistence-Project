using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public string playerName;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            Destroy(Instance);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotonStart ()
    {
        SceneManager.LoadScene(1);
    }

    public void BotonExit ()
    {
        Application.Quit();
    }

    public void ReadStringInput (string s)
    {
        playerName = s;
        Debug.Log(playerName);
    }
}
