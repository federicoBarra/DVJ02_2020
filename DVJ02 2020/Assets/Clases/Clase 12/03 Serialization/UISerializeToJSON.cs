using UnityEngine;

namespace DVJ02.Clase12
{
	public class UISerializeToJSON : MonoBehaviour
	{
	    public PlayerData playerData;

	    public string serializedData = "";

	    public void SerializePlayer()
	    {
	        serializedData = JsonUtility.ToJson(playerData);

			//PlayerPrefs.SetString("playerData", serializedData);

	        //https://jsonformatter.curiousconcept.com/
	    }
	    public void DeserializePlayer()
	    {
	        playerData = JsonUtility.FromJson<PlayerData>(serializedData);

		    //string data  = PlayerPrefs.GetString("playerData");
		    //playerData = JsonUtility.FromJson<PlayerData>(data);
		}
	}
}
