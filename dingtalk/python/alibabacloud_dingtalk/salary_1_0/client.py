# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.salary_1_0 import models as dingtalksalary__1__0_models
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

    def get_salary_calculation_with_options(
        self,
        request: dingtalksalary__1__0_models.GetSalaryCalculationRequest,
        headers: dingtalksalary__1__0_models.GetSalaryCalculationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.GetSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录
        
        @param request: GetSalaryCalculationRequest
        @param headers: GetSalaryCalculationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSalaryCalculationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.date):
            query['date'] = request.date
        if not UtilClient.is_unset(request.salary_group_id):
            query['salaryGroupId'] = request.salary_group_id
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
            action='GetSalaryCalculation',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/calculation',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.GetSalaryCalculationResponse(),
            self.execute(params, req, runtime)
        )

    async def get_salary_calculation_with_options_async(
        self,
        request: dingtalksalary__1__0_models.GetSalaryCalculationRequest,
        headers: dingtalksalary__1__0_models.GetSalaryCalculationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.GetSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录
        
        @param request: GetSalaryCalculationRequest
        @param headers: GetSalaryCalculationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSalaryCalculationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.date):
            query['date'] = request.date
        if not UtilClient.is_unset(request.salary_group_id):
            query['salaryGroupId'] = request.salary_group_id
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
            action='GetSalaryCalculation',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/calculation',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.GetSalaryCalculationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_salary_calculation(
        self,
        request: dingtalksalary__1__0_models.GetSalaryCalculationRequest,
    ) -> dingtalksalary__1__0_models.GetSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录
        
        @param request: GetSalaryCalculationRequest
        @return: GetSalaryCalculationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.GetSalaryCalculationHeaders()
        return self.get_salary_calculation_with_options(request, headers, runtime)

    async def get_salary_calculation_async(
        self,
        request: dingtalksalary__1__0_models.GetSalaryCalculationRequest,
    ) -> dingtalksalary__1__0_models.GetSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录
        
        @param request: GetSalaryCalculationRequest
        @return: GetSalaryCalculationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.GetSalaryCalculationHeaders()
        return await self.get_salary_calculation_with_options_async(request, headers, runtime)

    def get_salary_group_with_options(
        self,
        headers: dingtalksalary__1__0_models.GetSalaryGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.GetSalaryGroupResponse:
        """
        @summary 小微薪酬获取薪资组
        
        @param headers: GetSalaryGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSalaryGroupResponse
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
            action='GetSalaryGroup',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/group',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.GetSalaryGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def get_salary_group_with_options_async(
        self,
        headers: dingtalksalary__1__0_models.GetSalaryGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.GetSalaryGroupResponse:
        """
        @summary 小微薪酬获取薪资组
        
        @param headers: GetSalaryGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSalaryGroupResponse
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
            action='GetSalaryGroup',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/group',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.GetSalaryGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_salary_group(self) -> dingtalksalary__1__0_models.GetSalaryGroupResponse:
        """
        @summary 小微薪酬获取薪资组
        
        @return: GetSalaryGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.GetSalaryGroupHeaders()
        return self.get_salary_group_with_options(headers, runtime)

    async def get_salary_group_async(self) -> dingtalksalary__1__0_models.GetSalaryGroupResponse:
        """
        @summary 小微薪酬获取薪资组
        
        @return: GetSalaryGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.GetSalaryGroupHeaders()
        return await self.get_salary_group_with_options_async(headers, runtime)

    def get_salary_item_with_options(
        self,
        request: dingtalksalary__1__0_models.GetSalaryItemRequest,
        headers: dingtalksalary__1__0_models.GetSalaryItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.GetSalaryItemResponse:
        """
        @summary 小微薪酬获取薪资项目
        
        @param request: GetSalaryItemRequest
        @param headers: GetSalaryItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSalaryItemResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.salary_item_group_id):
            query['salaryItemGroupId'] = request.salary_item_group_id
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
            action='GetSalaryItem',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/item',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.GetSalaryItemResponse(),
            self.execute(params, req, runtime)
        )

    async def get_salary_item_with_options_async(
        self,
        request: dingtalksalary__1__0_models.GetSalaryItemRequest,
        headers: dingtalksalary__1__0_models.GetSalaryItemHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.GetSalaryItemResponse:
        """
        @summary 小微薪酬获取薪资项目
        
        @param request: GetSalaryItemRequest
        @param headers: GetSalaryItemHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSalaryItemResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.salary_item_group_id):
            query['salaryItemGroupId'] = request.salary_item_group_id
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
            action='GetSalaryItem',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/item',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.GetSalaryItemResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_salary_item(
        self,
        request: dingtalksalary__1__0_models.GetSalaryItemRequest,
    ) -> dingtalksalary__1__0_models.GetSalaryItemResponse:
        """
        @summary 小微薪酬获取薪资项目
        
        @param request: GetSalaryItemRequest
        @return: GetSalaryItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.GetSalaryItemHeaders()
        return self.get_salary_item_with_options(request, headers, runtime)

    async def get_salary_item_async(
        self,
        request: dingtalksalary__1__0_models.GetSalaryItemRequest,
    ) -> dingtalksalary__1__0_models.GetSalaryItemResponse:
        """
        @summary 小微薪酬获取薪资项目
        
        @param request: GetSalaryItemRequest
        @return: GetSalaryItemResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.GetSalaryItemHeaders()
        return await self.get_salary_item_with_options_async(request, headers, runtime)

    def get_salary_item_group_with_options(
        self,
        headers: dingtalksalary__1__0_models.GetSalaryItemGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.GetSalaryItemGroupResponse:
        """
        @summary 小微薪酬获取薪资项目大类
        
        @param headers: GetSalaryItemGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSalaryItemGroupResponse
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
            action='GetSalaryItemGroup',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/itemGroup',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.GetSalaryItemGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def get_salary_item_group_with_options_async(
        self,
        headers: dingtalksalary__1__0_models.GetSalaryItemGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.GetSalaryItemGroupResponse:
        """
        @summary 小微薪酬获取薪资项目大类
        
        @param headers: GetSalaryItemGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSalaryItemGroupResponse
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
            action='GetSalaryItemGroup',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/itemGroup',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.GetSalaryItemGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_salary_item_group(self) -> dingtalksalary__1__0_models.GetSalaryItemGroupResponse:
        """
        @summary 小微薪酬获取薪资项目大类
        
        @return: GetSalaryItemGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.GetSalaryItemGroupHeaders()
        return self.get_salary_item_group_with_options(headers, runtime)

    async def get_salary_item_group_async(self) -> dingtalksalary__1__0_models.GetSalaryItemGroupResponse:
        """
        @summary 小微薪酬获取薪资项目大类
        
        @return: GetSalaryItemGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.GetSalaryItemGroupHeaders()
        return await self.get_salary_item_group_with_options_async(headers, runtime)

    def list_salary_calculation_with_options(
        self,
        request: dingtalksalary__1__0_models.ListSalaryCalculationRequest,
        headers: dingtalksalary__1__0_models.ListSalaryCalculationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.ListSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录数据
        
        @param request: ListSalaryCalculationRequest
        @param headers: ListSalaryCalculationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSalaryCalculationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.date):
            body['date'] = request.date
        if not UtilClient.is_unset(request.page_index):
            body['pageIndex'] = request.page_index
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.salary_group_id):
            body['salaryGroupId'] = request.salary_group_id
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
            action='ListSalaryCalculation',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/calculation',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.ListSalaryCalculationResponse(),
            self.execute(params, req, runtime)
        )

    async def list_salary_calculation_with_options_async(
        self,
        request: dingtalksalary__1__0_models.ListSalaryCalculationRequest,
        headers: dingtalksalary__1__0_models.ListSalaryCalculationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.ListSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录数据
        
        @param request: ListSalaryCalculationRequest
        @param headers: ListSalaryCalculationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSalaryCalculationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.date):
            body['date'] = request.date
        if not UtilClient.is_unset(request.page_index):
            body['pageIndex'] = request.page_index
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.salary_group_id):
            body['salaryGroupId'] = request.salary_group_id
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
            action='ListSalaryCalculation',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/calculation',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.ListSalaryCalculationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_salary_calculation(
        self,
        request: dingtalksalary__1__0_models.ListSalaryCalculationRequest,
    ) -> dingtalksalary__1__0_models.ListSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录数据
        
        @param request: ListSalaryCalculationRequest
        @return: ListSalaryCalculationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.ListSalaryCalculationHeaders()
        return self.list_salary_calculation_with_options(request, headers, runtime)

    async def list_salary_calculation_async(
        self,
        request: dingtalksalary__1__0_models.ListSalaryCalculationRequest,
    ) -> dingtalksalary__1__0_models.ListSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录数据
        
        @param request: ListSalaryCalculationRequest
        @return: ListSalaryCalculationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.ListSalaryCalculationHeaders()
        return await self.list_salary_calculation_with_options_async(request, headers, runtime)

    def write_salary_calculation_with_options(
        self,
        request: dingtalksalary__1__0_models.WriteSalaryCalculationRequest,
        headers: dingtalksalary__1__0_models.WriteSalaryCalculationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.WriteSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录写入
        
        @param request: WriteSalaryCalculationRequest
        @param headers: WriteSalaryCalculationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteSalaryCalculationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.date):
            body['date'] = request.date
        if not UtilClient.is_unset(request.items):
            body['items'] = request.items
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
            action='WriteSalaryCalculation',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/calculation/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.WriteSalaryCalculationResponse(),
            self.execute(params, req, runtime)
        )

    async def write_salary_calculation_with_options_async(
        self,
        request: dingtalksalary__1__0_models.WriteSalaryCalculationRequest,
        headers: dingtalksalary__1__0_models.WriteSalaryCalculationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalksalary__1__0_models.WriteSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录写入
        
        @param request: WriteSalaryCalculationRequest
        @param headers: WriteSalaryCalculationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: WriteSalaryCalculationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.date):
            body['date'] = request.date
        if not UtilClient.is_unset(request.items):
            body['items'] = request.items
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
            action='WriteSalaryCalculation',
            version='salary_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/salary/calculation/write',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalksalary__1__0_models.WriteSalaryCalculationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def write_salary_calculation(
        self,
        request: dingtalksalary__1__0_models.WriteSalaryCalculationRequest,
    ) -> dingtalksalary__1__0_models.WriteSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录写入
        
        @param request: WriteSalaryCalculationRequest
        @return: WriteSalaryCalculationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.WriteSalaryCalculationHeaders()
        return self.write_salary_calculation_with_options(request, headers, runtime)

    async def write_salary_calculation_async(
        self,
        request: dingtalksalary__1__0_models.WriteSalaryCalculationRequest,
    ) -> dingtalksalary__1__0_models.WriteSalaryCalculationResponse:
        """
        @summary 小微薪酬获取薪资记录写入
        
        @param request: WriteSalaryCalculationRequest
        @return: WriteSalaryCalculationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalksalary__1__0_models.WriteSalaryCalculationHeaders()
        return await self.write_salary_calculation_with_options_async(request, headers, runtime)
