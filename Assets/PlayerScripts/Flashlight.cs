using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Flashlight : MonoBehaviour {

	public KeyCode control = KeyCode.F; // ������� ���������� ���������, ���/���� � �����������
	public float timeout = 30; // ����� ������ �������� � ��������

	public Light _light; // �������� �����

	// ����������� � ������������ ������������� ��������� �����
	public float min = 1;
	public float max = 8;
	
	public Slider slider; // ������� UI

	// ����� ����������
	public Color maxColor = Color.white;
	public Color halfColor = Color.yellow;
	public Color minColor = Color.red;

	public float reloadTime = 2.5f; // ����� ����������� � ��������
	public int batteryCount = 3; // ��������� ���������� �������� ��������

	private float curTime;
	private Image sliderColor;
	private float curReloadTime;

	void Awake () 
	{
		sliderColor = slider.fillRect.GetComponentInChildren<Image>();
	}

	void Start () 
	{
		sliderColor.color = maxColor;
		slider.minValue = 0;
		slider.maxValue = 100;
		slider.value = 100;
		_light.enabled = false;
		_light.intensity = min;
	}

	void Update () 
	{
		if(Input.GetKeyDown(control) && !_light.enabled && slider.value > 1)
		{
			_light.enabled = true;
		}
		else if(Input.GetKeyDown(control) && _light.enabled)
		{
			_light.enabled = false;
			_light.intensity = min;
		}

		if(_light.enabled)
		{
			curTime += Time.deltaTime;

			if(curTime > timeout) 
			{
				curTime = 0;
				slider.value = 0;
				_light.enabled = false;
			}
			else if(curTime != 0)
			{
				// ��������� ����� � �������� �������� �� 0 �� 100% � ������� �� 100
				slider.value = 100 - (curTime/timeout) * 100;
			}

			float intensity = max;
			Color curColor = maxColor;

			if(slider.value < 50) curColor = halfColor; // ������ ���� �� �������������, ���� ������ 50% ������

			if(slider.value < 20) 
			{
				curColor = minColor;
				intensity = max / 2; // ������� ������� ��������

				if(Random.Range(0, 0.9f) > 0.5f) intensity = intensity / Random.Range(1, 6); // ��������� ��������, ����� �����������
			}

			sliderColor.color = Color.Lerp(sliderColor.color, curColor, 1.5f * Time.deltaTime);
			_light.intensity = Mathf.Lerp(_light.intensity, intensity, 3f * Time.deltaTime);
		}
		else if(Input.GetKey(control) && slider.value < 90 && batteryCount > 0) // �����������, ���� ������ ������� ������ 90% � ���� ��� ��������
		{
			curReloadTime += Time.deltaTime;
			if(curReloadTime > reloadTime) 
			{
				curReloadTime = 0;
				batteryCount--;
				sliderColor.color = maxColor;
				slider.value = 100;
				_light.intensity = min;
			}
		}
		else
		{
			curReloadTime = 0;
		}
	}
}