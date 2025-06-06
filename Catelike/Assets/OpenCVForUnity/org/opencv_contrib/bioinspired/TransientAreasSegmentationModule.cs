
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.BioinspiredModule
{

    // C++: class TransientAreasSegmentationModule
    /// <summary>
    ///  class which provides a transient/moving areas segmentation module
    /// </summary>
    /// <remarks>
    ///  perform a locally adapted segmentation by using the retina magno input data Based on Alexandre
    ///  BENOIT thesis: "Le système visuel humain au secours de la vision par ordinateur"
    ///  
    ///  3 spatio temporal filters are used:
    ///  - a first one which filters the noise and local variations of the input motion energy
    ///  - a second (more powerfull low pass spatial filter) which gives the neighborhood motion energy the
    ///  segmentation consists in the comparison of these both outputs, if the local motion energy is higher
    ///  to the neighborhood otion energy, then the area is considered as moving and is segmented
    ///  - a stronger third low pass filter helps decision by providing a smooth information about the
    ///  "motion context" in a wider area
    /// </remarks>
    public partial class TransientAreasSegmentationModule : Algorithm
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
                        bioinspired_TransientAreasSegmentationModule_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TransientAreasSegmentationModule(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TransientAreasSegmentationModule __fromPtr__(IntPtr addr) { return new TransientAreasSegmentationModule(addr); }

        //
        // C++:  Size cv::bioinspired::TransientAreasSegmentationModule::getSize()
        //

        /// <summary>
        ///  return the sze of the manage input and output images
        /// </summary>
        public Size getSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            bioinspired_TransientAreasSegmentationModule_getSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::setup(String segmentationParameterFile = "", bool applyDefaultSetupOnFailure = true)
        //

        /// <summary>
        ///  try to open an XML segmentation parameters file to adjust current segmentation instance setup
        /// </summary>
        /// <remarks>
        ///      - if the xml file does not exist, then default setup is applied
        ///      - warning, Exceptions are thrown if read XML file is not valid
        /// </remarks>
        /// <param name="segmentationParameterFile">
        /// : the parameters filename
        /// </param>
        /// <param name="applyDefaultSetupOnFailure">
        /// : set to true if an error must be thrown on error
        /// </param>
        public void setup(string segmentationParameterFile, bool applyDefaultSetupOnFailure)
        {
            ThrowIfDisposed();

            bioinspired_TransientAreasSegmentationModule_setup_10(nativeObj, segmentationParameterFile, applyDefaultSetupOnFailure);


        }

        /// <summary>
        ///  try to open an XML segmentation parameters file to adjust current segmentation instance setup
        /// </summary>
        /// <remarks>
        ///      - if the xml file does not exist, then default setup is applied
        ///      - warning, Exceptions are thrown if read XML file is not valid
        /// </remarks>
        /// <param name="segmentationParameterFile">
        /// : the parameters filename
        /// </param>
        /// <param name="applyDefaultSetupOnFailure">
        /// : set to true if an error must be thrown on error
        /// </param>
        public void setup(string segmentationParameterFile)
        {
            ThrowIfDisposed();

            bioinspired_TransientAreasSegmentationModule_setup_11(nativeObj, segmentationParameterFile);


        }

        /// <summary>
        ///  try to open an XML segmentation parameters file to adjust current segmentation instance setup
        /// </summary>
        /// <remarks>
        ///      - if the xml file does not exist, then default setup is applied
        ///      - warning, Exceptions are thrown if read XML file is not valid
        /// </remarks>
        /// <param name="segmentationParameterFile">
        /// : the parameters filename
        /// </param>
        /// <param name="applyDefaultSetupOnFailure">
        /// : set to true if an error must be thrown on error
        /// </param>
        public void setup()
        {
            ThrowIfDisposed();

            bioinspired_TransientAreasSegmentationModule_setup_12(nativeObj);


        }


        //
        // C++:  String cv::bioinspired::TransientAreasSegmentationModule::printSetup()
        //

        /// <summary>
        ///  parameters setup display method
        /// </summary>
        /// <returns>
        ///  a string which contains formatted parameters information
        /// </returns>
        public string printSetup()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(bioinspired_TransientAreasSegmentationModule_printSetup_10(nativeObj)));

            return retVal;
        }


        //
        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::write(String fs)
        //

        /// <summary>
        ///  write xml/yml formated parameters information
        /// </summary>
        /// <param name="fs">
        /// : the filename of the xml file that will be open and writen with formatted parameters information
        /// </param>
        public void write(string fs)
        {
            ThrowIfDisposed();

            bioinspired_TransientAreasSegmentationModule_write_10(nativeObj, fs);


        }


        //
        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::run(Mat inputToSegment, int channelIndex = 0)
        //

        /// <summary>
        ///  main processing method, get result using methods getSegmentationPicture()
        /// </summary>
        /// <param name="inputToSegment">
        /// : the image to process, it must match the instance buffer size !
        /// </param>
        /// <param name="channelIndex">
        /// : the channel to process in case of multichannel images
        /// </param>
        public void run(Mat inputToSegment, int channelIndex)
        {
            ThrowIfDisposed();
            if (inputToSegment != null) inputToSegment.ThrowIfDisposed();

            bioinspired_TransientAreasSegmentationModule_run_10(nativeObj, inputToSegment.nativeObj, channelIndex);


        }

        /// <summary>
        ///  main processing method, get result using methods getSegmentationPicture()
        /// </summary>
        /// <param name="inputToSegment">
        /// : the image to process, it must match the instance buffer size !
        /// </param>
        /// <param name="channelIndex">
        /// : the channel to process in case of multichannel images
        /// </param>
        public void run(Mat inputToSegment)
        {
            ThrowIfDisposed();
            if (inputToSegment != null) inputToSegment.ThrowIfDisposed();

            bioinspired_TransientAreasSegmentationModule_run_11(nativeObj, inputToSegment.nativeObj);


        }


        //
        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::getSegmentationPicture(Mat& transientAreas)
        //

        /// <summary>
        ///  access function
        ///      return the last segmentation result: a boolean picture which is resampled between 0 and 255 for a display purpose
        /// </summary>
        public void getSegmentationPicture(Mat transientAreas)
        {
            ThrowIfDisposed();
            if (transientAreas != null) transientAreas.ThrowIfDisposed();

            bioinspired_TransientAreasSegmentationModule_getSegmentationPicture_10(nativeObj, transientAreas.nativeObj);


        }


        //
        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::clearAllBuffers()
        //

        /// <summary>
        ///  cleans all the buffers of the instance
        /// </summary>
        public void clearAllBuffers()
        {
            ThrowIfDisposed();

            bioinspired_TransientAreasSegmentationModule_clearAllBuffers_10(nativeObj);


        }


        //
        // C++: static Ptr_TransientAreasSegmentationModule cv::bioinspired::TransientAreasSegmentationModule::create(Size inputSize)
        //

        /// <summary>
        ///  allocator
        /// </summary>
        /// <param name="inputSize">
        /// : size of the images input to segment (output will be the same size)
        /// </param>
        public static TransientAreasSegmentationModule create(Size inputSize)
        {


            return TransientAreasSegmentationModule.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(bioinspired_TransientAreasSegmentationModule_create_10(inputSize.width, inputSize.height)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Size cv::bioinspired::TransientAreasSegmentationModule::getSize()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_getSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::setup(String segmentationParameterFile = "", bool applyDefaultSetupOnFailure = true)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_setup_10(IntPtr nativeObj, string segmentationParameterFile, [MarshalAs(UnmanagedType.U1)] bool applyDefaultSetupOnFailure);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_setup_11(IntPtr nativeObj, string segmentationParameterFile);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_setup_12(IntPtr nativeObj);

        // C++:  String cv::bioinspired::TransientAreasSegmentationModule::printSetup()
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_TransientAreasSegmentationModule_printSetup_10(IntPtr nativeObj);

        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::write(String fs)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_write_10(IntPtr nativeObj, string fs);

        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::run(Mat inputToSegment, int channelIndex = 0)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_run_10(IntPtr nativeObj, IntPtr inputToSegment_nativeObj, int channelIndex);
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_run_11(IntPtr nativeObj, IntPtr inputToSegment_nativeObj);

        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::getSegmentationPicture(Mat& transientAreas)
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_getSegmentationPicture_10(IntPtr nativeObj, IntPtr transientAreas_nativeObj);

        // C++:  void cv::bioinspired::TransientAreasSegmentationModule::clearAllBuffers()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_clearAllBuffers_10(IntPtr nativeObj);

        // C++: static Ptr_TransientAreasSegmentationModule cv::bioinspired::TransientAreasSegmentationModule::create(Size inputSize)
        [DllImport(LIBNAME)]
        private static extern IntPtr bioinspired_TransientAreasSegmentationModule_create_10(double inputSize_width, double inputSize_height);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bioinspired_TransientAreasSegmentationModule_delete(IntPtr nativeObj);

    }
}
