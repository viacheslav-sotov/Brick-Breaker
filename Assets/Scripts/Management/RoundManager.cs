using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    [SerializeField] protected List<BreakableBrick> bricks;
    [SerializeField] protected GameObject canvasScene;

    // methods
    private void Awake()
    {
        GameObject[] gOs = GameObject.FindObjectsOfType<GameObject>();

        if (gOs.Length > 1 )
        {
            Destroy(gameObject);
        }
    }

    public void RemoveBrick(BreakableBrick bb)
    {
        if(bricks.Count > 0)
        {
            bricks.Remove(bb);
        }
        EndRound();
    }

    protected void EndRound()
    {
        if (bricks.Count <= 0)
        {
            canvasScene.SetActive(true);
        }
    }
}
