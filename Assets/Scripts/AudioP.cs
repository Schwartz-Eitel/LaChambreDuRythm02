using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof (AudioSource))]
public class AudioP : MonoBehaviour
{
    AudioSource audioSource;//Le fichier son joué
    public static float[] fSamples = new float[512];//Tableau de sample/fréquence du son (ex fréquence 1,2,3,4 etc)

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();//Dans unity il faut faire référence de la souce audio gérer par ce code 
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
    }

    void GetSpectrumAudioSource()
    {
        audioSource.GetSpectrumData(fSamples,0,FFTWindow.Blackman); //Retourne le spectre de de la source audio 
    }
}
