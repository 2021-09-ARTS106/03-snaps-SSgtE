using UnityEngine;
using UnityEngine.Rendering;

public class hdrrenderpipeline : MonoBehaviour
{


    public hdrrenderpipeline exampleAssetA;
    public hdrrenderpipeline exampleAssetb;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GraphicsSettings.renderPipleineAsset = exampleAssetA;
            Debug.Log("Defaultrender pipeline asset is: " + GraphicsSettings.renderPipelineAsset.name);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            GraphicsSettings.renderPipleineAsset = exampleAssetB;
            Debug.Log("Defaultrender pipeline asset is: " + GraphicsSettings.renderPipelineAsset.name);
        }
    }

}