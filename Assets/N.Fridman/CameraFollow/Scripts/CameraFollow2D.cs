using UnityEngine;

namespace N.Fridman.CameraFollow.Scripts
{
    public class CameraFollow2D : MonoBehaviour
    {
        [Header("Parameters")]
        [SerializeField] private Transform playerTransform;
        [SerializeField] private string playerTag;
        [SerializeField] [Range(0.5f, 7.5f)] private float movingSpeed = 1.5f;
        [SerializeField]
        float leftLimit;
        [SerializeField]
        float rightLimit;
        [SerializeField]
        float bottomLimit;
        [SerializeField]
        float upperLimit;

        private void Awake()
        {
            if (this.playerTransform == null)
            {
                if (this.playerTag == "")
                {
                    this.playerTag = "Player";
                }
            
                this.playerTransform = GameObject.FindGameObjectWithTag(this.playerTag).transform;
            }
        
            this.transform.position = new Vector3()
            {
                x = this.playerTransform.position.x,
                y = this.playerTransform.position.y,
                z = this.playerTransform.position.z - 10,
            };
        }

        private void Update()
        {
            if (this.playerTransform)
            {
                Vector3 target = new Vector3()
                {
                    x = this.playerTransform.position.x,
                    y = this.playerTransform.position.y,
                    z = this.playerTransform.position.z - 10,
                };

                Vector3 pos = Vector3.Lerp(this.transform.position, target, this.movingSpeed * Time.deltaTime);

                this.transform.position = pos;
            }
            transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
             Mathf.Clamp(transform.position.y, bottomLimit, upperLimit),
             transform.position.z
            );
        }
    
    }
}
