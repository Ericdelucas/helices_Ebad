using UnityEngine;
using Unity.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class elices : MonoBehaviour
{
    public GameObject Contador;
    public int indice;
    public List<GameObject> helices = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    public void criador_elices()
    {
        if (Contador.GetComponent<ContadorEnergua>().energia >= 1000)
        {
            Contador.GetComponent<ContadorEnergua>().energia -= 1000;
            helices[indice].SetActive(true);
            indice++;
        }
    }
}
