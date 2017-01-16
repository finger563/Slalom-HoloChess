﻿using UnityEngine;

namespace Assets.Scripts
{
    public class CameraZoom : MonoBehaviour
    {
        private Vector3 _originalPosition;
        private Quaternion _originalRotation;
        private bool _isZoomed;

        private ClientGameState GameState
        {
            get { return GameManager.Instance.Client.GameState; }
        }

        public void Zoom()
        {
            if (_isZoomed)
            {
                ZoomOut();
            }
            else
            {
                ZoomIn();
            }
        }

        public void ZoomIn()
        {
            var selectedMonster = GameState.GetSelectedMonsterPrefab();
            if (_isZoomed || selectedMonster == null) return;

            // update camera location & rotation
            _originalPosition = Camera.main.transform.parent.localPosition;
            _originalRotation = Camera.main.transform.parent.localRotation;

            Camera.main.transform.parent.transform.localPosition = new Vector3(selectedMonster.transform.localPosition.x, 
                selectedMonster.transform.localPosition.y + .1f, selectedMonster.transform.localPosition.z);
            Camera.main.transform.parent.localScale = new Vector3(Camera.main.transform.localScale.x/25f, Camera.main.transform.localScale.y / 25f, Camera.main.transform.localScale.z / 25f);

            _isZoomed = true;
        }

        public void ZoomOut()
        {
            if (!_isZoomed) return;

            // update camera location
            Camera.main.transform.parent.transform.localPosition = _originalPosition;
            Camera.main.transform.parent.transform.localRotation = new Quaternion(_originalRotation.x, _originalRotation.y, _originalRotation.z, _originalRotation.w);

            Camera.main.transform.parent.localScale = new Vector3(Camera.main.transform.localScale.x * 25f, Camera.main.transform.localScale.y * 25f, Camera.main.transform.localScale.z * 25f);

            _isZoomed = false;
        }
    }
}