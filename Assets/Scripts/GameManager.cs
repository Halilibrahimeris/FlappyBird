using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public int denemeHakký;
    private int[] keys = new int[] { 985, 288, 532, 552, 517, 987, 788, 722, 566, 793, 802, 760, 153, 425, 339, 158, 449, 233, 782, 982, 518, 665, 796, 531, 203, 649, 603, 723, 695, 607, 399, 611, 877, 969, 881, 498, 863, 403, 703, 883, 492, 528, 698, 155, 818, 192, 946, 560, 623, 209, 327, 159, 995, 496, 367, 519, 150, 733, 239, 898, 516, 161, 138, 263, 294, 842, 405, 839, 412, 937, 214, 934, 357, 979, 838, 432, 208, 318, 891, 875, 475, 269, 371, 580, 851, 290, 303, 148, 369, 220, 213, 810, 241, 771, 485, 794, 276, 358, 689, 671 };


    public bool InputKeys(int Input)
    {
        for (int i = 0; i < keys.Length; i++)
        {
            if(Input == keys[i])
            {
                denemeHakký += 5;
                return true;
            }
        }
        return false;
    }

}
