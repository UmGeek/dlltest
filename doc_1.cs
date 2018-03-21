/* Created by SharpDevelop. */

using System;
using RGiesecke.DllExport;
using System.Runtime.InteropServices;

namespace MeuTeste
{
   internal static class dllExportTest
   {
     [DllExport("fteste", CallingConvention = CallingConvention.StdCall)]
     static bool fteste()
     {
         return true;
     }
   }   
}

