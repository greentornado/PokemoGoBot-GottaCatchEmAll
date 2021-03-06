// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/DownloadRemoteConfigVersionResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/DownloadRemoteConfigVersionResponse.proto</summary>
  public static partial class DownloadRemoteConfigVersionResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/DownloadRemoteConfigVersionResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DownloadRemoteConfigVersionResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CklQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0Rvd25sb2FkUmVt",
            "b3RlQ29uZmlnVmVyc2lvblJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5l",
            "dHdvcmtpbmcuUmVzcG9uc2VzIuwBCiNEb3dubG9hZFJlbW90ZUNvbmZpZ1Zl",
            "cnNpb25SZXNwb25zZRJbCgZyZXN1bHQYASABKA4ySy5QT0dPUHJvdG9zLk5l",
            "dHdvcmtpbmcuUmVzcG9uc2VzLkRvd25sb2FkUmVtb3RlQ29uZmlnVmVyc2lv",
            "blJlc3BvbnNlLlJlc3VsdBIjChtpdGVtX3RlbXBsYXRlc190aW1lc3RhbXBf",
            "bXMYAiABKAQSIQoZYXNzZXRfZGlnZXN0X3RpbWVzdGFtcF9tcxgDIAEoBCIg",
            "CgZSZXN1bHQSCQoFVU5TRVQQABILCgdTVUNDRVNTEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponse), global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponse.Parser, new[]{ "Result", "ItemTemplatesTimestampMs", "AssetDigestTimestampMs" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DownloadRemoteConfigVersionResponse : pb::IMessage<DownloadRemoteConfigVersionResponse> {
    private static readonly pb::MessageParser<DownloadRemoteConfigVersionResponse> _parser = new pb::MessageParser<DownloadRemoteConfigVersionResponse>(() => new DownloadRemoteConfigVersionResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DownloadRemoteConfigVersionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadRemoteConfigVersionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadRemoteConfigVersionResponse(DownloadRemoteConfigVersionResponse other) : this() {
      result_ = other.result_;
      itemTemplatesTimestampMs_ = other.itemTemplatesTimestampMs_;
      assetDigestTimestampMs_ = other.assetDigestTimestampMs_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DownloadRemoteConfigVersionResponse Clone() {
      return new DownloadRemoteConfigVersionResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "item_templates_timestamp_ms" field.</summary>
    public const int ItemTemplatesTimestampMsFieldNumber = 2;
    private ulong itemTemplatesTimestampMs_;
    /// <summary>
    ///  Latest available?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong ItemTemplatesTimestampMs {
      get { return itemTemplatesTimestampMs_; }
      set {
        itemTemplatesTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "asset_digest_timestamp_ms" field.</summary>
    public const int AssetDigestTimestampMsFieldNumber = 3;
    private ulong assetDigestTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong AssetDigestTimestampMs {
      get { return assetDigestTimestampMs_; }
      set {
        assetDigestTimestampMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DownloadRemoteConfigVersionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DownloadRemoteConfigVersionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (ItemTemplatesTimestampMs != other.ItemTemplatesTimestampMs) return false;
      if (AssetDigestTimestampMs != other.AssetDigestTimestampMs) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (ItemTemplatesTimestampMs != 0UL) hash ^= ItemTemplatesTimestampMs.GetHashCode();
      if (AssetDigestTimestampMs != 0UL) hash ^= AssetDigestTimestampMs.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (ItemTemplatesTimestampMs != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ItemTemplatesTimestampMs);
      }
      if (AssetDigestTimestampMs != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(AssetDigestTimestampMs);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (ItemTemplatesTimestampMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ItemTemplatesTimestampMs);
      }
      if (AssetDigestTimestampMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AssetDigestTimestampMs);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DownloadRemoteConfigVersionResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.ItemTemplatesTimestampMs != 0UL) {
        ItemTemplatesTimestampMs = other.ItemTemplatesTimestampMs;
      }
      if (other.AssetDigestTimestampMs != 0UL) {
        AssetDigestTimestampMs = other.AssetDigestTimestampMs;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            result_ = (global::POGOProtos.Networking.Responses.DownloadRemoteConfigVersionResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 16: {
            ItemTemplatesTimestampMs = input.ReadUInt64();
            break;
          }
          case 24: {
            AssetDigestTimestampMs = input.ReadUInt64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DownloadRemoteConfigVersionResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
