using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExempleDemo : MonoBehaviour
{

    string _monNom = "Pierre-Émile";
    bool _vraiNom = true;
    int _age = 11;
    bool _verite = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_monNom);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_vraiNom);
    }
}
