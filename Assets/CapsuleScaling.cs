using UnityEngine;

public class CapsuleScaling : MonoBehaviour
{
    [SerializeField]private float ScalingSpeed = 0.02f;
    [SerializeField]private float MaxScaling = 3f;
    [SerializeField]private float MinScaling = 0.5f;

    private bool _isScalingUp = true;

    void Update()
    {
        if (_isScalingUp)
        {
            transform.localScale += Vector3.one * ScalingSpeed * Time.deltaTime;

            if (transform.localScale.x >= MaxScaling)
            {
                _isScalingUp = false;
            }
        }
        else
        {
            transform.localScale -= Vector3.one * ScalingSpeed * Time.deltaTime;

            if (transform.localScale.x <= MinScaling)
            {
                _isScalingUp = true;
            }
        }
    }
}
