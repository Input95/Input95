using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Przejscie_Poziomu : MonoBehaviour
{
    
    public void LoadScene(string NazwaSceny)
    {
        SceneManager.LoadScene(NazwaSceny);
    }


 
}
