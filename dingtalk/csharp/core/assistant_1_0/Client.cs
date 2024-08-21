// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkassistant_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0
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
         * @summary 助理添加专业词汇
         *
         * @param request AddDomainWordsRequest
         * @param headers AddDomainWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDomainWordsResponse
         */
        public AddDomainWordsResponse AddDomainWordsWithOptions(AddDomainWordsRequest request, AddDomainWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainWords))
            {
                body["domainWords"] = request.DomainWords;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddDomainWords",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/domainWords",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDomainWordsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 助理添加专业词汇
         *
         * @param request AddDomainWordsRequest
         * @param headers AddDomainWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDomainWordsResponse
         */
        public async Task<AddDomainWordsResponse> AddDomainWordsWithOptionsAsync(AddDomainWordsRequest request, AddDomainWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainWords))
            {
                body["domainWords"] = request.DomainWords;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddDomainWords",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/domainWords",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDomainWordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 助理添加专业词汇
         *
         * @param request AddDomainWordsRequest
         * @return AddDomainWordsResponse
         */
        public AddDomainWordsResponse AddDomainWords(AddDomainWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddDomainWordsHeaders headers = new AddDomainWordsHeaders();
            return AddDomainWordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 助理添加专业词汇
         *
         * @param request AddDomainWordsRequest
         * @return AddDomainWordsResponse
         */
        public async Task<AddDomainWordsResponse> AddDomainWordsAsync(AddDomainWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddDomainWordsHeaders headers = new AddDomainWordsHeaders();
            return await AddDomainWordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建AI助理
         *
         * @param request CreateAssistantRequest
         * @param headers CreateAssistantHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAssistantResponse
         */
        public CreateAssistantResponse CreateAssistantWithOptions(CreateAssistantRequest request, CreateAssistantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendPrompts))
            {
                body["recommendPrompts"] = request.RecommendPrompts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WelcomeContent))
            {
                body["welcomeContent"] = request.WelcomeContent;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateAssistant",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/basicInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建AI助理
         *
         * @param request CreateAssistantRequest
         * @param headers CreateAssistantHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAssistantResponse
         */
        public async Task<CreateAssistantResponse> CreateAssistantWithOptionsAsync(CreateAssistantRequest request, CreateAssistantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendPrompts))
            {
                body["recommendPrompts"] = request.RecommendPrompts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WelcomeContent))
            {
                body["welcomeContent"] = request.WelcomeContent;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateAssistant",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/basicInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建AI助理
         *
         * @param request CreateAssistantRequest
         * @return CreateAssistantResponse
         */
        public CreateAssistantResponse CreateAssistant(CreateAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantHeaders headers = new CreateAssistantHeaders();
            return CreateAssistantWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建AI助理
         *
         * @param request CreateAssistantRequest
         * @return CreateAssistantResponse
         */
        public async Task<CreateAssistantResponse> CreateAssistantAsync(CreateAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantHeaders headers = new CreateAssistantHeaders();
            return await CreateAssistantWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建AI助理的消息体
         *
         * @param request CreateAssistantMessageRequest
         * @param headers CreateAssistantMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAssistantMessageResponse
         */
        public CreateAssistantMessageResponse CreateAssistantMessageWithOptions(string threadId, CreateAssistantMessageRequest request, CreateAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateAssistantMessage",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建AI助理的消息体
         *
         * @param request CreateAssistantMessageRequest
         * @param headers CreateAssistantMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAssistantMessageResponse
         */
        public async Task<CreateAssistantMessageResponse> CreateAssistantMessageWithOptionsAsync(string threadId, CreateAssistantMessageRequest request, CreateAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateAssistantMessage",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建AI助理的消息体
         *
         * @param request CreateAssistantMessageRequest
         * @return CreateAssistantMessageResponse
         */
        public CreateAssistantMessageResponse CreateAssistantMessage(string threadId, CreateAssistantMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantMessageHeaders headers = new CreateAssistantMessageHeaders();
            return CreateAssistantMessageWithOptions(threadId, request, headers, runtime);
        }

        /**
         * @summary 创建AI助理的消息体
         *
         * @param request CreateAssistantMessageRequest
         * @return CreateAssistantMessageResponse
         */
        public async Task<CreateAssistantMessageResponse> CreateAssistantMessageAsync(string threadId, CreateAssistantMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantMessageHeaders headers = new CreateAssistantMessageHeaders();
            return await CreateAssistantMessageWithOptionsAsync(threadId, request, headers, runtime);
        }

        /**
         * @summary 创建AI助理的运行任务
         *
         * @param request CreateAssistantRunRequest
         * @param headers CreateAssistantRunHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAssistantRunResponse
         */
        public CreateAssistantRunResponse CreateAssistantRunWithOptions(string threadId, CreateAssistantRunRequest request, CreateAssistantRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateAssistantRun",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/runs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantRunResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建AI助理的运行任务
         *
         * @param request CreateAssistantRunRequest
         * @param headers CreateAssistantRunHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAssistantRunResponse
         */
        public async Task<CreateAssistantRunResponse> CreateAssistantRunWithOptionsAsync(string threadId, CreateAssistantRunRequest request, CreateAssistantRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateAssistantRun",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/runs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantRunResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建AI助理的运行任务
         *
         * @param request CreateAssistantRunRequest
         * @return CreateAssistantRunResponse
         */
        public CreateAssistantRunResponse CreateAssistantRun(string threadId, CreateAssistantRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantRunHeaders headers = new CreateAssistantRunHeaders();
            return CreateAssistantRunWithOptions(threadId, request, headers, runtime);
        }

        /**
         * @summary 创建AI助理的运行任务
         *
         * @param request CreateAssistantRunRequest
         * @return CreateAssistantRunResponse
         */
        public async Task<CreateAssistantRunResponse> CreateAssistantRunAsync(string threadId, CreateAssistantRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantRunHeaders headers = new CreateAssistantRunHeaders();
            return await CreateAssistantRunWithOptionsAsync(threadId, request, headers, runtime);
        }

        /**
         * @summary 创建AI助理线程实例
         *
         * @param request CreateAssistantThreadRequest
         * @param headers CreateAssistantThreadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAssistantThreadResponse
         */
        public CreateAssistantThreadResponse CreateAssistantThreadWithOptions(CreateAssistantThreadRequest request, CreateAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateAssistantThread",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantThreadResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建AI助理线程实例
         *
         * @param request CreateAssistantThreadRequest
         * @param headers CreateAssistantThreadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAssistantThreadResponse
         */
        public async Task<CreateAssistantThreadResponse> CreateAssistantThreadWithOptionsAsync(CreateAssistantThreadRequest request, CreateAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metadata))
            {
                body["metadata"] = request.Metadata;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateAssistantThread",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAssistantThreadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建AI助理线程实例
         *
         * @param request CreateAssistantThreadRequest
         * @return CreateAssistantThreadResponse
         */
        public CreateAssistantThreadResponse CreateAssistantThread(CreateAssistantThreadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantThreadHeaders headers = new CreateAssistantThreadHeaders();
            return CreateAssistantThreadWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建AI助理线程实例
         *
         * @param request CreateAssistantThreadRequest
         * @return CreateAssistantThreadResponse
         */
        public async Task<CreateAssistantThreadResponse> CreateAssistantThreadAsync(CreateAssistantThreadRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAssistantThreadHeaders headers = new CreateAssistantThreadHeaders();
            return await CreateAssistantThreadWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除AI助理
         *
         * @param request DeleteAssistantRequest
         * @param headers DeleteAssistantHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAssistantResponse
         */
        public DeleteAssistantResponse DeleteAssistantWithOptions(DeleteAssistantRequest request, DeleteAssistantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                query["operatorUnionId"] = request.OperatorUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DeleteAssistant",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/basicInfo",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssistantResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除AI助理
         *
         * @param request DeleteAssistantRequest
         * @param headers DeleteAssistantHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAssistantResponse
         */
        public async Task<DeleteAssistantResponse> DeleteAssistantWithOptionsAsync(DeleteAssistantRequest request, DeleteAssistantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                query["operatorUnionId"] = request.OperatorUnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DeleteAssistant",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/basicInfo",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssistantResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除AI助理
         *
         * @param request DeleteAssistantRequest
         * @return DeleteAssistantResponse
         */
        public DeleteAssistantResponse DeleteAssistant(DeleteAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAssistantHeaders headers = new DeleteAssistantHeaders();
            return DeleteAssistantWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除AI助理
         *
         * @param request DeleteAssistantRequest
         * @return DeleteAssistantResponse
         */
        public async Task<DeleteAssistantResponse> DeleteAssistantAsync(DeleteAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAssistantHeaders headers = new DeleteAssistantHeaders();
            return await DeleteAssistantWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除AI助理的消息体
         *
         * @param headers DeleteAssistantMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAssistantMessageResponse
         */
        public DeleteAssistantMessageResponse DeleteAssistantMessageWithOptions(string threadId, string messageId, DeleteAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAssistantMessage",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/messages/" + messageId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssistantMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除AI助理的消息体
         *
         * @param headers DeleteAssistantMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAssistantMessageResponse
         */
        public async Task<DeleteAssistantMessageResponse> DeleteAssistantMessageWithOptionsAsync(string threadId, string messageId, DeleteAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAssistantMessage",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/messages/" + messageId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssistantMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除AI助理的消息体
         *
         * @return DeleteAssistantMessageResponse
         */
        public DeleteAssistantMessageResponse DeleteAssistantMessage(string threadId, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAssistantMessageHeaders headers = new DeleteAssistantMessageHeaders();
            return DeleteAssistantMessageWithOptions(threadId, messageId, headers, runtime);
        }

        /**
         * @summary 删除AI助理的消息体
         *
         * @return DeleteAssistantMessageResponse
         */
        public async Task<DeleteAssistantMessageResponse> DeleteAssistantMessageAsync(string threadId, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAssistantMessageHeaders headers = new DeleteAssistantMessageHeaders();
            return await DeleteAssistantMessageWithOptionsAsync(threadId, messageId, headers, runtime);
        }

        /**
         * @summary 删除AI助理线程实例
         *
         * @param headers DeleteAssistantThreadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAssistantThreadResponse
         */
        public DeleteAssistantThreadResponse DeleteAssistantThreadWithOptions(string threadId, DeleteAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAssistantThread",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssistantThreadResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除AI助理线程实例
         *
         * @param headers DeleteAssistantThreadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAssistantThreadResponse
         */
        public async Task<DeleteAssistantThreadResponse> DeleteAssistantThreadWithOptionsAsync(string threadId, DeleteAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAssistantThread",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAssistantThreadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除AI助理线程实例
         *
         * @return DeleteAssistantThreadResponse
         */
        public DeleteAssistantThreadResponse DeleteAssistantThread(string threadId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAssistantThreadHeaders headers = new DeleteAssistantThreadHeaders();
            return DeleteAssistantThreadWithOptions(threadId, headers, runtime);
        }

        /**
         * @summary 删除AI助理线程实例
         *
         * @return DeleteAssistantThreadResponse
         */
        public async Task<DeleteAssistantThreadResponse> DeleteAssistantThreadAsync(string threadId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteAssistantThreadHeaders headers = new DeleteAssistantThreadHeaders();
            return await DeleteAssistantThreadWithOptionsAsync(threadId, headers, runtime);
        }

        /**
         * @summary 助理删除专业词汇
         *
         * @param request DeleteDomainWordsRequest
         * @param headers DeleteDomainWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainWordsResponse
         */
        public DeleteDomainWordsResponse DeleteDomainWordsWithOptions(DeleteDomainWordsRequest request, DeleteDomainWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainWords))
            {
                body["domainWords"] = request.DomainWords;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DeleteDomainWords",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/domainWords/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainWordsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 助理删除专业词汇
         *
         * @param request DeleteDomainWordsRequest
         * @param headers DeleteDomainWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainWordsResponse
         */
        public async Task<DeleteDomainWordsResponse> DeleteDomainWordsWithOptionsAsync(DeleteDomainWordsRequest request, DeleteDomainWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainWords))
            {
                body["domainWords"] = request.DomainWords;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DeleteDomainWords",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/domainWords/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainWordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 助理删除专业词汇
         *
         * @param request DeleteDomainWordsRequest
         * @return DeleteDomainWordsResponse
         */
        public DeleteDomainWordsResponse DeleteDomainWords(DeleteDomainWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDomainWordsHeaders headers = new DeleteDomainWordsHeaders();
            return DeleteDomainWordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 助理删除专业词汇
         *
         * @param request DeleteDomainWordsRequest
         * @return DeleteDomainWordsResponse
         */
        public async Task<DeleteDomainWordsResponse> DeleteDomainWordsAsync(DeleteDomainWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteDomainWordsHeaders headers = new DeleteDomainWordsHeaders();
            return await DeleteDomainWordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除助理知识
         *
         * @param request DeleteKnowledgeRequest
         * @param headers DeleteKnowledgeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKnowledgeResponse
         */
        public DeleteKnowledgeResponse DeleteKnowledgeWithOptions(DeleteKnowledgeRequest request, DeleteKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudyId))
            {
                query["studyId"] = request.StudyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DeleteKnowledge",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/knowledges/items",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除助理知识
         *
         * @param request DeleteKnowledgeRequest
         * @param headers DeleteKnowledgeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKnowledgeResponse
         */
        public async Task<DeleteKnowledgeResponse> DeleteKnowledgeWithOptionsAsync(DeleteKnowledgeRequest request, DeleteKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudyId))
            {
                query["studyId"] = request.StudyId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DeleteKnowledge",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/knowledges/items",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKnowledgeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除助理知识
         *
         * @param request DeleteKnowledgeRequest
         * @return DeleteKnowledgeResponse
         */
        public DeleteKnowledgeResponse DeleteKnowledge(DeleteKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteKnowledgeHeaders headers = new DeleteKnowledgeHeaders();
            return DeleteKnowledgeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除助理知识
         *
         * @param request DeleteKnowledgeRequest
         * @return DeleteKnowledgeResponse
         */
        public async Task<DeleteKnowledgeResponse> DeleteKnowledgeAsync(DeleteKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteKnowledgeHeaders headers = new DeleteKnowledgeHeaders();
            return await DeleteKnowledgeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取助理问答明细
         *
         * @param request GetAskDetailRequest
         * @param headers GetAskDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAskDetailResponse
         */
        public GetAskDetailResponse GetAskDetailWithOptions(GetAskDetailRequest request, GetAskDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetAskDetail",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/askDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAskDetailResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取助理问答明细
         *
         * @param request GetAskDetailRequest
         * @param headers GetAskDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAskDetailResponse
         */
        public async Task<GetAskDetailResponse> GetAskDetailWithOptionsAsync(GetAskDetailRequest request, GetAskDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetAskDetail",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/askDetails",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAskDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取助理问答明细
         *
         * @param request GetAskDetailRequest
         * @return GetAskDetailResponse
         */
        public GetAskDetailResponse GetAskDetail(GetAskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAskDetailHeaders headers = new GetAskDetailHeaders();
            return GetAskDetailWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取助理问答明细
         *
         * @param request GetAskDetailRequest
         * @return GetAskDetailResponse
         */
        public async Task<GetAskDetailResponse> GetAskDetailAsync(GetAskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAskDetailHeaders headers = new GetAskDetailHeaders();
            return await GetAskDetailWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取助理专业词汇
         *
         * @param request GetDomainWordsRequest
         * @param headers GetDomainWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainWordsResponse
         */
        public GetDomainWordsResponse GetDomainWordsWithOptions(GetDomainWordsRequest request, GetDomainWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetDomainWords",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/domainWords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainWordsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取助理专业词汇
         *
         * @param request GetDomainWordsRequest
         * @param headers GetDomainWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDomainWordsResponse
         */
        public async Task<GetDomainWordsResponse> GetDomainWordsWithOptionsAsync(GetDomainWordsRequest request, GetDomainWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetDomainWords",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/domainWords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainWordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取助理专业词汇
         *
         * @param request GetDomainWordsRequest
         * @return GetDomainWordsResponse
         */
        public GetDomainWordsResponse GetDomainWords(GetDomainWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDomainWordsHeaders headers = new GetDomainWordsHeaders();
            return GetDomainWordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取助理专业词汇
         *
         * @param request GetDomainWordsRequest
         * @return GetDomainWordsResponse
         */
        public async Task<GetDomainWordsResponse> GetDomainWordsAsync(GetDomainWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDomainWordsHeaders headers = new GetDomainWordsHeaders();
            return await GetDomainWordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取助理知识列表
         *
         * @param request GetKnowledgeListRequest
         * @param headers GetKnowledgeListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKnowledgeListResponse
         */
        public GetKnowledgeListResponse GetKnowledgeListWithOptions(GetKnowledgeListRequest request, GetKnowledgeListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetKnowledgeList",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/knowledges/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取助理知识列表
         *
         * @param request GetKnowledgeListRequest
         * @param headers GetKnowledgeListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKnowledgeListResponse
         */
        public async Task<GetKnowledgeListResponse> GetKnowledgeListWithOptionsAsync(GetKnowledgeListRequest request, GetKnowledgeListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetKnowledgeList",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/knowledges/items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKnowledgeListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取助理知识列表
         *
         * @param request GetKnowledgeListRequest
         * @return GetKnowledgeListResponse
         */
        public GetKnowledgeListResponse GetKnowledgeList(GetKnowledgeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetKnowledgeListHeaders headers = new GetKnowledgeListHeaders();
            return GetKnowledgeListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取助理知识列表
         *
         * @param request GetKnowledgeListRequest
         * @return GetKnowledgeListResponse
         */
        public async Task<GetKnowledgeListResponse> GetKnowledgeListAsync(GetKnowledgeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetKnowledgeListHeaders headers = new GetKnowledgeListHeaders();
            return await GetKnowledgeListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 安装助理
         *
         * @param request InstallAssistantRequest
         * @param headers InstallAssistantHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallAssistantResponse
         */
        public InstallAssistantResponse InstallAssistantWithOptions(InstallAssistantRequest request, InstallAssistantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InstallAssistant",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAssistantResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 安装助理
         *
         * @param request InstallAssistantRequest
         * @param headers InstallAssistantHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallAssistantResponse
         */
        public async Task<InstallAssistantResponse> InstallAssistantWithOptionsAsync(InstallAssistantRequest request, InstallAssistantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InstallAssistant",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAssistantResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 安装助理
         *
         * @param request InstallAssistantRequest
         * @return InstallAssistantResponse
         */
        public InstallAssistantResponse InstallAssistant(InstallAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallAssistantHeaders headers = new InstallAssistantHeaders();
            return InstallAssistantWithOptions(request, headers, runtime);
        }

        /**
         * @summary 安装助理
         *
         * @param request InstallAssistantRequest
         * @return InstallAssistantResponse
         */
        public async Task<InstallAssistantResponse> InstallAssistantAsync(InstallAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallAssistantHeaders headers = new InstallAssistantHeaders();
            return await InstallAssistantWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 助理学习知识
         *
         * @param request LearnKnowledgeRequest
         * @param headers LearnKnowledgeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return LearnKnowledgeResponse
         */
        public LearnKnowledgeResponse LearnKnowledgeWithOptions(LearnKnowledgeRequest request, LearnKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocUrl))
            {
                body["docUrl"] = request.DocUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "LearnKnowledge",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/knowledges/items",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LearnKnowledgeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 助理学习知识
         *
         * @param request LearnKnowledgeRequest
         * @param headers LearnKnowledgeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return LearnKnowledgeResponse
         */
        public async Task<LearnKnowledgeResponse> LearnKnowledgeWithOptionsAsync(LearnKnowledgeRequest request, LearnKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocUrl))
            {
                body["docUrl"] = request.DocUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "LearnKnowledge",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/knowledges/items",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LearnKnowledgeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 助理学习知识
         *
         * @param request LearnKnowledgeRequest
         * @return LearnKnowledgeResponse
         */
        public LearnKnowledgeResponse LearnKnowledge(LearnKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LearnKnowledgeHeaders headers = new LearnKnowledgeHeaders();
            return LearnKnowledgeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 助理学习知识
         *
         * @param request LearnKnowledgeRequest
         * @return LearnKnowledgeResponse
         */
        public async Task<LearnKnowledgeResponse> LearnKnowledgeAsync(LearnKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LearnKnowledgeHeaders headers = new LearnKnowledgeHeaders();
            return await LearnKnowledgeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取AI助理列表
         *
         * @param request ListAssistantRequest
         * @param headers ListAssistantHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAssistantResponse
         */
        public ListAssistantResponse ListAssistantWithOptions(ListAssistantRequest request, ListAssistantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ListAssistant",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssistantResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取AI助理列表
         *
         * @param request ListAssistantRequest
         * @param headers ListAssistantHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAssistantResponse
         */
        public async Task<ListAssistantResponse> ListAssistantWithOptionsAsync(ListAssistantRequest request, ListAssistantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ListAssistant",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssistantResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取AI助理列表
         *
         * @param request ListAssistantRequest
         * @return ListAssistantResponse
         */
        public ListAssistantResponse ListAssistant(ListAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAssistantHeaders headers = new ListAssistantHeaders();
            return ListAssistantWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取AI助理列表
         *
         * @param request ListAssistantRequest
         * @return ListAssistantResponse
         */
        public async Task<ListAssistantResponse> ListAssistantAsync(ListAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAssistantHeaders headers = new ListAssistantHeaders();
            return await ListAssistantWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取AI助理消息列表
         *
         * @param request ListAssistantMessageRequest
         * @param headers ListAssistantMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAssistantMessageResponse
         */
        public ListAssistantMessageResponse ListAssistantMessageWithOptions(string threadId, ListAssistantMessageRequest request, ListAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["runId"] = request.RunId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ListAssistantMessage",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssistantMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取AI助理消息列表
         *
         * @param request ListAssistantMessageRequest
         * @param headers ListAssistantMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAssistantMessageResponse
         */
        public async Task<ListAssistantMessageResponse> ListAssistantMessageWithOptionsAsync(string threadId, ListAssistantMessageRequest request, ListAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["runId"] = request.RunId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ListAssistantMessage",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssistantMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取AI助理消息列表
         *
         * @param request ListAssistantMessageRequest
         * @return ListAssistantMessageResponse
         */
        public ListAssistantMessageResponse ListAssistantMessage(string threadId, ListAssistantMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAssistantMessageHeaders headers = new ListAssistantMessageHeaders();
            return ListAssistantMessageWithOptions(threadId, request, headers, runtime);
        }

        /**
         * @summary 获取AI助理消息列表
         *
         * @param request ListAssistantMessageRequest
         * @return ListAssistantMessageResponse
         */
        public async Task<ListAssistantMessageResponse> ListAssistantMessageAsync(string threadId, ListAssistantMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAssistantMessageHeaders headers = new ListAssistantMessageHeaders();
            return await ListAssistantMessageWithOptionsAsync(threadId, request, headers, runtime);
        }

        /**
         * @summary 获取AI助理的运行任务的列表
         *
         * @param request ListAssistantRunRequest
         * @param headers ListAssistantRunHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAssistantRunResponse
         */
        public ListAssistantRunResponse ListAssistantRunWithOptions(string threadId, ListAssistantRunRequest request, ListAssistantRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ListAssistantRun",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/runs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssistantRunResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取AI助理的运行任务的列表
         *
         * @param request ListAssistantRunRequest
         * @param headers ListAssistantRunHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAssistantRunResponse
         */
        public async Task<ListAssistantRunResponse> ListAssistantRunWithOptionsAsync(string threadId, ListAssistantRunRequest request, ListAssistantRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["order"] = request.Order;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ListAssistantRun",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/runs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAssistantRunResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取AI助理的运行任务的列表
         *
         * @param request ListAssistantRunRequest
         * @return ListAssistantRunResponse
         */
        public ListAssistantRunResponse ListAssistantRun(string threadId, ListAssistantRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAssistantRunHeaders headers = new ListAssistantRunHeaders();
            return ListAssistantRunWithOptions(threadId, request, headers, runtime);
        }

        /**
         * @summary 获取AI助理的运行任务的列表
         *
         * @param request ListAssistantRunRequest
         * @return ListAssistantRunResponse
         */
        public async Task<ListAssistantRunResponse> ListAssistantRunAsync(string threadId, ListAssistantRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAssistantRunHeaders headers = new ListAssistantRunHeaders();
            return await ListAssistantRunWithOptionsAsync(threadId, request, headers, runtime);
        }

        /**
         * @summary 获取用户可见范围的AI助理列表
         *
         * @param request ListVisibleAssistantRequest
         * @param headers ListVisibleAssistantHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVisibleAssistantResponse
         */
        public ListVisibleAssistantResponse ListVisibleAssistantWithOptions(ListVisibleAssistantRequest request, ListVisibleAssistantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ListVisibleAssistant",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/visibleList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVisibleAssistantResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户可见范围的AI助理列表
         *
         * @param request ListVisibleAssistantRequest
         * @param headers ListVisibleAssistantHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVisibleAssistantResponse
         */
        public async Task<ListVisibleAssistantResponse> ListVisibleAssistantWithOptionsAsync(ListVisibleAssistantRequest request, ListVisibleAssistantHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ListVisibleAssistant",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/visibleList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVisibleAssistantResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户可见范围的AI助理列表
         *
         * @param request ListVisibleAssistantRequest
         * @return ListVisibleAssistantResponse
         */
        public ListVisibleAssistantResponse ListVisibleAssistant(ListVisibleAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVisibleAssistantHeaders headers = new ListVisibleAssistantHeaders();
            return ListVisibleAssistantWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用户可见范围的AI助理列表
         *
         * @param request ListVisibleAssistantRequest
         * @return ListVisibleAssistantResponse
         */
        public async Task<ListVisibleAssistantResponse> ListVisibleAssistantAsync(ListVisibleAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListVisibleAssistantHeaders headers = new ListVisibleAssistantHeaders();
            return await ListVisibleAssistantWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 助理学习增量知识
         *
         * @param request RelearnKnowledgeRequest
         * @param headers RelearnKnowledgeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RelearnKnowledgeResponse
         */
        public RelearnKnowledgeResponse RelearnKnowledgeWithOptions(RelearnKnowledgeRequest request, RelearnKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RelearnKnowledge",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/knowledges/incrLearning",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RelearnKnowledgeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 助理学习增量知识
         *
         * @param request RelearnKnowledgeRequest
         * @param headers RelearnKnowledgeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RelearnKnowledgeResponse
         */
        public async Task<RelearnKnowledgeResponse> RelearnKnowledgeWithOptionsAsync(RelearnKnowledgeRequest request, RelearnKnowledgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RelearnKnowledge",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/knowledges/incrLearning",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RelearnKnowledgeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 助理学习增量知识
         *
         * @param request RelearnKnowledgeRequest
         * @return RelearnKnowledgeResponse
         */
        public RelearnKnowledgeResponse RelearnKnowledge(RelearnKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RelearnKnowledgeHeaders headers = new RelearnKnowledgeHeaders();
            return RelearnKnowledgeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 助理学习增量知识
         *
         * @param request RelearnKnowledgeRequest
         * @return RelearnKnowledgeResponse
         */
        public async Task<RelearnKnowledgeResponse> RelearnKnowledgeAsync(RelearnKnowledgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RelearnKnowledgeHeaders headers = new RelearnKnowledgeHeaders();
            return await RelearnKnowledgeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询 AI 助理的基本信息
         *
         * @param request RetrieveAssistantBasicInfoRequest
         * @param headers RetrieveAssistantBasicInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveAssistantBasicInfoResponse
         */
        public RetrieveAssistantBasicInfoResponse RetrieveAssistantBasicInfoWithOptions(RetrieveAssistantBasicInfoRequest request, RetrieveAssistantBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RetrieveAssistantBasicInfo",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/basicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantBasicInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询 AI 助理的基本信息
         *
         * @param request RetrieveAssistantBasicInfoRequest
         * @param headers RetrieveAssistantBasicInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveAssistantBasicInfoResponse
         */
        public async Task<RetrieveAssistantBasicInfoResponse> RetrieveAssistantBasicInfoWithOptionsAsync(RetrieveAssistantBasicInfoRequest request, RetrieveAssistantBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RetrieveAssistantBasicInfo",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/basicInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantBasicInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询 AI 助理的基本信息
         *
         * @param request RetrieveAssistantBasicInfoRequest
         * @return RetrieveAssistantBasicInfoResponse
         */
        public RetrieveAssistantBasicInfoResponse RetrieveAssistantBasicInfo(RetrieveAssistantBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantBasicInfoHeaders headers = new RetrieveAssistantBasicInfoHeaders();
            return RetrieveAssistantBasicInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询 AI 助理的基本信息
         *
         * @param request RetrieveAssistantBasicInfoRequest
         * @return RetrieveAssistantBasicInfoResponse
         */
        public async Task<RetrieveAssistantBasicInfoResponse> RetrieveAssistantBasicInfoAsync(RetrieveAssistantBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantBasicInfoHeaders headers = new RetrieveAssistantBasicInfoHeaders();
            return await RetrieveAssistantBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取AI助理的消息体
         *
         * @param headers RetrieveAssistantMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveAssistantMessageResponse
         */
        public RetrieveAssistantMessageResponse RetrieveAssistantMessageWithOptions(string threadId, string messageId, RetrieveAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RetrieveAssistantMessage",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/messages/" + messageId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取AI助理的消息体
         *
         * @param headers RetrieveAssistantMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveAssistantMessageResponse
         */
        public async Task<RetrieveAssistantMessageResponse> RetrieveAssistantMessageWithOptionsAsync(string threadId, string messageId, RetrieveAssistantMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RetrieveAssistantMessage",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/messages/" + messageId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取AI助理的消息体
         *
         * @return RetrieveAssistantMessageResponse
         */
        public RetrieveAssistantMessageResponse RetrieveAssistantMessage(string threadId, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantMessageHeaders headers = new RetrieveAssistantMessageHeaders();
            return RetrieveAssistantMessageWithOptions(threadId, messageId, headers, runtime);
        }

        /**
         * @summary 获取AI助理的消息体
         *
         * @return RetrieveAssistantMessageResponse
         */
        public async Task<RetrieveAssistantMessageResponse> RetrieveAssistantMessageAsync(string threadId, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantMessageHeaders headers = new RetrieveAssistantMessageHeaders();
            return await RetrieveAssistantMessageWithOptionsAsync(threadId, messageId, headers, runtime);
        }

        /**
         * @summary 检索AI助理的运行任务
         *
         * @param headers RetrieveAssistantRunHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveAssistantRunResponse
         */
        public RetrieveAssistantRunResponse RetrieveAssistantRunWithOptions(string threadId, string runId, RetrieveAssistantRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RetrieveAssistantRun",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/runs/" + runId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantRunResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 检索AI助理的运行任务
         *
         * @param headers RetrieveAssistantRunHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveAssistantRunResponse
         */
        public async Task<RetrieveAssistantRunResponse> RetrieveAssistantRunWithOptionsAsync(string threadId, string runId, RetrieveAssistantRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RetrieveAssistantRun",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId + "/runs/" + runId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantRunResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 检索AI助理的运行任务
         *
         * @return RetrieveAssistantRunResponse
         */
        public RetrieveAssistantRunResponse RetrieveAssistantRun(string threadId, string runId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantRunHeaders headers = new RetrieveAssistantRunHeaders();
            return RetrieveAssistantRunWithOptions(threadId, runId, headers, runtime);
        }

        /**
         * @summary 检索AI助理的运行任务
         *
         * @return RetrieveAssistantRunResponse
         */
        public async Task<RetrieveAssistantRunResponse> RetrieveAssistantRunAsync(string threadId, string runId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantRunHeaders headers = new RetrieveAssistantRunHeaders();
            return await RetrieveAssistantRunWithOptionsAsync(threadId, runId, headers, runtime);
        }

        /**
         * @summary 获取助理的使用范围
         *
         * @param request RetrieveAssistantScopeRequest
         * @param headers RetrieveAssistantScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveAssistantScopeResponse
         */
        public RetrieveAssistantScopeResponse RetrieveAssistantScopeWithOptions(RetrieveAssistantScopeRequest request, RetrieveAssistantScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RetrieveAssistantScope",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/scope",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantScopeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取助理的使用范围
         *
         * @param request RetrieveAssistantScopeRequest
         * @param headers RetrieveAssistantScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveAssistantScopeResponse
         */
        public async Task<RetrieveAssistantScopeResponse> RetrieveAssistantScopeWithOptionsAsync(RetrieveAssistantScopeRequest request, RetrieveAssistantScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                query["assistantId"] = request.AssistantId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RetrieveAssistantScope",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/scope",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantScopeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取助理的使用范围
         *
         * @param request RetrieveAssistantScopeRequest
         * @return RetrieveAssistantScopeResponse
         */
        public RetrieveAssistantScopeResponse RetrieveAssistantScope(RetrieveAssistantScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantScopeHeaders headers = new RetrieveAssistantScopeHeaders();
            return RetrieveAssistantScopeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取助理的使用范围
         *
         * @param request RetrieveAssistantScopeRequest
         * @return RetrieveAssistantScopeResponse
         */
        public async Task<RetrieveAssistantScopeResponse> RetrieveAssistantScopeAsync(RetrieveAssistantScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantScopeHeaders headers = new RetrieveAssistantScopeHeaders();
            return await RetrieveAssistantScopeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 检索AI助理线程实例
         *
         * @param headers RetrieveAssistantThreadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveAssistantThreadResponse
         */
        public RetrieveAssistantThreadResponse RetrieveAssistantThreadWithOptions(string threadId, RetrieveAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RetrieveAssistantThread",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantThreadResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 检索AI助理线程实例
         *
         * @param headers RetrieveAssistantThreadHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveAssistantThreadResponse
         */
        public async Task<RetrieveAssistantThreadResponse> RetrieveAssistantThreadWithOptionsAsync(string threadId, RetrieveAssistantThreadHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "RetrieveAssistantThread",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/threads/" + threadId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveAssistantThreadResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 检索AI助理线程实例
         *
         * @return RetrieveAssistantThreadResponse
         */
        public RetrieveAssistantThreadResponse RetrieveAssistantThread(string threadId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantThreadHeaders headers = new RetrieveAssistantThreadHeaders();
            return RetrieveAssistantThreadWithOptions(threadId, headers, runtime);
        }

        /**
         * @summary 检索AI助理线程实例
         *
         * @return RetrieveAssistantThreadResponse
         */
        public async Task<RetrieveAssistantThreadResponse> RetrieveAssistantThreadAsync(string threadId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RetrieveAssistantThreadHeaders headers = new RetrieveAssistantThreadHeaders();
            return await RetrieveAssistantThreadWithOptionsAsync(threadId, headers, runtime);
        }

        /**
         * @summary 更新AI助理基础信息
         *
         * @param request UpdateAssistantBasicInfoRequest
         * @param headers UpdateAssistantBasicInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAssistantBasicInfoResponse
         */
        public UpdateAssistantBasicInfoResponse UpdateAssistantBasicInfoWithOptions(UpdateAssistantBasicInfoRequest request, UpdateAssistantBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallbackContent))
            {
                body["fallbackContent"] = request.FallbackContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendPrompts))
            {
                body["recommendPrompts"] = request.RecommendPrompts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WelcomeContent))
            {
                body["welcomeContent"] = request.WelcomeContent;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateAssistantBasicInfo",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/basicInfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAssistantBasicInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新AI助理基础信息
         *
         * @param request UpdateAssistantBasicInfoRequest
         * @param headers UpdateAssistantBasicInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAssistantBasicInfoResponse
         */
        public async Task<UpdateAssistantBasicInfoResponse> UpdateAssistantBasicInfoWithOptionsAsync(UpdateAssistantBasicInfoRequest request, UpdateAssistantBasicInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FallbackContent))
            {
                body["fallbackContent"] = request.FallbackContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instructions))
            {
                body["instructions"] = request.Instructions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecommendPrompts))
            {
                body["recommendPrompts"] = request.RecommendPrompts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WelcomeContent))
            {
                body["welcomeContent"] = request.WelcomeContent;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateAssistantBasicInfo",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/basicInfo",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAssistantBasicInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新AI助理基础信息
         *
         * @param request UpdateAssistantBasicInfoRequest
         * @return UpdateAssistantBasicInfoResponse
         */
        public UpdateAssistantBasicInfoResponse UpdateAssistantBasicInfo(UpdateAssistantBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAssistantBasicInfoHeaders headers = new UpdateAssistantBasicInfoHeaders();
            return UpdateAssistantBasicInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新AI助理基础信息
         *
         * @param request UpdateAssistantBasicInfoRequest
         * @return UpdateAssistantBasicInfoResponse
         */
        public async Task<UpdateAssistantBasicInfoResponse> UpdateAssistantBasicInfoAsync(UpdateAssistantBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAssistantBasicInfoHeaders headers = new UpdateAssistantBasicInfoHeaders();
            return await UpdateAssistantBasicInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新 AI 助理使用范围
         *
         * @param request UpdateAssistantScopeRequest
         * @param headers UpdateAssistantScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAssistantScopeResponse
         */
        public UpdateAssistantScopeResponse UpdateAssistantScopeWithOptions(UpdateAssistantScopeRequest request, UpdateAssistantScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sharing))
            {
                body["sharing"] = request.Sharing;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateAssistantScope",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/scope",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "any",
            };
            return TeaModel.ToObject<UpdateAssistantScopeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新 AI 助理使用范围
         *
         * @param request UpdateAssistantScopeRequest
         * @param headers UpdateAssistantScopeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAssistantScopeResponse
         */
        public async Task<UpdateAssistantScopeResponse> UpdateAssistantScopeWithOptionsAsync(UpdateAssistantScopeRequest request, UpdateAssistantScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantId))
            {
                body["assistantId"] = request.AssistantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUnionId))
            {
                body["operatorUnionId"] = request.OperatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sharing))
            {
                body["sharing"] = request.Sharing;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateAssistantScope",
                Version = "assistant_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/assistant/scope",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "any",
            };
            return TeaModel.ToObject<UpdateAssistantScopeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新 AI 助理使用范围
         *
         * @param request UpdateAssistantScopeRequest
         * @return UpdateAssistantScopeResponse
         */
        public UpdateAssistantScopeResponse UpdateAssistantScope(UpdateAssistantScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAssistantScopeHeaders headers = new UpdateAssistantScopeHeaders();
            return UpdateAssistantScopeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新 AI 助理使用范围
         *
         * @param request UpdateAssistantScopeRequest
         * @return UpdateAssistantScopeResponse
         */
        public async Task<UpdateAssistantScopeResponse> UpdateAssistantScopeAsync(UpdateAssistantScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAssistantScopeHeaders headers = new UpdateAssistantScopeHeaders();
            return await UpdateAssistantScopeWithOptionsAsync(request, headers, runtime);
        }

    }
}
