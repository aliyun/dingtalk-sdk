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

    }
}
