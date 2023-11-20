using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvrirPetitePorte : MonoBehaviour
{
   
    [SerializeField] GameObject _petitePorte;
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _clé;

    
    void OnTriggerEnter(Collider others){

        if(others.tag == "Player"){

            _petitePorte.GetComponent<Animator>().SetBool("Ouvrir", true);
            _clé.SetActive(false);

        }

    }
    
         
}

    

