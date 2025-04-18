
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.BioinspiredModule
{

    // C++: class RetinaFastToneMapping
    /// <summary>
    ///   a wrapper class which allows the tone mapping algorithm of Meylan&amp;al(2007) to be used with OpenCV.
    /// </summary>
    /// <remarks>
    ///  This algorithm is already implemented in thre Retina class (retina::applyFastToneMapping) but used it does not require all the retina model to be allocated. This allows a light memory use for low memory devices (smartphones, etc.
    ///  As a summary, these are the model properties:
    ///  - 2 stages of local luminance adaptation with a different local neighborhood for each.
    ///  - first stage models the retina photorecetors local luminance adaptation
    ///  - second stage models th ganglion cells local information adaptation
    ///  - compared to the initial publication, this class uses spatio-temporal low pass filters instead of spatial only filters.
    ///    this can help noise robustness and temporal stability for video sequence use cases.
    ///  
    ///  for more information, read to the following papers :
    ///  Meylan L., Alleysson D., and Susstrunk S., A Model of Retinal Local Adaptation for the Tone Mapping of Color Filter Array Images, Journal of Optical Society of America, A, Vol. 24, N 9, September, 1st, 2007, pp. 2807-2816Benoit A., Caplier A., Durette B., Herault, J., "USING HUMAN VISUAL SYSTEM MODELING FOR BIO-INSPIRED LOW LEVEL IMAGE PROCESSING", Elsevier, Computer Vision and Image Understanding 114 (2010), pp. 758-773, DOI: http://dx.doi.org/10.1016/j.cviu.2010.01.011
    ///  regarding spatio-temporal filter and the bigger retina model :
    ///  Vision: Images, Signals and Neural Networks: Models of Neural Processing in Visual Perception (Progress in Neural Processing),By: Jeanny Herault, ISBN: 9814273686. WAPI (Tower ID): 113266891.
    /// </remarks>
    public partial class RetinaFastToneMapping : Algorithm
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        bioinspired_RetinaFastToneMapping_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal RetinaFastToneMapping(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new RetinaFastToneMapping __fromPtr__(IntPtr addr) { return new RetinaFastToneMapping(addr); }

        //
        // C++:  void cv::bioinspired::RetinaFastToneMapping::applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
        //

        /// <summary>
        ///  applies a luminance correction (initially High Dynamic Range (HDR) tone mapping)
        /// </summary>
        /// <remarks>
        ///      using only the 2 local adaptation stages of the retina parvocellular channel : photoreceptors
        ///      level and ganlion cells level. Spatio temporal filtering is applied but limited to temporal
        ///      smoothing and eventually high frequencies attenuation. This is a lighter method than the one
        ///      available using the regular retina::run method. It is then faster but it does not include
        ///      complete temporal filtering nor retina spectral whitening. Then, it can have a more limited
        ///      effect on images with a very high dynamic range. This is an adptation of the original still
        ///      image HDR tone mapping algorithm of David Alleyson, Sabine Susstruck and Laurence Meylan's
        ///      work, please cite: -&gt; Meylan L., Alleysson D., and Susstrunk S., A Model of Retinal Local
        ///      Adaptation for the Tone Mapping of Color Filter Array Images, Journal of Optical Society of
        ///      America, A, Vol. 24, N 9, September, 1st, 2007, pp. 2807-2816
        /// </remarks>
        /// <param name="inputImage">
        /// the input image to process RGB or gray levels
        /// </param>
        /// <param name="outputToneMappedImage">
        /// the output tone mapped image
        /// </param>
        public void applyFastToneMapping(Mat inputImage, Mat outputToneMappedImage)
        {
            ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (outputToneMappedImage != null) outputToneMappedImage.ThrowIfDisposed();

            bioinspired_RetinaFastToneMapping_applyFastToneMapping_10(nativeObj, inputImage.nativeObj, outputToneMappedImage.nativeObj);


        }


        //
        // C++:  void cv::bioinspired::RetinaFastToneMapping::setup(float photoreceptorsNeighborhoodRadius = 3.f, float ganglioncellsNeighborhoodRadius = 1.f, float meanLuminanceModulatorK = 1.f)
        //

        /// <summary>
        ///  updates tone mapping behaviors by adjusing the local luminance computation area
        /// </summary>
        /// <param name="photoreceptorsNeighborhoodRadius">
        /// the first stage local adaptation area
        /// </param>
        /// <param name="ganglioncellsNeighborhoodRadius">
        /// the second stage local adaptation area
        /// </param>
        /// <param name="meanLuminanceModulatorK">
        /// the factor applied to modulate the meanLuminance information
        ///      (default is 1, see reference paper)
        /// </param>
        public void setup(float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius, float meanLuminanceModulatorK)
        {
            ThrowIfDisposed();

            bioinspired_RetinaFastToneMapping_setup_10(nativeObj, photoreceptorsNeighborhoodRadius, ganglioncellsNeighborhoodRadius, meanLuminanceModulatorK);


        }

        /// <summary>
        ///  updates tone mapping behaviors by adjusing the local luminance computation area
        /// </summary>
        /// <param name="photoreceptorsNeighborhoodRadius">
        /// the first stage local adaptation area
        /// </param>
        /// <param name="ganglioncellsNeighborhoodRadius">
        /// the second stage local adaptation area
        /// </param>
        /// <param name="meanLuminanceModulatorK">
        /// the factor applied to modulate the meanLuminance information
        ///      (default is 1, see reference paper)
        /// </param>
        public void setup(float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius)
        {
            ThrowIfDisposed();

            bioinspired_RetinaFastToneMapping_setup_11(nativeObj, photoreceptorsNeighborhoodRadius, ganglioncellsNeighborhoodRadius);


        }

        /// <summary>
        ///  updates tone mapping behaviors by adjusing the local luminance computation area
        /// </summary>
        /// <param name="photoreceptorsNeighborhoodRadius">
        /// the first stage local adaptation area
        /// </param>
        /// <param name="ganglioncellsNeighborhoodRadius">
        /// the second stage local adaptation area
        /// </param>
        /// <param name="meanLuminanceModulatorK">
        /// the factor applied to modulate the meanLuminance information
        ///      (default is 1, see reference paper)
        /// </param>
        public void setup(float photoreceptorsNeighborhoodRadius)
        {
            ThrowIfDisposed();

            bioinspired_RetinaFastToneMapping_setup_12(nativeObj, photoreceptorsNeighborhoodRadius);


        }

        /// <summary>
        ///  updates tone mapping behaviors by adjusing the local luminance computation area
        /// </summary>
        /// <param name="photoreceptorsNeighborhoodRadius">
        /// the first stage local adaptation area
        /// </param>
        /// <param name="ganglioncellsNeighborhoodRadius">
        /// the second stage local adaptation area
        /// </param>
        /// <param name="meanLuminanceModulatorK">
        /// the factor applied to modulate the meanLuminance information
        ///      (default is 1, see reference paper)
        /// </param>
        public void setup()
        {
            ThrowIfDisposed();

            bioinspired_RetinaFastToneMapping_setup_13(nativeObj);


        }


        //
        // C++: static Ptr_RetinaFastToneMapping cv::bioinspired::RetinaFastToneMapping::create(Size inputSize)
        //

        public static RetinaFastToneMapping create(Size inputSize)
        {


            return RetinaFastToneMapping.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(bioinspired_RetinaFastToneMapping_create_10(inputSize.width, inputSize.height)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::bioinspired::RetinaFastToneMapping::applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_applyFastToneMapping_10(IntPtr nativeObj, IntPtr inputImage_nativeObj, IntPtr outputToneMappedImage_nativeObj);

        // C++:  void cv::bioinspired::RetinaFastToneMapping::setup(float photoreceptorsNeighborhoodRadius = 3.f, float ganglioncellsNeighborhoodRadius = 1.f, float meanLuminanceModulatorK = 1.f)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_setup_10(IntPtr nativeObj, float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius, float meanLuminanceModulatorK);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_setup_11(IntPtr nativeObj, float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_setup_12(IntPtr nativeObj, float photoreceptorsNeighborhoodRadius);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_setup_13(IntPtr nativeObj);

        // C++: static Ptr_RetinaFastToneMapping cv::bioinspired::RetinaFastToneMapping::create(Size inputSize)
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_RetinaFastToneMapping_create_10(double inputSize_width, double inputSize_height);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_delete(IntPtr nativeObj);

    }
}
