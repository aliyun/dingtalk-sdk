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
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public CreateMeetingRoomResponse CreateMeetingRoomWithOptions(CreateMeetingRoomRequest request, CreateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingrooms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateMeetingRoomResponse> CreateMeetingRoomWithOptionsAsync(CreateMeetingRoomRequest request, CreateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingrooms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomGroupResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMeetingRoomGroupResponse>(await ExecuteAsync(params_, req, runtime));
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

        public DeleteMeetingRoomResponse DeleteMeetingRoomWithOptions(string roomId, DeleteMeetingRoomRequest request, DeleteMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/" + roomId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteMeetingRoomResponse> DeleteMeetingRoomWithOptionsAsync(string roomId, DeleteMeetingRoomRequest request, DeleteMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/" + roomId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
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

        public DeleteMeetingRoomGroupResponse DeleteMeetingRoomGroupWithOptions(string groupId, DeleteMeetingRoomGroupRequest request, DeleteMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups/" + groupId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteMeetingRoomGroupResponse> DeleteMeetingRoomGroupWithOptionsAsync(string groupId, DeleteMeetingRoomGroupRequest request, DeleteMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups/" + groupId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMeetingRoomGroupResponse>(await ExecuteAsync(params_, req, runtime));
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

        public QueryDeviceIpByCodeResponse QueryDeviceIpByCodeWithOptions(string shareCode, QueryDeviceIpByCodeRequest request, QueryDeviceIpByCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceIpByCode",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/shareCodes/" + shareCode,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceIpByCodeResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryDeviceIpByCodeResponse> QueryDeviceIpByCodeWithOptionsAsync(string shareCode, QueryDeviceIpByCodeRequest request, QueryDeviceIpByCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceIpByCode",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/shareCodes/" + shareCode,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDeviceIpByCodeResponse>(await ExecuteAsync(params_, req, runtime));
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

        public QueryDevicePropertiesResponse QueryDevicePropertiesWithOptions(QueryDevicePropertiesRequest request, QueryDevicePropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionId))
            {
                query["deviceUnionId"] = request.DeviceUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                query["operatorUnionId"] = request.OperatorUnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyNames))
            {
                body["propertyNames"] = request.PropertyNames;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceProperties",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/properties/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePropertiesResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryDevicePropertiesResponse> QueryDevicePropertiesWithOptionsAsync(QueryDevicePropertiesRequest request, QueryDevicePropertiesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionId))
            {
                query["deviceUnionId"] = request.DeviceUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                query["operatorUnionId"] = request.OperatorUnionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyNames))
            {
                body["propertyNames"] = request.PropertyNames;
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeviceProperties",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices/properties/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDevicePropertiesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryDevicePropertiesResponse QueryDeviceProperties(QueryDevicePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDevicePropertiesHeaders headers = new QueryDevicePropertiesHeaders();
            return QueryDevicePropertiesWithOptions(request, headers, runtime);
        }

        public async Task<QueryDevicePropertiesResponse> QueryDevicePropertiesAsync(QueryDevicePropertiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDevicePropertiesHeaders headers = new QueryDevicePropertiesHeaders();
            return await QueryDevicePropertiesWithOptionsAsync(request, headers, runtime);
        }

        public QueryMeetingRoomResponse QueryMeetingRoomWithOptions(string roomId, QueryMeetingRoomRequest request, QueryMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/" + roomId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryMeetingRoomResponse> QueryMeetingRoomWithOptionsAsync(string roomId, QueryMeetingRoomRequest request, QueryMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/" + roomId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
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

        public QueryMeetingRoomDeviceResponse QueryMeetingRoomDeviceWithOptions(QueryMeetingRoomDeviceRequest request, QueryMeetingRoomDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionId))
            {
                query["deviceUnionId"] = request.DeviceUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                query["operatorUnionId"] = request.OperatorUnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomDevice",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomDeviceResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryMeetingRoomDeviceResponse> QueryMeetingRoomDeviceWithOptionsAsync(QueryMeetingRoomDeviceRequest request, QueryMeetingRoomDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUnionId))
            {
                query["deviceUnionId"] = request.DeviceUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                query["operatorUnionId"] = request.OperatorUnionId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomDevice",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/devices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryMeetingRoomDeviceResponse QueryMeetingRoomDevice(QueryMeetingRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomDeviceHeaders headers = new QueryMeetingRoomDeviceHeaders();
            return QueryMeetingRoomDeviceWithOptions(request, headers, runtime);
        }

        public async Task<QueryMeetingRoomDeviceResponse> QueryMeetingRoomDeviceAsync(QueryMeetingRoomDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMeetingRoomDeviceHeaders headers = new QueryMeetingRoomDeviceHeaders();
            return await QueryMeetingRoomDeviceWithOptionsAsync(request, headers, runtime);
        }

        public QueryMeetingRoomGroupResponse QueryMeetingRoomGroupWithOptions(string groupId, QueryMeetingRoomGroupRequest request, QueryMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups/" + groupId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryMeetingRoomGroupResponse> QueryMeetingRoomGroupWithOptionsAsync(string groupId, QueryMeetingRoomGroupRequest request, QueryMeetingRoomGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups/" + groupId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupResponse>(await ExecuteAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroupList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groupLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupListResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomGroupList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groupLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomGroupListResponse>(await ExecuteAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRoomLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomListResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMeetingRoomList",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRoomLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMeetingRoomListResponse>(await ExecuteAsync(params_, req, runtime));
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

        public RemoveSuperUserMeetingRoomResponse RemoveSuperUserMeetingRoomWithOptions(RemoveSuperUserMeetingRoomRequest request, RemoveSuperUserMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                query["roomId"] = request.RoomId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSuperUserMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/superUsers/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSuperUserMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        public async Task<RemoveSuperUserMeetingRoomResponse> RemoveSuperUserMeetingRoomWithOptionsAsync(RemoveSuperUserMeetingRoomRequest request, RemoveSuperUserMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                query["roomId"] = request.RoomId;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveSuperUserMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/superUsers/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveSuperUserMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public RemoveSuperUserMeetingRoomResponse RemoveSuperUserMeetingRoom(RemoveSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveSuperUserMeetingRoomHeaders headers = new RemoveSuperUserMeetingRoomHeaders();
            return RemoveSuperUserMeetingRoomWithOptions(request, headers, runtime);
        }

        public async Task<RemoveSuperUserMeetingRoomResponse> RemoveSuperUserMeetingRoomAsync(RemoveSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveSuperUserMeetingRoomHeaders headers = new RemoveSuperUserMeetingRoomHeaders();
            return await RemoveSuperUserMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        public SetSuperUserMeetingRoomResponse SetSuperUserMeetingRoomWithOptions(SetSuperUserMeetingRoomRequest request, SetSuperUserMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdWhiteList))
            {
                body["deptIdWhiteList"] = request.DeptIdWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdWhiteList))
            {
                body["userIdWhiteList"] = request.UserIdWhiteList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSuperUserMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/superUsers/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSuperUserMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        public async Task<SetSuperUserMeetingRoomResponse> SetSuperUserMeetingRoomWithOptionsAsync(SetSuperUserMeetingRoomRequest request, SetSuperUserMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIdWhiteList))
            {
                body["deptIdWhiteList"] = request.DeptIdWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoomId))
            {
                body["roomId"] = request.RoomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdWhiteList))
            {
                body["userIdWhiteList"] = request.UserIdWhiteList;
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSuperUserMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms/superUsers/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSuperUserMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SetSuperUserMeetingRoomResponse SetSuperUserMeetingRoom(SetSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetSuperUserMeetingRoomHeaders headers = new SetSuperUserMeetingRoomHeaders();
            return SetSuperUserMeetingRoomWithOptions(request, headers, runtime);
        }

        public async Task<SetSuperUserMeetingRoomResponse> SetSuperUserMeetingRoomAsync(SetSuperUserMeetingRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetSuperUserMeetingRoomHeaders headers = new SetSuperUserMeetingRoomHeaders();
            return await SetSuperUserMeetingRoomWithOptionsAsync(request, headers, runtime);
        }

        public UpdateMeetingRoomResponse UpdateMeetingRoomWithOptions(UpdateMeetingRoomRequest request, UpdateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateMeetingRoomResponse> UpdateMeetingRoomWithOptionsAsync(UpdateMeetingRoomRequest request, UpdateMeetingRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoom",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/meetingRooms",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomResponse>(await ExecuteAsync(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomGroupResponse>(Execute(params_, req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMeetingRoomGroup",
                Version = "rooms_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rooms/groups",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMeetingRoomGroupResponse>(await ExecuteAsync(params_, req, runtime));
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

    }
}
