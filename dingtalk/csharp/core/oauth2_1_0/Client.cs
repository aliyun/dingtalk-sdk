// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0
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
        /// <para>生成jsapi ticket</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CreateJsapiTicketHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJsapiTicketResponse
        /// </returns>
        public CreateJsapiTicketResponse CreateJsapiTicketWithOptions(CreateJsapiTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateJsapiTicket",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/jsapiTickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJsapiTicketResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成jsapi ticket</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// CreateJsapiTicketHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJsapiTicketResponse
        /// </returns>
        public async Task<CreateJsapiTicketResponse> CreateJsapiTicketWithOptionsAsync(CreateJsapiTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateJsapiTicket",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/jsapiTickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJsapiTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成jsapi ticket</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateJsapiTicketResponse
        /// </returns>
        public CreateJsapiTicketResponse CreateJsapiTicket()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateJsapiTicketHeaders headers = new CreateJsapiTicketHeaders();
            return CreateJsapiTicketWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成jsapi ticket</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateJsapiTicketResponse
        /// </returns>
        public async Task<CreateJsapiTicketResponse> CreateJsapiTicketAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateJsapiTicketHeaders headers = new CreateJsapiTicketHeaders();
            return await CreateJsapiTicketWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业accessToken(企业内部应用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public GetAccessTokenResponse GetAccessTokenWithOptions(GetAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                body["appSecret"] = request.AppSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/accessToken",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessTokenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业accessToken(企业内部应用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public async Task<GetAccessTokenResponse> GetAccessTokenWithOptionsAsync(GetAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSecret))
            {
                body["appSecret"] = request.AppSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/accessToken",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业accessToken(企业内部应用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAccessTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业accessToken(企业内部应用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessTokenResponse
        /// </returns>
        public async Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAccessTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业开通应用后的授权信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAuthInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetAuthInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAuthInfoResponse
        /// </returns>
        public GetAuthInfoResponse GetAuthInfoWithOptions(GetAuthInfoRequest request, GetAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCorpId))
            {
                query["authCorpId"] = request.AuthCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetAuthInfo",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/apps/authInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业开通应用后的授权信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAuthInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetAuthInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAuthInfoResponse
        /// </returns>
        public async Task<GetAuthInfoResponse> GetAuthInfoWithOptionsAsync(GetAuthInfoRequest request, GetAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCorpId))
            {
                query["authCorpId"] = request.AuthCorpId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetAuthInfo",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/apps/authInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业开通应用后的授权信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAuthInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAuthInfoResponse
        /// </returns>
        public GetAuthInfoResponse GetAuthInfo(GetAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAuthInfoHeaders headers = new GetAuthInfoHeaders();
            return GetAuthInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业开通应用后的授权信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAuthInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAuthInfoResponse
        /// </returns>
        public async Task<GetAuthInfoResponse> GetAuthInfoAsync(GetAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAuthInfoHeaders headers = new GetAuthInfoHeaders();
            return await GetAuthInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业accessToken(应用商店应用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpAccessTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpAccessTokenResponse
        /// </returns>
        public GetCorpAccessTokenResponse GetCorpAccessTokenWithOptions(GetCorpAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCorpId))
            {
                body["authCorpId"] = request.AuthCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteSecret))
            {
                body["suiteSecret"] = request.SuiteSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteTicket))
            {
                body["suiteTicket"] = request.SuiteTicket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCorpAccessToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/corpAccessToken",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpAccessTokenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业accessToken(应用商店应用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpAccessTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpAccessTokenResponse
        /// </returns>
        public async Task<GetCorpAccessTokenResponse> GetCorpAccessTokenWithOptionsAsync(GetCorpAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCorpId))
            {
                body["authCorpId"] = request.AuthCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteSecret))
            {
                body["suiteSecret"] = request.SuiteSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteTicket))
            {
                body["suiteTicket"] = request.SuiteTicket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCorpAccessToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/corpAccessToken",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpAccessTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业accessToken(应用商店应用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCorpAccessTokenResponse
        /// </returns>
        public GetCorpAccessTokenResponse GetCorpAccessToken(GetCorpAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCorpAccessTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业accessToken(应用商店应用)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCorpAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCorpAccessTokenResponse
        /// </returns>
        public async Task<GetCorpAccessTokenResponse> GetCorpAccessTokenAsync(GetCorpAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCorpAccessTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个人授权记录</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetPersonalAuthRuleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPersonalAuthRuleResponse
        /// </returns>
        public GetPersonalAuthRuleResponse GetPersonalAuthRuleWithOptions(GetPersonalAuthRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPersonalAuthRule",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/authRules/user",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPersonalAuthRuleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个人授权记录</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetPersonalAuthRuleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPersonalAuthRuleResponse
        /// </returns>
        public async Task<GetPersonalAuthRuleResponse> GetPersonalAuthRuleWithOptionsAsync(GetPersonalAuthRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetPersonalAuthRule",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/authRules/user",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPersonalAuthRuleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个人授权记录</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPersonalAuthRuleResponse
        /// </returns>
        public GetPersonalAuthRuleResponse GetPersonalAuthRule()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalAuthRuleHeaders headers = new GetPersonalAuthRuleHeaders();
            return GetPersonalAuthRuleWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个人授权记录</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPersonalAuthRuleResponse
        /// </returns>
        public async Task<GetPersonalAuthRuleResponse> GetPersonalAuthRuleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalAuthRuleHeaders headers = new GetPersonalAuthRuleHeaders();
            return await GetPersonalAuthRuleWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成微应用管理后台accessToken</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSsoAccessTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSsoAccessTokenResponse
        /// </returns>
        public GetSsoAccessTokenResponse GetSsoAccessTokenWithOptions(GetSsoAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Corpid))
            {
                body["corpid"] = request.Corpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoSecret))
            {
                body["ssoSecret"] = request.SsoSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSsoAccessToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/ssoAccessToken",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSsoAccessTokenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成微应用管理后台accessToken</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSsoAccessTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSsoAccessTokenResponse
        /// </returns>
        public async Task<GetSsoAccessTokenResponse> GetSsoAccessTokenWithOptionsAsync(GetSsoAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Corpid))
            {
                body["corpid"] = request.Corpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SsoSecret))
            {
                body["ssoSecret"] = request.SsoSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSsoAccessToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/ssoAccessToken",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSsoAccessTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成微应用管理后台accessToken</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSsoAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSsoAccessTokenResponse
        /// </returns>
        public GetSsoAccessTokenResponse GetSsoAccessToken(GetSsoAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSsoAccessTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成微应用管理后台accessToken</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSsoAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSsoAccessTokenResponse
        /// </returns>
        public async Task<GetSsoAccessTokenResponse> GetSsoAccessTokenAsync(GetSsoAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSsoAccessTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询微应用后台免登的用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSsoUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetSsoUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSsoUserInfoResponse
        /// </returns>
        public GetSsoUserInfoResponse GetSsoUserInfoWithOptions(GetSsoUserInfoRequest request, GetSsoUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSsoUserInfo",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/ssoUserInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSsoUserInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询微应用后台免登的用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSsoUserInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetSsoUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSsoUserInfoResponse
        /// </returns>
        public async Task<GetSsoUserInfoResponse> GetSsoUserInfoWithOptionsAsync(GetSsoUserInfoRequest request, GetSsoUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetSsoUserInfo",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/ssoUserInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSsoUserInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询微应用后台免登的用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSsoUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSsoUserInfoResponse
        /// </returns>
        public GetSsoUserInfoResponse GetSsoUserInfo(GetSsoUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSsoUserInfoHeaders headers = new GetSsoUserInfoHeaders();
            return GetSsoUserInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询微应用后台免登的用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSsoUserInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSsoUserInfoResponse
        /// </returns>
        public async Task<GetSsoUserInfoResponse> GetSsoUserInfoAsync(GetSsoUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSsoUserInfoHeaders headers = new GetSsoUserInfoHeaders();
            return await GetSsoUserInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取isvAccessToken（三方企业应用）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuiteAccessTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSuiteAccessTokenResponse
        /// </returns>
        public GetSuiteAccessTokenResponse GetSuiteAccessTokenWithOptions(GetSuiteAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteSecret))
            {
                body["suiteSecret"] = request.SuiteSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteTicket))
            {
                body["suiteTicket"] = request.SuiteTicket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSuiteAccessToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/suiteAccessToken",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSuiteAccessTokenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取isvAccessToken（三方企业应用）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuiteAccessTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSuiteAccessTokenResponse
        /// </returns>
        public async Task<GetSuiteAccessTokenResponse> GetSuiteAccessTokenWithOptionsAsync(GetSuiteAccessTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteSecret))
            {
                body["suiteSecret"] = request.SuiteSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteTicket))
            {
                body["suiteTicket"] = request.SuiteTicket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSuiteAccessToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/suiteAccessToken",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSuiteAccessTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取isvAccessToken（三方企业应用）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuiteAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSuiteAccessTokenResponse
        /// </returns>
        public GetSuiteAccessTokenResponse GetSuiteAccessToken(GetSuiteAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSuiteAccessTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取isvAccessToken（三方企业应用）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSuiteAccessTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSuiteAccessTokenResponse
        /// </returns>
        public async Task<GetSuiteAccessTokenResponse> GetSuiteAccessTokenAsync(GetSuiteAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSuiteAccessTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Access Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public GetTokenResponse GetTokenWithOptions(string corpId, GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["client_id"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                body["client_secret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                body["grant_type"] = request.GrantType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/" + corpId + "/token",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Access Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public async Task<GetTokenResponse> GetTokenWithOptionsAsync(string corpId, GetTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["client_id"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                body["client_secret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                body["grant_type"] = request.GrantType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/" + corpId + "/token",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Access Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public GetTokenResponse GetToken(string corpId, GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTokenWithOptions(corpId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取Access Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public async Task<GetTokenResponse> GetTokenAsync(string corpId, GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTokenWithOptionsAsync(corpId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserTokenResponse
        /// </returns>
        public GetUserTokenResponse GetUserTokenWithOptions(GetUserTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                body["clientSecret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                body["grantType"] = request.GrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshToken))
            {
                body["refreshToken"] = request.RefreshToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/userAccessToken",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserTokenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserTokenResponse
        /// </returns>
        public async Task<GetUserTokenResponse> GetUserTokenWithOptionsAsync(GetUserTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                body["clientSecret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantType))
            {
                body["grantType"] = request.GrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshToken))
            {
                body["refreshToken"] = request.RefreshToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserToken",
                Version = "oauth2_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/oauth2/userAccessToken",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserTokenResponse
        /// </returns>
        public GetUserTokenResponse GetUserToken(GetUserTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserTokenResponse
        /// </returns>
        public async Task<GetUserTokenResponse> GetUserTokenAsync(GetUserTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserTokenWithOptionsAsync(request, headers, runtime);
        }

    }
}
