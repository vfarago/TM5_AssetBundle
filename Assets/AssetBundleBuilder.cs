#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

public class AssetBundleBuilder : MonoBehaviour
{
    public class CreateAssetBundles
    {
        [MenuItem("Additional/Build AssetBundles")]
        static void BuildAllAssetBundles()
        {
            BuildPipeline.BuildAssetBundles("Assets/BuildFiles", BuildAssetBundleOptions.None, BuildTarget.Android);
        }
    }
}
#endif
