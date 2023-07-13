using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerUI : MonoBehaviour
{
	public GameObject canvas;
	public KeysCount keysCount;
	public TextMeshProUGUI keysCounterText;

	void Update()
	{
		// Обновляем текст с кол-вом ключей
		keysCounterText.text = "Собрано ключей: " + keysCount.keys.ToString() + "/ 3";

		if(keysCount.keys == 3)
        {
			canvas.SetActive(true);
			StartCoroutine(RestartLevelDelayed());

		}
	}
	IEnumerator RestartLevelDelayed()
	{
		yield return new WaitForSeconds(3f);

		Time.timeScale = 1;
		SceneManager.LoadScene(0);
	}
}

