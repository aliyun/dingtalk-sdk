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
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 追加角色权限点
         *
         * @param tmpReq AppendRolePermissionRequest
         * @param headers AppendRolePermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppendRolePermissionResponse
         */
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

        /**
         * @summary 追加角色权限点
         *
         * @param tmpReq AppendRolePermissionRequest
         * @param headers AppendRolePermissionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return AppendRolePermissionResponse
         */
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

        /**
         * @summary 追加角色权限点
         *
         * @param request AppendRolePermissionRequest
         * @return AppendRolePermissionResponse
         */
        public AppendRolePermissionResponse AppendRolePermission(AppendRolePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendRolePermissionHeaders headers = new AppendRolePermissionHeaders();
            return AppendRolePermissionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 追加角色权限点
         *
         * @param request AppendRolePermissionRequest
         * @return AppendRolePermissionResponse
         */
        public async Task<AppendRolePermissionResponse> AppendRolePermissionAsync(AppendRolePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppendRolePermissionHeaders headers = new AppendRolePermissionHeaders();
            return await AppendRolePermissionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发票数据批量写入
         *
         * @param request BatchAddInvoiceRequest
         * @param headers BatchAddInvoiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchAddInvoiceResponse
         */
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

        /**
         * @summary 发票数据批量写入
         *
         * @param request BatchAddInvoiceRequest
         * @param headers BatchAddInvoiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchAddInvoiceResponse
         */
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

        /**
         * @summary 发票数据批量写入
         *
         * @param request BatchAddInvoiceRequest
         * @return BatchAddInvoiceResponse
         */
        public BatchAddInvoiceResponse BatchAddInvoice(BatchAddInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddInvoiceHeaders headers = new BatchAddInvoiceHeaders();
            return BatchAddInvoiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发票数据批量写入
         *
         * @param request BatchAddInvoiceRequest
         * @return BatchAddInvoiceResponse
         */
        public async Task<BatchAddInvoiceResponse> BatchAddInvoiceAsync(BatchAddInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchAddInvoiceHeaders headers = new BatchAddInvoiceHeaders();
            return await BatchAddInvoiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量增加用户信息
         *
         * @param request BatchCreateCustomerRequest
         * @param headers BatchCreateCustomerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchCreateCustomerResponse
         */
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

        /**
         * @summary 批量增加用户信息
         *
         * @param request BatchCreateCustomerRequest
         * @param headers BatchCreateCustomerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchCreateCustomerResponse
         */
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

        /**
         * @summary 批量增加用户信息
         *
         * @param request BatchCreateCustomerRequest
         * @return BatchCreateCustomerResponse
         */
        public BatchCreateCustomerResponse BatchCreateCustomer(BatchCreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateCustomerHeaders headers = new BatchCreateCustomerHeaders();
            return BatchCreateCustomerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量增加用户信息
         *
         * @param request BatchCreateCustomerRequest
         * @return BatchCreateCustomerResponse
         */
        public async Task<BatchCreateCustomerResponse> BatchCreateCustomerAsync(BatchCreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchCreateCustomerHeaders headers = new BatchCreateCustomerHeaders();
            return await BatchCreateCustomerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 预核销智能财务的权益
         *
         * @param request BeginConsumeRequest
         * @param headers BeginConsumeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BeginConsumeResponse
         */
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

        /**
         * @summary 预核销智能财务的权益
         *
         * @param request BeginConsumeRequest
         * @param headers BeginConsumeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BeginConsumeResponse
         */
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

        /**
         * @summary 预核销智能财务的权益
         *
         * @param request BeginConsumeRequest
         * @return BeginConsumeResponse
         */
        public BeginConsumeResponse BeginConsume(BeginConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BeginConsumeHeaders headers = new BeginConsumeHeaders();
            return BeginConsumeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 预核销智能财务的权益
         *
         * @param request BeginConsumeRequest
         * @return BeginConsumeResponse
         */
        public async Task<BeginConsumeResponse> BeginConsumeAsync(BeginConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BeginConsumeHeaders headers = new BeginConsumeHeaders();
            return await BeginConsumeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 绑定钉钉智能财务企业主体的账套信息
         *
         * @param request BindCompanyAccountantBookRequest
         * @param headers BindCompanyAccountantBookHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindCompanyAccountantBookResponse
         */
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

        /**
         * @summary 绑定钉钉智能财务企业主体的账套信息
         *
         * @param request BindCompanyAccountantBookRequest
         * @param headers BindCompanyAccountantBookHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindCompanyAccountantBookResponse
         */
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

        /**
         * @summary 绑定钉钉智能财务企业主体的账套信息
         *
         * @param request BindCompanyAccountantBookRequest
         * @return BindCompanyAccountantBookResponse
         */
        public BindCompanyAccountantBookResponse BindCompanyAccountantBook(BindCompanyAccountantBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BindCompanyAccountantBookHeaders headers = new BindCompanyAccountantBookHeaders();
            return BindCompanyAccountantBookWithOptions(request, headers, runtime);
        }

        /**
         * @summary 绑定钉钉智能财务企业主体的账套信息
         *
         * @param request BindCompanyAccountantBookRequest
         * @return BindCompanyAccountantBookResponse
         */
        public async Task<BindCompanyAccountantBookResponse> BindCompanyAccountantBookAsync(BindCompanyAccountantBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BindCompanyAccountantBookHeaders headers = new BindCompanyAccountantBookHeaders();
            return await BindCompanyAccountantBookWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 取消核销智能财务的权益
         *
         * @param request CancelConsumeRequest
         * @param headers CancelConsumeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelConsumeResponse
         */
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

        /**
         * @summary 取消核销智能财务的权益
         *
         * @param request CancelConsumeRequest
         * @param headers CancelConsumeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelConsumeResponse
         */
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

        /**
         * @summary 取消核销智能财务的权益
         *
         * @param request CancelConsumeRequest
         * @return CancelConsumeResponse
         */
        public CancelConsumeResponse CancelConsume(CancelConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelConsumeHeaders headers = new CancelConsumeHeaders();
            return CancelConsumeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 取消核销智能财务的权益
         *
         * @param request CancelConsumeRequest
         * @return CancelConsumeResponse
         */
        public async Task<CancelConsumeResponse> CancelConsumeAsync(CancelConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelConsumeHeaders headers = new CancelConsumeHeaders();
            return await CancelConsumeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查验发票是否生成凭证
         *
         * @param request CheckVoucherStatusRequest
         * @param headers CheckVoucherStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckVoucherStatusResponse
         */
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

        /**
         * @summary 查验发票是否生成凭证
         *
         * @param request CheckVoucherStatusRequest
         * @param headers CheckVoucherStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckVoucherStatusResponse
         */
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

        /**
         * @summary 查验发票是否生成凭证
         *
         * @param request CheckVoucherStatusRequest
         * @return CheckVoucherStatusResponse
         */
        public CheckVoucherStatusResponse CheckVoucherStatus(CheckVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckVoucherStatusHeaders headers = new CheckVoucherStatusHeaders();
            return CheckVoucherStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查验发票是否生成凭证
         *
         * @param request CheckVoucherStatusRequest
         * @return CheckVoucherStatusResponse
         */
        public async Task<CheckVoucherStatusResponse> CheckVoucherStatusAsync(CheckVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckVoucherStatusHeaders headers = new CheckVoucherStatusHeaders();
            return await CheckVoucherStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 确认核销智能财务的权益
         *
         * @param request CommitConsumeRequest
         * @param headers CommitConsumeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CommitConsumeResponse
         */
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

        /**
         * @summary 确认核销智能财务的权益
         *
         * @param request CommitConsumeRequest
         * @param headers CommitConsumeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CommitConsumeResponse
         */
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

        /**
         * @summary 确认核销智能财务的权益
         *
         * @param request CommitConsumeRequest
         * @return CommitConsumeResponse
         */
        public CommitConsumeResponse CommitConsume(CommitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommitConsumeHeaders headers = new CommitConsumeHeaders();
            return CommitConsumeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 确认核销智能财务的权益
         *
         * @param request CommitConsumeRequest
         * @return CommitConsumeResponse
         */
        public async Task<CommitConsumeResponse> CommitConsumeAsync(CommitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CommitConsumeHeaders headers = new CommitConsumeHeaders();
            return await CommitConsumeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建智能财务的客户信息
         *
         * @param request CreateCustomerRequest
         * @param headers CreateCustomerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomerResponse
         */
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

        /**
         * @summary 创建智能财务的客户信息
         *
         * @param request CreateCustomerRequest
         * @param headers CreateCustomerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomerResponse
         */
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

        /**
         * @summary 创建智能财务的客户信息
         *
         * @param request CreateCustomerRequest
         * @return CreateCustomerResponse
         */
        public CreateCustomerResponse CreateCustomer(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomerHeaders headers = new CreateCustomerHeaders();
            return CreateCustomerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建智能财务的客户信息
         *
         * @param request CreateCustomerRequest
         * @return CreateCustomerResponse
         */
        public async Task<CreateCustomerResponse> CreateCustomerAsync(CreateCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateCustomerHeaders headers = new CreateCustomerHeaders();
            return await CreateCustomerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建智能财务单据
         *
         * @param request CreateReceiptRequest
         * @param headers CreateReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateReceiptResponse
         */
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

        /**
         * @summary 创建智能财务单据
         *
         * @param request CreateReceiptRequest
         * @param headers CreateReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateReceiptResponse
         */
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

        /**
         * @summary 创建智能财务单据
         *
         * @param request CreateReceiptRequest
         * @return CreateReceiptResponse
         */
        public CreateReceiptResponse CreateReceipt(CreateReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateReceiptHeaders headers = new CreateReceiptHeaders();
            return CreateReceiptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建智能财务单据
         *
         * @param request CreateReceiptRequest
         * @return CreateReceiptResponse
         */
        public async Task<CreateReceiptResponse> CreateReceiptAsync(CreateReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateReceiptHeaders headers = new CreateReceiptHeaders();
            return await CreateReceiptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除智能财务单据
         *
         * @param request DeleteReceiptRequest
         * @param headers DeleteReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteReceiptResponse
         */
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

        /**
         * @summary 删除智能财务单据
         *
         * @param request DeleteReceiptRequest
         * @param headers DeleteReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteReceiptResponse
         */
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

        /**
         * @summary 删除智能财务单据
         *
         * @param request DeleteReceiptRequest
         * @return DeleteReceiptResponse
         */
        public DeleteReceiptResponse DeleteReceipt(DeleteReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteReceiptHeaders headers = new DeleteReceiptHeaders();
            return DeleteReceiptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除智能财务单据
         *
         * @param request DeleteReceiptRequest
         * @return DeleteReceiptResponse
         */
        public async Task<DeleteReceiptResponse> DeleteReceiptAsync(DeleteReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteReceiptHeaders headers = new DeleteReceiptHeaders();
            return await DeleteReceiptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取可以查看账本的用户列表
         *
         * @param headers GetBookkeepingUserListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBookkeepingUserListResponse
         */
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

        /**
         * @summary 获取可以查看账本的用户列表
         *
         * @param headers GetBookkeepingUserListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBookkeepingUserListResponse
         */
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

        /**
         * @summary 获取可以查看账本的用户列表
         *
         * @return GetBookkeepingUserListResponse
         */
        public GetBookkeepingUserListResponse GetBookkeepingUserList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBookkeepingUserListHeaders headers = new GetBookkeepingUserListHeaders();
            return GetBookkeepingUserListWithOptions(headers, runtime);
        }

        /**
         * @summary 获取可以查看账本的用户列表
         *
         * @return GetBookkeepingUserListResponse
         */
        public async Task<GetBookkeepingUserListResponse> GetBookkeepingUserListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBookkeepingUserListHeaders headers = new GetBookkeepingUserListHeaders();
            return await GetBookkeepingUserListWithOptionsAsync(headers, runtime);
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
         * @summary 获取智能财务应用内维护的客户信息
         *
         * @param request GetCustomerRequest
         * @param headers GetCustomerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomerResponse
         */
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

        /**
         * @summary 获取智能财务应用内维护的客户信息
         *
         * @param request GetCustomerRequest
         * @param headers GetCustomerHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomerResponse
         */
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

        /**
         * @summary 获取智能财务应用内维护的客户信息
         *
         * @param request GetCustomerRequest
         * @return GetCustomerResponse
         */
        public GetCustomerResponse GetCustomer(GetCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCustomerHeaders headers = new GetCustomerHeaders();
            return GetCustomerWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取智能财务应用内维护的客户信息
         *
         * @param request GetCustomerRequest
         * @return GetCustomerResponse
         */
        public async Task<GetCustomerResponse> GetCustomerAsync(GetCustomerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCustomerHeaders headers = new GetCustomerHeaders();
            return await GetCustomerWithOptionsAsync(request, headers, runtime);
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
         * @summary 获取智能财务套件模版信息
         *
         * @param headers GetFormTemplateInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFormTemplateInfoResponse
         */
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

        /**
         * @summary 获取智能财务套件模版信息
         *
         * @param headers GetFormTemplateInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFormTemplateInfoResponse
         */
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

        /**
         * @summary 获取智能财务套件模版信息
         *
         * @return GetFormTemplateInfoResponse
         */
        public GetFormTemplateInfoResponse GetFormTemplateInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormTemplateInfoHeaders headers = new GetFormTemplateInfoHeaders();
            return GetFormTemplateInfoWithOptions(headers, runtime);
        }

        /**
         * @summary 获取智能财务套件模版信息
         *
         * @return GetFormTemplateInfoResponse
         */
        public async Task<GetFormTemplateInfoResponse> GetFormTemplateInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFormTemplateInfoHeaders headers = new GetFormTemplateInfoHeaders();
            return await GetFormTemplateInfoWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 发票分页查询接口
         *
         * @param tmpReq GetInvoiceByPageRequest
         * @param headers GetInvoiceByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInvoiceByPageResponse
         */
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

        /**
         * @summary 发票分页查询接口
         *
         * @param tmpReq GetInvoiceByPageRequest
         * @param headers GetInvoiceByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInvoiceByPageResponse
         */
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

        /**
         * @summary 发票分页查询接口
         *
         * @param request GetInvoiceByPageRequest
         * @return GetInvoiceByPageResponse
         */
        public GetInvoiceByPageResponse GetInvoiceByPage(GetInvoiceByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInvoiceByPageHeaders headers = new GetInvoiceByPageHeaders();
            return GetInvoiceByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发票分页查询接口
         *
         * @param request GetInvoiceByPageRequest
         * @return GetInvoiceByPageResponse
         */
        public async Task<GetInvoiceByPageResponse> GetInvoiceByPageAsync(GetInvoiceByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInvoiceByPageHeaders headers = new GetInvoiceByPageHeaders();
            return await GetInvoiceByPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 用来给isv提供是否使用智能账本的判断接口
         *
         * @param headers GetIsNewVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIsNewVersionResponse
         */
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

        /**
         * @summary 用来给isv提供是否使用智能账本的判断接口
         *
         * @param headers GetIsNewVersionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIsNewVersionResponse
         */
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

        /**
         * @summary 用来给isv提供是否使用智能账本的判断接口
         *
         * @return GetIsNewVersionResponse
         */
        public GetIsNewVersionResponse GetIsNewVersion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIsNewVersionHeaders headers = new GetIsNewVersionHeaders();
            return GetIsNewVersionWithOptions(headers, runtime);
        }

        /**
         * @summary 用来给isv提供是否使用智能账本的判断接口
         *
         * @return GetIsNewVersionResponse
         */
        public async Task<GetIsNewVersionResponse> GetIsNewVersionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIsNewVersionHeaders headers = new GetIsNewVersionHeaders();
            return await GetIsNewVersionWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 根据comanyCode查询钉钉智能财务多主体信息
         *
         * @param headers GetMultiCompanyInfoByCodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMultiCompanyInfoByCodeResponse
         */
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

        /**
         * @summary 根据comanyCode查询钉钉智能财务多主体信息
         *
         * @param headers GetMultiCompanyInfoByCodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMultiCompanyInfoByCodeResponse
         */
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

        /**
         * @summary 根据comanyCode查询钉钉智能财务多主体信息
         *
         * @return GetMultiCompanyInfoByCodeResponse
         */
        public GetMultiCompanyInfoByCodeResponse GetMultiCompanyInfoByCode(string companyCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMultiCompanyInfoByCodeHeaders headers = new GetMultiCompanyInfoByCodeHeaders();
            return GetMultiCompanyInfoByCodeWithOptions(companyCode, headers, runtime);
        }

        /**
         * @summary 根据comanyCode查询钉钉智能财务多主体信息
         *
         * @return GetMultiCompanyInfoByCodeResponse
         */
        public async Task<GetMultiCompanyInfoByCodeResponse> GetMultiCompanyInfoByCodeAsync(string companyCode)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetMultiCompanyInfoByCodeHeaders headers = new GetMultiCompanyInfoByCodeHeaders();
            return await GetMultiCompanyInfoByCodeWithOptionsAsync(companyCode, headers, runtime);
        }

        /**
         * @summary 获取商品信息
         *
         * @param request GetProductRequest
         * @param headers GetProductHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProductResponse
         */
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

        /**
         * @summary 获取商品信息
         *
         * @param request GetProductRequest
         * @param headers GetProductHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProductResponse
         */
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

        /**
         * @summary 获取商品信息
         *
         * @param request GetProductRequest
         * @return GetProductResponse
         */
        public GetProductResponse GetProduct(GetProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProductHeaders headers = new GetProductHeaders();
            return GetProductWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取商品信息
         *
         * @param request GetProductRequest
         * @return GetProductResponse
         */
        public async Task<GetProductResponse> GetProductAsync(GetProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetProductHeaders headers = new GetProductHeaders();
            return await GetProductWithOptionsAsync(request, headers, runtime);
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
         * @summary 获取用友开放平台接口鉴权信息
         *
         * @param request GetYongYouOpenApiTokenRequest
         * @param headers GetYongYouOpenApiTokenHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetYongYouOpenApiTokenResponse
         */
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

        /**
         * @summary 获取用友开放平台接口鉴权信息
         *
         * @param request GetYongYouOpenApiTokenRequest
         * @param headers GetYongYouOpenApiTokenHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetYongYouOpenApiTokenResponse
         */
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

        /**
         * @summary 获取用友开放平台接口鉴权信息
         *
         * @param request GetYongYouOpenApiTokenRequest
         * @return GetYongYouOpenApiTokenResponse
         */
        public GetYongYouOpenApiTokenResponse GetYongYouOpenApiToken(GetYongYouOpenApiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetYongYouOpenApiTokenHeaders headers = new GetYongYouOpenApiTokenHeaders();
            return GetYongYouOpenApiTokenWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取用友开放平台接口鉴权信息
         *
         * @param request GetYongYouOpenApiTokenRequest
         * @return GetYongYouOpenApiTokenResponse
         */
        public async Task<GetYongYouOpenApiTokenResponse> GetYongYouOpenApiTokenAsync(GetYongYouOpenApiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetYongYouOpenApiTokenHeaders headers = new GetYongYouOpenApiTokenHeaders();
            return await GetYongYouOpenApiTokenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询钉钉组织绑定的畅捷通组织
         *
         * @param headers GetYongYouOrgRelationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetYongYouOrgRelationResponse
         */
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

        /**
         * @summary 查询钉钉组织绑定的畅捷通组织
         *
         * @param headers GetYongYouOrgRelationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetYongYouOrgRelationResponse
         */
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

        /**
         * @summary 查询钉钉组织绑定的畅捷通组织
         *
         * @return GetYongYouOrgRelationResponse
         */
        public GetYongYouOrgRelationResponse GetYongYouOrgRelation()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetYongYouOrgRelationHeaders headers = new GetYongYouOrgRelationHeaders();
            return GetYongYouOrgRelationWithOptions(headers, runtime);
        }

        /**
         * @summary 查询钉钉组织绑定的畅捷通组织
         *
         * @return GetYongYouOrgRelationResponse
         */
        public async Task<GetYongYouOrgRelationResponse> GetYongYouOrgRelationAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetYongYouOrgRelationHeaders headers = new GetYongYouOrgRelationHeaders();
            return await GetYongYouOrgRelationWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 权益核销
         *
         * @param request ProfessionBenefitConsumeRequest
         * @param headers ProfessionBenefitConsumeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ProfessionBenefitConsumeResponse
         */
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

        /**
         * @summary 权益核销
         *
         * @param request ProfessionBenefitConsumeRequest
         * @param headers ProfessionBenefitConsumeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ProfessionBenefitConsumeResponse
         */
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

        /**
         * @summary 权益核销
         *
         * @param request ProfessionBenefitConsumeRequest
         * @return ProfessionBenefitConsumeResponse
         */
        public ProfessionBenefitConsumeResponse ProfessionBenefitConsume(ProfessionBenefitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProfessionBenefitConsumeHeaders headers = new ProfessionBenefitConsumeHeaders();
            return ProfessionBenefitConsumeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 权益核销
         *
         * @param request ProfessionBenefitConsumeRequest
         * @return ProfessionBenefitConsumeResponse
         */
        public async Task<ProfessionBenefitConsumeResponse> ProfessionBenefitConsumeAsync(ProfessionBenefitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProfessionBenefitConsumeHeaders headers = new ProfessionBenefitConsumeHeaders();
            return await ProfessionBenefitConsumeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 触发单据同步给有成
         *
         * @param request PushHistoricalReceiptsRequest
         * @param headers PushHistoricalReceiptsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushHistoricalReceiptsResponse
         */
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

        /**
         * @summary 触发单据同步给有成
         *
         * @param request PushHistoricalReceiptsRequest
         * @param headers PushHistoricalReceiptsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushHistoricalReceiptsResponse
         */
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

        /**
         * @summary 触发单据同步给有成
         *
         * @param request PushHistoricalReceiptsRequest
         * @return PushHistoricalReceiptsResponse
         */
        public PushHistoricalReceiptsResponse PushHistoricalReceipts(PushHistoricalReceiptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushHistoricalReceiptsHeaders headers = new PushHistoricalReceiptsHeaders();
            return PushHistoricalReceiptsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 触发单据同步给有成
         *
         * @param request PushHistoricalReceiptsRequest
         * @return PushHistoricalReceiptsResponse
         */
        public async Task<PushHistoricalReceiptsResponse> PushHistoricalReceiptsAsync(PushHistoricalReceiptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushHistoricalReceiptsHeaders headers = new PushHistoricalReceiptsHeaders();
            return await PushHistoricalReceiptsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询智能财务计量型权益
         *
         * @param request QueryBenefitRequest
         * @param headers QueryBenefitHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBenefitResponse
         */
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

        /**
         * @summary 查询智能财务计量型权益
         *
         * @param request QueryBenefitRequest
         * @param headers QueryBenefitHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBenefitResponse
         */
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

        /**
         * @summary 查询智能财务计量型权益
         *
         * @param request QueryBenefitRequest
         * @return QueryBenefitResponse
         */
        public QueryBenefitResponse QueryBenefit(QueryBenefitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBenefitHeaders headers = new QueryBenefitHeaders();
            return QueryBenefitWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询智能财务计量型权益
         *
         * @param request QueryBenefitRequest
         * @return QueryBenefitResponse
         */
        public async Task<QueryBenefitResponse> QueryBenefitAsync(QueryBenefitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBenefitHeaders headers = new QueryBenefitHeaders();
            return await QueryBenefitWithOptionsAsync(request, headers, runtime);
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/categories/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
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
                Version = "bizfinance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bizfinance/categories/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
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
         * @summary 查询某个主体的开票申请单的提单数量
         *
         * @param request QueryCompanyInvoiceRelationCountRequest
         * @param headers QueryCompanyInvoiceRelationCountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCompanyInvoiceRelationCountResponse
         */
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

        /**
         * @summary 查询某个主体的开票申请单的提单数量
         *
         * @param request QueryCompanyInvoiceRelationCountRequest
         * @param headers QueryCompanyInvoiceRelationCountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCompanyInvoiceRelationCountResponse
         */
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

        /**
         * @summary 查询某个主体的开票申请单的提单数量
         *
         * @param request QueryCompanyInvoiceRelationCountRequest
         * @return QueryCompanyInvoiceRelationCountResponse
         */
        public QueryCompanyInvoiceRelationCountResponse QueryCompanyInvoiceRelationCount(QueryCompanyInvoiceRelationCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCompanyInvoiceRelationCountHeaders headers = new QueryCompanyInvoiceRelationCountHeaders();
            return QueryCompanyInvoiceRelationCountWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询某个主体的开票申请单的提单数量
         *
         * @param request QueryCompanyInvoiceRelationCountRequest
         * @return QueryCompanyInvoiceRelationCountResponse
         */
        public async Task<QueryCompanyInvoiceRelationCountResponse> QueryCompanyInvoiceRelationCountAsync(QueryCompanyInvoiceRelationCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCompanyInvoiceRelationCountHeaders headers = new QueryCompanyInvoiceRelationCountHeaders();
            return await QueryCompanyInvoiceRelationCountWithOptionsAsync(request, headers, runtime);
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
         * @summary 提供给合作伙伴，查询智能财务的客户配置信息
         *
         * @param request QueryCustomerInfoRequest
         * @param headers QueryCustomerInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomerInfoResponse
         */
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

        /**
         * @summary 提供给合作伙伴，查询智能财务的客户配置信息
         *
         * @param request QueryCustomerInfoRequest
         * @param headers QueryCustomerInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCustomerInfoResponse
         */
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

        /**
         * @summary 提供给合作伙伴，查询智能财务的客户配置信息
         *
         * @param request QueryCustomerInfoRequest
         * @return QueryCustomerInfoResponse
         */
        public QueryCustomerInfoResponse QueryCustomerInfo(QueryCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerInfoHeaders headers = new QueryCustomerInfoHeaders();
            return QueryCustomerInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 提供给合作伙伴，查询智能财务的客户配置信息
         *
         * @param request QueryCustomerInfoRequest
         * @return QueryCustomerInfoResponse
         */
        public async Task<QueryCustomerInfoResponse> QueryCustomerInfoAsync(QueryCustomerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCustomerInfoHeaders headers = new QueryCustomerInfoHeaders();
            return await QueryCustomerInfoWithOptionsAsync(request, headers, runtime);
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
         * @summary 查询智能财务配置的企业信息
         *
         * @param headers QueryFinanceCompanyInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFinanceCompanyInfoResponse
         */
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

        /**
         * @summary 查询智能财务配置的企业信息
         *
         * @param headers QueryFinanceCompanyInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFinanceCompanyInfoResponse
         */
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

        /**
         * @summary 查询智能财务配置的企业信息
         *
         * @return QueryFinanceCompanyInfoResponse
         */
        public QueryFinanceCompanyInfoResponse QueryFinanceCompanyInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFinanceCompanyInfoHeaders headers = new QueryFinanceCompanyInfoHeaders();
            return QueryFinanceCompanyInfoWithOptions(headers, runtime);
        }

        /**
         * @summary 查询智能财务配置的企业信息
         *
         * @return QueryFinanceCompanyInfoResponse
         */
        public async Task<QueryFinanceCompanyInfoResponse> QueryFinanceCompanyInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryFinanceCompanyInfoHeaders headers = new QueryFinanceCompanyInfoHeaders();
            return await QueryFinanceCompanyInfoWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询开票申请单的提单数量
         *
         * @param headers QueryInvoiceRelationCountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInvoiceRelationCountResponse
         */
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

        /**
         * @summary 查询开票申请单的提单数量
         *
         * @param headers QueryInvoiceRelationCountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryInvoiceRelationCountResponse
         */
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

        /**
         * @summary 查询开票申请单的提单数量
         *
         * @return QueryInvoiceRelationCountResponse
         */
        public QueryInvoiceRelationCountResponse QueryInvoiceRelationCount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInvoiceRelationCountHeaders headers = new QueryInvoiceRelationCountHeaders();
            return QueryInvoiceRelationCountWithOptions(headers, runtime);
        }

        /**
         * @summary 查询开票申请单的提单数量
         *
         * @return QueryInvoiceRelationCountResponse
         */
        public async Task<QueryInvoiceRelationCountResponse> QueryInvoiceRelationCountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryInvoiceRelationCountHeaders headers = new QueryInvoiceRelationCountHeaders();
            return await QueryInvoiceRelationCountWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询钉钉智能财务多主体信息
         *
         * @param headers QueryMultiCompanyInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMultiCompanyInfoResponse
         */
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

        /**
         * @summary 查询钉钉智能财务多主体信息
         *
         * @param headers QueryMultiCompanyInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMultiCompanyInfoResponse
         */
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

        /**
         * @summary 查询钉钉智能财务多主体信息
         *
         * @return QueryMultiCompanyInfoResponse
         */
        public QueryMultiCompanyInfoResponse QueryMultiCompanyInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMultiCompanyInfoHeaders headers = new QueryMultiCompanyInfoHeaders();
            return QueryMultiCompanyInfoWithOptions(headers, runtime);
        }

        /**
         * @summary 查询钉钉智能财务多主体信息
         *
         * @return QueryMultiCompanyInfoResponse
         */
        public async Task<QueryMultiCompanyInfoResponse> QueryMultiCompanyInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMultiCompanyInfoHeaders headers = new QueryMultiCompanyInfoHeaders();
            return await QueryMultiCompanyInfoWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 提供给小望，查询当前用户所具有的的小望权限点信息
         *
         * @param request QueryPermissionByUserIdRequest
         * @param headers QueryPermissionByUserIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPermissionByUserIdResponse
         */
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

        /**
         * @summary 提供给小望，查询当前用户所具有的的小望权限点信息
         *
         * @param request QueryPermissionByUserIdRequest
         * @param headers QueryPermissionByUserIdHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPermissionByUserIdResponse
         */
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

        /**
         * @summary 提供给小望，查询当前用户所具有的的小望权限点信息
         *
         * @param request QueryPermissionByUserIdRequest
         * @return QueryPermissionByUserIdResponse
         */
        public QueryPermissionByUserIdResponse QueryPermissionByUserId(QueryPermissionByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPermissionByUserIdHeaders headers = new QueryPermissionByUserIdHeaders();
            return QueryPermissionByUserIdWithOptions(request, headers, runtime);
        }

        /**
         * @summary 提供给小望，查询当前用户所具有的的小望权限点信息
         *
         * @param request QueryPermissionByUserIdRequest
         * @return QueryPermissionByUserIdResponse
         */
        public async Task<QueryPermissionByUserIdResponse> QueryPermissionByUserIdAsync(QueryPermissionByUserIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPermissionByUserIdHeaders headers = new QueryPermissionByUserIdHeaders();
            return await QueryPermissionByUserIdWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询智能财务角色下的成员信息
         *
         * @param request QueryPermissionRoleMemberRequest
         * @param headers QueryPermissionRoleMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPermissionRoleMemberResponse
         */
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

        /**
         * @summary 查询智能财务角色下的成员信息
         *
         * @param request QueryPermissionRoleMemberRequest
         * @param headers QueryPermissionRoleMemberHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPermissionRoleMemberResponse
         */
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

        /**
         * @summary 查询智能财务角色下的成员信息
         *
         * @param request QueryPermissionRoleMemberRequest
         * @return QueryPermissionRoleMemberResponse
         */
        public QueryPermissionRoleMemberResponse QueryPermissionRoleMember(QueryPermissionRoleMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPermissionRoleMemberHeaders headers = new QueryPermissionRoleMemberHeaders();
            return QueryPermissionRoleMemberWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询智能财务角色下的成员信息
         *
         * @param request QueryPermissionRoleMemberRequest
         * @return QueryPermissionRoleMemberResponse
         */
        public async Task<QueryPermissionRoleMemberResponse> QueryPermissionRoleMemberAsync(QueryPermissionRoleMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPermissionRoleMemberHeaders headers = new QueryPermissionRoleMemberHeaders();
            return await QueryPermissionRoleMemberWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量获取商品信息
         *
         * @param request QueryProductByPageRequest
         * @param headers QueryProductByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryProductByPageResponse
         */
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

        /**
         * @summary 批量获取商品信息
         *
         * @param request QueryProductByPageRequest
         * @param headers QueryProductByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryProductByPageResponse
         */
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

        /**
         * @summary 批量获取商品信息
         *
         * @param request QueryProductByPageRequest
         * @return QueryProductByPageResponse
         */
        public QueryProductByPageResponse QueryProductByPage(QueryProductByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProductByPageHeaders headers = new QueryProductByPageHeaders();
            return QueryProductByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量获取商品信息
         *
         * @param request QueryProductByPageRequest
         * @return QueryProductByPageResponse
         */
        public async Task<QueryProductByPageResponse> QueryProductByPageAsync(QueryProductByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryProductByPageHeaders headers = new QueryProductByPageHeaders();
            return await QueryProductByPageWithOptionsAsync(request, headers, runtime);
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
         * @summary 查询开票申请单详情
         *
         * @param request QueryReceiptDetailForInvoiceRequest
         * @param headers QueryReceiptDetailForInvoiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReceiptDetailForInvoiceResponse
         */
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

        /**
         * @summary 查询开票申请单详情
         *
         * @param request QueryReceiptDetailForInvoiceRequest
         * @param headers QueryReceiptDetailForInvoiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReceiptDetailForInvoiceResponse
         */
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

        /**
         * @summary 查询开票申请单详情
         *
         * @param request QueryReceiptDetailForInvoiceRequest
         * @return QueryReceiptDetailForInvoiceResponse
         */
        public QueryReceiptDetailForInvoiceResponse QueryReceiptDetailForInvoice(QueryReceiptDetailForInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptDetailForInvoiceHeaders headers = new QueryReceiptDetailForInvoiceHeaders();
            return QueryReceiptDetailForInvoiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询开票申请单详情
         *
         * @param request QueryReceiptDetailForInvoiceRequest
         * @return QueryReceiptDetailForInvoiceResponse
         */
        public async Task<QueryReceiptDetailForInvoiceResponse> QueryReceiptDetailForInvoiceAsync(QueryReceiptDetailForInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptDetailForInvoiceHeaders headers = new QueryReceiptDetailForInvoiceHeaders();
            return await QueryReceiptDetailForInvoiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询智能财务单据主数据信息
         *
         * @param request QueryReceiptForInvoiceRequest
         * @param headers QueryReceiptForInvoiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReceiptForInvoiceResponse
         */
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

        /**
         * @summary 批量查询智能财务单据主数据信息
         *
         * @param request QueryReceiptForInvoiceRequest
         * @param headers QueryReceiptForInvoiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReceiptForInvoiceResponse
         */
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

        /**
         * @summary 批量查询智能财务单据主数据信息
         *
         * @param request QueryReceiptForInvoiceRequest
         * @return QueryReceiptForInvoiceResponse
         */
        public QueryReceiptForInvoiceResponse QueryReceiptForInvoice(QueryReceiptForInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptForInvoiceHeaders headers = new QueryReceiptForInvoiceHeaders();
            return QueryReceiptForInvoiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询智能财务单据主数据信息
         *
         * @param request QueryReceiptForInvoiceRequest
         * @return QueryReceiptForInvoiceResponse
         */
        public async Task<QueryReceiptForInvoiceResponse> QueryReceiptForInvoiceAsync(QueryReceiptForInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptForInvoiceHeaders headers = new QueryReceiptForInvoiceHeaders();
            return await QueryReceiptForInvoiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量查询智能财务的单据主数据基本信息
         *
         * @param request QueryReceiptsBaseInfoRequest
         * @param headers QueryReceiptsBaseInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReceiptsBaseInfoResponse
         */
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

        /**
         * @summary 批量查询智能财务的单据主数据基本信息
         *
         * @param request QueryReceiptsBaseInfoRequest
         * @param headers QueryReceiptsBaseInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReceiptsBaseInfoResponse
         */
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

        /**
         * @summary 批量查询智能财务的单据主数据基本信息
         *
         * @param request QueryReceiptsBaseInfoRequest
         * @return QueryReceiptsBaseInfoResponse
         */
        public QueryReceiptsBaseInfoResponse QueryReceiptsBaseInfo(QueryReceiptsBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptsBaseInfoHeaders headers = new QueryReceiptsBaseInfoHeaders();
            return QueryReceiptsBaseInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量查询智能财务的单据主数据基本信息
         *
         * @param request QueryReceiptsBaseInfoRequest
         * @return QueryReceiptsBaseInfoResponse
         */
        public async Task<QueryReceiptsBaseInfoResponse> QueryReceiptsBaseInfoAsync(QueryReceiptsBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptsBaseInfoHeaders headers = new QueryReceiptsBaseInfoHeaders();
            return await QueryReceiptsBaseInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页获取智能财务单据详情列表
         *
         * @param request QueryReceiptsByPageRequest
         * @param headers QueryReceiptsByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReceiptsByPageResponse
         */
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

        /**
         * @summary 分页获取智能财务单据详情列表
         *
         * @param request QueryReceiptsByPageRequest
         * @param headers QueryReceiptsByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryReceiptsByPageResponse
         */
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

        /**
         * @summary 分页获取智能财务单据详情列表
         *
         * @param request QueryReceiptsByPageRequest
         * @return QueryReceiptsByPageResponse
         */
        public QueryReceiptsByPageResponse QueryReceiptsByPage(QueryReceiptsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptsByPageHeaders headers = new QueryReceiptsByPageHeaders();
            return QueryReceiptsByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页获取智能财务单据详情列表
         *
         * @param request QueryReceiptsByPageRequest
         * @return QueryReceiptsByPageResponse
         */
        public async Task<QueryReceiptsByPageResponse> QueryReceiptsByPageAsync(QueryReceiptsByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryReceiptsByPageHeaders headers = new QueryReceiptsByPageHeaders();
            return await QueryReceiptsByPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 分页查询智能财务角色下的成员信息
         *
         * @param request QueryRoleMemberByPageRequest
         * @param headers QueryRoleMemberByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRoleMemberByPageResponse
         */
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

        /**
         * @summary 分页查询智能财务角色下的成员信息
         *
         * @param request QueryRoleMemberByPageRequest
         * @param headers QueryRoleMemberByPageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRoleMemberByPageResponse
         */
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

        /**
         * @summary 分页查询智能财务角色下的成员信息
         *
         * @param request QueryRoleMemberByPageRequest
         * @return QueryRoleMemberByPageResponse
         */
        public QueryRoleMemberByPageResponse QueryRoleMemberByPage(QueryRoleMemberByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoleMemberByPageHeaders headers = new QueryRoleMemberByPageHeaders();
            return QueryRoleMemberByPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 分页查询智能财务角色下的成员信息
         *
         * @param request QueryRoleMemberByPageRequest
         * @return QueryRoleMemberByPageResponse
         */
        public async Task<QueryRoleMemberByPageResponse> QueryRoleMemberByPageAsync(QueryRoleMemberByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRoleMemberByPageHeaders headers = new QueryRoleMemberByPageHeaders();
            return await QueryRoleMemberByPageWithOptionsAsync(request, headers, runtime);
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
         * @summary 查询用户角色
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

        /**
         * @summary 查询用户角色
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

        /**
         * @summary 查询用户角色
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
         * @summary 查询用户角色
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
         * @summary 解绑开票申请单关联的发票
         *
         * @param request UnbindApplyReceiptAndInvoiceRelatedRequest
         * @param headers UnbindApplyReceiptAndInvoiceRelatedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindApplyReceiptAndInvoiceRelatedResponse
         */
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

        /**
         * @summary 解绑开票申请单关联的发票
         *
         * @param request UnbindApplyReceiptAndInvoiceRelatedRequest
         * @param headers UnbindApplyReceiptAndInvoiceRelatedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindApplyReceiptAndInvoiceRelatedResponse
         */
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

        /**
         * @summary 解绑开票申请单关联的发票
         *
         * @param request UnbindApplyReceiptAndInvoiceRelatedRequest
         * @return UnbindApplyReceiptAndInvoiceRelatedResponse
         */
        public UnbindApplyReceiptAndInvoiceRelatedResponse UnbindApplyReceiptAndInvoiceRelated(UnbindApplyReceiptAndInvoiceRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindApplyReceiptAndInvoiceRelatedHeaders headers = new UnbindApplyReceiptAndInvoiceRelatedHeaders();
            return UnbindApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime);
        }

        /**
         * @summary 解绑开票申请单关联的发票
         *
         * @param request UnbindApplyReceiptAndInvoiceRelatedRequest
         * @return UnbindApplyReceiptAndInvoiceRelatedResponse
         */
        public async Task<UnbindApplyReceiptAndInvoiceRelatedResponse> UnbindApplyReceiptAndInvoiceRelatedAsync(UnbindApplyReceiptAndInvoiceRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnbindApplyReceiptAndInvoiceRelatedHeaders headers = new UnbindApplyReceiptAndInvoiceRelatedHeaders();
            return await UnbindApplyReceiptAndInvoiceRelatedWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 开票申请单关联发票
         *
         * @param request UpdateApplyReceiptAndInvoiceRelatedRequest
         * @param headers UpdateApplyReceiptAndInvoiceRelatedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplyReceiptAndInvoiceRelatedResponse
         */
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

        /**
         * @summary 开票申请单关联发票
         *
         * @param request UpdateApplyReceiptAndInvoiceRelatedRequest
         * @param headers UpdateApplyReceiptAndInvoiceRelatedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplyReceiptAndInvoiceRelatedResponse
         */
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

        /**
         * @summary 开票申请单关联发票
         *
         * @param request UpdateApplyReceiptAndInvoiceRelatedRequest
         * @return UpdateApplyReceiptAndInvoiceRelatedResponse
         */
        public UpdateApplyReceiptAndInvoiceRelatedResponse UpdateApplyReceiptAndInvoiceRelated(UpdateApplyReceiptAndInvoiceRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateApplyReceiptAndInvoiceRelatedHeaders headers = new UpdateApplyReceiptAndInvoiceRelatedHeaders();
            return UpdateApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime);
        }

        /**
         * @summary 开票申请单关联发票
         *
         * @param request UpdateApplyReceiptAndInvoiceRelatedRequest
         * @return UpdateApplyReceiptAndInvoiceRelatedResponse
         */
        public async Task<UpdateApplyReceiptAndInvoiceRelatedResponse> UpdateApplyReceiptAndInvoiceRelatedAsync(UpdateApplyReceiptAndInvoiceRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateApplyReceiptAndInvoiceRelatedHeaders headers = new UpdateApplyReceiptAndInvoiceRelatedHeaders();
            return await UpdateApplyReceiptAndInvoiceRelatedWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新全电发票企业信息
         *
         * @param request UpdateDigitalInvoiceOrgInfoRequest
         * @param headers UpdateDigitalInvoiceOrgInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDigitalInvoiceOrgInfoResponse
         */
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

        /**
         * @summary 更新全电发票企业信息
         *
         * @param request UpdateDigitalInvoiceOrgInfoRequest
         * @param headers UpdateDigitalInvoiceOrgInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDigitalInvoiceOrgInfoResponse
         */
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

        /**
         * @summary 更新全电发票企业信息
         *
         * @param request UpdateDigitalInvoiceOrgInfoRequest
         * @return UpdateDigitalInvoiceOrgInfoResponse
         */
        public UpdateDigitalInvoiceOrgInfoResponse UpdateDigitalInvoiceOrgInfo(UpdateDigitalInvoiceOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDigitalInvoiceOrgInfoHeaders headers = new UpdateDigitalInvoiceOrgInfoHeaders();
            return UpdateDigitalInvoiceOrgInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新全电发票企业信息
         *
         * @param request UpdateDigitalInvoiceOrgInfoRequest
         * @return UpdateDigitalInvoiceOrgInfoResponse
         */
        public async Task<UpdateDigitalInvoiceOrgInfoResponse> UpdateDigitalInvoiceOrgInfoAsync(UpdateDigitalInvoiceOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDigitalInvoiceOrgInfoHeaders headers = new UpdateDigitalInvoiceOrgInfoHeaders();
            return await UpdateDigitalInvoiceOrgInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新智能财务配置的企业信息
         *
         * @param request UpdateFinanceCompanyInfoRequest
         * @param headers UpdateFinanceCompanyInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFinanceCompanyInfoResponse
         */
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

        /**
         * @summary 更新智能财务配置的企业信息
         *
         * @param request UpdateFinanceCompanyInfoRequest
         * @param headers UpdateFinanceCompanyInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFinanceCompanyInfoResponse
         */
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

        /**
         * @summary 更新智能财务配置的企业信息
         *
         * @param request UpdateFinanceCompanyInfoRequest
         * @return UpdateFinanceCompanyInfoResponse
         */
        public UpdateFinanceCompanyInfoResponse UpdateFinanceCompanyInfo(UpdateFinanceCompanyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFinanceCompanyInfoHeaders headers = new UpdateFinanceCompanyInfoHeaders();
            return UpdateFinanceCompanyInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新智能财务配置的企业信息
         *
         * @param request UpdateFinanceCompanyInfoRequest
         * @return UpdateFinanceCompanyInfoResponse
         */
        public async Task<UpdateFinanceCompanyInfoResponse> UpdateFinanceCompanyInfoAsync(UpdateFinanceCompanyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFinanceCompanyInfoHeaders headers = new UpdateFinanceCompanyInfoHeaders();
            return await UpdateFinanceCompanyInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新钉钉智能财务多主体信息
         *
         * @param request UpdateFinanceMultiCompanyInfoRequest
         * @param headers UpdateFinanceMultiCompanyInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFinanceMultiCompanyInfoResponse
         */
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

        /**
         * @summary 更新钉钉智能财务多主体信息
         *
         * @param request UpdateFinanceMultiCompanyInfoRequest
         * @param headers UpdateFinanceMultiCompanyInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFinanceMultiCompanyInfoResponse
         */
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

        /**
         * @summary 更新钉钉智能财务多主体信息
         *
         * @param request UpdateFinanceMultiCompanyInfoRequest
         * @return UpdateFinanceMultiCompanyInfoResponse
         */
        public UpdateFinanceMultiCompanyInfoResponse UpdateFinanceMultiCompanyInfo(UpdateFinanceMultiCompanyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFinanceMultiCompanyInfoHeaders headers = new UpdateFinanceMultiCompanyInfoHeaders();
            return UpdateFinanceMultiCompanyInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新钉钉智能财务多主体信息
         *
         * @param request UpdateFinanceMultiCompanyInfoRequest
         * @return UpdateFinanceMultiCompanyInfoResponse
         */
        public async Task<UpdateFinanceMultiCompanyInfoResponse> UpdateFinanceMultiCompanyInfoAsync(UpdateFinanceMultiCompanyInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateFinanceMultiCompanyInfoHeaders headers = new UpdateFinanceMultiCompanyInfoHeaders();
            return await UpdateFinanceMultiCompanyInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发票红冲/废弃状态变更接口
         *
         * @param request UpdateInvoiceAbandonStatusRequest
         * @param headers UpdateInvoiceAbandonStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceAbandonStatusResponse
         */
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

        /**
         * @summary 发票红冲/废弃状态变更接口
         *
         * @param request UpdateInvoiceAbandonStatusRequest
         * @param headers UpdateInvoiceAbandonStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceAbandonStatusResponse
         */
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

        /**
         * @summary 发票红冲/废弃状态变更接口
         *
         * @param request UpdateInvoiceAbandonStatusRequest
         * @return UpdateInvoiceAbandonStatusResponse
         */
        public UpdateInvoiceAbandonStatusResponse UpdateInvoiceAbandonStatus(UpdateInvoiceAbandonStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAbandonStatusHeaders headers = new UpdateInvoiceAbandonStatusHeaders();
            return UpdateInvoiceAbandonStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发票红冲/废弃状态变更接口
         *
         * @param request UpdateInvoiceAbandonStatusRequest
         * @return UpdateInvoiceAbandonStatusResponse
         */
        public async Task<UpdateInvoiceAbandonStatusResponse> UpdateInvoiceAbandonStatusAsync(UpdateInvoiceAbandonStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAbandonStatusHeaders headers = new UpdateInvoiceAbandonStatusHeaders();
            return await UpdateInvoiceAbandonStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新发票账期状态
         *
         * @param request UpdateInvoiceAccountPeriodRequest
         * @param headers UpdateInvoiceAccountPeriodHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceAccountPeriodResponse
         */
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

        /**
         * @summary 更新发票账期状态
         *
         * @param request UpdateInvoiceAccountPeriodRequest
         * @param headers UpdateInvoiceAccountPeriodHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceAccountPeriodResponse
         */
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

        /**
         * @summary 更新发票账期状态
         *
         * @param request UpdateInvoiceAccountPeriodRequest
         * @return UpdateInvoiceAccountPeriodResponse
         */
        public UpdateInvoiceAccountPeriodResponse UpdateInvoiceAccountPeriod(UpdateInvoiceAccountPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountPeriodHeaders headers = new UpdateInvoiceAccountPeriodHeaders();
            return UpdateInvoiceAccountPeriodWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新发票账期状态
         *
         * @param request UpdateInvoiceAccountPeriodRequest
         * @return UpdateInvoiceAccountPeriodResponse
         */
        public async Task<UpdateInvoiceAccountPeriodResponse> UpdateInvoiceAccountPeriodAsync(UpdateInvoiceAccountPeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountPeriodHeaders headers = new UpdateInvoiceAccountPeriodHeaders();
            return await UpdateInvoiceAccountPeriodWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新全电企业入账时间
         *
         * @param request UpdateInvoiceAccountingPeriodDateRequest
         * @param headers UpdateInvoiceAccountingPeriodDateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceAccountingPeriodDateResponse
         */
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

        /**
         * @summary 更新全电企业入账时间
         *
         * @param request UpdateInvoiceAccountingPeriodDateRequest
         * @param headers UpdateInvoiceAccountingPeriodDateHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceAccountingPeriodDateResponse
         */
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

        /**
         * @summary 更新全电企业入账时间
         *
         * @param request UpdateInvoiceAccountingPeriodDateRequest
         * @return UpdateInvoiceAccountingPeriodDateResponse
         */
        public UpdateInvoiceAccountingPeriodDateResponse UpdateInvoiceAccountingPeriodDate(UpdateInvoiceAccountingPeriodDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountingPeriodDateHeaders headers = new UpdateInvoiceAccountingPeriodDateHeaders();
            return UpdateInvoiceAccountingPeriodDateWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新全电企业入账时间
         *
         * @param request UpdateInvoiceAccountingPeriodDateRequest
         * @return UpdateInvoiceAccountingPeriodDateResponse
         */
        public async Task<UpdateInvoiceAccountingPeriodDateResponse> UpdateInvoiceAccountingPeriodDateAsync(UpdateInvoiceAccountingPeriodDateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountingPeriodDateHeaders headers = new UpdateInvoiceAccountingPeriodDateHeaders();
            return await UpdateInvoiceAccountingPeriodDateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新全电企业入账状态
         *
         * @param request UpdateInvoiceAccountingStatusRequest
         * @param headers UpdateInvoiceAccountingStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceAccountingStatusResponse
         */
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

        /**
         * @summary 更新全电企业入账状态
         *
         * @param request UpdateInvoiceAccountingStatusRequest
         * @param headers UpdateInvoiceAccountingStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceAccountingStatusResponse
         */
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

        /**
         * @summary 更新全电企业入账状态
         *
         * @param request UpdateInvoiceAccountingStatusRequest
         * @return UpdateInvoiceAccountingStatusResponse
         */
        public UpdateInvoiceAccountingStatusResponse UpdateInvoiceAccountingStatus(UpdateInvoiceAccountingStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountingStatusHeaders headers = new UpdateInvoiceAccountingStatusHeaders();
            return UpdateInvoiceAccountingStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新全电企业入账状态
         *
         * @param request UpdateInvoiceAccountingStatusRequest
         * @return UpdateInvoiceAccountingStatusResponse
         */
        public async Task<UpdateInvoiceAccountingStatusResponse> UpdateInvoiceAccountingStatusAsync(UpdateInvoiceAccountingStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAccountingStatusHeaders headers = new UpdateInvoiceAccountingStatusHeaders();
            return await UpdateInvoiceAccountingStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新发票关联审批单
         *
         * @param request UpdateInvoiceAndReceiptRelatedRequest
         * @param headers UpdateInvoiceAndReceiptRelatedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceAndReceiptRelatedResponse
         */
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

        /**
         * @summary 更新发票关联审批单
         *
         * @param request UpdateInvoiceAndReceiptRelatedRequest
         * @param headers UpdateInvoiceAndReceiptRelatedHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceAndReceiptRelatedResponse
         */
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

        /**
         * @summary 更新发票关联审批单
         *
         * @param request UpdateInvoiceAndReceiptRelatedRequest
         * @return UpdateInvoiceAndReceiptRelatedResponse
         */
        public UpdateInvoiceAndReceiptRelatedResponse UpdateInvoiceAndReceiptRelated(UpdateInvoiceAndReceiptRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAndReceiptRelatedHeaders headers = new UpdateInvoiceAndReceiptRelatedHeaders();
            return UpdateInvoiceAndReceiptRelatedWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新发票关联审批单
         *
         * @param request UpdateInvoiceAndReceiptRelatedRequest
         * @return UpdateInvoiceAndReceiptRelatedResponse
         */
        public async Task<UpdateInvoiceAndReceiptRelatedResponse> UpdateInvoiceAndReceiptRelatedAsync(UpdateInvoiceAndReceiptRelatedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceAndReceiptRelatedHeaders headers = new UpdateInvoiceAndReceiptRelatedHeaders();
            return await UpdateInvoiceAndReceiptRelatedWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新发票忽略状态
         *
         * @param request UpdateInvoiceIgnoreStatusRequest
         * @param headers UpdateInvoiceIgnoreStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceIgnoreStatusResponse
         */
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

        /**
         * @summary 更新发票忽略状态
         *
         * @param request UpdateInvoiceIgnoreStatusRequest
         * @param headers UpdateInvoiceIgnoreStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceIgnoreStatusResponse
         */
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

        /**
         * @summary 更新发票忽略状态
         *
         * @param request UpdateInvoiceIgnoreStatusRequest
         * @return UpdateInvoiceIgnoreStatusResponse
         */
        public UpdateInvoiceIgnoreStatusResponse UpdateInvoiceIgnoreStatus(UpdateInvoiceIgnoreStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceIgnoreStatusHeaders headers = new UpdateInvoiceIgnoreStatusHeaders();
            return UpdateInvoiceIgnoreStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新发票忽略状态
         *
         * @param request UpdateInvoiceIgnoreStatusRequest
         * @return UpdateInvoiceIgnoreStatusResponse
         */
        public async Task<UpdateInvoiceIgnoreStatusResponse> UpdateInvoiceIgnoreStatusAsync(UpdateInvoiceIgnoreStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceIgnoreStatusHeaders headers = new UpdateInvoiceIgnoreStatusHeaders();
            return await UpdateInvoiceIgnoreStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发票认证状态变更接口
         *
         * @param request UpdateInvoiceVerifyStatusRequest
         * @param headers UpdateInvoiceVerifyStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceVerifyStatusResponse
         */
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

        /**
         * @summary 发票认证状态变更接口
         *
         * @param request UpdateInvoiceVerifyStatusRequest
         * @param headers UpdateInvoiceVerifyStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceVerifyStatusResponse
         */
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

        /**
         * @summary 发票认证状态变更接口
         *
         * @param request UpdateInvoiceVerifyStatusRequest
         * @return UpdateInvoiceVerifyStatusResponse
         */
        public UpdateInvoiceVerifyStatusResponse UpdateInvoiceVerifyStatus(UpdateInvoiceVerifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVerifyStatusHeaders headers = new UpdateInvoiceVerifyStatusHeaders();
            return UpdateInvoiceVerifyStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发票认证状态变更接口
         *
         * @param request UpdateInvoiceVerifyStatusRequest
         * @return UpdateInvoiceVerifyStatusResponse
         */
        public async Task<UpdateInvoiceVerifyStatusResponse> UpdateInvoiceVerifyStatusAsync(UpdateInvoiceVerifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVerifyStatusHeaders headers = new UpdateInvoiceVerifyStatusHeaders();
            return await UpdateInvoiceVerifyStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新发票生成凭证状态
         *
         * @param request UpdateInvoiceVoucherStatusRequest
         * @param headers UpdateInvoiceVoucherStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceVoucherStatusResponse
         */
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

        /**
         * @summary 更新发票生成凭证状态
         *
         * @param request UpdateInvoiceVoucherStatusRequest
         * @param headers UpdateInvoiceVoucherStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceVoucherStatusResponse
         */
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

        /**
         * @summary 更新发票生成凭证状态
         *
         * @param request UpdateInvoiceVoucherStatusRequest
         * @return UpdateInvoiceVoucherStatusResponse
         */
        public UpdateInvoiceVoucherStatusResponse UpdateInvoiceVoucherStatus(UpdateInvoiceVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVoucherStatusHeaders headers = new UpdateInvoiceVoucherStatusHeaders();
            return UpdateInvoiceVoucherStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新发票生成凭证状态
         *
         * @param request UpdateInvoiceVoucherStatusRequest
         * @return UpdateInvoiceVoucherStatusResponse
         */
        public async Task<UpdateInvoiceVoucherStatusResponse> UpdateInvoiceVoucherStatusAsync(UpdateInvoiceVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVoucherStatusHeaders headers = new UpdateInvoiceVoucherStatusHeaders();
            return await UpdateInvoiceVoucherStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新智能财务单据
         *
         * @param request UpdateReceiptRequest
         * @param headers UpdateReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateReceiptResponse
         */
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

        /**
         * @summary 更新智能财务单据
         *
         * @param request UpdateReceiptRequest
         * @param headers UpdateReceiptHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateReceiptResponse
         */
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

        /**
         * @summary 更新智能财务单据
         *
         * @param request UpdateReceiptRequest
         * @return UpdateReceiptResponse
         */
        public UpdateReceiptResponse UpdateReceipt(UpdateReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateReceiptHeaders headers = new UpdateReceiptHeaders();
            return UpdateReceiptWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新智能财务单据
         *
         * @param request UpdateReceiptRequest
         * @return UpdateReceiptResponse
         */
        public async Task<UpdateReceiptResponse> UpdateReceiptAsync(UpdateReceiptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateReceiptHeaders headers = new UpdateReceiptHeaders();
            return await UpdateReceiptWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新智能财务审批单的凭证状态
         *
         * @param request UpdateReceiptVoucherStatusRequest
         * @param headers UpdateReceiptVoucherStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateReceiptVoucherStatusResponse
         */
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

        /**
         * @summary 更新智能财务审批单的凭证状态
         *
         * @param request UpdateReceiptVoucherStatusRequest
         * @param headers UpdateReceiptVoucherStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateReceiptVoucherStatusResponse
         */
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

        /**
         * @summary 更新智能财务审批单的凭证状态
         *
         * @param request UpdateReceiptVoucherStatusRequest
         * @return UpdateReceiptVoucherStatusResponse
         */
        public UpdateReceiptVoucherStatusResponse UpdateReceiptVoucherStatus(UpdateReceiptVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateReceiptVoucherStatusHeaders headers = new UpdateReceiptVoucherStatusHeaders();
            return UpdateReceiptVoucherStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新智能财务审批单的凭证状态
         *
         * @param request UpdateReceiptVoucherStatusRequest
         * @return UpdateReceiptVoucherStatusResponse
         */
        public async Task<UpdateReceiptVoucherStatusResponse> UpdateReceiptVoucherStatusAsync(UpdateReceiptVoucherStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateReceiptVoucherStatusHeaders headers = new UpdateReceiptVoucherStatusHeaders();
            return await UpdateReceiptVoucherStatusWithOptionsAsync(request, headers, runtime);
        }

    }
}
