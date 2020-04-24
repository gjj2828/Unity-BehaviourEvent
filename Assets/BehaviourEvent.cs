using UnityEngine;

public class BehaviourEvent : MonoBehaviour
{
    private string mName;
    private bool mIsLogUpdate = false;

    private void Awake() {
        mName = gameObject.name;
        Log("Awake");
    }

    private void OnEnable() {
        Log("OnEnable");
    }

    private void OnDisable() {
        Log("OnDisable");
    }

    private void OnDestroy() {
        Log("OnDestroy");
    }

    // Start is called before the first frame update
    void Start()
    {
        Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if(!mIsLogUpdate) {
            Log("First Update");
            mIsLogUpdate = true;
        }
    }

    void Log(string evt) {
        Debug.LogFormat("{0} {1} at frame {2}", mName, evt, Time.frameCount);
    }
}
