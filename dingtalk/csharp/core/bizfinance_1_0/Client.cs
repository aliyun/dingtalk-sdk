// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
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
        /// <para>追加角色权限点</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AppendRolePermissionRequest
        /// </param>
        /// <param name="headers">
        /// AppendRolePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppendRolePermissionResponse
        /// </returns>
        public AppendRolePermissionResponse AppendRolePermissionWithOptions(AppendRolePermissionRequest tmpReq, AppendRolePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AppendRolePermissionShrinkRequest request = new AppendRolePermissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RolePermissionItemList))
            {
                request.RolePermissionItemListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RolePermissionItemList, "rolePermissionItemList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePermissionItemListShrink))
            {
                query["rolePermissionItemList"] = request.RolePermissionItemListShrink;
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
                Action = "AppendRolePermission",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/roles/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppendRolePermissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加角色权限点</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AppendRolePermissionRequest
        /// </param>
        /// <param name="headers">
        /// AppendRolePermissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AppendRolePermissionResponse
        /// </returns>
        public async Task<AppendRolePermissionResponse> AppendRolePermissionWithOptionsAsync(AppendRolePermissionRequest tmpReq, AppendRolePermissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AppendRolePermissionShrinkRequest request = new AppendRolePermissionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RolePermissionItemList))
            {
                request.RolePermissionItemListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RolePermissionItemList, "rolePermissionItemList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePermissionItemListShrink))
            {
                query["rolePermissionItemList"] = request.RolePermissionItemListShrink;
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
                Action = "AppendRolePermission",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/roles/permissions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppendRolePermissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加角色权限点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendRolePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AppendRolePermissionResponse
        /// </returns>
        public AppendRolePermissionResponse AppendRolePermission(AppendRolePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendRolePermissionHeaders headers = new AppendRolePermissionHeaders();
            return AppendRolePermissionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>追加角色权限点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AppendRolePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AppendRolePermissionResponse
        /// </returns>
        public async Task<AppendRolePermissionResponse> AppendRolePermissionAsync(AppendRolePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendRolePermissionHeaders headers = new AppendRolePermissionHeaders();
            return await AppendRolePermissionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据批量写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddInvoiceRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddInvoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddInvoiceResponse
        /// </returns>
        public BatchAddInvoiceResponse BatchAddInvoiceWithOptions(BatchAddInvoiceRequest request, BatchAddInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInvoiceVOList))
            {
                body["generalInvoiceVOList"] = request.GeneralInvoiceVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddInvoice",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddInvoiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据批量写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddInvoiceRequest
        /// </param>
        /// <param name="headers">
        /// BatchAddInvoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchAddInvoiceResponse
        /// </returns>
        public async Task<BatchAddInvoiceResponse> BatchAddInvoiceWithOptionsAsync(BatchAddInvoiceRequest request, BatchAddInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInvoiceVOList))
            {
                body["generalInvoiceVOList"] = request.GeneralInvoiceVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddInvoice",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddInvoiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据批量写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddInvoiceResponse
        /// </returns>
        public BatchAddInvoiceResponse BatchAddInvoice(BatchAddInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddInvoiceHeaders headers = new BatchAddInvoiceHeaders();
            return BatchAddInvoiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票数据批量写入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchAddInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchAddInvoiceResponse
        /// </returns>
        public async Task<BatchAddInvoiceResponse> BatchAddInvoiceAsync(BatchAddInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddInvoiceHeaders headers = new BatchAddInvoiceHeaders();
            return await BatchAddInvoiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量增加用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateCustomerRequest
        /// </param>
        /// <param name="headers">
        /// BatchCreateCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateCustomerResponse
        /// </returns>
        public BatchCreateCustomerResponse BatchCreateCustomerWithOptions(BatchCreateCustomerRequest request, BatchCreateCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCustomerRequestList))
            {
                body["createCustomerRequestList"] = request.CreateCustomerRequestList;
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
                Action = "BatchCreateCustomer",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/auxiliaries/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateCustomerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量增加用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateCustomerRequest
        /// </param>
        /// <param name="headers">
        /// BatchCreateCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateCustomerResponse
        /// </returns>
        public async Task<BatchCreateCustomerResponse> BatchCreateCustomerWithOptionsAsync(BatchCreateCustomerRequest request, BatchCreateCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateCustomerRequestList))
            {
                body["createCustomerRequestList"] = request.CreateCustomerRequestList;
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
                Action = "BatchCreateCustomer",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/auxiliaries/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCreateCustomerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量增加用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateCustomerResponse
        /// </returns>
        public BatchCreateCustomerResponse BatchCreateCustomer(BatchCreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateCustomerHeaders headers = new BatchCreateCustomerHeaders();
            return BatchCreateCustomerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量增加用户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchCreateCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchCreateCustomerResponse
        /// </returns>
        public async Task<BatchCreateCustomerResponse> BatchCreateCustomerAsync(BatchCreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateCustomerHeaders headers = new BatchCreateCustomerHeaders();
            return await BatchCreateCustomerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BeginConsumeRequest
        /// </param>
        /// <param name="headers">
        /// BeginConsumeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BeginConsumeResponse
        /// </returns>
        public BeginConsumeResponse BeginConsumeWithOptions(BeginConsumeRequest request, BeginConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                query["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                query["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["quota"] = request.Quota;
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
                Action = "BeginConsume",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/consumedBenefits/prepare",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BeginConsumeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BeginConsumeRequest
        /// </param>
        /// <param name="headers">
        /// BeginConsumeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BeginConsumeResponse
        /// </returns>
        public async Task<BeginConsumeResponse> BeginConsumeWithOptionsAsync(BeginConsumeRequest request, BeginConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                query["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                query["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["quota"] = request.Quota;
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
                Action = "BeginConsume",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/consumedBenefits/prepare",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BeginConsumeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BeginConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// BeginConsumeResponse
        /// </returns>
        public BeginConsumeResponse BeginConsume(BeginConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BeginConsumeHeaders headers = new BeginConsumeHeaders();
            return BeginConsumeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BeginConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// BeginConsumeResponse
        /// </returns>
        public async Task<BeginConsumeResponse> BeginConsumeAsync(BeginConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BeginConsumeHeaders headers = new BeginConsumeHeaders();
            return await BeginConsumeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定钉钉智能财务企业主体的账套信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindCompanyAccountantBookRequest
        /// </param>
        /// <param name="headers">
        /// BindCompanyAccountantBookHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindCompanyAccountantBookResponse
        /// </returns>
        public BindCompanyAccountantBookResponse BindCompanyAccountantBookWithOptions(BindCompanyAccountantBookRequest request, BindCompanyAccountantBookHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountantBookId))
            {
                query["accountantBookId"] = request.AccountantBookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BindCompanyAccountantBook",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/companies/accountantBooks/bind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindCompanyAccountantBookResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定钉钉智能财务企业主体的账套信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindCompanyAccountantBookRequest
        /// </param>
        /// <param name="headers">
        /// BindCompanyAccountantBookHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindCompanyAccountantBookResponse
        /// </returns>
        public async Task<BindCompanyAccountantBookResponse> BindCompanyAccountantBookWithOptionsAsync(BindCompanyAccountantBookRequest request, BindCompanyAccountantBookHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountantBookId))
            {
                query["accountantBookId"] = request.AccountantBookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "BindCompanyAccountantBook",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/companies/accountantBooks/bind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindCompanyAccountantBookResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定钉钉智能财务企业主体的账套信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindCompanyAccountantBookRequest
        /// </param>
        /// 
        /// <returns>
        /// BindCompanyAccountantBookResponse
        /// </returns>
        public BindCompanyAccountantBookResponse BindCompanyAccountantBook(BindCompanyAccountantBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BindCompanyAccountantBookHeaders headers = new BindCompanyAccountantBookHeaders();
            return BindCompanyAccountantBookWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定钉钉智能财务企业主体的账套信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindCompanyAccountantBookRequest
        /// </param>
        /// 
        /// <returns>
        /// BindCompanyAccountantBookResponse
        /// </returns>
        public async Task<BindCompanyAccountantBookResponse> BindCompanyAccountantBookAsync(BindCompanyAccountantBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BindCompanyAccountantBookHeaders headers = new BindCompanyAccountantBookHeaders();
            return await BindCompanyAccountantBookWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelConsumeRequest
        /// </param>
        /// <param name="headers">
        /// CancelConsumeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelConsumeResponse
        /// </returns>
        public CancelConsumeResponse CancelConsumeWithOptions(CancelConsumeRequest request, CancelConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                query["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                query["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["quota"] = request.Quota;
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
                Action = "CancelConsume",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/consumedBenefits/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelConsumeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelConsumeRequest
        /// </param>
        /// <param name="headers">
        /// CancelConsumeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelConsumeResponse
        /// </returns>
        public async Task<CancelConsumeResponse> CancelConsumeWithOptionsAsync(CancelConsumeRequest request, CancelConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                query["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                query["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["quota"] = request.Quota;
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
                Action = "CancelConsume",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/consumedBenefits/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelConsumeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelConsumeResponse
        /// </returns>
        public CancelConsumeResponse CancelConsume(CancelConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelConsumeHeaders headers = new CancelConsumeHeaders();
            return CancelConsumeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelConsumeResponse
        /// </returns>
        public async Task<CancelConsumeResponse> CancelConsumeAsync(CancelConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelConsumeHeaders headers = new CancelConsumeHeaders();
            return await CancelConsumeWithOptionsAsync(request, headers, runtime);
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/checkVoucherStatus/query",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/checkVoucherStatus/query",
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
        /// <para>确认核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommitConsumeRequest
        /// </param>
        /// <param name="headers">
        /// CommitConsumeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommitConsumeResponse
        /// </returns>
        public CommitConsumeResponse CommitConsumeWithOptions(CommitConsumeRequest request, CommitConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                query["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                query["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["quota"] = request.Quota;
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
                Action = "CommitConsume",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/consumedBenefits/commit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitConsumeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommitConsumeRequest
        /// </param>
        /// <param name="headers">
        /// CommitConsumeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommitConsumeResponse
        /// </returns>
        public async Task<CommitConsumeResponse> CommitConsumeWithOptionsAsync(CommitConsumeRequest request, CommitConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                query["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                query["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                query["quota"] = request.Quota;
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
                Action = "CommitConsume",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/consumedBenefits/commit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitConsumeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommitConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// CommitConsumeResponse
        /// </returns>
        public CommitConsumeResponse CommitConsume(CommitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommitConsumeHeaders headers = new CommitConsumeHeaders();
            return CommitConsumeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认核销智能财务的权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CommitConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// CommitConsumeResponse
        /// </returns>
        public async Task<CommitConsumeResponse> CommitConsumeAsync(CommitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommitConsumeHeaders headers = new CommitConsumeHeaders();
            return await CommitConsumeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// <param name="headers">
        /// CreateCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public CreateCustomerResponse CreateCustomerWithOptions(CreateCustomerRequest request, CreateCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrawerEmail))
            {
                body["drawerEmail"] = request.DrawerEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrawerTelephone))
            {
                body["drawerTelephone"] = request.DrawerTelephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserAccount))
            {
                body["purchaserAccount"] = request.PurchaserAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserAddress))
            {
                body["purchaserAddress"] = request.PurchaserAddress;
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomer",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/auxiliaries/customers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// <param name="headers">
        /// CreateCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public async Task<CreateCustomerResponse> CreateCustomerWithOptionsAsync(CreateCustomerRequest request, CreateCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrawerEmail))
            {
                body["drawerEmail"] = request.DrawerEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrawerTelephone))
            {
                body["drawerTelephone"] = request.DrawerTelephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserAccount))
            {
                body["purchaserAccount"] = request.PurchaserAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaserAddress))
            {
                body["purchaserAddress"] = request.PurchaserAddress;
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
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomer",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/auxiliaries/customers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public CreateCustomerResponse CreateCustomer(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomerHeaders headers = new CreateCustomerHeaders();
            return CreateCustomerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerResponse
        /// </returns>
        public async Task<CreateCustomerResponse> CreateCustomerAsync(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomerHeaders headers = new CreateCustomerHeaders();
            return await CreateCustomerWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReceiptRequest
        /// </param>
        /// <param name="headers">
        /// CreateReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateReceiptResponse
        /// </returns>
        public CreateReceiptResponse CreateReceiptWithOptions(CreateReceiptRequest request, CreateReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receipts))
            {
                body["receipts"] = request.Receipts;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReceipt",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReceiptResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReceiptRequest
        /// </param>
        /// <param name="headers">
        /// CreateReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateReceiptResponse
        /// </returns>
        public async Task<CreateReceiptResponse> CreateReceiptWithOptionsAsync(CreateReceiptRequest request, CreateReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receipts))
            {
                body["receipts"] = request.Receipts;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReceipt",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReceiptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateReceiptResponse
        /// </returns>
        public CreateReceiptResponse CreateReceipt(CreateReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateReceiptHeaders headers = new CreateReceiptHeaders();
            return CreateReceiptWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateReceiptResponse
        /// </returns>
        public async Task<CreateReceiptResponse> CreateReceiptAsync(CreateReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateReceiptHeaders headers = new CreateReceiptHeaders();
            return await CreateReceiptWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteReceiptRequest
        /// </param>
        /// <param name="headers">
        /// DeleteReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteReceiptResponse
        /// </returns>
        public DeleteReceiptResponse DeleteReceiptWithOptions(DeleteReceiptRequest request, DeleteReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receipts))
            {
                body["receipts"] = request.Receipts;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteReceipt",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteReceiptResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteReceiptRequest
        /// </param>
        /// <param name="headers">
        /// DeleteReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteReceiptResponse
        /// </returns>
        public async Task<DeleteReceiptResponse> DeleteReceiptWithOptionsAsync(DeleteReceiptRequest request, DeleteReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receipts))
            {
                body["receipts"] = request.Receipts;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteReceipt",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteReceiptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteReceiptResponse
        /// </returns>
        public DeleteReceiptResponse DeleteReceipt(DeleteReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteReceiptHeaders headers = new DeleteReceiptHeaders();
            return DeleteReceiptWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteReceiptResponse
        /// </returns>
        public async Task<DeleteReceiptResponse> DeleteReceiptAsync(DeleteReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteReceiptHeaders headers = new DeleteReceiptHeaders();
            return await DeleteReceiptWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可以查看账本的用户列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetBookkeepingUserListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBookkeepingUserListResponse
        /// </returns>
        public GetBookkeepingUserListResponse GetBookkeepingUserListWithOptions(GetBookkeepingUserListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetBookkeepingUserList",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/bookkeeping/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBookkeepingUserListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可以查看账本的用户列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetBookkeepingUserListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBookkeepingUserListResponse
        /// </returns>
        public async Task<GetBookkeepingUserListResponse> GetBookkeepingUserListWithOptionsAsync(GetBookkeepingUserListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetBookkeepingUserList",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/bookkeeping/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBookkeepingUserListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可以查看账本的用户列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetBookkeepingUserListResponse
        /// </returns>
        public GetBookkeepingUserListResponse GetBookkeepingUserList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBookkeepingUserListHeaders headers = new GetBookkeepingUserListHeaders();
            return GetBookkeepingUserListWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可以查看账本的用户列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetBookkeepingUserListResponse
        /// </returns>
        public async Task<GetBookkeepingUserListResponse> GetBookkeepingUserListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBookkeepingUserListHeaders headers = new GetBookkeepingUserListHeaders();
            return await GetBookkeepingUserListWithOptionsAsync(headers, runtime);
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/categories/get",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/categories/get",
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
        /// <para>获取智能财务应用内维护的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerRequest
        /// </param>
        /// <param name="headers">
        /// GetCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerResponse
        /// </returns>
        public GetCustomerResponse GetCustomerWithOptions(GetCustomerRequest request, GetCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCustomer",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/customers/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务应用内维护的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerRequest
        /// </param>
        /// <param name="headers">
        /// GetCustomerHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerResponse
        /// </returns>
        public async Task<GetCustomerResponse> GetCustomerWithOptionsAsync(GetCustomerRequest request, GetCustomerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetCustomer",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/customers/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务应用内维护的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerResponse
        /// </returns>
        public GetCustomerResponse GetCustomer(GetCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCustomerHeaders headers = new GetCustomerHeaders();
            return GetCustomerWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务应用内维护的客户信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomerResponse
        /// </returns>
        public async Task<GetCustomerResponse> GetCustomerAsync(GetCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCustomerHeaders headers = new GetCustomerHeaders();
            return await GetCustomerWithOptionsAsync(request, headers, runtime);
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/financeAccounts/get",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/financeAccounts/get",
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
        /// <para>获取智能财务套件模版信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFormTemplateInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFormTemplateInfoResponse
        /// </returns>
        public GetFormTemplateInfoResponse GetFormTemplateInfoWithOptions(GetFormTemplateInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFormTemplateInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/formTemplates/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormTemplateInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务套件模版信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFormTemplateInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFormTemplateInfoResponse
        /// </returns>
        public async Task<GetFormTemplateInfoResponse> GetFormTemplateInfoWithOptionsAsync(GetFormTemplateInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetFormTemplateInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/formTemplates/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFormTemplateInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务套件模版信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFormTemplateInfoResponse
        /// </returns>
        public GetFormTemplateInfoResponse GetFormTemplateInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormTemplateInfoHeaders headers = new GetFormTemplateInfoHeaders();
            return GetFormTemplateInfoWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取智能财务套件模版信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFormTemplateInfoResponse
        /// </returns>
        public async Task<GetFormTemplateInfoResponse> GetFormTemplateInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormTemplateInfoHeaders headers = new GetFormTemplateInfoHeaders();
            return await GetFormTemplateInfoWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票分页查询接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetInvoiceByPageRequest
        /// </param>
        /// <param name="headers">
        /// GetInvoiceByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInvoiceByPageResponse
        /// </returns>
        public GetInvoiceByPageResponse GetInvoiceByPageWithOptions(GetInvoiceByPageRequest tmpReq, GetInvoiceByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetInvoiceByPageShrinkRequest request = new GetInvoiceByPageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "request", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                query["request"] = request.RequestShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetInvoiceByPage",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInvoiceByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票分页查询接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetInvoiceByPageRequest
        /// </param>
        /// <param name="headers">
        /// GetInvoiceByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInvoiceByPageResponse
        /// </returns>
        public async Task<GetInvoiceByPageResponse> GetInvoiceByPageWithOptionsAsync(GetInvoiceByPageRequest tmpReq, GetInvoiceByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetInvoiceByPageShrinkRequest request = new GetInvoiceByPageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Request))
            {
                request.RequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Request, "request", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestShrink))
            {
                query["request"] = request.RequestShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "GetInvoiceByPage",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInvoiceByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票分页查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInvoiceByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInvoiceByPageResponse
        /// </returns>
        public GetInvoiceByPageResponse GetInvoiceByPage(GetInvoiceByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInvoiceByPageHeaders headers = new GetInvoiceByPageHeaders();
            return GetInvoiceByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票分页查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInvoiceByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInvoiceByPageResponse
        /// </returns>
        public async Task<GetInvoiceByPageResponse> GetInvoiceByPageAsync(GetInvoiceByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInvoiceByPageHeaders headers = new GetInvoiceByPageHeaders();
            return await GetInvoiceByPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用来给isv提供是否使用智能账本的判断接口</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetIsNewVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIsNewVersionResponse
        /// </returns>
        public GetIsNewVersionResponse GetIsNewVersionWithOptions(GetIsNewVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetIsNewVersion",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/accounts/uses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIsNewVersionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用来给isv提供是否使用智能账本的判断接口</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetIsNewVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIsNewVersionResponse
        /// </returns>
        public async Task<GetIsNewVersionResponse> GetIsNewVersionWithOptionsAsync(GetIsNewVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetIsNewVersion",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/accounts/uses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIsNewVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用来给isv提供是否使用智能账本的判断接口</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIsNewVersionResponse
        /// </returns>
        public GetIsNewVersionResponse GetIsNewVersion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIsNewVersionHeaders headers = new GetIsNewVersionHeaders();
            return GetIsNewVersionWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用来给isv提供是否使用智能账本的判断接口</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIsNewVersionResponse
        /// </returns>
        public async Task<GetIsNewVersionResponse> GetIsNewVersionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIsNewVersionHeaders headers = new GetIsNewVersionHeaders();
            return await GetIsNewVersionWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据comanyCode查询钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetMultiCompanyInfoByCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultiCompanyInfoByCodeResponse
        /// </returns>
        public GetMultiCompanyInfoByCodeResponse GetMultiCompanyInfoByCodeWithOptions(string companyCode, GetMultiCompanyInfoByCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMultiCompanyInfoByCode",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/multiCompanies/" + companyCode,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultiCompanyInfoByCodeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据comanyCode查询钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetMultiCompanyInfoByCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultiCompanyInfoByCodeResponse
        /// </returns>
        public async Task<GetMultiCompanyInfoByCodeResponse> GetMultiCompanyInfoByCodeWithOptionsAsync(string companyCode, GetMultiCompanyInfoByCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMultiCompanyInfoByCode",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/multiCompanies/" + companyCode,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMultiCompanyInfoByCodeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据comanyCode查询钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMultiCompanyInfoByCodeResponse
        /// </returns>
        public GetMultiCompanyInfoByCodeResponse GetMultiCompanyInfoByCode(string companyCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMultiCompanyInfoByCodeHeaders headers = new GetMultiCompanyInfoByCodeHeaders();
            return GetMultiCompanyInfoByCodeWithOptions(companyCode, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据comanyCode查询钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMultiCompanyInfoByCodeResponse
        /// </returns>
        public async Task<GetMultiCompanyInfoByCodeResponse> GetMultiCompanyInfoByCodeAsync(string companyCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMultiCompanyInfoByCodeHeaders headers = new GetMultiCompanyInfoByCodeHeaders();
            return await GetMultiCompanyInfoByCodeWithOptionsAsync(companyCode, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductRequest
        /// </param>
        /// <param name="headers">
        /// GetProductHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductResponse
        /// </returns>
        public GetProductResponse GetProductWithOptions(GetProductRequest request, GetProductHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetProduct",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/products",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductRequest
        /// </param>
        /// <param name="headers">
        /// GetProductHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProductResponse
        /// </returns>
        public async Task<GetProductResponse> GetProductWithOptionsAsync(GetProductRequest request, GetProductHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetProduct",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/products",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductResponse
        /// </returns>
        public GetProductResponse GetProduct(GetProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProductHeaders headers = new GetProductHeaders();
            return GetProductWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取商品信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProductRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProductResponse
        /// </returns>
        public async Task<GetProductResponse> GetProductAsync(GetProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProductHeaders headers = new GetProductHeaders();
            return await GetProductWithOptionsAsync(request, headers, runtime);
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/projects/get",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/projects/get",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/suppliers/details",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/suppliers/details",
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
        /// <para>获取用友开放平台接口鉴权信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYongYouOpenApiTokenRequest
        /// </param>
        /// <param name="headers">
        /// GetYongYouOpenApiTokenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYongYouOpenApiTokenResponse
        /// </returns>
        public GetYongYouOpenApiTokenResponse GetYongYouOpenApiTokenWithOptions(GetYongYouOpenApiTokenRequest request, GetYongYouOpenApiTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetYongYouOpenApiToken",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/yongyou/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYongYouOpenApiTokenResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用友开放平台接口鉴权信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYongYouOpenApiTokenRequest
        /// </param>
        /// <param name="headers">
        /// GetYongYouOpenApiTokenHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYongYouOpenApiTokenResponse
        /// </returns>
        public async Task<GetYongYouOpenApiTokenResponse> GetYongYouOpenApiTokenWithOptionsAsync(GetYongYouOpenApiTokenRequest request, GetYongYouOpenApiTokenHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetYongYouOpenApiToken",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/yongyou/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYongYouOpenApiTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用友开放平台接口鉴权信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYongYouOpenApiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYongYouOpenApiTokenResponse
        /// </returns>
        public GetYongYouOpenApiTokenResponse GetYongYouOpenApiToken(GetYongYouOpenApiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetYongYouOpenApiTokenHeaders headers = new GetYongYouOpenApiTokenHeaders();
            return GetYongYouOpenApiTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用友开放平台接口鉴权信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetYongYouOpenApiTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetYongYouOpenApiTokenResponse
        /// </returns>
        public async Task<GetYongYouOpenApiTokenResponse> GetYongYouOpenApiTokenAsync(GetYongYouOpenApiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetYongYouOpenApiTokenHeaders headers = new GetYongYouOpenApiTokenHeaders();
            return await GetYongYouOpenApiTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询钉钉组织绑定的畅捷通组织</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetYongYouOrgRelationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYongYouOrgRelationResponse
        /// </returns>
        public GetYongYouOrgRelationResponse GetYongYouOrgRelationWithOptions(GetYongYouOrgRelationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetYongYouOrgRelation",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/yongyou/relations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYongYouOrgRelationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询钉钉组织绑定的畅捷通组织</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetYongYouOrgRelationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetYongYouOrgRelationResponse
        /// </returns>
        public async Task<GetYongYouOrgRelationResponse> GetYongYouOrgRelationWithOptionsAsync(GetYongYouOrgRelationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetYongYouOrgRelation",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/yongyou/relations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetYongYouOrgRelationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询钉钉组织绑定的畅捷通组织</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetYongYouOrgRelationResponse
        /// </returns>
        public GetYongYouOrgRelationResponse GetYongYouOrgRelation()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetYongYouOrgRelationHeaders headers = new GetYongYouOrgRelationHeaders();
            return GetYongYouOrgRelationWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询钉钉组织绑定的畅捷通组织</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetYongYouOrgRelationResponse
        /// </returns>
        public async Task<GetYongYouOrgRelationResponse> GetYongYouOrgRelationAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetYongYouOrgRelationHeaders headers = new GetYongYouOrgRelationHeaders();
            return await GetYongYouOrgRelationWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>权益核销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProfessionBenefitConsumeRequest
        /// </param>
        /// <param name="headers">
        /// ProfessionBenefitConsumeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProfessionBenefitConsumeResponse
        /// </returns>
        public ProfessionBenefitConsumeResponse ProfessionBenefitConsumeWithOptions(ProfessionBenefitConsumeRequest request, ProfessionBenefitConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                body["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProfessionBenefitConsume",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/professions/benefits/consume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProfessionBenefitConsumeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>权益核销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProfessionBenefitConsumeRequest
        /// </param>
        /// <param name="headers">
        /// ProfessionBenefitConsumeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProfessionBenefitConsumeResponse
        /// </returns>
        public async Task<ProfessionBenefitConsumeResponse> ProfessionBenefitConsumeWithOptionsAsync(ProfessionBenefitConsumeRequest request, ProfessionBenefitConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                body["benefitCode"] = request.BenefitCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProfessionBenefitConsume",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/professions/benefits/consume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProfessionBenefitConsumeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>权益核销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProfessionBenefitConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// ProfessionBenefitConsumeResponse
        /// </returns>
        public ProfessionBenefitConsumeResponse ProfessionBenefitConsume(ProfessionBenefitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProfessionBenefitConsumeHeaders headers = new ProfessionBenefitConsumeHeaders();
            return ProfessionBenefitConsumeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>权益核销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProfessionBenefitConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// ProfessionBenefitConsumeResponse
        /// </returns>
        public async Task<ProfessionBenefitConsumeResponse> ProfessionBenefitConsumeAsync(ProfessionBenefitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProfessionBenefitConsumeHeaders headers = new ProfessionBenefitConsumeHeaders();
            return await ProfessionBenefitConsumeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发单据同步给有成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushHistoricalReceiptsRequest
        /// </param>
        /// <param name="headers">
        /// PushHistoricalReceiptsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushHistoricalReceiptsResponse
        /// </returns>
        public PushHistoricalReceiptsResponse PushHistoricalReceiptsWithOptions(PushHistoricalReceiptsRequest request, PushHistoricalReceiptsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForcedIgnoreDup))
            {
                body["forcedIgnoreDup"] = request.ForcedIgnoreDup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCodeList))
            {
                body["formCodeList"] = request.FormCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushHistoricalReceipts",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/budgets/historicalReceipts/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushHistoricalReceiptsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发单据同步给有成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushHistoricalReceiptsRequest
        /// </param>
        /// <param name="headers">
        /// PushHistoricalReceiptsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushHistoricalReceiptsResponse
        /// </returns>
        public async Task<PushHistoricalReceiptsResponse> PushHistoricalReceiptsWithOptionsAsync(PushHistoricalReceiptsRequest request, PushHistoricalReceiptsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForcedIgnoreDup))
            {
                body["forcedIgnoreDup"] = request.ForcedIgnoreDup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormCodeList))
            {
                body["formCodeList"] = request.FormCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushHistoricalReceipts",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/budgets/historicalReceipts/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushHistoricalReceiptsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发单据同步给有成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushHistoricalReceiptsRequest
        /// </param>
        /// 
        /// <returns>
        /// PushHistoricalReceiptsResponse
        /// </returns>
        public PushHistoricalReceiptsResponse PushHistoricalReceipts(PushHistoricalReceiptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushHistoricalReceiptsHeaders headers = new PushHistoricalReceiptsHeaders();
            return PushHistoricalReceiptsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>触发单据同步给有成</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushHistoricalReceiptsRequest
        /// </param>
        /// 
        /// <returns>
        /// PushHistoricalReceiptsResponse
        /// </returns>
        public async Task<PushHistoricalReceiptsResponse> PushHistoricalReceiptsAsync(PushHistoricalReceiptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushHistoricalReceiptsHeaders headers = new PushHistoricalReceiptsHeaders();
            return await PushHistoricalReceiptsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务计量型权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBenefitRequest
        /// </param>
        /// <param name="headers">
        /// QueryBenefitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBenefitResponse
        /// </returns>
        public QueryBenefitResponse QueryBenefitWithOptions(QueryBenefitRequest request, QueryBenefitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                query["benefitCode"] = request.BenefitCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryBenefit",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/benefits",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBenefitResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务计量型权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBenefitRequest
        /// </param>
        /// <param name="headers">
        /// QueryBenefitHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBenefitResponse
        /// </returns>
        public async Task<QueryBenefitResponse> QueryBenefitWithOptionsAsync(QueryBenefitRequest request, QueryBenefitHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitCode))
            {
                query["benefitCode"] = request.BenefitCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryBenefit",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/benefits",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBenefitResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务计量型权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBenefitRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBenefitResponse
        /// </returns>
        public QueryBenefitResponse QueryBenefit(QueryBenefitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBenefitHeaders headers = new QueryBenefitHeaders();
            return QueryBenefitWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务计量型权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBenefitRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBenefitResponse
        /// </returns>
        public async Task<QueryBenefitResponse> QueryBenefitAsync(QueryBenefitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBenefitHeaders headers = new QueryBenefitHeaders();
            return await QueryBenefitWithOptionsAsync(request, headers, runtime);
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/categories/list",
                Method = "GET",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/categories/list",
                Method = "GET",
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
        /// <para>查询某个主体的开票申请单的提单数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCompanyInvoiceRelationCountRequest
        /// </param>
        /// <param name="headers">
        /// QueryCompanyInvoiceRelationCountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCompanyInvoiceRelationCountResponse
        /// </returns>
        public QueryCompanyInvoiceRelationCountResponse QueryCompanyInvoiceRelationCountWithOptions(QueryCompanyInvoiceRelationCountRequest request, QueryCompanyInvoiceRelationCountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCompanyInvoiceRelationCount",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/companyRelationReceipts/counts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCompanyInvoiceRelationCountResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某个主体的开票申请单的提单数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCompanyInvoiceRelationCountRequest
        /// </param>
        /// <param name="headers">
        /// QueryCompanyInvoiceRelationCountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCompanyInvoiceRelationCountResponse
        /// </returns>
        public async Task<QueryCompanyInvoiceRelationCountResponse> QueryCompanyInvoiceRelationCountWithOptionsAsync(QueryCompanyInvoiceRelationCountRequest request, QueryCompanyInvoiceRelationCountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryCompanyInvoiceRelationCount",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/companyRelationReceipts/counts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCompanyInvoiceRelationCountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某个主体的开票申请单的提单数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCompanyInvoiceRelationCountRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCompanyInvoiceRelationCountResponse
        /// </returns>
        public QueryCompanyInvoiceRelationCountResponse QueryCompanyInvoiceRelationCount(QueryCompanyInvoiceRelationCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCompanyInvoiceRelationCountHeaders headers = new QueryCompanyInvoiceRelationCountHeaders();
            return QueryCompanyInvoiceRelationCountWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询某个主体的开票申请单的提单数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCompanyInvoiceRelationCountRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCompanyInvoiceRelationCountResponse
        /// </returns>
        public async Task<QueryCompanyInvoiceRelationCountResponse> QueryCompanyInvoiceRelationCountAsync(QueryCompanyInvoiceRelationCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCompanyInvoiceRelationCountHeaders headers = new QueryCompanyInvoiceRelationCountHeaders();
            return await QueryCompanyInvoiceRelationCountWithOptionsAsync(request, headers, runtime);
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/customers",
                Method = "GET",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/customers",
                Method = "GET",
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
        /// <para>提供给合作伙伴，查询智能财务的客户配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryCustomerInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerInfoResponse
        /// </returns>
        public QueryCustomerInfoResponse QueryCustomerInfoWithOptions(QueryCustomerInfoRequest request, QueryCustomerInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
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
                Action = "QueryCustomerInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/auxiliaries/customers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提供给合作伙伴，查询智能财务的客户配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryCustomerInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerInfoResponse
        /// </returns>
        public async Task<QueryCustomerInfoResponse> QueryCustomerInfoWithOptionsAsync(QueryCustomerInfoRequest request, QueryCustomerInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
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
                Action = "QueryCustomerInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/auxiliaries/customers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提供给合作伙伴，查询智能财务的客户配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerInfoResponse
        /// </returns>
        public QueryCustomerInfoResponse QueryCustomerInfo(QueryCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerInfoHeaders headers = new QueryCustomerInfoHeaders();
            return QueryCustomerInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提供给合作伙伴，查询智能财务的客户配置信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCustomerInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerInfoResponse
        /// </returns>
        public async Task<QueryCustomerInfoResponse> QueryCustomerInfoAsync(QueryCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerInfoHeaders headers = new QueryCustomerInfoHeaders();
            return await QueryCustomerInfoWithOptionsAsync(request, headers, runtime);
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/financeAccounts/list",
                Method = "GET",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/financeAccounts/list",
                Method = "GET",
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
        /// <para>查询智能财务配置的企业信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryFinanceCompanyInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFinanceCompanyInfoResponse
        /// </returns>
        public QueryFinanceCompanyInfoResponse QueryFinanceCompanyInfoWithOptions(QueryFinanceCompanyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryFinanceCompanyInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/companies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFinanceCompanyInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务配置的企业信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryFinanceCompanyInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFinanceCompanyInfoResponse
        /// </returns>
        public async Task<QueryFinanceCompanyInfoResponse> QueryFinanceCompanyInfoWithOptionsAsync(QueryFinanceCompanyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryFinanceCompanyInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/companies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFinanceCompanyInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务配置的企业信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryFinanceCompanyInfoResponse
        /// </returns>
        public QueryFinanceCompanyInfoResponse QueryFinanceCompanyInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFinanceCompanyInfoHeaders headers = new QueryFinanceCompanyInfoHeaders();
            return QueryFinanceCompanyInfoWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务配置的企业信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryFinanceCompanyInfoResponse
        /// </returns>
        public async Task<QueryFinanceCompanyInfoResponse> QueryFinanceCompanyInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFinanceCompanyInfoHeaders headers = new QueryFinanceCompanyInfoHeaders();
            return await QueryFinanceCompanyInfoWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开票申请单的提单数量</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryInvoiceRelationCountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInvoiceRelationCountResponse
        /// </returns>
        public QueryInvoiceRelationCountResponse QueryInvoiceRelationCountWithOptions(QueryInvoiceRelationCountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryInvoiceRelationCount",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/relationReceipts/counts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInvoiceRelationCountResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开票申请单的提单数量</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryInvoiceRelationCountHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInvoiceRelationCountResponse
        /// </returns>
        public async Task<QueryInvoiceRelationCountResponse> QueryInvoiceRelationCountWithOptionsAsync(QueryInvoiceRelationCountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryInvoiceRelationCount",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/relationReceipts/counts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInvoiceRelationCountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开票申请单的提单数量</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryInvoiceRelationCountResponse
        /// </returns>
        public QueryInvoiceRelationCountResponse QueryInvoiceRelationCount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInvoiceRelationCountHeaders headers = new QueryInvoiceRelationCountHeaders();
            return QueryInvoiceRelationCountWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开票申请单的提单数量</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryInvoiceRelationCountResponse
        /// </returns>
        public async Task<QueryInvoiceRelationCountResponse> QueryInvoiceRelationCountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInvoiceRelationCountHeaders headers = new QueryInvoiceRelationCountHeaders();
            return await QueryInvoiceRelationCountWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryMultiCompanyInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMultiCompanyInfoResponse
        /// </returns>
        public QueryMultiCompanyInfoResponse QueryMultiCompanyInfoWithOptions(QueryMultiCompanyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMultiCompanyInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/multiCompanies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMultiCompanyInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryMultiCompanyInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMultiCompanyInfoResponse
        /// </returns>
        public async Task<QueryMultiCompanyInfoResponse> QueryMultiCompanyInfoWithOptionsAsync(QueryMultiCompanyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMultiCompanyInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/multiCompanies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMultiCompanyInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryMultiCompanyInfoResponse
        /// </returns>
        public QueryMultiCompanyInfoResponse QueryMultiCompanyInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMultiCompanyInfoHeaders headers = new QueryMultiCompanyInfoHeaders();
            return QueryMultiCompanyInfoWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryMultiCompanyInfoResponse
        /// </returns>
        public async Task<QueryMultiCompanyInfoResponse> QueryMultiCompanyInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMultiCompanyInfoHeaders headers = new QueryMultiCompanyInfoHeaders();
            return await QueryMultiCompanyInfoWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提供给小望，查询当前用户所具有的的小望权限点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionByUserIdRequest
        /// </param>
        /// <param name="headers">
        /// QueryPermissionByUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionByUserIdResponse
        /// </returns>
        public QueryPermissionByUserIdResponse QueryPermissionByUserIdWithOptions(QueryPermissionByUserIdRequest request, QueryPermissionByUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPermissionByUserId",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPermissionByUserIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提供给小望，查询当前用户所具有的的小望权限点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionByUserIdRequest
        /// </param>
        /// <param name="headers">
        /// QueryPermissionByUserIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionByUserIdResponse
        /// </returns>
        public async Task<QueryPermissionByUserIdResponse> QueryPermissionByUserIdWithOptionsAsync(QueryPermissionByUserIdRequest request, QueryPermissionByUserIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryPermissionByUserId",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPermissionByUserIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提供给小望，查询当前用户所具有的的小望权限点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionByUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionByUserIdResponse
        /// </returns>
        public QueryPermissionByUserIdResponse QueryPermissionByUserId(QueryPermissionByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPermissionByUserIdHeaders headers = new QueryPermissionByUserIdHeaders();
            return QueryPermissionByUserIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提供给小望，查询当前用户所具有的的小望权限点信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionByUserIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionByUserIdResponse
        /// </returns>
        public async Task<QueryPermissionByUserIdResponse> QueryPermissionByUserIdAsync(QueryPermissionByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPermissionByUserIdHeaders headers = new QueryPermissionByUserIdHeaders();
            return await QueryPermissionByUserIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务角色下的成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionRoleMemberRequest
        /// </param>
        /// <param name="headers">
        /// QueryPermissionRoleMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionRoleMemberResponse
        /// </returns>
        public QueryPermissionRoleMemberResponse QueryPermissionRoleMemberWithOptions(QueryPermissionRoleMemberRequest request, QueryPermissionRoleMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodeList))
            {
                body["roleCodeList"] = request.RoleCodeList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPermissionRoleMember",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/roles/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPermissionRoleMemberResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务角色下的成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionRoleMemberRequest
        /// </param>
        /// <param name="headers">
        /// QueryPermissionRoleMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionRoleMemberResponse
        /// </returns>
        public async Task<QueryPermissionRoleMemberResponse> QueryPermissionRoleMemberWithOptionsAsync(QueryPermissionRoleMemberRequest request, QueryPermissionRoleMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCodeList))
            {
                body["roleCodeList"] = request.RoleCodeList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPermissionRoleMember",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/roles/members/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPermissionRoleMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务角色下的成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionRoleMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionRoleMemberResponse
        /// </returns>
        public QueryPermissionRoleMemberResponse QueryPermissionRoleMember(QueryPermissionRoleMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPermissionRoleMemberHeaders headers = new QueryPermissionRoleMemberHeaders();
            return QueryPermissionRoleMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询智能财务角色下的成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPermissionRoleMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPermissionRoleMemberResponse
        /// </returns>
        public async Task<QueryPermissionRoleMemberResponse> QueryPermissionRoleMemberAsync(QueryPermissionRoleMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPermissionRoleMemberHeaders headers = new QueryPermissionRoleMemberHeaders();
            return await QueryPermissionRoleMemberWithOptionsAsync(request, headers, runtime);
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/products/query",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/products/query",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/projects/list",
                Method = "GET",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/projects/list",
                Method = "GET",
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
        /// <para>查询开票申请单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptDetailForInvoiceRequest
        /// </param>
        /// <param name="headers">
        /// QueryReceiptDetailForInvoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptDetailForInvoiceResponse
        /// </returns>
        public QueryReceiptDetailForInvoiceResponse QueryReceiptDetailForInvoiceWithOptions(QueryReceiptDetailForInvoiceRequest request, QueryReceiptDetailForInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryReceiptDetailForInvoice",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/receipts/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReceiptDetailForInvoiceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开票申请单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptDetailForInvoiceRequest
        /// </param>
        /// <param name="headers">
        /// QueryReceiptDetailForInvoiceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptDetailForInvoiceResponse
        /// </returns>
        public async Task<QueryReceiptDetailForInvoiceResponse> QueryReceiptDetailForInvoiceWithOptionsAsync(QueryReceiptDetailForInvoiceRequest request, QueryReceiptDetailForInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryReceiptDetailForInvoice",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/receipts/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReceiptDetailForInvoiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开票申请单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptDetailForInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptDetailForInvoiceResponse
        /// </returns>
        public QueryReceiptDetailForInvoiceResponse QueryReceiptDetailForInvoice(QueryReceiptDetailForInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptDetailForInvoiceHeaders headers = new QueryReceiptDetailForInvoiceHeaders();
            return QueryReceiptDetailForInvoiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询开票申请单详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptDetailForInvoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptDetailForInvoiceResponse
        /// </returns>
        public async Task<QueryReceiptDetailForInvoiceResponse> QueryReceiptDetailForInvoiceAsync(QueryReceiptDetailForInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptDetailForInvoiceHeaders headers = new QueryReceiptDetailForInvoiceHeaders();
            return await QueryReceiptDetailForInvoiceWithOptionsAsync(request, headers, runtime);
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/receipts/query",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/receipts/query",
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
        /// <para>批量查询智能财务的单据主数据基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptsBaseInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryReceiptsBaseInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptsBaseInfoResponse
        /// </returns>
        public QueryReceiptsBaseInfoResponse QueryReceiptsBaseInfoWithOptions(QueryReceiptsBaseInfoRequest request, QueryReceiptsBaseInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountantBookId))
            {
                query["accountantBookId"] = request.AccountantBookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmountEnd))
            {
                query["amountEnd"] = request.AmountEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmountStart))
            {
                query["amountStart"] = request.AmountStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeFilterField))
            {
                query["timeFilterField"] = request.TimeFilterField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoucherStatus))
            {
                query["voucherStatus"] = request.VoucherStatus;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryReceiptsBaseInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts/dataInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReceiptsBaseInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能财务的单据主数据基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptsBaseInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryReceiptsBaseInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptsBaseInfoResponse
        /// </returns>
        public async Task<QueryReceiptsBaseInfoResponse> QueryReceiptsBaseInfoWithOptionsAsync(QueryReceiptsBaseInfoRequest request, QueryReceiptsBaseInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountantBookId))
            {
                query["accountantBookId"] = request.AccountantBookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmountEnd))
            {
                query["amountEnd"] = request.AmountEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AmountStart))
            {
                query["amountStart"] = request.AmountStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeFilterField))
            {
                query["timeFilterField"] = request.TimeFilterField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoucherStatus))
            {
                query["voucherStatus"] = request.VoucherStatus;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryReceiptsBaseInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts/dataInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReceiptsBaseInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能财务的单据主数据基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptsBaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptsBaseInfoResponse
        /// </returns>
        public QueryReceiptsBaseInfoResponse QueryReceiptsBaseInfo(QueryReceiptsBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptsBaseInfoHeaders headers = new QueryReceiptsBaseInfoHeaders();
            return QueryReceiptsBaseInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询智能财务的单据主数据基本信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptsBaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptsBaseInfoResponse
        /// </returns>
        public async Task<QueryReceiptsBaseInfoResponse> QueryReceiptsBaseInfoAsync(QueryReceiptsBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptsBaseInfoHeaders headers = new QueryReceiptsBaseInfoHeaders();
            return await QueryReceiptsBaseInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取智能财务单据详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptsByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryReceiptsByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptsByPageResponse
        /// </returns>
        public QueryReceiptsByPageResponse QueryReceiptsByPageWithOptions(QueryReceiptsByPageRequest request, QueryReceiptsByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeFilterField))
            {
                query["timeFilterField"] = request.TimeFilterField;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryReceiptsByPage",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReceiptsByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取智能财务单据详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptsByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryReceiptsByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptsByPageResponse
        /// </returns>
        public async Task<QueryReceiptsByPageResponse> QueryReceiptsByPageWithOptionsAsync(QueryReceiptsByPageRequest request, QueryReceiptsByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["modelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeFilterField))
            {
                query["timeFilterField"] = request.TimeFilterField;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryReceiptsByPage",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryReceiptsByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取智能财务单据详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptsByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptsByPageResponse
        /// </returns>
        public QueryReceiptsByPageResponse QueryReceiptsByPage(QueryReceiptsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptsByPageHeaders headers = new QueryReceiptsByPageHeaders();
            return QueryReceiptsByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页获取智能财务单据详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryReceiptsByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryReceiptsByPageResponse
        /// </returns>
        public async Task<QueryReceiptsByPageResponse> QueryReceiptsByPageAsync(QueryReceiptsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptsByPageHeaders headers = new QueryReceiptsByPageHeaders();
            return await QueryReceiptsByPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询智能财务角色下的成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoleMemberByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryRoleMemberByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRoleMemberByPageResponse
        /// </returns>
        public QueryRoleMemberByPageResponse QueryRoleMemberByPageWithOptions(QueryRoleMemberByPageRequest request, QueryRoleMemberByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCode))
            {
                query["roleCode"] = request.RoleCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryRoleMemberByPage",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/roles/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRoleMemberByPageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询智能财务角色下的成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoleMemberByPageRequest
        /// </param>
        /// <param name="headers">
        /// QueryRoleMemberByPageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRoleMemberByPageResponse
        /// </returns>
        public async Task<QueryRoleMemberByPageResponse> QueryRoleMemberByPageWithOptionsAsync(QueryRoleMemberByPageRequest request, QueryRoleMemberByPageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleCode))
            {
                query["roleCode"] = request.RoleCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "QueryRoleMemberByPage",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/roles/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRoleMemberByPageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询智能财务角色下的成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoleMemberByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRoleMemberByPageResponse
        /// </returns>
        public QueryRoleMemberByPageResponse QueryRoleMemberByPage(QueryRoleMemberByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoleMemberByPageHeaders headers = new QueryRoleMemberByPageHeaders();
            return QueryRoleMemberByPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询智能财务角色下的成员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRoleMemberByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRoleMemberByPageResponse
        /// </returns>
        public async Task<QueryRoleMemberByPageResponse> QueryRoleMemberByPageAsync(QueryRoleMemberByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoleMemberByPageHeaders headers = new QueryRoleMemberByPageHeaders();
            return await QueryRoleMemberByPageWithOptionsAsync(request, headers, runtime);
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/suppliers",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/suppliers",
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
        /// <para>查询用户角色</para>
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/users/roles",
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
        /// <para>查询用户角色</para>
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/users/roles",
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
        /// <para>查询用户角色</para>
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
        /// <para>查询用户角色</para>
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
        /// <para>解绑开票申请单关联的发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindApplyReceiptAndInvoiceRelatedRequest
        /// </param>
        /// <param name="headers">
        /// UnbindApplyReceiptAndInvoiceRelatedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindApplyReceiptAndInvoiceRelatedResponse
        /// </returns>
        public UnbindApplyReceiptAndInvoiceRelatedResponse UnbindApplyReceiptAndInvoiceRelatedWithOptions(UnbindApplyReceiptAndInvoiceRelatedRequest request, UnbindApplyReceiptAndInvoiceRelatedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
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
                Action = "UnbindApplyReceiptAndInvoiceRelated",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/unbind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindApplyReceiptAndInvoiceRelatedResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑开票申请单关联的发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindApplyReceiptAndInvoiceRelatedRequest
        /// </param>
        /// <param name="headers">
        /// UnbindApplyReceiptAndInvoiceRelatedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindApplyReceiptAndInvoiceRelatedResponse
        /// </returns>
        public async Task<UnbindApplyReceiptAndInvoiceRelatedResponse> UnbindApplyReceiptAndInvoiceRelatedWithOptionsAsync(UnbindApplyReceiptAndInvoiceRelatedRequest request, UnbindApplyReceiptAndInvoiceRelatedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
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
                Action = "UnbindApplyReceiptAndInvoiceRelated",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/unbind",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindApplyReceiptAndInvoiceRelatedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑开票申请单关联的发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindApplyReceiptAndInvoiceRelatedRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindApplyReceiptAndInvoiceRelatedResponse
        /// </returns>
        public UnbindApplyReceiptAndInvoiceRelatedResponse UnbindApplyReceiptAndInvoiceRelated(UnbindApplyReceiptAndInvoiceRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindApplyReceiptAndInvoiceRelatedHeaders headers = new UnbindApplyReceiptAndInvoiceRelatedHeaders();
            return UnbindApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑开票申请单关联的发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindApplyReceiptAndInvoiceRelatedRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindApplyReceiptAndInvoiceRelatedResponse
        /// </returns>
        public async Task<UnbindApplyReceiptAndInvoiceRelatedResponse> UnbindApplyReceiptAndInvoiceRelatedAsync(UnbindApplyReceiptAndInvoiceRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindApplyReceiptAndInvoiceRelatedHeaders headers = new UnbindApplyReceiptAndInvoiceRelatedHeaders();
            return await UnbindApplyReceiptAndInvoiceRelatedWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开票申请单关联发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplyReceiptAndInvoiceRelatedRequest
        /// </param>
        /// <param name="headers">
        /// UpdateApplyReceiptAndInvoiceRelatedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplyReceiptAndInvoiceRelatedResponse
        /// </returns>
        public UpdateApplyReceiptAndInvoiceRelatedResponse UpdateApplyReceiptAndInvoiceRelatedWithOptions(UpdateApplyReceiptAndInvoiceRelatedRequest request, UpdateApplyReceiptAndInvoiceRelatedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInvoiceVOList))
            {
                body["generalInvoiceVOList"] = request.GeneralInvoiceVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
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
                Action = "UpdateApplyReceiptAndInvoiceRelated",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/applyReceipts/relate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplyReceiptAndInvoiceRelatedResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开票申请单关联发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplyReceiptAndInvoiceRelatedRequest
        /// </param>
        /// <param name="headers">
        /// UpdateApplyReceiptAndInvoiceRelatedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplyReceiptAndInvoiceRelatedResponse
        /// </returns>
        public async Task<UpdateApplyReceiptAndInvoiceRelatedResponse> UpdateApplyReceiptAndInvoiceRelatedWithOptionsAsync(UpdateApplyReceiptAndInvoiceRelatedRequest request, UpdateApplyReceiptAndInvoiceRelatedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInvoiceVOList))
            {
                body["generalInvoiceVOList"] = request.GeneralInvoiceVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
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
                Action = "UpdateApplyReceiptAndInvoiceRelated",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/applyReceipts/relate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplyReceiptAndInvoiceRelatedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开票申请单关联发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplyReceiptAndInvoiceRelatedRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplyReceiptAndInvoiceRelatedResponse
        /// </returns>
        public UpdateApplyReceiptAndInvoiceRelatedResponse UpdateApplyReceiptAndInvoiceRelated(UpdateApplyReceiptAndInvoiceRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateApplyReceiptAndInvoiceRelatedHeaders headers = new UpdateApplyReceiptAndInvoiceRelatedHeaders();
            return UpdateApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开票申请单关联发票</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplyReceiptAndInvoiceRelatedRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplyReceiptAndInvoiceRelatedResponse
        /// </returns>
        public async Task<UpdateApplyReceiptAndInvoiceRelatedResponse> UpdateApplyReceiptAndInvoiceRelatedAsync(UpdateApplyReceiptAndInvoiceRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateApplyReceiptAndInvoiceRelatedHeaders headers = new UpdateApplyReceiptAndInvoiceRelatedHeaders();
            return await UpdateApplyReceiptAndInvoiceRelatedWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电发票企业信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalInvoiceOrgInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDigitalInvoiceOrgInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalInvoiceOrgInfoResponse
        /// </returns>
        public UpdateDigitalInvoiceOrgInfoResponse UpdateDigitalInvoiceOrgInfoWithOptions(UpdateDigitalInvoiceOrgInfoRequest request, UpdateDigitalInvoiceOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalInvoiceType))
            {
                body["digitalInvoiceType"] = request.DigitalInvoiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDigitalOrg))
            {
                body["isDigitalOrg"] = request.IsDigitalOrg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
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
                Action = "UpdateDigitalInvoiceOrgInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/organizationInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDigitalInvoiceOrgInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电发票企业信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalInvoiceOrgInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDigitalInvoiceOrgInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalInvoiceOrgInfoResponse
        /// </returns>
        public async Task<UpdateDigitalInvoiceOrgInfoResponse> UpdateDigitalInvoiceOrgInfoWithOptionsAsync(UpdateDigitalInvoiceOrgInfoRequest request, UpdateDigitalInvoiceOrgInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigitalInvoiceType))
            {
                body["digitalInvoiceType"] = request.DigitalInvoiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDigitalOrg))
            {
                body["isDigitalOrg"] = request.IsDigitalOrg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
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
                Action = "UpdateDigitalInvoiceOrgInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/organizationInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDigitalInvoiceOrgInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电发票企业信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalInvoiceOrgInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalInvoiceOrgInfoResponse
        /// </returns>
        public UpdateDigitalInvoiceOrgInfoResponse UpdateDigitalInvoiceOrgInfo(UpdateDigitalInvoiceOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDigitalInvoiceOrgInfoHeaders headers = new UpdateDigitalInvoiceOrgInfoHeaders();
            return UpdateDigitalInvoiceOrgInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电发票企业信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDigitalInvoiceOrgInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDigitalInvoiceOrgInfoResponse
        /// </returns>
        public async Task<UpdateDigitalInvoiceOrgInfoResponse> UpdateDigitalInvoiceOrgInfoAsync(UpdateDigitalInvoiceOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDigitalInvoiceOrgInfoHeaders headers = new UpdateDigitalInvoiceOrgInfoHeaders();
            return await UpdateDigitalInvoiceOrgInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务配置的企业信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceCompanyInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFinanceCompanyInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceCompanyInfoResponse
        /// </returns>
        public UpdateFinanceCompanyInfoResponse UpdateFinanceCompanyInfoWithOptions(UpdateFinanceCompanyInfoRequest request, UpdateFinanceCompanyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["companyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNature))
            {
                query["taxNature"] = request.TaxNature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                query["taxNo"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxOrInvoiceHasInit))
            {
                query["taxOrInvoiceHasInit"] = request.TaxOrInvoiceHasInit;
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
                Action = "UpdateFinanceCompanyInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/companies",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFinanceCompanyInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务配置的企业信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceCompanyInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFinanceCompanyInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceCompanyInfoResponse
        /// </returns>
        public async Task<UpdateFinanceCompanyInfoResponse> UpdateFinanceCompanyInfoWithOptionsAsync(UpdateFinanceCompanyInfoRequest request, UpdateFinanceCompanyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["companyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNature))
            {
                query["taxNature"] = request.TaxNature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                query["taxNo"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxOrInvoiceHasInit))
            {
                query["taxOrInvoiceHasInit"] = request.TaxOrInvoiceHasInit;
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
                Action = "UpdateFinanceCompanyInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/companies",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFinanceCompanyInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务配置的企业信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceCompanyInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceCompanyInfoResponse
        /// </returns>
        public UpdateFinanceCompanyInfoResponse UpdateFinanceCompanyInfo(UpdateFinanceCompanyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFinanceCompanyInfoHeaders headers = new UpdateFinanceCompanyInfoHeaders();
            return UpdateFinanceCompanyInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务配置的企业信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceCompanyInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceCompanyInfoResponse
        /// </returns>
        public async Task<UpdateFinanceCompanyInfoResponse> UpdateFinanceCompanyInfoAsync(UpdateFinanceCompanyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFinanceCompanyInfoHeaders headers = new UpdateFinanceCompanyInfoHeaders();
            return await UpdateFinanceCompanyInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceMultiCompanyInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFinanceMultiCompanyInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceMultiCompanyInfoResponse
        /// </returns>
        public UpdateFinanceMultiCompanyInfoResponse UpdateFinanceMultiCompanyInfoWithOptions(UpdateFinanceMultiCompanyInfoRequest request, UpdateFinanceMultiCompanyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["companyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNature))
            {
                query["taxNature"] = request.TaxNature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                query["taxNo"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxOrInvoiceHasInit))
            {
                query["taxOrInvoiceHasInit"] = request.TaxOrInvoiceHasInit;
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
                Action = "UpdateFinanceMultiCompanyInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/multiCompanies",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFinanceMultiCompanyInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceMultiCompanyInfoRequest
        /// </param>
        /// <param name="headers">
        /// UpdateFinanceMultiCompanyInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceMultiCompanyInfoResponse
        /// </returns>
        public async Task<UpdateFinanceMultiCompanyInfoResponse> UpdateFinanceMultiCompanyInfoWithOptionsAsync(UpdateFinanceMultiCompanyInfoRequest request, UpdateFinanceMultiCompanyInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                query["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                query["companyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNature))
            {
                query["taxNature"] = request.TaxNature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxNo))
            {
                query["taxNo"] = request.TaxNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaxOrInvoiceHasInit))
            {
                query["taxOrInvoiceHasInit"] = request.TaxOrInvoiceHasInit;
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
                Action = "UpdateFinanceMultiCompanyInfo",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/multiCompanies",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFinanceMultiCompanyInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceMultiCompanyInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceMultiCompanyInfoResponse
        /// </returns>
        public UpdateFinanceMultiCompanyInfoResponse UpdateFinanceMultiCompanyInfo(UpdateFinanceMultiCompanyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFinanceMultiCompanyInfoHeaders headers = new UpdateFinanceMultiCompanyInfoHeaders();
            return UpdateFinanceMultiCompanyInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新钉钉智能财务多主体信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFinanceMultiCompanyInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFinanceMultiCompanyInfoResponse
        /// </returns>
        public async Task<UpdateFinanceMultiCompanyInfoResponse> UpdateFinanceMultiCompanyInfoAsync(UpdateFinanceMultiCompanyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFinanceMultiCompanyInfoHeaders headers = new UpdateFinanceMultiCompanyInfoHeaders();
            return await UpdateFinanceMultiCompanyInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票红冲/废弃状态变更接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAbandonStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceAbandonStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAbandonStatusResponse
        /// </returns>
        public UpdateInvoiceAbandonStatusResponse UpdateInvoiceAbandonStatusWithOptions(UpdateInvoiceAbandonStatusRequest request, UpdateInvoiceAbandonStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlueGeneralInvoiceVO))
            {
                body["blueGeneralInvoiceVO"] = request.BlueGeneralInvoiceVO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlueInvoiceCode))
            {
                body["blueInvoiceCode"] = request.BlueInvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlueInvoiceNo))
            {
                body["blueInvoiceNo"] = request.BlueInvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlueInvoiceStatus))
            {
                body["blueInvoiceStatus"] = request.BlueInvoiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedGeneralInvoiceVO))
            {
                body["redGeneralInvoiceVO"] = request.RedGeneralInvoiceVO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedInvoiceCode))
            {
                body["redInvoiceCode"] = request.RedInvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedInvoiceNo))
            {
                body["redInvoiceNo"] = request.RedInvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedInvoiceStatus))
            {
                body["redInvoiceStatus"] = request.RedInvoiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInvoice))
            {
                body["targetInvoice"] = request.TargetInvoice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInvoiceAbandonStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/abandonStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceAbandonStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票红冲/废弃状态变更接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAbandonStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceAbandonStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAbandonStatusResponse
        /// </returns>
        public async Task<UpdateInvoiceAbandonStatusResponse> UpdateInvoiceAbandonStatusWithOptionsAsync(UpdateInvoiceAbandonStatusRequest request, UpdateInvoiceAbandonStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlueGeneralInvoiceVO))
            {
                body["blueGeneralInvoiceVO"] = request.BlueGeneralInvoiceVO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlueInvoiceCode))
            {
                body["blueInvoiceCode"] = request.BlueInvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlueInvoiceNo))
            {
                body["blueInvoiceNo"] = request.BlueInvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlueInvoiceStatus))
            {
                body["blueInvoiceStatus"] = request.BlueInvoiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedGeneralInvoiceVO))
            {
                body["redGeneralInvoiceVO"] = request.RedGeneralInvoiceVO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedInvoiceCode))
            {
                body["redInvoiceCode"] = request.RedInvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedInvoiceNo))
            {
                body["redInvoiceNo"] = request.RedInvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedInvoiceStatus))
            {
                body["redInvoiceStatus"] = request.RedInvoiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInvoice))
            {
                body["targetInvoice"] = request.TargetInvoice;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInvoiceAbandonStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/abandonStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceAbandonStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票红冲/废弃状态变更接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAbandonStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAbandonStatusResponse
        /// </returns>
        public UpdateInvoiceAbandonStatusResponse UpdateInvoiceAbandonStatus(UpdateInvoiceAbandonStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAbandonStatusHeaders headers = new UpdateInvoiceAbandonStatusHeaders();
            return UpdateInvoiceAbandonStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票红冲/废弃状态变更接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAbandonStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAbandonStatusResponse
        /// </returns>
        public async Task<UpdateInvoiceAbandonStatusResponse> UpdateInvoiceAbandonStatusAsync(UpdateInvoiceAbandonStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAbandonStatusHeaders headers = new UpdateInvoiceAbandonStatusHeaders();
            return await UpdateInvoiceAbandonStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票账期状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountPeriodRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceAccountPeriodHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountPeriodResponse
        /// </returns>
        public UpdateInvoiceAccountPeriodResponse UpdateInvoiceAccountPeriodWithOptions(UpdateInvoiceAccountPeriodRequest request, UpdateInvoiceAccountPeriodHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPeriod))
            {
                body["accountPeriod"] = request.AccountPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInvoiceVOList))
            {
                body["generalInvoiceVOList"] = request.GeneralInvoiceVOList;
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
                Action = "UpdateInvoiceAccountPeriod",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/accountPeriods",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceAccountPeriodResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票账期状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountPeriodRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceAccountPeriodHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountPeriodResponse
        /// </returns>
        public async Task<UpdateInvoiceAccountPeriodResponse> UpdateInvoiceAccountPeriodWithOptionsAsync(UpdateInvoiceAccountPeriodRequest request, UpdateInvoiceAccountPeriodHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPeriod))
            {
                body["accountPeriod"] = request.AccountPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInvoiceVOList))
            {
                body["generalInvoiceVOList"] = request.GeneralInvoiceVOList;
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
                Action = "UpdateInvoiceAccountPeriod",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/accountPeriods",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceAccountPeriodResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票账期状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountPeriodResponse
        /// </returns>
        public UpdateInvoiceAccountPeriodResponse UpdateInvoiceAccountPeriod(UpdateInvoiceAccountPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountPeriodHeaders headers = new UpdateInvoiceAccountPeriodHeaders();
            return UpdateInvoiceAccountPeriodWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票账期状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountPeriodRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountPeriodResponse
        /// </returns>
        public async Task<UpdateInvoiceAccountPeriodResponse> UpdateInvoiceAccountPeriodAsync(UpdateInvoiceAccountPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountPeriodHeaders headers = new UpdateInvoiceAccountPeriodHeaders();
            return await UpdateInvoiceAccountPeriodWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电企业入账时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountingPeriodDateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceAccountingPeriodDateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountingPeriodDateResponse
        /// </returns>
        public UpdateInvoiceAccountingPeriodDateResponse UpdateInvoiceAccountingPeriodDateWithOptions(UpdateInvoiceAccountingPeriodDateRequest request, UpdateInvoiceAccountingPeriodDateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceFinanceInfoVOList))
            {
                body["invoiceFinanceInfoVOList"] = request.InvoiceFinanceInfoVOList;
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
                Action = "UpdateInvoiceAccountingPeriodDate",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/accounts/periodDates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceAccountingPeriodDateResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电企业入账时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountingPeriodDateRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceAccountingPeriodDateHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountingPeriodDateResponse
        /// </returns>
        public async Task<UpdateInvoiceAccountingPeriodDateResponse> UpdateInvoiceAccountingPeriodDateWithOptionsAsync(UpdateInvoiceAccountingPeriodDateRequest request, UpdateInvoiceAccountingPeriodDateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceFinanceInfoVOList))
            {
                body["invoiceFinanceInfoVOList"] = request.InvoiceFinanceInfoVOList;
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
                Action = "UpdateInvoiceAccountingPeriodDate",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/accounts/periodDates",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceAccountingPeriodDateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电企业入账时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountingPeriodDateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountingPeriodDateResponse
        /// </returns>
        public UpdateInvoiceAccountingPeriodDateResponse UpdateInvoiceAccountingPeriodDate(UpdateInvoiceAccountingPeriodDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountingPeriodDateHeaders headers = new UpdateInvoiceAccountingPeriodDateHeaders();
            return UpdateInvoiceAccountingPeriodDateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电企业入账时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountingPeriodDateRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountingPeriodDateResponse
        /// </returns>
        public async Task<UpdateInvoiceAccountingPeriodDateResponse> UpdateInvoiceAccountingPeriodDateAsync(UpdateInvoiceAccountingPeriodDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountingPeriodDateHeaders headers = new UpdateInvoiceAccountingPeriodDateHeaders();
            return await UpdateInvoiceAccountingPeriodDateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电企业入账状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountingStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceAccountingStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountingStatusResponse
        /// </returns>
        public UpdateInvoiceAccountingStatusResponse UpdateInvoiceAccountingStatusWithOptions(UpdateInvoiceAccountingStatusRequest request, UpdateInvoiceAccountingStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceFinanceInfoVOList))
            {
                body["invoiceFinanceInfoVOList"] = request.InvoiceFinanceInfoVOList;
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
                Action = "UpdateInvoiceAccountingStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/accounts/statuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceAccountingStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电企业入账状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountingStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceAccountingStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountingStatusResponse
        /// </returns>
        public async Task<UpdateInvoiceAccountingStatusResponse> UpdateInvoiceAccountingStatusWithOptionsAsync(UpdateInvoiceAccountingStatusRequest request, UpdateInvoiceAccountingStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceFinanceInfoVOList))
            {
                body["invoiceFinanceInfoVOList"] = request.InvoiceFinanceInfoVOList;
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
                Action = "UpdateInvoiceAccountingStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/accounts/statuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceAccountingStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电企业入账状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountingStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountingStatusResponse
        /// </returns>
        public UpdateInvoiceAccountingStatusResponse UpdateInvoiceAccountingStatus(UpdateInvoiceAccountingStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountingStatusHeaders headers = new UpdateInvoiceAccountingStatusHeaders();
            return UpdateInvoiceAccountingStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新全电企业入账状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAccountingStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAccountingStatusResponse
        /// </returns>
        public async Task<UpdateInvoiceAccountingStatusResponse> UpdateInvoiceAccountingStatusAsync(UpdateInvoiceAccountingStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountingStatusHeaders headers = new UpdateInvoiceAccountingStatusHeaders();
            return await UpdateInvoiceAccountingStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票关联审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAndReceiptRelatedRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceAndReceiptRelatedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAndReceiptRelatedResponse
        /// </returns>
        public UpdateInvoiceAndReceiptRelatedResponse UpdateInvoiceAndReceiptRelatedWithOptions(UpdateInvoiceAndReceiptRelatedRequest request, UpdateInvoiceAndReceiptRelatedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInvoiceVO))
            {
                body["generalInvoiceVO"] = request.GeneralInvoiceVO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                body["invoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                body["invoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptCode))
            {
                body["receiptCode"] = request.ReceiptCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInvoiceAndReceiptRelated",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/approvalReceipts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceAndReceiptRelatedResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票关联审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAndReceiptRelatedRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceAndReceiptRelatedHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAndReceiptRelatedResponse
        /// </returns>
        public async Task<UpdateInvoiceAndReceiptRelatedResponse> UpdateInvoiceAndReceiptRelatedWithOptionsAsync(UpdateInvoiceAndReceiptRelatedRequest request, UpdateInvoiceAndReceiptRelatedHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInvoiceVO))
            {
                body["generalInvoiceVO"] = request.GeneralInvoiceVO;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                body["invoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                body["invoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptCode))
            {
                body["receiptCode"] = request.ReceiptCode;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInvoiceAndReceiptRelated",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/approvalReceipts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceAndReceiptRelatedResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票关联审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAndReceiptRelatedRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAndReceiptRelatedResponse
        /// </returns>
        public UpdateInvoiceAndReceiptRelatedResponse UpdateInvoiceAndReceiptRelated(UpdateInvoiceAndReceiptRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAndReceiptRelatedHeaders headers = new UpdateInvoiceAndReceiptRelatedHeaders();
            return UpdateInvoiceAndReceiptRelatedWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票关联审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceAndReceiptRelatedRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceAndReceiptRelatedResponse
        /// </returns>
        public async Task<UpdateInvoiceAndReceiptRelatedResponse> UpdateInvoiceAndReceiptRelatedAsync(UpdateInvoiceAndReceiptRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAndReceiptRelatedHeaders headers = new UpdateInvoiceAndReceiptRelatedHeaders();
            return await UpdateInvoiceAndReceiptRelatedWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票忽略状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceIgnoreStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceIgnoreStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceIgnoreStatusResponse
        /// </returns>
        public UpdateInvoiceIgnoreStatusResponse UpdateInvoiceIgnoreStatusWithOptions(UpdateInvoiceIgnoreStatusRequest request, UpdateInvoiceIgnoreStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
            }
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
                Action = "UpdateInvoiceIgnoreStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/ignoreStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceIgnoreStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票忽略状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceIgnoreStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceIgnoreStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceIgnoreStatusResponse
        /// </returns>
        public async Task<UpdateInvoiceIgnoreStatusResponse> UpdateInvoiceIgnoreStatusWithOptionsAsync(UpdateInvoiceIgnoreStatusRequest request, UpdateInvoiceIgnoreStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["operator"] = request.Operator;
            }
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
                Action = "UpdateInvoiceIgnoreStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/ignoreStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceIgnoreStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票忽略状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceIgnoreStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceIgnoreStatusResponse
        /// </returns>
        public UpdateInvoiceIgnoreStatusResponse UpdateInvoiceIgnoreStatus(UpdateInvoiceIgnoreStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceIgnoreStatusHeaders headers = new UpdateInvoiceIgnoreStatusHeaders();
            return UpdateInvoiceIgnoreStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票忽略状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceIgnoreStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceIgnoreStatusResponse
        /// </returns>
        public async Task<UpdateInvoiceIgnoreStatusResponse> UpdateInvoiceIgnoreStatusAsync(UpdateInvoiceIgnoreStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceIgnoreStatusHeaders headers = new UpdateInvoiceIgnoreStatusHeaders();
            return await UpdateInvoiceIgnoreStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票认证状态变更接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceVerifyStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceVerifyStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceVerifyStatusResponse
        /// </returns>
        public UpdateInvoiceVerifyStatusResponse UpdateInvoiceVerifyStatusWithOptions(UpdateInvoiceVerifyStatusRequest request, UpdateInvoiceVerifyStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductStatus))
            {
                body["deductStatus"] = request.DeductStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInvoiceVOList))
            {
                body["generalInvoiceVOList"] = request.GeneralInvoiceVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceKeyVOList))
            {
                body["invoiceKeyVOList"] = request.InvoiceKeyVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
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
                Action = "UpdateInvoiceVerifyStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/verifyStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceVerifyStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票认证状态变更接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceVerifyStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceVerifyStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceVerifyStatusResponse
        /// </returns>
        public async Task<UpdateInvoiceVerifyStatusResponse> UpdateInvoiceVerifyStatusWithOptionsAsync(UpdateInvoiceVerifyStatusRequest request, UpdateInvoiceVerifyStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyCode))
            {
                body["companyCode"] = request.CompanyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeductStatus))
            {
                body["deductStatus"] = request.DeductStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInvoiceVOList))
            {
                body["generalInvoiceVOList"] = request.GeneralInvoiceVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceKeyVOList))
            {
                body["invoiceKeyVOList"] = request.InvoiceKeyVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
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
                Action = "UpdateInvoiceVerifyStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/verifyStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceVerifyStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票认证状态变更接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceVerifyStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceVerifyStatusResponse
        /// </returns>
        public UpdateInvoiceVerifyStatusResponse UpdateInvoiceVerifyStatus(UpdateInvoiceVerifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVerifyStatusHeaders headers = new UpdateInvoiceVerifyStatusHeaders();
            return UpdateInvoiceVerifyStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发票认证状态变更接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceVerifyStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceVerifyStatusResponse
        /// </returns>
        public async Task<UpdateInvoiceVerifyStatusResponse> UpdateInvoiceVerifyStatusAsync(UpdateInvoiceVerifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVerifyStatusHeaders headers = new UpdateInvoiceVerifyStatusHeaders();
            return await UpdateInvoiceVerifyStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票生成凭证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceVoucherStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceVoucherStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceVoucherStatusResponse
        /// </returns>
        public UpdateInvoiceVoucherStatusResponse UpdateInvoiceVoucherStatusWithOptions(UpdateInvoiceVoucherStatusRequest request, UpdateInvoiceVoucherStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountantBookId))
            {
                body["accountantBookId"] = request.AccountantBookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                body["invoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                body["invoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoucherId))
            {
                body["voucherId"] = request.VoucherId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInvoiceVoucherStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/vouchers/states",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceVoucherStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票生成凭证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceVoucherStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateInvoiceVoucherStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceVoucherStatusResponse
        /// </returns>
        public async Task<UpdateInvoiceVoucherStatusResponse> UpdateInvoiceVoucherStatusWithOptionsAsync(UpdateInvoiceVoucherStatusRequest request, UpdateInvoiceVoucherStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountantBookId))
            {
                body["accountantBookId"] = request.AccountantBookId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                body["invoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                body["invoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                body["operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoucherId))
            {
                body["voucherId"] = request.VoucherId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInvoiceVoucherStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/invoices/vouchers/states",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceVoucherStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票生成凭证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceVoucherStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceVoucherStatusResponse
        /// </returns>
        public UpdateInvoiceVoucherStatusResponse UpdateInvoiceVoucherStatus(UpdateInvoiceVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVoucherStatusHeaders headers = new UpdateInvoiceVoucherStatusHeaders();
            return UpdateInvoiceVoucherStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新发票生成凭证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInvoiceVoucherStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInvoiceVoucherStatusResponse
        /// </returns>
        public async Task<UpdateInvoiceVoucherStatusResponse> UpdateInvoiceVoucherStatusAsync(UpdateInvoiceVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVoucherStatusHeaders headers = new UpdateInvoiceVoucherStatusHeaders();
            return await UpdateInvoiceVoucherStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateReceiptRequest
        /// </param>
        /// <param name="headers">
        /// UpdateReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateReceiptResponse
        /// </returns>
        public UpdateReceiptResponse UpdateReceiptWithOptions(UpdateReceiptRequest request, UpdateReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receipts))
            {
                body["receipts"] = request.Receipts;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateReceipt",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateReceiptResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateReceiptRequest
        /// </param>
        /// <param name="headers">
        /// UpdateReceiptHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateReceiptResponse
        /// </returns>
        public async Task<UpdateReceiptResponse> UpdateReceiptWithOptionsAsync(UpdateReceiptRequest request, UpdateReceiptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receipts))
            {
                body["receipts"] = request.Receipts;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateReceipt",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/receipts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateReceiptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateReceiptResponse
        /// </returns>
        public UpdateReceiptResponse UpdateReceipt(UpdateReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateReceiptHeaders headers = new UpdateReceiptHeaders();
            return UpdateReceiptWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务单据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateReceiptRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateReceiptResponse
        /// </returns>
        public async Task<UpdateReceiptResponse> UpdateReceiptAsync(UpdateReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateReceiptHeaders headers = new UpdateReceiptHeaders();
            return await UpdateReceiptWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务审批单的凭证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateReceiptVoucherStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateReceiptVoucherStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateReceiptVoucherStatusResponse
        /// </returns>
        public UpdateReceiptVoucherStatusResponse UpdateReceiptVoucherStatusWithOptions(UpdateReceiptVoucherStatusRequest request, UpdateReceiptVoucherStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPeriod))
            {
                body["accountPeriod"] = request.AccountPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptId))
            {
                body["receiptId"] = request.ReceiptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoucherCode))
            {
                body["voucherCode"] = request.VoucherCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoucherId))
            {
                body["voucherId"] = request.VoucherId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoucherNo))
            {
                body["voucherNo"] = request.VoucherNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateReceiptVoucherStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/vouchers/recepits",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateReceiptVoucherStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务审批单的凭证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateReceiptVoucherStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateReceiptVoucherStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateReceiptVoucherStatusResponse
        /// </returns>
        public async Task<UpdateReceiptVoucherStatusResponse> UpdateReceiptVoucherStatusWithOptionsAsync(UpdateReceiptVoucherStatusRequest request, UpdateReceiptVoucherStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPeriod))
            {
                body["accountPeriod"] = request.AccountPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptId))
            {
                body["receiptId"] = request.ReceiptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoucherCode))
            {
                body["voucherCode"] = request.VoucherCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoucherId))
            {
                body["voucherId"] = request.VoucherId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoucherNo))
            {
                body["voucherNo"] = request.VoucherNo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateReceiptVoucherStatus",
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/vouchers/recepits",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateReceiptVoucherStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务审批单的凭证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateReceiptVoucherStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateReceiptVoucherStatusResponse
        /// </returns>
        public UpdateReceiptVoucherStatusResponse UpdateReceiptVoucherStatus(UpdateReceiptVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateReceiptVoucherStatusHeaders headers = new UpdateReceiptVoucherStatusHeaders();
            return UpdateReceiptVoucherStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新智能财务审批单的凭证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateReceiptVoucherStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateReceiptVoucherStatusResponse
        /// </returns>
        public async Task<UpdateReceiptVoucherStatusResponse> UpdateReceiptVoucherStatusAsync(UpdateReceiptVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateReceiptVoucherStatusHeaders headers = new UpdateReceiptVoucherStatusHeaders();
            return await UpdateReceiptVoucherStatusWithOptionsAsync(request, headers, runtime);
        }

    }
}
