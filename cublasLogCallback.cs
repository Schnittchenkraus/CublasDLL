// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.cublasLogCallback
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

using System.Runtime.InteropServices;

namespace ManagedCuda.CudaBlas
{
  /// <summary>Cublas logging</summary>
  public delegate void cublasLogCallback([MarshalAs(UnmanagedType.LPStr)] string msg);
}
