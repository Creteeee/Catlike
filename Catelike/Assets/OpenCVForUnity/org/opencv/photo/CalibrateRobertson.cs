
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class CalibrateRobertson
    /// <summary>
    ///  Inverse camera response function is extracted for each brightness value by minimizing an objective
    ///  function as linear system. This algorithm uses all image pixels.
    /// </summary>
    /// <remarks>
    ///  For more information see @cite RB99 .
    /// </remarks>
    public class CalibrateRobertson : CalibrateCRF
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
                        photo_CalibrateRobertson_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CalibrateRobertson(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new CalibrateRobertson __fromPtr__(IntPtr addr) { return new CalibrateRobertson(addr); }

        //
        // C++:  int cv::CalibrateRobertson::getMaxIter()
        //

        public int getMaxIter()
        {
            ThrowIfDisposed();

            return photo_CalibrateRobertson_getMaxIter_10(nativeObj);


        }


        //
        // C++:  void cv::CalibrateRobertson::setMaxIter(int max_iter)
        //

        public void setMaxIter(int max_iter)
        {
            ThrowIfDisposed();

            photo_CalibrateRobertson_setMaxIter_10(nativeObj, max_iter);


        }


        //
        // C++:  float cv::CalibrateRobertson::getThreshold()
        //

        public float getThreshold()
        {
            ThrowIfDisposed();

            return photo_CalibrateRobertson_getThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::CalibrateRobertson::setThreshold(float threshold)
        //

        public void setThreshold(float threshold)
        {
            ThrowIfDisposed();

            photo_CalibrateRobertson_setThreshold_10(nativeObj, threshold);


        }


        //
        // C++:  Mat cv::CalibrateRobertson::getRadiance()
        //

        public Mat getRadiance()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(photo_CalibrateRobertson_getRadiance_10(nativeObj)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::CalibrateRobertson::getMaxIter()
        [DllImport(LIBNAME)]
        private static extern int photo_CalibrateRobertson_getMaxIter_10(IntPtr nativeObj);

        // C++:  void cv::CalibrateRobertson::setMaxIter(int max_iter)
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateRobertson_setMaxIter_10(IntPtr nativeObj, int max_iter);

        // C++:  float cv::CalibrateRobertson::getThreshold()
        [DllImport(LIBNAME)]
        private static extern float photo_CalibrateRobertson_getThreshold_10(IntPtr nativeObj);

        // C++:  void cv::CalibrateRobertson::setThreshold(float threshold)
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateRobertson_setThreshold_10(IntPtr nativeObj, float threshold);

        // C++:  Mat cv::CalibrateRobertson::getRadiance()
        [DllImport(LIBNAME)]
        private static extern IntPtr photo_CalibrateRobertson_getRadiance_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateRobertson_delete(IntPtr nativeObj);

    }
}
