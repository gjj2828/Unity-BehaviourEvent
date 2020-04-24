//using UnityEditor;
using UnityEngine;

public class BehaviourEventTester : MonoBehaviour
{
    public GameObject prefab;

    private GameObject mA;
    private GameObject mB;
    //private GameObject mC;
    //private GameObject mD;
    private GameObject mE;
    private GameObject mF;

    private bool mIsFirstUpdate = true;

    private void Awake() {
        mF = new GameObject("F", typeof(BehaviourEvent));
    }

    // Start is called before the first frame update
    void Start()
    {
        mA = new GameObject("A", typeof(BehaviourEvent));
        mB = new GameObject("B", typeof(BehaviourEvent));
        //GameObject go = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/BehaviourEvent.prefab");
        //mC = Instantiate(prefab);
        //mD = new GameObject("D");
        //mD.AddComponent<BehaviourEvent>();
        Invoke("DisableAll", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(mIsFirstUpdate) {
            mE = new GameObject("E", typeof(BehaviourEvent));
            mIsFirstUpdate = false;
        }
    }

    void DisableAll() {
        mA.SetActive(false);
        mB.SetActive(false);
        Invoke("EnableAll", 1.0f);
    }

    void EnableAll() {
        mA.SetActive(true);
        mB.SetActive(true);
        Invoke("DestroyAll", 1.0f);
    }

    void DestroyAll() {
        Object.Destroy(mA);
        Object.Destroy(mB);
        //Object.Destroy(mD.GetComponent<BehaviourEvent>());
    }
}
