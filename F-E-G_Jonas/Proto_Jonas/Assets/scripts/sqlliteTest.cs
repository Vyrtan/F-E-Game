using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class sqlliteTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Connect to DB
        string connection = "URI = file:" + Application.persistentDataPath + "/My_Database";
        Debug.Log(connection);
        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();

        // Drop old Table
        IDbCommand dbcmd;
        IDataReader reader;

        dbcmd = dbcon.CreateCommand();
        string q_dropTable = "DROP TABLE IF EXISTS my_table";

        dbcmd.CommandText = q_dropTable;
        reader = dbcmd.ExecuteReader();

        //create new table
        dbcmd = dbcon.CreateCommand();
        string q_createTable = "CREATE TABLE IF NOT EXISTS my_table (id INTEGER PRIMARY KEY, frage STRING, antworten STRING, loesung STRING )";

        dbcmd.CommandText = q_createTable;
        reader = dbcmd.ExecuteReader();

        // Insert values in table
        IDbCommand cmnd = dbcon.CreateCommand();
        cmnd.CommandText = "INSERT INTO my_table (id, frage, antworten, loesung) VALUES (0, 'Wer ist der Kaiser von China?', 'Ich | Du | Trump?', 'Trump?')";
        cmnd.ExecuteNonQuery();

        cmnd.CommandText = "INSERT INTO my_table (id, frage, antworten, loesung) VALUES (1, 'Was ist Trumps leibgericht?', 'Burger! | Salat | Sushi', 'Burger!')";
        cmnd.ExecuteNonQuery();

        cmnd.CommandText = "INSERT INTO my_table (id, frage, antworten, loesung) VALUES (2, 'Du bist immernoch da?', 'Ja | Nein | Ups', 'Ups')";
        cmnd.ExecuteNonQuery();


        // Read and print all values in table
        IDbCommand cmnd_read = dbcon.CreateCommand();
        string query = "SELECT * FROM my_table";
        cmnd_read.CommandText = query;
        reader = cmnd_read.ExecuteReader();
        while (reader.Read())
        {
            Debug.Log("id: " + reader[0].ToString());
            Debug.Log("val: " + reader[1].ToString());
            Debug.Log("val: " + reader[2].ToString());
            Debug.Log("val: " + reader[3].ToString());
        }

        // Close connection
        dbcon.Close();

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
