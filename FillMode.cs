// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.FillMode
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

namespace ManagedCuda.CudaBlas
{
  /// <summary>
  /// The FillMode type indicates which part (lower or upper) of the dense matrix was
  /// filled and consequently should be used by the function. Its values correspond to Fortran
  /// characters ‘L’ or ‘l’ (lower) and ‘U’ or ‘u’ (upper) that are often used as parameters to
  /// legacy BLAS implementations.
  /// </summary>
  public enum FillMode
  {
    /// <summary>the lower part of the matrix is filled</summary>
    Lower,
    /// <summary>the upper part of the matrix is filled</summary>
    Upper,
  }
}
