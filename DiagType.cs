// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.DiagType
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

namespace ManagedCuda.CudaBlas
{
  /// <summary>
  /// The DiagType type indicates whether the main diagonal of the dense matrix is
  /// unity and consequently should not be touched or modified by the function. Its values
  /// correspond to Fortran characters ‘N’ or ‘n’ (non-unit) and ‘U’ or ‘u’ (unit) that are
  /// often used as parameters to legacy BLAS implementations.
  /// </summary>
  public enum DiagType
  {
    /// <summary>the matrix diagonal has non-unit elements</summary>
    NonUnit,
    /// <summary>the matrix diagonal has unit elements</summary>
    Unit,
  }
}
