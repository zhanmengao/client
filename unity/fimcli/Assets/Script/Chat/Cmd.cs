// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cmd.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Forevernine.Midplat.Proto {

  /// <summary>Holder for reflection information generated from cmd.proto</summary>
  public static partial class CmdReflection {

    #region Descriptor
    /// <summary>File descriptor for cmd.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CmdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgljbWQucHJvdG8SGWZvcmV2ZXJuaW5lLm1pZHBsYXQucHJvdG8qugoKA0NN",
            "RBIXChNGSU1fU0VSVkVSX0NNRF9JTklUEAASFgoRRklNX0NNRF9MT0dJTl9S",
            "RVEQkU4SFgoRRklNX0NNRF9MT0dJTl9SU1AQkk4SGgoVRklNX0NNRF9IRUFS",
            "VEJFQVRfUkVREJNOEhoKFUZJTV9DTURfSEVBUlRCRUFUX1JTUBCUThIaChVG",
            "SU1fQ01EX1JFQ09OTkVDVF9SRVEQlU4SGgoVRklNX0NNRF9SRUNPTk5FQ1Rf",
            "UlNQEJZOEhsKFkZJTV9DTURfRU5URVJfUk9PTV9SRVEQl04SGwoWRklNX0NN",
            "RF9FTlRFUl9ST09NX1JTUBCYThIbChZGSU1fQ01EX0xFQVZFX1JPT01fUkVR",
            "EJlOEhsKFkZJTV9DTURfTEVBVkVfUk9PTV9SU1AQmk4SGQoURklNX0NNRF9T",
            "RU5EX01TR19SRVEQm04SGQoURklNX0NNRF9TRU5EX01TR19SU1AQnE4SGQoU",
            "RklNX0NNRF9SRUNWX01TR19SRVEQnU4SHAoXRklNX0NNRF9SRUNWX01TR19Q",
            "QUNLRVQQnk4SHgoZRklNX0NNRF9HRVRfQU5EX0xFQVZFX1JFURCfThIeChlG",
            "SU1fQ01EX0dFVF9BTkRfTEVBVkVfUlNQEKBOEhoKFUZJTV9DTURfUk9PTV9T",
            "WU5DX1JFURChThIeChlGSU1fQ01EX0dFVF9ST09NX0xJU1RfUkVREKNOEh4K",
            "GUZJTV9DTURfR0VUX1JPT01fTElTVF9SU1AQpE4SHAoXRklNX0NNRF9HRVRf",
            "TUVNQkVSU19SRVEQpU4SHAoXRklNX0NNRF9HRVRfTUVNQkVSU19SU1AQpk4S",
            "FwoSRklNX0NNRF9MT0dPVVRfUkVREKdOEh0KGEZJTV9DTURfU1JWX1NFTkRf",
            "TVNHX1JFURCpThIdChhGSU1fQ01EX1NSVl9TRU5EX01TR19SU1AQqk4SHQoX",
            "RklNX0xPR0lDX0NNRF9MT0dJTl9SRVEQoZwBEh0KF0ZJTV9MT0dJQ19DTURf",
            "TE9HSU5fUlNQEKKcARIhChtGSU1fTE9HSUNfQ01EX0hFQVJUQkVBVF9SRVEQ",
            "o5wBEiEKG0ZJTV9MT0dJQ19DTURfSEVBUlRCRUFUX1JTUBCknAESIQobRklN",
            "X0xPR0lDX0NNRF9SRUNPTk5FQ1RfUkVREKWcARIhChtGSU1fTE9HSUNfQ01E",
            "X1JFQ09OTkVDVF9SU1AQppwBEiIKHEZJTV9MT0dJQ19DTURfRU5URVJfUk9P",
            "TV9SRVEQp5wBEiIKHEZJTV9MT0dJQ19DTURfRU5URVJfUk9PTV9SU1AQqJwB",
            "EiAKGkZJTV9MT0dJQ19DTURfU0VORF9NU0dfUkVREKmcARIgChpGSU1fTE9H",
            "SUNfQ01EX1NFTkRfTVNHX1JTUBCqnAESIAoaRklNX0xPR0lDX0NNRF9SRUNW",
            "X01TR19SU1AQrJwBEiIKHEZJTV9MT0dJQ19DTURfTEVBVkVfUk9PTV9SRVEQ",
            "rZwBEiIKHEZJTV9MT0dJQ19DTURfTEVBVkVfUk9PTV9SU1AQrpwBEhcKEUFQ",
            "SV9DTURfRElSVFlfUkVRELHqARIXChFBUElfQ01EX0RJUlRZX1JTUBCy6gES",
            "FwoRRlRTX0NNRF9MT0dJTl9SRVEQwbgCEhcKEUZUU19DTURfTE9HSU5fUlNQ",
            "EMK4AhIVCg9GVFNfQ01EX1BBWV9SRVEQw7gCEhUKD0ZUU19DTURfUEFZX1JT",
            "UBDEuAISFgoQRkxTX01RX0xPR0lOX1JFURDRhgNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Forevernine.Midplat.Proto.CMD), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CMD {
    [pbr::OriginalName("FIM_SERVER_CMD_INIT")] FimServerCmdInit = 0,
    [pbr::OriginalName("FIM_CMD_LOGIN_REQ")] FimCmdLoginReq = 10001,
    [pbr::OriginalName("FIM_CMD_LOGIN_RSP")] FimCmdLoginRsp = 10002,
    [pbr::OriginalName("FIM_CMD_HEARTBEAT_REQ")] FimCmdHeartbeatReq = 10003,
    [pbr::OriginalName("FIM_CMD_HEARTBEAT_RSP")] FimCmdHeartbeatRsp = 10004,
    [pbr::OriginalName("FIM_CMD_RECONNECT_REQ")] FimCmdReconnectReq = 10005,
    [pbr::OriginalName("FIM_CMD_RECONNECT_RSP")] FimCmdReconnectRsp = 10006,
    [pbr::OriginalName("FIM_CMD_ENTER_ROOM_REQ")] FimCmdEnterRoomReq = 10007,
    [pbr::OriginalName("FIM_CMD_ENTER_ROOM_RSP")] FimCmdEnterRoomRsp = 10008,
    [pbr::OriginalName("FIM_CMD_LEAVE_ROOM_REQ")] FimCmdLeaveRoomReq = 10009,
    [pbr::OriginalName("FIM_CMD_LEAVE_ROOM_RSP")] FimCmdLeaveRoomRsp = 10010,
    [pbr::OriginalName("FIM_CMD_SEND_MSG_REQ")] FimCmdSendMsgReq = 10011,
    [pbr::OriginalName("FIM_CMD_SEND_MSG_RSP")] FimCmdSendMsgRsp = 10012,
    [pbr::OriginalName("FIM_CMD_RECV_MSG_REQ")] FimCmdRecvMsgReq = 10013,
    [pbr::OriginalName("FIM_CMD_RECV_MSG_PACKET")] FimCmdRecvMsgPacket = 10014,
    [pbr::OriginalName("FIM_CMD_GET_AND_LEAVE_REQ")] FimCmdGetAndLeaveReq = 10015,
    [pbr::OriginalName("FIM_CMD_GET_AND_LEAVE_RSP")] FimCmdGetAndLeaveRsp = 10016,
    [pbr::OriginalName("FIM_CMD_ROOM_SYNC_REQ")] FimCmdRoomSyncReq = 10017,
    [pbr::OriginalName("FIM_CMD_GET_ROOM_LIST_REQ")] FimCmdGetRoomListReq = 10019,
    [pbr::OriginalName("FIM_CMD_GET_ROOM_LIST_RSP")] FimCmdGetRoomListRsp = 10020,
    [pbr::OriginalName("FIM_CMD_GET_MEMBERS_REQ")] FimCmdGetMembersReq = 10021,
    [pbr::OriginalName("FIM_CMD_GET_MEMBERS_RSP")] FimCmdGetMembersRsp = 10022,
    [pbr::OriginalName("FIM_CMD_LOGOUT_REQ")] FimCmdLogoutReq = 10023,
    [pbr::OriginalName("FIM_CMD_SRV_SEND_MSG_REQ")] FimCmdSrvSendMsgReq = 10025,
    [pbr::OriginalName("FIM_CMD_SRV_SEND_MSG_RSP")] FimCmdSrvSendMsgRsp = 10026,
    [pbr::OriginalName("FIM_LOGIC_CMD_LOGIN_REQ")] FimLogicCmdLoginReq = 20001,
    [pbr::OriginalName("FIM_LOGIC_CMD_LOGIN_RSP")] FimLogicCmdLoginRsp = 20002,
    [pbr::OriginalName("FIM_LOGIC_CMD_HEARTBEAT_REQ")] FimLogicCmdHeartbeatReq = 20003,
    [pbr::OriginalName("FIM_LOGIC_CMD_HEARTBEAT_RSP")] FimLogicCmdHeartbeatRsp = 20004,
    [pbr::OriginalName("FIM_LOGIC_CMD_RECONNECT_REQ")] FimLogicCmdReconnectReq = 20005,
    [pbr::OriginalName("FIM_LOGIC_CMD_RECONNECT_RSP")] FimLogicCmdReconnectRsp = 20006,
    [pbr::OriginalName("FIM_LOGIC_CMD_ENTER_ROOM_REQ")] FimLogicCmdEnterRoomReq = 20007,
    [pbr::OriginalName("FIM_LOGIC_CMD_ENTER_ROOM_RSP")] FimLogicCmdEnterRoomRsp = 20008,
    [pbr::OriginalName("FIM_LOGIC_CMD_SEND_MSG_REQ")] FimLogicCmdSendMsgReq = 20009,
    [pbr::OriginalName("FIM_LOGIC_CMD_SEND_MSG_RSP")] FimLogicCmdSendMsgRsp = 20010,
    /// <summary>
    ///FIM_LOGIC_CMD_RECV_MSG_REQ = 20011;
    /// </summary>
    [pbr::OriginalName("FIM_LOGIC_CMD_RECV_MSG_RSP")] FimLogicCmdRecvMsgRsp = 20012,
    [pbr::OriginalName("FIM_LOGIC_CMD_LEAVE_ROOM_REQ")] FimLogicCmdLeaveRoomReq = 20013,
    [pbr::OriginalName("FIM_LOGIC_CMD_LEAVE_ROOM_RSP")] FimLogicCmdLeaveRoomRsp = 20014,
    [pbr::OriginalName("API_CMD_DIRTY_REQ")] ApiCmdDirtyReq = 30001,
    [pbr::OriginalName("API_CMD_DIRTY_RSP")] ApiCmdDirtyRsp = 30002,
    [pbr::OriginalName("FTS_CMD_LOGIN_REQ")] FtsCmdLoginReq = 40001,
    [pbr::OriginalName("FTS_CMD_LOGIN_RSP")] FtsCmdLoginRsp = 40002,
    [pbr::OriginalName("FTS_CMD_PAY_REQ")] FtsCmdPayReq = 40003,
    [pbr::OriginalName("FTS_CMD_PAY_RSP")] FtsCmdPayRsp = 40004,
    [pbr::OriginalName("FLS_MQ_LOGIN_REQ")] FlsMqLoginReq = 50001,
  }

  #endregion

}

#endregion Designer generated code
