# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.trip_1_0 import models as dingtalktrip__1__0_models
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

    def get_travel_process_detail_with_options(
        self,
        request: dingtalktrip__1__0_models.GetTravelProcessDetailRequest,
        headers: dingtalktrip__1__0_models.GetTravelProcessDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.GetTravelProcessDetailResponse:
        """
        @summary 获取差旅审批实例详情
        
        @param request: GetTravelProcessDetailRequest
        @param headers: GetTravelProcessDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTravelProcessDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.process_corp_id):
            query['processCorpId'] = request.process_corp_id
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetTravelProcessDetail',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.GetTravelProcessDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_travel_process_detail_with_options_async(
        self,
        request: dingtalktrip__1__0_models.GetTravelProcessDetailRequest,
        headers: dingtalktrip__1__0_models.GetTravelProcessDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.GetTravelProcessDetailResponse:
        """
        @summary 获取差旅审批实例详情
        
        @param request: GetTravelProcessDetailRequest
        @param headers: GetTravelProcessDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTravelProcessDetailResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.process_corp_id):
            query['processCorpId'] = request.process_corp_id
        if not UtilClient.is_unset(request.process_instance_id):
            query['processInstanceId'] = request.process_instance_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetTravelProcessDetail',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/details',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.GetTravelProcessDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_travel_process_detail(
        self,
        request: dingtalktrip__1__0_models.GetTravelProcessDetailRequest,
    ) -> dingtalktrip__1__0_models.GetTravelProcessDetailResponse:
        """
        @summary 获取差旅审批实例详情
        
        @param request: GetTravelProcessDetailRequest
        @return: GetTravelProcessDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.GetTravelProcessDetailHeaders()
        return self.get_travel_process_detail_with_options(request, headers, runtime)

    async def get_travel_process_detail_async(
        self,
        request: dingtalktrip__1__0_models.GetTravelProcessDetailRequest,
    ) -> dingtalktrip__1__0_models.GetTravelProcessDetailResponse:
        """
        @summary 获取差旅审批实例详情
        
        @param request: GetTravelProcessDetailRequest
        @return: GetTravelProcessDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.GetTravelProcessDetailHeaders()
        return await self.get_travel_process_detail_with_options_async(request, headers, runtime)

    def pre_check_template_with_options(
        self,
        request: dingtalktrip__1__0_models.PreCheckTemplateRequest,
        headers: dingtalktrip__1__0_models.PreCheckTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.PreCheckTemplateResponse:
        """
        @summary 表单升级预校验
        
        @param request: PreCheckTemplateRequest
        @param headers: PreCheckTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PreCheckTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.customer_corp_id):
            body['customerCorpId'] = request.customer_corp_id
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
            action='PreCheckTemplate',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/templateUpgrades/preCheck',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.PreCheckTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def pre_check_template_with_options_async(
        self,
        request: dingtalktrip__1__0_models.PreCheckTemplateRequest,
        headers: dingtalktrip__1__0_models.PreCheckTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.PreCheckTemplateResponse:
        """
        @summary 表单升级预校验
        
        @param request: PreCheckTemplateRequest
        @param headers: PreCheckTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PreCheckTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.customer_corp_id):
            body['customerCorpId'] = request.customer_corp_id
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
            action='PreCheckTemplate',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/templateUpgrades/preCheck',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.PreCheckTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pre_check_template(
        self,
        request: dingtalktrip__1__0_models.PreCheckTemplateRequest,
    ) -> dingtalktrip__1__0_models.PreCheckTemplateResponse:
        """
        @summary 表单升级预校验
        
        @param request: PreCheckTemplateRequest
        @return: PreCheckTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.PreCheckTemplateHeaders()
        return self.pre_check_template_with_options(request, headers, runtime)

    async def pre_check_template_async(
        self,
        request: dingtalktrip__1__0_models.PreCheckTemplateRequest,
    ) -> dingtalktrip__1__0_models.PreCheckTemplateResponse:
        """
        @summary 表单升级预校验
        
        @param request: PreCheckTemplateRequest
        @return: PreCheckTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.PreCheckTemplateHeaders()
        return await self.pre_check_template_with_options_async(request, headers, runtime)

    def query_trip_process_templates_with_options(
        self,
        request: dingtalktrip__1__0_models.QueryTripProcessTemplatesRequest,
        headers: dingtalktrip__1__0_models.QueryTripProcessTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.QueryTripProcessTemplatesResponse:
        """
        @summary 查询审批套件详情
        
        @param request: QueryTripProcessTemplatesRequest
        @param headers: QueryTripProcessTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTripProcessTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.customer_corp_id):
            query['customerCorpId'] = request.customer_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryTripProcessTemplates',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/templatesDetails',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.QueryTripProcessTemplatesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_trip_process_templates_with_options_async(
        self,
        request: dingtalktrip__1__0_models.QueryTripProcessTemplatesRequest,
        headers: dingtalktrip__1__0_models.QueryTripProcessTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.QueryTripProcessTemplatesResponse:
        """
        @summary 查询审批套件详情
        
        @param request: QueryTripProcessTemplatesRequest
        @param headers: QueryTripProcessTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTripProcessTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.customer_corp_id):
            query['customerCorpId'] = request.customer_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryTripProcessTemplates',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/templatesDetails',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.QueryTripProcessTemplatesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_trip_process_templates(
        self,
        request: dingtalktrip__1__0_models.QueryTripProcessTemplatesRequest,
    ) -> dingtalktrip__1__0_models.QueryTripProcessTemplatesResponse:
        """
        @summary 查询审批套件详情
        
        @param request: QueryTripProcessTemplatesRequest
        @return: QueryTripProcessTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.QueryTripProcessTemplatesHeaders()
        return self.query_trip_process_templates_with_options(request, headers, runtime)

    async def query_trip_process_templates_async(
        self,
        request: dingtalktrip__1__0_models.QueryTripProcessTemplatesRequest,
    ) -> dingtalktrip__1__0_models.QueryTripProcessTemplatesResponse:
        """
        @summary 查询审批套件详情
        
        @param request: QueryTripProcessTemplatesRequest
        @return: QueryTripProcessTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.QueryTripProcessTemplatesHeaders()
        return await self.query_trip_process_templates_with_options_async(request, headers, runtime)

    def sync_business_sign_info_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncBusinessSignInfoRequest,
        headers: dingtalktrip__1__0_models.SyncBusinessSignInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncBusinessSignInfoResponse:
        """
        @summary 同步服务商企业签约变更事件
        
        @param request: SyncBusinessSignInfoRequest
        @param headers: SyncBusinessSignInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncBusinessSignInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type_list):
            body['bizTypeList'] = request.biz_type_list
        if not UtilClient.is_unset(request.gmt_org_pay):
            body['gmtOrgPay'] = request.gmt_org_pay
        if not UtilClient.is_unset(request.gmt_sign):
            body['gmtSign'] = request.gmt_sign
        if not UtilClient.is_unset(request.org_pay_status):
            body['orgPayStatus'] = request.org_pay_status
        if not UtilClient.is_unset(request.sign_status):
            body['signStatus'] = request.sign_status
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.tmc_product_detail_list):
            body['tmcProductDetailList'] = request.tmc_product_detail_list
        if not UtilClient.is_unset(request.tmc_product_list):
            body['tmcProductList'] = request.tmc_product_list
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
            action='SyncBusinessSignInfo',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/businessSignInfos/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncBusinessSignInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_business_sign_info_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncBusinessSignInfoRequest,
        headers: dingtalktrip__1__0_models.SyncBusinessSignInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncBusinessSignInfoResponse:
        """
        @summary 同步服务商企业签约变更事件
        
        @param request: SyncBusinessSignInfoRequest
        @param headers: SyncBusinessSignInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncBusinessSignInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type_list):
            body['bizTypeList'] = request.biz_type_list
        if not UtilClient.is_unset(request.gmt_org_pay):
            body['gmtOrgPay'] = request.gmt_org_pay
        if not UtilClient.is_unset(request.gmt_sign):
            body['gmtSign'] = request.gmt_sign
        if not UtilClient.is_unset(request.org_pay_status):
            body['orgPayStatus'] = request.org_pay_status
        if not UtilClient.is_unset(request.sign_status):
            body['signStatus'] = request.sign_status
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.tmc_product_detail_list):
            body['tmcProductDetailList'] = request.tmc_product_detail_list
        if not UtilClient.is_unset(request.tmc_product_list):
            body['tmcProductList'] = request.tmc_product_list
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
            action='SyncBusinessSignInfo',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/businessSignInfos/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncBusinessSignInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_business_sign_info(
        self,
        request: dingtalktrip__1__0_models.SyncBusinessSignInfoRequest,
    ) -> dingtalktrip__1__0_models.SyncBusinessSignInfoResponse:
        """
        @summary 同步服务商企业签约变更事件
        
        @param request: SyncBusinessSignInfoRequest
        @return: SyncBusinessSignInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncBusinessSignInfoHeaders()
        return self.sync_business_sign_info_with_options(request, headers, runtime)

    async def sync_business_sign_info_async(
        self,
        request: dingtalktrip__1__0_models.SyncBusinessSignInfoRequest,
    ) -> dingtalktrip__1__0_models.SyncBusinessSignInfoResponse:
        """
        @summary 同步服务商企业签约变更事件
        
        @param request: SyncBusinessSignInfoRequest
        @return: SyncBusinessSignInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncBusinessSignInfoHeaders()
        return await self.sync_business_sign_info_with_options_async(request, headers, runtime)

    def sync_cost_center_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncCostCenterRequest,
        headers: dingtalktrip__1__0_models.SyncCostCenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncCostCenterResponse:
        """
        @summary 出差表单成本中心同步
        
        @param request: SyncCostCenterRequest
        @param headers: SyncCostCenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncCostCenterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.cost_center_id):
            body['costCenterId'] = request.cost_center_id
        if not UtilClient.is_unset(request.delete_flag):
            body['deleteFlag'] = request.delete_flag
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.gmt_action):
            body['gmtAction'] = request.gmt_action
        if not UtilClient.is_unset(request.number):
            body['number'] = request.number
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.third_part_id):
            body['thirdPartId'] = request.third_part_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='SyncCostCenter',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/costCenters/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncCostCenterResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_cost_center_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncCostCenterRequest,
        headers: dingtalktrip__1__0_models.SyncCostCenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncCostCenterResponse:
        """
        @summary 出差表单成本中心同步
        
        @param request: SyncCostCenterRequest
        @param headers: SyncCostCenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncCostCenterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.cost_center_id):
            body['costCenterId'] = request.cost_center_id
        if not UtilClient.is_unset(request.delete_flag):
            body['deleteFlag'] = request.delete_flag
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.gmt_action):
            body['gmtAction'] = request.gmt_action
        if not UtilClient.is_unset(request.number):
            body['number'] = request.number
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.third_part_id):
            body['thirdPartId'] = request.third_part_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
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
            action='SyncCostCenter',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/costCenters/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncCostCenterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_cost_center(
        self,
        request: dingtalktrip__1__0_models.SyncCostCenterRequest,
    ) -> dingtalktrip__1__0_models.SyncCostCenterResponse:
        """
        @summary 出差表单成本中心同步
        
        @param request: SyncCostCenterRequest
        @return: SyncCostCenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncCostCenterHeaders()
        return self.sync_cost_center_with_options(request, headers, runtime)

    async def sync_cost_center_async(
        self,
        request: dingtalktrip__1__0_models.SyncCostCenterRequest,
    ) -> dingtalktrip__1__0_models.SyncCostCenterResponse:
        """
        @summary 出差表单成本中心同步
        
        @param request: SyncCostCenterRequest
        @return: SyncCostCenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncCostCenterHeaders()
        return await self.sync_cost_center_with_options_async(request, headers, runtime)

    def sync_cost_center_entity_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncCostCenterEntityRequest,
        headers: dingtalktrip__1__0_models.SyncCostCenterEntityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncCostCenterEntityResponse:
        """
        @summary 出差表单成本中心可用范围
        
        @param request: SyncCostCenterEntityRequest
        @param headers: SyncCostCenterEntityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncCostCenterEntityResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.cost_center_id):
            body['costCenterId'] = request.cost_center_id
        if not UtilClient.is_unset(request.del_all):
            body['delAll'] = request.del_all
        if not UtilClient.is_unset(request.entity_list):
            body['entityList'] = request.entity_list
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
            action='SyncCostCenterEntity',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/costCenters/applicableScopes/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncCostCenterEntityResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_cost_center_entity_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncCostCenterEntityRequest,
        headers: dingtalktrip__1__0_models.SyncCostCenterEntityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncCostCenterEntityResponse:
        """
        @summary 出差表单成本中心可用范围
        
        @param request: SyncCostCenterEntityRequest
        @param headers: SyncCostCenterEntityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncCostCenterEntityResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.cost_center_id):
            body['costCenterId'] = request.cost_center_id
        if not UtilClient.is_unset(request.del_all):
            body['delAll'] = request.del_all
        if not UtilClient.is_unset(request.entity_list):
            body['entityList'] = request.entity_list
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
            action='SyncCostCenterEntity',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/costCenters/applicableScopes/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncCostCenterEntityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_cost_center_entity(
        self,
        request: dingtalktrip__1__0_models.SyncCostCenterEntityRequest,
    ) -> dingtalktrip__1__0_models.SyncCostCenterEntityResponse:
        """
        @summary 出差表单成本中心可用范围
        
        @param request: SyncCostCenterEntityRequest
        @return: SyncCostCenterEntityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncCostCenterEntityHeaders()
        return self.sync_cost_center_entity_with_options(request, headers, runtime)

    async def sync_cost_center_entity_async(
        self,
        request: dingtalktrip__1__0_models.SyncCostCenterEntityRequest,
    ) -> dingtalktrip__1__0_models.SyncCostCenterEntityResponse:
        """
        @summary 出差表单成本中心可用范围
        
        @param request: SyncCostCenterEntityRequest
        @return: SyncCostCenterEntityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncCostCenterEntityHeaders()
        return await self.sync_cost_center_entity_with_options_async(request, headers, runtime)

    def sync_invoice_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncInvoiceRequest,
        headers: dingtalktrip__1__0_models.SyncInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncInvoiceResponse:
        """
        @summary 出差表单发票抬头
        
        @param request: SyncInvoiceRequest
        @param headers: SyncInvoiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncInvoiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.bank_name):
            body['bankName'] = request.bank_name
        if not UtilClient.is_unset(request.bank_no):
            body['bankNo'] = request.bank_no
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.delete_flag):
            body['deleteFlag'] = request.delete_flag
        if not UtilClient.is_unset(request.gmt_action):
            body['gmtAction'] = request.gmt_action
        if not UtilClient.is_unset(request.invoice_id):
            body['invoiceId'] = request.invoice_id
        if not UtilClient.is_unset(request.project_ids):
            body['projectIds'] = request.project_ids
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.tax_no):
            body['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.tel):
            body['tel'] = request.tel
        if not UtilClient.is_unset(request.third_part_id):
            body['thirdPartId'] = request.third_part_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.unit_type):
            body['unitType'] = request.unit_type
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
            action='SyncInvoice',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/invoiceTitles/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncInvoiceResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_invoice_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncInvoiceRequest,
        headers: dingtalktrip__1__0_models.SyncInvoiceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncInvoiceResponse:
        """
        @summary 出差表单发票抬头
        
        @param request: SyncInvoiceRequest
        @param headers: SyncInvoiceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncInvoiceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.bank_name):
            body['bankName'] = request.bank_name
        if not UtilClient.is_unset(request.bank_no):
            body['bankNo'] = request.bank_no
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.delete_flag):
            body['deleteFlag'] = request.delete_flag
        if not UtilClient.is_unset(request.gmt_action):
            body['gmtAction'] = request.gmt_action
        if not UtilClient.is_unset(request.invoice_id):
            body['invoiceId'] = request.invoice_id
        if not UtilClient.is_unset(request.project_ids):
            body['projectIds'] = request.project_ids
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.tax_no):
            body['taxNo'] = request.tax_no
        if not UtilClient.is_unset(request.tel):
            body['tel'] = request.tel
        if not UtilClient.is_unset(request.third_part_id):
            body['thirdPartId'] = request.third_part_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.unit_type):
            body['unitType'] = request.unit_type
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
            action='SyncInvoice',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/invoiceTitles/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncInvoiceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_invoice(
        self,
        request: dingtalktrip__1__0_models.SyncInvoiceRequest,
    ) -> dingtalktrip__1__0_models.SyncInvoiceResponse:
        """
        @summary 出差表单发票抬头
        
        @param request: SyncInvoiceRequest
        @return: SyncInvoiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncInvoiceHeaders()
        return self.sync_invoice_with_options(request, headers, runtime)

    async def sync_invoice_async(
        self,
        request: dingtalktrip__1__0_models.SyncInvoiceRequest,
    ) -> dingtalktrip__1__0_models.SyncInvoiceResponse:
        """
        @summary 出差表单发票抬头
        
        @param request: SyncInvoiceRequest
        @return: SyncInvoiceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncInvoiceHeaders()
        return await self.sync_invoice_with_options_async(request, headers, runtime)

    def sync_invoice_entity_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncInvoiceEntityRequest,
        headers: dingtalktrip__1__0_models.SyncInvoiceEntityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncInvoiceEntityResponse:
        """
        @summary 出差表单发票抬头可用范围
        
        @param request: SyncInvoiceEntityRequest
        @param headers: SyncInvoiceEntityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncInvoiceEntityResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.del_all):
            body['delAll'] = request.del_all
        if not UtilClient.is_unset(request.entity_list):
            body['entityList'] = request.entity_list
        if not UtilClient.is_unset(request.invoice_id):
            body['invoiceId'] = request.invoice_id
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
            action='SyncInvoiceEntity',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/invoiceTitles/applicableScopes/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncInvoiceEntityResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_invoice_entity_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncInvoiceEntityRequest,
        headers: dingtalktrip__1__0_models.SyncInvoiceEntityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncInvoiceEntityResponse:
        """
        @summary 出差表单发票抬头可用范围
        
        @param request: SyncInvoiceEntityRequest
        @param headers: SyncInvoiceEntityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncInvoiceEntityResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.del_all):
            body['delAll'] = request.del_all
        if not UtilClient.is_unset(request.entity_list):
            body['entityList'] = request.entity_list
        if not UtilClient.is_unset(request.invoice_id):
            body['invoiceId'] = request.invoice_id
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
            action='SyncInvoiceEntity',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/invoiceTitles/applicableScopes/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncInvoiceEntityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_invoice_entity(
        self,
        request: dingtalktrip__1__0_models.SyncInvoiceEntityRequest,
    ) -> dingtalktrip__1__0_models.SyncInvoiceEntityResponse:
        """
        @summary 出差表单发票抬头可用范围
        
        @param request: SyncInvoiceEntityRequest
        @return: SyncInvoiceEntityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncInvoiceEntityHeaders()
        return self.sync_invoice_entity_with_options(request, headers, runtime)

    async def sync_invoice_entity_async(
        self,
        request: dingtalktrip__1__0_models.SyncInvoiceEntityRequest,
    ) -> dingtalktrip__1__0_models.SyncInvoiceEntityResponse:
        """
        @summary 出差表单发票抬头可用范围
        
        @param request: SyncInvoiceEntityRequest
        @return: SyncInvoiceEntityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncInvoiceEntityHeaders()
        return await self.sync_invoice_entity_with_options_async(request, headers, runtime)

    def sync_project_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncProjectRequest,
        headers: dingtalktrip__1__0_models.SyncProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncProjectResponse:
        """
        @summary 出差表单项目
        
        @param request: SyncProjectRequest
        @param headers: SyncProjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncProjectResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.cost_center_id):
            body['costCenterId'] = request.cost_center_id
        if not UtilClient.is_unset(request.delete_flag):
            body['deleteFlag'] = request.delete_flag
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.gmt_action):
            body['gmtAction'] = request.gmt_action
        if not UtilClient.is_unset(request.invoice_id):
            body['invoiceId'] = request.invoice_id
        if not UtilClient.is_unset(request.manager_ids):
            body['managerIds'] = request.manager_ids
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.project_name):
            body['projectName'] = request.project_name
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.third_part_id):
            body['thirdPartId'] = request.third_part_id
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
            action='SyncProject',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/projects/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncProjectResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_project_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncProjectRequest,
        headers: dingtalktrip__1__0_models.SyncProjectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncProjectResponse:
        """
        @summary 出差表单项目
        
        @param request: SyncProjectRequest
        @param headers: SyncProjectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncProjectResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.cost_center_id):
            body['costCenterId'] = request.cost_center_id
        if not UtilClient.is_unset(request.delete_flag):
            body['deleteFlag'] = request.delete_flag
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.gmt_action):
            body['gmtAction'] = request.gmt_action
        if not UtilClient.is_unset(request.invoice_id):
            body['invoiceId'] = request.invoice_id
        if not UtilClient.is_unset(request.manager_ids):
            body['managerIds'] = request.manager_ids
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.project_name):
            body['projectName'] = request.project_name
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.third_part_id):
            body['thirdPartId'] = request.third_part_id
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
            action='SyncProject',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/projects/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncProjectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_project(
        self,
        request: dingtalktrip__1__0_models.SyncProjectRequest,
    ) -> dingtalktrip__1__0_models.SyncProjectResponse:
        """
        @summary 出差表单项目
        
        @param request: SyncProjectRequest
        @return: SyncProjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncProjectHeaders()
        return self.sync_project_with_options(request, headers, runtime)

    async def sync_project_async(
        self,
        request: dingtalktrip__1__0_models.SyncProjectRequest,
    ) -> dingtalktrip__1__0_models.SyncProjectResponse:
        """
        @summary 出差表单项目
        
        @param request: SyncProjectRequest
        @return: SyncProjectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncProjectHeaders()
        return await self.sync_project_with_options_async(request, headers, runtime)

    def sync_project_entity_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncProjectEntityRequest,
        headers: dingtalktrip__1__0_models.SyncProjectEntityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncProjectEntityResponse:
        """
        @summary 出差表单项目可用范围
        
        @param request: SyncProjectEntityRequest
        @param headers: SyncProjectEntityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncProjectEntityResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.del_all):
            body['delAll'] = request.del_all
        if not UtilClient.is_unset(request.entity_list):
            body['entityList'] = request.entity_list
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
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
            action='SyncProjectEntity',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/projects/applicableScopes/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncProjectEntityResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_project_entity_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncProjectEntityRequest,
        headers: dingtalktrip__1__0_models.SyncProjectEntityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncProjectEntityResponse:
        """
        @summary 出差表单项目可用范围
        
        @param request: SyncProjectEntityRequest
        @param headers: SyncProjectEntityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncProjectEntityResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.del_all):
            body['delAll'] = request.del_all
        if not UtilClient.is_unset(request.entity_list):
            body['entityList'] = request.entity_list
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
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
            action='SyncProjectEntity',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/processes/projects/applicableScopes/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncProjectEntityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_project_entity(
        self,
        request: dingtalktrip__1__0_models.SyncProjectEntityRequest,
    ) -> dingtalktrip__1__0_models.SyncProjectEntityResponse:
        """
        @summary 出差表单项目可用范围
        
        @param request: SyncProjectEntityRequest
        @return: SyncProjectEntityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncProjectEntityHeaders()
        return self.sync_project_entity_with_options(request, headers, runtime)

    async def sync_project_entity_async(
        self,
        request: dingtalktrip__1__0_models.SyncProjectEntityRequest,
    ) -> dingtalktrip__1__0_models.SyncProjectEntityResponse:
        """
        @summary 出差表单项目可用范围
        
        @param request: SyncProjectEntityRequest
        @return: SyncProjectEntityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncProjectEntityHeaders()
        return await self.sync_project_entity_with_options_async(request, headers, runtime)

    def sync_secret_key_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncSecretKeyRequest,
        headers: dingtalktrip__1__0_models.SyncSecretKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncSecretKeyResponse:
        """
        @summary 调用本接口同步公司密钥信息。
        
        @param request: SyncSecretKeyRequest
        @param headers: SyncSecretKeyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncSecretKeyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.secret_string):
            body['secretString'] = request.secret_string
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.trip_app_key):
            body['tripAppKey'] = request.trip_app_key
        if not UtilClient.is_unset(request.trip_app_security):
            body['tripAppSecurity'] = request.trip_app_security
        if not UtilClient.is_unset(request.trip_corp_id):
            body['tripCorpId'] = request.trip_corp_id
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
            action='SyncSecretKey',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/secretKeys/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncSecretKeyResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_secret_key_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncSecretKeyRequest,
        headers: dingtalktrip__1__0_models.SyncSecretKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncSecretKeyResponse:
        """
        @summary 调用本接口同步公司密钥信息。
        
        @param request: SyncSecretKeyRequest
        @param headers: SyncSecretKeyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncSecretKeyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.secret_string):
            body['secretString'] = request.secret_string
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.trip_app_key):
            body['tripAppKey'] = request.trip_app_key
        if not UtilClient.is_unset(request.trip_app_security):
            body['tripAppSecurity'] = request.trip_app_security
        if not UtilClient.is_unset(request.trip_corp_id):
            body['tripCorpId'] = request.trip_corp_id
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
            action='SyncSecretKey',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/secretKeys/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncSecretKeyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_secret_key(
        self,
        request: dingtalktrip__1__0_models.SyncSecretKeyRequest,
    ) -> dingtalktrip__1__0_models.SyncSecretKeyResponse:
        """
        @summary 调用本接口同步公司密钥信息。
        
        @param request: SyncSecretKeyRequest
        @return: SyncSecretKeyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncSecretKeyHeaders()
        return self.sync_secret_key_with_options(request, headers, runtime)

    async def sync_secret_key_async(
        self,
        request: dingtalktrip__1__0_models.SyncSecretKeyRequest,
    ) -> dingtalktrip__1__0_models.SyncSecretKeyResponse:
        """
        @summary 调用本接口同步公司密钥信息。
        
        @param request: SyncSecretKeyRequest
        @return: SyncSecretKeyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncSecretKeyHeaders()
        return await self.sync_secret_key_with_options_async(request, headers, runtime)

    def sync_trip_order_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncTripOrderRequest,
        headers: dingtalktrip__1__0_models.SyncTripOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncTripOrderResponse:
        """
        @summary 同步出行订单变更事件
        
        @param request: SyncTripOrderRequest
        @param headers: SyncTripOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncTripOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_extension):
            body['bizExtension'] = request.biz_extension
        if not UtilClient.is_unset(request.channel_type):
            body['channelType'] = request.channel_type
        if not UtilClient.is_unset(request.currency):
            body['currency'] = request.currency
        if not UtilClient.is_unset(request.ding_user_id):
            body['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.discount_amount):
            body['discountAmount'] = request.discount_amount
        if not UtilClient.is_unset(request.endorse_flag):
            body['endorseFlag'] = request.endorse_flag
        if not UtilClient.is_unset(request.event):
            body['event'] = request.event
        if not UtilClient.is_unset(request.gmt_order):
            body['gmtOrder'] = request.gmt_order
        if not UtilClient.is_unset(request.gmt_pay):
            body['gmtPay'] = request.gmt_pay
        if not UtilClient.is_unset(request.gmt_refund):
            body['gmtRefund'] = request.gmt_refund
        if not UtilClient.is_unset(request.invoice_apply_url):
            body['invoiceApplyUrl'] = request.invoice_apply_url
        if not UtilClient.is_unset(request.journey_biz_no):
            body['journeyBizNo'] = request.journey_biz_no
        if not UtilClient.is_unset(request.order_details):
            body['orderDetails'] = request.order_details
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.order_url):
            body['orderUrl'] = request.order_url
        if not UtilClient.is_unset(request.process_id):
            body['processId'] = request.process_id
        if not UtilClient.is_unset(request.real_amount):
            body['realAmount'] = request.real_amount
        if not UtilClient.is_unset(request.refund_amount):
            body['refundAmount'] = request.refund_amount
        if not UtilClient.is_unset(request.relative_order_no):
            body['relativeOrderNo'] = request.relative_order_no
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.supply_logo):
            body['supplyLogo'] = request.supply_logo
        if not UtilClient.is_unset(request.supply_name):
            body['supplyName'] = request.supply_name
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.tmc_corp_id):
            body['tmcCorpId'] = request.tmc_corp_id
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='SyncTripOrder',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/tripOrders/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncTripOrderResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_trip_order_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncTripOrderRequest,
        headers: dingtalktrip__1__0_models.SyncTripOrderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncTripOrderResponse:
        """
        @summary 同步出行订单变更事件
        
        @param request: SyncTripOrderRequest
        @param headers: SyncTripOrderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncTripOrderResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_extension):
            body['bizExtension'] = request.biz_extension
        if not UtilClient.is_unset(request.channel_type):
            body['channelType'] = request.channel_type
        if not UtilClient.is_unset(request.currency):
            body['currency'] = request.currency
        if not UtilClient.is_unset(request.ding_user_id):
            body['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.discount_amount):
            body['discountAmount'] = request.discount_amount
        if not UtilClient.is_unset(request.endorse_flag):
            body['endorseFlag'] = request.endorse_flag
        if not UtilClient.is_unset(request.event):
            body['event'] = request.event
        if not UtilClient.is_unset(request.gmt_order):
            body['gmtOrder'] = request.gmt_order
        if not UtilClient.is_unset(request.gmt_pay):
            body['gmtPay'] = request.gmt_pay
        if not UtilClient.is_unset(request.gmt_refund):
            body['gmtRefund'] = request.gmt_refund
        if not UtilClient.is_unset(request.invoice_apply_url):
            body['invoiceApplyUrl'] = request.invoice_apply_url
        if not UtilClient.is_unset(request.journey_biz_no):
            body['journeyBizNo'] = request.journey_biz_no
        if not UtilClient.is_unset(request.order_details):
            body['orderDetails'] = request.order_details
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.order_url):
            body['orderUrl'] = request.order_url
        if not UtilClient.is_unset(request.process_id):
            body['processId'] = request.process_id
        if not UtilClient.is_unset(request.real_amount):
            body['realAmount'] = request.real_amount
        if not UtilClient.is_unset(request.refund_amount):
            body['refundAmount'] = request.refund_amount
        if not UtilClient.is_unset(request.relative_order_no):
            body['relativeOrderNo'] = request.relative_order_no
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.supply_logo):
            body['supplyLogo'] = request.supply_logo
        if not UtilClient.is_unset(request.supply_name):
            body['supplyName'] = request.supply_name
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.tmc_corp_id):
            body['tmcCorpId'] = request.tmc_corp_id
        if not UtilClient.is_unset(request.total_amount):
            body['totalAmount'] = request.total_amount
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='SyncTripOrder',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/tripOrders/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncTripOrderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_trip_order(
        self,
        request: dingtalktrip__1__0_models.SyncTripOrderRequest,
    ) -> dingtalktrip__1__0_models.SyncTripOrderResponse:
        """
        @summary 同步出行订单变更事件
        
        @param request: SyncTripOrderRequest
        @return: SyncTripOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncTripOrderHeaders()
        return self.sync_trip_order_with_options(request, headers, runtime)

    async def sync_trip_order_async(
        self,
        request: dingtalktrip__1__0_models.SyncTripOrderRequest,
    ) -> dingtalktrip__1__0_models.SyncTripOrderResponse:
        """
        @summary 同步出行订单变更事件
        
        @param request: SyncTripOrderRequest
        @return: SyncTripOrderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncTripOrderHeaders()
        return await self.sync_trip_order_with_options_async(request, headers, runtime)

    def sync_trip_product_config_with_options(
        self,
        request: dingtalktrip__1__0_models.SyncTripProductConfigRequest,
        headers: dingtalktrip__1__0_models.SyncTripProductConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncTripProductConfigResponse:
        """
        @summary 预订管理产品线配置同步
        
        @param request: SyncTripProductConfigRequest
        @param headers: SyncTripProductConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncTripProductConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.trip_product_config_list):
            body['tripProductConfigList'] = request.trip_product_config_list
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
            action='SyncTripProductConfig',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/productConfigs/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncTripProductConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_trip_product_config_with_options_async(
        self,
        request: dingtalktrip__1__0_models.SyncTripProductConfigRequest,
        headers: dingtalktrip__1__0_models.SyncTripProductConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.SyncTripProductConfigResponse:
        """
        @summary 预订管理产品线配置同步
        
        @param request: SyncTripProductConfigRequest
        @param headers: SyncTripProductConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncTripProductConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.trip_product_config_list):
            body['tripProductConfigList'] = request.trip_product_config_list
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
            action='SyncTripProductConfig',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/productConfigs/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.SyncTripProductConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_trip_product_config(
        self,
        request: dingtalktrip__1__0_models.SyncTripProductConfigRequest,
    ) -> dingtalktrip__1__0_models.SyncTripProductConfigResponse:
        """
        @summary 预订管理产品线配置同步
        
        @param request: SyncTripProductConfigRequest
        @return: SyncTripProductConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncTripProductConfigHeaders()
        return self.sync_trip_product_config_with_options(request, headers, runtime)

    async def sync_trip_product_config_async(
        self,
        request: dingtalktrip__1__0_models.SyncTripProductConfigRequest,
    ) -> dingtalktrip__1__0_models.SyncTripProductConfigResponse:
        """
        @summary 预订管理产品线配置同步
        
        @param request: SyncTripProductConfigRequest
        @return: SyncTripProductConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.SyncTripProductConfigHeaders()
        return await self.sync_trip_product_config_with_options_async(request, headers, runtime)

    def trip_platform_unified_entry_with_options(
        self,
        request: dingtalktrip__1__0_models.TripPlatformUnifiedEntryRequest,
        headers: dingtalktrip__1__0_models.TripPlatformUnifiedEntryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.TripPlatformUnifiedEntryResponse:
        """
        @summary 智能差旅平台数据互通统一入口
        
        @param request: TripPlatformUnifiedEntryRequest
        @param headers: TripPlatformUnifiedEntryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TripPlatformUnifiedEntryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.messages):
            body['messages'] = request.messages
        if not UtilClient.is_unset(request.method):
            body['method'] = request.method
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
            action='TripPlatformUnifiedEntry',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/platforms/entrances/unify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.TripPlatformUnifiedEntryResponse(),
            self.execute(params, req, runtime)
        )

    async def trip_platform_unified_entry_with_options_async(
        self,
        request: dingtalktrip__1__0_models.TripPlatformUnifiedEntryRequest,
        headers: dingtalktrip__1__0_models.TripPlatformUnifiedEntryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.TripPlatformUnifiedEntryResponse:
        """
        @summary 智能差旅平台数据互通统一入口
        
        @param request: TripPlatformUnifiedEntryRequest
        @param headers: TripPlatformUnifiedEntryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TripPlatformUnifiedEntryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.messages):
            body['messages'] = request.messages
        if not UtilClient.is_unset(request.method):
            body['method'] = request.method
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
            action='TripPlatformUnifiedEntry',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/platforms/entrances/unify',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.TripPlatformUnifiedEntryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def trip_platform_unified_entry(
        self,
        request: dingtalktrip__1__0_models.TripPlatformUnifiedEntryRequest,
    ) -> dingtalktrip__1__0_models.TripPlatformUnifiedEntryResponse:
        """
        @summary 智能差旅平台数据互通统一入口
        
        @param request: TripPlatformUnifiedEntryRequest
        @return: TripPlatformUnifiedEntryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.TripPlatformUnifiedEntryHeaders()
        return self.trip_platform_unified_entry_with_options(request, headers, runtime)

    async def trip_platform_unified_entry_async(
        self,
        request: dingtalktrip__1__0_models.TripPlatformUnifiedEntryRequest,
    ) -> dingtalktrip__1__0_models.TripPlatformUnifiedEntryResponse:
        """
        @summary 智能差旅平台数据互通统一入口
        
        @param request: TripPlatformUnifiedEntryRequest
        @return: TripPlatformUnifiedEntryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.TripPlatformUnifiedEntryHeaders()
        return await self.trip_platform_unified_entry_with_options_async(request, headers, runtime)

    def upgrade_template_with_options(
        self,
        request: dingtalktrip__1__0_models.UpgradeTemplateRequest,
        headers: dingtalktrip__1__0_models.UpgradeTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.UpgradeTemplateResponse:
        """
        @summary 升级套件
        
        @param request: UpgradeTemplateRequest
        @param headers: UpgradeTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpgradeTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.force_upgrade):
            body['forceUpgrade'] = request.force_upgrade
        if not UtilClient.is_unset(request.tmc_corp_id):
            body['tmcCorpId'] = request.tmc_corp_id
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
            action='UpgradeTemplate',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/process/templates/upgrade',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.UpgradeTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def upgrade_template_with_options_async(
        self,
        request: dingtalktrip__1__0_models.UpgradeTemplateRequest,
        headers: dingtalktrip__1__0_models.UpgradeTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktrip__1__0_models.UpgradeTemplateResponse:
        """
        @summary 升级套件
        
        @param request: UpgradeTemplateRequest
        @param headers: UpgradeTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpgradeTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel_corp_id):
            body['channelCorpId'] = request.channel_corp_id
        if not UtilClient.is_unset(request.force_upgrade):
            body['forceUpgrade'] = request.force_upgrade
        if not UtilClient.is_unset(request.tmc_corp_id):
            body['tmcCorpId'] = request.tmc_corp_id
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
            action='UpgradeTemplate',
            version='trip_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/trip/process/templates/upgrade',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktrip__1__0_models.UpgradeTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def upgrade_template(
        self,
        request: dingtalktrip__1__0_models.UpgradeTemplateRequest,
    ) -> dingtalktrip__1__0_models.UpgradeTemplateResponse:
        """
        @summary 升级套件
        
        @param request: UpgradeTemplateRequest
        @return: UpgradeTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.UpgradeTemplateHeaders()
        return self.upgrade_template_with_options(request, headers, runtime)

    async def upgrade_template_async(
        self,
        request: dingtalktrip__1__0_models.UpgradeTemplateRequest,
    ) -> dingtalktrip__1__0_models.UpgradeTemplateResponse:
        """
        @summary 升级套件
        
        @param request: UpgradeTemplateRequest
        @return: UpgradeTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktrip__1__0_models.UpgradeTemplateHeaders()
        return await self.upgrade_template_with_options_async(request, headers, runtime)
