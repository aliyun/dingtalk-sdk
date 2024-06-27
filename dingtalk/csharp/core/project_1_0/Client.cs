// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkproject_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0
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
         * @summary 增加项目成员
         *
         * @param request AddProjectMemberRequest
         * @param headers AddProjectMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddProjectMemberResponse
         */
        public AddProjectMemberResponse AddProjectMemberWithOptions(string userId, string projectId, AddProjectMemberRequest request, AddProjectMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AddProjectMember",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProjectMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 增加项目成员
         *
         * @param request AddProjectMemberRequest
         * @param headers AddProjectMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddProjectMemberResponse
         */
        public async Task<AddProjectMemberResponse> AddProjectMemberWithOptionsAsync(string userId, string projectId, AddProjectMemberRequest request, AddProjectMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AddProjectMember",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProjectMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 增加项目成员
         *
         * @param request AddProjectMemberRequest
         * @return AddProjectMemberResponse
         */
        public AddProjectMemberResponse AddProjectMember(string userId, string projectId, AddProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProjectMemberHeaders headers = new AddProjectMemberHeaders();
            return AddProjectMemberWithOptions(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 增加项目成员
         *
         * @param request AddProjectMemberRequest
         * @return AddProjectMemberResponse
         */
        public async Task<AddProjectMemberResponse> AddProjectMemberAsync(string userId, string projectId, AddProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProjectMemberHeaders headers = new AddProjectMemberHeaders();
            return await AddProjectMemberWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 项目放入回收站
         *
         * @param headers ArchiveProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ArchiveProjectResponse
         */
        public ArchiveProjectResponse ArchiveProjectWithOptions(string userId, string projectId, ArchiveProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ArchiveProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/archive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ArchiveProjectResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 项目放入回收站
         *
         * @param headers ArchiveProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ArchiveProjectResponse
         */
        public async Task<ArchiveProjectResponse> ArchiveProjectWithOptionsAsync(string userId, string projectId, ArchiveProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ArchiveProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/archive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ArchiveProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 项目放入回收站
         *
         * @return ArchiveProjectResponse
         */
        public ArchiveProjectResponse ArchiveProject(string userId, string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ArchiveProjectHeaders headers = new ArchiveProjectHeaders();
            return ArchiveProjectWithOptions(userId, projectId, headers, runtime);
        }

        /**
         * @summary 项目放入回收站
         *
         * @return ArchiveProjectResponse
         */
        public async Task<ArchiveProjectResponse> ArchiveProjectAsync(string userId, string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ArchiveProjectHeaders headers = new ArchiveProjectHeaders();
            return await ArchiveProjectWithOptionsAsync(userId, projectId, headers, runtime);
        }

        /**
         * @summary 任务迁移至回收站
         *
         * @param headers ArchiveTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ArchiveTaskResponse
         */
        public ArchiveTaskResponse ArchiveTaskWithOptions(string userId, string taskId, ArchiveTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ArchiveTask",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/archive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ArchiveTaskResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 任务迁移至回收站
         *
         * @param headers ArchiveTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ArchiveTaskResponse
         */
        public async Task<ArchiveTaskResponse> ArchiveTaskWithOptionsAsync(string userId, string taskId, ArchiveTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ArchiveTask",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/archive",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ArchiveTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 任务迁移至回收站
         *
         * @return ArchiveTaskResponse
         */
        public ArchiveTaskResponse ArchiveTask(string userId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ArchiveTaskHeaders headers = new ArchiveTaskHeaders();
            return ArchiveTaskWithOptions(userId, taskId, headers, runtime);
        }

        /**
         * @summary 任务迁移至回收站
         *
         * @return ArchiveTaskResponse
         */
        public async Task<ArchiveTaskResponse> ArchiveTaskAsync(string userId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ArchiveTaskHeaders headers = new ArchiveTaskHeaders();
            return await ArchiveTaskWithOptionsAsync(userId, taskId, headers, runtime);
        }

        /**
         * @summary 创建自由任务
         *
         * @param request CreateOrganizationTaskRequest
         * @param headers CreateOrganizationTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOrganizationTaskResponse
         */
        public CreateOrganizationTaskResponse CreateOrganizationTaskWithOptions(string userId, CreateOrganizationTaskRequest request, CreateOrganizationTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["createTime"] = request.CreateTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
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
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrganizationTaskResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建自由任务
         *
         * @param request CreateOrganizationTaskRequest
         * @param headers CreateOrganizationTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOrganizationTaskResponse
         */
        public async Task<CreateOrganizationTaskResponse> CreateOrganizationTaskWithOptionsAsync(string userId, CreateOrganizationTaskRequest request, CreateOrganizationTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["createTime"] = request.CreateTime;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
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
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrganizationTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建自由任务
         *
         * @param request CreateOrganizationTaskRequest
         * @return CreateOrganizationTaskResponse
         */
        public CreateOrganizationTaskResponse CreateOrganizationTask(string userId, CreateOrganizationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrganizationTaskHeaders headers = new CreateOrganizationTaskHeaders();
            return CreateOrganizationTaskWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 创建自由任务
         *
         * @param request CreateOrganizationTaskRequest
         * @return CreateOrganizationTaskResponse
         */
        public async Task<CreateOrganizationTaskResponse> CreateOrganizationTaskAsync(string userId, CreateOrganizationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrganizationTaskHeaders headers = new CreateOrganizationTaskHeaders();
            return await CreateOrganizationTaskWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 录入计划工时
         *
         * @param request CreatePlanTimeRequest
         * @param headers CreatePlanTimeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePlanTimeResponse
         */
        public CreatePlanTimeResponse CreatePlanTimeWithOptions(string userId, CreatePlanTimeRequest request, CreatePlanTimeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantType))
            {
                query["tenantType"] = request.TenantType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludesHolidays))
            {
                body["includesHolidays"] = request.IncludesHolidays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDuration))
            {
                body["isDuration"] = request.IsDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["objectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanTime))
            {
                body["planTime"] = request.PlanTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitterId))
            {
                body["submitterId"] = request.SubmitterId;
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
                Action = "CreatePlanTime",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/planTimes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePlanTimeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 录入计划工时
         *
         * @param request CreatePlanTimeRequest
         * @param headers CreatePlanTimeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePlanTimeResponse
         */
        public async Task<CreatePlanTimeResponse> CreatePlanTimeWithOptionsAsync(string userId, CreatePlanTimeRequest request, CreatePlanTimeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantType))
            {
                query["tenantType"] = request.TenantType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludesHolidays))
            {
                body["includesHolidays"] = request.IncludesHolidays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDuration))
            {
                body["isDuration"] = request.IsDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["objectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanTime))
            {
                body["planTime"] = request.PlanTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitterId))
            {
                body["submitterId"] = request.SubmitterId;
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
                Action = "CreatePlanTime",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/planTimes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePlanTimeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 录入计划工时
         *
         * @param request CreatePlanTimeRequest
         * @return CreatePlanTimeResponse
         */
        public CreatePlanTimeResponse CreatePlanTime(string userId, CreatePlanTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePlanTimeHeaders headers = new CreatePlanTimeHeaders();
            return CreatePlanTimeWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 录入计划工时
         *
         * @param request CreatePlanTimeRequest
         * @return CreatePlanTimeResponse
         */
        public async Task<CreatePlanTimeResponse> CreatePlanTimeAsync(string userId, CreatePlanTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePlanTimeHeaders headers = new CreatePlanTimeHeaders();
            return await CreatePlanTimeWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @param headers CreateProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProjectWithOptions(string userId, CreateProjectRequest request, CreateProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @param headers CreateProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(string userId, CreateProjectRequest request, CreateProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProject(string userId, CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectHeaders headers = new CreateProjectHeaders();
            return CreateProjectWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectAsync(string userId, CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectHeaders headers = new CreateProjectHeaders();
            return await CreateProjectWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 根据项目模板创建项目
         *
         * @param request CreateProjectByTemplateRequest
         * @param headers CreateProjectByTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectByTemplateResponse
         */
        public CreateProjectByTemplateResponse CreateProjectByTemplateWithOptions(string userId, CreateProjectByTemplateRequest request, CreateProjectByTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
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
                Action = "CreateProjectByTemplate",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/templates/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectByTemplateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据项目模板创建项目
         *
         * @param request CreateProjectByTemplateRequest
         * @param headers CreateProjectByTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectByTemplateResponse
         */
        public async Task<CreateProjectByTemplateResponse> CreateProjectByTemplateWithOptionsAsync(string userId, CreateProjectByTemplateRequest request, CreateProjectByTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
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
                Action = "CreateProjectByTemplate",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/templates/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectByTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据项目模板创建项目
         *
         * @param request CreateProjectByTemplateRequest
         * @return CreateProjectByTemplateResponse
         */
        public CreateProjectByTemplateResponse CreateProjectByTemplate(string userId, CreateProjectByTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectByTemplateHeaders headers = new CreateProjectByTemplateHeaders();
            return CreateProjectByTemplateWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 根据项目模板创建项目
         *
         * @param request CreateProjectByTemplateRequest
         * @return CreateProjectByTemplateResponse
         */
        public async Task<CreateProjectByTemplateResponse> CreateProjectByTemplateAsync(string userId, CreateProjectByTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectByTemplateHeaders headers = new CreateProjectByTemplateHeaders();
            return await CreateProjectByTemplateWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 创建或更新项目概览中自定义字段值
         *
         * @param request CreateProjectCustomfieldStatusRequest
         * @param headers CreateProjectCustomfieldStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectCustomfieldStatusResponse
         */
        public CreateProjectCustomfieldStatusResponse CreateProjectCustomfieldStatusWithOptions(string userId, string projectId, CreateProjectCustomfieldStatusRequest request, CreateProjectCustomfieldStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldId))
            {
                body["customFieldId"] = request.CustomFieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldInstanceId))
            {
                body["customFieldInstanceId"] = request.CustomFieldInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldName))
            {
                body["customFieldName"] = request.CustomFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
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
                Action = "CreateProjectCustomfieldStatus",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/customfields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectCustomfieldStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建或更新项目概览中自定义字段值
         *
         * @param request CreateProjectCustomfieldStatusRequest
         * @param headers CreateProjectCustomfieldStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectCustomfieldStatusResponse
         */
        public async Task<CreateProjectCustomfieldStatusResponse> CreateProjectCustomfieldStatusWithOptionsAsync(string userId, string projectId, CreateProjectCustomfieldStatusRequest request, CreateProjectCustomfieldStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldId))
            {
                body["customFieldId"] = request.CustomFieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldInstanceId))
            {
                body["customFieldInstanceId"] = request.CustomFieldInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldName))
            {
                body["customFieldName"] = request.CustomFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
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
                Action = "CreateProjectCustomfieldStatus",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/customfields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectCustomfieldStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建或更新项目概览中自定义字段值
         *
         * @param request CreateProjectCustomfieldStatusRequest
         * @return CreateProjectCustomfieldStatusResponse
         */
        public CreateProjectCustomfieldStatusResponse CreateProjectCustomfieldStatus(string userId, string projectId, CreateProjectCustomfieldStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectCustomfieldStatusHeaders headers = new CreateProjectCustomfieldStatusHeaders();
            return CreateProjectCustomfieldStatusWithOptions(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 创建或更新项目概览中自定义字段值
         *
         * @param request CreateProjectCustomfieldStatusRequest
         * @return CreateProjectCustomfieldStatusResponse
         */
        public async Task<CreateProjectCustomfieldStatusResponse> CreateProjectCustomfieldStatusAsync(string userId, string projectId, CreateProjectCustomfieldStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectCustomfieldStatusHeaders headers = new CreateProjectCustomfieldStatusHeaders();
            return await CreateProjectCustomfieldStatusWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 创建项目任务
         *
         * @param request CreateTaskRequest
         * @param headers CreateTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTaskId))
            {
                body["parentTaskId"] = request.ParentTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenariofieldconfigId))
            {
                body["scenariofieldconfigId"] = request.ScenariofieldconfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StageId))
            {
                body["stageId"] = request.StageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
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
                Action = "CreateTask",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建项目任务
         *
         * @param request CreateTaskRequest
         * @param headers CreateTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTaskId))
            {
                body["parentTaskId"] = request.ParentTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenariofieldconfigId))
            {
                body["scenariofieldconfigId"] = request.ScenariofieldconfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StageId))
            {
                body["stageId"] = request.StageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
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
                Action = "CreateTask",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建项目任务
         *
         * @param request CreateTaskRequest
         * @return CreateTaskResponse
         */
        public CreateTaskResponse CreateTask(string userId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTaskHeaders headers = new CreateTaskHeaders();
            return CreateTaskWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 创建项目任务
         *
         * @param request CreateTaskRequest
         * @return CreateTaskResponse
         */
        public async Task<CreateTaskResponse> CreateTaskAsync(string userId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTaskHeaders headers = new CreateTaskHeaders();
            return await CreateTaskWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 创建任务关联对象
         *
         * @param request CreateTaskObjectLinkRequest
         * @param headers CreateTaskObjectLinkHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskObjectLinkResponse
         */
        public CreateTaskObjectLinkResponse CreateTaskObjectLinkWithOptions(string userId, string taskId, CreateTaskObjectLinkRequest request, CreateTaskObjectLinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkedData))
            {
                body["linkedData"] = request.LinkedData;
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
                Action = "CreateTaskObjectLink",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/objectLinks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskObjectLinkResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建任务关联对象
         *
         * @param request CreateTaskObjectLinkRequest
         * @param headers CreateTaskObjectLinkHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskObjectLinkResponse
         */
        public async Task<CreateTaskObjectLinkResponse> CreateTaskObjectLinkWithOptionsAsync(string userId, string taskId, CreateTaskObjectLinkRequest request, CreateTaskObjectLinkHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkedData))
            {
                body["linkedData"] = request.LinkedData;
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
                Action = "CreateTaskObjectLink",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/objectLinks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskObjectLinkResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建任务关联对象
         *
         * @param request CreateTaskObjectLinkRequest
         * @return CreateTaskObjectLinkResponse
         */
        public CreateTaskObjectLinkResponse CreateTaskObjectLink(string userId, string taskId, CreateTaskObjectLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTaskObjectLinkHeaders headers = new CreateTaskObjectLinkHeaders();
            return CreateTaskObjectLinkWithOptions(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 创建任务关联对象
         *
         * @param request CreateTaskObjectLinkRequest
         * @return CreateTaskObjectLinkResponse
         */
        public async Task<CreateTaskObjectLinkResponse> CreateTaskObjectLinkAsync(string userId, string taskId, CreateTaskObjectLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTaskObjectLinkHeaders headers = new CreateTaskObjectLinkHeaders();
            return await CreateTaskObjectLinkWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 录入实际工时接口
         *
         * @param request CreateWorkTimeRequest
         * @param headers CreateWorkTimeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkTimeResponse
         */
        public CreateWorkTimeResponse CreateWorkTimeWithOptions(string userId, CreateWorkTimeRequest request, CreateWorkTimeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantType))
            {
                query["tenantType"] = request.TenantType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludesHolidays))
            {
                body["includesHolidays"] = request.IncludesHolidays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDuration))
            {
                body["isDuration"] = request.IsDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["objectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitterId))
            {
                body["submitterId"] = request.SubmitterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkTime))
            {
                body["workTime"] = request.WorkTime;
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
                Action = "CreateWorkTime",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/workTimes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkTimeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 录入实际工时接口
         *
         * @param request CreateWorkTimeRequest
         * @param headers CreateWorkTimeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkTimeResponse
         */
        public async Task<CreateWorkTimeResponse> CreateWorkTimeWithOptionsAsync(string userId, CreateWorkTimeRequest request, CreateWorkTimeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantType))
            {
                query["tenantType"] = request.TenantType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludesHolidays))
            {
                body["includesHolidays"] = request.IncludesHolidays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDuration))
            {
                body["isDuration"] = request.IsDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["objectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                body["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitterId))
            {
                body["submitterId"] = request.SubmitterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkTime))
            {
                body["workTime"] = request.WorkTime;
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
                Action = "CreateWorkTime",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/workTimes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkTimeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 录入实际工时接口
         *
         * @param request CreateWorkTimeRequest
         * @return CreateWorkTimeResponse
         */
        public CreateWorkTimeResponse CreateWorkTime(string userId, CreateWorkTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkTimeHeaders headers = new CreateWorkTimeHeaders();
            return CreateWorkTimeWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 录入实际工时接口
         *
         * @param request CreateWorkTimeRequest
         * @return CreateWorkTimeResponse
         */
        public async Task<CreateWorkTimeResponse> CreateWorkTimeAsync(string userId, CreateWorkTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkTimeHeaders headers = new CreateWorkTimeHeaders();
            return await CreateWorkTimeWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 创建实际工时审批对象。
         *
         * @param request CreateWorkTimeApproveRequest
         * @param headers CreateWorkTimeApproveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkTimeApproveResponse
         */
        public CreateWorkTimeApproveResponse CreateWorkTimeApproveWithOptions(string userId, CreateWorkTimeApproveRequest request, CreateWorkTimeApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkTimeIds))
            {
                body["workTimeIds"] = request.WorkTimeIds;
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
                Action = "CreateWorkTimeApprove",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/workTimes/approvals",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkTimeApproveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建实际工时审批对象。
         *
         * @param request CreateWorkTimeApproveRequest
         * @param headers CreateWorkTimeApproveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWorkTimeApproveResponse
         */
        public async Task<CreateWorkTimeApproveResponse> CreateWorkTimeApproveWithOptionsAsync(string userId, CreateWorkTimeApproveRequest request, CreateWorkTimeApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkTimeIds))
            {
                body["workTimeIds"] = request.WorkTimeIds;
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
                Action = "CreateWorkTimeApprove",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/workTimes/approvals",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWorkTimeApproveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实际工时审批对象。
         *
         * @param request CreateWorkTimeApproveRequest
         * @return CreateWorkTimeApproveResponse
         */
        public CreateWorkTimeApproveResponse CreateWorkTimeApprove(string userId, CreateWorkTimeApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkTimeApproveHeaders headers = new CreateWorkTimeApproveHeaders();
            return CreateWorkTimeApproveWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 创建实际工时审批对象。
         *
         * @param request CreateWorkTimeApproveRequest
         * @return CreateWorkTimeApproveResponse
         */
        public async Task<CreateWorkTimeApproveResponse> CreateWorkTimeApproveAsync(string userId, CreateWorkTimeApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkTimeApproveHeaders headers = new CreateWorkTimeApproveHeaders();
            return await CreateWorkTimeApproveWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 删除项目成员
         *
         * @param request DeleteProjectMemberRequest
         * @param headers DeleteProjectMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectMemberResponse
         */
        public DeleteProjectMemberResponse DeleteProjectMemberWithOptions(string userId, string projectId, DeleteProjectMemberRequest request, DeleteProjectMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteProjectMember",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除项目成员
         *
         * @param request DeleteProjectMemberRequest
         * @param headers DeleteProjectMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectMemberResponse
         */
        public async Task<DeleteProjectMemberResponse> DeleteProjectMemberWithOptionsAsync(string userId, string projectId, DeleteProjectMemberRequest request, DeleteProjectMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteProjectMember",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除项目成员
         *
         * @param request DeleteProjectMemberRequest
         * @return DeleteProjectMemberResponse
         */
        public DeleteProjectMemberResponse DeleteProjectMember(string userId, string projectId, DeleteProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProjectMemberHeaders headers = new DeleteProjectMemberHeaders();
            return DeleteProjectMemberWithOptions(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 删除项目成员
         *
         * @param request DeleteProjectMemberRequest
         * @return DeleteProjectMemberResponse
         */
        public async Task<DeleteProjectMemberResponse> DeleteProjectMemberAsync(string userId, string projectId, DeleteProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProjectMemberHeaders headers = new DeleteProjectMemberHeaders();
            return await DeleteProjectMemberWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 删除任务
         *
         * @param headers DeleteTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTaskResponse
         */
        public DeleteTaskResponse DeleteTaskWithOptions(string userId, string taskId, DeleteTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteTask",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTaskResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除任务
         *
         * @param headers DeleteTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTaskResponse
         */
        public async Task<DeleteTaskResponse> DeleteTaskWithOptionsAsync(string userId, string taskId, DeleteTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteTask",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除任务
         *
         * @return DeleteTaskResponse
         */
        public DeleteTaskResponse DeleteTask(string userId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTaskHeaders headers = new DeleteTaskHeaders();
            return DeleteTaskWithOptions(userId, taskId, headers, runtime);
        }

        /**
         * @summary 删除任务
         *
         * @return DeleteTaskResponse
         */
        public async Task<DeleteTaskResponse> DeleteTaskAsync(string userId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTaskHeaders headers = new DeleteTaskHeaders();
            return await DeleteTaskWithOptionsAsync(userId, taskId, headers, runtime);
        }

        /**
         * @summary 根据企业Id获取部门
         *
         * @param request GetDeptsByOrgIdRequest
         * @param headers GetDeptsByOrgIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeptsByOrgIdResponse
         */
        public GetDeptsByOrgIdResponse GetDeptsByOrgIdWithOptions(GetDeptsByOrgIdRequest request, GetDeptsByOrgIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingAccessTokenType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingOrgId);
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
                Action = "GetDeptsByOrgId",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/orgs/depts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeptsByOrgIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据企业Id获取部门
         *
         * @param request GetDeptsByOrgIdRequest
         * @param headers GetDeptsByOrgIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeptsByOrgIdResponse
         */
        public async Task<GetDeptsByOrgIdResponse> GetDeptsByOrgIdWithOptionsAsync(GetDeptsByOrgIdRequest request, GetDeptsByOrgIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingAccessTokenType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingOrgId);
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
                Action = "GetDeptsByOrgId",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/orgs/depts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeptsByOrgIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据企业Id获取部门
         *
         * @param request GetDeptsByOrgIdRequest
         * @return GetDeptsByOrgIdResponse
         */
        public GetDeptsByOrgIdResponse GetDeptsByOrgId(GetDeptsByOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeptsByOrgIdHeaders headers = new GetDeptsByOrgIdHeaders();
            return GetDeptsByOrgIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据企业Id获取部门
         *
         * @param request GetDeptsByOrgIdRequest
         * @return GetDeptsByOrgIdResponse
         */
        public async Task<GetDeptsByOrgIdResponse> GetDeptsByOrgIdAsync(GetDeptsByOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeptsByOrgIdHeaders headers = new GetDeptsByOrgIdHeaders();
            return await GetDeptsByOrgIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据企业Id获取企业内的员工信息
         *
         * @param request GetEmpsByOrgIdRequest
         * @param headers GetEmpsByOrgIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmpsByOrgIdResponse
         */
        public GetEmpsByOrgIdResponse GetEmpsByOrgIdWithOptions(GetEmpsByOrgIdRequest request, GetEmpsByOrgIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDept))
            {
                query["needDept"] = request.NeedDept;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingAccessTokenType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingOrgId);
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
                Action = "GetEmpsByOrgId",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/orgs/employees",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmpsByOrgIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据企业Id获取企业内的员工信息
         *
         * @param request GetEmpsByOrgIdRequest
         * @param headers GetEmpsByOrgIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmpsByOrgIdResponse
         */
        public async Task<GetEmpsByOrgIdResponse> GetEmpsByOrgIdWithOptionsAsync(GetEmpsByOrgIdRequest request, GetEmpsByOrgIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDept))
            {
                query["needDept"] = request.NeedDept;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingAccessTokenType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingOrgId);
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
                Action = "GetEmpsByOrgId",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/orgs/employees",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmpsByOrgIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据企业Id获取企业内的员工信息
         *
         * @param request GetEmpsByOrgIdRequest
         * @return GetEmpsByOrgIdResponse
         */
        public GetEmpsByOrgIdResponse GetEmpsByOrgId(GetEmpsByOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmpsByOrgIdHeaders headers = new GetEmpsByOrgIdHeaders();
            return GetEmpsByOrgIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据企业Id获取企业内的员工信息
         *
         * @param request GetEmpsByOrgIdRequest
         * @return GetEmpsByOrgIdResponse
         */
        public async Task<GetEmpsByOrgIdResponse> GetEmpsByOrgIdAsync(GetEmpsByOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmpsByOrgIdHeaders headers = new GetEmpsByOrgIdHeaders();
            return await GetEmpsByOrgIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量获取任务详情
         *
         * @param request GetOrganizatioTaskByIdsRequest
         * @param headers GetOrganizatioTaskByIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrganizatioTaskByIdsResponse
         */
        public GetOrganizatioTaskByIdsResponse GetOrganizatioTaskByIdsWithOptions(string userId, GetOrganizatioTaskByIdsRequest request, GetOrganizatioTaskByIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["taskIds"] = request.TaskIds;
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
                Action = "GetOrganizatioTaskByIds",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizatioTaskByIdsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量获取任务详情
         *
         * @param request GetOrganizatioTaskByIdsRequest
         * @param headers GetOrganizatioTaskByIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrganizatioTaskByIdsResponse
         */
        public async Task<GetOrganizatioTaskByIdsResponse> GetOrganizatioTaskByIdsWithOptionsAsync(string userId, GetOrganizatioTaskByIdsRequest request, GetOrganizatioTaskByIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                query["taskIds"] = request.TaskIds;
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
                Action = "GetOrganizatioTaskByIds",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizatioTaskByIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量获取任务详情
         *
         * @param request GetOrganizatioTaskByIdsRequest
         * @return GetOrganizatioTaskByIdsResponse
         */
        public GetOrganizatioTaskByIdsResponse GetOrganizatioTaskByIds(string userId, GetOrganizatioTaskByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizatioTaskByIdsHeaders headers = new GetOrganizatioTaskByIdsHeaders();
            return GetOrganizatioTaskByIdsWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 批量获取任务详情
         *
         * @param request GetOrganizatioTaskByIdsRequest
         * @return GetOrganizatioTaskByIdsResponse
         */
        public async Task<GetOrganizatioTaskByIdsResponse> GetOrganizatioTaskByIdsAsync(string userId, GetOrganizatioTaskByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizatioTaskByIdsHeaders headers = new GetOrganizatioTaskByIdsHeaders();
            return await GetOrganizatioTaskByIdsWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 获取企业优先级列表
         *
         * @param headers GetOrganizationPriorityListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrganizationPriorityListResponse
         */
        public GetOrganizationPriorityListResponse GetOrganizationPriorityListWithOptions(string userId, GetOrganizationPriorityListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOrganizationPriorityList",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/priorities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationPriorityListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业优先级列表
         *
         * @param headers GetOrganizationPriorityListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrganizationPriorityListResponse
         */
        public async Task<GetOrganizationPriorityListResponse> GetOrganizationPriorityListWithOptionsAsync(string userId, GetOrganizationPriorityListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOrganizationPriorityList",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/priorities",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationPriorityListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业优先级列表
         *
         * @return GetOrganizationPriorityListResponse
         */
        public GetOrganizationPriorityListResponse GetOrganizationPriorityList(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationPriorityListHeaders headers = new GetOrganizationPriorityListHeaders();
            return GetOrganizationPriorityListWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 获取企业优先级列表
         *
         * @return GetOrganizationPriorityListResponse
         */
        public async Task<GetOrganizationPriorityListResponse> GetOrganizationPriorityListAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationPriorityListHeaders headers = new GetOrganizationPriorityListHeaders();
            return await GetOrganizationPriorityListWithOptionsAsync(userId, headers, runtime);
        }

        /**
         * @summary 获取自由任务详情
         *
         * @param headers GetOrganizationTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrganizationTaskResponse
         */
        public GetOrganizationTaskResponse GetOrganizationTaskWithOptions(string taskId, string userId, GetOrganizationTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOrganizationTask",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationTaskResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取自由任务详情
         *
         * @param headers GetOrganizationTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrganizationTaskResponse
         */
        public async Task<GetOrganizationTaskResponse> GetOrganizationTaskWithOptionsAsync(string taskId, string userId, GetOrganizationTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOrganizationTask",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrganizationTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取自由任务详情
         *
         * @return GetOrganizationTaskResponse
         */
        public GetOrganizationTaskResponse GetOrganizationTask(string taskId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationTaskHeaders headers = new GetOrganizationTaskHeaders();
            return GetOrganizationTaskWithOptions(taskId, userId, headers, runtime);
        }

        /**
         * @summary 获取自由任务详情
         *
         * @return GetOrganizationTaskResponse
         */
        public async Task<GetOrganizationTaskResponse> GetOrganizationTaskAsync(string taskId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationTaskHeaders headers = new GetOrganizationTaskHeaders();
            return await GetOrganizationTaskWithOptionsAsync(taskId, userId, headers, runtime);
        }

        /**
         * @summary 查询可见的项目分组
         *
         * @param request GetProjectGroupRequest
         * @param headers GetProjectGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectGroupResponse
         */
        public GetProjectGroupResponse GetProjectGroupWithOptions(string userId, GetProjectGroupRequest request, GetProjectGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewerId))
            {
                query["viewerId"] = request.ViewerId;
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
                Action = "GetProjectGroup",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询可见的项目分组
         *
         * @param request GetProjectGroupRequest
         * @param headers GetProjectGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectGroupResponse
         */
        public async Task<GetProjectGroupResponse> GetProjectGroupWithOptionsAsync(string userId, GetProjectGroupRequest request, GetProjectGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewerId))
            {
                query["viewerId"] = request.ViewerId;
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
                Action = "GetProjectGroup",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询可见的项目分组
         *
         * @param request GetProjectGroupRequest
         * @return GetProjectGroupResponse
         */
        public GetProjectGroupResponse GetProjectGroup(string userId, GetProjectGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectGroupHeaders headers = new GetProjectGroupHeaders();
            return GetProjectGroupWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 查询可见的项目分组
         *
         * @param request GetProjectGroupRequest
         * @return GetProjectGroupResponse
         */
        public async Task<GetProjectGroupResponse> GetProjectGroupAsync(string userId, GetProjectGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectGroupHeaders headers = new GetProjectGroupHeaders();
            return await GetProjectGroupWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 获取项目成员
         *
         * @param request GetProjectMemebersRequest
         * @param headers GetProjectMemebersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectMemebersResponse
         */
        public GetProjectMemebersResponse GetProjectMemebersWithOptions(string userId, string projectId, GetProjectMemebersRequest request, GetProjectMemebersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectRoleId))
            {
                query["projectRoleId"] = request.ProjectRoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["skip"] = request.Skip;
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
                Action = "GetProjectMemebers",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectMemebersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取项目成员
         *
         * @param request GetProjectMemebersRequest
         * @param headers GetProjectMemebersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectMemebersResponse
         */
        public async Task<GetProjectMemebersResponse> GetProjectMemebersWithOptionsAsync(string userId, string projectId, GetProjectMemebersRequest request, GetProjectMemebersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectRoleId))
            {
                query["projectRoleId"] = request.ProjectRoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Skip))
            {
                query["skip"] = request.Skip;
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
                Action = "GetProjectMemebers",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectMemebersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取项目成员
         *
         * @param request GetProjectMemebersRequest
         * @return GetProjectMemebersResponse
         */
        public GetProjectMemebersResponse GetProjectMemebers(string userId, string projectId, GetProjectMemebersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectMemebersHeaders headers = new GetProjectMemebersHeaders();
            return GetProjectMemebersWithOptions(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 获取项目成员
         *
         * @param request GetProjectMemebersRequest
         * @return GetProjectMemebersResponse
         */
        public async Task<GetProjectMemebersResponse> GetProjectMemebersAsync(string userId, string projectId, GetProjectMemebersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectMemebersHeaders headers = new GetProjectMemebersHeaders();
            return await GetProjectMemebersWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 查询项目状态
         *
         * @param headers GetProjectStatusListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectStatusListResponse
         */
        public GetProjectStatusListResponse GetProjectStatusListWithOptions(string userId, string projectId, GetProjectStatusListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetProjectStatusList",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/statuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectStatusListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询项目状态
         *
         * @param headers GetProjectStatusListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectStatusListResponse
         */
        public async Task<GetProjectStatusListResponse> GetProjectStatusListWithOptionsAsync(string userId, string projectId, GetProjectStatusListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetProjectStatusList",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/statuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectStatusListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询项目状态
         *
         * @return GetProjectStatusListResponse
         */
        public GetProjectStatusListResponse GetProjectStatusList(string userId, string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectStatusListHeaders headers = new GetProjectStatusListHeaders();
            return GetProjectStatusListWithOptions(userId, projectId, headers, runtime);
        }

        /**
         * @summary 查询项目状态
         *
         * @return GetProjectStatusListResponse
         */
        public async Task<GetProjectStatusListResponse> GetProjectStatusListAsync(string userId, string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectStatusListHeaders headers = new GetProjectStatusListHeaders();
            return await GetProjectStatusListWithOptionsAsync(userId, projectId, headers, runtime);
        }

        /**
         * @summary 获取任务详情
         *
         * @param request GetTaskByIdsRequest
         * @param headers GetTaskByIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskByIdsResponse
         */
        public GetTaskByIdsResponse GetTaskByIdsWithOptions(string userId, GetTaskByIdsRequest request, GetTaskByIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTaskId))
            {
                query["parentTaskId"] = request.ParentTaskId;
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
                Action = "GetTaskByIds",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskByIdsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取任务详情
         *
         * @param request GetTaskByIdsRequest
         * @param headers GetTaskByIdsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskByIdsResponse
         */
        public async Task<GetTaskByIdsResponse> GetTaskByIdsWithOptionsAsync(string userId, GetTaskByIdsRequest request, GetTaskByIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentTaskId))
            {
                query["parentTaskId"] = request.ParentTaskId;
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
                Action = "GetTaskByIds",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskByIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务详情
         *
         * @param request GetTaskByIdsRequest
         * @return GetTaskByIdsResponse
         */
        public GetTaskByIdsResponse GetTaskByIds(string userId, GetTaskByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskByIdsHeaders headers = new GetTaskByIdsHeaders();
            return GetTaskByIdsWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 获取任务详情
         *
         * @param request GetTaskByIdsRequest
         * @return GetTaskByIdsResponse
         */
        public async Task<GetTaskByIdsResponse> GetTaskByIdsAsync(string userId, GetTaskByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskByIdsHeaders headers = new GetTaskByIdsHeaders();
            return await GetTaskByIdsWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 获取Teambition企业Id
         *
         * @param request GetTbOrgIdByDingOrgIdRequest
         * @param headers GetTbOrgIdByDingOrgIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTbOrgIdByDingOrgIdResponse
         */
        public GetTbOrgIdByDingOrgIdResponse GetTbOrgIdByDingOrgIdWithOptions(GetTbOrgIdByDingOrgIdRequest request, GetTbOrgIdByDingOrgIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                query["optUserId"] = request.OptUserId;
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
                Action = "GetTbOrgIdByDingOrgId",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/teambition/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTbOrgIdByDingOrgIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取Teambition企业Id
         *
         * @param request GetTbOrgIdByDingOrgIdRequest
         * @param headers GetTbOrgIdByDingOrgIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTbOrgIdByDingOrgIdResponse
         */
        public async Task<GetTbOrgIdByDingOrgIdResponse> GetTbOrgIdByDingOrgIdWithOptionsAsync(GetTbOrgIdByDingOrgIdRequest request, GetTbOrgIdByDingOrgIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                query["optUserId"] = request.OptUserId;
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
                Action = "GetTbOrgIdByDingOrgId",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/teambition/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTbOrgIdByDingOrgIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Teambition企业Id
         *
         * @param request GetTbOrgIdByDingOrgIdRequest
         * @return GetTbOrgIdByDingOrgIdResponse
         */
        public GetTbOrgIdByDingOrgIdResponse GetTbOrgIdByDingOrgId(GetTbOrgIdByDingOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbOrgIdByDingOrgIdHeaders headers = new GetTbOrgIdByDingOrgIdHeaders();
            return GetTbOrgIdByDingOrgIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取Teambition企业Id
         *
         * @param request GetTbOrgIdByDingOrgIdRequest
         * @return GetTbOrgIdByDingOrgIdResponse
         */
        public async Task<GetTbOrgIdByDingOrgIdResponse> GetTbOrgIdByDingOrgIdAsync(GetTbOrgIdByDingOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbOrgIdByDingOrgIdHeaders headers = new GetTbOrgIdByDingOrgIdHeaders();
            return await GetTbOrgIdByDingOrgIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取项目灰度标
         *
         * @param request GetTbProjectGrayRequest
         * @param headers GetTbProjectGrayHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTbProjectGrayResponse
         */
        public GetTbProjectGrayResponse GetTbProjectGrayWithOptions(GetTbProjectGrayRequest request, GetTbProjectGrayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["label"] = request.Label;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingAccessTokenType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingCorpId))
            {
                realHeaders["dingCorpId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingCorpId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingIsvOrgId))
            {
                realHeaders["dingIsvOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingIsvOrgId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingOrgId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingSuiteKey))
            {
                realHeaders["dingSuiteKey"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingSuiteKey);
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
                Action = "GetTbProjectGray",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/projects/gray",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTbProjectGrayResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取项目灰度标
         *
         * @param request GetTbProjectGrayRequest
         * @param headers GetTbProjectGrayHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTbProjectGrayResponse
         */
        public async Task<GetTbProjectGrayResponse> GetTbProjectGrayWithOptionsAsync(GetTbProjectGrayRequest request, GetTbProjectGrayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["label"] = request.Label;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingAccessTokenType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingCorpId))
            {
                realHeaders["dingCorpId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingCorpId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingIsvOrgId))
            {
                realHeaders["dingIsvOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingIsvOrgId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingOrgId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingSuiteKey))
            {
                realHeaders["dingSuiteKey"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingSuiteKey);
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
                Action = "GetTbProjectGray",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/projects/gray",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTbProjectGrayResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取项目灰度标
         *
         * @param request GetTbProjectGrayRequest
         * @return GetTbProjectGrayResponse
         */
        public GetTbProjectGrayResponse GetTbProjectGray(GetTbProjectGrayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectGrayHeaders headers = new GetTbProjectGrayHeaders();
            return GetTbProjectGrayWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取项目灰度标
         *
         * @param request GetTbProjectGrayRequest
         * @return GetTbProjectGrayResponse
         */
        public async Task<GetTbProjectGrayResponse> GetTbProjectGrayAsync(GetTbProjectGrayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectGrayHeaders headers = new GetTbProjectGrayHeaders();
            return await GetTbProjectGrayWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取项目来源
         *
         * @param headers GetTbProjectSourceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTbProjectSourceResponse
         */
        public GetTbProjectSourceResponse GetTbProjectSourceWithOptions(GetTbProjectSourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingAccessTokenType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingCorpId))
            {
                realHeaders["dingCorpId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingCorpId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingIsvOrgId))
            {
                realHeaders["dingIsvOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingIsvOrgId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingOrgId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingSuiteKey))
            {
                realHeaders["dingSuiteKey"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingSuiteKey);
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
                Action = "GetTbProjectSource",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/projects/source",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTbProjectSourceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取项目来源
         *
         * @param headers GetTbProjectSourceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTbProjectSourceResponse
         */
        public async Task<GetTbProjectSourceResponse> GetTbProjectSourceWithOptionsAsync(GetTbProjectSourceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingAccessTokenType))
            {
                realHeaders["dingAccessTokenType"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingAccessTokenType);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingCorpId))
            {
                realHeaders["dingCorpId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingCorpId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingIsvOrgId))
            {
                realHeaders["dingIsvOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingIsvOrgId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingOrgId))
            {
                realHeaders["dingOrgId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingOrgId);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.DingSuiteKey))
            {
                realHeaders["dingSuiteKey"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.DingSuiteKey);
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
                Action = "GetTbProjectSource",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/projects/source",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTbProjectSourceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取项目来源
         *
         * @return GetTbProjectSourceResponse
         */
        public GetTbProjectSourceResponse GetTbProjectSource()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectSourceHeaders headers = new GetTbProjectSourceHeaders();
            return GetTbProjectSourceWithOptions(headers, runtime);
        }

        /**
         * @summary 获取项目来源
         *
         * @return GetTbProjectSourceResponse
         */
        public async Task<GetTbProjectSourceResponse> GetTbProjectSourceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectSourceHeaders headers = new GetTbProjectSourceHeaders();
            return await GetTbProjectSourceWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 根据钉钉UserId获取Teambition用户Id
         *
         * @param request GetTbUserIdByStaffIdRequest
         * @param headers GetTbUserIdByStaffIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTbUserIdByStaffIdResponse
         */
        public GetTbUserIdByStaffIdResponse GetTbUserIdByStaffIdWithOptions(GetTbUserIdByStaffIdRequest request, GetTbUserIdByStaffIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                query["optUserId"] = request.OptUserId;
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
                Action = "GetTbUserIdByStaffId",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/teambition/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTbUserIdByStaffIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据钉钉UserId获取Teambition用户Id
         *
         * @param request GetTbUserIdByStaffIdRequest
         * @param headers GetTbUserIdByStaffIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTbUserIdByStaffIdResponse
         */
        public async Task<GetTbUserIdByStaffIdResponse> GetTbUserIdByStaffIdWithOptionsAsync(GetTbUserIdByStaffIdRequest request, GetTbUserIdByStaffIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUserId))
            {
                query["optUserId"] = request.OptUserId;
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
                Action = "GetTbUserIdByStaffId",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/teambition/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTbUserIdByStaffIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据钉钉UserId获取Teambition用户Id
         *
         * @param request GetTbUserIdByStaffIdRequest
         * @return GetTbUserIdByStaffIdResponse
         */
        public GetTbUserIdByStaffIdResponse GetTbUserIdByStaffId(GetTbUserIdByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbUserIdByStaffIdHeaders headers = new GetTbUserIdByStaffIdHeaders();
            return GetTbUserIdByStaffIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据钉钉UserId获取Teambition用户Id
         *
         * @param request GetTbUserIdByStaffIdRequest
         * @return GetTbUserIdByStaffIdResponse
         */
        public async Task<GetTbUserIdByStaffIdResponse> GetTbUserIdByStaffIdAsync(GetTbUserIdByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbUserIdByStaffIdHeaders headers = new GetTbUserIdByStaffIdHeaders();
            return await GetTbUserIdByStaffIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户加入的项目
         *
         * @param request GetUserJoinedProjectRequest
         * @param headers GetUserJoinedProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserJoinedProjectResponse
         */
        public GetUserJoinedProjectResponse GetUserJoinedProjectWithOptions(string userId, GetUserJoinedProjectRequest request, GetUserJoinedProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUserJoinedProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/joinProjects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserJoinedProjectResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户加入的项目
         *
         * @param request GetUserJoinedProjectRequest
         * @param headers GetUserJoinedProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserJoinedProjectResponse
         */
        public async Task<GetUserJoinedProjectResponse> GetUserJoinedProjectWithOptionsAsync(string userId, GetUserJoinedProjectRequest request, GetUserJoinedProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUserJoinedProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/joinProjects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserJoinedProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户加入的项目
         *
         * @param request GetUserJoinedProjectRequest
         * @return GetUserJoinedProjectResponse
         */
        public GetUserJoinedProjectResponse GetUserJoinedProject(string userId, GetUserJoinedProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserJoinedProjectHeaders headers = new GetUserJoinedProjectHeaders();
            return GetUserJoinedProjectWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 获取用户加入的项目
         *
         * @param request GetUserJoinedProjectRequest
         * @return GetUserJoinedProjectResponse
         */
        public async Task<GetUserJoinedProjectResponse> GetUserJoinedProjectAsync(string userId, GetUserJoinedProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserJoinedProjectHeaders headers = new GetUserJoinedProjectHeaders();
            return await GetUserJoinedProjectWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 查询项目
         *
         * @param request QueryProjectRequest
         * @param headers QueryProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryProjectResponse
         */
        public QueryProjectResponse QueryProjectWithOptions(string userId, QueryProjectRequest request, QueryProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProjectResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询项目
         *
         * @param request QueryProjectRequest
         * @param headers QueryProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryProjectResponse
         */
        public async Task<QueryProjectResponse> QueryProjectWithOptionsAsync(string userId, QueryProjectRequest request, QueryProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询项目
         *
         * @param request QueryProjectRequest
         * @return QueryProjectResponse
         */
        public QueryProjectResponse QueryProject(string userId, QueryProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProjectHeaders headers = new QueryProjectHeaders();
            return QueryProjectWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 查询项目
         *
         * @param request QueryProjectRequest
         * @return QueryProjectResponse
         */
        public async Task<QueryProjectResponse> QueryProjectAsync(string userId, QueryProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProjectHeaders headers = new QueryProjectHeaders();
            return await QueryProjectWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 查询项目中的任务
         *
         * @param request QueryTaskOfProjectRequest
         * @param headers QueryTaskOfProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskOfProjectResponse
         */
        public QueryTaskOfProjectResponse QueryTaskOfProjectWithOptions(string userId, string projectId, QueryTaskOfProjectRequest request, QueryTaskOfProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
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
                Action = "QueryTaskOfProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projectIds/" + projectId + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskOfProjectResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询项目中的任务
         *
         * @param request QueryTaskOfProjectRequest
         * @param headers QueryTaskOfProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskOfProjectResponse
         */
        public async Task<QueryTaskOfProjectResponse> QueryTaskOfProjectWithOptionsAsync(string userId, string projectId, QueryTaskOfProjectRequest request, QueryTaskOfProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
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
                Action = "QueryTaskOfProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projectIds/" + projectId + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskOfProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询项目中的任务
         *
         * @param request QueryTaskOfProjectRequest
         * @return QueryTaskOfProjectResponse
         */
        public QueryTaskOfProjectResponse QueryTaskOfProject(string userId, string projectId, QueryTaskOfProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTaskOfProjectHeaders headers = new QueryTaskOfProjectHeaders();
            return QueryTaskOfProjectWithOptions(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 查询项目中的任务
         *
         * @param request QueryTaskOfProjectRequest
         * @return QueryTaskOfProjectResponse
         */
        public async Task<QueryTaskOfProjectResponse> QueryTaskOfProjectAsync(string userId, string projectId, QueryTaskOfProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTaskOfProjectHeaders headers = new QueryTaskOfProjectHeaders();
            return await QueryTaskOfProjectWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 获取任务列表
         *
         * @param request SeachTaskStageRequest
         * @param headers SeachTaskStageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SeachTaskStageResponse
         */
        public SeachTaskStageResponse SeachTaskStageWithOptions(string userId, string projectId, SeachTaskStageRequest request, SeachTaskStageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskListId))
            {
                query["taskListId"] = request.TaskListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStageIds))
            {
                query["taskStageIds"] = request.TaskStageIds;
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
                Action = "SeachTaskStage",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskStages/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SeachTaskStageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取任务列表
         *
         * @param request SeachTaskStageRequest
         * @param headers SeachTaskStageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SeachTaskStageResponse
         */
        public async Task<SeachTaskStageResponse> SeachTaskStageWithOptionsAsync(string userId, string projectId, SeachTaskStageRequest request, SeachTaskStageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskListId))
            {
                query["taskListId"] = request.TaskListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStageIds))
            {
                query["taskStageIds"] = request.TaskStageIds;
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
                Action = "SeachTaskStage",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskStages/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SeachTaskStageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取任务列表
         *
         * @param request SeachTaskStageRequest
         * @return SeachTaskStageResponse
         */
        public SeachTaskStageResponse SeachTaskStage(string userId, string projectId, SeachTaskStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SeachTaskStageHeaders headers = new SeachTaskStageHeaders();
            return SeachTaskStageWithOptions(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 获取任务列表
         *
         * @param request SeachTaskStageRequest
         * @return SeachTaskStageResponse
         */
        public async Task<SeachTaskStageResponse> SeachTaskStageAsync(string userId, string projectId, SeachTaskStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SeachTaskStageHeaders headers = new SeachTaskStageHeaders();
            return await SeachTaskStageWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 通过TQL搜索自由任务和项目任务ID。
         *
         * @param request SearchAllTasksByTqlRequest
         * @param headers SearchAllTasksByTqlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchAllTasksByTqlResponse
         */
        public SearchAllTasksByTqlResponse SearchAllTasksByTqlWithOptions(string userId, SearchAllTasksByTqlRequest request, SearchAllTasksByTqlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tql/tasks/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchAllTasksByTqlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过TQL搜索自由任务和项目任务ID。
         *
         * @param request SearchAllTasksByTqlRequest
         * @param headers SearchAllTasksByTqlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchAllTasksByTqlResponse
         */
        public async Task<SearchAllTasksByTqlResponse> SearchAllTasksByTqlWithOptionsAsync(string userId, SearchAllTasksByTqlRequest request, SearchAllTasksByTqlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tql/tasks/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchAllTasksByTqlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过TQL搜索自由任务和项目任务ID。
         *
         * @param request SearchAllTasksByTqlRequest
         * @return SearchAllTasksByTqlResponse
         */
        public SearchAllTasksByTqlResponse SearchAllTasksByTql(string userId, SearchAllTasksByTqlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchAllTasksByTqlHeaders headers = new SearchAllTasksByTqlHeaders();
            return SearchAllTasksByTqlWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 通过TQL搜索自由任务和项目任务ID。
         *
         * @param request SearchAllTasksByTqlRequest
         * @return SearchAllTasksByTqlResponse
         */
        public async Task<SearchAllTasksByTqlResponse> SearchAllTasksByTqlAsync(string userId, SearchAllTasksByTqlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchAllTasksByTqlHeaders headers = new SearchAllTasksByTqlHeaders();
            return await SearchAllTasksByTqlWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 查询企业自定义字段
         *
         * @param request SearchOranizationCustomfieldRequest
         * @param headers SearchOranizationCustomfieldHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchOranizationCustomfieldResponse
         */
        public SearchOranizationCustomfieldResponse SearchOranizationCustomfieldWithOptions(string userId, SearchOranizationCustomfieldRequest request, SearchOranizationCustomfieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldIds))
            {
                query["customFieldIds"] = request.CustomFieldIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["instanceIds"] = request.InstanceIds;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
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
                Action = "SearchOranizationCustomfield",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/customfields/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchOranizationCustomfieldResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询企业自定义字段
         *
         * @param request SearchOranizationCustomfieldRequest
         * @param headers SearchOranizationCustomfieldHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchOranizationCustomfieldResponse
         */
        public async Task<SearchOranizationCustomfieldResponse> SearchOranizationCustomfieldWithOptionsAsync(string userId, SearchOranizationCustomfieldRequest request, SearchOranizationCustomfieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldIds))
            {
                query["customFieldIds"] = request.CustomFieldIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["instanceIds"] = request.InstanceIds;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
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
                Action = "SearchOranizationCustomfield",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/customfields/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchOranizationCustomfieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询企业自定义字段
         *
         * @param request SearchOranizationCustomfieldRequest
         * @return SearchOranizationCustomfieldResponse
         */
        public SearchOranizationCustomfieldResponse SearchOranizationCustomfield(string userId, SearchOranizationCustomfieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOranizationCustomfieldHeaders headers = new SearchOranizationCustomfieldHeaders();
            return SearchOranizationCustomfieldWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 查询企业自定义字段
         *
         * @param request SearchOranizationCustomfieldRequest
         * @return SearchOranizationCustomfieldResponse
         */
        public async Task<SearchOranizationCustomfieldResponse> SearchOranizationCustomfieldAsync(string userId, SearchOranizationCustomfieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOranizationCustomfieldHeaders headers = new SearchOranizationCustomfieldHeaders();
            return await SearchOranizationCustomfieldWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 查询项目自定义字段
         *
         * @param request SearchProjectCustomfieldRequest
         * @param headers SearchProjectCustomfieldHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchProjectCustomfieldResponse
         */
        public SearchProjectCustomfieldResponse SearchProjectCustomfieldWithOptions(string userId, string projectId, SearchProjectCustomfieldRequest request, SearchProjectCustomfieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldIds))
            {
                query["customFieldIds"] = request.CustomFieldIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["instanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioFieldConfigId))
            {
                query["scenarioFieldConfigId"] = request.ScenarioFieldConfigId;
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
                Action = "SearchProjectCustomfield",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/customfields/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchProjectCustomfieldResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询项目自定义字段
         *
         * @param request SearchProjectCustomfieldRequest
         * @param headers SearchProjectCustomfieldHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchProjectCustomfieldResponse
         */
        public async Task<SearchProjectCustomfieldResponse> SearchProjectCustomfieldWithOptionsAsync(string userId, string projectId, SearchProjectCustomfieldRequest request, SearchProjectCustomfieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldIds))
            {
                query["customFieldIds"] = request.CustomFieldIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["instanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioFieldConfigId))
            {
                query["scenarioFieldConfigId"] = request.ScenarioFieldConfigId;
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
                Action = "SearchProjectCustomfield",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/customfields/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchProjectCustomfieldResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询项目自定义字段
         *
         * @param request SearchProjectCustomfieldRequest
         * @return SearchProjectCustomfieldResponse
         */
        public SearchProjectCustomfieldResponse SearchProjectCustomfield(string userId, string projectId, SearchProjectCustomfieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchProjectCustomfieldHeaders headers = new SearchProjectCustomfieldHeaders();
            return SearchProjectCustomfieldWithOptions(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 查询项目自定义字段
         *
         * @param request SearchProjectCustomfieldRequest
         * @return SearchProjectCustomfieldResponse
         */
        public async Task<SearchProjectCustomfieldResponse> SearchProjectCustomfieldAsync(string userId, string projectId, SearchProjectCustomfieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchProjectCustomfieldHeaders headers = new SearchProjectCustomfieldHeaders();
            return await SearchProjectCustomfieldWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 按项目模板名字搜索企业自定义模板
         *
         * @param request SearchProjectTemplateRequest
         * @param headers SearchProjectTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchProjectTemplateResponse
         */
        public SearchProjectTemplateResponse SearchProjectTemplateWithOptions(string userId, SearchProjectTemplateRequest request, SearchProjectTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
                Action = "SearchProjectTemplate",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchProjectTemplateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 按项目模板名字搜索企业自定义模板
         *
         * @param request SearchProjectTemplateRequest
         * @param headers SearchProjectTemplateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchProjectTemplateResponse
         */
        public async Task<SearchProjectTemplateResponse> SearchProjectTemplateWithOptionsAsync(string userId, SearchProjectTemplateRequest request, SearchProjectTemplateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
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
                Action = "SearchProjectTemplate",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchProjectTemplateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 按项目模板名字搜索企业自定义模板
         *
         * @param request SearchProjectTemplateRequest
         * @return SearchProjectTemplateResponse
         */
        public SearchProjectTemplateResponse SearchProjectTemplate(string userId, SearchProjectTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchProjectTemplateHeaders headers = new SearchProjectTemplateHeaders();
            return SearchProjectTemplateWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 按项目模板名字搜索企业自定义模板
         *
         * @param request SearchProjectTemplateRequest
         * @return SearchProjectTemplateResponse
         */
        public async Task<SearchProjectTemplateResponse> SearchProjectTemplateAsync(string userId, SearchProjectTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchProjectTemplateHeaders headers = new SearchProjectTemplateHeaders();
            return await SearchProjectTemplateWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 查询任务工作流
         *
         * @param request SearchTaskFlowRequest
         * @param headers SearchTaskFlowHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchTaskFlowResponse
         */
        public SearchTaskFlowResponse SearchTaskFlowWithOptions(string userId, string projectId, SearchTaskFlowRequest request, SearchTaskFlowHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskflowIds))
            {
                query["taskflowIds"] = request.TaskflowIds;
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
                Action = "SearchTaskFlow",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskflows/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTaskFlowResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询任务工作流
         *
         * @param request SearchTaskFlowRequest
         * @param headers SearchTaskFlowHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchTaskFlowResponse
         */
        public async Task<SearchTaskFlowResponse> SearchTaskFlowWithOptionsAsync(string userId, string projectId, SearchTaskFlowRequest request, SearchTaskFlowHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskflowIds))
            {
                query["taskflowIds"] = request.TaskflowIds;
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
                Action = "SearchTaskFlow",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskflows/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTaskFlowResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询任务工作流
         *
         * @param request SearchTaskFlowRequest
         * @return SearchTaskFlowResponse
         */
        public SearchTaskFlowResponse SearchTaskFlow(string userId, string projectId, SearchTaskFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskFlowHeaders headers = new SearchTaskFlowHeaders();
            return SearchTaskFlowWithOptions(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 查询任务工作流
         *
         * @param request SearchTaskFlowRequest
         * @return SearchTaskFlowResponse
         */
        public async Task<SearchTaskFlowResponse> SearchTaskFlowAsync(string userId, string projectId, SearchTaskFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskFlowHeaders headers = new SearchTaskFlowHeaders();
            return await SearchTaskFlowWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 查询任务分组
         *
         * @param request SearchTaskListRequest
         * @param headers SearchTaskListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchTaskListResponse
         */
        public SearchTaskListResponse SearchTaskListWithOptions(string userId, string projectId, SearchTaskListRequest request, SearchTaskListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskListIds))
            {
                query["taskListIds"] = request.TaskListIds;
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
                Action = "SearchTaskList",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskLists/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTaskListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询任务分组
         *
         * @param request SearchTaskListRequest
         * @param headers SearchTaskListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchTaskListResponse
         */
        public async Task<SearchTaskListResponse> SearchTaskListWithOptionsAsync(string userId, string projectId, SearchTaskListRequest request, SearchTaskListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskListIds))
            {
                query["taskListIds"] = request.TaskListIds;
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
                Action = "SearchTaskList",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskLists/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTaskListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询任务分组
         *
         * @param request SearchTaskListRequest
         * @return SearchTaskListResponse
         */
        public SearchTaskListResponse SearchTaskList(string userId, string projectId, SearchTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskListHeaders headers = new SearchTaskListHeaders();
            return SearchTaskListWithOptions(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 查询任务分组
         *
         * @param request SearchTaskListRequest
         * @return SearchTaskListResponse
         */
        public async Task<SearchTaskListResponse> SearchTaskListAsync(string userId, string projectId, SearchTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskListHeaders headers = new SearchTaskListHeaders();
            return await SearchTaskListWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 搜索任务工作流状态
         *
         * @param request SearchTaskflowStatusRequest
         * @param headers SearchTaskflowStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchTaskflowStatusResponse
         */
        public SearchTaskflowStatusResponse SearchTaskflowStatusWithOptions(string userId, string projectId, SearchTaskflowStatusRequest request, SearchTaskflowStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TfIds))
            {
                query["tfIds"] = request.TfIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TfsIds))
            {
                query["tfsIds"] = request.TfsIds;
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
                Action = "SearchTaskflowStatus",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskflowStatuses/search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTaskflowStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 搜索任务工作流状态
         *
         * @param request SearchTaskflowStatusRequest
         * @param headers SearchTaskflowStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchTaskflowStatusResponse
         */
        public async Task<SearchTaskflowStatusResponse> SearchTaskflowStatusWithOptionsAsync(string userId, string projectId, SearchTaskflowStatusRequest request, SearchTaskflowStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TfIds))
            {
                query["tfIds"] = request.TfIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TfsIds))
            {
                query["tfsIds"] = request.TfsIds;
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
                Action = "SearchTaskflowStatus",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/taskflowStatuses/search",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchTaskflowStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 搜索任务工作流状态
         *
         * @param request SearchTaskflowStatusRequest
         * @return SearchTaskflowStatusResponse
         */
        public SearchTaskflowStatusResponse SearchTaskflowStatus(string userId, string projectId, SearchTaskflowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskflowStatusHeaders headers = new SearchTaskflowStatusHeaders();
            return SearchTaskflowStatusWithOptions(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 搜索任务工作流状态
         *
         * @param request SearchTaskflowStatusRequest
         * @return SearchTaskflowStatusResponse
         */
        public async Task<SearchTaskflowStatusResponse> SearchTaskflowStatusAsync(string userId, string projectId, SearchTaskflowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskflowStatusHeaders headers = new SearchTaskflowStatusHeaders();
            return await SearchTaskflowStatusWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 查询用户任务列表
         *
         * @param request SearchUserTaskRequest
         * @param headers SearchUserTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchUserTaskResponse
         */
        public SearchUserTaskResponse SearchUserTaskWithOptions(string userId, SearchUserTaskRequest request, SearchUserTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                query["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tql))
            {
                query["tql"] = request.Tql;
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
                Action = "SearchUserTask",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchUserTaskResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询用户任务列表
         *
         * @param request SearchUserTaskRequest
         * @param headers SearchUserTaskHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchUserTaskResponse
         */
        public async Task<SearchUserTaskResponse> SearchUserTaskWithOptionsAsync(string userId, SearchUserTaskRequest request, SearchUserTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                query["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tql))
            {
                query["tql"] = request.Tql;
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
                Action = "SearchUserTask",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchUserTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户任务列表
         *
         * @param request SearchUserTaskRequest
         * @return SearchUserTaskResponse
         */
        public SearchUserTaskResponse SearchUserTask(string userId, SearchUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchUserTaskHeaders headers = new SearchUserTaskHeaders();
            return SearchUserTaskWithOptions(userId, request, headers, runtime);
        }

        /**
         * @summary 查询用户任务列表
         *
         * @param request SearchUserTaskRequest
         * @return SearchUserTaskResponse
         */
        public async Task<SearchUserTaskResponse> SearchUserTaskAsync(string userId, SearchUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchUserTaskHeaders headers = new SearchUserTaskHeaders();
            return await SearchUserTaskWithOptionsAsync(userId, request, headers, runtime);
        }

        /**
         * @summary 归档项目
         *
         * @param headers SuspendProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SuspendProjectResponse
         */
        public SuspendProjectResponse SuspendProjectWithOptions(string projectId, string userId, SuspendProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SuspendProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/suspend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendProjectResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 归档项目
         *
         * @param headers SuspendProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SuspendProjectResponse
         */
        public async Task<SuspendProjectResponse> SuspendProjectWithOptionsAsync(string projectId, string userId, SuspendProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SuspendProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/suspend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 归档项目
         *
         * @return SuspendProjectResponse
         */
        public SuspendProjectResponse SuspendProject(string projectId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SuspendProjectHeaders headers = new SuspendProjectHeaders();
            return SuspendProjectWithOptions(projectId, userId, headers, runtime);
        }

        /**
         * @summary 归档项目
         *
         * @return SuspendProjectResponse
         */
        public async Task<SuspendProjectResponse> SuspendProjectAsync(string projectId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SuspendProjectHeaders headers = new SuspendProjectHeaders();
            return await SuspendProjectWithOptionsAsync(projectId, userId, headers, runtime);
        }

        /**
         * @summary 恢复项目归档
         *
         * @param headers UnSuspendProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnSuspendProjectResponse
         */
        public UnSuspendProjectResponse UnSuspendProjectWithOptions(string projectId, string userId, UnSuspendProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UnSuspendProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/unsuspend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnSuspendProjectResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 恢复项目归档
         *
         * @param headers UnSuspendProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnSuspendProjectResponse
         */
        public async Task<UnSuspendProjectResponse> UnSuspendProjectWithOptionsAsync(string projectId, string userId, UnSuspendProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UnSuspendProject",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/unsuspend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnSuspendProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 恢复项目归档
         *
         * @return UnSuspendProjectResponse
         */
        public UnSuspendProjectResponse UnSuspendProject(string projectId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnSuspendProjectHeaders headers = new UnSuspendProjectHeaders();
            return UnSuspendProjectWithOptions(projectId, userId, headers, runtime);
        }

        /**
         * @summary 恢复项目归档
         *
         * @return UnSuspendProjectResponse
         */
        public async Task<UnSuspendProjectResponse> UnSuspendProjectAsync(string projectId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnSuspendProjectHeaders headers = new UnSuspendProjectHeaders();
            return await UnSuspendProjectWithOptionsAsync(projectId, userId, headers, runtime);
        }

        /**
         * @summary 更新任务自定义字段的值
         *
         * @param request UpdateCustomfieldValueRequest
         * @param headers UpdateCustomfieldValueHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomfieldValueResponse
         */
        public UpdateCustomfieldValueResponse UpdateCustomfieldValueWithOptions(string userId, string taskId, UpdateCustomfieldValueRequest request, UpdateCustomfieldValueHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldId))
            {
                body["customFieldId"] = request.CustomFieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldName))
            {
                body["customFieldName"] = request.CustomFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
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
                Action = "UpdateCustomfieldValue",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/customFields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomfieldValueResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新任务自定义字段的值
         *
         * @param request UpdateCustomfieldValueRequest
         * @param headers UpdateCustomfieldValueHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomfieldValueResponse
         */
        public async Task<UpdateCustomfieldValueResponse> UpdateCustomfieldValueWithOptionsAsync(string userId, string taskId, UpdateCustomfieldValueRequest request, UpdateCustomfieldValueHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldId))
            {
                body["customFieldId"] = request.CustomFieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomFieldName))
            {
                body["customFieldName"] = request.CustomFieldName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
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
                Action = "UpdateCustomfieldValue",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/customFields",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomfieldValueResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务自定义字段的值
         *
         * @param request UpdateCustomfieldValueRequest
         * @return UpdateCustomfieldValueResponse
         */
        public UpdateCustomfieldValueResponse UpdateCustomfieldValue(string userId, string taskId, UpdateCustomfieldValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomfieldValueHeaders headers = new UpdateCustomfieldValueHeaders();
            return UpdateCustomfieldValueWithOptions(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务自定义字段的值
         *
         * @param request UpdateCustomfieldValueRequest
         * @return UpdateCustomfieldValueResponse
         */
        public async Task<UpdateCustomfieldValueResponse> UpdateCustomfieldValueAsync(string userId, string taskId, UpdateCustomfieldValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomfieldValueHeaders headers = new UpdateCustomfieldValueHeaders();
            return await UpdateCustomfieldValueWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更改自由任务标题
         *
         * @param request UpdateOrganizationTaskContentRequest
         * @param headers UpdateOrganizationTaskContentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskContentResponse
         */
        public UpdateOrganizationTaskContentResponse UpdateOrganizationTaskContentWithOptions(string taskId, string userId, UpdateOrganizationTaskContentRequest request, UpdateOrganizationTaskContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateOrganizationTaskContent",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/contents",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskContentResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更改自由任务标题
         *
         * @param request UpdateOrganizationTaskContentRequest
         * @param headers UpdateOrganizationTaskContentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskContentResponse
         */
        public async Task<UpdateOrganizationTaskContentResponse> UpdateOrganizationTaskContentWithOptionsAsync(string taskId, string userId, UpdateOrganizationTaskContentRequest request, UpdateOrganizationTaskContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateOrganizationTaskContent",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/contents",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskContentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更改自由任务标题
         *
         * @param request UpdateOrganizationTaskContentRequest
         * @return UpdateOrganizationTaskContentResponse
         */
        public UpdateOrganizationTaskContentResponse UpdateOrganizationTaskContent(string taskId, string userId, UpdateOrganizationTaskContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskContentHeaders headers = new UpdateOrganizationTaskContentHeaders();
            return UpdateOrganizationTaskContentWithOptions(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更改自由任务标题
         *
         * @param request UpdateOrganizationTaskContentRequest
         * @return UpdateOrganizationTaskContentResponse
         */
        public async Task<UpdateOrganizationTaskContentResponse> UpdateOrganizationTaskContentAsync(string taskId, string userId, UpdateOrganizationTaskContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskContentHeaders headers = new UpdateOrganizationTaskContentHeaders();
            return await UpdateOrganizationTaskContentWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更新自由任务截止时间
         *
         * @param request UpdateOrganizationTaskDueDateRequest
         * @param headers UpdateOrganizationTaskDueDateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskDueDateResponse
         */
        public UpdateOrganizationTaskDueDateResponse UpdateOrganizationTaskDueDateWithOptions(string taskId, string userId, UpdateOrganizationTaskDueDateRequest request, UpdateOrganizationTaskDueDateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "UpdateOrganizationTaskDueDate",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/dueDates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskDueDateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新自由任务截止时间
         *
         * @param request UpdateOrganizationTaskDueDateRequest
         * @param headers UpdateOrganizationTaskDueDateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskDueDateResponse
         */
        public async Task<UpdateOrganizationTaskDueDateResponse> UpdateOrganizationTaskDueDateWithOptionsAsync(string taskId, string userId, UpdateOrganizationTaskDueDateRequest request, UpdateOrganizationTaskDueDateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "UpdateOrganizationTaskDueDate",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/dueDates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskDueDateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新自由任务截止时间
         *
         * @param request UpdateOrganizationTaskDueDateRequest
         * @return UpdateOrganizationTaskDueDateResponse
         */
        public UpdateOrganizationTaskDueDateResponse UpdateOrganizationTaskDueDate(string taskId, string userId, UpdateOrganizationTaskDueDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskDueDateHeaders headers = new UpdateOrganizationTaskDueDateHeaders();
            return UpdateOrganizationTaskDueDateWithOptions(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更新自由任务截止时间
         *
         * @param request UpdateOrganizationTaskDueDateRequest
         * @return UpdateOrganizationTaskDueDateResponse
         */
        public async Task<UpdateOrganizationTaskDueDateResponse> UpdateOrganizationTaskDueDateAsync(string taskId, string userId, UpdateOrganizationTaskDueDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskDueDateHeaders headers = new UpdateOrganizationTaskDueDateHeaders();
            return await UpdateOrganizationTaskDueDateWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更改自由任务执行者
         *
         * @param request UpdateOrganizationTaskExecutorRequest
         * @param headers UpdateOrganizationTaskExecutorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskExecutorResponse
         */
        public UpdateOrganizationTaskExecutorResponse UpdateOrganizationTaskExecutorWithOptions(string taskId, string userId, UpdateOrganizationTaskExecutorRequest request, UpdateOrganizationTaskExecutorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
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
                Action = "UpdateOrganizationTaskExecutor",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/executors",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskExecutorResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更改自由任务执行者
         *
         * @param request UpdateOrganizationTaskExecutorRequest
         * @param headers UpdateOrganizationTaskExecutorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskExecutorResponse
         */
        public async Task<UpdateOrganizationTaskExecutorResponse> UpdateOrganizationTaskExecutorWithOptionsAsync(string taskId, string userId, UpdateOrganizationTaskExecutorRequest request, UpdateOrganizationTaskExecutorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
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
                Action = "UpdateOrganizationTaskExecutor",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/executors",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskExecutorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更改自由任务执行者
         *
         * @param request UpdateOrganizationTaskExecutorRequest
         * @return UpdateOrganizationTaskExecutorResponse
         */
        public UpdateOrganizationTaskExecutorResponse UpdateOrganizationTaskExecutor(string taskId, string userId, UpdateOrganizationTaskExecutorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskExecutorHeaders headers = new UpdateOrganizationTaskExecutorHeaders();
            return UpdateOrganizationTaskExecutorWithOptions(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更改自由任务执行者
         *
         * @param request UpdateOrganizationTaskExecutorRequest
         * @return UpdateOrganizationTaskExecutorResponse
         */
        public async Task<UpdateOrganizationTaskExecutorResponse> UpdateOrganizationTaskExecutorAsync(string taskId, string userId, UpdateOrganizationTaskExecutorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskExecutorHeaders headers = new UpdateOrganizationTaskExecutorHeaders();
            return await UpdateOrganizationTaskExecutorWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更新自由任务参与者
         *
         * @param request UpdateOrganizationTaskInvolveMembersRequest
         * @param headers UpdateOrganizationTaskInvolveMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskInvolveMembersResponse
         */
        public UpdateOrganizationTaskInvolveMembersResponse UpdateOrganizationTaskInvolveMembersWithOptions(string taskId, string userId, UpdateOrganizationTaskInvolveMembersRequest request, UpdateOrganizationTaskInvolveMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddInvolvers))
            {
                body["addInvolvers"] = request.AddInvolvers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelInvolvers))
            {
                body["delInvolvers"] = request.DelInvolvers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvolveMembers))
            {
                body["involveMembers"] = request.InvolveMembers;
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
                Action = "UpdateOrganizationTaskInvolveMembers",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/involveMembers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskInvolveMembersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新自由任务参与者
         *
         * @param request UpdateOrganizationTaskInvolveMembersRequest
         * @param headers UpdateOrganizationTaskInvolveMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskInvolveMembersResponse
         */
        public async Task<UpdateOrganizationTaskInvolveMembersResponse> UpdateOrganizationTaskInvolveMembersWithOptionsAsync(string taskId, string userId, UpdateOrganizationTaskInvolveMembersRequest request, UpdateOrganizationTaskInvolveMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddInvolvers))
            {
                body["addInvolvers"] = request.AddInvolvers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelInvolvers))
            {
                body["delInvolvers"] = request.DelInvolvers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvolveMembers))
            {
                body["involveMembers"] = request.InvolveMembers;
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
                Action = "UpdateOrganizationTaskInvolveMembers",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/involveMembers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskInvolveMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新自由任务参与者
         *
         * @param request UpdateOrganizationTaskInvolveMembersRequest
         * @return UpdateOrganizationTaskInvolveMembersResponse
         */
        public UpdateOrganizationTaskInvolveMembersResponse UpdateOrganizationTaskInvolveMembers(string taskId, string userId, UpdateOrganizationTaskInvolveMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskInvolveMembersHeaders headers = new UpdateOrganizationTaskInvolveMembersHeaders();
            return UpdateOrganizationTaskInvolveMembersWithOptions(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更新自由任务参与者
         *
         * @param request UpdateOrganizationTaskInvolveMembersRequest
         * @return UpdateOrganizationTaskInvolveMembersResponse
         */
        public async Task<UpdateOrganizationTaskInvolveMembersResponse> UpdateOrganizationTaskInvolveMembersAsync(string taskId, string userId, UpdateOrganizationTaskInvolveMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskInvolveMembersHeaders headers = new UpdateOrganizationTaskInvolveMembersHeaders();
            return await UpdateOrganizationTaskInvolveMembersWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更改自由任务备注
         *
         * @param request UpdateOrganizationTaskNoteRequest
         * @param headers UpdateOrganizationTaskNoteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskNoteResponse
         */
        public UpdateOrganizationTaskNoteResponse UpdateOrganizationTaskNoteWithOptions(string taskId, string userId, UpdateOrganizationTaskNoteRequest request, UpdateOrganizationTaskNoteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["note"] = request.Note;
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
                Action = "UpdateOrganizationTaskNote",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/notes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskNoteResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更改自由任务备注
         *
         * @param request UpdateOrganizationTaskNoteRequest
         * @param headers UpdateOrganizationTaskNoteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskNoteResponse
         */
        public async Task<UpdateOrganizationTaskNoteResponse> UpdateOrganizationTaskNoteWithOptionsAsync(string taskId, string userId, UpdateOrganizationTaskNoteRequest request, UpdateOrganizationTaskNoteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["note"] = request.Note;
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
                Action = "UpdateOrganizationTaskNote",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/notes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskNoteResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更改自由任务备注
         *
         * @param request UpdateOrganizationTaskNoteRequest
         * @return UpdateOrganizationTaskNoteResponse
         */
        public UpdateOrganizationTaskNoteResponse UpdateOrganizationTaskNote(string taskId, string userId, UpdateOrganizationTaskNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskNoteHeaders headers = new UpdateOrganizationTaskNoteHeaders();
            return UpdateOrganizationTaskNoteWithOptions(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更改自由任务备注
         *
         * @param request UpdateOrganizationTaskNoteRequest
         * @return UpdateOrganizationTaskNoteResponse
         */
        public async Task<UpdateOrganizationTaskNoteResponse> UpdateOrganizationTaskNoteAsync(string taskId, string userId, UpdateOrganizationTaskNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskNoteHeaders headers = new UpdateOrganizationTaskNoteHeaders();
            return await UpdateOrganizationTaskNoteWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更新自由任务优先级
         *
         * @param request UpdateOrganizationTaskPriorityRequest
         * @param headers UpdateOrganizationTaskPriorityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskPriorityResponse
         */
        public UpdateOrganizationTaskPriorityResponse UpdateOrganizationTaskPriorityWithOptions(string taskId, string userId, UpdateOrganizationTaskPriorityRequest request, UpdateOrganizationTaskPriorityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
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
                Action = "UpdateOrganizationTaskPriority",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/priorities",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskPriorityResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新自由任务优先级
         *
         * @param request UpdateOrganizationTaskPriorityRequest
         * @param headers UpdateOrganizationTaskPriorityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskPriorityResponse
         */
        public async Task<UpdateOrganizationTaskPriorityResponse> UpdateOrganizationTaskPriorityWithOptionsAsync(string taskId, string userId, UpdateOrganizationTaskPriorityRequest request, UpdateOrganizationTaskPriorityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
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
                Action = "UpdateOrganizationTaskPriority",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/priorities",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskPriorityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新自由任务优先级
         *
         * @param request UpdateOrganizationTaskPriorityRequest
         * @return UpdateOrganizationTaskPriorityResponse
         */
        public UpdateOrganizationTaskPriorityResponse UpdateOrganizationTaskPriority(string taskId, string userId, UpdateOrganizationTaskPriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskPriorityHeaders headers = new UpdateOrganizationTaskPriorityHeaders();
            return UpdateOrganizationTaskPriorityWithOptions(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更新自由任务优先级
         *
         * @param request UpdateOrganizationTaskPriorityRequest
         * @return UpdateOrganizationTaskPriorityResponse
         */
        public async Task<UpdateOrganizationTaskPriorityResponse> UpdateOrganizationTaskPriorityAsync(string taskId, string userId, UpdateOrganizationTaskPriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskPriorityHeaders headers = new UpdateOrganizationTaskPriorityHeaders();
            return await UpdateOrganizationTaskPriorityWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更改自由任务状态
         *
         * @param request UpdateOrganizationTaskStatusRequest
         * @param headers UpdateOrganizationTaskStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskStatusResponse
         */
        public UpdateOrganizationTaskStatusResponse UpdateOrganizationTaskStatusWithOptions(string taskId, string userId, UpdateOrganizationTaskStatusRequest request, UpdateOrganizationTaskStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
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
                Action = "UpdateOrganizationTaskStatus",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/states",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更改自由任务状态
         *
         * @param request UpdateOrganizationTaskStatusRequest
         * @param headers UpdateOrganizationTaskStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOrganizationTaskStatusResponse
         */
        public async Task<UpdateOrganizationTaskStatusResponse> UpdateOrganizationTaskStatusWithOptionsAsync(string taskId, string userId, UpdateOrganizationTaskStatusRequest request, UpdateOrganizationTaskStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableActivity))
            {
                body["disableActivity"] = request.DisableActivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableNotification))
            {
                body["disableNotification"] = request.DisableNotification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
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
                Action = "UpdateOrganizationTaskStatus",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/organizations/users/" + userId + "/tasks/" + taskId + "/states",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOrganizationTaskStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更改自由任务状态
         *
         * @param request UpdateOrganizationTaskStatusRequest
         * @return UpdateOrganizationTaskStatusResponse
         */
        public UpdateOrganizationTaskStatusResponse UpdateOrganizationTaskStatus(string taskId, string userId, UpdateOrganizationTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskStatusHeaders headers = new UpdateOrganizationTaskStatusHeaders();
            return UpdateOrganizationTaskStatusWithOptions(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更改自由任务状态
         *
         * @param request UpdateOrganizationTaskStatusRequest
         * @return UpdateOrganizationTaskStatusResponse
         */
        public async Task<UpdateOrganizationTaskStatusResponse> UpdateOrganizationTaskStatusAsync(string taskId, string userId, UpdateOrganizationTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskStatusHeaders headers = new UpdateOrganizationTaskStatusHeaders();
            return await UpdateOrganizationTaskStatusWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

        /**
         * @summary 更新项目的分组
         *
         * @param request UpdateProjectGroupRequest
         * @param headers UpdateProjectGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectGroupResponse
         */
        public UpdateProjectGroupResponse UpdateProjectGroupWithOptions(string userId, string projectId, UpdateProjectGroupRequest request, UpdateProjectGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddProjectGroupIds))
            {
                body["addProjectGroupIds"] = request.AddProjectGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelProjectGroupIds))
            {
                body["delProjectGroupIds"] = request.DelProjectGroupIds;
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
                Action = "UpdateProjectGroup",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/groups",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新项目的分组
         *
         * @param request UpdateProjectGroupRequest
         * @param headers UpdateProjectGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectGroupResponse
         */
        public async Task<UpdateProjectGroupResponse> UpdateProjectGroupWithOptionsAsync(string userId, string projectId, UpdateProjectGroupRequest request, UpdateProjectGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddProjectGroupIds))
            {
                body["addProjectGroupIds"] = request.AddProjectGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelProjectGroupIds))
            {
                body["delProjectGroupIds"] = request.DelProjectGroupIds;
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
                Action = "UpdateProjectGroup",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/projects/" + projectId + "/groups",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新项目的分组
         *
         * @param request UpdateProjectGroupRequest
         * @return UpdateProjectGroupResponse
         */
        public UpdateProjectGroupResponse UpdateProjectGroup(string userId, string projectId, UpdateProjectGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProjectGroupHeaders headers = new UpdateProjectGroupHeaders();
            return UpdateProjectGroupWithOptions(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 更新项目的分组
         *
         * @param request UpdateProjectGroupRequest
         * @return UpdateProjectGroupResponse
         */
        public async Task<UpdateProjectGroupResponse> UpdateProjectGroupAsync(string userId, string projectId, UpdateProjectGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProjectGroupHeaders headers = new UpdateProjectGroupHeaders();
            return await UpdateProjectGroupWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        /**
         * @summary 更新任务标题
         *
         * @param request UpdateTaskContentRequest
         * @param headers UpdateTaskContentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskContentResponse
         */
        public UpdateTaskContentResponse UpdateTaskContentWithOptions(string userId, string taskId, UpdateTaskContentRequest request, UpdateTaskContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
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
                Action = "UpdateTaskContent",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/contents",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskContentResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新任务标题
         *
         * @param request UpdateTaskContentRequest
         * @param headers UpdateTaskContentHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskContentResponse
         */
        public async Task<UpdateTaskContentResponse> UpdateTaskContentWithOptionsAsync(string userId, string taskId, UpdateTaskContentRequest request, UpdateTaskContentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
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
                Action = "UpdateTaskContent",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/contents",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskContentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务标题
         *
         * @param request UpdateTaskContentRequest
         * @return UpdateTaskContentResponse
         */
        public UpdateTaskContentResponse UpdateTaskContent(string userId, string taskId, UpdateTaskContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskContentHeaders headers = new UpdateTaskContentHeaders();
            return UpdateTaskContentWithOptions(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务标题
         *
         * @param request UpdateTaskContentRequest
         * @return UpdateTaskContentResponse
         */
        public async Task<UpdateTaskContentResponse> UpdateTaskContentAsync(string userId, string taskId, UpdateTaskContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskContentHeaders headers = new UpdateTaskContentHeaders();
            return await UpdateTaskContentWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务截止时间
         *
         * @param request UpdateTaskDueDateRequest
         * @param headers UpdateTaskDueDateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskDueDateResponse
         */
        public UpdateTaskDueDateResponse UpdateTaskDueDateWithOptions(string userId, string taskId, UpdateTaskDueDateRequest request, UpdateTaskDueDateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueDate))
            {
                body["dueDate"] = request.DueDate;
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
                Action = "UpdateTaskDueDate",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/dueDates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskDueDateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新任务截止时间
         *
         * @param request UpdateTaskDueDateRequest
         * @param headers UpdateTaskDueDateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskDueDateResponse
         */
        public async Task<UpdateTaskDueDateResponse> UpdateTaskDueDateWithOptionsAsync(string userId, string taskId, UpdateTaskDueDateRequest request, UpdateTaskDueDateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueDate))
            {
                body["dueDate"] = request.DueDate;
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
                Action = "UpdateTaskDueDate",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/dueDates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskDueDateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务截止时间
         *
         * @param request UpdateTaskDueDateRequest
         * @return UpdateTaskDueDateResponse
         */
        public UpdateTaskDueDateResponse UpdateTaskDueDate(string userId, string taskId, UpdateTaskDueDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskDueDateHeaders headers = new UpdateTaskDueDateHeaders();
            return UpdateTaskDueDateWithOptions(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务截止时间
         *
         * @param request UpdateTaskDueDateRequest
         * @return UpdateTaskDueDateResponse
         */
        public async Task<UpdateTaskDueDateResponse> UpdateTaskDueDateAsync(string userId, string taskId, UpdateTaskDueDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskDueDateHeaders headers = new UpdateTaskDueDateHeaders();
            return await UpdateTaskDueDateWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务执行者
         *
         * @param request UpdateTaskExecutorRequest
         * @param headers UpdateTaskExecutorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskExecutorResponse
         */
        public UpdateTaskExecutorResponse UpdateTaskExecutorWithOptions(string userId, string taskId, UpdateTaskExecutorRequest request, UpdateTaskExecutorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
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
                Action = "UpdateTaskExecutor",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/executors",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskExecutorResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新任务执行者
         *
         * @param request UpdateTaskExecutorRequest
         * @param headers UpdateTaskExecutorHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskExecutorResponse
         */
        public async Task<UpdateTaskExecutorResponse> UpdateTaskExecutorWithOptionsAsync(string userId, string taskId, UpdateTaskExecutorRequest request, UpdateTaskExecutorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorId))
            {
                body["executorId"] = request.ExecutorId;
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
                Action = "UpdateTaskExecutor",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/executors",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskExecutorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务执行者
         *
         * @param request UpdateTaskExecutorRequest
         * @return UpdateTaskExecutorResponse
         */
        public UpdateTaskExecutorResponse UpdateTaskExecutor(string userId, string taskId, UpdateTaskExecutorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskExecutorHeaders headers = new UpdateTaskExecutorHeaders();
            return UpdateTaskExecutorWithOptions(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务执行者
         *
         * @param request UpdateTaskExecutorRequest
         * @return UpdateTaskExecutorResponse
         */
        public async Task<UpdateTaskExecutorResponse> UpdateTaskExecutorAsync(string userId, string taskId, UpdateTaskExecutorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskExecutorHeaders headers = new UpdateTaskExecutorHeaders();
            return await UpdateTaskExecutorWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务参与者
         *
         * @param request UpdateTaskInvolvemembersRequest
         * @param headers UpdateTaskInvolvemembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskInvolvemembersResponse
         */
        public UpdateTaskInvolvemembersResponse UpdateTaskInvolvemembersWithOptions(string userId, string taskId, UpdateTaskInvolvemembersRequest request, UpdateTaskInvolvemembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddInvolvers))
            {
                body["addInvolvers"] = request.AddInvolvers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelInvolvers))
            {
                body["delInvolvers"] = request.DelInvolvers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvolveMembers))
            {
                body["involveMembers"] = request.InvolveMembers;
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
                Action = "UpdateTaskInvolvemembers",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/involveMembers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskInvolvemembersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新任务参与者
         *
         * @param request UpdateTaskInvolvemembersRequest
         * @param headers UpdateTaskInvolvemembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskInvolvemembersResponse
         */
        public async Task<UpdateTaskInvolvemembersResponse> UpdateTaskInvolvemembersWithOptionsAsync(string userId, string taskId, UpdateTaskInvolvemembersRequest request, UpdateTaskInvolvemembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddInvolvers))
            {
                body["addInvolvers"] = request.AddInvolvers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelInvolvers))
            {
                body["delInvolvers"] = request.DelInvolvers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvolveMembers))
            {
                body["involveMembers"] = request.InvolveMembers;
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
                Action = "UpdateTaskInvolvemembers",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/involveMembers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskInvolvemembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务参与者
         *
         * @param request UpdateTaskInvolvemembersRequest
         * @return UpdateTaskInvolvemembersResponse
         */
        public UpdateTaskInvolvemembersResponse UpdateTaskInvolvemembers(string userId, string taskId, UpdateTaskInvolvemembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskInvolvemembersHeaders headers = new UpdateTaskInvolvemembersHeaders();
            return UpdateTaskInvolvemembersWithOptions(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务参与者
         *
         * @param request UpdateTaskInvolvemembersRequest
         * @return UpdateTaskInvolvemembersResponse
         */
        public async Task<UpdateTaskInvolvemembersResponse> UpdateTaskInvolvemembersAsync(string userId, string taskId, UpdateTaskInvolvemembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskInvolvemembersHeaders headers = new UpdateTaskInvolvemembersHeaders();
            return await UpdateTaskInvolvemembersWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务备注
         *
         * @param request UpdateTaskNoteRequest
         * @param headers UpdateTaskNoteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskNoteResponse
         */
        public UpdateTaskNoteResponse UpdateTaskNoteWithOptions(string userId, string taskId, UpdateTaskNoteRequest request, UpdateTaskNoteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["note"] = request.Note;
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
                Action = "UpdateTaskNote",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/notes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskNoteResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新任务备注
         *
         * @param request UpdateTaskNoteRequest
         * @param headers UpdateTaskNoteHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskNoteResponse
         */
        public async Task<UpdateTaskNoteResponse> UpdateTaskNoteWithOptionsAsync(string userId, string taskId, UpdateTaskNoteRequest request, UpdateTaskNoteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["note"] = request.Note;
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
                Action = "UpdateTaskNote",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/notes",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskNoteResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务备注
         *
         * @param request UpdateTaskNoteRequest
         * @return UpdateTaskNoteResponse
         */
        public UpdateTaskNoteResponse UpdateTaskNote(string userId, string taskId, UpdateTaskNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskNoteHeaders headers = new UpdateTaskNoteHeaders();
            return UpdateTaskNoteWithOptions(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务备注
         *
         * @param request UpdateTaskNoteRequest
         * @return UpdateTaskNoteResponse
         */
        public async Task<UpdateTaskNoteResponse> UpdateTaskNoteAsync(string userId, string taskId, UpdateTaskNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskNoteHeaders headers = new UpdateTaskNoteHeaders();
            return await UpdateTaskNoteWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务优先级
         *
         * @param request UpdateTaskPriorityRequest
         * @param headers UpdateTaskPriorityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskPriorityResponse
         */
        public UpdateTaskPriorityResponse UpdateTaskPriorityWithOptions(string userId, string taskId, UpdateTaskPriorityRequest request, UpdateTaskPriorityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
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
                Action = "UpdateTaskPriority",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/priorities",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskPriorityResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新任务优先级
         *
         * @param request UpdateTaskPriorityRequest
         * @param headers UpdateTaskPriorityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskPriorityResponse
         */
        public async Task<UpdateTaskPriorityResponse> UpdateTaskPriorityWithOptionsAsync(string userId, string taskId, UpdateTaskPriorityRequest request, UpdateTaskPriorityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
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
                Action = "UpdateTaskPriority",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/priorities",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskPriorityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务优先级
         *
         * @param request UpdateTaskPriorityRequest
         * @return UpdateTaskPriorityResponse
         */
        public UpdateTaskPriorityResponse UpdateTaskPriority(string userId, string taskId, UpdateTaskPriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskPriorityHeaders headers = new UpdateTaskPriorityHeaders();
            return UpdateTaskPriorityWithOptions(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务优先级
         *
         * @param request UpdateTaskPriorityRequest
         * @return UpdateTaskPriorityResponse
         */
        public async Task<UpdateTaskPriorityResponse> UpdateTaskPriorityAsync(string userId, string taskId, UpdateTaskPriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskPriorityHeaders headers = new UpdateTaskPriorityHeaders();
            return await UpdateTaskPriorityWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务列表
         *
         * @param request UpdateTaskStageRequest
         * @param headers UpdateTaskStageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskStageResponse
         */
        public UpdateTaskStageResponse UpdateTaskStageWithOptions(string userId, string taskId, UpdateTaskStageRequest request, UpdateTaskStageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStageId))
            {
                body["taskStageId"] = request.TaskStageId;
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
                Action = "UpdateTaskStage",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/stages",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskStageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新任务列表
         *
         * @param request UpdateTaskStageRequest
         * @param headers UpdateTaskStageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskStageResponse
         */
        public async Task<UpdateTaskStageResponse> UpdateTaskStageWithOptionsAsync(string userId, string taskId, UpdateTaskStageRequest request, UpdateTaskStageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStageId))
            {
                body["taskStageId"] = request.TaskStageId;
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
                Action = "UpdateTaskStage",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/stages",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskStageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务列表
         *
         * @param request UpdateTaskStageRequest
         * @return UpdateTaskStageResponse
         */
        public UpdateTaskStageResponse UpdateTaskStage(string userId, string taskId, UpdateTaskStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskStageHeaders headers = new UpdateTaskStageHeaders();
            return UpdateTaskStageWithOptions(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务列表
         *
         * @param request UpdateTaskStageRequest
         * @return UpdateTaskStageResponse
         */
        public async Task<UpdateTaskStageResponse> UpdateTaskStageAsync(string userId, string taskId, UpdateTaskStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskStageHeaders headers = new UpdateTaskStageHeaders();
            return await UpdateTaskStageWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务开始时间
         *
         * @param request UpdateTaskStartdateRequest
         * @param headers UpdateTaskStartdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskStartdateResponse
         */
        public UpdateTaskStartdateResponse UpdateTaskStartdateWithOptions(string userId, string taskId, UpdateTaskStartdateRequest request, UpdateTaskStartdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
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
                Action = "UpdateTaskStartdate",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/startDates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskStartdateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新任务开始时间
         *
         * @param request UpdateTaskStartdateRequest
         * @param headers UpdateTaskStartdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskStartdateResponse
         */
        public async Task<UpdateTaskStartdateResponse> UpdateTaskStartdateWithOptionsAsync(string userId, string taskId, UpdateTaskStartdateRequest request, UpdateTaskStartdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
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
                Action = "UpdateTaskStartdate",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/startDates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskStartdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务开始时间
         *
         * @param request UpdateTaskStartdateRequest
         * @return UpdateTaskStartdateResponse
         */
        public UpdateTaskStartdateResponse UpdateTaskStartdate(string userId, string taskId, UpdateTaskStartdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskStartdateHeaders headers = new UpdateTaskStartdateHeaders();
            return UpdateTaskStartdateWithOptions(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务开始时间
         *
         * @param request UpdateTaskStartdateRequest
         * @return UpdateTaskStartdateResponse
         */
        public async Task<UpdateTaskStartdateResponse> UpdateTaskStartdateAsync(string userId, string taskId, UpdateTaskStartdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskStartdateHeaders headers = new UpdateTaskStartdateHeaders();
            return await UpdateTaskStartdateWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务工作流状态
         *
         * @param request UpdateTaskTaskflowstatusRequest
         * @param headers UpdateTaskTaskflowstatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskTaskflowstatusResponse
         */
        public UpdateTaskTaskflowstatusResponse UpdateTaskTaskflowstatusWithOptions(string userId, string taskId, UpdateTaskTaskflowstatusRequest request, UpdateTaskTaskflowstatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskflowStatusId))
            {
                body["taskflowStatusId"] = request.TaskflowStatusId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskflowStatusUpdateNote))
            {
                body["taskflowStatusUpdateNote"] = request.TaskflowStatusUpdateNote;
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
                Action = "UpdateTaskTaskflowstatus",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/taskflowStatuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskTaskflowstatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新任务工作流状态
         *
         * @param request UpdateTaskTaskflowstatusRequest
         * @param headers UpdateTaskTaskflowstatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskTaskflowstatusResponse
         */
        public async Task<UpdateTaskTaskflowstatusResponse> UpdateTaskTaskflowstatusWithOptionsAsync(string userId, string taskId, UpdateTaskTaskflowstatusRequest request, UpdateTaskTaskflowstatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskflowStatusId))
            {
                body["taskflowStatusId"] = request.TaskflowStatusId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskflowStatusUpdateNote))
            {
                body["taskflowStatusUpdateNote"] = request.TaskflowStatusUpdateNote;
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
                Action = "UpdateTaskTaskflowstatus",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/tasks/" + taskId + "/taskflowStatuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskTaskflowstatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新任务工作流状态
         *
         * @param request UpdateTaskTaskflowstatusRequest
         * @return UpdateTaskTaskflowstatusResponse
         */
        public UpdateTaskTaskflowstatusResponse UpdateTaskTaskflowstatus(string userId, string taskId, UpdateTaskTaskflowstatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskTaskflowstatusHeaders headers = new UpdateTaskTaskflowstatusHeaders();
            return UpdateTaskTaskflowstatusWithOptions(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新任务工作流状态
         *
         * @param request UpdateTaskTaskflowstatusRequest
         * @return UpdateTaskTaskflowstatusResponse
         */
        public async Task<UpdateTaskTaskflowstatusResponse> UpdateTaskTaskflowstatusAsync(string userId, string taskId, UpdateTaskTaskflowstatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskTaskflowstatusHeaders headers = new UpdateTaskTaskflowstatusHeaders();
            return await UpdateTaskTaskflowstatusWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        /**
         * @summary 更新工时审批对象
         *
         * @param request UpdateWorkTimeApproveRequest
         * @param headers UpdateWorkTimeApproveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkTimeApproveResponse
         */
        public UpdateWorkTimeApproveResponse UpdateWorkTimeApproveWithOptions(string userId, string approveOpenId, UpdateWorkTimeApproveRequest request, UpdateWorkTimeApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishTime))
            {
                body["finishTime"] = request.FinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTime))
            {
                body["submitTime"] = request.SubmitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
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
                Action = "UpdateWorkTimeApprove",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/workTimes/approvals/" + approveOpenId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkTimeApproveResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新工时审批对象
         *
         * @param request UpdateWorkTimeApproveRequest
         * @param headers UpdateWorkTimeApproveHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWorkTimeApproveResponse
         */
        public async Task<UpdateWorkTimeApproveResponse> UpdateWorkTimeApproveWithOptionsAsync(string userId, string approveOpenId, UpdateWorkTimeApproveRequest request, UpdateWorkTimeApproveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinishTime))
            {
                body["finishTime"] = request.FinishTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTime))
            {
                body["submitTime"] = request.SubmitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
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
                Action = "UpdateWorkTimeApprove",
                Version = "project_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/project/users/" + userId + "/workTimes/approvals/" + approveOpenId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWorkTimeApproveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新工时审批对象
         *
         * @param request UpdateWorkTimeApproveRequest
         * @return UpdateWorkTimeApproveResponse
         */
        public UpdateWorkTimeApproveResponse UpdateWorkTimeApprove(string userId, string approveOpenId, UpdateWorkTimeApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkTimeApproveHeaders headers = new UpdateWorkTimeApproveHeaders();
            return UpdateWorkTimeApproveWithOptions(userId, approveOpenId, request, headers, runtime);
        }

        /**
         * @summary 更新工时审批对象
         *
         * @param request UpdateWorkTimeApproveRequest
         * @return UpdateWorkTimeApproveResponse
         */
        public async Task<UpdateWorkTimeApproveResponse> UpdateWorkTimeApproveAsync(string userId, string approveOpenId, UpdateWorkTimeApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkTimeApproveHeaders headers = new UpdateWorkTimeApproveHeaders();
            return await UpdateWorkTimeApproveWithOptionsAsync(userId, approveOpenId, request, headers, runtime);
        }

    }
}
