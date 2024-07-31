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
            "Bois si t'as d�j� pens� que la meuf ou mec d'un joueur est bad laid",
            "Saute dans la piscine habill� ou bois",
            "nameone imite un autre joueur, le 1er qui trouve distribue 3 gorg�es",
            "A main lev�e, tu pref�re vivre la vie de nameone ou de nametwo",
            "nameone distribue 3 gorg�es",
            "Designez la personne la moins bien sapp�e, qui prendra 3 gorg�es",
            "nameone et nametwo font un shifumi pour 3 gorg�es",
            "Jusqu'au d�but de la prochaine heure, innversion du buffalo",
            "nameone et nametwo trinquent leurs gorg�es ensemble pdt 3 tours",
            "Tout le monde dis nique ta m�re � Yannis, qui prendra 745689 gorg�es",
            "nameone choisit la prochaine musique, si quelqu'un se plaint il prend 3 gorg�es",
            "Tu pr�f�res confier ton enfant 1 semaine � nameone ou nametwo",
            "Tu pr�f�res que ton gosse te pr�sente nameone ou nametwo, qui prendra 4 gorg�es",
            "nameone chantonne une musique, le 1er qui trouve distribue 4 gorg�es",
            "nameone designe qui entre nametwo et namethree est le plus aigri, qui prendra 4 gorg�es",
            "On classe les joueurs du plus bourr� au moins bourr�, le plus bas prend 5 gorg�es, puis 4 etc",
            "Le verre le plus plein se met � la hauteur du moins plein, en buvant son contenant evidemment",
            "nameone pose une question de jeu de la pi�ce � nametwo",
            "Chacun bois le nombre de gorg�es de sa diff�rence de pointure avec 35",
            "nameone dans la m�me phrase, insulte et complimente nametwo",
            "Donnez tous une gorg�e a celui que vous consid�rez va �tre le dernier au karting. Si le karting est d�j� pass�, le perdant, c'est cul-sec",
            "Tierlist des daronnes, le prog�niture des daronnes les bonnes prennent 5 gorg�es",
            "Si ta soeur est goudou prends 5 gorg�es",
            "nameone donne une anecdotes, les autres joueurs essaient de deviner si elle est vraie ou fausse. Les perdants prennent 3 gorg�es",
            "nameone prend un shot",
            "Les gens avec les cheveux color�s prennent 3 gorg�es",
            "Ceux qui ne sont pas all�s dans la piscine aujourd'hui prennent 5 gorg�es",
            "nameone si tu p�cho nametwo, tout le monde prend 3 gorg�es. En cas de refus 5 gorg�es",
            "les voisins en partant de la droite du joueur ayant le tel en main se rem�morrent leur meilleur souvenir � deux, si c'est pas le m�me ils boivent 3 gorg�es, sinon ils en distribuent 4 chacun"
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
