using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class DatabaseTest_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string connect = "uri=file:" + Application.persistentDataPath + "/myDatabase";
        IDbConnection dbcon = new SqliteConnection(connect);
        dbcon.Open();

        IDbCommand command;
        IDataReader reader;

        command = dbcon.CreateCommand();

        string query = "CREATE TABLE IF NOT EXISTS table (id INTEGER PRIMARY KEY, question STRING, answers STRING)";

        command.CommandText = query;
        reader = command.ExecuteReader();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
