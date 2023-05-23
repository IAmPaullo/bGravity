using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NPC.Shopkeeper
{
    public class NPCInteraction : MonoBehaviour
    {
        public GameObject shopUIPrefab;
        public GameObject dialogUIPrefab;
        public string dialogText = "Welcome to my shop!";
        private GameObject dialogUI;
        private bool isDialogOpen = false;

        public void OpenShop()
        {

        }
        private void OpenDialog()
        {


            isDialogOpen = true;
        }

        // Function to close the dialog window
        private void CloseDialog()
        {
            if (dialogUI != null)
            {
                Destroy(dialogUI);
            }

            isDialogOpen = false;
        }

        // Function to handle player interaction with the NPC
        public void Interact()
        {
            if (!isDialogOpen)
            {
                // Open the dialog window
                OpenDialog();
            }
            else
            {
                // Close the dialog window and open the shop UI
                CloseDialog();
                OpenShop();
            }
        }
    }
}