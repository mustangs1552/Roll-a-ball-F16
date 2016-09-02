// (Unity3D) New monobehaviour script that includes regions for common sections, and supports debugging.
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    #region GlobalVareables
    #region DefaultVareables
    public bool isDebug = false;
    private string debugScriptName = "PlayerController";
    #endregion

    #region Public
    public float spd = 1;
    #endregion

    #region Private
    private Rigidbody rb = null;

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
    void OnTriggerEnter(Collider otherObj)
    {
        if(otherObj.gameObject.CompareTag("PickUp"))
        {
            otherObj.gameObject.SetActive(false);
        }
    }
    #endregion

    #region Start_Update
    // Use this for initialization
    void Start()
    {
        if (isDebug) Debug.Log(debugScriptName + ": Loaded.");
        
        rb = GetComponent<Rigidbody>();

        #region ExternalScriptAssignments

        #endregion
    }
    // Called every fixed frame, called before physics calculations
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(moveHorizontal * spd, 0, moveVertical * spd));
    }
    // Called before each frame
    void Update()
    {

    }
    #endregion
}