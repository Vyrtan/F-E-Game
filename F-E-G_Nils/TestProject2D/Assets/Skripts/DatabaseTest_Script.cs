using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
//using Mono.Data.Sqlite;
using System.IO;

public class DatabaseTest_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string connect = "url=file:" + Application.persistentDataPath + "/myDatabase";
        //IDbConnection dbCon = new SqliteConnection(connect);
        //dbCon.open();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
