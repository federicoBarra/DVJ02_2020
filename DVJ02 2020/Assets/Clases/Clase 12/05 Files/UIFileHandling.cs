using System.IO;
using UnityEngine;

namespace DVJ02.Clase07
{
public class UIFileHandling : MonoBehaviour
{
    public string dataToSave;
    public string fileName = "dataLoca.txt";

    // Use this for initialization
    private void Start()
    {
        print(Application.persistentDataPath);
    }

    public void ReadFromFile()
    {
        string path = Application.persistentDataPath + "/" + fileName;
        string text = "";
        if (File.Exists(path))
            text = File.ReadAllText(path);

        dataToSave = text;
    }

    public void SaveToFile()
    {
        string path = Application.persistentDataPath + "/" + fileName;
        File.WriteAllText(path, dataToSave);
    }

}
}