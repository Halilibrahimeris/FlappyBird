using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Numbers : MonoBehaviour
{
    public int Number;
    public bool isFull;
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
    }
}
