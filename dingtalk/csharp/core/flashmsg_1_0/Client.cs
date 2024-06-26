// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkflashmsg_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkflashmsg_1_0
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
         * @summary 添加插件规则
         *
         * @param request AddPluginRuleRequest
         * @param headers AddPluginRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddPluginRuleResponse
         */
        public AddPluginRuleResponse AddPluginRuleWithOptions(AddPluginRuleRequest request, AddPluginRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatType))
            {
                body["chatType"] = request.ChatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                body["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                body["rules"] = request.Rules;
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
                Action = "AddPluginRule",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/plugins",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPluginRuleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 添加插件规则
         *
         * @param request AddPluginRuleRequest
         * @param headers AddPluginRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddPluginRuleResponse
         */
        public async Task<AddPluginRuleResponse> AddPluginRuleWithOptionsAsync(AddPluginRuleRequest request, AddPluginRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatType))
            {
                body["chatType"] = request.ChatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                body["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                body["rules"] = request.Rules;
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
                Action = "AddPluginRule",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/plugins",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddPluginRuleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加插件规则
         *
         * @param request AddPluginRuleRequest
         * @return AddPluginRuleResponse
         */
        public AddPluginRuleResponse AddPluginRule(AddPluginRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPluginRuleHeaders headers = new AddPluginRuleHeaders();
            return AddPluginRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加插件规则
         *
         * @param request AddPluginRuleRequest
         * @return AddPluginRuleResponse
         */
        public async Task<AddPluginRuleResponse> AddPluginRuleAsync(AddPluginRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddPluginRuleHeaders headers = new AddPluginRuleHeaders();
            return await AddPluginRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除插件规则
         *
         * @param request DeletePlguinRuleRequest
         * @param headers DeletePlguinRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePlguinRuleResponse
         */
        public DeletePlguinRuleResponse DeletePlguinRuleWithOptions(DeletePlguinRuleRequest request, DeletePlguinRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizIdList))
            {
                body["bizIdList"] = request.BizIdList;
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
                Action = "DeletePlguinRule",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/plugins/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePlguinRuleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除插件规则
         *
         * @param request DeletePlguinRuleRequest
         * @param headers DeletePlguinRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePlguinRuleResponse
         */
        public async Task<DeletePlguinRuleResponse> DeletePlguinRuleWithOptionsAsync(DeletePlguinRuleRequest request, DeletePlguinRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizIdList))
            {
                body["bizIdList"] = request.BizIdList;
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
                Action = "DeletePlguinRule",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/plugins/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePlguinRuleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除插件规则
         *
         * @param request DeletePlguinRuleRequest
         * @return DeletePlguinRuleResponse
         */
        public DeletePlguinRuleResponse DeletePlguinRule(DeletePlguinRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePlguinRuleHeaders headers = new DeletePlguinRuleHeaders();
            return DeletePlguinRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除插件规则
         *
         * @param request DeletePlguinRuleRequest
         * @return DeletePlguinRuleResponse
         */
        public async Task<DeletePlguinRuleResponse> DeletePlguinRuleAsync(DeletePlguinRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeletePlguinRuleHeaders headers = new DeletePlguinRuleHeaders();
            return await DeletePlguinRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 闪读用户基础信息查询
         *
         * @param request GetBaseProfileListRequest
         * @param headers GetBaseProfileListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBaseProfileListResponse
         */
        public GetBaseProfileListResponse GetBaseProfileListWithOptions(GetBaseProfileListRequest request, GetBaseProfileListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBaseProfileList",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/users/baseInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBaseProfileListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 闪读用户基础信息查询
         *
         * @param request GetBaseProfileListRequest
         * @param headers GetBaseProfileListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBaseProfileListResponse
         */
        public async Task<GetBaseProfileListResponse> GetBaseProfileListWithOptionsAsync(GetBaseProfileListRequest request, GetBaseProfileListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBaseProfileList",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/users/baseInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBaseProfileListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 闪读用户基础信息查询
         *
         * @param request GetBaseProfileListRequest
         * @return GetBaseProfileListResponse
         */
        public GetBaseProfileListResponse GetBaseProfileList(GetBaseProfileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBaseProfileListHeaders headers = new GetBaseProfileListHeaders();
            return GetBaseProfileListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 闪读用户基础信息查询
         *
         * @param request GetBaseProfileListRequest
         * @return GetBaseProfileListResponse
         */
        public async Task<GetBaseProfileListResponse> GetBaseProfileListAsync(GetBaseProfileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBaseProfileListHeaders headers = new GetBaseProfileListHeaders();
            return await GetBaseProfileListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获得闪读会话信息
         *
         * @param request GetConversationRequest
         * @param headers GetConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConversationResponse
         */
        public GetConversationResponse GetConversationWithOptions(GetConversationRequest request, GetConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
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
                Action = "GetConversation",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/conversations/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获得闪读会话信息
         *
         * @param request GetConversationRequest
         * @param headers GetConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConversationResponse
         */
        public async Task<GetConversationResponse> GetConversationWithOptionsAsync(GetConversationRequest request, GetConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
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
                Action = "GetConversation",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/conversations/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获得闪读会话信息
         *
         * @param request GetConversationRequest
         * @return GetConversationResponse
         */
        public GetConversationResponse GetConversation(GetConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationHeaders headers = new GetConversationHeaders();
            return GetConversationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获得闪读会话信息
         *
         * @param request GetConversationRequest
         * @return GetConversationResponse
         */
        public async Task<GetConversationResponse> GetConversationAsync(GetConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationHeaders headers = new GetConversationHeaders();
            return await GetConversationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获得成员ID列表
         *
         * @param request GetMemberListRequest
         * @param headers GetMemberListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMemberListResponse
         */
        public GetMemberListResponse GetMemberListWithOptions(GetMemberListRequest request, GetMemberListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "GetMemberList",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/conversations/memberIdLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemberListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获得成员ID列表
         *
         * @param request GetMemberListRequest
         * @param headers GetMemberListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMemberListResponse
         */
        public async Task<GetMemberListResponse> GetMemberListWithOptionsAsync(GetMemberListRequest request, GetMemberListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "GetMemberList",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/conversations/memberIdLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMemberListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获得成员ID列表
         *
         * @param request GetMemberListRequest
         * @return GetMemberListResponse
         */
        public GetMemberListResponse GetMemberList(GetMemberListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMemberListHeaders headers = new GetMemberListHeaders();
            return GetMemberListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获得成员ID列表
         *
         * @param request GetMemberListRequest
         * @return GetMemberListResponse
         */
        public async Task<GetMemberListResponse> GetMemberListAsync(GetMemberListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMemberListHeaders headers = new GetMemberListHeaders();
            return await GetMemberListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询插件规则
         *
         * @param request QueryPluginRuleRequest
         * @param headers QueryPluginRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPluginRuleResponse
         */
        public QueryPluginRuleResponse QueryPluginRuleWithOptions(QueryPluginRuleRequest request, QueryPluginRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatType))
            {
                query["chatType"] = request.ChatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["itemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryPluginRule",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/plugins",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPluginRuleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询插件规则
         *
         * @param request QueryPluginRuleRequest
         * @param headers QueryPluginRuleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPluginRuleResponse
         */
        public async Task<QueryPluginRuleResponse> QueryPluginRuleWithOptionsAsync(QueryPluginRuleRequest request, QueryPluginRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatType))
            {
                query["chatType"] = request.ChatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemId))
            {
                query["itemId"] = request.ItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemType))
            {
                query["itemType"] = request.ItemType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryPluginRule",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/plugins",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPluginRuleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询插件规则
         *
         * @param request QueryPluginRuleRequest
         * @return QueryPluginRuleResponse
         */
        public QueryPluginRuleResponse QueryPluginRule(QueryPluginRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPluginRuleHeaders headers = new QueryPluginRuleHeaders();
            return QueryPluginRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询插件规则
         *
         * @param request QueryPluginRuleRequest
         * @return QueryPluginRuleResponse
         */
        public async Task<QueryPluginRuleResponse> QueryPluginRuleAsync(QueryPluginRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPluginRuleHeaders headers = new QueryPluginRuleHeaders();
            return await QueryPluginRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送Ding提示消息
         *
         * @param request SendDingTipRequest
         * @param headers SendDingTipHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendDingTipResponse
         */
        public SendDingTipResponse SendDingTipWithOptions(SendDingTipRequest request, SendDingTipHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Link))
            {
                body["link"] = request.Link;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserId))
            {
                body["receiverUserId"] = request.ReceiverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                body["senderUserId"] = request.SenderUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["textContent"] = request.TextContent;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendDingTip",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/ding/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendDingTipResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送Ding提示消息
         *
         * @param request SendDingTipRequest
         * @param headers SendDingTipHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendDingTipResponse
         */
        public async Task<SendDingTipResponse> SendDingTipWithOptionsAsync(SendDingTipRequest request, SendDingTipHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Link))
            {
                body["link"] = request.Link;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserId))
            {
                body["receiverUserId"] = request.ReceiverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                body["senderUserId"] = request.SenderUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextContent))
            {
                body["textContent"] = request.TextContent;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendDingTip",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/ding/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendDingTipResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送Ding提示消息
         *
         * @param request SendDingTipRequest
         * @return SendDingTipResponse
         */
        public SendDingTipResponse SendDingTip(SendDingTipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendDingTipHeaders headers = new SendDingTipHeaders();
            return SendDingTipWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送Ding提示消息
         *
         * @param request SendDingTipRequest
         * @return SendDingTipResponse
         */
        public async Task<SendDingTipResponse> SendDingTipAsync(SendDingTipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendDingTipHeaders headers = new SendDingTipHeaders();
            return await SendDingTipWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送闪读消息提示
         *
         * @param request SendMessageTipRequest
         * @param headers SendMessageTipHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendMessageTipResponse
         */
        public SendMessageTipResponse SendMessageTipWithOptions(SendMessageTipRequest request, SendMessageTipHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultView))
            {
                body["defaultView"] = request.DefaultView;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateFieldMap))
            {
                body["privateFieldMap"] = request.PrivateFieldMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicField))
            {
                body["publicField"] = request.PublicField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserId))
            {
                body["receiverUserId"] = request.ReceiverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                body["senderUserId"] = request.SenderUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendMessageTip",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageTipResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送闪读消息提示
         *
         * @param request SendMessageTipRequest
         * @param headers SendMessageTipHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendMessageTipResponse
         */
        public async Task<SendMessageTipResponse> SendMessageTipWithOptionsAsync(SendMessageTipRequest request, SendMessageTipHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultView))
            {
                body["defaultView"] = request.DefaultView;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                body["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateFieldMap))
            {
                body["privateFieldMap"] = request.PrivateFieldMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicField))
            {
                body["publicField"] = request.PublicField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserId))
            {
                body["receiverUserId"] = request.ReceiverUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderUserId))
            {
                body["senderUserId"] = request.SenderUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendMessageTip",
                Version = "flashmsg_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/flashmsg/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageTipResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送闪读消息提示
         *
         * @param request SendMessageTipRequest
         * @return SendMessageTipResponse
         */
        public SendMessageTipResponse SendMessageTip(SendMessageTipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageTipHeaders headers = new SendMessageTipHeaders();
            return SendMessageTipWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送闪读消息提示
         *
         * @param request SendMessageTipRequest
         * @return SendMessageTipResponse
         */
        public async Task<SendMessageTipResponse> SendMessageTipAsync(SendMessageTipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageTipHeaders headers = new SendMessageTipHeaders();
            return await SendMessageTipWithOptionsAsync(request, headers, runtime);
        }

    }
}
