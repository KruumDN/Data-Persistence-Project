using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public Button startButton;
    public InputField nameField;

    public string nameText;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "StartMenu")
        {
            startButton.onClick.AddListener(StartGame);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        Debug.Log(nameField.text);
        nameText = nameField.text;
        SceneManager.LoadScene(1);
    }
}
