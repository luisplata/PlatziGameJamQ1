using UnityEngine;

[RequireComponent(typeof(MatrixBlender))]
public class PerspectiveSwitcher : MonoBehaviour
{
    private Matrix4x4 ortho,
                        perspective;
    public float fov = 60f,
                        near = .3f,
                        far = 1000f,
                        orthographicSize;
    private float aspect;
    private MatrixBlender blender;
    public bool orthoOn = true;
    public Camera camera;
    public PlayerController playerController;

    void Start()
    {
        aspect = (float)Screen.width / (float)Screen.height;
        ortho = Matrix4x4.Ortho(-orthographicSize * aspect, orthographicSize * aspect, -orthographicSize, orthographicSize, near, far);
        perspective = Matrix4x4.Perspective(fov, aspect, near, far);
        camera.projectionMatrix = ortho;
        orthoOn = true;
        blender = (MatrixBlender)GetComponent(typeof(MatrixBlender));
        blender.Installer(camera, playerController);
        playerController.ShowContentByOrthoOn(orthoOn);
    }
    public void SwitcherPrespective(Animator anim)
    {
        orthoOn = !orthoOn;
        if (orthoOn)
        {
            anim.SetTrigger("presp");
            Physics.gravity = new Vector3(0, -1.0F, 0);
            blender.BlendToMatrix(ortho, 1f, orthoOn);
        }
        else
        {
            anim.SetTrigger("orto");
            Physics.gravity = new Vector3(0, 0, -1.0F);
            blender.BlendToMatrix(perspective, 1f, orthoOn);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitcherPrespective(GetComponent<Animator>());
        }
    }
}