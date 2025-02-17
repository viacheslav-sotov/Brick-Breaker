using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour
{
    //Vars
    [SerializeField] protected int hitsToBreak;
    protected int curHitsToBreak = 0;

    //Methods
    public void Awake()
    {
        curHitsToBreak = hitsToBreak;
    }

    public void Break(int aDamage)
    {
        curHitsToBreak -= aDamage;

        BreakBrick();
    }


    protected void BreakBrick()
    {
        if (curHitsToBreak > 0)
        {
            Destroy(gameObject);
        }
        FindObjectsOfType<RoundManager>().RemoveBrick(this);
    }

    //Accessors
}
