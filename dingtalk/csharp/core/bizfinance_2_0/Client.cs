// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0
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
        /// <para>银行接入层通用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BankGatewayInvokeRequest
        /// </param>
        /// <param name="headers">
        /// BankGatewayInvokeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BankGatewayInvokeResponse
        /// </returns>
        public BankGatewayInvokeResponse BankGatewayInvokeWithOptions(BankGatewayInvokeRequest request, BankGatewayInvokeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputData))
            {
                body["inputData"] = request.InputData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BankGatewayInvoke",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/bankGateways/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BankGatewayInvokeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银行接入层通用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BankGatewayInvokeRequest
        /// </param>
        /// <param name="headers">
        /// BankGatewayInvokeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BankGatewayInvokeResponse
        /// </returns>
        public async Task<BankGatewayInvokeResponse> BankGatewayInvokeWithOptionsAsync(BankGatewayInvokeRequest request, BankGatewayInvokeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputData))
            {
                body["inputData"] = request.InputData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BankGatewayInvoke",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/bankGateways/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BankGatewayInvokeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银行接入层通用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BankGatewayInvokeRequest
        /// </param>
        /// 
        /// <returns>
        /// BankGatewayInvokeResponse
        /// </returns>
        public BankGatewayInvokeResponse BankGatewayInvoke(BankGatewayInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BankGatewayInvokeHeaders headers = new BankGatewayInvokeHeaders();
            return BankGatewayInvokeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>银行接入层通用接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BankGatewayInvokeRequest
        /// </param>
        /// 
        /// <returns>
        /// BankGatewayInvokeResponse
        /// </returns>
        public async Task<BankGatewayInvokeResponse> BankGatewayInvokeAsync(BankGatewayInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BankGatewayInvokeHeaders headers = new BankGatewayInvokeHeaders();
            return await BankGatewayInvokeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteReceiptRequest
        /// </param>
        /// <param name="headers">
        /// BatchDeleteReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteReceiptResponse
        /// </returns>
        public BatchDeleteReceiptResponse BatchDeleteReceiptWithOptions(BatchDeleteReceiptRequest request, BatchDeleteReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["instanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteReceipt",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/instances/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteReceiptResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteReceiptRequest
        /// </param>
        /// <param name="headers">
        /// BatchDeleteReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteReceiptResponse
        /// </returns>
        public async Task<BatchDeleteReceiptResponse> BatchDeleteReceiptWithOptionsAsync(BatchDeleteReceiptRequest request, BatchDeleteReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["instanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteReceipt",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/instances/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteReceiptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteReceiptResponse
        /// </returns>
        public BatchDeleteReceiptResponse BatchDeleteReceipt(BatchDeleteReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteReceiptHeaders headers = new BatchDeleteReceiptHeaders();
            return BatchDeleteReceiptWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteReceiptResponse
        /// </returns>
        public async Task<BatchDeleteReceiptResponse> BatchDeleteReceiptAsync(BatchDeleteReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteReceiptHeaders headers = new BatchDeleteReceiptHeaders();
            return await BatchDeleteReceiptWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同步银行回单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSyncBankReceiptRequest
        /// </param>
        /// <param name="headers">
        /// BatchSyncBankReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSyncBankReceiptResponse
        /// </returns>
        public BatchSyncBankReceiptResponse BatchSyncBankReceiptWithOptions(BatchSyncBankReceiptRequest request, BatchSyncBankReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSyncBankReceipt",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/receipts/batchSync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSyncBankReceiptResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同步银行回单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSyncBankReceiptRequest
        /// </param>
        /// <param name="headers">
        /// BatchSyncBankReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSyncBankReceiptResponse
        /// </returns>
        public async Task<BatchSyncBankReceiptResponse> BatchSyncBankReceiptWithOptionsAsync(BatchSyncBankReceiptRequest request, BatchSyncBankReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSyncBankReceipt",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/receipts/batchSync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSyncBankReceiptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同步银行回单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSyncBankReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSyncBankReceiptResponse
        /// </returns>
        public BatchSyncBankReceiptResponse BatchSyncBankReceipt(BatchSyncBankReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSyncBankReceiptHeaders headers = new BatchSyncBankReceiptHeaders();
            return BatchSyncBankReceiptWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量同步银行回单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSyncBankReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSyncBankReceiptResponse
        /// </returns>
        public async Task<BatchSyncBankReceiptResponse> BatchSyncBankReceiptAsync(BatchSyncBankReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSyncBankReceiptHeaders headers = new BatchSyncBankReceiptHeaders();
            return await BatchSyncBankReceiptWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取费用类别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCategoryRequest
        /// </param>
        /// <param name="headers">
        /// GetCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCategoryResponse
        /// </returns>
        public GetCategoryResponse GetCategoryWithOptions(GetCategoryRequest request, GetCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCategory",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/categories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCategoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取费用类别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCategoryRequest
        /// </param>
        /// <param name="headers">
        /// GetCategoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCategoryResponse
        /// </returns>
        public async Task<GetCategoryResponse> GetCategoryWithOptionsAsync(GetCategoryRequest request, GetCategoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCategory",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/categories",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCategoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取费用类别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCategoryResponse
        /// </returns>
        public GetCategoryResponse GetCategory(GetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCategoryHeaders headers = new GetCategoryHeaders();
            return GetCategoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取费用类别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCategoryResponse
        /// </returns>
        public async Task<GetCategoryResponse> GetCategoryAsync(GetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCategoryHeaders headers = new GetCategoryHeaders();
            return await GetCategoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFinanceAccountRequest
        /// </param>
        /// <param name="headers">
        /// GetFinanceAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFinanceAccountResponse
        /// </returns>
        public GetFinanceAccountResponse GetFinanceAccountWithOptions(GetFinanceAccountRequest request, GetFinanceAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountCode))
            {
                query["accountCode"] = request.AccountCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFinanceAccount",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/financeAccounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFinanceAccountResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFinanceAccountRequest
        /// </param>
        /// <param name="headers">
        /// GetFinanceAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFinanceAccountResponse
        /// </returns>
        public async Task<GetFinanceAccountResponse> GetFinanceAccountWithOptionsAsync(GetFinanceAccountRequest request, GetFinanceAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountCode))
            {
                query["accountCode"] = request.AccountCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetFinanceAccount",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/financeAccounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFinanceAccountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFinanceAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFinanceAccountResponse
        /// </returns>
        public GetFinanceAccountResponse GetFinanceAccount(GetFinanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFinanceAccountHeaders headers = new GetFinanceAccountHeaders();
            return GetFinanceAccountWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFinanceAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFinanceAccountResponse
        /// </returns>
        public async Task<GetFinanceAccountResponse> GetFinanceAccountAsync(GetFinanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFinanceAccountHeaders headers = new GetFinanceAccountHeaders();
            return await GetFinanceAccountWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单条项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// <param name="headers">
        /// GetProjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public GetProjectResponse GetProjectWithOptions(GetProjectRequest request, GetProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetProject",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单条项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// <param name="headers">
        /// GetProjectHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(GetProjectRequest request, GetProjectHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetProject",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单条项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public GetProjectResponse GetProject(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectHeaders headers = new GetProjectHeaders();
            return GetProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取单条项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public async Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectHeaders headers = new GetProjectHeaders();
            return await GetProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务单据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetReceiptRequest
        /// </param>
        /// <param name="headers">
        /// GetReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetReceiptResponse
        /// </returns>
        public GetReceiptResponse GetReceiptWithOptions(GetReceiptRequest request, GetReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetReceipt",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/receipts/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReceiptResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务单据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetReceiptRequest
        /// </param>
        /// <param name="headers">
        /// GetReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetReceiptResponse
        /// </returns>
        public async Task<GetReceiptResponse> GetReceiptWithOptionsAsync(GetReceiptRequest request, GetReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetReceipt",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/receipts/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReceiptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务单据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// GetReceiptResponse
        /// </returns>
        public GetReceiptResponse GetReceipt(GetReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetReceiptHeaders headers = new GetReceiptHeaders();
            return GetReceiptWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务单据详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// GetReceiptResponse
        /// </returns>
        public async Task<GetReceiptResponse> GetReceiptAsync(GetReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetReceiptHeaders headers = new GetReceiptHeaders();
            return await GetReceiptWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务应用内维护的供应商信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplierRequest
        /// </param>
        /// <param name="headers">
        /// GetSupplierHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSupplierResponse
        /// </returns>
        public GetSupplierResponse GetSupplierWithOptions(GetSupplierRequest request, GetSupplierHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSupplier",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/suppliers/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSupplierResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务应用内维护的供应商信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplierRequest
        /// </param>
        /// <param name="headers">
        /// GetSupplierHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSupplierResponse
        /// </returns>
        public async Task<GetSupplierResponse> GetSupplierWithOptionsAsync(GetSupplierRequest request, GetSupplierHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSupplier",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/suppliers/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSupplierResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务应用内维护的供应商信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplierRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSupplierResponse
        /// </returns>
        public GetSupplierResponse GetSupplier(GetSupplierRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSupplierHeaders headers = new GetSupplierHeaders();
            return GetSupplierWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务应用内维护的供应商信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSupplierRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSupplierResponse
        /// </returns>
        public async Task<GetSupplierResponse> GetSupplierAsync(GetSupplierRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSupplierHeaders headers = new GetSupplierHeaders();
            return await GetSupplierWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订单开票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IssueInvoiceWithOrderRequest
        /// </param>
        /// <param name="headers">
        /// IssueInvoiceWithOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IssueInvoiceWithOrderResponse
        /// </returns>
        public IssueInvoiceWithOrderResponse IssueInvoiceWithOrderWithOptions(IssueInvoiceWithOrderRequest request, IssueInvoiceWithOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceAppKey))
            {
                body["financeAppKey"] = request.FinanceAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IssueInvoiceWithOrder",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/issueInvoices/order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IssueInvoiceWithOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订单开票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IssueInvoiceWithOrderRequest
        /// </param>
        /// <param name="headers">
        /// IssueInvoiceWithOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IssueInvoiceWithOrderResponse
        /// </returns>
        public async Task<IssueInvoiceWithOrderResponse> IssueInvoiceWithOrderWithOptionsAsync(IssueInvoiceWithOrderRequest request, IssueInvoiceWithOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceAppKey))
            {
                body["financeAppKey"] = request.FinanceAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IssueInvoiceWithOrder",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/issueInvoices/order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IssueInvoiceWithOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订单开票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IssueInvoiceWithOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// IssueInvoiceWithOrderResponse
        /// </returns>
        public IssueInvoiceWithOrderResponse IssueInvoiceWithOrder(IssueInvoiceWithOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IssueInvoiceWithOrderHeaders headers = new IssueInvoiceWithOrderHeaders();
            return IssueInvoiceWithOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订单开票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IssueInvoiceWithOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// IssueInvoiceWithOrderResponse
        /// </returns>
        public async Task<IssueInvoiceWithOrderResponse> IssueInvoiceWithOrderAsync(IssueInvoiceWithOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IssueInvoiceWithOrderHeaders headers = new IssueInvoiceWithOrderHeaders();
            return await IssueInvoiceWithOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据不同的bizType查询不同的数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LinkCommonInvokeRequest
        /// </param>
        /// <param name="headers">
        /// LinkCommonInvokeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LinkCommonInvokeResponse
        /// </returns>
        public LinkCommonInvokeResponse LinkCommonInvokeWithOptions(LinkCommonInvokeRequest request, LinkCommonInvokeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeId))
            {
                body["invokeId"] = request.InvokeId;
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
                Action = "LinkCommonInvoke",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/link/bizTypes/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LinkCommonInvokeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据不同的bizType查询不同的数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LinkCommonInvokeRequest
        /// </param>
        /// <param name="headers">
        /// LinkCommonInvokeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LinkCommonInvokeResponse
        /// </returns>
        public async Task<LinkCommonInvokeResponse> LinkCommonInvokeWithOptionsAsync(LinkCommonInvokeRequest request, LinkCommonInvokeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeId))
            {
                body["invokeId"] = request.InvokeId;
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
                Action = "LinkCommonInvoke",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/link/bizTypes/invoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<LinkCommonInvokeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据不同的bizType查询不同的数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LinkCommonInvokeRequest
        /// </param>
        /// 
        /// <returns>
        /// LinkCommonInvokeResponse
        /// </returns>
        public LinkCommonInvokeResponse LinkCommonInvoke(LinkCommonInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LinkCommonInvokeHeaders headers = new LinkCommonInvokeHeaders();
            return LinkCommonInvokeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据不同的bizType查询不同的数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LinkCommonInvokeRequest
        /// </param>
        /// 
        /// <returns>
        /// LinkCommonInvokeResponse
        /// </returns>
        public async Task<LinkCommonInvokeResponse> LinkCommonInvokeAsync(LinkCommonInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LinkCommonInvokeHeaders headers = new LinkCommonInvokeHeaders();
            return await LinkCommonInvokeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订单开票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderBillingRequest
        /// </param>
        /// <param name="headers">
        /// OrderBillingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrderBillingResponse
        /// </returns>
        public OrderBillingResponse OrderBillingWithOptions(OrderBillingRequest request, OrderBillingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionInfos))
            {
                body["additionInfos"] = request.AdditionInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyPerson))
            {
                body["applyPerson"] = request.ApplyPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceRemark))
            {
                body["invoiceRemark"] = request.InvoiceRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceType))
            {
                body["invoiceType"] = request.InvoiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsNaturalPerson))
            {
                body["isNaturalPerson"] = request.IsNaturalPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payee))
            {
                body["payee"] = request.Payee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                body["products"] = request.Products;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserAddress))
            {
                body["purchaserAddress"] = request.PurchaserAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserBankAccount))
            {
                body["purchaserBankAccount"] = request.PurchaserBankAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserBankName))
            {
                body["purchaserBankName"] = request.PurchaserBankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserName))
            {
                body["purchaserName"] = request.PurchaserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserTaxNo))
            {
                body["purchaserTaxNo"] = request.PurchaserTaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserTel))
            {
                body["purchaserTel"] = request.PurchaserTel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reviewer))
            {
                body["reviewer"] = request.Reviewer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxSign))
            {
                body["taxSign"] = request.TaxSign;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrderBilling",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/billings/order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrderBillingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订单开票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderBillingRequest
        /// </param>
        /// <param name="headers">
        /// OrderBillingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OrderBillingResponse
        /// </returns>
        public async Task<OrderBillingResponse> OrderBillingWithOptionsAsync(OrderBillingRequest request, OrderBillingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionInfos))
            {
                body["additionInfos"] = request.AdditionInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyPerson))
            {
                body["applyPerson"] = request.ApplyPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceRemark))
            {
                body["invoiceRemark"] = request.InvoiceRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceType))
            {
                body["invoiceType"] = request.InvoiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsNaturalPerson))
            {
                body["isNaturalPerson"] = request.IsNaturalPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payee))
            {
                body["payee"] = request.Payee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                body["phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                body["products"] = request.Products;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserAddress))
            {
                body["purchaserAddress"] = request.PurchaserAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserBankAccount))
            {
                body["purchaserBankAccount"] = request.PurchaserBankAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserBankName))
            {
                body["purchaserBankName"] = request.PurchaserBankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserName))
            {
                body["purchaserName"] = request.PurchaserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserTaxNo))
            {
                body["purchaserTaxNo"] = request.PurchaserTaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserTel))
            {
                body["purchaserTel"] = request.PurchaserTel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reviewer))
            {
                body["reviewer"] = request.Reviewer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxSign))
            {
                body["taxSign"] = request.TaxSign;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OrderBilling",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/billings/order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OrderBillingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订单开票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderBillingRequest
        /// </param>
        /// 
        /// <returns>
        /// OrderBillingResponse
        /// </returns>
        public OrderBillingResponse OrderBilling(OrderBillingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderBillingHeaders headers = new OrderBillingHeaders();
            return OrderBillingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订单开票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OrderBillingRequest
        /// </param>
        /// 
        /// <returns>
        /// OrderBillingResponse
        /// </returns>
        public async Task<OrderBillingResponse> OrderBillingAsync(OrderBillingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OrderBillingHeaders headers = new OrderBillingHeaders();
            return await OrderBillingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询账户的银行交易流水</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTradeByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryAccountTradeByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTradeByPageResponse
        /// </returns>
        public QueryAccountTradeByPageResponse QueryAccountTradeByPageWithOptions(QueryAccountTradeByPageRequest request, QueryAccountTradeByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
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
                Action = "QueryAccountTradeByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/trades/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountTradeByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询账户的银行交易流水</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTradeByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryAccountTradeByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTradeByPageResponse
        /// </returns>
        public async Task<QueryAccountTradeByPageResponse> QueryAccountTradeByPageWithOptionsAsync(QueryAccountTradeByPageRequest request, QueryAccountTradeByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
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
                Action = "QueryAccountTradeByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/trades/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountTradeByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询账户的银行交易流水</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTradeByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTradeByPageResponse
        /// </returns>
        public QueryAccountTradeByPageResponse QueryAccountTradeByPage(QueryAccountTradeByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAccountTradeByPageHeaders headers = new QueryAccountTradeByPageHeaders();
            return QueryAccountTradeByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询账户的银行交易流水</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountTradeByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountTradeByPageResponse
        /// </returns>
        public async Task<QueryAccountTradeByPageResponse> QueryAccountTradeByPageAsync(QueryAccountTradeByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAccountTradeByPageHeaders headers = new QueryAccountTradeByPageHeaders();
            return await QueryAccountTradeByPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取费用类别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCategoryByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryCategoryByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCategoryByPageResponse
        /// </returns>
        public QueryCategoryByPageResponse QueryCategoryByPageWithOptions(QueryCategoryByPageRequest request, QueryCategoryByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCategoryByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/categories/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCategoryByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取费用类别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCategoryByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryCategoryByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCategoryByPageResponse
        /// </returns>
        public async Task<QueryCategoryByPageResponse> QueryCategoryByPageWithOptionsAsync(QueryCategoryByPageRequest request, QueryCategoryByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCategoryByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/categories/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCategoryByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取费用类别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCategoryByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCategoryByPageResponse
        /// </returns>
        public QueryCategoryByPageResponse QueryCategoryByPage(QueryCategoryByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCategoryByPageHeaders headers = new QueryCategoryByPageHeaders();
            return QueryCategoryByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取费用类别</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCategoryByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCategoryByPageResponse
        /// </returns>
        public async Task<QueryCategoryByPageResponse> QueryCategoryByPageAsync(QueryCategoryByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCategoryByPageHeaders headers = new QueryCategoryByPageHeaders();
            return await QueryCategoryByPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页批量获取智能财务应用内维护的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryCustomerByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerByPageResponse
        /// </returns>
        public QueryCustomerByPageResponse QueryCustomerByPageWithOptions(QueryCustomerByPageRequest request, QueryCustomerByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryCustomerByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/customers/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页批量获取智能财务应用内维护的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryCustomerByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerByPageResponse
        /// </returns>
        public async Task<QueryCustomerByPageResponse> QueryCustomerByPageWithOptionsAsync(QueryCustomerByPageRequest request, QueryCustomerByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryCustomerByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/customers/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页批量获取智能财务应用内维护的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerByPageResponse
        /// </returns>
        public QueryCustomerByPageResponse QueryCustomerByPage(QueryCustomerByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerByPageHeaders headers = new QueryCustomerByPageHeaders();
            return QueryCustomerByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页批量获取智能财务应用内维护的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerByPageResponse
        /// </returns>
        public async Task<QueryCustomerByPageResponse> QueryCustomerByPageAsync(QueryCustomerByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerByPageHeaders headers = new QueryCustomerByPageHeaders();
            return await QueryCustomerByPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnterpriseAccountByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryEnterpriseAccountByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseAccountByPageResponse
        /// </returns>
        public QueryEnterpriseAccountByPageResponse QueryEnterpriseAccountByPageWithOptions(QueryEnterpriseAccountByPageRequest request, QueryEnterpriseAccountByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryEnterpriseAccountByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/financeAccounts/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnterpriseAccountByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnterpriseAccountByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryEnterpriseAccountByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseAccountByPageResponse
        /// </returns>
        public async Task<QueryEnterpriseAccountByPageResponse> QueryEnterpriseAccountByPageWithOptionsAsync(QueryEnterpriseAccountByPageRequest request, QueryEnterpriseAccountByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryEnterpriseAccountByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/financeAccounts/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnterpriseAccountByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnterpriseAccountByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseAccountByPageResponse
        /// </returns>
        public QueryEnterpriseAccountByPageResponse QueryEnterpriseAccountByPage(QueryEnterpriseAccountByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEnterpriseAccountByPageHeaders headers = new QueryEnterpriseAccountByPageHeaders();
            return QueryEnterpriseAccountByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnterpriseAccountByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseAccountByPageResponse
        /// </returns>
        public async Task<QueryEnterpriseAccountByPageResponse> QueryEnterpriseAccountByPageAsync(QueryEnterpriseAccountByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEnterpriseAccountByPageHeaders headers = new QueryEnterpriseAccountByPageHeaders();
            return await QueryEnterpriseAccountByPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付订单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstancePaymentOrderDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryInstancePaymentOrderDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstancePaymentOrderDetailResponse
        /// </returns>
        public QueryInstancePaymentOrderDetailResponse QueryInstancePaymentOrderDetailWithOptions(string instanceId, QueryInstancePaymentOrderDetailRequest request, QueryInstancePaymentOrderDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["orderNo"] = request.OrderNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryInstancePaymentOrderDetail",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/instances/" + instanceId + "/paymentOrders/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstancePaymentOrderDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付订单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstancePaymentOrderDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryInstancePaymentOrderDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstancePaymentOrderDetailResponse
        /// </returns>
        public async Task<QueryInstancePaymentOrderDetailResponse> QueryInstancePaymentOrderDetailWithOptionsAsync(string instanceId, QueryInstancePaymentOrderDetailRequest request, QueryInstancePaymentOrderDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["orderNo"] = request.OrderNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryInstancePaymentOrderDetail",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/instances/" + instanceId + "/paymentOrders/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstancePaymentOrderDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付订单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstancePaymentOrderDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstancePaymentOrderDetailResponse
        /// </returns>
        public QueryInstancePaymentOrderDetailResponse QueryInstancePaymentOrderDetail(string instanceId, QueryInstancePaymentOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInstancePaymentOrderDetailHeaders headers = new QueryInstancePaymentOrderDetailHeaders();
            return QueryInstancePaymentOrderDetailWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付订单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInstancePaymentOrderDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstancePaymentOrderDetailResponse
        /// </returns>
        public async Task<QueryInstancePaymentOrderDetailResponse> QueryInstancePaymentOrderDetailAsync(string instanceId, QueryInstancePaymentOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInstancePaymentOrderDetailHeaders headers = new QueryInstancePaymentOrderDetailHeaders();
            return await QueryInstancePaymentOrderDetailWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据迁移，根据数据key查询具体数据data</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryInvoiceTransferDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryInvoiceTransferDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInvoiceTransferDataResponse
        /// </returns>
        public QueryInvoiceTransferDataResponse QueryInvoiceTransferDataWithOptions(QueryInvoiceTransferDataRequest tmpReq, QueryInvoiceTransferDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryInvoiceTransferDataShrinkRequest request = new QueryInvoiceTransferDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryInvoiceTransferData",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/transferredDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInvoiceTransferDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据迁移，根据数据key查询具体数据data</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryInvoiceTransferDataRequest
        /// </param>
        /// <param name="headers">
        /// QueryInvoiceTransferDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInvoiceTransferDataResponse
        /// </returns>
        public async Task<QueryInvoiceTransferDataResponse> QueryInvoiceTransferDataWithOptionsAsync(QueryInvoiceTransferDataRequest tmpReq, QueryInvoiceTransferDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryInvoiceTransferDataShrinkRequest request = new QueryInvoiceTransferDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryInvoiceTransferData",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/transferredDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInvoiceTransferDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据迁移，根据数据key查询具体数据data</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInvoiceTransferDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInvoiceTransferDataResponse
        /// </returns>
        public QueryInvoiceTransferDataResponse QueryInvoiceTransferData(QueryInvoiceTransferDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInvoiceTransferDataHeaders headers = new QueryInvoiceTransferDataHeaders();
            return QueryInvoiceTransferDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据迁移，根据数据key查询具体数据data</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryInvoiceTransferDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInvoiceTransferDataResponse
        /// </returns>
        public async Task<QueryInvoiceTransferDataResponse> QueryInvoiceTransferDataAsync(QueryInvoiceTransferDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInvoiceTransferDataHeaders headers = new QueryInvoiceTransferDataHeaders();
            return await QueryInvoiceTransferDataWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付回单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentRecallFileRequest
        /// </param>
        /// <param name="headers">
        /// QueryPaymentRecallFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentRecallFileResponse
        /// </returns>
        public QueryPaymentRecallFileResponse QueryPaymentRecallFileWithOptions(string instanceId, QueryPaymentRecallFileRequest request, QueryPaymentRecallFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPaymentRecallFile",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/recallFiles/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPaymentRecallFileResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付回单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentRecallFileRequest
        /// </param>
        /// <param name="headers">
        /// QueryPaymentRecallFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentRecallFileResponse
        /// </returns>
        public async Task<QueryPaymentRecallFileResponse> QueryPaymentRecallFileWithOptionsAsync(string instanceId, QueryPaymentRecallFileRequest request, QueryPaymentRecallFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPaymentRecallFile",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/recallFiles/" + instanceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPaymentRecallFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付回单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentRecallFileRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentRecallFileResponse
        /// </returns>
        public QueryPaymentRecallFileResponse QueryPaymentRecallFile(string instanceId, QueryPaymentRecallFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPaymentRecallFileHeaders headers = new QueryPaymentRecallFileHeaders();
            return QueryPaymentRecallFileWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付回单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentRecallFileRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentRecallFileResponse
        /// </returns>
        public async Task<QueryPaymentRecallFileResponse> QueryPaymentRecallFileAsync(string instanceId, QueryPaymentRecallFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPaymentRecallFileHeaders headers = new QueryPaymentRecallFileHeaders();
            return await QueryPaymentRecallFileWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付订单的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryPaymentStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentStatusResponse
        /// </returns>
        public QueryPaymentStatusResponse QueryPaymentStatusWithOptions(QueryPaymentStatusRequest request, QueryPaymentStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["orderNo"] = request.OrderNo;
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
                Action = "QueryPaymentStatus",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/statuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPaymentStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付订单的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentStatusRequest
        /// </param>
        /// <param name="headers">
        /// QueryPaymentStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentStatusResponse
        /// </returns>
        public async Task<QueryPaymentStatusResponse> QueryPaymentStatusWithOptionsAsync(QueryPaymentStatusRequest request, QueryPaymentStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["orderNo"] = request.OrderNo;
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
                Action = "QueryPaymentStatus",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/statuses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPaymentStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付订单的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentStatusResponse
        /// </returns>
        public QueryPaymentStatusResponse QueryPaymentStatus(QueryPaymentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPaymentStatusHeaders headers = new QueryPaymentStatusHeaders();
            return QueryPaymentStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付订单的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentStatusResponse
        /// </returns>
        public async Task<QueryPaymentStatusResponse> QueryPaymentStatusAsync(QueryPaymentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPaymentStatusHeaders headers = new QueryPaymentStatusHeaders();
            return await QueryPaymentStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProjectByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryProjectByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProjectByPageResponse
        /// </returns>
        public QueryProjectByPageResponse QueryProjectByPageWithOptions(QueryProjectByPageRequest request, QueryProjectByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryProjectByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/projects/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProjectByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProjectByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryProjectByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProjectByPageResponse
        /// </returns>
        public async Task<QueryProjectByPageResponse> QueryProjectByPageWithOptionsAsync(QueryProjectByPageRequest request, QueryProjectByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryProjectByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/projects/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProjectByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProjectByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProjectByPageResponse
        /// </returns>
        public QueryProjectByPageResponse QueryProjectByPage(QueryProjectByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProjectByPageHeaders headers = new QueryProjectByPageHeaders();
            return QueryProjectByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取项目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProjectByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProjectByPageResponse
        /// </returns>
        public async Task<QueryProjectByPageResponse> QueryProjectByPageAsync(QueryProjectByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProjectByPageHeaders headers = new QueryProjectByPageHeaders();
            return await QueryProjectByPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能财务单据主数据信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptForInvoiceRequest
        /// </param>
        /// <param name="headers">
        /// QueryReceiptForInvoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptForInvoiceResponse
        /// </returns>
        public QueryReceiptForInvoiceResponse QueryReceiptForInvoiceWithOptions(QueryReceiptForInvoiceRequest request, QueryReceiptForInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountantBookId))
            {
                body["accountantBookId"] = request.AccountantBookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyStatusList))
            {
                body["applyStatusList"] = request.ApplyStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizStatusList))
            {
                body["bizStatusList"] = request.BizStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptStatusList))
            {
                body["receiptStatusList"] = request.ReceiptStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParams))
            {
                body["searchParams"] = request.SearchParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryReceiptForInvoice",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/receipts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReceiptForInvoiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能财务单据主数据信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptForInvoiceRequest
        /// </param>
        /// <param name="headers">
        /// QueryReceiptForInvoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptForInvoiceResponse
        /// </returns>
        public async Task<QueryReceiptForInvoiceResponse> QueryReceiptForInvoiceWithOptionsAsync(QueryReceiptForInvoiceRequest request, QueryReceiptForInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountantBookId))
            {
                body["accountantBookId"] = request.AccountantBookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyStatusList))
            {
                body["applyStatusList"] = request.ApplyStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizStatusList))
            {
                body["bizStatusList"] = request.BizStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptStatusList))
            {
                body["receiptStatusList"] = request.ReceiptStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchParams))
            {
                body["searchParams"] = request.SearchParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryReceiptForInvoice",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/receipts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReceiptForInvoiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能财务单据主数据信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptForInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptForInvoiceResponse
        /// </returns>
        public QueryReceiptForInvoiceResponse QueryReceiptForInvoice(QueryReceiptForInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptForInvoiceHeaders headers = new QueryReceiptForInvoiceHeaders();
            return QueryReceiptForInvoiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能财务单据主数据信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptForInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptForInvoiceResponse
        /// </returns>
        public async Task<QueryReceiptForInvoiceResponse> QueryReceiptForInvoiceAsync(QueryReceiptForInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptForInvoiceHeaders headers = new QueryReceiptForInvoiceHeaders();
            return await QueryReceiptForInvoiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页批量获取智能财务应用内维护的供应商信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySupplierByPageRequest
        /// </param>
        /// <param name="headers">
        /// QuerySupplierByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySupplierByPageResponse
        /// </returns>
        public QuerySupplierByPageResponse QuerySupplierByPageWithOptions(QuerySupplierByPageRequest request, QuerySupplierByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QuerySupplierByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/suppliers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySupplierByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页批量获取智能财务应用内维护的供应商信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySupplierByPageRequest
        /// </param>
        /// <param name="headers">
        /// QuerySupplierByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySupplierByPageResponse
        /// </returns>
        public async Task<QuerySupplierByPageResponse> QuerySupplierByPageWithOptionsAsync(QuerySupplierByPageRequest request, QuerySupplierByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QuerySupplierByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/suppliers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySupplierByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页批量获取智能财务应用内维护的供应商信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySupplierByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySupplierByPageResponse
        /// </returns>
        public QuerySupplierByPageResponse QuerySupplierByPage(QuerySupplierByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySupplierByPageHeaders headers = new QuerySupplierByPageHeaders();
            return QuerySupplierByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页批量获取智能财务应用内维护的供应商信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySupplierByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySupplierByPageResponse
        /// </returns>
        public async Task<QuerySupplierByPageResponse> QuerySupplierByPageAsync(QuerySupplierByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySupplierByPageHeaders headers = new QuerySupplierByPageHeaders();
            return await QuerySupplierByPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织是否命中走新发票应用</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryUseNewInvoiceAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUseNewInvoiceAppResponse
        /// </returns>
        public QueryUseNewInvoiceAppResponse QueryUseNewInvoiceAppWithOptions(QueryUseNewInvoiceAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUseNewInvoiceApp",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoice/appGray",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUseNewInvoiceAppResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织是否命中走新发票应用</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryUseNewInvoiceAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUseNewInvoiceAppResponse
        /// </returns>
        public async Task<QueryUseNewInvoiceAppResponse> QueryUseNewInvoiceAppWithOptionsAsync(QueryUseNewInvoiceAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUseNewInvoiceApp",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoice/appGray",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUseNewInvoiceAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织是否命中走新发票应用</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryUseNewInvoiceAppResponse
        /// </returns>
        public QueryUseNewInvoiceAppResponse QueryUseNewInvoiceApp()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUseNewInvoiceAppHeaders headers = new QueryUseNewInvoiceAppHeaders();
            return QueryUseNewInvoiceAppWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织是否命中走新发票应用</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryUseNewInvoiceAppResponse
        /// </returns>
        public async Task<QueryUseNewInvoiceAppResponse> QueryUseNewInvoiceAppAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUseNewInvoiceAppHeaders headers = new QueryUseNewInvoiceAppHeaders();
            return await QueryUseNewInvoiceAppWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户角色成员，支持分页，可获取某个企业主体下的角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserRoleListRequest
        /// </param>
        /// <param name="headers">
        /// QueryUserRoleListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserRoleListResponse
        /// </returns>
        public QueryUserRoleListResponse QueryUserRoleListWithOptions(QueryUserRoleListRequest request, QueryUserRoleListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
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
                Action = "QueryUserRoleList",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/users/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserRoleListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户角色成员，支持分页，可获取某个企业主体下的角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserRoleListRequest
        /// </param>
        /// <param name="headers">
        /// QueryUserRoleListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserRoleListResponse
        /// </returns>
        public async Task<QueryUserRoleListResponse> QueryUserRoleListWithOptionsAsync(QueryUserRoleListRequest request, QueryUserRoleListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
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
                Action = "QueryUserRoleList",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/users/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserRoleListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户角色成员，支持分页，可获取某个企业主体下的角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserRoleListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserRoleListResponse
        /// </returns>
        public QueryUserRoleListResponse QueryUserRoleList(QueryUserRoleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserRoleListHeaders headers = new QueryUserRoleListHeaders();
            return QueryUserRoleListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户角色成员，支持分页，可获取某个企业主体下的角色成员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryUserRoleListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryUserRoleListResponse
        /// </returns>
        public async Task<QueryUserRoleListResponse> QueryUserRoleListAsync(QueryUserRoleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserRoleListHeaders headers = new QueryUserRoleListHeaders();
            return await QueryUserRoleListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签约企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignEnterpriseAccountRequest
        /// </param>
        /// <param name="headers">
        /// SignEnterpriseAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignEnterpriseAccountResponse
        /// </returns>
        public SignEnterpriseAccountResponse SignEnterpriseAccountWithOptions(SignEnterpriseAccountRequest request, SignEnterpriseAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardNo))
            {
                query["bankCardNo"] = request.BankCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankOpenId))
            {
                query["bankOpenId"] = request.BankOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["channelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignOperateType))
            {
                query["signOperateType"] = request.SignOperateType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SignEnterpriseAccount",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/enterpriseAccounts/sign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignEnterpriseAccountResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签约企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignEnterpriseAccountRequest
        /// </param>
        /// <param name="headers">
        /// SignEnterpriseAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SignEnterpriseAccountResponse
        /// </returns>
        public async Task<SignEnterpriseAccountResponse> SignEnterpriseAccountWithOptionsAsync(SignEnterpriseAccountRequest request, SignEnterpriseAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardNo))
            {
                query["bankCardNo"] = request.BankCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankOpenId))
            {
                query["bankOpenId"] = request.BankOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["channelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignOperateType))
            {
                query["signOperateType"] = request.SignOperateType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SignEnterpriseAccount",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/enterpriseAccounts/sign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SignEnterpriseAccountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签约企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignEnterpriseAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// SignEnterpriseAccountResponse
        /// </returns>
        public SignEnterpriseAccountResponse SignEnterpriseAccount(SignEnterpriseAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignEnterpriseAccountHeaders headers = new SignEnterpriseAccountHeaders();
            return SignEnterpriseAccountWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>签约企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SignEnterpriseAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// SignEnterpriseAccountResponse
        /// </returns>
        public async Task<SignEnterpriseAccountResponse> SignEnterpriseAccountAsync(SignEnterpriseAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignEnterpriseAccountHeaders headers = new SignEnterpriseAccountHeaders();
            return await SignEnterpriseAccountWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送银企支付回单文件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncReceiptRecallRequest
        /// </param>
        /// <param name="headers">
        /// SyncReceiptRecallHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncReceiptRecallResponse
        /// </returns>
        public SyncReceiptRecallResponse SyncReceiptRecallWithOptions(SyncReceiptRecallRequest request, SyncReceiptRecallHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileDownloadUrl))
            {
                query["fileDownloadUrl"] = request.FileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["orderNo"] = request.OrderNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SyncReceiptRecall",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/receipts/syncRecall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncReceiptRecallResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送银企支付回单文件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncReceiptRecallRequest
        /// </param>
        /// <param name="headers">
        /// SyncReceiptRecallHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncReceiptRecallResponse
        /// </returns>
        public async Task<SyncReceiptRecallResponse> SyncReceiptRecallWithOptionsAsync(SyncReceiptRecallRequest request, SyncReceiptRecallHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileDownloadUrl))
            {
                query["fileDownloadUrl"] = request.FileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["orderNo"] = request.OrderNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "SyncReceiptRecall",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/receipts/syncRecall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncReceiptRecallResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送银企支付回单文件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncReceiptRecallRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncReceiptRecallResponse
        /// </returns>
        public SyncReceiptRecallResponse SyncReceiptRecall(SyncReceiptRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncReceiptRecallHeaders headers = new SyncReceiptRecallHeaders();
            return SyncReceiptRecallWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送银企支付回单文件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncReceiptRecallRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncReceiptRecallResponse
        /// </returns>
        public async Task<SyncReceiptRecallResponse> SyncReceiptRecallAsync(SyncReceiptRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncReceiptRecallHeaders headers = new SyncReceiptRecallHeaders();
            return await SyncReceiptRecallWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单据的支付状态</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateInstanceOrderInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInstanceOrderInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceOrderInfoResponse
        /// </returns>
        public UpdateInstanceOrderInfoResponse UpdateInstanceOrderInfoWithOptions(string instanceId, UpdateInstanceOrderInfoRequest tmpReq, UpdateInstanceOrderInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateInstanceOrderInfoShrinkRequest request = new UpdateInstanceOrderInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PayerBank))
            {
                request.PayerBankShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PayerBank, "payerBank", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailReason))
            {
                query["failReason"] = request.FailReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderNo))
            {
                query["outOrderNo"] = request.OutOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerBankShrink))
            {
                query["payerBank"] = request.PayerBankShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentTime))
            {
                query["paymentTime"] = request.PaymentTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
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
                Action = "UpdateInstanceOrderInfo",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/instances/" + instanceId + "/paymentOrders/states",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceOrderInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单据的支付状态</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateInstanceOrderInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInstanceOrderInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceOrderInfoResponse
        /// </returns>
        public async Task<UpdateInstanceOrderInfoResponse> UpdateInstanceOrderInfoWithOptionsAsync(string instanceId, UpdateInstanceOrderInfoRequest tmpReq, UpdateInstanceOrderInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateInstanceOrderInfoShrinkRequest request = new UpdateInstanceOrderInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PayerBank))
            {
                request.PayerBankShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PayerBank, "payerBank", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailReason))
            {
                query["failReason"] = request.FailReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                query["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutOrderNo))
            {
                query["outOrderNo"] = request.OutOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerBankShrink))
            {
                query["payerBank"] = request.PayerBankShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentTime))
            {
                query["paymentTime"] = request.PaymentTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
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
                Action = "UpdateInstanceOrderInfo",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/instances/" + instanceId + "/paymentOrders/states",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceOrderInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单据的支付状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceOrderInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceOrderInfoResponse
        /// </returns>
        public UpdateInstanceOrderInfoResponse UpdateInstanceOrderInfo(string instanceId, UpdateInstanceOrderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstanceOrderInfoHeaders headers = new UpdateInstanceOrderInfoHeaders();
            return UpdateInstanceOrderInfoWithOptions(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新单据的支付状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceOrderInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceOrderInfoResponse
        /// </returns>
        public async Task<UpdateInstanceOrderInfoResponse> UpdateInstanceOrderInfoAsync(string instanceId, UpdateInstanceOrderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstanceOrderInfoHeaders headers = new UpdateInstanceOrderInfoHeaders();
            return await UpdateInstanceOrderInfoWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据迁移，新发票应用上报已成功搬移数据</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// UpdateInvoiceDataTransferDoneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceDataTransferDoneResponse
        /// </returns>
        public UpdateInvoiceDataTransferDoneResponse UpdateInvoiceDataTransferDoneWithOptions(UpdateInvoiceDataTransferDoneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateInvoiceDataTransferDone",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/transferredDatas/statuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceDataTransferDoneResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据迁移，新发票应用上报已成功搬移数据</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// UpdateInvoiceDataTransferDoneHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceDataTransferDoneResponse
        /// </returns>
        public async Task<UpdateInvoiceDataTransferDoneResponse> UpdateInvoiceDataTransferDoneWithOptionsAsync(UpdateInvoiceDataTransferDoneHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateInvoiceDataTransferDone",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/transferredDatas/statuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceDataTransferDoneResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据迁移，新发票应用上报已成功搬移数据</para>
        /// </summary>
        /// 
        /// <returns>
        /// UpdateInvoiceDataTransferDoneResponse
        /// </returns>
        public UpdateInvoiceDataTransferDoneResponse UpdateInvoiceDataTransferDone()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceDataTransferDoneHeaders headers = new UpdateInvoiceDataTransferDoneHeaders();
            return UpdateInvoiceDataTransferDoneWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据迁移，新发票应用上报已成功搬移数据</para>
        /// </summary>
        /// 
        /// <returns>
        /// UpdateInvoiceDataTransferDoneResponse
        /// </returns>
        public async Task<UpdateInvoiceDataTransferDoneResponse> UpdateInvoiceDataTransferDoneAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceDataTransferDoneHeaders headers = new UpdateInvoiceDataTransferDoneHeaders();
            return await UpdateInvoiceDataTransferDoneWithOptionsAsync(headers, runtime);
        }

    }
}
