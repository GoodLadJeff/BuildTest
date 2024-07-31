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
            "Saute dans la piscine habill� ou bois 5",
            "nameone imite un autre joueur, le 1er qui trouve distribue 3",
            "Tu pref�re vivre la vie de nameone ou de nametwo ?",
            "nameone distribue 3",
            "Designez la personne la moins bien sapp�e, qui prendra 3",
            "nameone et nametwo font un shifumi pour 3",
            "Jusqu'au d�but de la prochaine heure, inversion du buffalo",
            "nameone et nametwo trinquent ensemble 4",
            "Tout le monde dis nique ta m�re � Yannis, qui prendra 745689 gorg�es",
            "nameone choisit la prochaine musique, si quelqu'un se plaint il prend 3",
            "Tu pr�f�res confier ton enfant 1 semaine � nameone ou nametwo, le joueur qui gagne distribue 3",
            "Tu pr�f�res que ton gosse te pr�sente nameone ou nametwo? qui prendra 4",
            "nameone chantonne une musique, le 1er qui trouve distribue 4",
            "nameone designe qui entre nametwo et namethree est le plus aigri, qui prendra 4",
            "Designez les 3 joueurs les plus bour�s, ils prennent 3",
            "Le verre le plus plein se met � la hauteur du moins plein, en buvant son contenant evidemment",
            "nameone pose une question de jeu de la pi�ce � nametwo, nameone et nametwo prennent 2",
            "Chacun bois le nombre de gorg�es de sa diff�rence de pointure avec 35",
            "nameone dans la m�me phrase, insulte et complimente nametwo",
            "Donnez tous une gorg�e a celui que vous consid�rez va �tre le dernier au karting. Si le karting est d�j� pass�, le perdant, c'est cul-sec",
            "Votons! Est ce que la darrone de nameone bat la daronne de nametwo � la bagarre? Le perdant prend 3",
            "Si ta soeur est goudou prends 5 gorg�es",
            "Les gens avec les cheveux color�s prennent 3 gorg�es",
            "Ceux qui ne sont pas all�s dans la piscine aujourd'hui prennent 5 gorg�es",
            "les voisins en partant de la droite du joueur ayant le tel en main se rem�morrent leur meilleur souvenir � deux, si c'est pas le m�me ils boivent 3 gorg�es, sinon ils en distribuent 4 chacun",
            "nameone donne la date d'anniv de nametwo, en cas de reussite nameone distribue 3 et nametwo boit 3, sinon l'inverse",
            "nameone si t'es � la bi�re, prend un shot, sinon, distribue un shot"
        };

        names = player_data.player_names;
    }
}
