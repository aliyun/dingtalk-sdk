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
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 获取授权的页面地址
         *
         * @param request AuthUrlRequest
         * @param headers AuthUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthUrlResponse
         */
        public AuthUrlResponse AuthUrlWithOptions(AuthUrlRequest request, AuthUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/auths/url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取授权的页面地址
         *
         * @param request AuthUrlRequest
         * @param headers AuthUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AuthUrlResponse
         */
        public async Task<AuthUrlResponse> AuthUrlWithOptionsAsync(AuthUrlRequest request, AuthUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AuthUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/auths/url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AuthUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取授权的页面地址
         *
         * @param request AuthUrlRequest
         * @return AuthUrlResponse
         */
        public AuthUrlResponse AuthUrl(AuthUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthUrlHeaders headers = new AuthUrlHeaders();
            return AuthUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取授权的页面地址
         *
         * @param request AuthUrlRequest
         * @return AuthUrlResponse
         */
        public async Task<AuthUrlResponse> AuthUrlAsync(AuthUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AuthUrlHeaders headers = new AuthUrlHeaders();
            return await AuthUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 取消企业的授权
         *
         * @param headers CancelCorpAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelCorpAuthResponse
         */
        public CancelCorpAuthResponse CancelCorpAuthWithOptions(CancelCorpAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelCorpAuth",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/corps/auth/cancel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCorpAuthResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 取消企业的授权
         *
         * @param headers CancelCorpAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelCorpAuthResponse
         */
        public async Task<CancelCorpAuthResponse> CancelCorpAuthWithOptionsAsync(CancelCorpAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelCorpAuth",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/corps/auth/cancel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCorpAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 取消企业的授权
         *
         * @return CancelCorpAuthResponse
         */
        public CancelCorpAuthResponse CancelCorpAuth()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
            return CancelCorpAuthWithOptions(headers, runtime);
        }

        /**
         * @summary 取消企业的授权
         *
         * @return CancelCorpAuthResponse
         */
        public async Task<CancelCorpAuthResponse> CancelCorpAuthAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
            return await CancelCorpAuthWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 套餐转售1（分润模式）
         *
         * @param request ChannelOrderRequest
         * @param headers ChannelOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChannelOrderResponse
         */
        public ChannelOrderResponse ChannelOrderWithOptions(ChannelOrderRequest request, ChannelOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChannelOrder",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/orders/channel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChannelOrderResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 套餐转售1（分润模式）
         *
         * @param request ChannelOrderRequest
         * @param headers ChannelOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChannelOrderResponse
         */
        public async Task<ChannelOrderResponse> ChannelOrderWithOptionsAsync(ChannelOrderRequest request, ChannelOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChannelOrder",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/orders/channel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChannelOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 套餐转售1（分润模式）
         *
         * @param request ChannelOrderRequest
         * @return ChannelOrderResponse
         */
        public ChannelOrderResponse ChannelOrder(ChannelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChannelOrderHeaders headers = new ChannelOrderHeaders();
            return ChannelOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 套餐转售1（分润模式）
         *
         * @param request ChannelOrderRequest
         * @return ChannelOrderResponse
         */
        public async Task<ChannelOrderResponse> ChannelOrderAsync(ChannelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChannelOrderHeaders headers = new ChannelOrderHeaders();
            return await ChannelOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询套餐余量
         *
         * @param headers ContractMarginHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ContractMarginResponse
         */
        public ContractMarginResponse ContractMarginWithOptions(ContractMarginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ContractMargin",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/contracts/margin",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContractMarginResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询套餐余量
         *
         * @param headers ContractMarginHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ContractMarginResponse
         */
        public async Task<ContractMarginResponse> ContractMarginWithOptionsAsync(ContractMarginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ContractMargin",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/contracts/margin",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContractMarginResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询套餐余量
         *
         * @return ContractMarginResponse
         */
        public ContractMarginResponse ContractMargin()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ContractMarginHeaders headers = new ContractMarginHeaders();
            return ContractMarginWithOptions(headers, runtime);
        }

        /**
         * @summary 查询套餐余量
         *
         * @return ContractMarginResponse
         */
        public async Task<ContractMarginResponse> ContractMarginAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ContractMarginHeaders headers = new ContractMarginHeaders();
            return await ContractMarginWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询个人信息
         *
         * @param headers CorpConsoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CorpConsoleResponse
         */
        public CorpConsoleResponse CorpConsoleWithOptions(CorpConsoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CorpConsole",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/corps/console",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorpConsoleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询个人信息
         *
         * @param headers CorpConsoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CorpConsoleResponse
         */
        public async Task<CorpConsoleResponse> CorpConsoleWithOptionsAsync(CorpConsoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CorpConsole",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/corps/console",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorpConsoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询个人信息
         *
         * @return CorpConsoleResponse
         */
        public CorpConsoleResponse CorpConsole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpConsoleHeaders headers = new CorpConsoleHeaders();
            return CorpConsoleWithOptions(headers, runtime);
        }

        /**
         * @summary 查询个人信息
         *
         * @return CorpConsoleResponse
         */
        public async Task<CorpConsoleResponse> CorpConsoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpConsoleHeaders headers = new CorpConsoleHeaders();
            return await CorpConsoleWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询企业信息
         *
         * @param headers CorpInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CorpInfoResponse
         */
        public CorpInfoResponse CorpInfoWithOptions(CorpInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CorpInfo",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/corps/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorpInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询企业信息
         *
         * @param headers CorpInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CorpInfoResponse
         */
        public async Task<CorpInfoResponse> CorpInfoWithOptionsAsync(CorpInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CorpInfo",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/corps/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorpInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询企业信息
         *
         * @return CorpInfoResponse
         */
        public CorpInfoResponse CorpInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpInfoHeaders headers = new CorpInfoHeaders();
            return CorpInfoWithOptions(headers, runtime);
        }

        /**
         * @summary 查询企业信息
         *
         * @return CorpInfoResponse
         */
        public async Task<CorpInfoResponse> CorpInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpInfoHeaders headers = new CorpInfoHeaders();
            return await CorpInfoWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 钉钉ISV服务商的数据初始化
         *
         * @param request CreateDeveloperRequest
         * @param headers CreateDeveloperHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeveloperResponse
         */
        public CreateDeveloperResponse CreateDeveloperWithOptions(CreateDeveloperRequest request, CreateDeveloperHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeveloper",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/developers/create",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeveloperResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 钉钉ISV服务商的数据初始化
         *
         * @param request CreateDeveloperRequest
         * @param headers CreateDeveloperHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDeveloperResponse
         */
        public async Task<CreateDeveloperResponse> CreateDeveloperWithOptionsAsync(CreateDeveloperRequest request, CreateDeveloperHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeveloper",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/developers/create",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeveloperResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 钉钉ISV服务商的数据初始化
         *
         * @param request CreateDeveloperRequest
         * @return CreateDeveloperResponse
         */
        public CreateDeveloperResponse CreateDeveloper(CreateDeveloperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeveloperHeaders headers = new CreateDeveloperHeaders();
            return CreateDeveloperWithOptions(request, headers, runtime);
        }

        /**
         * @summary 钉钉ISV服务商的数据初始化
         *
         * @param request CreateDeveloperRequest
         * @return CreateDeveloperResponse
         */
        public async Task<CreateDeveloperResponse> CreateDeveloperAsync(CreateDeveloperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDeveloperHeaders headers = new CreateDeveloperHeaders();
            return await CreateDeveloperWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request GetCorpRealnameUrlRequest
         * @param headers GetCorpRealnameUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCorpRealnameUrlResponse
         */
        public GetCorpRealnameUrlResponse GetCorpRealnameUrlWithOptions(GetCorpRealnameUrlRequest request, GetCorpRealnameUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "GetCorpRealnameUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/corps/realname",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpRealnameUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request GetCorpRealnameUrlRequest
         * @param headers GetCorpRealnameUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCorpRealnameUrlResponse
         */
        public async Task<GetCorpRealnameUrlResponse> GetCorpRealnameUrlWithOptionsAsync(GetCorpRealnameUrlRequest request, GetCorpRealnameUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "GetCorpRealnameUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/corps/realname",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpRealnameUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request GetCorpRealnameUrlRequest
         * @return GetCorpRealnameUrlResponse
         */
        public GetCorpRealnameUrlResponse GetCorpRealnameUrl(GetCorpRealnameUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpRealnameUrlHeaders headers = new GetCorpRealnameUrlHeaders();
            return GetCorpRealnameUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request GetCorpRealnameUrlRequest
         * @return GetCorpRealnameUrlResponse
         */
        public async Task<GetCorpRealnameUrlResponse> GetCorpRealnameUrlAsync(GetCorpRealnameUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpRealnameUrlHeaders headers = new GetCorpRealnameUrlHeaders();
            return await GetCorpRealnameUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业e签宝微应用状态
         *
         * @param headers GetCropStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCropStatusResponse
         */
        public GetCropStatusResponse GetCropStatusWithOptions(GetCropStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCropStatus",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/corps/statuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCropStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取企业e签宝微应用状态
         *
         * @param headers GetCropStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCropStatusResponse
         */
        public async Task<GetCropStatusResponse> GetCropStatusWithOptionsAsync(GetCropStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCropStatus",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/corps/statuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCropStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取企业e签宝微应用状态
         *
         * @return GetCropStatusResponse
         */
        public GetCropStatusResponse GetCropStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCropStatusHeaders headers = new GetCropStatusHeaders();
            return GetCropStatusWithOptions(headers, runtime);
        }

        /**
         * @summary 获取企业e签宝微应用状态
         *
         * @return GetCropStatusResponse
         */
        public async Task<GetCropStatusResponse> GetCropStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCropStatusHeaders headers = new GetCropStatusHeaders();
            return await GetCropStatusWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询文件详情/下载文件
         *
         * @param headers GetFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileResponse
         */
        public GetFileResponse GetFileWithOptions(string fileId, GetFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFile",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/files/" + fileId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询文件详情/下载文件
         *
         * @param headers GetFileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileResponse
         */
        public async Task<GetFileResponse> GetFileWithOptionsAsync(string fileId, GetFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFile",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/files/" + fileId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询文件详情/下载文件
         *
         * @return GetFileResponse
         */
        public GetFileResponse GetFile(string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileHeaders headers = new GetFileHeaders();
            return GetFileWithOptions(fileId, headers, runtime);
        }

        /**
         * @summary 查询文件详情/下载文件
         *
         * @return GetFileResponse
         */
        public async Task<GetFileResponse> GetFileAsync(string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileHeaders headers = new GetFileHeaders();
            return await GetFileWithOptionsAsync(fileId, headers, runtime);
        }

        /**
         * @summary 获取对应流程任务详情
         *
         * @param request GetFlowDetailRequest
         * @param headers GetFlowDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowDetailResponse
         */
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowDetail",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/flows/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowDetailResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取对应流程任务详情
         *
         * @param request GetFlowDetailRequest
         * @param headers GetFlowDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowDetailResponse
         */
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowDetail",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/flows/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取对应流程任务详情
         *
         * @param request GetFlowDetailRequest
         * @return GetFlowDetailResponse
         */
        public GetFlowDetailResponse GetFlowDetail(GetFlowDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
            return GetFlowDetailWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取对应流程任务详情
         *
         * @param request GetFlowDetailRequest
         * @return GetFlowDetailResponse
         */
        public async Task<GetFlowDetailResponse> GetFlowDetailAsync(GetFlowDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
            return await GetFlowDetailWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取对应流程任务详情
         *
         * @param request GetFlowSignDetailRequest
         * @param headers GetFlowSignDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowSignDetailResponse
         */
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowSignDetail",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/flows/sign/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowSignDetailResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取对应流程任务详情
         *
         * @param request GetFlowSignDetailRequest
         * @param headers GetFlowSignDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowSignDetailResponse
         */
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFlowSignDetail",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/flows/sign/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowSignDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取对应流程任务详情
         *
         * @param request GetFlowSignDetailRequest
         * @return GetFlowSignDetailResponse
         */
        public GetFlowSignDetailResponse GetFlowSignDetail(GetFlowSignDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowSignDetailHeaders headers = new GetFlowSignDetailHeaders();
            return GetFlowSignDetailWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取对应流程任务详情
         *
         * @param request GetFlowSignDetailRequest
         * @return GetFlowSignDetailResponse
         */
        public async Task<GetFlowSignDetailResponse> GetFlowSignDetailAsync(GetFlowSignDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowSignDetailHeaders headers = new GetFlowSignDetailHeaders();
            return await GetFlowSignDetailWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发起签署的地址
         *
         * @param request GetProcessStartUrlRequest
         * @param headers GetProcessStartUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProcessStartUrlResponse
         */
        public GetProcessStartUrlResponse GetProcessStartUrlWithOptions(GetProcessStartUrlRequest request, GetProcessStartUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ccs))
            {
                body["ccs"] = request.Ccs;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInfo))
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProcessStartUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/process/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessStartUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发起签署的地址
         *
         * @param request GetProcessStartUrlRequest
         * @param headers GetProcessStartUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProcessStartUrlResponse
         */
        public async Task<GetProcessStartUrlResponse> GetProcessStartUrlWithOptionsAsync(GetProcessStartUrlRequest request, GetProcessStartUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ccs))
            {
                body["ccs"] = request.Ccs;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInfo))
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProcessStartUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/process/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProcessStartUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发起签署的地址
         *
         * @param request GetProcessStartUrlRequest
         * @return GetProcessStartUrlResponse
         */
        public GetProcessStartUrlResponse GetProcessStartUrl(GetProcessStartUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessStartUrlHeaders headers = new GetProcessStartUrlHeaders();
            return GetProcessStartUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发起签署的地址
         *
         * @param request GetProcessStartUrlRequest
         * @return GetProcessStartUrlResponse
         */
        public async Task<GetProcessStartUrlResponse> GetProcessStartUrlAsync(GetProcessStartUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProcessStartUrlHeaders headers = new GetProcessStartUrlHeaders();
            return await GetProcessStartUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取签署人签署地址
         *
         * @param request GetSignNoticeUrlRequest
         * @param headers GetSignNoticeUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSignNoticeUrlResponse
         */
        public GetSignNoticeUrlResponse GetSignNoticeUrlWithOptions(GetSignNoticeUrlRequest request, GetSignNoticeUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSignNoticeUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/signs/notice/url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignNoticeUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取签署人签署地址
         *
         * @param request GetSignNoticeUrlRequest
         * @param headers GetSignNoticeUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSignNoticeUrlResponse
         */
        public async Task<GetSignNoticeUrlResponse> GetSignNoticeUrlWithOptionsAsync(GetSignNoticeUrlRequest request, GetSignNoticeUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSignNoticeUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/signs/notice/url",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignNoticeUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取签署人签署地址
         *
         * @param request GetSignNoticeUrlRequest
         * @return GetSignNoticeUrlResponse
         */
        public GetSignNoticeUrlResponse GetSignNoticeUrl(GetSignNoticeUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignNoticeUrlHeaders headers = new GetSignNoticeUrlHeaders();
            return GetSignNoticeUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取签署人签署地址
         *
         * @param request GetSignNoticeUrlRequest
         * @return GetSignNoticeUrlResponse
         */
        public async Task<GetSignNoticeUrlResponse> GetSignNoticeUrlAsync(GetSignNoticeUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignNoticeUrlHeaders headers = new GetSignNoticeUrlHeaders();
            return await GetSignNoticeUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过上传方式创建文件
         *
         * @param request GetUploadUrlRequest
         * @param headers GetUploadUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadUrlResponse
         */
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/files/getUploadUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过上传方式创建文件
         *
         * @param request GetUploadUrlRequest
         * @param headers GetUploadUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUploadUrlResponse
         */
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUploadUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/files/getUploadUrl",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUploadUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过上传方式创建文件
         *
         * @param request GetUploadUrlRequest
         * @return GetUploadUrlResponse
         */
        public GetUploadUrlResponse GetUploadUrl(GetUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadUrlHeaders headers = new GetUploadUrlHeaders();
            return GetUploadUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过上传方式创建文件
         *
         * @param request GetUploadUrlRequest
         * @return GetUploadUrlResponse
         */
        public async Task<GetUploadUrlResponse> GetUploadUrlAsync(GetUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUploadUrlHeaders headers = new GetUploadUrlHeaders();
            return await GetUploadUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询个人信息
         *
         * @param headers GetUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserInfoResponse
         */
        public GetUserInfoResponse GetUserInfoWithOptions(string userId, GetUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUserInfo",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询个人信息
         *
         * @param headers GetUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserInfoResponse
         */
        public async Task<GetUserInfoResponse> GetUserInfoWithOptionsAsync(string userId, GetUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetUserInfo",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询个人信息
         *
         * @return GetUserInfoResponse
         */
        public GetUserInfoResponse GetUserInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return GetUserInfoWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 查询个人信息
         *
         * @return GetUserInfoResponse
         */
        public async Task<GetUserInfoResponse> GetUserInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return await GetUserInfoWithOptionsAsync(userId, headers, runtime);
        }

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request GetUserRealnameUrlRequest
         * @param headers GetUserRealnameUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserRealnameUrlResponse
         */
        public GetUserRealnameUrlResponse GetUserRealnameUrlWithOptions(GetUserRealnameUrlRequest request, GetUserRealnameUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserRealnameUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/users/realname",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserRealnameUrlResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request GetUserRealnameUrlRequest
         * @param headers GetUserRealnameUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserRealnameUrlResponse
         */
        public async Task<GetUserRealnameUrlResponse> GetUserRealnameUrlWithOptionsAsync(GetUserRealnameUrlRequest request, GetUserRealnameUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserRealnameUrl",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/users/realname",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserRealnameUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request GetUserRealnameUrlRequest
         * @return GetUserRealnameUrlResponse
         */
        public GetUserRealnameUrlResponse GetUserRealnameUrl(GetUserRealnameUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserRealnameUrlHeaders headers = new GetUserRealnameUrlHeaders();
            return GetUserRealnameUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request GetUserRealnameUrlRequest
         * @return GetUserRealnameUrlResponse
         */
        public async Task<GetUserRealnameUrlResponse> GetUserRealnameUrlAsync(GetUserRealnameUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserRealnameUrlHeaders headers = new GetUserRealnameUrlHeaders();
            return await GetUserRealnameUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取流程任务合同列表
         *
         * @param request ListFlowDocsRequest
         * @param headers ListFlowDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFlowDocsResponse
         */
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowDocs",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/flows/docs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowDocsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取流程任务合同列表
         *
         * @param request ListFlowDocsRequest
         * @param headers ListFlowDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFlowDocsResponse
         */
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlowDocs",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/flows/docs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlowDocsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取流程任务合同列表
         *
         * @param request ListFlowDocsRequest
         * @return ListFlowDocsResponse
         */
        public ListFlowDocsResponse ListFlowDocs(ListFlowDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFlowDocsHeaders headers = new ListFlowDocsHeaders();
            return ListFlowDocsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取流程任务合同列表
         *
         * @param request ListFlowDocsRequest
         * @return ListFlowDocsResponse
         */
        public async Task<ListFlowDocsResponse> ListFlowDocsAsync(ListFlowDocsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListFlowDocsHeaders headers = new ListFlowDocsHeaders();
            return await ListFlowDocsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取流程任务用印审批列表
         *
         * @param request ListSealApprovalRequest
         * @param headers ListSealApprovalHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSealApprovalResponse
         */
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSealApproval",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/seals/approval/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSealApprovalResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取流程任务用印审批列表
         *
         * @param request ListSealApprovalRequest
         * @param headers ListSealApprovalHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSealApprovalResponse
         */
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSealApproval",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/seals/approval/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSealApprovalResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取流程任务用印审批列表
         *
         * @param request ListSealApprovalRequest
         * @return ListSealApprovalResponse
         */
        public ListSealApprovalResponse ListSealApproval(ListSealApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSealApprovalHeaders headers = new ListSealApprovalHeaders();
            return ListSealApprovalWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取流程任务用印审批列表
         *
         * @param request ListSealApprovalRequest
         * @return ListSealApprovalResponse
         */
        public async Task<ListSealApprovalResponse> ListSealApprovalAsync(ListSealApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListSealApprovalHeaders headers = new ListSealApprovalHeaders();
            return await ListSealApprovalWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 套餐转售2（底价结算模式）
         *
         * @param request OrderResaleRequest
         * @param headers OrderResaleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrderResaleResponse
         */
        public OrderResaleResponse OrderResaleWithOptions(OrderResaleRequest request, OrderResaleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrderResale",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/orders/resale",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrderResaleResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 套餐转售2（底价结算模式）
         *
         * @param request OrderResaleRequest
         * @param headers OrderResaleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OrderResaleResponse
         */
        public async Task<OrderResaleResponse> OrderResaleWithOptionsAsync(OrderResaleRequest request, OrderResaleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrderResale",
                Version = "esign_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/esign/orders/resale",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrderResaleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 套餐转售2（底价结算模式）
         *
         * @param request OrderResaleRequest
         * @return OrderResaleResponse
         */
        public OrderResaleResponse OrderResale(OrderResaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderResaleHeaders headers = new OrderResaleHeaders();
            return OrderResaleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 套餐转售2（底价结算模式）
         *
         * @param request OrderResaleRequest
         * @return OrderResaleResponse
         */
        public async Task<OrderResaleResponse> OrderResaleAsync(OrderResaleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderResaleHeaders headers = new OrderResaleHeaders();
            return await OrderResaleWithOptionsAsync(request, headers, runtime);
        }

    }
}
