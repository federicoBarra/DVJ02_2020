using System.Collections;
using System.Collections.Generic;
using DVJ02.Clase12;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfiguration", menuName = "Clase DVJ02/Game Config" + "", order = 1)]
public class GameConfig : ScriptableObject
{
	public List<ScriptableObjectExample> availableCharacters;

	public int levelCount = 5;

	public int initialMoney = 100;

	public List<string> predefinedCharacterNames;


	public string GetRandomName()
	{
		int rnd = Random.Range(0, predefinedCharacterNames.Count);
		return predefinedCharacterNames[rnd];
	}

}