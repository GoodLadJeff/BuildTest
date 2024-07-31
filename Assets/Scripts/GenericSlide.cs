using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GenericSlide : MonoBehaviour
{
    [SerializeField] private RawImage background;
    [SerializeField] private GameObject text;
    private TextMeshProUGUI text_mesh_pro;

    private void Awake()
    {
        text_mesh_pro = text.GetComponent<TextMeshProUGUI>();
    }

    public void SetBackground(Texture new_background)
    {
        background.texture = new_background;
    }

    public void SetText(string new_text)
    {
        text_mesh_pro.SetText(new_text);
    }
}
