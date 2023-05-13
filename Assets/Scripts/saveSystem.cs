using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class saveSystem
{
    public static void SaveHiScore(gameController player){
        BinaryFormatter formatter= new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerHiscore.CatInABox"; 
        FileStream stream = new FileStream (path, FileMode.Create);

        playerData data = new playerData(player);
        
        formatter.Serialize(stream, data);
        stream.Close();

    }
    public static playerData LoadHiScore(){
        string path = Application.persistentDataPath + "/playerHiscore.CatInABox";
        if(File.Exists(path)){
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            playerData data = formatter.Deserialize(stream) as playerData;
            stream.Close();

            return data;
        } else{
            Debug.LogError("No save data found");
            return null;
        }
    }
  
}
