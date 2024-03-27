using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Inputs : MonoBehaviour
{
    public int Deger;
    private TextMeshProUGUI texts;
    private Button button;
    private void Start()
    {
        texts = GetComponentInChildren<TextMeshProUGUI>();
        button = GetComponent<Button>();
        button.onClick.AddListener(Deneme);
    }

    public void Deneme()
    {

    }

}
