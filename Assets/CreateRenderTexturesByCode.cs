using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRenderTexturesByCode : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        RenderTexture renderTexture = new RenderTexture(250, 250, 4);
        Camera.main.targetTexture = renderTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
