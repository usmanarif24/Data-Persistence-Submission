using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartManager : MonoBehaviour
{

    public static string _payerName;
    public InputField inputField;
    [SerializeField]
    public Text errorMessage;

    public void StartGame()
    {
        if (inputField.text == "")
        {
            errorMessage.text = "Please enter name first";
        }
        else {
            _payerName = inputField.text;
            SceneManager.LoadScene(1);
        }
    }
}
