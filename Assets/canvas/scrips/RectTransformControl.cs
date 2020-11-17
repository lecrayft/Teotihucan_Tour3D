using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectTransformControl : MonoBehaviour
{
    public RectTransform scroll;
    private void Update()
    {
        //////////// Vertical   ///////////////////////// 1

        if (Input.GetKeyDown("1"))
        {// if input 1

            scroll.offsetMin = new Vector2(0, 0);
            scroll.offsetMin = new Vector2(1, 710);

        } // if input 1

        //////////// Vertical   /////////////////////////  1
        

        //////////// Vertical   ///////////////////////// 2

        if (Input.GetKeyDown("2"))
        {// if input 2

            scroll.offsetMin = new Vector2(1, -710);
            scroll.offsetMin = new Vector2(0, 0);

        } // if input 2

        //////////// Vertical   ///////////////////////// 2

        //////////// horizontal   /////////////////////////   3

        if (Input.GetKeyDown("3"))
        {// if input 3

            scroll.offsetMin = new Vector2(0, 0);
            scroll.offsetMin = new Vector2(710, 1);

        } // if input 3

        //////////// horizontal   /////////////////////////   3

        //////////// horizontal   /////////////////////////  4

        if (Input.GetKeyDown("4"))
        {// if input 4

            scroll.offsetMin = new Vector2(-710, 1);
            scroll.offsetMin = new Vector2(0, 0);

        } // if input 4

        //////////// horizontal   /////////////////////////  4

    }




}
