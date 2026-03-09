using UnityEngine;

public class GeraMundo : MonoBehaviour
{
    public GameObject[] plataformas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject falsoPlayer = new GameObject("falso");

        falsoPlayer.transform.Translate(Vector3.forward * -10);
        // Vector3 pos = new Vector3(0, 0, 0);
        for (int i = 0; i < 30; i++)
        {
            int numeroPlataforma = Random.Range(0, plataformas.Length);

            // if(i==0) numeroPlataforma = 0;

            if ((plataformas[numeroPlataforma].tag == "platformZ") ||
                (plataformas[numeroPlataforma].tag == "platformZThin") ||
                (plataformas[numeroPlataforma].tag == "platformZSplit")
            )
            {
                int repete = Random.Range(0, 4);
                for (int j = 0; j < repete; j++)
                {
                    GameObject p2 = Instantiate(
                        plataformas[numeroPlataforma],
                        falsoPlayer.transform.position,
                        falsoPlayer.transform.rotation);
                    falsoPlayer.transform.Translate(Vector3.forward * -10);
                }
            }

            // if (i == 0)
            // {
            //     if (
            //         (plataformas[numeroPlataforma].tag == "stairsUp") ||
            //         (plataformas[numeroPlataforma].tag == "stairsDown") ||
            //         (plataformas[numeroPlataforma].tag == "platformZ") ||
            //         (plataformas[numeroPlataforma].tag == "platformZThin") ||
            //         (plataformas[numeroPlataforma].tag == "platformZSplit") ||
            //         (plataformas[numeroPlataforma].tag == "platformZFire") ||
            //         (plataformas[numeroPlataforma].tag == "platformZThinFire") ||
            //         (plataformas[numeroPlataforma].tag == "platformZSplitFire") ||
            //         (plataformas[numeroPlataforma].tag == "platformTSection")
            //         )
            //     {
            //         falsoPlayer.transform.Translate(Vector3.forward * -10);
            //     }
            // }


            // GameObject p = Instantiate(plataformas[numeroPlataforma], pos, Quaternion.identity);
            GameObject p = Instantiate(
                plataformas[numeroPlataforma],
                falsoPlayer.transform.position,
                falsoPlayer.transform.rotation);


            if (plataformas[numeroPlataforma].tag == "stairsUp")
            {
                // pos.y += 5;
                falsoPlayer.transform.Translate(0, 5, 0);
            }
            else if (plataformas[numeroPlataforma].tag == "stairsDown")
            {
                // pos.y -= 5;
                falsoPlayer.transform.Translate(0, -5, 0);
                p.transform.Rotate(new Vector3(0, 180, 0));
                // p.transform.position = pos;
                p.transform.position = falsoPlayer.transform.position;
            }
            else if (plataformas[numeroPlataforma].tag == "platformTSection")
            {
                if (Random.Range(0, 2) == 0)
                    falsoPlayer.transform.Rotate(new Vector3(0, 90, 0));
                else
                    falsoPlayer.transform.Rotate(new Vector3(0, -90, 0));
                falsoPlayer.transform.Translate(Vector3.forward * -10);
            }
            // pos.z -=10;
            falsoPlayer.transform.Translate(Vector3.forward * -10);
        }
    }

    // // Update is called once per frame
    // void Update()
    // {

    // }
}
