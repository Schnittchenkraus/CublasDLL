// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.DataType
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

namespace ManagedCuda.CudaBlas
{
  /// <summary>
  /// The cublasDataType_t type is an enumerant to specify the data precision. It is used
  /// when the data reference does not carry the type itself (e.g void *).
  /// To mimic the typedef in cublas_api.h, we redefine the enum identically to cudaDataType
  /// </summary>
  public enum DataType
  {
    /// <summary>32 bit real</summary>
    CUDA_R_32F,
    /// <summary>64 bit real</summary>
    CUDA_R_64F,
    /// <summary>16 bit real</summary>
    CUDA_R_16F,
    /// <summary>8 bit real as a signed integer</summary>
    CUDA_R_8I,
    /// <summary>32 bit complex</summary>
    CUDA_C_32F,
    /// <summary>64 bit complex</summary>
    CUDA_C_64F,
    /// <summary>16 bit complex</summary>
    CUDA_C_16F,
    /// <summary>8 bit complex as a pair of signed integers</summary>
    CUDA_C_8I,
    /// <summary>8 bit real as a signed integer</summary>
    CUDA_R_8U,
    /// <summary>8 bit complex as a pair of signed integers</summary>
    CUDA_C_8U,
  }
}
