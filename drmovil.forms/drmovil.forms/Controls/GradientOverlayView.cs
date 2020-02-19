using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using Xamarin.Forms;
using Color = Xamarin.Forms.Color;

namespace drmovil.forms.Controls
{
    public class GradientOverlayView : ContentView
    {

        /// <summary>
        /// If true, the first part of the gradient percentage specified in GradientStartHeavyPercent will be constant instead of gradient using the StartColor property.
        /// This is useful when text or other things overlayed at the top need to be displayed more clearly.
        /// </summary>
        public static readonly BindableProperty HasGradientStartInsetProperty = BindableProperty.Create(nameof(HasGradientStartInset), typeof(bool), typeof(GradientOverlayView), false, Xamarin.Forms.BindingMode.OneWay);
        public bool HasGradientStartInset
        {
            get { return (bool)GetValue(HasGradientStartInsetProperty); }
            set { SetValue(HasGradientStartInsetProperty, value); OnPropertyChanged(nameof(HasGradientStartInset)); }
        }

        /// <summary>
        /// Specifies the heavy gradient percentage deom 0.0 - 1.0, essentially at what point in the diagonal line of the gradient that the start color stops being constant and turns to the gradient. Default is 0.2f (20%).
        /// </summary>
        public static readonly BindableProperty GradientStartInsetPercentProperty = BindableProperty.Create(nameof(GradientStartInsetPercent), typeof(float), typeof(GradientOverlayView), 0.20f, Xamarin.Forms.BindingMode.OneWay);
        public float GradientStartInsetPercent
        {
            get { return (float)GetValue(GradientStartInsetPercentProperty); }
            set { SetValue(GradientStartInsetPercentProperty, value); OnPropertyChanged(nameof(GradientStartInsetPercent)); }
        }

        public GradientOverlayView()
        {
            try
            {
                var canvasView = new SKCanvasView();
                canvasView.PaintSurface += OnCanvasViewPaintSurface;
                canvasView.BackgroundColor = Color.Transparent;
                Content = canvasView;
            }
            catch (Exception ex)
            {
                // Don't crash for a pretty effect
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            try
            {
                SKImageInfo info = args.Info;
                SKSurface surface = args.Surface;
                SKCanvas canvas = surface.Canvas;

                canvas.Clear();

                var startPoint = new SKPoint(0, 0);
                var endPoint = new SKPoint(info.Width, info.Height);

                var startPoint2 = new SKPoint(info.Width / 2, info.Height);
                var endPoint2 = new SKPoint(info.Width / 2, 0);



                SKColor[] colors;
                SKShader shader;

                if (HasGradientStartInset)
                {
                    colors = new SKColor[] { Color.White.MultiplyAlpha(1).ToSKColor(), 
                                             Color.White.MultiplyAlpha(1).ToSKColor(), 
                                             Color.White.MultiplyAlpha(0.98).ToSKColor(), 
                                             Color.White.MultiplyAlpha(0.94).ToSKColor(), 
                                             Color.White.MultiplyAlpha(0.80).ToSKColor(),
                                             Color.White.MultiplyAlpha(0.65).ToSKColor()
                    };
                    shader = SKShader.CreateLinearGradient(startPoint2, endPoint2, colors, new float[] { 0, 0.45F, 0.55F, 0.85F , 0.95F, 1 }, SKShaderTileMode.Clamp);
                }
                else
                {
                    colors = new SKColor[] { Color.White.MultiplyAlpha(0.95).ToSKColor(), Color.White.MultiplyAlpha(0).ToSKColor() };
                    shader = SKShader.CreateLinearGradient(startPoint2, endPoint2, colors, null, SKShaderTileMode.Clamp);
                }

                var mainPaint = new SKPaint
                {
                    Style = SKPaintStyle.Fill,
                    Shader = shader
                };

                canvas.DrawRect(new SKRect(startPoint.X, startPoint.Y, endPoint.X, endPoint.Y), mainPaint);

            }
            catch (Exception ex)
            {
                // Don't crash for a pretty effect
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}
