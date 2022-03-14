using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    public GameObject gridMeteor;
    public int columnLenght;
    public int rowHeight;
    public GameObject[,] gridArray;
    private List<string> cellName = new List<string>();
    // Start is called before the first frame update
    void Start()
    {

        GameObject square = GameObject.Find("Square");
        Debug.Log(square.name);
        square.SetActive(false);

        TextMesh cellText = square.GetComponentInChildren<TextMesh>();
        Debug.Log(cellText.text);

       

        //cellText.text = "lol";

        // Adding name in list //

        cellName.Add("crow");
        cellName.Add("cow");
        cellName.Add("horse");
        cellName.Add("cat");
        cellName.Add("pigeon");
        cellName.Add("sparrow");
        cellName.Add("abc");
        cellName.Add("xyz");
        cellName.Add("lol");

        
        // Grid code //

        gridArray = new GameObject[columnLenght, rowHeight];
        for (int i = 0; i < columnLenght; i++) 
        {
            for (int j = 0; j < rowHeight; j++) 
            {
                int randomIndex = Random.Range(1, cellName.Count -1);
                gridArray[i, j] = Instantiate(gridMeteor,new Vector2(i * 2,j * 2), Quaternion.identity) as GameObject;
                gridArray[i, j].GetComponentInChildren<TextMesh>().text = cellName[randomIndex];

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
