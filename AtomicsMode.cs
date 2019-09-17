// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.AtomicsMode
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

namespace ManagedCuda.CudaBlas
{
  /// <summary>
  /// The type indicates whether cuBLAS routines which has an alternate implementation
  /// using atomics can be used. The atomics mode can be set and queried using and routines,
  /// respectively.
  /// </summary>
  public enum AtomicsMode
  {
    /// <summary>the usage of atomics is not allowed</summary>
    NotAllowed,
    /// <summary>the usage of atomics is allowed</summary>
    Allowed,
  }
}
