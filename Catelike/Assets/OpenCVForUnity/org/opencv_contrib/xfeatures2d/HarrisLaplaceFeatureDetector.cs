
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class HarrisLaplaceFeatureDetector
    /// <summary>
    ///  Class implementing the Harris-Laplace feature detector as described in @cite Mikolajczyk2004.
    /// </summary>
    public class HarrisLaplaceFeatureDetector : Feature2D
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
                        xfeatures2d_HarrisLaplaceFeatureDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal HarrisLaplaceFeatureDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new HarrisLaplaceFeatureDetector __fromPtr__(IntPtr addr) { return new HarrisLaplaceFeatureDetector(addr); }

        //
        // C++: static Ptr_HarrisLaplaceFeatureDetector cv::xfeatures2d::HarrisLaplaceFeatureDetector::create(int numOctaves = 6, float corn_thresh = 0.01f, float DOG_thresh = 0.01f, int maxCorners = 5000, int num_layers = 4)
        //

        /// <summary>
        ///  Creates a new implementation instance.
        /// </summary>
        /// <param name="numOctaves">
        /// the number of octaves in the scale-space pyramid
        /// </param>
        /// <param name="corn_thresh">
        /// the threshold for the Harris cornerness measure
        /// </param>
        /// <param name="DOG_thresh">
        /// the threshold for the Difference-of-Gaussians scale selection
        /// </param>
        /// <param name="maxCorners">
        /// the maximum number of corners to consider
        /// </param>
        /// <param name="num_layers">
        /// the number of intermediate scales per octave
        /// </param>
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners, int num_layers)
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_10(numOctaves, corn_thresh, DOG_thresh, maxCorners, num_layers)));


        }

        /// <summary>
        ///  Creates a new implementation instance.
        /// </summary>
        /// <param name="numOctaves">
        /// the number of octaves in the scale-space pyramid
        /// </param>
        /// <param name="corn_thresh">
        /// the threshold for the Harris cornerness measure
        /// </param>
        /// <param name="DOG_thresh">
        /// the threshold for the Difference-of-Gaussians scale selection
        /// </param>
        /// <param name="maxCorners">
        /// the maximum number of corners to consider
        /// </param>
        /// <param name="num_layers">
        /// the number of intermediate scales per octave
        /// </param>
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners)
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_11(numOctaves, corn_thresh, DOG_thresh, maxCorners)));


        }

        /// <summary>
        ///  Creates a new implementation instance.
        /// </summary>
        /// <param name="numOctaves">
        /// the number of octaves in the scale-space pyramid
        /// </param>
        /// <param name="corn_thresh">
        /// the threshold for the Harris cornerness measure
        /// </param>
        /// <param name="DOG_thresh">
        /// the threshold for the Difference-of-Gaussians scale selection
        /// </param>
        /// <param name="maxCorners">
        /// the maximum number of corners to consider
        /// </param>
        /// <param name="num_layers">
        /// the number of intermediate scales per octave
        /// </param>
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh, float DOG_thresh)
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_12(numOctaves, corn_thresh, DOG_thresh)));


        }

        /// <summary>
        ///  Creates a new implementation instance.
        /// </summary>
        /// <param name="numOctaves">
        /// the number of octaves in the scale-space pyramid
        /// </param>
        /// <param name="corn_thresh">
        /// the threshold for the Harris cornerness measure
        /// </param>
        /// <param name="DOG_thresh">
        /// the threshold for the Difference-of-Gaussians scale selection
        /// </param>
        /// <param name="maxCorners">
        /// the maximum number of corners to consider
        /// </param>
        /// <param name="num_layers">
        /// the number of intermediate scales per octave
        /// </param>
        public static HarrisLaplaceFeatureDetector create(int numOctaves, float corn_thresh)
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_13(numOctaves, corn_thresh)));


        }

        /// <summary>
        ///  Creates a new implementation instance.
        /// </summary>
        /// <param name="numOctaves">
        /// the number of octaves in the scale-space pyramid
        /// </param>
        /// <param name="corn_thresh">
        /// the threshold for the Harris cornerness measure
        /// </param>
        /// <param name="DOG_thresh">
        /// the threshold for the Difference-of-Gaussians scale selection
        /// </param>
        /// <param name="maxCorners">
        /// the maximum number of corners to consider
        /// </param>
        /// <param name="num_layers">
        /// the number of intermediate scales per octave
        /// </param>
        public static HarrisLaplaceFeatureDetector create(int numOctaves)
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_14(numOctaves)));


        }

        /// <summary>
        ///  Creates a new implementation instance.
        /// </summary>
        /// <param name="numOctaves">
        /// the number of octaves in the scale-space pyramid
        /// </param>
        /// <param name="corn_thresh">
        /// the threshold for the Harris cornerness measure
        /// </param>
        /// <param name="DOG_thresh">
        /// the threshold for the Difference-of-Gaussians scale selection
        /// </param>
        /// <param name="maxCorners">
        /// the maximum number of corners to consider
        /// </param>
        /// <param name="num_layers">
        /// the number of intermediate scales per octave
        /// </param>
        public static HarrisLaplaceFeatureDetector create()
        {


            return HarrisLaplaceFeatureDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_create_15()));


        }


        //
        // C++:  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setNumOctaves(int numOctaves_)
        //

        public void setNumOctaves(int numOctaves_)
        {
            ThrowIfDisposed();

            xfeatures2d_HarrisLaplaceFeatureDetector_setNumOctaves_10(nativeObj, numOctaves_);


        }


        //
        // C++:  int cv::xfeatures2d::HarrisLaplaceFeatureDetector::getNumOctaves()
        //

        public int getNumOctaves()
        {
            ThrowIfDisposed();

            return xfeatures2d_HarrisLaplaceFeatureDetector_getNumOctaves_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setCornThresh(float corn_thresh_)
        //

        public void setCornThresh(float corn_thresh_)
        {
            ThrowIfDisposed();

            xfeatures2d_HarrisLaplaceFeatureDetector_setCornThresh_10(nativeObj, corn_thresh_);


        }


        //
        // C++:  float cv::xfeatures2d::HarrisLaplaceFeatureDetector::getCornThresh()
        //

        public float getCornThresh()
        {
            ThrowIfDisposed();

            return xfeatures2d_HarrisLaplaceFeatureDetector_getCornThresh_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setDOGThresh(float DOG_thresh_)
        //

        public void setDOGThresh(float DOG_thresh_)
        {
            ThrowIfDisposed();

            xfeatures2d_HarrisLaplaceFeatureDetector_setDOGThresh_10(nativeObj, DOG_thresh_);


        }


        //
        // C++:  float cv::xfeatures2d::HarrisLaplaceFeatureDetector::getDOGThresh()
        //

        public float getDOGThresh()
        {
            ThrowIfDisposed();

            return xfeatures2d_HarrisLaplaceFeatureDetector_getDOGThresh_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setMaxCorners(int maxCorners_)
        //

        public void setMaxCorners(int maxCorners_)
        {
            ThrowIfDisposed();

            xfeatures2d_HarrisLaplaceFeatureDetector_setMaxCorners_10(nativeObj, maxCorners_);


        }


        //
        // C++:  int cv::xfeatures2d::HarrisLaplaceFeatureDetector::getMaxCorners()
        //

        public int getMaxCorners()
        {
            ThrowIfDisposed();

            return xfeatures2d_HarrisLaplaceFeatureDetector_getMaxCorners_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setNumLayers(int num_layers_)
        //

        public void setNumLayers(int num_layers_)
        {
            ThrowIfDisposed();

            xfeatures2d_HarrisLaplaceFeatureDetector_setNumLayers_10(nativeObj, num_layers_);


        }


        //
        // C++:  int cv::xfeatures2d::HarrisLaplaceFeatureDetector::getNumLayers()
        //

        public int getNumLayers()
        {
            ThrowIfDisposed();

            return xfeatures2d_HarrisLaplaceFeatureDetector_getNumLayers_10(nativeObj);


        }


        //
        // C++:  String cv::xfeatures2d::HarrisLaplaceFeatureDetector::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_HarrisLaplaceFeatureDetector_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_HarrisLaplaceFeatureDetector cv::xfeatures2d::HarrisLaplaceFeatureDetector::create(int numOctaves = 6, float corn_thresh = 0.01f, float DOG_thresh = 0.01f, int maxCorners = 5000, int num_layers = 4)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_10(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners, int num_layers);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_11(int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_12(int numOctaves, float corn_thresh, float DOG_thresh);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_13(int numOctaves, float corn_thresh);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_14(int numOctaves);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_15();

        // C++:  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setNumOctaves(int numOctaves_)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_HarrisLaplaceFeatureDetector_setNumOctaves_10(IntPtr nativeObj, int numOctaves_);

        // C++:  int cv::xfeatures2d::HarrisLaplaceFeatureDetector::getNumOctaves()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_HarrisLaplaceFeatureDetector_getNumOctaves_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setCornThresh(float corn_thresh_)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_HarrisLaplaceFeatureDetector_setCornThresh_10(IntPtr nativeObj, float corn_thresh_);

        // C++:  float cv::xfeatures2d::HarrisLaplaceFeatureDetector::getCornThresh()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_HarrisLaplaceFeatureDetector_getCornThresh_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setDOGThresh(float DOG_thresh_)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_HarrisLaplaceFeatureDetector_setDOGThresh_10(IntPtr nativeObj, float DOG_thresh_);

        // C++:  float cv::xfeatures2d::HarrisLaplaceFeatureDetector::getDOGThresh()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_HarrisLaplaceFeatureDetector_getDOGThresh_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setMaxCorners(int maxCorners_)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_HarrisLaplaceFeatureDetector_setMaxCorners_10(IntPtr nativeObj, int maxCorners_);

        // C++:  int cv::xfeatures2d::HarrisLaplaceFeatureDetector::getMaxCorners()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_HarrisLaplaceFeatureDetector_getMaxCorners_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setNumLayers(int num_layers_)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_HarrisLaplaceFeatureDetector_setNumLayers_10(IntPtr nativeObj, int num_layers_);

        // C++:  int cv::xfeatures2d::HarrisLaplaceFeatureDetector::getNumLayers()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_HarrisLaplaceFeatureDetector_getNumLayers_10(IntPtr nativeObj);

        // C++:  String cv::xfeatures2d::HarrisLaplaceFeatureDetector::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_HarrisLaplaceFeatureDetector_delete(IntPtr nativeObj);

    }
}
