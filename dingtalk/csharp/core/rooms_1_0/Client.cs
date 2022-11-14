// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkrooms_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public CreateMeetingRoomResponse CreateMeetingRoom(CreateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomHeaders headers = new CreateMeetingRoomHeaders();
            return CreateMeetingRoomWithOptions(request, headers, runtime);
        }

        public async Task<CreateMeetingRoomResponse> CreateMeetingRoomAsync(CreateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomHeaders headers = new CreateMeetingRoomHeaders();
            return await CreateMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        public CreateMeetingRoomResponse CreateMeetingRoomWithOptions(CreateMeetingRoomRequest request, CreateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["isvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIds))
            {
                body["roomLabelIds"] = request.RoomLabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocation))
            {
                body["roomLocation"] = request.RoomLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["roomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["roomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["roomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateMeetingRoomResponse>(DoROARequest("CreateMeetingRoom", "rooms_1.0", "HTTP", "POST", "AK", "/v1.0/rooms/meetingrooms", "json", req, runtime));
        }

        public async Task<CreateMeetingRoomResponse> CreateMeetingRoomWithOptionsAsync(CreateMeetingRoomRequest request, CreateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["isvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIds))
            {
                body["roomLabelIds"] = request.RoomLabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocation))
            {
                body["roomLocation"] = request.RoomLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["roomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["roomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["roomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateMeetingRoomResponse>(await DoROARequestAsync("CreateMeetingRoom", "rooms_1.0", "HTTP", "POST", "AK", "/v1.0/rooms/meetingrooms", "json", req, runtime));
        }

        public CreateMeetingRoomGroupResponse CreateMeetingRoomGroup(CreateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomGroupHeaders headers = new CreateMeetingRoomGroupHeaders();
            return CreateMeetingRoomGroupWithOptions(request, headers, runtime);
        }

        public async Task<CreateMeetingRoomGroupResponse> CreateMeetingRoomGroupAsync(CreateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateMeetingRoomGroupHeaders headers = new CreateMeetingRoomGroupHeaders();
            return await CreateMeetingRoomGroupWithOptionsAsync(request, headers, runtime);
        }

        public CreateMeetingRoomGroupResponse CreateMeetingRoomGroupWithOptions(CreateMeetingRoomGroupRequest request, CreateMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentGroupId))
            {
                body["parentGroupId"] = request.ParentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateMeetingRoomGroupResponse>(DoROARequest("CreateMeetingRoomGroup", "rooms_1.0", "HTTP", "POST", "AK", "/v1.0/rooms/groups", "json", req, runtime));
        }

        public async Task<CreateMeetingRoomGroupResponse> CreateMeetingRoomGroupWithOptionsAsync(CreateMeetingRoomGroupRequest request, CreateMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentGroupId))
            {
                body["parentGroupId"] = request.ParentGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateMeetingRoomGroupResponse>(await DoROARequestAsync("CreateMeetingRoomGroup", "rooms_1.0", "HTTP", "POST", "AK", "/v1.0/rooms/groups", "json", req, runtime));
        }

        public DeleteMeetingRoomResponse DeleteMeetingRoom(string roomId, DeleteMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomHeaders headers = new DeleteMeetingRoomHeaders();
            return DeleteMeetingRoomWithOptions(roomId, request, headers, runtime);
        }

        public async Task<DeleteMeetingRoomResponse> DeleteMeetingRoomAsync(string roomId, DeleteMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomHeaders headers = new DeleteMeetingRoomHeaders();
            return await DeleteMeetingRoomWithOptionsAsync(roomId, request, headers, runtime);
        }

        public DeleteMeetingRoomResponse DeleteMeetingRoomWithOptions(string roomId, DeleteMeetingRoomRequest request, DeleteMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            roomId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roomId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteMeetingRoomResponse>(DoROARequest("DeleteMeetingRoom", "rooms_1.0", "HTTP", "DELETE", "AK", "/v1.0/rooms/meetingRooms/" + roomId, "json", req, runtime));
        }

        public async Task<DeleteMeetingRoomResponse> DeleteMeetingRoomWithOptionsAsync(string roomId, DeleteMeetingRoomRequest request, DeleteMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            roomId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roomId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteMeetingRoomResponse>(await DoROARequestAsync("DeleteMeetingRoom", "rooms_1.0", "HTTP", "DELETE", "AK", "/v1.0/rooms/meetingRooms/" + roomId, "json", req, runtime));
        }

        public DeleteMeetingRoomGroupResponse DeleteMeetingRoomGroup(string groupId, DeleteMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomGroupHeaders headers = new DeleteMeetingRoomGroupHeaders();
            return DeleteMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
        }

        public async Task<DeleteMeetingRoomGroupResponse> DeleteMeetingRoomGroupAsync(string groupId, DeleteMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteMeetingRoomGroupHeaders headers = new DeleteMeetingRoomGroupHeaders();
            return await DeleteMeetingRoomGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        public DeleteMeetingRoomGroupResponse DeleteMeetingRoomGroupWithOptions(string groupId, DeleteMeetingRoomGroupRequest request, DeleteMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteMeetingRoomGroupResponse>(DoROARequest("DeleteMeetingRoomGroup", "rooms_1.0", "HTTP", "DELETE", "AK", "/v1.0/rooms/groups/" + groupId, "json", req, runtime));
        }

        public async Task<DeleteMeetingRoomGroupResponse> DeleteMeetingRoomGroupWithOptionsAsync(string groupId, DeleteMeetingRoomGroupRequest request, DeleteMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteMeetingRoomGroupResponse>(await DoROARequestAsync("DeleteMeetingRoomGroup", "rooms_1.0", "HTTP", "DELETE", "AK", "/v1.0/rooms/groups/" + groupId, "json", req, runtime));
        }

        public QueryDeviceIpByCodeResponse QueryDeviceIpByCode(string shareCode, QueryDeviceIpByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceIpByCodeHeaders headers = new QueryDeviceIpByCodeHeaders();
            return QueryDeviceIpByCodeWithOptions(shareCode, request, headers, runtime);
        }

        public async Task<QueryDeviceIpByCodeResponse> QueryDeviceIpByCodeAsync(string shareCode, QueryDeviceIpByCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDeviceIpByCodeHeaders headers = new QueryDeviceIpByCodeHeaders();
            return await QueryDeviceIpByCodeWithOptionsAsync(shareCode, request, headers, runtime);
        }

        public QueryDeviceIpByCodeResponse QueryDeviceIpByCodeWithOptions(string shareCode, QueryDeviceIpByCodeRequest request, QueryDeviceIpByCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            shareCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shareCode);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                query["deviceSn"] = request.DeviceSn;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDeviceIpByCodeResponse>(DoROARequest("QueryDeviceIpByCode", "rooms_1.0", "HTTP", "GET", "AK", "/v1.0/rooms/devices/shareCodes/" + shareCode, "json", req, runtime));
        }

        public async Task<QueryDeviceIpByCodeResponse> QueryDeviceIpByCodeWithOptionsAsync(string shareCode, QueryDeviceIpByCodeRequest request, QueryDeviceIpByCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            shareCode = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shareCode);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceSn))
            {
                query["deviceSn"] = request.DeviceSn;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryDeviceIpByCodeResponse>(await DoROARequestAsync("QueryDeviceIpByCode", "rooms_1.0", "HTTP", "GET", "AK", "/v1.0/rooms/devices/shareCodes/" + shareCode, "json", req, runtime));
        }

        public QueryMeetingRoomResponse QueryMeetingRoom(string roomId, QueryMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomHeaders headers = new QueryMeetingRoomHeaders();
            return QueryMeetingRoomWithOptions(roomId, request, headers, runtime);
        }

        public async Task<QueryMeetingRoomResponse> QueryMeetingRoomAsync(string roomId, QueryMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomHeaders headers = new QueryMeetingRoomHeaders();
            return await QueryMeetingRoomWithOptionsAsync(roomId, request, headers, runtime);
        }

        public QueryMeetingRoomResponse QueryMeetingRoomWithOptions(string roomId, QueryMeetingRoomRequest request, QueryMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            roomId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roomId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMeetingRoomResponse>(DoROARequest("QueryMeetingRoom", "rooms_1.0", "HTTP", "GET", "AK", "/v1.0/rooms/meetingRooms/" + roomId, "json", req, runtime));
        }

        public async Task<QueryMeetingRoomResponse> QueryMeetingRoomWithOptionsAsync(string roomId, QueryMeetingRoomRequest request, QueryMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            roomId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roomId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMeetingRoomResponse>(await DoROARequestAsync("QueryMeetingRoom", "rooms_1.0", "HTTP", "GET", "AK", "/v1.0/rooms/meetingRooms/" + roomId, "json", req, runtime));
        }

        public QueryMeetingRoomGroupResponse QueryMeetingRoomGroup(string groupId, QueryMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupHeaders headers = new QueryMeetingRoomGroupHeaders();
            return QueryMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
        }

        public async Task<QueryMeetingRoomGroupResponse> QueryMeetingRoomGroupAsync(string groupId, QueryMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupHeaders headers = new QueryMeetingRoomGroupHeaders();
            return await QueryMeetingRoomGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        public QueryMeetingRoomGroupResponse QueryMeetingRoomGroupWithOptions(string groupId, QueryMeetingRoomGroupRequest request, QueryMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupResponse>(DoROARequest("QueryMeetingRoomGroup", "rooms_1.0", "HTTP", "GET", "AK", "/v1.0/rooms/groups/" + groupId, "json", req, runtime));
        }

        public async Task<QueryMeetingRoomGroupResponse> QueryMeetingRoomGroupWithOptionsAsync(string groupId, QueryMeetingRoomGroupRequest request, QueryMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            groupId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupResponse>(await DoROARequestAsync("QueryMeetingRoomGroup", "rooms_1.0", "HTTP", "GET", "AK", "/v1.0/rooms/groups/" + groupId, "json", req, runtime));
        }

        public QueryMeetingRoomGroupListResponse QueryMeetingRoomGroupList(QueryMeetingRoomGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupListHeaders headers = new QueryMeetingRoomGroupListHeaders();
            return QueryMeetingRoomGroupListWithOptions(request, headers, runtime);
        }

        public async Task<QueryMeetingRoomGroupListResponse> QueryMeetingRoomGroupListAsync(QueryMeetingRoomGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomGroupListHeaders headers = new QueryMeetingRoomGroupListHeaders();
            return await QueryMeetingRoomGroupListWithOptionsAsync(request, headers, runtime);
        }

        public QueryMeetingRoomGroupListResponse QueryMeetingRoomGroupListWithOptions(QueryMeetingRoomGroupListRequest request, QueryMeetingRoomGroupListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupListResponse>(DoROARequest("QueryMeetingRoomGroupList", "rooms_1.0", "HTTP", "GET", "AK", "/v1.0/rooms/groupLists", "json", req, runtime));
        }

        public async Task<QueryMeetingRoomGroupListResponse> QueryMeetingRoomGroupListWithOptionsAsync(QueryMeetingRoomGroupListRequest request, QueryMeetingRoomGroupListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupListResponse>(await DoROARequestAsync("QueryMeetingRoomGroupList", "rooms_1.0", "HTTP", "GET", "AK", "/v1.0/rooms/groupLists", "json", req, runtime));
        }

        public QueryMeetingRoomListResponse QueryMeetingRoomList(QueryMeetingRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomListHeaders headers = new QueryMeetingRoomListHeaders();
            return QueryMeetingRoomListWithOptions(request, headers, runtime);
        }

        public async Task<QueryMeetingRoomListResponse> QueryMeetingRoomListAsync(QueryMeetingRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomListHeaders headers = new QueryMeetingRoomListHeaders();
            return await QueryMeetingRoomListWithOptionsAsync(request, headers, runtime);
        }

        public QueryMeetingRoomListResponse QueryMeetingRoomListWithOptions(QueryMeetingRoomListRequest request, QueryMeetingRoomListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMeetingRoomListResponse>(DoROARequest("QueryMeetingRoomList", "rooms_1.0", "HTTP", "GET", "AK", "/v1.0/rooms/meetingRoomLists", "json", req, runtime));
        }

        public async Task<QueryMeetingRoomListResponse> QueryMeetingRoomListWithOptionsAsync(QueryMeetingRoomListRequest request, QueryMeetingRoomListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<QueryMeetingRoomListResponse>(await DoROARequestAsync("QueryMeetingRoomList", "rooms_1.0", "HTTP", "GET", "AK", "/v1.0/rooms/meetingRoomLists", "json", req, runtime));
        }

        public UpdateMeetingRoomResponse UpdateMeetingRoom(UpdateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomHeaders headers = new UpdateMeetingRoomHeaders();
            return UpdateMeetingRoomWithOptions(request, headers, runtime);
        }

        public async Task<UpdateMeetingRoomResponse> UpdateMeetingRoomAsync(UpdateMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomHeaders headers = new UpdateMeetingRoomHeaders();
            return await UpdateMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        public UpdateMeetingRoomResponse UpdateMeetingRoomWithOptions(UpdateMeetingRoomRequest request, UpdateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["isvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIds))
            {
                body["roomLabelIds"] = request.RoomLabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocation))
            {
                body["roomLocation"] = request.RoomLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["roomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["roomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["roomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateMeetingRoomResponse>(DoROARequest("UpdateMeetingRoom", "rooms_1.0", "HTTP", "PUT", "AK", "/v1.0/rooms/meetingRooms", "json", req, runtime));
        }

        public async Task<UpdateMeetingRoomResponse> UpdateMeetingRoomWithOptionsAsync(UpdateMeetingRoomRequest request, UpdateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvRoomId))
            {
                body["isvRoomId"] = request.IsvRoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomCapacity))
            {
                body["roomCapacity"] = request.RoomCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLabelIds))
            {
                body["roomLabelIds"] = request.RoomLabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomLocation))
            {
                body["roomLocation"] = request.RoomLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomName))
            {
                body["roomName"] = request.RoomName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomPicture))
            {
                body["roomPicture"] = request.RoomPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomStatus))
            {
                body["roomStatus"] = request.RoomStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateMeetingRoomResponse>(await DoROARequestAsync("UpdateMeetingRoom", "rooms_1.0", "HTTP", "PUT", "AK", "/v1.0/rooms/meetingRooms", "json", req, runtime));
        }

        public UpdateMeetingRoomGroupResponse UpdateMeetingRoomGroup(UpdateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomGroupHeaders headers = new UpdateMeetingRoomGroupHeaders();
            return UpdateMeetingRoomGroupWithOptions(request, headers, runtime);
        }

        public async Task<UpdateMeetingRoomGroupResponse> UpdateMeetingRoomGroupAsync(UpdateMeetingRoomGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMeetingRoomGroupHeaders headers = new UpdateMeetingRoomGroupHeaders();
            return await UpdateMeetingRoomGroupWithOptionsAsync(request, headers, runtime);
        }

        public UpdateMeetingRoomGroupResponse UpdateMeetingRoomGroupWithOptions(UpdateMeetingRoomGroupRequest request, UpdateMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateMeetingRoomGroupResponse>(DoROARequest("UpdateMeetingRoomGroup", "rooms_1.0", "HTTP", "PUT", "AK", "/v1.0/rooms/groups", "json", req, runtime));
        }

        public async Task<UpdateMeetingRoomGroupResponse> UpdateMeetingRoomGroupWithOptionsAsync(UpdateMeetingRoomGroupRequest request, UpdateMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateMeetingRoomGroupResponse>(await DoROARequestAsync("UpdateMeetingRoomGroup", "rooms_1.0", "HTTP", "PUT", "AK", "/v1.0/rooms/groups", "json", req, runtime));
        }

    }
}
