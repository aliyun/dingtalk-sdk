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
        /// <para>查询任务概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalysisReportRequest
        /// </param>
        /// <param name="headers">
        /// AnalysisReportHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalysisReportResponse
        /// </returns>
        public AnalysisReportResponse AnalysisReportWithOptions(string userId, AnalysisReportRequest request, AnalysisReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["reportId"] = request.ReportId;
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
                Action = "AnalysisReport",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/analyses/report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalysisReportResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalysisReportRequest
        /// </param>
        /// <param name="headers">
        /// AnalysisReportHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalysisReportResponse
        /// </returns>
        public async Task<AnalysisReportResponse> AnalysisReportWithOptionsAsync(string userId, AnalysisReportRequest request, AnalysisReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportId))
            {
                body["reportId"] = request.ReportId;
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
                Action = "AnalysisReport",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/analyses/report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalysisReportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalysisReportRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalysisReportResponse
        /// </returns>
        public AnalysisReportResponse AnalysisReport(string userId, AnalysisReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AnalysisReportHeaders headers = new AnalysisReportHeaders();
            return AnalysisReportWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalysisReportRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalysisReportResponse
        /// </returns>
        public async Task<AnalysisReportResponse> AnalysisReportAsync(string userId, AnalysisReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AnalysisReportHeaders headers = new AnalysisReportHeaders();
            return await AnalysisReportWithOptionsAsync(userId, request, headers, runtime);
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
        /// <para>创建项目成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectMembersV3Request
        /// </param>
        /// <param name="headers">
        /// CreateProjectMembersV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectMembersV3Response
        /// </returns>
        public CreateProjectMembersV3Response CreateProjectMembersV3WithOptions(string userId, string projectId, CreateProjectMembersV3Request request, CreateProjectMembersV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CreateProjectMembersV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectMembersV3Response>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectMembersV3Request
        /// </param>
        /// <param name="headers">
        /// CreateProjectMembersV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectMembersV3Response
        /// </returns>
        public async Task<CreateProjectMembersV3Response> CreateProjectMembersV3WithOptionsAsync(string userId, string projectId, CreateProjectMembersV3Request request, CreateProjectMembersV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CreateProjectMembersV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectMembersV3Response>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectMembersV3Request
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectMembersV3Response
        /// </returns>
        public CreateProjectMembersV3Response CreateProjectMembersV3(string userId, string projectId, CreateProjectMembersV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectMembersV3Headers headers = new CreateProjectMembersV3Headers();
            return CreateProjectMembersV3WithOptions(userId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectMembersV3Request
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectMembersV3Response
        /// </returns>
        public async Task<CreateProjectMembersV3Response> CreateProjectMembersV3Async(string userId, string projectId, CreateProjectMembersV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectMembersV3Headers headers = new CreateProjectMembersV3Headers();
            return await CreateProjectMembersV3WithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectV3Request
        /// </param>
        /// <param name="headers">
        /// CreateProjectV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectV3Response
        /// </returns>
        public CreateProjectV3Response CreateProjectV3WithOptions(string userId, CreateProjectV3Request request, CreateProjectV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CreateProjectV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectV3Response>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectV3Request
        /// </param>
        /// <param name="headers">
        /// CreateProjectV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectV3Response
        /// </returns>
        public async Task<CreateProjectV3Response> CreateProjectV3WithOptionsAsync(string userId, CreateProjectV3Request request, CreateProjectV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrganizationId))
            {
                query["organizationId"] = request.OrganizationId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CreateProjectV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectV3Response>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectV3Request
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectV3Response
        /// </returns>
        public CreateProjectV3Response CreateProjectV3(string userId, CreateProjectV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectV3Headers headers = new CreateProjectV3Headers();
            return CreateProjectV3WithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectV3Request
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectV3Response
        /// </returns>
        public async Task<CreateProjectV3Response> CreateProjectV3Async(string userId, CreateProjectV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectV3Headers headers = new CreateProjectV3Headers();
            return await CreateProjectV3WithOptionsAsync(userId, request, headers, runtime);
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
        /// <para>删除项目成员。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProjectMembersV3Request
        /// </param>
        /// <param name="headers">
        /// DeleteProjectMembersV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectMembersV3Response
        /// </returns>
        public DeleteProjectMembersV3Response DeleteProjectMembersV3WithOptions(string userId, string projectId, DeleteProjectMembersV3Request request, DeleteProjectMembersV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DeleteProjectMembersV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectMembersV3Response>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除项目成员。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProjectMembersV3Request
        /// </param>
        /// <param name="headers">
        /// DeleteProjectMembersV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectMembersV3Response
        /// </returns>
        public async Task<DeleteProjectMembersV3Response> DeleteProjectMembersV3WithOptionsAsync(string userId, string projectId, DeleteProjectMembersV3Request request, DeleteProjectMembersV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "DeleteProjectMembersV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectMembersV3Response>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除项目成员。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProjectMembersV3Request
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectMembersV3Response
        /// </returns>
        public DeleteProjectMembersV3Response DeleteProjectMembersV3(string userId, string projectId, DeleteProjectMembersV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProjectMembersV3Headers headers = new DeleteProjectMembersV3Headers();
            return DeleteProjectMembersV3WithOptions(userId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除项目成员。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProjectMembersV3Request
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectMembersV3Response
        /// </returns>
        public async Task<DeleteProjectMembersV3Response> DeleteProjectMembersV3Async(string userId, string projectId, DeleteProjectMembersV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProjectMembersV3Headers headers = new DeleteProjectMembersV3Headers();
            return await DeleteProjectMembersV3WithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近访问的项目</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFootprintProjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFootprintProjectResponse
        /// </returns>
        public GetFootprintProjectResponse GetFootprintProjectWithOptions(string userId, GetFootprintProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFootprintProject",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/footprints/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFootprintProjectResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近访问的项目</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFootprintProjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFootprintProjectResponse
        /// </returns>
        public async Task<GetFootprintProjectResponse> GetFootprintProjectWithOptionsAsync(string userId, GetFootprintProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFootprintProject",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/footprints/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFootprintProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近访问的项目</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFootprintProjectResponse
        /// </returns>
        public GetFootprintProjectResponse GetFootprintProject(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFootprintProjectHeaders headers = new GetFootprintProjectHeaders();
            return GetFootprintProjectWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近访问的项目</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFootprintProjectResponse
        /// </returns>
        public async Task<GetFootprintProjectResponse> GetFootprintProjectAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFootprintProjectHeaders headers = new GetFootprintProjectHeaders();
            return await GetFootprintProjectWithOptionsAsync(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近访问的任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFootprintTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFootprintTaskResponse
        /// </returns>
        public GetFootprintTaskResponse GetFootprintTaskWithOptions(string userId, GetFootprintTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFootprintTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/footprints/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFootprintTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近访问的任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFootprintTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFootprintTaskResponse
        /// </returns>
        public async Task<GetFootprintTaskResponse> GetFootprintTaskWithOptionsAsync(string userId, GetFootprintTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFootprintTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/footprints/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFootprintTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近访问的任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFootprintTaskResponse
        /// </returns>
        public GetFootprintTaskResponse GetFootprintTask(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFootprintTaskHeaders headers = new GetFootprintTaskHeaders();
            return GetFootprintTaskWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近访问的任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFootprintTaskResponse
        /// </returns>
        public async Task<GetFootprintTaskResponse> GetFootprintTaskAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFootprintTaskHeaders headers = new GetFootprintTaskHeaders();
            return await GetFootprintTaskWithOptionsAsync(userId, headers, runtime);
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
        /// <para>获取协作空间成员列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectMembersV3Request
        /// </param>
        /// <param name="headers">
        /// GetProjectMembersV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectMembersV3Response
        /// </returns>
        public GetProjectMembersV3Response GetProjectMembersV3WithOptions(string userId, string projectId, GetProjectMembersV3Request request, GetProjectMembersV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectRoleId))
            {
                query["projectRoleId"] = request.ProjectRoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["userIds"] = request.UserIds;
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
                Action = "GetProjectMembersV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectMembersV3Response>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取协作空间成员列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectMembersV3Request
        /// </param>
        /// <param name="headers">
        /// GetProjectMembersV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectMembersV3Response
        /// </returns>
        public async Task<GetProjectMembersV3Response> GetProjectMembersV3WithOptionsAsync(string userId, string projectId, GetProjectMembersV3Request request, GetProjectMembersV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectRoleId))
            {
                query["projectRoleId"] = request.ProjectRoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                query["userIds"] = request.UserIds;
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
                Action = "GetProjectMembersV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectMembersV3Response>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取协作空间成员列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectMembersV3Request
        /// </param>
        /// 
        /// <returns>
        /// GetProjectMembersV3Response
        /// </returns>
        public GetProjectMembersV3Response GetProjectMembersV3(string userId, string projectId, GetProjectMembersV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectMembersV3Headers headers = new GetProjectMembersV3Headers();
            return GetProjectMembersV3WithOptions(userId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取协作空间成员列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectMembersV3Request
        /// </param>
        /// 
        /// <returns>
        /// GetProjectMembersV3Response
        /// </returns>
        public async Task<GetProjectMembersV3Response> GetProjectMembersV3Async(string userId, string projectId, GetProjectMembersV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectMembersV3Headers headers = new GetProjectMembersV3Headers();
            return await GetProjectMembersV3WithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目角色列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRolesV3Request
        /// </param>
        /// <param name="headers">
        /// GetProjectRolesV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectRolesV3Response
        /// </returns>
        public GetProjectRolesV3Response GetProjectRolesV3WithOptions(string userId, string projectId, GetProjectRolesV3Request request, GetProjectRolesV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeHidden))
            {
                query["includeHidden"] = request.IncludeHidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "GetProjectRolesV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectRolesV3Response>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目角色列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRolesV3Request
        /// </param>
        /// <param name="headers">
        /// GetProjectRolesV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectRolesV3Response
        /// </returns>
        public async Task<GetProjectRolesV3Response> GetProjectRolesV3WithOptionsAsync(string userId, string projectId, GetProjectRolesV3Request request, GetProjectRolesV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeHidden))
            {
                query["includeHidden"] = request.IncludeHidden;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Level))
            {
                query["level"] = request.Level;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "GetProjectRolesV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectRolesV3Response>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目角色列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRolesV3Request
        /// </param>
        /// 
        /// <returns>
        /// GetProjectRolesV3Response
        /// </returns>
        public GetProjectRolesV3Response GetProjectRolesV3(string userId, string projectId, GetProjectRolesV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectRolesV3Headers headers = new GetProjectRolesV3Headers();
            return GetProjectRolesV3WithOptions(userId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取项目角色列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRolesV3Request
        /// </param>
        /// 
        /// <returns>
        /// GetProjectRolesV3Response
        /// </returns>
        public async Task<GetProjectRolesV3Response> GetProjectRolesV3Async(string userId, string projectId, GetProjectRolesV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectRolesV3Headers headers = new GetProjectRolesV3Headers();
            return await GetProjectRolesV3WithOptionsAsync(userId, projectId, request, headers, runtime);
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
        /// <para>获取快办企业ID</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetThingOrgIdByDingOrgIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetThingOrgIdByDingOrgIdResponse
        /// </returns>
        public GetThingOrgIdByDingOrgIdResponse GetThingOrgIdByDingOrgIdWithOptions(GetThingOrgIdByDingOrgIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetThingOrgIdByDingOrgId",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetThingOrgIdByDingOrgIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取快办企业ID</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetThingOrgIdByDingOrgIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetThingOrgIdByDingOrgIdResponse
        /// </returns>
        public async Task<GetThingOrgIdByDingOrgIdResponse> GetThingOrgIdByDingOrgIdWithOptionsAsync(GetThingOrgIdByDingOrgIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetThingOrgIdByDingOrgId",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetThingOrgIdByDingOrgIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取快办企业ID</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetThingOrgIdByDingOrgIdResponse
        /// </returns>
        public GetThingOrgIdByDingOrgIdResponse GetThingOrgIdByDingOrgId()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetThingOrgIdByDingOrgIdHeaders headers = new GetThingOrgIdByDingOrgIdHeaders();
            return GetThingOrgIdByDingOrgIdWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取快办企业ID</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetThingOrgIdByDingOrgIdResponse
        /// </returns>
        public async Task<GetThingOrgIdByDingOrgIdResponse> GetThingOrgIdByDingOrgIdAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetThingOrgIdByDingOrgIdHeaders headers = new GetThingOrgIdByDingOrgIdHeaders();
            return await GetThingOrgIdByDingOrgIdWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户参与项目。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserJoinedProjectsV3Request
        /// </param>
        /// <param name="headers">
        /// GetUserJoinedProjectsV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserJoinedProjectsV3Response
        /// </returns>
        public GetUserJoinedProjectsV3Response GetUserJoinedProjectsV3WithOptions(string userId, GetUserJoinedProjectsV3Request request, GetUserJoinedProjectsV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                query["projectIds"] = request.ProjectIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectRoleLevels))
            {
                query["projectRoleLevels"] = request.ProjectRoleLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
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
                Action = "GetUserJoinedProjectsV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/userJoined",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserJoinedProjectsV3Response>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户参与项目。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserJoinedProjectsV3Request
        /// </param>
        /// <param name="headers">
        /// GetUserJoinedProjectsV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserJoinedProjectsV3Response
        /// </returns>
        public async Task<GetUserJoinedProjectsV3Response> GetUserJoinedProjectsV3WithOptionsAsync(string userId, GetUserJoinedProjectsV3Request request, GetUserJoinedProjectsV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIds))
            {
                query["projectIds"] = request.ProjectIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectRoleLevels))
            {
                query["projectRoleLevels"] = request.ProjectRoleLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
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
                Action = "GetUserJoinedProjectsV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/userJoined",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserJoinedProjectsV3Response>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户参与项目。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserJoinedProjectsV3Request
        /// </param>
        /// 
        /// <returns>
        /// GetUserJoinedProjectsV3Response
        /// </returns>
        public GetUserJoinedProjectsV3Response GetUserJoinedProjectsV3(string userId, GetUserJoinedProjectsV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserJoinedProjectsV3Headers headers = new GetUserJoinedProjectsV3Headers();
            return GetUserJoinedProjectsV3WithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户参与项目。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserJoinedProjectsV3Request
        /// </param>
        /// 
        /// <returns>
        /// GetUserJoinedProjectsV3Response
        /// </returns>
        public async Task<GetUserJoinedProjectsV3Response> GetUserJoinedProjectsV3Async(string userId, GetUserJoinedProjectsV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserJoinedProjectsV3Headers headers = new GetUserJoinedProjectsV3Headers();
            return await GetUserJoinedProjectsV3WithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取全部任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListAllTaskViewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllTaskViewResponse
        /// </returns>
        public ListAllTaskViewResponse ListAllTaskViewWithOptions(string userId, ListAllTaskViewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllTaskView",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/allTaskViews",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllTaskViewResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取全部任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListAllTaskViewHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllTaskViewResponse
        /// </returns>
        public async Task<ListAllTaskViewResponse> ListAllTaskViewWithOptionsAsync(string userId, ListAllTaskViewHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAllTaskView",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/allTaskViews",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllTaskViewResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取全部任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAllTaskViewResponse
        /// </returns>
        public ListAllTaskViewResponse ListAllTaskView(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllTaskViewHeaders headers = new ListAllTaskViewHeaders();
            return ListAllTaskViewWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取全部任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListAllTaskViewResponse
        /// </returns>
        public async Task<ListAllTaskViewResponse> ListAllTaskViewAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAllTaskViewHeaders headers = new ListAllTaskViewHeaders();
            return await ListAllTaskViewWithOptionsAsync(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询我的捷径</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMyShortcutViewsRequest
        /// </param>
        /// <param name="headers">
        /// ListMyShortcutViewsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMyShortcutViewsResponse
        /// </returns>
        public ListMyShortcutViewsResponse ListMyShortcutViewsWithOptions(string userId, ListMyShortcutViewsRequest request, ListMyShortcutViewsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListMyShortcutViews",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/shortcutViews",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMyShortcutViewsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询我的捷径</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMyShortcutViewsRequest
        /// </param>
        /// <param name="headers">
        /// ListMyShortcutViewsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMyShortcutViewsResponse
        /// </returns>
        public async Task<ListMyShortcutViewsResponse> ListMyShortcutViewsWithOptionsAsync(string userId, ListMyShortcutViewsRequest request, ListMyShortcutViewsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListMyShortcutViews",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/shortcutViews",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMyShortcutViewsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询我的捷径</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMyShortcutViewsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMyShortcutViewsResponse
        /// </returns>
        public ListMyShortcutViewsResponse ListMyShortcutViews(string userId, ListMyShortcutViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMyShortcutViewsHeaders headers = new ListMyShortcutViewsHeaders();
            return ListMyShortcutViewsWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询我的捷径</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMyShortcutViewsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMyShortcutViewsResponse
        /// </returns>
        public async Task<ListMyShortcutViewsResponse> ListMyShortcutViewsAsync(string userId, ListMyShortcutViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListMyShortcutViewsHeaders headers = new ListMyShortcutViewsHeaders();
            return await ListMyShortcutViewsWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自由任务和项目任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllTaskRequest
        /// </param>
        /// <param name="headers">
        /// QueryAllTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllTaskResponse
        /// </returns>
        public QueryAllTaskResponse QueryAllTaskWithOptions(string userId, QueryAllTaskRequest request, QueryAllTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryAllTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/tasks/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自由任务和项目任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllTaskRequest
        /// </param>
        /// <param name="headers">
        /// QueryAllTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllTaskResponse
        /// </returns>
        public async Task<QueryAllTaskResponse> QueryAllTaskWithOptionsAsync(string userId, QueryAllTaskRequest request, QueryAllTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryAllTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/tasks/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自由任务和项目任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllTaskResponse
        /// </returns>
        public QueryAllTaskResponse QueryAllTask(string userId, QueryAllTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllTaskHeaders headers = new QueryAllTaskHeaders();
            return QueryAllTaskWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自由任务和项目任务详情。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAllTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllTaskResponse
        /// </returns>
        public async Task<QueryAllTaskResponse> QueryAllTaskAsync(string userId, QueryAllTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllTaskHeaders headers = new QueryAllTaskHeaders();
            return await QueryAllTaskWithOptionsAsync(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询我的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskRequest
        /// </param>
        /// <param name="headers">
        /// QueryTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskResponse
        /// </returns>
        public QueryTaskResponse QueryTaskWithOptions(string userId, QueryTaskRequest request, QueryTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tql))
            {
                body["tql"] = request.Tql;
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
                Action = "QueryTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/tasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询我的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskRequest
        /// </param>
        /// <param name="headers">
        /// QueryTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskResponse
        /// </returns>
        public async Task<QueryTaskResponse> QueryTaskWithOptionsAsync(string userId, QueryTaskRequest request, QueryTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tql))
            {
                body["tql"] = request.Tql;
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
                Action = "QueryTask",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/tasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询我的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskResponse
        /// </returns>
        public QueryTaskResponse QueryTask(string userId, QueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTaskHeaders headers = new QueryTaskHeaders();
            return QueryTaskWithOptions(userId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询我的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskResponse
        /// </returns>
        public async Task<QueryTaskResponse> QueryTaskAsync(string userId, QueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTaskHeaders headers = new QueryTaskHeaders();
            return await QueryTaskWithOptionsAsync(userId, request, headers, runtime);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改项目成员的角色。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectMemberRoleV3Request
        /// </param>
        /// <param name="headers">
        /// UpdateProjectMemberRoleV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectMemberRoleV3Response
        /// </returns>
        public UpdateProjectMemberRoleV3Response UpdateProjectMemberRoleV3WithOptions(string userId, string projectId, UpdateProjectMemberRoleV3Request request, UpdateProjectMemberRoleV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                body["roleIds"] = request.RoleIds;
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
                Action = "UpdateProjectMemberRoleV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/roles/assign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectMemberRoleV3Response>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改项目成员的角色。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectMemberRoleV3Request
        /// </param>
        /// <param name="headers">
        /// UpdateProjectMemberRoleV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectMemberRoleV3Response
        /// </returns>
        public async Task<UpdateProjectMemberRoleV3Response> UpdateProjectMemberRoleV3WithOptionsAsync(string userId, string projectId, UpdateProjectMemberRoleV3Request request, UpdateProjectMemberRoleV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                body["roleIds"] = request.RoleIds;
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
                Action = "UpdateProjectMemberRoleV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId + "/roles/assign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectMemberRoleV3Response>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改项目成员的角色。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectMemberRoleV3Request
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectMemberRoleV3Response
        /// </returns>
        public UpdateProjectMemberRoleV3Response UpdateProjectMemberRoleV3(string userId, string projectId, UpdateProjectMemberRoleV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProjectMemberRoleV3Headers headers = new UpdateProjectMemberRoleV3Headers();
            return UpdateProjectMemberRoleV3WithOptions(userId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改项目成员的角色。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectMemberRoleV3Request
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectMemberRoleV3Response
        /// </returns>
        public async Task<UpdateProjectMemberRoleV3Response> UpdateProjectMemberRoleV3Async(string userId, string projectId, UpdateProjectMemberRoleV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProjectMemberRoleV3Headers headers = new UpdateProjectMemberRoleV3Headers();
            return await UpdateProjectMemberRoleV3WithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectV3Request
        /// </param>
        /// <param name="headers">
        /// UpdateProjectV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectV3Response
        /// </returns>
        public UpdateProjectV3Response UpdateProjectV3WithOptions(string userId, string projectId, UpdateProjectV3Request request, UpdateProjectV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "UpdateProjectV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectV3Response>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectV3Request
        /// </param>
        /// <param name="headers">
        /// UpdateProjectV3Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectV3Response
        /// </returns>
        public async Task<UpdateProjectV3Response> UpdateProjectV3WithOptionsAsync(string userId, string projectId, UpdateProjectV3Request request, UpdateProjectV3Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "UpdateProjectV3",
                Version = "teamSphere_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/teamSphere/users/" + userId + "/projects/" + projectId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectV3Response>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectV3Request
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectV3Response
        /// </returns>
        public UpdateProjectV3Response UpdateProjectV3(string userId, string projectId, UpdateProjectV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProjectV3Headers headers = new UpdateProjectV3Headers();
            return UpdateProjectV3WithOptions(userId, projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新协作空间。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectV3Request
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectV3Response
        /// </returns>
        public async Task<UpdateProjectV3Response> UpdateProjectV3Async(string userId, string projectId, UpdateProjectV3Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProjectV3Headers headers = new UpdateProjectV3Headers();
            return await UpdateProjectV3WithOptionsAsync(userId, projectId, request, headers, runtime);
        }

    }
}
