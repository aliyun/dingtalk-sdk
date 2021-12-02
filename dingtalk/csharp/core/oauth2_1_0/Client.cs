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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public CreateJsapiTicketResponse CreateJsapiTicket(CreateJsapiTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateJsapiTicketHeaders headers = new CreateJsapiTicketHeaders();
            return CreateJsapiTicketWithOptions(request, headers, runtime);
        }

        public async Task<CreateJsapiTicketResponse> CreateJsapiTicketAsync(CreateJsapiTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateJsapiTicketHeaders headers = new CreateJsapiTicketHeaders();
            return await CreateJsapiTicketWithOptionsAsync(request, headers, runtime);
        }

        public CreateJsapiTicketResponse CreateJsapiTicketWithOptions(CreateJsapiTicketRequest request, CreateJsapiTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateJsapiTicketResponse>(DoROARequest("CreateJsapiTicket", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/jsapiTickets", "json", req, runtime));
        }

        public async Task<CreateJsapiTicketResponse> CreateJsapiTicketWithOptionsAsync(CreateJsapiTicketRequest request, CreateJsapiTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                body["agentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOauthAppId))
            {
                body["dingOauthAppId"] = request.DingOauthAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTokenGrantType))
            {
                body["dingTokenGrantType"] = request.DingTokenGrantType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateJsapiTicketResponse>(await DoROARequestAsync("CreateJsapiTicket", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/jsapiTickets", "json", req, runtime));
        }

        public GetAccessTokenResponse GetAccessToken(GetAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAccessTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetAccessTokenResponse> GetAccessTokenAsync(GetAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAccessTokenWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetAccessTokenResponse>(DoROARequest("GetAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/accessToken", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetAccessTokenResponse>(await DoROARequestAsync("GetAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/accessToken", "json", req, runtime));
        }

        public GetAuthInfoResponse GetAuthInfo(GetAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAuthInfoHeaders headers = new GetAuthInfoHeaders();
            return GetAuthInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetAuthInfoResponse> GetAuthInfoAsync(GetAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAuthInfoHeaders headers = new GetAuthInfoHeaders();
            return await GetAuthInfoWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetAuthInfoResponse>(DoROARequest("GetAuthInfo", "oauth2_1.0", "HTTP", "GET", "AK", "/v1.0/oauth2/apps/authInfo", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetAuthInfoResponse>(await DoROARequestAsync("GetAuthInfo", "oauth2_1.0", "HTTP", "GET", "AK", "/v1.0/oauth2/apps/authInfo", "json", req, runtime));
        }

        public GetCorpAccessTokenResponse GetCorpAccessToken(GetCorpAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCorpAccessTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetCorpAccessTokenResponse> GetCorpAccessTokenAsync(GetCorpAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCorpAccessTokenWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetCorpAccessTokenResponse>(DoROARequest("GetCorpAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/corpAccessToken", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetCorpAccessTokenResponse>(await DoROARequestAsync("GetCorpAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/corpAccessToken", "json", req, runtime));
        }

        public GetPersonalAuthRuleResponse GetPersonalAuthRule()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalAuthRuleHeaders headers = new GetPersonalAuthRuleHeaders();
            return GetPersonalAuthRuleWithOptions(headers, runtime);
        }

        public async Task<GetPersonalAuthRuleResponse> GetPersonalAuthRuleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalAuthRuleHeaders headers = new GetPersonalAuthRuleHeaders();
            return await GetPersonalAuthRuleWithOptionsAsync(headers, runtime);
        }

        public GetPersonalAuthRuleResponse GetPersonalAuthRuleWithOptions(GetPersonalAuthRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetPersonalAuthRuleResponse>(DoROARequest("GetPersonalAuthRule", "oauth2_1.0", "HTTP", "GET", "AK", "/v1.0/oauth2/authRules/user", "json", req, runtime));
        }

        public async Task<GetPersonalAuthRuleResponse> GetPersonalAuthRuleWithOptionsAsync(GetPersonalAuthRuleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<GetPersonalAuthRuleResponse>(await DoROARequestAsync("GetPersonalAuthRule", "oauth2_1.0", "HTTP", "GET", "AK", "/v1.0/oauth2/authRules/user", "json", req, runtime));
        }

        public GetSsoAccessTokenResponse GetSsoAccessToken(GetSsoAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSsoAccessTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetSsoAccessTokenResponse> GetSsoAccessTokenAsync(GetSsoAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSsoAccessTokenWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetSsoAccessTokenResponse>(DoROARequest("GetSsoAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/ssoAccessToken", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetSsoAccessTokenResponse>(await DoROARequestAsync("GetSsoAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/ssoAccessToken", "json", req, runtime));
        }

        public GetSsoUserInfoResponse GetSsoUserInfo(GetSsoUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSsoUserInfoHeaders headers = new GetSsoUserInfoHeaders();
            return GetSsoUserInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetSsoUserInfoResponse> GetSsoUserInfoAsync(GetSsoUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSsoUserInfoHeaders headers = new GetSsoUserInfoHeaders();
            return await GetSsoUserInfoWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSsoUserInfoResponse>(DoROARequest("GetSsoUserInfo", "oauth2_1.0", "HTTP", "GET", "AK", "/v1.0/oauth2/ssoUserInfo", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSsoUserInfoResponse>(await DoROARequestAsync("GetSsoUserInfo", "oauth2_1.0", "HTTP", "GET", "AK", "/v1.0/oauth2/ssoUserInfo", "json", req, runtime));
        }

        public GetSuiteAccessTokenResponse GetSuiteAccessToken(GetSuiteAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSuiteAccessTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetSuiteAccessTokenResponse> GetSuiteAccessTokenAsync(GetSuiteAccessTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSuiteAccessTokenWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetSuiteAccessTokenResponse>(DoROARequest("GetSuiteAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/suiteAccessToken", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetSuiteAccessTokenResponse>(await DoROARequestAsync("GetSuiteAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/suiteAccessToken", "json", req, runtime));
        }

        public GetUserTokenResponse GetUserToken(GetUserTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserTokenWithOptions(request, headers, runtime);
        }

        public async Task<GetUserTokenResponse> GetUserTokenAsync(GetUserTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserTokenWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetUserTokenResponse>(DoROARequest("GetUserToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/userAccessToken", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetUserTokenResponse>(await DoROARequestAsync("GetUserToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/userAccessToken", "json", req, runtime));
        }

    }
}
