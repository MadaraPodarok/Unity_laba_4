using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class Teleport : MonoBehaviour
{
    private void OnTriggerStay (Collider other)
    {
        if (other.tag == ("Teleport"))
        {
            SceneManager.LoadScene("TerrainScene");
        }
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TagName In OnTriggerEnter: " + other.tag);
        if (other.tag == ("Teleport"))
        {
            SceneManager.LoadScene("TerrainScene");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TagName In OnTriggerExit: " + other.tag);
        if (other.tag == ("Teleport"))
        {
            SceneManager.LoadScene("TerrainScene");
        }
    }
    */
}