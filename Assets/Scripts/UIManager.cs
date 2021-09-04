using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    public Text _newText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _newText.text = "Hello, my name is Jack Leavey!";
        }

        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
}
