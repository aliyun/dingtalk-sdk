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

    def batch_delete_receipt_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.BatchDeleteReceiptRequest,
        headers: dingtalkbizfinance__2__0_models.BatchDeleteReceiptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.BatchDeleteReceiptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BatchDeleteReceiptHeaders()
        return self.batch_delete_receipt_with_options(request, headers, runtime)

    async def batch_delete_receipt_async(
        self,
        request: dingtalkbizfinance__2__0_models.BatchDeleteReceiptRequest,
    ) -> dingtalkbizfinance__2__0_models.BatchDeleteReceiptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.BatchDeleteReceiptHeaders()
        return await self.batch_delete_receipt_with_options_async(request, headers, runtime)

    def get_category_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.GetCategoryRequest,
        headers: dingtalkbizfinance__2__0_models.GetCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetCategoryResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetCategoryHeaders()
        return self.get_category_with_options(request, headers, runtime)

    async def get_category_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetCategoryRequest,
    ) -> dingtalkbizfinance__2__0_models.GetCategoryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetCategoryHeaders()
        return await self.get_category_with_options_async(request, headers, runtime)

    def get_finance_account_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.GetFinanceAccountRequest,
        headers: dingtalkbizfinance__2__0_models.GetFinanceAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetFinanceAccountResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetFinanceAccountHeaders()
        return self.get_finance_account_with_options(request, headers, runtime)

    async def get_finance_account_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetFinanceAccountRequest,
    ) -> dingtalkbizfinance__2__0_models.GetFinanceAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetFinanceAccountHeaders()
        return await self.get_finance_account_with_options_async(request, headers, runtime)

    def get_project_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.GetProjectRequest,
        headers: dingtalkbizfinance__2__0_models.GetProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetProjectResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetProjectHeaders()
        return self.get_project_with_options(request, headers, runtime)

    async def get_project_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetProjectRequest,
    ) -> dingtalkbizfinance__2__0_models.GetProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetProjectHeaders()
        return await self.get_project_with_options_async(request, headers, runtime)

    def get_supplier_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.GetSupplierRequest,
        headers: dingtalkbizfinance__2__0_models.GetSupplierHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.GetSupplierResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetSupplierHeaders()
        return self.get_supplier_with_options(request, headers, runtime)

    async def get_supplier_async(
        self,
        request: dingtalkbizfinance__2__0_models.GetSupplierRequest,
    ) -> dingtalkbizfinance__2__0_models.GetSupplierResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.GetSupplierHeaders()
        return await self.get_supplier_with_options_async(request, headers, runtime)

    def query_category_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCategoryByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryCategoryByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryCategoryByPageResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCategoryByPageHeaders()
        return self.query_category_by_page_with_options(request, headers, runtime)

    async def query_category_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCategoryByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryCategoryByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCategoryByPageHeaders()
        return await self.query_category_by_page_with_options_async(request, headers, runtime)

    def query_customer_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCustomerByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryCustomerByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryCustomerByPageResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCustomerByPageHeaders()
        return self.query_customer_by_page_with_options(request, headers, runtime)

    async def query_customer_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryCustomerByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryCustomerByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryCustomerByPageHeaders()
        return await self.query_customer_by_page_with_options_async(request, headers, runtime)

    def query_enterprise_account_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageHeaders()
        return self.query_enterprise_account_by_page_with_options(request, headers, runtime)

    async def query_enterprise_account_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryEnterpriseAccountByPageResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailHeaders()
        return self.query_instance_payment_order_detail_with_options(instance_id, request, headers, runtime)

    async def query_instance_payment_order_detail_async(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryInstancePaymentOrderDetailHeaders()
        return await self.query_instance_payment_order_detail_with_options_async(instance_id, request, headers, runtime)

    def query_project_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QueryProjectByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QueryProjectByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QueryProjectByPageResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryProjectByPageHeaders()
        return self.query_project_by_page_with_options(request, headers, runtime)

    async def query_project_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QueryProjectByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QueryProjectByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QueryProjectByPageHeaders()
        return await self.query_project_by_page_with_options_async(request, headers, runtime)

    def query_supplier_by_page_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.QuerySupplierByPageRequest,
        headers: dingtalkbizfinance__2__0_models.QuerySupplierByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.QuerySupplierByPageResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QuerySupplierByPageHeaders()
        return self.query_supplier_by_page_with_options(request, headers, runtime)

    async def query_supplier_by_page_async(
        self,
        request: dingtalkbizfinance__2__0_models.QuerySupplierByPageRequest,
    ) -> dingtalkbizfinance__2__0_models.QuerySupplierByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.QuerySupplierByPageHeaders()
        return await self.query_supplier_by_page_with_options_async(request, headers, runtime)

    def sign_enterprise_account_with_options(
        self,
        request: dingtalkbizfinance__2__0_models.SignEnterpriseAccountRequest,
        headers: dingtalkbizfinance__2__0_models.SignEnterpriseAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.SignEnterpriseAccountResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.bank_card_no):
            query['bankCardNo'] = request.bank_card_no
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
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.bank_card_no):
            query['bankCardNo'] = request.bank_card_no
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.SignEnterpriseAccountHeaders()
        return self.sign_enterprise_account_with_options(request, headers, runtime)

    async def sign_enterprise_account_async(
        self,
        request: dingtalkbizfinance__2__0_models.SignEnterpriseAccountRequest,
    ) -> dingtalkbizfinance__2__0_models.SignEnterpriseAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.SignEnterpriseAccountHeaders()
        return await self.sign_enterprise_account_with_options_async(request, headers, runtime)

    def update_instance_order_info_with_options(
        self,
        instance_id: str,
        tmp_req: dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoRequest,
        headers: dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoHeaders()
        return self.update_instance_order_info_with_options(instance_id, request, headers, runtime)

    async def update_instance_order_info_async(
        self,
        instance_id: str,
        request: dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoRequest,
    ) -> dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__2__0_models.UpdateInstanceOrderInfoHeaders()
        return await self.update_instance_order_info_with_options_async(instance_id, request, headers, runtime)
