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
        /// <para>新增智能财务的企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddFinanceEnterpriseAccountRequest
        /// </param>
        /// <param name="headers">
        /// AddFinanceEnterpriseAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddFinanceEnterpriseAccountResponse
        /// </returns>
        public AddFinanceEnterpriseAccountResponse AddFinanceEnterpriseAccountWithOptions(AddFinanceEnterpriseAccountRequest request, AddFinanceEnterpriseAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["accountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["accountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardNo))
            {
                body["bankCardNo"] = request.BankCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCode))
            {
                body["bankCode"] = request.BankCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankName))
            {
                body["bankName"] = request.BankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficialName))
            {
                body["officialName"] = request.OfficialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficialNumber))
            {
                body["officialNumber"] = request.OfficialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNature))
            {
                body["taxNature"] = request.TaxNature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["taxNo"] = request.TaxNo;
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
                Action = "AddFinanceEnterpriseAccount",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/enterpriseAccounts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFinanceEnterpriseAccountResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增智能财务的企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddFinanceEnterpriseAccountRequest
        /// </param>
        /// <param name="headers">
        /// AddFinanceEnterpriseAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddFinanceEnterpriseAccountResponse
        /// </returns>
        public async Task<AddFinanceEnterpriseAccountResponse> AddFinanceEnterpriseAccountWithOptionsAsync(AddFinanceEnterpriseAccountRequest request, AddFinanceEnterpriseAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["accountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["accountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardNo))
            {
                body["bankCardNo"] = request.BankCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCode))
            {
                body["bankCode"] = request.BankCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankName))
            {
                body["bankName"] = request.BankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficialName))
            {
                body["officialName"] = request.OfficialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficialNumber))
            {
                body["officialNumber"] = request.OfficialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNature))
            {
                body["taxNature"] = request.TaxNature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["taxNo"] = request.TaxNo;
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
                Action = "AddFinanceEnterpriseAccount",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/enterpriseAccounts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddFinanceEnterpriseAccountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增智能财务的企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddFinanceEnterpriseAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// AddFinanceEnterpriseAccountResponse
        /// </returns>
        public AddFinanceEnterpriseAccountResponse AddFinanceEnterpriseAccount(AddFinanceEnterpriseAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFinanceEnterpriseAccountHeaders headers = new AddFinanceEnterpriseAccountHeaders();
            return AddFinanceEnterpriseAccountWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增智能财务的企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddFinanceEnterpriseAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// AddFinanceEnterpriseAccountResponse
        /// </returns>
        public async Task<AddFinanceEnterpriseAccountResponse> AddFinanceEnterpriseAccountAsync(AddFinanceEnterpriseAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddFinanceEnterpriseAccountHeaders headers = new AddFinanceEnterpriseAccountHeaders();
            return await AddFinanceEnterpriseAccountWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>留资上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRetentionRecordRequest
        /// </param>
        /// <param name="headers">
        /// AddRetentionRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRetentionRecordResponse
        /// </returns>
        public AddRetentionRecordResponse AddRetentionRecordWithOptions(AddRetentionRecordRequest request, AddRetentionRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateCode))
            {
                query["stateCode"] = request.StateCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddRetentionRecord",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/retentionRecord",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRetentionRecordResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>留资上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRetentionRecordRequest
        /// </param>
        /// <param name="headers">
        /// AddRetentionRecordHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRetentionRecordResponse
        /// </returns>
        public async Task<AddRetentionRecordResponse> AddRetentionRecordWithOptionsAsync(AddRetentionRecordRequest request, AddRetentionRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateCode))
            {
                query["stateCode"] = request.StateCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "AddRetentionRecord",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/retentionRecord",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRetentionRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>留资上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRetentionRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRetentionRecordResponse
        /// </returns>
        public AddRetentionRecordResponse AddRetentionRecord(AddRetentionRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRetentionRecordHeaders headers = new AddRetentionRecordHeaders();
            return AddRetentionRecordWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>留资上报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRetentionRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRetentionRecordResponse
        /// </returns>
        public async Task<AddRetentionRecordResponse> AddRetentionRecordAsync(AddRetentionRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRetentionRecordHeaders headers = new AddRetentionRecordHeaders();
            return await AddRetentionRecordWithOptionsAsync(request, headers, runtime);
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
        /// <para>批量查询企业票池发票下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryOrgInvoiceUrlRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryOrgInvoiceUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryOrgInvoiceUrlResponse
        /// </returns>
        public BatchQueryOrgInvoiceUrlResponse BatchQueryOrgInvoiceUrlWithOptions(BatchQueryOrgInvoiceUrlRequest request, BatchQueryOrgInvoiceUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceKeyVOList))
            {
                body["invoiceKeyVOList"] = request.InvoiceKeyVOList;
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
                Action = "BatchQueryOrgInvoiceUrl",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/urls/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryOrgInvoiceUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询企业票池发票下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryOrgInvoiceUrlRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryOrgInvoiceUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryOrgInvoiceUrlResponse
        /// </returns>
        public async Task<BatchQueryOrgInvoiceUrlResponse> BatchQueryOrgInvoiceUrlWithOptionsAsync(BatchQueryOrgInvoiceUrlRequest request, BatchQueryOrgInvoiceUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceKeyVOList))
            {
                body["invoiceKeyVOList"] = request.InvoiceKeyVOList;
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
                Action = "BatchQueryOrgInvoiceUrl",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/urls/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryOrgInvoiceUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询企业票池发票下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryOrgInvoiceUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryOrgInvoiceUrlResponse
        /// </returns>
        public BatchQueryOrgInvoiceUrlResponse BatchQueryOrgInvoiceUrl(BatchQueryOrgInvoiceUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryOrgInvoiceUrlHeaders headers = new BatchQueryOrgInvoiceUrlHeaders();
            return BatchQueryOrgInvoiceUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询企业票池发票下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryOrgInvoiceUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryOrgInvoiceUrlResponse
        /// </returns>
        public async Task<BatchQueryOrgInvoiceUrlResponse> BatchQueryOrgInvoiceUrlAsync(BatchQueryOrgInvoiceUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryOrgInvoiceUrlHeaders headers = new BatchQueryOrgInvoiceUrlHeaders();
            return await BatchQueryOrgInvoiceUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询支付回单文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryPaymentRecallFileRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryPaymentRecallFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryPaymentRecallFileResponse
        /// </returns>
        public BatchQueryPaymentRecallFileResponse BatchQueryPaymentRecallFileWithOptions(BatchQueryPaymentRecallFileRequest request, BatchQueryPaymentRecallFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailIdList))
            {
                body["detailIdList"] = request.DetailIdList;
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
                Action = "BatchQueryPaymentRecallFile",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/recallFiles/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryPaymentRecallFileResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询支付回单文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryPaymentRecallFileRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryPaymentRecallFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryPaymentRecallFileResponse
        /// </returns>
        public async Task<BatchQueryPaymentRecallFileResponse> BatchQueryPaymentRecallFileWithOptionsAsync(BatchQueryPaymentRecallFileRequest request, BatchQueryPaymentRecallFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailIdList))
            {
                body["detailIdList"] = request.DetailIdList;
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
                Action = "BatchQueryPaymentRecallFile",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/recallFiles/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryPaymentRecallFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询支付回单文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryPaymentRecallFileRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryPaymentRecallFileResponse
        /// </returns>
        public BatchQueryPaymentRecallFileResponse BatchQueryPaymentRecallFile(BatchQueryPaymentRecallFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryPaymentRecallFileHeaders headers = new BatchQueryPaymentRecallFileHeaders();
            return BatchQueryPaymentRecallFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询支付回单文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryPaymentRecallFileRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryPaymentRecallFileResponse
        /// </returns>
        public async Task<BatchQueryPaymentRecallFileResponse> BatchQueryPaymentRecallFileAsync(BatchQueryPaymentRecallFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryPaymentRecallFileHeaders headers = new BatchQueryPaymentRecallFileHeaders();
            return await BatchQueryPaymentRecallFileWithOptionsAsync(request, headers, runtime);
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
        /// <para>查验发票是否生成凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckVoucherStatusRequest
        /// </param>
        /// <param name="headers">
        /// CheckVoucherStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckVoucherStatusResponse
        /// </returns>
        public CheckVoucherStatusResponse CheckVoucherStatusWithOptions(CheckVoucherStatusRequest request, CheckVoucherStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceType))
            {
                body["financeType"] = request.FinanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                body["invoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                body["invoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["taxNo"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyStatus))
            {
                body["verifyStatus"] = request.VerifyStatus;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckVoucherStatus",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/checkVoucherStatus/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckVoucherStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查验发票是否生成凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckVoucherStatusRequest
        /// </param>
        /// <param name="headers">
        /// CheckVoucherStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckVoucherStatusResponse
        /// </returns>
        public async Task<CheckVoucherStatusResponse> CheckVoucherStatusWithOptionsAsync(CheckVoucherStatusRequest request, CheckVoucherStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinanceType))
            {
                body["financeType"] = request.FinanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                body["invoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                body["invoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["taxNo"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyStatus))
            {
                body["verifyStatus"] = request.VerifyStatus;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckVoucherStatus",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/checkVoucherStatus/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckVoucherStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查验发票是否生成凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckVoucherStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckVoucherStatusResponse
        /// </returns>
        public CheckVoucherStatusResponse CheckVoucherStatus(CheckVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckVoucherStatusHeaders headers = new CheckVoucherStatusHeaders();
            return CheckVoucherStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查验发票是否生成凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckVoucherStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckVoucherStatusResponse
        /// </returns>
        public async Task<CheckVoucherStatusResponse> CheckVoucherStatusAsync(CheckVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckVoucherStatusHeaders headers = new CheckVoucherStatusHeaders();
            return await CheckVoucherStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取唤起智能财务收银台的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmPaymentOrderRequest
        /// </param>
        /// <param name="headers">
        /// ConfirmPaymentOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmPaymentOrderResponse
        /// </returns>
        public ConfirmPaymentOrderResponse ConfirmPaymentOrderWithOptions(ConfirmPaymentOrderRequest request, ConfirmPaymentOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizNoList))
            {
                body["outBizNoList"] = request.OutBizNoList;
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
                Action = "ConfirmPaymentOrder",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/confirm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmPaymentOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取唤起智能财务收银台的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmPaymentOrderRequest
        /// </param>
        /// <param name="headers">
        /// ConfirmPaymentOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmPaymentOrderResponse
        /// </returns>
        public async Task<ConfirmPaymentOrderResponse> ConfirmPaymentOrderWithOptionsAsync(ConfirmPaymentOrderRequest request, ConfirmPaymentOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizNoList))
            {
                body["outBizNoList"] = request.OutBizNoList;
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
                Action = "ConfirmPaymentOrder",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/confirm",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmPaymentOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取唤起智能财务收银台的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmPaymentOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmPaymentOrderResponse
        /// </returns>
        public ConfirmPaymentOrderResponse ConfirmPaymentOrder(ConfirmPaymentOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConfirmPaymentOrderHeaders headers = new ConfirmPaymentOrderHeaders();
            return ConfirmPaymentOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取唤起智能财务收银台的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ConfirmPaymentOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmPaymentOrderResponse
        /// </returns>
        public async Task<ConfirmPaymentOrderResponse> ConfirmPaymentOrderAsync(ConfirmPaymentOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConfirmPaymentOrderHeaders headers = new ConfirmPaymentOrderHeaders();
            return await ConfirmPaymentOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建收款订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCollectionOrderRequest
        /// </param>
        /// <param name="headers">
        /// CreateCollectionOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCollectionOrderResponse
        /// </returns>
        public CreateCollectionOrderResponse CreateCollectionOrderWithOptions(CreateCollectionOrderRequest request, CreateCollectionOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectionInfoId))
            {
                query["collectionInfoId"] = request.CollectionInfoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["remark"] = request.Remark;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateCollectionOrder",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/me/collections/orders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCollectionOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建收款订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCollectionOrderRequest
        /// </param>
        /// <param name="headers">
        /// CreateCollectionOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCollectionOrderResponse
        /// </returns>
        public async Task<CreateCollectionOrderResponse> CreateCollectionOrderWithOptionsAsync(CreateCollectionOrderRequest request, CreateCollectionOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CollectionInfoId))
            {
                query["collectionInfoId"] = request.CollectionInfoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["remark"] = request.Remark;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateCollectionOrder",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/me/collections/orders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCollectionOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建收款订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCollectionOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCollectionOrderResponse
        /// </returns>
        public CreateCollectionOrderResponse CreateCollectionOrder(CreateCollectionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCollectionOrderHeaders headers = new CreateCollectionOrderHeaders();
            return CreateCollectionOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建收款订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCollectionOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCollectionOrderResponse
        /// </returns>
        public async Task<CreateCollectionOrderResponse> CreateCollectionOrderAsync(CreateCollectionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCollectionOrderHeaders headers = new CreateCollectionOrderHeaders();
            return await CreateCollectionOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务待支付订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePaymentOrderRequest
        /// </param>
        /// <param name="headers">
        /// CreatePaymentOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePaymentOrderResponse
        /// </returns>
        public CreatePaymentOrderResponse CreatePaymentOrderWithOptions(CreatePaymentOrderRequest request, CreatePaymentOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizNo))
            {
                body["outBizNo"] = request.OutBizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayeeAccountDTO))
            {
                body["payeeAccountDTO"] = request.PayeeAccountDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerAccountDTO))
            {
                body["payerAccountDTO"] = request.PayerAccountDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentOrderTitle))
            {
                body["paymentOrderTitle"] = request.PaymentOrderTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Usage))
            {
                body["usage"] = request.Usage;
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
                Action = "CreatePaymentOrder",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/orders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePaymentOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务待支付订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePaymentOrderRequest
        /// </param>
        /// <param name="headers">
        /// CreatePaymentOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePaymentOrderResponse
        /// </returns>
        public async Task<CreatePaymentOrderResponse> CreatePaymentOrderWithOptionsAsync(CreatePaymentOrderRequest request, CreatePaymentOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizNo))
            {
                body["outBizNo"] = request.OutBizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayeeAccountDTO))
            {
                body["payeeAccountDTO"] = request.PayeeAccountDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerAccountDTO))
            {
                body["payerAccountDTO"] = request.PayerAccountDTO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentOrderTitle))
            {
                body["paymentOrderTitle"] = request.PaymentOrderTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Usage))
            {
                body["usage"] = request.Usage;
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
                Action = "CreatePaymentOrder",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/orders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePaymentOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务待支付订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePaymentOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePaymentOrderResponse
        /// </returns>
        public CreatePaymentOrderResponse CreatePaymentOrder(CreatePaymentOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePaymentOrderHeaders headers = new CreatePaymentOrderHeaders();
            return CreatePaymentOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务待支付订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePaymentOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePaymentOrderResponse
        /// </returns>
        public async Task<CreatePaymentOrderResponse> CreatePaymentOrderAsync(CreatePaymentOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatePaymentOrderHeaders headers = new CreatePaymentOrderHeaders();
            return await CreatePaymentOrderWithOptionsAsync(request, headers, runtime);
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
        /// <para>查询企业内自定义辅助档案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefineRequest
        /// </param>
        /// <param name="headers">
        /// GetDefineHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDefineResponse
        /// </returns>
        public GetDefineResponse GetDefineWithOptions(GetDefineRequest request, GetDefineHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefine",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/customInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefineResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内自定义辅助档案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefineRequest
        /// </param>
        /// <param name="headers">
        /// GetDefineHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDefineResponse
        /// </returns>
        public async Task<GetDefineResponse> GetDefineWithOptionsAsync(GetDefineRequest request, GetDefineHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefine",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/customInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefineResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内自定义辅助档案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefineRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDefineResponse
        /// </returns>
        public GetDefineResponse GetDefine(GetDefineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDefineHeaders headers = new GetDefineHeaders();
            return GetDefineWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内自定义辅助档案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefineRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDefineResponse
        /// </returns>
        public async Task<GetDefineResponse> GetDefineAsync(GetDefineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDefineHeaders headers = new GetDefineHeaders();
            return await GetDefineWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内自定义辅助档案数据信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefineDataRequest
        /// </param>
        /// <param name="headers">
        /// GetDefineDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDefineDataResponse
        /// </returns>
        public GetDefineDataResponse GetDefineDataWithOptions(GetDefineDataRequest request, GetDefineDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefineData",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/customDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefineDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内自定义辅助档案数据信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefineDataRequest
        /// </param>
        /// <param name="headers">
        /// GetDefineDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDefineDataResponse
        /// </returns>
        public async Task<GetDefineDataResponse> GetDefineDataWithOptionsAsync(GetDefineDataRequest request, GetDefineDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefineData",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/customDatas/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefineDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内自定义辅助档案数据信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefineDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDefineDataResponse
        /// </returns>
        public GetDefineDataResponse GetDefineData(GetDefineDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDefineDataHeaders headers = new GetDefineDataHeaders();
            return GetDefineDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业内自定义辅助档案数据信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefineDataRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDefineDataResponse
        /// </returns>
        public async Task<GetDefineDataResponse> GetDefineDataAsync(GetDefineDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDefineDataHeaders headers = new GetDefineDataHeaders();
            return await GetDefineDataWithOptionsAsync(request, headers, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["businessId"] = request.BusinessId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessId))
            {
                query["businessId"] = request.BusinessId;
            }
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
        /// <para>根据staffId批量查询返回支付宝userId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAlipayUserIdRequest
        /// </param>
        /// <param name="headers">
        /// QueryAlipayUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAlipayUserIdResponse
        /// </returns>
        public QueryAlipayUserIdResponse QueryAlipayUserIdWithOptions(QueryAlipayUserIdRequest request, QueryAlipayUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserIds))
            {
                body["dingUserIds"] = request.DingUserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAlipayUserId",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/consumption/aliPay/getUserId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAlipayUserIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据staffId批量查询返回支付宝userId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAlipayUserIdRequest
        /// </param>
        /// <param name="headers">
        /// QueryAlipayUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAlipayUserIdResponse
        /// </returns>
        public async Task<QueryAlipayUserIdResponse> QueryAlipayUserIdWithOptionsAsync(QueryAlipayUserIdRequest request, QueryAlipayUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserIds))
            {
                body["dingUserIds"] = request.DingUserIds;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAlipayUserId",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/consumption/aliPay/getUserId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAlipayUserIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据staffId批量查询返回支付宝userId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAlipayUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAlipayUserIdResponse
        /// </returns>
        public QueryAlipayUserIdResponse QueryAlipayUserId(QueryAlipayUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAlipayUserIdHeaders headers = new QueryAlipayUserIdHeaders();
            return QueryAlipayUserIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据staffId批量查询返回支付宝userId</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAlipayUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAlipayUserIdResponse
        /// </returns>
        public async Task<QueryAlipayUserIdResponse> QueryAlipayUserIdAsync(QueryAlipayUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAlipayUserIdHeaders headers = new QueryAlipayUserIdHeaders();
            return await QueryAlipayUserIdWithOptionsAsync(request, headers, runtime);
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
        /// <para>查询进件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCollectionInfoListRequest
        /// </param>
        /// <param name="headers">
        /// QueryCollectionInfoListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCollectionInfoListResponse
        /// </returns>
        public QueryCollectionInfoListResponse QueryCollectionInfoListWithOptions(QueryCollectionInfoListRequest request, QueryCollectionInfoListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCollectionInfoList",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/me/collections/accounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCollectionInfoListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询进件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCollectionInfoListRequest
        /// </param>
        /// <param name="headers">
        /// QueryCollectionInfoListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCollectionInfoListResponse
        /// </returns>
        public async Task<QueryCollectionInfoListResponse> QueryCollectionInfoListWithOptionsAsync(QueryCollectionInfoListRequest request, QueryCollectionInfoListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCollectionInfoList",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/me/collections/accounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCollectionInfoListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询进件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCollectionInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCollectionInfoListResponse
        /// </returns>
        public QueryCollectionInfoListResponse QueryCollectionInfoList(QueryCollectionInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCollectionInfoListHeaders headers = new QueryCollectionInfoListHeaders();
            return QueryCollectionInfoListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询进件信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCollectionInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCollectionInfoListResponse
        /// </returns>
        public async Task<QueryCollectionInfoListResponse> QueryCollectionInfoListAsync(QueryCollectionInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCollectionInfoListHeaders headers = new QueryCollectionInfoListHeaders();
            return await QueryCollectionInfoListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询收款订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCollectionOrderRequest
        /// </param>
        /// <param name="headers">
        /// QueryCollectionOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCollectionOrderResponse
        /// </returns>
        public QueryCollectionOrderResponse QueryCollectionOrderWithOptions(QueryCollectionOrderRequest request, QueryCollectionOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCollectionOrder",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/me/collections/orders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCollectionOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询收款订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCollectionOrderRequest
        /// </param>
        /// <param name="headers">
        /// QueryCollectionOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCollectionOrderResponse
        /// </returns>
        public async Task<QueryCollectionOrderResponse> QueryCollectionOrderWithOptionsAsync(QueryCollectionOrderRequest request, QueryCollectionOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCollectionOrder",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/me/collections/orders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCollectionOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询收款订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCollectionOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCollectionOrderResponse
        /// </returns>
        public QueryCollectionOrderResponse QueryCollectionOrder(QueryCollectionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCollectionOrderHeaders headers = new QueryCollectionOrderHeaders();
            return QueryCollectionOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询收款订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCollectionOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCollectionOrderResponse
        /// </returns>
        public async Task<QueryCollectionOrderResponse> QueryCollectionOrderAsync(QueryCollectionOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCollectionOrderHeaders headers = new QueryCollectionOrderHeaders();
            return await QueryCollectionOrderWithOptionsAsync(request, headers, runtime);
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
        /// <para>获取智能财务企业账户签约地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnterpriseAccountSignUrlRequest
        /// </param>
        /// <param name="headers">
        /// QueryEnterpriseAccountSignUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseAccountSignUrlResponse
        /// </returns>
        public QueryEnterpriseAccountSignUrlResponse QueryEnterpriseAccountSignUrlWithOptions(QueryEnterpriseAccountSignUrlRequest request, QueryEnterpriseAccountSignUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountCode))
            {
                query["accountCode"] = request.AccountCode;
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
                Action = "QueryEnterpriseAccountSignUrl",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/enterpriseAccounts/sign",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnterpriseAccountSignUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务企业账户签约地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnterpriseAccountSignUrlRequest
        /// </param>
        /// <param name="headers">
        /// QueryEnterpriseAccountSignUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseAccountSignUrlResponse
        /// </returns>
        public async Task<QueryEnterpriseAccountSignUrlResponse> QueryEnterpriseAccountSignUrlWithOptionsAsync(QueryEnterpriseAccountSignUrlRequest request, QueryEnterpriseAccountSignUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountCode))
            {
                query["accountCode"] = request.AccountCode;
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
                Action = "QueryEnterpriseAccountSignUrl",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/enterpriseAccounts/sign",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnterpriseAccountSignUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务企业账户签约地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnterpriseAccountSignUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseAccountSignUrlResponse
        /// </returns>
        public QueryEnterpriseAccountSignUrlResponse QueryEnterpriseAccountSignUrl(QueryEnterpriseAccountSignUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEnterpriseAccountSignUrlHeaders headers = new QueryEnterpriseAccountSignUrlHeaders();
            return QueryEnterpriseAccountSignUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务企业账户签约地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEnterpriseAccountSignUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseAccountSignUrlResponse
        /// </returns>
        public async Task<QueryEnterpriseAccountSignUrlResponse> QueryEnterpriseAccountSignUrlAsync(QueryEnterpriseAccountSignUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEnterpriseAccountSignUrlHeaders headers = new QueryEnterpriseAccountSignUrlHeaders();
            return await QueryEnterpriseAccountSignUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织的企业码开通情况</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryEnterpriseCodeOpenDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseCodeOpenDetailResponse
        /// </returns>
        public QueryEnterpriseCodeOpenDetailResponse QueryEnterpriseCodeOpenDetailWithOptions(QueryEnterpriseCodeOpenDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryEnterpriseCodeOpenDetail",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/enterprisecode/getOpenDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnterpriseCodeOpenDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织的企业码开通情况</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryEnterpriseCodeOpenDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnterpriseCodeOpenDetailResponse
        /// </returns>
        public async Task<QueryEnterpriseCodeOpenDetailResponse> QueryEnterpriseCodeOpenDetailWithOptionsAsync(QueryEnterpriseCodeOpenDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryEnterpriseCodeOpenDetail",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/enterprisecode/getOpenDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnterpriseCodeOpenDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织的企业码开通情况</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryEnterpriseCodeOpenDetailResponse
        /// </returns>
        public QueryEnterpriseCodeOpenDetailResponse QueryEnterpriseCodeOpenDetail()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEnterpriseCodeOpenDetailHeaders headers = new QueryEnterpriseCodeOpenDetailHeaders();
            return QueryEnterpriseCodeOpenDetailWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询组织的企业码开通情况</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryEnterpriseCodeOpenDetailResponse
        /// </returns>
        public async Task<QueryEnterpriseCodeOpenDetailResponse> QueryEnterpriseCodeOpenDetailAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryEnterpriseCodeOpenDetailHeaders headers = new QueryEnterpriseCodeOpenDetailHeaders();
            return await QueryEnterpriseCodeOpenDetailWithOptionsAsync(headers, runtime);
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
        /// <para>查询支付的权益使用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentBenefitRequest
        /// </param>
        /// <param name="headers">
        /// QueryPaymentBenefitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentBenefitResponse
        /// </returns>
        public QueryPaymentBenefitResponse QueryPaymentBenefitWithOptions(QueryPaymentBenefitRequest request, QueryPaymentBenefitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPaymentBenefit",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/benefits",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPaymentBenefitResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付的权益使用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentBenefitRequest
        /// </param>
        /// <param name="headers">
        /// QueryPaymentBenefitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentBenefitResponse
        /// </returns>
        public async Task<QueryPaymentBenefitResponse> QueryPaymentBenefitWithOptionsAsync(QueryPaymentBenefitRequest request, QueryPaymentBenefitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPaymentBenefit",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/benefits",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPaymentBenefitResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付的权益使用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentBenefitRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentBenefitResponse
        /// </returns>
        public QueryPaymentBenefitResponse QueryPaymentBenefit(QueryPaymentBenefitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPaymentBenefitHeaders headers = new QueryPaymentBenefitHeaders();
            return QueryPaymentBenefitWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询支付的权益使用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentBenefitRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentBenefitResponse
        /// </returns>
        public async Task<QueryPaymentBenefitResponse> QueryPaymentBenefitAsync(QueryPaymentBenefitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPaymentBenefitHeaders headers = new QueryPaymentBenefitHeaders();
            return await QueryPaymentBenefitWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务支付订单信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryPaymentOrderDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryPaymentOrderDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentOrderDetailResponse
        /// </returns>
        public QueryPaymentOrderDetailResponse QueryPaymentOrderDetailWithOptions(QueryPaymentOrderDetailRequest tmpReq, QueryPaymentOrderDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryPaymentOrderDetailShrinkRequest request = new QueryPaymentOrderDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutBizNoList))
            {
                request.OutBizNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutBizNoList, "outBizNoList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizNoListShrink))
            {
                query["outBizNoList"] = request.OutBizNoListShrink;
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
                Action = "QueryPaymentOrderDetail",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/orders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPaymentOrderDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务支付订单信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryPaymentOrderDetailRequest
        /// </param>
        /// <param name="headers">
        /// QueryPaymentOrderDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentOrderDetailResponse
        /// </returns>
        public async Task<QueryPaymentOrderDetailResponse> QueryPaymentOrderDetailWithOptionsAsync(QueryPaymentOrderDetailRequest tmpReq, QueryPaymentOrderDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryPaymentOrderDetailShrinkRequest request = new QueryPaymentOrderDetailShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutBizNoList))
            {
                request.OutBizNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutBizNoList, "outBizNoList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizNoListShrink))
            {
                query["outBizNoList"] = request.OutBizNoListShrink;
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
                Action = "QueryPaymentOrderDetail",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/payments/orders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPaymentOrderDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务支付订单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentOrderDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentOrderDetailResponse
        /// </returns>
        public QueryPaymentOrderDetailResponse QueryPaymentOrderDetail(QueryPaymentOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPaymentOrderDetailHeaders headers = new QueryPaymentOrderDetailHeaders();
            return QueryPaymentOrderDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务支付订单信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPaymentOrderDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPaymentOrderDetailResponse
        /// </returns>
        public async Task<QueryPaymentOrderDetailResponse> QueryPaymentOrderDetailAsync(QueryPaymentOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPaymentOrderDetailHeaders headers = new QueryPaymentOrderDetailHeaders();
            return await QueryPaymentOrderDetailWithOptionsAsync(request, headers, runtime);
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
        /// <para>查询对应权限点的人员staffId</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryPermissionUserIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionUserIdsResponse
        /// </returns>
        public QueryPermissionUserIdsResponse QueryPermissionUserIdsWithOptions(QueryPermissionUserIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPermissionUserIds",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/consumption/permission/getUserIds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPermissionUserIdsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询对应权限点的人员staffId</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryPermissionUserIdsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionUserIdsResponse
        /// </returns>
        public async Task<QueryPermissionUserIdsResponse> QueryPermissionUserIdsWithOptionsAsync(QueryPermissionUserIdsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPermissionUserIds",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/consumption/permission/getUserIds",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPermissionUserIdsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询对应权限点的人员staffId</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryPermissionUserIdsResponse
        /// </returns>
        public QueryPermissionUserIdsResponse QueryPermissionUserIds()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPermissionUserIdsHeaders headers = new QueryPermissionUserIdsHeaders();
            return QueryPermissionUserIdsWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询对应权限点的人员staffId</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryPermissionUserIdsResponse
        /// </returns>
        public async Task<QueryPermissionUserIdsResponse> QueryPermissionUserIdsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPermissionUserIdsHeaders headers = new QueryPermissionUserIdsHeaders();
            return await QueryPermissionUserIdsWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryProductByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProductByPageResponse
        /// </returns>
        public QueryProductByPageResponse QueryProductByPageWithOptions(QueryProductByPageRequest request, QueryProductByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryProductByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/products/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProductByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryProductByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryProductByPageResponse
        /// </returns>
        public async Task<QueryProductByPageResponse> QueryProductByPageWithOptionsAsync(QueryProductByPageRequest request, QueryProductByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryProductByPage",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/products/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryProductByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProductByPageResponse
        /// </returns>
        public QueryProductByPageResponse QueryProductByPage(QueryProductByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProductByPageHeaders headers = new QueryProductByPageHeaders();
            return QueryProductByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryProductByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryProductByPageResponse
        /// </returns>
        public async Task<QueryProductByPageResponse> QueryProductByPageAsync(QueryProductByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProductByPageHeaders headers = new QueryProductByPageHeaders();
            return await QueryProductByPageWithOptionsAsync(request, headers, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountCode))
            {
                query["accountCode"] = request.AccountCode;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeeItemCode))
            {
                query["feeItemCode"] = request.FeeItemCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueNo))
            {
                query["issueNo"] = request.IssueNo;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountCode))
            {
                query["accountCode"] = request.AccountCode;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeeItemCode))
            {
                query["feeItemCode"] = request.FeeItemCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueNo))
            {
                query["issueNo"] = request.IssueNo;
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
        /// <para>更新智能财务档案的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAuxiliaryStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateAuxiliaryStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAuxiliaryStatusResponse
        /// </returns>
        public UpdateAuxiliaryStatusResponse UpdateAuxiliaryStatusWithOptions(UpdateAuxiliaryStatusRequest request, UpdateAuxiliaryStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuxiliaryId))
            {
                query["auxiliaryId"] = request.AuxiliaryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuxiliaryType))
            {
                query["auxiliaryType"] = request.AuxiliaryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["operateType"] = request.OperateType;
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
                Action = "UpdateAuxiliaryStatus",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/auxiliaries/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAuxiliaryStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务档案的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAuxiliaryStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateAuxiliaryStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAuxiliaryStatusResponse
        /// </returns>
        public async Task<UpdateAuxiliaryStatusResponse> UpdateAuxiliaryStatusWithOptionsAsync(UpdateAuxiliaryStatusRequest request, UpdateAuxiliaryStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuxiliaryId))
            {
                query["auxiliaryId"] = request.AuxiliaryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuxiliaryType))
            {
                query["auxiliaryType"] = request.AuxiliaryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["operateType"] = request.OperateType;
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
                Action = "UpdateAuxiliaryStatus",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/auxiliaries/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAuxiliaryStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务档案的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAuxiliaryStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAuxiliaryStatusResponse
        /// </returns>
        public UpdateAuxiliaryStatusResponse UpdateAuxiliaryStatus(UpdateAuxiliaryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAuxiliaryStatusHeaders headers = new UpdateAuxiliaryStatusHeaders();
            return UpdateAuxiliaryStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务档案的状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAuxiliaryStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAuxiliaryStatusResponse
        /// </returns>
        public async Task<UpdateAuxiliaryStatusResponse> UpdateAuxiliaryStatusAsync(UpdateAuxiliaryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateAuxiliaryStatusHeaders headers = new UpdateAuxiliaryStatusHeaders();
            return await UpdateAuxiliaryStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务的企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceEnterpriseAccountRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFinanceEnterpriseAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceEnterpriseAccountResponse
        /// </returns>
        public UpdateFinanceEnterpriseAccountResponse UpdateFinanceEnterpriseAccountWithOptions(UpdateFinanceEnterpriseAccountRequest request, UpdateFinanceEnterpriseAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountCode))
            {
                body["accountCode"] = request.AccountCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["accountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["accountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardNo))
            {
                body["bankCardNo"] = request.BankCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCode))
            {
                body["bankCode"] = request.BankCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankName))
            {
                body["bankName"] = request.BankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficialName))
            {
                body["officialName"] = request.OfficialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficialNumber))
            {
                body["officialNumber"] = request.OfficialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNature))
            {
                body["taxNature"] = request.TaxNature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["taxNo"] = request.TaxNo;
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
                Action = "UpdateFinanceEnterpriseAccount",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/enterpriseAccounts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFinanceEnterpriseAccountResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务的企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceEnterpriseAccountRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFinanceEnterpriseAccountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceEnterpriseAccountResponse
        /// </returns>
        public async Task<UpdateFinanceEnterpriseAccountResponse> UpdateFinanceEnterpriseAccountWithOptionsAsync(UpdateFinanceEnterpriseAccountRequest request, UpdateFinanceEnterpriseAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountCode))
            {
                body["accountCode"] = request.AccountCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                body["accountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                body["accountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCardNo))
            {
                body["bankCardNo"] = request.BankCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankCode))
            {
                body["bankCode"] = request.BankCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BankName))
            {
                body["bankName"] = request.BankName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                body["city"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficialName))
            {
                body["officialName"] = request.OfficialName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficialNumber))
            {
                body["officialNumber"] = request.OfficialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                body["province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNature))
            {
                body["taxNature"] = request.TaxNature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                body["taxNo"] = request.TaxNo;
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
                Action = "UpdateFinanceEnterpriseAccount",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/enterpriseAccounts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFinanceEnterpriseAccountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务的企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceEnterpriseAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceEnterpriseAccountResponse
        /// </returns>
        public UpdateFinanceEnterpriseAccountResponse UpdateFinanceEnterpriseAccount(UpdateFinanceEnterpriseAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFinanceEnterpriseAccountHeaders headers = new UpdateFinanceEnterpriseAccountHeaders();
            return UpdateFinanceEnterpriseAccountWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务的企业账户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceEnterpriseAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceEnterpriseAccountResponse
        /// </returns>
        public async Task<UpdateFinanceEnterpriseAccountResponse> UpdateFinanceEnterpriseAccountAsync(UpdateFinanceEnterpriseAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFinanceEnterpriseAccountHeaders headers = new UpdateFinanceEnterpriseAccountHeaders();
            return await UpdateFinanceEnterpriseAccountWithOptionsAsync(request, headers, runtime);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新智能财务企业票池内对应发票的下载链接</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateInvoiceUrlRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceUrlResponse
        /// </returns>
        public UpdateInvoiceUrlResponse UpdateInvoiceUrlWithOptions(UpdateInvoiceUrlRequest tmpReq, UpdateInvoiceUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateInvoiceUrlShrinkRequest request = new UpdateInvoiceUrlShrinkRequest();
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
                Action = "UpdateInvoiceUrl",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/urls",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新智能财务企业票池内对应发票的下载链接</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateInvoiceUrlRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceUrlResponse
        /// </returns>
        public async Task<UpdateInvoiceUrlResponse> UpdateInvoiceUrlWithOptionsAsync(UpdateInvoiceUrlRequest tmpReq, UpdateInvoiceUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateInvoiceUrlShrinkRequest request = new UpdateInvoiceUrlShrinkRequest();
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
                Action = "UpdateInvoiceUrl",
                Version = "bizfinance_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/bizfinance/invoices/urls",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新智能财务企业票池内对应发票的下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceUrlResponse
        /// </returns>
        public UpdateInvoiceUrlResponse UpdateInvoiceUrl(UpdateInvoiceUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceUrlHeaders headers = new UpdateInvoiceUrlHeaders();
            return UpdateInvoiceUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用于更新智能财务企业票池内对应发票的下载链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceUrlResponse
        /// </returns>
        public async Task<UpdateInvoiceUrlResponse> UpdateInvoiceUrlAsync(UpdateInvoiceUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceUrlHeaders headers = new UpdateInvoiceUrlHeaders();
            return await UpdateInvoiceUrlWithOptionsAsync(request, headers, runtime);
        }

    }
}
