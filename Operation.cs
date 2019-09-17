// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.Operation
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

namespace ManagedCuda.CudaBlas
{
  /// <summary>
  /// The Operation type indicates which operation needs to be performed with the
  /// dense matrix. Its values correspond to Fortran characters ‘N’ or ‘n’ (non-transpose), ‘T’
  /// or ‘t’ (transpose) and ‘C’ or ‘c’ (conjugate transpose) that are often used as parameters
  /// to legacy BLAS implementations
  /// </summary>
  public enum Operation
  {
    /// <summary>the non-transpose operation is selected</summary>
    NonTranspose,
    /// <summary>the transpose operation is selected</summary>
    Transpose,
    /// <summary>the conjugate transpose operation is selected</summary>
    ConjugateTranspose,
  }
}
