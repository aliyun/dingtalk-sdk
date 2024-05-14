// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkim_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkim_1_0
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
         * @summary 添加企业文字表情
         *
         * @param request AddOrgTextEmotionRequest
         * @param headers AddOrgTextEmotionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddOrgTextEmotionResponse
         */
        public AddOrgTextEmotionResponse AddOrgTextEmotionWithOptions(AddOrgTextEmotionRequest request, AddOrgTextEmotionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundMediaId))
            {
                body["backgroundMediaId"] = request.BackgroundMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundMediaIdForPanel))
            {
                body["backgroundMediaIdForPanel"] = request.BackgroundMediaIdForPanel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmotionName))
            {
                body["emotionName"] = request.EmotionName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddOrgTextEmotion",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/organizations/textEmotions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrgTextEmotionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 添加企业文字表情
         *
         * @param request AddOrgTextEmotionRequest
         * @param headers AddOrgTextEmotionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddOrgTextEmotionResponse
         */
        public async Task<AddOrgTextEmotionResponse> AddOrgTextEmotionWithOptionsAsync(AddOrgTextEmotionRequest request, AddOrgTextEmotionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundMediaId))
            {
                body["backgroundMediaId"] = request.BackgroundMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundMediaIdForPanel))
            {
                body["backgroundMediaIdForPanel"] = request.BackgroundMediaIdForPanel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmotionName))
            {
                body["emotionName"] = request.EmotionName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddOrgTextEmotion",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/organizations/textEmotions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrgTextEmotionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加企业文字表情
         *
         * @param request AddOrgTextEmotionRequest
         * @return AddOrgTextEmotionResponse
         */
        public AddOrgTextEmotionResponse AddOrgTextEmotion(AddOrgTextEmotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgTextEmotionHeaders headers = new AddOrgTextEmotionHeaders();
            return AddOrgTextEmotionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加企业文字表情
         *
         * @param request AddOrgTextEmotionRequest
         * @return AddOrgTextEmotionResponse
         */
        public async Task<AddOrgTextEmotionResponse> AddOrgTextEmotionAsync(AddOrgTextEmotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgTextEmotionHeaders headers = new AddOrgTextEmotionHeaders();
            return await AddOrgTextEmotionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加机器人到会话
         *
         * @param request AddRobotToConversationRequest
         * @param headers AddRobotToConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddRobotToConversationResponse
         */
        public AddRobotToConversationResponse AddRobotToConversationWithOptions(AddRobotToConversationRequest request, AddRobotToConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddRobotToConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/robots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRobotToConversationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 添加机器人到会话
         *
         * @param request AddRobotToConversationRequest
         * @param headers AddRobotToConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddRobotToConversationResponse
         */
        public async Task<AddRobotToConversationResponse> AddRobotToConversationWithOptionsAsync(AddRobotToConversationRequest request, AddRobotToConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddRobotToConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/robots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRobotToConversationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加机器人到会话
         *
         * @param request AddRobotToConversationRequest
         * @return AddRobotToConversationResponse
         */
        public AddRobotToConversationResponse AddRobotToConversation(AddRobotToConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRobotToConversationHeaders headers = new AddRobotToConversationHeaders();
            return AddRobotToConversationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加机器人到会话
         *
         * @param request AddRobotToConversationRequest
         * @return AddRobotToConversationResponse
         */
        public async Task<AddRobotToConversationResponse> AddRobotToConversationAsync(AddRobotToConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRobotToConversationHeaders headers = new AddRobotToConversationHeaders();
            return await AddRobotToConversationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 自动开通钉钉客联微应用
         *
         * @param headers AutoOpenDingTalkConnectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AutoOpenDingTalkConnectResponse
         */
        public AutoOpenDingTalkConnectResponse AutoOpenDingTalkConnectWithOptions(AutoOpenDingTalkConnectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AutoOpenDingTalkConnect",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/apps/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AutoOpenDingTalkConnectResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 自动开通钉钉客联微应用
         *
         * @param headers AutoOpenDingTalkConnectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AutoOpenDingTalkConnectResponse
         */
        public async Task<AutoOpenDingTalkConnectResponse> AutoOpenDingTalkConnectWithOptionsAsync(AutoOpenDingTalkConnectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AutoOpenDingTalkConnect",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/apps/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AutoOpenDingTalkConnectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 自动开通钉钉客联微应用
         *
         * @return AutoOpenDingTalkConnectResponse
         */
        public AutoOpenDingTalkConnectResponse AutoOpenDingTalkConnect()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AutoOpenDingTalkConnectHeaders headers = new AutoOpenDingTalkConnectHeaders();
            return AutoOpenDingTalkConnectWithOptions(headers, runtime);
        }

        /**
         * @summary 自动开通钉钉客联微应用
         *
         * @return AutoOpenDingTalkConnectResponse
         */
        public async Task<AutoOpenDingTalkConnectResponse> AutoOpenDingTalkConnectAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AutoOpenDingTalkConnectHeaders headers = new AutoOpenDingTalkConnectHeaders();
            return await AutoOpenDingTalkConnectWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 批量查询家校群消息详情
         *
         * @param request BatchQueryFamilySchoolMessageRequest
         * @param headers BatchQueryFamilySchoolMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchQueryFamilySchoolMessageResponse
         */
        public BatchQueryFamilySchoolMessageResponse BatchQueryFamilySchoolMessageWithOptions(BatchQueryFamilySchoolMessageRequest request, BatchQueryFamilySchoolMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMessageIds))
            {
                body["openMessageIds"] = request.OpenMessageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchQueryFamilySchoolMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/familySchools/messages/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryFamilySchoolMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量查询家校群消息详情
         *
         * @param request BatchQueryFamilySchoolMessageRequest
         * @param headers BatchQueryFamilySchoolMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchQueryFamilySchoolMessageResponse
         */
        public async Task<BatchQueryFamilySchoolMessageResponse> BatchQueryFamilySchoolMessageWithOptionsAsync(BatchQueryFamilySchoolMessageRequest request, BatchQueryFamilySchoolMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMessageIds))
            {
                body["openMessageIds"] = request.OpenMessageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchQueryFamilySchoolMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/familySchools/messages/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryFamilySchoolMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询家校群消息详情
         *
         * @param request BatchQueryFamilySchoolMessageRequest
         * @return BatchQueryFamilySchoolMessageResponse
         */
        public BatchQueryFamilySchoolMessageResponse BatchQueryFamilySchoolMessage(BatchQueryFamilySchoolMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryFamilySchoolMessageHeaders headers = new BatchQueryFamilySchoolMessageHeaders();
            return BatchQueryFamilySchoolMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询家校群消息详情
         *
         * @param request BatchQueryFamilySchoolMessageRequest
         * @return BatchQueryFamilySchoolMessageResponse
         */
        public async Task<BatchQueryFamilySchoolMessageResponse> BatchQueryFamilySchoolMessageAsync(BatchQueryFamilySchoolMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryFamilySchoolMessageHeaders headers = new BatchQueryFamilySchoolMessageHeaders();
            return await BatchQueryFamilySchoolMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询群成员
         *
         * @param request BatchQueryGroupMemberRequest
         * @param headers BatchQueryGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchQueryGroupMemberResponse
         */
        public BatchQueryGroupMemberResponse BatchQueryGroupMemberWithOptions(BatchQueryGroupMemberRequest request, BatchQueryGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchQueryGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/members/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryGroupMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询群成员
         *
         * @param request BatchQueryGroupMemberRequest
         * @param headers BatchQueryGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchQueryGroupMemberResponse
         */
        public async Task<BatchQueryGroupMemberResponse> BatchQueryGroupMemberWithOptionsAsync(BatchQueryGroupMemberRequest request, BatchQueryGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BatchQueryGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/members/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryGroupMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询群成员
         *
         * @param request BatchQueryGroupMemberRequest
         * @return BatchQueryGroupMemberResponse
         */
        public BatchQueryGroupMemberResponse BatchQueryGroupMember(BatchQueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryGroupMemberHeaders headers = new BatchQueryGroupMemberHeaders();
            return BatchQueryGroupMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询群成员
         *
         * @param request BatchQueryGroupMemberRequest
         * @return BatchQueryGroupMemberResponse
         */
        public async Task<BatchQueryGroupMemberResponse> BatchQueryGroupMemberAsync(BatchQueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryGroupMemberHeaders headers = new BatchQueryGroupMemberHeaders();
            return await BatchQueryGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 钉钉互动卡片模板构建动作
         *
         * @param request CardTemplateBuildActionRequest
         * @param headers CardTemplateBuildActionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CardTemplateBuildActionResponse
         */
        public CardTemplateBuildActionResponse CardTemplateBuildActionWithOptions(CardTemplateBuildActionRequest request, CardTemplateBuildActionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateJson))
            {
                body["cardTemplateJson"] = request.CardTemplateJson;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CardTemplateBuildAction",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interactiveCards/templates/buildAction",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CardTemplateBuildActionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 钉钉互动卡片模板构建动作
         *
         * @param request CardTemplateBuildActionRequest
         * @param headers CardTemplateBuildActionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CardTemplateBuildActionResponse
         */
        public async Task<CardTemplateBuildActionResponse> CardTemplateBuildActionWithOptionsAsync(CardTemplateBuildActionRequest request, CardTemplateBuildActionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateJson))
            {
                body["cardTemplateJson"] = request.CardTemplateJson;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CardTemplateBuildAction",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interactiveCards/templates/buildAction",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CardTemplateBuildActionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 钉钉互动卡片模板构建动作
         *
         * @param request CardTemplateBuildActionRequest
         * @return CardTemplateBuildActionResponse
         */
        public CardTemplateBuildActionResponse CardTemplateBuildAction(CardTemplateBuildActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CardTemplateBuildActionHeaders headers = new CardTemplateBuildActionHeaders();
            return CardTemplateBuildActionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 钉钉互动卡片模板构建动作
         *
         * @param request CardTemplateBuildActionRequest
         * @return CardTemplateBuildActionResponse
         */
        public async Task<CardTemplateBuildActionResponse> CardTemplateBuildActionAsync(CardTemplateBuildActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CardTemplateBuildActionHeaders headers = new CardTemplateBuildActionHeaders();
            return await CardTemplateBuildActionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更换群主
         *
         * @param request ChangeGroupOwnerRequest
         * @param headers ChangeGroupOwnerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeGroupOwnerResponse
         */
        public ChangeGroupOwnerResponse ChangeGroupOwnerWithOptions(ChangeGroupOwnerRequest request, ChangeGroupOwnerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerId))
            {
                body["groupOwnerId"] = request.GroupOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerType))
            {
                body["groupOwnerType"] = request.GroupOwnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ChangeGroupOwner",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/owners",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeGroupOwnerResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更换群主
         *
         * @param request ChangeGroupOwnerRequest
         * @param headers ChangeGroupOwnerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeGroupOwnerResponse
         */
        public async Task<ChangeGroupOwnerResponse> ChangeGroupOwnerWithOptionsAsync(ChangeGroupOwnerRequest request, ChangeGroupOwnerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerId))
            {
                body["groupOwnerId"] = request.GroupOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerType))
            {
                body["groupOwnerType"] = request.GroupOwnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "ChangeGroupOwner",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/owners",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeGroupOwnerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更换群主
         *
         * @param request ChangeGroupOwnerRequest
         * @return ChangeGroupOwnerResponse
         */
        public ChangeGroupOwnerResponse ChangeGroupOwner(ChangeGroupOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeGroupOwnerHeaders headers = new ChangeGroupOwnerHeaders();
            return ChangeGroupOwnerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更换群主
         *
         * @param request ChangeGroupOwnerRequest
         * @return ChangeGroupOwnerResponse
         */
        public async Task<ChangeGroupOwnerResponse> ChangeGroupOwnerAsync(ChangeGroupOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeGroupOwnerHeaders headers = new ChangeGroupOwnerHeaders();
            return await ChangeGroupOwnerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 会话开放的ChatId转OpenConversationId
         *
         * @param headers ChatIdToOpenConversationIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatIdToOpenConversationIdResponse
         */
        public ChatIdToOpenConversationIdResponse ChatIdToOpenConversationIdWithOptions(string chatId, ChatIdToOpenConversationIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ChatIdToOpenConversationId",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/chat/" + chatId + "/convertToOpenConversationId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatIdToOpenConversationIdResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 会话开放的ChatId转OpenConversationId
         *
         * @param headers ChatIdToOpenConversationIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatIdToOpenConversationIdResponse
         */
        public async Task<ChatIdToOpenConversationIdResponse> ChatIdToOpenConversationIdWithOptionsAsync(string chatId, ChatIdToOpenConversationIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ChatIdToOpenConversationId",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/chat/" + chatId + "/convertToOpenConversationId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatIdToOpenConversationIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 会话开放的ChatId转OpenConversationId
         *
         * @return ChatIdToOpenConversationIdResponse
         */
        public ChatIdToOpenConversationIdResponse ChatIdToOpenConversationId(string chatId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatIdToOpenConversationIdHeaders headers = new ChatIdToOpenConversationIdHeaders();
            return ChatIdToOpenConversationIdWithOptions(chatId, headers, runtime);
        }

        /**
         * @summary 会话开放的ChatId转OpenConversationId
         *
         * @return ChatIdToOpenConversationIdResponse
         */
        public async Task<ChatIdToOpenConversationIdResponse> ChatIdToOpenConversationIdAsync(string chatId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatIdToOpenConversationIdHeaders headers = new ChatIdToOpenConversationIdHeaders();
            return await ChatIdToOpenConversationIdWithOptionsAsync(chatId, headers, runtime);
        }

        /**
         * @summary 设置群管理员
         *
         * @param request ChatSubAdminUpdateRequest
         * @param headers ChatSubAdminUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatSubAdminUpdateResponse
         */
        public ChatSubAdminUpdateResponse ChatSubAdminUpdateWithOptions(ChatSubAdminUpdateRequest request, ChatSubAdminUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
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
                Action = "ChatSubAdminUpdate",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/subAdministrators",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatSubAdminUpdateResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置群管理员
         *
         * @param request ChatSubAdminUpdateRequest
         * @param headers ChatSubAdminUpdateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChatSubAdminUpdateResponse
         */
        public async Task<ChatSubAdminUpdateResponse> ChatSubAdminUpdateWithOptionsAsync(ChatSubAdminUpdateRequest request, ChatSubAdminUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
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
                Action = "ChatSubAdminUpdate",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/subAdministrators",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatSubAdminUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置群管理员
         *
         * @param request ChatSubAdminUpdateRequest
         * @return ChatSubAdminUpdateResponse
         */
        public ChatSubAdminUpdateResponse ChatSubAdminUpdate(ChatSubAdminUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatSubAdminUpdateHeaders headers = new ChatSubAdminUpdateHeaders();
            return ChatSubAdminUpdateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置群管理员
         *
         * @param request ChatSubAdminUpdateRequest
         * @return ChatSubAdminUpdateResponse
         */
        public async Task<ChatSubAdminUpdateResponse> ChatSubAdminUpdateAsync(ChatSubAdminUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatSubAdminUpdateHeaders headers = new ChatSubAdminUpdateHeaders();
            return await ChatSubAdminUpdateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户是否为企业内部群成员
         *
         * @param request CheckUserIsGroupMemberRequest
         * @param headers CheckUserIsGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUserIsGroupMemberResponse
         */
        public CheckUserIsGroupMemberResponse CheckUserIsGroupMemberWithOptions(CheckUserIsGroupMemberRequest request, CheckUserIsGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "CheckUserIsGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/members/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUserIsGroupMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询用户是否为企业内部群成员
         *
         * @param request CheckUserIsGroupMemberRequest
         * @param headers CheckUserIsGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUserIsGroupMemberResponse
         */
        public async Task<CheckUserIsGroupMemberResponse> CheckUserIsGroupMemberWithOptionsAsync(CheckUserIsGroupMemberRequest request, CheckUserIsGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "CheckUserIsGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/members/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUserIsGroupMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户是否为企业内部群成员
         *
         * @param request CheckUserIsGroupMemberRequest
         * @return CheckUserIsGroupMemberResponse
         */
        public CheckUserIsGroupMemberResponse CheckUserIsGroupMember(CheckUserIsGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckUserIsGroupMemberHeaders headers = new CheckUserIsGroupMemberHeaders();
            return CheckUserIsGroupMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户是否为企业内部群成员
         *
         * @param request CheckUserIsGroupMemberRequest
         * @return CheckUserIsGroupMemberResponse
         */
        public async Task<CheckUserIsGroupMemberResponse> CheckUserIsGroupMemberAsync(CheckUserIsGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckUserIsGroupMemberHeaders headers = new CheckUserIsGroupMemberHeaders();
            return await CheckUserIsGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建钉外两人群
         *
         * @param request CreateCoupleGroupConversationRequest
         * @param headers CreateCoupleGroupConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCoupleGroupConversationResponse
         */
        public CreateCoupleGroupConversationResponse CreateCoupleGroupConversationWithOptions(CreateCoupleGroupConversationRequest request, CreateCoupleGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserId))
            {
                body["appUserId"] = request.AppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAvatar))
            {
                body["groupAvatar"] = request.GroupAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerId))
            {
                body["groupOwnerId"] = request.GroupOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateCoupleGroupConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/coupleGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCoupleGroupConversationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建钉外两人群
         *
         * @param request CreateCoupleGroupConversationRequest
         * @param headers CreateCoupleGroupConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCoupleGroupConversationResponse
         */
        public async Task<CreateCoupleGroupConversationResponse> CreateCoupleGroupConversationWithOptionsAsync(CreateCoupleGroupConversationRequest request, CreateCoupleGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserId))
            {
                body["appUserId"] = request.AppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAvatar))
            {
                body["groupAvatar"] = request.GroupAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerId))
            {
                body["groupOwnerId"] = request.GroupOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateCoupleGroupConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/coupleGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCoupleGroupConversationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建钉外两人群
         *
         * @param request CreateCoupleGroupConversationRequest
         * @return CreateCoupleGroupConversationResponse
         */
        public CreateCoupleGroupConversationResponse CreateCoupleGroupConversation(CreateCoupleGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCoupleGroupConversationHeaders headers = new CreateCoupleGroupConversationHeaders();
            return CreateCoupleGroupConversationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建钉外两人群
         *
         * @param request CreateCoupleGroupConversationRequest
         * @return CreateCoupleGroupConversationResponse
         */
        public async Task<CreateCoupleGroupConversationResponse> CreateCoupleGroupConversationAsync(CreateCoupleGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCoupleGroupConversationHeaders headers = new CreateCoupleGroupConversationHeaders();
            return await CreateCoupleGroupConversationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建互通群（支持普通互通群、跨钉两人群）
         *
         * @param request CreateGroupConversationRequest
         * @param headers CreateGroupConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupConversationResponse
         */
        public CreateGroupConversationResponse CreateGroupConversationWithOptions(CreateGroupConversationRequest request, CreateGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserIds))
            {
                body["appUserIds"] = request.AppUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAvatar))
            {
                body["groupAvatar"] = request.GroupAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerId))
            {
                body["groupOwnerId"] = request.GroupOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerType))
            {
                body["groupOwnerType"] = request.GroupOwnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
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
                Action = "CreateGroupConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupConversationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建互通群（支持普通互通群、跨钉两人群）
         *
         * @param request CreateGroupConversationRequest
         * @param headers CreateGroupConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupConversationResponse
         */
        public async Task<CreateGroupConversationResponse> CreateGroupConversationWithOptionsAsync(CreateGroupConversationRequest request, CreateGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserIds))
            {
                body["appUserIds"] = request.AppUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAvatar))
            {
                body["groupAvatar"] = request.GroupAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerId))
            {
                body["groupOwnerId"] = request.GroupOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerType))
            {
                body["groupOwnerType"] = request.GroupOwnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
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
                Action = "CreateGroupConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupConversationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建互通群（支持普通互通群、跨钉两人群）
         *
         * @param request CreateGroupConversationRequest
         * @return CreateGroupConversationResponse
         */
        public CreateGroupConversationResponse CreateGroupConversation(CreateGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupConversationHeaders headers = new CreateGroupConversationHeaders();
            return CreateGroupConversationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建互通群（支持普通互通群、跨钉两人群）
         *
         * @param request CreateGroupConversationRequest
         * @return CreateGroupConversationResponse
         */
        public async Task<CreateGroupConversationResponse> CreateGroupConversationAsync(CreateGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupConversationHeaders headers = new CreateGroupConversationHeaders();
            return await CreateGroupConversationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建钉外账号
         *
         * @param request CreateInterconnectionRequest
         * @param headers CreateInterconnectionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInterconnectionResponse
         */
        public CreateInterconnectionResponse CreateInterconnectionWithOptions(CreateInterconnectionRequest request, CreateInterconnectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interconnections))
            {
                body["interconnections"] = request.Interconnections;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateInterconnection",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInterconnectionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建钉外账号
         *
         * @param request CreateInterconnectionRequest
         * @param headers CreateInterconnectionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInterconnectionResponse
         */
        public async Task<CreateInterconnectionResponse> CreateInterconnectionWithOptionsAsync(CreateInterconnectionRequest request, CreateInterconnectionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interconnections))
            {
                body["interconnections"] = request.Interconnections;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateInterconnection",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInterconnectionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建钉外账号
         *
         * @param request CreateInterconnectionRequest
         * @return CreateInterconnectionResponse
         */
        public CreateInterconnectionResponse CreateInterconnection(CreateInterconnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInterconnectionHeaders headers = new CreateInterconnectionHeaders();
            return CreateInterconnectionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建钉外账号
         *
         * @param request CreateInterconnectionRequest
         * @return CreateInterconnectionResponse
         */
        public async Task<CreateInterconnectionResponse> CreateInterconnectionAsync(CreateInterconnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInterconnectionHeaders headers = new CreateInterconnectionHeaders();
            return await CreateInterconnectionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建场景群会话
         *
         * @param request CreateSceneGroupConversationRequest
         * @param headers CreateSceneGroupConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSceneGroupConversationResponse
         */
        public CreateSceneGroupConversationResponse CreateSceneGroupConversationWithOptions(CreateSceneGroupConversationRequest request, CreateSceneGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Features))
            {
                body["features"] = request.Features;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerId))
            {
                body["groupOwnerId"] = request.GroupOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagementOptions))
            {
                body["managementOptions"] = request.ManagementOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateSceneGroupConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSceneGroupConversationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建场景群会话
         *
         * @param request CreateSceneGroupConversationRequest
         * @param headers CreateSceneGroupConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSceneGroupConversationResponse
         */
        public async Task<CreateSceneGroupConversationResponse> CreateSceneGroupConversationWithOptionsAsync(CreateSceneGroupConversationRequest request, CreateSceneGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Features))
            {
                body["features"] = request.Features;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwnerId))
            {
                body["groupOwnerId"] = request.GroupOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagementOptions))
            {
                body["managementOptions"] = request.ManagementOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateSceneGroupConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSceneGroupConversationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建场景群会话
         *
         * @param request CreateSceneGroupConversationRequest
         * @return CreateSceneGroupConversationResponse
         */
        public CreateSceneGroupConversationResponse CreateSceneGroupConversation(CreateSceneGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSceneGroupConversationHeaders headers = new CreateSceneGroupConversationHeaders();
            return CreateSceneGroupConversationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建场景群会话
         *
         * @param request CreateSceneGroupConversationRequest
         * @return CreateSceneGroupConversationResponse
         */
        public async Task<CreateSceneGroupConversationResponse> CreateSceneGroupConversationAsync(CreateSceneGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSceneGroupConversationHeaders headers = new CreateSceneGroupConversationHeaders();
            return await CreateSceneGroupConversationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建店铺群
         *
         * @param request CreateStoreGroupConversationRequest
         * @param headers CreateStoreGroupConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateStoreGroupConversationResponse
         */
        public CreateStoreGroupConversationResponse CreateStoreGroupConversationWithOptions(CreateStoreGroupConversationRequest request, CreateStoreGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserId))
            {
                body["appUserId"] = request.AppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessUniqueKey))
            {
                body["businessUniqueKey"] = request.BusinessUniqueKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAvatar))
            {
                body["groupAvatar"] = request.GroupAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
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
                Action = "CreateStoreGroupConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/storeGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStoreGroupConversationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建店铺群
         *
         * @param request CreateStoreGroupConversationRequest
         * @param headers CreateStoreGroupConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateStoreGroupConversationResponse
         */
        public async Task<CreateStoreGroupConversationResponse> CreateStoreGroupConversationWithOptionsAsync(CreateStoreGroupConversationRequest request, CreateStoreGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserId))
            {
                body["appUserId"] = request.AppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessUniqueKey))
            {
                body["businessUniqueKey"] = request.BusinessUniqueKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAvatar))
            {
                body["groupAvatar"] = request.GroupAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
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
                Action = "CreateStoreGroupConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/storeGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStoreGroupConversationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建店铺群
         *
         * @param request CreateStoreGroupConversationRequest
         * @return CreateStoreGroupConversationResponse
         */
        public CreateStoreGroupConversationResponse CreateStoreGroupConversation(CreateStoreGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateStoreGroupConversationHeaders headers = new CreateStoreGroupConversationHeaders();
            return CreateStoreGroupConversationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建店铺群
         *
         * @param request CreateStoreGroupConversationRequest
         * @return CreateStoreGroupConversationResponse
         */
        public async Task<CreateStoreGroupConversationResponse> CreateStoreGroupConversationAsync(CreateStoreGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateStoreGroupConversationHeaders headers = new CreateStoreGroupConversationHeaders();
            return await CreateStoreGroupConversationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除企业文字表情
         *
         * @param request DeleteOrgTextEmotionRequest
         * @param headers DeleteOrgTextEmotionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteOrgTextEmotionResponse
         */
        public DeleteOrgTextEmotionResponse DeleteOrgTextEmotionWithOptions(DeleteOrgTextEmotionRequest request, DeleteOrgTextEmotionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmotionIds))
            {
                body["emotionIds"] = request.EmotionIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DeleteOrgTextEmotion",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/organizations/textEmotions/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOrgTextEmotionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除企业文字表情
         *
         * @param request DeleteOrgTextEmotionRequest
         * @param headers DeleteOrgTextEmotionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteOrgTextEmotionResponse
         */
        public async Task<DeleteOrgTextEmotionResponse> DeleteOrgTextEmotionWithOptionsAsync(DeleteOrgTextEmotionRequest request, DeleteOrgTextEmotionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmotionIds))
            {
                body["emotionIds"] = request.EmotionIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DeleteOrgTextEmotion",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/organizations/textEmotions/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOrgTextEmotionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除企业文字表情
         *
         * @param request DeleteOrgTextEmotionRequest
         * @return DeleteOrgTextEmotionResponse
         */
        public DeleteOrgTextEmotionResponse DeleteOrgTextEmotion(DeleteOrgTextEmotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteOrgTextEmotionHeaders headers = new DeleteOrgTextEmotionHeaders();
            return DeleteOrgTextEmotionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除企业文字表情
         *
         * @param request DeleteOrgTextEmotionRequest
         * @return DeleteOrgTextEmotionResponse
         */
        public async Task<DeleteOrgTextEmotionResponse> DeleteOrgTextEmotionAsync(DeleteOrgTextEmotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteOrgTextEmotionHeaders headers = new DeleteOrgTextEmotionHeaders();
            return await DeleteOrgTextEmotionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 解散互通群
         *
         * @param request DismissGroupConversationRequest
         * @param headers DismissGroupConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DismissGroupConversationResponse
         */
        public DismissGroupConversationResponse DismissGroupConversationWithOptions(DismissGroupConversationRequest request, DismissGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DismissGroupConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/dismiss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DismissGroupConversationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 解散互通群
         *
         * @param request DismissGroupConversationRequest
         * @param headers DismissGroupConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DismissGroupConversationResponse
         */
        public async Task<DismissGroupConversationResponse> DismissGroupConversationWithOptionsAsync(DismissGroupConversationRequest request, DismissGroupConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "DismissGroupConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/dismiss",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DismissGroupConversationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 解散互通群
         *
         * @param request DismissGroupConversationRequest
         * @return DismissGroupConversationResponse
         */
        public DismissGroupConversationResponse DismissGroupConversation(DismissGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DismissGroupConversationHeaders headers = new DismissGroupConversationHeaders();
            return DismissGroupConversationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 解散互通群
         *
         * @param request DismissGroupConversationRequest
         * @return DismissGroupConversationResponse
         */
        public async Task<DismissGroupConversationResponse> DismissGroupConversationAsync(DismissGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DismissGroupConversationHeaders headers = new DismissGroupConversationHeaders();
            return await DismissGroupConversationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建ToB会话地址
         *
         * @param request GetConversationUrlRequest
         * @param headers GetConversationUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConversationUrlResponse
         */
        public GetConversationUrlResponse GetConversationUrlWithOptions(GetConversationUrlRequest request, GetConversationUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserId))
            {
                body["appUserId"] = request.AppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCode))
            {
                body["channelCode"] = request.ChannelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "GetConversationUrl",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/urls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建ToB会话地址
         *
         * @param request GetConversationUrlRequest
         * @param headers GetConversationUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConversationUrlResponse
         */
        public async Task<GetConversationUrlResponse> GetConversationUrlWithOptionsAsync(GetConversationUrlRequest request, GetConversationUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserId))
            {
                body["appUserId"] = request.AppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCode))
            {
                body["channelCode"] = request.ChannelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "GetConversationUrl",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/urls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建ToB会话地址
         *
         * @param request GetConversationUrlRequest
         * @return GetConversationUrlResponse
         */
        public GetConversationUrlResponse GetConversationUrl(GetConversationUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationUrlHeaders headers = new GetConversationUrlHeaders();
            return GetConversationUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建ToB会话地址
         *
         * @param request GetConversationUrlRequest
         * @return GetConversationUrlResponse
         */
        public async Task<GetConversationUrlResponse> GetConversationUrlAsync(GetConversationUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationUrlHeaders headers = new GetConversationUrlHeaders();
            return await GetConversationUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户家校群消息(图片&视频Z&富文本)
         *
         * @param request GetFamilySchoolConversationMsgRequest
         * @param headers GetFamilySchoolConversationMsgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFamilySchoolConversationMsgResponse
         */
        public GetFamilySchoolConversationMsgResponse GetFamilySchoolConversationMsgWithOptions(GetFamilySchoolConversationMsgRequest request, GetFamilySchoolConversationMsgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgTypes))
            {
                body["msgTypes"] = request.MsgTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFamilySchoolConversationMsg",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/familySchools/messages/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFamilySchoolConversationMsgResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询用户家校群消息(图片&视频Z&富文本)
         *
         * @param request GetFamilySchoolConversationMsgRequest
         * @param headers GetFamilySchoolConversationMsgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFamilySchoolConversationMsgResponse
         */
        public async Task<GetFamilySchoolConversationMsgResponse> GetFamilySchoolConversationMsgWithOptionsAsync(GetFamilySchoolConversationMsgRequest request, GetFamilySchoolConversationMsgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgTypes))
            {
                body["msgTypes"] = request.MsgTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFamilySchoolConversationMsg",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/familySchools/messages/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFamilySchoolConversationMsgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户家校群消息(图片&视频Z&富文本)
         *
         * @param request GetFamilySchoolConversationMsgRequest
         * @return GetFamilySchoolConversationMsgResponse
         */
        public GetFamilySchoolConversationMsgResponse GetFamilySchoolConversationMsg(GetFamilySchoolConversationMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFamilySchoolConversationMsgHeaders headers = new GetFamilySchoolConversationMsgHeaders();
            return GetFamilySchoolConversationMsgWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户家校群消息(图片&视频Z&富文本)
         *
         * @param request GetFamilySchoolConversationMsgRequest
         * @return GetFamilySchoolConversationMsgResponse
         */
        public async Task<GetFamilySchoolConversationMsgResponse> GetFamilySchoolConversationMsgAsync(GetFamilySchoolConversationMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFamilySchoolConversationMsgHeaders headers = new GetFamilySchoolConversationMsgHeaders();
            return await GetFamilySchoolConversationMsgWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户家校群
         *
         * @param request GetFamilySchoolConversationsRequest
         * @param headers GetFamilySchoolConversationsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFamilySchoolConversationsResponse
         */
        public GetFamilySchoolConversationsResponse GetFamilySchoolConversationsWithOptions(GetFamilySchoolConversationsRequest request, GetFamilySchoolConversationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFamilySchoolConversations",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/familySchools/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFamilySchoolConversationsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询用户家校群
         *
         * @param request GetFamilySchoolConversationsRequest
         * @param headers GetFamilySchoolConversationsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFamilySchoolConversationsResponse
         */
        public async Task<GetFamilySchoolConversationsResponse> GetFamilySchoolConversationsWithOptionsAsync(GetFamilySchoolConversationsRequest request, GetFamilySchoolConversationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFamilySchoolConversations",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/familySchools/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFamilySchoolConversationsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户家校群
         *
         * @param request GetFamilySchoolConversationsRequest
         * @return GetFamilySchoolConversationsResponse
         */
        public GetFamilySchoolConversationsResponse GetFamilySchoolConversations(GetFamilySchoolConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFamilySchoolConversationsHeaders headers = new GetFamilySchoolConversationsHeaders();
            return GetFamilySchoolConversationsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户家校群
         *
         * @param request GetFamilySchoolConversationsRequest
         * @return GetFamilySchoolConversationsResponse
         */
        public async Task<GetFamilySchoolConversationsResponse> GetFamilySchoolConversationsAsync(GetFamilySchoolConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFamilySchoolConversationsHeaders headers = new GetFamilySchoolConversationsHeaders();
            return await GetFamilySchoolConversationsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询企业内部群成员
         *
         * @param request GetInnerGroupMembersRequest
         * @param headers GetInnerGroupMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInnerGroupMembersResponse
         */
        public GetInnerGroupMembersResponse GetInnerGroupMembersWithOptions(GetInnerGroupMembersRequest request, GetInnerGroupMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "GetInnerGroupMembers",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInnerGroupMembersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询企业内部群成员
         *
         * @param request GetInnerGroupMembersRequest
         * @param headers GetInnerGroupMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInnerGroupMembersResponse
         */
        public async Task<GetInnerGroupMembersResponse> GetInnerGroupMembersWithOptionsAsync(GetInnerGroupMembersRequest request, GetInnerGroupMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "GetInnerGroupMembers",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInnerGroupMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询企业内部群成员
         *
         * @param request GetInnerGroupMembersRequest
         * @return GetInnerGroupMembersResponse
         */
        public GetInnerGroupMembersResponse GetInnerGroupMembers(GetInnerGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInnerGroupMembersHeaders headers = new GetInnerGroupMembersHeaders();
            return GetInnerGroupMembersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询企业内部群成员
         *
         * @param request GetInnerGroupMembersRequest
         * @return GetInnerGroupMembersResponse
         */
        public async Task<GetInnerGroupMembersResponse> GetInnerGroupMembersAsync(GetInnerGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInnerGroupMembersHeaders headers = new GetInnerGroupMembersHeaders();
            return await GetInnerGroupMembersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建客联互通会话地址
         *
         * @param request GetInterconnectionUrlRequest
         * @param headers GetInterconnectionUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInterconnectionUrlResponse
         */
        public GetInterconnectionUrlResponse GetInterconnectionUrlWithOptions(GetInterconnectionUrlRequest request, GetInterconnectionUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserAvatar))
            {
                body["appUserAvatar"] = request.AppUserAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserAvatarType))
            {
                body["appUserAvatarType"] = request.AppUserAvatarType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserId))
            {
                body["appUserId"] = request.AppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserMobileNumber))
            {
                body["appUserMobileNumber"] = request.AppUserMobileNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserName))
            {
                body["appUserName"] = request.AppUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgPageType))
            {
                body["msgPageType"] = request.MsgPageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QrCode))
            {
                body["qrCode"] = request.QrCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCode))
            {
                body["sourceCode"] = request.SourceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
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
                Action = "GetInterconnectionUrl",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/sessions/urls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInterconnectionUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建客联互通会话地址
         *
         * @param request GetInterconnectionUrlRequest
         * @param headers GetInterconnectionUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInterconnectionUrlResponse
         */
        public async Task<GetInterconnectionUrlResponse> GetInterconnectionUrlWithOptionsAsync(GetInterconnectionUrlRequest request, GetInterconnectionUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserAvatar))
            {
                body["appUserAvatar"] = request.AppUserAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserAvatarType))
            {
                body["appUserAvatarType"] = request.AppUserAvatarType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserId))
            {
                body["appUserId"] = request.AppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserMobileNumber))
            {
                body["appUserMobileNumber"] = request.AppUserMobileNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserName))
            {
                body["appUserName"] = request.AppUserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgPageType))
            {
                body["msgPageType"] = request.MsgPageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QrCode))
            {
                body["qrCode"] = request.QrCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCode))
            {
                body["sourceCode"] = request.SourceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["sourceType"] = request.SourceType;
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
                Action = "GetInterconnectionUrl",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/sessions/urls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInterconnectionUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建客联互通会话地址
         *
         * @param request GetInterconnectionUrlRequest
         * @return GetInterconnectionUrlResponse
         */
        public GetInterconnectionUrlResponse GetInterconnectionUrl(GetInterconnectionUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInterconnectionUrlHeaders headers = new GetInterconnectionUrlHeaders();
            return GetInterconnectionUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建客联互通会话地址
         *
         * @param request GetInterconnectionUrlRequest
         * @return GetInterconnectionUrlResponse
         */
        public async Task<GetInterconnectionUrlResponse> GetInterconnectionUrlAsync(GetInterconnectionUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInterconnectionUrlHeaders headers = new GetInterconnectionUrlHeaders();
            return await GetInterconnectionUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询最近活跃的企业内部群列表
         *
         * @param request GetNewestInnerGroupsRequest
         * @param headers GetNewestInnerGroupsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNewestInnerGroupsResponse
         */
        public GetNewestInnerGroupsResponse GetNewestInnerGroupsWithOptions(GetNewestInnerGroupsRequest request, GetNewestInnerGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetNewestInnerGroups",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/activities/innerGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNewestInnerGroupsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询最近活跃的企业内部群列表
         *
         * @param request GetNewestInnerGroupsRequest
         * @param headers GetNewestInnerGroupsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNewestInnerGroupsResponse
         */
        public async Task<GetNewestInnerGroupsResponse> GetNewestInnerGroupsWithOptionsAsync(GetNewestInnerGroupsRequest request, GetNewestInnerGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetNewestInnerGroups",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/activities/innerGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNewestInnerGroupsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询最近活跃的企业内部群列表
         *
         * @param request GetNewestInnerGroupsRequest
         * @return GetNewestInnerGroupsResponse
         */
        public GetNewestInnerGroupsResponse GetNewestInnerGroups(GetNewestInnerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNewestInnerGroupsHeaders headers = new GetNewestInnerGroupsHeaders();
            return GetNewestInnerGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询最近活跃的企业内部群列表
         *
         * @param request GetNewestInnerGroupsRequest
         * @return GetNewestInnerGroupsResponse
         */
        public async Task<GetNewestInnerGroupsResponse> GetNewestInnerGroupsAsync(GetNewestInnerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNewestInnerGroupsHeaders headers = new GetNewestInnerGroupsHeaders();
            return await GetNewestInnerGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询群简要信息
         *
         * @param request GetSceneGroupInfoRequest
         * @param headers GetSceneGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSceneGroupInfoResponse
         */
        public GetSceneGroupInfoResponse GetSceneGroupInfoWithOptions(GetSceneGroupInfoRequest request, GetSceneGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSceneGroupInfo",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSceneGroupInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询群简要信息
         *
         * @param request GetSceneGroupInfoRequest
         * @param headers GetSceneGroupInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSceneGroupInfoResponse
         */
        public async Task<GetSceneGroupInfoResponse> GetSceneGroupInfoWithOptionsAsync(GetSceneGroupInfoRequest request, GetSceneGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSceneGroupInfo",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSceneGroupInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询群简要信息
         *
         * @param request GetSceneGroupInfoRequest
         * @return GetSceneGroupInfoResponse
         */
        public GetSceneGroupInfoResponse GetSceneGroupInfo(GetSceneGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSceneGroupInfoHeaders headers = new GetSceneGroupInfoHeaders();
            return GetSceneGroupInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询群简要信息
         *
         * @param request GetSceneGroupInfoRequest
         * @return GetSceneGroupInfoResponse
         */
        public async Task<GetSceneGroupInfoResponse> GetSceneGroupInfoAsync(GetSceneGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSceneGroupInfoHeaders headers = new GetSceneGroupInfoHeaders();
            return await GetSceneGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询群成员
         *
         * @param request GetSceneGroupMembersRequest
         * @param headers GetSceneGroupMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSceneGroupMembersResponse
         */
        public GetSceneGroupMembersResponse GetSceneGroupMembersWithOptions(GetSceneGroupMembersRequest request, GetSceneGroupMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSceneGroupMembers",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSceneGroupMembersResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询群成员
         *
         * @param request GetSceneGroupMembersRequest
         * @param headers GetSceneGroupMembersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSceneGroupMembersResponse
         */
        public async Task<GetSceneGroupMembersResponse> GetSceneGroupMembersWithOptionsAsync(GetSceneGroupMembersRequest request, GetSceneGroupMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSceneGroupMembers",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSceneGroupMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询群成员
         *
         * @param request GetSceneGroupMembersRequest
         * @return GetSceneGroupMembersResponse
         */
        public GetSceneGroupMembersResponse GetSceneGroupMembers(GetSceneGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSceneGroupMembersHeaders headers = new GetSceneGroupMembersHeaders();
            return GetSceneGroupMembersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询群成员
         *
         * @param request GetSceneGroupMembersRequest
         * @return GetSceneGroupMembersResponse
         */
        public async Task<GetSceneGroupMembersResponse> GetSceneGroupMembersAsync(GetSceneGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSceneGroupMembersHeaders headers = new GetSceneGroupMembersHeaders();
            return await GetSceneGroupMembersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 群禁言
         *
         * @param request GroupBanWordsRequest
         * @param headers GroupBanWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupBanWordsResponse
         */
        public GroupBanWordsResponse GroupBanWordsWithOptions(GroupBanWordsRequest request, GroupBanWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BanWordsMode))
            {
                body["banWordsMode"] = request.BanWordsMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupBanWords",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/words/ban",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<GroupBanWordsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 群禁言
         *
         * @param request GroupBanWordsRequest
         * @param headers GroupBanWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupBanWordsResponse
         */
        public async Task<GroupBanWordsResponse> GroupBanWordsWithOptionsAsync(GroupBanWordsRequest request, GroupBanWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BanWordsMode))
            {
                body["banWordsMode"] = request.BanWordsMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupBanWords",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/words/ban",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<GroupBanWordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 群禁言
         *
         * @param request GroupBanWordsRequest
         * @return GroupBanWordsResponse
         */
        public GroupBanWordsResponse GroupBanWords(GroupBanWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupBanWordsHeaders headers = new GroupBanWordsHeaders();
            return GroupBanWordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 群禁言
         *
         * @param request GroupBanWordsRequest
         * @return GroupBanWordsResponse
         */
        public async Task<GroupBanWordsResponse> GroupBanWordsAsync(GroupBanWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupBanWordsHeaders headers = new GroupBanWordsHeaders();
            return await GroupBanWordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 群容量扩容询价
         *
         * @param request GroupCapacityInquiryRequest
         * @param headers GroupCapacityInquiryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupCapacityInquiryResponse
         */
        public GroupCapacityInquiryResponse GroupCapacityInquiryWithOptions(GroupCapacityInquiryRequest request, GroupCapacityInquiryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDuration))
            {
                body["effectiveDuration"] = request.EffectiveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCapacity))
            {
                body["targetCapacity"] = request.TargetCapacity;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupCapacityInquiry",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/capacities/inquiries/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupCapacityInquiryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 群容量扩容询价
         *
         * @param request GroupCapacityInquiryRequest
         * @param headers GroupCapacityInquiryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupCapacityInquiryResponse
         */
        public async Task<GroupCapacityInquiryResponse> GroupCapacityInquiryWithOptionsAsync(GroupCapacityInquiryRequest request, GroupCapacityInquiryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectiveDuration))
            {
                body["effectiveDuration"] = request.EffectiveDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCapacity))
            {
                body["targetCapacity"] = request.TargetCapacity;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupCapacityInquiry",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/capacities/inquiries/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupCapacityInquiryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 群容量扩容询价
         *
         * @param request GroupCapacityInquiryRequest
         * @return GroupCapacityInquiryResponse
         */
        public GroupCapacityInquiryResponse GroupCapacityInquiry(GroupCapacityInquiryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityInquiryHeaders headers = new GroupCapacityInquiryHeaders();
            return GroupCapacityInquiryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 群容量扩容询价
         *
         * @param request GroupCapacityInquiryRequest
         * @return GroupCapacityInquiryResponse
         */
        public async Task<GroupCapacityInquiryResponse> GroupCapacityInquiryAsync(GroupCapacityInquiryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityInquiryHeaders headers = new GroupCapacityInquiryHeaders();
            return await GroupCapacityInquiryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 群容量扩容确认下单
         *
         * @param request GroupCapacityOrderConfirmRequest
         * @param headers GroupCapacityOrderConfirmHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupCapacityOrderConfirmResponse
         */
        public GroupCapacityOrderConfirmResponse GroupCapacityOrderConfirmWithOptions(GroupCapacityOrderConfirmRequest request, GroupCapacityOrderConfirmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupCapacityOrderConfirm",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/capacities/orders/confirm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupCapacityOrderConfirmResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 群容量扩容确认下单
         *
         * @param request GroupCapacityOrderConfirmRequest
         * @param headers GroupCapacityOrderConfirmHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupCapacityOrderConfirmResponse
         */
        public async Task<GroupCapacityOrderConfirmResponse> GroupCapacityOrderConfirmWithOptionsAsync(GroupCapacityOrderConfirmRequest request, GroupCapacityOrderConfirmHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupCapacityOrderConfirm",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/capacities/orders/confirm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupCapacityOrderConfirmResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 群容量扩容确认下单
         *
         * @param request GroupCapacityOrderConfirmRequest
         * @return GroupCapacityOrderConfirmResponse
         */
        public GroupCapacityOrderConfirmResponse GroupCapacityOrderConfirm(GroupCapacityOrderConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityOrderConfirmHeaders headers = new GroupCapacityOrderConfirmHeaders();
            return GroupCapacityOrderConfirmWithOptions(request, headers, runtime);
        }

        /**
         * @summary 群容量扩容确认下单
         *
         * @param request GroupCapacityOrderConfirmRequest
         * @return GroupCapacityOrderConfirmResponse
         */
        public async Task<GroupCapacityOrderConfirmResponse> GroupCapacityOrderConfirmAsync(GroupCapacityOrderConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityOrderConfirmHeaders headers = new GroupCapacityOrderConfirmHeaders();
            return await GroupCapacityOrderConfirmWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 群容量请求扩容下单
         *
         * @param request GroupCapacityOrderPlaceRequest
         * @param headers GroupCapacityOrderPlaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupCapacityOrderPlaceResponse
         */
        public GroupCapacityOrderPlaceResponse GroupCapacityOrderPlaceWithOptions(GroupCapacityOrderPlaceRequest request, GroupCapacityOrderPlaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualPrice))
            {
                body["actualPrice"] = request.ActualPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentCapacity))
            {
                body["currentCapacity"] = request.CurrentCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentEffectUntil))
            {
                body["currentEffectUntil"] = request.CurrentEffectUntil;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Discount))
            {
                body["discount"] = request.Discount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["extInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkedPrice))
            {
                body["markedPrice"] = request.MarkedPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCapacity))
            {
                body["targetCapacity"] = request.TargetCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetEffectUntil))
            {
                body["targetEffectUntil"] = request.TargetEffectUntil;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupCapacityOrderPlace",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/capacities/orders/place",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupCapacityOrderPlaceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 群容量请求扩容下单
         *
         * @param request GroupCapacityOrderPlaceRequest
         * @param headers GroupCapacityOrderPlaceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupCapacityOrderPlaceResponse
         */
        public async Task<GroupCapacityOrderPlaceResponse> GroupCapacityOrderPlaceWithOptionsAsync(GroupCapacityOrderPlaceRequest request, GroupCapacityOrderPlaceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualPrice))
            {
                body["actualPrice"] = request.ActualPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentCapacity))
            {
                body["currentCapacity"] = request.CurrentCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentEffectUntil))
            {
                body["currentEffectUntil"] = request.CurrentEffectUntil;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Discount))
            {
                body["discount"] = request.Discount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["extInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkedPrice))
            {
                body["markedPrice"] = request.MarkedPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCapacity))
            {
                body["targetCapacity"] = request.TargetCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetEffectUntil))
            {
                body["targetEffectUntil"] = request.TargetEffectUntil;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["token"] = request.Token;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupCapacityOrderPlace",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/capacities/orders/place",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupCapacityOrderPlaceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 群容量请求扩容下单
         *
         * @param request GroupCapacityOrderPlaceRequest
         * @return GroupCapacityOrderPlaceResponse
         */
        public GroupCapacityOrderPlaceResponse GroupCapacityOrderPlace(GroupCapacityOrderPlaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityOrderPlaceHeaders headers = new GroupCapacityOrderPlaceHeaders();
            return GroupCapacityOrderPlaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 群容量请求扩容下单
         *
         * @param request GroupCapacityOrderPlaceRequest
         * @return GroupCapacityOrderPlaceResponse
         */
        public async Task<GroupCapacityOrderPlaceResponse> GroupCapacityOrderPlaceAsync(GroupCapacityOrderPlaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityOrderPlaceHeaders headers = new GroupCapacityOrderPlaceHeaders();
            return await GroupCapacityOrderPlaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据群链接、群号等检索条件，查询群信息
         *
         * @param request GroupManageQueryRequest
         * @param headers GroupManageQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupManageQueryResponse
         */
        public GroupManageQueryResponse GroupManageQueryWithOptions(GroupManageQueryRequest request, GroupManageQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedAfter))
            {
                body["createdAfter"] = request.CreatedAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMemberSamples))
            {
                body["groupMemberSamples"] = request.GroupMemberSamples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwner))
            {
                body["groupOwner"] = request.GroupOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTitleKeywords))
            {
                body["groupTitleKeywords"] = request.GroupTitleKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUrl))
            {
                body["groupUrl"] = request.GroupUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersOver))
            {
                body["membersOver"] = request.MembersOver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupManageQuery",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/managements/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupManageQueryResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据群链接、群号等检索条件，查询群信息
         *
         * @param request GroupManageQueryRequest
         * @param headers GroupManageQueryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupManageQueryResponse
         */
        public async Task<GroupManageQueryResponse> GroupManageQueryWithOptionsAsync(GroupManageQueryRequest request, GroupManageQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedAfter))
            {
                body["createdAfter"] = request.CreatedAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMemberSamples))
            {
                body["groupMemberSamples"] = request.GroupMemberSamples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupOwner))
            {
                body["groupOwner"] = request.GroupOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTitleKeywords))
            {
                body["groupTitleKeywords"] = request.GroupTitleKeywords;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUrl))
            {
                body["groupUrl"] = request.GroupUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MembersOver))
            {
                body["membersOver"] = request.MembersOver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupManageQuery",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/managements/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GroupManageQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据群链接、群号等检索条件，查询群信息
         *
         * @param request GroupManageQueryRequest
         * @return GroupManageQueryResponse
         */
        public GroupManageQueryResponse GroupManageQuery(GroupManageQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupManageQueryHeaders headers = new GroupManageQueryHeaders();
            return GroupManageQueryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据群链接、群号等检索条件，查询群信息
         *
         * @param request GroupManageQueryRequest
         * @return GroupManageQueryResponse
         */
        public async Task<GroupManageQueryResponse> GroupManageQueryAsync(GroupManageQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupManageQueryHeaders headers = new GroupManageQueryHeaders();
            return await GroupManageQueryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 群管理缩容
         *
         * @param request GroupManageReduceRequest
         * @param headers GroupManageReduceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupManageReduceResponse
         */
        public GroupManageReduceResponse GroupManageReduceWithOptions(GroupManageReduceRequest request, GroupManageReduceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CapacityLimit))
            {
                body["capacityLimit"] = request.CapacityLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupManageReduce",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/capacities/reduce",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<GroupManageReduceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 群管理缩容
         *
         * @param request GroupManageReduceRequest
         * @param headers GroupManageReduceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GroupManageReduceResponse
         */
        public async Task<GroupManageReduceResponse> GroupManageReduceWithOptionsAsync(GroupManageReduceRequest request, GroupManageReduceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CapacityLimit))
            {
                body["capacityLimit"] = request.CapacityLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GroupManageReduce",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/capacities/reduce",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<GroupManageReduceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 群管理缩容
         *
         * @param request GroupManageReduceRequest
         * @return GroupManageReduceResponse
         */
        public GroupManageReduceResponse GroupManageReduce(GroupManageReduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupManageReduceHeaders headers = new GroupManageReduceHeaders();
            return GroupManageReduceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 群管理缩容
         *
         * @param request GroupManageReduceRequest
         * @return GroupManageReduceResponse
         */
        public async Task<GroupManageReduceResponse> GroupManageReduceAsync(GroupManageReduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupManageReduceHeaders headers = new GroupManageReduceHeaders();
            return await GroupManageReduceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 安装机器人到组织
         *
         * @param request InstallRobotToOrgRequest
         * @param headers InstallRobotToOrgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallRobotToOrgResponse
         */
        public InstallRobotToOrgResponse InstallRobotToOrgWithOptions(InstallRobotToOrgRequest request, InstallRobotToOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brief))
            {
                body["brief"] = request.Brief;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutgoingToken))
            {
                body["outgoingToken"] = request.OutgoingToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutgoingUrl))
            {
                body["outgoingUrl"] = request.OutgoingUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewMediaId))
            {
                body["previewMediaId"] = request.PreviewMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InstallRobotToOrg",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/organizations/robots/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallRobotToOrgResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 安装机器人到组织
         *
         * @param request InstallRobotToOrgRequest
         * @param headers InstallRobotToOrgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallRobotToOrgResponse
         */
        public async Task<InstallRobotToOrgResponse> InstallRobotToOrgWithOptionsAsync(InstallRobotToOrgRequest request, InstallRobotToOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brief))
            {
                body["brief"] = request.Brief;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutgoingToken))
            {
                body["outgoingToken"] = request.OutgoingToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutgoingUrl))
            {
                body["outgoingUrl"] = request.OutgoingUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewMediaId))
            {
                body["previewMediaId"] = request.PreviewMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InstallRobotToOrg",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/organizations/robots/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallRobotToOrgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 安装机器人到组织
         *
         * @param request InstallRobotToOrgRequest
         * @return InstallRobotToOrgResponse
         */
        public InstallRobotToOrgResponse InstallRobotToOrg(InstallRobotToOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallRobotToOrgHeaders headers = new InstallRobotToOrgHeaders();
            return InstallRobotToOrgWithOptions(request, headers, runtime);
        }

        /**
         * @summary 安装机器人到组织
         *
         * @param request InstallRobotToOrgRequest
         * @return InstallRobotToOrgResponse
         */
        public async Task<InstallRobotToOrgResponse> InstallRobotToOrgAsync(InstallRobotToOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallRobotToOrgHeaders headers = new InstallRobotToOrgHeaders();
            return await InstallRobotToOrgWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建可交互式实例
         *
         * @param request InteractiveCardCreateInstanceRequest
         * @param headers InteractiveCardCreateInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InteractiveCardCreateInstanceResponse
         */
        public InteractiveCardCreateInstanceResponse InteractiveCardCreateInstanceWithOptions(InteractiveCardCreateInstanceRequest request, InteractiveCardCreateInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatBotId))
            {
                body["chatBotId"] = request.ChatBotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullStrategy))
            {
                body["pullStrategy"] = request.PullStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InteractiveCardCreateInstance",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interactiveCards/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InteractiveCardCreateInstanceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建可交互式实例
         *
         * @param request InteractiveCardCreateInstanceRequest
         * @param headers InteractiveCardCreateInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InteractiveCardCreateInstanceResponse
         */
        public async Task<InteractiveCardCreateInstanceResponse> InteractiveCardCreateInstanceWithOptionsAsync(InteractiveCardCreateInstanceRequest request, InteractiveCardCreateInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatBotId))
            {
                body["chatBotId"] = request.ChatBotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullStrategy))
            {
                body["pullStrategy"] = request.PullStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "InteractiveCardCreateInstance",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interactiveCards/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InteractiveCardCreateInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建可交互式实例
         *
         * @param request InteractiveCardCreateInstanceRequest
         * @return InteractiveCardCreateInstanceResponse
         */
        public InteractiveCardCreateInstanceResponse InteractiveCardCreateInstance(InteractiveCardCreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InteractiveCardCreateInstanceHeaders headers = new InteractiveCardCreateInstanceHeaders();
            return InteractiveCardCreateInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建可交互式实例
         *
         * @param request InteractiveCardCreateInstanceRequest
         * @return InteractiveCardCreateInstanceResponse
         */
        public async Task<InteractiveCardCreateInstanceResponse> InteractiveCardCreateInstanceAsync(InteractiveCardCreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InteractiveCardCreateInstanceHeaders headers = new InteractiveCardCreateInstanceHeaders();
            return await InteractiveCardCreateInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
         *
         * @param headers ListOrgTextEmotionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrgTextEmotionResponse
         */
        public ListOrgTextEmotionResponse ListOrgTextEmotionWithOptions(ListOrgTextEmotionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListOrgTextEmotion",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/organizations/textEmotions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrgTextEmotionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
         *
         * @param headers ListOrgTextEmotionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrgTextEmotionResponse
         */
        public async Task<ListOrgTextEmotionResponse> ListOrgTextEmotionWithOptionsAsync(ListOrgTextEmotionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListOrgTextEmotion",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/organizations/textEmotions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrgTextEmotionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
         *
         * @return ListOrgTextEmotionResponse
         */
        public ListOrgTextEmotionResponse ListOrgTextEmotion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrgTextEmotionHeaders headers = new ListOrgTextEmotionHeaders();
            return ListOrgTextEmotionWithOptions(headers, runtime);
        }

        /**
         * @summary 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
         *
         * @return ListOrgTextEmotionResponse
         */
        public async Task<ListOrgTextEmotionResponse> ListOrgTextEmotionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrgTextEmotionHeaders headers = new ListOrgTextEmotionHeaders();
            return await ListOrgTextEmotionWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 成员授权场景下查询群信息
         *
         * @param request QueryGroupInfoByMemberAuthRequest
         * @param headers QueryGroupInfoByMemberAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupInfoByMemberAuthResponse
         */
        public QueryGroupInfoByMemberAuthResponse QueryGroupInfoByMemberAuthWithOptions(QueryGroupInfoByMemberAuthRequest request, QueryGroupInfoByMemberAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryGroupInfoByMemberAuth",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/memberAuthorizations/groups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupInfoByMemberAuthResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 成员授权场景下查询群信息
         *
         * @param request QueryGroupInfoByMemberAuthRequest
         * @param headers QueryGroupInfoByMemberAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupInfoByMemberAuthResponse
         */
        public async Task<QueryGroupInfoByMemberAuthResponse> QueryGroupInfoByMemberAuthWithOptionsAsync(QueryGroupInfoByMemberAuthRequest request, QueryGroupInfoByMemberAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryGroupInfoByMemberAuth",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/memberAuthorizations/groups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupInfoByMemberAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 成员授权场景下查询群信息
         *
         * @param request QueryGroupInfoByMemberAuthRequest
         * @return QueryGroupInfoByMemberAuthResponse
         */
        public QueryGroupInfoByMemberAuthResponse QueryGroupInfoByMemberAuth(QueryGroupInfoByMemberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupInfoByMemberAuthHeaders headers = new QueryGroupInfoByMemberAuthHeaders();
            return QueryGroupInfoByMemberAuthWithOptions(request, headers, runtime);
        }

        /**
         * @summary 成员授权场景下查询群信息
         *
         * @param request QueryGroupInfoByMemberAuthRequest
         * @return QueryGroupInfoByMemberAuthResponse
         */
        public async Task<QueryGroupInfoByMemberAuthResponse> QueryGroupInfoByMemberAuthAsync(QueryGroupInfoByMemberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupInfoByMemberAuthHeaders headers = new QueryGroupInfoByMemberAuthHeaders();
            return await QueryGroupInfoByMemberAuthWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询群成员列表
         *
         * @param request QueryGroupMemberRequest
         * @param headers QueryGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupMemberResponse
         */
        public QueryGroupMemberResponse QueryGroupMemberWithOptions(QueryGroupMemberRequest request, QueryGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/conversations/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询群成员列表
         *
         * @param request QueryGroupMemberRequest
         * @param headers QueryGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupMemberResponse
         */
        public async Task<QueryGroupMemberResponse> QueryGroupMemberWithOptionsAsync(QueryGroupMemberRequest request, QueryGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/conversations/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询群成员列表
         *
         * @param request QueryGroupMemberRequest
         * @return QueryGroupMemberResponse
         */
        public QueryGroupMemberResponse QueryGroupMember(QueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMemberHeaders headers = new QueryGroupMemberHeaders();
            return QueryGroupMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询群成员列表
         *
         * @param request QueryGroupMemberRequest
         * @return QueryGroupMemberResponse
         */
        public async Task<QueryGroupMemberResponse> QueryGroupMemberAsync(QueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMemberHeaders headers = new QueryGroupMemberHeaders();
            return await QueryGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 成员授权场景下查询群成员
         *
         * @param request QueryGroupMemberByMemberAuthRequest
         * @param headers QueryGroupMemberByMemberAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupMemberByMemberAuthResponse
         */
        public QueryGroupMemberByMemberAuthResponse QueryGroupMemberByMemberAuthWithOptions(QueryGroupMemberByMemberAuthRequest request, QueryGroupMemberByMemberAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryGroupMemberByMemberAuth",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/memberAuthorizations/groups/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupMemberByMemberAuthResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 成员授权场景下查询群成员
         *
         * @param request QueryGroupMemberByMemberAuthRequest
         * @param headers QueryGroupMemberByMemberAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupMemberByMemberAuthResponse
         */
        public async Task<QueryGroupMemberByMemberAuthResponse> QueryGroupMemberByMemberAuthWithOptionsAsync(QueryGroupMemberByMemberAuthRequest request, QueryGroupMemberByMemberAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryGroupMemberByMemberAuth",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/memberAuthorizations/groups/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupMemberByMemberAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 成员授权场景下查询群成员
         *
         * @param request QueryGroupMemberByMemberAuthRequest
         * @return QueryGroupMemberByMemberAuthResponse
         */
        public QueryGroupMemberByMemberAuthResponse QueryGroupMemberByMemberAuth(QueryGroupMemberByMemberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMemberByMemberAuthHeaders headers = new QueryGroupMemberByMemberAuthHeaders();
            return QueryGroupMemberByMemberAuthWithOptions(request, headers, runtime);
        }

        /**
         * @summary 成员授权场景下查询群成员
         *
         * @param request QueryGroupMemberByMemberAuthRequest
         * @return QueryGroupMemberByMemberAuthResponse
         */
        public async Task<QueryGroupMemberByMemberAuthResponse> QueryGroupMemberByMemberAuthAsync(QueryGroupMemberByMemberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMemberByMemberAuthHeaders headers = new QueryGroupMemberByMemberAuthHeaders();
            return await QueryGroupMemberByMemberAuthWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询群禁言状态
         *
         * @param request QueryGroupMuteStatusRequest
         * @param headers QueryGroupMuteStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupMuteStatusResponse
         */
        public QueryGroupMuteStatusResponse QueryGroupMuteStatusWithOptions(QueryGroupMuteStatusRequest request, QueryGroupMuteStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryGroupMuteStatus",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/muteSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupMuteStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询群禁言状态
         *
         * @param request QueryGroupMuteStatusRequest
         * @param headers QueryGroupMuteStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryGroupMuteStatusResponse
         */
        public async Task<QueryGroupMuteStatusResponse> QueryGroupMuteStatusWithOptionsAsync(QueryGroupMuteStatusRequest request, QueryGroupMuteStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryGroupMuteStatus",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/muteSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupMuteStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询群禁言状态
         *
         * @param request QueryGroupMuteStatusRequest
         * @return QueryGroupMuteStatusResponse
         */
        public QueryGroupMuteStatusResponse QueryGroupMuteStatus(QueryGroupMuteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMuteStatusHeaders headers = new QueryGroupMuteStatusHeaders();
            return QueryGroupMuteStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询群禁言状态
         *
         * @param request QueryGroupMuteStatusRequest
         * @return QueryGroupMuteStatusResponse
         */
        public async Task<QueryGroupMuteStatusResponse> QueryGroupMuteStatusAsync(QueryGroupMuteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMuteStatusHeaders headers = new QueryGroupMuteStatusHeaders();
            return await QueryGroupMuteStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询群内具有指定群角色的所有群成员
         *
         * @param request QueryMembersOfGroupRoleRequest
         * @param headers QueryMembersOfGroupRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMembersOfGroupRoleResponse
         */
        public QueryMembersOfGroupRoleResponse QueryMembersOfGroupRoleWithOptions(QueryMembersOfGroupRoleRequest request, QueryMembersOfGroupRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenRoleId))
            {
                body["openRoleId"] = request.OpenRoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                body["timestamp"] = request.Timestamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryMembersOfGroupRole",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/roles/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMembersOfGroupRoleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询群内具有指定群角色的所有群成员
         *
         * @param request QueryMembersOfGroupRoleRequest
         * @param headers QueryMembersOfGroupRoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMembersOfGroupRoleResponse
         */
        public async Task<QueryMembersOfGroupRoleResponse> QueryMembersOfGroupRoleWithOptionsAsync(QueryMembersOfGroupRoleRequest request, QueryMembersOfGroupRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenRoleId))
            {
                body["openRoleId"] = request.OpenRoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                body["timestamp"] = request.Timestamp;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryMembersOfGroupRole",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/roles/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMembersOfGroupRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询群内具有指定群角色的所有群成员
         *
         * @param request QueryMembersOfGroupRoleRequest
         * @return QueryMembersOfGroupRoleResponse
         */
        public QueryMembersOfGroupRoleResponse QueryMembersOfGroupRole(QueryMembersOfGroupRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMembersOfGroupRoleHeaders headers = new QueryMembersOfGroupRoleHeaders();
            return QueryMembersOfGroupRoleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询群内具有指定群角色的所有群成员
         *
         * @param request QueryMembersOfGroupRoleRequest
         * @return QueryMembersOfGroupRoleResponse
         */
        public async Task<QueryMembersOfGroupRoleResponse> QueryMembersOfGroupRoleAsync(QueryMembersOfGroupRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMembersOfGroupRoleHeaders headers = new QueryMembersOfGroupRoleHeaders();
            return await QueryMembersOfGroupRoleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询群内群模板机器人
         *
         * @param request QuerySceneGroupTemplateRobotRequest
         * @param headers QuerySceneGroupTemplateRobotHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySceneGroupTemplateRobotResponse
         */
        public QuerySceneGroupTemplateRobotResponse QuerySceneGroupTemplateRobotWithOptions(QuerySceneGroupTemplateRobotRequest request, QuerySceneGroupTemplateRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                query["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QuerySceneGroupTemplateRobot",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/templates/robots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySceneGroupTemplateRobotResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询群内群模板机器人
         *
         * @param request QuerySceneGroupTemplateRobotRequest
         * @param headers QuerySceneGroupTemplateRobotHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySceneGroupTemplateRobotResponse
         */
        public async Task<QuerySceneGroupTemplateRobotResponse> QuerySceneGroupTemplateRobotWithOptionsAsync(QuerySceneGroupTemplateRobotRequest request, QuerySceneGroupTemplateRobotHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                query["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QuerySceneGroupTemplateRobot",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/templates/robots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySceneGroupTemplateRobotResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询群内群模板机器人
         *
         * @param request QuerySceneGroupTemplateRobotRequest
         * @return QuerySceneGroupTemplateRobotResponse
         */
        public QuerySceneGroupTemplateRobotResponse QuerySceneGroupTemplateRobot(QuerySceneGroupTemplateRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySceneGroupTemplateRobotHeaders headers = new QuerySceneGroupTemplateRobotHeaders();
            return QuerySceneGroupTemplateRobotWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询群内群模板机器人
         *
         * @param request QuerySceneGroupTemplateRobotRequest
         * @return QuerySceneGroupTemplateRobotResponse
         */
        public async Task<QuerySceneGroupTemplateRobotResponse> QuerySceneGroupTemplateRobotAsync(QuerySceneGroupTemplateRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySceneGroupTemplateRobotHeaders headers = new QuerySceneGroupTemplateRobotHeaders();
            return await QuerySceneGroupTemplateRobotWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询群信息
         *
         * @param request QuerySingleGroupRequest
         * @param headers QuerySingleGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySingleGroupResponse
         */
        public QuerySingleGroupResponse QuerySingleGroupWithOptions(QuerySingleGroupRequest request, QuerySingleGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembers))
            {
                body["groupMembers"] = request.GroupMembers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QuerySingleGroup",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/doubleGroups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量查询群信息
         *
         * @param request QuerySingleGroupRequest
         * @param headers QuerySingleGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySingleGroupResponse
         */
        public async Task<QuerySingleGroupResponse> QuerySingleGroupWithOptionsAsync(QuerySingleGroupRequest request, QuerySingleGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupMembers))
            {
                body["groupMembers"] = request.GroupMembers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupTemplateId))
            {
                body["groupTemplateId"] = request.GroupTemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QuerySingleGroup",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/doubleGroups/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询群信息
         *
         * @param request QuerySingleGroupRequest
         * @return QuerySingleGroupResponse
         */
        public QuerySingleGroupResponse QuerySingleGroup(QuerySingleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySingleGroupHeaders headers = new QuerySingleGroupHeaders();
            return QuerySingleGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询群信息
         *
         * @param request QuerySingleGroupRequest
         * @return QuerySingleGroupResponse
         */
        public async Task<QuerySingleGroupResponse> QuerySingleGroupAsync(QuerySingleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySingleGroupHeaders headers = new QuerySingleGroupHeaders();
            return await QuerySingleGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询未读消息数
         *
         * @param request QueryUnReadMessageRequest
         * @param headers QueryUnReadMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUnReadMessageResponse
         */
        public QueryUnReadMessageResponse QueryUnReadMessageWithOptions(QueryUnReadMessageRequest request, QueryUnReadMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserId))
            {
                body["appUserId"] = request.AppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryUnReadMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/unReadMsgs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnReadMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量查询未读消息数
         *
         * @param request QueryUnReadMessageRequest
         * @param headers QueryUnReadMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUnReadMessageResponse
         */
        public async Task<QueryUnReadMessageResponse> QueryUnReadMessageWithOptionsAsync(QueryUnReadMessageRequest request, QueryUnReadMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserId))
            {
                body["appUserId"] = request.AppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryUnReadMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/unReadMsgs/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnReadMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询未读消息数
         *
         * @param request QueryUnReadMessageRequest
         * @return QueryUnReadMessageResponse
         */
        public QueryUnReadMessageResponse QueryUnReadMessage(QueryUnReadMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnReadMessageHeaders headers = new QueryUnReadMessageHeaders();
            return QueryUnReadMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询未读消息数
         *
         * @param request QueryUnReadMessageRequest
         * @return QueryUnReadMessageResponse
         */
        public async Task<QueryUnReadMessageResponse> QueryUnReadMessageAsync(QueryUnReadMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnReadMessageHeaders headers = new QueryUnReadMessageHeaders();
            return await QueryUnReadMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 移除会话机器人
         *
         * @param request RemoveRobotFromConversationRequest
         * @param headers RemoveRobotFromConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveRobotFromConversationResponse
         */
        public RemoveRobotFromConversationResponse RemoveRobotFromConversationWithOptions(RemoveRobotFromConversationRequest request, RemoveRobotFromConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatBotUserId))
            {
                body["chatBotUserId"] = request.ChatBotUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RemoveRobotFromConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/robots/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveRobotFromConversationResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 移除会话机器人
         *
         * @param request RemoveRobotFromConversationRequest
         * @param headers RemoveRobotFromConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveRobotFromConversationResponse
         */
        public async Task<RemoveRobotFromConversationResponse> RemoveRobotFromConversationWithOptionsAsync(RemoveRobotFromConversationRequest request, RemoveRobotFromConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatBotUserId))
            {
                body["chatBotUserId"] = request.ChatBotUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "RemoveRobotFromConversation",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/robots/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveRobotFromConversationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 移除会话机器人
         *
         * @param request RemoveRobotFromConversationRequest
         * @return RemoveRobotFromConversationResponse
         */
        public RemoveRobotFromConversationResponse RemoveRobotFromConversation(RemoveRobotFromConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveRobotFromConversationHeaders headers = new RemoveRobotFromConversationHeaders();
            return RemoveRobotFromConversationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 移除会话机器人
         *
         * @param request RemoveRobotFromConversationRequest
         * @return RemoveRobotFromConversationResponse
         */
        public async Task<RemoveRobotFromConversationResponse> RemoveRobotFromConversationAsync(RemoveRobotFromConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveRobotFromConversationHeaders headers = new RemoveRobotFromConversationHeaders();
            return await RemoveRobotFromConversationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据关键词搜索企业内部群
         *
         * @param request SearchInnerGroupsRequest
         * @param headers SearchInnerGroupsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchInnerGroupsResponse
         */
        public SearchInnerGroupsResponse SearchInnerGroupsWithOptions(SearchInnerGroupsRequest request, SearchInnerGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["searchKey"] = request.SearchKey;
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
                Action = "SearchInnerGroups",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchInnerGroupsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据关键词搜索企业内部群
         *
         * @param request SearchInnerGroupsRequest
         * @param headers SearchInnerGroupsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchInnerGroupsResponse
         */
        public async Task<SearchInnerGroupsResponse> SearchInnerGroupsWithOptionsAsync(SearchInnerGroupsRequest request, SearchInnerGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKey))
            {
                body["searchKey"] = request.SearchKey;
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
                Action = "SearchInnerGroups",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchInnerGroupsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据关键词搜索企业内部群
         *
         * @param request SearchInnerGroupsRequest
         * @return SearchInnerGroupsResponse
         */
        public SearchInnerGroupsResponse SearchInnerGroups(SearchInnerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchInnerGroupsHeaders headers = new SearchInnerGroupsHeaders();
            return SearchInnerGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据关键词搜索企业内部群
         *
         * @param request SearchInnerGroupsRequest
         * @return SearchInnerGroupsResponse
         */
        public async Task<SearchInnerGroupsResponse> SearchInnerGroupsAsync(SearchInnerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchInnerGroupsHeaders headers = new SearchInnerGroupsHeaders();
            return await SearchInnerGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送可交互式动态卡片
         *
         * @param request SendInteractiveCardRequest
         * @param headers SendInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendInteractiveCardResponse
         */
        public SendInteractiveCardResponse SendInteractiveCardWithOptions(SendInteractiveCardRequest request, SendInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtOpenIds))
            {
                body["atOpenIds"] = request.AtOpenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardOptions))
            {
                body["cardOptions"] = request.CardOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatBotId))
            {
                body["chatBotId"] = request.ChatBotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalWorkerCode))
            {
                body["digitalWorkerCode"] = request.DigitalWorkerCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullStrategy))
            {
                body["pullStrategy"] = request.PullStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interactiveCards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendInteractiveCardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送可交互式动态卡片
         *
         * @param request SendInteractiveCardRequest
         * @param headers SendInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendInteractiveCardResponse
         */
        public async Task<SendInteractiveCardResponse> SendInteractiveCardWithOptionsAsync(SendInteractiveCardRequest request, SendInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtOpenIds))
            {
                body["atOpenIds"] = request.AtOpenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardOptions))
            {
                body["cardOptions"] = request.CardOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChatBotId))
            {
                body["chatBotId"] = request.ChatBotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalWorkerCode))
            {
                body["digitalWorkerCode"] = request.DigitalWorkerCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullStrategy))
            {
                body["pullStrategy"] = request.PullStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interactiveCards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendInteractiveCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送可交互式动态卡片
         *
         * @param request SendInteractiveCardRequest
         * @return SendInteractiveCardResponse
         */
        public SendInteractiveCardResponse SendInteractiveCard(SendInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
            return SendInteractiveCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送可交互式动态卡片
         *
         * @param request SendInteractiveCardRequest
         * @return SendInteractiveCardResponse
         */
        public async Task<SendInteractiveCardResponse> SendInteractiveCardAsync(SendInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
            return await SendInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 人与人单聊发送可交互式动态卡片
         *
         * @param request SendOTOInteractiveCardRequest
         * @param headers SendOTOInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendOTOInteractiveCardResponse
         */
        public SendOTOInteractiveCardResponse SendOTOInteractiveCardWithOptions(SendOTOInteractiveCardRequest request, SendOTOInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtOpenIds))
            {
                body["atOpenIds"] = request.AtOpenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardOptions))
            {
                body["cardOptions"] = request.CardOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullStrategy))
            {
                body["pullStrategy"] = request.PullStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendOTOInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/privateChat/interactiveCards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOTOInteractiveCardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 人与人单聊发送可交互式动态卡片
         *
         * @param request SendOTOInteractiveCardRequest
         * @param headers SendOTOInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendOTOInteractiveCardResponse
         */
        public async Task<SendOTOInteractiveCardResponse> SendOTOInteractiveCardWithOptionsAsync(SendOTOInteractiveCardRequest request, SendOTOInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtOpenIds))
            {
                body["atOpenIds"] = request.AtOpenIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackRouteKey))
            {
                body["callbackRouteKey"] = request.CallbackRouteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardOptions))
            {
                body["cardOptions"] = request.CardOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullStrategy))
            {
                body["pullStrategy"] = request.PullStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendOTOInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/privateChat/interactiveCards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOTOInteractiveCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 人与人单聊发送可交互式动态卡片
         *
         * @param request SendOTOInteractiveCardRequest
         * @return SendOTOInteractiveCardResponse
         */
        public SendOTOInteractiveCardResponse SendOTOInteractiveCard(SendOTOInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendOTOInteractiveCardHeaders headers = new SendOTOInteractiveCardHeaders();
            return SendOTOInteractiveCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 人与人单聊发送可交互式动态卡片
         *
         * @param request SendOTOInteractiveCardRequest
         * @return SendOTOInteractiveCardResponse
         */
        public async Task<SendOTOInteractiveCardResponse> SendOTOInteractiveCardAsync(SendOTOInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendOTOInteractiveCardHeaders headers = new SendOTOInteractiveCardHeaders();
            return await SendOTOInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 机器人发送互动卡片（普通版）
         *
         * @param request SendRobotInteractiveCardRequest
         * @param headers SendRobotInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendRobotInteractiveCardResponse
         */
        public SendRobotInteractiveCardResponse SendRobotInteractiveCardWithOptions(SendRobotInteractiveCardRequest request, SendRobotInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardBizId))
            {
                body["cardBizId"] = request.CardBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullStrategy))
            {
                body["pullStrategy"] = request.PullStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendOptions))
            {
                body["sendOptions"] = request.SendOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SingleChatReceiver))
            {
                body["singleChatReceiver"] = request.SingleChatReceiver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionIdPrivateDataMap))
            {
                body["unionIdPrivateDataMap"] = request.UnionIdPrivateDataMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdPrivateDataMap))
            {
                body["userIdPrivateDataMap"] = request.UserIdPrivateDataMap;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendRobotInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/v1.0/robot/interactiveCards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRobotInteractiveCardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 机器人发送互动卡片（普通版）
         *
         * @param request SendRobotInteractiveCardRequest
         * @param headers SendRobotInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendRobotInteractiveCardResponse
         */
        public async Task<SendRobotInteractiveCardResponse> SendRobotInteractiveCardWithOptionsAsync(SendRobotInteractiveCardRequest request, SendRobotInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardBizId))
            {
                body["cardBizId"] = request.CardBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullStrategy))
            {
                body["pullStrategy"] = request.PullStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendOptions))
            {
                body["sendOptions"] = request.SendOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SingleChatReceiver))
            {
                body["singleChatReceiver"] = request.SingleChatReceiver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionIdPrivateDataMap))
            {
                body["unionIdPrivateDataMap"] = request.UnionIdPrivateDataMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdPrivateDataMap))
            {
                body["userIdPrivateDataMap"] = request.UserIdPrivateDataMap;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendRobotInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/v1.0/robot/interactiveCards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRobotInteractiveCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 机器人发送互动卡片（普通版）
         *
         * @param request SendRobotInteractiveCardRequest
         * @return SendRobotInteractiveCardResponse
         */
        public SendRobotInteractiveCardResponse SendRobotInteractiveCard(SendRobotInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotInteractiveCardHeaders headers = new SendRobotInteractiveCardHeaders();
            return SendRobotInteractiveCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 机器人发送互动卡片（普通版）
         *
         * @param request SendRobotInteractiveCardRequest
         * @return SendRobotInteractiveCardResponse
         */
        public async Task<SendRobotInteractiveCardResponse> SendRobotInteractiveCardAsync(SendRobotInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotInteractiveCardHeaders headers = new SendRobotInteractiveCardHeaders();
            return await SendRobotInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 机器人发送消息
         *
         * @param request SendRobotMessageRequest
         * @param headers SendRobotMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendRobotMessageResponse
         */
        public SendRobotMessageResponse SendRobotMessageWithOptions(SendRobotMessageRequest request, SendRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtAll))
            {
                body["atAll"] = request.AtAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtAppUserId))
            {
                body["atAppUserId"] = request.AtAppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtDingUserId))
            {
                body["atDingUserId"] = request.AtDingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgContent))
            {
                body["msgContent"] = request.MsgContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgType))
            {
                body["msgType"] = request.MsgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendRobotMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/robotMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRobotMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 机器人发送消息
         *
         * @param request SendRobotMessageRequest
         * @param headers SendRobotMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendRobotMessageResponse
         */
        public async Task<SendRobotMessageResponse> SendRobotMessageWithOptionsAsync(SendRobotMessageRequest request, SendRobotMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtAll))
            {
                body["atAll"] = request.AtAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtAppUserId))
            {
                body["atAppUserId"] = request.AtAppUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtDingUserId))
            {
                body["atDingUserId"] = request.AtDingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgContent))
            {
                body["msgContent"] = request.MsgContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgType))
            {
                body["msgType"] = request.MsgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationIds))
            {
                body["openConversationIds"] = request.OpenConversationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendRobotMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/robotMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendRobotMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 机器人发送消息
         *
         * @param request SendRobotMessageRequest
         * @return SendRobotMessageResponse
         */
        public SendRobotMessageResponse SendRobotMessage(SendRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotMessageHeaders headers = new SendRobotMessageHeaders();
            return SendRobotMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 机器人发送消息
         *
         * @param request SendRobotMessageRequest
         * @return SendRobotMessageResponse
         */
        public async Task<SendRobotMessageResponse> SendRobotMessageAsync(SendRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotMessageHeaders headers = new SendRobotMessageHeaders();
            return await SendRobotMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送模板响应式可交互式卡片
         *
         * @param request SendTemplateInteractiveCardRequest
         * @param headers SendTemplateInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendTemplateInteractiveCardResponse
         */
        public SendTemplateInteractiveCardResponse SendTemplateInteractiveCardWithOptions(SendTemplateInteractiveCardRequest request, SendTemplateInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendOptions))
            {
                body["sendOptions"] = request.SendOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SingleChatReceiver))
            {
                body["singleChatReceiver"] = request.SingleChatReceiver;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendTemplateInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interactiveCards/templates/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTemplateInteractiveCardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送模板响应式可交互式卡片
         *
         * @param request SendTemplateInteractiveCardRequest
         * @param headers SendTemplateInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendTemplateInteractiveCardResponse
         */
        public async Task<SendTemplateInteractiveCardResponse> SendTemplateInteractiveCardWithOptionsAsync(SendTemplateInteractiveCardRequest request, SendTemplateInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendOptions))
            {
                body["sendOptions"] = request.SendOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SingleChatReceiver))
            {
                body["singleChatReceiver"] = request.SingleChatReceiver;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendTemplateInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interactiveCards/templates/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTemplateInteractiveCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送模板响应式可交互式卡片
         *
         * @param request SendTemplateInteractiveCardRequest
         * @return SendTemplateInteractiveCardResponse
         */
        public SendTemplateInteractiveCardResponse SendTemplateInteractiveCard(SendTemplateInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendTemplateInteractiveCardHeaders headers = new SendTemplateInteractiveCardHeaders();
            return SendTemplateInteractiveCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送模板响应式可交互式卡片
         *
         * @param request SendTemplateInteractiveCardRequest
         * @return SendTemplateInteractiveCardResponse
         */
        public async Task<SendTemplateInteractiveCardResponse> SendTemplateInteractiveCardAsync(SendTemplateInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendTemplateInteractiveCardHeaders headers = new SendTemplateInteractiveCardHeaders();
            return await SendTemplateInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置侧边栏
         *
         * @param request SetRightPanelRequest
         * @param headers SetRightPanelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRightPanelResponse
         */
        public SetRightPanelResponse SetRightPanelWithOptions(SetRightPanelRequest request, SetRightPanelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightPanelClosePermitted))
            {
                body["rightPanelClosePermitted"] = request.RightPanelClosePermitted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightPanelOpenStatus))
            {
                body["rightPanelOpenStatus"] = request.RightPanelOpenStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebWndParams))
            {
                body["webWndParams"] = request.WebWndParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetRightPanel",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/rightPanels/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRightPanelResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置侧边栏
         *
         * @param request SetRightPanelRequest
         * @param headers SetRightPanelHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRightPanelResponse
         */
        public async Task<SetRightPanelResponse> SetRightPanelWithOptionsAsync(SetRightPanelRequest request, SetRightPanelHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightPanelClosePermitted))
            {
                body["rightPanelClosePermitted"] = request.RightPanelClosePermitted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RightPanelOpenStatus))
            {
                body["rightPanelOpenStatus"] = request.RightPanelOpenStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebWndParams))
            {
                body["webWndParams"] = request.WebWndParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["width"] = request.Width;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SetRightPanel",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/rightPanels/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRightPanelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置侧边栏
         *
         * @param request SetRightPanelRequest
         * @return SetRightPanelResponse
         */
        public SetRightPanelResponse SetRightPanel(SetRightPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRightPanelHeaders headers = new SetRightPanelHeaders();
            return SetRightPanelWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置侧边栏
         *
         * @param request SetRightPanelRequest
         * @return SetRightPanelResponse
         */
        public async Task<SetRightPanelResponse> SetRightPanelAsync(SetRightPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRightPanelHeaders headers = new SetRightPanelHeaders();
            return await SetRightPanelWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 钉钉吊顶卡片关闭
         *
         * @param request TopboxCloseRequest
         * @param headers TopboxCloseHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TopboxCloseResponse
         */
        public TopboxCloseResponse TopboxCloseWithOptions(TopboxCloseRequest request, TopboxCloseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TopboxClose",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/topBoxes/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<TopboxCloseResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 钉钉吊顶卡片关闭
         *
         * @param request TopboxCloseRequest
         * @param headers TopboxCloseHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TopboxCloseResponse
         */
        public async Task<TopboxCloseResponse> TopboxCloseWithOptionsAsync(TopboxCloseRequest request, TopboxCloseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TopboxClose",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/topBoxes/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<TopboxCloseResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 钉钉吊顶卡片关闭
         *
         * @param request TopboxCloseRequest
         * @return TopboxCloseResponse
         */
        public TopboxCloseResponse TopboxClose(TopboxCloseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TopboxCloseHeaders headers = new TopboxCloseHeaders();
            return TopboxCloseWithOptions(request, headers, runtime);
        }

        /**
         * @summary 钉钉吊顶卡片关闭
         *
         * @param request TopboxCloseRequest
         * @return TopboxCloseResponse
         */
        public async Task<TopboxCloseResponse> TopboxCloseAsync(TopboxCloseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TopboxCloseHeaders headers = new TopboxCloseHeaders();
            return await TopboxCloseWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 钉钉吊顶卡片开启
         *
         * @param request TopboxOpenRequest
         * @param headers TopboxOpenHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TopboxOpenResponse
         */
        public TopboxOpenResponse TopboxOpenWithOptions(TopboxOpenRequest request, TopboxOpenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                body["expiredTime"] = request.ExpiredTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platforms))
            {
                body["platforms"] = request.Platforms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TopboxOpen",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/topBoxes/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<TopboxOpenResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 钉钉吊顶卡片开启
         *
         * @param request TopboxOpenRequest
         * @param headers TopboxOpenHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return TopboxOpenResponse
         */
        public async Task<TopboxOpenResponse> TopboxOpenWithOptionsAsync(TopboxOpenRequest request, TopboxOpenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                body["conversationType"] = request.ConversationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredTime))
            {
                body["expiredTime"] = request.ExpiredTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platforms))
            {
                body["platforms"] = request.Platforms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUserIdList))
            {
                body["receiverUserIdList"] = request.ReceiverUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "TopboxOpen",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/topBoxes/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<TopboxOpenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 钉钉吊顶卡片开启
         *
         * @param request TopboxOpenRequest
         * @return TopboxOpenResponse
         */
        public TopboxOpenResponse TopboxOpen(TopboxOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TopboxOpenHeaders headers = new TopboxOpenHeaders();
            return TopboxOpenWithOptions(request, headers, runtime);
        }

        /**
         * @summary 钉钉吊顶卡片开启
         *
         * @param request TopboxOpenRequest
         * @return TopboxOpenResponse
         */
        public async Task<TopboxOpenResponse> TopboxOpenAsync(TopboxOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TopboxOpenHeaders headers = new TopboxOpenHeaders();
            return await TopboxOpenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改群头像
         *
         * @param request UpdateGroupAvatarRequest
         * @param headers UpdateGroupAvatarHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupAvatarResponse
         */
        public UpdateGroupAvatarResponse UpdateGroupAvatarWithOptions(UpdateGroupAvatarRequest request, UpdateGroupAvatarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAvatar))
            {
                body["groupAvatar"] = request.GroupAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateGroupAvatar",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/avatars",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupAvatarResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 修改群头像
         *
         * @param request UpdateGroupAvatarRequest
         * @param headers UpdateGroupAvatarHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupAvatarResponse
         */
        public async Task<UpdateGroupAvatarResponse> UpdateGroupAvatarWithOptionsAsync(UpdateGroupAvatarRequest request, UpdateGroupAvatarHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAvatar))
            {
                body["groupAvatar"] = request.GroupAvatar;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateGroupAvatar",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/avatars",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupAvatarResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 修改群头像
         *
         * @param request UpdateGroupAvatarRequest
         * @return UpdateGroupAvatarResponse
         */
        public UpdateGroupAvatarResponse UpdateGroupAvatar(UpdateGroupAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupAvatarHeaders headers = new UpdateGroupAvatarHeaders();
            return UpdateGroupAvatarWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改群头像
         *
         * @param request UpdateGroupAvatarRequest
         * @return UpdateGroupAvatarResponse
         */
        public async Task<UpdateGroupAvatarResponse> UpdateGroupAvatarAsync(UpdateGroupAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupAvatarHeaders headers = new UpdateGroupAvatarHeaders();
            return await UpdateGroupAvatarWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改群名称
         *
         * @param request UpdateGroupNameRequest
         * @param headers UpdateGroupNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupNameResponse
         */
        public UpdateGroupNameResponse UpdateGroupNameWithOptions(UpdateGroupNameRequest request, UpdateGroupNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateGroupName",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/names",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupNameResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 修改群名称
         *
         * @param request UpdateGroupNameRequest
         * @param headers UpdateGroupNameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupNameResponse
         */
        public async Task<UpdateGroupNameResponse> UpdateGroupNameWithOptionsAsync(UpdateGroupNameRequest request, UpdateGroupNameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateGroupName",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/names",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupNameResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 修改群名称
         *
         * @param request UpdateGroupNameRequest
         * @return UpdateGroupNameResponse
         */
        public UpdateGroupNameResponse UpdateGroupName(UpdateGroupNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupNameHeaders headers = new UpdateGroupNameHeaders();
            return UpdateGroupNameWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改群名称
         *
         * @param request UpdateGroupNameRequest
         * @return UpdateGroupNameResponse
         */
        public async Task<UpdateGroupNameResponse> UpdateGroupNameAsync(UpdateGroupNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupNameHeaders headers = new UpdateGroupNameHeaders();
            return await UpdateGroupNameWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置场景群权限项
         *
         * @param request UpdateGroupPermissionRequest
         * @param headers UpdateGroupPermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupPermissionResponse
         */
        public UpdateGroupPermissionResponse UpdateGroupPermissionWithOptions(UpdateGroupPermissionRequest request, UpdateGroupPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionGroup))
            {
                body["permissionGroup"] = request.PermissionGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateGroupPermission",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupPermissionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置场景群权限项
         *
         * @param request UpdateGroupPermissionRequest
         * @param headers UpdateGroupPermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupPermissionResponse
         */
        public async Task<UpdateGroupPermissionResponse> UpdateGroupPermissionWithOptionsAsync(UpdateGroupPermissionRequest request, UpdateGroupPermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionGroup))
            {
                body["permissionGroup"] = request.PermissionGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateGroupPermission",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupPermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置场景群权限项
         *
         * @param request UpdateGroupPermissionRequest
         * @return UpdateGroupPermissionResponse
         */
        public UpdateGroupPermissionResponse UpdateGroupPermission(UpdateGroupPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupPermissionHeaders headers = new UpdateGroupPermissionHeaders();
            return UpdateGroupPermissionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置场景群权限项
         *
         * @param request UpdateGroupPermissionRequest
         * @return UpdateGroupPermissionResponse
         */
        public async Task<UpdateGroupPermissionResponse> UpdateGroupPermissionAsync(UpdateGroupPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupPermissionHeaders headers = new UpdateGroupPermissionHeaders();
            return await UpdateGroupPermissionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新群管理员
         *
         * @param request UpdateGroupSubAdminRequest
         * @param headers UpdateGroupSubAdminHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupSubAdminResponse
         */
        public UpdateGroupSubAdminResponse UpdateGroupSubAdminWithOptions(UpdateGroupSubAdminRequest request, UpdateGroupSubAdminHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
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
                Action = "UpdateGroupSubAdmin",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/subAdmins",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupSubAdminResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新群管理员
         *
         * @param request UpdateGroupSubAdminRequest
         * @param headers UpdateGroupSubAdminHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupSubAdminResponse
         */
        public async Task<UpdateGroupSubAdminResponse> UpdateGroupSubAdminWithOptionsAsync(UpdateGroupSubAdminRequest request, UpdateGroupSubAdminHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                body["role"] = request.Role;
            }
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
                Action = "UpdateGroupSubAdmin",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/subAdmins",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupSubAdminResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新群管理员
         *
         * @param request UpdateGroupSubAdminRequest
         * @return UpdateGroupSubAdminResponse
         */
        public UpdateGroupSubAdminResponse UpdateGroupSubAdmin(UpdateGroupSubAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupSubAdminHeaders headers = new UpdateGroupSubAdminHeaders();
            return UpdateGroupSubAdminWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新群管理员
         *
         * @param request UpdateGroupSubAdminRequest
         * @return UpdateGroupSubAdminResponse
         */
        public async Task<UpdateGroupSubAdminResponse> UpdateGroupSubAdminAsync(UpdateGroupSubAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupSubAdminHeaders headers = new UpdateGroupSubAdminHeaders();
            return await UpdateGroupSubAdminWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新可交互式动态卡片
         *
         * @param request UpdateInteractiveCardRequest
         * @param headers UpdateInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInteractiveCardResponse
         */
        public UpdateInteractiveCardResponse UpdateInteractiveCardWithOptions(UpdateInteractiveCardRequest request, UpdateInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardOptions))
            {
                body["cardOptions"] = request.CardOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interactiveCards",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInteractiveCardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新可交互式动态卡片
         *
         * @param request UpdateInteractiveCardRequest
         * @param headers UpdateInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInteractiveCardResponse
         */
        public async Task<UpdateInteractiveCardResponse> UpdateInteractiveCardWithOptionsAsync(UpdateInteractiveCardRequest request, UpdateInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardOptions))
            {
                body["cardOptions"] = request.CardOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTrackId))
            {
                body["outTrackId"] = request.OutTrackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateData))
            {
                body["privateData"] = request.PrivateData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdType))
            {
                body["userIdType"] = request.UserIdType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interactiveCards",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInteractiveCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新可交互式动态卡片
         *
         * @param request UpdateInteractiveCardRequest
         * @return UpdateInteractiveCardResponse
         */
        public UpdateInteractiveCardResponse UpdateInteractiveCard(UpdateInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
            return UpdateInteractiveCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新可交互式动态卡片
         *
         * @param request UpdateInteractiveCardRequest
         * @return UpdateInteractiveCardResponse
         */
        public async Task<UpdateInteractiveCardResponse> UpdateInteractiveCardAsync(UpdateInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
            return await UpdateInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置群成员禁言状态
         *
         * @param request UpdateMemberBanWordsRequest
         * @param headers UpdateMemberBanWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemberBanWordsResponse
         */
        public UpdateMemberBanWordsResponse UpdateMemberBanWordsWithOptions(UpdateMemberBanWordsRequest request, UpdateMemberBanWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteDuration))
            {
                body["muteDuration"] = request.MuteDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteStatus))
            {
                body["muteStatus"] = request.MuteStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateMemberBanWords",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/muteMembers/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateMemberBanWordsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置群成员禁言状态
         *
         * @param request UpdateMemberBanWordsRequest
         * @param headers UpdateMemberBanWordsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemberBanWordsResponse
         */
        public async Task<UpdateMemberBanWordsResponse> UpdateMemberBanWordsWithOptionsAsync(UpdateMemberBanWordsRequest request, UpdateMemberBanWordsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteDuration))
            {
                body["muteDuration"] = request.MuteDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteStatus))
            {
                body["muteStatus"] = request.MuteStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateMemberBanWords",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/muteMembers/set",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateMemberBanWordsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置群成员禁言状态
         *
         * @param request UpdateMemberBanWordsRequest
         * @return UpdateMemberBanWordsResponse
         */
        public UpdateMemberBanWordsResponse UpdateMemberBanWords(UpdateMemberBanWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberBanWordsHeaders headers = new UpdateMemberBanWordsHeaders();
            return UpdateMemberBanWordsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置群成员禁言状态
         *
         * @param request UpdateMemberBanWordsRequest
         * @return UpdateMemberBanWordsResponse
         */
        public async Task<UpdateMemberBanWordsResponse> UpdateMemberBanWordsAsync(UpdateMemberBanWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberBanWordsHeaders headers = new UpdateMemberBanWordsHeaders();
            return await UpdateMemberBanWordsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新群成员的群昵称
         *
         * @param request UpdateMemberGroupNickRequest
         * @param headers UpdateMemberGroupNickHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemberGroupNickResponse
         */
        public UpdateMemberGroupNickResponse UpdateMemberGroupNickWithOptions(UpdateMemberGroupNickRequest request, UpdateMemberGroupNickHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNick))
            {
                body["groupNick"] = request.GroupNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "UpdateMemberGroupNick",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/members/groupNicks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemberGroupNickResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新群成员的群昵称
         *
         * @param request UpdateMemberGroupNickRequest
         * @param headers UpdateMemberGroupNickHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMemberGroupNickResponse
         */
        public async Task<UpdateMemberGroupNickResponse> UpdateMemberGroupNickWithOptionsAsync(UpdateMemberGroupNickRequest request, UpdateMemberGroupNickHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupNick))
            {
                body["groupNick"] = request.GroupNick;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
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
                Action = "UpdateMemberGroupNick",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/members/groupNicks",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMemberGroupNickResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新群成员的群昵称
         *
         * @param request UpdateMemberGroupNickRequest
         * @return UpdateMemberGroupNickResponse
         */
        public UpdateMemberGroupNickResponse UpdateMemberGroupNick(UpdateMemberGroupNickRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberGroupNickHeaders headers = new UpdateMemberGroupNickHeaders();
            return UpdateMemberGroupNickWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新群成员的群昵称
         *
         * @param request UpdateMemberGroupNickRequest
         * @return UpdateMemberGroupNickResponse
         */
        public async Task<UpdateMemberGroupNickResponse> UpdateMemberGroupNickAsync(UpdateMemberGroupNickRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberGroupNickHeaders headers = new UpdateMemberGroupNickHeaders();
            return await UpdateMemberGroupNickWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改组织里的机器人
         *
         * @param request UpdateRobotInOrgRequest
         * @param headers UpdateRobotInOrgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRobotInOrgResponse
         */
        public UpdateRobotInOrgResponse UpdateRobotInOrgWithOptions(UpdateRobotInOrgRequest request, UpdateRobotInOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brief))
            {
                body["brief"] = request.Brief;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutgoingToken))
            {
                body["outgoingToken"] = request.OutgoingToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutgoingUrl))
            {
                body["outgoingUrl"] = request.OutgoingUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewMediaId))
            {
                body["previewMediaId"] = request.PreviewMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateRobotInOrg",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/organizations/robots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRobotInOrgResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 修改组织里的机器人
         *
         * @param request UpdateRobotInOrgRequest
         * @param headers UpdateRobotInOrgHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRobotInOrgResponse
         */
        public async Task<UpdateRobotInOrgResponse> UpdateRobotInOrgWithOptionsAsync(UpdateRobotInOrgRequest request, UpdateRobotInOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Brief))
            {
                body["brief"] = request.Brief;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Icon))
            {
                body["icon"] = request.Icon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutgoingToken))
            {
                body["outgoingToken"] = request.OutgoingToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutgoingUrl))
            {
                body["outgoingUrl"] = request.OutgoingUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewMediaId))
            {
                body["previewMediaId"] = request.PreviewMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RobotCode))
            {
                body["robotCode"] = request.RobotCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateRobotInOrg",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/organizations/robots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRobotInOrgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 修改组织里的机器人
         *
         * @param request UpdateRobotInOrgRequest
         * @return UpdateRobotInOrgResponse
         */
        public UpdateRobotInOrgResponse UpdateRobotInOrg(UpdateRobotInOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRobotInOrgHeaders headers = new UpdateRobotInOrgHeaders();
            return UpdateRobotInOrgWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改组织里的机器人
         *
         * @param request UpdateRobotInOrgRequest
         * @return UpdateRobotInOrgResponse
         */
        public async Task<UpdateRobotInOrgResponse> UpdateRobotInOrgAsync(UpdateRobotInOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRobotInOrgHeaders headers = new UpdateRobotInOrgHeaders();
            return await UpdateRobotInOrgWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 机器人更新可交互式卡片(个人、企业)
         *
         * @param request UpdateRobotInteractiveCardRequest
         * @param headers UpdateRobotInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRobotInteractiveCardResponse
         */
        public UpdateRobotInteractiveCardResponse UpdateRobotInteractiveCardWithOptions(UpdateRobotInteractiveCardRequest request, UpdateRobotInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardBizId))
            {
                body["cardBizId"] = request.CardBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionIdPrivateDataMap))
            {
                body["unionIdPrivateDataMap"] = request.UnionIdPrivateDataMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateOptions))
            {
                body["updateOptions"] = request.UpdateOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdPrivateDataMap))
            {
                body["userIdPrivateDataMap"] = request.UserIdPrivateDataMap;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateRobotInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/robots/interactiveCards",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRobotInteractiveCardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 机器人更新可交互式卡片(个人、企业)
         *
         * @param request UpdateRobotInteractiveCardRequest
         * @param headers UpdateRobotInteractiveCardHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRobotInteractiveCardResponse
         */
        public async Task<UpdateRobotInteractiveCardResponse> UpdateRobotInteractiveCardWithOptionsAsync(UpdateRobotInteractiveCardRequest request, UpdateRobotInteractiveCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardBizId))
            {
                body["cardBizId"] = request.CardBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardData))
            {
                body["cardData"] = request.CardData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionIdPrivateDataMap))
            {
                body["unionIdPrivateDataMap"] = request.UnionIdPrivateDataMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateOptions))
            {
                body["updateOptions"] = request.UpdateOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdPrivateDataMap))
            {
                body["userIdPrivateDataMap"] = request.UserIdPrivateDataMap;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "UpdateRobotInteractiveCard",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/robots/interactiveCards",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRobotInteractiveCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 机器人更新可交互式卡片(个人、企业)
         *
         * @param request UpdateRobotInteractiveCardRequest
         * @return UpdateRobotInteractiveCardResponse
         */
        public UpdateRobotInteractiveCardResponse UpdateRobotInteractiveCard(UpdateRobotInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRobotInteractiveCardHeaders headers = new UpdateRobotInteractiveCardHeaders();
            return UpdateRobotInteractiveCardWithOptions(request, headers, runtime);
        }

        /**
         * @summary 机器人更新可交互式卡片(个人、企业)
         *
         * @param request UpdateRobotInteractiveCardRequest
         * @return UpdateRobotInteractiveCardResponse
         */
        public async Task<UpdateRobotInteractiveCardResponse> UpdateRobotInteractiveCardAsync(UpdateRobotInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRobotInteractiveCardHeaders headers = new UpdateRobotInteractiveCardHeaders();
            return await UpdateRobotInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置群成员的群角色
         *
         * @param request UpdateTheGroupRolesOfGroupMemberRequest
         * @param headers UpdateTheGroupRolesOfGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTheGroupRolesOfGroupMemberResponse
         */
        public UpdateTheGroupRolesOfGroupMemberResponse UpdateTheGroupRolesOfGroupMemberWithOptions(UpdateTheGroupRolesOfGroupMemberRequest request, UpdateTheGroupRolesOfGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenRoleIds))
            {
                body["openRoleIds"] = request.OpenRoleIds;
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
                Action = "UpdateTheGroupRolesOfGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/members/groupRoles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTheGroupRolesOfGroupMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 设置群成员的群角色
         *
         * @param request UpdateTheGroupRolesOfGroupMemberRequest
         * @param headers UpdateTheGroupRolesOfGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTheGroupRolesOfGroupMemberResponse
         */
        public async Task<UpdateTheGroupRolesOfGroupMemberResponse> UpdateTheGroupRolesOfGroupMemberWithOptionsAsync(UpdateTheGroupRolesOfGroupMemberRequest request, UpdateTheGroupRolesOfGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenRoleIds))
            {
                body["openRoleIds"] = request.OpenRoleIds;
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
                Action = "UpdateTheGroupRolesOfGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/sceneGroups/members/groupRoles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTheGroupRolesOfGroupMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 设置群成员的群角色
         *
         * @param request UpdateTheGroupRolesOfGroupMemberRequest
         * @return UpdateTheGroupRolesOfGroupMemberResponse
         */
        public UpdateTheGroupRolesOfGroupMemberResponse UpdateTheGroupRolesOfGroupMember(UpdateTheGroupRolesOfGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTheGroupRolesOfGroupMemberHeaders headers = new UpdateTheGroupRolesOfGroupMemberHeaders();
            return UpdateTheGroupRolesOfGroupMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置群成员的群角色
         *
         * @param request UpdateTheGroupRolesOfGroupMemberRequest
         * @return UpdateTheGroupRolesOfGroupMemberResponse
         */
        public async Task<UpdateTheGroupRolesOfGroupMemberResponse> UpdateTheGroupRolesOfGroupMemberAsync(UpdateTheGroupRolesOfGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTheGroupRolesOfGroupMemberHeaders headers = new UpdateTheGroupRolesOfGroupMemberHeaders();
            return await UpdateTheGroupRolesOfGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 添加群成员
         *
         * @param request AddGroupMemberRequest
         * @param headers AddGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGroupMemberResponse
         */
        public AddGroupMemberResponse AddGroupMemberWithOptions(AddGroupMemberRequest request, AddGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserIds))
            {
                body["appUserIds"] = request.AppUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
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
                Action = "addGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 添加群成员
         *
         * @param request AddGroupMemberRequest
         * @param headers AddGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGroupMemberResponse
         */
        public async Task<AddGroupMemberResponse> AddGroupMemberWithOptionsAsync(AddGroupMemberRequest request, AddGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserIds))
            {
                body["appUserIds"] = request.AppUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
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
                Action = "addGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 添加群成员
         *
         * @param request AddGroupMemberRequest
         * @return AddGroupMemberResponse
         */
        public AddGroupMemberResponse AddGroupMember(AddGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddGroupMemberHeaders headers = new AddGroupMemberHeaders();
            return AddGroupMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 添加群成员
         *
         * @param request AddGroupMemberRequest
         * @return AddGroupMemberResponse
         */
        public async Task<AddGroupMemberResponse> AddGroupMemberAsync(AddGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddGroupMemberHeaders headers = new AddGroupMemberHeaders();
            return await AddGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 移除群成员
         *
         * @param request RemoveGroupMemberRequest
         * @param headers RemoveGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveGroupMemberResponse
         */
        public RemoveGroupMemberResponse RemoveGroupMemberWithOptions(RemoveGroupMemberRequest request, RemoveGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserIds))
            {
                body["appUserIds"] = request.AppUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
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
                Action = "removeGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveGroupMemberResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 移除群成员
         *
         * @param request RemoveGroupMemberRequest
         * @param headers RemoveGroupMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveGroupMemberResponse
         */
        public async Task<RemoveGroupMemberResponse> RemoveGroupMemberWithOptionsAsync(RemoveGroupMemberRequest request, RemoveGroupMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppUserIds))
            {
                body["appUserIds"] = request.AppUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
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
                Action = "removeGroupMember",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/groups/members/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveGroupMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 移除群成员
         *
         * @param request RemoveGroupMemberRequest
         * @return RemoveGroupMemberResponse
         */
        public RemoveGroupMemberResponse RemoveGroupMember(RemoveGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveGroupMemberHeaders headers = new RemoveGroupMemberHeaders();
            return RemoveGroupMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 移除群成员
         *
         * @param request RemoveGroupMemberRequest
         * @return RemoveGroupMemberResponse
         */
        public async Task<RemoveGroupMemberResponse> RemoveGroupMemberAsync(RemoveGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveGroupMemberHeaders headers = new RemoveGroupMemberHeaders();
            return await RemoveGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送ToC消息
         *
         * @param request SendDingMessageRequest
         * @param headers SendDingMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendDingMessageResponse
         */
        public SendDingMessageResponse SendDingMessageWithOptions(SendDingMessageRequest request, SendDingMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverId))
            {
                body["receiverId"] = request.ReceiverId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderId))
            {
                body["senderId"] = request.SenderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "sendDingMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/dingMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendDingMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送ToC消息
         *
         * @param request SendDingMessageRequest
         * @param headers SendDingMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendDingMessageResponse
         */
        public async Task<SendDingMessageResponse> SendDingMessageWithOptionsAsync(SendDingMessageRequest request, SendDingMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverId))
            {
                body["receiverId"] = request.ReceiverId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderId))
            {
                body["senderId"] = request.SenderId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "sendDingMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/dingMessages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendDingMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送ToC消息
         *
         * @param request SendDingMessageRequest
         * @return SendDingMessageResponse
         */
        public SendDingMessageResponse SendDingMessage(SendDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendDingMessageHeaders headers = new SendDingMessageHeaders();
            return SendDingMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送ToC消息
         *
         * @param request SendDingMessageRequest
         * @return SendDingMessageResponse
         */
        public async Task<SendDingMessageResponse> SendDingMessageAsync(SendDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendDingMessageHeaders headers = new SendDingMessageHeaders();
            return await SendDingMessageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送ToB消息
         *
         * @param request SendMessageRequest
         * @param headers SendMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendMessageResponse
         */
        public SendMessageResponse SendMessageWithOptions(SendMessageRequest request, SendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverId))
            {
                body["receiverId"] = request.ReceiverId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderId))
            {
                body["senderId"] = request.SenderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInfos))
            {
                body["sourceInfos"] = request.SourceInfos;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "sendMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发送ToB消息
         *
         * @param request SendMessageRequest
         * @param headers SendMessageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendMessageResponse
         */
        public async Task<SendMessageResponse> SendMessageWithOptionsAsync(SendMessageRequest request, SendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverId))
            {
                body["receiverId"] = request.ReceiverId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderId))
            {
                body["senderId"] = request.SenderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInfos))
            {
                body["sourceInfos"] = request.SourceInfos;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "sendMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/interconnections/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发送ToB消息
         *
         * @param request SendMessageRequest
         * @return SendMessageResponse
         */
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageHeaders headers = new SendMessageHeaders();
            return SendMessageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送ToB消息
         *
         * @param request SendMessageRequest
         * @return SendMessageResponse
         */
        public async Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageHeaders headers = new SendMessageHeaders();
            return await SendMessageWithOptionsAsync(request, headers, runtime);
        }

    }
}
