// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalktodo_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0
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


        public GetTodoTaskDetailResponse GetTodoTaskDetail(string taskId, string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskDetailHeaders headers = new GetTodoTaskDetailHeaders();
            return GetTodoTaskDetailWithOptions(taskId, unionId, headers, runtime);
        }

        public async Task<GetTodoTaskDetailResponse> GetTodoTaskDetailAsync(string taskId, string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskDetailHeaders headers = new GetTodoTaskDetailHeaders();
            return await GetTodoTaskDetailWithOptionsAsync(taskId, unionId, headers, runtime);
        }

        public GetTodoTaskDetailResponse GetTodoTaskDetailWithOptions(string taskId, string unionId, GetTodoTaskDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetTodoTaskDetailResponse>(DoROARequest("GetTodoTaskDetail", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/exclusive/users/" + unionId + "/tasks/" + taskId, "json", req, runtime));
        }

        public async Task<GetTodoTaskDetailResponse> GetTodoTaskDetailWithOptionsAsync(string taskId, string unionId, GetTodoTaskDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetTodoTaskDetailResponse>(await DoROARequestAsync("GetTodoTaskDetail", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/exclusive/users/" + unionId + "/tasks/" + taskId, "json", req, runtime));
        }

        public GetTodoTaskResponse GetTodoTask(string unionId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskHeaders headers = new GetTodoTaskHeaders();
            return GetTodoTaskWithOptions(unionId, taskId, headers, runtime);
        }

        public async Task<GetTodoTaskResponse> GetTodoTaskAsync(string unionId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskHeaders headers = new GetTodoTaskHeaders();
            return await GetTodoTaskWithOptionsAsync(unionId, taskId, headers, runtime);
        }

        public GetTodoTaskResponse GetTodoTaskWithOptions(string unionId, string taskId, GetTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetTodoTaskResponse>(DoROARequest("GetTodoTask", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId, "json", req, runtime));
        }

        public async Task<GetTodoTaskResponse> GetTodoTaskWithOptionsAsync(string unionId, string taskId, GetTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetTodoTaskResponse>(await DoROARequestAsync("GetTodoTask", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId, "json", req, runtime));
        }

        public GetTodoTaskBySourceIdResponse GetTodoTaskBySourceId(string unionId, string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskBySourceIdHeaders headers = new GetTodoTaskBySourceIdHeaders();
            return GetTodoTaskBySourceIdWithOptions(unionId, sourceId, headers, runtime);
        }

        public async Task<GetTodoTaskBySourceIdResponse> GetTodoTaskBySourceIdAsync(string unionId, string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskBySourceIdHeaders headers = new GetTodoTaskBySourceIdHeaders();
            return await GetTodoTaskBySourceIdWithOptionsAsync(unionId, sourceId, headers, runtime);
        }

        public GetTodoTaskBySourceIdResponse GetTodoTaskBySourceIdWithOptions(string unionId, string sourceId, GetTodoTaskBySourceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetTodoTaskBySourceIdResponse>(DoROARequest("GetTodoTaskBySourceId", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/users/" + unionId + "/tasks/sources/" + sourceId, "json", req, runtime));
        }

        public async Task<GetTodoTaskBySourceIdResponse> GetTodoTaskBySourceIdWithOptionsAsync(string unionId, string sourceId, GetTodoTaskBySourceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetTodoTaskBySourceIdResponse>(await DoROARequestAsync("GetTodoTaskBySourceId", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/users/" + unionId + "/tasks/sources/" + sourceId, "json", req, runtime));
        }

        public CountTodoTasksResponse CountTodoTasks(string unionId, CountTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CountTodoTasksHeaders headers = new CountTodoTasksHeaders();
            return CountTodoTasksWithOptions(unionId, request, headers, runtime);
        }

        public async Task<CountTodoTasksResponse> CountTodoTasksAsync(string unionId, CountTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CountTodoTasksHeaders headers = new CountTodoTasksHeaders();
            return await CountTodoTasksWithOptionsAsync(unionId, request, headers, runtime);
        }

        public CountTodoTasksResponse CountTodoTasksWithOptions(string unionId, CountTodoTasksRequest request, CountTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                body["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDueTime))
            {
                body["fromDueTime"] = request.FromDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDueTime))
            {
                body["toDueTime"] = request.ToDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecycled))
            {
                body["isRecycled"] = request.IsRecycled;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CountTodoTasksResponse>(DoROARequest("CountTodoTasks", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/tasks/count", "json", req, runtime));
        }

        public async Task<CountTodoTasksResponse> CountTodoTasksWithOptionsAsync(string unionId, CountTodoTasksRequest request, CountTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                body["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDueTime))
            {
                body["fromDueTime"] = request.FromDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDueTime))
            {
                body["toDueTime"] = request.ToDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecycled))
            {
                body["isRecycled"] = request.IsRecycled;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CountTodoTasksResponse>(await DoROARequestAsync("CountTodoTasks", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/tasks/count", "json", req, runtime));
        }

        public QueryOrgTodoTasksResponse QueryOrgTodoTasks(string unionId, QueryOrgTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgTodoTasksHeaders headers = new QueryOrgTodoTasksHeaders();
            return QueryOrgTodoTasksWithOptions(unionId, request, headers, runtime);
        }

        public async Task<QueryOrgTodoTasksResponse> QueryOrgTodoTasksAsync(string unionId, QueryOrgTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgTodoTasksHeaders headers = new QueryOrgTodoTasksHeaders();
            return await QueryOrgTodoTasksWithOptionsAsync(unionId, request, headers, runtime);
        }

        public QueryOrgTodoTasksResponse QueryOrgTodoTasksWithOptions(string unionId, QueryOrgTodoTasksRequest request, QueryOrgTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryOrgTodoTasksResponse>(DoROARequest("QueryOrgTodoTasks", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/org/tasks/query", "json", req, runtime));
        }

        public async Task<QueryOrgTodoTasksResponse> QueryOrgTodoTasksWithOptionsAsync(string unionId, QueryOrgTodoTasksRequest request, QueryOrgTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryOrgTodoTasksResponse>(await DoROARequestAsync("QueryOrgTodoTasks", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/org/tasks/query", "json", req, runtime));
        }

        public CreateTodoTaskResponse CreateTodoTask(string unionId, CreateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTodoTaskHeaders headers = new CreateTodoTaskHeaders();
            return CreateTodoTaskWithOptions(unionId, request, headers, runtime);
        }

        public async Task<CreateTodoTaskResponse> CreateTodoTaskAsync(string unionId, CreateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTodoTaskHeaders headers = new CreateTodoTaskHeaders();
            return await CreateTodoTaskWithOptionsAsync(unionId, request, headers, runtime);
        }

        public CreateTodoTaskResponse CreateTodoTaskWithOptions(string unionId, CreateTodoTaskRequest request, CreateTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                body["creatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIds))
            {
                body["executorIds"] = request.ExecutorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIds))
            {
                body["participantIds"] = request.ParticipantIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailUrl.ToMap()))
            {
                body["detailUrl"] = request.DetailUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateTodoTaskResponse>(DoROARequest("CreateTodoTask", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/tasks", "json", req, runtime));
        }

        public async Task<CreateTodoTaskResponse> CreateTodoTaskWithOptionsAsync(string unionId, CreateTodoTaskRequest request, CreateTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                body["creatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIds))
            {
                body["executorIds"] = request.ExecutorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIds))
            {
                body["participantIds"] = request.ParticipantIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailUrl.ToMap()))
            {
                body["detailUrl"] = request.DetailUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateTodoTaskResponse>(await DoROARequestAsync("CreateTodoTask", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/tasks", "json", req, runtime));
        }

        public GetTodoTypeConfigResponse GetTodoTypeConfig(string unionId, string cardTypeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTypeConfigHeaders headers = new GetTodoTypeConfigHeaders();
            return GetTodoTypeConfigWithOptions(unionId, cardTypeId, headers, runtime);
        }

        public async Task<GetTodoTypeConfigResponse> GetTodoTypeConfigAsync(string unionId, string cardTypeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTypeConfigHeaders headers = new GetTodoTypeConfigHeaders();
            return await GetTodoTypeConfigWithOptionsAsync(unionId, cardTypeId, headers, runtime);
        }

        public GetTodoTypeConfigResponse GetTodoTypeConfigWithOptions(string unionId, string cardTypeId, GetTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetTodoTypeConfigResponse>(DoROARequest("GetTodoTypeConfig", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId, "json", req, runtime));
        }

        public async Task<GetTodoTypeConfigResponse> GetTodoTypeConfigWithOptionsAsync(string unionId, string cardTypeId, GetTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetTodoTypeConfigResponse>(await DoROARequestAsync("GetTodoTypeConfig", "todo_1.0", "HTTP", "GET", "AK", "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId, "json", req, runtime));
        }

        public QueryTodoTasksResponse QueryTodoTasks(string unionId, QueryTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTodoTasksHeaders headers = new QueryTodoTasksHeaders();
            return QueryTodoTasksWithOptions(unionId, request, headers, runtime);
        }

        public async Task<QueryTodoTasksResponse> QueryTodoTasksAsync(string unionId, QueryTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTodoTasksHeaders headers = new QueryTodoTasksHeaders();
            return await QueryTodoTasksWithOptionsAsync(unionId, request, headers, runtime);
        }

        public QueryTodoTasksResponse QueryTodoTasksWithOptions(string unionId, QueryTodoTasksRequest request, QueryTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                body["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDueTime))
            {
                body["fromDueTime"] = request.FromDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDueTime))
            {
                body["toDueTime"] = request.ToDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecycled))
            {
                body["isRecycled"] = request.IsRecycled;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryTodoTasksResponse>(DoROARequest("QueryTodoTasks", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/tasks/list", "json", req, runtime));
        }

        public async Task<QueryTodoTasksResponse> QueryTodoTasksWithOptionsAsync(string unionId, QueryTodoTasksRequest request, QueryTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                body["orderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDirection))
            {
                body["orderDirection"] = request.OrderDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                body["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDueTime))
            {
                body["fromDueTime"] = request.FromDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDueTime))
            {
                body["toDueTime"] = request.ToDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecycled))
            {
                body["isRecycled"] = request.IsRecycled;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryTodoTasksResponse>(await DoROARequestAsync("QueryTodoTasks", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/tasks/list", "json", req, runtime));
        }

        public UpdateTodoTypeConfigResponse UpdateTodoTypeConfig(string unionId, string cardTypeId, UpdateTodoTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTypeConfigHeaders headers = new UpdateTodoTypeConfigHeaders();
            return UpdateTodoTypeConfigWithOptions(unionId, cardTypeId, request, headers, runtime);
        }

        public async Task<UpdateTodoTypeConfigResponse> UpdateTodoTypeConfigAsync(string unionId, string cardTypeId, UpdateTodoTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTypeConfigHeaders headers = new UpdateTodoTypeConfigHeaders();
            return await UpdateTodoTypeConfigWithOptionsAsync(unionId, cardTypeId, request, headers, runtime);
        }

        public UpdateTodoTypeConfigResponse UpdateTodoTypeConfigWithOptions(string unionId, string cardTypeId, UpdateTodoTypeConfigRequest request, UpdateTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcDetailUrlOpenMode))
            {
                body["pcDetailUrlOpenMode"] = request.PcDetailUrlOpenMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldList))
            {
                body["contentFieldList"] = request.ContentFieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionList))
            {
                body["actionList"] = request.ActionList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateTodoTypeConfigResponse>(DoROARequest("UpdateTodoTypeConfig", "todo_1.0", "HTTP", "PUT", "AK", "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId, "json", req, runtime));
        }

        public async Task<UpdateTodoTypeConfigResponse> UpdateTodoTypeConfigWithOptionsAsync(string unionId, string cardTypeId, UpdateTodoTypeConfigRequest request, UpdateTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcDetailUrlOpenMode))
            {
                body["pcDetailUrlOpenMode"] = request.PcDetailUrlOpenMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldList))
            {
                body["contentFieldList"] = request.ContentFieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionList))
            {
                body["actionList"] = request.ActionList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateTodoTypeConfigResponse>(await DoROARequestAsync("UpdateTodoTypeConfig", "todo_1.0", "HTTP", "PUT", "AK", "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId, "json", req, runtime));
        }

        public DeleteTodoTaskResponse DeleteTodoTask(string unionId, string taskId, DeleteTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTodoTaskHeaders headers = new DeleteTodoTaskHeaders();
            return DeleteTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
        }

        public async Task<DeleteTodoTaskResponse> DeleteTodoTaskAsync(string unionId, string taskId, DeleteTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTodoTaskHeaders headers = new DeleteTodoTaskHeaders();
            return await DeleteTodoTaskWithOptionsAsync(unionId, taskId, request, headers, runtime);
        }

        public DeleteTodoTaskResponse DeleteTodoTaskWithOptions(string unionId, string taskId, DeleteTodoTaskRequest request, DeleteTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteTodoTaskResponse>(DoROARequest("DeleteTodoTask", "todo_1.0", "HTTP", "DELETE", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId, "json", req, runtime));
        }

        public async Task<DeleteTodoTaskResponse> DeleteTodoTaskWithOptionsAsync(string unionId, string taskId, DeleteTodoTaskRequest request, DeleteTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteTodoTaskResponse>(await DoROARequestAsync("DeleteTodoTask", "todo_1.0", "HTTP", "DELETE", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId, "json", req, runtime));
        }

        public UpdateTodoTaskExecutorStatusResponse UpdateTodoTaskExecutorStatus(string unionId, string taskId, UpdateTodoTaskExecutorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskExecutorStatusHeaders headers = new UpdateTodoTaskExecutorStatusHeaders();
            return UpdateTodoTaskExecutorStatusWithOptions(unionId, taskId, request, headers, runtime);
        }

        public async Task<UpdateTodoTaskExecutorStatusResponse> UpdateTodoTaskExecutorStatusAsync(string unionId, string taskId, UpdateTodoTaskExecutorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskExecutorStatusHeaders headers = new UpdateTodoTaskExecutorStatusHeaders();
            return await UpdateTodoTaskExecutorStatusWithOptionsAsync(unionId, taskId, request, headers, runtime);
        }

        public UpdateTodoTaskExecutorStatusResponse UpdateTodoTaskExecutorStatusWithOptions(string unionId, string taskId, UpdateTodoTaskExecutorStatusRequest request, UpdateTodoTaskExecutorStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorStatusList))
            {
                body["executorStatusList"] = request.ExecutorStatusList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateTodoTaskExecutorStatusResponse>(DoROARequest("UpdateTodoTaskExecutorStatus", "todo_1.0", "HTTP", "PUT", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + "/executorStatus", "json", req, runtime));
        }

        public async Task<UpdateTodoTaskExecutorStatusResponse> UpdateTodoTaskExecutorStatusWithOptionsAsync(string unionId, string taskId, UpdateTodoTaskExecutorStatusRequest request, UpdateTodoTaskExecutorStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorStatusList))
            {
                body["executorStatusList"] = request.ExecutorStatusList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateTodoTaskExecutorStatusResponse>(await DoROARequestAsync("UpdateTodoTaskExecutorStatus", "todo_1.0", "HTTP", "PUT", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + "/executorStatus", "json", req, runtime));
        }

        public CreateTodoTypeConfigResponse CreateTodoTypeConfig(string unionId, CreateTodoTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTodoTypeConfigHeaders headers = new CreateTodoTypeConfigHeaders();
            return CreateTodoTypeConfigWithOptions(unionId, request, headers, runtime);
        }

        public async Task<CreateTodoTypeConfigResponse> CreateTodoTypeConfigAsync(string unionId, CreateTodoTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTodoTypeConfigHeaders headers = new CreateTodoTypeConfigHeaders();
            return await CreateTodoTypeConfigWithOptionsAsync(unionId, request, headers, runtime);
        }

        public CreateTodoTypeConfigResponse CreateTodoTypeConfigWithOptions(string unionId, CreateTodoTypeConfigRequest request, CreateTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcDetailUrlOpenMode))
            {
                body["pcDetailUrlOpenMode"] = request.PcDetailUrlOpenMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldList))
            {
                body["contentFieldList"] = request.ContentFieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionList))
            {
                body["actionList"] = request.ActionList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateTodoTypeConfigResponse>(DoROARequest("CreateTodoTypeConfig", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/configs/types", "json", req, runtime));
        }

        public async Task<CreateTodoTypeConfigResponse> CreateTodoTypeConfigWithOptionsAsync(string unionId, CreateTodoTypeConfigRequest request, CreateTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcDetailUrlOpenMode))
            {
                body["pcDetailUrlOpenMode"] = request.PcDetailUrlOpenMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldList))
            {
                body["contentFieldList"] = request.ContentFieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionList))
            {
                body["actionList"] = request.ActionList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateTodoTypeConfigResponse>(await DoROARequestAsync("CreateTodoTypeConfig", "todo_1.0", "HTTP", "POST", "AK", "/v1.0/todo/users/" + unionId + "/configs/types", "json", req, runtime));
        }

        public UpdateTodoTaskResponse UpdateTodoTask(string unionId, string taskId, UpdateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskHeaders headers = new UpdateTodoTaskHeaders();
            return UpdateTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
        }

        public async Task<UpdateTodoTaskResponse> UpdateTodoTaskAsync(string unionId, string taskId, UpdateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskHeaders headers = new UpdateTodoTaskHeaders();
            return await UpdateTodoTaskWithOptionsAsync(unionId, taskId, request, headers, runtime);
        }

        public UpdateTodoTaskResponse UpdateTodoTaskWithOptions(string unionId, string taskId, UpdateTodoTaskRequest request, UpdateTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Done))
            {
                body["done"] = request.Done;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIds))
            {
                body["executorIds"] = request.ExecutorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIds))
            {
                body["participantIds"] = request.ParticipantIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateTodoTaskResponse>(DoROARequest("UpdateTodoTask", "todo_1.0", "HTTP", "PUT", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId, "json", req, runtime));
        }

        public async Task<UpdateTodoTaskResponse> UpdateTodoTaskWithOptionsAsync(string unionId, string taskId, UpdateTodoTaskRequest request, UpdateTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Done))
            {
                body["done"] = request.Done;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIds))
            {
                body["executorIds"] = request.ExecutorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIds))
            {
                body["participantIds"] = request.ParticipantIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpdateTodoTaskResponse>(await DoROARequestAsync("UpdateTodoTask", "todo_1.0", "HTTP", "PUT", "AK", "/v1.0/todo/users/" + unionId + "/tasks/" + taskId, "json", req, runtime));
        }

    }
}
