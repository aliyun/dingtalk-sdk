// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 批量注册设备
         *
         * @param request BatchRegisterDeviceRequest
         * @param headers BatchRegisterDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRegisterDeviceResponse
         */
        public BatchRegisterDeviceResponse BatchRegisterDeviceWithOptions(BatchRegisterDeviceRequest request, BatchRegisterDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceList))
            {
                body["deviceList"] = request.DeviceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "BatchRegisterDevice",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/devices/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRegisterDeviceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量注册设备
         *
         * @param request BatchRegisterDeviceRequest
         * @param headers BatchRegisterDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchRegisterDeviceResponse
         */
        public async Task<BatchRegisterDeviceResponse> BatchRegisterDeviceWithOptionsAsync(BatchRegisterDeviceRequest request, BatchRegisterDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceList))
            {
                body["deviceList"] = request.DeviceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "BatchRegisterDevice",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/devices/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRegisterDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量注册设备
         *
         * @param request BatchRegisterDeviceRequest
         * @return BatchRegisterDeviceResponse
         */
        public BatchRegisterDeviceResponse BatchRegisterDevice(BatchRegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRegisterDeviceHeaders headers = new BatchRegisterDeviceHeaders();
            return BatchRegisterDeviceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量注册设备
         *
         * @param request BatchRegisterDeviceRequest
         * @return BatchRegisterDeviceResponse
         */
        public async Task<BatchRegisterDeviceResponse> BatchRegisterDeviceAsync(BatchRegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRegisterDeviceHeaders headers = new BatchRegisterDeviceHeaders();
            return await BatchRegisterDeviceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 想设备上钉连接器推送设备事件
         *
         * @param request ConnectorEventPushRequest
         * @param headers ConnectorEventPushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConnectorEventPushResponse
         */
        public ConnectorEventPushResponse ConnectorEventPushWithOptions(ConnectorEventPushRequest request, ConnectorEventPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTypeUuid))
            {
                body["deviceTypeUuid"] = request.DeviceTypeUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["eventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
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
                Action = "ConnectorEventPush",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/connectors/events/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConnectorEventPushResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 想设备上钉连接器推送设备事件
         *
         * @param request ConnectorEventPushRequest
         * @param headers ConnectorEventPushHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConnectorEventPushResponse
         */
        public async Task<ConnectorEventPushResponse> ConnectorEventPushWithOptionsAsync(ConnectorEventPushRequest request, ConnectorEventPushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTypeUuid))
            {
                body["deviceTypeUuid"] = request.DeviceTypeUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["eventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Input))
            {
                body["input"] = request.Input;
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
                Action = "ConnectorEventPush",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/connectors/events/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConnectorEventPushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 想设备上钉连接器推送设备事件
         *
         * @param request ConnectorEventPushRequest
         * @return ConnectorEventPushResponse
         */
        public ConnectorEventPushResponse ConnectorEventPush(ConnectorEventPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConnectorEventPushHeaders headers = new ConnectorEventPushHeaders();
            return ConnectorEventPushWithOptions(request, headers, runtime);
        }

        /**
         * @summary 想设备上钉连接器推送设备事件
         *
         * @param request ConnectorEventPushRequest
         * @return ConnectorEventPushResponse
         */
        public async Task<ConnectorEventPushResponse> ConnectorEventPushAsync(ConnectorEventPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConnectorEventPushHeaders headers = new ConnectorEventPushHeaders();
            return await ConnectorEventPushWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建设备群
         *
         * @param request CreateChatRoomRequest
         * @param headers CreateChatRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateChatRoomResponse
         */
        public CreateChatRoomResponse CreateChatRoomWithOptions(CreateChatRoomRequest request, CreateChatRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatGroupName))
            {
                body["chatGroupName"] = request.ChatGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCodes))
            {
                body["deviceCodes"] = request.DeviceCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTypeId))
            {
                body["deviceTypeId"] = request.DeviceTypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                body["ownerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleList))
            {
                body["roleList"] = request.RoleList;
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
                Action = "CreateChatRoom",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatRoomResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建设备群
         *
         * @param request CreateChatRoomRequest
         * @param headers CreateChatRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateChatRoomResponse
         */
        public async Task<CreateChatRoomResponse> CreateChatRoomWithOptionsAsync(CreateChatRoomRequest request, CreateChatRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatGroupName))
            {
                body["chatGroupName"] = request.ChatGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCodes))
            {
                body["deviceCodes"] = request.DeviceCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTypeId))
            {
                body["deviceTypeId"] = request.DeviceTypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                body["ownerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleList))
            {
                body["roleList"] = request.RoleList;
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
                Action = "CreateChatRoom",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRoom",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatRoomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建设备群
         *
         * @param request CreateChatRoomRequest
         * @return CreateChatRoomResponse
         */
        public CreateChatRoomResponse CreateChatRoom(CreateChatRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateChatRoomHeaders headers = new CreateChatRoomHeaders();
            return CreateChatRoomWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建设备群
         *
         * @param request CreateChatRoomRequest
         * @return CreateChatRoomResponse
         */
        public async Task<CreateChatRoomResponse> CreateChatRoomAsync(CreateChatRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateChatRoomHeaders headers = new CreateChatRoomHeaders();
            return await CreateChatRoomWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建部门
         *
         * @param request CreateDepartmentRequest
         * @param headers CreateDepartmentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDepartmentResponse
         */
        public CreateDepartmentResponse CreateDepartmentWithOptions(CreateDepartmentRequest request, CreateDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthInfo))
            {
                body["authInfo"] = request.AuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                body["authType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizExt))
            {
                body["bizExt"] = request.BizExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                body["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentType))
            {
                body["departmentType"] = request.DepartmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemUrl))
            {
                body["systemUrl"] = request.SystemUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "CreateDepartment",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/departments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDepartmentResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建部门
         *
         * @param request CreateDepartmentRequest
         * @param headers CreateDepartmentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDepartmentResponse
         */
        public async Task<CreateDepartmentResponse> CreateDepartmentWithOptionsAsync(CreateDepartmentRequest request, CreateDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthInfo))
            {
                body["authInfo"] = request.AuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                body["authType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizExt))
            {
                body["bizExt"] = request.BizExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                body["departmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentType))
            {
                body["departmentType"] = request.DepartmentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemUrl))
            {
                body["systemUrl"] = request.SystemUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "CreateDepartment",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/departments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDepartmentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建部门
         *
         * @param request CreateDepartmentRequest
         * @return CreateDepartmentResponse
         */
        public CreateDepartmentResponse CreateDepartment(CreateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDepartmentHeaders headers = new CreateDepartmentHeaders();
            return CreateDepartmentWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建部门
         *
         * @param request CreateDepartmentRequest
         * @return CreateDepartmentResponse
         */
        public async Task<CreateDepartmentResponse> CreateDepartmentAsync(CreateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDepartmentHeaders headers = new CreateDepartmentHeaders();
            return await CreateDepartmentWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建设备场景群
         *
         * @param request CreateDeviceChatRoomRequest
         * @param headers CreateDeviceChatRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeviceChatRoomResponse
         */
        public CreateDeviceChatRoomResponse CreateDeviceChatRoomWithOptions(CreateDeviceChatRoomRequest request, CreateDeviceChatRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatType))
            {
                body["chatType"] = request.ChatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCodes))
            {
                body["deviceCodes"] = request.DeviceCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuids))
            {
                body["deviceUuids"] = request.DeviceUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                body["ownerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "CreateDeviceChatRoom",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeviceChatRoomResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建设备场景群
         *
         * @param request CreateDeviceChatRoomRequest
         * @param headers CreateDeviceChatRoomHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeviceChatRoomResponse
         */
        public async Task<CreateDeviceChatRoomResponse> CreateDeviceChatRoomWithOptionsAsync(CreateDeviceChatRoomRequest request, CreateDeviceChatRoomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatType))
            {
                body["chatType"] = request.ChatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCodes))
            {
                body["deviceCodes"] = request.DeviceCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuids))
            {
                body["deviceUuids"] = request.DeviceUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUserId))
            {
                body["ownerUserId"] = request.OwnerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "CreateDeviceChatRoom",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeviceChatRoomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建设备场景群
         *
         * @param request CreateDeviceChatRoomRequest
         * @return CreateDeviceChatRoomResponse
         */
        public CreateDeviceChatRoomResponse CreateDeviceChatRoom(CreateDeviceChatRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceChatRoomHeaders headers = new CreateDeviceChatRoomHeaders();
            return CreateDeviceChatRoomWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建设备场景群
         *
         * @param request CreateDeviceChatRoomRequest
         * @return CreateDeviceChatRoomResponse
         */
        public async Task<CreateDeviceChatRoomResponse> CreateDeviceChatRoomAsync(CreateDeviceChatRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceChatRoomHeaders headers = new CreateDeviceChatRoomHeaders();
            return await CreateDeviceChatRoomWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设备账号向目标用户发送ding消息
         *
         * @param request DeviceDingRequest
         * @param headers DeviceDingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeviceDingResponse
         */
        public DeviceDingResponse DeviceDingWithOptions(DeviceDingRequest request, DeviceDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceKey))
            {
                body["deviceKey"] = request.DeviceKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                body["paramsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
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
                Action = "DeviceDing",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/ding",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceDingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设备账号向目标用户发送ding消息
         *
         * @param request DeviceDingRequest
         * @param headers DeviceDingHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeviceDingResponse
         */
        public async Task<DeviceDingResponse> DeviceDingWithOptionsAsync(DeviceDingRequest request, DeviceDingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceKey))
            {
                body["deviceKey"] = request.DeviceKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsJson))
            {
                body["paramsJson"] = request.ParamsJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
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
                Action = "DeviceDing",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/ding",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeviceDingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设备账号向目标用户发送ding消息
         *
         * @param request DeviceDingRequest
         * @return DeviceDingResponse
         */
        public DeviceDingResponse DeviceDing(DeviceDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeviceDingHeaders headers = new DeviceDingHeaders();
            return DeviceDingWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设备账号向目标用户发送ding消息
         *
         * @param request DeviceDingRequest
         * @return DeviceDingResponse
         */
        public async Task<DeviceDingResponse> DeviceDingAsync(DeviceDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeviceDingHeaders headers = new DeviceDingHeaders();
            return await DeviceDingWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 解散设备群
         *
         * @param request DissolveGroupRequest
         * @param headers DissolveGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DissolveGroupResponse
         */
        public DissolveGroupResponse DissolveGroupWithOptions(DissolveGroupRequest request, DissolveGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "DissolveGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/groups/dissolve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissolveGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 解散设备群
         *
         * @param request DissolveGroupRequest
         * @param headers DissolveGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DissolveGroupResponse
         */
        public async Task<DissolveGroupResponse> DissolveGroupWithOptionsAsync(DissolveGroupRequest request, DissolveGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "DissolveGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/groups/dissolve",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissolveGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 解散设备群
         *
         * @param request DissolveGroupRequest
         * @return DissolveGroupResponse
         */
        public DissolveGroupResponse DissolveGroup(DissolveGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DissolveGroupHeaders headers = new DissolveGroupHeaders();
            return DissolveGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 解散设备群
         *
         * @param request DissolveGroupRequest
         * @return DissolveGroupResponse
         */
        public async Task<DissolveGroupResponse> DissolveGroupAsync(DissolveGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DissolveGroupHeaders headers = new DissolveGroupHeaders();
            return await DissolveGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 编辑设备管理员
         *
         * @param request EditDeviceAdminRequest
         * @param headers EditDeviceAdminHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EditDeviceAdminResponse
         */
        public EditDeviceAdminResponse EditDeviceAdminWithOptions(EditDeviceAdminRequest request, EditDeviceAdminHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleUuid))
            {
                body["roleUuid"] = request.RoleUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "EditDeviceAdmin",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/administrators/edit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditDeviceAdminResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 编辑设备管理员
         *
         * @param request EditDeviceAdminRequest
         * @param headers EditDeviceAdminHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return EditDeviceAdminResponse
         */
        public async Task<EditDeviceAdminResponse> EditDeviceAdminWithOptionsAsync(EditDeviceAdminRequest request, EditDeviceAdminHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleUuid))
            {
                body["roleUuid"] = request.RoleUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "EditDeviceAdmin",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/administrators/edit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditDeviceAdminResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 编辑设备管理员
         *
         * @param request EditDeviceAdminRequest
         * @return EditDeviceAdminResponse
         */
        public EditDeviceAdminResponse EditDeviceAdmin(EditDeviceAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditDeviceAdminHeaders headers = new EditDeviceAdminHeaders();
            return EditDeviceAdminWithOptions(request, headers, runtime);
        }

        /**
         * @summary 编辑设备管理员
         *
         * @param request EditDeviceAdminRequest
         * @return EditDeviceAdminResponse
         */
        public async Task<EditDeviceAdminResponse> EditDeviceAdminAsync(EditDeviceAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditDeviceAdminHeaders headers = new EditDeviceAdminHeaders();
            return await EditDeviceAdminWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取设备群信息
         *
         * @param request GetDeviceGroupInfoRequest
         * @param headers GetDeviceGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceGroupInfoResponse
         */
        public GetDeviceGroupInfoResponse GetDeviceGroupInfoWithOptions(GetDeviceGroupInfoRequest request, GetDeviceGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "GetDeviceGroupInfo",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/groupInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceGroupInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取设备群信息
         *
         * @param request GetDeviceGroupInfoRequest
         * @param headers GetDeviceGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceGroupInfoResponse
         */
        public async Task<GetDeviceGroupInfoResponse> GetDeviceGroupInfoWithOptionsAsync(GetDeviceGroupInfoRequest request, GetDeviceGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "GetDeviceGroupInfo",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/groupInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceGroupInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取设备群信息
         *
         * @param request GetDeviceGroupInfoRequest
         * @return GetDeviceGroupInfoResponse
         */
        public GetDeviceGroupInfoResponse GetDeviceGroupInfo(GetDeviceGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceGroupInfoHeaders headers = new GetDeviceGroupInfoHeaders();
            return GetDeviceGroupInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取设备群信息
         *
         * @param request GetDeviceGroupInfoRequest
         * @return GetDeviceGroupInfoResponse
         */
        public async Task<GetDeviceGroupInfoResponse> GetDeviceGroupInfoAsync(GetDeviceGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceGroupInfoHeaders headers = new GetDeviceGroupInfoHeaders();
            return await GetDeviceGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取设备全员群标识
         *
         * @param headers GetWholeDeviceGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWholeDeviceGroupResponse
         */
        public GetWholeDeviceGroupResponse GetWholeDeviceGroupWithOptions(GetWholeDeviceGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWholeDeviceGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/wholeGroupId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWholeDeviceGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取设备全员群标识
         *
         * @param headers GetWholeDeviceGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWholeDeviceGroupResponse
         */
        public async Task<GetWholeDeviceGroupResponse> GetWholeDeviceGroupWithOptionsAsync(GetWholeDeviceGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWholeDeviceGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/wholeGroupId",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWholeDeviceGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取设备全员群标识
         *
         * @return GetWholeDeviceGroupResponse
         */
        public GetWholeDeviceGroupResponse GetWholeDeviceGroup()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWholeDeviceGroupHeaders headers = new GetWholeDeviceGroupHeaders();
            return GetWholeDeviceGroupWithOptions(headers, runtime);
        }

        /**
         * @summary 获取设备全员群标识
         *
         * @return GetWholeDeviceGroupResponse
         */
        public async Task<GetWholeDeviceGroupResponse> GetWholeDeviceGroupAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWholeDeviceGroupHeaders headers = new GetWholeDeviceGroupHeaders();
            return await GetWholeDeviceGroupWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询激活的设备信息
         *
         * @param request ListActivateDevicesRequest
         * @param headers ListActivateDevicesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListActivateDevicesResponse
         */
        public ListActivateDevicesResponse ListActivateDevicesWithOptions(ListActivateDevicesRequest request, ListActivateDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCategory))
            {
                query["deviceCategory"] = request.DeviceCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                query["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTypeId))
            {
                query["deviceTypeId"] = request.DeviceTypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListActivateDevices",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/activations/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListActivateDevicesResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询激活的设备信息
         *
         * @param request ListActivateDevicesRequest
         * @param headers ListActivateDevicesHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListActivateDevicesResponse
         */
        public async Task<ListActivateDevicesResponse> ListActivateDevicesWithOptionsAsync(ListActivateDevicesRequest request, ListActivateDevicesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCategory))
            {
                query["deviceCategory"] = request.DeviceCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                query["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTypeId))
            {
                query["deviceTypeId"] = request.DeviceTypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ListActivateDevices",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/activations/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListActivateDevicesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询激活的设备信息
         *
         * @param request ListActivateDevicesRequest
         * @return ListActivateDevicesResponse
         */
        public ListActivateDevicesResponse ListActivateDevices(ListActivateDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListActivateDevicesHeaders headers = new ListActivateDevicesHeaders();
            return ListActivateDevicesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询激活的设备信息
         *
         * @param request ListActivateDevicesRequest
         * @return ListActivateDevicesResponse
         */
        public async Task<ListActivateDevicesResponse> ListActivateDevicesAsync(ListActivateDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListActivateDevicesHeaders headers = new ListActivateDevicesHeaders();
            return await ListActivateDevicesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取巡检、保养记录
         *
         * @param request ListInspectInfoRequest
         * @param headers ListInspectInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInspectInfoResponse
         */
        public ListInspectInfoResponse ListInspectInfoWithOptions(ListInspectInfoRequest request, ListInspectInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuid))
            {
                body["deviceUuid"] = request.DeviceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "ListInspectInfo",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/inspectInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInspectInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取巡检、保养记录
         *
         * @param request ListInspectInfoRequest
         * @param headers ListInspectInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInspectInfoResponse
         */
        public async Task<ListInspectInfoResponse> ListInspectInfoWithOptionsAsync(ListInspectInfoRequest request, ListInspectInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuid))
            {
                body["deviceUuid"] = request.DeviceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "ListInspectInfo",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/inspectInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInspectInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取巡检、保养记录
         *
         * @param request ListInspectInfoRequest
         * @return ListInspectInfoResponse
         */
        public ListInspectInfoResponse ListInspectInfo(ListInspectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInspectInfoHeaders headers = new ListInspectInfoHeaders();
            return ListInspectInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取巡检、保养记录
         *
         * @param request ListInspectInfoRequest
         * @return ListInspectInfoResponse
         */
        public async Task<ListInspectInfoResponse> ListInspectInfoAsync(ListInspectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInspectInfoHeaders headers = new ListInspectInfoHeaders();
            return await ListInspectInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取报修信息
         *
         * @param request ListMaintainInfoRequest
         * @param headers ListMaintainInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMaintainInfoResponse
         */
        public ListMaintainInfoResponse ListMaintainInfoWithOptions(ListMaintainInfoRequest request, ListMaintainInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuid))
            {
                body["deviceUuid"] = request.DeviceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "ListMaintainInfo",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/maintainInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMaintainInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取报修信息
         *
         * @param request ListMaintainInfoRequest
         * @param headers ListMaintainInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMaintainInfoResponse
         */
        public async Task<ListMaintainInfoResponse> ListMaintainInfoWithOptionsAsync(ListMaintainInfoRequest request, ListMaintainInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuid))
            {
                body["deviceUuid"] = request.DeviceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
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
                Action = "ListMaintainInfo",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/maintainInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMaintainInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取报修信息
         *
         * @param request ListMaintainInfoRequest
         * @return ListMaintainInfoResponse
         */
        public ListMaintainInfoResponse ListMaintainInfo(ListMaintainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMaintainInfoHeaders headers = new ListMaintainInfoHeaders();
            return ListMaintainInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取报修信息
         *
         * @param request ListMaintainInfoRequest
         * @return ListMaintainInfoResponse
         */
        public async Task<ListMaintainInfoResponse> ListMaintainInfoAsync(ListMaintainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMaintainInfoHeaders headers = new ListMaintainInfoHeaders();
            return await ListMaintainInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 拉设备进群
         *
         * @param request PullDeviceToGroupRequest
         * @param headers PullDeviceToGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PullDeviceToGroupResponse
         */
        public PullDeviceToGroupResponse PullDeviceToGroupWithOptions(PullDeviceToGroupRequest request, PullDeviceToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCodes))
            {
                body["deviceCodes"] = request.DeviceCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuids))
            {
                body["deviceUuids"] = request.DeviceUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
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
                Action = "PullDeviceToGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/devices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullDeviceToGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 拉设备进群
         *
         * @param request PullDeviceToGroupRequest
         * @param headers PullDeviceToGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PullDeviceToGroupResponse
         */
        public async Task<PullDeviceToGroupResponse> PullDeviceToGroupWithOptionsAsync(PullDeviceToGroupRequest request, PullDeviceToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCodes))
            {
                body["deviceCodes"] = request.DeviceCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuids))
            {
                body["deviceUuids"] = request.DeviceUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
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
                Action = "PullDeviceToGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/devices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullDeviceToGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 拉设备进群
         *
         * @param request PullDeviceToGroupRequest
         * @return PullDeviceToGroupResponse
         */
        public PullDeviceToGroupResponse PullDeviceToGroup(PullDeviceToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDeviceToGroupHeaders headers = new PullDeviceToGroupHeaders();
            return PullDeviceToGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 拉设备进群
         *
         * @param request PullDeviceToGroupRequest
         * @return PullDeviceToGroupResponse
         */
        public async Task<PullDeviceToGroupResponse> PullDeviceToGroupAsync(PullDeviceToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDeviceToGroupHeaders headers = new PullDeviceToGroupHeaders();
            return await PullDeviceToGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 拉设用户进群
         *
         * @param request PullUserToGroupRequest
         * @param headers PullUserToGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PullUserToGroupResponse
         */
        public PullUserToGroupResponse PullUserToGroupWithOptions(PullUserToGroupRequest request, PullUserToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "PullUserToGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullUserToGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 拉设用户进群
         *
         * @param request PullUserToGroupRequest
         * @param headers PullUserToGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PullUserToGroupResponse
         */
        public async Task<PullUserToGroupResponse> PullUserToGroupWithOptionsAsync(PullUserToGroupRequest request, PullUserToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "PullUserToGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullUserToGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 拉设用户进群
         *
         * @param request PullUserToGroupRequest
         * @return PullUserToGroupResponse
         */
        public PullUserToGroupResponse PullUserToGroup(PullUserToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullUserToGroupHeaders headers = new PullUserToGroupHeaders();
            return PullUserToGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 拉设用户进群
         *
         * @param request PullUserToGroupRequest
         * @return PullUserToGroupResponse
         */
        public async Task<PullUserToGroupResponse> PullUserToGroupAsync(PullUserToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullUserToGroupHeaders headers = new PullUserToGroupHeaders();
            return await PullUserToGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 注册与激活设备
         *
         * @param request RegisterAndActivateDeviceRequest
         * @param headers RegisterAndActivateDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterAndActivateDeviceResponse
         */
        public RegisterAndActivateDeviceResponse RegisterAndActivateDeviceWithOptions(RegisterAndActivateDeviceRequest request, RegisterAndActivateDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCallbackUrl))
            {
                body["deviceCallbackUrl"] = request.DeviceCallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCategory))
            {
                body["deviceCategory"] = request.DeviceCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceDetailUrl))
            {
                body["deviceDetailUrl"] = request.DeviceDetailUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                body["introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleUuid))
            {
                body["roleUuid"] = request.RoleUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeUuid))
            {
                body["typeUuid"] = request.TypeUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "RegisterAndActivateDevice",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/registerAndActivate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterAndActivateDeviceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 注册与激活设备
         *
         * @param request RegisterAndActivateDeviceRequest
         * @param headers RegisterAndActivateDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterAndActivateDeviceResponse
         */
        public async Task<RegisterAndActivateDeviceResponse> RegisterAndActivateDeviceWithOptionsAsync(RegisterAndActivateDeviceRequest request, RegisterAndActivateDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCallbackUrl))
            {
                body["deviceCallbackUrl"] = request.DeviceCallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCategory))
            {
                body["deviceCategory"] = request.DeviceCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceDetailUrl))
            {
                body["deviceDetailUrl"] = request.DeviceDetailUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Introduction))
            {
                body["introduction"] = request.Introduction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleUuid))
            {
                body["roleUuid"] = request.RoleUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeUuid))
            {
                body["typeUuid"] = request.TypeUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "RegisterAndActivateDevice",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/registerAndActivate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterAndActivateDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 注册与激活设备
         *
         * @param request RegisterAndActivateDeviceRequest
         * @return RegisterAndActivateDeviceResponse
         */
        public RegisterAndActivateDeviceResponse RegisterAndActivateDevice(RegisterAndActivateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterAndActivateDeviceHeaders headers = new RegisterAndActivateDeviceHeaders();
            return RegisterAndActivateDeviceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 注册与激活设备
         *
         * @param request RegisterAndActivateDeviceRequest
         * @return RegisterAndActivateDeviceResponse
         */
        public async Task<RegisterAndActivateDeviceResponse> RegisterAndActivateDeviceAsync(RegisterAndActivateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterAndActivateDeviceHeaders headers = new RegisterAndActivateDeviceHeaders();
            return await RegisterAndActivateDeviceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量注册与激活设备
         *
         * @param request RegisterAndActivateDeviceBatchRequest
         * @param headers RegisterAndActivateDeviceBatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterAndActivateDeviceBatchResponse
         */
        public RegisterAndActivateDeviceBatchResponse RegisterAndActivateDeviceBatchWithOptions(RegisterAndActivateDeviceBatchRequest request, RegisterAndActivateDeviceBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterAndActivateVOS))
            {
                body["registerAndActivateVOS"] = request.RegisterAndActivateVOS;
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
                Action = "RegisterAndActivateDeviceBatch",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/registrationActivations/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterAndActivateDeviceBatchResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量注册与激活设备
         *
         * @param request RegisterAndActivateDeviceBatchRequest
         * @param headers RegisterAndActivateDeviceBatchHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterAndActivateDeviceBatchResponse
         */
        public async Task<RegisterAndActivateDeviceBatchResponse> RegisterAndActivateDeviceBatchWithOptionsAsync(RegisterAndActivateDeviceBatchRequest request, RegisterAndActivateDeviceBatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterAndActivateVOS))
            {
                body["registerAndActivateVOS"] = request.RegisterAndActivateVOS;
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
                Action = "RegisterAndActivateDeviceBatch",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/registrationActivations/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterAndActivateDeviceBatchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量注册与激活设备
         *
         * @param request RegisterAndActivateDeviceBatchRequest
         * @return RegisterAndActivateDeviceBatchResponse
         */
        public RegisterAndActivateDeviceBatchResponse RegisterAndActivateDeviceBatch(RegisterAndActivateDeviceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterAndActivateDeviceBatchHeaders headers = new RegisterAndActivateDeviceBatchHeaders();
            return RegisterAndActivateDeviceBatchWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量注册与激活设备
         *
         * @param request RegisterAndActivateDeviceBatchRequest
         * @return RegisterAndActivateDeviceBatchResponse
         */
        public async Task<RegisterAndActivateDeviceBatchResponse> RegisterAndActivateDeviceBatchAsync(RegisterAndActivateDeviceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterAndActivateDeviceBatchHeaders headers = new RegisterAndActivateDeviceBatchHeaders();
            return await RegisterAndActivateDeviceBatchWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 注册设备并为其创建机器人
         *
         * @param request RegisterDeviceRequest
         * @param headers RegisterDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterDeviceResponse
         */
        public RegisterDeviceResponse RegisterDeviceWithOptions(RegisterDeviceRequest request, RegisterDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Collaborators))
            {
                body["collaborators"] = request.Collaborators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                body["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceKey))
            {
                body["deviceKey"] = request.DeviceKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Managers))
            {
                body["managers"] = request.Managers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "RegisterDevice",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/devices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 注册设备并为其创建机器人
         *
         * @param request RegisterDeviceRequest
         * @param headers RegisterDeviceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterDeviceResponse
         */
        public async Task<RegisterDeviceResponse> RegisterDeviceWithOptionsAsync(RegisterDeviceRequest request, RegisterDeviceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Collaborators))
            {
                body["collaborators"] = request.Collaborators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                body["departmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceKey))
            {
                body["deviceKey"] = request.DeviceKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                body["deviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Managers))
            {
                body["managers"] = request.Managers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "RegisterDevice",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/devices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 注册设备并为其创建机器人
         *
         * @param request RegisterDeviceRequest
         * @return RegisterDeviceResponse
         */
        public RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterDeviceHeaders headers = new RegisterDeviceHeaders();
            return RegisterDeviceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 注册设备并为其创建机器人
         *
         * @param request RegisterDeviceRequest
         * @return RegisterDeviceResponse
         */
        public async Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterDeviceHeaders headers = new RegisterDeviceHeaders();
            return await RegisterDeviceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 移设备出群
         *
         * @param request RemoveDeviceFromGroupRequest
         * @param headers RemoveDeviceFromGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveDeviceFromGroupResponse
         */
        public RemoveDeviceFromGroupResponse RemoveDeviceFromGroupWithOptions(RemoveDeviceFromGroupRequest request, RemoveDeviceFromGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCodes))
            {
                body["deviceCodes"] = request.DeviceCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuids))
            {
                body["deviceUuids"] = request.DeviceUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
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
                Action = "RemoveDeviceFromGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/devices/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDeviceFromGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 移设备出群
         *
         * @param request RemoveDeviceFromGroupRequest
         * @param headers RemoveDeviceFromGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveDeviceFromGroupResponse
         */
        public async Task<RemoveDeviceFromGroupResponse> RemoveDeviceFromGroupWithOptionsAsync(RemoveDeviceFromGroupRequest request, RemoveDeviceFromGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCodes))
            {
                body["deviceCodes"] = request.DeviceCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuids))
            {
                body["deviceUuids"] = request.DeviceUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
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
                Action = "RemoveDeviceFromGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/devices/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveDeviceFromGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 移设备出群
         *
         * @param request RemoveDeviceFromGroupRequest
         * @return RemoveDeviceFromGroupResponse
         */
        public RemoveDeviceFromGroupResponse RemoveDeviceFromGroup(RemoveDeviceFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveDeviceFromGroupHeaders headers = new RemoveDeviceFromGroupHeaders();
            return RemoveDeviceFromGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 移设备出群
         *
         * @param request RemoveDeviceFromGroupRequest
         * @return RemoveDeviceFromGroupResponse
         */
        public async Task<RemoveDeviceFromGroupResponse> RemoveDeviceFromGroupAsync(RemoveDeviceFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveDeviceFromGroupHeaders headers = new RemoveDeviceFromGroupHeaders();
            return await RemoveDeviceFromGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 移用户出设备群
         *
         * @param request RemoveUserFromGroupRequest
         * @param headers RemoveUserFromGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUserFromGroupResponse
         */
        public RemoveUserFromGroupResponse RemoveUserFromGroupWithOptions(RemoveUserFromGroupRequest request, RemoveUserFromGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "RemoveUserFromGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/users/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserFromGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 移用户出设备群
         *
         * @param request RemoveUserFromGroupRequest
         * @param headers RemoveUserFromGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveUserFromGroupResponse
         */
        public async Task<RemoveUserFromGroupResponse> RemoveUserFromGroupWithOptionsAsync(RemoveUserFromGroupRequest request, RemoveUserFromGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "RemoveUserFromGroup",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/chatRooms/users/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveUserFromGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 移用户出设备群
         *
         * @param request RemoveUserFromGroupRequest
         * @return RemoveUserFromGroupResponse
         */
        public RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveUserFromGroupHeaders headers = new RemoveUserFromGroupHeaders();
            return RemoveUserFromGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 移用户出设备群
         *
         * @param request RemoveUserFromGroupRequest
         * @return RemoveUserFromGroupResponse
         */
        public async Task<RemoveUserFromGroupResponse> RemoveUserFromGroupAsync(RemoveUserFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveUserFromGroupHeaders headers = new RemoveUserFromGroupHeaders();
            return await RemoveUserFromGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送卡片
         *
         * @param request SendCardRequest
         * @param headers SendCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendCardResponse
         */
        public SendCardResponse SendCardWithOptions(SendCardRequest request, SendCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuid))
            {
                body["deviceUuid"] = request.DeviceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartVisible))
            {
                body["partVisible"] = request.PartVisible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receivers))
            {
                body["receivers"] = request.Receivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topbox))
            {
                body["topbox"] = request.Topbox;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "SendCard",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/cards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送卡片
         *
         * @param request SendCardRequest
         * @param headers SendCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendCardResponse
         */
        public async Task<SendCardResponse> SendCardWithOptionsAsync(SendCardRequest request, SendCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuid))
            {
                body["deviceUuid"] = request.DeviceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartVisible))
            {
                body["partVisible"] = request.PartVisible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receivers))
            {
                body["receivers"] = request.Receivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topbox))
            {
                body["topbox"] = request.Topbox;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "SendCard",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/cards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送卡片
         *
         * @param request SendCardRequest
         * @return SendCardResponse
         */
        public SendCardResponse SendCard(SendCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendCardHeaders headers = new SendCardHeaders();
            return SendCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送卡片
         *
         * @param request SendCardRequest
         * @return SendCardResponse
         */
        public async Task<SendCardResponse> SendCardAsync(SendCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendCardHeaders headers = new SendCardHeaders();
            return await SendCardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送普通消息
         *
         * @param request SendMsgRequest
         * @param headers SendMsgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendMsgResponse
         */
        public SendMsgResponse SendMsgWithOptions(SendMsgRequest request, SendMsgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuid))
            {
                body["deviceUuid"] = request.DeviceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
                Action = "SendMsg",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMsgResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送普通消息
         *
         * @param request SendMsgRequest
         * @param headers SendMsgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendMsgResponse
         */
        public async Task<SendMsgResponse> SendMsgWithOptionsAsync(SendMsgRequest request, SendMsgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuid))
            {
                body["deviceUuid"] = request.DeviceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserList))
            {
                body["userList"] = request.UserList;
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
                Action = "SendMsg",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMsgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送普通消息
         *
         * @param request SendMsgRequest
         * @return SendMsgResponse
         */
        public SendMsgResponse SendMsg(SendMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMsgHeaders headers = new SendMsgHeaders();
            return SendMsgWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送普通消息
         *
         * @param request SendMsgRequest
         * @return SendMsgResponse
         */
        public async Task<SendMsgResponse> SendMsgAsync(SendMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMsgHeaders headers = new SendMsgHeaders();
            return await SendMsgWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 卸载设备
         *
         * @param request UninstallDeviceRobotRequest
         * @param headers UninstallDeviceRobotHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UninstallDeviceRobotResponse
         */
        public UninstallDeviceRobotResponse UninstallDeviceRobotWithOptions(UninstallDeviceRobotRequest request, UninstallDeviceRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "UninstallDeviceRobot",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallDeviceRobotResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 卸载设备
         *
         * @param request UninstallDeviceRobotRequest
         * @param headers UninstallDeviceRobotHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UninstallDeviceRobotResponse
         */
        public async Task<UninstallDeviceRobotResponse> UninstallDeviceRobotWithOptionsAsync(UninstallDeviceRobotRequest request, UninstallDeviceRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "UninstallDeviceRobot",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/devices/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallDeviceRobotResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 卸载设备
         *
         * @param request UninstallDeviceRobotRequest
         * @return UninstallDeviceRobotResponse
         */
        public UninstallDeviceRobotResponse UninstallDeviceRobot(UninstallDeviceRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UninstallDeviceRobotHeaders headers = new UninstallDeviceRobotHeaders();
            return UninstallDeviceRobotWithOptions(request, headers, runtime);
        }

        /**
         * @summary 卸载设备
         *
         * @param request UninstallDeviceRobotRequest
         * @return UninstallDeviceRobotResponse
         */
        public async Task<UninstallDeviceRobotResponse> UninstallDeviceRobotAsync(UninstallDeviceRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UninstallDeviceRobotHeaders headers = new UninstallDeviceRobotHeaders();
            return await UninstallDeviceRobotWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardRequest
         * @param headers UpdateCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCardResponse
         */
        public UpdateCardResponse UpdateCardWithOptions(UpdateCardRequest request, UpdateCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tips))
            {
                body["tips"] = request.Tips;
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
                Action = "UpdateCard",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/cards",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardRequest
         * @param headers UpdateCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCardResponse
         */
        public async Task<UpdateCardResponse> UpdateCardWithOptionsAsync(UpdateCardRequest request, UpdateCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tips))
            {
                body["tips"] = request.Tips;
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
                Action = "UpdateCard",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/customers/cards",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardRequest
         * @return UpdateCardResponse
         */
        public UpdateCardResponse UpdateCard(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardHeaders headers = new UpdateCardHeaders();
            return UpdateCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新卡片
         *
         * @param request UpdateCardRequest
         * @return UpdateCardResponse
         */
        public async Task<UpdateCardResponse> UpdateCardAsync(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardHeaders headers = new UpdateCardHeaders();
            return await UpdateCardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设备事件上报
         *
         * @param request UploadEventRequest
         * @param headers UploadEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadEventResponse
         */
        public UploadEventResponse UploadEventWithOptions(UploadEventRequest request, UploadEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuid))
            {
                body["deviceUuid"] = request.DeviceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTime))
            {
                body["eventTime"] = request.EventTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                body["eventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
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
                Action = "UploadEvent",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/suppliers/events/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadEventResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设备事件上报
         *
         * @param request UploadEventRequest
         * @param headers UploadEventHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadEventResponse
         */
        public async Task<UploadEventResponse> UploadEventWithOptionsAsync(UploadEventRequest request, UploadEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverUrl))
            {
                body["coverUrl"] = request.CoverUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceCode))
            {
                body["deviceCode"] = request.DeviceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceUuid))
            {
                body["deviceUuid"] = request.DeviceUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTime))
            {
                body["eventTime"] = request.EventTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                body["eventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                body["level"] = request.Level;
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
                Action = "UploadEvent",
                Version = "devicemng_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/devicemng/suppliers/events/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设备事件上报
         *
         * @param request UploadEventRequest
         * @return UploadEventResponse
         */
        public UploadEventResponse UploadEvent(UploadEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadEventHeaders headers = new UploadEventHeaders();
            return UploadEventWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设备事件上报
         *
         * @param request UploadEventRequest
         * @return UploadEventResponse
         */
        public async Task<UploadEventResponse> UploadEventAsync(UploadEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadEventHeaders headers = new UploadEventHeaders();
            return await UploadEventWithOptionsAsync(request, headers, runtime);
        }

    }
}
