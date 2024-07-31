using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameSelector : MonoBehaviour
{
    [SerializeField] private PlayerNames_Data player_data;

    [SerializeField] private TextMeshProUGUI name_input;
    [SerializeField] private TextMeshProUGUI name_paragraph;
    [SerializeField] private Button add_button;

    // Start is called before the first frame update
    void Start()
    {
        player_data.player_names.Clear();
        name_paragraph.SetText(string.Empty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_Add()
    {
        name_paragraph.SetText(name_paragraph.text + " " + name_input.text);
        player_data.AddName(name_input.text);
    }

    public void OnClick_StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
