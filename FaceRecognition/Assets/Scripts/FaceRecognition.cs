using UnityEngine;
using System.Collections;
using System.Drawing;
using System.IO;

public class FaceRecognition : MonoBehaviour {
    public Bitmap ImageToSearch;
    public GameObject PictureCube;

    Renderer pictureRender;

    // Use this for initialization
    void Start () {
        MultiFaceRec.FaceRecognition faceRecognition = new MultiFaceRec.FaceRecognition();
        faceRecognition.FindFaces(imageToByteArray(ImageToSearch));
        pictureRender = PictureCube.GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private byte[] imageToByteArray(Bitmap imageIn)
    {
        MemoryStream ms = new MemoryStream();
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
        return ms.ToArray();
    }
}
