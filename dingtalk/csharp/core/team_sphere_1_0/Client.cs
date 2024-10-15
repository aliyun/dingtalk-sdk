// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0
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
        /// <para>创建自由任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrganizationTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateOrganizationTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrganizationTaskResponse
        /// </returns>
        public CreateOrganizationTaskResponse CreateOrganizationTaskWithOptions(string userId, CreateOrganizationTaskRequest request, CreateOrganizationTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueDate))
            {
                body["dueDate"] = request.DueDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvolveMembers))
            {
                body["involveMembers"] = request.InvolveMembers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visible))
            {
                body["visible"] = request.Visible;
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
                Action = "CreateOrganizationTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/organizations/users/" + userId + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrganizationTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自由任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrganizationTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateOrganizationTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrganizationTaskResponse
        /// </returns>
        public async Task<CreateOrganizationTaskResponse> CreateOrganizationTaskWithOptionsAsync(string userId, CreateOrganizationTaskRequest request, CreateOrganizationTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueDate))
            {
                body["dueDate"] = request.DueDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvolveMembers))
            {
                body["involveMembers"] = request.InvolveMembers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Visible))
            {
                body["visible"] = request.Visible;
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
                Action = "CreateOrganizationTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/organizations/users/" + userId + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrganizationTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自由任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrganizationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrganizationTaskResponse
        /// </returns>
        public CreateOrganizationTaskResponse CreateOrganizationTask(string userId, CreateOrganizationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrganizationTaskHeaders headers = new CreateOrganizationTaskHeaders();
            return CreateOrganizationTaskWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自由任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrganizationTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrganizationTaskResponse
        /// </returns>
        public async Task<CreateOrganizationTaskResponse> CreateOrganizationTaskAsync(string userId, CreateOrganizationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrganizationTaskHeaders headers = new CreateOrganizationTaskHeaders();
            return await CreateOrganizationTaskWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建协作空间任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public CreateTaskResponse CreateTaskWithOptions(string userId, CreateTaskRequest request, CreateTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Customfields))
            {
                body["customfields"] = request.Customfields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueDate))
            {
                body["dueDate"] = request.DueDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
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
                Action = "CreateTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建协作空间任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public async Task<CreateTaskResponse> CreateTaskWithOptionsAsync(string userId, CreateTaskRequest request, CreateTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Customfields))
            {
                body["customfields"] = request.Customfields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueDate))
            {
                body["dueDate"] = request.DueDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
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
                Action = "CreateTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建协作空间任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public CreateTaskResponse CreateTask(string userId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTaskHeaders headers = new CreateTaskHeaders();
            return CreateTaskWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建协作空间任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public async Task<CreateTaskResponse> CreateTaskAsync(string userId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTaskHeaders headers = new CreateTaskHeaders();
            return await CreateTaskWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询轻任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFreeTaskRequest
        /// </param>
        /// <param name="headers">
        /// GetFreeTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFreeTaskResponse
        /// </returns>
        public GetFreeTaskResponse GetFreeTaskWithOptions(string taskId, GetFreeTaskRequest request, GetFreeTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetFreeTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/organizations/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFreeTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询轻任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFreeTaskRequest
        /// </param>
        /// <param name="headers">
        /// GetFreeTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFreeTaskResponse
        /// </returns>
        public async Task<GetFreeTaskResponse> GetFreeTaskWithOptionsAsync(string taskId, GetFreeTaskRequest request, GetFreeTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetFreeTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/organizations/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFreeTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询轻任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFreeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFreeTaskResponse
        /// </returns>
        public GetFreeTaskResponse GetFreeTask(string taskId, GetFreeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFreeTaskHeaders headers = new GetFreeTaskHeaders();
            return GetFreeTaskWithOptions(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询轻任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFreeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFreeTaskResponse
        /// </returns>
        public async Task<GetFreeTaskResponse> GetFreeTaskAsync(string taskId, GetFreeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFreeTaskHeaders headers = new GetFreeTaskHeaders();
            return await GetFreeTaskWithOptionsAsync(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉 userId 查询 24位长 userId。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTbUserIdByDingUserIdRequest
        /// </param>
        /// <param name="headers">
        /// GetTbUserIdByDingUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTbUserIdByDingUserIdResponse
        /// </returns>
        public GetTbUserIdByDingUserIdResponse GetTbUserIdByDingUserIdWithOptions(GetTbUserIdByDingUserIdRequest request, GetTbUserIdByDingUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserIds))
            {
                query["dingUserIds"] = request.DingUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetTbUserIdByDingUserId",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/idmaps/userIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTbUserIdByDingUserIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉 userId 查询 24位长 userId。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTbUserIdByDingUserIdRequest
        /// </param>
        /// <param name="headers">
        /// GetTbUserIdByDingUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTbUserIdByDingUserIdResponse
        /// </returns>
        public async Task<GetTbUserIdByDingUserIdResponse> GetTbUserIdByDingUserIdWithOptionsAsync(GetTbUserIdByDingUserIdRequest request, GetTbUserIdByDingUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserIds))
            {
                query["dingUserIds"] = request.DingUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "GetTbUserIdByDingUserId",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/idmaps/userIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTbUserIdByDingUserIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉 userId 查询 24位长 userId。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTbUserIdByDingUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTbUserIdByDingUserIdResponse
        /// </returns>
        public GetTbUserIdByDingUserIdResponse GetTbUserIdByDingUserId(GetTbUserIdByDingUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbUserIdByDingUserIdHeaders headers = new GetTbUserIdByDingUserIdHeaders();
            return GetTbUserIdByDingUserIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉 userId 查询 24位长 userId。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTbUserIdByDingUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTbUserIdByDingUserIdResponse
        /// </returns>
        public async Task<GetTbUserIdByDingUserIdResponse> GetTbUserIdByDingUserIdAsync(GetTbUserIdByDingUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbUserIdByDingUserIdHeaders headers = new GetTbUserIdByDingUserIdHeaders();
            return await GetTbUserIdByDingUserIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询协作空间任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTasksV3Request
        /// </param>
        /// <param name="headers">
        /// QueryTasksV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTasksV3Response
        /// </returns>
        public QueryTasksV3Response QueryTasksV3WithOptions(string userId, QueryTasksV3Request request, QueryTasksV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTaskId))
            {
                query["parentTaskId"] = request.ParentTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortIds))
            {
                query["shortIds"] = request.ShortIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
                Action = "QueryTasksV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/user/" + userId + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTasksV3Response>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询协作空间任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTasksV3Request
        /// </param>
        /// <param name="headers">
        /// QueryTasksV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTasksV3Response
        /// </returns>
        public async Task<QueryTasksV3Response> QueryTasksV3WithOptionsAsync(string userId, QueryTasksV3Request request, QueryTasksV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTaskId))
            {
                query["parentTaskId"] = request.ParentTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShortIds))
            {
                query["shortIds"] = request.ShortIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
                Action = "QueryTasksV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/user/" + userId + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTasksV3Response>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询协作空间任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTasksV3Request
        /// </param>
        /// 
        /// <returns>
        /// QueryTasksV3Response
        /// </returns>
        public QueryTasksV3Response QueryTasksV3(string userId, QueryTasksV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTasksV3Headers headers = new QueryTasksV3Headers();
            return QueryTasksV3WithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询协作空间任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTasksV3Request
        /// </param>
        /// 
        /// <returns>
        /// QueryTasksV3Response
        /// </returns>
        public async Task<QueryTasksV3Response> QueryTasksV3Async(string userId, QueryTasksV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTasksV3Headers headers = new QueryTasksV3Headers();
            return await QueryTasksV3WithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过TQL搜索自由任务和协作空间任务ID。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchAllTasksByTqlRequest
        /// </param>
        /// <param name="headers">
        /// SearchAllTasksByTqlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchAllTasksByTqlResponse
        /// </returns>
        public SearchAllTasksByTqlResponse SearchAllTasksByTqlWithOptions(SearchAllTasksByTqlRequest request, SearchAllTasksByTqlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tql))
            {
                query["tql"] = request.Tql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "SearchAllTasksByTql",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/taskIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchAllTasksByTqlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过TQL搜索自由任务和协作空间任务ID。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchAllTasksByTqlRequest
        /// </param>
        /// <param name="headers">
        /// SearchAllTasksByTqlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchAllTasksByTqlResponse
        /// </returns>
        public async Task<SearchAllTasksByTqlResponse> SearchAllTasksByTqlWithOptionsAsync(SearchAllTasksByTqlRequest request, SearchAllTasksByTqlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tql))
            {
                query["tql"] = request.Tql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "SearchAllTasksByTql",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/taskIds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchAllTasksByTqlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过TQL搜索自由任务和协作空间任务ID。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchAllTasksByTqlRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchAllTasksByTqlResponse
        /// </returns>
        public SearchAllTasksByTqlResponse SearchAllTasksByTql(SearchAllTasksByTqlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchAllTasksByTqlHeaders headers = new SearchAllTasksByTqlHeaders();
            return SearchAllTasksByTqlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过TQL搜索自由任务和协作空间任务ID。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchAllTasksByTqlRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchAllTasksByTqlResponse
        /// </returns>
        public async Task<SearchAllTasksByTqlResponse> SearchAllTasksByTqlAsync(SearchAllTasksByTqlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchAllTasksByTqlHeaders headers = new SearchAllTasksByTqlHeaders();
            return await SearchAllTasksByTqlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchProjectsV3Request
        /// </param>
        /// <param name="headers">
        /// SearchProjectsV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchProjectsV3Response
        /// </returns>
        public SearchProjectsV3Response SearchProjectsV3WithOptions(SearchProjectsV3Request request, SearchProjectsV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTemplate))
            {
                query["includeTemplate"] = request.IncludeTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                query["projectIds"] = request.ProjectIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "SearchProjectsV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchProjectsV3Response>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchProjectsV3Request
        /// </param>
        /// <param name="headers">
        /// SearchProjectsV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchProjectsV3Response
        /// </returns>
        public async Task<SearchProjectsV3Response> SearchProjectsV3WithOptionsAsync(SearchProjectsV3Request request, SearchProjectsV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeTemplate))
            {
                query["includeTemplate"] = request.IncludeTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                query["projectIds"] = request.ProjectIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "SearchProjectsV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchProjectsV3Response>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchProjectsV3Request
        /// </param>
        /// 
        /// <returns>
        /// SearchProjectsV3Response
        /// </returns>
        public SearchProjectsV3Response SearchProjectsV3(SearchProjectsV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchProjectsV3Headers headers = new SearchProjectsV3Headers();
            return SearchProjectsV3WithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchProjectsV3Request
        /// </param>
        /// 
        /// <returns>
        /// SearchProjectsV3Response
        /// </returns>
        public async Task<SearchProjectsV3Response> SearchProjectsV3Async(SearchProjectsV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchProjectsV3Headers headers = new SearchProjectsV3Headers();
            return await SearchProjectsV3WithOptionsAsync(request, headers, runtime);
        }

    }
}
