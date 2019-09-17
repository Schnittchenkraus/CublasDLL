// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.CudaBlasNativeMethods
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

using ManagedCuda.BasicTypes;
using ManagedCuda.VectorTypes;
using System;
using System.Runtime.InteropServices;

namespace ManagedCuda.CudaBlas
{
  /// <summary>C# wrapper for cublas_v2.h and cublas_api.h</summary>
  public static class CudaBlasNativeMethods
  {
    internal const string CUBLAS_API_DLL_NAME = "cublas64_100";

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCreate_v2(ref CudaBlasHandle handle);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDestroy_v2(CudaBlasHandle handle);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGetVersion_v2(
      CudaBlasHandle handle,
      ref int version);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSetStream_v2(
      CudaBlasHandle handle,
      CUstream streamId);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGetStream_v2(
      CudaBlasHandle handle,
      ref CUstream streamId);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGetPointerMode_v2(
      CudaBlasHandle handle,
      ref PointerMode mode);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSetPointerMode_v2(
      CudaBlasHandle handle,
      PointerMode mode);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGetAtomicsMode(
      CudaBlasHandle handle,
      ref AtomicsMode mode);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSetAtomicsMode(
      CudaBlasHandle handle,
      AtomicsMode mode);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGetMathMode(
      CudaBlasHandle handle,
      ref Math mode);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSetMathMode(
      CudaBlasHandle handle,
      Math mode);

    /// <summary>
    /// copies n elements from a vector x in CPU memory space to a vector y
    /// in GPU memory space. Elements in both vectors are assumed to have a
    /// size of elemSize bytes. Storage spacing between consecutive elements
    /// is incx for the source vector x and incy for the destination vector
    /// y. In general, y points to an object, or part of an object, allocated
    /// via cublasAlloc(). Column major format for two-dimensional matrices
    /// is assumed throughout CUBLAS. Therefore, if the increment for a vector
    /// is equal to 1, this access a column vector while using an increment
    /// equal to the leading dimension of the respective matrix accesses a
    /// row vector.
    /// </summary>
    /// <returns>
    /// CudaBlas Error Codes: <see cref="F:ManagedCuda.CudaBlas.CublasStatus.Success" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.InvalidValue" />,
    /// <see cref="F:ManagedCuda.CudaBlas.CublasStatus.MappingError" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.NotInitialized" />.
    /// </returns>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSetVector(
      int n,
      int elemSize,
      [In] IntPtr x,
      int incx,
      CUdeviceptr devicePtr,
      int incy);

    /// <summary>
    /// copies n elements from a vector x in GPU memory space to a vector y
    /// in CPU memory space. Elements in both vectors are assumed to have a
    /// size of elemSize bytes. Storage spacing between consecutive elements
    /// is incx for the source vector x and incy for the destination vector
    /// y. In general, x points to an object, or part of an object, allocated
    /// via cublasAlloc(). Column major format for two-dimensional matrices
    /// is assumed throughout CUBLAS. Therefore, if the increment for a vector
    /// is equal to 1, this access a column vector while using an increment
    /// equal to the leading dimension of the respective matrix accesses a
    /// row vector.
    /// </summary>
    /// <returns>
    /// CudaBlas Error Codes: <see cref="F:ManagedCuda.CudaBlas.CublasStatus.Success" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.InvalidValue" />,
    /// <see cref="F:ManagedCuda.CudaBlas.CublasStatus.MappingError" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.NotInitialized" />.
    /// </returns>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGetVector(
      int n,
      int elemSize,
      [In] CUdeviceptr x,
      int incx,
      IntPtr y,
      int incy);

    /// <summary>
    /// copies a tile of rows x cols elements from a matrix A in CPU memory
    /// space to a matrix B in GPU memory space. Each element requires storage
    /// of elemSize bytes. Both matrices are assumed to be stored in column
    /// major format, with the leading dimension (i.e. number of rows) of
    /// source matrix A provided in lda, and the leading dimension of matrix B
    /// provided in ldb. In general, B points to an object, or part of an
    /// object, that was allocated via cublasAlloc().
    /// </summary>
    /// <returns>
    /// CudaBlas Error Codes: <see cref="F:ManagedCuda.CudaBlas.CublasStatus.Success" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.InvalidValue" />,
    /// <see cref="F:ManagedCuda.CudaBlas.CublasStatus.MappingError" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.NotInitialized" />.
    /// </returns>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSetMatrix(
      int rows,
      int cols,
      int elemSize,
      [In] IntPtr A,
      int lda,
      CUdeviceptr B,
      int ldb);

    /// <summary>
    /// copies a tile of rows x cols elements from a matrix A in GPU memory
    /// space to a matrix B in CPU memory space. Each element requires storage
    /// of elemSize bytes. Both matrices are assumed to be stored in column
    /// major format, with the leading dimension (i.e. number of rows) of
    /// source matrix A provided in lda, and the leading dimension of matrix B
    /// provided in ldb. In general, A points to an object, or part of an
    /// object, that was allocated via cublasAlloc().
    /// </summary>
    /// <returns>
    /// CudaBlas Error Codes: <see cref="F:ManagedCuda.CudaBlas.CublasStatus.Success" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.InvalidValue" />,
    /// <see cref="F:ManagedCuda.CudaBlas.CublasStatus.MappingError" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.NotInitialized" />.
    /// </returns>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGetMatrix(
      int rows,
      int cols,
      int elemSize,
      [In] CUdeviceptr A,
      int lda,
      IntPtr B,
      int ldb);

    /// <summary>
    /// cublasSetVectorAsync has the same functionnality as cublasSetVector
    /// but the transfer is done asynchronously within the CUDA stream passed
    /// in parameter.
    /// </summary>
    /// <returns>
    /// CudaBlas Error Codes: <see cref="F:ManagedCuda.CudaBlas.CublasStatus.Success" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.InvalidValue" />,
    /// <see cref="F:ManagedCuda.CudaBlas.CublasStatus.MappingError" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.NotInitialized" />.
    /// </returns>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSetVectorAsync(
      int n,
      int elemSize,
      [In] IntPtr hostPtr,
      int incx,
      CUdeviceptr devicePtr,
      int incy,
      CUstream stream);

    /// <summary>
    /// cublasGetVectorAsync has the same functionnality as cublasGetVector
    /// but the transfer is done asynchronously within the CUDA stream passed
    /// in parameter.
    /// </summary>
    /// <returns>
    /// CudaBlas Error Codes: <see cref="F:ManagedCuda.CudaBlas.CublasStatus.Success" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.InvalidValue" />,
    /// <see cref="F:ManagedCuda.CudaBlas.CublasStatus.MappingError" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.NotInitialized" />.
    /// </returns>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGetVectorAsync(
      int n,
      int elemSize,
      [In] CUdeviceptr devicePtr,
      int incx,
      IntPtr hostPtr,
      int incy,
      CUstream stream);

    /// <summary>
    /// cublasSetMatrixAsync has the same functionnality as cublasSetMatrix
    /// but the transfer is done asynchronously within the CUDA stream passed
    /// in parameter.
    /// </summary>
    /// <returns>
    /// CudaBlas Error Codes: <see cref="F:ManagedCuda.CudaBlas.CublasStatus.Success" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.InvalidValue" />,
    /// <see cref="F:ManagedCuda.CudaBlas.CublasStatus.MappingError" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.NotInitialized" />.
    /// </returns>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSetMatrixAsync(
      int rows,
      int cols,
      int elemSize,
      [In] IntPtr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      CUstream stream);

    /// <summary>
    /// cublasGetMatrixAsync has the same functionnality as cublasGetMatrix
    /// but the transfer is done asynchronously within the CUDA stream passed
    /// in parameter.
    /// </summary>
    /// <returns>
    /// CudaBlas Error Codes: <see cref="F:ManagedCuda.CudaBlas.CublasStatus.Success" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.InvalidValue" />,
    /// <see cref="F:ManagedCuda.CudaBlas.CublasStatus.MappingError" />, <see cref="F:ManagedCuda.CudaBlas.CublasStatus.NotInitialized" />.
    /// </returns>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGetMatrixAsync(
      int rows,
      int cols,
      int elemSize,
      [In] CUdeviceptr A,
      int lda,
      IntPtr B,
      int ldb,
      CUstream stream);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasScopy_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDcopy_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCcopy_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZcopy_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSswap_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDswap_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCswap_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZswap_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasNrm2Ex(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      cudaDataType xType,
      int incx,
      IntPtr result,
      cudaDataType resultType,
      cudaDataType executionType);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDotEx(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      cudaDataType xType,
      int incx,
      CUdeviceptr y,
      cudaDataType yType,
      int incy,
      IntPtr result,
      cudaDataType resultType,
      cudaDataType executionType);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDotcEx(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      cudaDataType xType,
      int incx,
      CUdeviceptr y,
      cudaDataType yType,
      int incy,
      IntPtr result,
      cudaDataType resultType,
      cudaDataType executionType);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSnrm2_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref float result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDnrm2_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref double result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasScnrm2_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref float result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDznrm2_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref double result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSdot_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      ref float result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDdot_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      ref double result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCdotu_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      ref cuFloatComplex result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCdotc_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      ref cuFloatComplex result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZdotu_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      ref cuDoubleComplex result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZdotc_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      ref cuDoubleComplex result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasScalEx(
      CudaBlasHandle handle,
      int n,
      IntPtr alpha,
      cudaDataType alphaType,
      CUdeviceptr x,
      cudaDataType xType,
      int incx,
      cudaDataType executionType);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] ref float alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] ref double alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] ref cuFloatComplex alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] ref float alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] ref cuDoubleComplex alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZdscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] ref double alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasAxpyEx(
      CudaBlasHandle handle,
      int n,
      IntPtr alpha,
      cudaDataType alphaType,
      CUdeviceptr x,
      cudaDataType xType,
      int incx,
      CUdeviceptr y,
      cudaDataType yType,
      int incy,
      cudaDataType executiontype);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSaxpy_v2(
      CudaBlasHandle handle,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDaxpy_v2(
      CudaBlasHandle handle,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCaxpy_v2(
      CudaBlasHandle handle,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZaxpy_v2(
      CudaBlasHandle handle,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIsamax_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref int result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIdamax_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref int result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIcamax_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref int result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIzamax_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref int result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIsamin_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref int result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIdamin_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref int result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIcamin_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref int result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIzamin_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref int result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSasum_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref float result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDasum_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref double result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasScasum_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref float result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDzasum_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      ref double result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] ref float c,
      [In] ref float s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] ref double c,
      [In] ref double s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] ref float c,
      [In] ref cuFloatComplex s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] ref float c,
      [In] ref float s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] ref double c,
      [In] ref cuDoubleComplex s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZdrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] ref double c,
      [In] ref double s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSrotg_v2(
      CudaBlasHandle handle,
      ref float a,
      ref float b,
      ref float c,
      ref float s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDrotg_v2(
      CudaBlasHandle handle,
      ref double a,
      ref double b,
      ref double c,
      ref double s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCrotg_v2(
      CudaBlasHandle handle,
      ref cuFloatComplex a,
      ref cuFloatComplex b,
      ref float c,
      ref cuFloatComplex s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZrotg_v2(
      CudaBlasHandle handle,
      ref cuDoubleComplex a,
      ref cuDoubleComplex b,
      ref double c,
      ref cuDoubleComplex s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSrotm_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 5), In] float[] param);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDrotm_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 5), In] double[] param);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSrotmg_v2(
      CudaBlasHandle handle,
      ref float d1,
      ref float d2,
      ref float x1,
      [In] ref float y1,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 5)] float[] param);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDrotmg_v2(
      CudaBlasHandle handle,
      ref double d1,
      ref double d2,
      ref double x1,
      [In] ref double y1,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 5)] double[] param);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasNrm2Ex(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      cudaDataType xType,
      int incx,
      CUdeviceptr result,
      cudaDataType resultType,
      cudaDataType executionType);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDotEx(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      cudaDataType xType,
      int incx,
      CUdeviceptr y,
      cudaDataType yType,
      int incy,
      CUdeviceptr result,
      cudaDataType resultType,
      cudaDataType executionType);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDotcEx(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      cudaDataType xType,
      int incx,
      CUdeviceptr y,
      cudaDataType yType,
      int incy,
      CUdeviceptr result,
      cudaDataType resultType,
      cudaDataType executionType);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSnrm2_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDnrm2_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasScnrm2_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDznrm2_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSdot_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDdot_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCdotu_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCdotc_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZdotu_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZdotc_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasScalEx(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr alpha,
      cudaDataType alphaType,
      CUdeviceptr x,
      cudaDataType xType,
      int incx,
      cudaDataType executionType);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZdscal_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr alpha,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasAxpyEx(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr alpha,
      cudaDataType alphaType,
      CUdeviceptr x,
      cudaDataType xType,
      int incx,
      CUdeviceptr y,
      cudaDataType yType,
      int incy,
      cudaDataType executiontype);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSaxpy_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDaxpy_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCaxpy_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZaxpy_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIsamax_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIdamax_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIcamax_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIzamax_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIsamin_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIdamin_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIcamin_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasIzamin_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSasum_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDasum_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasScasum_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDzasum_v2(
      CudaBlasHandle handle,
      int n,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr result);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] CUdeviceptr c,
      [In] CUdeviceptr s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] CUdeviceptr c,
      [In] CUdeviceptr s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] CUdeviceptr c,
      [In] CUdeviceptr s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] CUdeviceptr c,
      [In] CUdeviceptr s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] CUdeviceptr c,
      [In] CUdeviceptr s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZdrot_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] CUdeviceptr c,
      [In] CUdeviceptr s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSrotg_v2(
      CudaBlasHandle handle,
      CUdeviceptr a,
      CUdeviceptr b,
      CUdeviceptr c,
      CUdeviceptr s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDrotg_v2(
      CudaBlasHandle handle,
      CUdeviceptr a,
      CUdeviceptr b,
      CUdeviceptr c,
      CUdeviceptr s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCrotg_v2(
      CudaBlasHandle handle,
      CUdeviceptr a,
      CUdeviceptr b,
      CUdeviceptr c,
      CUdeviceptr s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZrotg_v2(
      CudaBlasHandle handle,
      CUdeviceptr a,
      CUdeviceptr b,
      CUdeviceptr c,
      CUdeviceptr s);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSrotm_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] CUdeviceptr param);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDrotm_v2(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr x,
      int incx,
      CUdeviceptr y,
      int incy,
      [In] CUdeviceptr param);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSrotmg_v2(
      CudaBlasHandle handle,
      CUdeviceptr d1,
      CUdeviceptr d2,
      CUdeviceptr x1,
      [In] CUdeviceptr y1,
      CUdeviceptr param);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDrotmg_v2(
      CudaBlasHandle handle,
      CUdeviceptr d1,
      CUdeviceptr d2,
      CUdeviceptr x1,
      [In] CUdeviceptr y1,
      CUdeviceptr param);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStrmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtrmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtrmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtrmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      int k,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      int k,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      int k,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      int k,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStpmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr AP,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtpmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr AP,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtpmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr AP,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtpmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr AP,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStrsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtrsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtrsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtrsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStpsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr AP,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtpsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr AP,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtpsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr AP,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtpsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      [In] CUdeviceptr AP,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStbsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      int k,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtbsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      int k,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtbsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      int k,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtbsv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int n,
      int k,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgemv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref float beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgemv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref double beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuFloatComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgemv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuDoubleComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgbmv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int kl,
      int ku,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref float beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgbmv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int kl,
      int ku,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref double beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgbmv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int kl,
      int ku,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuFloatComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgbmv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int kl,
      int ku,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuDoubleComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsymv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref float beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsymv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref double beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsymv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuFloatComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsymv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuDoubleComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChemv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuFloatComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhemv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuDoubleComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      int k,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref float beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      int k,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref double beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      int k,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuFloatComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      int k,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuDoubleComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSspmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr AP,
      [In] CUdeviceptr x,
      int incx,
      [In] ref float beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDspmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr AP,
      [In] CUdeviceptr x,
      int incx,
      [In] ref double beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChpmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr AP,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuFloatComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhpmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr AP,
      [In] CUdeviceptr x,
      int incx,
      [In] ref cuDoubleComplex beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSger_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDger_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgeru_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgerc_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgeru_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgerc_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsyr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsyr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsyr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCher_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZher_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSspr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDspr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChpr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhpr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsyr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsyr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsyr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCher2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZher2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSspr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDspr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChpr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhpr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgemv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgemv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgemv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgbmv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int kl,
      int ku,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgbmv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int kl,
      int ku,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgbmv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int kl,
      int ku,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgbmv_v2(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int kl,
      int ku,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsymv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsymv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsymv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsymv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChemv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhemv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhbmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSspmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr AP,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDspmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr AP,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChpmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr AP,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhpmv_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr AP,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr beta,
      CUdeviceptr y,
      int incy);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSger_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDger_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgeru_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgerc_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgeru_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgerc_v2(
      CudaBlasHandle handle,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsyr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsyr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsyr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCher_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZher_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSspr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDspr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChpr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhpr_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsyr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsyr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsyr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCher2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZher2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSspr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDspr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChpr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhpr2_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr x,
      int incx,
      [In] CUdeviceptr y,
      int incy,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgemm_v2(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref float beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgemm_v2(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref double beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemm_v2(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref cuFloatComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemm3m(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref cuFloatComplex alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      ref cuFloatComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemm3m(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgemm3m(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref cuDoubleComplex alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      ref cuDoubleComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgemm3m(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemm3mEx(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref cuFloatComplex alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      CUdeviceptr B,
      cudaDataType Btype,
      int ldb,
      ref cuFloatComplex beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgemm_v2(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref cuDoubleComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasHgemm(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref half alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      ref half beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasHgemm(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasHgemmBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref half alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      ref half beta,
      CUdeviceptr C,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasHgemmBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr C,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgemmEx(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref float alpha,
      CUdeviceptr A,
      DataType Atype,
      int lda,
      CUdeviceptr B,
      DataType Btype,
      int ldb,
      ref float beta,
      CUdeviceptr C,
      DataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGemmEx(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      IntPtr alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      CUdeviceptr B,
      cudaDataType Btype,
      int ldb,
      IntPtr beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc,
      cudaDataType computeType,
      GemmAlgo algo);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGemmEx(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      CUdeviceptr B,
      cudaDataType Btype,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc,
      cudaDataType computeType,
      GemmAlgo algo);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemmEx(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref cuFloatComplex alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      CUdeviceptr B,
      cudaDataType Btype,
      int ldb,
      ref cuFloatComplex beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemmEx(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      CUdeviceptr B,
      cudaDataType Btype,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasUint8gemmBias(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      Operation transc,
      int m,
      int n,
      int k,
      CUdeviceptr A,
      int A_bias,
      int lda,
      CUdeviceptr B,
      int B_bias,
      int ldb,
      CUdeviceptr C,
      int C_bias,
      int ldc,
      int C_mult,
      int C_shift);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgemmEx(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      DataType Atype,
      int lda,
      CUdeviceptr B,
      DataType Btype,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr C,
      DataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsyrk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] ref float beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsyrk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] ref double beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyrk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] ref cuFloatComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsyrk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] ref cuDoubleComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyrkEx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      ref cuFloatComplex alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      ref cuFloatComplex beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyrkEx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      CUdeviceptr beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyrk3mEx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      ref cuFloatComplex alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      ref cuFloatComplex beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyrk3mEx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      CUdeviceptr lpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      CUdeviceptr beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCherk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] ref float beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZherk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] ref double beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsyr2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref float beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsyr2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref double beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyr2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref cuFloatComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsyr2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref cuDoubleComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCher2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref float beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZher2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref double beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCherkEx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      ref float alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      ref float beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCherk3mEx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      ref float alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      ref float beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCherkEx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      CUdeviceptr beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCherk3mEx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      CUdeviceptr beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsyrkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref float beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsyrkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref double beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyrkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref cuFloatComplex beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsyrkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref cuDoubleComplex beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCherkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref float beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZherkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref double beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsymm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref float beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsymm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref double beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsymm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref cuFloatComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsymm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref cuDoubleComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChemm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref cuFloatComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhemm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] ref cuDoubleComplex beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStrsm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtrsm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtrsm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtrsm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStrmm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] ref float alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtrmm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] ref double alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtrmm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] ref cuFloatComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtrmm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] ref cuDoubleComplex alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgemm_v2(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgemm_v2(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemm_v2(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgemm_v2(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsyrk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsyrk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyrk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsyrk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCherk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZherk_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsyr2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsyr2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyr2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsyr2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCher2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZher2k_v2(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsyrkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsyrkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsyrkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsyrkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCherkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZherkx(
      CudaBlasHandle handle,
      FillMode uplo,
      Operation trans,
      int n,
      int k,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      [In] CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSsymm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDsymm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCsymm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZsymm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasChemm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZhemm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      [In] CUdeviceptr beta,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStrsm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtrsm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtrsm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtrsm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStrmm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtrmm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtrmm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtrmm_v2(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      [In] CUdeviceptr alpha,
      [In] CUdeviceptr A,
      int lda,
      [In] CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgeam(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr beta,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgeam(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr beta,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgeam(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr beta,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgeam(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr beta,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgeam(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      ref float alpha,
      CUdeviceptr A,
      int lda,
      ref float beta,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgeam(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      ref double alpha,
      CUdeviceptr A,
      int lda,
      ref double beta,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgeam(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      ref cuFloatComplex alpha,
      CUdeviceptr A,
      int lda,
      ref cuFloatComplex beta,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgeam(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      ref cuDoubleComplex alpha,
      CUdeviceptr A,
      int lda,
      ref cuDoubleComplex beta,
      CUdeviceptr B,
      int ldb,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSmatinvBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr Ainv,
      int lda_inv,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDmatinvBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr Ainv,
      int lda_inv,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCmatinvBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr Ainv,
      int lda_inv,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZmatinvBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr Ainv,
      int lda_inv,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSdgmm(
      CudaBlasHandle handle,
      SideMode mode,
      int m,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDdgmm(
      CudaBlasHandle handle,
      SideMode mode,
      int m,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCdgmm(
      CudaBlasHandle handle,
      SideMode mode,
      int m,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZdgmm(
      CudaBlasHandle handle,
      SideMode mode,
      int m,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr x,
      int incx,
      CUdeviceptr C,
      int ldc);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgemmBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Barray,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr Carray,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgemmBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Barray,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr Carray,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemmBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Barray,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr Carray,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgemmBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Barray,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr Carray,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemm3mBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref cuFloatComplex alpha,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Barray,
      int ldb,
      ref cuFloatComplex beta,
      CUdeviceptr Carray,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemm3mBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Barray,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr Carray,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemm3mStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref cuFloatComplex alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      ref cuFloatComplex beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemm3mStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      CUdeviceptr beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGemmBatchedEx(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr Aarray,
      cudaDataType Atype,
      int lda,
      CUdeviceptr Barray,
      cudaDataType Btype,
      int ldb,
      CUdeviceptr beta,
      CUdeviceptr Carray,
      cudaDataType Ctype,
      int ldc,
      int batchCount,
      cudaDataType computeType,
      GemmAlgo algo);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGemmStridedBatchedEx(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      long strideA,
      CUdeviceptr B,
      cudaDataType Btype,
      int ldb,
      long strideB,
      CUdeviceptr beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc,
      long strideC,
      int batchCount,
      cudaDataType computeType,
      GemmAlgo algo);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgemmStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      CUdeviceptr beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgemmStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      CUdeviceptr beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemmStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      CUdeviceptr beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgemmStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      CUdeviceptr beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasHgemmStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      CUdeviceptr beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgemmBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref float alpha,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Barray,
      int ldb,
      ref float beta,
      CUdeviceptr Carray,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgemmBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref double alpha,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Barray,
      int ldb,
      ref double beta,
      CUdeviceptr Carray,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemmBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref cuFloatComplex alpha,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Barray,
      int ldb,
      ref cuFloatComplex beta,
      CUdeviceptr Carray,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgemmBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref cuDoubleComplex alpha,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Barray,
      int ldb,
      ref cuDoubleComplex beta,
      CUdeviceptr Carray,
      int ldc,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGemmBatchedEx(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      IntPtr alpha,
      CUdeviceptr Aarray,
      cudaDataType Atype,
      int lda,
      CUdeviceptr Barray,
      cudaDataType Btype,
      int ldb,
      IntPtr beta,
      CUdeviceptr Carray,
      cudaDataType Ctype,
      int ldc,
      int batchCount,
      cudaDataType computeType,
      GemmAlgo algo);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGemmStridedBatchedEx(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      IntPtr alpha,
      CUdeviceptr A,
      cudaDataType Atype,
      int lda,
      long strideA,
      CUdeviceptr B,
      cudaDataType Btype,
      int ldb,
      long strideB,
      IntPtr beta,
      CUdeviceptr C,
      cudaDataType Ctype,
      int ldc,
      long strideC,
      int batchCount,
      cudaDataType computeType,
      GemmAlgo algo);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgemmStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref float alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      ref float beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgemmStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref double alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      ref double beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgemmStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref cuFloatComplex alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      ref cuFloatComplex beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgemmStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref cuDoubleComplex alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      ref cuDoubleComplex beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasHgemmStridedBatched(
      CudaBlasHandle handle,
      Operation transa,
      Operation transb,
      int m,
      int n,
      int k,
      ref half alpha,
      CUdeviceptr A,
      int lda,
      long strideA,
      CUdeviceptr B,
      int ldb,
      long strideB,
      ref half beta,
      CUdeviceptr C,
      int ldc,
      long strideC,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgetrfBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr P,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgetrfBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr P,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgetrfBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr P,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgetrfBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr P,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgetriBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr P,
      CUdeviceptr C,
      int ldc,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgetriBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr P,
      CUdeviceptr C,
      int ldc,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgetriBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr P,
      CUdeviceptr C,
      int ldc,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgetriBatched(
      CudaBlasHandle handle,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr P,
      CUdeviceptr C,
      int ldc,
      CUdeviceptr INFO,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStrsmBatched(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtrsmBatched(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtrsmBatched(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      CUdeviceptr alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtrsmBatched(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      CUdeviceptr salpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStrsmBatched(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      ref float alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtrsmBatched(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      ref double alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtrsmBatched(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      ref cuFloatComplex alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtrsmBatched(
      CudaBlasHandle handle,
      SideMode side,
      FillMode uplo,
      Operation trans,
      DiagType diag,
      int m,
      int n,
      ref cuDoubleComplex alpha,
      CUdeviceptr A,
      int lda,
      CUdeviceptr B,
      int ldb,
      int batchCount);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStpttr(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      CUdeviceptr AP,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtpttr(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      CUdeviceptr AP,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtpttr(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      CUdeviceptr AP,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtpttr(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      CUdeviceptr AP,
      CUdeviceptr A,
      int lda);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasStrttp(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDtrttp(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCtrttp(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZtrttp(
      CudaBlasHandle handle,
      FillMode uplo,
      int n,
      CUdeviceptr A,
      int lda,
      CUdeviceptr AP);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgeqrfBatched(
      CudaBlasHandle handle,
      int m,
      int n,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr TauArray,
      ref int info,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgeqrfBatched(
      CudaBlasHandle handle,
      int m,
      int n,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr TauArray,
      ref int info,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgeqrfBatched(
      CudaBlasHandle handle,
      int m,
      int n,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr TauArray,
      ref int info,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgeqrfBatched(
      CudaBlasHandle handle,
      int m,
      int n,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr TauArray,
      ref int info,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgelsBatched(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int nrhs,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Carray,
      int ldc,
      ref int info,
      CUdeviceptr devInfoArray,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgelsBatched(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int nrhs,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Carray,
      int ldc,
      ref int info,
      CUdeviceptr devInfoArray,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgelsBatched(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int nrhs,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Carray,
      int ldc,
      ref int info,
      CUdeviceptr devInfoArray,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgelsBatched(
      CudaBlasHandle handle,
      Operation trans,
      int m,
      int n,
      int nrhs,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr Carray,
      int ldc,
      ref int info,
      CUdeviceptr devInfoArray,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSgetrsBatched(
      CudaBlasHandle handle,
      Operation trans,
      int n,
      int nrhs,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr devIpiv,
      CUdeviceptr Barray,
      int ldb,
      ref int info,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasDgetrsBatched(
      CudaBlasHandle handle,
      Operation trans,
      int n,
      int nrhs,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr devIpiv,
      CUdeviceptr Barray,
      int ldb,
      ref int info,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasCgetrsBatched(
      CudaBlasHandle handle,
      Operation trans,
      int n,
      int nrhs,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr devIpiv,
      CUdeviceptr Barray,
      int ldb,
      ref int info,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasZgetrsBatched(
      CudaBlasHandle handle,
      Operation trans,
      int n,
      int nrhs,
      CUdeviceptr Aarray,
      int lda,
      CUdeviceptr devIpiv,
      CUdeviceptr Barray,
      int ldb,
      ref int info,
      int batchSize);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasLoggerConfigure(
      int logIsOn,
      int logToStdOut,
      int logToStdErr,
      [MarshalAs(UnmanagedType.LPStr)] string logFileName);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasSetLoggerCallback(
      cublasLogCallback userCallback);

    /// <summary>
    /// </summary>
    [DllImport("cublas64_100")]
    public static extern CublasStatus cublasGetLoggerCallback(
      ref cublasLogCallback userCallback);
  }
}
