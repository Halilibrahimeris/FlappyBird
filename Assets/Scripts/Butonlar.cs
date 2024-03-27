using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butonlar : MonoBehaviour
{
    public void Sahneler(int Id)
    {
        SceneManager.LoadScene(Id);
    }
}
