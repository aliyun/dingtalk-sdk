// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkai_global_e_c_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkai_global_e_c_1_0
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
        /// <para>全渠道运营客服tiktok消息接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConnectionOmniChannelTiktokMessageRequest
        /// </param>
        /// <param name="headers">
        /// ConnectionOmniChannelTiktokMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConnectionOmniChannelTiktokMessageResponse
        /// </returns>
        public ConnectionOmniChannelTiktokMessageResponse ConnectionOmniChannelTiktokMessageWithOptions(ConnectionOmniChannelTiktokMessageRequest request, ConnectionOmniChannelTiktokMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TiktokContentJsonString))
            {
                body["tiktokContentJsonString"] = request.TiktokContentJsonString;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConnectionOmniChannelTiktokMessage",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/omniChannel/tiktok/im/message/process",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConnectionOmniChannelTiktokMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全渠道运营客服tiktok消息接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConnectionOmniChannelTiktokMessageRequest
        /// </param>
        /// <param name="headers">
        /// ConnectionOmniChannelTiktokMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConnectionOmniChannelTiktokMessageResponse
        /// </returns>
        public async Task<ConnectionOmniChannelTiktokMessageResponse> ConnectionOmniChannelTiktokMessageWithOptionsAsync(ConnectionOmniChannelTiktokMessageRequest request, ConnectionOmniChannelTiktokMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TiktokContentJsonString))
            {
                body["tiktokContentJsonString"] = request.TiktokContentJsonString;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConnectionOmniChannelTiktokMessage",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/omniChannel/tiktok/im/message/process",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConnectionOmniChannelTiktokMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全渠道运营客服tiktok消息接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConnectionOmniChannelTiktokMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ConnectionOmniChannelTiktokMessageResponse
        /// </returns>
        public ConnectionOmniChannelTiktokMessageResponse ConnectionOmniChannelTiktokMessage(ConnectionOmniChannelTiktokMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConnectionOmniChannelTiktokMessageHeaders headers = new ConnectionOmniChannelTiktokMessageHeaders();
            return ConnectionOmniChannelTiktokMessageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全渠道运营客服tiktok消息接入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConnectionOmniChannelTiktokMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ConnectionOmniChannelTiktokMessageResponse
        /// </returns>
        public async Task<ConnectionOmniChannelTiktokMessageResponse> ConnectionOmniChannelTiktokMessageAsync(ConnectionOmniChannelTiktokMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConnectionOmniChannelTiktokMessageHeaders headers = new ConnectionOmniChannelTiktokMessageHeaders();
            return await ConnectionOmniChannelTiktokMessageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前登录用户版本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginUserRequest
        /// </param>
        /// <param name="headers">
        /// GetLoginUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoginUserResponse
        /// </returns>
        public GetLoginUserResponse GetLoginUserWithOptions(GetLoginUserRequest request, GetLoginUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginUser",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/authCode/getLoginUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginUserResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前登录用户版本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginUserRequest
        /// </param>
        /// <param name="headers">
        /// GetLoginUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLoginUserResponse
        /// </returns>
        public async Task<GetLoginUserResponse> GetLoginUserWithOptionsAsync(GetLoginUserRequest request, GetLoginUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLoginUser",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/authCode/getLoginUser",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoginUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前登录用户版本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoginUserResponse
        /// </returns>
        public GetLoginUserResponse GetLoginUser(GetLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLoginUserHeaders headers = new GetLoginUserHeaders();
            return GetLoginUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前登录用户版本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLoginUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLoginUserResponse
        /// </returns>
        public async Task<GetLoginUserResponse> GetLoginUserAsync(GetLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLoginUserHeaders headers = new GetLoginUserHeaders();
            return await GetLoginUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刊登的对外开放Api</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LaunchRequest
        /// </param>
        /// <param name="headers">
        /// LaunchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LaunchResponse
        /// </returns>
        public LaunchResponse LaunchWithOptions(LaunchRequest request, LaunchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingAgentId))
            {
                query["dingAgentId"] = request.DingAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                query["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                query["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                query["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                query["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                query["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUid))
            {
                query["dingUid"] = request.DingUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrls))
            {
                body["imageUrls"] = request.ImageUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellingPoints))
            {
                body["sellingPoints"] = request.SellingPoints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceData))
            {
                body["sourceData"] = request.SourceData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variants))
            {
                body["variants"] = request.Variants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrls))
            {
                body["videoUrls"] = request.VideoUrls;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "Launch",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/launch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LaunchResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刊登的对外开放Api</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LaunchRequest
        /// </param>
        /// <param name="headers">
        /// LaunchHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LaunchResponse
        /// </returns>
        public async Task<LaunchResponse> LaunchWithOptionsAsync(LaunchRequest request, LaunchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingAgentId))
            {
                query["dingAgentId"] = request.DingAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingClientId))
            {
                query["dingClientId"] = request.DingClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                query["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                query["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                query["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                query["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUid))
            {
                query["dingUid"] = request.DingUid;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrls))
            {
                body["imageUrls"] = request.ImageUrls;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellingPoints))
            {
                body["sellingPoints"] = request.SellingPoints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceData))
            {
                body["sourceData"] = request.SourceData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variants))
            {
                body["variants"] = request.Variants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrls))
            {
                body["videoUrls"] = request.VideoUrls;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "Launch",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/launch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LaunchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刊登的对外开放Api</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LaunchRequest
        /// </param>
        /// 
        /// <returns>
        /// LaunchResponse
        /// </returns>
        public LaunchResponse Launch(LaunchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LaunchHeaders headers = new LaunchHeaders();
            return LaunchWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刊登的对外开放Api</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LaunchRequest
        /// </param>
        /// 
        /// <returns>
        /// LaunchResponse
        /// </returns>
        public async Task<LaunchResponse> LaunchAsync(LaunchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LaunchHeaders headers = new LaunchHeaders();
            return await LaunchWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全渠道AI表格业务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryNotableInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryNotableInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryNotableInfoResponse
        /// </returns>
        public QueryNotableInfoResponse QueryNotableInfoWithOptions(QueryNotableInfoRequest request, QueryNotableInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["sceneCode"] = request.SceneCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryNotableInfo",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/omniChannel/notable",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryNotableInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全渠道AI表格业务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryNotableInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryNotableInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryNotableInfoResponse
        /// </returns>
        public async Task<QueryNotableInfoResponse> QueryNotableInfoWithOptionsAsync(QueryNotableInfoRequest request, QueryNotableInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["sceneCode"] = request.SceneCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryNotableInfo",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/omniChannel/notable",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryNotableInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全渠道AI表格业务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryNotableInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryNotableInfoResponse
        /// </returns>
        public QueryNotableInfoResponse QueryNotableInfo(QueryNotableInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryNotableInfoHeaders headers = new QueryNotableInfoHeaders();
            return QueryNotableInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全渠道AI表格业务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryNotableInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryNotableInfoResponse
        /// </returns>
        public async Task<QueryNotableInfoResponse> QueryNotableInfoAsync(QueryNotableInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryNotableInfoHeaders headers = new QueryNotableInfoHeaders();
            return await QueryNotableInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>平台店铺授权回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TiktokShopAuthCallbackRequest
        /// </param>
        /// <param name="headers">
        /// TiktokShopAuthCallbackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TiktokShopAuthCallbackResponse
        /// </returns>
        public TiktokShopAuthCallbackResponse TiktokShopAuthCallbackWithOptions(TiktokShopAuthCallbackRequest request, TiktokShopAuthCallbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerType))
            {
                body["sellerType"] = request.SellerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShopId))
            {
                body["shopId"] = request.ShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShopName))
            {
                body["shopName"] = request.ShopName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShopRegion))
            {
                body["shopRegion"] = request.ShopRegion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TiktokShopAuthCallback",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/omniChannel/tiktok/shop/authCallback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TiktokShopAuthCallbackResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>平台店铺授权回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TiktokShopAuthCallbackRequest
        /// </param>
        /// <param name="headers">
        /// TiktokShopAuthCallbackHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TiktokShopAuthCallbackResponse
        /// </returns>
        public async Task<TiktokShopAuthCallbackResponse> TiktokShopAuthCallbackWithOptionsAsync(TiktokShopAuthCallbackRequest request, TiktokShopAuthCallbackHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellerType))
            {
                body["sellerType"] = request.SellerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShopId))
            {
                body["shopId"] = request.ShopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShopName))
            {
                body["shopName"] = request.ShopName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShopRegion))
            {
                body["shopRegion"] = request.ShopRegion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TiktokShopAuthCallback",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/omniChannel/tiktok/shop/authCallback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TiktokShopAuthCallbackResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>平台店铺授权回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TiktokShopAuthCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// TiktokShopAuthCallbackResponse
        /// </returns>
        public TiktokShopAuthCallbackResponse TiktokShopAuthCallback(TiktokShopAuthCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TiktokShopAuthCallbackHeaders headers = new TiktokShopAuthCallbackHeaders();
            return TiktokShopAuthCallbackWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>平台店铺授权回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TiktokShopAuthCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// TiktokShopAuthCallbackResponse
        /// </returns>
        public async Task<TiktokShopAuthCallbackResponse> TiktokShopAuthCallbackAsync(TiktokShopAuthCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TiktokShopAuthCallbackHeaders headers = new TiktokShopAuthCallbackHeaders();
            return await TiktokShopAuthCallbackWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全渠道运营Tiktok的Webhook信息写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TiktokWebhookProcessRequest
        /// </param>
        /// <param name="headers">
        /// TiktokWebhookProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TiktokWebhookProcessResponse
        /// </returns>
        public TiktokWebhookProcessResponse TiktokWebhookProcessWithOptions(TiktokWebhookProcessRequest request, TiktokWebhookProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TiktokContentJsonString))
            {
                body["tiktokContentJsonString"] = request.TiktokContentJsonString;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TiktokWebhookProcess",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/omniChannel/tiktok/webhook/process",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TiktokWebhookProcessResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全渠道运营Tiktok的Webhook信息写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TiktokWebhookProcessRequest
        /// </param>
        /// <param name="headers">
        /// TiktokWebhookProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TiktokWebhookProcessResponse
        /// </returns>
        public async Task<TiktokWebhookProcessResponse> TiktokWebhookProcessWithOptionsAsync(TiktokWebhookProcessRequest request, TiktokWebhookProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TiktokContentJsonString))
            {
                body["tiktokContentJsonString"] = request.TiktokContentJsonString;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TiktokWebhookProcess",
                Version = "aiGlobalEC_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/aiGlobalEC/omniChannel/tiktok/webhook/process",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<TiktokWebhookProcessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全渠道运营Tiktok的Webhook信息写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TiktokWebhookProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// TiktokWebhookProcessResponse
        /// </returns>
        public TiktokWebhookProcessResponse TiktokWebhookProcess(TiktokWebhookProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TiktokWebhookProcessHeaders headers = new TiktokWebhookProcessHeaders();
            return TiktokWebhookProcessWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>全渠道运营Tiktok的Webhook信息写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TiktokWebhookProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// TiktokWebhookProcessResponse
        /// </returns>
        public async Task<TiktokWebhookProcessResponse> TiktokWebhookProcessAsync(TiktokWebhookProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            TiktokWebhookProcessHeaders headers = new TiktokWebhookProcessHeaders();
            return await TiktokWebhookProcessWithOptionsAsync(request, headers, runtime);
        }

    }
}
