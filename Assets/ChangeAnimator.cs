using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    
    public void getAnimatorCroun(){
        this.GetComponent<Animator>().Play("Cr");
    }

    public void getAnimatorTaunt(){
        this.GetComponent<Animator>().Play("Ta");
    }

}
