# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.bizfinance_2_0 import models as dingtalkbizfinance__2__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def add_finance_enterprise_account_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountRequest,
        headers: dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountResponse:
        """
        @summary 新增智能财务的企业账户
        
        @param request: AddFinanceEnterpriseAccountRequest
        @param headers: AddFinanceEnterpriseAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddFinanceEnterpriseAccountResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_name):
            body['accountName'] = request.account_name
        if not UtilClient.is_unset(request.account_type):
            body['accountType'] = request.account_type
        if not UtilClient.is_unset(request.bank_card_no):
            body['bankCardNo'] = request.bank_card_no
        if not UtilClient.is_unset(request.bank_code):
            body['bankCode'] = request.bank_code
        if not UtilClient.is_unset(request.bank_name):
            body['bankName'] = request.bank_name
        if not UtilClient.is_unset(request.city):
            body['city'] = request.city
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.official_name):
            body['officialName'] = request.official_name
        if not UtilClient.is_unset(request.official_number):
            body['officialNumber'] = request.official_number
        if not UtilClient.is_unset(request.province):
            body['province'] = request.province
        if not UtilClient.is_unset(request.tax_nature):
            body['taxNature'] = request.tax_nature
        if not UtilClient.is_unset(request.tax_no):
            body['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddFinanceEnterpriseAccount',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/enterpriseAccounts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountResponse(),
            self.execute(params, req, runtime)
        )

    async def add_finance_enterprise_account_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountRequest,
        headers: dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountResponse:
        """
        @summary 新增智能财务的企业账户
        
        @param request: AddFinanceEnterpriseAccountRequest
        @param headers: AddFinanceEnterpriseAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddFinanceEnterpriseAccountResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_name):
            body['accountName'] = request.account_name
        if not UtilClient.is_unset(request.account_type):
            body['accountType'] = request.account_type
        if not UtilClient.is_unset(request.bank_card_no):
            body['bankCardNo'] = request.bank_card_no
        if not UtilClient.is_unset(request.bank_code):
            body['bankCode'] = request.bank_code
        if not UtilClient.is_unset(request.bank_name):
            body['bankName'] = request.bank_name
        if not UtilClient.is_unset(request.city):
            body['city'] = request.city
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.official_name):
            body['officialName'] = request.official_name
        if not UtilClient.is_unset(request.official_number):
            body['officialNumber'] = request.official_number
        if not UtilClient.is_unset(request.province):
            body['province'] = request.province
        if not UtilClient.is_unset(request.tax_nature):
            body['taxNature'] = request.tax_nature
        if not UtilClient.is_unset(request.tax_no):
            body['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddFinanceEnterpriseAccount',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/enterpriseAccounts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_finance_enterprise_account(
        self,
        request: dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountRequest,
    ) -> dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountResponse:
        """
        @summary 新增智能财务的企业账户
        
        @param request: AddFinanceEnterpriseAccountRequest
        @return: AddFinanceEnterpriseAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountHeaders()
        return self.add_finance_enterprise_account_with_options(request, headers, runtime)

    async def add_finance_enterprise_account_async(
        self,
        request: dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountRequest,
    ) -> dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountResponse:
        """
        @summary 新增智能财务的企业账户
        
        @param request: AddFinanceEnterpriseAccountRequest
        @return: AddFinanceEnterpriseAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.AddFinanceEnterpriseAccountHeaders()
        return await self.add_finance_enterprise_account_with_options_async(request, headers, runtime)

    def bank_gateway_invoke_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.BankGatewayInvokeRequest,
        headers: dingtalkbizfinance__2__0_models.BankGatewayInvokeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.BankGatewayInvokeResponse:
        """
        @summary 银行接入层通用接口
        
        @param request: BankGatewayInvokeRequest
        @param headers: BankGatewayInvokeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BankGatewayInvokeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.input_data):
            body['inputData'] = request.input_data
        if not UtilClient.is_unset(request.url):
            body['url'] = request.url
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BankGatewayInvoke',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/bankGateways/invoke',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.BankGatewayInvokeResponse(),
            self.execute(params, req, runtime)
        )

    async def bank_gateway_invoke_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.BankGatewayInvokeRequest,
        headers: dingtalkbizfinance__2__0_models.BankGatewayInvokeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.BankGatewayInvokeResponse:
        """
        @summary 银行接入层通用接口
        
        @param request: BankGatewayInvokeRequest
        @param headers: BankGatewayInvokeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BankGatewayInvokeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.input_data):
            body['inputData'] = request.input_data
        if not UtilClient.is_unset(request.url):
            body['url'] = request.url
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BankGatewayInvoke',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/bankGateways/invoke',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.BankGatewayInvokeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def bank_gateway_invoke(
        self,
        request: dingtalkbizfinance__2__0_models.BankGatewayInvokeRequest,
    ) -> dingtalkbizfinance__2__0_models.BankGatewayInvokeResponse:
        """
        @summary 银行接入层通用接口
        
        @param request: BankGatewayInvokeRequest
        @return: BankGatewayInvokeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BankGatewayInvokeHeaders()
        return self.bank_gateway_invoke_with_options(request, headers, runtime)

    async def bank_gateway_invoke_async(
        self,
        request: dingtalkbizfinance__2__0_models.BankGatewayInvokeRequest,
    ) -> dingtalkbizfinance__2__0_models.BankGatewayInvokeResponse:
        """
        @summary 银行接入层通用接口
        
        @param request: BankGatewayInvokeRequest
        @return: BankGatewayInvokeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BankGatewayInvokeHeaders()
        return await self.bank_gateway_invoke_with_options_async(request, headers, runtime)

    def batch_delete_receipt_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.BatchDeleteReceiptRequest,
        headers: dingtalkbizfinance__2__0_models.BatchDeleteReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.BatchDeleteReceiptResponse:
        """
        @summary 批量删除智能财务单据
        
        @param request: BatchDeleteReceiptRequest
        @param headers: BatchDeleteReceiptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchDeleteReceiptResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_id_list):
            body['instanceIdList'] = request.instance_id_list
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchDeleteReceipt',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/instances/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.BatchDeleteReceiptResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_delete_receipt_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.BatchDeleteReceiptRequest,
        headers: dingtalkbizfinance__2__0_models.BatchDeleteReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.BatchDeleteReceiptResponse:
        """
        @summary 批量删除智能财务单据
        
        @param request: BatchDeleteReceiptRequest
        @param headers: BatchDeleteReceiptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchDeleteReceiptResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_id_list):
            body['instanceIdList'] = request.instance_id_list
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchDeleteReceipt',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/instances/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.BatchDeleteReceiptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_delete_receipt(
        self,
        request: dingtalkbizfinance__2__0_models.BatchDeleteReceiptRequest,
    ) -> dingtalkbizfinance__2__0_models.BatchDeleteReceiptResponse:
        """
        @summary 批量删除智能财务单据
        
        @param request: BatchDeleteReceiptRequest
        @return: BatchDeleteReceiptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BatchDeleteReceiptHeaders()
        return self.batch_delete_receipt_with_options(request, headers, runtime)

    async def batch_delete_receipt_async(
        self,
        request: dingtalkbizfinance__2__0_models.BatchDeleteReceiptRequest,
    ) -> dingtalkbizfinance__2__0_models.BatchDeleteReceiptResponse:
        """
        @summary 批量删除智能财务单据
        
        @param request: BatchDeleteReceiptRequest
        @return: BatchDeleteReceiptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BatchDeleteReceiptHeaders()
        return await self.batch_delete_receipt_with_options_async(request, headers, runtime)

    def batch_query_org_invoice_url_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlRequest,
        headers: dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlResponse:
        """
        @summary 批量查询企业票池发票下载链接
        
        @param request: BatchQueryOrgInvoiceUrlRequest
        @param headers: BatchQueryOrgInvoiceUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryOrgInvoiceUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.invoice_key_volist):
            body['invoiceKeyVOList'] = request.invoice_key_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQueryOrgInvoiceUrl',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/urls/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_query_org_invoice_url_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlRequest,
        headers: dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlResponse:
        """
        @summary 批量查询企业票池发票下载链接
        
        @param request: BatchQueryOrgInvoiceUrlRequest
        @param headers: BatchQueryOrgInvoiceUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryOrgInvoiceUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.invoice_key_volist):
            body['invoiceKeyVOList'] = request.invoice_key_volist
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQueryOrgInvoiceUrl',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/urls/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_query_org_invoice_url(
        self,
        request: dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlRequest,
    ) -> dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlResponse:
        """
        @summary 批量查询企业票池发票下载链接
        
        @param request: BatchQueryOrgInvoiceUrlRequest
        @return: BatchQueryOrgInvoiceUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlHeaders()
        return self.batch_query_org_invoice_url_with_options(request, headers, runtime)

    async def batch_query_org_invoice_url_async(
        self,
        request: dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlRequest,
    ) -> dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlResponse:
        """
        @summary 批量查询企业票池发票下载链接
        
        @param request: BatchQueryOrgInvoiceUrlRequest
        @return: BatchQueryOrgInvoiceUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BatchQueryOrgInvoiceUrlHeaders()
        return await self.batch_query_org_invoice_url_with_options_async(request, headers, runtime)

    def batch_query_payment_recall_file_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileRequest,
        headers: dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileResponse:
        """
        @summary 批量查询支付回单文件
        
        @param request: BatchQueryPaymentRecallFileRequest
        @param headers: BatchQueryPaymentRecallFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryPaymentRecallFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail_id_list):
            body['detailIdList'] = request.detail_id_list
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQueryPaymentRecallFile',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/recallFiles/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_query_payment_recall_file_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileRequest,
        headers: dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileResponse:
        """
        @summary 批量查询支付回单文件
        
        @param request: BatchQueryPaymentRecallFileRequest
        @param headers: BatchQueryPaymentRecallFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryPaymentRecallFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail_id_list):
            body['detailIdList'] = request.detail_id_list
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQueryPaymentRecallFile',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/recallFiles/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_query_payment_recall_file(
        self,
        request: dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileRequest,
    ) -> dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileResponse:
        """
        @summary 批量查询支付回单文件
        
        @param request: BatchQueryPaymentRecallFileRequest
        @return: BatchQueryPaymentRecallFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileHeaders()
        return self.batch_query_payment_recall_file_with_options(request, headers, runtime)

    async def batch_query_payment_recall_file_async(
        self,
        request: dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileRequest,
    ) -> dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileResponse:
        """
        @summary 批量查询支付回单文件
        
        @param request: BatchQueryPaymentRecallFileRequest
        @return: BatchQueryPaymentRecallFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BatchQueryPaymentRecallFileHeaders()
        return await self.batch_query_payment_recall_file_with_options_async(request, headers, runtime)

    def batch_sync_bank_receipt_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.BatchSyncBankReceiptRequest,
        headers: dingtalkbizfinance__2__0_models.BatchSyncBankReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.BatchSyncBankReceiptResponse:
        """
        @summary 批量同步银行回单
        
        @param request: BatchSyncBankReceiptRequest
        @param headers: BatchSyncBankReceiptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchSyncBankReceiptResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='BatchSyncBankReceipt',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/receipts/batchSync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.BatchSyncBankReceiptResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_sync_bank_receipt_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.BatchSyncBankReceiptRequest,
        headers: dingtalkbizfinance__2__0_models.BatchSyncBankReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.BatchSyncBankReceiptResponse:
        """
        @summary 批量同步银行回单
        
        @param request: BatchSyncBankReceiptRequest
        @param headers: BatchSyncBankReceiptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchSyncBankReceiptResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='BatchSyncBankReceipt',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/receipts/batchSync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.BatchSyncBankReceiptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_sync_bank_receipt(
        self,
        request: dingtalkbizfinance__2__0_models.BatchSyncBankReceiptRequest,
    ) -> dingtalkbizfinance__2__0_models.BatchSyncBankReceiptResponse:
        """
        @summary 批量同步银行回单
        
        @param request: BatchSyncBankReceiptRequest
        @return: BatchSyncBankReceiptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BatchSyncBankReceiptHeaders()
        return self.batch_sync_bank_receipt_with_options(request, headers, runtime)

    async def batch_sync_bank_receipt_async(
        self,
        request: dingtalkbizfinance__2__0_models.BatchSyncBankReceiptRequest,
    ) -> dingtalkbizfinance__2__0_models.BatchSyncBankReceiptResponse:
        """
        @summary 批量同步银行回单
        
        @param request: BatchSyncBankReceiptRequest
        @return: BatchSyncBankReceiptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BatchSyncBankReceiptHeaders()
        return await self.batch_sync_bank_receipt_with_options_async(request, headers, runtime)

    def check_voucher_status_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.CheckVoucherStatusRequest,
        headers: dingtalkbizfinance__2__0_models.CheckVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.CheckVoucherStatusResponse:
        """
        @summary 查验发票是否生成凭证
        
        @param request: CheckVoucherStatusRequest
        @param headers: CheckVoucherStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckVoucherStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.finance_type):
            body['financeType'] = request.finance_type
        if not UtilClient.is_unset(request.invoice_code):
            body['invoiceCode'] = request.invoice_code
        if not UtilClient.is_unset(request.invoice_no):
            body['invoiceNo'] = request.invoice_no
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.tax_no):
            body['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.verify_status):
            body['verifyStatus'] = request.verify_status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CheckVoucherStatus',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/checkVoucherStatus/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.CheckVoucherStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def check_voucher_status_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.CheckVoucherStatusRequest,
        headers: dingtalkbizfinance__2__0_models.CheckVoucherStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.CheckVoucherStatusResponse:
        """
        @summary 查验发票是否生成凭证
        
        @param request: CheckVoucherStatusRequest
        @param headers: CheckVoucherStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckVoucherStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.finance_type):
            body['financeType'] = request.finance_type
        if not UtilClient.is_unset(request.invoice_code):
            body['invoiceCode'] = request.invoice_code
        if not UtilClient.is_unset(request.invoice_no):
            body['invoiceNo'] = request.invoice_no
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.tax_no):
            body['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.verify_status):
            body['verifyStatus'] = request.verify_status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CheckVoucherStatus',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/checkVoucherStatus/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.CheckVoucherStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_voucher_status(
        self,
        request: dingtalkbizfinance__2__0_models.CheckVoucherStatusRequest,
    ) -> dingtalkbizfinance__2__0_models.CheckVoucherStatusResponse:
        """
        @summary 查验发票是否生成凭证
        
        @param request: CheckVoucherStatusRequest
        @return: CheckVoucherStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.CheckVoucherStatusHeaders()
        return self.check_voucher_status_with_options(request, headers, runtime)

    async def check_voucher_status_async(
        self,
        request: dingtalkbizfinance__2__0_models.CheckVoucherStatusRequest,
    ) -> dingtalkbizfinance__2__0_models.CheckVoucherStatusResponse:
        """
        @summary 查验发票是否生成凭证
        
        @param request: CheckVoucherStatusRequest
        @return: CheckVoucherStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.CheckVoucherStatusHeaders()
        return await self.check_voucher_status_with_options_async(request, headers, runtime)

    def confirm_payment_order_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.ConfirmPaymentOrderRequest,
        headers: dingtalkbizfinance__2__0_models.ConfirmPaymentOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.ConfirmPaymentOrderResponse:
        """
        @summary 获取唤起智能财务收银台的地址
        
        @param request: ConfirmPaymentOrderRequest
        @param headers: ConfirmPaymentOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConfirmPaymentOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_biz_no_list):
            body['outBizNoList'] = request.out_biz_no_list
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ConfirmPaymentOrder',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/confirm',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.ConfirmPaymentOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def confirm_payment_order_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.ConfirmPaymentOrderRequest,
        headers: dingtalkbizfinance__2__0_models.ConfirmPaymentOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.ConfirmPaymentOrderResponse:
        """
        @summary 获取唤起智能财务收银台的地址
        
        @param request: ConfirmPaymentOrderRequest
        @param headers: ConfirmPaymentOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConfirmPaymentOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.out_biz_no_list):
            body['outBizNoList'] = request.out_biz_no_list
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ConfirmPaymentOrder',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/confirm',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.ConfirmPaymentOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def confirm_payment_order(
        self,
        request: dingtalkbizfinance__2__0_models.ConfirmPaymentOrderRequest,
    ) -> dingtalkbizfinance__2__0_models.ConfirmPaymentOrderResponse:
        """
        @summary 获取唤起智能财务收银台的地址
        
        @param request: ConfirmPaymentOrderRequest
        @return: ConfirmPaymentOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.ConfirmPaymentOrderHeaders()
        return self.confirm_payment_order_with_options(request, headers, runtime)

    async def confirm_payment_order_async(
        self,
        request: dingtalkbizfinance__2__0_models.ConfirmPaymentOrderRequest,
    ) -> dingtalkbizfinance__2__0_models.ConfirmPaymentOrderResponse:
        """
        @summary 获取唤起智能财务收银台的地址
        
        @param request: ConfirmPaymentOrderRequest
        @return: ConfirmPaymentOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.ConfirmPaymentOrderHeaders()
        return await self.confirm_payment_order_with_options_async(request, headers, runtime)

    def create_collection_order_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.CreateCollectionOrderRequest,
        headers: dingtalkbizfinance__2__0_models.CreateCollectionOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.CreateCollectionOrderResponse:
        """
        @summary 创建收款订单
        
        @param request: CreateCollectionOrderRequest
        @param headers: CreateCollectionOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCollectionOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.amount):
            query['amount'] = request.amount
        if not UtilClient.is_unset(request.collection_info_id):
            query['collectionInfoId'] = request.collection_info_id
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.remark):
            query['remark'] = request.remark
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CreateCollectionOrder',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/me/collections/orders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.CreateCollectionOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def create_collection_order_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.CreateCollectionOrderRequest,
        headers: dingtalkbizfinance__2__0_models.CreateCollectionOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.CreateCollectionOrderResponse:
        """
        @summary 创建收款订单
        
        @param request: CreateCollectionOrderRequest
        @param headers: CreateCollectionOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCollectionOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.amount):
            query['amount'] = request.amount
        if not UtilClient.is_unset(request.collection_info_id):
            query['collectionInfoId'] = request.collection_info_id
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.remark):
            query['remark'] = request.remark
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CreateCollectionOrder',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/me/collections/orders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.CreateCollectionOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_collection_order(
        self,
        request: dingtalkbizfinance__2__0_models.CreateCollectionOrderRequest,
    ) -> dingtalkbizfinance__2__0_models.CreateCollectionOrderResponse:
        """
        @summary 创建收款订单
        
        @param request: CreateCollectionOrderRequest
        @return: CreateCollectionOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.CreateCollectionOrderHeaders()
        return self.create_collection_order_with_options(request, headers, runtime)

    async def create_collection_order_async(
        self,
        request: dingtalkbizfinance__2__0_models.CreateCollectionOrderRequest,
    ) -> dingtalkbizfinance__2__0_models.CreateCollectionOrderResponse:
        """
        @summary 创建收款订单
        
        @param request: CreateCollectionOrderRequest
        @return: CreateCollectionOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.CreateCollectionOrderHeaders()
        return await self.create_collection_order_with_options_async(request, headers, runtime)

    def create_payment_order_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.CreatePaymentOrderRequest,
        headers: dingtalkbizfinance__2__0_models.CreatePaymentOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.CreatePaymentOrderResponse:
        """
        @summary 创建智能财务待支付订单
        
        @param request: CreatePaymentOrderRequest
        @param headers: CreatePaymentOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreatePaymentOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.amount):
            body['amount'] = request.amount
        if not UtilClient.is_unset(request.expire_time):
            body['expireTime'] = request.expire_time
        if not UtilClient.is_unset(request.out_biz_no):
            body['outBizNo'] = request.out_biz_no
        if not UtilClient.is_unset(request.payee_account_dto):
            body['payeeAccountDTO'] = request.payee_account_dto
        if not UtilClient.is_unset(request.payer_account_dto):
            body['payerAccountDTO'] = request.payer_account_dto
        if not UtilClient.is_unset(request.payment_order_title):
            body['paymentOrderTitle'] = request.payment_order_title
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.usage):
            body['usage'] = request.usage
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreatePaymentOrder',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/orders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.CreatePaymentOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def create_payment_order_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.CreatePaymentOrderRequest,
        headers: dingtalkbizfinance__2__0_models.CreatePaymentOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.CreatePaymentOrderResponse:
        """
        @summary 创建智能财务待支付订单
        
        @param request: CreatePaymentOrderRequest
        @param headers: CreatePaymentOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreatePaymentOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.amount):
            body['amount'] = request.amount
        if not UtilClient.is_unset(request.expire_time):
            body['expireTime'] = request.expire_time
        if not UtilClient.is_unset(request.out_biz_no):
            body['outBizNo'] = request.out_biz_no
        if not UtilClient.is_unset(request.payee_account_dto):
            body['payeeAccountDTO'] = request.payee_account_dto
        if not UtilClient.is_unset(request.payer_account_dto):
            body['payerAccountDTO'] = request.payer_account_dto
        if not UtilClient.is_unset(request.payment_order_title):
            body['paymentOrderTitle'] = request.payment_order_title
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.usage):
            body['usage'] = request.usage
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreatePaymentOrder',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/orders',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.CreatePaymentOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_payment_order(
        self,
        request: dingtalkbizfinance__2__0_models.CreatePaymentOrderRequest,
    ) -> dingtalkbizfinance__2__0_models.CreatePaymentOrderResponse:
        """
        @summary 创建智能财务待支付订单
        
        @param request: CreatePaymentOrderRequest
        @return: CreatePaymentOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.CreatePaymentOrderHeaders()
        return self.create_payment_order_with_options(request, headers, runtime)

    async def create_payment_order_async(
        self,
        request: dingtalkbizfinance__2__0_models.CreatePaymentOrderRequest,
    ) -> dingtalkbizfinance__2__0_models.CreatePaymentOrderResponse:
        """
        @summary 创建智能财务待支付订单
        
        @param request: CreatePaymentOrderRequest
        @return: CreatePaymentOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.CreatePaymentOrderHeaders()
        return await self.create_payment_order_with_options_async(request, headers, runtime)

    def get_category_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.GetCategoryRequest,
        headers: dingtalkbizfinance__2__0_models.GetCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetCategoryResponse:
        """
        @summary 获取费用类别
        
        @param request: GetCategoryRequest
        @param headers: GetCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCategoryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetCategory',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/categories',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetCategoryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_category_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetCategoryRequest,
        headers: dingtalkbizfinance__2__0_models.GetCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetCategoryResponse:
        """
        @summary 获取费用类别
        
        @param request: GetCategoryRequest
        @param headers: GetCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCategoryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetCategory',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/categories',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetCategoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_category(
        self,
        request: dingtalkbizfinance__2__0_models.GetCategoryRequest,
    ) -> dingtalkbizfinance__2__0_models.GetCategoryResponse:
        """
        @summary 获取费用类别
        
        @param request: GetCategoryRequest
        @return: GetCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetCategoryHeaders()
        return self.get_category_with_options(request, headers, runtime)

    async def get_category_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetCategoryRequest,
    ) -> dingtalkbizfinance__2__0_models.GetCategoryResponse:
        """
        @summary 获取费用类别
        
        @param request: GetCategoryRequest
        @return: GetCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetCategoryHeaders()
        return await self.get_category_with_options_async(request, headers, runtime)

    def get_define_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.GetDefineRequest,
        headers: dingtalkbizfinance__2__0_models.GetDefineHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetDefineResponse:
        """
        @summary 查询企业内自定义辅助档案信息
        
        @param request: GetDefineRequest
        @param headers: GetDefineHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDefineResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetDefine',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/customInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetDefineResponse(),
            self.execute(params, req, runtime)
        )

    async def get_define_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetDefineRequest,
        headers: dingtalkbizfinance__2__0_models.GetDefineHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetDefineResponse:
        """
        @summary 查询企业内自定义辅助档案信息
        
        @param request: GetDefineRequest
        @param headers: GetDefineHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDefineResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetDefine',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/customInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetDefineResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_define(
        self,
        request: dingtalkbizfinance__2__0_models.GetDefineRequest,
    ) -> dingtalkbizfinance__2__0_models.GetDefineResponse:
        """
        @summary 查询企业内自定义辅助档案信息
        
        @param request: GetDefineRequest
        @return: GetDefineResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetDefineHeaders()
        return self.get_define_with_options(request, headers, runtime)

    async def get_define_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetDefineRequest,
    ) -> dingtalkbizfinance__2__0_models.GetDefineResponse:
        """
        @summary 查询企业内自定义辅助档案信息
        
        @param request: GetDefineRequest
        @return: GetDefineResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetDefineHeaders()
        return await self.get_define_with_options_async(request, headers, runtime)

    def get_define_data_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.GetDefineDataRequest,
        headers: dingtalkbizfinance__2__0_models.GetDefineDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetDefineDataResponse:
        """
        @summary 查询企业内自定义辅助档案数据信息
        
        @param request: GetDefineDataRequest
        @param headers: GetDefineDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDefineDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetDefineData',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/customDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetDefineDataResponse(),
            self.execute(params, req, runtime)
        )

    async def get_define_data_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetDefineDataRequest,
        headers: dingtalkbizfinance__2__0_models.GetDefineDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetDefineDataResponse:
        """
        @summary 查询企业内自定义辅助档案数据信息
        
        @param request: GetDefineDataRequest
        @param headers: GetDefineDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDefineDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetDefineData',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/customDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetDefineDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_define_data(
        self,
        request: dingtalkbizfinance__2__0_models.GetDefineDataRequest,
    ) -> dingtalkbizfinance__2__0_models.GetDefineDataResponse:
        """
        @summary 查询企业内自定义辅助档案数据信息
        
        @param request: GetDefineDataRequest
        @return: GetDefineDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetDefineDataHeaders()
        return self.get_define_data_with_options(request, headers, runtime)

    async def get_define_data_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetDefineDataRequest,
    ) -> dingtalkbizfinance__2__0_models.GetDefineDataResponse:
        """
        @summary 查询企业内自定义辅助档案数据信息
        
        @param request: GetDefineDataRequest
        @return: GetDefineDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetDefineDataHeaders()
        return await self.get_define_data_with_options_async(request, headers, runtime)

    def get_finance_account_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.GetFinanceAccountRequest,
        headers: dingtalkbizfinance__2__0_models.GetFinanceAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetFinanceAccountResponse:
        """
        @summary 获取企业账户
        
        @param request: GetFinanceAccountRequest
        @param headers: GetFinanceAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFinanceAccountResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_code):
            query['accountCode'] = request.account_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetFinanceAccount',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/financeAccounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetFinanceAccountResponse(),
            self.execute(params, req, runtime)
        )

    async def get_finance_account_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetFinanceAccountRequest,
        headers: dingtalkbizfinance__2__0_models.GetFinanceAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetFinanceAccountResponse:
        """
        @summary 获取企业账户
        
        @param request: GetFinanceAccountRequest
        @param headers: GetFinanceAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFinanceAccountResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_code):
            query['accountCode'] = request.account_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetFinanceAccount',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/financeAccounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetFinanceAccountResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_finance_account(
        self,
        request: dingtalkbizfinance__2__0_models.GetFinanceAccountRequest,
    ) -> dingtalkbizfinance__2__0_models.GetFinanceAccountResponse:
        """
        @summary 获取企业账户
        
        @param request: GetFinanceAccountRequest
        @return: GetFinanceAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetFinanceAccountHeaders()
        return self.get_finance_account_with_options(request, headers, runtime)

    async def get_finance_account_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetFinanceAccountRequest,
    ) -> dingtalkbizfinance__2__0_models.GetFinanceAccountResponse:
        """
        @summary 获取企业账户
        
        @param request: GetFinanceAccountRequest
        @return: GetFinanceAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetFinanceAccountHeaders()
        return await self.get_finance_account_with_options_async(request, headers, runtime)

    def get_project_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.GetProjectRequest,
        headers: dingtalkbizfinance__2__0_models.GetProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetProjectResponse:
        """
        @summary 获取单条项目
        
        @param request: GetProjectRequest
        @param headers: GetProjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProjectResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetProject',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/projects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetProjectResponse(),
            self.execute(params, req, runtime)
        )

    async def get_project_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetProjectRequest,
        headers: dingtalkbizfinance__2__0_models.GetProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetProjectResponse:
        """
        @summary 获取单条项目
        
        @param request: GetProjectRequest
        @param headers: GetProjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetProjectResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetProject',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/projects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetProjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_project(
        self,
        request: dingtalkbizfinance__2__0_models.GetProjectRequest,
    ) -> dingtalkbizfinance__2__0_models.GetProjectResponse:
        """
        @summary 获取单条项目
        
        @param request: GetProjectRequest
        @return: GetProjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetProjectHeaders()
        return self.get_project_with_options(request, headers, runtime)

    async def get_project_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetProjectRequest,
    ) -> dingtalkbizfinance__2__0_models.GetProjectResponse:
        """
        @summary 获取单条项目
        
        @param request: GetProjectRequest
        @return: GetProjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetProjectHeaders()
        return await self.get_project_with_options_async(request, headers, runtime)

    def get_receipt_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.GetReceiptRequest,
        headers: dingtalkbizfinance__2__0_models.GetReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetReceiptResponse:
        """
        @summary 获取智能财务单据详情
        
        @param request: GetReceiptRequest
        @param headers: GetReceiptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetReceiptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.business_id):
            query['businessId'] = request.business_id
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.model_id):
            query['modelId'] = request.model_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetReceipt',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/receipts/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetReceiptResponse(),
            self.execute(params, req, runtime)
        )

    async def get_receipt_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetReceiptRequest,
        headers: dingtalkbizfinance__2__0_models.GetReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetReceiptResponse:
        """
        @summary 获取智能财务单据详情
        
        @param request: GetReceiptRequest
        @param headers: GetReceiptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetReceiptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.business_id):
            query['businessId'] = request.business_id
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.model_id):
            query['modelId'] = request.model_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetReceipt',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/receipts/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetReceiptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_receipt(
        self,
        request: dingtalkbizfinance__2__0_models.GetReceiptRequest,
    ) -> dingtalkbizfinance__2__0_models.GetReceiptResponse:
        """
        @summary 获取智能财务单据详情
        
        @param request: GetReceiptRequest
        @return: GetReceiptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetReceiptHeaders()
        return self.get_receipt_with_options(request, headers, runtime)

    async def get_receipt_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetReceiptRequest,
    ) -> dingtalkbizfinance__2__0_models.GetReceiptResponse:
        """
        @summary 获取智能财务单据详情
        
        @param request: GetReceiptRequest
        @return: GetReceiptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetReceiptHeaders()
        return await self.get_receipt_with_options_async(request, headers, runtime)

    def get_supplier_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.GetSupplierRequest,
        headers: dingtalkbizfinance__2__0_models.GetSupplierHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetSupplierResponse:
        """
        @summary 获取智能财务应用内维护的供应商信息
        
        @param request: GetSupplierRequest
        @param headers: GetSupplierHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSupplierResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetSupplier',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/suppliers/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetSupplierResponse(),
            self.execute(params, req, runtime)
        )

    async def get_supplier_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetSupplierRequest,
        headers: dingtalkbizfinance__2__0_models.GetSupplierHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetSupplierResponse:
        """
        @summary 获取智能财务应用内维护的供应商信息
        
        @param request: GetSupplierRequest
        @param headers: GetSupplierHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSupplierResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetSupplier',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/suppliers/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.GetSupplierResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_supplier(
        self,
        request: dingtalkbizfinance__2__0_models.GetSupplierRequest,
    ) -> dingtalkbizfinance__2__0_models.GetSupplierResponse:
        """
        @summary 获取智能财务应用内维护的供应商信息
        
        @param request: GetSupplierRequest
        @return: GetSupplierResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetSupplierHeaders()
        return self.get_supplier_with_options(request, headers, runtime)

    async def get_supplier_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetSupplierRequest,
    ) -> dingtalkbizfinance__2__0_models.GetSupplierResponse:
        """
        @summary 获取智能财务应用内维护的供应商信息
        
        @param request: GetSupplierRequest
        @return: GetSupplierResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetSupplierHeaders()
        return await self.get_supplier_with_options_async(request, headers, runtime)

    def issue_invoice_with_order_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderRequest,
        headers: dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderResponse:
        """
        @summary 订单开票
        
        @param request: IssueInvoiceWithOrderRequest
        @param headers: IssueInvoiceWithOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IssueInvoiceWithOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.finance_app_key):
            body['financeAppKey'] = request.finance_app_key
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='IssueInvoiceWithOrder',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/issueInvoices/order',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def issue_invoice_with_order_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderRequest,
        headers: dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderResponse:
        """
        @summary 订单开票
        
        @param request: IssueInvoiceWithOrderRequest
        @param headers: IssueInvoiceWithOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IssueInvoiceWithOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.finance_app_key):
            body['financeAppKey'] = request.finance_app_key
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='IssueInvoiceWithOrder',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/issueInvoices/order',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def issue_invoice_with_order(
        self,
        request: dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderRequest,
    ) -> dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderResponse:
        """
        @summary 订单开票
        
        @param request: IssueInvoiceWithOrderRequest
        @return: IssueInvoiceWithOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderHeaders()
        return self.issue_invoice_with_order_with_options(request, headers, runtime)

    async def issue_invoice_with_order_async(
        self,
        request: dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderRequest,
    ) -> dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderResponse:
        """
        @summary 订单开票
        
        @param request: IssueInvoiceWithOrderRequest
        @return: IssueInvoiceWithOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.IssueInvoiceWithOrderHeaders()
        return await self.issue_invoice_with_order_with_options_async(request, headers, runtime)

    def link_common_invoke_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.LinkCommonInvokeRequest,
        headers: dingtalkbizfinance__2__0_models.LinkCommonInvokeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.LinkCommonInvokeResponse:
        """
        @summary 根据不同的bizType查询不同的数据
        
        @param request: LinkCommonInvokeRequest
        @param headers: LinkCommonInvokeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LinkCommonInvokeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.invoke_id):
            body['invokeId'] = request.invoke_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='LinkCommonInvoke',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/link/bizTypes/invoke',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.LinkCommonInvokeResponse(),
            self.execute(params, req, runtime)
        )

    async def link_common_invoke_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.LinkCommonInvokeRequest,
        headers: dingtalkbizfinance__2__0_models.LinkCommonInvokeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.LinkCommonInvokeResponse:
        """
        @summary 根据不同的bizType查询不同的数据
        
        @param request: LinkCommonInvokeRequest
        @param headers: LinkCommonInvokeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LinkCommonInvokeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.invoke_id):
            body['invokeId'] = request.invoke_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='LinkCommonInvoke',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/link/bizTypes/invoke',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.LinkCommonInvokeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def link_common_invoke(
        self,
        request: dingtalkbizfinance__2__0_models.LinkCommonInvokeRequest,
    ) -> dingtalkbizfinance__2__0_models.LinkCommonInvokeResponse:
        """
        @summary 根据不同的bizType查询不同的数据
        
        @param request: LinkCommonInvokeRequest
        @return: LinkCommonInvokeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.LinkCommonInvokeHeaders()
        return self.link_common_invoke_with_options(request, headers, runtime)

    async def link_common_invoke_async(
        self,
        request: dingtalkbizfinance__2__0_models.LinkCommonInvokeRequest,
    ) -> dingtalkbizfinance__2__0_models.LinkCommonInvokeResponse:
        """
        @summary 根据不同的bizType查询不同的数据
        
        @param request: LinkCommonInvokeRequest
        @return: LinkCommonInvokeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.LinkCommonInvokeHeaders()
        return await self.link_common_invoke_with_options_async(request, headers, runtime)

    def order_billing_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.OrderBillingRequest,
        headers: dingtalkbizfinance__2__0_models.OrderBillingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.OrderBillingResponse:
        """
        @summary 订单开票
        
        @param request: OrderBillingRequest
        @param headers: OrderBillingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OrderBillingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.addition_infos):
            body['additionInfos'] = request.addition_infos
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.apply_person):
            body['applyPerson'] = request.apply_person
        if not UtilClient.is_unset(request.invoice_remark):
            body['invoiceRemark'] = request.invoice_remark
        if not UtilClient.is_unset(request.invoice_type):
            body['invoiceType'] = request.invoice_type
        if not UtilClient.is_unset(request.is_natural_person):
            body['isNaturalPerson'] = request.is_natural_person
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.payee):
            body['payee'] = request.payee
        if not UtilClient.is_unset(request.phone):
            body['phone'] = request.phone
        if not UtilClient.is_unset(request.products):
            body['products'] = request.products
        if not UtilClient.is_unset(request.purchaser_address):
            body['purchaserAddress'] = request.purchaser_address
        if not UtilClient.is_unset(request.purchaser_bank_account):
            body['purchaserBankAccount'] = request.purchaser_bank_account
        if not UtilClient.is_unset(request.purchaser_bank_name):
            body['purchaserBankName'] = request.purchaser_bank_name
        if not UtilClient.is_unset(request.purchaser_name):
            body['purchaserName'] = request.purchaser_name
        if not UtilClient.is_unset(request.purchaser_tax_no):
            body['purchaserTaxNo'] = request.purchaser_tax_no
        if not UtilClient.is_unset(request.purchaser_tel):
            body['purchaserTel'] = request.purchaser_tel
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.reviewer):
            body['reviewer'] = request.reviewer
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.tax_sign):
            body['taxSign'] = request.tax_sign
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='OrderBilling',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/billings/order',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.OrderBillingResponse(),
            self.execute(params, req, runtime)
        )

    async def order_billing_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.OrderBillingRequest,
        headers: dingtalkbizfinance__2__0_models.OrderBillingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.OrderBillingResponse:
        """
        @summary 订单开票
        
        @param request: OrderBillingRequest
        @param headers: OrderBillingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OrderBillingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.addition_infos):
            body['additionInfos'] = request.addition_infos
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.apply_person):
            body['applyPerson'] = request.apply_person
        if not UtilClient.is_unset(request.invoice_remark):
            body['invoiceRemark'] = request.invoice_remark
        if not UtilClient.is_unset(request.invoice_type):
            body['invoiceType'] = request.invoice_type
        if not UtilClient.is_unset(request.is_natural_person):
            body['isNaturalPerson'] = request.is_natural_person
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.payee):
            body['payee'] = request.payee
        if not UtilClient.is_unset(request.phone):
            body['phone'] = request.phone
        if not UtilClient.is_unset(request.products):
            body['products'] = request.products
        if not UtilClient.is_unset(request.purchaser_address):
            body['purchaserAddress'] = request.purchaser_address
        if not UtilClient.is_unset(request.purchaser_bank_account):
            body['purchaserBankAccount'] = request.purchaser_bank_account
        if not UtilClient.is_unset(request.purchaser_bank_name):
            body['purchaserBankName'] = request.purchaser_bank_name
        if not UtilClient.is_unset(request.purchaser_name):
            body['purchaserName'] = request.purchaser_name
        if not UtilClient.is_unset(request.purchaser_tax_no):
            body['purchaserTaxNo'] = request.purchaser_tax_no
        if not UtilClient.is_unset(request.purchaser_tel):
            body['purchaserTel'] = request.purchaser_tel
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.reviewer):
            body['reviewer'] = request.reviewer
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.tax_sign):
            body['taxSign'] = request.tax_sign
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='OrderBilling',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/billings/order',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.OrderBillingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def order_billing(
        self,
        request: dingtalkbizfinance__2__0_models.OrderBillingRequest,
    ) -> dingtalkbizfinance__2__0_models.OrderBillingResponse:
        """
        @summary 订单开票
        
        @param request: OrderBillingRequest
        @return: OrderBillingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.OrderBillingHeaders()
        return self.order_billing_with_options(request, headers, runtime)

    async def order_billing_async(
        self,
        request: dingtalkbizfinance__2__0_models.OrderBillingRequest,
    ) -> dingtalkbizfinance__2__0_models.OrderBillingResponse:
        """
        @summary 订单开票
        
        @param request: OrderBillingRequest
        @return: OrderBillingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.OrderBillingHeaders()
        return await self.order_billing_with_options_async(request, headers, runtime)

    def query_account_trade_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryAccountTradeByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryAccountTradeByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryAccountTradeByPageResponse:
        """
        @summary 分页查询账户的银行交易流水
        
        @param request: QueryAccountTradeByPageRequest
        @param headers: QueryAccountTradeByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAccountTradeByPageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.filter):
            body['filter'] = request.filter
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryAccountTradeByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/trades/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryAccountTradeByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_account_trade_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryAccountTradeByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryAccountTradeByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryAccountTradeByPageResponse:
        """
        @summary 分页查询账户的银行交易流水
        
        @param request: QueryAccountTradeByPageRequest
        @param headers: QueryAccountTradeByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAccountTradeByPageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_id):
            body['accountId'] = request.account_id
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.filter):
            body['filter'] = request.filter
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryAccountTradeByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/trades/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryAccountTradeByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_account_trade_by_page(
        self,
        request: dingtalkbizfinance__2__0_models.QueryAccountTradeByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryAccountTradeByPageResponse:
        """
        @summary 分页查询账户的银行交易流水
        
        @param request: QueryAccountTradeByPageRequest
        @return: QueryAccountTradeByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryAccountTradeByPageHeaders()
        return self.query_account_trade_by_page_with_options(request, headers, runtime)

    async def query_account_trade_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryAccountTradeByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryAccountTradeByPageResponse:
        """
        @summary 分页查询账户的银行交易流水
        
        @param request: QueryAccountTradeByPageRequest
        @return: QueryAccountTradeByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryAccountTradeByPageHeaders()
        return await self.query_account_trade_by_page_with_options_async(request, headers, runtime)

    def query_alipay_user_id_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryAlipayUserIdRequest,
        headers: dingtalkbizfinance__2__0_models.QueryAlipayUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryAlipayUserIdResponse:
        """
        @summary 根据staffId批量查询返回支付宝userId
        
        @param request: QueryAlipayUserIdRequest
        @param headers: QueryAlipayUserIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAlipayUserIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_user_ids):
            body['dingUserIds'] = request.ding_user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryAlipayUserId',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/consumption/aliPay/getUserId',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryAlipayUserIdResponse(),
            self.execute(params, req, runtime)
        )

    async def query_alipay_user_id_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryAlipayUserIdRequest,
        headers: dingtalkbizfinance__2__0_models.QueryAlipayUserIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryAlipayUserIdResponse:
        """
        @summary 根据staffId批量查询返回支付宝userId
        
        @param request: QueryAlipayUserIdRequest
        @param headers: QueryAlipayUserIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAlipayUserIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_user_ids):
            body['dingUserIds'] = request.ding_user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryAlipayUserId',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/consumption/aliPay/getUserId',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryAlipayUserIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_alipay_user_id(
        self,
        request: dingtalkbizfinance__2__0_models.QueryAlipayUserIdRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryAlipayUserIdResponse:
        """
        @summary 根据staffId批量查询返回支付宝userId
        
        @param request: QueryAlipayUserIdRequest
        @return: QueryAlipayUserIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryAlipayUserIdHeaders()
        return self.query_alipay_user_id_with_options(request, headers, runtime)

    async def query_alipay_user_id_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryAlipayUserIdRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryAlipayUserIdResponse:
        """
        @summary 根据staffId批量查询返回支付宝userId
        
        @param request: QueryAlipayUserIdRequest
        @return: QueryAlipayUserIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryAlipayUserIdHeaders()
        return await self.query_alipay_user_id_with_options_async(request, headers, runtime)

    def query_category_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCategoryByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryCategoryByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryCategoryByPageResponse:
        """
        @summary 批量获取费用类别
        
        @param request: QueryCategoryByPageRequest
        @param headers: QueryCategoryByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCategoryByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCategoryByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/categories/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryCategoryByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_category_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCategoryByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryCategoryByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryCategoryByPageResponse:
        """
        @summary 批量获取费用类别
        
        @param request: QueryCategoryByPageRequest
        @param headers: QueryCategoryByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCategoryByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCategoryByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/categories/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryCategoryByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_category_by_page(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCategoryByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryCategoryByPageResponse:
        """
        @summary 批量获取费用类别
        
        @param request: QueryCategoryByPageRequest
        @return: QueryCategoryByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCategoryByPageHeaders()
        return self.query_category_by_page_with_options(request, headers, runtime)

    async def query_category_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCategoryByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryCategoryByPageResponse:
        """
        @summary 批量获取费用类别
        
        @param request: QueryCategoryByPageRequest
        @return: QueryCategoryByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCategoryByPageHeaders()
        return await self.query_category_by_page_with_options_async(request, headers, runtime)

    def query_collection_info_list_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCollectionInfoListRequest,
        headers: dingtalkbizfinance__2__0_models.QueryCollectionInfoListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryCollectionInfoListResponse:
        """
        @summary 查询进件信息
        
        @param request: QueryCollectionInfoListRequest
        @param headers: QueryCollectionInfoListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCollectionInfoListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.status):
            query['status'] = request.status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCollectionInfoList',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/me/collections/accounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryCollectionInfoListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_collection_info_list_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCollectionInfoListRequest,
        headers: dingtalkbizfinance__2__0_models.QueryCollectionInfoListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryCollectionInfoListResponse:
        """
        @summary 查询进件信息
        
        @param request: QueryCollectionInfoListRequest
        @param headers: QueryCollectionInfoListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCollectionInfoListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.status):
            query['status'] = request.status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCollectionInfoList',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/me/collections/accounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryCollectionInfoListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_collection_info_list(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCollectionInfoListRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryCollectionInfoListResponse:
        """
        @summary 查询进件信息
        
        @param request: QueryCollectionInfoListRequest
        @return: QueryCollectionInfoListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCollectionInfoListHeaders()
        return self.query_collection_info_list_with_options(request, headers, runtime)

    async def query_collection_info_list_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCollectionInfoListRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryCollectionInfoListResponse:
        """
        @summary 查询进件信息
        
        @param request: QueryCollectionInfoListRequest
        @return: QueryCollectionInfoListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCollectionInfoListHeaders()
        return await self.query_collection_info_list_with_options_async(request, headers, runtime)

    def query_collection_order_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCollectionOrderRequest,
        headers: dingtalkbizfinance__2__0_models.QueryCollectionOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryCollectionOrderResponse:
        """
        @summary 查询收款订单
        
        @param request: QueryCollectionOrderRequest
        @param headers: QueryCollectionOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCollectionOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCollectionOrder',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/me/collections/orders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryCollectionOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def query_collection_order_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCollectionOrderRequest,
        headers: dingtalkbizfinance__2__0_models.QueryCollectionOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryCollectionOrderResponse:
        """
        @summary 查询收款订单
        
        @param request: QueryCollectionOrderRequest
        @param headers: QueryCollectionOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCollectionOrderResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCollectionOrder',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/me/collections/orders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryCollectionOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_collection_order(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCollectionOrderRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryCollectionOrderResponse:
        """
        @summary 查询收款订单
        
        @param request: QueryCollectionOrderRequest
        @return: QueryCollectionOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCollectionOrderHeaders()
        return self.query_collection_order_with_options(request, headers, runtime)

    async def query_collection_order_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCollectionOrderRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryCollectionOrderResponse:
        """
        @summary 查询收款订单
        
        @param request: QueryCollectionOrderRequest
        @return: QueryCollectionOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCollectionOrderHeaders()
        return await self.query_collection_order_with_options_async(request, headers, runtime)

    def query_customer_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCustomerByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryCustomerByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryCustomerByPageResponse:
        """
        @summary 分页批量获取智能财务应用内维护的客户信息
        
        @param request: QueryCustomerByPageRequest
        @param headers: QueryCustomerByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCustomerByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCustomerByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/customers/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryCustomerByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_customer_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCustomerByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryCustomerByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryCustomerByPageResponse:
        """
        @summary 分页批量获取智能财务应用内维护的客户信息
        
        @param request: QueryCustomerByPageRequest
        @param headers: QueryCustomerByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCustomerByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryCustomerByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/customers/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryCustomerByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_customer_by_page(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCustomerByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryCustomerByPageResponse:
        """
        @summary 分页批量获取智能财务应用内维护的客户信息
        
        @param request: QueryCustomerByPageRequest
        @return: QueryCustomerByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCustomerByPageHeaders()
        return self.query_customer_by_page_with_options(request, headers, runtime)

    async def query_customer_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCustomerByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryCustomerByPageResponse:
        """
        @summary 分页批量获取智能财务应用内维护的客户信息
        
        @param request: QueryCustomerByPageRequest
        @return: QueryCustomerByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCustomerByPageHeaders()
        return await self.query_customer_by_page_with_options_async(request, headers, runtime)

    def query_enterprise_account_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageResponse:
        """
        @summary 批量获取企业账户
        
        @param request: QueryEnterpriseAccountByPageRequest
        @param headers: QueryEnterpriseAccountByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryEnterpriseAccountByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryEnterpriseAccountByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/financeAccounts/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_enterprise_account_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageResponse:
        """
        @summary 批量获取企业账户
        
        @param request: QueryEnterpriseAccountByPageRequest
        @param headers: QueryEnterpriseAccountByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryEnterpriseAccountByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryEnterpriseAccountByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/financeAccounts/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_enterprise_account_by_page(
        self,
        request: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageResponse:
        """
        @summary 批量获取企业账户
        
        @param request: QueryEnterpriseAccountByPageRequest
        @return: QueryEnterpriseAccountByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageHeaders()
        return self.query_enterprise_account_by_page_with_options(request, headers, runtime)

    async def query_enterprise_account_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageResponse:
        """
        @summary 批量获取企业账户
        
        @param request: QueryEnterpriseAccountByPageRequest
        @return: QueryEnterpriseAccountByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageHeaders()
        return await self.query_enterprise_account_by_page_with_options_async(request, headers, runtime)

    def query_enterprise_account_sign_url_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlRequest,
        headers: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlResponse:
        """
        @summary 获取智能财务企业账户签约地址
        
        @param request: QueryEnterpriseAccountSignUrlRequest
        @param headers: QueryEnterpriseAccountSignUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryEnterpriseAccountSignUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_code):
            query['accountCode'] = request.account_code
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryEnterpriseAccountSignUrl',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/enterpriseAccounts/sign',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def query_enterprise_account_sign_url_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlRequest,
        headers: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlResponse:
        """
        @summary 获取智能财务企业账户签约地址
        
        @param request: QueryEnterpriseAccountSignUrlRequest
        @param headers: QueryEnterpriseAccountSignUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryEnterpriseAccountSignUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_code):
            query['accountCode'] = request.account_code
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryEnterpriseAccountSignUrl',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/enterpriseAccounts/sign',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_enterprise_account_sign_url(
        self,
        request: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlResponse:
        """
        @summary 获取智能财务企业账户签约地址
        
        @param request: QueryEnterpriseAccountSignUrlRequest
        @return: QueryEnterpriseAccountSignUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlHeaders()
        return self.query_enterprise_account_sign_url_with_options(request, headers, runtime)

    async def query_enterprise_account_sign_url_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlResponse:
        """
        @summary 获取智能财务企业账户签约地址
        
        @param request: QueryEnterpriseAccountSignUrlRequest
        @return: QueryEnterpriseAccountSignUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryEnterpriseAccountSignUrlHeaders()
        return await self.query_enterprise_account_sign_url_with_options_async(request, headers, runtime)

    def query_instance_payment_order_detail_with_options(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailRequest,
        headers: dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailResponse:
        """
        @summary 查询支付订单详情
        
        @param request: QueryInstancePaymentOrderDetailRequest
        @param headers: QueryInstancePaymentOrderDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryInstancePaymentOrderDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryInstancePaymentOrderDetail',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/instances/{instance_id}/paymentOrders/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def query_instance_payment_order_detail_with_options_async(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailRequest,
        headers: dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailResponse:
        """
        @summary 查询支付订单详情
        
        @param request: QueryInstancePaymentOrderDetailRequest
        @param headers: QueryInstancePaymentOrderDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryInstancePaymentOrderDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryInstancePaymentOrderDetail',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/instances/{instance_id}/paymentOrders/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_instance_payment_order_detail(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailResponse:
        """
        @summary 查询支付订单详情
        
        @param request: QueryInstancePaymentOrderDetailRequest
        @return: QueryInstancePaymentOrderDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailHeaders()
        return self.query_instance_payment_order_detail_with_options(instance_id, request, headers, runtime)

    async def query_instance_payment_order_detail_async(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailResponse:
        """
        @summary 查询支付订单详情
        
        @param request: QueryInstancePaymentOrderDetailRequest
        @return: QueryInstancePaymentOrderDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailHeaders()
        return await self.query_instance_payment_order_detail_with_options_async(instance_id, request, headers, runtime)

    def query_invoice_transfer_data_with_options(
        self,
        tmp_req: dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataRequest,
        headers: dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataResponse:
        """
        @summary 发票数据迁移，根据数据key查询具体数据data
        
        @param tmp_req: QueryInvoiceTransferDataRequest
        @param headers: QueryInvoiceTransferDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryInvoiceTransferDataResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryInvoiceTransferData',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/transferredDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_invoice_transfer_data_with_options_async(
        self,
        tmp_req: dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataRequest,
        headers: dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataResponse:
        """
        @summary 发票数据迁移，根据数据key查询具体数据data
        
        @param tmp_req: QueryInvoiceTransferDataRequest
        @param headers: QueryInvoiceTransferDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryInvoiceTransferDataResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryInvoiceTransferData',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/transferredDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_invoice_transfer_data(
        self,
        request: dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataResponse:
        """
        @summary 发票数据迁移，根据数据key查询具体数据data
        
        @param request: QueryInvoiceTransferDataRequest
        @return: QueryInvoiceTransferDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataHeaders()
        return self.query_invoice_transfer_data_with_options(request, headers, runtime)

    async def query_invoice_transfer_data_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataResponse:
        """
        @summary 发票数据迁移，根据数据key查询具体数据data
        
        @param request: QueryInvoiceTransferDataRequest
        @return: QueryInvoiceTransferDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryInvoiceTransferDataHeaders()
        return await self.query_invoice_transfer_data_with_options_async(request, headers, runtime)

    def query_payment_benefit_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryPaymentBenefitRequest,
        headers: dingtalkbizfinance__2__0_models.QueryPaymentBenefitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentBenefitResponse:
        """
        @summary 查询支付的权益使用信息
        
        @param request: QueryPaymentBenefitRequest
        @param headers: QueryPaymentBenefitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPaymentBenefitResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryPaymentBenefit',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/benefits',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryPaymentBenefitResponse(),
            self.execute(params, req, runtime)
        )

    async def query_payment_benefit_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryPaymentBenefitRequest,
        headers: dingtalkbizfinance__2__0_models.QueryPaymentBenefitHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentBenefitResponse:
        """
        @summary 查询支付的权益使用信息
        
        @param request: QueryPaymentBenefitRequest
        @param headers: QueryPaymentBenefitHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPaymentBenefitResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryPaymentBenefit',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/benefits',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryPaymentBenefitResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_payment_benefit(
        self,
        request: dingtalkbizfinance__2__0_models.QueryPaymentBenefitRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentBenefitResponse:
        """
        @summary 查询支付的权益使用信息
        
        @param request: QueryPaymentBenefitRequest
        @return: QueryPaymentBenefitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryPaymentBenefitHeaders()
        return self.query_payment_benefit_with_options(request, headers, runtime)

    async def query_payment_benefit_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryPaymentBenefitRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentBenefitResponse:
        """
        @summary 查询支付的权益使用信息
        
        @param request: QueryPaymentBenefitRequest
        @return: QueryPaymentBenefitResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryPaymentBenefitHeaders()
        return await self.query_payment_benefit_with_options_async(request, headers, runtime)

    def query_payment_order_detail_with_options(
        self,
        tmp_req: dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailRequest,
        headers: dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailResponse:
        """
        @summary 查询智能财务支付订单信息
        
        @param tmp_req: QueryPaymentOrderDetailRequest
        @param headers: QueryPaymentOrderDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPaymentOrderDetailResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.out_biz_no_list):
            request.out_biz_no_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.out_biz_no_list, 'outBizNoList', 'json')
        query = {}
        if not UtilClient.is_unset(request.out_biz_no_list_shrink):
            query['outBizNoList'] = request.out_biz_no_list_shrink
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryPaymentOrderDetail',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/orders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def query_payment_order_detail_with_options_async(
        self,
        tmp_req: dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailRequest,
        headers: dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailResponse:
        """
        @summary 查询智能财务支付订单信息
        
        @param tmp_req: QueryPaymentOrderDetailRequest
        @param headers: QueryPaymentOrderDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPaymentOrderDetailResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.out_biz_no_list):
            request.out_biz_no_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.out_biz_no_list, 'outBizNoList', 'json')
        query = {}
        if not UtilClient.is_unset(request.out_biz_no_list_shrink):
            query['outBizNoList'] = request.out_biz_no_list_shrink
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryPaymentOrderDetail',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/orders',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_payment_order_detail(
        self,
        request: dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailResponse:
        """
        @summary 查询智能财务支付订单信息
        
        @param request: QueryPaymentOrderDetailRequest
        @return: QueryPaymentOrderDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailHeaders()
        return self.query_payment_order_detail_with_options(request, headers, runtime)

    async def query_payment_order_detail_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailResponse:
        """
        @summary 查询智能财务支付订单信息
        
        @param request: QueryPaymentOrderDetailRequest
        @return: QueryPaymentOrderDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryPaymentOrderDetailHeaders()
        return await self.query_payment_order_detail_with_options_async(request, headers, runtime)

    def query_payment_recall_file_with_options(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.QueryPaymentRecallFileRequest,
        headers: dingtalkbizfinance__2__0_models.QueryPaymentRecallFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentRecallFileResponse:
        """
        @summary 查询支付回单信息
        
        @param request: QueryPaymentRecallFileRequest
        @param headers: QueryPaymentRecallFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPaymentRecallFileResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryPaymentRecallFile',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/recallFiles/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryPaymentRecallFileResponse(),
            self.execute(params, req, runtime)
        )

    async def query_payment_recall_file_with_options_async(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.QueryPaymentRecallFileRequest,
        headers: dingtalkbizfinance__2__0_models.QueryPaymentRecallFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentRecallFileResponse:
        """
        @summary 查询支付回单信息
        
        @param request: QueryPaymentRecallFileRequest
        @param headers: QueryPaymentRecallFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPaymentRecallFileResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryPaymentRecallFile',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/recallFiles/{instance_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryPaymentRecallFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_payment_recall_file(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.QueryPaymentRecallFileRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentRecallFileResponse:
        """
        @summary 查询支付回单信息
        
        @param request: QueryPaymentRecallFileRequest
        @return: QueryPaymentRecallFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryPaymentRecallFileHeaders()
        return self.query_payment_recall_file_with_options(instance_id, request, headers, runtime)

    async def query_payment_recall_file_async(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.QueryPaymentRecallFileRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentRecallFileResponse:
        """
        @summary 查询支付回单信息
        
        @param request: QueryPaymentRecallFileRequest
        @return: QueryPaymentRecallFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryPaymentRecallFileHeaders()
        return await self.query_payment_recall_file_with_options_async(instance_id, request, headers, runtime)

    def query_payment_status_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryPaymentStatusRequest,
        headers: dingtalkbizfinance__2__0_models.QueryPaymentStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentStatusResponse:
        """
        @summary 查询支付订单的状态
        
        @param request: QueryPaymentStatusRequest
        @param headers: QueryPaymentStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPaymentStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryPaymentStatus',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/statuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryPaymentStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def query_payment_status_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryPaymentStatusRequest,
        headers: dingtalkbizfinance__2__0_models.QueryPaymentStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentStatusResponse:
        """
        @summary 查询支付订单的状态
        
        @param request: QueryPaymentStatusRequest
        @param headers: QueryPaymentStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPaymentStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.instance_id):
            query['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryPaymentStatus',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/payments/statuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryPaymentStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_payment_status(
        self,
        request: dingtalkbizfinance__2__0_models.QueryPaymentStatusRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentStatusResponse:
        """
        @summary 查询支付订单的状态
        
        @param request: QueryPaymentStatusRequest
        @return: QueryPaymentStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryPaymentStatusHeaders()
        return self.query_payment_status_with_options(request, headers, runtime)

    async def query_payment_status_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryPaymentStatusRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryPaymentStatusResponse:
        """
        @summary 查询支付订单的状态
        
        @param request: QueryPaymentStatusRequest
        @return: QueryPaymentStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryPaymentStatusHeaders()
        return await self.query_payment_status_with_options_async(request, headers, runtime)

    def query_permission_user_ids_with_options(
        self,
        headers: dingtalkbizfinance__2__0_models.QueryPermissionUserIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryPermissionUserIdsResponse:
        """
        @summary 查询对应权限点的人员staffId
        
        @param headers: QueryPermissionUserIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPermissionUserIdsResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryPermissionUserIds',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/consumption/permission/getUserIds',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryPermissionUserIdsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_permission_user_ids_with_options_async(
        self,
        headers: dingtalkbizfinance__2__0_models.QueryPermissionUserIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryPermissionUserIdsResponse:
        """
        @summary 查询对应权限点的人员staffId
        
        @param headers: QueryPermissionUserIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPermissionUserIdsResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryPermissionUserIds',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/consumption/permission/getUserIds',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryPermissionUserIdsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_permission_user_ids(self) -> dingtalkbizfinance__2__0_models.QueryPermissionUserIdsResponse:
        """
        @summary 查询对应权限点的人员staffId
        
        @return: QueryPermissionUserIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryPermissionUserIdsHeaders()
        return self.query_permission_user_ids_with_options(headers, runtime)

    async def query_permission_user_ids_async(self) -> dingtalkbizfinance__2__0_models.QueryPermissionUserIdsResponse:
        """
        @summary 查询对应权限点的人员staffId
        
        @return: QueryPermissionUserIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryPermissionUserIdsHeaders()
        return await self.query_permission_user_ids_with_options_async(headers, runtime)

    def query_product_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryProductByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryProductByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryProductByPageResponse:
        """
        @summary 批量获取商品信息
        
        @param request: QueryProductByPageRequest
        @param headers: QueryProductByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryProductByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryProductByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/products/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryProductByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_product_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryProductByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryProductByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryProductByPageResponse:
        """
        @summary 批量获取商品信息
        
        @param request: QueryProductByPageRequest
        @param headers: QueryProductByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryProductByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryProductByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/products/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryProductByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_product_by_page(
        self,
        request: dingtalkbizfinance__2__0_models.QueryProductByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryProductByPageResponse:
        """
        @summary 批量获取商品信息
        
        @param request: QueryProductByPageRequest
        @return: QueryProductByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryProductByPageHeaders()
        return self.query_product_by_page_with_options(request, headers, runtime)

    async def query_product_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryProductByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryProductByPageResponse:
        """
        @summary 批量获取商品信息
        
        @param request: QueryProductByPageRequest
        @return: QueryProductByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryProductByPageHeaders()
        return await self.query_product_by_page_with_options_async(request, headers, runtime)

    def query_project_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryProjectByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryProjectByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryProjectByPageResponse:
        """
        @summary 批量获取项目信息
        
        @param request: QueryProjectByPageRequest
        @param headers: QueryProjectByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryProjectByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryProjectByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/projects/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryProjectByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_project_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryProjectByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryProjectByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryProjectByPageResponse:
        """
        @summary 批量获取项目信息
        
        @param request: QueryProjectByPageRequest
        @param headers: QueryProjectByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryProjectByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryProjectByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/projects/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryProjectByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_project_by_page(
        self,
        request: dingtalkbizfinance__2__0_models.QueryProjectByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryProjectByPageResponse:
        """
        @summary 批量获取项目信息
        
        @param request: QueryProjectByPageRequest
        @return: QueryProjectByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryProjectByPageHeaders()
        return self.query_project_by_page_with_options(request, headers, runtime)

    async def query_project_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryProjectByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryProjectByPageResponse:
        """
        @summary 批量获取项目信息
        
        @param request: QueryProjectByPageRequest
        @return: QueryProjectByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryProjectByPageHeaders()
        return await self.query_project_by_page_with_options_async(request, headers, runtime)

    def query_receipt_for_invoice_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceRequest,
        headers: dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceResponse:
        """
        @summary 批量查询智能财务单据主数据信息
        
        @param request: QueryReceiptForInvoiceRequest
        @param headers: QueryReceiptForInvoiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryReceiptForInvoiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.accountant_book_id):
            body['accountantBookId'] = request.accountant_book_id
        if not UtilClient.is_unset(request.apply_status_list):
            body['applyStatusList'] = request.apply_status_list
        if not UtilClient.is_unset(request.biz_status_list):
            body['bizStatusList'] = request.biz_status_list
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.receipt_status_list):
            body['receiptStatusList'] = request.receipt_status_list
        if not UtilClient.is_unset(request.search_params):
            body['searchParams'] = request.search_params
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryReceiptForInvoice',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/receipts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_receipt_for_invoice_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceRequest,
        headers: dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceResponse:
        """
        @summary 批量查询智能财务单据主数据信息
        
        @param request: QueryReceiptForInvoiceRequest
        @param headers: QueryReceiptForInvoiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryReceiptForInvoiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.accountant_book_id):
            body['accountantBookId'] = request.accountant_book_id
        if not UtilClient.is_unset(request.apply_status_list):
            body['applyStatusList'] = request.apply_status_list
        if not UtilClient.is_unset(request.biz_status_list):
            body['bizStatusList'] = request.biz_status_list
        if not UtilClient.is_unset(request.company_code):
            body['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.receipt_status_list):
            body['receiptStatusList'] = request.receipt_status_list
        if not UtilClient.is_unset(request.search_params):
            body['searchParams'] = request.search_params
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryReceiptForInvoice',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/receipts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_receipt_for_invoice(
        self,
        request: dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceResponse:
        """
        @summary 批量查询智能财务单据主数据信息
        
        @param request: QueryReceiptForInvoiceRequest
        @return: QueryReceiptForInvoiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceHeaders()
        return self.query_receipt_for_invoice_with_options(request, headers, runtime)

    async def query_receipt_for_invoice_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceResponse:
        """
        @summary 批量查询智能财务单据主数据信息
        
        @param request: QueryReceiptForInvoiceRequest
        @return: QueryReceiptForInvoiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryReceiptForInvoiceHeaders()
        return await self.query_receipt_for_invoice_with_options_async(request, headers, runtime)

    def query_supplier_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QuerySupplierByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QuerySupplierByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QuerySupplierByPageResponse:
        """
        @summary 分页批量获取智能财务应用内维护的供应商信息
        
        @param request: QuerySupplierByPageRequest
        @param headers: QuerySupplierByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySupplierByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QuerySupplierByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/suppliers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QuerySupplierByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_supplier_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QuerySupplierByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QuerySupplierByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QuerySupplierByPageResponse:
        """
        @summary 分页批量获取智能财务应用内维护的供应商信息
        
        @param request: QuerySupplierByPageRequest
        @param headers: QuerySupplierByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySupplierByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QuerySupplierByPage',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/suppliers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QuerySupplierByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_supplier_by_page(
        self,
        request: dingtalkbizfinance__2__0_models.QuerySupplierByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QuerySupplierByPageResponse:
        """
        @summary 分页批量获取智能财务应用内维护的供应商信息
        
        @param request: QuerySupplierByPageRequest
        @return: QuerySupplierByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QuerySupplierByPageHeaders()
        return self.query_supplier_by_page_with_options(request, headers, runtime)

    async def query_supplier_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QuerySupplierByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QuerySupplierByPageResponse:
        """
        @summary 分页批量获取智能财务应用内维护的供应商信息
        
        @param request: QuerySupplierByPageRequest
        @return: QuerySupplierByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QuerySupplierByPageHeaders()
        return await self.query_supplier_by_page_with_options_async(request, headers, runtime)

    def query_use_new_invoice_app_with_options(
        self,
        headers: dingtalkbizfinance__2__0_models.QueryUseNewInvoiceAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryUseNewInvoiceAppResponse:
        """
        @summary 查询组织是否命中走新发票应用
        
        @param headers: QueryUseNewInvoiceAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUseNewInvoiceAppResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryUseNewInvoiceApp',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoice/appGray',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryUseNewInvoiceAppResponse(),
            self.execute(params, req, runtime)
        )

    async def query_use_new_invoice_app_with_options_async(
        self,
        headers: dingtalkbizfinance__2__0_models.QueryUseNewInvoiceAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryUseNewInvoiceAppResponse:
        """
        @summary 查询组织是否命中走新发票应用
        
        @param headers: QueryUseNewInvoiceAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUseNewInvoiceAppResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryUseNewInvoiceApp',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoice/appGray',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryUseNewInvoiceAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_use_new_invoice_app(self) -> dingtalkbizfinance__2__0_models.QueryUseNewInvoiceAppResponse:
        """
        @summary 查询组织是否命中走新发票应用
        
        @return: QueryUseNewInvoiceAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryUseNewInvoiceAppHeaders()
        return self.query_use_new_invoice_app_with_options(headers, runtime)

    async def query_use_new_invoice_app_async(self) -> dingtalkbizfinance__2__0_models.QueryUseNewInvoiceAppResponse:
        """
        @summary 查询组织是否命中走新发票应用
        
        @return: QueryUseNewInvoiceAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryUseNewInvoiceAppHeaders()
        return await self.query_use_new_invoice_app_with_options_async(headers, runtime)

    def query_user_role_list_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryUserRoleListRequest,
        headers: dingtalkbizfinance__2__0_models.QueryUserRoleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryUserRoleListResponse:
        """
        @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
        
        @param request: QueryUserRoleListRequest
        @param headers: QueryUserRoleListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserRoleListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.company_code):
            query['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryUserRoleList',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/users/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryUserRoleListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_role_list_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryUserRoleListRequest,
        headers: dingtalkbizfinance__2__0_models.QueryUserRoleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryUserRoleListResponse:
        """
        @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
        
        @param request: QueryUserRoleListRequest
        @param headers: QueryUserRoleListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserRoleListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.company_code):
            query['companyCode'] = request.company_code
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryUserRoleList',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/users/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.QueryUserRoleListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_role_list(
        self,
        request: dingtalkbizfinance__2__0_models.QueryUserRoleListRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryUserRoleListResponse:
        """
        @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
        
        @param request: QueryUserRoleListRequest
        @return: QueryUserRoleListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryUserRoleListHeaders()
        return self.query_user_role_list_with_options(request, headers, runtime)

    async def query_user_role_list_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryUserRoleListRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryUserRoleListResponse:
        """
        @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
        
        @param request: QueryUserRoleListRequest
        @return: QueryUserRoleListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryUserRoleListHeaders()
        return await self.query_user_role_list_with_options_async(request, headers, runtime)

    def sign_enterprise_account_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.SignEnterpriseAccountRequest,
        headers: dingtalkbizfinance__2__0_models.SignEnterpriseAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.SignEnterpriseAccountResponse:
        """
        @summary 签约企业账户
        
        @param request: SignEnterpriseAccountRequest
        @param headers: SignEnterpriseAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SignEnterpriseAccountResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_code):
            query['accountCode'] = request.account_code
        if not UtilClient.is_unset(request.bank_card_no):
            query['bankCardNo'] = request.bank_card_no
        if not UtilClient.is_unset(request.bank_open_id):
            query['bankOpenId'] = request.bank_open_id
        if not UtilClient.is_unset(request.channel_type):
            query['channelType'] = request.channel_type
        if not UtilClient.is_unset(request.fee_item_code):
            query['feeItemCode'] = request.fee_item_code
        if not UtilClient.is_unset(request.issue_no):
            query['issueNo'] = request.issue_no
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.sign_operate_type):
            query['signOperateType'] = request.sign_operate_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SignEnterpriseAccount',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/enterpriseAccounts/sign',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.SignEnterpriseAccountResponse(),
            self.execute(params, req, runtime)
        )

    async def sign_enterprise_account_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.SignEnterpriseAccountRequest,
        headers: dingtalkbizfinance__2__0_models.SignEnterpriseAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.SignEnterpriseAccountResponse:
        """
        @summary 签约企业账户
        
        @param request: SignEnterpriseAccountRequest
        @param headers: SignEnterpriseAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SignEnterpriseAccountResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_code):
            query['accountCode'] = request.account_code
        if not UtilClient.is_unset(request.bank_card_no):
            query['bankCardNo'] = request.bank_card_no
        if not UtilClient.is_unset(request.bank_open_id):
            query['bankOpenId'] = request.bank_open_id
        if not UtilClient.is_unset(request.channel_type):
            query['channelType'] = request.channel_type
        if not UtilClient.is_unset(request.fee_item_code):
            query['feeItemCode'] = request.fee_item_code
        if not UtilClient.is_unset(request.issue_no):
            query['issueNo'] = request.issue_no
        if not UtilClient.is_unset(request.operator):
            query['operator'] = request.operator
        if not UtilClient.is_unset(request.sign_operate_type):
            query['signOperateType'] = request.sign_operate_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SignEnterpriseAccount',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/enterpriseAccounts/sign',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.SignEnterpriseAccountResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sign_enterprise_account(
        self,
        request: dingtalkbizfinance__2__0_models.SignEnterpriseAccountRequest,
    ) -> dingtalkbizfinance__2__0_models.SignEnterpriseAccountResponse:
        """
        @summary 签约企业账户
        
        @param request: SignEnterpriseAccountRequest
        @return: SignEnterpriseAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.SignEnterpriseAccountHeaders()
        return self.sign_enterprise_account_with_options(request, headers, runtime)

    async def sign_enterprise_account_async(
        self,
        request: dingtalkbizfinance__2__0_models.SignEnterpriseAccountRequest,
    ) -> dingtalkbizfinance__2__0_models.SignEnterpriseAccountResponse:
        """
        @summary 签约企业账户
        
        @param request: SignEnterpriseAccountRequest
        @return: SignEnterpriseAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.SignEnterpriseAccountHeaders()
        return await self.sign_enterprise_account_with_options_async(request, headers, runtime)

    def sync_receipt_recall_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.SyncReceiptRecallRequest,
        headers: dingtalkbizfinance__2__0_models.SyncReceiptRecallHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.SyncReceiptRecallResponse:
        """
        @summary 发送银企支付回单文件信息
        
        @param request: SyncReceiptRecallRequest
        @param headers: SyncReceiptRecallHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncReceiptRecallResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.file_download_url):
            query['fileDownloadUrl'] = request.file_download_url
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SyncReceiptRecall',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/receipts/syncRecall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.SyncReceiptRecallResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_receipt_recall_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.SyncReceiptRecallRequest,
        headers: dingtalkbizfinance__2__0_models.SyncReceiptRecallHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.SyncReceiptRecallResponse:
        """
        @summary 发送银企支付回单文件信息
        
        @param request: SyncReceiptRecallRequest
        @param headers: SyncReceiptRecallHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncReceiptRecallResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.file_download_url):
            query['fileDownloadUrl'] = request.file_download_url
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SyncReceiptRecall',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/receipts/syncRecall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.SyncReceiptRecallResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_receipt_recall(
        self,
        request: dingtalkbizfinance__2__0_models.SyncReceiptRecallRequest,
    ) -> dingtalkbizfinance__2__0_models.SyncReceiptRecallResponse:
        """
        @summary 发送银企支付回单文件信息
        
        @param request: SyncReceiptRecallRequest
        @return: SyncReceiptRecallResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.SyncReceiptRecallHeaders()
        return self.sync_receipt_recall_with_options(request, headers, runtime)

    async def sync_receipt_recall_async(
        self,
        request: dingtalkbizfinance__2__0_models.SyncReceiptRecallRequest,
    ) -> dingtalkbizfinance__2__0_models.SyncReceiptRecallResponse:
        """
        @summary 发送银企支付回单文件信息
        
        @param request: SyncReceiptRecallRequest
        @return: SyncReceiptRecallResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.SyncReceiptRecallHeaders()
        return await self.sync_receipt_recall_with_options_async(request, headers, runtime)

    def update_auxiliary_status_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusRequest,
        headers: dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusResponse:
        """
        @summary 更新智能财务档案的状态
        
        @param request: UpdateAuxiliaryStatusRequest
        @param headers: UpdateAuxiliaryStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateAuxiliaryStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auxiliary_id):
            query['auxiliaryId'] = request.auxiliary_id
        if not UtilClient.is_unset(request.auxiliary_type):
            query['auxiliaryType'] = request.auxiliary_type
        if not UtilClient.is_unset(request.operate_type):
            query['operateType'] = request.operate_type
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateAuxiliaryStatus',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/auxiliaries/status',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_auxiliary_status_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusRequest,
        headers: dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusResponse:
        """
        @summary 更新智能财务档案的状态
        
        @param request: UpdateAuxiliaryStatusRequest
        @param headers: UpdateAuxiliaryStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateAuxiliaryStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.auxiliary_id):
            query['auxiliaryId'] = request.auxiliary_id
        if not UtilClient.is_unset(request.auxiliary_type):
            query['auxiliaryType'] = request.auxiliary_type
        if not UtilClient.is_unset(request.operate_type):
            query['operateType'] = request.operate_type
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateAuxiliaryStatus',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/auxiliaries/status',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_auxiliary_status(
        self,
        request: dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusRequest,
    ) -> dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusResponse:
        """
        @summary 更新智能财务档案的状态
        
        @param request: UpdateAuxiliaryStatusRequest
        @return: UpdateAuxiliaryStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusHeaders()
        return self.update_auxiliary_status_with_options(request, headers, runtime)

    async def update_auxiliary_status_async(
        self,
        request: dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusRequest,
    ) -> dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusResponse:
        """
        @summary 更新智能财务档案的状态
        
        @param request: UpdateAuxiliaryStatusRequest
        @return: UpdateAuxiliaryStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateAuxiliaryStatusHeaders()
        return await self.update_auxiliary_status_with_options_async(request, headers, runtime)

    def update_finance_enterprise_account_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountRequest,
        headers: dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountResponse:
        """
        @summary 更新智能财务的企业账户
        
        @param request: UpdateFinanceEnterpriseAccountRequest
        @param headers: UpdateFinanceEnterpriseAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateFinanceEnterpriseAccountResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_code):
            body['accountCode'] = request.account_code
        if not UtilClient.is_unset(request.account_name):
            body['accountName'] = request.account_name
        if not UtilClient.is_unset(request.account_type):
            body['accountType'] = request.account_type
        if not UtilClient.is_unset(request.bank_card_no):
            body['bankCardNo'] = request.bank_card_no
        if not UtilClient.is_unset(request.bank_code):
            body['bankCode'] = request.bank_code
        if not UtilClient.is_unset(request.bank_name):
            body['bankName'] = request.bank_name
        if not UtilClient.is_unset(request.city):
            body['city'] = request.city
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.official_name):
            body['officialName'] = request.official_name
        if not UtilClient.is_unset(request.official_number):
            body['officialNumber'] = request.official_number
        if not UtilClient.is_unset(request.province):
            body['province'] = request.province
        if not UtilClient.is_unset(request.tax_nature):
            body['taxNature'] = request.tax_nature
        if not UtilClient.is_unset(request.tax_no):
            body['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateFinanceEnterpriseAccount',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/enterpriseAccounts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountResponse(),
            self.execute(params, req, runtime)
        )

    async def update_finance_enterprise_account_with_options_async(
        self,
        request: dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountRequest,
        headers: dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountResponse:
        """
        @summary 更新智能财务的企业账户
        
        @param request: UpdateFinanceEnterpriseAccountRequest
        @param headers: UpdateFinanceEnterpriseAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateFinanceEnterpriseAccountResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.account_code):
            body['accountCode'] = request.account_code
        if not UtilClient.is_unset(request.account_name):
            body['accountName'] = request.account_name
        if not UtilClient.is_unset(request.account_type):
            body['accountType'] = request.account_type
        if not UtilClient.is_unset(request.bank_card_no):
            body['bankCardNo'] = request.bank_card_no
        if not UtilClient.is_unset(request.bank_code):
            body['bankCode'] = request.bank_code
        if not UtilClient.is_unset(request.bank_name):
            body['bankName'] = request.bank_name
        if not UtilClient.is_unset(request.city):
            body['city'] = request.city
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.official_name):
            body['officialName'] = request.official_name
        if not UtilClient.is_unset(request.official_number):
            body['officialNumber'] = request.official_number
        if not UtilClient.is_unset(request.province):
            body['province'] = request.province
        if not UtilClient.is_unset(request.tax_nature):
            body['taxNature'] = request.tax_nature
        if not UtilClient.is_unset(request.tax_no):
            body['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateFinanceEnterpriseAccount',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/enterpriseAccounts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_finance_enterprise_account(
        self,
        request: dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountRequest,
    ) -> dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountResponse:
        """
        @summary 更新智能财务的企业账户
        
        @param request: UpdateFinanceEnterpriseAccountRequest
        @return: UpdateFinanceEnterpriseAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountHeaders()
        return self.update_finance_enterprise_account_with_options(request, headers, runtime)

    async def update_finance_enterprise_account_async(
        self,
        request: dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountRequest,
    ) -> dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountResponse:
        """
        @summary 更新智能财务的企业账户
        
        @param request: UpdateFinanceEnterpriseAccountRequest
        @return: UpdateFinanceEnterpriseAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateFinanceEnterpriseAccountHeaders()
        return await self.update_finance_enterprise_account_with_options_async(request, headers, runtime)

    def update_instance_order_info_with_options(
        self,
        instance_id: str,
        tmp_req: dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoRequest,
        headers: dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoResponse:
        """
        @summary 更新单据的支付状态
        
        @param tmp_req: UpdateInstanceOrderInfoRequest
        @param headers: UpdateInstanceOrderInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInstanceOrderInfoResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.payer_bank):
            request.payer_bank_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.payer_bank, 'payerBank', 'json')
        query = {}
        if not UtilClient.is_unset(request.fail_reason):
            query['failReason'] = request.fail_reason
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.out_order_no):
            query['outOrderNo'] = request.out_order_no
        if not UtilClient.is_unset(request.payer_bank_shrink):
            query['payerBank'] = request.payer_bank_shrink
        if not UtilClient.is_unset(request.payment_time):
            query['paymentTime'] = request.payment_time
        if not UtilClient.is_unset(request.status):
            query['status'] = request.status
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateInstanceOrderInfo',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/instances/{instance_id}/paymentOrders/states',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def update_instance_order_info_with_options_async(
        self,
        instance_id: str,
        tmp_req: dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoRequest,
        headers: dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoResponse:
        """
        @summary 更新单据的支付状态
        
        @param tmp_req: UpdateInstanceOrderInfoRequest
        @param headers: UpdateInstanceOrderInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInstanceOrderInfoResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.payer_bank):
            request.payer_bank_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.payer_bank, 'payerBank', 'json')
        query = {}
        if not UtilClient.is_unset(request.fail_reason):
            query['failReason'] = request.fail_reason
        if not UtilClient.is_unset(request.order_no):
            query['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.out_order_no):
            query['outOrderNo'] = request.out_order_no
        if not UtilClient.is_unset(request.payer_bank_shrink):
            query['payerBank'] = request.payer_bank_shrink
        if not UtilClient.is_unset(request.payment_time):
            query['paymentTime'] = request.payment_time
        if not UtilClient.is_unset(request.status):
            query['status'] = request.status
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateInstanceOrderInfo',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/instances/{instance_id}/paymentOrders/states',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_instance_order_info(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoRequest,
    ) -> dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoResponse:
        """
        @summary 更新单据的支付状态
        
        @param request: UpdateInstanceOrderInfoRequest
        @return: UpdateInstanceOrderInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoHeaders()
        return self.update_instance_order_info_with_options(instance_id, request, headers, runtime)

    async def update_instance_order_info_async(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoRequest,
    ) -> dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoResponse:
        """
        @summary 更新单据的支付状态
        
        @param request: UpdateInstanceOrderInfoRequest
        @return: UpdateInstanceOrderInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoHeaders()
        return await self.update_instance_order_info_with_options_async(instance_id, request, headers, runtime)

    def update_invoice_data_transfer_done_with_options(
        self,
        headers: dingtalkbizfinance__2__0_models.UpdateInvoiceDataTransferDoneHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.UpdateInvoiceDataTransferDoneResponse:
        """
        @summary 发票数据迁移，新发票应用上报已成功搬移数据
        
        @param headers: UpdateInvoiceDataTransferDoneHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInvoiceDataTransferDoneResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='UpdateInvoiceDataTransferDone',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/transferredDatas/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.UpdateInvoiceDataTransferDoneResponse(),
            self.execute(params, req, runtime)
        )

    async def update_invoice_data_transfer_done_with_options_async(
        self,
        headers: dingtalkbizfinance__2__0_models.UpdateInvoiceDataTransferDoneHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.UpdateInvoiceDataTransferDoneResponse:
        """
        @summary 发票数据迁移，新发票应用上报已成功搬移数据
        
        @param headers: UpdateInvoiceDataTransferDoneHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInvoiceDataTransferDoneResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='UpdateInvoiceDataTransferDone',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/transferredDatas/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.UpdateInvoiceDataTransferDoneResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_invoice_data_transfer_done(self) -> dingtalkbizfinance__2__0_models.UpdateInvoiceDataTransferDoneResponse:
        """
        @summary 发票数据迁移，新发票应用上报已成功搬移数据
        
        @return: UpdateInvoiceDataTransferDoneResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateInvoiceDataTransferDoneHeaders()
        return self.update_invoice_data_transfer_done_with_options(headers, runtime)

    async def update_invoice_data_transfer_done_async(self) -> dingtalkbizfinance__2__0_models.UpdateInvoiceDataTransferDoneResponse:
        """
        @summary 发票数据迁移，新发票应用上报已成功搬移数据
        
        @return: UpdateInvoiceDataTransferDoneResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateInvoiceDataTransferDoneHeaders()
        return await self.update_invoice_data_transfer_done_with_options_async(headers, runtime)

    def update_invoice_url_with_options(
        self,
        tmp_req: dingtalkbizfinance__2__0_models.UpdateInvoiceUrlRequest,
        headers: dingtalkbizfinance__2__0_models.UpdateInvoiceUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.UpdateInvoiceUrlResponse:
        """
        @summary 用于更新智能财务企业票池内对应发票的下载链接
        
        @param tmp_req: UpdateInvoiceUrlRequest
        @param headers: UpdateInvoiceUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInvoiceUrlResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__2__0_models.UpdateInvoiceUrlShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceUrl',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/urls',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.UpdateInvoiceUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def update_invoice_url_with_options_async(
        self,
        tmp_req: dingtalkbizfinance__2__0_models.UpdateInvoiceUrlRequest,
        headers: dingtalkbizfinance__2__0_models.UpdateInvoiceUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.UpdateInvoiceUrlResponse:
        """
        @summary 用于更新智能财务企业票池内对应发票的下载链接
        
        @param tmp_req: UpdateInvoiceUrlRequest
        @param headers: UpdateInvoiceUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInvoiceUrlResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkbizfinance__2__0_models.UpdateInvoiceUrlShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateInvoiceUrl',
            version='bizfinance_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/bizfinance/invoices/urls',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkbizfinance__2__0_models.UpdateInvoiceUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_invoice_url(
        self,
        request: dingtalkbizfinance__2__0_models.UpdateInvoiceUrlRequest,
    ) -> dingtalkbizfinance__2__0_models.UpdateInvoiceUrlResponse:
        """
        @summary 用于更新智能财务企业票池内对应发票的下载链接
        
        @param request: UpdateInvoiceUrlRequest
        @return: UpdateInvoiceUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateInvoiceUrlHeaders()
        return self.update_invoice_url_with_options(request, headers, runtime)

    async def update_invoice_url_async(
        self,
        request: dingtalkbizfinance__2__0_models.UpdateInvoiceUrlRequest,
    ) -> dingtalkbizfinance__2__0_models.UpdateInvoiceUrlResponse:
        """
        @summary 用于更新智能财务企业票池内对应发票的下载链接
        
        @param request: UpdateInvoiceUrlRequest
        @return: UpdateInvoiceUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateInvoiceUrlHeaders()
        return await self.update_invoice_url_with_options_async(request, headers, runtime)
