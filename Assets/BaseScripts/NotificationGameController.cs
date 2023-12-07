using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationGameController : MonoBehaviour
{
    [SerializeField] private Text messageHelper;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door")
        {
            messageHelper.text = "������� � ����� �������|������� �����";
        }
        else if (other.tag == "Fonarik")
        {
            messageHelper.text = "������� F ����� ���|���� �������";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Door")
        {
            messageHelper.text = "";
        }
        else if (other.tag == "Fonarik")
        {
            messageHelper.text = "";
        }
    }
}
