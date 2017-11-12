using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Climb_Vision;
using Xamarin.Forms.Platform.Android;
using Climb_Vision.Views;
using Xamarin.Forms;
using Android.Graphics;
using System.ComponentModel;

[assembly:ExportRenderer(typeof(CameraPage), typeof(Climb_Vision.Droid.Renderers.CameraCustomRenderer))]

namespace Climb_Vision.Droid.Renderers
{
    public class CameraCustomRenderer : PageRenderer, TextureView.ISurfaceTextureListener
    {
        public CameraCustomRenderer() { }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
        }

        public void OnSurfaceTextureAvailable(SurfaceTexture surface, int width, int height)
        {
            throw new NotImplementedException();
        }

        public bool OnSurfaceTextureDestroyed(SurfaceTexture surface)
        {
            throw new NotImplementedException();
        }

        public void OnSurfaceTextureSizeChanged(SurfaceTexture surface, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void OnSurfaceTextureUpdated(SurfaceTexture surface)
        {
            throw new NotImplementedException();
        }
    }
}