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

        public AddProjectMemberResponse AddProjectMember(string userId, string projectId, AddProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProjectMemberHeaders headers = new AddProjectMemberHeaders();
            return AddProjectMemberWithOptions(userId, projectId, request, headers, runtime);
        }

        public async Task<AddProjectMemberResponse> AddProjectMemberAsync(string userId, string projectId, AddProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddProjectMemberHeaders headers = new AddProjectMemberHeaders();
            return await AddProjectMemberWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

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

        public ArchiveProjectResponse ArchiveProject(string userId, string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ArchiveProjectHeaders headers = new ArchiveProjectHeaders();
            return ArchiveProjectWithOptions(userId, projectId, headers, runtime);
        }

        public async Task<ArchiveProjectResponse> ArchiveProjectAsync(string userId, string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ArchiveProjectHeaders headers = new ArchiveProjectHeaders();
            return await ArchiveProjectWithOptionsAsync(userId, projectId, headers, runtime);
        }

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

        public ArchiveTaskResponse ArchiveTask(string userId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ArchiveTaskHeaders headers = new ArchiveTaskHeaders();
            return ArchiveTaskWithOptions(userId, taskId, headers, runtime);
        }

        public async Task<ArchiveTaskResponse> ArchiveTaskAsync(string userId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ArchiveTaskHeaders headers = new ArchiveTaskHeaders();
            return await ArchiveTaskWithOptionsAsync(userId, taskId, headers, runtime);
        }

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

        public CreateOrganizationTaskResponse CreateOrganizationTask(string userId, CreateOrganizationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrganizationTaskHeaders headers = new CreateOrganizationTaskHeaders();
            return CreateOrganizationTaskWithOptions(userId, request, headers, runtime);
        }

        public async Task<CreateOrganizationTaskResponse> CreateOrganizationTaskAsync(string userId, CreateOrganizationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOrganizationTaskHeaders headers = new CreateOrganizationTaskHeaders();
            return await CreateOrganizationTaskWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public CreatePlanTimeResponse CreatePlanTime(string userId, CreatePlanTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePlanTimeHeaders headers = new CreatePlanTimeHeaders();
            return CreatePlanTimeWithOptions(userId, request, headers, runtime);
        }

        public async Task<CreatePlanTimeResponse> CreatePlanTimeAsync(string userId, CreatePlanTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePlanTimeHeaders headers = new CreatePlanTimeHeaders();
            return await CreatePlanTimeWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public CreateProjectResponse CreateProject(string userId, CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectHeaders headers = new CreateProjectHeaders();
            return CreateProjectWithOptions(userId, request, headers, runtime);
        }

        public async Task<CreateProjectResponse> CreateProjectAsync(string userId, CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectHeaders headers = new CreateProjectHeaders();
            return await CreateProjectWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public CreateProjectByTemplateResponse CreateProjectByTemplate(string userId, CreateProjectByTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectByTemplateHeaders headers = new CreateProjectByTemplateHeaders();
            return CreateProjectByTemplateWithOptions(userId, request, headers, runtime);
        }

        public async Task<CreateProjectByTemplateResponse> CreateProjectByTemplateAsync(string userId, CreateProjectByTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectByTemplateHeaders headers = new CreateProjectByTemplateHeaders();
            return await CreateProjectByTemplateWithOptionsAsync(userId, request, headers, runtime);
        }

        public CreateProjectCustomfieldStatusResponse CreateProjectCustomfieldStatusWithOptions(string userId, string projectId, CreateProjectCustomfieldStatusRequest request, CreateProjectCustomfieldStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldId))
            {
                body["customfieldId"] = request.CustomfieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldInstanceId))
            {
                body["customfieldInstanceId"] = request.CustomfieldInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldName))
            {
                body["customfieldName"] = request.CustomfieldName;
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

        public async Task<CreateProjectCustomfieldStatusResponse> CreateProjectCustomfieldStatusWithOptionsAsync(string userId, string projectId, CreateProjectCustomfieldStatusRequest request, CreateProjectCustomfieldStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldId))
            {
                body["customfieldId"] = request.CustomfieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldInstanceId))
            {
                body["customfieldInstanceId"] = request.CustomfieldInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldName))
            {
                body["customfieldName"] = request.CustomfieldName;
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

        public CreateProjectCustomfieldStatusResponse CreateProjectCustomfieldStatus(string userId, string projectId, CreateProjectCustomfieldStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectCustomfieldStatusHeaders headers = new CreateProjectCustomfieldStatusHeaders();
            return CreateProjectCustomfieldStatusWithOptions(userId, projectId, request, headers, runtime);
        }

        public async Task<CreateProjectCustomfieldStatusResponse> CreateProjectCustomfieldStatusAsync(string userId, string projectId, CreateProjectCustomfieldStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProjectCustomfieldStatusHeaders headers = new CreateProjectCustomfieldStatusHeaders();
            return await CreateProjectCustomfieldStatusWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

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

        public CreateTaskResponse CreateTask(string userId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTaskHeaders headers = new CreateTaskHeaders();
            return CreateTaskWithOptions(userId, request, headers, runtime);
        }

        public async Task<CreateTaskResponse> CreateTaskAsync(string userId, CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTaskHeaders headers = new CreateTaskHeaders();
            return await CreateTaskWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public CreateTaskObjectLinkResponse CreateTaskObjectLink(string userId, string taskId, CreateTaskObjectLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTaskObjectLinkHeaders headers = new CreateTaskObjectLinkHeaders();
            return CreateTaskObjectLinkWithOptions(userId, taskId, request, headers, runtime);
        }

        public async Task<CreateTaskObjectLinkResponse> CreateTaskObjectLinkAsync(string userId, string taskId, CreateTaskObjectLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTaskObjectLinkHeaders headers = new CreateTaskObjectLinkHeaders();
            return await CreateTaskObjectLinkWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        public CreateWorkTimeResponse CreateWorkTimeWithOptions(string userId, CreateWorkTimeRequest request, CreateWorkTimeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public async Task<CreateWorkTimeResponse> CreateWorkTimeWithOptionsAsync(string userId, CreateWorkTimeRequest request, CreateWorkTimeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public CreateWorkTimeResponse CreateWorkTime(string userId, CreateWorkTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkTimeHeaders headers = new CreateWorkTimeHeaders();
            return CreateWorkTimeWithOptions(userId, request, headers, runtime);
        }

        public async Task<CreateWorkTimeResponse> CreateWorkTimeAsync(string userId, CreateWorkTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkTimeHeaders headers = new CreateWorkTimeHeaders();
            return await CreateWorkTimeWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public CreateWorkTimeApproveResponse CreateWorkTimeApprove(string userId, CreateWorkTimeApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkTimeApproveHeaders headers = new CreateWorkTimeApproveHeaders();
            return CreateWorkTimeApproveWithOptions(userId, request, headers, runtime);
        }

        public async Task<CreateWorkTimeApproveResponse> CreateWorkTimeApproveAsync(string userId, CreateWorkTimeApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateWorkTimeApproveHeaders headers = new CreateWorkTimeApproveHeaders();
            return await CreateWorkTimeApproveWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public DeleteProjectMemberResponse DeleteProjectMember(string userId, string projectId, DeleteProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProjectMemberHeaders headers = new DeleteProjectMemberHeaders();
            return DeleteProjectMemberWithOptions(userId, projectId, request, headers, runtime);
        }

        public async Task<DeleteProjectMemberResponse> DeleteProjectMemberAsync(string userId, string projectId, DeleteProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteProjectMemberHeaders headers = new DeleteProjectMemberHeaders();
            return await DeleteProjectMemberWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

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

        public DeleteTaskResponse DeleteTask(string userId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTaskHeaders headers = new DeleteTaskHeaders();
            return DeleteTaskWithOptions(userId, taskId, headers, runtime);
        }

        public async Task<DeleteTaskResponse> DeleteTaskAsync(string userId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTaskHeaders headers = new DeleteTaskHeaders();
            return await DeleteTaskWithOptionsAsync(userId, taskId, headers, runtime);
        }

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

        public GetDeptsByOrgIdResponse GetDeptsByOrgId(GetDeptsByOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeptsByOrgIdHeaders headers = new GetDeptsByOrgIdHeaders();
            return GetDeptsByOrgIdWithOptions(request, headers, runtime);
        }

        public async Task<GetDeptsByOrgIdResponse> GetDeptsByOrgIdAsync(GetDeptsByOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDeptsByOrgIdHeaders headers = new GetDeptsByOrgIdHeaders();
            return await GetDeptsByOrgIdWithOptionsAsync(request, headers, runtime);
        }

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

        public GetEmpsByOrgIdResponse GetEmpsByOrgId(GetEmpsByOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmpsByOrgIdHeaders headers = new GetEmpsByOrgIdHeaders();
            return GetEmpsByOrgIdWithOptions(request, headers, runtime);
        }

        public async Task<GetEmpsByOrgIdResponse> GetEmpsByOrgIdAsync(GetEmpsByOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetEmpsByOrgIdHeaders headers = new GetEmpsByOrgIdHeaders();
            return await GetEmpsByOrgIdWithOptionsAsync(request, headers, runtime);
        }

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

        public GetOrganizatioTaskByIdsResponse GetOrganizatioTaskByIds(string userId, GetOrganizatioTaskByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizatioTaskByIdsHeaders headers = new GetOrganizatioTaskByIdsHeaders();
            return GetOrganizatioTaskByIdsWithOptions(userId, request, headers, runtime);
        }

        public async Task<GetOrganizatioTaskByIdsResponse> GetOrganizatioTaskByIdsAsync(string userId, GetOrganizatioTaskByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizatioTaskByIdsHeaders headers = new GetOrganizatioTaskByIdsHeaders();
            return await GetOrganizatioTaskByIdsWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public GetOrganizationPriorityListResponse GetOrganizationPriorityList(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationPriorityListHeaders headers = new GetOrganizationPriorityListHeaders();
            return GetOrganizationPriorityListWithOptions(userId, headers, runtime);
        }

        public async Task<GetOrganizationPriorityListResponse> GetOrganizationPriorityListAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationPriorityListHeaders headers = new GetOrganizationPriorityListHeaders();
            return await GetOrganizationPriorityListWithOptionsAsync(userId, headers, runtime);
        }

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

        public GetOrganizationTaskResponse GetOrganizationTask(string taskId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationTaskHeaders headers = new GetOrganizationTaskHeaders();
            return GetOrganizationTaskWithOptions(taskId, userId, headers, runtime);
        }

        public async Task<GetOrganizationTaskResponse> GetOrganizationTaskAsync(string taskId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetOrganizationTaskHeaders headers = new GetOrganizationTaskHeaders();
            return await GetOrganizationTaskWithOptionsAsync(taskId, userId, headers, runtime);
        }

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

        public GetProjectGroupResponse GetProjectGroup(string userId, GetProjectGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectGroupHeaders headers = new GetProjectGroupHeaders();
            return GetProjectGroupWithOptions(userId, request, headers, runtime);
        }

        public async Task<GetProjectGroupResponse> GetProjectGroupAsync(string userId, GetProjectGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectGroupHeaders headers = new GetProjectGroupHeaders();
            return await GetProjectGroupWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public GetProjectMemebersResponse GetProjectMemebers(string userId, string projectId, GetProjectMemebersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectMemebersHeaders headers = new GetProjectMemebersHeaders();
            return GetProjectMemebersWithOptions(userId, projectId, request, headers, runtime);
        }

        public async Task<GetProjectMemebersResponse> GetProjectMemebersAsync(string userId, string projectId, GetProjectMemebersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectMemebersHeaders headers = new GetProjectMemebersHeaders();
            return await GetProjectMemebersWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

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

        public GetProjectStatusListResponse GetProjectStatusList(string userId, string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectStatusListHeaders headers = new GetProjectStatusListHeaders();
            return GetProjectStatusListWithOptions(userId, projectId, headers, runtime);
        }

        public async Task<GetProjectStatusListResponse> GetProjectStatusListAsync(string userId, string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectStatusListHeaders headers = new GetProjectStatusListHeaders();
            return await GetProjectStatusListWithOptionsAsync(userId, projectId, headers, runtime);
        }

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

        public GetTaskByIdsResponse GetTaskByIds(string userId, GetTaskByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskByIdsHeaders headers = new GetTaskByIdsHeaders();
            return GetTaskByIdsWithOptions(userId, request, headers, runtime);
        }

        public async Task<GetTaskByIdsResponse> GetTaskByIdsAsync(string userId, GetTaskByIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTaskByIdsHeaders headers = new GetTaskByIdsHeaders();
            return await GetTaskByIdsWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public GetTbOrgIdByDingOrgIdResponse GetTbOrgIdByDingOrgId(GetTbOrgIdByDingOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbOrgIdByDingOrgIdHeaders headers = new GetTbOrgIdByDingOrgIdHeaders();
            return GetTbOrgIdByDingOrgIdWithOptions(request, headers, runtime);
        }

        public async Task<GetTbOrgIdByDingOrgIdResponse> GetTbOrgIdByDingOrgIdAsync(GetTbOrgIdByDingOrgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbOrgIdByDingOrgIdHeaders headers = new GetTbOrgIdByDingOrgIdHeaders();
            return await GetTbOrgIdByDingOrgIdWithOptionsAsync(request, headers, runtime);
        }

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

        public GetTbProjectGrayResponse GetTbProjectGray(GetTbProjectGrayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectGrayHeaders headers = new GetTbProjectGrayHeaders();
            return GetTbProjectGrayWithOptions(request, headers, runtime);
        }

        public async Task<GetTbProjectGrayResponse> GetTbProjectGrayAsync(GetTbProjectGrayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectGrayHeaders headers = new GetTbProjectGrayHeaders();
            return await GetTbProjectGrayWithOptionsAsync(request, headers, runtime);
        }

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

        public GetTbProjectSourceResponse GetTbProjectSource()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectSourceHeaders headers = new GetTbProjectSourceHeaders();
            return GetTbProjectSourceWithOptions(headers, runtime);
        }

        public async Task<GetTbProjectSourceResponse> GetTbProjectSourceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbProjectSourceHeaders headers = new GetTbProjectSourceHeaders();
            return await GetTbProjectSourceWithOptionsAsync(headers, runtime);
        }

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

        public GetTbUserIdByStaffIdResponse GetTbUserIdByStaffId(GetTbUserIdByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbUserIdByStaffIdHeaders headers = new GetTbUserIdByStaffIdHeaders();
            return GetTbUserIdByStaffIdWithOptions(request, headers, runtime);
        }

        public async Task<GetTbUserIdByStaffIdResponse> GetTbUserIdByStaffIdAsync(GetTbUserIdByStaffIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTbUserIdByStaffIdHeaders headers = new GetTbUserIdByStaffIdHeaders();
            return await GetTbUserIdByStaffIdWithOptionsAsync(request, headers, runtime);
        }

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

        public GetUserJoinedProjectResponse GetUserJoinedProject(string userId, GetUserJoinedProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserJoinedProjectHeaders headers = new GetUserJoinedProjectHeaders();
            return GetUserJoinedProjectWithOptions(userId, request, headers, runtime);
        }

        public async Task<GetUserJoinedProjectResponse> GetUserJoinedProjectAsync(string userId, GetUserJoinedProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserJoinedProjectHeaders headers = new GetUserJoinedProjectHeaders();
            return await GetUserJoinedProjectWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public QueryProjectResponse QueryProject(string userId, QueryProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProjectHeaders headers = new QueryProjectHeaders();
            return QueryProjectWithOptions(userId, request, headers, runtime);
        }

        public async Task<QueryProjectResponse> QueryProjectAsync(string userId, QueryProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProjectHeaders headers = new QueryProjectHeaders();
            return await QueryProjectWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public QueryTaskOfProjectResponse QueryTaskOfProject(string userId, string projectId, QueryTaskOfProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTaskOfProjectHeaders headers = new QueryTaskOfProjectHeaders();
            return QueryTaskOfProjectWithOptions(userId, projectId, request, headers, runtime);
        }

        public async Task<QueryTaskOfProjectResponse> QueryTaskOfProjectAsync(string userId, string projectId, QueryTaskOfProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTaskOfProjectHeaders headers = new QueryTaskOfProjectHeaders();
            return await QueryTaskOfProjectWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StageIds))
            {
                query["stageIds"] = request.StageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskListId))
            {
                query["taskListId"] = request.TaskListId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StageIds))
            {
                query["stageIds"] = request.StageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskListId))
            {
                query["taskListId"] = request.TaskListId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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

        public SeachTaskStageResponse SeachTaskStage(string userId, string projectId, SeachTaskStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SeachTaskStageHeaders headers = new SeachTaskStageHeaders();
            return SeachTaskStageWithOptions(userId, projectId, request, headers, runtime);
        }

        public async Task<SeachTaskStageResponse> SeachTaskStageAsync(string userId, string projectId, SeachTaskStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SeachTaskStageHeaders headers = new SeachTaskStageHeaders();
            return await SeachTaskStageWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

        public SearchOranizationCustomfieldResponse SearchOranizationCustomfieldWithOptions(string userId, SearchOranizationCustomfieldRequest request, SearchOranizationCustomfieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldIds))
            {
                query["customfieldIds"] = request.CustomfieldIds;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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

        public async Task<SearchOranizationCustomfieldResponse> SearchOranizationCustomfieldWithOptionsAsync(string userId, SearchOranizationCustomfieldRequest request, SearchOranizationCustomfieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldIds))
            {
                query["customfieldIds"] = request.CustomfieldIds;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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

        public SearchOranizationCustomfieldResponse SearchOranizationCustomfield(string userId, SearchOranizationCustomfieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOranizationCustomfieldHeaders headers = new SearchOranizationCustomfieldHeaders();
            return SearchOranizationCustomfieldWithOptions(userId, request, headers, runtime);
        }

        public async Task<SearchOranizationCustomfieldResponse> SearchOranizationCustomfieldAsync(string userId, SearchOranizationCustomfieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchOranizationCustomfieldHeaders headers = new SearchOranizationCustomfieldHeaders();
            return await SearchOranizationCustomfieldWithOptionsAsync(userId, request, headers, runtime);
        }

        public SearchProjectCustomfieldResponse SearchProjectCustomfieldWithOptions(string userId, string projectId, SearchProjectCustomfieldRequest request, SearchProjectCustomfieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldIds))
            {
                query["customfieldIds"] = request.CustomfieldIds;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenariofieldconfigId))
            {
                query["scenariofieldconfigId"] = request.ScenariofieldconfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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

        public async Task<SearchProjectCustomfieldResponse> SearchProjectCustomfieldWithOptionsAsync(string userId, string projectId, SearchProjectCustomfieldRequest request, SearchProjectCustomfieldHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldIds))
            {
                query["customfieldIds"] = request.CustomfieldIds;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenariofieldconfigId))
            {
                query["scenariofieldconfigId"] = request.ScenariofieldconfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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

        public SearchProjectCustomfieldResponse SearchProjectCustomfield(string userId, string projectId, SearchProjectCustomfieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchProjectCustomfieldHeaders headers = new SearchProjectCustomfieldHeaders();
            return SearchProjectCustomfieldWithOptions(userId, projectId, request, headers, runtime);
        }

        public async Task<SearchProjectCustomfieldResponse> SearchProjectCustomfieldAsync(string userId, string projectId, SearchProjectCustomfieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchProjectCustomfieldHeaders headers = new SearchProjectCustomfieldHeaders();
            return await SearchProjectCustomfieldWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

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

        public SearchProjectTemplateResponse SearchProjectTemplate(string userId, SearchProjectTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchProjectTemplateHeaders headers = new SearchProjectTemplateHeaders();
            return SearchProjectTemplateWithOptions(userId, request, headers, runtime);
        }

        public async Task<SearchProjectTemplateResponse> SearchProjectTemplateAsync(string userId, SearchProjectTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchProjectTemplateHeaders headers = new SearchProjectTemplateHeaders();
            return await SearchProjectTemplateWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public SearchTaskFlowResponse SearchTaskFlow(string userId, string projectId, SearchTaskFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskFlowHeaders headers = new SearchTaskFlowHeaders();
            return SearchTaskFlowWithOptions(userId, projectId, request, headers, runtime);
        }

        public async Task<SearchTaskFlowResponse> SearchTaskFlowAsync(string userId, string projectId, SearchTaskFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskFlowHeaders headers = new SearchTaskFlowHeaders();
            return await SearchTaskFlowWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

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

        public SearchTaskListResponse SearchTaskList(string userId, string projectId, SearchTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskListHeaders headers = new SearchTaskListHeaders();
            return SearchTaskListWithOptions(userId, projectId, request, headers, runtime);
        }

        public async Task<SearchTaskListResponse> SearchTaskListAsync(string userId, string projectId, SearchTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskListHeaders headers = new SearchTaskListHeaders();
            return await SearchTaskListWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

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

        public SearchTaskflowStatusResponse SearchTaskflowStatus(string userId, string projectId, SearchTaskflowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskflowStatusHeaders headers = new SearchTaskflowStatusHeaders();
            return SearchTaskflowStatusWithOptions(userId, projectId, request, headers, runtime);
        }

        public async Task<SearchTaskflowStatusResponse> SearchTaskflowStatusAsync(string userId, string projectId, SearchTaskflowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchTaskflowStatusHeaders headers = new SearchTaskflowStatusHeaders();
            return await SearchTaskflowStatusWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

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

        public SearchUserTaskResponse SearchUserTask(string userId, SearchUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchUserTaskHeaders headers = new SearchUserTaskHeaders();
            return SearchUserTaskWithOptions(userId, request, headers, runtime);
        }

        public async Task<SearchUserTaskResponse> SearchUserTaskAsync(string userId, SearchUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchUserTaskHeaders headers = new SearchUserTaskHeaders();
            return await SearchUserTaskWithOptionsAsync(userId, request, headers, runtime);
        }

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

        public SuspendProjectResponse SuspendProject(string projectId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SuspendProjectHeaders headers = new SuspendProjectHeaders();
            return SuspendProjectWithOptions(projectId, userId, headers, runtime);
        }

        public async Task<SuspendProjectResponse> SuspendProjectAsync(string projectId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SuspendProjectHeaders headers = new SuspendProjectHeaders();
            return await SuspendProjectWithOptionsAsync(projectId, userId, headers, runtime);
        }

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

        public UnSuspendProjectResponse UnSuspendProject(string projectId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnSuspendProjectHeaders headers = new UnSuspendProjectHeaders();
            return UnSuspendProjectWithOptions(projectId, userId, headers, runtime);
        }

        public async Task<UnSuspendProjectResponse> UnSuspendProjectAsync(string projectId, string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnSuspendProjectHeaders headers = new UnSuspendProjectHeaders();
            return await UnSuspendProjectWithOptionsAsync(projectId, userId, headers, runtime);
        }

        public UpdateCustomfieldValueResponse UpdateCustomfieldValueWithOptions(string userId, string taskId, UpdateCustomfieldValueRequest request, UpdateCustomfieldValueHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldId))
            {
                body["customfieldId"] = request.CustomfieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldName))
            {
                body["customfieldName"] = request.CustomfieldName;
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

        public async Task<UpdateCustomfieldValueResponse> UpdateCustomfieldValueWithOptionsAsync(string userId, string taskId, UpdateCustomfieldValueRequest request, UpdateCustomfieldValueHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldId))
            {
                body["customfieldId"] = request.CustomfieldId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomfieldName))
            {
                body["customfieldName"] = request.CustomfieldName;
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

        public UpdateCustomfieldValueResponse UpdateCustomfieldValue(string userId, string taskId, UpdateCustomfieldValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomfieldValueHeaders headers = new UpdateCustomfieldValueHeaders();
            return UpdateCustomfieldValueWithOptions(userId, taskId, request, headers, runtime);
        }

        public async Task<UpdateCustomfieldValueResponse> UpdateCustomfieldValueAsync(string userId, string taskId, UpdateCustomfieldValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateCustomfieldValueHeaders headers = new UpdateCustomfieldValueHeaders();
            return await UpdateCustomfieldValueWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

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

        public UpdateOrganizationTaskContentResponse UpdateOrganizationTaskContent(string taskId, string userId, UpdateOrganizationTaskContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskContentHeaders headers = new UpdateOrganizationTaskContentHeaders();
            return UpdateOrganizationTaskContentWithOptions(taskId, userId, request, headers, runtime);
        }

        public async Task<UpdateOrganizationTaskContentResponse> UpdateOrganizationTaskContentAsync(string taskId, string userId, UpdateOrganizationTaskContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskContentHeaders headers = new UpdateOrganizationTaskContentHeaders();
            return await UpdateOrganizationTaskContentWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

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

        public UpdateOrganizationTaskDueDateResponse UpdateOrganizationTaskDueDate(string taskId, string userId, UpdateOrganizationTaskDueDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskDueDateHeaders headers = new UpdateOrganizationTaskDueDateHeaders();
            return UpdateOrganizationTaskDueDateWithOptions(taskId, userId, request, headers, runtime);
        }

        public async Task<UpdateOrganizationTaskDueDateResponse> UpdateOrganizationTaskDueDateAsync(string taskId, string userId, UpdateOrganizationTaskDueDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskDueDateHeaders headers = new UpdateOrganizationTaskDueDateHeaders();
            return await UpdateOrganizationTaskDueDateWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

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

        public UpdateOrganizationTaskExecutorResponse UpdateOrganizationTaskExecutor(string taskId, string userId, UpdateOrganizationTaskExecutorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskExecutorHeaders headers = new UpdateOrganizationTaskExecutorHeaders();
            return UpdateOrganizationTaskExecutorWithOptions(taskId, userId, request, headers, runtime);
        }

        public async Task<UpdateOrganizationTaskExecutorResponse> UpdateOrganizationTaskExecutorAsync(string taskId, string userId, UpdateOrganizationTaskExecutorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskExecutorHeaders headers = new UpdateOrganizationTaskExecutorHeaders();
            return await UpdateOrganizationTaskExecutorWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

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

        public UpdateOrganizationTaskInvolveMembersResponse UpdateOrganizationTaskInvolveMembers(string taskId, string userId, UpdateOrganizationTaskInvolveMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskInvolveMembersHeaders headers = new UpdateOrganizationTaskInvolveMembersHeaders();
            return UpdateOrganizationTaskInvolveMembersWithOptions(taskId, userId, request, headers, runtime);
        }

        public async Task<UpdateOrganizationTaskInvolveMembersResponse> UpdateOrganizationTaskInvolveMembersAsync(string taskId, string userId, UpdateOrganizationTaskInvolveMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskInvolveMembersHeaders headers = new UpdateOrganizationTaskInvolveMembersHeaders();
            return await UpdateOrganizationTaskInvolveMembersWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

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

        public UpdateOrganizationTaskNoteResponse UpdateOrganizationTaskNote(string taskId, string userId, UpdateOrganizationTaskNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskNoteHeaders headers = new UpdateOrganizationTaskNoteHeaders();
            return UpdateOrganizationTaskNoteWithOptions(taskId, userId, request, headers, runtime);
        }

        public async Task<UpdateOrganizationTaskNoteResponse> UpdateOrganizationTaskNoteAsync(string taskId, string userId, UpdateOrganizationTaskNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskNoteHeaders headers = new UpdateOrganizationTaskNoteHeaders();
            return await UpdateOrganizationTaskNoteWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

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

        public UpdateOrganizationTaskPriorityResponse UpdateOrganizationTaskPriority(string taskId, string userId, UpdateOrganizationTaskPriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskPriorityHeaders headers = new UpdateOrganizationTaskPriorityHeaders();
            return UpdateOrganizationTaskPriorityWithOptions(taskId, userId, request, headers, runtime);
        }

        public async Task<UpdateOrganizationTaskPriorityResponse> UpdateOrganizationTaskPriorityAsync(string taskId, string userId, UpdateOrganizationTaskPriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskPriorityHeaders headers = new UpdateOrganizationTaskPriorityHeaders();
            return await UpdateOrganizationTaskPriorityWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

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

        public UpdateOrganizationTaskStatusResponse UpdateOrganizationTaskStatus(string taskId, string userId, UpdateOrganizationTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskStatusHeaders headers = new UpdateOrganizationTaskStatusHeaders();
            return UpdateOrganizationTaskStatusWithOptions(taskId, userId, request, headers, runtime);
        }

        public async Task<UpdateOrganizationTaskStatusResponse> UpdateOrganizationTaskStatusAsync(string taskId, string userId, UpdateOrganizationTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateOrganizationTaskStatusHeaders headers = new UpdateOrganizationTaskStatusHeaders();
            return await UpdateOrganizationTaskStatusWithOptionsAsync(taskId, userId, request, headers, runtime);
        }

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

        public UpdateProjectGroupResponse UpdateProjectGroup(string userId, string projectId, UpdateProjectGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProjectGroupHeaders headers = new UpdateProjectGroupHeaders();
            return UpdateProjectGroupWithOptions(userId, projectId, request, headers, runtime);
        }

        public async Task<UpdateProjectGroupResponse> UpdateProjectGroupAsync(string userId, string projectId, UpdateProjectGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateProjectGroupHeaders headers = new UpdateProjectGroupHeaders();
            return await UpdateProjectGroupWithOptionsAsync(userId, projectId, request, headers, runtime);
        }

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

        public UpdateTaskContentResponse UpdateTaskContent(string userId, string taskId, UpdateTaskContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskContentHeaders headers = new UpdateTaskContentHeaders();
            return UpdateTaskContentWithOptions(userId, taskId, request, headers, runtime);
        }

        public async Task<UpdateTaskContentResponse> UpdateTaskContentAsync(string userId, string taskId, UpdateTaskContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskContentHeaders headers = new UpdateTaskContentHeaders();
            return await UpdateTaskContentWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

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

        public UpdateTaskDueDateResponse UpdateTaskDueDate(string userId, string taskId, UpdateTaskDueDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskDueDateHeaders headers = new UpdateTaskDueDateHeaders();
            return UpdateTaskDueDateWithOptions(userId, taskId, request, headers, runtime);
        }

        public async Task<UpdateTaskDueDateResponse> UpdateTaskDueDateAsync(string userId, string taskId, UpdateTaskDueDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskDueDateHeaders headers = new UpdateTaskDueDateHeaders();
            return await UpdateTaskDueDateWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

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

        public UpdateTaskExecutorResponse UpdateTaskExecutor(string userId, string taskId, UpdateTaskExecutorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskExecutorHeaders headers = new UpdateTaskExecutorHeaders();
            return UpdateTaskExecutorWithOptions(userId, taskId, request, headers, runtime);
        }

        public async Task<UpdateTaskExecutorResponse> UpdateTaskExecutorAsync(string userId, string taskId, UpdateTaskExecutorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskExecutorHeaders headers = new UpdateTaskExecutorHeaders();
            return await UpdateTaskExecutorWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

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

        public UpdateTaskInvolvemembersResponse UpdateTaskInvolvemembers(string userId, string taskId, UpdateTaskInvolvemembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskInvolvemembersHeaders headers = new UpdateTaskInvolvemembersHeaders();
            return UpdateTaskInvolvemembersWithOptions(userId, taskId, request, headers, runtime);
        }

        public async Task<UpdateTaskInvolvemembersResponse> UpdateTaskInvolvemembersAsync(string userId, string taskId, UpdateTaskInvolvemembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskInvolvemembersHeaders headers = new UpdateTaskInvolvemembersHeaders();
            return await UpdateTaskInvolvemembersWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

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

        public UpdateTaskNoteResponse UpdateTaskNote(string userId, string taskId, UpdateTaskNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskNoteHeaders headers = new UpdateTaskNoteHeaders();
            return UpdateTaskNoteWithOptions(userId, taskId, request, headers, runtime);
        }

        public async Task<UpdateTaskNoteResponse> UpdateTaskNoteAsync(string userId, string taskId, UpdateTaskNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskNoteHeaders headers = new UpdateTaskNoteHeaders();
            return await UpdateTaskNoteWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

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

        public UpdateTaskPriorityResponse UpdateTaskPriority(string userId, string taskId, UpdateTaskPriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskPriorityHeaders headers = new UpdateTaskPriorityHeaders();
            return UpdateTaskPriorityWithOptions(userId, taskId, request, headers, runtime);
        }

        public async Task<UpdateTaskPriorityResponse> UpdateTaskPriorityAsync(string userId, string taskId, UpdateTaskPriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskPriorityHeaders headers = new UpdateTaskPriorityHeaders();
            return await UpdateTaskPriorityWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

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

        public UpdateTaskStageResponse UpdateTaskStage(string userId, string taskId, UpdateTaskStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskStageHeaders headers = new UpdateTaskStageHeaders();
            return UpdateTaskStageWithOptions(userId, taskId, request, headers, runtime);
        }

        public async Task<UpdateTaskStageResponse> UpdateTaskStageAsync(string userId, string taskId, UpdateTaskStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskStageHeaders headers = new UpdateTaskStageHeaders();
            return await UpdateTaskStageWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

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

        public UpdateTaskStartdateResponse UpdateTaskStartdate(string userId, string taskId, UpdateTaskStartdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskStartdateHeaders headers = new UpdateTaskStartdateHeaders();
            return UpdateTaskStartdateWithOptions(userId, taskId, request, headers, runtime);
        }

        public async Task<UpdateTaskStartdateResponse> UpdateTaskStartdateAsync(string userId, string taskId, UpdateTaskStartdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskStartdateHeaders headers = new UpdateTaskStartdateHeaders();
            return await UpdateTaskStartdateWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

        public UpdateTaskTaskflowstatusResponse UpdateTaskTaskflowstatusWithOptions(string userId, string taskId, UpdateTaskTaskflowstatusRequest request, UpdateTaskTaskflowstatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskflowStatusId))
            {
                body["taskflowStatusId"] = request.TaskflowStatusId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TfsUpdateNote))
            {
                body["tfsUpdateNote"] = request.TfsUpdateNote;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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

        public async Task<UpdateTaskTaskflowstatusResponse> UpdateTaskTaskflowstatusWithOptionsAsync(string userId, string taskId, UpdateTaskTaskflowstatusRequest request, UpdateTaskTaskflowstatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskflowStatusId))
            {
                body["taskflowStatusId"] = request.TaskflowStatusId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TfsUpdateNote))
            {
                body["tfsUpdateNote"] = request.TfsUpdateNote;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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

        public UpdateTaskTaskflowstatusResponse UpdateTaskTaskflowstatus(string userId, string taskId, UpdateTaskTaskflowstatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskTaskflowstatusHeaders headers = new UpdateTaskTaskflowstatusHeaders();
            return UpdateTaskTaskflowstatusWithOptions(userId, taskId, request, headers, runtime);
        }

        public async Task<UpdateTaskTaskflowstatusResponse> UpdateTaskTaskflowstatusAsync(string userId, string taskId, UpdateTaskTaskflowstatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTaskTaskflowstatusHeaders headers = new UpdateTaskTaskflowstatusHeaders();
            return await UpdateTaskTaskflowstatusWithOptionsAsync(userId, taskId, request, headers, runtime);
        }

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

        public UpdateWorkTimeApproveResponse UpdateWorkTimeApprove(string userId, string approveOpenId, UpdateWorkTimeApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkTimeApproveHeaders headers = new UpdateWorkTimeApproveHeaders();
            return UpdateWorkTimeApproveWithOptions(userId, approveOpenId, request, headers, runtime);
        }

        public async Task<UpdateWorkTimeApproveResponse> UpdateWorkTimeApproveAsync(string userId, string approveOpenId, UpdateWorkTimeApproveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateWorkTimeApproveHeaders headers = new UpdateWorkTimeApproveHeaders();
            return await UpdateWorkTimeApproveWithOptionsAsync(userId, approveOpenId, request, headers, runtime);
        }

    }
}
