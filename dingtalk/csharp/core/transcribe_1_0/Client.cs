// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalktranscribe_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalktranscribe_1_0
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


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪记任务的概要信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetTranscribeBriefHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTranscribeBriefResponse
        /// </returns>
        public GetTranscribeBriefResponse GetTranscribeBriefWithOptions(string taskUuid, GetTranscribeBriefHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTranscribeBrief",
                Version = "transcribe_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/transcribe/tasks/" + taskUuid + "/briefInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscribeBriefResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪记任务的概要信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetTranscribeBriefHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTranscribeBriefResponse
        /// </returns>
        public async Task<GetTranscribeBriefResponse> GetTranscribeBriefWithOptionsAsync(string taskUuid, GetTranscribeBriefHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTranscribeBrief",
                Version = "transcribe_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/transcribe/tasks/" + taskUuid + "/briefInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTranscribeBriefResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪记任务的概要信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTranscribeBriefResponse
        /// </returns>
        public GetTranscribeBriefResponse GetTranscribeBrief(string taskUuid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTranscribeBriefHeaders headers = new GetTranscribeBriefHeaders();
            return GetTranscribeBriefWithOptions(taskUuid, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取闪记任务的概要信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTranscribeBriefResponse
        /// </returns>
        public async Task<GetTranscribeBriefResponse> GetTranscribeBriefAsync(string taskUuid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTranscribeBriefHeaders headers = new GetTranscribeBriefHeaders();
            return await GetTranscribeBriefWithOptionsAsync(taskUuid, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除指定用户对闪记任务的权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemovePermissionRequest
        /// </param>
        /// <param name="headers">
        /// RemovePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemovePermissionResponse
        /// </returns>
        public RemovePermissionResponse RemovePermissionWithOptions(string taskUuid, RemovePermissionRequest request, RemovePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCreator))
            {
                body["taskCreator"] = request.TaskCreator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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
                Action = "RemovePermission",
                Version = "transcribe_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/transcribe/tasks/" + taskUuid + "/permissions/remove",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除指定用户对闪记任务的权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemovePermissionRequest
        /// </param>
        /// <param name="headers">
        /// RemovePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemovePermissionResponse
        /// </returns>
        public async Task<RemovePermissionResponse> RemovePermissionWithOptionsAsync(string taskUuid, RemovePermissionRequest request, RemovePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCreator))
            {
                body["taskCreator"] = request.TaskCreator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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
                Action = "RemovePermission",
                Version = "transcribe_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/transcribe/tasks/" + taskUuid + "/permissions/remove",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除指定用户对闪记任务的权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemovePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// RemovePermissionResponse
        /// </returns>
        public RemovePermissionResponse RemovePermission(string taskUuid, RemovePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemovePermissionHeaders headers = new RemovePermissionHeaders();
            return RemovePermissionWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除指定用户对闪记任务的权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemovePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// RemovePermissionResponse
        /// </returns>
        public async Task<RemovePermissionResponse> RemovePermissionAsync(string taskUuid, RemovePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemovePermissionHeaders headers = new RemovePermissionHeaders();
            return await RemovePermissionWithOptionsAsync(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>针对指定的闪记，修改或者授予指定用户权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionForUsersRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePermissionForUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionForUsersResponse
        /// </returns>
        public UpdatePermissionForUsersResponse UpdatePermissionForUsersWithOptions(string taskUuid, UpdatePermissionForUsersRequest request, UpdatePermissionForUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                query["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCreator))
            {
                body["taskCreator"] = request.TaskCreator;
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
                Action = "UpdatePermissionForUsers",
                Version = "transcribe_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/transcribe/tasks/" + taskUuid + "/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePermissionForUsersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>针对指定的闪记，修改或者授予指定用户权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionForUsersRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePermissionForUsersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionForUsersResponse
        /// </returns>
        public async Task<UpdatePermissionForUsersResponse> UpdatePermissionForUsersWithOptionsAsync(string taskUuid, UpdatePermissionForUsersRequest request, UpdatePermissionForUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                query["operatorUid"] = request.OperatorUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskCreator))
            {
                body["taskCreator"] = request.TaskCreator;
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
                Action = "UpdatePermissionForUsers",
                Version = "transcribe_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/transcribe/tasks/" + taskUuid + "/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePermissionForUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>针对指定的闪记，修改或者授予指定用户权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionForUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionForUsersResponse
        /// </returns>
        public UpdatePermissionForUsersResponse UpdatePermissionForUsers(string taskUuid, UpdatePermissionForUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionForUsersHeaders headers = new UpdatePermissionForUsersHeaders();
            return UpdatePermissionForUsersWithOptions(taskUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>针对指定的闪记，修改或者授予指定用户权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePermissionForUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePermissionForUsersResponse
        /// </returns>
        public async Task<UpdatePermissionForUsersResponse> UpdatePermissionForUsersAsync(string taskUuid, UpdatePermissionForUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePermissionForUsersHeaders headers = new UpdatePermissionForUsersHeaders();
            return await UpdatePermissionForUsersWithOptionsAsync(taskUuid, request, headers, runtime);
        }

    }
}
