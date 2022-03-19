// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: autogen_base_packet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Forevernine.Midplat.Proto {

  /// <summary>Holder for reflection information generated from autogen_base_packet.proto</summary>
  public static partial class AutogenBasePacketReflection {

    #region Descriptor
    /// <summary>File descriptor for autogen_base_packet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AutogenBasePacketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlhdXRvZ2VuX2Jhc2VfcGFja2V0LnByb3RvEhlmb3JldmVybmluZS5taWRw",
            "bGF0LnByb3RvIvgBCgpQYWNrZXRIZWFkEgsKA0NtZBgBIAEoBRILCgNTZXEY",
            "AiABKAUSDAoEVGltZRgDIAEoAxIMCgRPcHRzGAQgASgDEgwKBFJLZXkYCiAB",
            "KAkSEQoJQ2xpZW50VmVyGAsgASgJEhAKCENsaWVudElQGAwgASgJEgsKA01v",
            "ZBgNIAEoBRINCgVSZXFJZBgOIAEoCRINCgVFdmVudBgPIAEoCBIWCg5DbGll",
            "bnRSZXZpc2lvbhgQIAEoCRIOCgZGbG93SUQYESABKAQSEAoIUmVzZXJ2ZWQY",
            "EiABKAwSCwoDVUlEGBQgASgJEg8KB1RhYmxlSUQYFSABKAUiSwoGUGFja2V0",
            "EjMKBEhlYWQYASABKAsyJS5mb3JldmVybmluZS5taWRwbGF0LnByb3RvLlBh",
            "Y2tldEhlYWQSDAoEQm9keRgCIAEoDCIkCgdSc3BIZWFkEgwKBENvZGUYASAB",
            "KAUSCwoDTXNnGAIgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Forevernine.Midplat.Proto.PacketHead), global::Forevernine.Midplat.Proto.PacketHead.Parser, new[]{ "Cmd", "Seq", "Time", "Opts", "RKey", "ClientVer", "ClientIP", "Mod", "ReqId", "Event", "ClientRevision", "FlowID", "Reserved", "UID", "TableID" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Forevernine.Midplat.Proto.Packet), global::Forevernine.Midplat.Proto.Packet.Parser, new[]{ "Head", "Body" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Forevernine.Midplat.Proto.RspHead), global::Forevernine.Midplat.Proto.RspHead.Parser, new[]{ "Code", "Msg" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PacketHead : pb::IMessage<PacketHead> {
    private static readonly pb::MessageParser<PacketHead> _parser = new pb::MessageParser<PacketHead>(() => new PacketHead());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PacketHead> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Forevernine.Midplat.Proto.AutogenBasePacketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PacketHead() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PacketHead(PacketHead other) : this() {
      cmd_ = other.cmd_;
      seq_ = other.seq_;
      time_ = other.time_;
      opts_ = other.opts_;
      rKey_ = other.rKey_;
      clientVer_ = other.clientVer_;
      clientIP_ = other.clientIP_;
      mod_ = other.mod_;
      reqId_ = other.reqId_;
      event_ = other.event_;
      clientRevision_ = other.clientRevision_;
      flowID_ = other.flowID_;
      reserved_ = other.reserved_;
      uID_ = other.uID_;
      tableID_ = other.tableID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PacketHead Clone() {
      return new PacketHead(this);
    }

    /// <summary>Field number for the "Cmd" field.</summary>
    public const int CmdFieldNumber = 1;
    private int cmd_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Cmd {
      get { return cmd_; }
      set {
        cmd_ = value;
      }
    }

    /// <summary>Field number for the "Seq" field.</summary>
    public const int SeqFieldNumber = 2;
    private int seq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Seq {
      get { return seq_; }
      set {
        seq_ = value;
      }
    }

    /// <summary>Field number for the "Time" field.</summary>
    public const int TimeFieldNumber = 3;
    private long time_;
    /// <summary>
    /// server timestamp(millisecond)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "Opts" field.</summary>
    public const int OptsFieldNumber = 4;
    private long opts_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Opts {
      get { return opts_; }
      set {
        opts_ = value;
      }
    }

    /// <summary>Field number for the "RKey" field.</summary>
    public const int RKeyFieldNumber = 10;
    private string rKey_ = "";
    /// <summary>
    /// route key
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RKey {
      get { return rKey_; }
      set {
        rKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ClientVer" field.</summary>
    public const int ClientVerFieldNumber = 11;
    private string clientVer_ = "";
    /// <summary>
    /// server field
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientVer {
      get { return clientVer_; }
      set {
        clientVer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ClientIP" field.</summary>
    public const int ClientIPFieldNumber = 12;
    private string clientIP_ = "";
    /// <summary>
    /// server field
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientIP {
      get { return clientIP_; }
      set {
        clientIP_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Mod" field.</summary>
    public const int ModFieldNumber = 13;
    private int mod_;
    /// <summary>
    /// server field
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Mod {
      get { return mod_; }
      set {
        mod_ = value;
      }
    }

    /// <summary>Field number for the "ReqId" field.</summary>
    public const int ReqIdFieldNumber = 14;
    private string reqId_ = "";
    /// <summary>
    /// server field: request id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ReqId {
      get { return reqId_; }
      set {
        reqId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Event" field.</summary>
    public const int EventFieldNumber = 15;
    private bool event_;
    /// <summary>
    /// server, packet is a server internal event
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Event {
      get { return event_; }
      set {
        event_ = value;
      }
    }

    /// <summary>Field number for the "ClientRevision" field.</summary>
    public const int ClientRevisionFieldNumber = 16;
    private string clientRevision_ = "";
    /// <summary>
    /// 客户端热更新版本号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientRevision {
      get { return clientRevision_; }
      set {
        clientRevision_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "FlowID" field.</summary>
    public const int FlowIDFieldNumber = 17;
    private ulong flowID_;
    /// <summary>
    /// 用于服务器内部通信的请求响应ID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong FlowID {
      get { return flowID_; }
      set {
        flowID_ = value;
      }
    }

    /// <summary>Field number for the "Reserved" field.</summary>
    public const int ReservedFieldNumber = 18;
    private pb::ByteString reserved_ = pb::ByteString.Empty;
    /// <summary>
    /// 预留字段
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Reserved {
      get { return reserved_; }
      set {
        reserved_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "UID" field.</summary>
    public const int UIDFieldNumber = 20;
    private string uID_ = "";
    /// <summary>
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UID {
      get { return uID_; }
      set {
        uID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "TableID" field.</summary>
    public const int TableIDFieldNumber = 21;
    private int tableID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TableID {
      get { return tableID_; }
      set {
        tableID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PacketHead);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PacketHead other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Cmd != other.Cmd) return false;
      if (Seq != other.Seq) return false;
      if (Time != other.Time) return false;
      if (Opts != other.Opts) return false;
      if (RKey != other.RKey) return false;
      if (ClientVer != other.ClientVer) return false;
      if (ClientIP != other.ClientIP) return false;
      if (Mod != other.Mod) return false;
      if (ReqId != other.ReqId) return false;
      if (Event != other.Event) return false;
      if (ClientRevision != other.ClientRevision) return false;
      if (FlowID != other.FlowID) return false;
      if (Reserved != other.Reserved) return false;
      if (UID != other.UID) return false;
      if (TableID != other.TableID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Cmd != 0) hash ^= Cmd.GetHashCode();
      if (Seq != 0) hash ^= Seq.GetHashCode();
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (Opts != 0L) hash ^= Opts.GetHashCode();
      if (RKey.Length != 0) hash ^= RKey.GetHashCode();
      if (ClientVer.Length != 0) hash ^= ClientVer.GetHashCode();
      if (ClientIP.Length != 0) hash ^= ClientIP.GetHashCode();
      if (Mod != 0) hash ^= Mod.GetHashCode();
      if (ReqId.Length != 0) hash ^= ReqId.GetHashCode();
      if (Event != false) hash ^= Event.GetHashCode();
      if (ClientRevision.Length != 0) hash ^= ClientRevision.GetHashCode();
      if (FlowID != 0UL) hash ^= FlowID.GetHashCode();
      if (Reserved.Length != 0) hash ^= Reserved.GetHashCode();
      if (UID.Length != 0) hash ^= UID.GetHashCode();
      if (TableID != 0) hash ^= TableID.GetHashCode();
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
      if (Cmd != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Cmd);
      }
      if (Seq != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Seq);
      }
      if (Time != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Time);
      }
      if (Opts != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Opts);
      }
      if (RKey.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(RKey);
      }
      if (ClientVer.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(ClientVer);
      }
      if (ClientIP.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(ClientIP);
      }
      if (Mod != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Mod);
      }
      if (ReqId.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(ReqId);
      }
      if (Event != false) {
        output.WriteRawTag(120);
        output.WriteBool(Event);
      }
      if (ClientRevision.Length != 0) {
        output.WriteRawTag(130, 1);
        output.WriteString(ClientRevision);
      }
      if (FlowID != 0UL) {
        output.WriteRawTag(136, 1);
        output.WriteUInt64(FlowID);
      }
      if (Reserved.Length != 0) {
        output.WriteRawTag(146, 1);
        output.WriteBytes(Reserved);
      }
      if (UID.Length != 0) {
        output.WriteRawTag(162, 1);
        output.WriteString(UID);
      }
      if (TableID != 0) {
        output.WriteRawTag(168, 1);
        output.WriteInt32(TableID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Cmd != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Cmd);
      }
      if (Seq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Seq);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (Opts != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Opts);
      }
      if (RKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RKey);
      }
      if (ClientVer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientVer);
      }
      if (ClientIP.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientIP);
      }
      if (Mod != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Mod);
      }
      if (ReqId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReqId);
      }
      if (Event != false) {
        size += 1 + 1;
      }
      if (ClientRevision.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ClientRevision);
      }
      if (FlowID != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(FlowID);
      }
      if (Reserved.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeBytesSize(Reserved);
      }
      if (UID.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(UID);
      }
      if (TableID != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(TableID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PacketHead other) {
      if (other == null) {
        return;
      }
      if (other.Cmd != 0) {
        Cmd = other.Cmd;
      }
      if (other.Seq != 0) {
        Seq = other.Seq;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      if (other.Opts != 0L) {
        Opts = other.Opts;
      }
      if (other.RKey.Length != 0) {
        RKey = other.RKey;
      }
      if (other.ClientVer.Length != 0) {
        ClientVer = other.ClientVer;
      }
      if (other.ClientIP.Length != 0) {
        ClientIP = other.ClientIP;
      }
      if (other.Mod != 0) {
        Mod = other.Mod;
      }
      if (other.ReqId.Length != 0) {
        ReqId = other.ReqId;
      }
      if (other.Event != false) {
        Event = other.Event;
      }
      if (other.ClientRevision.Length != 0) {
        ClientRevision = other.ClientRevision;
      }
      if (other.FlowID != 0UL) {
        FlowID = other.FlowID;
      }
      if (other.Reserved.Length != 0) {
        Reserved = other.Reserved;
      }
      if (other.UID.Length != 0) {
        UID = other.UID;
      }
      if (other.TableID != 0) {
        TableID = other.TableID;
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
          case 8: {
            Cmd = input.ReadInt32();
            break;
          }
          case 16: {
            Seq = input.ReadInt32();
            break;
          }
          case 24: {
            Time = input.ReadInt64();
            break;
          }
          case 32: {
            Opts = input.ReadInt64();
            break;
          }
          case 82: {
            RKey = input.ReadString();
            break;
          }
          case 90: {
            ClientVer = input.ReadString();
            break;
          }
          case 98: {
            ClientIP = input.ReadString();
            break;
          }
          case 104: {
            Mod = input.ReadInt32();
            break;
          }
          case 114: {
            ReqId = input.ReadString();
            break;
          }
          case 120: {
            Event = input.ReadBool();
            break;
          }
          case 130: {
            ClientRevision = input.ReadString();
            break;
          }
          case 136: {
            FlowID = input.ReadUInt64();
            break;
          }
          case 146: {
            Reserved = input.ReadBytes();
            break;
          }
          case 162: {
            UID = input.ReadString();
            break;
          }
          case 168: {
            TableID = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Packet : pb::IMessage<Packet> {
    private static readonly pb::MessageParser<Packet> _parser = new pb::MessageParser<Packet>(() => new Packet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Packet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Forevernine.Midplat.Proto.AutogenBasePacketReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Packet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Packet(Packet other) : this() {
      head_ = other.head_ != null ? other.head_.Clone() : null;
      body_ = other.body_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Packet Clone() {
      return new Packet(this);
    }

    /// <summary>Field number for the "Head" field.</summary>
    public const int HeadFieldNumber = 1;
    private global::Forevernine.Midplat.Proto.PacketHead head_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Forevernine.Midplat.Proto.PacketHead Head {
      get { return head_; }
      set {
        head_ = value;
      }
    }

    /// <summary>Field number for the "Body" field.</summary>
    public const int BodyFieldNumber = 2;
    private pb::ByteString body_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Body {
      get { return body_; }
      set {
        body_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Packet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Packet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Head, other.Head)) return false;
      if (Body != other.Body) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (head_ != null) hash ^= Head.GetHashCode();
      if (Body.Length != 0) hash ^= Body.GetHashCode();
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
      if (head_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Head);
      }
      if (Body.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Body);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (head_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Head);
      }
      if (Body.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Body);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Packet other) {
      if (other == null) {
        return;
      }
      if (other.head_ != null) {
        if (head_ == null) {
          Head = new global::Forevernine.Midplat.Proto.PacketHead();
        }
        Head.MergeFrom(other.Head);
      }
      if (other.Body.Length != 0) {
        Body = other.Body;
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
          case 10: {
            if (head_ == null) {
              Head = new global::Forevernine.Midplat.Proto.PacketHead();
            }
            input.ReadMessage(Head);
            break;
          }
          case 18: {
            Body = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RspHead : pb::IMessage<RspHead> {
    private static readonly pb::MessageParser<RspHead> _parser = new pb::MessageParser<RspHead>(() => new RspHead());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RspHead> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Forevernine.Midplat.Proto.AutogenBasePacketReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspHead() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspHead(RspHead other) : this() {
      code_ = other.code_;
      msg_ = other.msg_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RspHead Clone() {
      return new RspHead(this);
    }

    /// <summary>Field number for the "Code" field.</summary>
    public const int CodeFieldNumber = 1;
    private int code_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "Msg" field.</summary>
    public const int MsgFieldNumber = 2;
    private string msg_ = "";
    /// <summary>
    ///主要用于前端debug
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RspHead);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RspHead other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      if (Msg != other.Msg) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != 0) hash ^= Code.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
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
      if (Code != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Code);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Msg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Code);
      }
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RspHead other) {
      if (other == null) {
        return;
      }
      if (other.Code != 0) {
        Code = other.Code;
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
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
          case 8: {
            Code = input.ReadInt32();
            break;
          }
          case 18: {
            Msg = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
