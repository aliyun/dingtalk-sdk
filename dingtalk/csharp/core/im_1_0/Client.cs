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


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加企业文字表情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgTextEmotionRequest
        /// </param>
        /// <param name="headers">
        /// AddOrgTextEmotionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrgTextEmotionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加企业文字表情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgTextEmotionRequest
        /// </param>
        /// <param name="headers">
        /// AddOrgTextEmotionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddOrgTextEmotionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加企业文字表情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgTextEmotionRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrgTextEmotionResponse
        /// </returns>
        public AddOrgTextEmotionResponse AddOrgTextEmotion(AddOrgTextEmotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgTextEmotionHeaders headers = new AddOrgTextEmotionHeaders();
            return AddOrgTextEmotionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加企业文字表情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddOrgTextEmotionRequest
        /// </param>
        /// 
        /// <returns>
        /// AddOrgTextEmotionResponse
        /// </returns>
        public async Task<AddOrgTextEmotionResponse> AddOrgTextEmotionAsync(AddOrgTextEmotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddOrgTextEmotionHeaders headers = new AddOrgTextEmotionHeaders();
            return await AddOrgTextEmotionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加机器人到会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRobotToConversationRequest
        /// </param>
        /// <param name="headers">
        /// AddRobotToConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRobotToConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加机器人到会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRobotToConversationRequest
        /// </param>
        /// <param name="headers">
        /// AddRobotToConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRobotToConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加机器人到会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRobotToConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRobotToConversationResponse
        /// </returns>
        public AddRobotToConversationResponse AddRobotToConversation(AddRobotToConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRobotToConversationHeaders headers = new AddRobotToConversationHeaders();
            return AddRobotToConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加机器人到会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRobotToConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRobotToConversationResponse
        /// </returns>
        public async Task<AddRobotToConversationResponse> AddRobotToConversationAsync(AddRobotToConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRobotToConversationHeaders headers = new AddRobotToConversationHeaders();
            return await AddRobotToConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增链接增强注册规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// AddUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUnfurlingRegisterResponse
        /// </returns>
        public AddUnfurlingRegisterResponse AddUnfurlingRegisterWithOptions(AddUnfurlingRegisterRequest request, AddUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSecret))
            {
                body["apiSecret"] = request.ApiSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleDesc))
            {
                body["ruleDesc"] = request.RuleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleMatchType))
            {
                body["ruleMatchType"] = request.RuleMatchType;
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
                Action = "AddUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUnfurlingRegisterResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增链接增强注册规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// AddUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddUnfurlingRegisterResponse
        /// </returns>
        public async Task<AddUnfurlingRegisterResponse> AddUnfurlingRegisterWithOptionsAsync(AddUnfurlingRegisterRequest request, AddUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSecret))
            {
                body["apiSecret"] = request.ApiSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleDesc))
            {
                body["ruleDesc"] = request.RuleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleMatchType))
            {
                body["ruleMatchType"] = request.RuleMatchType;
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
                Action = "AddUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddUnfurlingRegisterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增链接增强注册规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUnfurlingRegisterResponse
        /// </returns>
        public AddUnfurlingRegisterResponse AddUnfurlingRegister(AddUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddUnfurlingRegisterHeaders headers = new AddUnfurlingRegisterHeaders();
            return AddUnfurlingRegisterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增链接增强注册规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// AddUnfurlingRegisterResponse
        /// </returns>
        public async Task<AddUnfurlingRegisterResponse> AddUnfurlingRegisterAsync(AddUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddUnfurlingRegisterHeaders headers = new AddUnfurlingRegisterHeaders();
            return await AddUnfurlingRegisterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自动开通钉钉客联微应用</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// AutoOpenDingTalkConnectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AutoOpenDingTalkConnectResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自动开通钉钉客联微应用</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// AutoOpenDingTalkConnectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AutoOpenDingTalkConnectResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自动开通钉钉客联微应用</para>
        /// </summary>
        /// 
        /// <returns>
        /// AutoOpenDingTalkConnectResponse
        /// </returns>
        public AutoOpenDingTalkConnectResponse AutoOpenDingTalkConnect()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AutoOpenDingTalkConnectHeaders headers = new AutoOpenDingTalkConnectHeaders();
            return AutoOpenDingTalkConnectWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>自动开通钉钉客联微应用</para>
        /// </summary>
        /// 
        /// <returns>
        /// AutoOpenDingTalkConnectResponse
        /// </returns>
        public async Task<AutoOpenDingTalkConnectResponse> AutoOpenDingTalkConnectAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AutoOpenDingTalkConnectHeaders headers = new AutoOpenDingTalkConnectHeaders();
            return await AutoOpenDingTalkConnectWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询家校群消息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryFamilySchoolMessageRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryFamilySchoolMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryFamilySchoolMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询家校群消息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryFamilySchoolMessageRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryFamilySchoolMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryFamilySchoolMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询家校群消息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryFamilySchoolMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryFamilySchoolMessageResponse
        /// </returns>
        public BatchQueryFamilySchoolMessageResponse BatchQueryFamilySchoolMessage(BatchQueryFamilySchoolMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryFamilySchoolMessageHeaders headers = new BatchQueryFamilySchoolMessageHeaders();
            return BatchQueryFamilySchoolMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询家校群消息详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryFamilySchoolMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryFamilySchoolMessageResponse
        /// </returns>
        public async Task<BatchQueryFamilySchoolMessageResponse> BatchQueryFamilySchoolMessageAsync(BatchQueryFamilySchoolMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryFamilySchoolMessageHeaders headers = new BatchQueryFamilySchoolMessageHeaders();
            return await BatchQueryFamilySchoolMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryGroupMemberResponse
        /// </returns>
        public BatchQueryGroupMemberResponse BatchQueryGroupMember(BatchQueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryGroupMemberHeaders headers = new BatchQueryGroupMemberHeaders();
            return BatchQueryGroupMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryGroupMemberResponse
        /// </returns>
        public async Task<BatchQueryGroupMemberResponse> BatchQueryGroupMemberAsync(BatchQueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryGroupMemberHeaders headers = new BatchQueryGroupMemberHeaders();
            return await BatchQueryGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉互动卡片模板构建动作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardTemplateBuildActionRequest
        /// </param>
        /// <param name="headers">
        /// CardTemplateBuildActionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CardTemplateBuildActionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉互动卡片模板构建动作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardTemplateBuildActionRequest
        /// </param>
        /// <param name="headers">
        /// CardTemplateBuildActionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CardTemplateBuildActionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉互动卡片模板构建动作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardTemplateBuildActionRequest
        /// </param>
        /// 
        /// <returns>
        /// CardTemplateBuildActionResponse
        /// </returns>
        public CardTemplateBuildActionResponse CardTemplateBuildAction(CardTemplateBuildActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CardTemplateBuildActionHeaders headers = new CardTemplateBuildActionHeaders();
            return CardTemplateBuildActionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉互动卡片模板构建动作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CardTemplateBuildActionRequest
        /// </param>
        /// 
        /// <returns>
        /// CardTemplateBuildActionResponse
        /// </returns>
        public async Task<CardTemplateBuildActionResponse> CardTemplateBuildActionAsync(CardTemplateBuildActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CardTemplateBuildActionHeaders headers = new CardTemplateBuildActionHeaders();
            return await CardTemplateBuildActionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换群主</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeGroupOwnerRequest
        /// </param>
        /// <param name="headers">
        /// ChangeGroupOwnerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeGroupOwnerResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换群主</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeGroupOwnerRequest
        /// </param>
        /// <param name="headers">
        /// ChangeGroupOwnerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeGroupOwnerResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换群主</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeGroupOwnerRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeGroupOwnerResponse
        /// </returns>
        public ChangeGroupOwnerResponse ChangeGroupOwner(ChangeGroupOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeGroupOwnerHeaders headers = new ChangeGroupOwnerHeaders();
            return ChangeGroupOwnerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更换群主</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeGroupOwnerRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeGroupOwnerResponse
        /// </returns>
        public async Task<ChangeGroupOwnerResponse> ChangeGroupOwnerAsync(ChangeGroupOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChangeGroupOwnerHeaders headers = new ChangeGroupOwnerHeaders();
            return await ChangeGroupOwnerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话开放的ChatId转OpenConversationId</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ChatIdToOpenConversationIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatIdToOpenConversationIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话开放的ChatId转OpenConversationId</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ChatIdToOpenConversationIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatIdToOpenConversationIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话开放的ChatId转OpenConversationId</para>
        /// </summary>
        /// 
        /// <returns>
        /// ChatIdToOpenConversationIdResponse
        /// </returns>
        public ChatIdToOpenConversationIdResponse ChatIdToOpenConversationId(string chatId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatIdToOpenConversationIdHeaders headers = new ChatIdToOpenConversationIdHeaders();
            return ChatIdToOpenConversationIdWithOptions(chatId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话开放的ChatId转OpenConversationId</para>
        /// </summary>
        /// 
        /// <returns>
        /// ChatIdToOpenConversationIdResponse
        /// </returns>
        public async Task<ChatIdToOpenConversationIdResponse> ChatIdToOpenConversationIdAsync(string chatId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatIdToOpenConversationIdHeaders headers = new ChatIdToOpenConversationIdHeaders();
            return await ChatIdToOpenConversationIdWithOptionsAsync(chatId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatSubAdminUpdateRequest
        /// </param>
        /// <param name="headers">
        /// ChatSubAdminUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatSubAdminUpdateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatSubAdminUpdateRequest
        /// </param>
        /// <param name="headers">
        /// ChatSubAdminUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatSubAdminUpdateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatSubAdminUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatSubAdminUpdateResponse
        /// </returns>
        public ChatSubAdminUpdateResponse ChatSubAdminUpdate(ChatSubAdminUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatSubAdminUpdateHeaders headers = new ChatSubAdminUpdateHeaders();
            return ChatSubAdminUpdateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatSubAdminUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatSubAdminUpdateResponse
        /// </returns>
        public async Task<ChatSubAdminUpdateResponse> ChatSubAdminUpdateAsync(ChatSubAdminUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatSubAdminUpdateHeaders headers = new ChatSubAdminUpdateHeaders();
            return await ChatSubAdminUpdateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户是否为企业内部群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUserIsGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// CheckUserIsGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckUserIsGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户是否为企业内部群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUserIsGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// CheckUserIsGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckUserIsGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户是否为企业内部群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUserIsGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckUserIsGroupMemberResponse
        /// </returns>
        public CheckUserIsGroupMemberResponse CheckUserIsGroupMember(CheckUserIsGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckUserIsGroupMemberHeaders headers = new CheckUserIsGroupMemberHeaders();
            return CheckUserIsGroupMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户是否为企业内部群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckUserIsGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckUserIsGroupMemberResponse
        /// </returns>
        public async Task<CheckUserIsGroupMemberResponse> CheckUserIsGroupMemberAsync(CheckUserIsGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckUserIsGroupMemberHeaders headers = new CheckUserIsGroupMemberHeaders();
            return await CheckUserIsGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则拷贝</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// CopyUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyUnfurlingRegisterResponse
        /// </returns>
        public CopyUnfurlingRegisterResponse CopyUnfurlingRegisterWithOptions(CopyUnfurlingRegisterRequest request, CopyUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
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
                Action = "CopyUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyUnfurlingRegisterResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则拷贝</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// CopyUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyUnfurlingRegisterResponse
        /// </returns>
        public async Task<CopyUnfurlingRegisterResponse> CopyUnfurlingRegisterWithOptionsAsync(CopyUnfurlingRegisterRequest request, CopyUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
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
                Action = "CopyUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyUnfurlingRegisterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则拷贝</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyUnfurlingRegisterResponse
        /// </returns>
        public CopyUnfurlingRegisterResponse CopyUnfurlingRegister(CopyUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyUnfurlingRegisterHeaders headers = new CopyUnfurlingRegisterHeaders();
            return CopyUnfurlingRegisterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则拷贝</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyUnfurlingRegisterResponse
        /// </returns>
        public async Task<CopyUnfurlingRegisterResponse> CopyUnfurlingRegisterAsync(CopyUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CopyUnfurlingRegisterHeaders headers = new CopyUnfurlingRegisterHeaders();
            return await CopyUnfurlingRegisterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询消息开放群模板下群计数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOpenMsgSceneGroupsRequest
        /// </param>
        /// <param name="headers">
        /// CountOpenMsgSceneGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountOpenMsgSceneGroupsResponse
        /// </returns>
        public CountOpenMsgSceneGroupsResponse CountOpenMsgSceneGroupsWithOptions(CountOpenMsgSceneGroupsRequest request, CountOpenMsgSceneGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CountOpenMsgSceneGroups",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/openMsgSceneGroups/templates/counts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountOpenMsgSceneGroupsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询消息开放群模板下群计数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOpenMsgSceneGroupsRequest
        /// </param>
        /// <param name="headers">
        /// CountOpenMsgSceneGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountOpenMsgSceneGroupsResponse
        /// </returns>
        public async Task<CountOpenMsgSceneGroupsResponse> CountOpenMsgSceneGroupsWithOptionsAsync(CountOpenMsgSceneGroupsRequest request, CountOpenMsgSceneGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CountOpenMsgSceneGroups",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/openMsgSceneGroups/templates/counts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountOpenMsgSceneGroupsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询消息开放群模板下群计数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOpenMsgSceneGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// CountOpenMsgSceneGroupsResponse
        /// </returns>
        public CountOpenMsgSceneGroupsResponse CountOpenMsgSceneGroups(CountOpenMsgSceneGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CountOpenMsgSceneGroupsHeaders headers = new CountOpenMsgSceneGroupsHeaders();
            return CountOpenMsgSceneGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询消息开放群模板下群计数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CountOpenMsgSceneGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// CountOpenMsgSceneGroupsResponse
        /// </returns>
        public async Task<CountOpenMsgSceneGroupsResponse> CountOpenMsgSceneGroupsAsync(CountOpenMsgSceneGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CountOpenMsgSceneGroupsHeaders headers = new CountOpenMsgSceneGroupsHeaders();
            return await CountOpenMsgSceneGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群模板关联的群数量</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CountSceneGroupsByTemplateIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountSceneGroupsByTemplateIdResponse
        /// </returns>
        public CountSceneGroupsByTemplateIdResponse CountSceneGroupsByTemplateIdWithOptions(string templateId, CountSceneGroupsByTemplateIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CountSceneGroupsByTemplateId",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/chats/sceneGroups/templates/" + templateId + "/counts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountSceneGroupsByTemplateIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群模板关联的群数量</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CountSceneGroupsByTemplateIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CountSceneGroupsByTemplateIdResponse
        /// </returns>
        public async Task<CountSceneGroupsByTemplateIdResponse> CountSceneGroupsByTemplateIdWithOptionsAsync(string templateId, CountSceneGroupsByTemplateIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CountSceneGroupsByTemplateId",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/chats/sceneGroups/templates/" + templateId + "/counts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CountSceneGroupsByTemplateIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群模板关联的群数量</para>
        /// </summary>
        /// 
        /// <returns>
        /// CountSceneGroupsByTemplateIdResponse
        /// </returns>
        public CountSceneGroupsByTemplateIdResponse CountSceneGroupsByTemplateId(string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CountSceneGroupsByTemplateIdHeaders headers = new CountSceneGroupsByTemplateIdHeaders();
            return CountSceneGroupsByTemplateIdWithOptions(templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群模板关联的群数量</para>
        /// </summary>
        /// 
        /// <returns>
        /// CountSceneGroupsByTemplateIdResponse
        /// </returns>
        public async Task<CountSceneGroupsByTemplateIdResponse> CountSceneGroupsByTemplateIdAsync(string templateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CountSceneGroupsByTemplateIdHeaders headers = new CountSceneGroupsByTemplateIdHeaders();
            return await CountSceneGroupsByTemplateIdWithOptionsAsync(templateId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉外两人群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCoupleGroupConversationRequest
        /// </param>
        /// <param name="headers">
        /// CreateCoupleGroupConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCoupleGroupConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉外两人群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCoupleGroupConversationRequest
        /// </param>
        /// <param name="headers">
        /// CreateCoupleGroupConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCoupleGroupConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉外两人群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCoupleGroupConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCoupleGroupConversationResponse
        /// </returns>
        public CreateCoupleGroupConversationResponse CreateCoupleGroupConversation(CreateCoupleGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCoupleGroupConversationHeaders headers = new CreateCoupleGroupConversationHeaders();
            return CreateCoupleGroupConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉外两人群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCoupleGroupConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCoupleGroupConversationResponse
        /// </returns>
        public async Task<CreateCoupleGroupConversationResponse> CreateCoupleGroupConversationAsync(CreateCoupleGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCoupleGroupConversationHeaders headers = new CreateCoupleGroupConversationHeaders();
            return await CreateCoupleGroupConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建互通群（支持普通互通群、跨钉两人群）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupConversationRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建互通群（支持普通互通群、跨钉两人群）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupConversationRequest
        /// </param>
        /// <param name="headers">
        /// CreateGroupConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建互通群（支持普通互通群、跨钉两人群）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupConversationResponse
        /// </returns>
        public CreateGroupConversationResponse CreateGroupConversation(CreateGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupConversationHeaders headers = new CreateGroupConversationHeaders();
            return CreateGroupConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建互通群（支持普通互通群、跨钉两人群）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupConversationResponse
        /// </returns>
        public async Task<CreateGroupConversationResponse> CreateGroupConversationAsync(CreateGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateGroupConversationHeaders headers = new CreateGroupConversationHeaders();
            return await CreateGroupConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉外账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInterconnectionRequest
        /// </param>
        /// <param name="headers">
        /// CreateInterconnectionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInterconnectionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉外账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInterconnectionRequest
        /// </param>
        /// <param name="headers">
        /// CreateInterconnectionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInterconnectionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉外账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInterconnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInterconnectionResponse
        /// </returns>
        public CreateInterconnectionResponse CreateInterconnection(CreateInterconnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInterconnectionHeaders headers = new CreateInterconnectionHeaders();
            return CreateInterconnectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉外账号</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInterconnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInterconnectionResponse
        /// </returns>
        public async Task<CreateInterconnectionResponse> CreateInterconnectionAsync(CreateInterconnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateInterconnectionHeaders headers = new CreateInterconnectionHeaders();
            return await CreateInterconnectionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景群会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSceneGroupConversationRequest
        /// </param>
        /// <param name="headers">
        /// CreateSceneGroupConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneGroupConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景群会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSceneGroupConversationRequest
        /// </param>
        /// <param name="headers">
        /// CreateSceneGroupConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneGroupConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景群会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSceneGroupConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneGroupConversationResponse
        /// </returns>
        public CreateSceneGroupConversationResponse CreateSceneGroupConversation(CreateSceneGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSceneGroupConversationHeaders headers = new CreateSceneGroupConversationHeaders();
            return CreateSceneGroupConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建场景群会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSceneGroupConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSceneGroupConversationResponse
        /// </returns>
        public async Task<CreateSceneGroupConversationResponse> CreateSceneGroupConversationAsync(CreateSceneGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSceneGroupConversationHeaders headers = new CreateSceneGroupConversationHeaders();
            return await CreateSceneGroupConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建店铺群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateStoreGroupConversationRequest
        /// </param>
        /// <param name="headers">
        /// CreateStoreGroupConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStoreGroupConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建店铺群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateStoreGroupConversationRequest
        /// </param>
        /// <param name="headers">
        /// CreateStoreGroupConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateStoreGroupConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建店铺群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateStoreGroupConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStoreGroupConversationResponse
        /// </returns>
        public CreateStoreGroupConversationResponse CreateStoreGroupConversation(CreateStoreGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateStoreGroupConversationHeaders headers = new CreateStoreGroupConversationHeaders();
            return CreateStoreGroupConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建店铺群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateStoreGroupConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateStoreGroupConversationResponse
        /// </returns>
        public async Task<CreateStoreGroupConversationResponse> CreateStoreGroupConversationAsync(CreateStoreGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateStoreGroupConversationHeaders headers = new CreateStoreGroupConversationHeaders();
            return await CreateStoreGroupConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// DebugUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DebugUnfurlingRegisterResponse
        /// </returns>
        public DebugUnfurlingRegisterResponse DebugUnfurlingRegisterWithOptions(DebugUnfurlingRegisterRequest request, DebugUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayGroupIdList))
            {
                body["grayGroupIdList"] = request.GrayGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayUserIdList))
            {
                body["grayUserIdList"] = request.GrayUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
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
                Action = "DebugUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/debug",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugUnfurlingRegisterResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// DebugUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DebugUnfurlingRegisterResponse
        /// </returns>
        public async Task<DebugUnfurlingRegisterResponse> DebugUnfurlingRegisterWithOptionsAsync(DebugUnfurlingRegisterRequest request, DebugUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayGroupIdList))
            {
                body["grayGroupIdList"] = request.GrayGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrayUserIdList))
            {
                body["grayUserIdList"] = request.GrayUserIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
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
                Action = "DebugUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/debug",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugUnfurlingRegisterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// DebugUnfurlingRegisterResponse
        /// </returns>
        public DebugUnfurlingRegisterResponse DebugUnfurlingRegister(DebugUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DebugUnfurlingRegisterHeaders headers = new DebugUnfurlingRegisterHeaders();
            return DebugUnfurlingRegisterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则调试</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// DebugUnfurlingRegisterResponse
        /// </returns>
        public async Task<DebugUnfurlingRegisterResponse> DebugUnfurlingRegisterAsync(DebugUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DebugUnfurlingRegisterHeaders headers = new DebugUnfurlingRegisterHeaders();
            return await DebugUnfurlingRegisterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除企业文字表情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOrgTextEmotionRequest
        /// </param>
        /// <param name="headers">
        /// DeleteOrgTextEmotionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOrgTextEmotionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除企业文字表情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOrgTextEmotionRequest
        /// </param>
        /// <param name="headers">
        /// DeleteOrgTextEmotionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOrgTextEmotionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除企业文字表情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOrgTextEmotionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOrgTextEmotionResponse
        /// </returns>
        public DeleteOrgTextEmotionResponse DeleteOrgTextEmotion(DeleteOrgTextEmotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteOrgTextEmotionHeaders headers = new DeleteOrgTextEmotionHeaders();
            return DeleteOrgTextEmotionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除企业文字表情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOrgTextEmotionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOrgTextEmotionResponse
        /// </returns>
        public async Task<DeleteOrgTextEmotionResponse> DeleteOrgTextEmotionAsync(DeleteOrgTextEmotionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteOrgTextEmotionHeaders headers = new DeleteOrgTextEmotionHeaders();
            return await DeleteOrgTextEmotionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解散互通群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DismissGroupConversationRequest
        /// </param>
        /// <param name="headers">
        /// DismissGroupConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DismissGroupConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解散互通群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DismissGroupConversationRequest
        /// </param>
        /// <param name="headers">
        /// DismissGroupConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DismissGroupConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解散互通群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DismissGroupConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// DismissGroupConversationResponse
        /// </returns>
        public DismissGroupConversationResponse DismissGroupConversation(DismissGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DismissGroupConversationHeaders headers = new DismissGroupConversationHeaders();
            return DismissGroupConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解散互通群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DismissGroupConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// DismissGroupConversationResponse
        /// </returns>
        public async Task<DismissGroupConversationResponse> DismissGroupConversationAsync(DismissGroupConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DismissGroupConversationHeaders headers = new DismissGroupConversationHeaders();
            return await DismissGroupConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建ToB会话地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetConversationUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConversationUrlResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建ToB会话地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetConversationUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConversationUrlResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建ToB会话地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConversationUrlResponse
        /// </returns>
        public GetConversationUrlResponse GetConversationUrl(GetConversationUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationUrlHeaders headers = new GetConversationUrlHeaders();
            return GetConversationUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建ToB会话地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConversationUrlResponse
        /// </returns>
        public async Task<GetConversationUrlResponse> GetConversationUrlAsync(GetConversationUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetConversationUrlHeaders headers = new GetConversationUrlHeaders();
            return await GetConversationUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户家校群消息(图片&amp;视频Z&amp;富文本)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFamilySchoolConversationMsgRequest
        /// </param>
        /// <param name="headers">
        /// GetFamilySchoolConversationMsgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFamilySchoolConversationMsgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户家校群消息(图片&amp;视频Z&amp;富文本)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFamilySchoolConversationMsgRequest
        /// </param>
        /// <param name="headers">
        /// GetFamilySchoolConversationMsgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFamilySchoolConversationMsgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户家校群消息(图片&amp;视频Z&amp;富文本)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFamilySchoolConversationMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFamilySchoolConversationMsgResponse
        /// </returns>
        public GetFamilySchoolConversationMsgResponse GetFamilySchoolConversationMsg(GetFamilySchoolConversationMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFamilySchoolConversationMsgHeaders headers = new GetFamilySchoolConversationMsgHeaders();
            return GetFamilySchoolConversationMsgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户家校群消息(图片&amp;视频Z&amp;富文本)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFamilySchoolConversationMsgRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFamilySchoolConversationMsgResponse
        /// </returns>
        public async Task<GetFamilySchoolConversationMsgResponse> GetFamilySchoolConversationMsgAsync(GetFamilySchoolConversationMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFamilySchoolConversationMsgHeaders headers = new GetFamilySchoolConversationMsgHeaders();
            return await GetFamilySchoolConversationMsgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户家校群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFamilySchoolConversationsRequest
        /// </param>
        /// <param name="headers">
        /// GetFamilySchoolConversationsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFamilySchoolConversationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户家校群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFamilySchoolConversationsRequest
        /// </param>
        /// <param name="headers">
        /// GetFamilySchoolConversationsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFamilySchoolConversationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户家校群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFamilySchoolConversationsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFamilySchoolConversationsResponse
        /// </returns>
        public GetFamilySchoolConversationsResponse GetFamilySchoolConversations(GetFamilySchoolConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFamilySchoolConversationsHeaders headers = new GetFamilySchoolConversationsHeaders();
            return GetFamilySchoolConversationsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户家校群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFamilySchoolConversationsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFamilySchoolConversationsResponse
        /// </returns>
        public async Task<GetFamilySchoolConversationsResponse> GetFamilySchoolConversationsAsync(GetFamilySchoolConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFamilySchoolConversationsHeaders headers = new GetFamilySchoolConversationsHeaders();
            return await GetFamilySchoolConversationsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内部群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInnerGroupMembersRequest
        /// </param>
        /// <param name="headers">
        /// GetInnerGroupMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInnerGroupMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内部群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInnerGroupMembersRequest
        /// </param>
        /// <param name="headers">
        /// GetInnerGroupMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInnerGroupMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内部群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInnerGroupMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInnerGroupMembersResponse
        /// </returns>
        public GetInnerGroupMembersResponse GetInnerGroupMembers(GetInnerGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInnerGroupMembersHeaders headers = new GetInnerGroupMembersHeaders();
            return GetInnerGroupMembersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内部群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInnerGroupMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInnerGroupMembersResponse
        /// </returns>
        public async Task<GetInnerGroupMembersResponse> GetInnerGroupMembersAsync(GetInnerGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInnerGroupMembersHeaders headers = new GetInnerGroupMembersHeaders();
            return await GetInnerGroupMembersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建客联互通会话地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterconnectionUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetInterconnectionUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInterconnectionUrlResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建客联互通会话地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterconnectionUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetInterconnectionUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInterconnectionUrlResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建客联互通会话地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterconnectionUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInterconnectionUrlResponse
        /// </returns>
        public GetInterconnectionUrlResponse GetInterconnectionUrl(GetInterconnectionUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInterconnectionUrlHeaders headers = new GetInterconnectionUrlHeaders();
            return GetInterconnectionUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建客联互通会话地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInterconnectionUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInterconnectionUrlResponse
        /// </returns>
        public async Task<GetInterconnectionUrlResponse> GetInterconnectionUrlAsync(GetInterconnectionUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInterconnectionUrlHeaders headers = new GetInterconnectionUrlHeaders();
            return await GetInterconnectionUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近活跃的企业内部群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNewestInnerGroupsRequest
        /// </param>
        /// <param name="headers">
        /// GetNewestInnerGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNewestInnerGroupsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近活跃的企业内部群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNewestInnerGroupsRequest
        /// </param>
        /// <param name="headers">
        /// GetNewestInnerGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNewestInnerGroupsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近活跃的企业内部群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNewestInnerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNewestInnerGroupsResponse
        /// </returns>
        public GetNewestInnerGroupsResponse GetNewestInnerGroups(GetNewestInnerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNewestInnerGroupsHeaders headers = new GetNewestInnerGroupsHeaders();
            return GetNewestInnerGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近活跃的企业内部群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNewestInnerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNewestInnerGroupsResponse
        /// </returns>
        public async Task<GetNewestInnerGroupsResponse> GetNewestInnerGroupsAsync(GetNewestInnerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetNewestInnerGroupsHeaders headers = new GetNewestInnerGroupsHeaders();
            return await GetNewestInnerGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群简要信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneGroupInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetSceneGroupInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSceneGroupInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群简要信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneGroupInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetSceneGroupInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSceneGroupInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群简要信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneGroupInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSceneGroupInfoResponse
        /// </returns>
        public GetSceneGroupInfoResponse GetSceneGroupInfo(GetSceneGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSceneGroupInfoHeaders headers = new GetSceneGroupInfoHeaders();
            return GetSceneGroupInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群简要信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneGroupInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSceneGroupInfoResponse
        /// </returns>
        public async Task<GetSceneGroupInfoResponse> GetSceneGroupInfoAsync(GetSceneGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSceneGroupInfoHeaders headers = new GetSceneGroupInfoHeaders();
            return await GetSceneGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneGroupMembersRequest
        /// </param>
        /// <param name="headers">
        /// GetSceneGroupMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSceneGroupMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneGroupMembersRequest
        /// </param>
        /// <param name="headers">
        /// GetSceneGroupMembersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSceneGroupMembersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneGroupMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSceneGroupMembersResponse
        /// </returns>
        public GetSceneGroupMembersResponse GetSceneGroupMembers(GetSceneGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSceneGroupMembersHeaders headers = new GetSceneGroupMembersHeaders();
            return GetSceneGroupMembersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSceneGroupMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSceneGroupMembersResponse
        /// </returns>
        public async Task<GetSceneGroupMembersResponse> GetSceneGroupMembersAsync(GetSceneGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSceneGroupMembersHeaders headers = new GetSceneGroupMembersHeaders();
            return await GetSceneGroupMembersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群禁言</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupBanWordsRequest
        /// </param>
        /// <param name="headers">
        /// GroupBanWordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupBanWordsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群禁言</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupBanWordsRequest
        /// </param>
        /// <param name="headers">
        /// GroupBanWordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupBanWordsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群禁言</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupBanWordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupBanWordsResponse
        /// </returns>
        public GroupBanWordsResponse GroupBanWords(GroupBanWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupBanWordsHeaders headers = new GroupBanWordsHeaders();
            return GroupBanWordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群禁言</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupBanWordsRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupBanWordsResponse
        /// </returns>
        public async Task<GroupBanWordsResponse> GroupBanWordsAsync(GroupBanWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupBanWordsHeaders headers = new GroupBanWordsHeaders();
            return await GroupBanWordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量扩容询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityInquiryRequest
        /// </param>
        /// <param name="headers">
        /// GroupCapacityInquiryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityInquiryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量扩容询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityInquiryRequest
        /// </param>
        /// <param name="headers">
        /// GroupCapacityInquiryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityInquiryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量扩容询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityInquiryRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityInquiryResponse
        /// </returns>
        public GroupCapacityInquiryResponse GroupCapacityInquiry(GroupCapacityInquiryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityInquiryHeaders headers = new GroupCapacityInquiryHeaders();
            return GroupCapacityInquiryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量扩容询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityInquiryRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityInquiryResponse
        /// </returns>
        public async Task<GroupCapacityInquiryResponse> GroupCapacityInquiryAsync(GroupCapacityInquiryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityInquiryHeaders headers = new GroupCapacityInquiryHeaders();
            return await GroupCapacityInquiryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量扩容确认下单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityOrderConfirmRequest
        /// </param>
        /// <param name="headers">
        /// GroupCapacityOrderConfirmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityOrderConfirmResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量扩容确认下单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityOrderConfirmRequest
        /// </param>
        /// <param name="headers">
        /// GroupCapacityOrderConfirmHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityOrderConfirmResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量扩容确认下单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityOrderConfirmRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityOrderConfirmResponse
        /// </returns>
        public GroupCapacityOrderConfirmResponse GroupCapacityOrderConfirm(GroupCapacityOrderConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityOrderConfirmHeaders headers = new GroupCapacityOrderConfirmHeaders();
            return GroupCapacityOrderConfirmWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量扩容确认下单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityOrderConfirmRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityOrderConfirmResponse
        /// </returns>
        public async Task<GroupCapacityOrderConfirmResponse> GroupCapacityOrderConfirmAsync(GroupCapacityOrderConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityOrderConfirmHeaders headers = new GroupCapacityOrderConfirmHeaders();
            return await GroupCapacityOrderConfirmWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量请求扩容下单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityOrderPlaceRequest
        /// </param>
        /// <param name="headers">
        /// GroupCapacityOrderPlaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityOrderPlaceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量请求扩容下单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityOrderPlaceRequest
        /// </param>
        /// <param name="headers">
        /// GroupCapacityOrderPlaceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityOrderPlaceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量请求扩容下单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityOrderPlaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityOrderPlaceResponse
        /// </returns>
        public GroupCapacityOrderPlaceResponse GroupCapacityOrderPlace(GroupCapacityOrderPlaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityOrderPlaceHeaders headers = new GroupCapacityOrderPlaceHeaders();
            return GroupCapacityOrderPlaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群容量请求扩容下单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupCapacityOrderPlaceRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupCapacityOrderPlaceResponse
        /// </returns>
        public async Task<GroupCapacityOrderPlaceResponse> GroupCapacityOrderPlaceAsync(GroupCapacityOrderPlaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupCapacityOrderPlaceHeaders headers = new GroupCapacityOrderPlaceHeaders();
            return await GroupCapacityOrderPlaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群链接、群号等检索条件，查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupManageQueryRequest
        /// </param>
        /// <param name="headers">
        /// GroupManageQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupManageQueryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群链接、群号等检索条件，查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupManageQueryRequest
        /// </param>
        /// <param name="headers">
        /// GroupManageQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupManageQueryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群链接、群号等检索条件，查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupManageQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupManageQueryResponse
        /// </returns>
        public GroupManageQueryResponse GroupManageQuery(GroupManageQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupManageQueryHeaders headers = new GroupManageQueryHeaders();
            return GroupManageQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据群链接、群号等检索条件，查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupManageQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupManageQueryResponse
        /// </returns>
        public async Task<GroupManageQueryResponse> GroupManageQueryAsync(GroupManageQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupManageQueryHeaders headers = new GroupManageQueryHeaders();
            return await GroupManageQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群管理缩容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupManageReduceRequest
        /// </param>
        /// <param name="headers">
        /// GroupManageReduceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupManageReduceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群管理缩容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupManageReduceRequest
        /// </param>
        /// <param name="headers">
        /// GroupManageReduceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GroupManageReduceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群管理缩容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupManageReduceRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupManageReduceResponse
        /// </returns>
        public GroupManageReduceResponse GroupManageReduce(GroupManageReduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupManageReduceHeaders headers = new GroupManageReduceHeaders();
            return GroupManageReduceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群管理缩容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GroupManageReduceRequest
        /// </param>
        /// 
        /// <returns>
        /// GroupManageReduceResponse
        /// </returns>
        public async Task<GroupManageReduceResponse> GroupManageReduceAsync(GroupManageReduceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GroupManageReduceHeaders headers = new GroupManageReduceHeaders();
            return await GroupManageReduceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装机器人到组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallRobotToOrgRequest
        /// </param>
        /// <param name="headers">
        /// InstallRobotToOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallRobotToOrgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装机器人到组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallRobotToOrgRequest
        /// </param>
        /// <param name="headers">
        /// InstallRobotToOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallRobotToOrgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装机器人到组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallRobotToOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallRobotToOrgResponse
        /// </returns>
        public InstallRobotToOrgResponse InstallRobotToOrg(InstallRobotToOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallRobotToOrgHeaders headers = new InstallRobotToOrgHeaders();
            return InstallRobotToOrgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装机器人到组织</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallRobotToOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallRobotToOrgResponse
        /// </returns>
        public async Task<InstallRobotToOrgResponse> InstallRobotToOrgAsync(InstallRobotToOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallRobotToOrgHeaders headers = new InstallRobotToOrgHeaders();
            return await InstallRobotToOrgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建可交互式实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InteractiveCardCreateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// InteractiveCardCreateInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InteractiveCardCreateInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建可交互式实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InteractiveCardCreateInstanceRequest
        /// </param>
        /// <param name="headers">
        /// InteractiveCardCreateInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InteractiveCardCreateInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建可交互式实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InteractiveCardCreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// InteractiveCardCreateInstanceResponse
        /// </returns>
        public InteractiveCardCreateInstanceResponse InteractiveCardCreateInstance(InteractiveCardCreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InteractiveCardCreateInstanceHeaders headers = new InteractiveCardCreateInstanceHeaders();
            return InteractiveCardCreateInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建可交互式实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InteractiveCardCreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// InteractiveCardCreateInstanceResponse
        /// </returns>
        public async Task<InteractiveCardCreateInstanceResponse> InteractiveCardCreateInstanceAsync(InteractiveCardCreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InteractiveCardCreateInstanceHeaders headers = new InteractiveCardCreateInstanceHeaders();
            return await InteractiveCardCreateInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListOrgTextEmotionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOrgTextEmotionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ListOrgTextEmotionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOrgTextEmotionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListOrgTextEmotionResponse
        /// </returns>
        public ListOrgTextEmotionResponse ListOrgTextEmotion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrgTextEmotionHeaders headers = new ListOrgTextEmotionHeaders();
            return ListOrgTextEmotionWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListOrgTextEmotionResponse
        /// </returns>
        public async Task<ListOrgTextEmotionResponse> ListOrgTextEmotionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListOrgTextEmotionHeaders headers = new ListOrgTextEmotionHeaders();
            return await ListOrgTextEmotionWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板id查询关联的群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSceneGroupsByTemplateIdRequest
        /// </param>
        /// <param name="headers">
        /// ListSceneGroupsByTemplateIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSceneGroupsByTemplateIdResponse
        /// </returns>
        public ListSceneGroupsByTemplateIdResponse ListSceneGroupsByTemplateIdWithOptions(string templateId, ListSceneGroupsByTemplateIdRequest request, ListSceneGroupsByTemplateIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListSceneGroupsByTemplateId",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/chats/sceneGroups/templates/" + templateId + "/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSceneGroupsByTemplateIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板id查询关联的群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSceneGroupsByTemplateIdRequest
        /// </param>
        /// <param name="headers">
        /// ListSceneGroupsByTemplateIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSceneGroupsByTemplateIdResponse
        /// </returns>
        public async Task<ListSceneGroupsByTemplateIdResponse> ListSceneGroupsByTemplateIdWithOptionsAsync(string templateId, ListSceneGroupsByTemplateIdRequest request, ListSceneGroupsByTemplateIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListSceneGroupsByTemplateId",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/chats/sceneGroups/templates/" + templateId + "/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSceneGroupsByTemplateIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板id查询关联的群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSceneGroupsByTemplateIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSceneGroupsByTemplateIdResponse
        /// </returns>
        public ListSceneGroupsByTemplateIdResponse ListSceneGroupsByTemplateId(string templateId, ListSceneGroupsByTemplateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSceneGroupsByTemplateIdHeaders headers = new ListSceneGroupsByTemplateIdHeaders();
            return ListSceneGroupsByTemplateIdWithOptions(templateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板id查询关联的群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSceneGroupsByTemplateIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSceneGroupsByTemplateIdResponse
        /// </returns>
        public async Task<ListSceneGroupsByTemplateIdResponse> ListSceneGroupsByTemplateIdAsync(string templateId, ListSceneGroupsByTemplateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSceneGroupsByTemplateIdHeaders headers = new ListSceneGroupsByTemplateIdHeaders();
            return await ListSceneGroupsByTemplateIdWithOptionsAsync(templateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// OfflineUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineUnfurlingRegisterResponse
        /// </returns>
        public OfflineUnfurlingRegisterResponse OfflineUnfurlingRegisterWithOptions(OfflineUnfurlingRegisterRequest request, OfflineUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
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
                Action = "OfflineUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineUnfurlingRegisterResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// OfflineUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineUnfurlingRegisterResponse
        /// </returns>
        public async Task<OfflineUnfurlingRegisterResponse> OfflineUnfurlingRegisterWithOptionsAsync(OfflineUnfurlingRegisterRequest request, OfflineUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
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
                Action = "OfflineUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineUnfurlingRegisterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineUnfurlingRegisterResponse
        /// </returns>
        public OfflineUnfurlingRegisterResponse OfflineUnfurlingRegister(OfflineUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OfflineUnfurlingRegisterHeaders headers = new OfflineUnfurlingRegisterHeaders();
            return OfflineUnfurlingRegisterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineUnfurlingRegisterResponse
        /// </returns>
        public async Task<OfflineUnfurlingRegisterResponse> OfflineUnfurlingRegisterAsync(OfflineUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OfflineUnfurlingRegisterHeaders headers = new OfflineUnfurlingRegisterHeaders();
            return await OfflineUnfurlingRegisterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群新增群角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleAddRequest
        /// </param>
        /// <param name="headers">
        /// OpenGroupRoleAddHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleAddResponse
        /// </returns>
        public OpenGroupRoleAddResponse OpenGroupRoleAddWithOptions(OpenGroupRoleAddRequest request, OpenGroupRoleAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
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
                Action = "OpenGroupRoleAdd",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenGroupRoleAddResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群新增群角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleAddRequest
        /// </param>
        /// <param name="headers">
        /// OpenGroupRoleAddHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleAddResponse
        /// </returns>
        public async Task<OpenGroupRoleAddResponse> OpenGroupRoleAddWithOptionsAsync(OpenGroupRoleAddRequest request, OpenGroupRoleAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
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
                Action = "OpenGroupRoleAdd",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenGroupRoleAddResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群新增群角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleAddRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleAddResponse
        /// </returns>
        public OpenGroupRoleAddResponse OpenGroupRoleAdd(OpenGroupRoleAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenGroupRoleAddHeaders headers = new OpenGroupRoleAddHeaders();
            return OpenGroupRoleAddWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群新增群角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleAddRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleAddResponse
        /// </returns>
        public async Task<OpenGroupRoleAddResponse> OpenGroupRoleAddAsync(OpenGroupRoleAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenGroupRoleAddHeaders headers = new OpenGroupRoleAddHeaders();
            return await OpenGroupRoleAddWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleQueryRequest
        /// </param>
        /// <param name="headers">
        /// OpenGroupRoleQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleQueryResponse
        /// </returns>
        public OpenGroupRoleQueryResponse OpenGroupRoleQueryWithOptions(OpenGroupRoleQueryRequest request, OpenGroupRoleQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "OpenGroupRoleQuery",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/roles/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenGroupRoleQueryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleQueryRequest
        /// </param>
        /// <param name="headers">
        /// OpenGroupRoleQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleQueryResponse
        /// </returns>
        public async Task<OpenGroupRoleQueryResponse> OpenGroupRoleQueryWithOptionsAsync(OpenGroupRoleQueryRequest request, OpenGroupRoleQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "OpenGroupRoleQuery",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/roles/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenGroupRoleQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleQueryResponse
        /// </returns>
        public OpenGroupRoleQueryResponse OpenGroupRoleQuery(OpenGroupRoleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenGroupRoleQueryHeaders headers = new OpenGroupRoleQueryHeaders();
            return OpenGroupRoleQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleQueryResponse
        /// </returns>
        public async Task<OpenGroupRoleQueryResponse> OpenGroupRoleQueryAsync(OpenGroupRoleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenGroupRoleQueryHeaders headers = new OpenGroupRoleQueryHeaders();
            return await OpenGroupRoleQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色移除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleRemoveRequest
        /// </param>
        /// <param name="headers">
        /// OpenGroupRoleRemoveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleRemoveResponse
        /// </returns>
        public OpenGroupRoleRemoveResponse OpenGroupRoleRemoveWithOptions(OpenGroupRoleRemoveRequest request, OpenGroupRoleRemoveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "OpenGroupRoleRemove",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/roles/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenGroupRoleRemoveResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色移除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleRemoveRequest
        /// </param>
        /// <param name="headers">
        /// OpenGroupRoleRemoveHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleRemoveResponse
        /// </returns>
        public async Task<OpenGroupRoleRemoveResponse> OpenGroupRoleRemoveWithOptionsAsync(OpenGroupRoleRemoveRequest request, OpenGroupRoleRemoveHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "OpenGroupRoleRemove",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/roles/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenGroupRoleRemoveResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色移除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleRemoveRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleRemoveResponse
        /// </returns>
        public OpenGroupRoleRemoveResponse OpenGroupRoleRemove(OpenGroupRoleRemoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenGroupRoleRemoveHeaders headers = new OpenGroupRoleRemoveHeaders();
            return OpenGroupRoleRemoveWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色移除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleRemoveRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleRemoveResponse
        /// </returns>
        public async Task<OpenGroupRoleRemoveResponse> OpenGroupRoleRemoveAsync(OpenGroupRoleRemoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenGroupRoleRemoveHeaders headers = new OpenGroupRoleRemoveHeaders();
            return await OpenGroupRoleRemoveWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色变更</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleUpdateRequest
        /// </param>
        /// <param name="headers">
        /// OpenGroupRoleUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleUpdateResponse
        /// </returns>
        public OpenGroupRoleUpdateResponse OpenGroupRoleUpdateWithOptions(OpenGroupRoleUpdateRequest request, OpenGroupRoleUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
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
                Action = "OpenGroupRoleUpdate",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenGroupRoleUpdateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色变更</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleUpdateRequest
        /// </param>
        /// <param name="headers">
        /// OpenGroupRoleUpdateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleUpdateResponse
        /// </returns>
        public async Task<OpenGroupRoleUpdateResponse> OpenGroupRoleUpdateWithOptionsAsync(OpenGroupRoleUpdateRequest request, OpenGroupRoleUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
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
                Action = "OpenGroupRoleUpdate",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenGroupRoleUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色变更</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleUpdateResponse
        /// </returns>
        public OpenGroupRoleUpdateResponse OpenGroupRoleUpdate(OpenGroupRoleUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenGroupRoleUpdateHeaders headers = new OpenGroupRoleUpdateHeaders();
            return OpenGroupRoleUpdateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群角色变更</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupRoleUpdateRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupRoleUpdateResponse
        /// </returns>
        public async Task<OpenGroupRoleUpdateResponse> OpenGroupRoleUpdateAsync(OpenGroupRoleUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenGroupRoleUpdateHeaders headers = new OpenGroupRoleUpdateHeaders();
            return await OpenGroupRoleUpdateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群成员的群角色信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupUserRoleQueryRequest
        /// </param>
        /// <param name="headers">
        /// OpenGroupUserRoleQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupUserRoleQueryResponse
        /// </returns>
        public OpenGroupUserRoleQueryResponse OpenGroupUserRoleQueryWithOptions(OpenGroupUserRoleQueryRequest request, OpenGroupUserRoleQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewedUserId))
            {
                body["viewedUserId"] = request.ViewedUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "OpenGroupUserRoleQuery",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/users/roles/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenGroupUserRoleQueryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群成员的群角色信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupUserRoleQueryRequest
        /// </param>
        /// <param name="headers">
        /// OpenGroupUserRoleQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupUserRoleQueryResponse
        /// </returns>
        public async Task<OpenGroupUserRoleQueryResponse> OpenGroupUserRoleQueryWithOptionsAsync(OpenGroupUserRoleQueryRequest request, OpenGroupUserRoleQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewedUserId))
            {
                body["viewedUserId"] = request.ViewedUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "OpenGroupUserRoleQuery",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/users/roles/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenGroupUserRoleQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群成员的群角色信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupUserRoleQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupUserRoleQueryResponse
        /// </returns>
        public OpenGroupUserRoleQueryResponse OpenGroupUserRoleQuery(OpenGroupUserRoleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenGroupUserRoleQueryHeaders headers = new OpenGroupUserRoleQueryHeaders();
            return OpenGroupUserRoleQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开放场景群群成员的群角色信息查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenGroupUserRoleQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenGroupUserRoleQueryResponse
        /// </returns>
        public async Task<OpenGroupUserRoleQueryResponse> OpenGroupUserRoleQueryAsync(OpenGroupUserRoleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenGroupUserRoleQueryHeaders headers = new OpenGroupUserRoleQueryHeaders();
            return await OpenGroupUserRoleQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内部群转部门群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenInnerGroupTransferToDeptGroupRequest
        /// </param>
        /// <param name="headers">
        /// OpenInnerGroupTransferToDeptGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenInnerGroupTransferToDeptGroupResponse
        /// </returns>
        public OpenInnerGroupTransferToDeptGroupResponse OpenInnerGroupTransferToDeptGroupWithOptions(OpenInnerGroupTransferToDeptGroupRequest request, OpenInnerGroupTransferToDeptGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
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
                Action = "OpenInnerGroupTransferToDeptGroup",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/transferToDeptGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenInnerGroupTransferToDeptGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内部群转部门群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenInnerGroupTransferToDeptGroupRequest
        /// </param>
        /// <param name="headers">
        /// OpenInnerGroupTransferToDeptGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenInnerGroupTransferToDeptGroupResponse
        /// </returns>
        public async Task<OpenInnerGroupTransferToDeptGroupResponse> OpenInnerGroupTransferToDeptGroupWithOptionsAsync(OpenInnerGroupTransferToDeptGroupRequest request, OpenInnerGroupTransferToDeptGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
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
                Action = "OpenInnerGroupTransferToDeptGroup",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/transferToDeptGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenInnerGroupTransferToDeptGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内部群转部门群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenInnerGroupTransferToDeptGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenInnerGroupTransferToDeptGroupResponse
        /// </returns>
        public OpenInnerGroupTransferToDeptGroupResponse OpenInnerGroupTransferToDeptGroup(OpenInnerGroupTransferToDeptGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenInnerGroupTransferToDeptGroupHeaders headers = new OpenInnerGroupTransferToDeptGroupHeaders();
            return OpenInnerGroupTransferToDeptGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>内部群转部门群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenInnerGroupTransferToDeptGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenInnerGroupTransferToDeptGroupResponse
        /// </returns>
        public async Task<OpenInnerGroupTransferToDeptGroupResponse> OpenInnerGroupTransferToDeptGroupAsync(OpenInnerGroupTransferToDeptGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenInnerGroupTransferToDeptGroupHeaders headers = new OpenInnerGroupTransferToDeptGroupHeaders();
            return await OpenInnerGroupTransferToDeptGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenSearchGroupListRequest
        /// </param>
        /// <param name="headers">
        /// OpenSearchGroupListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenSearchGroupListResponse
        /// </returns>
        public OpenSearchGroupListResponse OpenSearchGroupListWithOptions(OpenSearchGroupListRequest request, OpenSearchGroupListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
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
                Action = "OpenSearchGroupList",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenSearchGroupListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenSearchGroupListRequest
        /// </param>
        /// <param name="headers">
        /// OpenSearchGroupListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenSearchGroupListResponse
        /// </returns>
        public async Task<OpenSearchGroupListResponse> OpenSearchGroupListWithOptionsAsync(OpenSearchGroupListRequest request, OpenSearchGroupListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                body["keyword"] = request.Keyword;
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
                Action = "OpenSearchGroupList",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/search",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenSearchGroupListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenSearchGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenSearchGroupListResponse
        /// </returns>
        public OpenSearchGroupListResponse OpenSearchGroupList(OpenSearchGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenSearchGroupListHeaders headers = new OpenSearchGroupListHeaders();
            return OpenSearchGroupListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenSearchGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenSearchGroupListResponse
        /// </returns>
        public async Task<OpenSearchGroupListResponse> OpenSearchGroupListAsync(OpenSearchGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenSearchGroupListHeaders headers = new OpenSearchGroupListHeaders();
            return await OpenSearchGroupListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以个人身份发送卡片消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenUserSendCardMessageRequest
        /// </param>
        /// <param name="headers">
        /// OpenUserSendCardMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenUserSendCardMessageResponse
        /// </returns>
        public OpenUserSendCardMessageResponse OpenUserSendCardMessageWithOptions(OpenUserSendCardMessageRequest request, OpenUserSendCardMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardContent))
            {
                body["cardContent"] = request.CardContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveUserId))
            {
                body["receiveUserId"] = request.ReceiveUserId;
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
                Action = "OpenUserSendCardMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/cardMessages/users/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenUserSendCardMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以个人身份发送卡片消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenUserSendCardMessageRequest
        /// </param>
        /// <param name="headers">
        /// OpenUserSendCardMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenUserSendCardMessageResponse
        /// </returns>
        public async Task<OpenUserSendCardMessageResponse> OpenUserSendCardMessageWithOptionsAsync(OpenUserSendCardMessageRequest request, OpenUserSendCardMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardContent))
            {
                body["cardContent"] = request.CardContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveUserId))
            {
                body["receiveUserId"] = request.ReceiveUserId;
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
                Action = "OpenUserSendCardMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/cardMessages/users/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenUserSendCardMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以个人身份发送卡片消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenUserSendCardMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenUserSendCardMessageResponse
        /// </returns>
        public OpenUserSendCardMessageResponse OpenUserSendCardMessage(OpenUserSendCardMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenUserSendCardMessageHeaders headers = new OpenUserSendCardMessageHeaders();
            return OpenUserSendCardMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以个人身份发送卡片消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenUserSendCardMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenUserSendCardMessageResponse
        /// </returns>
        public async Task<OpenUserSendCardMessageResponse> OpenUserSendCardMessageAsync(OpenUserSendCardMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenUserSendCardMessageHeaders headers = new OpenUserSendCardMessageHeaders();
            return await OpenUserSendCardMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以用户身份发送卡片消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalSendCardMessageRequest
        /// </param>
        /// <param name="headers">
        /// PersonalSendCardMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PersonalSendCardMessageResponse
        /// </returns>
        public PersonalSendCardMessageResponse PersonalSendCardMessageWithOptions(PersonalSendCardMessageRequest request, PersonalSendCardMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtUserIds))
            {
                body["atUserIds"] = request.AtUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardContent))
            {
                body["cardContent"] = request.CardContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveUserId))
            {
                body["receiveUserId"] = request.ReceiveUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PersonalSendCardMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/me/messages/cards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PersonalSendCardMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以用户身份发送卡片消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalSendCardMessageRequest
        /// </param>
        /// <param name="headers">
        /// PersonalSendCardMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PersonalSendCardMessageResponse
        /// </returns>
        public async Task<PersonalSendCardMessageResponse> PersonalSendCardMessageWithOptionsAsync(PersonalSendCardMessageRequest request, PersonalSendCardMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AtUserIds))
            {
                body["atUserIds"] = request.AtUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardContent))
            {
                body["cardContent"] = request.CardContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveUserId))
            {
                body["receiveUserId"] = request.ReceiveUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "PersonalSendCardMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/me/messages/cards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PersonalSendCardMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以用户身份发送卡片消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalSendCardMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PersonalSendCardMessageResponse
        /// </returns>
        public PersonalSendCardMessageResponse PersonalSendCardMessage(PersonalSendCardMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PersonalSendCardMessageHeaders headers = new PersonalSendCardMessageHeaders();
            return PersonalSendCardMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>以用户身份发送卡片消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PersonalSendCardMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PersonalSendCardMessageResponse
        /// </returns>
        public async Task<PersonalSendCardMessageResponse> PersonalSendCardMessageAsync(PersonalSendCardMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PersonalSendCardMessageHeaders headers = new PersonalSendCardMessageHeaders();
            return await PersonalSendCardMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员授权场景下查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupInfoByMemberAuthRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupInfoByMemberAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupInfoByMemberAuthResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员授权场景下查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupInfoByMemberAuthRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupInfoByMemberAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupInfoByMemberAuthResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员授权场景下查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupInfoByMemberAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupInfoByMemberAuthResponse
        /// </returns>
        public QueryGroupInfoByMemberAuthResponse QueryGroupInfoByMemberAuth(QueryGroupInfoByMemberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupInfoByMemberAuthHeaders headers = new QueryGroupInfoByMemberAuthHeaders();
            return QueryGroupInfoByMemberAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员授权场景下查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupInfoByMemberAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupInfoByMemberAuthResponse
        /// </returns>
        public async Task<QueryGroupInfoByMemberAuthResponse> QueryGroupInfoByMemberAuthAsync(QueryGroupInfoByMemberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupInfoByMemberAuthHeaders headers = new QueryGroupInfoByMemberAuthHeaders();
            return await QueryGroupInfoByMemberAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMemberResponse
        /// </returns>
        public QueryGroupMemberResponse QueryGroupMember(QueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMemberHeaders headers = new QueryGroupMemberHeaders();
            return QueryGroupMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMemberResponse
        /// </returns>
        public async Task<QueryGroupMemberResponse> QueryGroupMemberAsync(QueryGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMemberHeaders headers = new QueryGroupMemberHeaders();
            return await QueryGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员授权场景下查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMemberByMemberAuthRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupMemberByMemberAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMemberByMemberAuthResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员授权场景下查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMemberByMemberAuthRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupMemberByMemberAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMemberByMemberAuthResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员授权场景下查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMemberByMemberAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMemberByMemberAuthResponse
        /// </returns>
        public QueryGroupMemberByMemberAuthResponse QueryGroupMemberByMemberAuth(QueryGroupMemberByMemberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMemberByMemberAuthHeaders headers = new QueryGroupMemberByMemberAuthHeaders();
            return QueryGroupMemberByMemberAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>成员授权场景下查询群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMemberByMemberAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMemberByMemberAuthResponse
        /// </returns>
        public async Task<QueryGroupMemberByMemberAuthResponse> QueryGroupMemberByMemberAuthAsync(QueryGroupMemberByMemberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMemberByMemberAuthHeaders headers = new QueryGroupMemberByMemberAuthHeaders();
            return await QueryGroupMemberByMemberAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群禁言状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMuteStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupMuteStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMuteStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群禁言状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMuteStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryGroupMuteStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMuteStatusResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群禁言状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMuteStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMuteStatusResponse
        /// </returns>
        public QueryGroupMuteStatusResponse QueryGroupMuteStatus(QueryGroupMuteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMuteStatusHeaders headers = new QueryGroupMuteStatusHeaders();
            return QueryGroupMuteStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群禁言状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGroupMuteStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGroupMuteStatusResponse
        /// </returns>
        public async Task<QueryGroupMuteStatusResponse> QueryGroupMuteStatusAsync(QueryGroupMuteStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupMuteStatusHeaders headers = new QueryGroupMuteStatusHeaders();
            return await QueryGroupMuteStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取群成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerGroupMemberListRequest
        /// </param>
        /// <param name="headers">
        /// QueryInnerGroupMemberListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerGroupMemberListResponse
        /// </returns>
        public QueryInnerGroupMemberListResponse QueryInnerGroupMemberListWithOptions(QueryInnerGroupMemberListRequest request, QueryInnerGroupMemberListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryInnerGroupMemberList",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/memberLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInnerGroupMemberListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取群成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerGroupMemberListRequest
        /// </param>
        /// <param name="headers">
        /// QueryInnerGroupMemberListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerGroupMemberListResponse
        /// </returns>
        public async Task<QueryInnerGroupMemberListResponse> QueryInnerGroupMemberListWithOptionsAsync(QueryInnerGroupMemberListRequest request, QueryInnerGroupMemberListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryInnerGroupMemberList",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/memberLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInnerGroupMemberListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取群成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerGroupMemberListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerGroupMemberListResponse
        /// </returns>
        public QueryInnerGroupMemberListResponse QueryInnerGroupMemberList(QueryInnerGroupMemberListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInnerGroupMemberListHeaders headers = new QueryInnerGroupMemberListHeaders();
            return QueryInnerGroupMemberListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>读取群成员列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerGroupMemberListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerGroupMemberListResponse
        /// </returns>
        public async Task<QueryInnerGroupMemberListResponse> QueryInnerGroupMemberListAsync(QueryInnerGroupMemberListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInnerGroupMemberListHeaders headers = new QueryInnerGroupMemberListHeaders();
            return await QueryInnerGroupMemberListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近活跃的企业内部群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerGroupRecentListRequest
        /// </param>
        /// <param name="headers">
        /// QueryInnerGroupRecentListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerGroupRecentListResponse
        /// </returns>
        public QueryInnerGroupRecentListResponse QueryInnerGroupRecentListWithOptions(QueryInnerGroupRecentListRequest request, QueryInnerGroupRecentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryInnerGroupRecentList",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/recentLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInnerGroupRecentListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近活跃的企业内部群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerGroupRecentListRequest
        /// </param>
        /// <param name="headers">
        /// QueryInnerGroupRecentListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerGroupRecentListResponse
        /// </returns>
        public async Task<QueryInnerGroupRecentListResponse> QueryInnerGroupRecentListWithOptionsAsync(QueryInnerGroupRecentListRequest request, QueryInnerGroupRecentListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryInnerGroupRecentList",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/innerGroups/recentLists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInnerGroupRecentListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近活跃的企业内部群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerGroupRecentListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerGroupRecentListResponse
        /// </returns>
        public QueryInnerGroupRecentListResponse QueryInnerGroupRecentList(QueryInnerGroupRecentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInnerGroupRecentListHeaders headers = new QueryInnerGroupRecentListHeaders();
            return QueryInnerGroupRecentListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询最近活跃的企业内部群列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInnerGroupRecentListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInnerGroupRecentListResponse
        /// </returns>
        public async Task<QueryInnerGroupRecentListResponse> QueryInnerGroupRecentListAsync(QueryInnerGroupRecentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInnerGroupRecentListHeaders headers = new QueryInnerGroupRecentListHeaders();
            return await QueryInnerGroupRecentListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内具有指定群角色的所有群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMembersOfGroupRoleRequest
        /// </param>
        /// <param name="headers">
        /// QueryMembersOfGroupRoleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMembersOfGroupRoleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内具有指定群角色的所有群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMembersOfGroupRoleRequest
        /// </param>
        /// <param name="headers">
        /// QueryMembersOfGroupRoleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMembersOfGroupRoleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内具有指定群角色的所有群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMembersOfGroupRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMembersOfGroupRoleResponse
        /// </returns>
        public QueryMembersOfGroupRoleResponse QueryMembersOfGroupRole(QueryMembersOfGroupRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMembersOfGroupRoleHeaders headers = new QueryMembersOfGroupRoleHeaders();
            return QueryMembersOfGroupRoleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内具有指定群角色的所有群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMembersOfGroupRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMembersOfGroupRoleResponse
        /// </returns>
        public async Task<QueryMembersOfGroupRoleResponse> QueryMembersOfGroupRoleAsync(QueryMembersOfGroupRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMembersOfGroupRoleHeaders headers = new QueryMembersOfGroupRoleHeaders();
            return await QueryMembersOfGroupRoleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据openTaskId查询消息发送结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMessageSendResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryMessageSendResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageSendResultResponse
        /// </returns>
        public QueryMessageSendResultResponse QueryMessageSendResultWithOptions(QueryMessageSendResultRequest request, QueryMessageSendResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTaskId))
            {
                body["openTaskId"] = request.OpenTaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryMessageSendResult",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/messages/sendResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMessageSendResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据openTaskId查询消息发送结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMessageSendResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryMessageSendResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageSendResultResponse
        /// </returns>
        public async Task<QueryMessageSendResultResponse> QueryMessageSendResultWithOptionsAsync(QueryMessageSendResultRequest request, QueryMessageSendResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenTaskId))
            {
                body["openTaskId"] = request.OpenTaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryMessageSendResult",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/messages/sendResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMessageSendResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据openTaskId查询消息发送结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMessageSendResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageSendResultResponse
        /// </returns>
        public QueryMessageSendResultResponse QueryMessageSendResult(QueryMessageSendResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMessageSendResultHeaders headers = new QueryMessageSendResultHeaders();
            return QueryMessageSendResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据openTaskId查询消息发送结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryMessageSendResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageSendResultResponse
        /// </returns>
        public async Task<QueryMessageSendResultResponse> QueryMessageSendResultAsync(QueryMessageSendResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMessageSendResultHeaders headers = new QueryMessageSendResultHeaders();
            return await QueryMessageSendResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据单聊会话及发送方获取接收方用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOpenConversationReceiveUserRequest
        /// </param>
        /// <param name="headers">
        /// QueryOpenConversationReceiveUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOpenConversationReceiveUserResponse
        /// </returns>
        public QueryOpenConversationReceiveUserResponse QueryOpenConversationReceiveUserWithOptions(QueryOpenConversationReceiveUserRequest request, QueryOpenConversationReceiveUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendUserId))
            {
                body["sendUserId"] = request.SendUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryOpenConversationReceiveUser",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/otoChat/receiveUsers/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOpenConversationReceiveUserResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据单聊会话及发送方获取接收方用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOpenConversationReceiveUserRequest
        /// </param>
        /// <param name="headers">
        /// QueryOpenConversationReceiveUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOpenConversationReceiveUserResponse
        /// </returns>
        public async Task<QueryOpenConversationReceiveUserResponse> QueryOpenConversationReceiveUserWithOptionsAsync(QueryOpenConversationReceiveUserRequest request, QueryOpenConversationReceiveUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendUserId))
            {
                body["sendUserId"] = request.SendUserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryOpenConversationReceiveUser",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/otoChat/receiveUsers/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOpenConversationReceiveUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据单聊会话及发送方获取接收方用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOpenConversationReceiveUserRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOpenConversationReceiveUserResponse
        /// </returns>
        public QueryOpenConversationReceiveUserResponse QueryOpenConversationReceiveUser(QueryOpenConversationReceiveUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOpenConversationReceiveUserHeaders headers = new QueryOpenConversationReceiveUserHeaders();
            return QueryOpenConversationReceiveUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据单聊会话及发送方获取接收方用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOpenConversationReceiveUserRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOpenConversationReceiveUserResponse
        /// </returns>
        public async Task<QueryOpenConversationReceiveUserResponse> QueryOpenConversationReceiveUserAsync(QueryOpenConversationReceiveUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOpenConversationReceiveUserHeaders headers = new QueryOpenConversationReceiveUserHeaders();
            return await QueryOpenConversationReceiveUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOpenGroupBaseInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryOpenGroupBaseInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOpenGroupBaseInfoResponse
        /// </returns>
        public QueryOpenGroupBaseInfoResponse QueryOpenGroupBaseInfoWithOptions(QueryOpenGroupBaseInfoRequest request, QueryOpenGroupBaseInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryOpenGroupBaseInfo",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/baseInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOpenGroupBaseInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOpenGroupBaseInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryOpenGroupBaseInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOpenGroupBaseInfoResponse
        /// </returns>
        public async Task<QueryOpenGroupBaseInfoResponse> QueryOpenGroupBaseInfoWithOptionsAsync(QueryOpenGroupBaseInfoRequest request, QueryOpenGroupBaseInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryOpenGroupBaseInfo",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/groups/baseInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOpenGroupBaseInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOpenGroupBaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOpenGroupBaseInfoResponse
        /// </returns>
        public QueryOpenGroupBaseInfoResponse QueryOpenGroupBaseInfo(QueryOpenGroupBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOpenGroupBaseInfoHeaders headers = new QueryOpenGroupBaseInfoHeaders();
            return QueryOpenGroupBaseInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取群基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryOpenGroupBaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOpenGroupBaseInfoResponse
        /// </returns>
        public async Task<QueryOpenGroupBaseInfoResponse> QueryOpenGroupBaseInfoAsync(QueryOpenGroupBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryOpenGroupBaseInfoHeaders headers = new QueryOpenGroupBaseInfoHeaders();
            return await QueryOpenGroupBaseInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户身份查询消息已读未读状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPersonalMessageReadStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryPersonalMessageReadStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPersonalMessageReadStatusResponse
        /// </returns>
        public QueryPersonalMessageReadStatusResponse QueryPersonalMessageReadStatusWithOptions(QueryPersonalMessageReadStatusRequest request, QueryPersonalMessageReadStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMessageId))
            {
                body["openMessageId"] = request.OpenMessageId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryPersonalMessageReadStatus",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/me/messages/readStatuses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPersonalMessageReadStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户身份查询消息已读未读状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPersonalMessageReadStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryPersonalMessageReadStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPersonalMessageReadStatusResponse
        /// </returns>
        public async Task<QueryPersonalMessageReadStatusResponse> QueryPersonalMessageReadStatusWithOptionsAsync(QueryPersonalMessageReadStatusRequest request, QueryPersonalMessageReadStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenMessageId))
            {
                body["openMessageId"] = request.OpenMessageId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryPersonalMessageReadStatus",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/me/messages/readStatuses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPersonalMessageReadStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户身份查询消息已读未读状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPersonalMessageReadStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPersonalMessageReadStatusResponse
        /// </returns>
        public QueryPersonalMessageReadStatusResponse QueryPersonalMessageReadStatus(QueryPersonalMessageReadStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPersonalMessageReadStatusHeaders headers = new QueryPersonalMessageReadStatusHeaders();
            return QueryPersonalMessageReadStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户身份查询消息已读未读状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPersonalMessageReadStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPersonalMessageReadStatusResponse
        /// </returns>
        public async Task<QueryPersonalMessageReadStatusResponse> QueryPersonalMessageReadStatusAsync(QueryPersonalMessageReadStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPersonalMessageReadStatusHeaders headers = new QueryPersonalMessageReadStatusHeaders();
            return await QueryPersonalMessageReadStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近联系人及群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecentConversationsRequest
        /// </param>
        /// <param name="headers">
        /// QueryRecentConversationsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRecentConversationsResponse
        /// </returns>
        public QueryRecentConversationsResponse QueryRecentConversationsWithOptions(QueryRecentConversationsRequest request, QueryRecentConversationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyHuman))
            {
                body["onlyHuman"] = request.OnlyHuman;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyInnerGroup))
            {
                body["onlyInnerGroup"] = request.OnlyInnerGroup;
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
                Action = "QueryRecentConversations",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/recentLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecentConversationsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近联系人及群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecentConversationsRequest
        /// </param>
        /// <param name="headers">
        /// QueryRecentConversationsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRecentConversationsResponse
        /// </returns>
        public async Task<QueryRecentConversationsResponse> QueryRecentConversationsWithOptionsAsync(QueryRecentConversationsRequest request, QueryRecentConversationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyHuman))
            {
                body["onlyHuman"] = request.OnlyHuman;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyInnerGroup))
            {
                body["onlyInnerGroup"] = request.OnlyInnerGroup;
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
                Action = "QueryRecentConversations",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/conversations/recentLists/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRecentConversationsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近联系人及群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecentConversationsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRecentConversationsResponse
        /// </returns>
        public QueryRecentConversationsResponse QueryRecentConversations(QueryRecentConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRecentConversationsHeaders headers = new QueryRecentConversationsHeaders();
            return QueryRecentConversationsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近联系人及群组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRecentConversationsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRecentConversationsResponse
        /// </returns>
        public async Task<QueryRecentConversationsResponse> QueryRecentConversationsAsync(QueryRecentConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRecentConversationsHeaders headers = new QueryRecentConversationsHeaders();
            return await QueryRecentConversationsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内群模板机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySceneGroupTemplateRobotRequest
        /// </param>
        /// <param name="headers">
        /// QuerySceneGroupTemplateRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySceneGroupTemplateRobotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内群模板机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySceneGroupTemplateRobotRequest
        /// </param>
        /// <param name="headers">
        /// QuerySceneGroupTemplateRobotHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySceneGroupTemplateRobotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内群模板机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySceneGroupTemplateRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySceneGroupTemplateRobotResponse
        /// </returns>
        public QuerySceneGroupTemplateRobotResponse QuerySceneGroupTemplateRobot(QuerySceneGroupTemplateRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySceneGroupTemplateRobotHeaders headers = new QuerySceneGroupTemplateRobotHeaders();
            return QuerySceneGroupTemplateRobotWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群内群模板机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySceneGroupTemplateRobotRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySceneGroupTemplateRobotResponse
        /// </returns>
        public async Task<QuerySceneGroupTemplateRobotResponse> QuerySceneGroupTemplateRobotAsync(QuerySceneGroupTemplateRobotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySceneGroupTemplateRobotHeaders headers = new QuerySceneGroupTemplateRobotHeaders();
            return await QuerySceneGroupTemplateRobotWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleGroupRequest
        /// </param>
        /// <param name="headers">
        /// QuerySingleGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleGroupRequest
        /// </param>
        /// <param name="headers">
        /// QuerySingleGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleGroupResponse
        /// </returns>
        public QuerySingleGroupResponse QuerySingleGroup(QuerySingleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySingleGroupHeaders headers = new QuerySingleGroupHeaders();
            return QuerySingleGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询群信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySingleGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleGroupResponse
        /// </returns>
        public async Task<QuerySingleGroupResponse> QuerySingleGroupAsync(QuerySingleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySingleGroupHeaders headers = new QuerySingleGroupHeaders();
            return await QuerySingleGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询未读消息数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnReadMessageRequest
        /// </param>
        /// <param name="headers">
        /// QueryUnReadMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUnReadMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询未读消息数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnReadMessageRequest
        /// </param>
        /// <param name="headers">
        /// QueryUnReadMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUnReadMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询未读消息数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnReadMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUnReadMessageResponse
        /// </returns>
        public QueryUnReadMessageResponse QueryUnReadMessage(QueryUnReadMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnReadMessageHeaders headers = new QueryUnReadMessageHeaders();
            return QueryUnReadMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询未读消息数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnReadMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUnReadMessageResponse
        /// </returns>
        public async Task<QueryUnReadMessageResponse> QueryUnReadMessageAsync(QueryUnReadMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnReadMessageHeaders headers = new QueryUnReadMessageHeaders();
            return await QueryUnReadMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询链接查询链接增强注册信息创建者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnfurlingRegisterCreatorRequest
        /// </param>
        /// <param name="headers">
        /// QueryUnfurlingRegisterCreatorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUnfurlingRegisterCreatorResponse
        /// </returns>
        public QueryUnfurlingRegisterCreatorResponse QueryUnfurlingRegisterCreatorWithOptions(QueryUnfurlingRegisterCreatorRequest request, QueryUnfurlingRegisterCreatorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryUnfurlingRegisterCreator",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/creators",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnfurlingRegisterCreatorResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询链接查询链接增强注册信息创建者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnfurlingRegisterCreatorRequest
        /// </param>
        /// <param name="headers">
        /// QueryUnfurlingRegisterCreatorHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUnfurlingRegisterCreatorResponse
        /// </returns>
        public async Task<QueryUnfurlingRegisterCreatorResponse> QueryUnfurlingRegisterCreatorWithOptionsAsync(QueryUnfurlingRegisterCreatorRequest request, QueryUnfurlingRegisterCreatorHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["path"] = request.Path;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryUnfurlingRegisterCreator",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/creators",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnfurlingRegisterCreatorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询链接查询链接增强注册信息创建者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnfurlingRegisterCreatorRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUnfurlingRegisterCreatorResponse
        /// </returns>
        public QueryUnfurlingRegisterCreatorResponse QueryUnfurlingRegisterCreator(QueryUnfurlingRegisterCreatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnfurlingRegisterCreatorHeaders headers = new QueryUnfurlingRegisterCreatorHeaders();
            return QueryUnfurlingRegisterCreatorWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询链接查询链接增强注册信息创建者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnfurlingRegisterCreatorRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUnfurlingRegisterCreatorResponse
        /// </returns>
        public async Task<QueryUnfurlingRegisterCreatorResponse> QueryUnfurlingRegisterCreatorAsync(QueryUnfurlingRegisterCreatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnfurlingRegisterCreatorHeaders headers = new QueryUnfurlingRegisterCreatorHeaders();
            return await QueryUnfurlingRegisterCreatorWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询链接增强注册信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnfurlingRegisterInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryUnfurlingRegisterInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUnfurlingRegisterInfoResponse
        /// </returns>
        public QueryUnfurlingRegisterInfoResponse QueryUnfurlingRegisterInfoWithOptions(QueryUnfurlingRegisterInfoRequest request, QueryUnfurlingRegisterInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
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
                Action = "QueryUnfurlingRegisterInfo",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnfurlingRegisterInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询链接增强注册信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnfurlingRegisterInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryUnfurlingRegisterInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUnfurlingRegisterInfoResponse
        /// </returns>
        public async Task<QueryUnfurlingRegisterInfoResponse> QueryUnfurlingRegisterInfoWithOptionsAsync(QueryUnfurlingRegisterInfoRequest request, QueryUnfurlingRegisterInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
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
                Action = "QueryUnfurlingRegisterInfo",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUnfurlingRegisterInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询链接增强注册信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnfurlingRegisterInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUnfurlingRegisterInfoResponse
        /// </returns>
        public QueryUnfurlingRegisterInfoResponse QueryUnfurlingRegisterInfo(QueryUnfurlingRegisterInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnfurlingRegisterInfoHeaders headers = new QueryUnfurlingRegisterInfoHeaders();
            return QueryUnfurlingRegisterInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询链接增强注册信息列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUnfurlingRegisterInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUnfurlingRegisterInfoResponse
        /// </returns>
        public async Task<QueryUnfurlingRegisterInfoResponse> QueryUnfurlingRegisterInfoAsync(QueryUnfurlingRegisterInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUnfurlingRegisterInfoHeaders headers = new QueryUnfurlingRegisterInfoHeaders();
            return await QueryUnfurlingRegisterInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则发布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseUnfurlingRegisterResponse
        /// </returns>
        public ReleaseUnfurlingRegisterResponse ReleaseUnfurlingRegisterWithOptions(ReleaseUnfurlingRegisterRequest request, ReleaseUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
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
                Action = "ReleaseUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseUnfurlingRegisterResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则发布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// ReleaseUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseUnfurlingRegisterResponse
        /// </returns>
        public async Task<ReleaseUnfurlingRegisterResponse> ReleaseUnfurlingRegisterWithOptionsAsync(ReleaseUnfurlingRegisterRequest request, ReleaseUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
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
                Action = "ReleaseUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/publish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseUnfurlingRegisterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则发布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseUnfurlingRegisterResponse
        /// </returns>
        public ReleaseUnfurlingRegisterResponse ReleaseUnfurlingRegister(ReleaseUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseUnfurlingRegisterHeaders headers = new ReleaseUnfurlingRegisterHeaders();
            return ReleaseUnfurlingRegisterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则发布</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseUnfurlingRegisterResponse
        /// </returns>
        public async Task<ReleaseUnfurlingRegisterResponse> ReleaseUnfurlingRegisterAsync(ReleaseUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ReleaseUnfurlingRegisterHeaders headers = new ReleaseUnfurlingRegisterHeaders();
            return await ReleaseUnfurlingRegisterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除会话机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveRobotFromConversationRequest
        /// </param>
        /// <param name="headers">
        /// RemoveRobotFromConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveRobotFromConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除会话机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveRobotFromConversationRequest
        /// </param>
        /// <param name="headers">
        /// RemoveRobotFromConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveRobotFromConversationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除会话机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveRobotFromConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveRobotFromConversationResponse
        /// </returns>
        public RemoveRobotFromConversationResponse RemoveRobotFromConversation(RemoveRobotFromConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveRobotFromConversationHeaders headers = new RemoveRobotFromConversationHeaders();
            return RemoveRobotFromConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除会话机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveRobotFromConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveRobotFromConversationResponse
        /// </returns>
        public async Task<RemoveRobotFromConversationResponse> RemoveRobotFromConversationAsync(RemoveRobotFromConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveRobotFromConversationHeaders headers = new RemoveRobotFromConversationHeaders();
            return await RemoveRobotFromConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据关键词搜索企业内部群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInnerGroupsRequest
        /// </param>
        /// <param name="headers">
        /// SearchInnerGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchInnerGroupsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据关键词搜索企业内部群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInnerGroupsRequest
        /// </param>
        /// <param name="headers">
        /// SearchInnerGroupsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchInnerGroupsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据关键词搜索企业内部群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInnerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchInnerGroupsResponse
        /// </returns>
        public SearchInnerGroupsResponse SearchInnerGroups(SearchInnerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchInnerGroupsHeaders headers = new SearchInnerGroupsHeaders();
            return SearchInnerGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据关键词搜索企业内部群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInnerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchInnerGroupsResponse
        /// </returns>
        public async Task<SearchInnerGroupsResponse> SearchInnerGroupsAsync(SearchInnerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SearchInnerGroupsHeaders headers = new SearchInnerGroupsHeaders();
            return await SearchInnerGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// SendInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// SendInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendInteractiveCardResponse
        /// </returns>
        public SendInteractiveCardResponse SendInteractiveCard(SendInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
            return SendInteractiveCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendInteractiveCardResponse
        /// </returns>
        public async Task<SendInteractiveCardResponse> SendInteractiveCardAsync(SendInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
            return await SendInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人与人单聊发送可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOTOInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// SendOTOInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOTOInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人与人单聊发送可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOTOInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// SendOTOInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOTOInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人与人单聊发送可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOTOInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOTOInteractiveCardResponse
        /// </returns>
        public SendOTOInteractiveCardResponse SendOTOInteractiveCard(SendOTOInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendOTOInteractiveCardHeaders headers = new SendOTOInteractiveCardHeaders();
            return SendOTOInteractiveCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人与人单聊发送可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOTOInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOTOInteractiveCardResponse
        /// </returns>
        public async Task<SendOTOInteractiveCardResponse> SendOTOInteractiveCardAsync(SendOTOInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendOTOInteractiveCardHeaders headers = new SendOTOInteractiveCardHeaders();
            return await SendOTOInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendPersonalMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendPersonalMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendPersonalMessageResponse
        /// </returns>
        public SendPersonalMessageResponse SendPersonalMessageWithOptions(SendPersonalMessageRequest request, SendPersonalMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgType))
            {
                body["msgType"] = request.MsgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUid))
            {
                body["receiverUid"] = request.ReceiverUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendPersonalMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/me/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendPersonalMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendPersonalMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendPersonalMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendPersonalMessageResponse
        /// </returns>
        public async Task<SendPersonalMessageResponse> SendPersonalMessageWithOptionsAsync(SendPersonalMessageRequest request, SendPersonalMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgType))
            {
                body["msgType"] = request.MsgType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                body["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverUid))
            {
                body["receiverUid"] = request.ReceiverUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SendPersonalMessage",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/me/messages/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendPersonalMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendPersonalMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendPersonalMessageResponse
        /// </returns>
        public SendPersonalMessageResponse SendPersonalMessage(SendPersonalMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendPersonalMessageHeaders headers = new SendPersonalMessageHeaders();
            return SendPersonalMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>委托权限发消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendPersonalMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendPersonalMessageResponse
        /// </returns>
        public async Task<SendPersonalMessageResponse> SendPersonalMessageAsync(SendPersonalMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendPersonalMessageHeaders headers = new SendPersonalMessageHeaders();
            return await SendPersonalMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送互动卡片（普通版）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// SendRobotInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendRobotInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送互动卡片（普通版）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// SendRobotInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendRobotInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送互动卡片（普通版）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendRobotInteractiveCardResponse
        /// </returns>
        public SendRobotInteractiveCardResponse SendRobotInteractiveCard(SendRobotInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotInteractiveCardHeaders headers = new SendRobotInteractiveCardHeaders();
            return SendRobotInteractiveCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送互动卡片（普通版）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendRobotInteractiveCardResponse
        /// </returns>
        public async Task<SendRobotInteractiveCardResponse> SendRobotInteractiveCardAsync(SendRobotInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotInteractiveCardHeaders headers = new SendRobotInteractiveCardHeaders();
            return await SendRobotInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendRobotMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendRobotMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendRobotMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendRobotMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendRobotMessageResponse
        /// </returns>
        public SendRobotMessageResponse SendRobotMessage(SendRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotMessageHeaders headers = new SendRobotMessageHeaders();
            return SendRobotMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人发送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendRobotMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendRobotMessageResponse
        /// </returns>
        public async Task<SendRobotMessageResponse> SendRobotMessageAsync(SendRobotMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendRobotMessageHeaders headers = new SendRobotMessageHeaders();
            return await SendRobotMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送模板响应式可交互式卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendTemplateInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// SendTemplateInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendTemplateInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送模板响应式可交互式卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendTemplateInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// SendTemplateInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendTemplateInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送模板响应式可交互式卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendTemplateInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendTemplateInteractiveCardResponse
        /// </returns>
        public SendTemplateInteractiveCardResponse SendTemplateInteractiveCard(SendTemplateInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendTemplateInteractiveCardHeaders headers = new SendTemplateInteractiveCardHeaders();
            return SendTemplateInteractiveCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送模板响应式可交互式卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendTemplateInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendTemplateInteractiveCardResponse
        /// </returns>
        public async Task<SendTemplateInteractiveCardResponse> SendTemplateInteractiveCardAsync(SendTemplateInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendTemplateInteractiveCardHeaders headers = new SendTemplateInteractiveCardHeaders();
            return await SendTemplateInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置侧边栏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRightPanelRequest
        /// </param>
        /// <param name="headers">
        /// SetRightPanelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRightPanelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置侧边栏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRightPanelRequest
        /// </param>
        /// <param name="headers">
        /// SetRightPanelHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRightPanelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置侧边栏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRightPanelRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRightPanelResponse
        /// </returns>
        public SetRightPanelResponse SetRightPanel(SetRightPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRightPanelHeaders headers = new SetRightPanelHeaders();
            return SetRightPanelWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置侧边栏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRightPanelRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRightPanelResponse
        /// </returns>
        public async Task<SetRightPanelResponse> SetRightPanelAsync(SetRightPanelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SetRightPanelHeaders headers = new SetRightPanelHeaders();
            return await SetRightPanelWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉吊顶卡片关闭</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TopboxCloseRequest
        /// </param>
        /// <param name="headers">
        /// TopboxCloseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TopboxCloseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉吊顶卡片关闭</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TopboxCloseRequest
        /// </param>
        /// <param name="headers">
        /// TopboxCloseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TopboxCloseResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉吊顶卡片关闭</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TopboxCloseRequest
        /// </param>
        /// 
        /// <returns>
        /// TopboxCloseResponse
        /// </returns>
        public TopboxCloseResponse TopboxClose(TopboxCloseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TopboxCloseHeaders headers = new TopboxCloseHeaders();
            return TopboxCloseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉吊顶卡片关闭</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TopboxCloseRequest
        /// </param>
        /// 
        /// <returns>
        /// TopboxCloseResponse
        /// </returns>
        public async Task<TopboxCloseResponse> TopboxCloseAsync(TopboxCloseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TopboxCloseHeaders headers = new TopboxCloseHeaders();
            return await TopboxCloseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉吊顶卡片开启</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TopboxOpenRequest
        /// </param>
        /// <param name="headers">
        /// TopboxOpenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TopboxOpenResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉吊顶卡片开启</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TopboxOpenRequest
        /// </param>
        /// <param name="headers">
        /// TopboxOpenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TopboxOpenResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉吊顶卡片开启</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TopboxOpenRequest
        /// </param>
        /// 
        /// <returns>
        /// TopboxOpenResponse
        /// </returns>
        public TopboxOpenResponse TopboxOpen(TopboxOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TopboxOpenHeaders headers = new TopboxOpenHeaders();
            return TopboxOpenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉吊顶卡片开启</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TopboxOpenRequest
        /// </param>
        /// 
        /// <returns>
        /// TopboxOpenResponse
        /// </returns>
        public async Task<TopboxOpenResponse> TopboxOpenAsync(TopboxOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TopboxOpenHeaders headers = new TopboxOpenHeaders();
            return await TopboxOpenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改群头像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupAvatarRequest
        /// </param>
        /// <param name="headers">
        /// UpdateGroupAvatarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupAvatarResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改群头像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupAvatarRequest
        /// </param>
        /// <param name="headers">
        /// UpdateGroupAvatarHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupAvatarResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改群头像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupAvatarRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupAvatarResponse
        /// </returns>
        public UpdateGroupAvatarResponse UpdateGroupAvatar(UpdateGroupAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupAvatarHeaders headers = new UpdateGroupAvatarHeaders();
            return UpdateGroupAvatarWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改群头像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupAvatarRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupAvatarResponse
        /// </returns>
        public async Task<UpdateGroupAvatarResponse> UpdateGroupAvatarAsync(UpdateGroupAvatarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupAvatarHeaders headers = new UpdateGroupAvatarHeaders();
            return await UpdateGroupAvatarWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改群名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupNameRequest
        /// </param>
        /// <param name="headers">
        /// UpdateGroupNameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupNameResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改群名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupNameRequest
        /// </param>
        /// <param name="headers">
        /// UpdateGroupNameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupNameResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改群名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupNameResponse
        /// </returns>
        public UpdateGroupNameResponse UpdateGroupName(UpdateGroupNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupNameHeaders headers = new UpdateGroupNameHeaders();
            return UpdateGroupNameWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改群名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupNameResponse
        /// </returns>
        public async Task<UpdateGroupNameResponse> UpdateGroupNameAsync(UpdateGroupNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupNameHeaders headers = new UpdateGroupNameHeaders();
            return await UpdateGroupNameWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置场景群权限项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupPermissionRequest
        /// </param>
        /// <param name="headers">
        /// UpdateGroupPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置场景群权限项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupPermissionRequest
        /// </param>
        /// <param name="headers">
        /// UpdateGroupPermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置场景群权限项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupPermissionResponse
        /// </returns>
        public UpdateGroupPermissionResponse UpdateGroupPermission(UpdateGroupPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupPermissionHeaders headers = new UpdateGroupPermissionHeaders();
            return UpdateGroupPermissionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置场景群权限项</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupPermissionResponse
        /// </returns>
        public async Task<UpdateGroupPermissionResponse> UpdateGroupPermissionAsync(UpdateGroupPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupPermissionHeaders headers = new UpdateGroupPermissionHeaders();
            return await UpdateGroupPermissionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupSubAdminRequest
        /// </param>
        /// <param name="headers">
        /// UpdateGroupSubAdminHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupSubAdminResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupSubAdminRequest
        /// </param>
        /// <param name="headers">
        /// UpdateGroupSubAdminHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupSubAdminResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupSubAdminRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupSubAdminResponse
        /// </returns>
        public UpdateGroupSubAdminResponse UpdateGroupSubAdmin(UpdateGroupSubAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupSubAdminHeaders headers = new UpdateGroupSubAdminHeaders();
            return UpdateGroupSubAdminWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群管理员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupSubAdminRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupSubAdminResponse
        /// </returns>
        public async Task<UpdateGroupSubAdminResponse> UpdateGroupSubAdminAsync(UpdateGroupSubAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateGroupSubAdminHeaders headers = new UpdateGroupSubAdminHeaders();
            return await UpdateGroupSubAdminWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInteractiveCardResponse
        /// </returns>
        public UpdateInteractiveCardResponse UpdateInteractiveCard(UpdateInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
            return UpdateInteractiveCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新可交互式动态卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInteractiveCardResponse
        /// </returns>
        public async Task<UpdateInteractiveCardResponse> UpdateInteractiveCardAsync(UpdateInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
            return await UpdateInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群成员禁言状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberBanWordsRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMemberBanWordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberBanWordsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群成员禁言状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberBanWordsRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMemberBanWordsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberBanWordsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群成员禁言状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberBanWordsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberBanWordsResponse
        /// </returns>
        public UpdateMemberBanWordsResponse UpdateMemberBanWords(UpdateMemberBanWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberBanWordsHeaders headers = new UpdateMemberBanWordsHeaders();
            return UpdateMemberBanWordsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群成员禁言状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberBanWordsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberBanWordsResponse
        /// </returns>
        public async Task<UpdateMemberBanWordsResponse> UpdateMemberBanWordsAsync(UpdateMemberBanWordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberBanWordsHeaders headers = new UpdateMemberBanWordsHeaders();
            return await UpdateMemberBanWordsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群成员的群昵称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberGroupNickRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMemberGroupNickHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberGroupNickResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群成员的群昵称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberGroupNickRequest
        /// </param>
        /// <param name="headers">
        /// UpdateMemberGroupNickHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberGroupNickResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群成员的群昵称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberGroupNickRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberGroupNickResponse
        /// </returns>
        public UpdateMemberGroupNickResponse UpdateMemberGroupNick(UpdateMemberGroupNickRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberGroupNickHeaders headers = new UpdateMemberGroupNickHeaders();
            return UpdateMemberGroupNickWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新群成员的群昵称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMemberGroupNickRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMemberGroupNickResponse
        /// </returns>
        public async Task<UpdateMemberGroupNickResponse> UpdateMemberGroupNickAsync(UpdateMemberGroupNickRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateMemberGroupNickHeaders headers = new UpdateMemberGroupNickHeaders();
            return await UpdateMemberGroupNickWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改组织里的机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRobotInOrgRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRobotInOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRobotInOrgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改组织里的机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRobotInOrgRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRobotInOrgHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRobotInOrgResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改组织里的机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRobotInOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRobotInOrgResponse
        /// </returns>
        public UpdateRobotInOrgResponse UpdateRobotInOrg(UpdateRobotInOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRobotInOrgHeaders headers = new UpdateRobotInOrgHeaders();
            return UpdateRobotInOrgWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改组织里的机器人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRobotInOrgRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRobotInOrgResponse
        /// </returns>
        public async Task<UpdateRobotInOrgResponse> UpdateRobotInOrgAsync(UpdateRobotInOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRobotInOrgHeaders headers = new UpdateRobotInOrgHeaders();
            return await UpdateRobotInOrgWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人更新可交互式卡片(个人、企业)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRobotInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRobotInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRobotInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人更新可交互式卡片(个人、企业)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRobotInteractiveCardRequest
        /// </param>
        /// <param name="headers">
        /// UpdateRobotInteractiveCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRobotInteractiveCardResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人更新可交互式卡片(个人、企业)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRobotInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRobotInteractiveCardResponse
        /// </returns>
        public UpdateRobotInteractiveCardResponse UpdateRobotInteractiveCard(UpdateRobotInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRobotInteractiveCardHeaders headers = new UpdateRobotInteractiveCardHeaders();
            return UpdateRobotInteractiveCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>机器人更新可交互式卡片(个人、企业)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRobotInteractiveCardRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRobotInteractiveCardResponse
        /// </returns>
        public async Task<UpdateRobotInteractiveCardResponse> UpdateRobotInteractiveCardAsync(UpdateRobotInteractiveCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateRobotInteractiveCardHeaders headers = new UpdateRobotInteractiveCardHeaders();
            return await UpdateRobotInteractiveCardWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群成员的群角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTheGroupRolesOfGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTheGroupRolesOfGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTheGroupRolesOfGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群成员的群角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTheGroupRolesOfGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// UpdateTheGroupRolesOfGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTheGroupRolesOfGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群成员的群角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTheGroupRolesOfGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTheGroupRolesOfGroupMemberResponse
        /// </returns>
        public UpdateTheGroupRolesOfGroupMemberResponse UpdateTheGroupRolesOfGroupMember(UpdateTheGroupRolesOfGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTheGroupRolesOfGroupMemberHeaders headers = new UpdateTheGroupRolesOfGroupMemberHeaders();
            return UpdateTheGroupRolesOfGroupMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置群成员的群角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTheGroupRolesOfGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTheGroupRolesOfGroupMemberResponse
        /// </returns>
        public async Task<UpdateTheGroupRolesOfGroupMemberResponse> UpdateTheGroupRolesOfGroupMemberAsync(UpdateTheGroupRolesOfGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateTheGroupRolesOfGroupMemberHeaders headers = new UpdateTheGroupRolesOfGroupMemberHeaders();
            return await UpdateTheGroupRolesOfGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑链接增强注册规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// UpdateUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUnfurlingRegisterResponse
        /// </returns>
        public UpdateUnfurlingRegisterResponse UpdateUnfurlingRegisterWithOptions(UpdateUnfurlingRegisterRequest request, UpdateUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSecret))
            {
                body["apiSecret"] = request.ApiSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleDesc))
            {
                body["ruleDesc"] = request.RuleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleMatchType))
            {
                body["ruleMatchType"] = request.RuleMatchType;
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
                Action = "UpdateUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUnfurlingRegisterResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑链接增强注册规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUnfurlingRegisterRequest
        /// </param>
        /// <param name="headers">
        /// UpdateUnfurlingRegisterHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUnfurlingRegisterResponse
        /// </returns>
        public async Task<UpdateUnfurlingRegisterResponse> UpdateUnfurlingRegisterWithOptionsAsync(UpdateUnfurlingRegisterRequest request, UpdateUnfurlingRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiSecret))
            {
                body["apiSecret"] = request.ApiSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["callbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardTemplateId))
            {
                body["cardTemplateId"] = request.CardTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                body["domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleDesc))
            {
                body["ruleDesc"] = request.RuleDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleMatchType))
            {
                body["ruleMatchType"] = request.RuleMatchType;
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
                Action = "UpdateUnfurlingRegister",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUnfurlingRegisterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑链接增强注册规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUnfurlingRegisterResponse
        /// </returns>
        public UpdateUnfurlingRegisterResponse UpdateUnfurlingRegister(UpdateUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUnfurlingRegisterHeaders headers = new UpdateUnfurlingRegisterHeaders();
            return UpdateUnfurlingRegisterWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑链接增强注册规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUnfurlingRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUnfurlingRegisterResponse
        /// </returns>
        public async Task<UpdateUnfurlingRegisterResponse> UpdateUnfurlingRegisterAsync(UpdateUnfurlingRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUnfurlingRegisterHeaders headers = new UpdateUnfurlingRegisterHeaders();
            return await UpdateUnfurlingRegisterWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则状态更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUnfurlingRegisterStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateUnfurlingRegisterStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUnfurlingRegisterStatusResponse
        /// </returns>
        public UpdateUnfurlingRegisterStatusResponse UpdateUnfurlingRegisterStatusWithOptions(UpdateUnfurlingRegisterStatusRequest request, UpdateUnfurlingRegisterStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "UpdateUnfurlingRegisterStatus",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/statuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUnfurlingRegisterStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则状态更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUnfurlingRegisterStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateUnfurlingRegisterStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUnfurlingRegisterStatusResponse
        /// </returns>
        public async Task<UpdateUnfurlingRegisterStatusResponse> UpdateUnfurlingRegisterStatusWithOptionsAsync(UpdateUnfurlingRegisterStatusRequest request, UpdateUnfurlingRegisterStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "UpdateUnfurlingRegisterStatus",
                Version = "im_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/im/unfurling/rules/statuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUnfurlingRegisterStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则状态更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUnfurlingRegisterStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUnfurlingRegisterStatusResponse
        /// </returns>
        public UpdateUnfurlingRegisterStatusResponse UpdateUnfurlingRegisterStatus(UpdateUnfurlingRegisterStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUnfurlingRegisterStatusHeaders headers = new UpdateUnfurlingRegisterStatusHeaders();
            return UpdateUnfurlingRegisterStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>链接增强规则状态更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUnfurlingRegisterStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUnfurlingRegisterStatusResponse
        /// </returns>
        public async Task<UpdateUnfurlingRegisterStatusResponse> UpdateUnfurlingRegisterStatusAsync(UpdateUnfurlingRegisterStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUnfurlingRegisterStatusHeaders headers = new UpdateUnfurlingRegisterStatusHeaders();
            return await UpdateUnfurlingRegisterStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// AddGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// AddGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddGroupMemberResponse
        /// </returns>
        public AddGroupMemberResponse AddGroupMember(AddGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddGroupMemberHeaders headers = new AddGroupMemberHeaders();
            return AddGroupMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// AddGroupMemberResponse
        /// </returns>
        public async Task<AddGroupMemberResponse> AddGroupMemberAsync(AddGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddGroupMemberHeaders headers = new AddGroupMemberHeaders();
            return await AddGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// RemoveGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveGroupMemberRequest
        /// </param>
        /// <param name="headers">
        /// RemoveGroupMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveGroupMemberResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveGroupMemberResponse
        /// </returns>
        public RemoveGroupMemberResponse RemoveGroupMember(RemoveGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveGroupMemberHeaders headers = new RemoveGroupMemberHeaders();
            return RemoveGroupMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除群成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveGroupMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveGroupMemberResponse
        /// </returns>
        public async Task<RemoveGroupMemberResponse> RemoveGroupMemberAsync(RemoveGroupMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RemoveGroupMemberHeaders headers = new RemoveGroupMemberHeaders();
            return await RemoveGroupMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送ToC消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendDingMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendDingMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendDingMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送ToC消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendDingMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendDingMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendDingMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送ToC消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendDingMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendDingMessageResponse
        /// </returns>
        public SendDingMessageResponse SendDingMessage(SendDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendDingMessageHeaders headers = new SendDingMessageHeaders();
            return SendDingMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送ToC消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendDingMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendDingMessageResponse
        /// </returns>
        public async Task<SendDingMessageResponse> SendDingMessageAsync(SendDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendDingMessageHeaders headers = new SendDingMessageHeaders();
            return await SendDingMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送ToB消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送ToB消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送ToB消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageHeaders headers = new SendMessageHeaders();
            return SendMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送ToB消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public async Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageHeaders headers = new SendMessageHeaders();
            return await SendMessageWithOptionsAsync(request, headers, runtime);
        }

    }
}
