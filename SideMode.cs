// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.SideMode
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

namespace ManagedCuda.CudaBlas
{
  /// <summary>
  /// The SideMode type indicates whether the dense matrix is on the left or right side
  /// in the matrix equation solved by a particular function. Its values correspond to Fortran
  /// characters ‘L’ or ‘l’ (left) and ‘R’ or ‘r’ (right) that are often used as parameters to
  /// legacy BLAS implementations.
  /// </summary>
  public enum SideMode
  {
    /// <summary>the matrix is on the left side in the equation</summary>
    Left,
    /// <summary>the matrix is on the right side in the equation</summary>
    Right,
  }
}
