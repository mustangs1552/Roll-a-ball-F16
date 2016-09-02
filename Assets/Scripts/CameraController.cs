// (Unity3D) New monobehaviour script that includes regions for common sections, and supports debugging.
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    #region GlobalVareables
    #region DefaultVareables
    public bool isDebug = false;
    private string debugScriptName = "CameraController";
    #endregion

    #region Public
    public GameObject player = null;
    #endregion

    #region Private
    private Vector3 offset = Vector3.zero;

    #region ExternalScripts

    #endregion
    #endregion
    #endregion

    #region CustomFunction
    #region Public

    #endregion

    #region Private

    #endregion

    #region Debug
    private void PrintDebugMsg(string msg)
    {
        if (isDebug) Debug.Log(debugScriptName + "(" + this.gameObject.name + "): " + msg);
    }
    private void PrintWarningDebugMsg(string msg)
    {
        Debug.LogWarning(debugScriptName + "(" + this.gameObject.name + "): " + msg);
    }
    private void PrintErrorDebugMsg(string msg)
    {
        Debug.LogError(debugScriptName + "(" + this.gameObject.name + "): " + msg);
    }
    #endregion

    #region Getters

    #endregion

    #region Setters

    #endregion
    #endregion

    #region UnityFunctions

    #endregion

    #region Start_Update
    // Use this for initialization
    void Start()
    {
        if (isDebug) Debug.Log(debugScriptName + ": Loaded.");

        #region ExternalScriptAssignments

        #endregion
        
        offset = transform.position - player.transform.position;
    }
    // Called every fixed frame
    void FixedUpdate()
    {

    }
    // Called each frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    #endregion
}