# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.bizfinance_1_0 import models as dingtalkbizfinance__1__0_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def query_project_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProjectByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryProjectByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryProjectByPageHeaders()
        return self.query_project_by_page_with_options(request, headers, runtime)

    async def query_project_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProjectByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryProjectByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryProjectByPageHeaders()
        return await self.query_project_by_page_with_options_async(request, headers, runtime)

    def query_project_by_page_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProjectByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryProjectByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryProjectByPageResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryProjectByPageResponse(),
            self.do_roarequest('QueryProjectByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/projects/list', 'json', req, runtime)
        )

    async def query_project_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryProjectByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryProjectByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryProjectByPageResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryProjectByPageResponse(),
            await self.do_roarequest_async('QueryProjectByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/projects/list', 'json', req, runtime)
        )

    def query_category_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCategoryByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryCategoryByPageHeaders()
        return self.query_category_by_page_with_options(request, headers, runtime)

    async def query_category_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCategoryByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryCategoryByPageHeaders()
        return await self.query_category_by_page_with_options_async(request, headers, runtime)

    def query_category_by_page_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCategoryByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryCategoryByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse(),
            self.do_roarequest('QueryCategoryByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/categories/list', 'json', req, runtime)
        )

    async def query_category_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryCategoryByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryCategoryByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryCategoryByPageResponse(),
            await self.do_roarequest_async('QueryCategoryByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/categories/list', 'json', req, runtime)
        )

    def get_category(
        self,
        request: dingtalkbizfinance__1__0_models.GetCategoryRequest,
    ) -> dingtalkbizfinance__1__0_models.GetCategoryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetCategoryHeaders()
        return self.get_category_with_options(request, headers, runtime)

    async def get_category_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetCategoryRequest,
    ) -> dingtalkbizfinance__1__0_models.GetCategoryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetCategoryHeaders()
        return await self.get_category_with_options_async(request, headers, runtime)

    def get_category_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.GetCategoryRequest,
        headers: dingtalkbizfinance__1__0_models.GetCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetCategoryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetCategoryResponse(),
            self.do_roarequest('GetCategory', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/categories/get', 'json', req, runtime)
        )

    async def get_category_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetCategoryRequest,
        headers: dingtalkbizfinance__1__0_models.GetCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetCategoryResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetCategoryResponse(),
            await self.do_roarequest_async('GetCategory', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/categories/get', 'json', req, runtime)
        )

    def query_enterprise_account_by_page(
        self,
        request: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageHeaders()
        return self.query_enterprise_account_by_page_with_options(request, headers, runtime)

    async def query_enterprise_account_by_page_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageRequest,
    ) -> dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageHeaders()
        return await self.query_enterprise_account_by_page_with_options_async(request, headers, runtime)

    def query_enterprise_account_by_page_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse(),
            self.do_roarequest('QueryEnterpriseAccountByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/financeAccounts/list', 'json', req, runtime)
        )

    async def query_enterprise_account_by_page_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageRequest,
        headers: dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.QueryEnterpriseAccountByPageResponse(),
            await self.do_roarequest_async('QueryEnterpriseAccountByPage', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/financeAccounts/list', 'json', req, runtime)
        )

    def get_project(
        self,
        request: dingtalkbizfinance__1__0_models.GetProjectRequest,
    ) -> dingtalkbizfinance__1__0_models.GetProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetProjectHeaders()
        return self.get_project_with_options(request, headers, runtime)

    async def get_project_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetProjectRequest,
    ) -> dingtalkbizfinance__1__0_models.GetProjectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetProjectHeaders()
        return await self.get_project_with_options_async(request, headers, runtime)

    def get_project_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.GetProjectRequest,
        headers: dingtalkbizfinance__1__0_models.GetProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetProjectResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetProjectResponse(),
            self.do_roarequest('GetProject', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/projects/get', 'json', req, runtime)
        )

    async def get_project_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetProjectRequest,
        headers: dingtalkbizfinance__1__0_models.GetProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetProjectResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetProjectResponse(),
            await self.do_roarequest_async('GetProject', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/projects/get', 'json', req, runtime)
        )

    def get_finance_account(
        self,
        request: dingtalkbizfinance__1__0_models.GetFinanceAccountRequest,
    ) -> dingtalkbizfinance__1__0_models.GetFinanceAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetFinanceAccountHeaders()
        return self.get_finance_account_with_options(request, headers, runtime)

    async def get_finance_account_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetFinanceAccountRequest,
    ) -> dingtalkbizfinance__1__0_models.GetFinanceAccountResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkbizfinance__1__0_models.GetFinanceAccountHeaders()
        return await self.get_finance_account_with_options_async(request, headers, runtime)

    def get_finance_account_with_options(
        self,
        request: dingtalkbizfinance__1__0_models.GetFinanceAccountRequest,
        headers: dingtalkbizfinance__1__0_models.GetFinanceAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetFinanceAccountResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_code):
            query['accountCode'] = request.account_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetFinanceAccountResponse(),
            self.do_roarequest('GetFinanceAccount', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/financeAccounts/get', 'json', req, runtime)
        )

    async def get_finance_account_with_options_async(
        self,
        request: dingtalkbizfinance__1__0_models.GetFinanceAccountRequest,
        headers: dingtalkbizfinance__1__0_models.GetFinanceAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkbizfinance__1__0_models.GetFinanceAccountResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.account_code):
            query['accountCode'] = request.account_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkbizfinance__1__0_models.GetFinanceAccountResponse(),
            await self.do_roarequest_async('GetFinanceAccount', 'bizfinance_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/bizfinance/financeAccounts/get', 'json', req, runtime)
        )
