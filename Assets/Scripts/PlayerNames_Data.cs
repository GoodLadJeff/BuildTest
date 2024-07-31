using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PlayerNamesScriptableObject")]
public class PlayerNames_Data : ScriptableObject
{
    public List<string> player_names = new List<string>();

    public void AddName(string new_name)
    {
        player_names.Add(new_name);
    }
}
