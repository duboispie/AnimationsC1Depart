using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendreTorche : MonoBehaviour
{

    [SerializeField] GameObject _torcheMurale;
    [SerializeField] GameObject _torcheMain;
    [SerializeField] GameObject _player;
    
  private void OnTriggerEnter(Collider other){

            if(other.tag == "Player"){
            
            _torcheMain.SetActive(true);
            _torcheMurale.SetActive(false);

        }

        }
}