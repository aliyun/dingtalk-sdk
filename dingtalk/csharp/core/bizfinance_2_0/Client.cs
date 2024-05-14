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
         * @summary 银行接入层通用接口
         *
         * @param request BankGatewayInvokeRequest
         * @param headers BankGatewayInvokeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BankGatewayInvokeResponse
         */
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

        /**
         * @summary 银行接入层通用接口
         *
         * @param request BankGatewayInvokeRequest
         * @param headers BankGatewayInvokeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BankGatewayInvokeResponse
         */
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

        /**
         * @summary 银行接入层通用接口
         *
         * @param request BankGatewayInvokeRequest
         * @return BankGatewayInvokeResponse
         */
        public BankGatewayInvokeResponse BankGatewayInvoke(BankGatewayInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BankGatewayInvokeHeaders headers = new BankGatewayInvokeHeaders();
            return BankGatewayInvokeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 银行接入层通用接口
         *
         * @param request BankGatewayInvokeRequest
         * @return BankGatewayInvokeResponse
         */
        public async Task<BankGatewayInvokeResponse> BankGatewayInvokeAsync(BankGatewayInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BankGatewayInvokeHeaders headers = new BankGatewayInvokeHeaders();
            return await BankGatewayInvokeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量删除智能财务单据
         *
         * @param request BatchDeleteReceiptRequest
         * @param headers BatchDeleteReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchDeleteReceiptResponse
         */
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

        /**
         * @summary 批量删除智能财务单据
         *
         * @param request BatchDeleteReceiptRequest
         * @param headers BatchDeleteReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchDeleteReceiptResponse
         */
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

        /**
         * @summary 批量删除智能财务单据
         *
         * @param request BatchDeleteReceiptRequest
         * @return BatchDeleteReceiptResponse
         */
        public BatchDeleteReceiptResponse BatchDeleteReceipt(BatchDeleteReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteReceiptHeaders headers = new BatchDeleteReceiptHeaders();
            return BatchDeleteReceiptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量删除智能财务单据
         *
         * @param request BatchDeleteReceiptRequest
         * @return BatchDeleteReceiptResponse
         */
        public async Task<BatchDeleteReceiptResponse> BatchDeleteReceiptAsync(BatchDeleteReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchDeleteReceiptHeaders headers = new BatchDeleteReceiptHeaders();
            return await BatchDeleteReceiptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量同步银行回单
         *
         * @param request BatchSyncBankReceiptRequest
         * @param headers BatchSyncBankReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSyncBankReceiptResponse
         */
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

        /**
         * @summary 批量同步银行回单
         *
         * @param request BatchSyncBankReceiptRequest
         * @param headers BatchSyncBankReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSyncBankReceiptResponse
         */
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

        /**
         * @summary 批量同步银行回单
         *
         * @param request BatchSyncBankReceiptRequest
         * @return BatchSyncBankReceiptResponse
         */
        public BatchSyncBankReceiptResponse BatchSyncBankReceipt(BatchSyncBankReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSyncBankReceiptHeaders headers = new BatchSyncBankReceiptHeaders();
            return BatchSyncBankReceiptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量同步银行回单
         *
         * @param request BatchSyncBankReceiptRequest
         * @return BatchSyncBankReceiptResponse
         */
        public async Task<BatchSyncBankReceiptResponse> BatchSyncBankReceiptAsync(BatchSyncBankReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchSyncBankReceiptHeaders headers = new BatchSyncBankReceiptHeaders();
            return await BatchSyncBankReceiptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取费用类别
         *
         * @param request GetCategoryRequest
         * @param headers GetCategoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCategoryResponse
         */
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

        /**
         * @summary 获取费用类别
         *
         * @param request GetCategoryRequest
         * @param headers GetCategoryHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCategoryResponse
         */
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

        /**
         * @summary 获取费用类别
         *
         * @param request GetCategoryRequest
         * @return GetCategoryResponse
         */
        public GetCategoryResponse GetCategory(GetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCategoryHeaders headers = new GetCategoryHeaders();
            return GetCategoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取费用类别
         *
         * @param request GetCategoryRequest
         * @return GetCategoryResponse
         */
        public async Task<GetCategoryResponse> GetCategoryAsync(GetCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCategoryHeaders headers = new GetCategoryHeaders();
            return await GetCategoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取企业账户
         *
         * @param request GetFinanceAccountRequest
         * @param headers GetFinanceAccountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFinanceAccountResponse
         */
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

        /**
         * @summary 获取企业账户
         *
         * @param request GetFinanceAccountRequest
         * @param headers GetFinanceAccountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFinanceAccountResponse
         */
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

        /**
         * @summary 获取企业账户
         *
         * @param request GetFinanceAccountRequest
         * @return GetFinanceAccountResponse
         */
        public GetFinanceAccountResponse GetFinanceAccount(GetFinanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFinanceAccountHeaders headers = new GetFinanceAccountHeaders();
            return GetFinanceAccountWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取企业账户
         *
         * @param request GetFinanceAccountRequest
         * @return GetFinanceAccountResponse
         */
        public async Task<GetFinanceAccountResponse> GetFinanceAccountAsync(GetFinanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFinanceAccountHeaders headers = new GetFinanceAccountHeaders();
            return await GetFinanceAccountWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取单条项目
         *
         * @param request GetProjectRequest
         * @param headers GetProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectResponse
         */
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

        /**
         * @summary 获取单条项目
         *
         * @param request GetProjectRequest
         * @param headers GetProjectHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectResponse
         */
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

        /**
         * @summary 获取单条项目
         *
         * @param request GetProjectRequest
         * @return GetProjectResponse
         */
        public GetProjectResponse GetProject(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectHeaders headers = new GetProjectHeaders();
            return GetProjectWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取单条项目
         *
         * @param request GetProjectRequest
         * @return GetProjectResponse
         */
        public async Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProjectHeaders headers = new GetProjectHeaders();
            return await GetProjectWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取智能财务单据详情
         *
         * @param request GetReceiptRequest
         * @param headers GetReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetReceiptResponse
         */
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

        /**
         * @summary 获取智能财务单据详情
         *
         * @param request GetReceiptRequest
         * @param headers GetReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetReceiptResponse
         */
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

        /**
         * @summary 获取智能财务单据详情
         *
         * @param request GetReceiptRequest
         * @return GetReceiptResponse
         */
        public GetReceiptResponse GetReceipt(GetReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetReceiptHeaders headers = new GetReceiptHeaders();
            return GetReceiptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取智能财务单据详情
         *
         * @param request GetReceiptRequest
         * @return GetReceiptResponse
         */
        public async Task<GetReceiptResponse> GetReceiptAsync(GetReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetReceiptHeaders headers = new GetReceiptHeaders();
            return await GetReceiptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取智能财务应用内维护的供应商信息
         *
         * @param request GetSupplierRequest
         * @param headers GetSupplierHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSupplierResponse
         */
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

        /**
         * @summary 获取智能财务应用内维护的供应商信息
         *
         * @param request GetSupplierRequest
         * @param headers GetSupplierHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSupplierResponse
         */
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

        /**
         * @summary 获取智能财务应用内维护的供应商信息
         *
         * @param request GetSupplierRequest
         * @return GetSupplierResponse
         */
        public GetSupplierResponse GetSupplier(GetSupplierRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSupplierHeaders headers = new GetSupplierHeaders();
            return GetSupplierWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取智能财务应用内维护的供应商信息
         *
         * @param request GetSupplierRequest
         * @return GetSupplierResponse
         */
        public async Task<GetSupplierResponse> GetSupplierAsync(GetSupplierRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSupplierHeaders headers = new GetSupplierHeaders();
            return await GetSupplierWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据不同的bizType查询不同的数据
         *
         * @param request LinkCommonInvokeRequest
         * @param headers LinkCommonInvokeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return LinkCommonInvokeResponse
         */
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

        /**
         * @summary 根据不同的bizType查询不同的数据
         *
         * @param request LinkCommonInvokeRequest
         * @param headers LinkCommonInvokeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return LinkCommonInvokeResponse
         */
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

        /**
         * @summary 根据不同的bizType查询不同的数据
         *
         * @param request LinkCommonInvokeRequest
         * @return LinkCommonInvokeResponse
         */
        public LinkCommonInvokeResponse LinkCommonInvoke(LinkCommonInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LinkCommonInvokeHeaders headers = new LinkCommonInvokeHeaders();
            return LinkCommonInvokeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据不同的bizType查询不同的数据
         *
         * @param request LinkCommonInvokeRequest
         * @return LinkCommonInvokeResponse
         */
        public async Task<LinkCommonInvokeResponse> LinkCommonInvokeAsync(LinkCommonInvokeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            LinkCommonInvokeHeaders headers = new LinkCommonInvokeHeaders();
            return await LinkCommonInvokeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量获取费用类别
         *
         * @param request QueryCategoryByPageRequest
         * @param headers QueryCategoryByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCategoryByPageResponse
         */
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

        /**
         * @summary 批量获取费用类别
         *
         * @param request QueryCategoryByPageRequest
         * @param headers QueryCategoryByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCategoryByPageResponse
         */
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

        /**
         * @summary 批量获取费用类别
         *
         * @param request QueryCategoryByPageRequest
         * @return QueryCategoryByPageResponse
         */
        public QueryCategoryByPageResponse QueryCategoryByPage(QueryCategoryByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCategoryByPageHeaders headers = new QueryCategoryByPageHeaders();
            return QueryCategoryByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量获取费用类别
         *
         * @param request QueryCategoryByPageRequest
         * @return QueryCategoryByPageResponse
         */
        public async Task<QueryCategoryByPageResponse> QueryCategoryByPageAsync(QueryCategoryByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCategoryByPageHeaders headers = new QueryCategoryByPageHeaders();
            return await QueryCategoryByPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页批量获取智能财务应用内维护的客户信息
         *
         * @param request QueryCustomerByPageRequest
         * @param headers QueryCustomerByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomerByPageResponse
         */
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

        /**
         * @summary 分页批量获取智能财务应用内维护的客户信息
         *
         * @param request QueryCustomerByPageRequest
         * @param headers QueryCustomerByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomerByPageResponse
         */
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

        /**
         * @summary 分页批量获取智能财务应用内维护的客户信息
         *
         * @param request QueryCustomerByPageRequest
         * @return QueryCustomerByPageResponse
         */
        public QueryCustomerByPageResponse QueryCustomerByPage(QueryCustomerByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerByPageHeaders headers = new QueryCustomerByPageHeaders();
            return QueryCustomerByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页批量获取智能财务应用内维护的客户信息
         *
         * @param request QueryCustomerByPageRequest
         * @return QueryCustomerByPageResponse
         */
        public async Task<QueryCustomerByPageResponse> QueryCustomerByPageAsync(QueryCustomerByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerByPageHeaders headers = new QueryCustomerByPageHeaders();
            return await QueryCustomerByPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量获取企业账户
         *
         * @param request QueryEnterpriseAccountByPageRequest
         * @param headers QueryEnterpriseAccountByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEnterpriseAccountByPageResponse
         */
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

        /**
         * @summary 批量获取企业账户
         *
         * @param request QueryEnterpriseAccountByPageRequest
         * @param headers QueryEnterpriseAccountByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEnterpriseAccountByPageResponse
         */
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

        /**
         * @summary 批量获取企业账户
         *
         * @param request QueryEnterpriseAccountByPageRequest
         * @return QueryEnterpriseAccountByPageResponse
         */
        public QueryEnterpriseAccountByPageResponse QueryEnterpriseAccountByPage(QueryEnterpriseAccountByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEnterpriseAccountByPageHeaders headers = new QueryEnterpriseAccountByPageHeaders();
            return QueryEnterpriseAccountByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量获取企业账户
         *
         * @param request QueryEnterpriseAccountByPageRequest
         * @return QueryEnterpriseAccountByPageResponse
         */
        public async Task<QueryEnterpriseAccountByPageResponse> QueryEnterpriseAccountByPageAsync(QueryEnterpriseAccountByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEnterpriseAccountByPageHeaders headers = new QueryEnterpriseAccountByPageHeaders();
            return await QueryEnterpriseAccountByPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询支付订单详情
         *
         * @param request QueryInstancePaymentOrderDetailRequest
         * @param headers QueryInstancePaymentOrderDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInstancePaymentOrderDetailResponse
         */
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

        /**
         * @summary 查询支付订单详情
         *
         * @param request QueryInstancePaymentOrderDetailRequest
         * @param headers QueryInstancePaymentOrderDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInstancePaymentOrderDetailResponse
         */
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

        /**
         * @summary 查询支付订单详情
         *
         * @param request QueryInstancePaymentOrderDetailRequest
         * @return QueryInstancePaymentOrderDetailResponse
         */
        public QueryInstancePaymentOrderDetailResponse QueryInstancePaymentOrderDetail(string instanceId, QueryInstancePaymentOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInstancePaymentOrderDetailHeaders headers = new QueryInstancePaymentOrderDetailHeaders();
            return QueryInstancePaymentOrderDetailWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 查询支付订单详情
         *
         * @param request QueryInstancePaymentOrderDetailRequest
         * @return QueryInstancePaymentOrderDetailResponse
         */
        public async Task<QueryInstancePaymentOrderDetailResponse> QueryInstancePaymentOrderDetailAsync(string instanceId, QueryInstancePaymentOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInstancePaymentOrderDetailHeaders headers = new QueryInstancePaymentOrderDetailHeaders();
            return await QueryInstancePaymentOrderDetailWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary 批量获取项目信息
         *
         * @param request QueryProjectByPageRequest
         * @param headers QueryProjectByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryProjectByPageResponse
         */
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

        /**
         * @summary 批量获取项目信息
         *
         * @param request QueryProjectByPageRequest
         * @param headers QueryProjectByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryProjectByPageResponse
         */
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

        /**
         * @summary 批量获取项目信息
         *
         * @param request QueryProjectByPageRequest
         * @return QueryProjectByPageResponse
         */
        public QueryProjectByPageResponse QueryProjectByPage(QueryProjectByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProjectByPageHeaders headers = new QueryProjectByPageHeaders();
            return QueryProjectByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量获取项目信息
         *
         * @param request QueryProjectByPageRequest
         * @return QueryProjectByPageResponse
         */
        public async Task<QueryProjectByPageResponse> QueryProjectByPageAsync(QueryProjectByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProjectByPageHeaders headers = new QueryProjectByPageHeaders();
            return await QueryProjectByPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页批量获取智能财务应用内维护的供应商信息
         *
         * @param request QuerySupplierByPageRequest
         * @param headers QuerySupplierByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySupplierByPageResponse
         */
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

        /**
         * @summary 分页批量获取智能财务应用内维护的供应商信息
         *
         * @param request QuerySupplierByPageRequest
         * @param headers QuerySupplierByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySupplierByPageResponse
         */
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

        /**
         * @summary 分页批量获取智能财务应用内维护的供应商信息
         *
         * @param request QuerySupplierByPageRequest
         * @return QuerySupplierByPageResponse
         */
        public QuerySupplierByPageResponse QuerySupplierByPage(QuerySupplierByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySupplierByPageHeaders headers = new QuerySupplierByPageHeaders();
            return QuerySupplierByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页批量获取智能财务应用内维护的供应商信息
         *
         * @param request QuerySupplierByPageRequest
         * @return QuerySupplierByPageResponse
         */
        public async Task<QuerySupplierByPageResponse> QuerySupplierByPageAsync(QuerySupplierByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QuerySupplierByPageHeaders headers = new QuerySupplierByPageHeaders();
            return await QuerySupplierByPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
         *
         * @param request QueryUserRoleListRequest
         * @param headers QueryUserRoleListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserRoleListResponse
         */
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

        /**
         * @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
         *
         * @param request QueryUserRoleListRequest
         * @param headers QueryUserRoleListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserRoleListResponse
         */
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

        /**
         * @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
         *
         * @param request QueryUserRoleListRequest
         * @return QueryUserRoleListResponse
         */
        public QueryUserRoleListResponse QueryUserRoleList(QueryUserRoleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserRoleListHeaders headers = new QueryUserRoleListHeaders();
            return QueryUserRoleListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
         *
         * @param request QueryUserRoleListRequest
         * @return QueryUserRoleListResponse
         */
        public async Task<QueryUserRoleListResponse> QueryUserRoleListAsync(QueryUserRoleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserRoleListHeaders headers = new QueryUserRoleListHeaders();
            return await QueryUserRoleListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 签约企业账户
         *
         * @param request SignEnterpriseAccountRequest
         * @param headers SignEnterpriseAccountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SignEnterpriseAccountResponse
         */
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

        /**
         * @summary 签约企业账户
         *
         * @param request SignEnterpriseAccountRequest
         * @param headers SignEnterpriseAccountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SignEnterpriseAccountResponse
         */
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

        /**
         * @summary 签约企业账户
         *
         * @param request SignEnterpriseAccountRequest
         * @return SignEnterpriseAccountResponse
         */
        public SignEnterpriseAccountResponse SignEnterpriseAccount(SignEnterpriseAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignEnterpriseAccountHeaders headers = new SignEnterpriseAccountHeaders();
            return SignEnterpriseAccountWithOptions(request, headers, runtime);
        }

        /**
         * @summary 签约企业账户
         *
         * @param request SignEnterpriseAccountRequest
         * @return SignEnterpriseAccountResponse
         */
        public async Task<SignEnterpriseAccountResponse> SignEnterpriseAccountAsync(SignEnterpriseAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SignEnterpriseAccountHeaders headers = new SignEnterpriseAccountHeaders();
            return await SignEnterpriseAccountWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发送银企支付回单文件信息
         *
         * @param request SyncReceiptRecallRequest
         * @param headers SyncReceiptRecallHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncReceiptRecallResponse
         */
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

        /**
         * @summary 发送银企支付回单文件信息
         *
         * @param request SyncReceiptRecallRequest
         * @param headers SyncReceiptRecallHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncReceiptRecallResponse
         */
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

        /**
         * @summary 发送银企支付回单文件信息
         *
         * @param request SyncReceiptRecallRequest
         * @return SyncReceiptRecallResponse
         */
        public SyncReceiptRecallResponse SyncReceiptRecall(SyncReceiptRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncReceiptRecallHeaders headers = new SyncReceiptRecallHeaders();
            return SyncReceiptRecallWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发送银企支付回单文件信息
         *
         * @param request SyncReceiptRecallRequest
         * @return SyncReceiptRecallResponse
         */
        public async Task<SyncReceiptRecallResponse> SyncReceiptRecallAsync(SyncReceiptRecallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncReceiptRecallHeaders headers = new SyncReceiptRecallHeaders();
            return await SyncReceiptRecallWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新单据的支付状态
         *
         * @param tmpReq UpdateInstanceOrderInfoRequest
         * @param headers UpdateInstanceOrderInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceOrderInfoResponse
         */
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

        /**
         * @summary 更新单据的支付状态
         *
         * @param tmpReq UpdateInstanceOrderInfoRequest
         * @param headers UpdateInstanceOrderInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceOrderInfoResponse
         */
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

        /**
         * @summary 更新单据的支付状态
         *
         * @param request UpdateInstanceOrderInfoRequest
         * @return UpdateInstanceOrderInfoResponse
         */
        public UpdateInstanceOrderInfoResponse UpdateInstanceOrderInfo(string instanceId, UpdateInstanceOrderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstanceOrderInfoHeaders headers = new UpdateInstanceOrderInfoHeaders();
            return UpdateInstanceOrderInfoWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 更新单据的支付状态
         *
         * @param request UpdateInstanceOrderInfoRequest
         * @return UpdateInstanceOrderInfoResponse
         */
        public async Task<UpdateInstanceOrderInfoResponse> UpdateInstanceOrderInfoAsync(string instanceId, UpdateInstanceOrderInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInstanceOrderInfoHeaders headers = new UpdateInstanceOrderInfoHeaders();
            return await UpdateInstanceOrderInfoWithOptionsAsync(instanceId, request, headers, runtime);
        }

    }
}
