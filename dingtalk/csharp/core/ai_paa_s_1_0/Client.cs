// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0
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


        public ExecuteAgentResponse ExecuteAgentWithOptions(ExecuteAgentRequest request, ExecuteAgentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentCode))
            {
                body["agentCode"] = request.AgentCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inputs))
            {
                body["inputs"] = request.Inputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioCode))
            {
                body["scenarioCode"] = request.ScenarioCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioInstanceId))
            {
                body["scenarioInstanceId"] = request.ScenarioInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                body["skillId"] = request.SkillId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExecuteAgent",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/me/agents/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAgentResponse>(Execute(params_, req, runtime));
        }

        public async Task<ExecuteAgentResponse> ExecuteAgentWithOptionsAsync(ExecuteAgentRequest request, ExecuteAgentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentCode))
            {
                body["agentCode"] = request.AgentCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inputs))
            {
                body["inputs"] = request.Inputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioCode))
            {
                body["scenarioCode"] = request.ScenarioCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenarioInstanceId))
            {
                body["scenarioInstanceId"] = request.ScenarioInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                body["skillId"] = request.SkillId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExecuteAgent",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/me/agents/execute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAgentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ExecuteAgentResponse ExecuteAgent(ExecuteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteAgentHeaders headers = new ExecuteAgentHeaders();
            return ExecuteAgentWithOptions(request, headers, runtime);
        }

        public async Task<ExecuteAgentResponse> ExecuteAgentAsync(ExecuteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteAgentHeaders headers = new ExecuteAgentHeaders();
            return await ExecuteAgentWithOptionsAsync(request, headers, runtime);
        }

        public LiandanluExclusiveModelResponse LiandanluExclusiveModelWithOptions(LiandanluExclusiveModelRequest request, LiandanluExclusiveModelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
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
                Action = "LiandanluExclusiveModel",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/ai/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiandanluExclusiveModelResponse>(Execute(params_, req, runtime));
        }

        public async Task<LiandanluExclusiveModelResponse> LiandanluExclusiveModelWithOptionsAsync(LiandanluExclusiveModelRequest request, LiandanluExclusiveModelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
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
                Action = "LiandanluExclusiveModel",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/ai/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiandanluExclusiveModelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public LiandanluExclusiveModelResponse LiandanluExclusiveModel(LiandanluExclusiveModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LiandanluExclusiveModelHeaders headers = new LiandanluExclusiveModelHeaders();
            return LiandanluExclusiveModelWithOptions(request, headers, runtime);
        }

        public async Task<LiandanluExclusiveModelResponse> LiandanluExclusiveModelAsync(LiandanluExclusiveModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LiandanluExclusiveModelHeaders headers = new LiandanluExclusiveModelHeaders();
            return await LiandanluExclusiveModelWithOptionsAsync(request, headers, runtime);
        }

        public QueryConversationMessageForAIResponse QueryConversationMessageForAIWithOptions(string cid, QueryConversationMessageForAIRequest tmpReq, QueryConversationMessageForAIHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryConversationMessageForAIShrinkRequest request = new QueryConversationMessageForAIShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenMsgIds))
            {
                request.OpenMsgIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenMsgIds, "openMsgIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMsgIdsShrink))
            {
                query["openMsgIds"] = request.OpenMsgIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentDays))
            {
                query["recentDays"] = request.RecentDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentHours))
            {
                query["recentHours"] = request.RecentHours;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentN))
            {
                query["recentN"] = request.RecentN;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryConversationMessageForAI",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/me/memory/im/" + cid + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConversationMessageForAIResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryConversationMessageForAIResponse> QueryConversationMessageForAIWithOptionsAsync(string cid, QueryConversationMessageForAIRequest tmpReq, QueryConversationMessageForAIHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryConversationMessageForAIShrinkRequest request = new QueryConversationMessageForAIShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OpenMsgIds))
            {
                request.OpenMsgIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OpenMsgIds, "openMsgIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMsgIdsShrink))
            {
                query["openMsgIds"] = request.OpenMsgIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentDays))
            {
                query["recentDays"] = request.RecentDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentHours))
            {
                query["recentHours"] = request.RecentHours;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentN))
            {
                query["recentN"] = request.RecentN;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryConversationMessageForAI",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/me/memory/im/" + cid + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryConversationMessageForAIResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryConversationMessageForAIResponse QueryConversationMessageForAI(string cid, QueryConversationMessageForAIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConversationMessageForAIHeaders headers = new QueryConversationMessageForAIHeaders();
            return QueryConversationMessageForAIWithOptions(cid, request, headers, runtime);
        }

        public async Task<QueryConversationMessageForAIResponse> QueryConversationMessageForAIAsync(string cid, QueryConversationMessageForAIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConversationMessageForAIHeaders headers = new QueryConversationMessageForAIHeaders();
            return await QueryConversationMessageForAIWithOptionsAsync(cid, request, headers, runtime);
        }

        public QueryMemoryLearningTaskResponse QueryMemoryLearningTaskWithOptions(QueryMemoryLearningTaskRequest request, QueryMemoryLearningTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentCode))
            {
                query["agentCode"] = request.AgentCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningCode))
            {
                query["learningCode"] = request.LearningCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryMemoryLearningTask",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/me/memory/learningTask/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMemoryLearningTaskResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryMemoryLearningTaskResponse> QueryMemoryLearningTaskWithOptionsAsync(QueryMemoryLearningTaskRequest request, QueryMemoryLearningTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentCode))
            {
                query["agentCode"] = request.AgentCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningCode))
            {
                query["learningCode"] = request.LearningCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryMemoryLearningTask",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/me/memory/learningTask/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMemoryLearningTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryMemoryLearningTaskResponse QueryMemoryLearningTask(QueryMemoryLearningTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMemoryLearningTaskHeaders headers = new QueryMemoryLearningTaskHeaders();
            return QueryMemoryLearningTaskWithOptions(request, headers, runtime);
        }

        public async Task<QueryMemoryLearningTaskResponse> QueryMemoryLearningTaskAsync(QueryMemoryLearningTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMemoryLearningTaskHeaders headers = new QueryMemoryLearningTaskHeaders();
            return await QueryMemoryLearningTaskWithOptionsAsync(request, headers, runtime);
        }

        public SubmitMemoryLearningTaskResponse SubmitMemoryLearningTaskWithOptions(SubmitMemoryLearningTaskRequest tmpReq, SubmitMemoryLearningTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitMemoryLearningTaskShrinkRequest request = new SubmitMemoryLearningTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "content", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentCode))
            {
                query["agentCode"] = request.AgentCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningMode))
            {
                query["learningMode"] = request.LearningMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryKey))
            {
                query["memoryKey"] = request.MemoryKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SubmitMemoryLearningTask",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/me/memory/learningTask/put",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMemoryLearningTaskResponse>(Execute(params_, req, runtime));
        }

        public async Task<SubmitMemoryLearningTaskResponse> SubmitMemoryLearningTaskWithOptionsAsync(SubmitMemoryLearningTaskRequest tmpReq, SubmitMemoryLearningTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitMemoryLearningTaskShrinkRequest request = new SubmitMemoryLearningTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "content", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentCode))
            {
                query["agentCode"] = request.AgentCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LearningMode))
            {
                query["learningMode"] = request.LearningMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemoryKey))
            {
                query["memoryKey"] = request.MemoryKey;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SubmitMemoryLearningTask",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/me/memory/learningTask/put",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitMemoryLearningTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SubmitMemoryLearningTaskResponse SubmitMemoryLearningTask(SubmitMemoryLearningTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitMemoryLearningTaskHeaders headers = new SubmitMemoryLearningTaskHeaders();
            return SubmitMemoryLearningTaskWithOptions(request, headers, runtime);
        }

        public async Task<SubmitMemoryLearningTaskResponse> SubmitMemoryLearningTaskAsync(SubmitMemoryLearningTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitMemoryLearningTaskHeaders headers = new SubmitMemoryLearningTaskHeaders();
            return await SubmitMemoryLearningTaskWithOptionsAsync(request, headers, runtime);
        }

    }
}
