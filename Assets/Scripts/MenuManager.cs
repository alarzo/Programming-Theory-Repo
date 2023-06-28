using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text errorText;
    [SerializeField] public string playerName { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InputField()
    {
        playerName = inputField.text; 
    }
    public void OnInputFieldLeave()
    {
        if(playerName.Length >= 25)
        {
            playerName = "";
            errorText.gameObject.SetActive(true);
        }
        else
        {
            errorText.gameObject.SetActive(false);
        }
    }

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
