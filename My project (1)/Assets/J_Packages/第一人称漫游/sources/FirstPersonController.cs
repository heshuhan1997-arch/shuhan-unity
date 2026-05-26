using UnityEngine;

namespace J_Packages
{
    // 第一人称漫游控制
    [RequireComponent(typeof(CharacterController))] // 自动添加CharacterController组件
    public class FirstPersonController : MonoBehaviour
    {
        public static FirstPersonController Inst;
        private void Awake()
        {
            Inst = this;
        }
        public bool m_bInteractable = true;
        // 可在Inspector面板调整的参数
        [Header("移动设置")]
        public float moveSpeed = 5f;       // 移动速度
        public float mouseSensitivity = 2f;// 鼠标灵敏度
        public float jumpForce = 3f;       // 跳跃力度

        // 私有变量
        private CharacterController cc;    // 角色控制器引用
        private float verticalRot = 0f;    // 相机垂直旋转角度（限制上下视角）
        private float verticalSpeed = 0f;  // 垂直方向速度（重力/跳跃）
        private readonly float gravity = 9.8f; // 重力值

        void Start()
        {
            // 获取组件引用
            cc = GetComponent<CharacterController>();
        }

        void Update()
        {
            if (m_bInteractable)
            {
                // 1. 鼠标视角控制
                MouseLook();
            }
        }
        private void FixedUpdate()
        {
            if (m_bInteractable)
            {
                // 2. 键盘移动控制（含重力/跳跃）
                MoveAndJump();
            }
        }

        // 鼠标视角控制
        void MouseLook()
        {
            if (Input.GetMouseButton(1))
            {

                // 获取鼠标偏移量
                float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
                float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

                // 水平旋转（玩家整体旋转）
                transform.Rotate(0, mouseX, 0);

                // 垂直旋转（相机旋转，限制-80到80度避免翻转）
                verticalRot -= mouseY;
                verticalRot = Mathf.Clamp(verticalRot, -80f, 80f);
                Camera.main.transform.localRotation = Quaternion.Euler(verticalRot, 0, 0);

            }
        }

        // 移动和跳跃
        void MoveAndJump()
        {
            // 获取WASD输入
            float h = Input.GetAxis("Horizontal"); // 左右
            float v = Input.GetAxis("Vertical");   // 前后

            // 计算移动方向（转换为世界空间，避免相机旋转影响移动）
            Vector3 moveDir = transform.right * h + transform.forward * v;
            moveDir.Normalize(); // 归一化，避免斜向移动更快

            // 处理重力
            if (cc.isGrounded) // 落地时重置垂直速度
            {
                verticalSpeed = 0;
                // 跳跃检测
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    verticalSpeed = jumpForce;
                }
            }
            else // 空中应用重力
            {
                verticalSpeed -= gravity * Time.deltaTime;
            }

            // 加入垂直方向速度
            moveDir.y = verticalSpeed;

            // 执行移动（Time.deltaTime保证帧率无关）
            cc.Move(moveDir * moveSpeed * Time.deltaTime);
        }
    }
}