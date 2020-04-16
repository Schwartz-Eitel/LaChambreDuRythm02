using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeShifting : MonoBehaviour
{
    public GameObject shapeShiftingMesh; //Mesh dont on veut changer la scale ou tout autre propriété a modifier selon le son
    [SerializeField] public int nSample; //Fréquence du son que l'on veut attribuer au mesh

    // Start is called before the first frame update
    void Start()
    {
        shapeShiftingMesh = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        shapeShiftingMesh.transform.localScale = new Vector3(/*(AudioP.fSamples[nSample] * 0.75f  + 0.6f)*/0.8f, /*(AudioP.fSamples[nSample] * 0.75f + 0.5f)*/0.8f ,(AudioP.fSamples[nSample] * 0.75f + 0.8f));
        //Formule pour modifier les trois valeurs de la scale (x,y,z) en fonction du son.
    }
}
