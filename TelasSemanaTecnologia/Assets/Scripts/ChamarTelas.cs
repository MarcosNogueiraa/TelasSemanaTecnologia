using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamarTelas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChamaCena(string nomeCena)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nomeCena);
    }
}
