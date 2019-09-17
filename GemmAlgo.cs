// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.GemmAlgo
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

namespace ManagedCuda.CudaBlas
{
  /// <summary>For different GEMM algorithm</summary>
  public enum GemmAlgo
  {
    /// <summary>
    /// </summary>
    Default = -1, // 0xFFFFFFFF
    /// <summary>
    /// </summary>
    Algo0 = 0,
    /// <summary>
    /// </summary>
    Algo1 = 1,
    /// <summary>
    /// </summary>
    Algo2 = 2,
    /// <summary>
    /// </summary>
    Algo3 = 3,
    /// <summary>
    /// </summary>
    Algo4 = 4,
    /// <summary>
    /// </summary>
    Algo5 = 5,
    /// <summary>
    /// </summary>
    Algo6 = 6,
    /// <summary>
    /// </summary>
    Algo7 = 7,
    /// <summary>
    /// </summary>
    Algo8 = 8,
    /// <summary>
    /// </summary>
    Algo9 = 9,
    /// <summary>
    /// </summary>
    Algo10 = 10, // 0x0000000A
    /// <summary>
    /// </summary>
    Algo11 = 11, // 0x0000000B
    /// <summary>
    /// </summary>
    Algo12 = 12, // 0x0000000C
    /// <summary>
    /// </summary>
    Algo13 = 13, // 0x0000000D
    /// <summary>
    /// </summary>
    Algo14 = 14, // 0x0000000E
    /// <summary>
    /// </summary>
    Algo15 = 15, // 0x0000000F
    /// <summary>
    /// </summary>
    Algo16 = 16, // 0x00000010
    /// <summary>
    /// </summary>
    Algo17 = 17, // 0x00000011
    /// <summary>sliced 32x32</summary>
    Algo18 = 18, // 0x00000012
    /// <summary>sliced 64x32</summary>
    Algo19 = 19, // 0x00000013
    /// <summary>sliced 128x32</summary>
    Algo20 = 20, // 0x00000014
    /// <summary>sliced 32x32  -splitK</summary>
    Algo21 = 21, // 0x00000015
    /// <summary>sliced 64x32  -splitK</summary>
    Algo22 = 22, // 0x00000016
    /// <summary>sliced 128x32 -splitK</summary>
    Algo23 = 23, // 0x00000017
    /// <summary>
    /// </summary>
    DefaultTensorOp = 99, // 0x00000063
    /// <summary>
    /// </summary>
    Algo0TensorOp = 100, // 0x00000064
    /// <summary>
    /// </summary>
    Algo1TensorOp = 101, // 0x00000065
    /// <summary>
    /// </summary>
    Algo2TensorOp = 102, // 0x00000066
    /// <summary>
    /// </summary>
    Algo3TensorOp = 103, // 0x00000067
    /// <summary>
    /// </summary>
    Algo4TensorOp = 104, // 0x00000068
    /// <summary>
    /// </summary>
    Algo5TensorOp = 105, // 0x00000069
    /// <summary>
    /// </summary>
    Algo6TensorOp = 106, // 0x0000006A
    /// <summary>
    /// </summary>
    Algo7TensorOp = 107, // 0x0000006B
    /// <summary>
    /// </summary>
    Algo8TensorOp = 108, // 0x0000006C
    /// <summary>
    /// </summary>
    Algo9TensorOp = 109, // 0x0000006D
    /// <summary>
    /// </summary>
    Algo10TensorOp = 110, // 0x0000006E
    /// <summary>
    /// </summary>
    Algo11TensorOp = 111, // 0x0000006F
    /// <summary>
    /// </summary>
    Algo12TensorOp = 112, // 0x00000070
    /// <summary>
    /// </summary>
    Algo13TensorOp = 113, // 0x00000071
    /// <summary>
    /// </summary>
    Algo14TensorOp = 114, // 0x00000072
    /// <summary>
    /// </summary>
    Algo15TensorOp = 115, // 0x00000073
  }
}
