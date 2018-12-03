// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/policy_topic_evidence_destination_mismatch_url_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/policy_topic_evidence_destination_mismatch_url_type.proto</summary>
  public static partial class PolicyTopicEvidenceDestinationMismatchUrlTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/policy_topic_evidence_destination_mismatch_url_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyTopicEvidenceDestinationMismatchUrlTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cldnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9wb2xpY3lfdG9waWNf",
            "ZXZpZGVuY2VfZGVzdGluYXRpb25fbWlzbWF0Y2hfdXJsX3R5cGUucHJvdG8S",
            "HWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zIuQBCjFQb2xpY3lUb3Bp",
            "Y0V2aWRlbmNlRGVzdGluYXRpb25NaXNtYXRjaFVybFR5cGVFbnVtIq4BCi1Q",
            "b2xpY3lUb3BpY0V2aWRlbmNlRGVzdGluYXRpb25NaXNtYXRjaFVybFR5cGUS",
            "DwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDwoLRElTUExBWV9VUkwQ",
            "AhINCglGSU5BTF9VUkwQAxIUChBGSU5BTF9NT0JJTEVfVVJMEAQSEAoMVFJB",
            "Q0tJTkdfVVJMEAUSFwoTTU9CSUxFX1RSQUNLSU5HX1VSTBAGQuMBCiFjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXNCMlBvbGljeVRvcGljRXZp",
            "ZGVuY2VEZXN0aW5hdGlvbk1pc21hdGNoVXJsVHlwZVByb3RvUAFaQmdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92MC9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRz",
            "LlYwLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjBcRW51bXNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum.Types.PolicyTopicEvidenceDestinationMismatchUrlType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible policy topic evidence destination
  /// mismatch url types.
  /// </summary>
  public sealed partial class PolicyTopicEvidenceDestinationMismatchUrlTypeEnum : pb::IMessage<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum> {
    private static readonly pb::MessageParser<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum> _parser = new pb::MessageParser<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum>(() => new PolicyTopicEvidenceDestinationMismatchUrlTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyTopicEvidenceDestinationMismatchUrlTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyTopicEvidenceDestinationMismatchUrlTypeEnum(PolicyTopicEvidenceDestinationMismatchUrlTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyTopicEvidenceDestinationMismatchUrlTypeEnum Clone() {
      return new PolicyTopicEvidenceDestinationMismatchUrlTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PolicyTopicEvidenceDestinationMismatchUrlTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PolicyTopicEvidenceDestinationMismatchUrlTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PolicyTopicEvidenceDestinationMismatchUrlTypeEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the PolicyTopicEvidenceDestinationMismatchUrlTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible policy topic evidence destination mismatch url types.
      /// </summary>
      public enum PolicyTopicEvidenceDestinationMismatchUrlType {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The display url.
        /// </summary>
        [pbr::OriginalName("DISPLAY_URL")] DisplayUrl = 2,
        /// <summary>
        /// The final url.
        /// </summary>
        [pbr::OriginalName("FINAL_URL")] FinalUrl = 3,
        /// <summary>
        /// The final mobile url.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URL")] FinalMobileUrl = 4,
        /// <summary>
        /// The tracking url template, with substituted desktop url.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 5,
        /// <summary>
        /// The tracking url template, with substituted mobile url.
        /// </summary>
        [pbr::OriginalName("MOBILE_TRACKING_URL")] MobileTrackingUrl = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code