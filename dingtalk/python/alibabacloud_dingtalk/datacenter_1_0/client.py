# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.datacenter_1_0 import models as dingtalkdatacenter__1__0_models
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

    def close_data_deliver_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.CloseDataDeliverRequest,
        headers: dingtalkdatacenter__1__0_models.CloseDataDeliverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.CloseDataDeliverResponse:
        """
        @summary 关闭数据投递任务
        
        @param request: CloseDataDeliverRequest
        @param headers: CloseDataDeliverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CloseDataDeliverResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.deliver_id):
            query['deliverId'] = request.deliver_id
        if not UtilClient.is_unset(request.dispatching_item_type):
            query['dispatchingItemType'] = request.dispatching_item_type
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
            action='CloseDataDeliver',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataDeliverServices/close',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.CloseDataDeliverResponse(),
            self.execute(params, req, runtime)
        )

    async def close_data_deliver_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.CloseDataDeliverRequest,
        headers: dingtalkdatacenter__1__0_models.CloseDataDeliverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.CloseDataDeliverResponse:
        """
        @summary 关闭数据投递任务
        
        @param request: CloseDataDeliverRequest
        @param headers: CloseDataDeliverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CloseDataDeliverResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.deliver_id):
            query['deliverId'] = request.deliver_id
        if not UtilClient.is_unset(request.dispatching_item_type):
            query['dispatchingItemType'] = request.dispatching_item_type
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
            action='CloseDataDeliver',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataDeliverServices/close',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.CloseDataDeliverResponse(),
            await self.execute_async(params, req, runtime)
        )

    def close_data_deliver(
        self,
        request: dingtalkdatacenter__1__0_models.CloseDataDeliverRequest,
    ) -> dingtalkdatacenter__1__0_models.CloseDataDeliverResponse:
        """
        @summary 关闭数据投递任务
        
        @param request: CloseDataDeliverRequest
        @return: CloseDataDeliverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.CloseDataDeliverHeaders()
        return self.close_data_deliver_with_options(request, headers, runtime)

    async def close_data_deliver_async(
        self,
        request: dingtalkdatacenter__1__0_models.CloseDataDeliverRequest,
    ) -> dingtalkdatacenter__1__0_models.CloseDataDeliverResponse:
        """
        @summary 关闭数据投递任务
        
        @param request: CloseDataDeliverRequest
        @return: CloseDataDeliverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.CloseDataDeliverHeaders()
        return await self.close_data_deliver_with_options_async(request, headers, runtime)

    def create_data_deliver_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.CreateDataDeliverRequest,
        headers: dingtalkdatacenter__1__0_models.CreateDataDeliverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.CreateDataDeliverResponse:
        """
        @summary 创建数据投递
        
        @param request: CreateDataDeliverRequest
        @param headers: CreateDataDeliverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDataDeliverResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.bizcode):
            query['bizcode'] = request.bizcode
        if not UtilClient.is_unset(request.dispatching_cycle):
            query['dispatchingCycle'] = request.dispatching_cycle
        if not UtilClient.is_unset(request.dispatching_item_type):
            query['dispatchingItemType'] = request.dispatching_item_type
        if not UtilClient.is_unset(request.dispatching_start_date):
            query['dispatchingStartDate'] = request.dispatching_start_date
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateDataDeliver',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataDeliveries',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.CreateDataDeliverResponse(),
            self.execute(params, req, runtime)
        )

    async def create_data_deliver_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.CreateDataDeliverRequest,
        headers: dingtalkdatacenter__1__0_models.CreateDataDeliverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.CreateDataDeliverResponse:
        """
        @summary 创建数据投递
        
        @param request: CreateDataDeliverRequest
        @param headers: CreateDataDeliverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDataDeliverResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.bizcode):
            query['bizcode'] = request.bizcode
        if not UtilClient.is_unset(request.dispatching_cycle):
            query['dispatchingCycle'] = request.dispatching_cycle
        if not UtilClient.is_unset(request.dispatching_item_type):
            query['dispatchingItemType'] = request.dispatching_item_type
        if not UtilClient.is_unset(request.dispatching_start_date):
            query['dispatchingStartDate'] = request.dispatching_start_date
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateDataDeliver',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataDeliveries',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.CreateDataDeliverResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_data_deliver(
        self,
        request: dingtalkdatacenter__1__0_models.CreateDataDeliverRequest,
    ) -> dingtalkdatacenter__1__0_models.CreateDataDeliverResponse:
        """
        @summary 创建数据投递
        
        @param request: CreateDataDeliverRequest
        @return: CreateDataDeliverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.CreateDataDeliverHeaders()
        return self.create_data_deliver_with_options(request, headers, runtime)

    async def create_data_deliver_async(
        self,
        request: dingtalkdatacenter__1__0_models.CreateDataDeliverRequest,
    ) -> dingtalkdatacenter__1__0_models.CreateDataDeliverResponse:
        """
        @summary 创建数据投递
        
        @param request: CreateDataDeliverRequest
        @return: CreateDataDeliverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.CreateDataDeliverHeaders()
        return await self.create_data_deliver_with_options_async(request, headers, runtime)

    def create_screen_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.CreateScreenRequest,
        headers: dingtalkdatacenter__1__0_models.CreateScreenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.CreateScreenResponse:
        """
        @summary 新增数据大屏
        
        @param request: CreateScreenRequest
        @param headers: CreateScreenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateScreenResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.template_id):
            query['templateId'] = request.template_id
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
            action='CreateScreen',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/screens',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.CreateScreenResponse(),
            self.execute(params, req, runtime)
        )

    async def create_screen_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.CreateScreenRequest,
        headers: dingtalkdatacenter__1__0_models.CreateScreenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.CreateScreenResponse:
        """
        @summary 新增数据大屏
        
        @param request: CreateScreenRequest
        @param headers: CreateScreenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateScreenResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.template_id):
            query['templateId'] = request.template_id
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
            action='CreateScreen',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/screens',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.CreateScreenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_screen(
        self,
        request: dingtalkdatacenter__1__0_models.CreateScreenRequest,
    ) -> dingtalkdatacenter__1__0_models.CreateScreenResponse:
        """
        @summary 新增数据大屏
        
        @param request: CreateScreenRequest
        @return: CreateScreenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.CreateScreenHeaders()
        return self.create_screen_with_options(request, headers, runtime)

    async def create_screen_async(
        self,
        request: dingtalkdatacenter__1__0_models.CreateScreenRequest,
    ) -> dingtalkdatacenter__1__0_models.CreateScreenResponse:
        """
        @summary 新增数据大屏
        
        @param request: CreateScreenRequest
        @return: CreateScreenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.CreateScreenHeaders()
        return await self.create_screen_with_options_async(request, headers, runtime)

    def get_abnormal_operation_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetAbnormalOperationRequest,
        headers: dingtalkdatacenter__1__0_models.GetAbnormalOperationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse:
        """
        @summary 工商-经营异常
        
        @param request: GetAbnormalOperationRequest
        @param headers: GetAbnormalOperationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAbnormalOperationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetAbnormalOperation',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/abnormalOperations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse(),
            self.execute(params, req, runtime)
        )

    async def get_abnormal_operation_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetAbnormalOperationRequest,
        headers: dingtalkdatacenter__1__0_models.GetAbnormalOperationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse:
        """
        @summary 工商-经营异常
        
        @param request: GetAbnormalOperationRequest
        @param headers: GetAbnormalOperationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAbnormalOperationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetAbnormalOperation',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/abnormalOperations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_abnormal_operation(
        self,
        request: dingtalkdatacenter__1__0_models.GetAbnormalOperationRequest,
    ) -> dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse:
        """
        @summary 工商-经营异常
        
        @param request: GetAbnormalOperationRequest
        @return: GetAbnormalOperationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetAbnormalOperationHeaders()
        return self.get_abnormal_operation_with_options(request, headers, runtime)

    async def get_abnormal_operation_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetAbnormalOperationRequest,
    ) -> dingtalkdatacenter__1__0_models.GetAbnormalOperationResponse:
        """
        @summary 工商-经营异常
        
        @param request: GetAbnormalOperationRequest
        @return: GetAbnormalOperationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetAbnormalOperationHeaders()
        return await self.get_abnormal_operation_with_options_async(request, headers, runtime)

    def get_administrative_licensing_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativeLicensingRequest,
        headers: dingtalkdatacenter__1__0_models.GetAdministrativeLicensingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativeLicensingResponse:
        """
        @summary 获取工商-行政许可
        
        @param request: GetAdministrativeLicensingRequest
        @param headers: GetAdministrativeLicensingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAdministrativeLicensingResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetAdministrativeLicensing',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/administrativeLicenses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetAdministrativeLicensingResponse(),
            self.execute(params, req, runtime)
        )

    async def get_administrative_licensing_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativeLicensingRequest,
        headers: dingtalkdatacenter__1__0_models.GetAdministrativeLicensingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativeLicensingResponse:
        """
        @summary 获取工商-行政许可
        
        @param request: GetAdministrativeLicensingRequest
        @param headers: GetAdministrativeLicensingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAdministrativeLicensingResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetAdministrativeLicensing',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/administrativeLicenses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetAdministrativeLicensingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_administrative_licensing(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativeLicensingRequest,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativeLicensingResponse:
        """
        @summary 获取工商-行政许可
        
        @param request: GetAdministrativeLicensingRequest
        @return: GetAdministrativeLicensingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetAdministrativeLicensingHeaders()
        return self.get_administrative_licensing_with_options(request, headers, runtime)

    async def get_administrative_licensing_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativeLicensingRequest,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativeLicensingResponse:
        """
        @summary 获取工商-行政许可
        
        @param request: GetAdministrativeLicensingRequest
        @return: GetAdministrativeLicensingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetAdministrativeLicensingHeaders()
        return await self.get_administrative_licensing_with_options_async(request, headers, runtime)

    def get_administrative_penalties_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesRequest,
        headers: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse:
        """
        @summary 负面-行政处罚
        
        @param request: GetAdministrativePenaltiesRequest
        @param headers: GetAdministrativePenaltiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAdministrativePenaltiesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetAdministrativePenalties',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/administrativePenalties',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_administrative_penalties_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesRequest,
        headers: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse:
        """
        @summary 负面-行政处罚
        
        @param request: GetAdministrativePenaltiesRequest
        @param headers: GetAdministrativePenaltiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAdministrativePenaltiesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetAdministrativePenalties',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/administrativePenalties',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_administrative_penalties(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesRequest,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse:
        """
        @summary 负面-行政处罚
        
        @param request: GetAdministrativePenaltiesRequest
        @return: GetAdministrativePenaltiesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesHeaders()
        return self.get_administrative_penalties_with_options(request, headers, runtime)

    async def get_administrative_penalties_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesRequest,
    ) -> dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesResponse:
        """
        @summary 负面-行政处罚
        
        @param request: GetAdministrativePenaltiesRequest
        @return: GetAdministrativePenaltiesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetAdministrativePenaltiesHeaders()
        return await self.get_administrative_penalties_with_options_async(request, headers, runtime)

    def get_basic_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetBasicInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetBasicInfoResponse:
        """
        @summary 工商-基础信息
        
        @param request: GetBasicInfoRequest
        @param headers: GetBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBasicInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetBasicInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/businessBasicInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetBasicInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_basic_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetBasicInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetBasicInfoResponse:
        """
        @summary 工商-基础信息
        
        @param request: GetBasicInfoRequest
        @param headers: GetBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBasicInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetBasicInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/businessBasicInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetBasicInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_basic_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetBasicInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetBasicInfoResponse:
        """
        @summary 工商-基础信息
        
        @param request: GetBasicInfoRequest
        @return: GetBasicInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetBasicInfoHeaders()
        return self.get_basic_info_with_options(request, headers, runtime)

    async def get_basic_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetBasicInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetBasicInfoResponse:
        """
        @summary 工商-基础信息
        
        @param request: GetBasicInfoRequest
        @return: GetBasicInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetBasicInfoHeaders()
        return await self.get_basic_info_with_options_async(request, headers, runtime)

    def get_bidding_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetBiddingInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetBiddingInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetBiddingInfoResponse:
        """
        @summary 获取经营-招投标信息
        
        @param request: GetBiddingInfoRequest
        @param headers: GetBiddingInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBiddingInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetBiddingInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/biddingInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetBiddingInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_bidding_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetBiddingInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetBiddingInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetBiddingInfoResponse:
        """
        @summary 获取经营-招投标信息
        
        @param request: GetBiddingInfoRequest
        @param headers: GetBiddingInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBiddingInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetBiddingInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/biddingInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetBiddingInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_bidding_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetBiddingInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetBiddingInfoResponse:
        """
        @summary 获取经营-招投标信息
        
        @param request: GetBiddingInfoRequest
        @return: GetBiddingInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetBiddingInfoHeaders()
        return self.get_bidding_info_with_options(request, headers, runtime)

    async def get_bidding_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetBiddingInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetBiddingInfoResponse:
        """
        @summary 获取经营-招投标信息
        
        @param request: GetBiddingInfoRequest
        @return: GetBiddingInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetBiddingInfoHeaders()
        return await self.get_bidding_info_with_options_async(request, headers, runtime)

    def get_branch_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetBranchInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetBranchInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetBranchInfoResponse:
        """
        @summary 获取工商-分支机构
        
        @param request: GetBranchInfoRequest
        @param headers: GetBranchInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBranchInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetBranchInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/branchInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetBranchInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_branch_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetBranchInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetBranchInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetBranchInfoResponse:
        """
        @summary 获取工商-分支机构
        
        @param request: GetBranchInfoRequest
        @param headers: GetBranchInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBranchInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetBranchInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/branchInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetBranchInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_branch_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetBranchInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetBranchInfoResponse:
        """
        @summary 获取工商-分支机构
        
        @param request: GetBranchInfoRequest
        @return: GetBranchInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetBranchInfoHeaders()
        return self.get_branch_info_with_options(request, headers, runtime)

    async def get_branch_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetBranchInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetBranchInfoResponse:
        """
        @summary 获取工商-分支机构
        
        @param request: GetBranchInfoRequest
        @return: GetBranchInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetBranchInfoHeaders()
        return await self.get_branch_info_with_options_async(request, headers, runtime)

    def get_change_record_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetChangeRecordRequest,
        headers: dingtalkdatacenter__1__0_models.GetChangeRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetChangeRecordResponse:
        """
        @summary 获取工商-变更记录
        
        @param request: GetChangeRecordRequest
        @param headers: GetChangeRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetChangeRecordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetChangeRecord',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/changeRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetChangeRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def get_change_record_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetChangeRecordRequest,
        headers: dingtalkdatacenter__1__0_models.GetChangeRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetChangeRecordResponse:
        """
        @summary 获取工商-变更记录
        
        @param request: GetChangeRecordRequest
        @param headers: GetChangeRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetChangeRecordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetChangeRecord',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/changeRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetChangeRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_change_record(
        self,
        request: dingtalkdatacenter__1__0_models.GetChangeRecordRequest,
    ) -> dingtalkdatacenter__1__0_models.GetChangeRecordResponse:
        """
        @summary 获取工商-变更记录
        
        @param request: GetChangeRecordRequest
        @return: GetChangeRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetChangeRecordHeaders()
        return self.get_change_record_with_options(request, headers, runtime)

    async def get_change_record_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetChangeRecordRequest,
    ) -> dingtalkdatacenter__1__0_models.GetChangeRecordResponse:
        """
        @summary 获取工商-变更记录
        
        @param request: GetChangeRecordRequest
        @return: GetChangeRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetChangeRecordHeaders()
        return await self.get_change_record_with_options_async(request, headers, runtime)

    def get_data_deliver_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetDataDeliverRequest,
        headers: dingtalkdatacenter__1__0_models.GetDataDeliverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetDataDeliverResponse:
        """
        @summary 获取投递任务信息
        
        @param request: GetDataDeliverRequest
        @param headers: GetDataDeliverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDataDeliverResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.deliver_id):
            query['deliverId'] = request.deliver_id
        if not UtilClient.is_unset(request.dispatching_item_type):
            query['dispatchingItemType'] = request.dispatching_item_type
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
            action='GetDataDeliver',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataDeliverServices/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetDataDeliverResponse(),
            self.execute(params, req, runtime)
        )

    async def get_data_deliver_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetDataDeliverRequest,
        headers: dingtalkdatacenter__1__0_models.GetDataDeliverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetDataDeliverResponse:
        """
        @summary 获取投递任务信息
        
        @param request: GetDataDeliverRequest
        @param headers: GetDataDeliverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDataDeliverResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.deliver_id):
            query['deliverId'] = request.deliver_id
        if not UtilClient.is_unset(request.dispatching_item_type):
            query['dispatchingItemType'] = request.dispatching_item_type
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
            action='GetDataDeliver',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataDeliverServices/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetDataDeliverResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_data_deliver(
        self,
        request: dingtalkdatacenter__1__0_models.GetDataDeliverRequest,
    ) -> dingtalkdatacenter__1__0_models.GetDataDeliverResponse:
        """
        @summary 获取投递任务信息
        
        @param request: GetDataDeliverRequest
        @return: GetDataDeliverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetDataDeliverHeaders()
        return self.get_data_deliver_with_options(request, headers, runtime)

    async def get_data_deliver_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetDataDeliverRequest,
    ) -> dingtalkdatacenter__1__0_models.GetDataDeliverResponse:
        """
        @summary 获取投递任务信息
        
        @param request: GetDataDeliverRequest
        @return: GetDataDeliverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetDataDeliverHeaders()
        return await self.get_data_deliver_with_options_async(request, headers, runtime)

    def get_domain_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetDomainInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetDomainInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetDomainInfoResponse:
        """
        @summary 获取知识产权-域名信息
        
        @param request: GetDomainInfoRequest
        @param headers: GetDomainInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDomainInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetDomainInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/domainInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetDomainInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_domain_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetDomainInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetDomainInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetDomainInfoResponse:
        """
        @summary 获取知识产权-域名信息
        
        @param request: GetDomainInfoRequest
        @param headers: GetDomainInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDomainInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetDomainInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/domainInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetDomainInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_domain_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetDomainInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetDomainInfoResponse:
        """
        @summary 获取知识产权-域名信息
        
        @param request: GetDomainInfoRequest
        @return: GetDomainInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetDomainInfoHeaders()
        return self.get_domain_info_with_options(request, headers, runtime)

    async def get_domain_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetDomainInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetDomainInfoResponse:
        """
        @summary 获取知识产权-域名信息
        
        @param request: GetDomainInfoRequest
        @return: GetDomainInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetDomainInfoHeaders()
        return await self.get_domain_info_with_options_async(request, headers, runtime)

    def get_double_random_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetDoubleRandomRequest,
        headers: dingtalkdatacenter__1__0_models.GetDoubleRandomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetDoubleRandomResponse:
        """
        @summary 获取工商-双随机抽查结果
        
        @param request: GetDoubleRandomRequest
        @param headers: GetDoubleRandomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDoubleRandomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetDoubleRandom',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/doubleRandomness',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetDoubleRandomResponse(),
            self.execute(params, req, runtime)
        )

    async def get_double_random_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetDoubleRandomRequest,
        headers: dingtalkdatacenter__1__0_models.GetDoubleRandomHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetDoubleRandomResponse:
        """
        @summary 获取工商-双随机抽查结果
        
        @param request: GetDoubleRandomRequest
        @param headers: GetDoubleRandomHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDoubleRandomResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetDoubleRandom',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/doubleRandomness',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetDoubleRandomResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_double_random(
        self,
        request: dingtalkdatacenter__1__0_models.GetDoubleRandomRequest,
    ) -> dingtalkdatacenter__1__0_models.GetDoubleRandomResponse:
        """
        @summary 获取工商-双随机抽查结果
        
        @param request: GetDoubleRandomRequest
        @return: GetDoubleRandomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetDoubleRandomHeaders()
        return self.get_double_random_with_options(request, headers, runtime)

    async def get_double_random_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetDoubleRandomRequest,
    ) -> dingtalkdatacenter__1__0_models.GetDoubleRandomResponse:
        """
        @summary 获取工商-双随机抽查结果
        
        @param request: GetDoubleRandomRequest
        @return: GetDoubleRandomResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetDoubleRandomHeaders()
        return await self.get_double_random_with_options_async(request, headers, runtime)

    def get_environmental_penalties_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesRequest,
        headers: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse:
        """
        @summary 负面-环保处罚
        
        @param request: GetEnvironmentalPenaltiesRequest
        @param headers: GetEnvironmentalPenaltiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEnvironmentalPenaltiesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetEnvironmentalPenalties',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/environmentalPenalties',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_environmental_penalties_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesRequest,
        headers: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse:
        """
        @summary 负面-环保处罚
        
        @param request: GetEnvironmentalPenaltiesRequest
        @param headers: GetEnvironmentalPenaltiesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEnvironmentalPenaltiesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetEnvironmentalPenalties',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/environmentalPenalties',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_environmental_penalties(
        self,
        request: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesRequest,
    ) -> dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse:
        """
        @summary 负面-环保处罚
        
        @param request: GetEnvironmentalPenaltiesRequest
        @return: GetEnvironmentalPenaltiesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesHeaders()
        return self.get_environmental_penalties_with_options(request, headers, runtime)

    async def get_environmental_penalties_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesRequest,
    ) -> dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesResponse:
        """
        @summary 负面-环保处罚
        
        @param request: GetEnvironmentalPenaltiesRequest
        @return: GetEnvironmentalPenaltiesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetEnvironmentalPenaltiesHeaders()
        return await self.get_environmental_penalties_with_options_async(request, headers, runtime)

    def get_event_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetEventDataRequest,
        headers: dingtalkdatacenter__1__0_models.GetEventDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetEventDataResponse:
        """
        @summary 获取事件订阅的数据
        
        @param request: GetEventDataRequest
        @param headers: GetEventDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEventDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.event_uid):
            body['eventUid'] = request.event_uid
        if not UtilClient.is_unset(request.sub_id):
            body['subId'] = request.sub_id
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
            action='GetEventData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/eventDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetEventDataResponse(),
            self.execute(params, req, runtime)
        )

    async def get_event_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetEventDataRequest,
        headers: dingtalkdatacenter__1__0_models.GetEventDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetEventDataResponse:
        """
        @summary 获取事件订阅的数据
        
        @param request: GetEventDataRequest
        @param headers: GetEventDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEventDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.event_uid):
            body['eventUid'] = request.event_uid
        if not UtilClient.is_unset(request.sub_id):
            body['subId'] = request.sub_id
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
            action='GetEventData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/eventDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetEventDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_event_data(
        self,
        request: dingtalkdatacenter__1__0_models.GetEventDataRequest,
    ) -> dingtalkdatacenter__1__0_models.GetEventDataResponse:
        """
        @summary 获取事件订阅的数据
        
        @param request: GetEventDataRequest
        @return: GetEventDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetEventDataHeaders()
        return self.get_event_data_with_options(request, headers, runtime)

    async def get_event_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetEventDataRequest,
    ) -> dingtalkdatacenter__1__0_models.GetEventDataResponse:
        """
        @summary 获取事件订阅的数据
        
        @param request: GetEventDataRequest
        @return: GetEventDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetEventDataHeaders()
        return await self.get_event_data_with_options_async(request, headers, runtime)

    def get_holder_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetHolderInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetHolderInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetHolderInfoResponse:
        """
        @summary 工商-股东信息
        
        @param request: GetHolderInfoRequest
        @param headers: GetHolderInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetHolderInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetHolderInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/shareholderInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetHolderInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_holder_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetHolderInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetHolderInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetHolderInfoResponse:
        """
        @summary 工商-股东信息
        
        @param request: GetHolderInfoRequest
        @param headers: GetHolderInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetHolderInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetHolderInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/shareholderInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetHolderInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_holder_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetHolderInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetHolderInfoResponse:
        """
        @summary 工商-股东信息
        
        @param request: GetHolderInfoRequest
        @return: GetHolderInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetHolderInfoHeaders()
        return self.get_holder_info_with_options(request, headers, runtime)

    async def get_holder_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetHolderInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetHolderInfoResponse:
        """
        @summary 工商-股东信息
        
        @param request: GetHolderInfoRequest
        @return: GetHolderInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetHolderInfoHeaders()
        return await self.get_holder_info_with_options_async(request, headers, runtime)

    def get_intellectual_property_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetIntellectualPropertyRequest,
        headers: dingtalkdatacenter__1__0_models.GetIntellectualPropertyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetIntellectualPropertyResponse:
        """
        @summary 获取工商-知识产权出质
        
        @param request: GetIntellectualPropertyRequest
        @param headers: GetIntellectualPropertyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetIntellectualPropertyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetIntellectualProperty',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/intellectualProperties',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetIntellectualPropertyResponse(),
            self.execute(params, req, runtime)
        )

    async def get_intellectual_property_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetIntellectualPropertyRequest,
        headers: dingtalkdatacenter__1__0_models.GetIntellectualPropertyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetIntellectualPropertyResponse:
        """
        @summary 获取工商-知识产权出质
        
        @param request: GetIntellectualPropertyRequest
        @param headers: GetIntellectualPropertyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetIntellectualPropertyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetIntellectualProperty',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/intellectualProperties',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetIntellectualPropertyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_intellectual_property(
        self,
        request: dingtalkdatacenter__1__0_models.GetIntellectualPropertyRequest,
    ) -> dingtalkdatacenter__1__0_models.GetIntellectualPropertyResponse:
        """
        @summary 获取工商-知识产权出质
        
        @param request: GetIntellectualPropertyRequest
        @return: GetIntellectualPropertyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetIntellectualPropertyHeaders()
        return self.get_intellectual_property_with_options(request, headers, runtime)

    async def get_intellectual_property_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetIntellectualPropertyRequest,
    ) -> dingtalkdatacenter__1__0_models.GetIntellectualPropertyResponse:
        """
        @summary 获取工商-知识产权出质
        
        @param request: GetIntellectualPropertyRequest
        @return: GetIntellectualPropertyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetIntellectualPropertyHeaders()
        return await self.get_intellectual_property_with_options_async(request, headers, runtime)

    def get_investment_abroad_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetInvestmentAbroadRequest,
        headers: dingtalkdatacenter__1__0_models.GetInvestmentAbroadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetInvestmentAbroadResponse:
        """
        @summary 获取工商-对外投资
        
        @param request: GetInvestmentAbroadRequest
        @param headers: GetInvestmentAbroadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInvestmentAbroadResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetInvestmentAbroad',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/abroadInvestments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetInvestmentAbroadResponse(),
            self.execute(params, req, runtime)
        )

    async def get_investment_abroad_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetInvestmentAbroadRequest,
        headers: dingtalkdatacenter__1__0_models.GetInvestmentAbroadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetInvestmentAbroadResponse:
        """
        @summary 获取工商-对外投资
        
        @param request: GetInvestmentAbroadRequest
        @param headers: GetInvestmentAbroadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInvestmentAbroadResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetInvestmentAbroad',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/abroadInvestments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetInvestmentAbroadResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_investment_abroad(
        self,
        request: dingtalkdatacenter__1__0_models.GetInvestmentAbroadRequest,
    ) -> dingtalkdatacenter__1__0_models.GetInvestmentAbroadResponse:
        """
        @summary 获取工商-对外投资
        
        @param request: GetInvestmentAbroadRequest
        @return: GetInvestmentAbroadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetInvestmentAbroadHeaders()
        return self.get_investment_abroad_with_options(request, headers, runtime)

    async def get_investment_abroad_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetInvestmentAbroadRequest,
    ) -> dingtalkdatacenter__1__0_models.GetInvestmentAbroadResponse:
        """
        @summary 获取工商-对外投资
        
        @param request: GetInvestmentAbroadRequest
        @return: GetInvestmentAbroadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetInvestmentAbroadHeaders()
        return await self.get_investment_abroad_with_options_async(request, headers, runtime)

    def get_job_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetJobInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetJobInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetJobInfoResponse:
        """
        @summary 获取经营-招聘信息
        
        @param request: GetJobInfoRequest
        @param headers: GetJobInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetJobInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetJobInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/jobInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetJobInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_job_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetJobInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetJobInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetJobInfoResponse:
        """
        @summary 获取经营-招聘信息
        
        @param request: GetJobInfoRequest
        @param headers: GetJobInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetJobInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetJobInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/jobInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetJobInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_job_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetJobInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetJobInfoResponse:
        """
        @summary 获取经营-招聘信息
        
        @param request: GetJobInfoRequest
        @return: GetJobInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetJobInfoHeaders()
        return self.get_job_info_with_options(request, headers, runtime)

    async def get_job_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetJobInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetJobInfoResponse:
        """
        @summary 获取经营-招聘信息
        
        @param request: GetJobInfoRequest
        @return: GetJobInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetJobInfoHeaders()
        return await self.get_job_info_with_options_async(request, headers, runtime)

    def get_patent_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetPatentInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetPatentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetPatentInfoResponse:
        """
        @summary 获取知识产权-专利信息
        
        @param request: GetPatentInfoRequest
        @param headers: GetPatentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPatentInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetPatentInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/patentInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetPatentInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_patent_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetPatentInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetPatentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetPatentInfoResponse:
        """
        @summary 获取知识产权-专利信息
        
        @param request: GetPatentInfoRequest
        @param headers: GetPatentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPatentInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetPatentInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/patentInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetPatentInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_patent_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetPatentInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetPatentInfoResponse:
        """
        @summary 获取知识产权-专利信息
        
        @param request: GetPatentInfoRequest
        @return: GetPatentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetPatentInfoHeaders()
        return self.get_patent_info_with_options(request, headers, runtime)

    async def get_patent_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetPatentInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetPatentInfoResponse:
        """
        @summary 获取知识产权-专利信息
        
        @param request: GetPatentInfoRequest
        @return: GetPatentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetPatentInfoHeaders()
        return await self.get_patent_info_with_options_async(request, headers, runtime)

    def get_principal_employee_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetPrincipalEmployeeRequest,
        headers: dingtalkdatacenter__1__0_models.GetPrincipalEmployeeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetPrincipalEmployeeResponse:
        """
        @summary 获取工商-主要人员
        
        @param request: GetPrincipalEmployeeRequest
        @param headers: GetPrincipalEmployeeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPrincipalEmployeeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetPrincipalEmployee',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/principalEmployees',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetPrincipalEmployeeResponse(),
            self.execute(params, req, runtime)
        )

    async def get_principal_employee_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetPrincipalEmployeeRequest,
        headers: dingtalkdatacenter__1__0_models.GetPrincipalEmployeeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetPrincipalEmployeeResponse:
        """
        @summary 获取工商-主要人员
        
        @param request: GetPrincipalEmployeeRequest
        @param headers: GetPrincipalEmployeeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPrincipalEmployeeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetPrincipalEmployee',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/principalEmployees',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetPrincipalEmployeeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_principal_employee(
        self,
        request: dingtalkdatacenter__1__0_models.GetPrincipalEmployeeRequest,
    ) -> dingtalkdatacenter__1__0_models.GetPrincipalEmployeeResponse:
        """
        @summary 获取工商-主要人员
        
        @param request: GetPrincipalEmployeeRequest
        @return: GetPrincipalEmployeeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetPrincipalEmployeeHeaders()
        return self.get_principal_employee_with_options(request, headers, runtime)

    async def get_principal_employee_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetPrincipalEmployeeRequest,
    ) -> dingtalkdatacenter__1__0_models.GetPrincipalEmployeeResponse:
        """
        @summary 获取工商-主要人员
        
        @param request: GetPrincipalEmployeeRequest
        @return: GetPrincipalEmployeeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetPrincipalEmployeeHeaders()
        return await self.get_principal_employee_with_options_async(request, headers, runtime)

    def get_qeneral_taxpayer_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse:
        """
        @summary 经营-一般纳税人
        
        @param request: GetQeneralTaxpayerInfoRequest
        @param headers: GetQeneralTaxpayerInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetQeneralTaxpayerInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetQeneralTaxpayerInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/generalTaxpayerInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_qeneral_taxpayer_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse:
        """
        @summary 经营-一般纳税人
        
        @param request: GetQeneralTaxpayerInfoRequest
        @param headers: GetQeneralTaxpayerInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetQeneralTaxpayerInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetQeneralTaxpayerInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/generalTaxpayerInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_qeneral_taxpayer_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse:
        """
        @summary 经营-一般纳税人
        
        @param request: GetQeneralTaxpayerInfoRequest
        @return: GetQeneralTaxpayerInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoHeaders()
        return self.get_qeneral_taxpayer_info_with_options(request, headers, runtime)

    async def get_qeneral_taxpayer_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoResponse:
        """
        @summary 经营-一般纳税人
        
        @param request: GetQeneralTaxpayerInfoRequest
        @return: GetQeneralTaxpayerInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetQeneralTaxpayerInfoHeaders()
        return await self.get_qeneral_taxpayer_info_with_options_async(request, headers, runtime)

    def get_qualification_cert_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetQualificationCertRequest,
        headers: dingtalkdatacenter__1__0_models.GetQualificationCertHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetQualificationCertResponse:
        """
        @summary 获取知识产权-资质证书
        
        @param request: GetQualificationCertRequest
        @param headers: GetQualificationCertHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetQualificationCertResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetQualificationCert',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/qualificationCerts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetQualificationCertResponse(),
            self.execute(params, req, runtime)
        )

    async def get_qualification_cert_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetQualificationCertRequest,
        headers: dingtalkdatacenter__1__0_models.GetQualificationCertHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetQualificationCertResponse:
        """
        @summary 获取知识产权-资质证书
        
        @param request: GetQualificationCertRequest
        @param headers: GetQualificationCertHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetQualificationCertResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetQualificationCert',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/qualificationCerts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetQualificationCertResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_qualification_cert(
        self,
        request: dingtalkdatacenter__1__0_models.GetQualificationCertRequest,
    ) -> dingtalkdatacenter__1__0_models.GetQualificationCertResponse:
        """
        @summary 获取知识产权-资质证书
        
        @param request: GetQualificationCertRequest
        @return: GetQualificationCertResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetQualificationCertHeaders()
        return self.get_qualification_cert_with_options(request, headers, runtime)

    async def get_qualification_cert_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetQualificationCertRequest,
    ) -> dingtalkdatacenter__1__0_models.GetQualificationCertResponse:
        """
        @summary 获取知识产权-资质证书
        
        @param request: GetQualificationCertRequest
        @return: GetQualificationCertResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetQualificationCertHeaders()
        return await self.get_qualification_cert_with_options_async(request, headers, runtime)

    def get_serious_violation_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetSeriousViolationRequest,
        headers: dingtalkdatacenter__1__0_models.GetSeriousViolationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetSeriousViolationResponse:
        """
        @summary 负面-严重违法
        
        @param request: GetSeriousViolationRequest
        @param headers: GetSeriousViolationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSeriousViolationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetSeriousViolation',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/seriousViolations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetSeriousViolationResponse(),
            self.execute(params, req, runtime)
        )

    async def get_serious_violation_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetSeriousViolationRequest,
        headers: dingtalkdatacenter__1__0_models.GetSeriousViolationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetSeriousViolationResponse:
        """
        @summary 负面-严重违法
        
        @param request: GetSeriousViolationRequest
        @param headers: GetSeriousViolationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSeriousViolationResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetSeriousViolation',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/seriousViolations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetSeriousViolationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_serious_violation(
        self,
        request: dingtalkdatacenter__1__0_models.GetSeriousViolationRequest,
    ) -> dingtalkdatacenter__1__0_models.GetSeriousViolationResponse:
        """
        @summary 负面-严重违法
        
        @param request: GetSeriousViolationRequest
        @return: GetSeriousViolationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetSeriousViolationHeaders()
        return self.get_serious_violation_with_options(request, headers, runtime)

    async def get_serious_violation_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetSeriousViolationRequest,
    ) -> dingtalkdatacenter__1__0_models.GetSeriousViolationResponse:
        """
        @summary 负面-严重违法
        
        @param request: GetSeriousViolationRequest
        @return: GetSeriousViolationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetSeriousViolationHeaders()
        return await self.get_serious_violation_with_options_async(request, headers, runtime)

    def get_software_copyright_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetSoftwareCopyrightRequest,
        headers: dingtalkdatacenter__1__0_models.GetSoftwareCopyrightHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetSoftwareCopyrightResponse:
        """
        @summary 获取知识产权-软件著作权
        
        @param request: GetSoftwareCopyrightRequest
        @param headers: GetSoftwareCopyrightHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSoftwareCopyrightResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetSoftwareCopyright',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/softwareCopyrights',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetSoftwareCopyrightResponse(),
            self.execute(params, req, runtime)
        )

    async def get_software_copyright_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetSoftwareCopyrightRequest,
        headers: dingtalkdatacenter__1__0_models.GetSoftwareCopyrightHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetSoftwareCopyrightResponse:
        """
        @summary 获取知识产权-软件著作权
        
        @param request: GetSoftwareCopyrightRequest
        @param headers: GetSoftwareCopyrightHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSoftwareCopyrightResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetSoftwareCopyright',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/softwareCopyrights',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetSoftwareCopyrightResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_software_copyright(
        self,
        request: dingtalkdatacenter__1__0_models.GetSoftwareCopyrightRequest,
    ) -> dingtalkdatacenter__1__0_models.GetSoftwareCopyrightResponse:
        """
        @summary 获取知识产权-软件著作权
        
        @param request: GetSoftwareCopyrightRequest
        @return: GetSoftwareCopyrightResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetSoftwareCopyrightHeaders()
        return self.get_software_copyright_with_options(request, headers, runtime)

    async def get_software_copyright_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetSoftwareCopyrightRequest,
    ) -> dingtalkdatacenter__1__0_models.GetSoftwareCopyrightResponse:
        """
        @summary 获取知识产权-软件著作权
        
        @param request: GetSoftwareCopyrightRequest
        @return: GetSoftwareCopyrightResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetSoftwareCopyrightHeaders()
        return await self.get_software_copyright_with_options_async(request, headers, runtime)

    def get_trademark_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetTrademarkInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetTrademarkInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetTrademarkInfoResponse:
        """
        @summary 获取知识产权-商标信息
        
        @param request: GetTrademarkInfoRequest
        @param headers: GetTrademarkInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTrademarkInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetTrademarkInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/trademarkInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetTrademarkInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_trademark_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetTrademarkInfoRequest,
        headers: dingtalkdatacenter__1__0_models.GetTrademarkInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetTrademarkInfoResponse:
        """
        @summary 获取知识产权-商标信息
        
        @param request: GetTrademarkInfoRequest
        @param headers: GetTrademarkInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTrademarkInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetTrademarkInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/trademarkInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetTrademarkInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_trademark_info(
        self,
        request: dingtalkdatacenter__1__0_models.GetTrademarkInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetTrademarkInfoResponse:
        """
        @summary 获取知识产权-商标信息
        
        @param request: GetTrademarkInfoRequest
        @return: GetTrademarkInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetTrademarkInfoHeaders()
        return self.get_trademark_info_with_options(request, headers, runtime)

    async def get_trademark_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetTrademarkInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.GetTrademarkInfoResponse:
        """
        @summary 获取知识产权-商标信息
        
        @param request: GetTrademarkInfoRequest
        @return: GetTrademarkInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetTrademarkInfoHeaders()
        return await self.get_trademark_info_with_options_async(request, headers, runtime)

    def get_work_copyright_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.GetWorkCopyrightRequest,
        headers: dingtalkdatacenter__1__0_models.GetWorkCopyrightHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetWorkCopyrightResponse:
        """
        @summary 获取知识产权-作品著作权
        
        @param request: GetWorkCopyrightRequest
        @param headers: GetWorkCopyrightHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWorkCopyrightResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetWorkCopyright',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/workCopyrights',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetWorkCopyrightResponse(),
            self.execute(params, req, runtime)
        )

    async def get_work_copyright_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetWorkCopyrightRequest,
        headers: dingtalkdatacenter__1__0_models.GetWorkCopyrightHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.GetWorkCopyrightResponse:
        """
        @summary 获取知识产权-作品著作权
        
        @param request: GetWorkCopyrightRequest
        @param headers: GetWorkCopyrightHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWorkCopyrightResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='GetWorkCopyright',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/workCopyrights',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.GetWorkCopyrightResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_work_copyright(
        self,
        request: dingtalkdatacenter__1__0_models.GetWorkCopyrightRequest,
    ) -> dingtalkdatacenter__1__0_models.GetWorkCopyrightResponse:
        """
        @summary 获取知识产权-作品著作权
        
        @param request: GetWorkCopyrightRequest
        @return: GetWorkCopyrightResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetWorkCopyrightHeaders()
        return self.get_work_copyright_with_options(request, headers, runtime)

    async def get_work_copyright_async(
        self,
        request: dingtalkdatacenter__1__0_models.GetWorkCopyrightRequest,
    ) -> dingtalkdatacenter__1__0_models.GetWorkCopyrightResponse:
        """
        @summary 获取知识产权-作品著作权
        
        @param request: GetWorkCopyrightRequest
        @return: GetWorkCopyrightResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.GetWorkCopyrightHeaders()
        return await self.get_work_copyright_with_options_async(request, headers, runtime)

    def list_data_delivers_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.ListDataDeliversRequest,
        headers: dingtalkdatacenter__1__0_models.ListDataDeliversHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.ListDataDeliversResponse:
        """
        @summary 数据投递列表
        
        @param request: ListDataDeliversRequest
        @param headers: ListDataDeliversHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListDataDeliversResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dispatching_item_type):
            query['dispatchingItemType'] = request.dispatching_item_type
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
            action='ListDataDelivers',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataDeliverServices/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.ListDataDeliversResponse(),
            self.execute(params, req, runtime)
        )

    async def list_data_delivers_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.ListDataDeliversRequest,
        headers: dingtalkdatacenter__1__0_models.ListDataDeliversHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.ListDataDeliversResponse:
        """
        @summary 数据投递列表
        
        @param request: ListDataDeliversRequest
        @param headers: ListDataDeliversHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListDataDeliversResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dispatching_item_type):
            query['dispatchingItemType'] = request.dispatching_item_type
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
            action='ListDataDelivers',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataDeliverServices/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.ListDataDeliversResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_data_delivers(
        self,
        request: dingtalkdatacenter__1__0_models.ListDataDeliversRequest,
    ) -> dingtalkdatacenter__1__0_models.ListDataDeliversResponse:
        """
        @summary 数据投递列表
        
        @param request: ListDataDeliversRequest
        @return: ListDataDeliversResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.ListDataDeliversHeaders()
        return self.list_data_delivers_with_options(request, headers, runtime)

    async def list_data_delivers_async(
        self,
        request: dingtalkdatacenter__1__0_models.ListDataDeliversRequest,
    ) -> dingtalkdatacenter__1__0_models.ListDataDeliversResponse:
        """
        @summary 数据投递列表
        
        @param request: ListDataDeliversRequest
        @return: ListDataDeliversResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.ListDataDeliversHeaders()
        return await self.list_data_delivers_with_options_async(request, headers, runtime)

    def operate_chart_config_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.OperateChartConfigRequest,
        headers: dingtalkdatacenter__1__0_models.OperateChartConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.OperateChartConfigResponse:
        """
        @summary 操作表格配置
        
        @param request: OperateChartConfigRequest
        @param headers: OperateChartConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OperateChartConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_key):
            body['apiKey'] = request.api_key
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        if not UtilClient.is_unset(request.ticket):
            body['ticket'] = request.ticket
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
            action='OperateChartConfig',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/chartConfigs/operate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.OperateChartConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def operate_chart_config_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.OperateChartConfigRequest,
        headers: dingtalkdatacenter__1__0_models.OperateChartConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.OperateChartConfigResponse:
        """
        @summary 操作表格配置
        
        @param request: OperateChartConfigRequest
        @param headers: OperateChartConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OperateChartConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_key):
            body['apiKey'] = request.api_key
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        if not UtilClient.is_unset(request.ticket):
            body['ticket'] = request.ticket
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
            action='OperateChartConfig',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/chartConfigs/operate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.OperateChartConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def operate_chart_config(
        self,
        request: dingtalkdatacenter__1__0_models.OperateChartConfigRequest,
    ) -> dingtalkdatacenter__1__0_models.OperateChartConfigResponse:
        """
        @summary 操作表格配置
        
        @param request: OperateChartConfigRequest
        @return: OperateChartConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.OperateChartConfigHeaders()
        return self.operate_chart_config_with_options(request, headers, runtime)

    async def operate_chart_config_async(
        self,
        request: dingtalkdatacenter__1__0_models.OperateChartConfigRequest,
    ) -> dingtalkdatacenter__1__0_models.OperateChartConfigResponse:
        """
        @summary 操作表格配置
        
        @param request: OperateChartConfigRequest
        @return: OperateChartConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.OperateChartConfigHeaders()
        return await self.operate_chart_config_with_options_async(request, headers, runtime)

    def post_corp_auth_info_with_options(
        self,
        headers: dingtalkdatacenter__1__0_models.PostCorpAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse:
        """
        @summary 企业授权信息
        
        @param headers: PostCorpAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PostCorpAuthInfoResponse
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
            action='PostCorpAuthInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/corporations/authorize',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def post_corp_auth_info_with_options_async(
        self,
        headers: dingtalkdatacenter__1__0_models.PostCorpAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse:
        """
        @summary 企业授权信息
        
        @param headers: PostCorpAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PostCorpAuthInfoResponse
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
            action='PostCorpAuthInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/corporations/authorize',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def post_corp_auth_info(self) -> dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse:
        """
        @summary 企业授权信息
        
        @return: PostCorpAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.PostCorpAuthInfoHeaders()
        return self.post_corp_auth_info_with_options(headers, runtime)

    async def post_corp_auth_info_async(self) -> dingtalkdatacenter__1__0_models.PostCorpAuthInfoResponse:
        """
        @summary 企业授权信息
        
        @return: PostCorpAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.PostCorpAuthInfoHeaders()
        return await self.post_corp_auth_info_with_options_async(headers, runtime)

    def query_active_user_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        """
        @summary 获取企业用户激活状态统计数据
        
        @param request: QueryActiveUserStatisticalDataRequest
        @param headers: QueryActiveUserStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryActiveUserStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryActiveUserStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/activeUserData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_active_user_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        """
        @summary 获取企业用户激活状态统计数据
        
        @param request: QueryActiveUserStatisticalDataRequest
        @param headers: QueryActiveUserStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryActiveUserStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryActiveUserStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/activeUserData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_active_user_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        """
        @summary 获取企业用户激活状态统计数据
        
        @param request: QueryActiveUserStatisticalDataRequest
        @return: QueryActiveUserStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders()
        return self.query_active_user_statistical_data_with_options(request, headers, runtime)

    async def query_active_user_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataResponse:
        """
        @summary 获取企业用户激活状态统计数据
        
        @param request: QueryActiveUserStatisticalDataRequest
        @return: QueryActiveUserStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryActiveUserStatisticalDataHeaders()
        return await self.query_active_user_statistical_data_with_options_async(request, headers, runtime)

    def query_anhmd_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse:
        """
        @summary 获取安恒密盾统计数据
        
        @param request: QueryAnhmdStatisticalDataRequest
        @param headers: QueryAnhmdStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAnhmdStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryAnhmdStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/statisticDatas/anHmd',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_anhmd_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse:
        """
        @summary 获取安恒密盾统计数据
        
        @param request: QueryAnhmdStatisticalDataRequest
        @param headers: QueryAnhmdStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAnhmdStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryAnhmdStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/statisticDatas/anHmd',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_anhmd_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse:
        """
        @summary 获取安恒密盾统计数据
        
        @param request: QueryAnhmdStatisticalDataRequest
        @return: QueryAnhmdStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataHeaders()
        return self.query_anhmd_statistical_data_with_options(request, headers, runtime)

    async def query_anhmd_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataResponse:
        """
        @summary 获取安恒密盾统计数据
        
        @param request: QueryAnhmdStatisticalDataRequest
        @return: QueryAnhmdStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryAnhmdStatisticalDataHeaders()
        return await self.query_anhmd_statistical_data_with_options_async(request, headers, runtime)

    def query_approval_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        """
        @summary 获取企业审批统计数据
        
        @param request: QueryApprovalStatisticalDataRequest
        @param headers: QueryApprovalStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryApprovalStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryApprovalStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/approvalData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_approval_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        """
        @summary 获取企业审批统计数据
        
        @param request: QueryApprovalStatisticalDataRequest
        @param headers: QueryApprovalStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryApprovalStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryApprovalStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/approvalData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_approval_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        """
        @summary 获取企业审批统计数据
        
        @param request: QueryApprovalStatisticalDataRequest
        @return: QueryApprovalStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders()
        return self.query_approval_statistical_data_with_options(request, headers, runtime)

    async def query_approval_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataResponse:
        """
        @summary 获取企业审批统计数据
        
        @param request: QueryApprovalStatisticalDataRequest
        @return: QueryApprovalStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryApprovalStatisticalDataHeaders()
        return await self.query_approval_statistical_data_with_options_async(request, headers, runtime)

    def query_attendance_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        """
        @summary 获取企业考勤统计数据
        
        @param request: QueryAttendanceStatisticalDataRequest
        @param headers: QueryAttendanceStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAttendanceStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryAttendanceStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/attendanceData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_attendance_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        """
        @summary 获取企业考勤统计数据
        
        @param request: QueryAttendanceStatisticalDataRequest
        @param headers: QueryAttendanceStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAttendanceStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryAttendanceStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/attendanceData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_attendance_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        """
        @summary 获取企业考勤统计数据
        
        @param request: QueryAttendanceStatisticalDataRequest
        @return: QueryAttendanceStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders()
        return self.query_attendance_statistical_data_with_options(request, headers, runtime)

    async def query_attendance_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataResponse:
        """
        @summary 获取企业考勤统计数据
        
        @param request: QueryAttendanceStatisticalDataRequest
        @return: QueryAttendanceStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryAttendanceStatisticalDataHeaders()
        return await self.query_attendance_statistical_data_with_options_async(request, headers, runtime)

    def query_blackboard_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        """
        @summary 获取企业公告统计数据
        
        @param request: QueryBlackboardStatisticalDataRequest
        @param headers: QueryBlackboardStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBlackboardStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryBlackboardStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/blackboardData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_blackboard_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        """
        @summary 获取企业公告统计数据
        
        @param request: QueryBlackboardStatisticalDataRequest
        @param headers: QueryBlackboardStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBlackboardStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryBlackboardStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/blackboardData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_blackboard_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        """
        @summary 获取企业公告统计数据
        
        @param request: QueryBlackboardStatisticalDataRequest
        @return: QueryBlackboardStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders()
        return self.query_blackboard_statistical_data_with_options(request, headers, runtime)

    async def query_blackboard_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataResponse:
        """
        @summary 获取企业公告统计数据
        
        @param request: QueryBlackboardStatisticalDataRequest
        @return: QueryBlackboardStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryBlackboardStatisticalDataHeaders()
        return await self.query_blackboard_statistical_data_with_options_async(request, headers, runtime)

    def query_calendar_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        """
        @summary 获取企业日程统计数据
        
        @param request: QueryCalendarStatisticalDataRequest
        @param headers: QueryCalendarStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCalendarStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryCalendarStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/calendarData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_calendar_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        """
        @summary 获取企业日程统计数据
        
        @param request: QueryCalendarStatisticalDataRequest
        @param headers: QueryCalendarStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCalendarStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryCalendarStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/calendarData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_calendar_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        """
        @summary 获取企业日程统计数据
        
        @param request: QueryCalendarStatisticalDataRequest
        @return: QueryCalendarStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders()
        return self.query_calendar_statistical_data_with_options(request, headers, runtime)

    async def query_calendar_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataResponse:
        """
        @summary 获取企业日程统计数据
        
        @param request: QueryCalendarStatisticalDataRequest
        @return: QueryCalendarStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCalendarStatisticalDataHeaders()
        return await self.query_calendar_statistical_data_with_options_async(request, headers, runtime)

    def query_chart_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryChartDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryChartDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryChartDataResponse:
        """
        @summary 获取图表数据
        
        @param request: QueryChartDataRequest
        @param headers: QueryChartDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryChartDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.ticket):
            body['ticket'] = request.ticket
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
            action='QueryChartData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/chartDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryChartDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_chart_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryChartDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryChartDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryChartDataResponse:
        """
        @summary 获取图表数据
        
        @param request: QueryChartDataRequest
        @param headers: QueryChartDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryChartDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.ticket):
            body['ticket'] = request.ticket
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
            action='QueryChartData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/chartDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryChartDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_chart_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryChartDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryChartDataResponse:
        """
        @summary 获取图表数据
        
        @param request: QueryChartDataRequest
        @return: QueryChartDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryChartDataHeaders()
        return self.query_chart_data_with_options(request, headers, runtime)

    async def query_chart_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryChartDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryChartDataResponse:
        """
        @summary 获取图表数据
        
        @param request: QueryChartDataRequest
        @return: QueryChartDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryChartDataHeaders()
        return await self.query_chart_data_with_options_async(request, headers, runtime)

    def query_checkin_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        """
        @summary 获取企业签到统计数据
        
        @param request: QueryCheckinStatisticalDataRequest
        @param headers: QueryCheckinStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCheckinStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryCheckinStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/checkinData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_checkin_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        """
        @summary 获取企业签到统计数据
        
        @param request: QueryCheckinStatisticalDataRequest
        @param headers: QueryCheckinStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCheckinStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryCheckinStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/checkinData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_checkin_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        """
        @summary 获取企业签到统计数据
        
        @param request: QueryCheckinStatisticalDataRequest
        @return: QueryCheckinStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders()
        return self.query_checkin_statistical_data_with_options(request, headers, runtime)

    async def query_checkin_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataResponse:
        """
        @summary 获取企业签到统计数据
        
        @param request: QueryCheckinStatisticalDataRequest
        @return: QueryCheckinStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCheckinStatisticalDataHeaders()
        return await self.query_checkin_statistical_data_with_options_async(request, headers, runtime)

    def query_circle_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        """
        @summary 获取企业全员圈统计数据
        
        @param request: QueryCircleStatisticalDataRequest
        @param headers: QueryCircleStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCircleStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryCircleStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/circleData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_circle_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        """
        @summary 获取企业全员圈统计数据
        
        @param request: QueryCircleStatisticalDataRequest
        @param headers: QueryCircleStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCircleStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryCircleStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/circleData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_circle_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        """
        @summary 获取企业全员圈统计数据
        
        @param request: QueryCircleStatisticalDataRequest
        @return: QueryCircleStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders()
        return self.query_circle_statistical_data_with_options(request, headers, runtime)

    async def query_circle_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataResponse:
        """
        @summary 获取企业全员圈统计数据
        
        @param request: QueryCircleStatisticalDataRequest
        @return: QueryCircleStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCircleStatisticalDataHeaders()
        return await self.query_circle_statistical_data_with_options_async(request, headers, runtime)

    def query_company_basic_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        """
        @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
        
        @param request: QueryCompanyBasicInfoRequest
        @param headers: QueryCompanyBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCompanyBasicInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
            action='QueryCompanyBasicInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/basicInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_company_basic_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        """
        @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
        
        @param request: QueryCompanyBasicInfoRequest
        @param headers: QueryCompanyBasicInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCompanyBasicInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
            action='QueryCompanyBasicInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/companies/basicInfo',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_company_basic_info(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        """
        @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
        
        @param request: QueryCompanyBasicInfoRequest
        @return: QueryCompanyBasicInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders()
        return self.query_company_basic_info_with_options(request, headers, runtime)

    async def query_company_basic_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoResponse:
        """
        @summary 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
        
        @param request: QueryCompanyBasicInfoRequest
        @return: QueryCompanyBasicInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryCompanyBasicInfoHeaders()
        return await self.query_company_basic_info_with_options_async(request, headers, runtime)

    def query_digital_district_org_info_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        """
        @summary 获取数字区县组织信息
        
        @param request: QueryDigitalDistrictOrgInfoRequest
        @param headers: QueryDigitalDistrictOrgInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDigitalDistrictOrgInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_ids):
            body['corpIds'] = request.corp_ids
        if not UtilClient.is_unset(request.stat_dates):
            body['statDates'] = request.stat_dates
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
            action='QueryDigitalDistrictOrgInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/digitalCounty/orgInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_digital_district_org_info_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        """
        @summary 获取数字区县组织信息
        
        @param request: QueryDigitalDistrictOrgInfoRequest
        @param headers: QueryDigitalDistrictOrgInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDigitalDistrictOrgInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_ids):
            body['corpIds'] = request.corp_ids
        if not UtilClient.is_unset(request.stat_dates):
            body['statDates'] = request.stat_dates
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
            action='QueryDigitalDistrictOrgInfo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/digitalCounty/orgInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_digital_district_org_info(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        """
        @summary 获取数字区县组织信息
        
        @param request: QueryDigitalDistrictOrgInfoRequest
        @return: QueryDigitalDistrictOrgInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders()
        return self.query_digital_district_org_info_with_options(request, headers, runtime)

    async def query_digital_district_org_info_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoResponse:
        """
        @summary 获取数字区县组织信息
        
        @param request: QueryDigitalDistrictOrgInfoRequest
        @return: QueryDigitalDistrictOrgInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDigitalDistrictOrgInfoHeaders()
        return await self.query_digital_district_org_info_with_options_async(request, headers, runtime)

    def query_ding_recive_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        """
        @summary 获取企业DING接收及评论统计数据
        
        @param request: QueryDingReciveStatisticalDataRequest
        @param headers: QueryDingReciveStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDingReciveStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryDingReciveStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dingReciveData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_ding_recive_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        """
        @summary 获取企业DING接收及评论统计数据
        
        @param request: QueryDingReciveStatisticalDataRequest
        @param headers: QueryDingReciveStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDingReciveStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryDingReciveStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dingReciveData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_ding_recive_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        """
        @summary 获取企业DING接收及评论统计数据
        
        @param request: QueryDingReciveStatisticalDataRequest
        @return: QueryDingReciveStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders()
        return self.query_ding_recive_statistical_data_with_options(request, headers, runtime)

    async def query_ding_recive_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataResponse:
        """
        @summary 获取企业DING接收及评论统计数据
        
        @param request: QueryDingReciveStatisticalDataRequest
        @return: QueryDingReciveStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingReciveStatisticalDataHeaders()
        return await self.query_ding_recive_statistical_data_with_options_async(request, headers, runtime)

    def query_ding_send_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        """
        @summary 获取企业DING发送统计数据
        
        @param request: QueryDingSendStatisticalDataRequest
        @param headers: QueryDingSendStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDingSendStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryDingSendStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dingSendData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_ding_send_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        """
        @summary 获取企业DING发送统计数据
        
        @param request: QueryDingSendStatisticalDataRequest
        @param headers: QueryDingSendStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDingSendStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryDingSendStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dingSendData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_ding_send_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        """
        @summary 获取企业DING发送统计数据
        
        @param request: QueryDingSendStatisticalDataRequest
        @return: QueryDingSendStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders()
        return self.query_ding_send_statistical_data_with_options(request, headers, runtime)

    async def query_ding_send_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataResponse:
        """
        @summary 获取企业DING发送统计数据
        
        @param request: QueryDingSendStatisticalDataRequest
        @return: QueryDingSendStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDingSendStatisticalDataHeaders()
        return await self.query_ding_send_statistical_data_with_options_async(request, headers, runtime)

    def query_document_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        """
        @summary 获取企业文档统计数据
        
        @param request: QueryDocumentStatisticalDataRequest
        @param headers: QueryDocumentStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDocumentStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryDocumentStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/documentData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_document_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        """
        @summary 获取企业文档统计数据
        
        @param request: QueryDocumentStatisticalDataRequest
        @param headers: QueryDocumentStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDocumentStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryDocumentStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/documentData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_document_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        """
        @summary 获取企业文档统计数据
        
        @param request: QueryDocumentStatisticalDataRequest
        @return: QueryDocumentStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders()
        return self.query_document_statistical_data_with_options(request, headers, runtime)

    async def query_document_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataResponse:
        """
        @summary 获取企业文档统计数据
        
        @param request: QueryDocumentStatisticalDataRequest
        @return: QueryDocumentStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDocumentStatisticalDataHeaders()
        return await self.query_document_statistical_data_with_options_async(request, headers, runtime)

    def query_dpaas_data_package_with_options(
        self,
        headers: dingtalkdatacenter__1__0_models.QueryDpaasDataPackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDpaasDataPackageResponse:
        """
        @summary 查询数据资产平台增购包购买信息
        
        @param headers: QueryDpaasDataPackageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDpaasDataPackageResponse
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
            action='QueryDpaasDataPackage',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dpaas/dataPackages/purchaseInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDpaasDataPackageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_dpaas_data_package_with_options_async(
        self,
        headers: dingtalkdatacenter__1__0_models.QueryDpaasDataPackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDpaasDataPackageResponse:
        """
        @summary 查询数据资产平台增购包购买信息
        
        @param headers: QueryDpaasDataPackageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDpaasDataPackageResponse
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
            action='QueryDpaasDataPackage',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dpaas/dataPackages/purchaseInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDpaasDataPackageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_dpaas_data_package(self) -> dingtalkdatacenter__1__0_models.QueryDpaasDataPackageResponse:
        """
        @summary 查询数据资产平台增购包购买信息
        
        @return: QueryDpaasDataPackageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDpaasDataPackageHeaders()
        return self.query_dpaas_data_package_with_options(headers, runtime)

    async def query_dpaas_data_package_async(self) -> dingtalkdatacenter__1__0_models.QueryDpaasDataPackageResponse:
        """
        @summary 查询数据资产平台增购包购买信息
        
        @return: QueryDpaasDataPackageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDpaasDataPackageHeaders()
        return await self.query_dpaas_data_package_with_options_async(headers, runtime)

    def query_drive_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        """
        @summary 获取企业钉盘统计数据
        
        @param request: QueryDriveStatisticalDataRequest
        @param headers: QueryDriveStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDriveStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryDriveStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/driveData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_drive_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        """
        @summary 获取企业钉盘统计数据
        
        @param request: QueryDriveStatisticalDataRequest
        @param headers: QueryDriveStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDriveStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryDriveStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/driveData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_drive_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        """
        @summary 获取企业钉盘统计数据
        
        @param request: QueryDriveStatisticalDataRequest
        @return: QueryDriveStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders()
        return self.query_drive_statistical_data_with_options(request, headers, runtime)

    async def query_drive_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataResponse:
        """
        @summary 获取企业钉盘统计数据
        
        @param request: QueryDriveStatisticalDataRequest
        @return: QueryDriveStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryDriveStatisticalDataHeaders()
        return await self.query_drive_statistical_data_with_options_async(request, headers, runtime)

    def query_employee_type_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        """
        @summary 获取企业员工类型统计数据
        
        @param request: QueryEmployeeTypeStatisticalDataRequest
        @param headers: QueryEmployeeTypeStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryEmployeeTypeStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryEmployeeTypeStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/employeeTypeData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_employee_type_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        """
        @summary 获取企业员工类型统计数据
        
        @param request: QueryEmployeeTypeStatisticalDataRequest
        @param headers: QueryEmployeeTypeStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryEmployeeTypeStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryEmployeeTypeStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/employeeTypeData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_employee_type_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        """
        @summary 获取企业员工类型统计数据
        
        @param request: QueryEmployeeTypeStatisticalDataRequest
        @return: QueryEmployeeTypeStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders()
        return self.query_employee_type_statistical_data_with_options(request, headers, runtime)

    async def query_employee_type_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataResponse:
        """
        @summary 获取企业员工类型统计数据
        
        @param request: QueryEmployeeTypeStatisticalDataRequest
        @return: QueryEmployeeTypeStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryEmployeeTypeStatisticalDataHeaders()
        return await self.query_employee_type_statistical_data_with_options_async(request, headers, runtime)

    def query_general_data_service_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse:
        """
        @summary 数据资产平台数据服务接口
        
        @param request: QueryGeneralDataServiceRequest
        @param headers: QueryGeneralDataServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGeneralDataServiceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.end_date):
            query['endDate'] = request.end_date
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.return_total):
            query['returnTotal'] = request.return_total
        if not UtilClient.is_unset(request.service_id):
            query['serviceId'] = request.service_id
        if not UtilClient.is_unset(request.start_date):
            query['startDate'] = request.start_date
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
            action='QueryGeneralDataService',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/generalDataServices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_general_data_service_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse:
        """
        @summary 数据资产平台数据服务接口
        
        @param request: QueryGeneralDataServiceRequest
        @param headers: QueryGeneralDataServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGeneralDataServiceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.end_date):
            query['endDate'] = request.end_date
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.return_total):
            query['returnTotal'] = request.return_total
        if not UtilClient.is_unset(request.service_id):
            query['serviceId'] = request.service_id
        if not UtilClient.is_unset(request.start_date):
            query['startDate'] = request.start_date
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
            action='QueryGeneralDataService',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/generalDataServices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_general_data_service(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse:
        """
        @summary 数据资产平台数据服务接口
        
        @param request: QueryGeneralDataServiceRequest
        @return: QueryGeneralDataServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGeneralDataServiceHeaders()
        return self.query_general_data_service_with_options(request, headers, runtime)

    async def query_general_data_service_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceResponse:
        """
        @summary 数据资产平台数据服务接口
        
        @param request: QueryGeneralDataServiceRequest
        @return: QueryGeneralDataServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGeneralDataServiceHeaders()
        return await self.query_general_data_service_with_options_async(request, headers, runtime)

    def query_general_data_service_batch_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchResponse:
        """
        @summary 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
        
        @param request: QueryGeneralDataServiceBatchRequest
        @param headers: QueryGeneralDataServiceBatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGeneralDataServiceBatchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.filters):
            body['filters'] = request.filters
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.return_total):
            body['returnTotal'] = request.return_total
        if not UtilClient.is_unset(request.service_id):
            body['serviceId'] = request.service_id
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='QueryGeneralDataServiceBatch',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataServices/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchResponse(),
            self.execute(params, req, runtime)
        )

    async def query_general_data_service_batch_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchResponse:
        """
        @summary 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
        
        @param request: QueryGeneralDataServiceBatchRequest
        @param headers: QueryGeneralDataServiceBatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGeneralDataServiceBatchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.filters):
            body['filters'] = request.filters
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.return_total):
            body['returnTotal'] = request.return_total
        if not UtilClient.is_unset(request.service_id):
            body['serviceId'] = request.service_id
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='QueryGeneralDataServiceBatch',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataServices/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_general_data_service_batch(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchResponse:
        """
        @summary 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
        
        @param request: QueryGeneralDataServiceBatchRequest
        @return: QueryGeneralDataServiceBatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchHeaders()
        return self.query_general_data_service_batch_with_options(request, headers, runtime)

    async def query_general_data_service_batch_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchResponse:
        """
        @summary 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
        
        @param request: QueryGeneralDataServiceBatchRequest
        @return: QueryGeneralDataServiceBatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGeneralDataServiceBatchHeaders()
        return await self.query_general_data_service_batch_with_options_async(request, headers, runtime)

    def query_general_data_update_date_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateResponse:
        """
        @summary 数据资产平台数据服务接口(查询数据更新日期)
        
        @param request: QueryGeneralDataUpdateDateRequest
        @param headers: QueryGeneralDataUpdateDateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGeneralDataUpdateDateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.service_id):
            query['serviceId'] = request.service_id
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
            action='QueryGeneralDataUpdateDate',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataUpdateDates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateResponse(),
            self.execute(params, req, runtime)
        )

    async def query_general_data_update_date_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateResponse:
        """
        @summary 数据资产平台数据服务接口(查询数据更新日期)
        
        @param request: QueryGeneralDataUpdateDateRequest
        @param headers: QueryGeneralDataUpdateDateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGeneralDataUpdateDateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.service_id):
            query['serviceId'] = request.service_id
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
            action='QueryGeneralDataUpdateDate',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataUpdateDates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_general_data_update_date(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateResponse:
        """
        @summary 数据资产平台数据服务接口(查询数据更新日期)
        
        @param request: QueryGeneralDataUpdateDateRequest
        @return: QueryGeneralDataUpdateDateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateHeaders()
        return self.query_general_data_update_date_with_options(request, headers, runtime)

    async def query_general_data_update_date_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateResponse:
        """
        @summary 数据资产平台数据服务接口(查询数据更新日期)
        
        @param request: QueryGeneralDataUpdateDateRequest
        @return: QueryGeneralDataUpdateDateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGeneralDataUpdateDateHeaders()
        return await self.query_general_data_update_date_with_options_async(request, headers, runtime)

    def query_group_live_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        """
        @summary 获取企业群直播统计数据
        
        @param request: QueryGroupLiveStatisticalDataRequest
        @param headers: QueryGroupLiveStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupLiveStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryGroupLiveStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/groupLiveData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_group_live_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        """
        @summary 获取企业群直播统计数据
        
        @param request: QueryGroupLiveStatisticalDataRequest
        @param headers: QueryGroupLiveStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupLiveStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryGroupLiveStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/groupLiveData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_group_live_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        """
        @summary 获取企业群直播统计数据
        
        @param request: QueryGroupLiveStatisticalDataRequest
        @return: QueryGroupLiveStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders()
        return self.query_group_live_statistical_data_with_options(request, headers, runtime)

    async def query_group_live_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataResponse:
        """
        @summary 获取企业群直播统计数据
        
        @param request: QueryGroupLiveStatisticalDataRequest
        @return: QueryGroupLiveStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupLiveStatisticalDataHeaders()
        return await self.query_group_live_statistical_data_with_options_async(request, headers, runtime)

    def query_group_message_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        """
        @summary 获取企业群聊统计数据
        
        @param request: QueryGroupMessageStatisticalDataRequest
        @param headers: QueryGroupMessageStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupMessageStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryGroupMessageStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/groupMessageData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_group_message_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        """
        @summary 获取企业群聊统计数据
        
        @param request: QueryGroupMessageStatisticalDataRequest
        @param headers: QueryGroupMessageStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupMessageStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryGroupMessageStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/groupMessageData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_group_message_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        """
        @summary 获取企业群聊统计数据
        
        @param request: QueryGroupMessageStatisticalDataRequest
        @return: QueryGroupMessageStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders()
        return self.query_group_message_statistical_data_with_options(request, headers, runtime)

    async def query_group_message_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataResponse:
        """
        @summary 获取企业群聊统计数据
        
        @param request: QueryGroupMessageStatisticalDataRequest
        @return: QueryGroupMessageStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryGroupMessageStatisticalDataHeaders()
        return await self.query_group_message_statistical_data_with_options_async(request, headers, runtime)

    def query_health_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        """
        @summary 获取企业钉钉运动统计数据
        
        @param request: QueryHealthStatisticalDataRequest
        @param headers: QueryHealthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHealthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryHealthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/healtheUserData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_health_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        """
        @summary 获取企业钉钉运动统计数据
        
        @param request: QueryHealthStatisticalDataRequest
        @param headers: QueryHealthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHealthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryHealthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/healtheUserData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_health_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        """
        @summary 获取企业钉钉运动统计数据
        
        @param request: QueryHealthStatisticalDataRequest
        @return: QueryHealthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders()
        return self.query_health_statistical_data_with_options(request, headers, runtime)

    async def query_health_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataResponse:
        """
        @summary 获取企业钉钉运动统计数据
        
        @param request: QueryHealthStatisticalDataRequest
        @return: QueryHealthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryHealthStatisticalDataHeaders()
        return await self.query_health_statistical_data_with_options_async(request, headers, runtime)

    def query_mail_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        """
        @summary 获取企业邮箱统计数据
        
        @param request: QueryMailStatisticalDataRequest
        @param headers: QueryMailStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMailStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryMailStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/mailData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_mail_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        """
        @summary 获取企业邮箱统计数据
        
        @param request: QueryMailStatisticalDataRequest
        @param headers: QueryMailStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMailStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryMailStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/mailData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_mail_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        """
        @summary 获取企业邮箱统计数据
        
        @param request: QueryMailStatisticalDataRequest
        @return: QueryMailStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders()
        return self.query_mail_statistical_data_with_options(request, headers, runtime)

    async def query_mail_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryMailStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryMailStatisticalDataResponse:
        """
        @summary 获取企业邮箱统计数据
        
        @param request: QueryMailStatisticalDataRequest
        @return: QueryMailStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryMailStatisticalDataHeaders()
        return await self.query_mail_statistical_data_with_options_async(request, headers, runtime)

    def query_official_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDataResponse:
        """
        @summary 获取官方数据集数据
        
        @param request: QueryOfficialDataRequest
        @param headers: QueryOfficialDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.param):
            query['param'] = request.param
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
            action='QueryOfficialData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/datas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_official_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDataResponse:
        """
        @summary 获取官方数据集数据
        
        @param request: QueryOfficialDataRequest
        @param headers: QueryOfficialDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.param):
            query['param'] = request.param
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
            action='QueryOfficialData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/datas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_official_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDataResponse:
        """
        @summary 获取官方数据集数据
        
        @param request: QueryOfficialDataRequest
        @return: QueryOfficialDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDataHeaders()
        return self.query_official_data_with_options(request, headers, runtime)

    async def query_official_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDataResponse:
        """
        @summary 获取官方数据集数据
        
        @param request: QueryOfficialDataRequest
        @return: QueryOfficialDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDataHeaders()
        return await self.query_official_data_with_options_async(request, headers, runtime)

    def query_official_dataset_fields_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse:
        """
        @summary ISV获取官方数据集字段信息
        
        @param request: QueryOfficialDatasetFieldsRequest
        @param headers: QueryOfficialDatasetFieldsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialDatasetFieldsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ds_id):
            query['dsId'] = request.ds_id
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
            action='QueryOfficialDatasetFields',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/datasetFields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_official_dataset_fields_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse:
        """
        @summary ISV获取官方数据集字段信息
        
        @param request: QueryOfficialDatasetFieldsRequest
        @param headers: QueryOfficialDatasetFieldsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialDatasetFieldsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ds_id):
            query['dsId'] = request.ds_id
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
            action='QueryOfficialDatasetFields',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/datasetFields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_official_dataset_fields(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse:
        """
        @summary ISV获取官方数据集字段信息
        
        @param request: QueryOfficialDatasetFieldsRequest
        @return: QueryOfficialDatasetFieldsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsHeaders()
        return self.query_official_dataset_fields_with_options(request, headers, runtime)

    async def query_official_dataset_fields_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsResponse:
        """
        @summary ISV获取官方数据集字段信息
        
        @param request: QueryOfficialDatasetFieldsRequest
        @return: QueryOfficialDatasetFieldsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDatasetFieldsHeaders()
        return await self.query_official_dataset_fields_with_options_async(request, headers, runtime)

    def query_official_dataset_list_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse:
        """
        @summary ISV获取官方数据集列表
        
        @param request: QueryOfficialDatasetListRequest
        @param headers: QueryOfficialDatasetListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialDatasetListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
            action='QueryOfficialDatasetList',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/datasetLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_official_dataset_list_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse:
        """
        @summary ISV获取官方数据集列表
        
        @param request: QueryOfficialDatasetListRequest
        @param headers: QueryOfficialDatasetListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialDatasetListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.keyword):
            query['keyword'] = request.keyword
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
            action='QueryOfficialDatasetList',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/datasetLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_official_dataset_list(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse:
        """
        @summary ISV获取官方数据集列表
        
        @param request: QueryOfficialDatasetListRequest
        @return: QueryOfficialDatasetListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDatasetListHeaders()
        return self.query_official_dataset_list_with_options(request, headers, runtime)

    async def query_official_dataset_list_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialDatasetListRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialDatasetListResponse:
        """
        @summary ISV获取官方数据集列表
        
        @param request: QueryOfficialDatasetListRequest
        @return: QueryOfficialDatasetListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialDatasetListHeaders()
        return await self.query_official_dataset_list_with_options_async(request, headers, runtime)

    def query_official_form_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialFormDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialFormDataResponse:
        """
        @summary 获取官方数据集数据
        
        @param request: QueryOfficialFormDataRequest
        @param headers: QueryOfficialFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialFormDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='QueryOfficialFormData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialFormDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_official_form_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialFormDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialFormDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialFormDataResponse:
        """
        @summary 获取官方数据集数据
        
        @param request: QueryOfficialFormDataRequest
        @param headers: QueryOfficialFormDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialFormDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='QueryOfficialFormData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/datas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialFormDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_official_form_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialFormDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialFormDataResponse:
        """
        @summary 获取官方数据集数据
        
        @param request: QueryOfficialFormDataRequest
        @return: QueryOfficialFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialFormDataHeaders()
        return self.query_official_form_data_with_options(request, headers, runtime)

    async def query_official_form_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialFormDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialFormDataResponse:
        """
        @summary 获取官方数据集数据
        
        @param request: QueryOfficialFormDataRequest
        @return: QueryOfficialFormDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialFormDataHeaders()
        return await self.query_official_form_data_with_options_async(request, headers, runtime)

    def query_official_form_data_direct_holo_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloResponse:
        """
        @summary 获取HOLO中官方OA表单数据集数据
        
        @param request: QueryOfficialFormDataDirectHoloRequest
        @param headers: QueryOfficialFormDataDirectHoloHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialFormDataDirectHoloResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='QueryOfficialFormDataDirectHolo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/oaDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloResponse(),
            self.execute(params, req, runtime)
        )

    async def query_official_form_data_direct_holo_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloResponse:
        """
        @summary 获取HOLO中官方OA表单数据集数据
        
        @param request: QueryOfficialFormDataDirectHoloRequest
        @param headers: QueryOfficialFormDataDirectHoloHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOfficialFormDataDirectHoloResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='QueryOfficialFormDataDirectHolo',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/oaDatas/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_official_form_data_direct_holo(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloResponse:
        """
        @summary 获取HOLO中官方OA表单数据集数据
        
        @param request: QueryOfficialFormDataDirectHoloRequest
        @return: QueryOfficialFormDataDirectHoloResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloHeaders()
        return self.query_official_form_data_direct_holo_with_options(request, headers, runtime)

    async def query_official_form_data_direct_holo_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloResponse:
        """
        @summary 获取HOLO中官方OA表单数据集数据
        
        @param request: QueryOfficialFormDataDirectHoloRequest
        @return: QueryOfficialFormDataDirectHoloResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOfficialFormDataDirectHoloHeaders()
        return await self.query_official_form_data_direct_holo_with_options_async(request, headers, runtime)

    def query_online_user_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        """
        @summary 获取企业用户在线统计数据
        
        @param request: QueryOnlineUserStatisticalDataRequest
        @param headers: QueryOnlineUserStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOnlineUserStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryOnlineUserStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/onlineUserData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_online_user_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        """
        @summary 获取企业用户在线统计数据
        
        @param request: QueryOnlineUserStatisticalDataRequest
        @param headers: QueryOnlineUserStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOnlineUserStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryOnlineUserStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/onlineUserData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_online_user_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        """
        @summary 获取企业用户在线统计数据
        
        @param request: QueryOnlineUserStatisticalDataRequest
        @return: QueryOnlineUserStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders()
        return self.query_online_user_statistical_data_with_options(request, headers, runtime)

    async def query_online_user_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataResponse:
        """
        @summary 获取企业用户在线统计数据
        
        @param request: QueryOnlineUserStatisticalDataRequest
        @return: QueryOnlineUserStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryOnlineUserStatisticalDataHeaders()
        return await self.query_online_user_statistical_data_with_options_async(request, headers, runtime)

    def query_red_envelope_recive_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        """
        @summary 获取企业接收红包统计数据
        
        @param request: QueryRedEnvelopeReciveStatisticalDataRequest
        @param headers: QueryRedEnvelopeReciveStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRedEnvelopeReciveStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryRedEnvelopeReciveStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/redEnvelopeReciveData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_red_envelope_recive_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        """
        @summary 获取企业接收红包统计数据
        
        @param request: QueryRedEnvelopeReciveStatisticalDataRequest
        @param headers: QueryRedEnvelopeReciveStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRedEnvelopeReciveStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryRedEnvelopeReciveStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/redEnvelopeReciveData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_red_envelope_recive_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        """
        @summary 获取企业接收红包统计数据
        
        @param request: QueryRedEnvelopeReciveStatisticalDataRequest
        @return: QueryRedEnvelopeReciveStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders()
        return self.query_red_envelope_recive_statistical_data_with_options(request, headers, runtime)

    async def query_red_envelope_recive_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataResponse:
        """
        @summary 获取企业接收红包统计数据
        
        @param request: QueryRedEnvelopeReciveStatisticalDataRequest
        @return: QueryRedEnvelopeReciveStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeReciveStatisticalDataHeaders()
        return await self.query_red_envelope_recive_statistical_data_with_options_async(request, headers, runtime)

    def query_red_envelope_send_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        """
        @summary 获取企业发送红包统计数据
        
        @param request: QueryRedEnvelopeSendStatisticalDataRequest
        @param headers: QueryRedEnvelopeSendStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRedEnvelopeSendStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryRedEnvelopeSendStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/redEnvelopeSendData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_red_envelope_send_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        """
        @summary 获取企业发送红包统计数据
        
        @param request: QueryRedEnvelopeSendStatisticalDataRequest
        @param headers: QueryRedEnvelopeSendStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRedEnvelopeSendStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryRedEnvelopeSendStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/redEnvelopeSendData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_red_envelope_send_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        """
        @summary 获取企业发送红包统计数据
        
        @param request: QueryRedEnvelopeSendStatisticalDataRequest
        @return: QueryRedEnvelopeSendStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders()
        return self.query_red_envelope_send_statistical_data_with_options(request, headers, runtime)

    async def query_red_envelope_send_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataResponse:
        """
        @summary 获取企业发送红包统计数据
        
        @param request: QueryRedEnvelopeSendStatisticalDataRequest
        @return: QueryRedEnvelopeSendStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryRedEnvelopeSendStatisticalDataHeaders()
        return await self.query_red_envelope_send_statistical_data_with_options_async(request, headers, runtime)

    def query_report_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        """
        @summary 获取企业日志统计数据
        
        @param request: QueryReportStatisticalDataRequest
        @param headers: QueryReportStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryReportStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryReportStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/reportData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_report_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        """
        @summary 获取企业日志统计数据
        
        @param request: QueryReportStatisticalDataRequest
        @param headers: QueryReportStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryReportStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryReportStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/reportData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_report_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        """
        @summary 获取企业日志统计数据
        
        @param request: QueryReportStatisticalDataRequest
        @return: QueryReportStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders()
        return self.query_report_statistical_data_with_options(request, headers, runtime)

    async def query_report_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryReportStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryReportStatisticalDataResponse:
        """
        @summary 获取企业日志统计数据
        
        @param request: QueryReportStatisticalDataRequest
        @return: QueryReportStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryReportStatisticalDataHeaders()
        return await self.query_report_statistical_data_with_options_async(request, headers, runtime)

    def query_screen_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryScreenRequest,
        headers: dingtalkdatacenter__1__0_models.QueryScreenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryScreenResponse:
        """
        @summary 查询数据大屏
        
        @param request: QueryScreenRequest
        @param headers: QueryScreenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScreenResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='QueryScreen',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/screens',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryScreenResponse(),
            self.execute(params, req, runtime)
        )

    async def query_screen_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryScreenRequest,
        headers: dingtalkdatacenter__1__0_models.QueryScreenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryScreenResponse:
        """
        @summary 查询数据大屏
        
        @param request: QueryScreenRequest
        @param headers: QueryScreenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScreenResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='QueryScreen',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/screens',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryScreenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_screen(
        self,
        request: dingtalkdatacenter__1__0_models.QueryScreenRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryScreenResponse:
        """
        @summary 查询数据大屏
        
        @param request: QueryScreenRequest
        @return: QueryScreenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryScreenHeaders()
        return self.query_screen_with_options(request, headers, runtime)

    async def query_screen_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryScreenRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryScreenResponse:
        """
        @summary 查询数据大屏
        
        @param request: QueryScreenRequest
        @return: QueryScreenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryScreenHeaders()
        return await self.query_screen_with_options_async(request, headers, runtime)

    def query_screen_template_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryScreenTemplateRequest,
        headers: dingtalkdatacenter__1__0_models.QueryScreenTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryScreenTemplateResponse:
        """
        @summary 查询数据大屏模版
        
        @param request: QueryScreenTemplateRequest
        @param headers: QueryScreenTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScreenTemplateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.sample):
            query['sample'] = request.sample
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
            action='QueryScreenTemplate',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/screenTemplates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryScreenTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def query_screen_template_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryScreenTemplateRequest,
        headers: dingtalkdatacenter__1__0_models.QueryScreenTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryScreenTemplateResponse:
        """
        @summary 查询数据大屏模版
        
        @param request: QueryScreenTemplateRequest
        @param headers: QueryScreenTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryScreenTemplateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.sample):
            query['sample'] = request.sample
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
            action='QueryScreenTemplate',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/screenTemplates',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryScreenTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_screen_template(
        self,
        request: dingtalkdatacenter__1__0_models.QueryScreenTemplateRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryScreenTemplateResponse:
        """
        @summary 查询数据大屏模版
        
        @param request: QueryScreenTemplateRequest
        @return: QueryScreenTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryScreenTemplateHeaders()
        return self.query_screen_template_with_options(request, headers, runtime)

    async def query_screen_template_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryScreenTemplateRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryScreenTemplateResponse:
        """
        @summary 查询数据大屏模版
        
        @param request: QueryScreenTemplateRequest
        @return: QueryScreenTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryScreenTemplateHeaders()
        return await self.query_screen_template_with_options_async(request, headers, runtime)

    def query_single_message_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        """
        @summary 获取企业单聊统计数据
        
        @param request: QuerySingleMessageStatisticalDataRequest
        @param headers: QuerySingleMessageStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySingleMessageStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QuerySingleMessageStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/singleMessagerData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_single_message_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        """
        @summary 获取企业单聊统计数据
        
        @param request: QuerySingleMessageStatisticalDataRequest
        @param headers: QuerySingleMessageStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySingleMessageStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QuerySingleMessageStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/singleMessagerData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_single_message_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        """
        @summary 获取企业单聊统计数据
        
        @param request: QuerySingleMessageStatisticalDataRequest
        @return: QuerySingleMessageStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders()
        return self.query_single_message_statistical_data_with_options(request, headers, runtime)

    async def query_single_message_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataResponse:
        """
        @summary 获取企业单聊统计数据
        
        @param request: QuerySingleMessageStatisticalDataRequest
        @return: QuerySingleMessageStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QuerySingleMessageStatisticalDataHeaders()
        return await self.query_single_message_statistical_data_with_options_async(request, headers, runtime)

    def query_tel_meeting_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        """
        @summary 获取企业电话会议统计数据
        
        @param request: QueryTelMeetingStatisticalDataRequest
        @param headers: QueryTelMeetingStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTelMeetingStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryTelMeetingStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/telMeetingData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_tel_meeting_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        """
        @summary 获取企业电话会议统计数据
        
        @param request: QueryTelMeetingStatisticalDataRequest
        @param headers: QueryTelMeetingStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTelMeetingStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryTelMeetingStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/telMeetingData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_tel_meeting_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        """
        @summary 获取企业电话会议统计数据
        
        @param request: QueryTelMeetingStatisticalDataRequest
        @return: QueryTelMeetingStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders()
        return self.query_tel_meeting_statistical_data_with_options(request, headers, runtime)

    async def query_tel_meeting_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataResponse:
        """
        @summary 获取企业电话会议统计数据
        
        @param request: QueryTelMeetingStatisticalDataRequest
        @return: QueryTelMeetingStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTelMeetingStatisticalDataHeaders()
        return await self.query_tel_meeting_statistical_data_with_options_async(request, headers, runtime)

    def query_todo_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        """
        @summary 获取企业待办统计数据
        
        @param request: QueryTodoStatisticalDataRequest
        @param headers: QueryTodoStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTodoStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryTodoStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/todoUserData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_todo_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        """
        @summary 获取企业待办统计数据
        
        @param request: QueryTodoStatisticalDataRequest
        @param headers: QueryTodoStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTodoStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryTodoStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/todoUserData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_todo_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        """
        @summary 获取企业待办统计数据
        
        @param request: QueryTodoStatisticalDataRequest
        @return: QueryTodoStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders()
        return self.query_todo_statistical_data_with_options(request, headers, runtime)

    async def query_todo_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataResponse:
        """
        @summary 获取企业待办统计数据
        
        @param request: QueryTodoStatisticalDataRequest
        @return: QueryTodoStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTodoStatisticalDataHeaders()
        return await self.query_todo_statistical_data_with_options_async(request, headers, runtime)

    def query_total_data_count_service_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceResponse:
        """
        @summary 数据资产平台查询数据记录数
        
        @param request: QueryTotalDataCountServiceRequest
        @param headers: QueryTotalDataCountServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTotalDataCountServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.service_id):
            body['serviceId'] = request.service_id
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='QueryTotalDataCountService',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/datas/totalCounts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_total_data_count_service_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceRequest,
        headers: dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceResponse:
        """
        @summary 数据资产平台查询数据记录数
        
        @param request: QueryTotalDataCountServiceRequest
        @param headers: QueryTotalDataCountServiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTotalDataCountServiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.service_id):
            body['serviceId'] = request.service_id
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
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
            action='QueryTotalDataCountService',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/datas/totalCounts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_total_data_count_service(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceResponse:
        """
        @summary 数据资产平台查询数据记录数
        
        @param request: QueryTotalDataCountServiceRequest
        @return: QueryTotalDataCountServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceHeaders()
        return self.query_total_data_count_service_with_options(request, headers, runtime)

    async def query_total_data_count_service_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceResponse:
        """
        @summary 数据资产平台查询数据记录数
        
        @param request: QueryTotalDataCountServiceRequest
        @return: QueryTotalDataCountServiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryTotalDataCountServiceHeaders()
        return await self.query_total_data_count_service_with_options_async(request, headers, runtime)

    def query_vedio_meeting_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        """
        @summary 获取企业视频会议统计数据
        
        @param request: QueryVedioMeetingStatisticalDataRequest
        @param headers: QueryVedioMeetingStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryVedioMeetingStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryVedioMeetingStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/vedioMeetingData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_vedio_meeting_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        """
        @summary 获取企业视频会议统计数据
        
        @param request: QueryVedioMeetingStatisticalDataRequest
        @param headers: QueryVedioMeetingStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryVedioMeetingStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryVedioMeetingStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/vedioMeetingData',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_vedio_meeting_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        """
        @summary 获取企业视频会议统计数据
        
        @param request: QueryVedioMeetingStatisticalDataRequest
        @return: QueryVedioMeetingStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders()
        return self.query_vedio_meeting_statistical_data_with_options(request, headers, runtime)

    async def query_vedio_meeting_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataResponse:
        """
        @summary 获取企业视频会议统计数据
        
        @param request: QueryVedioMeetingStatisticalDataRequest
        @return: QueryVedioMeetingStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryVedioMeetingStatisticalDataHeaders()
        return await self.query_vedio_meeting_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_active_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按日统计）指标接口
        
        @param request: QueryYydActiveDayStatisticalDataRequest
        @param headers: QueryYydActiveDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydActiveDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydActiveDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydActiveDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_active_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按日统计）指标接口
        
        @param request: QueryYydActiveDayStatisticalDataRequest
        @param headers: QueryYydActiveDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydActiveDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydActiveDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydActiveDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_active_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按日统计）指标接口
        
        @param request: QueryYydActiveDayStatisticalDataRequest
        @return: QueryYydActiveDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataHeaders()
        return self.query_yyd_active_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_active_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按日统计）指标接口
        
        @param request: QueryYydActiveDayStatisticalDataRequest
        @return: QueryYydActiveDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveDayStatisticalDataHeaders()
        return await self.query_yyd_active_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_active_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按月统计）指标接口
        
        @param request: QueryYydActiveMonthStatisticalDataRequest
        @param headers: QueryYydActiveMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydActiveMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydActiveMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydActiveMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_active_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按月统计）指标接口
        
        @param request: QueryYydActiveMonthStatisticalDataRequest
        @param headers: QueryYydActiveMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydActiveMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydActiveMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydActiveMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_active_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按月统计）指标接口
        
        @param request: QueryYydActiveMonthStatisticalDataRequest
        @return: QueryYydActiveMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataHeaders()
        return self.query_yyd_active_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_active_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按月统计）指标接口
        
        @param request: QueryYydActiveMonthStatisticalDataRequest
        @return: QueryYydActiveMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveMonthStatisticalDataHeaders()
        return await self.query_yyd_active_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_active_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按周统计）指标接口
        
        @param request: QueryYydActiveWeekStatisticalDataRequest
        @param headers: QueryYydActiveWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydActiveWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydActiveWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydActiveWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_active_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按周统计）指标接口
        
        @param request: QueryYydActiveWeekStatisticalDataRequest
        @param headers: QueryYydActiveWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydActiveWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydActiveWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydActiveWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_active_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按周统计）指标接口
        
        @param request: QueryYydActiveWeekStatisticalDataRequest
        @return: QueryYydActiveWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataHeaders()
        return self.query_yyd_active_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_active_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataResponse:
        """
        @summary 亚运钉参谋活跃分析（按周统计）指标接口
        
        @param request: QueryYydActiveWeekStatisticalDataRequest
        @return: QueryYydActiveWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydActiveWeekStatisticalDataHeaders()
        return await self.query_yyd_active_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_app_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按日统计）指标接口
        
        @param request: QueryYydAppDayStatisticalDataRequest
        @param headers: QueryYydAppDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydAppDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydAppDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydAppDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_app_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按日统计）指标接口
        
        @param request: QueryYydAppDayStatisticalDataRequest
        @param headers: QueryYydAppDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydAppDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydAppDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydAppDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_app_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按日统计）指标接口
        
        @param request: QueryYydAppDayStatisticalDataRequest
        @return: QueryYydAppDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataHeaders()
        return self.query_yyd_app_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_app_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按日统计）指标接口
        
        @param request: QueryYydAppDayStatisticalDataRequest
        @return: QueryYydAppDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppDayStatisticalDataHeaders()
        return await self.query_yyd_app_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_app_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按月统计）指标接口
        
        @param request: QueryYydAppMonthStatisticalDataRequest
        @param headers: QueryYydAppMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydAppMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydAppMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydAppMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_app_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按月统计）指标接口
        
        @param request: QueryYydAppMonthStatisticalDataRequest
        @param headers: QueryYydAppMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydAppMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydAppMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydAppMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_app_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按月统计）指标接口
        
        @param request: QueryYydAppMonthStatisticalDataRequest
        @return: QueryYydAppMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataHeaders()
        return self.query_yyd_app_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_app_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按月统计）指标接口
        
        @param request: QueryYydAppMonthStatisticalDataRequest
        @return: QueryYydAppMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppMonthStatisticalDataHeaders()
        return await self.query_yyd_app_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_app_std_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（累计）指标接口
        
        @param request: QueryYydAppStdStatisticalDataRequest
        @param headers: QueryYydAppStdStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydAppStdStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydAppStdStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydAppStdDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_app_std_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（累计）指标接口
        
        @param request: QueryYydAppStdStatisticalDataRequest
        @param headers: QueryYydAppStdStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydAppStdStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydAppStdStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydAppStdDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_app_std_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（累计）指标接口
        
        @param request: QueryYydAppStdStatisticalDataRequest
        @return: QueryYydAppStdStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataHeaders()
        return self.query_yyd_app_std_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_app_std_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（累计）指标接口
        
        @param request: QueryYydAppStdStatisticalDataRequest
        @return: QueryYydAppStdStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppStdStatisticalDataHeaders()
        return await self.query_yyd_app_std_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_app_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按周统计）指标接口
        
        @param request: QueryYydAppWeekStatisticalDataRequest
        @param headers: QueryYydAppWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydAppWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydAppWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydAppWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_app_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按周统计）指标接口
        
        @param request: QueryYydAppWeekStatisticalDataRequest
        @param headers: QueryYydAppWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydAppWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydAppWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydAppWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_app_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按周统计）指标接口
        
        @param request: QueryYydAppWeekStatisticalDataRequest
        @return: QueryYydAppWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataHeaders()
        return self.query_yyd_app_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_app_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋应用概况（按周统计）指标接口
        
        @param request: QueryYydAppWeekStatisticalDataRequest
        @return: QueryYydAppWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydAppWeekStatisticalDataHeaders()
        return await self.query_yyd_app_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_calendar_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
        
        @param request: QueryYydCalendarDayStatisticalDataRequest
        @param headers: QueryYydCalendarDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydCalendarDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydCalendarDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydCalendarDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_calendar_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
        
        @param request: QueryYydCalendarDayStatisticalDataRequest
        @param headers: QueryYydCalendarDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydCalendarDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydCalendarDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydCalendarDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_calendar_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
        
        @param request: QueryYydCalendarDayStatisticalDataRequest
        @return: QueryYydCalendarDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataHeaders()
        return self.query_yyd_calendar_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_calendar_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按日统计）指标接口
        
        @param request: QueryYydCalendarDayStatisticalDataRequest
        @return: QueryYydCalendarDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarDayStatisticalDataHeaders()
        return await self.query_yyd_calendar_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_calendar_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
        
        @param request: QueryYydCalendarMonthStatisticalDataRequest
        @param headers: QueryYydCalendarMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydCalendarMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydCalendarMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydCalendarMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_calendar_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
        
        @param request: QueryYydCalendarMonthStatisticalDataRequest
        @param headers: QueryYydCalendarMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydCalendarMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydCalendarMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydCalendarMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_calendar_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
        
        @param request: QueryYydCalendarMonthStatisticalDataRequest
        @return: QueryYydCalendarMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataHeaders()
        return self.query_yyd_calendar_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_calendar_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按月统计）指标接口
        
        @param request: QueryYydCalendarMonthStatisticalDataRequest
        @return: QueryYydCalendarMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarMonthStatisticalDataHeaders()
        return await self.query_yyd_calendar_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_calendar_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
        
        @param request: QueryYydCalendarWeekStatisticalDataRequest
        @param headers: QueryYydCalendarWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydCalendarWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydCalendarWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydCalendarWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_calendar_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
        
        @param request: QueryYydCalendarWeekStatisticalDataRequest
        @param headers: QueryYydCalendarWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydCalendarWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydCalendarWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydCalendarWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_calendar_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
        
        @param request: QueryYydCalendarWeekStatisticalDataRequest
        @return: QueryYydCalendarWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataHeaders()
        return self.query_yyd_calendar_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_calendar_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋会议日程分析（按周统计）指标接口
        
        @param request: QueryYydCalendarWeekStatisticalDataRequest
        @return: QueryYydCalendarWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydCalendarWeekStatisticalDataHeaders()
        return await self.query_yyd_calendar_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_ding_msg_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
        
        @param request: QueryYydDingMsgDayStatisticalDataRequest
        @param headers: QueryYydDingMsgDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydDingMsgDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydDingMsgDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydDingMsgDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_ding_msg_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
        
        @param request: QueryYydDingMsgDayStatisticalDataRequest
        @param headers: QueryYydDingMsgDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydDingMsgDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydDingMsgDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydDingMsgDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_ding_msg_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
        
        @param request: QueryYydDingMsgDayStatisticalDataRequest
        @return: QueryYydDingMsgDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataHeaders()
        return self.query_yyd_ding_msg_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_ding_msg_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按日统计）指标接口
        
        @param request: QueryYydDingMsgDayStatisticalDataRequest
        @return: QueryYydDingMsgDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgDayStatisticalDataHeaders()
        return await self.query_yyd_ding_msg_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_ding_msg_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
        
        @param request: QueryYydDingMsgMonthStatisticalDataRequest
        @param headers: QueryYydDingMsgMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydDingMsgMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydDingMsgMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydDingMsgMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_ding_msg_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
        
        @param request: QueryYydDingMsgMonthStatisticalDataRequest
        @param headers: QueryYydDingMsgMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydDingMsgMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydDingMsgMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydDingMsgMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_ding_msg_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
        
        @param request: QueryYydDingMsgMonthStatisticalDataRequest
        @return: QueryYydDingMsgMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataHeaders()
        return self.query_yyd_ding_msg_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_ding_msg_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按月统计）指标接口
        
        @param request: QueryYydDingMsgMonthStatisticalDataRequest
        @return: QueryYydDingMsgMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgMonthStatisticalDataHeaders()
        return await self.query_yyd_ding_msg_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_ding_msg_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
        
        @param request: QueryYydDingMsgWeekStatisticalDataRequest
        @param headers: QueryYydDingMsgWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydDingMsgWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydDingMsgWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydDingMsgWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_ding_msg_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
        
        @param request: QueryYydDingMsgWeekStatisticalDataRequest
        @param headers: QueryYydDingMsgWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydDingMsgWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydDingMsgWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydDingMsgWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_ding_msg_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
        
        @param request: QueryYydDingMsgWeekStatisticalDataRequest
        @return: QueryYydDingMsgWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataHeaders()
        return self.query_yyd_ding_msg_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_ding_msg_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉消息分析（按周统计）指标接口
        
        @param request: QueryYydDingMsgWeekStatisticalDataRequest
        @return: QueryYydDingMsgWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydDingMsgWeekStatisticalDataHeaders()
        return await self.query_yyd_ding_msg_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_group_msg_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
        
        @param request: QueryYydGroupMsgDayStatisticalDataRequest
        @param headers: QueryYydGroupMsgDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydGroupMsgDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydGroupMsgDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydGroupMsgDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_group_msg_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
        
        @param request: QueryYydGroupMsgDayStatisticalDataRequest
        @param headers: QueryYydGroupMsgDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydGroupMsgDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydGroupMsgDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydGroupMsgDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_group_msg_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
        
        @param request: QueryYydGroupMsgDayStatisticalDataRequest
        @return: QueryYydGroupMsgDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataHeaders()
        return self.query_yyd_group_msg_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_group_msg_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按日统计）指标接口
        
        @param request: QueryYydGroupMsgDayStatisticalDataRequest
        @return: QueryYydGroupMsgDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgDayStatisticalDataHeaders()
        return await self.query_yyd_group_msg_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_group_msg_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
        
        @param request: QueryYydGroupMsgMonthStatisticalDataRequest
        @param headers: QueryYydGroupMsgMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydGroupMsgMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydGroupMsgMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydGroupMsgMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_group_msg_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
        
        @param request: QueryYydGroupMsgMonthStatisticalDataRequest
        @param headers: QueryYydGroupMsgMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydGroupMsgMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydGroupMsgMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydGroupMsgMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_group_msg_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
        
        @param request: QueryYydGroupMsgMonthStatisticalDataRequest
        @return: QueryYydGroupMsgMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataHeaders()
        return self.query_yyd_group_msg_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_group_msg_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按月统计）指标接口
        
        @param request: QueryYydGroupMsgMonthStatisticalDataRequest
        @return: QueryYydGroupMsgMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgMonthStatisticalDataHeaders()
        return await self.query_yyd_group_msg_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_group_msg_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
        
        @param request: QueryYydGroupMsgWeekStatisticalDataRequest
        @param headers: QueryYydGroupMsgWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydGroupMsgWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydGroupMsgWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydGroupMsgWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_group_msg_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
        
        @param request: QueryYydGroupMsgWeekStatisticalDataRequest
        @param headers: QueryYydGroupMsgWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydGroupMsgWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydGroupMsgWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydGroupMsgWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_group_msg_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
        
        @param request: QueryYydGroupMsgWeekStatisticalDataRequest
        @return: QueryYydGroupMsgWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataHeaders()
        return self.query_yyd_group_msg_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_group_msg_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋群聊分析（按周统计）指标接口
        
        @param request: QueryYydGroupMsgWeekStatisticalDataRequest
        @return: QueryYydGroupMsgWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydGroupMsgWeekStatisticalDataHeaders()
        return await self.query_yyd_group_msg_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_log_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按日统计）指标接口
        
        @param request: QueryYydLogDayStatisticalDataRequest
        @param headers: QueryYydLogDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydLogDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydLogDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydLogDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_log_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按日统计）指标接口
        
        @param request: QueryYydLogDayStatisticalDataRequest
        @param headers: QueryYydLogDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydLogDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydLogDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydLogDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_log_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按日统计）指标接口
        
        @param request: QueryYydLogDayStatisticalDataRequest
        @return: QueryYydLogDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataHeaders()
        return self.query_yyd_log_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_log_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按日统计）指标接口
        
        @param request: QueryYydLogDayStatisticalDataRequest
        @return: QueryYydLogDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogDayStatisticalDataHeaders()
        return await self.query_yyd_log_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_log_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按月统计）指标接口
        
        @param request: QueryYydLogMonthStatisticalDataRequest
        @param headers: QueryYydLogMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydLogMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydLogMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydLogMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_log_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按月统计）指标接口
        
        @param request: QueryYydLogMonthStatisticalDataRequest
        @param headers: QueryYydLogMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydLogMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydLogMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydLogMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_log_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按月统计）指标接口
        
        @param request: QueryYydLogMonthStatisticalDataRequest
        @return: QueryYydLogMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataHeaders()
        return self.query_yyd_log_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_log_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按月统计）指标接口
        
        @param request: QueryYydLogMonthStatisticalDataRequest
        @return: QueryYydLogMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogMonthStatisticalDataHeaders()
        return await self.query_yyd_log_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_log_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按周统计）指标接口
        
        @param request: QueryYydLogWeekStatisticalDataRequest
        @param headers: QueryYydLogWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydLogWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydLogWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydLogWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_log_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按周统计）指标接口
        
        @param request: QueryYydLogWeekStatisticalDataRequest
        @param headers: QueryYydLogWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydLogWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydLogWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydLogWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_log_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按周统计）指标接口
        
        @param request: QueryYydLogWeekStatisticalDataRequest
        @return: QueryYydLogWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataHeaders()
        return self.query_yyd_log_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_log_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋日志分析（按周统计）指标接口
        
        @param request: QueryYydLogWeekStatisticalDataRequest
        @return: QueryYydLogWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydLogWeekStatisticalDataHeaders()
        return await self.query_yyd_log_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_meeting_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
        
        @param request: QueryYydMeetingDayStatisticalDataRequest
        @param headers: QueryYydMeetingDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydMeetingDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydMeetingDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydMeetingDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_meeting_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
        
        @param request: QueryYydMeetingDayStatisticalDataRequest
        @param headers: QueryYydMeetingDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydMeetingDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydMeetingDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydMeetingDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_meeting_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
        
        @param request: QueryYydMeetingDayStatisticalDataRequest
        @return: QueryYydMeetingDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataHeaders()
        return self.query_yyd_meeting_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_meeting_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按日统计）指标接口
        
        @param request: QueryYydMeetingDayStatisticalDataRequest
        @return: QueryYydMeetingDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingDayStatisticalDataHeaders()
        return await self.query_yyd_meeting_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_meeting_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
        
        @param request: QueryYydMeetingMonthStatisticalDataRequest
        @param headers: QueryYydMeetingMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydMeetingMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydMeetingMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydMeetingMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_meeting_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
        
        @param request: QueryYydMeetingMonthStatisticalDataRequest
        @param headers: QueryYydMeetingMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydMeetingMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydMeetingMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydMeetingMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_meeting_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
        
        @param request: QueryYydMeetingMonthStatisticalDataRequest
        @return: QueryYydMeetingMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataHeaders()
        return self.query_yyd_meeting_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_meeting_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按月统计）指标接口
        
        @param request: QueryYydMeetingMonthStatisticalDataRequest
        @return: QueryYydMeetingMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingMonthStatisticalDataHeaders()
        return await self.query_yyd_meeting_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_meeting_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
        
        @param request: QueryYydMeetingWeekStatisticalDataRequest
        @param headers: QueryYydMeetingWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydMeetingWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydMeetingWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydMeetingWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_meeting_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
        
        @param request: QueryYydMeetingWeekStatisticalDataRequest
        @param headers: QueryYydMeetingWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydMeetingWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydMeetingWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydMeetingWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_meeting_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
        
        @param request: QueryYydMeetingWeekStatisticalDataRequest
        @return: QueryYydMeetingWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataHeaders()
        return self.query_yyd_meeting_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_meeting_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋钉会议分析（按周统计）指标接口
        
        @param request: QueryYydMeetingWeekStatisticalDataRequest
        @return: QueryYydMeetingWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydMeetingWeekStatisticalDataHeaders()
        return await self.query_yyd_meeting_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_notice_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按日统计）指标接口
        
        @param request: QueryYydNoticeDayStatisticalDataRequest
        @param headers: QueryYydNoticeDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydNoticeDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydNoticeDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydNoticeDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_notice_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按日统计）指标接口
        
        @param request: QueryYydNoticeDayStatisticalDataRequest
        @param headers: QueryYydNoticeDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydNoticeDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydNoticeDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydNoticeDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_notice_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按日统计）指标接口
        
        @param request: QueryYydNoticeDayStatisticalDataRequest
        @return: QueryYydNoticeDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataHeaders()
        return self.query_yyd_notice_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_notice_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按日统计）指标接口
        
        @param request: QueryYydNoticeDayStatisticalDataRequest
        @return: QueryYydNoticeDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeDayStatisticalDataHeaders()
        return await self.query_yyd_notice_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_notice_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按月统计）指标接口
        
        @param request: QueryYydNoticeMonthStatisticalDataRequest
        @param headers: QueryYydNoticeMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydNoticeMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydNoticeMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydNoticeMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_notice_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按月统计）指标接口
        
        @param request: QueryYydNoticeMonthStatisticalDataRequest
        @param headers: QueryYydNoticeMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydNoticeMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydNoticeMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydNoticeMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_notice_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按月统计）指标接口
        
        @param request: QueryYydNoticeMonthStatisticalDataRequest
        @return: QueryYydNoticeMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataHeaders()
        return self.query_yyd_notice_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_notice_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按月统计）指标接口
        
        @param request: QueryYydNoticeMonthStatisticalDataRequest
        @return: QueryYydNoticeMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeMonthStatisticalDataHeaders()
        return await self.query_yyd_notice_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_notice_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按周统计）指标接口
        
        @param request: QueryYydNoticeWeekStatisticalDataRequest
        @param headers: QueryYydNoticeWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydNoticeWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydNoticeWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydNoticeWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_notice_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按周统计）指标接口
        
        @param request: QueryYydNoticeWeekStatisticalDataRequest
        @param headers: QueryYydNoticeWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydNoticeWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydNoticeWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydNoticeWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_notice_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按周统计）指标接口
        
        @param request: QueryYydNoticeWeekStatisticalDataRequest
        @return: QueryYydNoticeWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataHeaders()
        return self.query_yyd_notice_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_notice_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋通知分析（按周统计）指标接口
        
        @param request: QueryYydNoticeWeekStatisticalDataRequest
        @return: QueryYydNoticeWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydNoticeWeekStatisticalDataHeaders()
        return await self.query_yyd_notice_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_single_msg_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
        
        @param request: QueryYydSingleMsgDayStatisticalDataRequest
        @param headers: QueryYydSingleMsgDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydSingleMsgDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydSingleMsgDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydSingleMsgDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_single_msg_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
        
        @param request: QueryYydSingleMsgDayStatisticalDataRequest
        @param headers: QueryYydSingleMsgDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydSingleMsgDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydSingleMsgDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydSingleMsgDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_single_msg_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
        
        @param request: QueryYydSingleMsgDayStatisticalDataRequest
        @return: QueryYydSingleMsgDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataHeaders()
        return self.query_yyd_single_msg_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_single_msg_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按日统计）指标接口
        
        @param request: QueryYydSingleMsgDayStatisticalDataRequest
        @return: QueryYydSingleMsgDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgDayStatisticalDataHeaders()
        return await self.query_yyd_single_msg_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_single_msg_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
        
        @param request: QueryYydSingleMsgMonthStatisticalDataRequest
        @param headers: QueryYydSingleMsgMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydSingleMsgMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydSingleMsgMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydSingleMsgMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_single_msg_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
        
        @param request: QueryYydSingleMsgMonthStatisticalDataRequest
        @param headers: QueryYydSingleMsgMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydSingleMsgMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydSingleMsgMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydSingleMsgMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_single_msg_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
        
        @param request: QueryYydSingleMsgMonthStatisticalDataRequest
        @return: QueryYydSingleMsgMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataHeaders()
        return self.query_yyd_single_msg_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_single_msg_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按月统计）指标接口
        
        @param request: QueryYydSingleMsgMonthStatisticalDataRequest
        @return: QueryYydSingleMsgMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgMonthStatisticalDataHeaders()
        return await self.query_yyd_single_msg_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_single_msg_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
        
        @param request: QueryYydSingleMsgWeekStatisticalDataRequest
        @param headers: QueryYydSingleMsgWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydSingleMsgWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydSingleMsgWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydSingleMsgWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_single_msg_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
        
        @param request: QueryYydSingleMsgWeekStatisticalDataRequest
        @param headers: QueryYydSingleMsgWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydSingleMsgWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydSingleMsgWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydSingleMsgWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_single_msg_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
        
        @param request: QueryYydSingleMsgWeekStatisticalDataRequest
        @return: QueryYydSingleMsgWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataHeaders()
        return self.query_yyd_single_msg_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_single_msg_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋单聊分析（按周统计）指标接口
        
        @param request: QueryYydSingleMsgWeekStatisticalDataRequest
        @return: QueryYydSingleMsgWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydSingleMsgWeekStatisticalDataHeaders()
        return await self.query_yyd_single_msg_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_toatl_msg_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按日统计）指标接口
        
        @param request: QueryYydToatlMsgDayStatisticalDataRequest
        @param headers: QueryYydToatlMsgDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydToatlMsgDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydToatlMsgDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydToatlMsgDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_toatl_msg_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按日统计）指标接口
        
        @param request: QueryYydToatlMsgDayStatisticalDataRequest
        @param headers: QueryYydToatlMsgDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydToatlMsgDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydToatlMsgDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydToatlMsgDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_toatl_msg_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按日统计）指标接口
        
        @param request: QueryYydToatlMsgDayStatisticalDataRequest
        @return: QueryYydToatlMsgDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataHeaders()
        return self.query_yyd_toatl_msg_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_toatl_msg_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按日统计）指标接口
        
        @param request: QueryYydToatlMsgDayStatisticalDataRequest
        @return: QueryYydToatlMsgDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgDayStatisticalDataHeaders()
        return await self.query_yyd_toatl_msg_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_toatl_msg_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按月统计）指标接口
        
        @param request: QueryYydToatlMsgMonthStatisticalDataRequest
        @param headers: QueryYydToatlMsgMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydToatlMsgMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydToatlMsgMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydToatlMsgMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_toatl_msg_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按月统计）指标接口
        
        @param request: QueryYydToatlMsgMonthStatisticalDataRequest
        @param headers: QueryYydToatlMsgMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydToatlMsgMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydToatlMsgMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydToatlMsgMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_toatl_msg_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按月统计）指标接口
        
        @param request: QueryYydToatlMsgMonthStatisticalDataRequest
        @return: QueryYydToatlMsgMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataHeaders()
        return self.query_yyd_toatl_msg_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_toatl_msg_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按月统计）指标接口
        
        @param request: QueryYydToatlMsgMonthStatisticalDataRequest
        @return: QueryYydToatlMsgMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgMonthStatisticalDataHeaders()
        return await self.query_yyd_toatl_msg_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_toatl_msg_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按周统计）指标接口
        
        @param request: QueryYydToatlMsgWeekStatisticalDataRequest
        @param headers: QueryYydToatlMsgWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydToatlMsgWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydToatlMsgWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydToatlMsgWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_toatl_msg_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按周统计）指标接口
        
        @param request: QueryYydToatlMsgWeekStatisticalDataRequest
        @param headers: QueryYydToatlMsgWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydToatlMsgWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydToatlMsgWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydToatlMsgWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_toatl_msg_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按周统计）指标接口
        
        @param request: QueryYydToatlMsgWeekStatisticalDataRequest
        @return: QueryYydToatlMsgWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataHeaders()
        return self.query_yyd_toatl_msg_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_toatl_msg_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋消息概览（按周统计）指标接口
        
        @param request: QueryYydToatlMsgWeekStatisticalDataRequest
        @return: QueryYydToatlMsgWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydToatlMsgWeekStatisticalDataHeaders()
        return await self.query_yyd_toatl_msg_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_todo_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按日统计）指标接口
        
        @param request: QueryYydTodoDayStatisticalDataRequest
        @param headers: QueryYydTodoDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTodoDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTodoDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTodoDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_todo_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按日统计）指标接口
        
        @param request: QueryYydTodoDayStatisticalDataRequest
        @param headers: QueryYydTodoDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTodoDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTodoDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTodoDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_todo_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按日统计）指标接口
        
        @param request: QueryYydTodoDayStatisticalDataRequest
        @return: QueryYydTodoDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataHeaders()
        return self.query_yyd_todo_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_todo_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按日统计）指标接口
        
        @param request: QueryYydTodoDayStatisticalDataRequest
        @return: QueryYydTodoDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoDayStatisticalDataHeaders()
        return await self.query_yyd_todo_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_todo_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按月统计）指标接口
        
        @param request: QueryYydTodoMonthStatisticalDataRequest
        @param headers: QueryYydTodoMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTodoMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTodoMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTodoMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_todo_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按月统计）指标接口
        
        @param request: QueryYydTodoMonthStatisticalDataRequest
        @param headers: QueryYydTodoMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTodoMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTodoMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTodoMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_todo_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按月统计）指标接口
        
        @param request: QueryYydTodoMonthStatisticalDataRequest
        @return: QueryYydTodoMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataHeaders()
        return self.query_yyd_todo_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_todo_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按月统计）指标接口
        
        @param request: QueryYydTodoMonthStatisticalDataRequest
        @return: QueryYydTodoMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoMonthStatisticalDataHeaders()
        return await self.query_yyd_todo_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_todo_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按周统计）指标接口
        
        @param request: QueryYydTodoWeekStatisticalDataRequest
        @param headers: QueryYydTodoWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTodoWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTodoWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTodoWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_todo_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按周统计）指标接口
        
        @param request: QueryYydTodoWeekStatisticalDataRequest
        @param headers: QueryYydTodoWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTodoWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTodoWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTodoWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_todo_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按周统计）指标接口
        
        @param request: QueryYydTodoWeekStatisticalDataRequest
        @return: QueryYydTodoWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataHeaders()
        return self.query_yyd_todo_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_todo_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataResponse:
        """
        @summary 亚运钉数字参谋待办分析（按周统计）指标接口
        
        @param request: QueryYydTodoWeekStatisticalDataRequest
        @return: QueryYydTodoWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTodoWeekStatisticalDataHeaders()
        return await self.query_yyd_todo_week_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_total_day_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按日统计）指标接口
        
        @param request: QueryYydTotalDayStatisticalDataRequest
        @param headers: QueryYydTotalDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTotalDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTotalDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTotalDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_total_day_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按日统计）指标接口
        
        @param request: QueryYydTotalDayStatisticalDataRequest
        @param headers: QueryYydTotalDayStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTotalDayStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTotalDayStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTotalDayDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_total_day_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按日统计）指标接口
        
        @param request: QueryYydTotalDayStatisticalDataRequest
        @return: QueryYydTotalDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataHeaders()
        return self.query_yyd_total_day_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_total_day_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按日统计）指标接口
        
        @param request: QueryYydTotalDayStatisticalDataRequest
        @return: QueryYydTotalDayStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalDayStatisticalDataHeaders()
        return await self.query_yyd_total_day_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_total_month_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按月统计）指标接口
        
        @param request: QueryYydTotalMonthStatisticalDataRequest
        @param headers: QueryYydTotalMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTotalMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTotalMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTotalMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_total_month_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按月统计）指标接口
        
        @param request: QueryYydTotalMonthStatisticalDataRequest
        @param headers: QueryYydTotalMonthStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTotalMonthStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTotalMonthStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTotalMonthDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_total_month_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按月统计）指标接口
        
        @param request: QueryYydTotalMonthStatisticalDataRequest
        @return: QueryYydTotalMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataHeaders()
        return self.query_yyd_total_month_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_total_month_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按月统计）指标接口
        
        @param request: QueryYydTotalMonthStatisticalDataRequest
        @return: QueryYydTotalMonthStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalMonthStatisticalDataHeaders()
        return await self.query_yyd_total_month_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_total_std_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（累计）指标接口
        
        @param request: QueryYydTotalStdStatisticalDataRequest
        @param headers: QueryYydTotalStdStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTotalStdStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTotalStdStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTotalStdDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_total_std_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（累计）指标接口
        
        @param request: QueryYydTotalStdStatisticalDataRequest
        @param headers: QueryYydTotalStdStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTotalStdStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTotalStdStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTotalStdDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_total_std_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（累计）指标接口
        
        @param request: QueryYydTotalStdStatisticalDataRequest
        @return: QueryYydTotalStdStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataHeaders()
        return self.query_yyd_total_std_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_total_std_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（累计）指标接口
        
        @param request: QueryYydTotalStdStatisticalDataRequest
        @return: QueryYydTotalStdStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalStdStatisticalDataHeaders()
        return await self.query_yyd_total_std_statistical_data_with_options_async(request, headers, runtime)

    def query_yyd_total_week_statistical_data_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按周统计）指标接口
        
        @param request: QueryYydTotalWeekStatisticalDataRequest
        @param headers: QueryYydTotalWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTotalWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTotalWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTotalWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_yyd_total_week_statistical_data_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataRequest,
        headers: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按周统计）指标接口
        
        @param request: QueryYydTotalWeekStatisticalDataRequest
        @param headers: QueryYydTotalWeekStatisticalDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryYydTotalWeekStatisticalDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='QueryYydTotalWeekStatisticalData',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/yydTotalWeekDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_yyd_total_week_statistical_data(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按周统计）指标接口
        
        @param request: QueryYydTotalWeekStatisticalDataRequest
        @return: QueryYydTotalWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataHeaders()
        return self.query_yyd_total_week_statistical_data_with_options(request, headers, runtime)

    async def query_yyd_total_week_statistical_data_async(
        self,
        request: dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataRequest,
    ) -> dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataResponse:
        """
        @summary 亚运钉参谋全局概览（按周统计）指标接口
        
        @param request: QueryYydTotalWeekStatisticalDataRequest
        @return: QueryYydTotalWeekStatisticalDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.QueryYydTotalWeekStatisticalDataHeaders()
        return await self.query_yyd_total_week_statistical_data_with_options_async(request, headers, runtime)

    def search_company_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.SearchCompanyRequest,
        headers: dingtalkdatacenter__1__0_models.SearchCompanyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.SearchCompanyResponse:
        """
        @summary 通过关键词搜索企业
        
        @param request: SearchCompanyRequest
        @param headers: SearchCompanyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchCompanyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='SearchCompany',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/keywords/companies',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.SearchCompanyResponse(),
            self.execute(params, req, runtime)
        )

    async def search_company_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.SearchCompanyRequest,
        headers: dingtalkdatacenter__1__0_models.SearchCompanyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.SearchCompanyResponse:
        """
        @summary 通过关键词搜索企业
        
        @param request: SearchCompanyRequest
        @param headers: SearchCompanyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchCompanyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.search_key):
            query['searchKey'] = request.search_key
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
            action='SearchCompany',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/keywords/companies',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.SearchCompanyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_company(
        self,
        request: dingtalkdatacenter__1__0_models.SearchCompanyRequest,
    ) -> dingtalkdatacenter__1__0_models.SearchCompanyResponse:
        """
        @summary 通过关键词搜索企业
        
        @param request: SearchCompanyRequest
        @return: SearchCompanyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.SearchCompanyHeaders()
        return self.search_company_with_options(request, headers, runtime)

    async def search_company_async(
        self,
        request: dingtalkdatacenter__1__0_models.SearchCompanyRequest,
    ) -> dingtalkdatacenter__1__0_models.SearchCompanyResponse:
        """
        @summary 通过关键词搜索企业
        
        @param request: SearchCompanyRequest
        @return: SearchCompanyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.SearchCompanyHeaders()
        return await self.search_company_with_options_async(request, headers, runtime)

    def sync_data_screen_with_options(
        self,
        request: dingtalkdatacenter__1__0_models.SyncDataScreenRequest,
        headers: dingtalkdatacenter__1__0_models.SyncDataScreenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.SyncDataScreenResponse:
        """
        @summary 同步数据大屏
        
        @param request: SyncDataScreenRequest
        @param headers: SyncDataScreenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncDataScreenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.screen_id):
            body['screenId'] = request.screen_id
        if not UtilClient.is_unset(request.ticket):
            body['ticket'] = request.ticket
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
            action='SyncDataScreen',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataScreens/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.SyncDataScreenResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_data_screen_with_options_async(
        self,
        request: dingtalkdatacenter__1__0_models.SyncDataScreenRequest,
        headers: dingtalkdatacenter__1__0_models.SyncDataScreenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdatacenter__1__0_models.SyncDataScreenResponse:
        """
        @summary 同步数据大屏
        
        @param request: SyncDataScreenRequest
        @param headers: SyncDataScreenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncDataScreenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.screen_id):
            body['screenId'] = request.screen_id
        if not UtilClient.is_unset(request.ticket):
            body['ticket'] = request.ticket
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
            action='SyncDataScreen',
            version='datacenter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/datacenter/dataScreens/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdatacenter__1__0_models.SyncDataScreenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_data_screen(
        self,
        request: dingtalkdatacenter__1__0_models.SyncDataScreenRequest,
    ) -> dingtalkdatacenter__1__0_models.SyncDataScreenResponse:
        """
        @summary 同步数据大屏
        
        @param request: SyncDataScreenRequest
        @return: SyncDataScreenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.SyncDataScreenHeaders()
        return self.sync_data_screen_with_options(request, headers, runtime)

    async def sync_data_screen_async(
        self,
        request: dingtalkdatacenter__1__0_models.SyncDataScreenRequest,
    ) -> dingtalkdatacenter__1__0_models.SyncDataScreenResponse:
        """
        @summary 同步数据大屏
        
        @param request: SyncDataScreenRequest
        @return: SyncDataScreenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdatacenter__1__0_models.SyncDataScreenHeaders()
        return await self.sync_data_screen_with_options_async(request, headers, runtime)
