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
            this._productId = "dingtalk";
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量注册设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRegisterDeviceRequest
        /// </param>
        /// <param name="headers">
        /// BatchRegisterDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRegisterDeviceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量注册设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRegisterDeviceRequest
        /// </param>
        /// <param name="headers">
        /// BatchRegisterDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRegisterDeviceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量注册设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRegisterDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRegisterDeviceResponse
        /// </returns>
        public BatchRegisterDeviceResponse BatchRegisterDevice(BatchRegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRegisterDeviceHeaders headers = new BatchRegisterDeviceHeaders();
            return BatchRegisterDeviceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量注册设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRegisterDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRegisterDeviceResponse
        /// </returns>
        public async Task<BatchRegisterDeviceResponse> BatchRegisterDeviceAsync(BatchRegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchRegisterDeviceHeaders headers = new BatchRegisterDeviceHeaders();
            return await BatchRegisterDeviceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>想设备上钉连接器推送设备事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConnectorEventPushRequest
        /// </param>
        /// <param name="headers">
        /// ConnectorEventPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConnectorEventPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>想设备上钉连接器推送设备事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConnectorEventPushRequest
        /// </param>
        /// <param name="headers">
        /// ConnectorEventPushHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConnectorEventPushResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>想设备上钉连接器推送设备事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConnectorEventPushRequest
        /// </param>
        /// 
        /// <returns>
        /// ConnectorEventPushResponse
        /// </returns>
        public ConnectorEventPushResponse ConnectorEventPush(ConnectorEventPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConnectorEventPushHeaders headers = new ConnectorEventPushHeaders();
            return ConnectorEventPushWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>想设备上钉连接器推送设备事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConnectorEventPushRequest
        /// </param>
        /// 
        /// <returns>
        /// ConnectorEventPushResponse
        /// </returns>
        public async Task<ConnectorEventPushResponse> ConnectorEventPushAsync(ConnectorEventPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConnectorEventPushHeaders headers = new ConnectorEventPushHeaders();
            return await ConnectorEventPushWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRoomRequest
        /// </param>
        /// <param name="headers">
        /// CreateChatRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRoomRequest
        /// </param>
        /// <param name="headers">
        /// CreateChatRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatRoomResponse
        /// </returns>
        public CreateChatRoomResponse CreateChatRoom(CreateChatRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateChatRoomHeaders headers = new CreateChatRoomHeaders();
            return CreateChatRoomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatRoomResponse
        /// </returns>
        public async Task<CreateChatRoomResponse> CreateChatRoomAsync(CreateChatRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateChatRoomHeaders headers = new CreateChatRoomHeaders();
            return await CreateChatRoomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDepartmentRequest
        /// </param>
        /// <param name="headers">
        /// CreateDepartmentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDepartmentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDepartmentRequest
        /// </param>
        /// <param name="headers">
        /// CreateDepartmentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDepartmentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDepartmentResponse
        /// </returns>
        public CreateDepartmentResponse CreateDepartment(CreateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDepartmentHeaders headers = new CreateDepartmentHeaders();
            return CreateDepartmentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDepartmentResponse
        /// </returns>
        public async Task<CreateDepartmentResponse> CreateDepartmentAsync(CreateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDepartmentHeaders headers = new CreateDepartmentHeaders();
            return await CreateDepartmentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备场景群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceChatRoomRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeviceChatRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceChatRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备场景群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceChatRoomRequest
        /// </param>
        /// <param name="headers">
        /// CreateDeviceChatRoomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceChatRoomResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备场景群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceChatRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceChatRoomResponse
        /// </returns>
        public CreateDeviceChatRoomResponse CreateDeviceChatRoom(CreateDeviceChatRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceChatRoomHeaders headers = new CreateDeviceChatRoomHeaders();
            return CreateDeviceChatRoomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备场景群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDeviceChatRoomRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDeviceChatRoomResponse
        /// </returns>
        public async Task<CreateDeviceChatRoomResponse> CreateDeviceChatRoomAsync(CreateDeviceChatRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeviceChatRoomHeaders headers = new CreateDeviceChatRoomHeaders();
            return await CreateDeviceChatRoomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备账号向目标用户发送ding消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceDingRequest
        /// </param>
        /// <param name="headers">
        /// DeviceDingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeviceDingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备账号向目标用户发送ding消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceDingRequest
        /// </param>
        /// <param name="headers">
        /// DeviceDingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeviceDingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备账号向目标用户发送ding消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceDingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeviceDingResponse
        /// </returns>
        public DeviceDingResponse DeviceDing(DeviceDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeviceDingHeaders headers = new DeviceDingHeaders();
            return DeviceDingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备账号向目标用户发送ding消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeviceDingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeviceDingResponse
        /// </returns>
        public async Task<DeviceDingResponse> DeviceDingAsync(DeviceDingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeviceDingHeaders headers = new DeviceDingHeaders();
            return await DeviceDingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解散设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissolveGroupRequest
        /// </param>
        /// <param name="headers">
        /// DissolveGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissolveGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解散设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissolveGroupRequest
        /// </param>
        /// <param name="headers">
        /// DissolveGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissolveGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解散设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissolveGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DissolveGroupResponse
        /// </returns>
        public DissolveGroupResponse DissolveGroup(DissolveGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DissolveGroupHeaders headers = new DissolveGroupHeaders();
            return DissolveGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解散设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissolveGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DissolveGroupResponse
        /// </returns>
        public async Task<DissolveGroupResponse> DissolveGroupAsync(DissolveGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DissolveGroupHeaders headers = new DissolveGroupHeaders();
            return await DissolveGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑设备管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditDeviceAdminRequest
        /// </param>
        /// <param name="headers">
        /// EditDeviceAdminHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditDeviceAdminResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑设备管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditDeviceAdminRequest
        /// </param>
        /// <param name="headers">
        /// EditDeviceAdminHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditDeviceAdminResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑设备管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditDeviceAdminRequest
        /// </param>
        /// 
        /// <returns>
        /// EditDeviceAdminResponse
        /// </returns>
        public EditDeviceAdminResponse EditDeviceAdmin(EditDeviceAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditDeviceAdminHeaders headers = new EditDeviceAdminHeaders();
            return EditDeviceAdminWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑设备管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditDeviceAdminRequest
        /// </param>
        /// 
        /// <returns>
        /// EditDeviceAdminResponse
        /// </returns>
        public async Task<EditDeviceAdminResponse> EditDeviceAdminAsync(EditDeviceAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EditDeviceAdminHeaders headers = new EditDeviceAdminHeaders();
            return await EditDeviceAdminWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceGroupInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceGroupInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceGroupInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceGroupInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetDeviceGroupInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceGroupInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceGroupInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceGroupInfoResponse
        /// </returns>
        public GetDeviceGroupInfoResponse GetDeviceGroupInfo(GetDeviceGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceGroupInfoHeaders headers = new GetDeviceGroupInfoHeaders();
            return GetDeviceGroupInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDeviceGroupInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDeviceGroupInfoResponse
        /// </returns>
        public async Task<GetDeviceGroupInfoResponse> GetDeviceGroupInfoAsync(GetDeviceGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeviceGroupInfoHeaders headers = new GetDeviceGroupInfoHeaders();
            return await GetDeviceGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备全员群标识</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetWholeDeviceGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWholeDeviceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备全员群标识</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetWholeDeviceGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWholeDeviceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备全员群标识</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWholeDeviceGroupResponse
        /// </returns>
        public GetWholeDeviceGroupResponse GetWholeDeviceGroup()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWholeDeviceGroupHeaders headers = new GetWholeDeviceGroupHeaders();
            return GetWholeDeviceGroupWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取设备全员群标识</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetWholeDeviceGroupResponse
        /// </returns>
        public async Task<GetWholeDeviceGroupResponse> GetWholeDeviceGroupAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetWholeDeviceGroupHeaders headers = new GetWholeDeviceGroupHeaders();
            return await GetWholeDeviceGroupWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询激活的设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListActivateDevicesRequest
        /// </param>
        /// <param name="headers">
        /// ListActivateDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListActivateDevicesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询激活的设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListActivateDevicesRequest
        /// </param>
        /// <param name="headers">
        /// ListActivateDevicesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListActivateDevicesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询激活的设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListActivateDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListActivateDevicesResponse
        /// </returns>
        public ListActivateDevicesResponse ListActivateDevices(ListActivateDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListActivateDevicesHeaders headers = new ListActivateDevicesHeaders();
            return ListActivateDevicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询激活的设备信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListActivateDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListActivateDevicesResponse
        /// </returns>
        public async Task<ListActivateDevicesResponse> ListActivateDevicesAsync(ListActivateDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListActivateDevicesHeaders headers = new ListActivateDevicesHeaders();
            return await ListActivateDevicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取巡检、保养记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInspectInfoRequest
        /// </param>
        /// <param name="headers">
        /// ListInspectInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInspectInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取巡检、保养记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInspectInfoRequest
        /// </param>
        /// <param name="headers">
        /// ListInspectInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInspectInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取巡检、保养记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInspectInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInspectInfoResponse
        /// </returns>
        public ListInspectInfoResponse ListInspectInfo(ListInspectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInspectInfoHeaders headers = new ListInspectInfoHeaders();
            return ListInspectInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取巡检、保养记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInspectInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInspectInfoResponse
        /// </returns>
        public async Task<ListInspectInfoResponse> ListInspectInfoAsync(ListInspectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListInspectInfoHeaders headers = new ListInspectInfoHeaders();
            return await ListInspectInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取报修信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMaintainInfoRequest
        /// </param>
        /// <param name="headers">
        /// ListMaintainInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMaintainInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取报修信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMaintainInfoRequest
        /// </param>
        /// <param name="headers">
        /// ListMaintainInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMaintainInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取报修信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMaintainInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMaintainInfoResponse
        /// </returns>
        public ListMaintainInfoResponse ListMaintainInfo(ListMaintainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMaintainInfoHeaders headers = new ListMaintainInfoHeaders();
            return ListMaintainInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取报修信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMaintainInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMaintainInfoResponse
        /// </returns>
        public async Task<ListMaintainInfoResponse> ListMaintainInfoAsync(ListMaintainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMaintainInfoHeaders headers = new ListMaintainInfoHeaders();
            return await ListMaintainInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉设备进群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullDeviceToGroupRequest
        /// </param>
        /// <param name="headers">
        /// PullDeviceToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PullDeviceToGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉设备进群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullDeviceToGroupRequest
        /// </param>
        /// <param name="headers">
        /// PullDeviceToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PullDeviceToGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉设备进群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullDeviceToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// PullDeviceToGroupResponse
        /// </returns>
        public PullDeviceToGroupResponse PullDeviceToGroup(PullDeviceToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDeviceToGroupHeaders headers = new PullDeviceToGroupHeaders();
            return PullDeviceToGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉设备进群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullDeviceToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// PullDeviceToGroupResponse
        /// </returns>
        public async Task<PullDeviceToGroupResponse> PullDeviceToGroupAsync(PullDeviceToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullDeviceToGroupHeaders headers = new PullDeviceToGroupHeaders();
            return await PullDeviceToGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉设用户进群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullUserToGroupRequest
        /// </param>
        /// <param name="headers">
        /// PullUserToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PullUserToGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉设用户进群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullUserToGroupRequest
        /// </param>
        /// <param name="headers">
        /// PullUserToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PullUserToGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉设用户进群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullUserToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// PullUserToGroupResponse
        /// </returns>
        public PullUserToGroupResponse PullUserToGroup(PullUserToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullUserToGroupHeaders headers = new PullUserToGroupHeaders();
            return PullUserToGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉设用户进群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullUserToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// PullUserToGroupResponse
        /// </returns>
        public async Task<PullUserToGroupResponse> PullUserToGroupAsync(PullUserToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullUserToGroupHeaders headers = new PullUserToGroupHeaders();
            return await PullUserToGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册与激活设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAndActivateDeviceRequest
        /// </param>
        /// <param name="headers">
        /// RegisterAndActivateDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterAndActivateDeviceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册与激活设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAndActivateDeviceRequest
        /// </param>
        /// <param name="headers">
        /// RegisterAndActivateDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterAndActivateDeviceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册与激活设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAndActivateDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterAndActivateDeviceResponse
        /// </returns>
        public RegisterAndActivateDeviceResponse RegisterAndActivateDevice(RegisterAndActivateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterAndActivateDeviceHeaders headers = new RegisterAndActivateDeviceHeaders();
            return RegisterAndActivateDeviceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册与激活设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAndActivateDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterAndActivateDeviceResponse
        /// </returns>
        public async Task<RegisterAndActivateDeviceResponse> RegisterAndActivateDeviceAsync(RegisterAndActivateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterAndActivateDeviceHeaders headers = new RegisterAndActivateDeviceHeaders();
            return await RegisterAndActivateDeviceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量注册与激活设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAndActivateDeviceBatchRequest
        /// </param>
        /// <param name="headers">
        /// RegisterAndActivateDeviceBatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterAndActivateDeviceBatchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量注册与激活设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAndActivateDeviceBatchRequest
        /// </param>
        /// <param name="headers">
        /// RegisterAndActivateDeviceBatchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterAndActivateDeviceBatchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量注册与激活设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAndActivateDeviceBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterAndActivateDeviceBatchResponse
        /// </returns>
        public RegisterAndActivateDeviceBatchResponse RegisterAndActivateDeviceBatch(RegisterAndActivateDeviceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterAndActivateDeviceBatchHeaders headers = new RegisterAndActivateDeviceBatchHeaders();
            return RegisterAndActivateDeviceBatchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量注册与激活设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterAndActivateDeviceBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterAndActivateDeviceBatchResponse
        /// </returns>
        public async Task<RegisterAndActivateDeviceBatchResponse> RegisterAndActivateDeviceBatchAsync(RegisterAndActivateDeviceBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterAndActivateDeviceBatchHeaders headers = new RegisterAndActivateDeviceBatchHeaders();
            return await RegisterAndActivateDeviceBatchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册设备并为其创建机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterDeviceRequest
        /// </param>
        /// <param name="headers">
        /// RegisterDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterDeviceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册设备并为其创建机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterDeviceRequest
        /// </param>
        /// <param name="headers">
        /// RegisterDeviceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterDeviceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册设备并为其创建机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterDeviceResponse
        /// </returns>
        public RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterDeviceHeaders headers = new RegisterDeviceHeaders();
            return RegisterDeviceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册设备并为其创建机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterDeviceResponse
        /// </returns>
        public async Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterDeviceHeaders headers = new RegisterDeviceHeaders();
            return await RegisterDeviceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移设备出群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveDeviceFromGroupRequest
        /// </param>
        /// <param name="headers">
        /// RemoveDeviceFromGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveDeviceFromGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移设备出群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveDeviceFromGroupRequest
        /// </param>
        /// <param name="headers">
        /// RemoveDeviceFromGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveDeviceFromGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移设备出群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveDeviceFromGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveDeviceFromGroupResponse
        /// </returns>
        public RemoveDeviceFromGroupResponse RemoveDeviceFromGroup(RemoveDeviceFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveDeviceFromGroupHeaders headers = new RemoveDeviceFromGroupHeaders();
            return RemoveDeviceFromGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移设备出群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveDeviceFromGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveDeviceFromGroupResponse
        /// </returns>
        public async Task<RemoveDeviceFromGroupResponse> RemoveDeviceFromGroupAsync(RemoveDeviceFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveDeviceFromGroupHeaders headers = new RemoveDeviceFromGroupHeaders();
            return await RemoveDeviceFromGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移用户出设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserFromGroupRequest
        /// </param>
        /// <param name="headers">
        /// RemoveUserFromGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移用户出设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserFromGroupRequest
        /// </param>
        /// <param name="headers">
        /// RemoveUserFromGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移用户出设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserFromGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromGroupResponse
        /// </returns>
        public RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveUserFromGroupHeaders headers = new RemoveUserFromGroupHeaders();
            return RemoveUserFromGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移用户出设备群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveUserFromGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveUserFromGroupResponse
        /// </returns>
        public async Task<RemoveUserFromGroupResponse> RemoveUserFromGroupAsync(RemoveUserFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveUserFromGroupHeaders headers = new RemoveUserFromGroupHeaders();
            return await RemoveUserFromGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendCardRequest
        /// </param>
        /// <param name="headers">
        /// SendCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendCardRequest
        /// </param>
        /// <param name="headers">
        /// SendCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendCardResponse
        /// </returns>
        public SendCardResponse SendCard(SendCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendCardHeaders headers = new SendCardHeaders();
            return SendCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendCardResponse
        /// </returns>
        public async Task<SendCardResponse> SendCardAsync(SendCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendCardHeaders headers = new SendCardHeaders();
            return await SendCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送普通消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendMsgRequest
        /// </param>
        /// <param name="headers">
        /// SendMsgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMsgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送普通消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendMsgRequest
        /// </param>
        /// <param name="headers">
        /// SendMsgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMsgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送普通消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMsgResponse
        /// </returns>
        public SendMsgResponse SendMsg(SendMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMsgHeaders headers = new SendMsgHeaders();
            return SendMsgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送普通消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMsgResponse
        /// </returns>
        public async Task<SendMsgResponse> SendMsgAsync(SendMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMsgHeaders headers = new SendMsgHeaders();
            return await SendMsgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallDeviceRobotRequest
        /// </param>
        /// <param name="headers">
        /// UninstallDeviceRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallDeviceRobotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallDeviceRobotRequest
        /// </param>
        /// <param name="headers">
        /// UninstallDeviceRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallDeviceRobotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallDeviceRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallDeviceRobotResponse
        /// </returns>
        public UninstallDeviceRobotResponse UninstallDeviceRobot(UninstallDeviceRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UninstallDeviceRobotHeaders headers = new UninstallDeviceRobotHeaders();
            return UninstallDeviceRobotWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallDeviceRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallDeviceRobotResponse
        /// </returns>
        public async Task<UninstallDeviceRobotResponse> UninstallDeviceRobotAsync(UninstallDeviceRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UninstallDeviceRobotHeaders headers = new UninstallDeviceRobotHeaders();
            return await UninstallDeviceRobotWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardRequest
        /// </param>
        /// <param name="headers">
        /// UpdateCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardResponse
        /// </returns>
        public UpdateCardResponse UpdateCard(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardHeaders headers = new UpdateCardHeaders();
            return UpdateCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCardRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCardResponse
        /// </returns>
        public async Task<UpdateCardResponse> UpdateCardAsync(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCardHeaders headers = new UpdateCardHeaders();
            return await UpdateCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备事件上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadEventRequest
        /// </param>
        /// <param name="headers">
        /// UploadEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadEventResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备事件上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadEventRequest
        /// </param>
        /// <param name="headers">
        /// UploadEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadEventResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备事件上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadEventRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadEventResponse
        /// </returns>
        public UploadEventResponse UploadEvent(UploadEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadEventHeaders headers = new UploadEventHeaders();
            return UploadEventWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设备事件上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadEventRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadEventResponse
        /// </returns>
        public async Task<UploadEventResponse> UploadEventAsync(UploadEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadEventHeaders headers = new UploadEventHeaders();
            return await UploadEventWithOptionsAsync(request, headers, runtime);
        }

    }
}
