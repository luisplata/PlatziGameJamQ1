﻿using System.Collections;
using UnityEngine;

public class MatrixBlender : MonoBehaviour
{
    Camera camera;
    PlayerController playerControler;
    public void Installer(Camera camera, PlayerController playerControler)
    {
        this.camera = camera;
        this.playerControler = playerControler;
    }
    public static Matrix4x4 MatrixLerp(Matrix4x4 from, Matrix4x4 to, float time)
    {
        Matrix4x4 ret = new Matrix4x4();
        for (int i = 0; i < 16; i++)
            ret[i] = Mathf.Lerp(from[i], to[i], time);
        return ret;
    }

    private IEnumerator LerpFromTo(Matrix4x4 src, Matrix4x4 dest, float duration, bool isOrtho)
    {
        float startTime = Time.time;
        while (Time.time - startTime < duration)
        {
            camera.projectionMatrix = MatrixLerp(src, dest, (Time.time - startTime) / duration);
            yield return 1;
        }
        camera.projectionMatrix = dest;
        playerControler.ShowContentByOrthoOn(isOrtho);
    }

    public Coroutine BlendToMatrix(Matrix4x4 targetMatrix, float duration, bool isOrtho)
    {
        StopAllCoroutines();
        return StartCoroutine(LerpFromTo(camera.projectionMatrix, targetMatrix, duration, isOrtho));
    }
}