using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsContainer : MonoBehaviour
{
    [HideInInspector] public List<string> questions;
    [HideInInspector] public List<string> names;
    [HideInInspector] public List<string> name_slot_def;

    private void Awake()
    {
        name_slot_def = new List<string>() { "nameone", "nametwo", "namethree" };

        questions = new List<string>() {
            "Bois si t'as déjà pensé que la meuf ou mec d'un joueur est bad laid",
            "Saute dans la piscine habillé ou bois",
            "nameone imite un autre joueur, le 1er qui trouve distribue 3 gorgées",
            "A main levée, tu prefère vivre la vie de nameone ou de nametwo",
            "nameone distribue 3 gorgées",
            "Designez la personne la moins bien sappée, qui prendra 3 gorgées",
            "nameone et nametwo font un shifumi pour 3 gorgées",
            "Jusqu'au début de la prochaine heure, innversion du buffalo",
            "nameone et nametwo trinquent leurs gorgées ensemble pdt 3 tours",
            "Tout le monde dis nique ta mère à Yannis, qui prendra 745689 gorgées",
            "nameone choisit la prochaine musique, si quelqu'un se plaint il prend 3 gorgées",
            "Tu préfères confier ton enfant 1 semaine à nameone ou nametwo",
            "Tu préfères que ton gosse te présente nameone ou nametwo, qui prendra 4 gorgées",
            "nameone chantonne une musique, le 1er qui trouve distribue 4 gorgées",
            "nameone designe qui entre nametwo et namethree est le plus aigri, qui prendra 4 gorgées",
            "On classe les joueurs du plus bourré au moins bourré, le plus bas prend 5 gorgées, puis 4 etc",
            "Le verre le plus plein se met à la hauteur du moins plein, en buvant son contenant evidemment",
            "nameone pose une question de jeu de la pièce à nametwo",
            "Chacun bois le nombre de gorgées de sa différence de pointure avec 35",
            "nameone dans la même phrase, insulte et complimente nametwo",
            "Donnez tous une gorgée a celui que vous considérez va être le dernier au karting. Si le karting est déjà passé, le perdant, c'est cul-sec",
            "Tierlist des daronnes, le progéniture des daronnes les bonnes prennent 5 gorgées",
            "Si ta soeur est goudou prends 5 gorgées",
            "nameone donne une anecdotes, les autres joueurs essaient de deviner si elle est vraie ou fausse. Les perdants prennent 3 gorgées",
            "nameone prend un shot",
            "Les gens avec les cheveux colorés prennent 3 gorgées",
            "Ceux qui ne sont pas allés dans la piscine aujourd'hui prennent 5 gorgées",
            "nameone si tu pécho nametwo, tout le monde prend 3 gorgées. En cas de refus 5 gorgées",
            "les voisins en partant de la droite du joueur ayant le tel en main se remémorrent leur meilleur souvenir à deux, si c'est pas le même ils boivent 3 gorgées, sinon ils en distribuent 4 chacun"
        };

        names = new List<string>() {
            "Eloise",
            "Lucas",
            "Yannis",
            "Cilou",
            "Geoffroy",
            "Corentin",
            "Joachim"
        };
    }
}
