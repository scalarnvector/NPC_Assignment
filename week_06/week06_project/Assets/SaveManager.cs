using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public GameObject player;
    private string savePath;

    void Start()
    {
        savePath = Path.Combine(Application.persistentDataPath, "savefile.json");
    }

/*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SaveGame();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
           LoadGame();
        }
    }
*/
    public void SaveGame()
    {
       
        SaveData data = new SaveData();
       
        data.playerLevel = 25;
        data.playerName = "도트용사";
        data.x = player.transform.position.x;
        data.y = player.transform.position.y;

        string jsonText = JsonUtility.ToJson(data, true);

        File.WriteAllText(savePath, jsonText);

        Debug.Log($"📂 [JSON] 저장 완료! 경로: {savePath}");
    }

    public void LoadGame()
    {
       
        if (File.Exists(savePath))
        {
            string jsonText = File.ReadAllText(savePath);
           
            SaveData data = JsonUtility.FromJson<SaveData>(jsonText);

            player.transform.position = new Vector3(data.x, data.y, 0f);

            Debug.Log($"🎮 [JSON] 로드 완료! 이름: {data.playerName}, 위치 복구 성공!");
        }
        else
        {
            Debug.LogWarning("❌ 세이브 파일이 존재하지 않습니다.");
        }
    }
}
[System.Serializable]
public class SaveData
{
    public int playerLevel;
    public string playerName;
    public float x;
    public float y;
}