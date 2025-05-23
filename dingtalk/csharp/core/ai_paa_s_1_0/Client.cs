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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉专属模型推理服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExclusiveModelCompleteServiceRequest
        /// </param>
        /// <param name="headers">
        /// ExclusiveModelCompleteServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExclusiveModelCompleteServiceResponse
        /// </returns>
        public ExclusiveModelCompleteServiceResponse ExclusiveModelCompleteServiceWithOptions(ExclusiveModelCompleteServiceRequest request, ExclusiveModelCompleteServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSearch))
            {
                body["enable_search"] = request.EnableSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTokens))
            {
                body["max_tokens"] = request.MaxTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Temperature))
            {
                body["temperature"] = request.Temperature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopP))
            {
                body["top_p"] = request.TopP;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExclusiveModelCompleteService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/ai/complete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExclusiveModelCompleteServiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉专属模型推理服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExclusiveModelCompleteServiceRequest
        /// </param>
        /// <param name="headers">
        /// ExclusiveModelCompleteServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExclusiveModelCompleteServiceResponse
        /// </returns>
        public async Task<ExclusiveModelCompleteServiceResponse> ExclusiveModelCompleteServiceWithOptionsAsync(ExclusiveModelCompleteServiceRequest request, ExclusiveModelCompleteServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSearch))
            {
                body["enable_search"] = request.EnableSearch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTokens))
            {
                body["max_tokens"] = request.MaxTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["messages"] = request.Messages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Temperature))
            {
                body["temperature"] = request.Temperature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopP))
            {
                body["top_p"] = request.TopP;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ExclusiveModelCompleteService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/ai/complete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExclusiveModelCompleteServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉专属模型推理服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExclusiveModelCompleteServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// ExclusiveModelCompleteServiceResponse
        /// </returns>
        public ExclusiveModelCompleteServiceResponse ExclusiveModelCompleteService(ExclusiveModelCompleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExclusiveModelCompleteServiceHeaders headers = new ExclusiveModelCompleteServiceHeaders();
            return ExclusiveModelCompleteServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉专属模型推理服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExclusiveModelCompleteServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// ExclusiveModelCompleteServiceResponse
        /// </returns>
        public async Task<ExclusiveModelCompleteServiceResponse> ExclusiveModelCompleteServiceAsync(ExclusiveModelCompleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExclusiveModelCompleteServiceHeaders headers = new ExclusiveModelCompleteServiceHeaders();
            return await ExclusiveModelCompleteServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行AI技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAgentRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteAgentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAgentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行AI技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAgentRequest
        /// </param>
        /// <param name="headers">
        /// ExecuteAgentHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAgentResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行AI技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAgentResponse
        /// </returns>
        public ExecuteAgentResponse ExecuteAgent(ExecuteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteAgentHeaders headers = new ExecuteAgentHeaders();
            return ExecuteAgentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行AI技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAgentResponse
        /// </returns>
        public async Task<ExecuteAgentResponse> ExecuteAgentAsync(ExecuteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExecuteAgentHeaders headers = new ExecuteAgentHeaders();
            return await ExecuteAgentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉文生图任务结果获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanTextImageGetRequest
        /// </param>
        /// <param name="headers">
        /// LiandanTextImageGetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LiandanTextImageGetResponse
        /// </returns>
        public LiandanTextImageGetResponse LiandanTextImageGetWithOptions(LiandanTextImageGetRequest request, LiandanTextImageGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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
                Action = "LiandanTextImageGet",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/ai/textToImage/results/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiandanTextImageGetResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉文生图任务结果获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanTextImageGetRequest
        /// </param>
        /// <param name="headers">
        /// LiandanTextImageGetHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LiandanTextImageGetResponse
        /// </returns>
        public async Task<LiandanTextImageGetResponse> LiandanTextImageGetWithOptionsAsync(LiandanTextImageGetRequest request, LiandanTextImageGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
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
                Action = "LiandanTextImageGet",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/ai/textToImage/results/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiandanTextImageGetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉文生图任务结果获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanTextImageGetRequest
        /// </param>
        /// 
        /// <returns>
        /// LiandanTextImageGetResponse
        /// </returns>
        public LiandanTextImageGetResponse LiandanTextImageGet(LiandanTextImageGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LiandanTextImageGetHeaders headers = new LiandanTextImageGetHeaders();
            return LiandanTextImageGetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉文生图任务结果获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanTextImageGetRequest
        /// </param>
        /// 
        /// <returns>
        /// LiandanTextImageGetResponse
        /// </returns>
        public async Task<LiandanTextImageGetResponse> LiandanTextImageGetAsync(LiandanTextImageGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LiandanTextImageGetHeaders headers = new LiandanTextImageGetHeaders();
            return await LiandanTextImageGetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉专属模型接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanluExclusiveModelRequest
        /// </param>
        /// <param name="headers">
        /// LiandanluExclusiveModelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LiandanluExclusiveModelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉专属模型接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanluExclusiveModelRequest
        /// </param>
        /// <param name="headers">
        /// LiandanluExclusiveModelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LiandanluExclusiveModelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉专属模型接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanluExclusiveModelRequest
        /// </param>
        /// 
        /// <returns>
        /// LiandanluExclusiveModelResponse
        /// </returns>
        public LiandanluExclusiveModelResponse LiandanluExclusiveModel(LiandanluExclusiveModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LiandanluExclusiveModelHeaders headers = new LiandanluExclusiveModelHeaders();
            return LiandanluExclusiveModelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉专属模型接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanluExclusiveModelRequest
        /// </param>
        /// 
        /// <returns>
        /// LiandanluExclusiveModelResponse
        /// </returns>
        public async Task<LiandanluExclusiveModelResponse> LiandanluExclusiveModelAsync(LiandanluExclusiveModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LiandanluExclusiveModelHeaders headers = new LiandanluExclusiveModelHeaders();
            return await LiandanluExclusiveModelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉通过提示词生成图片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanluTextToImageModelRequest
        /// </param>
        /// <param name="headers">
        /// LiandanluTextToImageModelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LiandanluTextToImageModelResponse
        /// </returns>
        public LiandanluTextToImageModelResponse LiandanluTextToImageModelWithOptions(LiandanluTextToImageModelRequest request, LiandanluTextToImageModelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
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
                Action = "LiandanluTextToImageModel",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/ai/textToImage/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiandanluTextToImageModelResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉通过提示词生成图片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanluTextToImageModelRequest
        /// </param>
        /// <param name="headers">
        /// LiandanluTextToImageModelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LiandanluTextToImageModelResponse
        /// </returns>
        public async Task<LiandanluTextToImageModelResponse> LiandanluTextToImageModelWithOptionsAsync(LiandanluTextToImageModelRequest request, LiandanluTextToImageModelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                body["module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                body["number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
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
                Action = "LiandanluTextToImageModel",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/ai/textToImage/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LiandanluTextToImageModelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉通过提示词生成图片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanluTextToImageModelRequest
        /// </param>
        /// 
        /// <returns>
        /// LiandanluTextToImageModelResponse
        /// </returns>
        public LiandanluTextToImageModelResponse LiandanluTextToImageModel(LiandanluTextToImageModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LiandanluTextToImageModelHeaders headers = new LiandanluTextToImageModelHeaders();
            return LiandanluTextToImageModelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>炼丹炉通过提示词生成图片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LiandanluTextToImageModelRequest
        /// </param>
        /// 
        /// <returns>
        /// LiandanluTextToImageModelResponse
        /// </returns>
        public async Task<LiandanluTextToImageModelResponse> LiandanluTextToImageModelAsync(LiandanluTextToImageModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LiandanluTextToImageModelHeaders headers = new LiandanluTextToImageModelHeaders();
            return await LiandanluTextToImageModelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过配置的指令，连接用户和系统，训练大模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NLToFrameServiceRequest
        /// </param>
        /// <param name="headers">
        /// NLToFrameServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NLToFrameServiceResponse
        /// </returns>
        public NLToFrameServiceResponse NLToFrameServiceWithOptions(NLToFrameServiceRequest request, NLToFrameServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtensionStr))
            {
                body["extensionStr"] = request.ExtensionStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsNewModel))
            {
                body["isNewModel"] = request.IsNewModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                body["modelName"] = request.ModelName;
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
                Action = "NLToFrameService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/ai/nl2frame",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NLToFrameServiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过配置的指令，连接用户和系统，训练大模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NLToFrameServiceRequest
        /// </param>
        /// <param name="headers">
        /// NLToFrameServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NLToFrameServiceResponse
        /// </returns>
        public async Task<NLToFrameServiceResponse> NLToFrameServiceWithOptionsAsync(NLToFrameServiceRequest request, NLToFrameServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtensionStr))
            {
                body["extensionStr"] = request.ExtensionStr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsNewModel))
            {
                body["isNewModel"] = request.IsNewModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                body["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                body["modelName"] = request.ModelName;
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
                Action = "NLToFrameService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/ai/nl2frame",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NLToFrameServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过配置的指令，连接用户和系统，训练大模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NLToFrameServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// NLToFrameServiceResponse
        /// </returns>
        public NLToFrameServiceResponse NLToFrameService(NLToFrameServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NLToFrameServiceHeaders headers = new NLToFrameServiceHeaders();
            return NLToFrameServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过配置的指令，连接用户和系统，训练大模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NLToFrameServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// NLToFrameServiceResponse
        /// </returns>
        public async Task<NLToFrameServiceResponse> NLToFrameServiceAsync(NLToFrameServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NLToFrameServiceHeaders headers = new NLToFrameServiceHeaders();
            return await NLToFrameServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Baymax技能执行日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBaymaxSkillLogRequest
        /// </param>
        /// <param name="headers">
        /// QueryBaymaxSkillLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBaymaxSkillLogResponse
        /// </returns>
        public QueryBaymaxSkillLogResponse QueryBaymaxSkillLogWithOptions(QueryBaymaxSkillLogRequest request, QueryBaymaxSkillLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLevel))
            {
                query["logLevel"] = request.LogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillExecuteId))
            {
                query["skillExecuteId"] = request.SkillExecuteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryBaymaxSkillLog",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/skills/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBaymaxSkillLogResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Baymax技能执行日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBaymaxSkillLogRequest
        /// </param>
        /// <param name="headers">
        /// QueryBaymaxSkillLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBaymaxSkillLogResponse
        /// </returns>
        public async Task<QueryBaymaxSkillLogResponse> QueryBaymaxSkillLogWithOptionsAsync(QueryBaymaxSkillLogRequest request, QueryBaymaxSkillLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogLevel))
            {
                query["logLevel"] = request.LogLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillExecuteId))
            {
                query["skillExecuteId"] = request.SkillExecuteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryBaymaxSkillLog",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/skills/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBaymaxSkillLogResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Baymax技能执行日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBaymaxSkillLogRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBaymaxSkillLogResponse
        /// </returns>
        public QueryBaymaxSkillLogResponse QueryBaymaxSkillLog(QueryBaymaxSkillLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBaymaxSkillLogHeaders headers = new QueryBaymaxSkillLogHeaders();
            return QueryBaymaxSkillLogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Baymax技能执行日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBaymaxSkillLogRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBaymaxSkillLogResponse
        /// </returns>
        public async Task<QueryBaymaxSkillLogResponse> QueryBaymaxSkillLogAsync(QueryBaymaxSkillLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBaymaxSkillLogHeaders headers = new QueryBaymaxSkillLogHeaders();
            return await QueryBaymaxSkillLogWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话消息并以大模型友好的协议返回</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryConversationMessageForAIRequest
        /// </param>
        /// <param name="headers">
        /// QueryConversationMessageForAIHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConversationMessageForAIResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话消息并以大模型友好的协议返回</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryConversationMessageForAIRequest
        /// </param>
        /// <param name="headers">
        /// QueryConversationMessageForAIHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryConversationMessageForAIResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话消息并以大模型友好的协议返回</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConversationMessageForAIRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConversationMessageForAIResponse
        /// </returns>
        public QueryConversationMessageForAIResponse QueryConversationMessageForAI(string cid, QueryConversationMessageForAIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConversationMessageForAIHeaders headers = new QueryConversationMessageForAIHeaders();
            return QueryConversationMessageForAIWithOptions(cid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询会话消息并以大模型友好的协议返回</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryConversationMessageForAIRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryConversationMessageForAIResponse
        /// </returns>
        public async Task<QueryConversationMessageForAIResponse> QueryConversationMessageForAIAsync(string cid, QueryConversationMessageForAIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryConversationMessageForAIHeaders headers = new QueryConversationMessageForAIHeaders();
            return await QueryConversationMessageForAIWithOptionsAsync(cid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆学习进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMemoryLearningTaskRequest
        /// </param>
        /// <param name="headers">
        /// QueryMemoryLearningTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMemoryLearningTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆学习进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMemoryLearningTaskRequest
        /// </param>
        /// <param name="headers">
        /// QueryMemoryLearningTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMemoryLearningTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆学习进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMemoryLearningTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMemoryLearningTaskResponse
        /// </returns>
        public QueryMemoryLearningTaskResponse QueryMemoryLearningTask(QueryMemoryLearningTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMemoryLearningTaskHeaders headers = new QueryMemoryLearningTaskHeaders();
            return QueryMemoryLearningTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询记忆学习进度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMemoryLearningTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMemoryLearningTaskResponse
        /// </returns>
        public async Task<QueryMemoryLearningTaskResponse> QueryMemoryLearningTaskAsync(QueryMemoryLearningTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMemoryLearningTaskHeaders headers = new QueryMemoryLearningTaskHeaders();
            return await QueryMemoryLearningTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中信金属智能配料任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartFormulaResultServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartFormulaResultServiceResponse
        /// </returns>
        public SmartFormulaResultServiceResponse SmartFormulaResultServiceWithOptions(SmartFormulaResultServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmartFormulaResultService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartFormulas/results/query",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartFormulaResultServiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中信金属智能配料任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartFormulaResultServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartFormulaResultServiceResponse
        /// </returns>
        public async Task<SmartFormulaResultServiceResponse> SmartFormulaResultServiceWithOptionsAsync(SmartFormulaResultServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmartFormulaResultService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartFormulas/results/query",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartFormulaResultServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中信金属智能配料任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartFormulaResultServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartFormulaResultServiceResponse
        /// </returns>
        public SmartFormulaResultServiceResponse SmartFormulaResultService(SmartFormulaResultServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SmartFormulaResultServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中信金属智能配料任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartFormulaResultServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartFormulaResultServiceResponse
        /// </returns>
        public async Task<SmartFormulaResultServiceResponse> SmartFormulaResultServiceAsync(SmartFormulaResultServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SmartFormulaResultServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中信金属智能配料任务触发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartFormulaTriggerServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartFormulaTriggerServiceResponse
        /// </returns>
        public SmartFormulaTriggerServiceResponse SmartFormulaTriggerServiceWithOptions(SmartFormulaTriggerServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmartFormulaTriggerService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartFormulas/trigger",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartFormulaTriggerServiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中信金属智能配料任务触发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartFormulaTriggerServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartFormulaTriggerServiceResponse
        /// </returns>
        public async Task<SmartFormulaTriggerServiceResponse> SmartFormulaTriggerServiceWithOptionsAsync(SmartFormulaTriggerServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmartFormulaTriggerService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartFormulas/trigger",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartFormulaTriggerServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中信金属智能配料任务触发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartFormulaTriggerServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartFormulaTriggerServiceResponse
        /// </returns>
        public SmartFormulaTriggerServiceResponse SmartFormulaTriggerService(SmartFormulaTriggerServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SmartFormulaTriggerServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>中信金属智能配料任务触发</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartFormulaTriggerServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartFormulaTriggerServiceResponse
        /// </returns>
        public async Task<SmartFormulaTriggerServiceResponse> SmartFormulaTriggerServiceAsync(SmartFormulaTriggerServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SmartFormulaTriggerServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能报价结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteBatchQueryResultServiceRequest
        /// </param>
        /// <param name="headers">
        /// SmartQuoteBatchQueryResultServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteBatchQueryResultServiceResponse
        /// </returns>
        public SmartQuoteBatchQueryResultServiceResponse SmartQuoteBatchQueryResultServiceWithOptions(SmartQuoteBatchQueryResultServiceRequest request, SmartQuoteBatchQueryResultServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "SmartQuoteBatchQueryResultService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartQuotations/results/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartQuoteBatchQueryResultServiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能报价结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteBatchQueryResultServiceRequest
        /// </param>
        /// <param name="headers">
        /// SmartQuoteBatchQueryResultServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteBatchQueryResultServiceResponse
        /// </returns>
        public async Task<SmartQuoteBatchQueryResultServiceResponse> SmartQuoteBatchQueryResultServiceWithOptionsAsync(SmartQuoteBatchQueryResultServiceRequest request, SmartQuoteBatchQueryResultServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "SmartQuoteBatchQueryResultService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartQuotations/results/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartQuoteBatchQueryResultServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能报价结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteBatchQueryResultServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteBatchQueryResultServiceResponse
        /// </returns>
        public SmartQuoteBatchQueryResultServiceResponse SmartQuoteBatchQueryResultService(SmartQuoteBatchQueryResultServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SmartQuoteBatchQueryResultServiceHeaders headers = new SmartQuoteBatchQueryResultServiceHeaders();
            return SmartQuoteBatchQueryResultServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能报价结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteBatchQueryResultServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteBatchQueryResultServiceResponse
        /// </returns>
        public async Task<SmartQuoteBatchQueryResultServiceResponse> SmartQuoteBatchQueryResultServiceAsync(SmartQuoteBatchQueryResultServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SmartQuoteBatchQueryResultServiceHeaders headers = new SmartQuoteBatchQueryResultServiceHeaders();
            return await SmartQuoteBatchQueryResultServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteBatchQueryServiceRequest
        /// </param>
        /// <param name="headers">
        /// SmartQuoteBatchQueryServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteBatchQueryServiceResponse
        /// </returns>
        public SmartQuoteBatchQueryServiceResponse SmartQuoteBatchQueryServiceWithOptions(SmartQuoteBatchQueryServiceRequest request, SmartQuoteBatchQueryServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SmartQuoteBatchQueryService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartQuotations/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartQuoteBatchQueryServiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteBatchQueryServiceRequest
        /// </param>
        /// <param name="headers">
        /// SmartQuoteBatchQueryServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteBatchQueryServiceResponse
        /// </returns>
        public async Task<SmartQuoteBatchQueryServiceResponse> SmartQuoteBatchQueryServiceWithOptionsAsync(SmartQuoteBatchQueryServiceRequest request, SmartQuoteBatchQueryServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SmartQuoteBatchQueryService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartQuotations/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartQuoteBatchQueryServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteBatchQueryServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteBatchQueryServiceResponse
        /// </returns>
        public SmartQuoteBatchQueryServiceResponse SmartQuoteBatchQueryService(SmartQuoteBatchQueryServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SmartQuoteBatchQueryServiceHeaders headers = new SmartQuoteBatchQueryServiceHeaders();
            return SmartQuoteBatchQueryServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteBatchQueryServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteBatchQueryServiceResponse
        /// </returns>
        public async Task<SmartQuoteBatchQueryServiceResponse> SmartQuoteBatchQueryServiceAsync(SmartQuoteBatchQueryServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SmartQuoteBatchQueryServiceHeaders headers = new SmartQuoteBatchQueryServiceHeaders();
            return await SmartQuoteBatchQueryServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加智能报价数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteDataServiceRequest
        /// </param>
        /// <param name="headers">
        /// SmartQuoteDataServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteDataServiceResponse
        /// </returns>
        public SmartQuoteDataServiceResponse SmartQuoteDataServiceWithOptions(SmartQuoteDataServiceRequest request, SmartQuoteDataServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SmartQuoteDataService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartQuotations/datas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartQuoteDataServiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加智能报价数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteDataServiceRequest
        /// </param>
        /// <param name="headers">
        /// SmartQuoteDataServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteDataServiceResponse
        /// </returns>
        public async Task<SmartQuoteDataServiceResponse> SmartQuoteDataServiceWithOptionsAsync(SmartQuoteDataServiceRequest request, SmartQuoteDataServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SmartQuoteDataService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartQuotations/datas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartQuoteDataServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加智能报价数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteDataServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteDataServiceResponse
        /// </returns>
        public SmartQuoteDataServiceResponse SmartQuoteDataService(SmartQuoteDataServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SmartQuoteDataServiceHeaders headers = new SmartQuoteDataServiceHeaders();
            return SmartQuoteDataServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加智能报价数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteDataServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteDataServiceResponse
        /// </returns>
        public async Task<SmartQuoteDataServiceResponse> SmartQuoteDataServiceAsync(SmartQuoteDataServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SmartQuoteDataServiceHeaders headers = new SmartQuoteDataServiceHeaders();
            return await SmartQuoteDataServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能报价结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteQueryResultServiceRequest
        /// </param>
        /// <param name="headers">
        /// SmartQuoteQueryResultServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteQueryResultServiceResponse
        /// </returns>
        public SmartQuoteQueryResultServiceResponse SmartQuoteQueryResultServiceWithOptions(SmartQuoteQueryResultServiceRequest request, SmartQuoteQueryResultServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "SmartQuoteQueryResultService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartQuotations/results/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartQuoteQueryResultServiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能报价结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteQueryResultServiceRequest
        /// </param>
        /// <param name="headers">
        /// SmartQuoteQueryResultServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteQueryResultServiceResponse
        /// </returns>
        public async Task<SmartQuoteQueryResultServiceResponse> SmartQuoteQueryResultServiceWithOptionsAsync(SmartQuoteQueryResultServiceRequest request, SmartQuoteQueryResultServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "SmartQuoteQueryResultService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartQuotations/results/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartQuoteQueryResultServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能报价结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteQueryResultServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteQueryResultServiceResponse
        /// </returns>
        public SmartQuoteQueryResultServiceResponse SmartQuoteQueryResultService(SmartQuoteQueryResultServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SmartQuoteQueryResultServiceHeaders headers = new SmartQuoteQueryResultServiceHeaders();
            return SmartQuoteQueryResultServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能报价结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteQueryResultServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteQueryResultServiceResponse
        /// </returns>
        public async Task<SmartQuoteQueryResultServiceResponse> SmartQuoteQueryResultServiceAsync(SmartQuoteQueryResultServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SmartQuoteQueryResultServiceHeaders headers = new SmartQuoteQueryResultServiceHeaders();
            return await SmartQuoteQueryResultServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteQueryServiceRequest
        /// </param>
        /// <param name="headers">
        /// SmartQuoteQueryServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteQueryServiceResponse
        /// </returns>
        public SmartQuoteQueryServiceResponse SmartQuoteQueryServiceWithOptions(SmartQuoteQueryServiceRequest request, SmartQuoteQueryServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SmartQuoteQueryService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartQuotations/triggerQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartQuoteQueryServiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteQueryServiceRequest
        /// </param>
        /// <param name="headers">
        /// SmartQuoteQueryServiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteQueryServiceResponse
        /// </returns>
        public async Task<SmartQuoteQueryServiceResponse> SmartQuoteQueryServiceWithOptionsAsync(SmartQuoteQueryServiceRequest request, SmartQuoteQueryServiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                body["request"] = request.Request;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SmartQuoteQueryService",
                Version = "aiPaaS_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiPaaS/nl2x/smartQuotations/triggerQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartQuoteQueryServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteQueryServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteQueryServiceResponse
        /// </returns>
        public SmartQuoteQueryServiceResponse SmartQuoteQueryService(SmartQuoteQueryServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SmartQuoteQueryServiceHeaders headers = new SmartQuoteQueryServiceHeaders();
            return SmartQuoteQueryServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SmartQuoteQueryServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartQuoteQueryServiceResponse
        /// </returns>
        public async Task<SmartQuoteQueryServiceResponse> SmartQuoteQueryServiceAsync(SmartQuoteQueryServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SmartQuoteQueryServiceHeaders headers = new SmartQuoteQueryServiceHeaders();
            return await SmartQuoteQueryServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交记忆学习任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitMemoryLearningTaskRequest
        /// </param>
        /// <param name="headers">
        /// SubmitMemoryLearningTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitMemoryLearningTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交记忆学习任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitMemoryLearningTaskRequest
        /// </param>
        /// <param name="headers">
        /// SubmitMemoryLearningTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitMemoryLearningTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交记忆学习任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitMemoryLearningTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitMemoryLearningTaskResponse
        /// </returns>
        public SubmitMemoryLearningTaskResponse SubmitMemoryLearningTask(SubmitMemoryLearningTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitMemoryLearningTaskHeaders headers = new SubmitMemoryLearningTaskHeaders();
            return SubmitMemoryLearningTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交记忆学习任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitMemoryLearningTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitMemoryLearningTaskResponse
        /// </returns>
        public async Task<SubmitMemoryLearningTaskResponse> SubmitMemoryLearningTaskAsync(SubmitMemoryLearningTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitMemoryLearningTaskHeaders headers = new SubmitMemoryLearningTaskHeaders();
            return await SubmitMemoryLearningTaskWithOptionsAsync(request, headers, runtime);
        }

    }
}
