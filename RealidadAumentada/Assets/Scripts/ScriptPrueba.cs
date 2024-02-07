using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScriptPrueba : MonoBehaviour
{
    [SerializeField] private TMP_Text m_Text;
    // Start is called before the first frame update
    void Start()
    {
        m_Text.text = " ";
        Debug.Log("working");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowText()
    {
        m_Text.text = "TodoGucci";
        Debug.Log("working");

    }

    public void hideText()
    {
        m_Text.text = " ";
        Debug.Log("working");

    }

}
