using UnityEngine;
//using UnityEngine.InputSystem; Cannot read?

public class MyPhysics : MonoBehaviour
{
    [SerializeField] private GameObject _canonBallPrefab;
    [SerializeField] private ForceMode _forceMode;
    [SerializeField] private Vector3 _force;
    private Rigidbody _canonBallBody;

    void Start()
    {
        _canonBallBody = Instantiate(_canonBallPrefab, transform).GetComponent<Rigidbody>();
        _canonBallBody.AddForce(_force, _forceMode);
    }

    private void Update()
    {
        /*if (Mouse.current.leftButton.wasPressedThisFrame) //Commented out due to Unity having trouble reading select code
        {
            _canonBallBody.AddForce(_force, _forceMode);
        }
        
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            //
        }*/
    }
}
