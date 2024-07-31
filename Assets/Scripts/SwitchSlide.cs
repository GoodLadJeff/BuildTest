using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SwitchSlide : MonoBehaviour
{
    [SerializeField] private GenericSlide generic_slide = default;
    [SerializeField] private QuestionsContainer questions_container = default;

    private List<string> questions;
    private List<string> names;
    public List<string> weighted_names;

    public List<string> names_ingame;

    private int current_slide_index = 0;

    private void Start()
    {
        questions = questions_container.questions;
        names = questions_container.names;
        names_ingame = new List<string>();
        
        FillTheNameWeightedList();

        NextQuestion();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            NextQuestion();
        }
    }

    private void InitializeFirstQuestion()
    {
        current_slide_index = 0;
        CheckIfNameInQuestion();
        generic_slide.SetText(questions[0]);
    }

    private void NextQuestion()
    {
        names_ingame.Clear();

        if (questions.Count == 0)
        {
            generic_slide.SetText("Partie terminée");
        }

        current_slide_index = UnityEngine.Random.Range(0, questions.Count - 1);
        CheckIfNameInQuestion();

        generic_slide.SetText(questions[current_slide_index]);
        questions.RemoveAt(current_slide_index);
    }

    int security = 0;

    private void CheckIfNameInQuestion()
    {
        
        if(security > 6)
        {
            print("EXPLOSION");
            security = 0;
            return;
        }
        

        string def_to_modify = "null";

        for (int i = 0; i < questions_container.name_slot_def.Count; i++)
        {
            if (questions[current_slide_index].Contains(questions_container.name_slot_def[i]))
            {
                def_to_modify = questions_container.name_slot_def[i];
                break;
            }
        }

        if (def_to_modify != "null")
        {
            string current_question = questions[current_slide_index];
            int random_name_index = PickARandomIndexName();
            string name_picked = weighted_names[random_name_index];

            bool name_is_already_in_question = false;
            for (int i = 0; i < names_ingame.Count; i++)
            {
                if (names_ingame[i] == name_picked)
                {
                    name_is_already_in_question = true;
                }
            }

            if(!name_is_already_in_question)            
            {
                print("onéla");
                current_question = current_question.Replace(def_to_modify, name_picked);
                questions[current_slide_index] = current_question;
                weighted_names.RemoveAt(random_name_index);
                names_ingame.Add(name_picked);
            }

            CheckIfNameInQuestion();
            security = 0;
        }
        else
        {
            security++;
        }
    }

    private int PickARandomIndexName()
    {
        bool all_names_are_same = true;
        string test_name = weighted_names[0];

        for (int i = 1; i < weighted_names.Count; i++)
        {
            if (weighted_names[i] != test_name) 
                all_names_are_same = false;
        }

        if (all_names_are_same) 
            FillTheNameWeightedList();

        int random_index = UnityEngine.Random.Range(0, weighted_names.Count - 1);
        return random_index;
    }

    private void FillTheNameWeightedList()
    {
        //weighted_names.Clear();

        for (int i = 0; i < names.Count; i++)
        {
            for (int y = 0; y < 3; y++)
            {
                weighted_names.Add(names[i]);
            }
        }
    }
}