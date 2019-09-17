// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.CublasStatus
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

namespace ManagedCuda.CudaBlas
{
  /// <summary>CUBLAS status type returns</summary>
  public enum CublasStatus
  {
    /// <summary>
    /// 
    /// </summary>
    Success = 0,
    /// <summary>
    /// 
    /// </summary>
    NotInitialized = 1,
    /// <summary>
    /// 
    /// </summary>
    AllocFailed = 3,
    /// <summary>
    /// 
    /// </summary>
    InvalidValue = 7,
    /// <summary>
    /// 
    /// </summary>
    ArchMismatch = 8,
    /// <summary>
    /// 
    /// </summary>
    MappingError = 11, // 0x0000000B
    /// <summary>
    /// 
    /// </summary>
    ExecutionFailed = 13, // 0x0000000D
    /// <summary>
    /// 
    /// </summary>
    InternalError = 14, // 0x0000000E
    /// <summary>
    /// 
    /// </summary>
    NotSupported = 15, // 0x0000000F
    /// <summary>
    /// 
    /// </summary>
    LicenseError = 16, // 0x00000010
  }
}
