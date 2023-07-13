using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
	public KeysCount keysCount;
	public TextMeshProUGUI keysCounterText;

	void Update()
	{
		// Обновляем текст с кол-вом ключей
		keysCounterText.text = keysCount.keys.ToString();
	}
}

