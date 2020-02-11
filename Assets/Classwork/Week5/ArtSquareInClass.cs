using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script randomly selects items from an array
 * and scatters them randomly
 * It parents the items to the root object
 * so that they will be destroyed when 'rebuild' is true
 */

namespace Art
{
    public class ArtSquareInClass : ArtMakerTemplate
    {
        public GameObject[] objects;

        public int amount = 10;

        public override void MakeArt()
        {
            int amt = Random.Range(2, amount);
            for (int i = 0; i < amt; i++)
            {
                int index = Random.Range(0, objects.Length);
                GameObject g = Instantiate(objects[index]);

                g.transform.parent = root.transform;
                g.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

                g.transform.position = Random.insideUnitSphere*.5f;


                if(index==0){
                    g.transform.localScale = new Vector3(.1f,Random.Range(5f,10f),.1f);
                }
                else{
                    float s = Random.value * .25f;
                    g.transform.localScale = new Vector3(s, s, s);
                }
            }
        }
    }
}