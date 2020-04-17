using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private bool monstreGauche; // d'abord false; devient true quand le monstre sort
    private bool monstreDroite; // d'abord false; devient true quand le monstre sort

    public float timer; // temps; déclenché selon rythme
    public bool timerGo; // devient vrai au début du timer; redevient faux à la fin du timer
    public bool timerEnd; // devient vrai quand le timer est fini; redevient faux après réinitialisation

    public bool reussi; // devient vrai si l'action est réussie; redevient faux après réinitialisation
    public bool rate;

    private bool enfantCouverture; // OPTIONNEL ; devient aléatoirement true pour déclencher petite animation, puis repasse à false

    public Animator animator;

    public int score;


    /* To do:
 * - musique à rythme binaire : 2 coups
 *      -> 1er : indicateur
 *      -> 2eme : input 
 * - fonction détection deuxième coup : booleen? dxmeCoup = true
 * - si dxmeCoup = true : lancement timer + (timerGo = true) + (sortie = true) ->c'est le lancement de l'animation
 * - fin timer : (timerEnd = true) + (sortie = false)
 * - si ((timerGo == true) && (timerEnd == false) && (GetButtonDown("bouton"))) alors REUSSI -> si c'est conditions sont remplie on ne s'occuper pas du sinon
 * - sinon si ((timerGo == true) && (timerEnd == true)) alors RATE -> si la condition précédente n'est pas remplie on lit le sinon
 * - si REUSSI alors (coup = true)
 * - si RATE alors (peur = true)
 * - quand tout est fini, tous les booleens = false
 * - selon REUSSI ou RATE, ajout de points au score
 */

    void Start()
    {
        Debug.Log("game start");

        monstreGauche = false;
        monstreDroite = false;

        timer = 0;
        timerGo = false;
        timerEnd = false;

        reussi = false;
        rate = false;

        enfantCouverture = false;

        score = 0;
    }

    void Update()
    {

        MonstresOnOff();
 
        if (monstreDroite == true)
        {
            MonstreDroite();
        }
        

        if (monstreGauche == true)
        {
            MonstreGauche();
        }



        ReinitVar();

    }

    void MonstresOnOff()
    // les deux conditions suivantes permettent de basculer a true/false les booleens des monstres ; code temporaire en attendant qe pouvoir le faire automatiquement
    {
        if (Input.GetKeyDown(KeyCode.D) && (monstreDroite == false))
        {
            monstreDroite = true;
            Debug.Log("monstreDroite = true");
        }
        else
        {
            monstreDroite = false;
            Debug.Log("monstreDroite = false");
        }
        if (Input.GetKeyDown(KeyCode.G) && (monstreGauche == false))
        {
            monstreGauche = true;
            Debug.Log("monstreGauche = true");
        }
        else
        {
            monstreGauche = false;
            Debug.Log("monstreGauche = false");
        }
    }

    void ReinitVar()
    {
        //réinitialisation des variables (sauf le score)

        monstreGauche = false;
        monstreDroite = false;

        timer = 0;
        timerGo = false;
        timerEnd = false;

        reussi = false;
        rate = false;

        enfantCouverture = false;
    }

    void CalcScore()
    {
        // calcul du score selon action réussie ou ratée


    }


    void MonstreGauche()
    // !! ne pas confondre avec la variable monstreGauche
    {
        if (Input.GetButtonDown("Gauche"))
        {
            animator.SetBool("coupGaucheReussi", true);
        }
    }

    void MonstreDroite()
    // !! ne pas confondre avec la variable monstreDroite
    {
        if (Input.GetButtonDown("Droite"))
        {
            animator.SetBool("coupDroitReussi", true);
        }
    }

}
