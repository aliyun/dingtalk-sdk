# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
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
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

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
        if not UtilClient.is_unset(request.bank_card_no):
            query['bankCardNo'] = request.bank_card_no
        if not UtilClient.is_unset(request.bank_open_id):
            query['bankOpenId'] = request.bank_open_id
        if not UtilClient.is_unset(request.channel_type):
            query['channelType'] = request.channel_type
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
        if not UtilClient.is_unset(request.bank_card_no):
            query['bankCardNo'] = request.bank_card_no
        if not UtilClient.is_unset(request.bank_open_id):
            query['bankOpenId'] = request.bank_open_id
        if not UtilClient.is_unset(request.channel_type):
            query['channelType'] = request.channel_type
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
