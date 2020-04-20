using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pino : MonoBehaviour
{
	private int masa;

	public static int operator +(Pino b, Pino c)
	{
		return b.masa + c.masa;
	}

	//public static string operator +(string b, int c)
	//{
	//	return b + c.ToString();
	//}
}
