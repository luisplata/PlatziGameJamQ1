using Cinemachine;
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
    public CinemachineVirtualCamera virtualCamera;
    public ControlesDeUI ui;
    public GameObject ui3D;

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
        SwitcherPrespective(GetComponent<Animator>());
        ui.DesactivarUI();
        ui.HiddeMenu();
    }
    public void SwitcherPrespective(Animator anim)
    {
        orthoOn = !orthoOn;
        if (orthoOn)
        {
            anim.SetTrigger("presp");
            blender.BlendToMatrix(ortho, 1f, orthoOn);
            virtualCamera.Follow = playerController.Rendering2D.transform;
            Physics.gravity = ConstantesDeProyecto.gravedad;
            ui.ActivarUI();
            ui3D.SetActive(false);
        }
        else
        {
            anim.SetTrigger("orto");
            blender.BlendToMatrix(perspective, 1f, orthoOn);
            virtualCamera.Follow = playerController.Rendering3D.transform;
            Physics.gravity = ConstantesDeProyecto.gravedad * 0;
            ui.DesactivarUI();
            ui3D.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SwitcherPrespective(GetComponent<Animator>());
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ui.ShowMenu();
        }

    }
}