using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class CompleteGameController : MonoBehaviour
{
    
    [SerializeField] private Text successText;
    [SerializeField] private Canvas successCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "TerrainScene")
        {
            successCanvas.enabled = true;
            successText.text = "Вы прошли игру!";
        }
    }
   
}
