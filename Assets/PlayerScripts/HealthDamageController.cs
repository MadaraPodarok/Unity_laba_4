using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDamageController : MonoBehaviour
{

	[SerializeField] private float maxHealth;
    [SerializeField] private float damage;
    [SerializeField] private Text dieText;
    [SerializeField] private Canvas dieCanvas;

    private float currentHealth;
	public DefaultHealthController dhc;

    private void Start()
    {
		currentHealth = maxHealth;
		dhc.SetMaxHealth(maxHealth);
        dieCanvas.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("TAG: " + other.gameObject.tag);
        if (other.gameObject.tag == "Fire")
        {
            TakeDamage(damage);
        }
    }

	private void TakeDamage(float damage)
    {
        Debug.Log("HP TakeDamage: " + currentHealth);
        if (currentHealth < 0) 
        {
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            dieCanvas.enabled = true;
            dieText.text = "ПОТРАЧЕНО";
        }
        else
        {
            currentHealth -= damage;
            dhc.SetHealth(currentHealth);
        }
	}
}
