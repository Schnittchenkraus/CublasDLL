// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.PointerMode
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

namespace ManagedCuda.CudaBlas
{
  /// <summary>
  /// The PointerMode type indicates whether the scalar values are passed by
  /// reference on the host or device. It is important to point out that if several scalar values are
  /// present in the function call, all of them must conform to the same single pointer mode.
  /// The pointer mode can be set and retrieved using cublasSetPointerMode() and
  /// cublasGetPointerMode() routines, respectively.
  /// </summary>
  public enum PointerMode
  {
    /// <summary>the scalars are passed by reference on the host</summary>
    Host,
    /// <summary>the scalars are passed by reference on the device</summary>
    Device,
  }
}
