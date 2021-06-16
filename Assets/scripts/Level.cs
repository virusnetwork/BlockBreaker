using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks = 0;

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
}
