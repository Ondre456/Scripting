using UnityEngine;

public class Scaller : MonoBehaviour
{
    [SerializeField]private float Speed = 0.02f;
    [SerializeField]private float Max = 3f;
    [SerializeField]private float Min = 0.5f;

    private bool _isScalingUp = true;

    void Update()
    {
        if (_isScalingUp)
        {
            transform.localScale += Vector3.one * Speed * Time.deltaTime;

            if (transform.localScale.x >= Max)
            {
                _isScalingUp = false;
            }
        }
        else
        {
            transform.localScale -= Vector3.one * Speed * Time.deltaTime;

            if (transform.localScale.x <= Min)
            {
                _isScalingUp = true;
            }
        }
    }
}
