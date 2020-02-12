using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenemanager : MonoBehaviour

{
    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {
        CreateTilemap();
    }

    // Update is called once per frame
    private void CreateTilemap()
    {
        float tilesize = tile.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        for(int x=0; x<10; x++){
            for(int y=0; y<5; y++){
                GameObject newTile = Instantiate(tile);
                newTile.transform.position = new Vector3(tilesize*x, tilesize * y, 0);

            }
        }
    }
}

