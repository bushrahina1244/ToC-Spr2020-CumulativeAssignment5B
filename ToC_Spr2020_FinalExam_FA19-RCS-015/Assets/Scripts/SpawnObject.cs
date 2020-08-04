using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour
{

    string catchvalue;
    private GameObject particle;
    public GameObject pickCube;

    public GameObject childobject;

    findObjectChild objchild = new findObjectChild();


    //public Vector3 center;
    //public Vector3 size;
    //public LayerMask mask;
    //public bool checkCubefun = false;

   // public GameObject CubePrefab;
    private GameObject txt_box_parent;
    public Text txt_box;


    // Start is called before the first frame update
    void Start()
    {
      
        StartCoroutine(cubespawn());
      

    }

    // Update is called once per frame
    void Update()
    {

        


    }
   
    

    IEnumerator cubespawn()
    {
        for (int i = 1; i <= 30; i += 1)
        {

            Instantiate(pickCube, new Vector3(Random.Range(-7f, 17f), 1, 6), Quaternion.identity);
            yield return new WaitForSeconds(3.0f);
            if (i < 30)
            {
                childobject.GetComponent<TextMesh>().text = objchild.MatchingParanthesis();
            }
            else
            {
                childobject.GetComponent<TextMesh>().text = objchild.changeString();
               
                particle = childobject.gameObject.transform.Find("Particle System").gameObject;
                particle.SetActive(false);
            }
            
           
          
        }
        
        for (int i = 15; i <= 20; i += 1)
        {
            Instantiate(pickCube, new Vector3(Random.Range(-7f, 7f), 1, -9), Quaternion.identity);
            yield return new WaitForSeconds(3.0f);
        }

        for (int i = 21; i <= 30; i += 1)
        {
            Instantiate(pickCube, new Vector3(Random.Range(-9f, 19f), 1, -5), Quaternion.identity);
            yield return new WaitForSeconds(3.0f);

        }

        for (int i = 31; i <= 45; i += 1)
        {
            Instantiate(pickCube, new Vector3(Random.Range(-5f, 15f), 1, -3), Quaternion.identity);
            yield return new WaitForSeconds(3.0f);

        }

    }






    public void setText()
    {
        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        txt_box.transform.position = namePos;
    }


}
