// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkagoal_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0
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
         * @summary 获取Agoal指定目标或者关键结果关联的关键行动
         *
         * @param request AgoalObjectiveKeyActionListRequest
         * @param headers AgoalObjectiveKeyActionListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalObjectiveKeyActionListResponse
         */
        public AgoalObjectiveKeyActionListResponse AgoalObjectiveKeyActionListWithOptions(AgoalObjectiveKeyActionListRequest request, AgoalObjectiveKeyActionListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                query["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyResultId))
            {
                query["keyResultId"] = request.KeyResultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AgoalObjectiveKeyActionList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectives/keyActionLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveKeyActionListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取Agoal指定目标或者关键结果关联的关键行动
         *
         * @param request AgoalObjectiveKeyActionListRequest
         * @param headers AgoalObjectiveKeyActionListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalObjectiveKeyActionListResponse
         */
        public async Task<AgoalObjectiveKeyActionListResponse> AgoalObjectiveKeyActionListWithOptionsAsync(AgoalObjectiveKeyActionListRequest request, AgoalObjectiveKeyActionListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                query["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyResultId))
            {
                query["keyResultId"] = request.KeyResultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveId))
            {
                query["objectiveId"] = request.ObjectiveId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AgoalObjectiveKeyActionList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectives/keyActionLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveKeyActionListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Agoal指定目标或者关键结果关联的关键行动
         *
         * @param request AgoalObjectiveKeyActionListRequest
         * @return AgoalObjectiveKeyActionListResponse
         */
        public AgoalObjectiveKeyActionListResponse AgoalObjectiveKeyActionList(AgoalObjectiveKeyActionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveKeyActionListHeaders headers = new AgoalObjectiveKeyActionListHeaders();
            return AgoalObjectiveKeyActionListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取Agoal指定目标或者关键结果关联的关键行动
         *
         * @param request AgoalObjectiveKeyActionListRequest
         * @return AgoalObjectiveKeyActionListResponse
         */
        public async Task<AgoalObjectiveKeyActionListResponse> AgoalObjectiveKeyActionListAsync(AgoalObjectiveKeyActionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveKeyActionListHeaders headers = new AgoalObjectiveKeyActionListHeaders();
            return await AgoalObjectiveKeyActionListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取Agoal目标规则下的周期列表
         *
         * @param request AgoalObjectiveRulePeriodListRequest
         * @param headers AgoalObjectiveRulePeriodListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalObjectiveRulePeriodListResponse
         */
        public AgoalObjectiveRulePeriodListResponse AgoalObjectiveRulePeriodListWithOptions(AgoalObjectiveRulePeriodListRequest request, AgoalObjectiveRulePeriodListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveRuleId))
            {
                query["objectiveRuleId"] = request.ObjectiveRuleId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AgoalObjectiveRulePeriodList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRules/periodLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveRulePeriodListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取Agoal目标规则下的周期列表
         *
         * @param request AgoalObjectiveRulePeriodListRequest
         * @param headers AgoalObjectiveRulePeriodListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalObjectiveRulePeriodListResponse
         */
        public async Task<AgoalObjectiveRulePeriodListResponse> AgoalObjectiveRulePeriodListWithOptionsAsync(AgoalObjectiveRulePeriodListRequest request, AgoalObjectiveRulePeriodListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveRuleId))
            {
                query["objectiveRuleId"] = request.ObjectiveRuleId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AgoalObjectiveRulePeriodList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRules/periodLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalObjectiveRulePeriodListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Agoal目标规则下的周期列表
         *
         * @param request AgoalObjectiveRulePeriodListRequest
         * @return AgoalObjectiveRulePeriodListResponse
         */
        public AgoalObjectiveRulePeriodListResponse AgoalObjectiveRulePeriodList(AgoalObjectiveRulePeriodListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveRulePeriodListHeaders headers = new AgoalObjectiveRulePeriodListHeaders();
            return AgoalObjectiveRulePeriodListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取Agoal目标规则下的周期列表
         *
         * @param request AgoalObjectiveRulePeriodListRequest
         * @return AgoalObjectiveRulePeriodListResponse
         */
        public async Task<AgoalObjectiveRulePeriodListResponse> AgoalObjectiveRulePeriodListAsync(AgoalObjectiveRulePeriodListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalObjectiveRulePeriodListHeaders headers = new AgoalObjectiveRulePeriodListHeaders();
            return await AgoalObjectiveRulePeriodListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取Agoal目标规则列表
         *
         * @param headers AgoalOrgObjectiveRuleListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalOrgObjectiveRuleListResponse
         */
        public AgoalOrgObjectiveRuleListResponse AgoalOrgObjectiveRuleListWithOptions(AgoalOrgObjectiveRuleListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalOrgObjectiveRuleList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRules/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgObjectiveRuleListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取Agoal目标规则列表
         *
         * @param headers AgoalOrgObjectiveRuleListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalOrgObjectiveRuleListResponse
         */
        public async Task<AgoalOrgObjectiveRuleListResponse> AgoalOrgObjectiveRuleListWithOptionsAsync(AgoalOrgObjectiveRuleListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalOrgObjectiveRuleList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/objectiveRules/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalOrgObjectiveRuleListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Agoal目标规则列表
         *
         * @return AgoalOrgObjectiveRuleListResponse
         */
        public AgoalOrgObjectiveRuleListResponse AgoalOrgObjectiveRuleList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgObjectiveRuleListHeaders headers = new AgoalOrgObjectiveRuleListHeaders();
            return AgoalOrgObjectiveRuleListWithOptions(headers, runtime);
        }

        /**
         * @summary 获取Agoal目标规则列表
         *
         * @return AgoalOrgObjectiveRuleListResponse
         */
        public async Task<AgoalOrgObjectiveRuleListResponse> AgoalOrgObjectiveRuleListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalOrgObjectiveRuleListHeaders headers = new AgoalOrgObjectiveRuleListHeaders();
            return await AgoalOrgObjectiveRuleListWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary Agoal消息发送
         *
         * @param request AgoalSendMessageRequest
         * @param headers AgoalSendMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalSendMessageResponse
         */
        public AgoalSendMessageResponse AgoalSendMessageWithOptions(AgoalSendMessageRequest request, AgoalSendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileUrl))
            {
                body["mobileUrl"] = request.MobileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcUrl))
            {
                body["pcUrl"] = request.PcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDingUserId))
            {
                body["sourceDingUserId"] = request.SourceDingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDingUserIds))
            {
                body["targetDingUserIds"] = request.TargetDingUserIds;
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
                Action = "AgoalSendMessage",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalSendMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Agoal消息发送
         *
         * @param request AgoalSendMessageRequest
         * @param headers AgoalSendMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalSendMessageResponse
         */
        public async Task<AgoalSendMessageResponse> AgoalSendMessageWithOptionsAsync(AgoalSendMessageRequest request, AgoalSendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileUrl))
            {
                body["mobileUrl"] = request.MobileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PcUrl))
            {
                body["pcUrl"] = request.PcUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDingUserId))
            {
                body["sourceDingUserId"] = request.SourceDingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDingUserIds))
            {
                body["targetDingUserIds"] = request.TargetDingUserIds;
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
                Action = "AgoalSendMessage",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalSendMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Agoal消息发送
         *
         * @param request AgoalSendMessageRequest
         * @return AgoalSendMessageResponse
         */
        public AgoalSendMessageResponse AgoalSendMessage(AgoalSendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalSendMessageHeaders headers = new AgoalSendMessageHeaders();
            return AgoalSendMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary Agoal消息发送
         *
         * @param request AgoalSendMessageRequest
         * @return AgoalSendMessageResponse
         */
        public async Task<AgoalSendMessageResponse> AgoalSendMessageAsync(AgoalSendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalSendMessageHeaders headers = new AgoalSendMessageHeaders();
            return await AgoalSendMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取Agoal管理员列表
         *
         * @param headers AgoalUserAdminListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalUserAdminListResponse
         */
        public AgoalUserAdminListResponse AgoalUserAdminListWithOptions(AgoalUserAdminListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalUserAdminList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/administrators/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalUserAdminListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取Agoal管理员列表
         *
         * @param headers AgoalUserAdminListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalUserAdminListResponse
         */
        public async Task<AgoalUserAdminListResponse> AgoalUserAdminListWithOptionsAsync(AgoalUserAdminListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AgoalUserAdminList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/administrators/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalUserAdminListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取Agoal管理员列表
         *
         * @return AgoalUserAdminListResponse
         */
        public AgoalUserAdminListResponse AgoalUserAdminList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalUserAdminListHeaders headers = new AgoalUserAdminListHeaders();
            return AgoalUserAdminListWithOptions(headers, runtime);
        }

        /**
         * @summary 获取Agoal管理员列表
         *
         * @return AgoalUserAdminListResponse
         */
        public async Task<AgoalUserAdminListResponse> AgoalUserAdminListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalUserAdminListHeaders headers = new AgoalUserAdminListHeaders();
            return await AgoalUserAdminListWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary Agoal用户目标列表
         *
         * @param request AgoalUserObjectiveListRequest
         * @param headers AgoalUserObjectiveListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalUserObjectiveListResponse
         */
        public AgoalUserObjectiveListResponse AgoalUserObjectiveListWithOptions(AgoalUserObjectiveListRequest request, AgoalUserObjectiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveRuleId))
            {
                body["objectiveRuleId"] = request.ObjectiveRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodIds))
            {
                body["periodIds"] = request.PeriodIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AgoalUserObjectiveList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/users/objectiveLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalUserObjectiveListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Agoal用户目标列表
         *
         * @param request AgoalUserObjectiveListRequest
         * @param headers AgoalUserObjectiveListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AgoalUserObjectiveListResponse
         */
        public async Task<AgoalUserObjectiveListResponse> AgoalUserObjectiveListWithOptionsAsync(AgoalUserObjectiveListRequest request, AgoalUserObjectiveListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectiveRuleId))
            {
                body["objectiveRuleId"] = request.ObjectiveRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodIds))
            {
                body["periodIds"] = request.PeriodIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AgoalUserObjectiveList",
                Version = "agoal_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/agoal/users/objectiveLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AgoalUserObjectiveListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Agoal用户目标列表
         *
         * @param request AgoalUserObjectiveListRequest
         * @return AgoalUserObjectiveListResponse
         */
        public AgoalUserObjectiveListResponse AgoalUserObjectiveList(AgoalUserObjectiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalUserObjectiveListHeaders headers = new AgoalUserObjectiveListHeaders();
            return AgoalUserObjectiveListWithOptions(request, headers, runtime);
        }

        /**
         * @summary Agoal用户目标列表
         *
         * @param request AgoalUserObjectiveListRequest
         * @return AgoalUserObjectiveListResponse
         */
        public async Task<AgoalUserObjectiveListResponse> AgoalUserObjectiveListAsync(AgoalUserObjectiveListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AgoalUserObjectiveListHeaders headers = new AgoalUserObjectiveListHeaders();
            return await AgoalUserObjectiveListWithOptionsAsync(request, headers, runtime);
        }

    }
}
