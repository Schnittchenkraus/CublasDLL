// Decompiled with JetBrains decompiler
// Type: ManagedCuda.CudaBlas.CudaBlasException
// Assembly: CudaBlas, Version=10.0.31.0, Culture=neutral, PublicKeyToken=539d54d12e99fedb
// MVID: 645B487D-3E05-446D-9AF7-29C966B69DA3
// Assembly location: D:\VS17\June_1\cuBLAS1\packages\ManagedCuda-CUBLAS.10.0.31\lib\net46\CudaBlas.dll

using System;
using System.Runtime.Serialization;

namespace ManagedCuda.CudaBlas
{
  /// <summary>
  /// An CudaBlasException is thrown, if any wrapped call to the CUBLAS-library does not return <see cref="F:ManagedCuda.CudaBlas.CublasStatus.Success" />.
  /// </summary>
  public class CudaBlasException : Exception, ISerializable
  {
    private CublasStatus _cudaBlasError;

    /// <summary>
    /// 
    /// </summary>
    public CudaBlasException()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="serInfo"></param>
    /// <param name="streamingContext"></param>
    protected CudaBlasException(SerializationInfo serInfo, StreamingContext streamingContext)
      : base(serInfo, streamingContext)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="error"></param>
    public CudaBlasException(CublasStatus error)
      : base(CudaBlasException.GetErrorMessageFromCUResult(error))
    {
      this._cudaBlasError = error;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    public CudaBlasException(string message)
      : base(message)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <param name="exception"></param>
    public CudaBlasException(string message, Exception exception)
      : base(message, exception)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="error"></param>
    /// <param name="message"></param>
    /// <param name="exception"></param>
    public CudaBlasException(CublasStatus error, string message, Exception exception)
      : base(message, exception)
    {
      this._cudaBlasError = error;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return this._cudaBlasError.ToString();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="info"></param>
    /// <param name="context"></param>
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      base.GetObjectData(info, context);
      info.AddValue("CudaBlasError", (object) this._cudaBlasError);
    }

    private static string GetErrorMessageFromCUResult(CublasStatus error)
    {
      string str = string.Empty;
      switch (error)
      {
        case CublasStatus.Success:
          str = "Any CUBLAS operation is successful.";
          break;
        case CublasStatus.NotInitialized:
          str = "The CUBLAS library was not initialized.";
          break;
        case CublasStatus.AllocFailed:
          str = "Resource allocation failed.";
          break;
        case CublasStatus.InvalidValue:
          str = "An invalid numerical value was used as an argument.";
          break;
        case CublasStatus.ArchMismatch:
          str = "An absent device architectural feature is required.";
          break;
        case CublasStatus.MappingError:
          str = "An access to GPU memory space failed.";
          break;
        case CublasStatus.ExecutionFailed:
          str = "An access to GPU memory space failed.";
          break;
        case CublasStatus.InternalError:
          str = "An internal operation failed.";
          break;
        case CublasStatus.NotSupported:
          str = "Error: Not supported.";
          break;
      }
      return error.ToString() + ": " + str;
    }

    /// <summary>
    /// 
    /// </summary>
    public CublasStatus CudaBlasError
    {
      get
      {
        return this._cudaBlasError;
      }
      set
      {
        this._cudaBlasError = value;
      }
    }
  }
}
