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
        /// <para>查询用户待办计数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountTodoTasksRequest
        /// </param>
        /// <param name="headers">
        /// CountTodoTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountTodoTasksResponse
        /// </returns>
        public CountTodoTasksResponse CountTodoTasksWithOptions(string unionId, CountTodoTasksRequest request, CountTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDueTime))
            {
                body["fromDueTime"] = request.FromDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecycled))
            {
                body["isRecycled"] = request.IsRecycled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                body["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDueTime))
            {
                body["toDueTime"] = request.ToDueTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CountTodoTasks",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/count",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountTodoTasksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户待办计数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountTodoTasksRequest
        /// </param>
        /// <param name="headers">
        /// CountTodoTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountTodoTasksResponse
        /// </returns>
        public async Task<CountTodoTasksResponse> CountTodoTasksWithOptionsAsync(string unionId, CountTodoTasksRequest request, CountTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDueTime))
            {
                body["fromDueTime"] = request.FromDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecycled))
            {
                body["isRecycled"] = request.IsRecycled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                body["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDueTime))
            {
                body["toDueTime"] = request.ToDueTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CountTodoTasks",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/count",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountTodoTasksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户待办计数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountTodoTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// CountTodoTasksResponse
        /// </returns>
        public CountTodoTasksResponse CountTodoTasks(string unionId, CountTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CountTodoTasksHeaders headers = new CountTodoTasksHeaders();
            return CountTodoTasksWithOptions(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户待办计数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountTodoTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// CountTodoTasksResponse
        /// </returns>
        public async Task<CountTodoTasksResponse> CountTodoTasksAsync(string unionId, CountTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CountTodoTasksHeaders headers = new CountTodoTasksHeaders();
            return await CountTodoTasksWithOptionsAsync(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以用户个人身份创建个人待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePersonalTodoTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreatePersonalTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalTodoTaskResponse
        /// </returns>
        public CreatePersonalTodoTaskResponse CreatePersonalTodoTaskWithOptions(CreatePersonalTodoTaskRequest request, CreatePersonalTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyConfigs))
            {
                body["notifyConfigs"] = request.NotifyConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIds))
            {
                body["participantIds"] = request.ParticipantIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReminderTimeStamp))
            {
                body["reminderTimeStamp"] = request.ReminderTimeStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreatePersonalTodoTask",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/me/personalTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalTodoTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以用户个人身份创建个人待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePersonalTodoTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreatePersonalTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalTodoTaskResponse
        /// </returns>
        public async Task<CreatePersonalTodoTaskResponse> CreatePersonalTodoTaskWithOptionsAsync(CreatePersonalTodoTaskRequest request, CreatePersonalTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyConfigs))
            {
                body["notifyConfigs"] = request.NotifyConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIds))
            {
                body["participantIds"] = request.ParticipantIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReminderTimeStamp))
            {
                body["reminderTimeStamp"] = request.ReminderTimeStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreatePersonalTodoTask",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/me/personalTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalTodoTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以用户个人身份创建个人待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePersonalTodoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalTodoTaskResponse
        /// </returns>
        public CreatePersonalTodoTaskResponse CreatePersonalTodoTask(CreatePersonalTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePersonalTodoTaskHeaders headers = new CreatePersonalTodoTaskHeaders();
            return CreatePersonalTodoTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以用户个人身份创建个人待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePersonalTodoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePersonalTodoTaskResponse
        /// </returns>
        public async Task<CreatePersonalTodoTaskResponse> CreatePersonalTodoTaskAsync(CreatePersonalTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePersonalTodoTaskHeaders headers = new CreatePersonalTodoTaskHeaders();
            return await CreatePersonalTodoTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTodoTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTodoTaskResponse
        /// </returns>
        public CreateTodoTaskResponse CreateTodoTaskWithOptions(string unionId, CreateTodoTaskRequest request, CreateTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionList))
            {
                body["actionList"] = request.ActionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategoryId))
            {
                body["bizCategoryId"] = request.BizCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldList))
            {
                body["contentFieldList"] = request.ContentFieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                body["creatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailUrl))
            {
                body["detailUrl"] = request.DetailUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIds))
            {
                body["executorIds"] = request.ExecutorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnlyShowExecutor))
            {
                body["isOnlyShowExecutor"] = request.IsOnlyShowExecutor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyConfigs))
            {
                body["notifyConfigs"] = request.NotifyConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIds))
            {
                body["participantIds"] = request.ParticipantIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateTodoTask",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTodoTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTodoTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTodoTaskResponse
        /// </returns>
        public async Task<CreateTodoTaskResponse> CreateTodoTaskWithOptionsAsync(string unionId, CreateTodoTaskRequest request, CreateTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionList))
            {
                body["actionList"] = request.ActionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategoryId))
            {
                body["bizCategoryId"] = request.BizCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldList))
            {
                body["contentFieldList"] = request.ContentFieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorId))
            {
                body["creatorId"] = request.CreatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailUrl))
            {
                body["detailUrl"] = request.DetailUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutorIds))
            {
                body["executorIds"] = request.ExecutorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOnlyShowExecutor))
            {
                body["isOnlyShowExecutor"] = request.IsOnlyShowExecutor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyConfigs))
            {
                body["notifyConfigs"] = request.NotifyConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParticipantIds))
            {
                body["participantIds"] = request.ParticipantIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateTodoTask",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTodoTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTodoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTodoTaskResponse
        /// </returns>
        public CreateTodoTaskResponse CreateTodoTask(string unionId, CreateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTodoTaskHeaders headers = new CreateTodoTaskHeaders();
            return CreateTodoTaskWithOptions(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTodoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTodoTaskResponse
        /// </returns>
        public async Task<CreateTodoTaskResponse> CreateTodoTaskAsync(string unionId, CreateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTodoTaskHeaders headers = new CreateTodoTaskHeaders();
            return await CreateTodoTaskWithOptionsAsync(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTodoTypeConfigRequest
        /// </param>
        /// <param name="headers">
        /// CreateTodoTypeConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTodoTypeConfigResponse
        /// </returns>
        public CreateTodoTypeConfigResponse CreateTodoTypeConfigWithOptions(string unionId, CreateTodoTypeConfigRequest request, CreateTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionList))
            {
                body["actionList"] = request.ActionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldList))
            {
                body["contentFieldList"] = request.ContentFieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcDetailUrlOpenMode))
            {
                body["pcDetailUrlOpenMode"] = request.PcDetailUrlOpenMode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateTodoTypeConfig",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/configs/types",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTodoTypeConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTodoTypeConfigRequest
        /// </param>
        /// <param name="headers">
        /// CreateTodoTypeConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTodoTypeConfigResponse
        /// </returns>
        public async Task<CreateTodoTypeConfigResponse> CreateTodoTypeConfigWithOptionsAsync(string unionId, CreateTodoTypeConfigRequest request, CreateTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionList))
            {
                body["actionList"] = request.ActionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldList))
            {
                body["contentFieldList"] = request.ContentFieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcDetailUrlOpenMode))
            {
                body["pcDetailUrlOpenMode"] = request.PcDetailUrlOpenMode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateTodoTypeConfig",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/configs/types",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTodoTypeConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTodoTypeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTodoTypeConfigResponse
        /// </returns>
        public CreateTodoTypeConfigResponse CreateTodoTypeConfig(string unionId, CreateTodoTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTodoTypeConfigHeaders headers = new CreateTodoTypeConfigHeaders();
            return CreateTodoTypeConfigWithOptions(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTodoTypeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTodoTypeConfigResponse
        /// </returns>
        public async Task<CreateTodoTypeConfigResponse> CreateTodoTypeConfigAsync(string unionId, CreateTodoTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateTodoTypeConfigHeaders headers = new CreateTodoTypeConfigHeaders();
            return await CreateTodoTypeConfigWithOptionsAsync(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTodoTaskRequest
        /// </param>
        /// <param name="headers">
        /// DeleteTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTodoTaskResponse
        /// </returns>
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTodoTask",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/" + taskId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTodoTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTodoTaskRequest
        /// </param>
        /// <param name="headers">
        /// DeleteTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTodoTaskResponse
        /// </returns>
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTodoTask",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/" + taskId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTodoTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTodoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTodoTaskResponse
        /// </returns>
        public DeleteTodoTaskResponse DeleteTodoTask(string unionId, string taskId, DeleteTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTodoTaskHeaders headers = new DeleteTodoTaskHeaders();
            return DeleteTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTodoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTodoTaskResponse
        /// </returns>
        public async Task<DeleteTodoTaskResponse> DeleteTodoTaskAsync(string unionId, string taskId, DeleteTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteTodoTaskHeaders headers = new DeleteTodoTaskHeaders();
            return await DeleteTodoTaskWithOptionsAsync(unionId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询待办</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTodoTaskResponse
        /// </returns>
        public GetTodoTaskResponse GetTodoTaskWithOptions(string unionId, string taskId, GetTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTodoTask",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTodoTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询待办</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTodoTaskResponse
        /// </returns>
        public async Task<GetTodoTaskResponse> GetTodoTaskWithOptionsAsync(string unionId, string taskId, GetTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTodoTask",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTodoTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询待办</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTodoTaskResponse
        /// </returns>
        public GetTodoTaskResponse GetTodoTask(string unionId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskHeaders headers = new GetTodoTaskHeaders();
            return GetTodoTaskWithOptions(unionId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询待办</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTodoTaskResponse
        /// </returns>
        public async Task<GetTodoTaskResponse> GetTodoTaskAsync(string unionId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskHeaders headers = new GetTodoTaskHeaders();
            return await GetTodoTaskWithOptionsAsync(unionId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据sourceId查询待办详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetTodoTaskBySourceIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTodoTaskBySourceIdResponse
        /// </returns>
        public GetTodoTaskBySourceIdResponse GetTodoTaskBySourceIdWithOptions(string unionId, string sourceId, GetTodoTaskBySourceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTodoTaskBySourceId",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/sources/" + sourceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTodoTaskBySourceIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据sourceId查询待办详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetTodoTaskBySourceIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTodoTaskBySourceIdResponse
        /// </returns>
        public async Task<GetTodoTaskBySourceIdResponse> GetTodoTaskBySourceIdWithOptionsAsync(string unionId, string sourceId, GetTodoTaskBySourceIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTodoTaskBySourceId",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/sources/" + sourceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTodoTaskBySourceIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据sourceId查询待办详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTodoTaskBySourceIdResponse
        /// </returns>
        public GetTodoTaskBySourceIdResponse GetTodoTaskBySourceId(string unionId, string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskBySourceIdHeaders headers = new GetTodoTaskBySourceIdHeaders();
            return GetTodoTaskBySourceIdWithOptions(unionId, sourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据sourceId查询待办详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTodoTaskBySourceIdResponse
        /// </returns>
        public async Task<GetTodoTaskBySourceIdResponse> GetTodoTaskBySourceIdAsync(string unionId, string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskBySourceIdHeaders headers = new GetTodoTaskBySourceIdHeaders();
            return await GetTodoTaskBySourceIdWithOptionsAsync(unionId, sourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属钉根据待办ID查询待办详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetTodoTaskDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTodoTaskDetailResponse
        /// </returns>
        public GetTodoTaskDetailResponse GetTodoTaskDetailWithOptions(string taskId, string unionId, GetTodoTaskDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTodoTaskDetail",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/exclusive/users/" + unionId + "/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTodoTaskDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属钉根据待办ID查询待办详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetTodoTaskDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTodoTaskDetailResponse
        /// </returns>
        public async Task<GetTodoTaskDetailResponse> GetTodoTaskDetailWithOptionsAsync(string taskId, string unionId, GetTodoTaskDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTodoTaskDetail",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/exclusive/users/" + unionId + "/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTodoTaskDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属钉根据待办ID查询待办详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTodoTaskDetailResponse
        /// </returns>
        public GetTodoTaskDetailResponse GetTodoTaskDetail(string taskId, string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskDetailHeaders headers = new GetTodoTaskDetailHeaders();
            return GetTodoTaskDetailWithOptions(taskId, unionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>专属钉根据待办ID查询待办详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTodoTaskDetailResponse
        /// </returns>
        public async Task<GetTodoTaskDetailResponse> GetTodoTaskDetailAsync(string taskId, string unionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTaskDetailHeaders headers = new GetTodoTaskDetailHeaders();
            return await GetTodoTaskDetailWithOptionsAsync(taskId, unionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetTodoTypeConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTodoTypeConfigResponse
        /// </returns>
        public GetTodoTypeConfigResponse GetTodoTypeConfigWithOptions(string unionId, string cardTypeId, GetTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTodoTypeConfig",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTodoTypeConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetTodoTypeConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTodoTypeConfigResponse
        /// </returns>
        public async Task<GetTodoTypeConfigResponse> GetTodoTypeConfigWithOptionsAsync(string unionId, string cardTypeId, GetTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTodoTypeConfig",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTodoTypeConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTodoTypeConfigResponse
        /// </returns>
        public GetTodoTypeConfigResponse GetTodoTypeConfig(string unionId, string cardTypeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTypeConfigHeaders headers = new GetTodoTypeConfigHeaders();
            return GetTodoTypeConfigWithOptions(unionId, cardTypeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id获取待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTodoTypeConfigResponse
        /// </returns>
        public async Task<GetTodoTypeConfigResponse> GetTodoTypeConfigAsync(string unionId, string cardTypeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetTodoTypeConfigHeaders headers = new GetTodoTypeConfigHeaders();
            return await GetTodoTypeConfigWithOptionsAsync(unionId, cardTypeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgTodoByUserRequest
        /// </param>
        /// <param name="headers">
        /// QueryOrgTodoByUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgTodoByUserResponse
        /// </returns>
        public QueryOrgTodoByUserResponse QueryOrgTodoByUserWithOptions(string unionId, QueryOrgTodoByUserRequest request, QueryOrgTodoByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDueTime))
            {
                body["fromDueTime"] = request.FromDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                body["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDueTime))
            {
                body["toDueTime"] = request.ToDueTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryOrgTodoByUser",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/organizations/tasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgTodoByUserResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgTodoByUserRequest
        /// </param>
        /// <param name="headers">
        /// QueryOrgTodoByUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgTodoByUserResponse
        /// </returns>
        public async Task<QueryOrgTodoByUserResponse> QueryOrgTodoByUserWithOptionsAsync(string unionId, QueryOrgTodoByUserRequest request, QueryOrgTodoByUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDueTime))
            {
                body["fromDueTime"] = request.FromDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                body["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDueTime))
            {
                body["toDueTime"] = request.ToDueTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryOrgTodoByUser",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/organizations/tasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgTodoByUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgTodoByUserRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgTodoByUserResponse
        /// </returns>
        public QueryOrgTodoByUserResponse QueryOrgTodoByUser(string unionId, QueryOrgTodoByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgTodoByUserHeaders headers = new QueryOrgTodoByUserHeaders();
            return QueryOrgTodoByUserWithOptions(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户企业类型待办列表，支持查询当前企业的一方应用、三方应用、自建应用产生的工作待办数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgTodoByUserRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgTodoByUserResponse
        /// </returns>
        public async Task<QueryOrgTodoByUserResponse> QueryOrgTodoByUserAsync(string unionId, QueryOrgTodoByUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgTodoByUserHeaders headers = new QueryOrgTodoByUserHeaders();
            return await QueryOrgTodoByUserWithOptionsAsync(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下用户待办列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgTodoTasksRequest
        /// </param>
        /// <param name="headers">
        /// QueryOrgTodoTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgTodoTasksResponse
        /// </returns>
        public QueryOrgTodoTasksResponse QueryOrgTodoTasksWithOptions(string unionId, QueryOrgTodoTasksRequest request, QueryOrgTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryOrgTodoTasks",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/org/tasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgTodoTasksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下用户待办列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgTodoTasksRequest
        /// </param>
        /// <param name="headers">
        /// QueryOrgTodoTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgTodoTasksResponse
        /// </returns>
        public async Task<QueryOrgTodoTasksResponse> QueryOrgTodoTasksWithOptionsAsync(string unionId, QueryOrgTodoTasksRequest request, QueryOrgTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryOrgTodoTasks",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/org/tasks/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrgTodoTasksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下用户待办列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgTodoTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgTodoTasksResponse
        /// </returns>
        public QueryOrgTodoTasksResponse QueryOrgTodoTasks(string unionId, QueryOrgTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgTodoTasksHeaders headers = new QueryOrgTodoTasksHeaders();
            return QueryOrgTodoTasksWithOptions(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业下用户待办列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOrgTodoTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrgTodoTasksResponse
        /// </returns>
        public async Task<QueryOrgTodoTasksResponse> QueryOrgTodoTasksAsync(string unionId, QueryOrgTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOrgTodoTasksHeaders headers = new QueryOrgTodoTasksHeaders();
            return await QueryOrgTodoTasksWithOptionsAsync(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户待办列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTodoTasksRequest
        /// </param>
        /// <param name="headers">
        /// QueryTodoTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTodoTasksResponse
        /// </returns>
        public QueryTodoTasksResponse QueryTodoTasksWithOptions(string unionId, QueryTodoTasksRequest request, QueryTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDueTime))
            {
                body["fromDueTime"] = request.FromDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecycled))
            {
                body["isRecycled"] = request.IsRecycled;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                body["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDueTime))
            {
                body["toDueTime"] = request.ToDueTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryTodoTasks",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTodoTasksResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户待办列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTodoTasksRequest
        /// </param>
        /// <param name="headers">
        /// QueryTodoTasksHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTodoTasksResponse
        /// </returns>
        public async Task<QueryTodoTasksResponse> QueryTodoTasksWithOptionsAsync(string unionId, QueryTodoTasksRequest request, QueryTodoTasksHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromDueTime))
            {
                body["fromDueTime"] = request.FromDueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDone))
            {
                body["isDone"] = request.IsDone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRecycled))
            {
                body["isRecycled"] = request.IsRecycled;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleTypes))
            {
                body["roleTypes"] = request.RoleTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToDueTime))
            {
                body["toDueTime"] = request.ToDueTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryTodoTasks",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTodoTasksResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户待办列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTodoTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTodoTasksResponse
        /// </returns>
        public QueryTodoTasksResponse QueryTodoTasks(string unionId, QueryTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTodoTasksHeaders headers = new QueryTodoTasksHeaders();
            return QueryTodoTasksWithOptions(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户待办列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTodoTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTodoTasksResponse
        /// </returns>
        public async Task<QueryTodoTasksResponse> QueryTodoTasksAsync(string unionId, QueryTodoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTodoTasksHeaders headers = new QueryTodoTasksHeaders();
            return await QueryTodoTasksWithOptionsAsync(unionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTaskRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTaskResponse
        /// </returns>
        public UpdateTodoTaskResponse UpdateTodoTaskWithOptions(string unionId, string taskId, UpdateTodoTaskRequest request, UpdateTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Done))
            {
                body["done"] = request.Done;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateTodoTask",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/" + taskId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTodoTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTaskRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTodoTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTaskResponse
        /// </returns>
        public async Task<UpdateTodoTaskResponse> UpdateTodoTaskWithOptionsAsync(string unionId, string taskId, UpdateTodoTaskRequest request, UpdateTodoTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Done))
            {
                body["done"] = request.Done;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["subject"] = request.Subject;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateTodoTask",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/" + taskId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTodoTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTaskResponse
        /// </returns>
        public UpdateTodoTaskResponse UpdateTodoTask(string unionId, string taskId, UpdateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskHeaders headers = new UpdateTodoTaskHeaders();
            return UpdateTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTaskResponse
        /// </returns>
        public async Task<UpdateTodoTaskResponse> UpdateTodoTaskAsync(string unionId, string taskId, UpdateTodoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskHeaders headers = new UpdateTodoTaskHeaders();
            return await UpdateTodoTaskWithOptionsAsync(unionId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办执行者状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTaskExecutorStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTodoTaskExecutorStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTaskExecutorStatusResponse
        /// </returns>
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
                Action = "UpdateTodoTaskExecutorStatus",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + "/executorStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTodoTaskExecutorStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办执行者状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTaskExecutorStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTodoTaskExecutorStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTaskExecutorStatusResponse
        /// </returns>
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
                Action = "UpdateTodoTaskExecutorStatus",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/tasks/" + taskId + "/executorStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTodoTaskExecutorStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办执行者状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTaskExecutorStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTaskExecutorStatusResponse
        /// </returns>
        public UpdateTodoTaskExecutorStatusResponse UpdateTodoTaskExecutorStatus(string unionId, string taskId, UpdateTodoTaskExecutorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskExecutorStatusHeaders headers = new UpdateTodoTaskExecutorStatusHeaders();
            return UpdateTodoTaskExecutorStatusWithOptions(unionId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办执行者状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTaskExecutorStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTaskExecutorStatusResponse
        /// </returns>
        public async Task<UpdateTodoTaskExecutorStatusResponse> UpdateTodoTaskExecutorStatusAsync(string unionId, string taskId, UpdateTodoTaskExecutorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTaskExecutorStatusHeaders headers = new UpdateTodoTaskExecutorStatusHeaders();
            return await UpdateTodoTaskExecutorStatusWithOptionsAsync(unionId, taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTypeConfigRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTodoTypeConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTypeConfigResponse
        /// </returns>
        public UpdateTodoTypeConfigResponse UpdateTodoTypeConfigWithOptions(string unionId, string cardTypeId, UpdateTodoTypeConfigRequest request, UpdateTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionList))
            {
                body["actionList"] = request.ActionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldList))
            {
                body["contentFieldList"] = request.ContentFieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcDetailUrlOpenMode))
            {
                body["pcDetailUrlOpenMode"] = request.PcDetailUrlOpenMode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateTodoTypeConfig",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTodoTypeConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTypeConfigRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTodoTypeConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTypeConfigResponse
        /// </returns>
        public async Task<UpdateTodoTypeConfigResponse> UpdateTodoTypeConfigWithOptionsAsync(string unionId, string cardTypeId, UpdateTodoTypeConfigRequest request, UpdateTodoTypeConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                query["operatorId"] = request.OperatorId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionList))
            {
                body["actionList"] = request.ActionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentFieldList))
            {
                body["contentFieldList"] = request.ContentFieldList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcDetailUrlOpenMode))
            {
                body["pcDetailUrlOpenMode"] = request.PcDetailUrlOpenMode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateTodoTypeConfig",
                Version = "todo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todo/users/" + unionId + "/configs/types/" + cardTypeId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTodoTypeConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTypeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTypeConfigResponse
        /// </returns>
        public UpdateTodoTypeConfigResponse UpdateTodoTypeConfig(string unionId, string cardTypeId, UpdateTodoTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTypeConfigHeaders headers = new UpdateTodoTypeConfigHeaders();
            return UpdateTodoTypeConfigWithOptions(unionId, cardTypeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新待办卡片类型配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTodoTypeConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTodoTypeConfigResponse
        /// </returns>
        public async Task<UpdateTodoTypeConfigResponse> UpdateTodoTypeConfigAsync(string unionId, string cardTypeId, UpdateTodoTypeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTodoTypeConfigHeaders headers = new UpdateTodoTypeConfigHeaders();
            return await UpdateTodoTypeConfigWithOptionsAsync(unionId, cardTypeId, request, headers, runtime);
        }

    }
}
