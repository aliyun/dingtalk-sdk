// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkesign_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0
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


        public AuthUrlResponse AuthUrl(AuthUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthUrlHeaders headers = new AuthUrlHeaders();
            return AuthUrlWithOptions(request, headers, runtime);
        }

        public async Task<AuthUrlResponse> AuthUrlAsync(AuthUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthUrlHeaders headers = new AuthUrlHeaders();
            return await AuthUrlWithOptionsAsync(request, headers, runtime);
        }

        public AuthUrlResponse AuthUrlWithOptions(AuthUrlRequest request, AuthUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
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
            return TeaModel.ToObject<AuthUrlResponse>(DoROARequest("AuthUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/auths/url", "json", req, runtime));
        }

        public async Task<AuthUrlResponse> AuthUrlWithOptionsAsync(AuthUrlRequest request, AuthUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
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
            return TeaModel.ToObject<AuthUrlResponse>(await DoROARequestAsync("AuthUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/auths/url", "json", req, runtime));
        }

        public CancelCorpAuthResponse CancelCorpAuth()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
            return CancelCorpAuthWithOptions(headers, runtime);
        }

        public async Task<CancelCorpAuthResponse> CancelCorpAuthAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
            return await CancelCorpAuthWithOptionsAsync(headers, runtime);
        }

        public CancelCorpAuthResponse CancelCorpAuthWithOptions(CancelCorpAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<CancelCorpAuthResponse>(DoROARequest("CancelCorpAuth", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/auth/cancel", "json", req, runtime));
        }

        public async Task<CancelCorpAuthResponse> CancelCorpAuthWithOptionsAsync(CancelCorpAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<CancelCorpAuthResponse>(await DoROARequestAsync("CancelCorpAuth", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/auth/cancel", "json", req, runtime));
        }

        public ChannelOrderResponse ChannelOrder(ChannelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChannelOrderHeaders headers = new ChannelOrderHeaders();
            return ChannelOrderWithOptions(request, headers, runtime);
        }

        public async Task<ChannelOrderResponse> ChannelOrderAsync(ChannelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChannelOrderHeaders headers = new ChannelOrderHeaders();
            return await ChannelOrderWithOptionsAsync(request, headers, runtime);
        }

        public ChannelOrderResponse ChannelOrderWithOptions(ChannelOrderRequest request, ChannelOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemCode))
            {
                body["itemCode"] = request.ItemCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemName))
            {
                body["itemName"] = request.ItemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateTime))
            {
                body["orderCreateTime"] = request.OrderCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayFee))
            {
                body["payFee"] = request.PayFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                body["quantity"] = request.Quantity;
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
            return TeaModel.ToObject<ChannelOrderResponse>(DoROARequest("ChannelOrder", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/orders/channel", "json", req, runtime));
        }

        public async Task<ChannelOrderResponse> ChannelOrderWithOptionsAsync(ChannelOrderRequest request, ChannelOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemCode))
            {
                body["itemCode"] = request.ItemCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemName))
            {
                body["itemName"] = request.ItemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateTime))
            {
                body["orderCreateTime"] = request.OrderCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayFee))
            {
                body["payFee"] = request.PayFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                body["quantity"] = request.Quantity;
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
            return TeaModel.ToObject<ChannelOrderResponse>(await DoROARequestAsync("ChannelOrder", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/orders/channel", "json", req, runtime));
        }

        public ContractMarginResponse ContractMargin()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ContractMarginHeaders headers = new ContractMarginHeaders();
            return ContractMarginWithOptions(headers, runtime);
        }

        public async Task<ContractMarginResponse> ContractMarginAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ContractMarginHeaders headers = new ContractMarginHeaders();
            return await ContractMarginWithOptionsAsync(headers, runtime);
        }

        public ContractMarginResponse ContractMarginWithOptions(ContractMarginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ContractMarginResponse>(DoROARequest("ContractMargin", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/contracts/margin", "json", req, runtime));
        }

        public async Task<ContractMarginResponse> ContractMarginWithOptionsAsync(ContractMarginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ContractMarginResponse>(await DoROARequestAsync("ContractMargin", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/contracts/margin", "json", req, runtime));
        }

        public CorpConsoleResponse CorpConsole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpConsoleHeaders headers = new CorpConsoleHeaders();
            return CorpConsoleWithOptions(headers, runtime);
        }

        public async Task<CorpConsoleResponse> CorpConsoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpConsoleHeaders headers = new CorpConsoleHeaders();
            return await CorpConsoleWithOptionsAsync(headers, runtime);
        }

        public CorpConsoleResponse CorpConsoleWithOptions(CorpConsoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<CorpConsoleResponse>(DoROARequest("CorpConsole", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/console", "json", req, runtime));
        }

        public async Task<CorpConsoleResponse> CorpConsoleWithOptionsAsync(CorpConsoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<CorpConsoleResponse>(await DoROARequestAsync("CorpConsole", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/console", "json", req, runtime));
        }

        public CorpInfoResponse CorpInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpInfoHeaders headers = new CorpInfoHeaders();
            return CorpInfoWithOptions(headers, runtime);
        }

        public async Task<CorpInfoResponse> CorpInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpInfoHeaders headers = new CorpInfoHeaders();
            return await CorpInfoWithOptionsAsync(headers, runtime);
        }

        public CorpInfoResponse CorpInfoWithOptions(CorpInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<CorpInfoResponse>(DoROARequest("CorpInfo", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/info", "json", req, runtime));
        }

        public async Task<CorpInfoResponse> CorpInfoWithOptionsAsync(CorpInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<CorpInfoResponse>(await DoROARequestAsync("CorpInfo", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/info", "json", req, runtime));
        }

        public CreateDeveloperResponse CreateDeveloper(CreateDeveloperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeveloperHeaders headers = new CreateDeveloperHeaders();
            return CreateDeveloperWithOptions(request, headers, runtime);
        }

        public async Task<CreateDeveloperResponse> CreateDeveloperAsync(CreateDeveloperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeveloperHeaders headers = new CreateDeveloperHeaders();
            return await CreateDeveloperWithOptionsAsync(request, headers, runtime);
        }

        public CreateDeveloperResponse CreateDeveloperWithOptions(CreateDeveloperRequest request, CreateDeveloperHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
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
            return TeaModel.ToObject<CreateDeveloperResponse>(DoROARequest("CreateDeveloper", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/developers/create", "json", req, runtime));
        }

        public async Task<CreateDeveloperResponse> CreateDeveloperWithOptionsAsync(CreateDeveloperRequest request, CreateDeveloperHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
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
            return TeaModel.ToObject<CreateDeveloperResponse>(await DoROARequestAsync("CreateDeveloper", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/developers/create", "json", req, runtime));
        }

        public GetCorpRealnameUrlResponse GetCorpRealnameUrl(GetCorpRealnameUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpRealnameUrlHeaders headers = new GetCorpRealnameUrlHeaders();
            return GetCorpRealnameUrlWithOptions(request, headers, runtime);
        }

        public async Task<GetCorpRealnameUrlResponse> GetCorpRealnameUrlAsync(GetCorpRealnameUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpRealnameUrlHeaders headers = new GetCorpRealnameUrlHeaders();
            return await GetCorpRealnameUrlWithOptionsAsync(request, headers, runtime);
        }

        public GetCorpRealnameUrlResponse GetCorpRealnameUrlWithOptions(GetCorpRealnameUrlRequest request, GetCorpRealnameUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetCorpRealnameUrlResponse>(DoROARequest("GetCorpRealnameUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/corps/realname", "json", req, runtime));
        }

        public async Task<GetCorpRealnameUrlResponse> GetCorpRealnameUrlWithOptionsAsync(GetCorpRealnameUrlRequest request, GetCorpRealnameUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetCorpRealnameUrlResponse>(await DoROARequestAsync("GetCorpRealnameUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/corps/realname", "json", req, runtime));
        }

        public GetCropStatusResponse GetCropStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCropStatusHeaders headers = new GetCropStatusHeaders();
            return GetCropStatusWithOptions(headers, runtime);
        }

        public async Task<GetCropStatusResponse> GetCropStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCropStatusHeaders headers = new GetCropStatusHeaders();
            return await GetCropStatusWithOptionsAsync(headers, runtime);
        }

        public GetCropStatusResponse GetCropStatusWithOptions(GetCropStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetCropStatusResponse>(DoROARequest("GetCropStatus", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/statuses", "json", req, runtime));
        }

        public async Task<GetCropStatusResponse> GetCropStatusWithOptionsAsync(GetCropStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<GetCropStatusResponse>(await DoROARequestAsync("GetCropStatus", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/corps/statuses", "json", req, runtime));
        }

        public GetFileResponse GetFile(string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileHeaders headers = new GetFileHeaders();
            return GetFileWithOptions(fileId, headers, runtime);
        }

        public async Task<GetFileResponse> GetFileAsync(string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileHeaders headers = new GetFileHeaders();
            return await GetFileWithOptionsAsync(fileId, headers, runtime);
        }

        public GetFileResponse GetFileWithOptions(string fileId, GetFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
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
            return TeaModel.ToObject<GetFileResponse>(DoROARequest("GetFile", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/files/" + fileId, "json", req, runtime));
        }

        public async Task<GetFileResponse> GetFileWithOptionsAsync(string fileId, GetFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            fileId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(fileId);
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
            return TeaModel.ToObject<GetFileResponse>(await DoROARequestAsync("GetFile", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/files/" + fileId, "json", req, runtime));
        }

        public GetFlowDetailResponse GetFlowDetail(GetFlowDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
            return GetFlowDetailWithOptions(request, headers, runtime);
        }

        public async Task<GetFlowDetailResponse> GetFlowDetailAsync(GetFlowDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
            return await GetFlowDetailWithOptionsAsync(request, headers, runtime);
        }

        public GetFlowDetailResponse GetFlowDetailWithOptions(GetFlowDetailRequest request, GetFlowDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
            return TeaModel.ToObject<GetFlowDetailResponse>(DoROARequest("GetFlowDetail", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/flows/detail", "json", req, runtime));
        }

        public async Task<GetFlowDetailResponse> GetFlowDetailWithOptionsAsync(GetFlowDetailRequest request, GetFlowDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
            return TeaModel.ToObject<GetFlowDetailResponse>(await DoROARequestAsync("GetFlowDetail", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/flows/detail", "json", req, runtime));
        }

        public GetFlowSignDetailResponse GetFlowSignDetail(GetFlowSignDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowSignDetailHeaders headers = new GetFlowSignDetailHeaders();
            return GetFlowSignDetailWithOptions(request, headers, runtime);
        }

        public async Task<GetFlowSignDetailResponse> GetFlowSignDetailAsync(GetFlowSignDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowSignDetailHeaders headers = new GetFlowSignDetailHeaders();
            return await GetFlowSignDetailWithOptionsAsync(request, headers, runtime);
        }

        public GetFlowSignDetailResponse GetFlowSignDetailWithOptions(GetFlowSignDetailRequest request, GetFlowSignDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
            return TeaModel.ToObject<GetFlowSignDetailResponse>(DoROARequest("GetFlowSignDetail", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/flows/sign/detail", "json", req, runtime));
        }

        public async Task<GetFlowSignDetailResponse> GetFlowSignDetailWithOptionsAsync(GetFlowSignDetailRequest request, GetFlowSignDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
            return TeaModel.ToObject<GetFlowSignDetailResponse>(await DoROARequestAsync("GetFlowSignDetail", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/flows/sign/detail", "json", req, runtime));
        }

        public GetProcessStartUrlResponse GetProcessStartUrl(GetProcessStartUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessStartUrlHeaders headers = new GetProcessStartUrlHeaders();
            return GetProcessStartUrlWithOptions(request, headers, runtime);
        }

        public async Task<GetProcessStartUrlResponse> GetProcessStartUrlAsync(GetProcessStartUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessStartUrlHeaders headers = new GetProcessStartUrlHeaders();
            return await GetProcessStartUrlWithOptionsAsync(request, headers, runtime);
        }

        public GetProcessStartUrlResponse GetProcessStartUrlWithOptions(GetProcessStartUrlRequest request, GetProcessStartUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ccs))
            {
                body["ccs"] = request.Ccs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatorUserId))
            {
                body["initiatorUserId"] = request.InitiatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Participants))
            {
                body["participants"] = request.Participants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInfo.ToMap()))
            {
                body["sourceInfo"] = request.SourceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
            return TeaModel.ToObject<GetProcessStartUrlResponse>(DoROARequest("GetProcessStartUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/process/start", "json", req, runtime));
        }

        public async Task<GetProcessStartUrlResponse> GetProcessStartUrlWithOptionsAsync(GetProcessStartUrlRequest request, GetProcessStartUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ccs))
            {
                body["ccs"] = request.Ccs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatorUserId))
            {
                body["initiatorUserId"] = request.InitiatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Participants))
            {
                body["participants"] = request.Participants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInfo.ToMap()))
            {
                body["sourceInfo"] = request.SourceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
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
            return TeaModel.ToObject<GetProcessStartUrlResponse>(await DoROARequestAsync("GetProcessStartUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/process/start", "json", req, runtime));
        }

        public GetSignNoticeUrlResponse GetSignNoticeUrl(GetSignNoticeUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignNoticeUrlHeaders headers = new GetSignNoticeUrlHeaders();
            return GetSignNoticeUrlWithOptions(request, headers, runtime);
        }

        public async Task<GetSignNoticeUrlResponse> GetSignNoticeUrlAsync(GetSignNoticeUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignNoticeUrlHeaders headers = new GetSignNoticeUrlHeaders();
            return await GetSignNoticeUrlWithOptionsAsync(request, headers, runtime);
        }

        public GetSignNoticeUrlResponse GetSignNoticeUrlWithOptions(GetSignNoticeUrlRequest request, GetSignNoticeUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetSignNoticeUrlResponse>(DoROARequest("GetSignNoticeUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/signs/notice/url", "json", req, runtime));
        }

        public async Task<GetSignNoticeUrlResponse> GetSignNoticeUrlWithOptionsAsync(GetSignNoticeUrlRequest request, GetSignNoticeUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetSignNoticeUrlResponse>(await DoROARequestAsync("GetSignNoticeUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/signs/notice/url", "json", req, runtime));
        }

        public GetUploadUrlResponse GetUploadUrl(GetUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadUrlHeaders headers = new GetUploadUrlHeaders();
            return GetUploadUrlWithOptions(request, headers, runtime);
        }

        public async Task<GetUploadUrlResponse> GetUploadUrlAsync(GetUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadUrlHeaders headers = new GetUploadUrlHeaders();
            return await GetUploadUrlWithOptionsAsync(request, headers, runtime);
        }

        public GetUploadUrlResponse GetUploadUrlWithOptions(GetUploadUrlRequest request, GetUploadUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentMd5))
            {
                body["contentMd5"] = request.ContentMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Convert2Pdf))
            {
                body["convert2Pdf"] = request.Convert2Pdf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
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
            return TeaModel.ToObject<GetUploadUrlResponse>(DoROARequest("GetUploadUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/files/getUploadUrl", "json", req, runtime));
        }

        public async Task<GetUploadUrlResponse> GetUploadUrlWithOptionsAsync(GetUploadUrlRequest request, GetUploadUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentMd5))
            {
                body["contentMd5"] = request.ContentMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Convert2Pdf))
            {
                body["convert2Pdf"] = request.Convert2Pdf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
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
            return TeaModel.ToObject<GetUploadUrlResponse>(await DoROARequestAsync("GetUploadUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/files/getUploadUrl", "json", req, runtime));
        }

        public GetUserInfoResponse GetUserInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return GetUserInfoWithOptions(userId, headers, runtime);
        }

        public async Task<GetUserInfoResponse> GetUserInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return await GetUserInfoWithOptionsAsync(userId, headers, runtime);
        }

        public GetUserInfoResponse GetUserInfoWithOptions(string userId, GetUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<GetUserInfoResponse>(DoROARequest("GetUserInfo", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/users/" + userId, "json", req, runtime));
        }

        public async Task<GetUserInfoResponse> GetUserInfoWithOptionsAsync(string userId, GetUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            userId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(userId);
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
            return TeaModel.ToObject<GetUserInfoResponse>(await DoROARequestAsync("GetUserInfo", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/users/" + userId, "json", req, runtime));
        }

        public GetUserRealnameUrlResponse GetUserRealnameUrl(GetUserRealnameUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserRealnameUrlHeaders headers = new GetUserRealnameUrlHeaders();
            return GetUserRealnameUrlWithOptions(request, headers, runtime);
        }

        public async Task<GetUserRealnameUrlResponse> GetUserRealnameUrlAsync(GetUserRealnameUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserRealnameUrlHeaders headers = new GetUserRealnameUrlHeaders();
            return await GetUserRealnameUrlWithOptionsAsync(request, headers, runtime);
        }

        public GetUserRealnameUrlResponse GetUserRealnameUrlWithOptions(GetUserRealnameUrlRequest request, GetUserRealnameUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetUserRealnameUrlResponse>(DoROARequest("GetUserRealnameUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/users/realname", "json", req, runtime));
        }

        public async Task<GetUserRealnameUrlResponse> GetUserRealnameUrlWithOptionsAsync(GetUserRealnameUrlRequest request, GetUserRealnameUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<GetUserRealnameUrlResponse>(await DoROARequestAsync("GetUserRealnameUrl", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/users/realname", "json", req, runtime));
        }

        public ListFlowDocsResponse ListFlowDocs(ListFlowDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFlowDocsHeaders headers = new ListFlowDocsHeaders();
            return ListFlowDocsWithOptions(request, headers, runtime);
        }

        public async Task<ListFlowDocsResponse> ListFlowDocsAsync(ListFlowDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFlowDocsHeaders headers = new ListFlowDocsHeaders();
            return await ListFlowDocsWithOptionsAsync(request, headers, runtime);
        }

        public ListFlowDocsResponse ListFlowDocsWithOptions(ListFlowDocsRequest request, ListFlowDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
            return TeaModel.ToObject<ListFlowDocsResponse>(DoROARequest("ListFlowDocs", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/flows/docs", "json", req, runtime));
        }

        public async Task<ListFlowDocsResponse> ListFlowDocsWithOptionsAsync(ListFlowDocsRequest request, ListFlowDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
            return TeaModel.ToObject<ListFlowDocsResponse>(await DoROARequestAsync("ListFlowDocs", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/flows/docs", "json", req, runtime));
        }

        public ListSealApprovalResponse ListSealApproval(ListSealApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSealApprovalHeaders headers = new ListSealApprovalHeaders();
            return ListSealApprovalWithOptions(request, headers, runtime);
        }

        public async Task<ListSealApprovalResponse> ListSealApprovalAsync(ListSealApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSealApprovalHeaders headers = new ListSealApprovalHeaders();
            return await ListSealApprovalWithOptionsAsync(request, headers, runtime);
        }

        public ListSealApprovalResponse ListSealApprovalWithOptions(ListSealApprovalRequest request, ListSealApprovalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
            return TeaModel.ToObject<ListSealApprovalResponse>(DoROARequest("ListSealApproval", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/seals/approval/list", "json", req, runtime));
        }

        public async Task<ListSealApprovalResponse> ListSealApprovalWithOptionsAsync(ListSealApprovalRequest request, ListSealApprovalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
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
            return TeaModel.ToObject<ListSealApprovalResponse>(await DoROARequestAsync("ListSealApproval", "esign_1.0", "HTTP", "GET", "AK", "/v1.0/esign/seals/approval/list", "json", req, runtime));
        }

        public OrderResaleResponse OrderResale(OrderResaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderResaleHeaders headers = new OrderResaleHeaders();
            return OrderResaleWithOptions(request, headers, runtime);
        }

        public async Task<OrderResaleResponse> OrderResaleAsync(OrderResaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderResaleHeaders headers = new OrderResaleHeaders();
            return await OrderResaleWithOptionsAsync(request, headers, runtime);
        }

        public OrderResaleResponse OrderResaleWithOptions(OrderResaleRequest request, OrderResaleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateTime))
            {
                body["orderCreateTime"] = request.OrderCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                body["quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStartTime))
            {
                body["serviceStartTime"] = request.ServiceStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStopTime))
            {
                body["serviceStopTime"] = request.ServiceStopTime;
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
            return TeaModel.ToObject<OrderResaleResponse>(DoROARequest("OrderResale", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/orders/resale", "json", req, runtime));
        }

        public async Task<OrderResaleResponse> OrderResaleWithOptionsAsync(OrderResaleRequest request, OrderResaleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                body["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvAccessToken))
            {
                body["dingIsvAccessToken"] = request.DingIsvAccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateTime))
            {
                body["orderCreateTime"] = request.OrderCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                body["quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStartTime))
            {
                body["serviceStartTime"] = request.ServiceStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStopTime))
            {
                body["serviceStopTime"] = request.ServiceStopTime;
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
            return TeaModel.ToObject<OrderResaleResponse>(await DoROARequestAsync("OrderResale", "esign_1.0", "HTTP", "POST", "AK", "/v1.0/esign/orders/resale", "json", req, runtime));
        }

    }
}
