using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsContainer : MonoBehaviour
{
    [SerializeField] private PlayerNames_Data player_data;

    [HideInInspector] public List<string> questions;
    [HideInInspector] public List<string> names;
    [HideInInspector] public List<string> name_slot_def;

    private void Awake()
    {
        name_slot_def = new List<string>() { "nameone", "nametwo", "namethree" };

        questions = new List<string>() {
            "Saute dans la piscine habillé ou bois 5",
            "nameone imite un autre joueur, le 1er qui trouve distribue 3",
            "Tu prefère vivre la vie de nameone ou de nametwo ?",
            "nameone distribue 3",
            "Designez la personne la moins bien sappée, qui prendra 3",
            "nameone et nametwo font un shifumi pour 3",
            "Jusqu'au début de la prochaine heure, inversion du buffalo",
            "nameone et nametwo trinquent ensemble 4",
            "Tout le monde dis nique ta mère à Yannis, qui prendra 745689 gorgées",
            "nameone choisit la prochaine musique, si quelqu'un se plaint il prend 3",
            "Tu préfères confier ton enfant 1 semaine à nameone ou nametwo, le joueur qui gagne distribue 3",
            "Tu préfères que ton gosse te présente nameone ou nametwo? qui prendra 4",
            "nameone chantonne une musique, le 1er qui trouve distribue 4",
            "nameone designe qui entre nametwo et namethree est le plus aigri, qui prendra 4",
            "Designez les 3 joueurs les plus bourés, ils prennent 3",
            "Le verre le plus plein se met à la hauteur du moins plein, en buvant son contenant evidemment",
            "nameone pose une question de jeu de la pièce à nametwo, nameone et nametwo prennent 2",
            "Chacun bois le nombre de gorgées de sa différence de pointure avec 35",
            "nameone dans la même phrase, insulte et complimente nametwo",
            "Donnez tous une gorgée a celui que vous considérez va être le dernier au karting. Si le karting est déjà passé, le perdant, c'est cul-sec",
            "Votons! Est ce que la darrone de nameone bat la daronne de nametwo à la bagarre? Le perdant prend 3",
            "Si ta soeur est goudou prends 5 gorgées",
            "Les gens avec les cheveux colorés prennent 3 gorgées",
            "Ceux qui ne sont pas allés dans la piscine aujourd'hui prennent 5 gorgées",
            "les voisins en partant de la droite du joueur ayant le tel en main se remémorrent leur meilleur souvenir à deux, si c'est pas le même ils boivent 3 gorgées, sinon ils en distribuent 4 chacun",
            "nameone donne la date d'anniv de nametwo, en cas de reussite nameone distribue 3 et nametwo boit 3, sinon l'inverse",
            "nameone si t'es à la bière, prend un shot, sinon, distribue un shot"
        };

        names = player_data.player_names;
    }
}
