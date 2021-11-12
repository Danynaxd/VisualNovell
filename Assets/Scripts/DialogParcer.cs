using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using UnityEditor;
using System.Text.RegularExpressions;
using UnityEditor.SceneManagement;



/*public class DialogParcer : MonoBehaviour
{
    List <DialogueLine> Lines;
    struct DialogueLine 
    {
        string name;
        string content;
        int pose;

        public DialogueLine (string n, string c, string p)
        {
            name = n;
            content = c;
            pose = p;

        }
    }


    void Start()
    {
       string file = "Dialogues";
       string sceneNum = EditorApplication.currentScene; 
       sceneNum = Regex.Replace (sceneNum, "[^ 0-9]", ""); 
       file+= sceneNum;
       file+= ".txt"; 

       LoadDialogue (file);   
    }

    
    void Update()
    {
        
    }

    void LoadDialogue (string linename)
    {
        string file = "Assets/Resourses" + filename;
        string line;
        StreamReader r = new StreamReader(file);

        using(r) 
        {
            
                do
                {
                    line = r.ReadLine;
                    if (line!= null);
                    {
                        string [] line_values = line.Split(",");
                        DialogueLine Line_entry = new DialogueLine(line_values[0], line_values [1], int.Parse(line_values [3]));
                        Lines.Add (Line_entry);
                        
                    }
                }
                while(line != null);
                    r.Close(); 
            
        }
    }
}
*/