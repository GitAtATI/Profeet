﻿//----------------------------------------------------------------------------
//  Copyright (C) 2004-2016 by EMGU Corporation. All rights reserved.       
//----------------------------------------------------------------------------

﻿using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Emgu.CV.XPhoto
{
   public static partial class XPhotoInvoke
   {
      static XPhotoInvoke()
      {
         CvInvoke.CheckLibraryLoaded();
      }

      /// <summary>
      /// The function implements different algorithm of automatic white balance, i.e. it tries to map image’s white color to perceptual white (this can be violated due to specific illumination or camera settings).
      /// </summary>
      /// <param name="src">The source.</param>
      /// <param name="dst">The DST.</param>
      /// <param name="algorithmType">Type of the algorithm to use. Use SIMPLE to perform smart histogram adjustments (ignoring 4% pixels with minimal and maximal values) for each channel.</param>
      /// <param name="inputMin">Minimum value in the input image</param>
      /// <param name="inputMax">Maximum value in the input image</param>
      /// <param name="outputMin">Minimum value in the output image</param>
      /// <param name="outputMax">Maximum value in the output image</param>
      public static void BalanceWhite(Mat src, Mat dst, CvEnum.WhiteBalanceMethod algorithmType, float inputMin = 0f, float inputMax = 255f, float outputMin = 0f, float outputMax = 255f)
      {
         cveBalanceWhite(src, dst, algorithmType, inputMin, inputMax, outputMin, outputMax);  
      }

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      private static extern void cveBalanceWhite(IntPtr src, IntPtr dst, CvEnum.WhiteBalanceMethod algorithmType, float inputMin, float inputMax, float outputMin, float outputMax);


      public static void AutowbGrayworld(IInputArray src, IOutputArray dst, float thresh = 0.5f)
      {
         using (InputArray iaSrc = src.GetInputArray())
         using (OutputArray oaDst = dst.GetOutputArray())
            cveAutowbGrayworld(iaSrc, oaDst, thresh);
      }

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      private static extern void cveAutowbGrayworld(IntPtr src, IntPtr dst, float thresh);

      /// <summary>
      /// The function implements simple dct-based denoising, link: http://www.ipol.im/pub/art/2011/ys-dct/.
      /// </summary>
      /// <param name="src">Source image</param>
      /// <param name="dst">Destination image</param>
      /// <param name="sigma">Expected noise standard deviation</param>
      /// <param name="psize">Size of block side where dct is computed</param>
      public static void DctDenoising(Mat src, Mat dst, double sigma, int psize = 16)
      {
         cveDctDenoising(src, dst, sigma, psize);
      }

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      private static extern void cveDctDenoising(IntPtr src, IntPtr dst, double sigma, int psize);

      public enum InpaintType
      {
         Shiftmap = 0
      }

      public static void Inpaint(Mat src, Mat mask, Mat dst, InpaintType algorithmType)
      {
         cveXInpaint(src, mask, dst, algorithmType);
      }

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      private static extern void cveXInpaint(IntPtr src, IntPtr mask, IntPtr dst, InpaintType algorithmType);
   }
}
