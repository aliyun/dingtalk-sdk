# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.industry_1_0 import models as dingtalkindustry__1__0_models
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

    def batch_get_task_result_with_options(
        self,
        request: dingtalkindustry__1__0_models.BatchGetTaskResultRequest,
        headers: dingtalkindustry__1__0_models.BatchGetTaskResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.BatchGetTaskResultResponse:
        """
        @summary 批量查询任务结果
        
        @param request: BatchGetTaskResultRequest
        @param headers: BatchGetTaskResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetTaskResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_ids):
            body['taskIds'] = request.task_ids
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
            action='BatchGetTaskResult',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/ai/taskResults/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.BatchGetTaskResultResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_get_task_result_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.BatchGetTaskResultRequest,
        headers: dingtalkindustry__1__0_models.BatchGetTaskResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.BatchGetTaskResultResponse:
        """
        @summary 批量查询任务结果
        
        @param request: BatchGetTaskResultRequest
        @param headers: BatchGetTaskResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetTaskResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_ids):
            body['taskIds'] = request.task_ids
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
            action='BatchGetTaskResult',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/ai/taskResults/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.BatchGetTaskResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_get_task_result(
        self,
        request: dingtalkindustry__1__0_models.BatchGetTaskResultRequest,
    ) -> dingtalkindustry__1__0_models.BatchGetTaskResultResponse:
        """
        @summary 批量查询任务结果
        
        @param request: BatchGetTaskResultRequest
        @return: BatchGetTaskResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.BatchGetTaskResultHeaders()
        return self.batch_get_task_result_with_options(request, headers, runtime)

    async def batch_get_task_result_async(
        self,
        request: dingtalkindustry__1__0_models.BatchGetTaskResultRequest,
    ) -> dingtalkindustry__1__0_models.BatchGetTaskResultResponse:
        """
        @summary 批量查询任务结果
        
        @param request: BatchGetTaskResultRequest
        @return: BatchGetTaskResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.BatchGetTaskResultHeaders()
        return await self.batch_get_task_result_with_options_async(request, headers, runtime)

    def business_match_with_options(
        self,
        request: dingtalkindustry__1__0_models.BusinessMatchRequest,
        headers: dingtalkindustry__1__0_models.BusinessMatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.BusinessMatchResponse:
        """
        @summary 商机匹配
        
        @param request: BusinessMatchRequest
        @param headers: BusinessMatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BusinessMatchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.business_info):
            body['businessInfo'] = request.business_info
        if not UtilClient.is_unset(request.corp_name):
            body['corpName'] = request.corp_name
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
            action='BusinessMatch',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/me/businesses/matching',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.BusinessMatchResponse(),
            self.execute(params, req, runtime)
        )

    async def business_match_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.BusinessMatchRequest,
        headers: dingtalkindustry__1__0_models.BusinessMatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.BusinessMatchResponse:
        """
        @summary 商机匹配
        
        @param request: BusinessMatchRequest
        @param headers: BusinessMatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BusinessMatchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.business_info):
            body['businessInfo'] = request.business_info
        if not UtilClient.is_unset(request.corp_name):
            body['corpName'] = request.corp_name
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
            action='BusinessMatch',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/me/businesses/matching',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.BusinessMatchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def business_match(
        self,
        request: dingtalkindustry__1__0_models.BusinessMatchRequest,
    ) -> dingtalkindustry__1__0_models.BusinessMatchResponse:
        """
        @summary 商机匹配
        
        @param request: BusinessMatchRequest
        @return: BusinessMatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.BusinessMatchHeaders()
        return self.business_match_with_options(request, headers, runtime)

    async def business_match_async(
        self,
        request: dingtalkindustry__1__0_models.BusinessMatchRequest,
    ) -> dingtalkindustry__1__0_models.BusinessMatchResponse:
        """
        @summary 商机匹配
        
        @param request: BusinessMatchRequest
        @return: BusinessMatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.BusinessMatchHeaders()
        return await self.business_match_with_options_async(request, headers, runtime)

    def business_match_result_with_options(
        self,
        request: dingtalkindustry__1__0_models.BusinessMatchResultRequest,
        headers: dingtalkindustry__1__0_models.BusinessMatchResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.BusinessMatchResultResponse:
        """
        @summary 商机匹配结果查询
        
        @param request: BusinessMatchResultRequest
        @param headers: BusinessMatchResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BusinessMatchResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='BusinessMatchResult',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/me/businesses/matchingResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.BusinessMatchResultResponse(),
            self.execute(params, req, runtime)
        )

    async def business_match_result_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.BusinessMatchResultRequest,
        headers: dingtalkindustry__1__0_models.BusinessMatchResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.BusinessMatchResultResponse:
        """
        @summary 商机匹配结果查询
        
        @param request: BusinessMatchResultRequest
        @param headers: BusinessMatchResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BusinessMatchResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.task_id):
            query['taskId'] = request.task_id
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
            action='BusinessMatchResult',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/me/businesses/matchingResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.BusinessMatchResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def business_match_result(
        self,
        request: dingtalkindustry__1__0_models.BusinessMatchResultRequest,
    ) -> dingtalkindustry__1__0_models.BusinessMatchResultResponse:
        """
        @summary 商机匹配结果查询
        
        @param request: BusinessMatchResultRequest
        @return: BusinessMatchResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.BusinessMatchResultHeaders()
        return self.business_match_result_with_options(request, headers, runtime)

    async def business_match_result_async(
        self,
        request: dingtalkindustry__1__0_models.BusinessMatchResultRequest,
    ) -> dingtalkindustry__1__0_models.BusinessMatchResultResponse:
        """
        @summary 商机匹配结果查询
        
        @param request: BusinessMatchResultRequest
        @return: BusinessMatchResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.BusinessMatchResultHeaders()
        return await self.business_match_result_with_options_async(request, headers, runtime)

    def campus_add_renter_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusAddRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusAddRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusAddRenterMemberResponse:
        """
        @summary 添加租客下成员
        
        @param request: CampusAddRenterMemberRequest
        @param headers: CampusAddRenterMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusAddRenterMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.renter_id):
            body['renterId'] = request.renter_id
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
            action='CampusAddRenterMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusAddRenterMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_add_renter_member_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusAddRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusAddRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusAddRenterMemberResponse:
        """
        @summary 添加租客下成员
        
        @param request: CampusAddRenterMemberRequest
        @param headers: CampusAddRenterMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusAddRenterMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.renter_id):
            body['renterId'] = request.renter_id
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
            action='CampusAddRenterMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusAddRenterMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_add_renter_member(
        self,
        request: dingtalkindustry__1__0_models.CampusAddRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusAddRenterMemberResponse:
        """
        @summary 添加租客下成员
        
        @param request: CampusAddRenterMemberRequest
        @return: CampusAddRenterMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusAddRenterMemberHeaders()
        return self.campus_add_renter_member_with_options(request, headers, runtime)

    async def campus_add_renter_member_async(
        self,
        request: dingtalkindustry__1__0_models.CampusAddRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusAddRenterMemberResponse:
        """
        @summary 添加租客下成员
        
        @param request: CampusAddRenterMemberRequest
        @return: CampusAddRenterMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusAddRenterMemberHeaders()
        return await self.campus_add_renter_member_with_options_async(request, headers, runtime)

    def campus_create_campus_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusCreateCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusResponse:
        """
        @summary 创建园区
        
        @param request: CampusCreateCampusRequest
        @param headers: CampusCreateCampusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusCreateCampusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.area):
            body['area'] = request.area
        if not UtilClient.is_unset(request.belong_project_group_id):
            body['belongProjectGroupId'] = request.belong_project_group_id
        if not UtilClient.is_unset(request.campus_name):
            body['campusName'] = request.campus_name
        if not UtilClient.is_unset(request.capacity):
            body['capacity'] = request.capacity
        if not UtilClient.is_unset(request.city_id):
            body['cityId'] = request.city_id
        if not UtilClient.is_unset(request.country):
            body['country'] = request.country
        if not UtilClient.is_unset(request.county_id):
            body['countyId'] = request.county_id
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.order_end_time):
            body['orderEndTime'] = request.order_end_time
        if not UtilClient.is_unset(request.order_info):
            body['orderInfo'] = request.order_info
        if not UtilClient.is_unset(request.order_start_time):
            body['orderStartTime'] = request.order_start_time
        if not UtilClient.is_unset(request.prov_id):
            body['provId'] = request.prov_id
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
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
            action='CampusCreateCampus',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateCampusResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_create_campus_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusCreateCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusResponse:
        """
        @summary 创建园区
        
        @param request: CampusCreateCampusRequest
        @param headers: CampusCreateCampusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusCreateCampusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.area):
            body['area'] = request.area
        if not UtilClient.is_unset(request.belong_project_group_id):
            body['belongProjectGroupId'] = request.belong_project_group_id
        if not UtilClient.is_unset(request.campus_name):
            body['campusName'] = request.campus_name
        if not UtilClient.is_unset(request.capacity):
            body['capacity'] = request.capacity
        if not UtilClient.is_unset(request.city_id):
            body['cityId'] = request.city_id
        if not UtilClient.is_unset(request.country):
            body['country'] = request.country
        if not UtilClient.is_unset(request.county_id):
            body['countyId'] = request.county_id
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.order_end_time):
            body['orderEndTime'] = request.order_end_time
        if not UtilClient.is_unset(request.order_info):
            body['orderInfo'] = request.order_info
        if not UtilClient.is_unset(request.order_start_time):
            body['orderStartTime'] = request.order_start_time
        if not UtilClient.is_unset(request.prov_id):
            body['provId'] = request.prov_id
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
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
            action='CampusCreateCampus',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateCampusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_create_campus(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusResponse:
        """
        @summary 创建园区
        
        @param request: CampusCreateCampusRequest
        @return: CampusCreateCampusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateCampusHeaders()
        return self.campus_create_campus_with_options(request, headers, runtime)

    async def campus_create_campus_async(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusResponse:
        """
        @summary 创建园区
        
        @param request: CampusCreateCampusRequest
        @return: CampusCreateCampusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateCampusHeaders()
        return await self.campus_create_campus_with_options_async(request, headers, runtime)

    def campus_create_campus_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusCreateCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusGroupResponse:
        """
        @summary 创建园区项目组
        
        @param request: CampusCreateCampusGroupRequest
        @param headers: CampusCreateCampusGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusCreateCampusGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='CampusCreateCampusGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateCampusGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_create_campus_group_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusCreateCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusGroupResponse:
        """
        @summary 创建园区项目组
        
        @param request: CampusCreateCampusGroupRequest
        @param headers: CampusCreateCampusGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusCreateCampusGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='CampusCreateCampusGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateCampusGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_create_campus_group(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusGroupResponse:
        """
        @summary 创建园区项目组
        
        @param request: CampusCreateCampusGroupRequest
        @return: CampusCreateCampusGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateCampusGroupHeaders()
        return self.campus_create_campus_group_with_options(request, headers, runtime)

    async def campus_create_campus_group_async(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusGroupResponse:
        """
        @summary 创建园区项目组
        
        @param request: CampusCreateCampusGroupRequest
        @return: CampusCreateCampusGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateCampusGroupHeaders()
        return await self.campus_create_campus_group_with_options_async(request, headers, runtime)

    def campus_create_renter_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusCreateRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusCreateRenterResponse:
        """
        @summary 创建租客
        
        @param request: CampusCreateRenterRequest
        @param headers: CampusCreateRenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusCreateRenterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.credit_code):
            body['creditCode'] = request.credit_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
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
            action='CampusCreateRenter',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateRenterResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_create_renter_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusCreateRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusCreateRenterResponse:
        """
        @summary 创建租客
        
        @param request: CampusCreateRenterRequest
        @param headers: CampusCreateRenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusCreateRenterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.credit_code):
            body['creditCode'] = request.credit_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
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
            action='CampusCreateRenter',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateRenterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_create_renter(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusCreateRenterResponse:
        """
        @summary 创建租客
        
        @param request: CampusCreateRenterRequest
        @return: CampusCreateRenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateRenterHeaders()
        return self.campus_create_renter_with_options(request, headers, runtime)

    async def campus_create_renter_async(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusCreateRenterResponse:
        """
        @summary 创建租客
        
        @param request: CampusCreateRenterRequest
        @return: CampusCreateRenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateRenterHeaders()
        return await self.campus_create_renter_with_options_async(request, headers, runtime)

    def campus_del_renter_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusDelRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusDelRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusDelRenterMemberResponse:
        """
        @summary 移除租客人员
        
        @param request: CampusDelRenterMemberRequest
        @param headers: CampusDelRenterMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusDelRenterMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.renter_id):
            query['renterId'] = request.renter_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusDelRenterMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters/members',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDelRenterMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_del_renter_member_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusDelRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusDelRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusDelRenterMemberResponse:
        """
        @summary 移除租客人员
        
        @param request: CampusDelRenterMemberRequest
        @param headers: CampusDelRenterMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusDelRenterMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.renter_id):
            query['renterId'] = request.renter_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusDelRenterMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters/members',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDelRenterMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_del_renter_member(
        self,
        request: dingtalkindustry__1__0_models.CampusDelRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusDelRenterMemberResponse:
        """
        @summary 移除租客人员
        
        @param request: CampusDelRenterMemberRequest
        @return: CampusDelRenterMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDelRenterMemberHeaders()
        return self.campus_del_renter_member_with_options(request, headers, runtime)

    async def campus_del_renter_member_async(
        self,
        request: dingtalkindustry__1__0_models.CampusDelRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusDelRenterMemberResponse:
        """
        @summary 移除租客人员
        
        @param request: CampusDelRenterMemberRequest
        @return: CampusDelRenterMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDelRenterMemberHeaders()
        return await self.campus_del_renter_member_with_options_async(request, headers, runtime)

    def campus_delete_campus_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusDeleteCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusDeleteCampusGroupResponse:
        """
        @summary 删除园区项目组
        
        @param request: CampusDeleteCampusGroupRequest
        @param headers: CampusDeleteCampusGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusDeleteCampusGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.campus_project_group_id):
            query['campusProjectGroupId'] = request.campus_project_group_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusDeleteCampusGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects/groups',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDeleteCampusGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_delete_campus_group_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusDeleteCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusDeleteCampusGroupResponse:
        """
        @summary 删除园区项目组
        
        @param request: CampusDeleteCampusGroupRequest
        @param headers: CampusDeleteCampusGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusDeleteCampusGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.campus_project_group_id):
            query['campusProjectGroupId'] = request.campus_project_group_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusDeleteCampusGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects/groups',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDeleteCampusGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_delete_campus_group(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusDeleteCampusGroupResponse:
        """
        @summary 删除园区项目组
        
        @param request: CampusDeleteCampusGroupRequest
        @return: CampusDeleteCampusGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDeleteCampusGroupHeaders()
        return self.campus_delete_campus_group_with_options(request, headers, runtime)

    async def campus_delete_campus_group_async(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusDeleteCampusGroupResponse:
        """
        @summary 删除园区项目组
        
        @param request: CampusDeleteCampusGroupRequest
        @return: CampusDeleteCampusGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDeleteCampusGroupHeaders()
        return await self.campus_delete_campus_group_with_options_async(request, headers, runtime)

    def campus_delete_renter_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusDeleteRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusDeleteRenterResponse:
        """
        @summary 删除租客
        
        @param request: CampusDeleteRenterRequest
        @param headers: CampusDeleteRenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusDeleteRenterResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.renter_id):
            query['renterId'] = request.renter_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusDeleteRenter',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDeleteRenterResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_delete_renter_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusDeleteRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusDeleteRenterResponse:
        """
        @summary 删除租客
        
        @param request: CampusDeleteRenterRequest
        @param headers: CampusDeleteRenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusDeleteRenterResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.renter_id):
            query['renterId'] = request.renter_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusDeleteRenter',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDeleteRenterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_delete_renter(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusDeleteRenterResponse:
        """
        @summary 删除租客
        
        @param request: CampusDeleteRenterRequest
        @return: CampusDeleteRenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDeleteRenterHeaders()
        return self.campus_delete_renter_with_options(request, headers, runtime)

    async def campus_delete_renter_async(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusDeleteRenterResponse:
        """
        @summary 删除租客
        
        @param request: CampusDeleteRenterRequest
        @return: CampusDeleteRenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDeleteRenterHeaders()
        return await self.campus_delete_renter_with_options_async(request, headers, runtime)

    def campus_get_campus_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusGetCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusResponse:
        """
        @summary 查询园区详情
        
        @param request: CampusGetCampusRequest
        @param headers: CampusGetCampusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusGetCampusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.campus_dept_id):
            query['campusDeptId'] = request.campus_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusGetCampus',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projectInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetCampusResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_get_campus_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusGetCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusResponse:
        """
        @summary 查询园区详情
        
        @param request: CampusGetCampusRequest
        @param headers: CampusGetCampusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusGetCampusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.campus_dept_id):
            query['campusDeptId'] = request.campus_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusGetCampus',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projectInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetCampusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_get_campus(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusResponse:
        """
        @summary 查询园区详情
        
        @param request: CampusGetCampusRequest
        @return: CampusGetCampusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetCampusHeaders()
        return self.campus_get_campus_with_options(request, headers, runtime)

    async def campus_get_campus_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusResponse:
        """
        @summary 查询园区详情
        
        @param request: CampusGetCampusRequest
        @return: CampusGetCampusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetCampusHeaders()
        return await self.campus_get_campus_with_options_async(request, headers, runtime)

    def campus_get_campus_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusGetCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusGroupResponse:
        """
        @summary 查询园区项目组详情
        
        @param request: CampusGetCampusGroupRequest
        @param headers: CampusGetCampusGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusGetCampusGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.group_id):
            query['groupId'] = request.group_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusGetCampusGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects/groupInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetCampusGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_get_campus_group_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusGetCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusGroupResponse:
        """
        @summary 查询园区项目组详情
        
        @param request: CampusGetCampusGroupRequest
        @param headers: CampusGetCampusGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusGetCampusGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.group_id):
            query['groupId'] = request.group_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusGetCampusGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects/groupInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetCampusGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_get_campus_group(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusGroupResponse:
        """
        @summary 查询园区项目组详情
        
        @param request: CampusGetCampusGroupRequest
        @return: CampusGetCampusGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetCampusGroupHeaders()
        return self.campus_get_campus_group_with_options(request, headers, runtime)

    async def campus_get_campus_group_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusGroupResponse:
        """
        @summary 查询园区项目组详情
        
        @param request: CampusGetCampusGroupRequest
        @return: CampusGetCampusGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetCampusGroupHeaders()
        return await self.campus_get_campus_group_with_options_async(request, headers, runtime)

    def campus_get_renter_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusGetRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterResponse:
        """
        @summary 获取租客详情
        
        @param request: CampusGetRenterRequest
        @param headers: CampusGetRenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusGetRenterResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.renter_id):
            query['renterId'] = request.renter_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusGetRenter',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renterInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetRenterResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_get_renter_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusGetRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterResponse:
        """
        @summary 获取租客详情
        
        @param request: CampusGetRenterRequest
        @param headers: CampusGetRenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusGetRenterResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.renter_id):
            query['renterId'] = request.renter_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusGetRenter',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renterInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetRenterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_get_renter(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterResponse:
        """
        @summary 获取租客详情
        
        @param request: CampusGetRenterRequest
        @return: CampusGetRenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetRenterHeaders()
        return self.campus_get_renter_with_options(request, headers, runtime)

    async def campus_get_renter_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterResponse:
        """
        @summary 获取租客详情
        
        @param request: CampusGetRenterRequest
        @return: CampusGetRenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetRenterHeaders()
        return await self.campus_get_renter_with_options_async(request, headers, runtime)

    def campus_get_renter_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusGetRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterMemberResponse:
        """
        @summary 查询租客指定成员信息
        
        @param request: CampusGetRenterMemberRequest
        @param headers: CampusGetRenterMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusGetRenterMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.renter_id):
            query['renterId'] = request.renter_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusGetRenterMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters/memberInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetRenterMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_get_renter_member_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusGetRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterMemberResponse:
        """
        @summary 查询租客指定成员信息
        
        @param request: CampusGetRenterMemberRequest
        @param headers: CampusGetRenterMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusGetRenterMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.renter_id):
            query['renterId'] = request.renter_id
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusGetRenterMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters/memberInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetRenterMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_get_renter_member(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterMemberResponse:
        """
        @summary 查询租客指定成员信息
        
        @param request: CampusGetRenterMemberRequest
        @return: CampusGetRenterMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetRenterMemberHeaders()
        return self.campus_get_renter_member_with_options(request, headers, runtime)

    async def campus_get_renter_member_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterMemberResponse:
        """
        @summary 查询租客指定成员信息
        
        @param request: CampusGetRenterMemberRequest
        @return: CampusGetRenterMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetRenterMemberHeaders()
        return await self.campus_get_renter_member_with_options_async(request, headers, runtime)

    def campus_list_campus_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusListCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusListCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListCampusResponse:
        """
        @summary 查询园区列表
        
        @param request: CampusListCampusRequest
        @param headers: CampusListCampusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusListCampusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.group_dept_id):
            query['groupDeptId'] = request.group_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusListCampus',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListCampusResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_list_campus_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusListCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusListCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListCampusResponse:
        """
        @summary 查询园区列表
        
        @param request: CampusListCampusRequest
        @param headers: CampusListCampusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusListCampusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.group_dept_id):
            query['groupDeptId'] = request.group_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusListCampus',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListCampusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_list_campus(
        self,
        request: dingtalkindustry__1__0_models.CampusListCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusListCampusResponse:
        """
        @summary 查询园区列表
        
        @param request: CampusListCampusRequest
        @return: CampusListCampusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListCampusHeaders()
        return self.campus_list_campus_with_options(request, headers, runtime)

    async def campus_list_campus_async(
        self,
        request: dingtalkindustry__1__0_models.CampusListCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusListCampusResponse:
        """
        @summary 查询园区列表
        
        @param request: CampusListCampusRequest
        @return: CampusListCampusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListCampusHeaders()
        return await self.campus_list_campus_with_options_async(request, headers, runtime)

    def campus_list_campus_group_with_options(
        self,
        headers: dingtalkindustry__1__0_models.CampusListCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListCampusGroupResponse:
        """
        @summary 查询园区项目组列表
        
        @param headers: CampusListCampusGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusListCampusGroupResponse
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
            action='CampusListCampusGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListCampusGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_list_campus_group_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.CampusListCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListCampusGroupResponse:
        """
        @summary 查询园区项目组列表
        
        @param headers: CampusListCampusGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusListCampusGroupResponse
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
            action='CampusListCampusGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListCampusGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_list_campus_group(self) -> dingtalkindustry__1__0_models.CampusListCampusGroupResponse:
        """
        @summary 查询园区项目组列表
        
        @return: CampusListCampusGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListCampusGroupHeaders()
        return self.campus_list_campus_group_with_options(headers, runtime)

    async def campus_list_campus_group_async(self) -> dingtalkindustry__1__0_models.CampusListCampusGroupResponse:
        """
        @summary 查询园区项目组列表
        
        @return: CampusListCampusGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListCampusGroupHeaders()
        return await self.campus_list_campus_group_with_options_async(headers, runtime)

    def campus_list_renter_with_options(
        self,
        headers: dingtalkindustry__1__0_models.CampusListRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListRenterResponse:
        """
        @summary 获取租客列表
        
        @param headers: CampusListRenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusListRenterResponse
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
            action='CampusListRenter',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListRenterResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_list_renter_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.CampusListRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListRenterResponse:
        """
        @summary 获取租客列表
        
        @param headers: CampusListRenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusListRenterResponse
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
            action='CampusListRenter',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListRenterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_list_renter(self) -> dingtalkindustry__1__0_models.CampusListRenterResponse:
        """
        @summary 获取租客列表
        
        @return: CampusListRenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListRenterHeaders()
        return self.campus_list_renter_with_options(headers, runtime)

    async def campus_list_renter_async(self) -> dingtalkindustry__1__0_models.CampusListRenterResponse:
        """
        @summary 获取租客列表
        
        @return: CampusListRenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListRenterHeaders()
        return await self.campus_list_renter_with_options_async(headers, runtime)

    def campus_list_renter_members_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusListRenterMembersRequest,
        headers: dingtalkindustry__1__0_models.CampusListRenterMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListRenterMembersResponse:
        """
        @summary 查询租客下所有成员
        
        @param request: CampusListRenterMembersRequest
        @param headers: CampusListRenterMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusListRenterMembersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.renter_id):
            query['renterId'] = request.renter_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusListRenterMembers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListRenterMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_list_renter_members_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusListRenterMembersRequest,
        headers: dingtalkindustry__1__0_models.CampusListRenterMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListRenterMembersResponse:
        """
        @summary 查询租客下所有成员
        
        @param request: CampusListRenterMembersRequest
        @param headers: CampusListRenterMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusListRenterMembersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.renter_id):
            query['renterId'] = request.renter_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CampusListRenterMembers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListRenterMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_list_renter_members(
        self,
        request: dingtalkindustry__1__0_models.CampusListRenterMembersRequest,
    ) -> dingtalkindustry__1__0_models.CampusListRenterMembersResponse:
        """
        @summary 查询租客下所有成员
        
        @param request: CampusListRenterMembersRequest
        @return: CampusListRenterMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListRenterMembersHeaders()
        return self.campus_list_renter_members_with_options(request, headers, runtime)

    async def campus_list_renter_members_async(
        self,
        request: dingtalkindustry__1__0_models.CampusListRenterMembersRequest,
    ) -> dingtalkindustry__1__0_models.CampusListRenterMembersResponse:
        """
        @summary 查询租客下所有成员
        
        @param request: CampusListRenterMembersRequest
        @return: CampusListRenterMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListRenterMembersHeaders()
        return await self.campus_list_renter_members_with_options_async(request, headers, runtime)

    def campus_update_campus_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusResponse:
        """
        @summary 更新园区项目
        
        @param request: CampusUpdateCampusRequest
        @param headers: CampusUpdateCampusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusUpdateCampusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.area):
            body['area'] = request.area
        if not UtilClient.is_unset(request.belong_project_group_id):
            body['belongProjectGroupId'] = request.belong_project_group_id
        if not UtilClient.is_unset(request.campus_dept_id):
            body['campusDeptId'] = request.campus_dept_id
        if not UtilClient.is_unset(request.campus_name):
            body['campusName'] = request.campus_name
        if not UtilClient.is_unset(request.capacity):
            body['capacity'] = request.capacity
        if not UtilClient.is_unset(request.city_id):
            body['cityId'] = request.city_id
        if not UtilClient.is_unset(request.country):
            body['country'] = request.country
        if not UtilClient.is_unset(request.county_id):
            body['countyId'] = request.county_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.order_end_time):
            body['orderEndTime'] = request.order_end_time
        if not UtilClient.is_unset(request.order_info):
            body['orderInfo'] = request.order_info
        if not UtilClient.is_unset(request.order_start_time):
            body['orderStartTime'] = request.order_start_time
        if not UtilClient.is_unset(request.prov_id):
            body['provId'] = request.prov_id
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
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
            action='CampusUpdateCampus',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateCampusResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_update_campus_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusResponse:
        """
        @summary 更新园区项目
        
        @param request: CampusUpdateCampusRequest
        @param headers: CampusUpdateCampusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusUpdateCampusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.area):
            body['area'] = request.area
        if not UtilClient.is_unset(request.belong_project_group_id):
            body['belongProjectGroupId'] = request.belong_project_group_id
        if not UtilClient.is_unset(request.campus_dept_id):
            body['campusDeptId'] = request.campus_dept_id
        if not UtilClient.is_unset(request.campus_name):
            body['campusName'] = request.campus_name
        if not UtilClient.is_unset(request.capacity):
            body['capacity'] = request.capacity
        if not UtilClient.is_unset(request.city_id):
            body['cityId'] = request.city_id
        if not UtilClient.is_unset(request.country):
            body['country'] = request.country
        if not UtilClient.is_unset(request.county_id):
            body['countyId'] = request.county_id
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.order_end_time):
            body['orderEndTime'] = request.order_end_time
        if not UtilClient.is_unset(request.order_info):
            body['orderInfo'] = request.order_info
        if not UtilClient.is_unset(request.order_start_time):
            body['orderStartTime'] = request.order_start_time
        if not UtilClient.is_unset(request.prov_id):
            body['provId'] = request.prov_id
        if not UtilClient.is_unset(request.telephone):
            body['telephone'] = request.telephone
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
            action='CampusUpdateCampus',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateCampusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_update_campus(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusResponse:
        """
        @summary 更新园区项目
        
        @param request: CampusUpdateCampusRequest
        @return: CampusUpdateCampusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateCampusHeaders()
        return self.campus_update_campus_with_options(request, headers, runtime)

    async def campus_update_campus_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusResponse:
        """
        @summary 更新园区项目
        
        @param request: CampusUpdateCampusRequest
        @return: CampusUpdateCampusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateCampusHeaders()
        return await self.campus_update_campus_with_options_async(request, headers, runtime)

    def campus_update_campus_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusGroupResponse:
        """
        @summary 更新园区项目组
        
        @param request: CampusUpdateCampusGroupRequest
        @param headers: CampusUpdateCampusGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusUpdateCampusGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.campus_project_group_id):
            body['campusProjectGroupId'] = request.campus_project_group_id
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='CampusUpdateCampusGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects/groups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateCampusGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_update_campus_group_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusGroupResponse:
        """
        @summary 更新园区项目组
        
        @param request: CampusUpdateCampusGroupRequest
        @param headers: CampusUpdateCampusGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusUpdateCampusGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.campus_project_group_id):
            body['campusProjectGroupId'] = request.campus_project_group_id
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='CampusUpdateCampusGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/projects/groups',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateCampusGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_update_campus_group(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusGroupResponse:
        """
        @summary 更新园区项目组
        
        @param request: CampusUpdateCampusGroupRequest
        @return: CampusUpdateCampusGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateCampusGroupHeaders()
        return self.campus_update_campus_group_with_options(request, headers, runtime)

    async def campus_update_campus_group_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusGroupResponse:
        """
        @summary 更新园区项目组
        
        @param request: CampusUpdateCampusGroupRequest
        @return: CampusUpdateCampusGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateCampusGroupHeaders()
        return await self.campus_update_campus_group_with_options_async(request, headers, runtime)

    def campus_update_renter_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterResponse:
        """
        @summary 更新租客
        
        @param request: CampusUpdateRenterRequest
        @param headers: CampusUpdateRenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusUpdateRenterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.credit_code):
            body['creditCode'] = request.credit_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.renter_id):
            body['renterId'] = request.renter_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
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
            action='CampusUpdateRenter',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateRenterResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_update_renter_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterResponse:
        """
        @summary 更新租客
        
        @param request: CampusUpdateRenterRequest
        @param headers: CampusUpdateRenterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusUpdateRenterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.credit_code):
            body['creditCode'] = request.credit_code
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.renter_id):
            body['renterId'] = request.renter_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
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
            action='CampusUpdateRenter',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateRenterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_update_renter(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterResponse:
        """
        @summary 更新租客
        
        @param request: CampusUpdateRenterRequest
        @return: CampusUpdateRenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateRenterHeaders()
        return self.campus_update_renter_with_options(request, headers, runtime)

    async def campus_update_renter_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterResponse:
        """
        @summary 更新租客
        
        @param request: CampusUpdateRenterRequest
        @return: CampusUpdateRenterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateRenterHeaders()
        return await self.campus_update_renter_with_options_async(request, headers, runtime)

    def campus_update_renter_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterMemberResponse:
        """
        @summary 更新租客下成员
        
        @param request: CampusUpdateRenterMemberRequest
        @param headers: CampusUpdateRenterMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusUpdateRenterMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.renter_id):
            body['renterId'] = request.renter_id
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='CampusUpdateRenterMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateRenterMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def campus_update_renter_member_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterMemberResponse:
        """
        @summary 更新租客下成员
        
        @param request: CampusUpdateRenterMemberRequest
        @param headers: CampusUpdateRenterMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CampusUpdateRenterMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.extend):
            body['extend'] = request.extend
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.renter_id):
            body['renterId'] = request.renter_id
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='CampusUpdateRenterMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/campuses/renters/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateRenterMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def campus_update_renter_member(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterMemberResponse:
        """
        @summary 更新租客下成员
        
        @param request: CampusUpdateRenterMemberRequest
        @return: CampusUpdateRenterMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateRenterMemberHeaders()
        return self.campus_update_renter_member_with_options(request, headers, runtime)

    async def campus_update_renter_member_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterMemberResponse:
        """
        @summary 更新租客下成员
        
        @param request: CampusUpdateRenterMemberRequest
        @return: CampusUpdateRenterMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateRenterMemberHeaders()
        return await self.campus_update_renter_member_with_options_async(request, headers, runtime)

    def chat_aiadd_dataset_permission_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionRequest,
        headers: dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionResponse:
        """
        @summary 添加数据集权限
        
        @param request: ChatAIAddDatasetPermissionRequest
        @param headers: ChatAIAddDatasetPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatAIAddDatasetPermissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.authorization_type):
            body['authorizationType'] = request.authorization_type
        if not UtilClient.is_unset(request.authorized_object_id):
            body['authorizedObjectId'] = request.authorized_object_id
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.opt_user):
            body['optUser'] = request.opt_user
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
            action='ChatAIAddDatasetPermission',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatai/dataset/permissions/add',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_aiadd_dataset_permission_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionRequest,
        headers: dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionResponse:
        """
        @summary 添加数据集权限
        
        @param request: ChatAIAddDatasetPermissionRequest
        @param headers: ChatAIAddDatasetPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatAIAddDatasetPermissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.authorization_type):
            body['authorizationType'] = request.authorization_type
        if not UtilClient.is_unset(request.authorized_object_id):
            body['authorizedObjectId'] = request.authorized_object_id
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.opt_user):
            body['optUser'] = request.opt_user
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
            action='ChatAIAddDatasetPermission',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatai/dataset/permissions/add',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_aiadd_dataset_permission(
        self,
        request: dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionRequest,
    ) -> dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionResponse:
        """
        @summary 添加数据集权限
        
        @param request: ChatAIAddDatasetPermissionRequest
        @return: ChatAIAddDatasetPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionHeaders()
        return self.chat_aiadd_dataset_permission_with_options(request, headers, runtime)

    async def chat_aiadd_dataset_permission_async(
        self,
        request: dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionRequest,
    ) -> dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionResponse:
        """
        @summary 添加数据集权限
        
        @param request: ChatAIAddDatasetPermissionRequest
        @return: ChatAIAddDatasetPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatAIAddDatasetPermissionHeaders()
        return await self.chat_aiadd_dataset_permission_with_options_async(request, headers, runtime)

    def chat_ailist_dataset_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatAIListDatasetRequest,
        headers: dingtalkindustry__1__0_models.ChatAIListDatasetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatAIListDatasetResponse:
        """
        @summary 获取chatAI应用下的数据集列表
        
        @param request: ChatAIListDatasetRequest
        @param headers: ChatAIListDatasetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatAIListDatasetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ChatAIListDataset',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatai/datasets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatAIListDatasetResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_ailist_dataset_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatAIListDatasetRequest,
        headers: dingtalkindustry__1__0_models.ChatAIListDatasetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatAIListDatasetResponse:
        """
        @summary 获取chatAI应用下的数据集列表
        
        @param request: ChatAIListDatasetRequest
        @param headers: ChatAIListDatasetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatAIListDatasetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ChatAIListDataset',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatai/datasets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatAIListDatasetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_ailist_dataset(
        self,
        request: dingtalkindustry__1__0_models.ChatAIListDatasetRequest,
    ) -> dingtalkindustry__1__0_models.ChatAIListDatasetResponse:
        """
        @summary 获取chatAI应用下的数据集列表
        
        @param request: ChatAIListDatasetRequest
        @return: ChatAIListDatasetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatAIListDatasetHeaders()
        return self.chat_ailist_dataset_with_options(request, headers, runtime)

    async def chat_ailist_dataset_async(
        self,
        request: dingtalkindustry__1__0_models.ChatAIListDatasetRequest,
    ) -> dingtalkindustry__1__0_models.ChatAIListDatasetResponse:
        """
        @summary 获取chatAI应用下的数据集列表
        
        @param request: ChatAIListDatasetRequest
        @return: ChatAIListDatasetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatAIListDatasetHeaders()
        return await self.chat_ailist_dataset_with_options_async(request, headers, runtime)

    def chat_aiquery_dataset_permission_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionRequest,
        headers: dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionResponse:
        """
        @summary 查询数据集权限明细
        
        @param request: ChatAIQueryDatasetPermissionRequest
        @param headers: ChatAIQueryDatasetPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatAIQueryDatasetPermissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dataset_id):
            query['datasetId'] = request.dataset_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ChatAIQueryDatasetPermission',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatai/dataset/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_aiquery_dataset_permission_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionRequest,
        headers: dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionResponse:
        """
        @summary 查询数据集权限明细
        
        @param request: ChatAIQueryDatasetPermissionRequest
        @param headers: ChatAIQueryDatasetPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatAIQueryDatasetPermissionResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dataset_id):
            query['datasetId'] = request.dataset_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ChatAIQueryDatasetPermission',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatai/dataset/permissions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_aiquery_dataset_permission(
        self,
        request: dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionRequest,
    ) -> dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionResponse:
        """
        @summary 查询数据集权限明细
        
        @param request: ChatAIQueryDatasetPermissionRequest
        @return: ChatAIQueryDatasetPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionHeaders()
        return self.chat_aiquery_dataset_permission_with_options(request, headers, runtime)

    async def chat_aiquery_dataset_permission_async(
        self,
        request: dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionRequest,
    ) -> dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionResponse:
        """
        @summary 查询数据集权限明细
        
        @param request: ChatAIQueryDatasetPermissionRequest
        @return: ChatAIQueryDatasetPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatAIQueryDatasetPermissionHeaders()
        return await self.chat_aiquery_dataset_permission_with_options_async(request, headers, runtime)

    def chat_airemove_dataset_permission_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionRequest,
        headers: dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionResponse:
        """
        @summary 删除数据集权限
        
        @param request: ChatAIRemoveDatasetPermissionRequest
        @param headers: ChatAIRemoveDatasetPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatAIRemoveDatasetPermissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.authorization_type):
            body['authorizationType'] = request.authorization_type
        if not UtilClient.is_unset(request.authorized_object_id):
            body['authorizedObjectId'] = request.authorized_object_id
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.opt_user):
            body['optUser'] = request.opt_user
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
            action='ChatAIRemoveDatasetPermission',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatai/dataset/permissions/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_airemove_dataset_permission_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionRequest,
        headers: dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionResponse:
        """
        @summary 删除数据集权限
        
        @param request: ChatAIRemoveDatasetPermissionRequest
        @param headers: ChatAIRemoveDatasetPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatAIRemoveDatasetPermissionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.authorization_type):
            body['authorizationType'] = request.authorization_type
        if not UtilClient.is_unset(request.authorized_object_id):
            body['authorizedObjectId'] = request.authorized_object_id
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.opt_user):
            body['optUser'] = request.opt_user
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
            action='ChatAIRemoveDatasetPermission',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatai/dataset/permissions/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_airemove_dataset_permission(
        self,
        request: dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionRequest,
    ) -> dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionResponse:
        """
        @summary 删除数据集权限
        
        @param request: ChatAIRemoveDatasetPermissionRequest
        @return: ChatAIRemoveDatasetPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionHeaders()
        return self.chat_airemove_dataset_permission_with_options(request, headers, runtime)

    async def chat_airemove_dataset_permission_async(
        self,
        request: dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionRequest,
    ) -> dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionResponse:
        """
        @summary 删除数据集权限
        
        @param request: ChatAIRemoveDatasetPermissionRequest
        @return: ChatAIRemoveDatasetPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatAIRemoveDatasetPermissionHeaders()
        return await self.chat_airemove_dataset_permission_with_options_async(request, headers, runtime)

    def chat_ai_travel_list_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatAiTravelListRequest,
        headers: dingtalkindustry__1__0_models.ChatAiTravelListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatAiTravelListResponse:
        """
        @summary 获取差旅单列表
        
        @param request: ChatAiTravelListRequest
        @param headers: ChatAiTravelListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatAiTravelListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param_list):
            body['paramList'] = request.param_list
        if not UtilClient.is_unset(request.travel_id):
            body['travelId'] = request.travel_id
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
            action='ChatAiTravelList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/ai/travelLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatAiTravelListResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_ai_travel_list_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatAiTravelListRequest,
        headers: dingtalkindustry__1__0_models.ChatAiTravelListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatAiTravelListResponse:
        """
        @summary 获取差旅单列表
        
        @param request: ChatAiTravelListRequest
        @param headers: ChatAiTravelListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatAiTravelListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param_list):
            body['paramList'] = request.param_list
        if not UtilClient.is_unset(request.travel_id):
            body['travelId'] = request.travel_id
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
            action='ChatAiTravelList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/ai/travelLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatAiTravelListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_ai_travel_list(
        self,
        request: dingtalkindustry__1__0_models.ChatAiTravelListRequest,
    ) -> dingtalkindustry__1__0_models.ChatAiTravelListResponse:
        """
        @summary 获取差旅单列表
        
        @param request: ChatAiTravelListRequest
        @return: ChatAiTravelListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatAiTravelListHeaders()
        return self.chat_ai_travel_list_with_options(request, headers, runtime)

    async def chat_ai_travel_list_async(
        self,
        request: dingtalkindustry__1__0_models.ChatAiTravelListRequest,
    ) -> dingtalkindustry__1__0_models.ChatAiTravelListResponse:
        """
        @summary 获取差旅单列表
        
        @param request: ChatAiTravelListRequest
        @return: ChatAiTravelListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatAiTravelListHeaders()
        return await self.chat_ai_travel_list_with_options_async(request, headers, runtime)

    def chat_form_get_data_for_api_access_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessRequest,
        headers: dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessResponse:
        """
        @summary ChatForm查询表单识别结果
        
        @param request: ChatFormGetDataForApiAccessRequest
        @param headers: ChatFormGetDataForApiAccessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatFormGetDataForApiAccessResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_talk_trace_id):
            query['dingTalkTraceId'] = request.ding_talk_trace_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ChatFormGetDataForApiAccess',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatform/datas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_form_get_data_for_api_access_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessRequest,
        headers: dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessResponse:
        """
        @summary ChatForm查询表单识别结果
        
        @param request: ChatFormGetDataForApiAccessRequest
        @param headers: ChatFormGetDataForApiAccessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatFormGetDataForApiAccessResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_talk_trace_id):
            query['dingTalkTraceId'] = request.ding_talk_trace_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ChatFormGetDataForApiAccess',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatform/datas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_form_get_data_for_api_access(
        self,
        request: dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessRequest,
    ) -> dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessResponse:
        """
        @summary ChatForm查询表单识别结果
        
        @param request: ChatFormGetDataForApiAccessRequest
        @return: ChatFormGetDataForApiAccessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessHeaders()
        return self.chat_form_get_data_for_api_access_with_options(request, headers, runtime)

    async def chat_form_get_data_for_api_access_async(
        self,
        request: dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessRequest,
    ) -> dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessResponse:
        """
        @summary ChatForm查询表单识别结果
        
        @param request: ChatFormGetDataForApiAccessRequest
        @return: ChatFormGetDataForApiAccessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatFormGetDataForApiAccessHeaders()
        return await self.chat_form_get_data_for_api_access_with_options_async(request, headers, runtime)

    def chat_memo_add_general_file_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoAddGeneralFileRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoAddGeneralFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoAddGeneralFileResponse:
        """
        @summary 新增普通文件
        
        @param request: ChatMemoAddGeneralFileRequest
        @param headers: ChatMemoAddGeneralFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoAddGeneralFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.download_url):
            body['downloadUrl'] = request.download_url
        if not UtilClient.is_unset(request.file_desc):
            body['fileDesc'] = request.file_desc
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.tag_list):
            body['tagList'] = request.tag_list
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
            action='ChatMemoAddGeneralFile',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/files',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoAddGeneralFileResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_memo_add_general_file_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoAddGeneralFileRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoAddGeneralFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoAddGeneralFileResponse:
        """
        @summary 新增普通文件
        
        @param request: ChatMemoAddGeneralFileRequest
        @param headers: ChatMemoAddGeneralFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoAddGeneralFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.download_url):
            body['downloadUrl'] = request.download_url
        if not UtilClient.is_unset(request.file_desc):
            body['fileDesc'] = request.file_desc
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.tag_list):
            body['tagList'] = request.tag_list
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
            action='ChatMemoAddGeneralFile',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/files',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoAddGeneralFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_memo_add_general_file(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoAddGeneralFileRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoAddGeneralFileResponse:
        """
        @summary 新增普通文件
        
        @param request: ChatMemoAddGeneralFileRequest
        @return: ChatMemoAddGeneralFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoAddGeneralFileHeaders()
        return self.chat_memo_add_general_file_with_options(request, headers, runtime)

    async def chat_memo_add_general_file_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoAddGeneralFileRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoAddGeneralFileResponse:
        """
        @summary 新增普通文件
        
        @param request: ChatMemoAddGeneralFileRequest
        @return: ChatMemoAddGeneralFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoAddGeneralFileHeaders()
        return await self.chat_memo_add_general_file_with_options_async(request, headers, runtime)

    def chat_memo_delete_general_file_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileResponse:
        """
        @summary 删除普通文件
        
        @param request: ChatMemoDeleteGeneralFileRequest
        @param headers: ChatMemoDeleteGeneralFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoDeleteGeneralFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            action='ChatMemoDeleteGeneralFile',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/files/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_memo_delete_general_file_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileResponse:
        """
        @summary 删除普通文件
        
        @param request: ChatMemoDeleteGeneralFileRequest
        @param headers: ChatMemoDeleteGeneralFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoDeleteGeneralFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            action='ChatMemoDeleteGeneralFile',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/files/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_memo_delete_general_file(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileResponse:
        """
        @summary 删除普通文件
        
        @param request: ChatMemoDeleteGeneralFileRequest
        @return: ChatMemoDeleteGeneralFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileHeaders()
        return self.chat_memo_delete_general_file_with_options(request, headers, runtime)

    async def chat_memo_delete_general_file_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileResponse:
        """
        @summary 删除普通文件
        
        @param request: ChatMemoDeleteGeneralFileRequest
        @return: ChatMemoDeleteGeneralFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoDeleteGeneralFileHeaders()
        return await self.chat_memo_delete_general_file_with_options_async(request, headers, runtime)

    def chat_memo_faq_add_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqAddRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoFaqAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqAddResponse:
        """
        @summary 新增 FAQ
        
        @param request: ChatMemoFaqAddRequest
        @param headers: ChatMemoFaqAddHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoFaqAddResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.answer):
            body['answer'] = request.answer
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.question):
            body['question'] = request.question
        if not UtilClient.is_unset(request.redirection):
            body['redirection'] = request.redirection
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
            action='ChatMemoFaqAdd',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/faq',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoFaqAddResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_memo_faq_add_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqAddRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoFaqAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqAddResponse:
        """
        @summary 新增 FAQ
        
        @param request: ChatMemoFaqAddRequest
        @param headers: ChatMemoFaqAddHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoFaqAddResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.answer):
            body['answer'] = request.answer
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.question):
            body['question'] = request.question
        if not UtilClient.is_unset(request.redirection):
            body['redirection'] = request.redirection
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
            action='ChatMemoFaqAdd',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/faq',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoFaqAddResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_memo_faq_add(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqAddRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqAddResponse:
        """
        @summary 新增 FAQ
        
        @param request: ChatMemoFaqAddRequest
        @return: ChatMemoFaqAddResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoFaqAddHeaders()
        return self.chat_memo_faq_add_with_options(request, headers, runtime)

    async def chat_memo_faq_add_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqAddRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqAddResponse:
        """
        @summary 新增 FAQ
        
        @param request: ChatMemoFaqAddRequest
        @return: ChatMemoFaqAddResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoFaqAddHeaders()
        return await self.chat_memo_faq_add_with_options_async(request, headers, runtime)

    def chat_memo_faq_delete_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqDeleteRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoFaqDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqDeleteResponse:
        """
        @summary 删除指定数据集中的FAQ
        
        @param request: ChatMemoFaqDeleteRequest
        @param headers: ChatMemoFaqDeleteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoFaqDeleteResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            action='ChatMemoFaqDelete',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/faq/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoFaqDeleteResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_memo_faq_delete_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqDeleteRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoFaqDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqDeleteResponse:
        """
        @summary 删除指定数据集中的FAQ
        
        @param request: ChatMemoFaqDeleteRequest
        @param headers: ChatMemoFaqDeleteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoFaqDeleteResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            action='ChatMemoFaqDelete',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/faq/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoFaqDeleteResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_memo_faq_delete(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqDeleteRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqDeleteResponse:
        """
        @summary 删除指定数据集中的FAQ
        
        @param request: ChatMemoFaqDeleteRequest
        @return: ChatMemoFaqDeleteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoFaqDeleteHeaders()
        return self.chat_memo_faq_delete_with_options(request, headers, runtime)

    async def chat_memo_faq_delete_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqDeleteRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqDeleteResponse:
        """
        @summary 删除指定数据集中的FAQ
        
        @param request: ChatMemoFaqDeleteRequest
        @return: ChatMemoFaqDeleteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoFaqDeleteHeaders()
        return await self.chat_memo_faq_delete_with_options_async(request, headers, runtime)

    def chat_memo_faq_list_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqListRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoFaqListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqListResponse:
        """
        @summary 查询指定数据集中的FAQ列表
        
        @param request: ChatMemoFaqListRequest
        @param headers: ChatMemoFaqListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoFaqListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dataset_id):
            query['datasetId'] = request.dataset_id
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
            action='ChatMemoFaqList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/faq/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoFaqListResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_memo_faq_list_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqListRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoFaqListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqListResponse:
        """
        @summary 查询指定数据集中的FAQ列表
        
        @param request: ChatMemoFaqListRequest
        @param headers: ChatMemoFaqListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoFaqListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dataset_id):
            query['datasetId'] = request.dataset_id
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
            action='ChatMemoFaqList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/faq/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoFaqListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_memo_faq_list(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqListRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqListResponse:
        """
        @summary 查询指定数据集中的FAQ列表
        
        @param request: ChatMemoFaqListRequest
        @return: ChatMemoFaqListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoFaqListHeaders()
        return self.chat_memo_faq_list_with_options(request, headers, runtime)

    async def chat_memo_faq_list_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoFaqListRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoFaqListResponse:
        """
        @summary 查询指定数据集中的FAQ列表
        
        @param request: ChatMemoFaqListRequest
        @return: ChatMemoFaqListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoFaqListHeaders()
        return await self.chat_memo_faq_list_with_options_async(request, headers, runtime)

    def chat_memo_get_file_list_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoGetFileListRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoGetFileListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoGetFileListResponse:
        """
        @summary 查询指定数据集中的文件列表
        
        @param request: ChatMemoGetFileListRequest
        @param headers: ChatMemoGetFileListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoGetFileListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dataset_id):
            query['datasetId'] = request.dataset_id
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
            action='ChatMemoGetFileList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/file/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoGetFileListResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_memo_get_file_list_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoGetFileListRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoGetFileListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoGetFileListResponse:
        """
        @summary 查询指定数据集中的文件列表
        
        @param request: ChatMemoGetFileListRequest
        @param headers: ChatMemoGetFileListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoGetFileListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dataset_id):
            query['datasetId'] = request.dataset_id
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
            action='ChatMemoGetFileList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/file/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoGetFileListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_memo_get_file_list(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoGetFileListRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoGetFileListResponse:
        """
        @summary 查询指定数据集中的文件列表
        
        @param request: ChatMemoGetFileListRequest
        @return: ChatMemoGetFileListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoGetFileListHeaders()
        return self.chat_memo_get_file_list_with_options(request, headers, runtime)

    async def chat_memo_get_file_list_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoGetFileListRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoGetFileListResponse:
        """
        @summary 查询指定数据集中的文件列表
        
        @param request: ChatMemoGetFileListRequest
        @return: ChatMemoGetFileListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoGetFileListHeaders()
        return await self.chat_memo_get_file_list_with_options_async(request, headers, runtime)

    def chat_memo_get_file_status_with_options(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoGetFileStatusRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoGetFileStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoGetFileStatusResponse:
        """
        @summary 获取文件状态
        
        @param request: ChatMemoGetFileStatusRequest
        @param headers: ChatMemoGetFileStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoGetFileStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            action='ChatMemoGetFileStatus',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/files/statuses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoGetFileStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_memo_get_file_status_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoGetFileStatusRequest,
        headers: dingtalkindustry__1__0_models.ChatMemoGetFileStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ChatMemoGetFileStatusResponse:
        """
        @summary 获取文件状态
        
        @param request: ChatMemoGetFileStatusRequest
        @param headers: ChatMemoGetFileStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatMemoGetFileStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dataset_id):
            body['datasetId'] = request.dataset_id
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            action='ChatMemoGetFileStatus',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatmemo/files/statuses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ChatMemoGetFileStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def chat_memo_get_file_status(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoGetFileStatusRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoGetFileStatusResponse:
        """
        @summary 获取文件状态
        
        @param request: ChatMemoGetFileStatusRequest
        @return: ChatMemoGetFileStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoGetFileStatusHeaders()
        return self.chat_memo_get_file_status_with_options(request, headers, runtime)

    async def chat_memo_get_file_status_async(
        self,
        request: dingtalkindustry__1__0_models.ChatMemoGetFileStatusRequest,
    ) -> dingtalkindustry__1__0_models.ChatMemoGetFileStatusResponse:
        """
        @summary 获取文件状态
        
        @param request: ChatMemoGetFileStatusRequest
        @return: ChatMemoGetFileStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ChatMemoGetFileStatusHeaders()
        return await self.chat_memo_get_file_status_with_options_async(request, headers, runtime)

    def college_active_college_dept_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupRequest,
        headers: dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupResponse:
        """
        @summary 开启学段/学院/年级/专业\系/班级群
        
        @param request: CollegeActiveCollegeDeptGroupRequest
        @param headers: CollegeActiveCollegeDeptGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeActiveCollegeDeptGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeActiveCollegeDeptGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/depts/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def college_active_college_dept_group_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupRequest,
        headers: dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupResponse:
        """
        @summary 开启学段/学院/年级/专业\系/班级群
        
        @param request: CollegeActiveCollegeDeptGroupRequest
        @param headers: CollegeActiveCollegeDeptGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeActiveCollegeDeptGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeActiveCollegeDeptGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/depts/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_active_college_dept_group(
        self,
        request: dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupRequest,
    ) -> dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupResponse:
        """
        @summary 开启学段/学院/年级/专业\系/班级群
        
        @param request: CollegeActiveCollegeDeptGroupRequest
        @return: CollegeActiveCollegeDeptGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupHeaders()
        return self.college_active_college_dept_group_with_options(request, headers, runtime)

    async def college_active_college_dept_group_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupRequest,
    ) -> dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupResponse:
        """
        @summary 开启学段/学院/年级/专业\系/班级群
        
        @param request: CollegeActiveCollegeDeptGroupRequest
        @return: CollegeActiveCollegeDeptGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupHeaders()
        return await self.college_active_college_dept_group_with_options_async(request, headers, runtime)

    def college_add_college_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddCollegeDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeAddCollegeDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeAddCollegeDeptResponse:
        """
        @summary 创建学段/学院/年级/专业\系/班级
        
        @param request: CollegeAddCollegeDeptRequest
        @param headers: CollegeAddCollegeDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeAddCollegeDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_name):
            query['deptName'] = request.dept_name
        if not UtilClient.is_unset(request.dept_type):
            query['deptType'] = request.dept_type
        if not UtilClient.is_unset(request.sort_factor):
            query['sortFactor'] = request.sort_factor
        if not UtilClient.is_unset(request.super_id):
            query['superId'] = request.super_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeAddCollegeDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/depts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeAddCollegeDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def college_add_college_dept_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddCollegeDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeAddCollegeDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeAddCollegeDeptResponse:
        """
        @summary 创建学段/学院/年级/专业\系/班级
        
        @param request: CollegeAddCollegeDeptRequest
        @param headers: CollegeAddCollegeDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeAddCollegeDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_name):
            query['deptName'] = request.dept_name
        if not UtilClient.is_unset(request.dept_type):
            query['deptType'] = request.dept_type
        if not UtilClient.is_unset(request.sort_factor):
            query['sortFactor'] = request.sort_factor
        if not UtilClient.is_unset(request.super_id):
            query['superId'] = request.super_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeAddCollegeDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/depts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeAddCollegeDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_add_college_dept(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddCollegeDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeAddCollegeDeptResponse:
        """
        @summary 创建学段/学院/年级/专业\系/班级
        
        @param request: CollegeAddCollegeDeptRequest
        @return: CollegeAddCollegeDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddCollegeDeptHeaders()
        return self.college_add_college_dept_with_options(request, headers, runtime)

    async def college_add_college_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddCollegeDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeAddCollegeDeptResponse:
        """
        @summary 创建学段/学院/年级/专业\系/班级
        
        @param request: CollegeAddCollegeDeptRequest
        @return: CollegeAddCollegeDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddCollegeDeptHeaders()
        return await self.college_add_college_dept_with_options_async(request, headers, runtime)

    def college_add_manager_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddManagerRequest,
        headers: dingtalkindustry__1__0_models.CollegeAddManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeAddManagerResponse:
        """
        @summary 往部门中添加负责人
        
        @param request: CollegeAddManagerRequest
        @param headers: CollegeAddManagerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeAddManagerResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            action='CollegeAddManager',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/managers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeAddManagerResponse(),
            self.execute(params, req, runtime)
        )

    async def college_add_manager_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddManagerRequest,
        headers: dingtalkindustry__1__0_models.CollegeAddManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeAddManagerResponse:
        """
        @summary 往部门中添加负责人
        
        @param request: CollegeAddManagerRequest
        @param headers: CollegeAddManagerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeAddManagerResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            action='CollegeAddManager',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/managers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeAddManagerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_add_manager(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddManagerRequest,
    ) -> dingtalkindustry__1__0_models.CollegeAddManagerResponse:
        """
        @summary 往部门中添加负责人
        
        @param request: CollegeAddManagerRequest
        @return: CollegeAddManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddManagerHeaders()
        return self.college_add_manager_with_options(request, headers, runtime)

    async def college_add_manager_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddManagerRequest,
    ) -> dingtalkindustry__1__0_models.CollegeAddManagerResponse:
        """
        @summary 往部门中添加负责人
        
        @param request: CollegeAddManagerRequest
        @return: CollegeAddManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddManagerHeaders()
        return await self.college_add_manager_with_options_async(request, headers, runtime)

    def college_add_student_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddStudentRequest,
        headers: dingtalkindustry__1__0_models.CollegeAddStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeAddStudentResponse:
        """
        @summary 在班级中添加人员
        
        @param request: CollegeAddStudentRequest
        @param headers: CollegeAddStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeAddStudentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.emp_extension):
            body['empExtension'] = request.emp_extension
        if not UtilClient.is_unset(request.gender):
            body['gender'] = request.gender
        if not UtilClient.is_unset(request.identify_id):
            body['identifyId'] = request.identify_id
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.start_year):
            body['startYear'] = request.start_year
        if not UtilClient.is_unset(request.student_name):
            body['studentName'] = request.student_name
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
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
            action='CollegeAddStudent',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/students',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeAddStudentResponse(),
            self.execute(params, req, runtime)
        )

    async def college_add_student_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddStudentRequest,
        headers: dingtalkindustry__1__0_models.CollegeAddStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeAddStudentResponse:
        """
        @summary 在班级中添加人员
        
        @param request: CollegeAddStudentRequest
        @param headers: CollegeAddStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeAddStudentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.emp_extension):
            body['empExtension'] = request.emp_extension
        if not UtilClient.is_unset(request.gender):
            body['gender'] = request.gender
        if not UtilClient.is_unset(request.identify_id):
            body['identifyId'] = request.identify_id
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.start_year):
            body['startYear'] = request.start_year
        if not UtilClient.is_unset(request.student_name):
            body['studentName'] = request.student_name
        if not UtilClient.is_unset(request.student_number):
            body['studentNumber'] = request.student_number
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
            action='CollegeAddStudent',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/students',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeAddStudentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_add_student(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddStudentRequest,
    ) -> dingtalkindustry__1__0_models.CollegeAddStudentResponse:
        """
        @summary 在班级中添加人员
        
        @param request: CollegeAddStudentRequest
        @return: CollegeAddStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddStudentHeaders()
        return self.college_add_student_with_options(request, headers, runtime)

    async def college_add_student_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddStudentRequest,
    ) -> dingtalkindustry__1__0_models.CollegeAddStudentResponse:
        """
        @summary 在班级中添加人员
        
        @param request: CollegeAddStudentRequest
        @return: CollegeAddStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddStudentHeaders()
        return await self.college_add_student_with_options_async(request, headers, runtime)

    def college_change_student_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeChangeStudentDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeChangeStudentDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeChangeStudentDeptResponse:
        """
        @summary 移动学生到其他部门
        
        @param request: CollegeChangeStudentDeptRequest
        @param headers: CollegeChangeStudentDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeChangeStudentDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.new_dept_id):
            query['newDeptId'] = request.new_dept_id
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeChangeStudentDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/students/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeChangeStudentDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def college_change_student_dept_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeChangeStudentDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeChangeStudentDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeChangeStudentDeptResponse:
        """
        @summary 移动学生到其他部门
        
        @param request: CollegeChangeStudentDeptRequest
        @param headers: CollegeChangeStudentDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeChangeStudentDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.new_dept_id):
            query['newDeptId'] = request.new_dept_id
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeChangeStudentDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/students/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeChangeStudentDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_change_student_dept(
        self,
        request: dingtalkindustry__1__0_models.CollegeChangeStudentDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeChangeStudentDeptResponse:
        """
        @summary 移动学生到其他部门
        
        @param request: CollegeChangeStudentDeptRequest
        @return: CollegeChangeStudentDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeChangeStudentDeptHeaders()
        return self.college_change_student_dept_with_options(request, headers, runtime)

    async def college_change_student_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeChangeStudentDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeChangeStudentDeptResponse:
        """
        @summary 移动学生到其他部门
        
        @param request: CollegeChangeStudentDeptRequest
        @return: CollegeChangeStudentDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeChangeStudentDeptHeaders()
        return await self.college_change_student_dept_with_options_async(request, headers, runtime)

    def college_delete_college_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptResponse:
        """
        @summary 删除学段/学院/年级/专业\系/班级
        
        @param request: CollegeDeleteCollegeDeptRequest
        @param headers: CollegeDeleteCollegeDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeDeleteCollegeDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeDeleteCollegeDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/depts',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def college_delete_college_dept_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptResponse:
        """
        @summary 删除学段/学院/年级/专业\系/班级
        
        @param request: CollegeDeleteCollegeDeptRequest
        @param headers: CollegeDeleteCollegeDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeDeleteCollegeDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeDeleteCollegeDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/depts',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_delete_college_dept(
        self,
        request: dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptResponse:
        """
        @summary 删除学段/学院/年级/专业\系/班级
        
        @param request: CollegeDeleteCollegeDeptRequest
        @return: CollegeDeleteCollegeDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptHeaders()
        return self.college_delete_college_dept_with_options(request, headers, runtime)

    async def college_delete_college_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptResponse:
        """
        @summary 删除学段/学院/年级/专业\系/班级
        
        @param request: CollegeDeleteCollegeDeptRequest
        @return: CollegeDeleteCollegeDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptHeaders()
        return await self.college_delete_college_dept_with_options_async(request, headers, runtime)

    def college_list_college_sub_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeListCollegeSubDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeListCollegeSubDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListCollegeSubDeptResponse:
        """
        @summary 获取下级节点列表
        
        @param request: CollegeListCollegeSubDeptRequest
        @param headers: CollegeListCollegeSubDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeListCollegeSubDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeListCollegeSubDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/subDepts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeListCollegeSubDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def college_list_college_sub_dept_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListCollegeSubDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeListCollegeSubDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListCollegeSubDeptResponse:
        """
        @summary 获取下级节点列表
        
        @param request: CollegeListCollegeSubDeptRequest
        @param headers: CollegeListCollegeSubDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeListCollegeSubDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeListCollegeSubDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/subDepts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeListCollegeSubDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_list_college_sub_dept(
        self,
        request: dingtalkindustry__1__0_models.CollegeListCollegeSubDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListCollegeSubDeptResponse:
        """
        @summary 获取下级节点列表
        
        @param request: CollegeListCollegeSubDeptRequest
        @return: CollegeListCollegeSubDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListCollegeSubDeptHeaders()
        return self.college_list_college_sub_dept_with_options(request, headers, runtime)

    async def college_list_college_sub_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListCollegeSubDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListCollegeSubDeptResponse:
        """
        @summary 获取下级节点列表
        
        @param request: CollegeListCollegeSubDeptRequest
        @return: CollegeListCollegeSubDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListCollegeSubDeptHeaders()
        return await self.college_list_college_sub_dept_with_options_async(request, headers, runtime)

    def college_list_dept_manager_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeListDeptManagerRequest,
        headers: dingtalkindustry__1__0_models.CollegeListDeptManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListDeptManagerResponse:
        """
        @summary 获取部门下所有负责人列表
        
        @param request: CollegeListDeptManagerRequest
        @param headers: CollegeListDeptManagerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeListDeptManagerResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            action='CollegeListDeptManager',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/managers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeListDeptManagerResponse(),
            self.execute(params, req, runtime)
        )

    async def college_list_dept_manager_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListDeptManagerRequest,
        headers: dingtalkindustry__1__0_models.CollegeListDeptManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListDeptManagerResponse:
        """
        @summary 获取部门下所有负责人列表
        
        @param request: CollegeListDeptManagerRequest
        @param headers: CollegeListDeptManagerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeListDeptManagerResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            action='CollegeListDeptManager',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/managers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeListDeptManagerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_list_dept_manager(
        self,
        request: dingtalkindustry__1__0_models.CollegeListDeptManagerRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListDeptManagerResponse:
        """
        @summary 获取部门下所有负责人列表
        
        @param request: CollegeListDeptManagerRequest
        @return: CollegeListDeptManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListDeptManagerHeaders()
        return self.college_list_dept_manager_with_options(request, headers, runtime)

    async def college_list_dept_manager_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListDeptManagerRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListDeptManagerResponse:
        """
        @summary 获取部门下所有负责人列表
        
        @param request: CollegeListDeptManagerRequest
        @return: CollegeListDeptManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListDeptManagerHeaders()
        return await self.college_list_dept_manager_with_options_async(request, headers, runtime)

    def college_list_student_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeListStudentInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeListStudentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListStudentInfoResponse:
        """
        @summary 分页获取班级下所有学生列表
        
        @param request: CollegeListStudentInfoRequest
        @param headers: CollegeListStudentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeListStudentInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.ding_student_status):
            query['dingStudentStatus'] = request.ding_student_status
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
            action='CollegeListStudentInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/students',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeListStudentInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def college_list_student_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListStudentInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeListStudentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListStudentInfoResponse:
        """
        @summary 分页获取班级下所有学生列表
        
        @param request: CollegeListStudentInfoRequest
        @param headers: CollegeListStudentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeListStudentInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.ding_student_status):
            query['dingStudentStatus'] = request.ding_student_status
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
            action='CollegeListStudentInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/students',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeListStudentInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_list_student_info(
        self,
        request: dingtalkindustry__1__0_models.CollegeListStudentInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListStudentInfoResponse:
        """
        @summary 分页获取班级下所有学生列表
        
        @param request: CollegeListStudentInfoRequest
        @return: CollegeListStudentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListStudentInfoHeaders()
        return self.college_list_student_info_with_options(request, headers, runtime)

    async def college_list_student_info_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListStudentInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListStudentInfoResponse:
        """
        @summary 分页获取班级下所有学生列表
        
        @param request: CollegeListStudentInfoRequest
        @return: CollegeListStudentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListStudentInfoHeaders()
        return await self.college_list_student_info_with_options_async(request, headers, runtime)

    def college_list_unchecked_student_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeListUncheckedStudentRequest,
        headers: dingtalkindustry__1__0_models.CollegeListUncheckedStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListUncheckedStudentResponse:
        """
        @summary 分页查询未加入组织的学生列表
        
        @param request: CollegeListUncheckedStudentRequest
        @param headers: CollegeListUncheckedStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeListUncheckedStudentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            action='CollegeListUncheckedStudent',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/organizations/unjoinedStudents',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeListUncheckedStudentResponse(),
            self.execute(params, req, runtime)
        )

    async def college_list_unchecked_student_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListUncheckedStudentRequest,
        headers: dingtalkindustry__1__0_models.CollegeListUncheckedStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListUncheckedStudentResponse:
        """
        @summary 分页查询未加入组织的学生列表
        
        @param request: CollegeListUncheckedStudentRequest
        @param headers: CollegeListUncheckedStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeListUncheckedStudentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            action='CollegeListUncheckedStudent',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/organizations/unjoinedStudents',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeListUncheckedStudentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_list_unchecked_student(
        self,
        request: dingtalkindustry__1__0_models.CollegeListUncheckedStudentRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListUncheckedStudentResponse:
        """
        @summary 分页查询未加入组织的学生列表
        
        @param request: CollegeListUncheckedStudentRequest
        @return: CollegeListUncheckedStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListUncheckedStudentHeaders()
        return self.college_list_unchecked_student_with_options(request, headers, runtime)

    async def college_list_unchecked_student_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListUncheckedStudentRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListUncheckedStudentResponse:
        """
        @summary 分页查询未加入组织的学生列表
        
        @param request: CollegeListUncheckedStudentRequest
        @return: CollegeListUncheckedStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListUncheckedStudentHeaders()
        return await self.college_list_unchecked_student_with_options_async(request, headers, runtime)

    def college_query_college_dept_group_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoResponse:
        """
        @summary 获取学段/学院/年级/专业\系/班级群群信息
        
        @param request: CollegeQueryCollegeDeptGroupInfoRequest
        @param headers: CollegeQueryCollegeDeptGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeQueryCollegeDeptGroupInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeQueryCollegeDeptGroupInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/depts/groupInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def college_query_college_dept_group_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoResponse:
        """
        @summary 获取学段/学院/年级/专业\系/班级群群信息
        
        @param request: CollegeQueryCollegeDeptGroupInfoRequest
        @param headers: CollegeQueryCollegeDeptGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeQueryCollegeDeptGroupInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeQueryCollegeDeptGroupInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/depts/groupInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_query_college_dept_group_info(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoResponse:
        """
        @summary 获取学段/学院/年级/专业\系/班级群群信息
        
        @param request: CollegeQueryCollegeDeptGroupInfoRequest
        @return: CollegeQueryCollegeDeptGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoHeaders()
        return self.college_query_college_dept_group_info_with_options(request, headers, runtime)

    async def college_query_college_dept_group_info_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoResponse:
        """
        @summary 获取学段/学院/年级/专业\系/班级群群信息
        
        @param request: CollegeQueryCollegeDeptGroupInfoRequest
        @return: CollegeQueryCollegeDeptGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoHeaders()
        return await self.college_query_college_dept_group_info_with_options_async(request, headers, runtime)

    def college_query_college_dept_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoResponse:
        """
        @summary 获取学段/学院/年级/专业\系/班级信息
        
        @param request: CollegeQueryCollegeDeptInfoRequest
        @param headers: CollegeQueryCollegeDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeQueryCollegeDeptInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeQueryCollegeDeptInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/deptInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def college_query_college_dept_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoResponse:
        """
        @summary 获取学段/学院/年级/专业\系/班级信息
        
        @param request: CollegeQueryCollegeDeptInfoRequest
        @param headers: CollegeQueryCollegeDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeQueryCollegeDeptInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeQueryCollegeDeptInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/deptInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_query_college_dept_info(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoResponse:
        """
        @summary 获取学段/学院/年级/专业\系/班级信息
        
        @param request: CollegeQueryCollegeDeptInfoRequest
        @return: CollegeQueryCollegeDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoHeaders()
        return self.college_query_college_dept_info_with_options(request, headers, runtime)

    async def college_query_college_dept_info_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoResponse:
        """
        @summary 获取学段/学院/年级/专业\系/班级信息
        
        @param request: CollegeQueryCollegeDeptInfoRequest
        @return: CollegeQueryCollegeDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoHeaders()
        return await self.college_query_college_dept_info_with_options_async(request, headers, runtime)

    def college_query_student_info_by_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptResponse:
        """
        @summary 获取指定部门下指定学生的信息
        
        @param request: CollegeQueryStudentInfoByDeptRequest
        @param headers: CollegeQueryStudentInfoByDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeQueryStudentInfoByDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeQueryStudentInfoByDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/studentinfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def college_query_student_info_by_dept_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptResponse:
        """
        @summary 获取指定部门下指定学生的信息
        
        @param request: CollegeQueryStudentInfoByDeptRequest
        @param headers: CollegeQueryStudentInfoByDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeQueryStudentInfoByDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeQueryStudentInfoByDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/studentinfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_query_student_info_by_dept(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptResponse:
        """
        @summary 获取指定部门下指定学生的信息
        
        @param request: CollegeQueryStudentInfoByDeptRequest
        @return: CollegeQueryStudentInfoByDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptHeaders()
        return self.college_query_student_info_by_dept_with_options(request, headers, runtime)

    async def college_query_student_info_by_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptResponse:
        """
        @summary 获取指定部门下指定学生的信息
        
        @param request: CollegeQueryStudentInfoByDeptRequest
        @return: CollegeQueryStudentInfoByDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptHeaders()
        return await self.college_query_student_info_by_dept_with_options_async(request, headers, runtime)

    def college_query_student_info_by_mobile_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileResponse:
        """
        @summary 根据手机号查询学生信息
        
        @param request: CollegeQueryStudentInfoByMobileRequest
        @param headers: CollegeQueryStudentInfoByMobileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeQueryStudentInfoByMobileResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeQueryStudentInfoByMobile',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/students/mobiles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileResponse(),
            self.execute(params, req, runtime)
        )

    async def college_query_student_info_by_mobile_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileResponse:
        """
        @summary 根据手机号查询学生信息
        
        @param request: CollegeQueryStudentInfoByMobileRequest
        @param headers: CollegeQueryStudentInfoByMobileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeQueryStudentInfoByMobileResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeQueryStudentInfoByMobile',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/students/mobiles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_query_student_info_by_mobile(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileResponse:
        """
        @summary 根据手机号查询学生信息
        
        @param request: CollegeQueryStudentInfoByMobileRequest
        @return: CollegeQueryStudentInfoByMobileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileHeaders()
        return self.college_query_student_info_by_mobile_with_options(request, headers, runtime)

    async def college_query_student_info_by_mobile_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileResponse:
        """
        @summary 根据手机号查询学生信息
        
        @param request: CollegeQueryStudentInfoByMobileRequest
        @return: CollegeQueryStudentInfoByMobileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileHeaders()
        return await self.college_query_student_info_by_mobile_with_options_async(request, headers, runtime)

    def college_query_student_info_by_student_id_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdResponse:
        """
        @summary 根据studentId查询学生信息
        
        @param request: CollegeQueryStudentInfoByStudentIdRequest
        @param headers: CollegeQueryStudentInfoByStudentIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeQueryStudentInfoByStudentIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeQueryStudentInfoByStudentId',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/students',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdResponse(),
            self.execute(params, req, runtime)
        )

    async def college_query_student_info_by_student_id_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdResponse:
        """
        @summary 根据studentId查询学生信息
        
        @param request: CollegeQueryStudentInfoByStudentIdRequest
        @param headers: CollegeQueryStudentInfoByStudentIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeQueryStudentInfoByStudentIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeQueryStudentInfoByStudentId',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/students',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_query_student_info_by_student_id(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdResponse:
        """
        @summary 根据studentId查询学生信息
        
        @param request: CollegeQueryStudentInfoByStudentIdRequest
        @return: CollegeQueryStudentInfoByStudentIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdHeaders()
        return self.college_query_student_info_by_student_id_with_options(request, headers, runtime)

    async def college_query_student_info_by_student_id_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdResponse:
        """
        @summary 根据studentId查询学生信息
        
        @param request: CollegeQueryStudentInfoByStudentIdRequest
        @return: CollegeQueryStudentInfoByStudentIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdHeaders()
        return await self.college_query_student_info_by_student_id_with_options_async(request, headers, runtime)

    def college_remove_manager_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveManagerRequest,
        headers: dingtalkindustry__1__0_models.CollegeRemoveManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveManagerResponse:
        """
        @summary 从部门中移除负责人
        
        @param request: CollegeRemoveManagerRequest
        @param headers: CollegeRemoveManagerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeRemoveManagerResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.is_force):
            query['isForce'] = request.is_force
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
            action='CollegeRemoveManager',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/managers',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeRemoveManagerResponse(),
            self.execute(params, req, runtime)
        )

    async def college_remove_manager_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveManagerRequest,
        headers: dingtalkindustry__1__0_models.CollegeRemoveManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveManagerResponse:
        """
        @summary 从部门中移除负责人
        
        @param request: CollegeRemoveManagerRequest
        @param headers: CollegeRemoveManagerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeRemoveManagerResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.is_force):
            query['isForce'] = request.is_force
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
            action='CollegeRemoveManager',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/managers',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeRemoveManagerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_remove_manager(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveManagerRequest,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveManagerResponse:
        """
        @summary 从部门中移除负责人
        
        @param request: CollegeRemoveManagerRequest
        @return: CollegeRemoveManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeRemoveManagerHeaders()
        return self.college_remove_manager_with_options(request, headers, runtime)

    async def college_remove_manager_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveManagerRequest,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveManagerResponse:
        """
        @summary 从部门中移除负责人
        
        @param request: CollegeRemoveManagerRequest
        @return: CollegeRemoveManagerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeRemoveManagerHeaders()
        return await self.college_remove_manager_with_options_async(request, headers, runtime)

    def college_remove_student_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveStudentRequest,
        headers: dingtalkindustry__1__0_models.CollegeRemoveStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveStudentResponse:
        """
        @summary 从部门中移除学生
        
        @param request: CollegeRemoveStudentRequest
        @param headers: CollegeRemoveStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeRemoveStudentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeRemoveStudent',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/students',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeRemoveStudentResponse(),
            self.execute(params, req, runtime)
        )

    async def college_remove_student_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveStudentRequest,
        headers: dingtalkindustry__1__0_models.CollegeRemoveStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveStudentResponse:
        """
        @summary 从部门中移除学生
        
        @param request: CollegeRemoveStudentRequest
        @param headers: CollegeRemoveStudentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeRemoveStudentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeRemoveStudent',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/students',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeRemoveStudentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_remove_student(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveStudentRequest,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveStudentResponse:
        """
        @summary 从部门中移除学生
        
        @param request: CollegeRemoveStudentRequest
        @return: CollegeRemoveStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeRemoveStudentHeaders()
        return self.college_remove_student_with_options(request, headers, runtime)

    async def college_remove_student_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveStudentRequest,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveStudentResponse:
        """
        @summary 从部门中移除学生
        
        @param request: CollegeRemoveStudentRequest
        @return: CollegeRemoveStudentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeRemoveStudentHeaders()
        return await self.college_remove_student_with_options_async(request, headers, runtime)

    def college_update_college_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptResponse:
        """
        @summary 编辑学段/学院/年级/专业\系/班级
        
        @param request: CollegeUpdateCollegeDeptRequest
        @param headers: CollegeUpdateCollegeDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeUpdateCollegeDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.dept_name):
            query['deptName'] = request.dept_name
        if not UtilClient.is_unset(request.sort_factor):
            query['sortFactor'] = request.sort_factor
        if not UtilClient.is_unset(request.super_id):
            query['superId'] = request.super_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeUpdateCollegeDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/depts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def college_update_college_dept_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptResponse:
        """
        @summary 编辑学段/学院/年级/专业\系/班级
        
        @param request: CollegeUpdateCollegeDeptRequest
        @param headers: CollegeUpdateCollegeDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeUpdateCollegeDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.dept_name):
            query['deptName'] = request.dept_name
        if not UtilClient.is_unset(request.sort_factor):
            query['sortFactor'] = request.sort_factor
        if not UtilClient.is_unset(request.super_id):
            query['superId'] = request.super_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeUpdateCollegeDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/depts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_update_college_dept(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptResponse:
        """
        @summary 编辑学段/学院/年级/专业\系/班级
        
        @param request: CollegeUpdateCollegeDeptRequest
        @return: CollegeUpdateCollegeDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptHeaders()
        return self.college_update_college_dept_with_options(request, headers, runtime)

    async def college_update_college_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptResponse:
        """
        @summary 编辑学段/学院/年级/专业\系/班级
        
        @param request: CollegeUpdateCollegeDeptRequest
        @return: CollegeUpdateCollegeDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptHeaders()
        return await self.college_update_college_dept_with_options_async(request, headers, runtime)

    def college_update_student_dept_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoResponse:
        """
        @summary 更新学生的部门相关信息
        
        @param request: CollegeUpdateStudentDeptInfoRequest
        @param headers: CollegeUpdateStudentDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeUpdateStudentDeptInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        if not UtilClient.is_unset(request.student_number):
            query['studentNumber'] = request.student_number
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeUpdateStudentDeptInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/deptInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def college_update_student_dept_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoResponse:
        """
        @summary 更新学生的部门相关信息
        
        @param request: CollegeUpdateStudentDeptInfoRequest
        @param headers: CollegeUpdateStudentDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeUpdateStudentDeptInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        if not UtilClient.is_unset(request.student_number):
            query['studentNumber'] = request.student_number
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeUpdateStudentDeptInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/deptInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_update_student_dept_info(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoResponse:
        """
        @summary 更新学生的部门相关信息
        
        @param request: CollegeUpdateStudentDeptInfoRequest
        @return: CollegeUpdateStudentDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoHeaders()
        return self.college_update_student_dept_info_with_options(request, headers, runtime)

    async def college_update_student_dept_info_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoResponse:
        """
        @summary 更新学生的部门相关信息
        
        @param request: CollegeUpdateStudentDeptInfoRequest
        @return: CollegeUpdateStudentDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoHeaders()
        return await self.college_update_student_dept_info_with_options_async(request, headers, runtime)

    def college_update_student_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateStudentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentInfoResponse:
        """
        @summary 更新班级下学生信息
        
        @param request: CollegeUpdateStudentInfoRequest
        @param headers: CollegeUpdateStudentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeUpdateStudentInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.emp_extension):
            body['empExtension'] = request.emp_extension
        if not UtilClient.is_unset(request.gender):
            body['gender'] = request.gender
        if not UtilClient.is_unset(request.identify_id):
            body['identifyId'] = request.identify_id
        if not UtilClient.is_unset(request.start_year):
            body['startYear'] = request.start_year
        if not UtilClient.is_unset(request.student_id):
            body['studentId'] = request.student_id
        if not UtilClient.is_unset(request.student_name):
            body['studentName'] = request.student_name
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
            action='CollegeUpdateStudentInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/students',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeUpdateStudentInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def college_update_student_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateStudentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentInfoResponse:
        """
        @summary 更新班级下学生信息
        
        @param request: CollegeUpdateStudentInfoRequest
        @param headers: CollegeUpdateStudentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeUpdateStudentInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.emp_extension):
            body['empExtension'] = request.emp_extension
        if not UtilClient.is_unset(request.gender):
            body['gender'] = request.gender
        if not UtilClient.is_unset(request.identify_id):
            body['identifyId'] = request.identify_id
        if not UtilClient.is_unset(request.start_year):
            body['startYear'] = request.start_year
        if not UtilClient.is_unset(request.student_id):
            body['studentId'] = request.student_id
        if not UtilClient.is_unset(request.student_name):
            body['studentName'] = request.student_name
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
            action='CollegeUpdateStudentInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/depts/students',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeUpdateStudentInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_update_student_info(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentInfoResponse:
        """
        @summary 更新班级下学生信息
        
        @param request: CollegeUpdateStudentInfoRequest
        @return: CollegeUpdateStudentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentInfoHeaders()
        return self.college_update_student_info_with_options(request, headers, runtime)

    async def college_update_student_info_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentInfoResponse:
        """
        @summary 更新班级下学生信息
        
        @param request: CollegeUpdateStudentInfoRequest
        @return: CollegeUpdateStudentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentInfoHeaders()
        return await self.college_update_student_info_with_options_async(request, headers, runtime)

    def college_update_student_moblie_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieResponse:
        """
        @summary 修改学生手机号
        
        @param request: CollegeUpdateStudentMoblieRequest
        @param headers: CollegeUpdateStudentMoblieHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeUpdateStudentMoblieResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_force):
            query['isForce'] = request.is_force
        if not UtilClient.is_unset(request.new_mobile):
            query['newMobile'] = request.new_mobile
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeUpdateStudentMoblie',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/students/mobiles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieResponse(),
            self.execute(params, req, runtime)
        )

    async def college_update_student_moblie_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieResponse:
        """
        @summary 修改学生手机号
        
        @param request: CollegeUpdateStudentMoblieRequest
        @param headers: CollegeUpdateStudentMoblieHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CollegeUpdateStudentMoblieResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_force):
            query['isForce'] = request.is_force
        if not UtilClient.is_unset(request.new_mobile):
            query['newMobile'] = request.new_mobile
        if not UtilClient.is_unset(request.student_id):
            query['studentId'] = request.student_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CollegeUpdateStudentMoblie',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/colleges/members/students/mobiles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieResponse(),
            await self.execute_async(params, req, runtime)
        )

    def college_update_student_moblie(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieResponse:
        """
        @summary 修改学生手机号
        
        @param request: CollegeUpdateStudentMoblieRequest
        @return: CollegeUpdateStudentMoblieResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieHeaders()
        return self.college_update_student_moblie_with_options(request, headers, runtime)

    async def college_update_student_moblie_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieResponse:
        """
        @summary 修改学生手机号
        
        @param request: CollegeUpdateStudentMoblieRequest
        @return: CollegeUpdateStudentMoblieResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieHeaders()
        return await self.college_update_student_moblie_with_options_async(request, headers, runtime)

    def customize_contact_create_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactCreateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactCreateResponse:
        """
        @summary 创建自定义通讯录
        
        @param request: CustomizeContactCreateRequest
        @param headers: CustomizeContactCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactCreateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.manager_id_list):
            body['managerIdList'] = request.manager_id_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
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
            action='CustomizeContactCreate',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/contacts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactCreateResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_create_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactCreateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactCreateResponse:
        """
        @summary 创建自定义通讯录
        
        @param request: CustomizeContactCreateRequest
        @param headers: CustomizeContactCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactCreateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.manager_id_list):
            body['managerIdList'] = request.manager_id_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
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
            action='CustomizeContactCreate',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/contacts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactCreateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_create(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactCreateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactCreateResponse:
        """
        @summary 创建自定义通讯录
        
        @param request: CustomizeContactCreateRequest
        @return: CustomizeContactCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactCreateHeaders()
        return self.customize_contact_create_with_options(request, headers, runtime)

    async def customize_contact_create_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactCreateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactCreateResponse:
        """
        @summary 创建自定义通讯录
        
        @param request: CustomizeContactCreateRequest
        @return: CustomizeContactCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactCreateHeaders()
        return await self.customize_contact_create_with_options_async(request, headers, runtime)

    def customize_contact_delete_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeleteRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeleteResponse:
        """
        @summary 删除自定义通讯录
        
        @param request: CustomizeContactDeleteRequest
        @param headers: CustomizeContactDeleteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeleteResponse
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
            action='CustomizeContactDelete',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/contacts',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeleteResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_delete_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeleteRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeleteResponse:
        """
        @summary 删除自定义通讯录
        
        @param request: CustomizeContactDeleteRequest
        @param headers: CustomizeContactDeleteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeleteResponse
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
            action='CustomizeContactDelete',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/contacts',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeleteResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_delete(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeleteRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeleteResponse:
        """
        @summary 删除自定义通讯录
        
        @param request: CustomizeContactDeleteRequest
        @return: CustomizeContactDeleteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeleteHeaders()
        return self.customize_contact_delete_with_options(request, headers, runtime)

    async def customize_contact_delete_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeleteRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeleteResponse:
        """
        @summary 删除自定义通讯录
        
        @param request: CustomizeContactDeleteRequest
        @return: CustomizeContactDeleteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeleteHeaders()
        return await self.customize_contact_delete_with_options_async(request, headers, runtime)

    def customize_contact_dept_create_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptCreateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptCreateResponse:
        """
        @summary 创建部门
        
        @param request: CustomizeContactDeptCreateRequest
        @param headers: CustomizeContactDeptCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptCreateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.manager_id_list):
            body['managerIdList'] = request.manager_id_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
        if not UtilClient.is_unset(request.parent_dept_id):
            body['parentDeptId'] = request.parent_dept_id
        if not UtilClient.is_unset(request.ref_id):
            body['refId'] = request.ref_id
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
            action='CustomizeContactDeptCreate',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/departments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptCreateResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_dept_create_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptCreateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptCreateResponse:
        """
        @summary 创建部门
        
        @param request: CustomizeContactDeptCreateRequest
        @param headers: CustomizeContactDeptCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptCreateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.manager_id_list):
            body['managerIdList'] = request.manager_id_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
        if not UtilClient.is_unset(request.parent_dept_id):
            body['parentDeptId'] = request.parent_dept_id
        if not UtilClient.is_unset(request.ref_id):
            body['refId'] = request.ref_id
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
            action='CustomizeContactDeptCreate',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/departments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptCreateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_dept_create(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptCreateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptCreateResponse:
        """
        @summary 创建部门
        
        @param request: CustomizeContactDeptCreateRequest
        @return: CustomizeContactDeptCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptCreateHeaders()
        return self.customize_contact_dept_create_with_options(request, headers, runtime)

    async def customize_contact_dept_create_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptCreateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptCreateResponse:
        """
        @summary 创建部门
        
        @param request: CustomizeContactDeptCreateRequest
        @return: CustomizeContactDeptCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptCreateHeaders()
        return await self.customize_contact_dept_create_with_options_async(request, headers, runtime)

    def customize_contact_dept_delete_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptDeleteRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptDeleteResponse:
        """
        @summary 删除部门
        
        @param request: CustomizeContactDeptDeleteRequest
        @param headers: CustomizeContactDeptDeleteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptDeleteResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CustomizeContactDeptDelete',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/departments',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptDeleteResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_dept_delete_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptDeleteRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptDeleteResponse:
        """
        @summary 删除部门
        
        @param request: CustomizeContactDeptDeleteRequest
        @param headers: CustomizeContactDeptDeleteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptDeleteResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CustomizeContactDeptDelete',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/departments',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptDeleteResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_dept_delete(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptDeleteRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptDeleteResponse:
        """
        @summary 删除部门
        
        @param request: CustomizeContactDeptDeleteRequest
        @return: CustomizeContactDeptDeleteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptDeleteHeaders()
        return self.customize_contact_dept_delete_with_options(request, headers, runtime)

    async def customize_contact_dept_delete_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptDeleteRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptDeleteResponse:
        """
        @summary 删除部门
        
        @param request: CustomizeContactDeptDeleteRequest
        @return: CustomizeContactDeptDeleteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptDeleteHeaders()
        return await self.customize_contact_dept_delete_with_options_async(request, headers, runtime)

    def customize_contact_dept_group_create_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateResponse:
        """
        @summary 创建自定义通讯录某个部门的部门群
        
        @param request: CustomizeContactDeptGroupCreateRequest
        @param headers: CustomizeContactDeptGroupCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptGroupCreateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
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
            action='CustomizeContactDeptGroupCreate',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/departmentGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_dept_group_create_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateResponse:
        """
        @summary 创建自定义通讯录某个部门的部门群
        
        @param request: CustomizeContactDeptGroupCreateRequest
        @param headers: CustomizeContactDeptGroupCreateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptGroupCreateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
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
            action='CustomizeContactDeptGroupCreate',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/departmentGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_dept_group_create(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateResponse:
        """
        @summary 创建自定义通讯录某个部门的部门群
        
        @param request: CustomizeContactDeptGroupCreateRequest
        @return: CustomizeContactDeptGroupCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateHeaders()
        return self.customize_contact_dept_group_create_with_options(request, headers, runtime)

    async def customize_contact_dept_group_create_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateResponse:
        """
        @summary 创建自定义通讯录某个部门的部门群
        
        @param request: CustomizeContactDeptGroupCreateRequest
        @return: CustomizeContactDeptGroupCreateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateHeaders()
        return await self.customize_contact_dept_group_create_with_options_async(request, headers, runtime)

    def customize_contact_dept_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptInfoResponse:
        """
        @summary 获取部门详情
        
        @param request: CustomizeContactDeptInfoRequest
        @param headers: CustomizeContactDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CustomizeContactDeptInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/departments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_dept_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptInfoResponse:
        """
        @summary 获取部门详情
        
        @param request: CustomizeContactDeptInfoRequest
        @param headers: CustomizeContactDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CustomizeContactDeptInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/departments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_dept_info(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptInfoResponse:
        """
        @summary 获取部门详情
        
        @param request: CustomizeContactDeptInfoRequest
        @return: CustomizeContactDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptInfoHeaders()
        return self.customize_contact_dept_info_with_options(request, headers, runtime)

    async def customize_contact_dept_info_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptInfoResponse:
        """
        @summary 获取部门详情
        
        @param request: CustomizeContactDeptInfoRequest
        @return: CustomizeContactDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptInfoHeaders()
        return await self.customize_contact_dept_info_with_options_async(request, headers, runtime)

    def customize_contact_dept_list_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptListRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptListResponse:
        """
        @summary 获取子部门列表
        
        @param request: CustomizeContactDeptListRequest
        @param headers: CustomizeContactDeptListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CustomizeContactDeptList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/subsidiaryDepartments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptListResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_dept_list_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptListRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptListResponse:
        """
        @summary 获取子部门列表
        
        @param request: CustomizeContactDeptListRequest
        @param headers: CustomizeContactDeptListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CustomizeContactDeptList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/subsidiaryDepartments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_dept_list(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptListRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptListResponse:
        """
        @summary 获取子部门列表
        
        @param request: CustomizeContactDeptListRequest
        @return: CustomizeContactDeptListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptListHeaders()
        return self.customize_contact_dept_list_with_options(request, headers, runtime)

    async def customize_contact_dept_list_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptListRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptListResponse:
        """
        @summary 获取子部门列表
        
        @param request: CustomizeContactDeptListRequest
        @return: CustomizeContactDeptListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptListHeaders()
        return await self.customize_contact_dept_list_with_options_async(request, headers, runtime)

    def customize_contact_dept_update_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptUpdateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptUpdateResponse:
        """
        @summary 更新部门
        
        @param request: CustomizeContactDeptUpdateRequest
        @param headers: CustomizeContactDeptUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.manager_id_list):
            body['managerIdList'] = request.manager_id_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
        if not UtilClient.is_unset(request.parent_dept_id):
            body['parentDeptId'] = request.parent_dept_id
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
            action='CustomizeContactDeptUpdate',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/departments',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_dept_update_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptUpdateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptUpdateResponse:
        """
        @summary 更新部门
        
        @param request: CustomizeContactDeptUpdateRequest
        @param headers: CustomizeContactDeptUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactDeptUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.manager_id_list):
            body['managerIdList'] = request.manager_id_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
        if not UtilClient.is_unset(request.parent_dept_id):
            body['parentDeptId'] = request.parent_dept_id
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
            action='CustomizeContactDeptUpdate',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/departments',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_dept_update(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptUpdateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptUpdateResponse:
        """
        @summary 更新部门
        
        @param request: CustomizeContactDeptUpdateRequest
        @return: CustomizeContactDeptUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptUpdateHeaders()
        return self.customize_contact_dept_update_with_options(request, headers, runtime)

    async def customize_contact_dept_update_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptUpdateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptUpdateResponse:
        """
        @summary 更新部门
        
        @param request: CustomizeContactDeptUpdateRequest
        @return: CustomizeContactDeptUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptUpdateHeaders()
        return await self.customize_contact_dept_update_with_options_async(request, headers, runtime)

    def customize_contact_emp_add_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpAddRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactEmpAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpAddResponse:
        """
        @summary 普通部门下添加人员
        
        @param request: CustomizeContactEmpAddRequest
        @param headers: CustomizeContactEmpAddHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactEmpAddResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='CustomizeContactEmpAdd',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpAddResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_emp_add_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpAddRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactEmpAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpAddResponse:
        """
        @summary 普通部门下添加人员
        
        @param request: CustomizeContactEmpAddRequest
        @param headers: CustomizeContactEmpAddHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactEmpAddResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='CustomizeContactEmpAdd',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpAddResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_emp_add(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpAddRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpAddResponse:
        """
        @summary 普通部门下添加人员
        
        @param request: CustomizeContactEmpAddRequest
        @return: CustomizeContactEmpAddResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpAddHeaders()
        return self.customize_contact_emp_add_with_options(request, headers, runtime)

    async def customize_contact_emp_add_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpAddRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpAddResponse:
        """
        @summary 普通部门下添加人员
        
        @param request: CustomizeContactEmpAddRequest
        @return: CustomizeContactEmpAddResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpAddHeaders()
        return await self.customize_contact_emp_add_with_options_async(request, headers, runtime)

    def customize_contact_emp_delete_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpDeleteRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactEmpDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpDeleteResponse:
        """
        @summary 普通部门下移除人员
        
        @param request: CustomizeContactEmpDeleteRequest
        @param headers: CustomizeContactEmpDeleteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactEmpDeleteResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='CustomizeContactEmpDelete',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/users/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpDeleteResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_emp_delete_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpDeleteRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactEmpDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpDeleteResponse:
        """
        @summary 普通部门下移除人员
        
        @param request: CustomizeContactEmpDeleteRequest
        @param headers: CustomizeContactEmpDeleteHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactEmpDeleteResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='CustomizeContactEmpDelete',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/users/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpDeleteResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_emp_delete(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpDeleteRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpDeleteResponse:
        """
        @summary 普通部门下移除人员
        
        @param request: CustomizeContactEmpDeleteRequest
        @return: CustomizeContactEmpDeleteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpDeleteHeaders()
        return self.customize_contact_emp_delete_with_options(request, headers, runtime)

    async def customize_contact_emp_delete_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpDeleteRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpDeleteResponse:
        """
        @summary 普通部门下移除人员
        
        @param request: CustomizeContactEmpDeleteRequest
        @return: CustomizeContactEmpDeleteResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpDeleteHeaders()
        return await self.customize_contact_emp_delete_with_options_async(request, headers, runtime)

    def customize_contact_emp_list_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpListRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactEmpListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpListResponse:
        """
        @summary 查询部门下人员
        
        @param request: CustomizeContactEmpListRequest
        @param headers: CustomizeContactEmpListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactEmpListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CustomizeContactEmpList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpListResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_emp_list_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpListRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactEmpListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpListResponse:
        """
        @summary 查询部门下人员
        
        @param request: CustomizeContactEmpListRequest
        @param headers: CustomizeContactEmpListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactEmpListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CustomizeContactEmpList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_emp_list(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpListRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpListResponse:
        """
        @summary 查询部门下人员
        
        @param request: CustomizeContactEmpListRequest
        @return: CustomizeContactEmpListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpListHeaders()
        return self.customize_contact_emp_list_with_options(request, headers, runtime)

    async def customize_contact_emp_list_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpListRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpListResponse:
        """
        @summary 查询部门下人员
        
        @param request: CustomizeContactEmpListRequest
        @return: CustomizeContactEmpListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpListHeaders()
        return await self.customize_contact_emp_list_with_options_async(request, headers, runtime)

    def customize_contact_list_with_options(
        self,
        headers: dingtalkindustry__1__0_models.CustomizeContactListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactListResponse:
        """
        @summary 获取自定义通讯录列表
        
        @param headers: CustomizeContactListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactListResponse
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
            action='CustomizeContactList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/contacts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactListResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_list_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.CustomizeContactListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactListResponse:
        """
        @summary 获取自定义通讯录列表
        
        @param headers: CustomizeContactListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactListResponse
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
            action='CustomizeContactList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/contacts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_list(self) -> dingtalkindustry__1__0_models.CustomizeContactListResponse:
        """
        @summary 获取自定义通讯录列表
        
        @return: CustomizeContactListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactListHeaders()
        return self.customize_contact_list_with_options(headers, runtime)

    async def customize_contact_list_async(self) -> dingtalkindustry__1__0_models.CustomizeContactListResponse:
        """
        @summary 获取自定义通讯录列表
        
        @return: CustomizeContactListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactListHeaders()
        return await self.customize_contact_list_with_options_async(headers, runtime)

    def customize_contact_update_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactUpdateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactUpdateResponse:
        """
        @summary 更新自定义通讯录
        
        @param request: CustomizeContactUpdateRequest
        @param headers: CustomizeContactUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.manager_id_list):
            body['managerIdList'] = request.manager_id_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
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
            action='CustomizeContactUpdate',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/contacts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def customize_contact_update_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactUpdateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactUpdateResponse:
        """
        @summary 更新自定义通讯录
        
        @param request: CustomizeContactUpdateRequest
        @param headers: CustomizeContactUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomizeContactUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.manager_id_list):
            body['managerIdList'] = request.manager_id_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.order):
            body['order'] = request.order
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
            action='CustomizeContactUpdate',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/customizations/contacts',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customize_contact_update(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactUpdateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactUpdateResponse:
        """
        @summary 更新自定义通讯录
        
        @param request: CustomizeContactUpdateRequest
        @return: CustomizeContactUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactUpdateHeaders()
        return self.customize_contact_update_with_options(request, headers, runtime)

    async def customize_contact_update_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactUpdateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactUpdateResponse:
        """
        @summary 更新自定义通讯录
        
        @param request: CustomizeContactUpdateRequest
        @return: CustomizeContactUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactUpdateHeaders()
        return await self.customize_contact_update_with_options_async(request, headers, runtime)

    def d_igital_store_message_push_with_options(
        self,
        tmp_req: dingtalkindustry__1__0_models.DIgitalStoreMessagePushRequest,
        headers: dingtalkindustry__1__0_models.DIgitalStoreMessagePushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DIgitalStoreMessagePushResponse:
        """
        @summary 门店通业务消息推送
        
        @param tmp_req: DIgitalStoreMessagePushRequest
        @param headers: DIgitalStoreMessagePushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DIgitalStoreMessagePushResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkindustry__1__0_models.DIgitalStoreMessagePushShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.message_data_list):
            request.message_data_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.message_data_list, 'messageDataList', 'json')
        query = {}
        if not UtilClient.is_unset(request.message_data_list_shrink):
            query['messageDataList'] = request.message_data_list_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DIgitalStoreMessagePush',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/messages/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DIgitalStoreMessagePushResponse(),
            self.execute(params, req, runtime)
        )

    async def d_igital_store_message_push_with_options_async(
        self,
        tmp_req: dingtalkindustry__1__0_models.DIgitalStoreMessagePushRequest,
        headers: dingtalkindustry__1__0_models.DIgitalStoreMessagePushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DIgitalStoreMessagePushResponse:
        """
        @summary 门店通业务消息推送
        
        @param tmp_req: DIgitalStoreMessagePushRequest
        @param headers: DIgitalStoreMessagePushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DIgitalStoreMessagePushResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkindustry__1__0_models.DIgitalStoreMessagePushShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.message_data_list):
            request.message_data_list_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.message_data_list, 'messageDataList', 'json')
        query = {}
        if not UtilClient.is_unset(request.message_data_list_shrink):
            query['messageDataList'] = request.message_data_list_shrink
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DIgitalStoreMessagePush',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/messages/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DIgitalStoreMessagePushResponse(),
            await self.execute_async(params, req, runtime)
        )

    def d_igital_store_message_push(
        self,
        request: dingtalkindustry__1__0_models.DIgitalStoreMessagePushRequest,
    ) -> dingtalkindustry__1__0_models.DIgitalStoreMessagePushResponse:
        """
        @summary 门店通业务消息推送
        
        @param request: DIgitalStoreMessagePushRequest
        @return: DIgitalStoreMessagePushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DIgitalStoreMessagePushHeaders()
        return self.d_igital_store_message_push_with_options(request, headers, runtime)

    async def d_igital_store_message_push_async(
        self,
        request: dingtalkindustry__1__0_models.DIgitalStoreMessagePushRequest,
    ) -> dingtalkindustry__1__0_models.DIgitalStoreMessagePushResponse:
        """
        @summary 门店通业务消息推送
        
        @param request: DIgitalStoreMessagePushRequest
        @return: DIgitalStoreMessagePushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DIgitalStoreMessagePushHeaders()
        return await self.d_igital_store_message_push_with_options_async(request, headers, runtime)

    def digital_store_card_record_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreCardRecordRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreCardRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreCardRecordResponse:
        """
        @summary 群运营-场景卡片发送记录列表
        
        @param request: DigitalStoreCardRecordRequest
        @param headers: DigitalStoreCardRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreCardRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.begin_time):
            body['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.ids):
            body['ids'] = request.ids
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.scene_card_name):
            body['sceneCardName'] = request.scene_card_name
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
            action='DigitalStoreCardRecord',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/cardSendRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreCardRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_card_record_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreCardRecordRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreCardRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreCardRecordResponse:
        """
        @summary 群运营-场景卡片发送记录列表
        
        @param request: DigitalStoreCardRecordRequest
        @param headers: DigitalStoreCardRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreCardRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.begin_time):
            body['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.ids):
            body['ids'] = request.ids
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.scene_card_name):
            body['sceneCardName'] = request.scene_card_name
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
            action='DigitalStoreCardRecord',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/cardSendRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreCardRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_card_record(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreCardRecordRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreCardRecordResponse:
        """
        @summary 群运营-场景卡片发送记录列表
        
        @param request: DigitalStoreCardRecordRequest
        @return: DigitalStoreCardRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreCardRecordHeaders()
        return self.digital_store_card_record_with_options(request, headers, runtime)

    async def digital_store_card_record_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreCardRecordRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreCardRecordResponse:
        """
        @summary 群运营-场景卡片发送记录列表
        
        @param request: DigitalStoreCardRecordRequest
        @return: DigitalStoreCardRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreCardRecordHeaders()
        return await self.digital_store_card_record_with_options_async(request, headers, runtime)

    def digital_store_contact_info_with_options(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreContactInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse:
        """
        @summary 查询组织中门店通通讯录基础信息
        
        @param headers: DigitalStoreContactInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreContactInfoResponse
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
            action='DigitalStoreContactInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/contactInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_contact_info_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreContactInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse:
        """
        @summary 查询组织中门店通通讯录基础信息
        
        @param headers: DigitalStoreContactInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreContactInfoResponse
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
            action='DigitalStoreContactInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/contactInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_contact_info(self) -> dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse:
        """
        @summary 查询组织中门店通通讯录基础信息
        
        @return: DigitalStoreContactInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreContactInfoHeaders()
        return self.digital_store_contact_info_with_options(headers, runtime)

    async def digital_store_contact_info_async(self) -> dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse:
        """
        @summary 查询组织中门店通通讯录基础信息
        
        @return: DigitalStoreContactInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreContactInfoHeaders()
        return await self.digital_store_contact_info_with_options_async(headers, runtime)

    def digital_store_conversations_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreConversationsRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreConversationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreConversationsResponse:
        """
        @summary 获取门店通相关会话列表（区域群、门店群）
        
        @param request: DigitalStoreConversationsRequest
        @param headers: DigitalStoreConversationsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreConversationsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.conversation_title):
            query['conversationTitle'] = request.conversation_title
        if not UtilClient.is_unset(request.conversation_type):
            query['conversationType'] = request.conversation_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreConversations',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/conversations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreConversationsResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_conversations_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreConversationsRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreConversationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreConversationsResponse:
        """
        @summary 获取门店通相关会话列表（区域群、门店群）
        
        @param request: DigitalStoreConversationsRequest
        @param headers: DigitalStoreConversationsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreConversationsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.conversation_title):
            query['conversationTitle'] = request.conversation_title
        if not UtilClient.is_unset(request.conversation_type):
            query['conversationType'] = request.conversation_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreConversations',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/conversations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreConversationsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_conversations(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreConversationsRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreConversationsResponse:
        """
        @summary 获取门店通相关会话列表（区域群、门店群）
        
        @param request: DigitalStoreConversationsRequest
        @return: DigitalStoreConversationsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreConversationsHeaders()
        return self.digital_store_conversations_with_options(request, headers, runtime)

    async def digital_store_conversations_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreConversationsRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreConversationsResponse:
        """
        @summary 获取门店通相关会话列表（区域群、门店群）
        
        @param request: DigitalStoreConversationsRequest
        @return: DigitalStoreConversationsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreConversationsHeaders()
        return await self.digital_store_conversations_with_options_async(request, headers, runtime)

    def digital_store_export_card_record_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreExportCardRecordResponse:
        """
        @summary 群运营-数据监控-导出列表
        
        @param request: DigitalStoreExportCardRecordRequest
        @param headers: DigitalStoreExportCardRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreExportCardRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.begin_time):
            body['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.ids):
            body['ids'] = request.ids
        if not UtilClient.is_unset(request.scene_card_name):
            body['sceneCardName'] = request.scene_card_name
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
            action='DigitalStoreExportCardRecord',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/cardRecords/export',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreExportCardRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_export_card_record_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreExportCardRecordResponse:
        """
        @summary 群运营-数据监控-导出列表
        
        @param request: DigitalStoreExportCardRecordRequest
        @param headers: DigitalStoreExportCardRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreExportCardRecordResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.begin_time):
            body['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.ids):
            body['ids'] = request.ids
        if not UtilClient.is_unset(request.scene_card_name):
            body['sceneCardName'] = request.scene_card_name
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
            action='DigitalStoreExportCardRecord',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/cardRecords/export',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreExportCardRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_export_card_record(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreExportCardRecordResponse:
        """
        @summary 群运营-数据监控-导出列表
        
        @param request: DigitalStoreExportCardRecordRequest
        @return: DigitalStoreExportCardRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreExportCardRecordHeaders()
        return self.digital_store_export_card_record_with_options(request, headers, runtime)

    async def digital_store_export_card_record_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreExportCardRecordResponse:
        """
        @summary 群运营-数据监控-导出列表
        
        @param request: DigitalStoreExportCardRecordRequest
        @return: DigitalStoreExportCardRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreExportCardRecordHeaders()
        return await self.digital_store_export_card_record_with_options_async(request, headers, runtime)

    def digital_store_export_card_record_detail_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailResponse:
        """
        @summary 群运营-数据监控-导出明细
        
        @param request: DigitalStoreExportCardRecordDetailRequest
        @param headers: DigitalStoreExportCardRecordDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreExportCardRecordDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.begin_time):
            body['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.ids):
            body['ids'] = request.ids
        if not UtilClient.is_unset(request.scene_card_name):
            body['sceneCardName'] = request.scene_card_name
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
            action='DigitalStoreExportCardRecordDetail',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/cardRecordDetails/export',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_export_card_record_detail_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailResponse:
        """
        @summary 群运营-数据监控-导出明细
        
        @param request: DigitalStoreExportCardRecordDetailRequest
        @param headers: DigitalStoreExportCardRecordDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreExportCardRecordDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.begin_time):
            body['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.ids):
            body['ids'] = request.ids
        if not UtilClient.is_unset(request.scene_card_name):
            body['sceneCardName'] = request.scene_card_name
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
            action='DigitalStoreExportCardRecordDetail',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/cardRecordDetails/export',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_export_card_record_detail(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailResponse:
        """
        @summary 群运营-数据监控-导出明细
        
        @param request: DigitalStoreExportCardRecordDetailRequest
        @return: DigitalStoreExportCardRecordDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailHeaders()
        return self.digital_store_export_card_record_detail_with_options(request, headers, runtime)

    async def digital_store_export_card_record_detail_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailResponse:
        """
        @summary 群运营-数据监控-导出明细
        
        @param request: DigitalStoreExportCardRecordDetailRequest
        @return: DigitalStoreExportCardRecordDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreExportCardRecordDetailHeaders()
        return await self.digital_store_export_card_record_detail_with_options_async(request, headers, runtime)

    def digital_store_group_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreGroupInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreGroupInfoResponse:
        """
        @summary 查询门店通中的门店分组详情
        
        @param request: DigitalStoreGroupInfoRequest
        @param headers: DigitalStoreGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreGroupInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.group_id):
            query['groupId'] = request.group_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreGroupInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/groupInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreGroupInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_group_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreGroupInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreGroupInfoResponse:
        """
        @summary 查询门店通中的门店分组详情
        
        @param request: DigitalStoreGroupInfoRequest
        @param headers: DigitalStoreGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreGroupInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.group_id):
            query['groupId'] = request.group_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreGroupInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/groupInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreGroupInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_group_info(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreGroupInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreGroupInfoResponse:
        """
        @summary 查询门店通中的门店分组详情
        
        @param request: DigitalStoreGroupInfoRequest
        @return: DigitalStoreGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreGroupInfoHeaders()
        return self.digital_store_group_info_with_options(request, headers, runtime)

    async def digital_store_group_info_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreGroupInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreGroupInfoResponse:
        """
        @summary 查询门店通中的门店分组详情
        
        @param request: DigitalStoreGroupInfoRequest
        @return: DigitalStoreGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreGroupInfoHeaders()
        return await self.digital_store_group_info_with_options_async(request, headers, runtime)

    def digital_store_groups_with_options(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreGroupsResponse:
        """
        @summary 查询门店通中的分组列表
        
        @param headers: DigitalStoreGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreGroupsResponse
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
            action='DigitalStoreGroups',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreGroupsResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_groups_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreGroupsResponse:
        """
        @summary 查询门店通中的分组列表
        
        @param headers: DigitalStoreGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreGroupsResponse
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
            action='DigitalStoreGroups',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreGroupsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_groups(self) -> dingtalkindustry__1__0_models.DigitalStoreGroupsResponse:
        """
        @summary 查询门店通中的分组列表
        
        @return: DigitalStoreGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreGroupsHeaders()
        return self.digital_store_groups_with_options(headers, runtime)

    async def digital_store_groups_async(self) -> dingtalkindustry__1__0_models.DigitalStoreGroupsResponse:
        """
        @summary 查询门店通中的分组列表
        
        @return: DigitalStoreGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreGroupsHeaders()
        return await self.digital_store_groups_with_options_async(headers, runtime)

    def digital_store_node_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreNodeInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreNodeInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreNodeInfoResponse:
        """
        @summary 查询门店通讯录某个节点信息
        
        @param request: DigitalStoreNodeInfoRequest
        @param headers: DigitalStoreNodeInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreNodeInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.node_id):
            query['nodeId'] = request.node_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreNodeInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/nodeInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreNodeInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_node_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreNodeInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreNodeInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreNodeInfoResponse:
        """
        @summary 查询门店通讯录某个节点信息
        
        @param request: DigitalStoreNodeInfoRequest
        @param headers: DigitalStoreNodeInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreNodeInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.node_id):
            query['nodeId'] = request.node_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreNodeInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/nodeInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreNodeInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_node_info(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreNodeInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreNodeInfoResponse:
        """
        @summary 查询门店通讯录某个节点信息
        
        @param request: DigitalStoreNodeInfoRequest
        @return: DigitalStoreNodeInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreNodeInfoHeaders()
        return self.digital_store_node_info_with_options(request, headers, runtime)

    async def digital_store_node_info_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreNodeInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreNodeInfoResponse:
        """
        @summary 查询门店通讯录某个节点信息
        
        @param request: DigitalStoreNodeInfoRequest
        @return: DigitalStoreNodeInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreNodeInfoHeaders()
        return await self.digital_store_node_info_with_options_async(request, headers, runtime)

    def digital_store_rights_info_with_options(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreRightsInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse:
        """
        @summary 门店通权益信息查询
        
        @param headers: DigitalStoreRightsInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreRightsInfoResponse
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
            action='DigitalStoreRightsInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/rightsInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_rights_info_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreRightsInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse:
        """
        @summary 门店通权益信息查询
        
        @param headers: DigitalStoreRightsInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreRightsInfoResponse
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
            action='DigitalStoreRightsInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/rightsInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_rights_info(self) -> dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse:
        """
        @summary 门店通权益信息查询
        
        @return: DigitalStoreRightsInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRightsInfoHeaders()
        return self.digital_store_rights_info_with_options(headers, runtime)

    async def digital_store_rights_info_async(self) -> dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse:
        """
        @summary 门店通权益信息查询
        
        @return: DigitalStoreRightsInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRightsInfoHeaders()
        return await self.digital_store_rights_info_with_options_async(headers, runtime)

    def digital_store_roles_with_options(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreRolesResponse:
        """
        @summary 查询门店通中的角色列表
        
        @param headers: DigitalStoreRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreRolesResponse
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
            action='DigitalStoreRoles',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreRolesResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_roles_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreRolesResponse:
        """
        @summary 查询门店通中的角色列表
        
        @param headers: DigitalStoreRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreRolesResponse
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
            action='DigitalStoreRoles',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreRolesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_roles(self) -> dingtalkindustry__1__0_models.DigitalStoreRolesResponse:
        """
        @summary 查询门店通中的角色列表
        
        @return: DigitalStoreRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRolesHeaders()
        return self.digital_store_roles_with_options(headers, runtime)

    async def digital_store_roles_async(self) -> dingtalkindustry__1__0_models.DigitalStoreRolesResponse:
        """
        @summary 查询门店通中的角色列表
        
        @return: DigitalStoreRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRolesHeaders()
        return await self.digital_store_roles_with_options_async(headers, runtime)

    def digital_store_scene_scope_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSceneScopeRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreSceneScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSceneScopeResponse:
        """
        @summary 获取门店通场景群的业务范围
        
        @param request: DigitalStoreSceneScopeRequest
        @param headers: DigitalStoreSceneScopeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreSceneScopeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.scene_code):
            query['sceneCode'] = request.scene_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreSceneScope',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/sceneScopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreSceneScopeResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_scene_scope_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSceneScopeRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreSceneScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSceneScopeResponse:
        """
        @summary 获取门店通场景群的业务范围
        
        @param request: DigitalStoreSceneScopeRequest
        @param headers: DigitalStoreSceneScopeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreSceneScopeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.scene_code):
            query['sceneCode'] = request.scene_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreSceneScope',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/sceneScopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreSceneScopeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_scene_scope(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSceneScopeRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSceneScopeResponse:
        """
        @summary 获取门店通场景群的业务范围
        
        @param request: DigitalStoreSceneScopeRequest
        @return: DigitalStoreSceneScopeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreSceneScopeHeaders()
        return self.digital_store_scene_scope_with_options(request, headers, runtime)

    async def digital_store_scene_scope_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSceneScopeRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSceneScopeResponse:
        """
        @summary 获取门店通场景群的业务范围
        
        @param request: DigitalStoreSceneScopeRequest
        @return: DigitalStoreSceneScopeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreSceneScopeHeaders()
        return await self.digital_store_scene_scope_with_options_async(request, headers, runtime)

    def digital_store_store_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreStoreInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreStoreInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreStoreInfoResponse:
        """
        @summary 查询门店通中的门店详情
        
        @param request: DigitalStoreStoreInfoRequest
        @param headers: DigitalStoreStoreInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreStoreInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.store_id):
            query['storeId'] = request.store_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreStoreInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/storeInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreStoreInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_store_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreStoreInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreStoreInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreStoreInfoResponse:
        """
        @summary 查询门店通中的门店详情
        
        @param request: DigitalStoreStoreInfoRequest
        @param headers: DigitalStoreStoreInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreStoreInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.store_id):
            query['storeId'] = request.store_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreStoreInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/storeInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreStoreInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_store_info(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreStoreInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreStoreInfoResponse:
        """
        @summary 查询门店通中的门店详情
        
        @param request: DigitalStoreStoreInfoRequest
        @return: DigitalStoreStoreInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreStoreInfoHeaders()
        return self.digital_store_store_info_with_options(request, headers, runtime)

    async def digital_store_store_info_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreStoreInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreStoreInfoResponse:
        """
        @summary 查询门店通中的门店详情
        
        @param request: DigitalStoreStoreInfoRequest
        @return: DigitalStoreStoreInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreStoreInfoHeaders()
        return await self.digital_store_store_info_with_options_async(request, headers, runtime)

    def digital_store_sub_nodes_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSubNodesRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreSubNodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSubNodesResponse:
        """
        @summary 查询门店通讯录某个节点下的子节点
        
        @param request: DigitalStoreSubNodesRequest
        @param headers: DigitalStoreSubNodesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreSubNodesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.node_id):
            query['nodeId'] = request.node_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreSubNodes',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/subsidiaryNodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreSubNodesResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_sub_nodes_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSubNodesRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreSubNodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSubNodesResponse:
        """
        @summary 查询门店通讯录某个节点下的子节点
        
        @param request: DigitalStoreSubNodesRequest
        @param headers: DigitalStoreSubNodesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreSubNodesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.node_id):
            query['nodeId'] = request.node_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreSubNodes',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/subsidiaryNodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreSubNodesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_sub_nodes(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSubNodesRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSubNodesResponse:
        """
        @summary 查询门店通讯录某个节点下的子节点
        
        @param request: DigitalStoreSubNodesRequest
        @return: DigitalStoreSubNodesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreSubNodesHeaders()
        return self.digital_store_sub_nodes_with_options(request, headers, runtime)

    async def digital_store_sub_nodes_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSubNodesRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSubNodesResponse:
        """
        @summary 查询门店通讯录某个节点下的子节点
        
        @param request: DigitalStoreSubNodesRequest
        @return: DigitalStoreSubNodesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreSubNodesHeaders()
        return await self.digital_store_sub_nodes_with_options_async(request, headers, runtime)

    def digital_store_update_auth_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoResponse:
        """
        @summary 修改人员管辖范围以及所属角色
        
        @param request: DigitalStoreUpdateAuthInfoRequest
        @param headers: DigitalStoreUpdateAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreUpdateAuthInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.update_user_list):
            body['updateUserList'] = request.update_user_list
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
            action='DigitalStoreUpdateAuthInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/authInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_update_auth_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoResponse:
        """
        @summary 修改人员管辖范围以及所属角色
        
        @param request: DigitalStoreUpdateAuthInfoRequest
        @param headers: DigitalStoreUpdateAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreUpdateAuthInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.update_user_list):
            body['updateUserList'] = request.update_user_list
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
            action='DigitalStoreUpdateAuthInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/authInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_update_auth_info(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoResponse:
        """
        @summary 修改人员管辖范围以及所属角色
        
        @param request: DigitalStoreUpdateAuthInfoRequest
        @return: DigitalStoreUpdateAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoHeaders()
        return self.digital_store_update_auth_info_with_options(request, headers, runtime)

    async def digital_store_update_auth_info_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoResponse:
        """
        @summary 修改人员管辖范围以及所属角色
        
        @param request: DigitalStoreUpdateAuthInfoRequest
        @return: DigitalStoreUpdateAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoHeaders()
        return await self.digital_store_update_auth_info_with_options_async(request, headers, runtime)

    def digital_store_user_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUserInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUserInfoResponse:
        """
        @summary 查询门店通讯录人员信息
        
        @param request: DigitalStoreUserInfoRequest
        @param headers: DigitalStoreUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreUserInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
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
            action='DigitalStoreUserInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/userInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreUserInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_user_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUserInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUserInfoResponse:
        """
        @summary 查询门店通讯录人员信息
        
        @param request: DigitalStoreUserInfoRequest
        @param headers: DigitalStoreUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreUserInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
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
            action='DigitalStoreUserInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/userInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreUserInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_user_info(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUserInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUserInfoResponse:
        """
        @summary 查询门店通讯录人员信息
        
        @param request: DigitalStoreUserInfoRequest
        @return: DigitalStoreUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUserInfoHeaders()
        return self.digital_store_user_info_with_options(request, headers, runtime)

    async def digital_store_user_info_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUserInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUserInfoResponse:
        """
        @summary 查询门店通讯录人员信息
        
        @param request: DigitalStoreUserInfoRequest
        @return: DigitalStoreUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUserInfoHeaders()
        return await self.digital_store_user_info_with_options_async(request, headers, runtime)

    def digital_store_users_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUsersRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUsersResponse:
        """
        @summary 查询门店通讯录某个节点下的所有人员
        
        @param request: DigitalStoreUsersRequest
        @param headers: DigitalStoreUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.node_id):
            query['nodeId'] = request.node_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreUsers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/nodes/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_store_users_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUsersRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUsersResponse:
        """
        @summary 查询门店通讯录某个节点下的所有人员
        
        @param request: DigitalStoreUsersRequest
        @param headers: DigitalStoreUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStoreUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        if not UtilClient.is_unset(request.node_id):
            query['nodeId'] = request.node_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DigitalStoreUsers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/nodes/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_store_users(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUsersRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUsersResponse:
        """
        @summary 查询门店通讯录某个节点下的所有人员
        
        @param request: DigitalStoreUsersRequest
        @return: DigitalStoreUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUsersHeaders()
        return self.digital_store_users_with_options(request, headers, runtime)

    async def digital_store_users_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUsersRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUsersResponse:
        """
        @summary 查询门店通讯录某个节点下的所有人员
        
        @param request: DigitalStoreUsersRequest
        @return: DigitalStoreUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUsersHeaders()
        return await self.digital_store_users_with_options_async(request, headers, runtime)

    def digital_storelist_export_task_record_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordRequest,
        headers: dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordResponse:
        """
        @summary 群运营-数据监控-查询导出任务的记录列表
        
        @param request: DigitalStorelistExportTaskRecordRequest
        @param headers: DigitalStorelistExportTaskRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStorelistExportTaskRecordResponse
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
            action='DigitalStorelistExportTaskRecord',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/exportTaskRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def digital_storelist_export_task_record_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordRequest,
        headers: dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordResponse:
        """
        @summary 群运营-数据监控-查询导出任务的记录列表
        
        @param request: DigitalStorelistExportTaskRecordRequest
        @param headers: DigitalStorelistExportTaskRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DigitalStorelistExportTaskRecordResponse
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
            action='DigitalStorelistExportTaskRecord',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/digitalStores/exportTaskRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def digital_storelist_export_task_record(
        self,
        request: dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordResponse:
        """
        @summary 群运营-数据监控-查询导出任务的记录列表
        
        @param request: DigitalStorelistExportTaskRecordRequest
        @return: DigitalStorelistExportTaskRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordHeaders()
        return self.digital_storelist_export_task_record_with_options(request, headers, runtime)

    async def digital_storelist_export_task_record_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordResponse:
        """
        @summary 群运营-数据监控-查询导出任务的记录列表
        
        @param request: DigitalStorelistExportTaskRecordRequest
        @return: DigitalStorelistExportTaskRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStorelistExportTaskRecordHeaders()
        return await self.digital_storelist_export_task_record_with_options_async(request, headers, runtime)

    def external_query_external_app_orgs_with_options(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsRequest,
        headers: dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsResponse:
        """
        @summary 查询启用了当前应用的外部协作组织
        
        @param request: ExternalQueryExternalAppOrgsRequest
        @param headers: ExternalQueryExternalAppOrgsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExternalQueryExternalAppOrgsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.external_type):
            query['externalType'] = request.external_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ExternalQueryExternalAppOrgs',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/externals/apps/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsResponse(),
            self.execute(params, req, runtime)
        )

    async def external_query_external_app_orgs_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsRequest,
        headers: dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsResponse:
        """
        @summary 查询启用了当前应用的外部协作组织
        
        @param request: ExternalQueryExternalAppOrgsRequest
        @param headers: ExternalQueryExternalAppOrgsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExternalQueryExternalAppOrgsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.external_type):
            query['externalType'] = request.external_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ExternalQueryExternalAppOrgs',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/externals/apps/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def external_query_external_app_orgs(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsRequest,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsResponse:
        """
        @summary 查询启用了当前应用的外部协作组织
        
        @param request: ExternalQueryExternalAppOrgsRequest
        @return: ExternalQueryExternalAppOrgsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsHeaders()
        return self.external_query_external_app_orgs_with_options(request, headers, runtime)

    async def external_query_external_app_orgs_async(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsRequest,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsResponse:
        """
        @summary 查询启用了当前应用的外部协作组织
        
        @param request: ExternalQueryExternalAppOrgsRequest
        @return: ExternalQueryExternalAppOrgsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsHeaders()
        return await self.external_query_external_app_orgs_with_options_async(request, headers, runtime)

    def external_query_external_belong_main_org_with_options(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgRequest,
        headers: dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgResponse:
        """
        @summary 查询归属的主组织
        
        @param request: ExternalQueryExternalBelongMainOrgRequest
        @param headers: ExternalQueryExternalBelongMainOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExternalQueryExternalBelongMainOrgResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.external_type):
            query['externalType'] = request.external_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ExternalQueryExternalBelongMainOrg',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/externals/attributions/masterOrganizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def external_query_external_belong_main_org_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgRequest,
        headers: dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgResponse:
        """
        @summary 查询归属的主组织
        
        @param request: ExternalQueryExternalBelongMainOrgRequest
        @param headers: ExternalQueryExternalBelongMainOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExternalQueryExternalBelongMainOrgResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.external_type):
            query['externalType'] = request.external_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ExternalQueryExternalBelongMainOrg',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/externals/attributions/masterOrganizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def external_query_external_belong_main_org(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgRequest,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgResponse:
        """
        @summary 查询归属的主组织
        
        @param request: ExternalQueryExternalBelongMainOrgRequest
        @return: ExternalQueryExternalBelongMainOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgHeaders()
        return self.external_query_external_belong_main_org_with_options(request, headers, runtime)

    async def external_query_external_belong_main_org_async(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgRequest,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgResponse:
        """
        @summary 查询归属的主组织
        
        @param request: ExternalQueryExternalBelongMainOrgRequest
        @return: ExternalQueryExternalBelongMainOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgHeaders()
        return await self.external_query_external_belong_main_org_with_options_async(request, headers, runtime)

    def external_query_external_orgs_with_options(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalOrgsRequest,
        headers: dingtalkindustry__1__0_models.ExternalQueryExternalOrgsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalOrgsResponse:
        """
        @summary 查询外部协作组织
        
        @param request: ExternalQueryExternalOrgsRequest
        @param headers: ExternalQueryExternalOrgsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExternalQueryExternalOrgsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.external_type):
            query['externalType'] = request.external_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ExternalQueryExternalOrgs',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/externals/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ExternalQueryExternalOrgsResponse(),
            self.execute(params, req, runtime)
        )

    async def external_query_external_orgs_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalOrgsRequest,
        headers: dingtalkindustry__1__0_models.ExternalQueryExternalOrgsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalOrgsResponse:
        """
        @summary 查询外部协作组织
        
        @param request: ExternalQueryExternalOrgsRequest
        @param headers: ExternalQueryExternalOrgsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExternalQueryExternalOrgsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.external_type):
            query['externalType'] = request.external_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ExternalQueryExternalOrgs',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/externals/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.ExternalQueryExternalOrgsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def external_query_external_orgs(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalOrgsRequest,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalOrgsResponse:
        """
        @summary 查询外部协作组织
        
        @param request: ExternalQueryExternalOrgsRequest
        @return: ExternalQueryExternalOrgsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalOrgsHeaders()
        return self.external_query_external_orgs_with_options(request, headers, runtime)

    async def external_query_external_orgs_async(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalOrgsRequest,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalOrgsResponse:
        """
        @summary 查询外部协作组织
        
        @param request: ExternalQueryExternalOrgsRequest
        @return: ExternalQueryExternalOrgsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalOrgsHeaders()
        return await self.external_query_external_orgs_with_options_async(request, headers, runtime)

    def hospital_data_check_with_options(
        self,
        request: dingtalkindustry__1__0_models.HospitalDataCheckRequest,
        headers: dingtalkindustry__1__0_models.HospitalDataCheckHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.HospitalDataCheckResponse:
        """
        @summary 医疗数据对账
        
        @param request: HospitalDataCheckRequest
        @param headers: HospitalDataCheckHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HospitalDataCheckResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.all_dept_count):
            body['allDeptCount'] = request.all_dept_count
        if not UtilClient.is_unset(request.all_dept_user_count):
            body['allDeptUserCount'] = request.all_dept_user_count
        if not UtilClient.is_unset(request.all_group_count):
            body['allGroupCount'] = request.all_group_count
        if not UtilClient.is_unset(request.all_group_user_count):
            body['allGroupUserCount'] = request.all_group_user_count
        if not UtilClient.is_unset(request.dept_count):
            body['deptCount'] = request.dept_count
        if not UtilClient.is_unset(request.dept_user_count):
            body['deptUserCount'] = request.dept_user_count
        if not UtilClient.is_unset(request.group_count):
            body['groupCount'] = request.group_count
        if not UtilClient.is_unset(request.group_user_count):
            body['groupUserCount'] = request.group_user_count
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
            action='HospitalDataCheck',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/datas/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.HospitalDataCheckResponse(),
            self.execute(params, req, runtime)
        )

    async def hospital_data_check_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.HospitalDataCheckRequest,
        headers: dingtalkindustry__1__0_models.HospitalDataCheckHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.HospitalDataCheckResponse:
        """
        @summary 医疗数据对账
        
        @param request: HospitalDataCheckRequest
        @param headers: HospitalDataCheckHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HospitalDataCheckResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.all_dept_count):
            body['allDeptCount'] = request.all_dept_count
        if not UtilClient.is_unset(request.all_dept_user_count):
            body['allDeptUserCount'] = request.all_dept_user_count
        if not UtilClient.is_unset(request.all_group_count):
            body['allGroupCount'] = request.all_group_count
        if not UtilClient.is_unset(request.all_group_user_count):
            body['allGroupUserCount'] = request.all_group_user_count
        if not UtilClient.is_unset(request.dept_count):
            body['deptCount'] = request.dept_count
        if not UtilClient.is_unset(request.dept_user_count):
            body['deptUserCount'] = request.dept_user_count
        if not UtilClient.is_unset(request.group_count):
            body['groupCount'] = request.group_count
        if not UtilClient.is_unset(request.group_user_count):
            body['groupUserCount'] = request.group_user_count
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
            action='HospitalDataCheck',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/datas/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.HospitalDataCheckResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hospital_data_check(
        self,
        request: dingtalkindustry__1__0_models.HospitalDataCheckRequest,
    ) -> dingtalkindustry__1__0_models.HospitalDataCheckResponse:
        """
        @summary 医疗数据对账
        
        @param request: HospitalDataCheckRequest
        @return: HospitalDataCheckResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.HospitalDataCheckHeaders()
        return self.hospital_data_check_with_options(request, headers, runtime)

    async def hospital_data_check_async(
        self,
        request: dingtalkindustry__1__0_models.HospitalDataCheckRequest,
    ) -> dingtalkindustry__1__0_models.HospitalDataCheckResponse:
        """
        @summary 医疗数据对账
        
        @param request: HospitalDataCheckRequest
        @return: HospitalDataCheckResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.HospitalDataCheckHeaders()
        return await self.hospital_data_check_with_options_async(request, headers, runtime)

    def industry_manufacture_common_event_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCommonEventRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureCommonEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCommonEventResponse:
        """
        @summary 行业化制造业事件中心
        
        @param request: IndustryManufactureCommonEventRequest
        @param headers: IndustryManufactureCommonEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureCommonEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.biz_data):
            body['bizData'] = request.biz_data
        if not UtilClient.is_unset(request.event_type):
            body['eventType'] = request.event_type
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
            action='IndustryManufactureCommonEvent',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturing/bases/commons/events',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureCommonEventResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_common_event_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCommonEventRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureCommonEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCommonEventResponse:
        """
        @summary 行业化制造业事件中心
        
        @param request: IndustryManufactureCommonEventRequest
        @param headers: IndustryManufactureCommonEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureCommonEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.biz_data):
            body['bizData'] = request.biz_data
        if not UtilClient.is_unset(request.event_type):
            body['eventType'] = request.event_type
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
            action='IndustryManufactureCommonEvent',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturing/bases/commons/events',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureCommonEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_common_event(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCommonEventRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCommonEventResponse:
        """
        @summary 行业化制造业事件中心
        
        @param request: IndustryManufactureCommonEventRequest
        @return: IndustryManufactureCommonEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureCommonEventHeaders()
        return self.industry_manufacture_common_event_with_options(request, headers, runtime)

    async def industry_manufacture_common_event_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCommonEventRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCommonEventResponse:
        """
        @summary 行业化制造业事件中心
        
        @param request: IndustryManufactureCommonEventRequest
        @return: IndustryManufactureCommonEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureCommonEventHeaders()
        return await self.industry_manufacture_common_event_with_options_async(request, headers, runtime)

    def industry_manufacture_cost_record_list_get_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetResponse:
        """
        @summary 物料成本开放服务
        
        @param request: IndustryManufactureCostRecordListGetRequest
        @param headers: IndustryManufactureCostRecordListGetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureCostRecordListGetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.app_ids):
            body['appIds'] = request.app_ids
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.isv_org_id):
            body['isvOrgId'] = request.isv_org_id
        if not UtilClient.is_unset(request.material_no):
            body['materialNo'] = request.material_no
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.org_id):
            body['orgId'] = request.org_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.production_task_no):
            body['productionTaskNo'] = request.production_task_no
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.token_grant_type):
            body['tokenGrantType'] = request.token_grant_type
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
            action='IndustryManufactureCostRecordListGet',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufactures/materialCostRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_cost_record_list_get_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetResponse:
        """
        @summary 物料成本开放服务
        
        @param request: IndustryManufactureCostRecordListGetRequest
        @param headers: IndustryManufactureCostRecordListGetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureCostRecordListGetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.app_ids):
            body['appIds'] = request.app_ids
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.isv_org_id):
            body['isvOrgId'] = request.isv_org_id
        if not UtilClient.is_unset(request.material_no):
            body['materialNo'] = request.material_no
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.order_no):
            body['orderNo'] = request.order_no
        if not UtilClient.is_unset(request.org_id):
            body['orgId'] = request.org_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.production_task_no):
            body['productionTaskNo'] = request.production_task_no
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.token_grant_type):
            body['tokenGrantType'] = request.token_grant_type
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
            action='IndustryManufactureCostRecordListGet',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufactures/materialCostRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_cost_record_list_get(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetResponse:
        """
        @summary 物料成本开放服务
        
        @param request: IndustryManufactureCostRecordListGetRequest
        @return: IndustryManufactureCostRecordListGetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetHeaders()
        return self.industry_manufacture_cost_record_list_get_with_options(request, headers, runtime)

    async def industry_manufacture_cost_record_list_get_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetResponse:
        """
        @summary 物料成本开放服务
        
        @param request: IndustryManufactureCostRecordListGetRequest
        @return: IndustryManufactureCostRecordListGetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetHeaders()
        return await self.industry_manufacture_cost_record_list_get_with_options_async(request, headers, runtime)

    def industry_manufacture_fee_list_get_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureFeeListGetRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureFeeListGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureFeeListGetResponse:
        """
        @summary 费用服务
        
        @param request: IndustryManufactureFeeListGetRequest
        @param headers: IndustryManufactureFeeListGetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureFeeListGetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.app_ids):
            body['appIds'] = request.app_ids
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.isv_org_id):
            body['isvOrgId'] = request.isv_org_id
        if not UtilClient.is_unset(request.material_no):
            body['materialNo'] = request.material_no
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.org_id):
            body['orgId'] = request.org_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.production_task_no):
            body['productionTaskNo'] = request.production_task_no
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.token_grant_type):
            body['tokenGrantType'] = request.token_grant_type
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
            action='IndustryManufactureFeeListGet',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufactures/fees/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureFeeListGetResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_fee_list_get_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureFeeListGetRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureFeeListGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureFeeListGetResponse:
        """
        @summary 费用服务
        
        @param request: IndustryManufactureFeeListGetRequest
        @param headers: IndustryManufactureFeeListGetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureFeeListGetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.app_ids):
            body['appIds'] = request.app_ids
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.isv_org_id):
            body['isvOrgId'] = request.isv_org_id
        if not UtilClient.is_unset(request.material_no):
            body['materialNo'] = request.material_no
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.org_id):
            body['orgId'] = request.org_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.production_task_no):
            body['productionTaskNo'] = request.production_task_no
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.token_grant_type):
            body['tokenGrantType'] = request.token_grant_type
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
            action='IndustryManufactureFeeListGet',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufactures/fees/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureFeeListGetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_fee_list_get(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureFeeListGetRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureFeeListGetResponse:
        """
        @summary 费用服务
        
        @param request: IndustryManufactureFeeListGetRequest
        @return: IndustryManufactureFeeListGetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureFeeListGetHeaders()
        return self.industry_manufacture_fee_list_get_with_options(request, headers, runtime)

    async def industry_manufacture_fee_list_get_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureFeeListGetRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureFeeListGetResponse:
        """
        @summary 费用服务
        
        @param request: IndustryManufactureFeeListGetRequest
        @return: IndustryManufactureFeeListGetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureFeeListGetHeaders()
        return await self.industry_manufacture_fee_list_get_with_options_async(request, headers, runtime)

    def industry_manufacture_labour_cost_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureLabourCostRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureLabourCostHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureLabourCostResponse:
        """
        @summary 行业化-制造业工价接口
        
        @param request: IndustryManufactureLabourCostRequest
        @param headers: IndustryManufactureLabourCostHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureLabourCostResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.app_ids):
            body['appIds'] = request.app_ids
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.isv_org_id):
            body['isvOrgId'] = request.isv_org_id
        if not UtilClient.is_unset(request.material_no):
            body['materialNo'] = request.material_no
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.org_id):
            body['orgId'] = request.org_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_no):
            body['processNo'] = request.process_no
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.token_grant_type):
            body['tokenGrantType'] = request.token_grant_type
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
            action='IndustryManufactureLabourCost',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufactures/labourCosts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureLabourCostResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_labour_cost_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureLabourCostRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureLabourCostHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureLabourCostResponse:
        """
        @summary 行业化-制造业工价接口
        
        @param request: IndustryManufactureLabourCostRequest
        @param headers: IndustryManufactureLabourCostHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureLabourCostResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.app_ids):
            body['appIds'] = request.app_ids
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.isv_org_id):
            body['isvOrgId'] = request.isv_org_id
        if not UtilClient.is_unset(request.material_no):
            body['materialNo'] = request.material_no
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.org_id):
            body['orgId'] = request.org_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.process_no):
            body['processNo'] = request.process_no
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.token_grant_type):
            body['tokenGrantType'] = request.token_grant_type
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
            action='IndustryManufactureLabourCost',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufactures/labourCosts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureLabourCostResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_labour_cost(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureLabourCostRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureLabourCostResponse:
        """
        @summary 行业化-制造业工价接口
        
        @param request: IndustryManufactureLabourCostRequest
        @return: IndustryManufactureLabourCostResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureLabourCostHeaders()
        return self.industry_manufacture_labour_cost_with_options(request, headers, runtime)

    async def industry_manufacture_labour_cost_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureLabourCostRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureLabourCostResponse:
        """
        @summary 行业化-制造业工价接口
        
        @param request: IndustryManufactureLabourCostRequest
        @return: IndustryManufactureLabourCostResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureLabourCostHeaders()
        return await self.industry_manufacture_labour_cost_with_options_async(request, headers, runtime)

    def industry_manufacture_material_list_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMaterialListRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMaterialListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMaterialListResponse:
        """
        @summary 查询行业物料列表
        
        @param request: IndustryManufactureMaterialListRequest
        @param headers: IndustryManufactureMaterialListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMaterialListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.app_ids):
            body['appIds'] = request.app_ids
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.current_page):
            body['currentPage'] = request.current_page
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.isv_org_id):
            body['isvOrgId'] = request.isv_org_id
        if not UtilClient.is_unset(request.material_no):
            body['materialNo'] = request.material_no
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.org_id):
            body['orgId'] = request.org_id
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.token_grant_type):
            body['tokenGrantType'] = request.token_grant_type
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
            action='IndustryManufactureMaterialList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufactures/materials/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMaterialListResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_material_list_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMaterialListRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMaterialListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMaterialListResponse:
        """
        @summary 查询行业物料列表
        
        @param request: IndustryManufactureMaterialListRequest
        @param headers: IndustryManufactureMaterialListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMaterialListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.app_ids):
            body['appIds'] = request.app_ids
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.current_page):
            body['currentPage'] = request.current_page
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.isv_org_id):
            body['isvOrgId'] = request.isv_org_id
        if not UtilClient.is_unset(request.material_no):
            body['materialNo'] = request.material_no
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.org_id):
            body['orgId'] = request.org_id
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.token_grant_type):
            body['tokenGrantType'] = request.token_grant_type
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
            action='IndustryManufactureMaterialList',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufactures/materials/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMaterialListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_material_list(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMaterialListRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMaterialListResponse:
        """
        @summary 查询行业物料列表
        
        @param request: IndustryManufactureMaterialListRequest
        @return: IndustryManufactureMaterialListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMaterialListHeaders()
        return self.industry_manufacture_material_list_with_options(request, headers, runtime)

    async def industry_manufacture_material_list_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMaterialListRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMaterialListResponse:
        """
        @summary 查询行业物料列表
        
        @param request: IndustryManufactureMaterialListRequest
        @return: IndustryManufactureMaterialListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMaterialListHeaders()
        return await self.industry_manufacture_material_list_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_dispatch_task_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskResponse:
        """
        @summary 派工任务管理
        
        @param request: IndustryManufactureMesDispatchTaskRequest
        @param headers: IndustryManufactureMesDispatchTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesDispatchTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.defects_amount):
            body['defectsAmount'] = request.defects_amount
        if not UtilClient.is_unset(request.dispatch_staff_name):
            body['dispatchStaffName'] = request.dispatch_staff_name
        if not UtilClient.is_unset(request.dispatch_staff_no):
            body['dispatchStaffNo'] = request.dispatch_staff_no
        if not UtilClient.is_unset(request.fine_amount):
            body['fineAmount'] = request.fine_amount
        if not UtilClient.is_unset(request.overdue):
            body['overdue'] = request.overdue
        if not UtilClient.is_unset(request.plan_quantity):
            body['planQuantity'] = request.plan_quantity
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.process_name):
            body['processName'] = request.process_name
        if not UtilClient.is_unset(request.process_uuid):
            body['processUuid'] = request.process_uuid
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.product_specification):
            body['productSpecification'] = request.product_specification
        if not UtilClient.is_unset(request.project_code):
            body['projectCode'] = request.project_code
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.project_status):
            body['projectStatus'] = request.project_status
        if not UtilClient.is_unset(request.task_operators):
            body['taskOperators'] = request.task_operators
        if not UtilClient.is_unset(request.task_plan_end_time):
            body['taskPlanEndTime'] = request.task_plan_end_time
        if not UtilClient.is_unset(request.task_plan_start_time):
            body['taskPlanStartTime'] = request.task_plan_start_time
        if not UtilClient.is_unset(request.task_status):
            body['taskStatus'] = request.task_status
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        if not UtilClient.is_unset(request.team_id):
            body['teamId'] = request.team_id
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesDispatchTask',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/dispatchTasks/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_mes_dispatch_task_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskResponse:
        """
        @summary 派工任务管理
        
        @param request: IndustryManufactureMesDispatchTaskRequest
        @param headers: IndustryManufactureMesDispatchTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesDispatchTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.defects_amount):
            body['defectsAmount'] = request.defects_amount
        if not UtilClient.is_unset(request.dispatch_staff_name):
            body['dispatchStaffName'] = request.dispatch_staff_name
        if not UtilClient.is_unset(request.dispatch_staff_no):
            body['dispatchStaffNo'] = request.dispatch_staff_no
        if not UtilClient.is_unset(request.fine_amount):
            body['fineAmount'] = request.fine_amount
        if not UtilClient.is_unset(request.overdue):
            body['overdue'] = request.overdue
        if not UtilClient.is_unset(request.plan_quantity):
            body['planQuantity'] = request.plan_quantity
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.process_name):
            body['processName'] = request.process_name
        if not UtilClient.is_unset(request.process_uuid):
            body['processUuid'] = request.process_uuid
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.product_specification):
            body['productSpecification'] = request.product_specification
        if not UtilClient.is_unset(request.project_code):
            body['projectCode'] = request.project_code
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.project_status):
            body['projectStatus'] = request.project_status
        if not UtilClient.is_unset(request.task_operators):
            body['taskOperators'] = request.task_operators
        if not UtilClient.is_unset(request.task_plan_end_time):
            body['taskPlanEndTime'] = request.task_plan_end_time
        if not UtilClient.is_unset(request.task_plan_start_time):
            body['taskPlanStartTime'] = request.task_plan_start_time
        if not UtilClient.is_unset(request.task_status):
            body['taskStatus'] = request.task_status
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        if not UtilClient.is_unset(request.team_id):
            body['teamId'] = request.team_id
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesDispatchTask',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/dispatchTasks/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_mes_dispatch_task(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskResponse:
        """
        @summary 派工任务管理
        
        @param request: IndustryManufactureMesDispatchTaskRequest
        @return: IndustryManufactureMesDispatchTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskHeaders()
        return self.industry_manufacture_mes_dispatch_task_with_options(request, headers, runtime)

    async def industry_manufacture_mes_dispatch_task_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskResponse:
        """
        @summary 派工任务管理
        
        @param request: IndustryManufactureMesDispatchTaskRequest
        @return: IndustryManufactureMesDispatchTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskHeaders()
        return await self.industry_manufacture_mes_dispatch_task_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_material_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesMaterialRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesMaterialHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesMaterialResponse:
        """
        @summary MES系统物料管理
        
        @param request: IndustryManufactureMesMaterialRequest
        @param headers: IndustryManufactureMesMaterialHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesMaterialResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.category):
            body['category'] = request.category
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.product_specification):
            body['productSpecification'] = request.product_specification
        if not UtilClient.is_unset(request.prop):
            body['prop'] = request.prop
        if not UtilClient.is_unset(request.unit):
            body['unit'] = request.unit
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesMaterial',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/materials/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesMaterialResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_mes_material_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesMaterialRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesMaterialHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesMaterialResponse:
        """
        @summary MES系统物料管理
        
        @param request: IndustryManufactureMesMaterialRequest
        @param headers: IndustryManufactureMesMaterialHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesMaterialResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.category):
            body['category'] = request.category
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.product_specification):
            body['productSpecification'] = request.product_specification
        if not UtilClient.is_unset(request.prop):
            body['prop'] = request.prop
        if not UtilClient.is_unset(request.unit):
            body['unit'] = request.unit
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesMaterial',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/materials/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesMaterialResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_mes_material(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesMaterialRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesMaterialResponse:
        """
        @summary MES系统物料管理
        
        @param request: IndustryManufactureMesMaterialRequest
        @return: IndustryManufactureMesMaterialResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesMaterialHeaders()
        return self.industry_manufacture_mes_material_with_options(request, headers, runtime)

    async def industry_manufacture_mes_material_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesMaterialRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesMaterialResponse:
        """
        @summary MES系统物料管理
        
        @param request: IndustryManufactureMesMaterialRequest
        @return: IndustryManufactureMesMaterialResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesMaterialHeaders()
        return await self.industry_manufacture_mes_material_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_out_plan_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanResponse:
        """
        @summary 生产委外工单管理
        
        @param request: IndustryManufactureMesOutPlanRequest
        @param headers: IndustryManufactureMesOutPlanHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesOutPlanResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.approval_status):
            body['approvalStatus'] = request.approval_status
        if not UtilClient.is_unset(request.approver):
            body['approver'] = request.approver
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.out_source_project_code):
            body['outSourceProjectCode'] = request.out_source_project_code
        if not UtilClient.is_unset(request.out_source_team_id):
            body['outSourceTeamId'] = request.out_source_team_id
        if not UtilClient.is_unset(request.price):
            body['price'] = request.price
        if not UtilClient.is_unset(request.process_identification_code):
            body['processIdentificationCode'] = request.process_identification_code
        if not UtilClient.is_unset(request.process_uuids):
            body['processUuids'] = request.process_uuids
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.product_specification):
            body['productSpecification'] = request.product_specification
        if not UtilClient.is_unset(request.project_code):
            body['projectCode'] = request.project_code
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.send_plan_quantity):
            body['sendPlanQuantity'] = request.send_plan_quantity
        if not UtilClient.is_unset(request.supplier_code):
            body['supplierCode'] = request.supplier_code
        if not UtilClient.is_unset(request.supplier_name):
            body['supplierName'] = request.supplier_name
        if not UtilClient.is_unset(request.total_wage):
            body['totalWage'] = request.total_wage
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesOutPlan',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/outPlans/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_mes_out_plan_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanResponse:
        """
        @summary 生产委外工单管理
        
        @param request: IndustryManufactureMesOutPlanRequest
        @param headers: IndustryManufactureMesOutPlanHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesOutPlanResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.approval_status):
            body['approvalStatus'] = request.approval_status
        if not UtilClient.is_unset(request.approver):
            body['approver'] = request.approver
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.out_source_project_code):
            body['outSourceProjectCode'] = request.out_source_project_code
        if not UtilClient.is_unset(request.out_source_team_id):
            body['outSourceTeamId'] = request.out_source_team_id
        if not UtilClient.is_unset(request.price):
            body['price'] = request.price
        if not UtilClient.is_unset(request.process_identification_code):
            body['processIdentificationCode'] = request.process_identification_code
        if not UtilClient.is_unset(request.process_uuids):
            body['processUuids'] = request.process_uuids
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.product_specification):
            body['productSpecification'] = request.product_specification
        if not UtilClient.is_unset(request.project_code):
            body['projectCode'] = request.project_code
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.send_plan_quantity):
            body['sendPlanQuantity'] = request.send_plan_quantity
        if not UtilClient.is_unset(request.supplier_code):
            body['supplierCode'] = request.supplier_code
        if not UtilClient.is_unset(request.supplier_name):
            body['supplierName'] = request.supplier_name
        if not UtilClient.is_unset(request.total_wage):
            body['totalWage'] = request.total_wage
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesOutPlan',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/outPlans/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_mes_out_plan(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanResponse:
        """
        @summary 生产委外工单管理
        
        @param request: IndustryManufactureMesOutPlanRequest
        @return: IndustryManufactureMesOutPlanResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanHeaders()
        return self.industry_manufacture_mes_out_plan_with_options(request, headers, runtime)

    async def industry_manufacture_mes_out_plan_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanResponse:
        """
        @summary 生产委外工单管理
        
        @param request: IndustryManufactureMesOutPlanRequest
        @return: IndustryManufactureMesOutPlanResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanHeaders()
        return await self.industry_manufacture_mes_out_plan_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_output_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutputRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesOutputHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutputResponse:
        """
        @summary 生产报工管理
        
        @param request: IndustryManufactureMesOutputRequest
        @param headers: IndustryManufactureMesOutputHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesOutputResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.approve_status):
            body['approveStatus'] = request.approve_status
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.defects_amount):
            body['defectsAmount'] = request.defects_amount
        if not UtilClient.is_unset(request.defects_reason):
            body['defectsReason'] = request.defects_reason
        if not UtilClient.is_unset(request.fine_amount):
            body['fineAmount'] = request.fine_amount
        if not UtilClient.is_unset(request.has_quality_test):
            body['hasQualityTest'] = request.has_quality_test
        if not UtilClient.is_unset(request.overdue):
            body['overdue'] = request.overdue
        if not UtilClient.is_unset(request.plan_quantity):
            body['planQuantity'] = request.plan_quantity
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.process_name):
            body['processName'] = request.process_name
        if not UtilClient.is_unset(request.process_uuid):
            body['processUuid'] = request.process_uuid
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.product_specification):
            body['productSpecification'] = request.product_specification
        if not UtilClient.is_unset(request.project_code):
            body['projectCode'] = request.project_code
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.project_status):
            body['projectStatus'] = request.project_status
        if not UtilClient.is_unset(request.quality_test_status):
            body['qualityTestStatus'] = request.quality_test_status
        if not UtilClient.is_unset(request.task_plan_end_time):
            body['taskPlanEndTime'] = request.task_plan_end_time
        if not UtilClient.is_unset(request.task_plan_start_time):
            body['taskPlanStartTime'] = request.task_plan_start_time
        if not UtilClient.is_unset(request.task_status):
            body['taskStatus'] = request.task_status
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        if not UtilClient.is_unset(request.task_uuid):
            body['taskUuid'] = request.task_uuid
        if not UtilClient.is_unset(request.team_id):
            body['teamId'] = request.team_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_name):
            body['userName'] = request.user_name
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesOutput',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/outputs/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesOutputResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_mes_output_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutputRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesOutputHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutputResponse:
        """
        @summary 生产报工管理
        
        @param request: IndustryManufactureMesOutputRequest
        @param headers: IndustryManufactureMesOutputHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesOutputResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.approve_status):
            body['approveStatus'] = request.approve_status
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.defects_amount):
            body['defectsAmount'] = request.defects_amount
        if not UtilClient.is_unset(request.defects_reason):
            body['defectsReason'] = request.defects_reason
        if not UtilClient.is_unset(request.fine_amount):
            body['fineAmount'] = request.fine_amount
        if not UtilClient.is_unset(request.has_quality_test):
            body['hasQualityTest'] = request.has_quality_test
        if not UtilClient.is_unset(request.overdue):
            body['overdue'] = request.overdue
        if not UtilClient.is_unset(request.plan_quantity):
            body['planQuantity'] = request.plan_quantity
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.process_name):
            body['processName'] = request.process_name
        if not UtilClient.is_unset(request.process_uuid):
            body['processUuid'] = request.process_uuid
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.product_specification):
            body['productSpecification'] = request.product_specification
        if not UtilClient.is_unset(request.project_code):
            body['projectCode'] = request.project_code
        if not UtilClient.is_unset(request.project_id):
            body['projectId'] = request.project_id
        if not UtilClient.is_unset(request.project_status):
            body['projectStatus'] = request.project_status
        if not UtilClient.is_unset(request.quality_test_status):
            body['qualityTestStatus'] = request.quality_test_status
        if not UtilClient.is_unset(request.task_plan_end_time):
            body['taskPlanEndTime'] = request.task_plan_end_time
        if not UtilClient.is_unset(request.task_plan_start_time):
            body['taskPlanStartTime'] = request.task_plan_start_time
        if not UtilClient.is_unset(request.task_status):
            body['taskStatus'] = request.task_status
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        if not UtilClient.is_unset(request.task_uuid):
            body['taskUuid'] = request.task_uuid
        if not UtilClient.is_unset(request.team_id):
            body['teamId'] = request.team_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_name):
            body['userName'] = request.user_name
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesOutput',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/outputs/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesOutputResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_mes_output(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutputRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutputResponse:
        """
        @summary 生产报工管理
        
        @param request: IndustryManufactureMesOutputRequest
        @return: IndustryManufactureMesOutputResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesOutputHeaders()
        return self.industry_manufacture_mes_output_with_options(request, headers, runtime)

    async def industry_manufacture_mes_output_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutputRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutputResponse:
        """
        @summary 生产报工管理
        
        @param request: IndustryManufactureMesOutputRequest
        @return: IndustryManufactureMesOutputResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesOutputHeaders()
        return await self.industry_manufacture_mes_output_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_process_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProcessRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesProcessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProcessResponse:
        """
        @summary MES系统工序管理
        
        @param request: IndustryManufactureMesProcessRequest
        @param headers: IndustryManufactureMesProcessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesProcessResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.need_dispatch):
            body['needDispatch'] = request.need_dispatch
        if not UtilClient.is_unset(request.need_quality_test):
            body['needQualityTest'] = request.need_quality_test
        if not UtilClient.is_unset(request.no):
            body['no'] = request.no
        if not UtilClient.is_unset(request.price):
            body['price'] = request.price
        if not UtilClient.is_unset(request.prop):
            body['prop'] = request.prop
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.sop):
            body['sop'] = request.sop
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesProcess',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/processes/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesProcessResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_mes_process_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProcessRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesProcessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProcessResponse:
        """
        @summary MES系统工序管理
        
        @param request: IndustryManufactureMesProcessRequest
        @param headers: IndustryManufactureMesProcessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesProcessResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.need_dispatch):
            body['needDispatch'] = request.need_dispatch
        if not UtilClient.is_unset(request.need_quality_test):
            body['needQualityTest'] = request.need_quality_test
        if not UtilClient.is_unset(request.no):
            body['no'] = request.no
        if not UtilClient.is_unset(request.price):
            body['price'] = request.price
        if not UtilClient.is_unset(request.prop):
            body['prop'] = request.prop
        if not UtilClient.is_unset(request.remark):
            body['remark'] = request.remark
        if not UtilClient.is_unset(request.sop):
            body['sop'] = request.sop
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesProcess',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/processes/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesProcessResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_mes_process(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProcessRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProcessResponse:
        """
        @summary MES系统工序管理
        
        @param request: IndustryManufactureMesProcessRequest
        @return: IndustryManufactureMesProcessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesProcessHeaders()
        return self.industry_manufacture_mes_process_with_options(request, headers, runtime)

    async def industry_manufacture_mes_process_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProcessRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProcessResponse:
        """
        @summary MES系统工序管理
        
        @param request: IndustryManufactureMesProcessRequest
        @return: IndustryManufactureMesProcessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesProcessHeaders()
        return await self.industry_manufacture_mes_process_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_production_plan_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanResponse:
        """
        @summary 生产工单管理
        
        @param request: IndustryManufactureMesProductionPlanRequest
        @param headers: IndustryManufactureMesProductionPlanHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesProductionPlanResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.actual_end_time):
            body['actualEndTime'] = request.actual_end_time
        if not UtilClient.is_unset(request.actual_start_time):
            body['actualStartTime'] = request.actual_start_time
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.bom_uuid):
            body['bomUuid'] = request.bom_uuid
        if not UtilClient.is_unset(request.events):
            body['events'] = request.events
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.no):
            body['no'] = request.no
        if not UtilClient.is_unset(request.overdue):
            body['overdue'] = request.overdue
        if not UtilClient.is_unset(request.plan_end_time):
            body['planEndTime'] = request.plan_end_time
        if not UtilClient.is_unset(request.plan_quantity):
            body['planQuantity'] = request.plan_quantity
        if not UtilClient.is_unset(request.plan_start_time):
            body['planStartTime'] = request.plan_start_time
        if not UtilClient.is_unset(request.process_uuids):
            body['processUuids'] = request.process_uuids
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.product_specification):
            body['productSpecification'] = request.product_specification
        if not UtilClient.is_unset(request.qualified_quantity):
            body['qualifiedQuantity'] = request.qualified_quantity
        if not UtilClient.is_unset(request.sell_order_no):
            body['sellOrderNo'] = request.sell_order_no
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.team_list):
            body['teamList'] = request.team_list
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.unit):
            body['unit'] = request.unit
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesProductionPlan',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/productionPlans/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_mes_production_plan_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanResponse:
        """
        @summary 生产工单管理
        
        @param request: IndustryManufactureMesProductionPlanRequest
        @param headers: IndustryManufactureMesProductionPlanHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesProductionPlanResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.actual_end_time):
            body['actualEndTime'] = request.actual_end_time
        if not UtilClient.is_unset(request.actual_start_time):
            body['actualStartTime'] = request.actual_start_time
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.bom_uuid):
            body['bomUuid'] = request.bom_uuid
        if not UtilClient.is_unset(request.events):
            body['events'] = request.events
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.no):
            body['no'] = request.no
        if not UtilClient.is_unset(request.overdue):
            body['overdue'] = request.overdue
        if not UtilClient.is_unset(request.plan_end_time):
            body['planEndTime'] = request.plan_end_time
        if not UtilClient.is_unset(request.plan_quantity):
            body['planQuantity'] = request.plan_quantity
        if not UtilClient.is_unset(request.plan_start_time):
            body['planStartTime'] = request.plan_start_time
        if not UtilClient.is_unset(request.process_uuids):
            body['processUuids'] = request.process_uuids
        if not UtilClient.is_unset(request.product_code):
            body['productCode'] = request.product_code
        if not UtilClient.is_unset(request.product_name):
            body['productName'] = request.product_name
        if not UtilClient.is_unset(request.product_specification):
            body['productSpecification'] = request.product_specification
        if not UtilClient.is_unset(request.qualified_quantity):
            body['qualifiedQuantity'] = request.qualified_quantity
        if not UtilClient.is_unset(request.sell_order_no):
            body['sellOrderNo'] = request.sell_order_no
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.team_list):
            body['teamList'] = request.team_list
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.unit):
            body['unit'] = request.unit
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesProductionPlan',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/productionPlans/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_mes_production_plan(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanResponse:
        """
        @summary 生产工单管理
        
        @param request: IndustryManufactureMesProductionPlanRequest
        @return: IndustryManufactureMesProductionPlanResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanHeaders()
        return self.industry_manufacture_mes_production_plan_with_options(request, headers, runtime)

    async def industry_manufacture_mes_production_plan_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanResponse:
        """
        @summary 生产工单管理
        
        @param request: IndustryManufactureMesProductionPlanRequest
        @return: IndustryManufactureMesProductionPlanResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanHeaders()
        return await self.industry_manufacture_mes_production_plan_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_sub_cooperation_team_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamResponse:
        """
        @summary 生产委外合作班组管理
        
        @param request: IndustryManufactureMesSubCooperationTeamRequest
        @param headers: IndustryManufactureMesSubCooperationTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesSubCooperationTeamResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.events):
            body['events'] = request.events
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.group_plugins):
            body['groupPlugins'] = request.group_plugins
        if not UtilClient.is_unset(request.group_type):
            body['groupType'] = request.group_type
        if not UtilClient.is_unset(request.leaders):
            body['leaders'] = request.leaders
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.out_corp_id):
            body['outCorpId'] = request.out_corp_id
        if not UtilClient.is_unset(request.process_ids):
            body['processIds'] = request.process_ids
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesSubCooperationTeam',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/outTeams/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_mes_sub_cooperation_team_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamResponse:
        """
        @summary 生产委外合作班组管理
        
        @param request: IndustryManufactureMesSubCooperationTeamRequest
        @param headers: IndustryManufactureMesSubCooperationTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesSubCooperationTeamResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.events):
            body['events'] = request.events
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.group_plugins):
            body['groupPlugins'] = request.group_plugins
        if not UtilClient.is_unset(request.group_type):
            body['groupType'] = request.group_type
        if not UtilClient.is_unset(request.leaders):
            body['leaders'] = request.leaders
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.out_corp_id):
            body['outCorpId'] = request.out_corp_id
        if not UtilClient.is_unset(request.process_ids):
            body['processIds'] = request.process_ids
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
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
            action='IndustryManufactureMesSubCooperationTeam',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturings/outTeams/manage',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_mes_sub_cooperation_team(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamResponse:
        """
        @summary 生产委外合作班组管理
        
        @param request: IndustryManufactureMesSubCooperationTeamRequest
        @return: IndustryManufactureMesSubCooperationTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamHeaders()
        return self.industry_manufacture_mes_sub_cooperation_team_with_options(request, headers, runtime)

    async def industry_manufacture_mes_sub_cooperation_team_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamResponse:
        """
        @summary 生产委外合作班组管理
        
        @param request: IndustryManufactureMesSubCooperationTeamRequest
        @return: IndustryManufactureMesSubCooperationTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamHeaders()
        return await self.industry_manufacture_mes_sub_cooperation_team_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_team_mgmt_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtResponse:
        """
        @summary MES系统班组管理
        
        @param request: IndustryManufactureMesTeamMgmtRequest
        @param headers: IndustryManufactureMesTeamMgmtHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesTeamMgmtResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.events):
            body['events'] = request.events
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.group_config):
            body['groupConfig'] = request.group_config
        if not UtilClient.is_unset(request.group_plugins):
            body['groupPlugins'] = request.group_plugins
        if not UtilClient.is_unset(request.group_type):
            body['groupType'] = request.group_type
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.leaders):
            body['leaders'] = request.leaders
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.process_ids):
            body['processIds'] = request.process_ids
        if not UtilClient.is_unset(request.tag_key):
            body['tagKey'] = request.tag_key
        if not UtilClient.is_unset(request.tag_values):
            body['tagValues'] = request.tag_values
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
            action='IndustryManufactureMesTeamMgmt',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturing/base/data/team',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_manufacture_mes_team_mgmt_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtResponse:
        """
        @summary MES系统班组管理
        
        @param request: IndustryManufactureMesTeamMgmtRequest
        @param headers: IndustryManufactureMesTeamMgmtHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryManufactureMesTeamMgmtResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.app_key):
            body['appKey'] = request.app_key
        if not UtilClient.is_unset(request.base_data_name):
            body['baseDataName'] = request.base_data_name
        if not UtilClient.is_unset(request.events):
            body['events'] = request.events
        if not UtilClient.is_unset(request.extend_data):
            body['extendData'] = request.extend_data
        if not UtilClient.is_unset(request.group_config):
            body['groupConfig'] = request.group_config
        if not UtilClient.is_unset(request.group_plugins):
            body['groupPlugins'] = request.group_plugins
        if not UtilClient.is_unset(request.group_type):
            body['groupType'] = request.group_type
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.leaders):
            body['leaders'] = request.leaders
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.process_ids):
            body['processIds'] = request.process_ids
        if not UtilClient.is_unset(request.tag_key):
            body['tagKey'] = request.tag_key
        if not UtilClient.is_unset(request.tag_values):
            body['tagValues'] = request.tag_values
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
            action='IndustryManufactureMesTeamMgmt',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufacturing/base/data/team',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_manufacture_mes_team_mgmt(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtResponse:
        """
        @summary MES系统班组管理
        
        @param request: IndustryManufactureMesTeamMgmtRequest
        @return: IndustryManufactureMesTeamMgmtResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtHeaders()
        return self.industry_manufacture_mes_team_mgmt_with_options(request, headers, runtime)

    async def industry_manufacture_mes_team_mgmt_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtResponse:
        """
        @summary MES系统班组管理
        
        @param request: IndustryManufactureMesTeamMgmtRequest
        @return: IndustryManufactureMesTeamMgmtResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtHeaders()
        return await self.industry_manufacture_mes_team_mgmt_with_options_async(request, headers, runtime)

    def industry_mmanufacture_material_cost_get_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetRequest,
        headers: dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetResponse:
        """
        @summary 物料成本查询服务
        
        @param request: IndustryMmanufactureMaterialCostGetRequest
        @param headers: IndustryMmanufactureMaterialCostGetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryMmanufactureMaterialCostGetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.app_ids):
            body['appIds'] = request.app_ids
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.isv_org_id):
            body['isvOrgId'] = request.isv_org_id
        if not UtilClient.is_unset(request.material_no):
            body['materialNo'] = request.material_no
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.org_id):
            body['orgId'] = request.org_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.token_grant_type):
            body['tokenGrantType'] = request.token_grant_type
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
            action='IndustryMmanufactureMaterialCostGet',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufactures/base/materialCosts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetResponse(),
            self.execute(params, req, runtime)
        )

    async def industry_mmanufacture_material_cost_get_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetRequest,
        headers: dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetResponse:
        """
        @summary 物料成本查询服务
        
        @param request: IndustryMmanufactureMaterialCostGetRequest
        @param headers: IndustryMmanufactureMaterialCostGetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IndustryMmanufactureMaterialCostGetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.app_ids):
            body['appIds'] = request.app_ids
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        if not UtilClient.is_unset(request.isv_org_id):
            body['isvOrgId'] = request.isv_org_id
        if not UtilClient.is_unset(request.material_no):
            body['materialNo'] = request.material_no
        if not UtilClient.is_unset(request.microapp_agent_id):
            body['microappAgentId'] = request.microapp_agent_id
        if not UtilClient.is_unset(request.org_id):
            body['orgId'] = request.org_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.suite_key):
            body['suiteKey'] = request.suite_key
        if not UtilClient.is_unset(request.token_grant_type):
            body['tokenGrantType'] = request.token_grant_type
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
            action='IndustryMmanufactureMaterialCostGet',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/manufactures/base/materialCosts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def industry_mmanufacture_material_cost_get(
        self,
        request: dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetRequest,
    ) -> dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetResponse:
        """
        @summary 物料成本查询服务
        
        @param request: IndustryMmanufactureMaterialCostGetRequest
        @return: IndustryMmanufactureMaterialCostGetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetHeaders()
        return self.industry_mmanufacture_material_cost_get_with_options(request, headers, runtime)

    async def industry_mmanufacture_material_cost_get_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetRequest,
    ) -> dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetResponse:
        """
        @summary 物料成本查询服务
        
        @param request: IndustryMmanufactureMaterialCostGetRequest
        @return: IndustryMmanufactureMaterialCostGetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetHeaders()
        return await self.industry_mmanufacture_material_cost_get_with_options_async(request, headers, runtime)

    def push_ding_message_with_options(
        self,
        request: dingtalkindustry__1__0_models.PushDingMessageRequest,
        headers: dingtalkindustry__1__0_models.PushDingMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.PushDingMessageResponse:
        """
        @summary 提供text和card两种形式工作通知消息
        
        @param request: PushDingMessageRequest
        @param headers: PushDingMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PushDingMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.message_url):
            body['messageUrl'] = request.message_url
        if not UtilClient.is_unset(request.picture_url):
            body['pictureUrl'] = request.picture_url
        if not UtilClient.is_unset(request.single_title):
            body['singleTitle'] = request.single_title
        if not UtilClient.is_unset(request.single_url):
            body['singleUrl'] = request.single_url
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='PushDingMessage',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/works/notice',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.PushDingMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def push_ding_message_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.PushDingMessageRequest,
        headers: dingtalkindustry__1__0_models.PushDingMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.PushDingMessageResponse:
        """
        @summary 提供text和card两种形式工作通知消息
        
        @param request: PushDingMessageRequest
        @param headers: PushDingMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PushDingMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.message_url):
            body['messageUrl'] = request.message_url
        if not UtilClient.is_unset(request.picture_url):
            body['pictureUrl'] = request.picture_url
        if not UtilClient.is_unset(request.single_title):
            body['singleTitle'] = request.single_title
        if not UtilClient.is_unset(request.single_url):
            body['singleUrl'] = request.single_url
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
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
            action='PushDingMessage',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/works/notice',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.PushDingMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def push_ding_message(
        self,
        request: dingtalkindustry__1__0_models.PushDingMessageRequest,
    ) -> dingtalkindustry__1__0_models.PushDingMessageResponse:
        """
        @summary 提供text和card两种形式工作通知消息
        
        @param request: PushDingMessageRequest
        @return: PushDingMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.PushDingMessageHeaders()
        return self.push_ding_message_with_options(request, headers, runtime)

    async def push_ding_message_async(
        self,
        request: dingtalkindustry__1__0_models.PushDingMessageRequest,
    ) -> dingtalkindustry__1__0_models.PushDingMessageResponse:
        """
        @summary 提供text和card两种形式工作通知消息
        
        @param request: PushDingMessageRequest
        @return: PushDingMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.PushDingMessageHeaders()
        return await self.push_ding_message_with_options_async(request, headers, runtime)

    def query_all_department_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDepartmentRequest,
        headers: dingtalkindustry__1__0_models.QueryAllDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllDepartmentResponse:
        """
        @summary 获取当前组织下的所有科室
        
        @param request: QueryAllDepartmentRequest
        @param headers: QueryAllDepartmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllDepartmentResponse
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
            action='QueryAllDepartment',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/departments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllDepartmentResponse(),
            self.execute(params, req, runtime)
        )

    async def query_all_department_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDepartmentRequest,
        headers: dingtalkindustry__1__0_models.QueryAllDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllDepartmentResponse:
        """
        @summary 获取当前组织下的所有科室
        
        @param request: QueryAllDepartmentRequest
        @param headers: QueryAllDepartmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllDepartmentResponse
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
            action='QueryAllDepartment',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/departments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllDepartmentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_all_department(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDepartmentRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllDepartmentResponse:
        """
        @summary 获取当前组织下的所有科室
        
        @param request: QueryAllDepartmentRequest
        @return: QueryAllDepartmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllDepartmentHeaders()
        return self.query_all_department_with_options(request, headers, runtime)

    async def query_all_department_async(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDepartmentRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllDepartmentResponse:
        """
        @summary 获取当前组织下的所有科室
        
        @param request: QueryAllDepartmentRequest
        @return: QueryAllDepartmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllDepartmentHeaders()
        return await self.query_all_department_with_options_async(request, headers, runtime)

    def query_all_doctors_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDoctorsRequest,
        headers: dingtalkindustry__1__0_models.QueryAllDoctorsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllDoctorsResponse:
        """
        @summary 查询医院下的所有医生
        
        @param request: QueryAllDoctorsRequest
        @param headers: QueryAllDoctorsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllDoctorsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.month_mark):
            query['monthMark'] = request.month_mark
        if not UtilClient.is_unset(request.page_num):
            query['pageNum'] = request.page_num
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
            action='QueryAllDoctors',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/doctors',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllDoctorsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_all_doctors_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDoctorsRequest,
        headers: dingtalkindustry__1__0_models.QueryAllDoctorsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllDoctorsResponse:
        """
        @summary 查询医院下的所有医生
        
        @param request: QueryAllDoctorsRequest
        @param headers: QueryAllDoctorsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllDoctorsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.month_mark):
            query['monthMark'] = request.month_mark
        if not UtilClient.is_unset(request.page_num):
            query['pageNum'] = request.page_num
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
            action='QueryAllDoctors',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/doctors',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllDoctorsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_all_doctors(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDoctorsRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllDoctorsResponse:
        """
        @summary 查询医院下的所有医生
        
        @param request: QueryAllDoctorsRequest
        @return: QueryAllDoctorsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllDoctorsHeaders()
        return self.query_all_doctors_with_options(request, headers, runtime)

    async def query_all_doctors_async(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDoctorsRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllDoctorsResponse:
        """
        @summary 查询医院下的所有医生
        
        @param request: QueryAllDoctorsRequest
        @return: QueryAllDoctorsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllDoctorsHeaders()
        return await self.query_all_doctors_with_options_async(request, headers, runtime)

    def query_all_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryAllGroupRequest,
        headers: dingtalkindustry__1__0_models.QueryAllGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupResponse:
        """
        @summary 查询所有医疗组
        
        @param request: QueryAllGroupRequest
        @param headers: QueryAllGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllGroupResponse
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
            action='QueryAllGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def query_all_group_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.QueryAllGroupRequest,
        headers: dingtalkindustry__1__0_models.QueryAllGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupResponse:
        """
        @summary 查询所有医疗组
        
        @param request: QueryAllGroupRequest
        @param headers: QueryAllGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllGroupResponse
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
            action='QueryAllGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_all_group(
        self,
        request: dingtalkindustry__1__0_models.QueryAllGroupRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupResponse:
        """
        @summary 查询所有医疗组
        
        @param request: QueryAllGroupRequest
        @return: QueryAllGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllGroupHeaders()
        return self.query_all_group_with_options(request, headers, runtime)

    async def query_all_group_async(
        self,
        request: dingtalkindustry__1__0_models.QueryAllGroupRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupResponse:
        """
        @summary 查询所有医疗组
        
        @param request: QueryAllGroupRequest
        @return: QueryAllGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllGroupHeaders()
        return await self.query_all_group_with_options_async(request, headers, runtime)

    def query_all_groups_in_dept_with_options(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllGroupsInDeptRequest,
        headers: dingtalkindustry__1__0_models.QueryAllGroupsInDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupsInDeptResponse:
        """
        @summary 查询科室下的所有医疗组
        
        @param request: QueryAllGroupsInDeptRequest
        @param headers: QueryAllGroupsInDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllGroupsInDeptResponse
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
            action='QueryAllGroupsInDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/departments/{dept_id}/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllGroupsInDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def query_all_groups_in_dept_with_options_async(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllGroupsInDeptRequest,
        headers: dingtalkindustry__1__0_models.QueryAllGroupsInDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupsInDeptResponse:
        """
        @summary 查询科室下的所有医疗组
        
        @param request: QueryAllGroupsInDeptRequest
        @param headers: QueryAllGroupsInDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllGroupsInDeptResponse
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
            action='QueryAllGroupsInDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/departments/{dept_id}/groups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllGroupsInDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_all_groups_in_dept(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllGroupsInDeptRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupsInDeptResponse:
        """
        @summary 查询科室下的所有医疗组
        
        @param request: QueryAllGroupsInDeptRequest
        @return: QueryAllGroupsInDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllGroupsInDeptHeaders()
        return self.query_all_groups_in_dept_with_options(dept_id, request, headers, runtime)

    async def query_all_groups_in_dept_async(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllGroupsInDeptRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupsInDeptResponse:
        """
        @summary 查询科室下的所有医疗组
        
        @param request: QueryAllGroupsInDeptRequest
        @return: QueryAllGroupsInDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllGroupsInDeptHeaders()
        return await self.query_all_groups_in_dept_with_options_async(dept_id, request, headers, runtime)

    def query_all_member_by_dept_with_options(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByDeptRequest,
        headers: dingtalkindustry__1__0_models.QueryAllMemberByDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByDeptResponse:
        """
        @summary 查询科室下的所有人员
        
        @param request: QueryAllMemberByDeptRequest
        @param headers: QueryAllMemberByDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllMemberByDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.month_mark):
            query['monthMark'] = request.month_mark
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
            action='QueryAllMemberByDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/departments/{dept_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllMemberByDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def query_all_member_by_dept_with_options_async(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByDeptRequest,
        headers: dingtalkindustry__1__0_models.QueryAllMemberByDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByDeptResponse:
        """
        @summary 查询科室下的所有人员
        
        @param request: QueryAllMemberByDeptRequest
        @param headers: QueryAllMemberByDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllMemberByDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.month_mark):
            query['monthMark'] = request.month_mark
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
            action='QueryAllMemberByDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/departments/{dept_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllMemberByDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_all_member_by_dept(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByDeptRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByDeptResponse:
        """
        @summary 查询科室下的所有人员
        
        @param request: QueryAllMemberByDeptRequest
        @return: QueryAllMemberByDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllMemberByDeptHeaders()
        return self.query_all_member_by_dept_with_options(dept_id, request, headers, runtime)

    async def query_all_member_by_dept_async(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByDeptRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByDeptResponse:
        """
        @summary 查询科室下的所有人员
        
        @param request: QueryAllMemberByDeptRequest
        @return: QueryAllMemberByDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllMemberByDeptHeaders()
        return await self.query_all_member_by_dept_with_options_async(dept_id, request, headers, runtime)

    def query_all_member_by_group_with_options(
        self,
        group_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByGroupRequest,
        headers: dingtalkindustry__1__0_models.QueryAllMemberByGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByGroupResponse:
        """
        @summary 获取医疗组下面的所有成员
        
        @param request: QueryAllMemberByGroupRequest
        @param headers: QueryAllMemberByGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllMemberByGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.month_mark):
            query['monthMark'] = request.month_mark
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
            action='QueryAllMemberByGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/groups/{group_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllMemberByGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def query_all_member_by_group_with_options_async(
        self,
        group_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByGroupRequest,
        headers: dingtalkindustry__1__0_models.QueryAllMemberByGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByGroupResponse:
        """
        @summary 获取医疗组下面的所有成员
        
        @param request: QueryAllMemberByGroupRequest
        @param headers: QueryAllMemberByGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAllMemberByGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.month_mark):
            query['monthMark'] = request.month_mark
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
            action='QueryAllMemberByGroup',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/groups/{group_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllMemberByGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_all_member_by_group(
        self,
        group_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByGroupRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByGroupResponse:
        """
        @summary 获取医疗组下面的所有成员
        
        @param request: QueryAllMemberByGroupRequest
        @return: QueryAllMemberByGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllMemberByGroupHeaders()
        return self.query_all_member_by_group_with_options(group_id, request, headers, runtime)

    async def query_all_member_by_group_async(
        self,
        group_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByGroupRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByGroupResponse:
        """
        @summary 获取医疗组下面的所有成员
        
        @param request: QueryAllMemberByGroupRequest
        @return: QueryAllMemberByGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllMemberByGroupHeaders()
        return await self.query_all_member_by_group_with_options_async(group_id, request, headers, runtime)

    def query_biz_opt_log_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryBizOptLogRequest,
        headers: dingtalkindustry__1__0_models.QueryBizOptLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryBizOptLogResponse:
        """
        @summary 获取当前企业医疗通讯录的业务操作日志
        
        @param request: QueryBizOptLogRequest
        @param headers: QueryBizOptLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBizOptLogResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryBizOptLog',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/bizOptLogs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryBizOptLogResponse(),
            self.execute(params, req, runtime)
        )

    async def query_biz_opt_log_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.QueryBizOptLogRequest,
        headers: dingtalkindustry__1__0_models.QueryBizOptLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryBizOptLogResponse:
        """
        @summary 获取当前企业医疗通讯录的业务操作日志
        
        @param request: QueryBizOptLogRequest
        @param headers: QueryBizOptLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryBizOptLogResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryBizOptLog',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/bizOptLogs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryBizOptLogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_biz_opt_log(
        self,
        request: dingtalkindustry__1__0_models.QueryBizOptLogRequest,
    ) -> dingtalkindustry__1__0_models.QueryBizOptLogResponse:
        """
        @summary 获取当前企业医疗通讯录的业务操作日志
        
        @param request: QueryBizOptLogRequest
        @return: QueryBizOptLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryBizOptLogHeaders()
        return self.query_biz_opt_log_with_options(request, headers, runtime)

    async def query_biz_opt_log_async(
        self,
        request: dingtalkindustry__1__0_models.QueryBizOptLogRequest,
    ) -> dingtalkindustry__1__0_models.QueryBizOptLogResponse:
        """
        @summary 获取当前企业医疗通讯录的业务操作日志
        
        @param request: QueryBizOptLogRequest
        @return: QueryBizOptLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryBizOptLogHeaders()
        return await self.query_biz_opt_log_with_options_async(request, headers, runtime)

    def query_chat_aioxminfo_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryChatAIOXMInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryChatAIOXMInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryChatAIOXMInfoResponse:
        """
        @summary 获取专属AI平台信息
        
        @param request: QueryChatAIOXMInfoRequest
        @param headers: QueryChatAIOXMInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryChatAIOXMInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
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
            action='QueryChatAIOXMInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatai/oxm/infos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryChatAIOXMInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_chat_aioxminfo_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.QueryChatAIOXMInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryChatAIOXMInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryChatAIOXMInfoResponse:
        """
        @summary 获取专属AI平台信息
        
        @param request: QueryChatAIOXMInfoRequest
        @param headers: QueryChatAIOXMInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryChatAIOXMInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
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
            action='QueryChatAIOXMInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/chatai/oxm/infos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryChatAIOXMInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_chat_aioxminfo(
        self,
        request: dingtalkindustry__1__0_models.QueryChatAIOXMInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryChatAIOXMInfoResponse:
        """
        @summary 获取专属AI平台信息
        
        @param request: QueryChatAIOXMInfoRequest
        @return: QueryChatAIOXMInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryChatAIOXMInfoHeaders()
        return self.query_chat_aioxminfo_with_options(request, headers, runtime)

    async def query_chat_aioxminfo_async(
        self,
        request: dingtalkindustry__1__0_models.QueryChatAIOXMInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryChatAIOXMInfoResponse:
        """
        @summary 获取专属AI平台信息
        
        @param request: QueryChatAIOXMInfoRequest
        @return: QueryChatAIOXMInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryChatAIOXMInfoHeaders()
        return await self.query_chat_aioxminfo_with_options_async(request, headers, runtime)

    def query_department_extend_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryDepartmentExtendInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryDepartmentExtendInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentExtendInfoResponse:
        """
        @summary 查询科室和医疗组的扩展信息
        
        @param request: QueryDepartmentExtendInfoRequest
        @param headers: QueryDepartmentExtendInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDepartmentExtendInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_code):
            query['deptCode'] = request.dept_code
        if not UtilClient.is_unset(request.prop_code):
            query['propCode'] = request.prop_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryDepartmentExtendInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/departments/extensions/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryDepartmentExtendInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_department_extend_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.QueryDepartmentExtendInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryDepartmentExtendInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentExtendInfoResponse:
        """
        @summary 查询科室和医疗组的扩展信息
        
        @param request: QueryDepartmentExtendInfoRequest
        @param headers: QueryDepartmentExtendInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDepartmentExtendInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_code):
            query['deptCode'] = request.dept_code
        if not UtilClient.is_unset(request.prop_code):
            query['propCode'] = request.prop_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryDepartmentExtendInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/departments/extensions/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryDepartmentExtendInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_department_extend_info(
        self,
        request: dingtalkindustry__1__0_models.QueryDepartmentExtendInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentExtendInfoResponse:
        """
        @summary 查询科室和医疗组的扩展信息
        
        @param request: QueryDepartmentExtendInfoRequest
        @return: QueryDepartmentExtendInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryDepartmentExtendInfoHeaders()
        return self.query_department_extend_info_with_options(request, headers, runtime)

    async def query_department_extend_info_async(
        self,
        request: dingtalkindustry__1__0_models.QueryDepartmentExtendInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentExtendInfoResponse:
        """
        @summary 查询科室和医疗组的扩展信息
        
        @param request: QueryDepartmentExtendInfoRequest
        @return: QueryDepartmentExtendInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryDepartmentExtendInfoHeaders()
        return await self.query_department_extend_info_with_options_async(request, headers, runtime)

    def query_department_info_with_options(
        self,
        dept_id: str,
        headers: dingtalkindustry__1__0_models.QueryDepartmentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentInfoResponse:
        """
        @summary 查询部门详情
        
        @param headers: QueryDepartmentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDepartmentInfoResponse
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
            action='QueryDepartmentInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/departments/{dept_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryDepartmentInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_department_info_with_options_async(
        self,
        dept_id: str,
        headers: dingtalkindustry__1__0_models.QueryDepartmentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentInfoResponse:
        """
        @summary 查询部门详情
        
        @param headers: QueryDepartmentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDepartmentInfoResponse
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
            action='QueryDepartmentInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/departments/{dept_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryDepartmentInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_department_info(
        self,
        dept_id: str,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentInfoResponse:
        """
        @summary 查询部门详情
        
        @return: QueryDepartmentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryDepartmentInfoHeaders()
        return self.query_department_info_with_options(dept_id, headers, runtime)

    async def query_department_info_async(
        self,
        dept_id: str,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentInfoResponse:
        """
        @summary 查询部门详情
        
        @return: QueryDepartmentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryDepartmentInfoHeaders()
        return await self.query_department_info_with_options_async(dept_id, headers, runtime)

    def query_doctor_details_by_job_number_with_options(
        self,
        job_number: str,
        request: dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberRequest,
        headers: dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberResponse:
        """
        @summary 通过工号查询人员信息
        
        @param request: QueryDoctorDetailsByJobNumberRequest
        @param headers: QueryDoctorDetailsByJobNumberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDoctorDetailsByJobNumberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.month_mark):
            query['monthMark'] = request.month_mark
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryDoctorDetailsByJobNumber',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/doctors/{job_number}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberResponse(),
            self.execute(params, req, runtime)
        )

    async def query_doctor_details_by_job_number_with_options_async(
        self,
        job_number: str,
        request: dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberRequest,
        headers: dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberResponse:
        """
        @summary 通过工号查询人员信息
        
        @param request: QueryDoctorDetailsByJobNumberRequest
        @param headers: QueryDoctorDetailsByJobNumberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDoctorDetailsByJobNumberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.month_mark):
            query['monthMark'] = request.month_mark
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryDoctorDetailsByJobNumber',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/doctors/{job_number}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_doctor_details_by_job_number(
        self,
        job_number: str,
        request: dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberRequest,
    ) -> dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberResponse:
        """
        @summary 通过工号查询人员信息
        
        @param request: QueryDoctorDetailsByJobNumberRequest
        @return: QueryDoctorDetailsByJobNumberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberHeaders()
        return self.query_doctor_details_by_job_number_with_options(job_number, request, headers, runtime)

    async def query_doctor_details_by_job_number_async(
        self,
        job_number: str,
        request: dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberRequest,
    ) -> dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberResponse:
        """
        @summary 通过工号查询人员信息
        
        @param request: QueryDoctorDetailsByJobNumberRequest
        @return: QueryDoctorDetailsByJobNumberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberHeaders()
        return await self.query_doctor_details_by_job_number_with_options_async(job_number, request, headers, runtime)

    def query_group_info_with_options(
        self,
        group_id: str,
        headers: dingtalkindustry__1__0_models.QueryGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryGroupInfoResponse:
        """
        @summary 获取医疗组详情
        
        @param headers: QueryGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupInfoResponse
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
            action='QueryGroupInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/groups/{group_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryGroupInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_group_info_with_options_async(
        self,
        group_id: str,
        headers: dingtalkindustry__1__0_models.QueryGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryGroupInfoResponse:
        """
        @summary 获取医疗组详情
        
        @param headers: QueryGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupInfoResponse
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
            action='QueryGroupInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/groups/{group_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryGroupInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_group_info(
        self,
        group_id: str,
    ) -> dingtalkindustry__1__0_models.QueryGroupInfoResponse:
        """
        @summary 获取医疗组详情
        
        @return: QueryGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryGroupInfoHeaders()
        return self.query_group_info_with_options(group_id, headers, runtime)

    async def query_group_info_async(
        self,
        group_id: str,
    ) -> dingtalkindustry__1__0_models.QueryGroupInfoResponse:
        """
        @summary 获取医疗组详情
        
        @return: QueryGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryGroupInfoHeaders()
        return await self.query_group_info_with_options_async(group_id, headers, runtime)

    def query_hospital_district_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalDistrictInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryHospitalDistrictInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryHospitalDistrictInfoResponse:
        """
        @summary 查询医院的院区和病区信息
        
        @param request: QueryHospitalDistrictInfoRequest
        @param headers: QueryHospitalDistrictInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHospitalDistrictInfoResponse
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
            action='QueryHospitalDistrictInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/districts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalDistrictInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_hospital_district_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalDistrictInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryHospitalDistrictInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryHospitalDistrictInfoResponse:
        """
        @summary 查询医院的院区和病区信息
        
        @param request: QueryHospitalDistrictInfoRequest
        @param headers: QueryHospitalDistrictInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHospitalDistrictInfoResponse
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
            action='QueryHospitalDistrictInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/districts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalDistrictInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_hospital_district_info(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalDistrictInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryHospitalDistrictInfoResponse:
        """
        @summary 查询医院的院区和病区信息
        
        @param request: QueryHospitalDistrictInfoRequest
        @return: QueryHospitalDistrictInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalDistrictInfoHeaders()
        return self.query_hospital_district_info_with_options(request, headers, runtime)

    async def query_hospital_district_info_async(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalDistrictInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryHospitalDistrictInfoResponse:
        """
        @summary 查询医院的院区和病区信息
        
        @param request: QueryHospitalDistrictInfoRequest
        @return: QueryHospitalDistrictInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalDistrictInfoHeaders()
        return await self.query_hospital_district_info_with_options_async(request, headers, runtime)

    def query_hospital_role_user_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoResponse:
        """
        @summary 查询医院所有角色的人员
        
        @param request: QueryHospitalRoleUserInfoRequest
        @param headers: QueryHospitalRoleUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHospitalRoleUserInfoResponse
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
            action='QueryHospitalRoleUserInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/roles/userInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_hospital_role_user_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoResponse:
        """
        @summary 查询医院所有角色的人员
        
        @param request: QueryHospitalRoleUserInfoRequest
        @param headers: QueryHospitalRoleUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHospitalRoleUserInfoResponse
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
            action='QueryHospitalRoleUserInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/roles/userInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_hospital_role_user_info(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoResponse:
        """
        @summary 查询医院所有角色的人员
        
        @param request: QueryHospitalRoleUserInfoRequest
        @return: QueryHospitalRoleUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoHeaders()
        return self.query_hospital_role_user_info_with_options(request, headers, runtime)

    async def query_hospital_role_user_info_async(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoResponse:
        """
        @summary 查询医院所有角色的人员
        
        @param request: QueryHospitalRoleUserInfoRequest
        @return: QueryHospitalRoleUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoHeaders()
        return await self.query_hospital_role_user_info_with_options_async(request, headers, runtime)

    def query_hospital_roles_with_options(
        self,
        headers: dingtalkindustry__1__0_models.QueryHospitalRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryHospitalRolesResponse:
        """
        @summary 查询医院的角色
        
        @param headers: QueryHospitalRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHospitalRolesResponse
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
            action='QueryHospitalRoles',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalRolesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_hospital_roles_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.QueryHospitalRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryHospitalRolesResponse:
        """
        @summary 查询医院的角色
        
        @param headers: QueryHospitalRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryHospitalRolesResponse
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
            action='QueryHospitalRoles',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalRolesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_hospital_roles(self) -> dingtalkindustry__1__0_models.QueryHospitalRolesResponse:
        """
        @summary 查询医院的角色
        
        @return: QueryHospitalRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalRolesHeaders()
        return self.query_hospital_roles_with_options(headers, runtime)

    async def query_hospital_roles_async(self) -> dingtalkindustry__1__0_models.QueryHospitalRolesResponse:
        """
        @summary 查询医院的角色
        
        @return: QueryHospitalRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalRolesHeaders()
        return await self.query_hospital_roles_with_options_async(headers, runtime)

    def query_job_code_dictionary_with_options(
        self,
        headers: dingtalkindustry__1__0_models.QueryJobCodeDictionaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse:
        """
        @summary 查询职称字典表
        
        @param headers: QueryJobCodeDictionaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryJobCodeDictionaryResponse
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
            action='QueryJobCodeDictionary',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/jobCodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse(),
            self.execute(params, req, runtime)
        )

    async def query_job_code_dictionary_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.QueryJobCodeDictionaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse:
        """
        @summary 查询职称字典表
        
        @param headers: QueryJobCodeDictionaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryJobCodeDictionaryResponse
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
            action='QueryJobCodeDictionary',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/jobCodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_job_code_dictionary(self) -> dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse:
        """
        @summary 查询职称字典表
        
        @return: QueryJobCodeDictionaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobCodeDictionaryHeaders()
        return self.query_job_code_dictionary_with_options(headers, runtime)

    async def query_job_code_dictionary_async(self) -> dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse:
        """
        @summary 查询职称字典表
        
        @return: QueryJobCodeDictionaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobCodeDictionaryHeaders()
        return await self.query_job_code_dictionary_with_options_async(headers, runtime)

    def query_job_status_code_dictionary_with_options(
        self,
        headers: dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse:
        """
        @summary 查询工作状态字典表
        
        @param headers: QueryJobStatusCodeDictionaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryJobStatusCodeDictionaryResponse
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
            action='QueryJobStatusCodeDictionary',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/jobStatusCodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse(),
            self.execute(params, req, runtime)
        )

    async def query_job_status_code_dictionary_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse:
        """
        @summary 查询工作状态字典表
        
        @param headers: QueryJobStatusCodeDictionaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryJobStatusCodeDictionaryResponse
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
            action='QueryJobStatusCodeDictionary',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/jobStatusCodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_job_status_code_dictionary(self) -> dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse:
        """
        @summary 查询工作状态字典表
        
        @return: QueryJobStatusCodeDictionaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryHeaders()
        return self.query_job_status_code_dictionary_with_options(headers, runtime)

    async def query_job_status_code_dictionary_async(self) -> dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse:
        """
        @summary 查询工作状态字典表
        
        @return: QueryJobStatusCodeDictionaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryHeaders()
        return await self.query_job_status_code_dictionary_with_options_async(headers, runtime)

    def query_medical_events_with_options(
        self,
        headers: dingtalkindustry__1__0_models.QueryMedicalEventsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryMedicalEventsResponse:
        """
        @summary 查询医疗行业事件
        
        @param headers: QueryMedicalEventsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMedicalEventsResponse
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
            action='QueryMedicalEvents',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/events',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryMedicalEventsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_medical_events_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.QueryMedicalEventsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryMedicalEventsResponse:
        """
        @summary 查询医疗行业事件
        
        @param headers: QueryMedicalEventsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMedicalEventsResponse
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
            action='QueryMedicalEvents',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/events',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryMedicalEventsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_medical_events(self) -> dingtalkindustry__1__0_models.QueryMedicalEventsResponse:
        """
        @summary 查询医疗行业事件
        
        @return: QueryMedicalEventsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryMedicalEventsHeaders()
        return self.query_medical_events_with_options(headers, runtime)

    async def query_medical_events_async(self) -> dingtalkindustry__1__0_models.QueryMedicalEventsResponse:
        """
        @summary 查询医疗行业事件
        
        @return: QueryMedicalEventsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryMedicalEventsHeaders()
        return await self.query_medical_events_with_options_async(headers, runtime)

    def query_user_credentials_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryUserCredentialsRequest,
        headers: dingtalkindustry__1__0_models.QueryUserCredentialsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserCredentialsResponse:
        """
        @summary 查询用户的证书
        
        @param request: QueryUserCredentialsRequest
        @param headers: QueryUserCredentialsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserCredentialsResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='QueryUserCredentials',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/credentials/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserCredentialsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_credentials_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.QueryUserCredentialsRequest,
        headers: dingtalkindustry__1__0_models.QueryUserCredentialsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserCredentialsResponse:
        """
        @summary 查询用户的证书
        
        @param request: QueryUserCredentialsRequest
        @param headers: QueryUserCredentialsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserCredentialsResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='QueryUserCredentials',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/credentials/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserCredentialsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_credentials(
        self,
        request: dingtalkindustry__1__0_models.QueryUserCredentialsRequest,
    ) -> dingtalkindustry__1__0_models.QueryUserCredentialsResponse:
        """
        @summary 查询用户的证书
        
        @param request: QueryUserCredentialsRequest
        @return: QueryUserCredentialsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserCredentialsHeaders()
        return self.query_user_credentials_with_options(request, headers, runtime)

    async def query_user_credentials_async(
        self,
        request: dingtalkindustry__1__0_models.QueryUserCredentialsRequest,
    ) -> dingtalkindustry__1__0_models.QueryUserCredentialsResponse:
        """
        @summary 查询用户的证书
        
        @param request: QueryUserCredentialsRequest
        @return: QueryUserCredentialsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserCredentialsHeaders()
        return await self.query_user_credentials_with_options_async(request, headers, runtime)

    def query_user_ext_info_with_options(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserExtInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserExtInfoResponse:
        """
        @summary 查询人员的扩展信息
        
        @param headers: QueryUserExtInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserExtInfoResponse
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
            action='QueryUserExtInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/{user_id}/extInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserExtInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_ext_info_with_options_async(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserExtInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserExtInfoResponse:
        """
        @summary 查询人员的扩展信息
        
        @param headers: QueryUserExtInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserExtInfoResponse
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
            action='QueryUserExtInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/{user_id}/extInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserExtInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_ext_info(
        self,
        user_id: str,
    ) -> dingtalkindustry__1__0_models.QueryUserExtInfoResponse:
        """
        @summary 查询人员的扩展信息
        
        @return: QueryUserExtInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserExtInfoHeaders()
        return self.query_user_ext_info_with_options(user_id, headers, runtime)

    async def query_user_ext_info_async(
        self,
        user_id: str,
    ) -> dingtalkindustry__1__0_models.QueryUserExtInfoResponse:
        """
        @summary 查询人员的扩展信息
        
        @return: QueryUserExtInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserExtInfoHeaders()
        return await self.query_user_ext_info_with_options_async(user_id, headers, runtime)

    def query_user_extend_values_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryUserExtendValuesRequest,
        headers: dingtalkindustry__1__0_models.QueryUserExtendValuesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserExtendValuesResponse:
        """
        @summary 获取用户拓展字段
        
        @param request: QueryUserExtendValuesRequest
        @param headers: QueryUserExtendValuesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserExtendValuesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_extend_key):
            body['userExtendKey'] = request.user_extend_key
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
            action='QueryUserExtendValues',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/extends/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserExtendValuesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_extend_values_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.QueryUserExtendValuesRequest,
        headers: dingtalkindustry__1__0_models.QueryUserExtendValuesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserExtendValuesResponse:
        """
        @summary 获取用户拓展字段
        
        @param request: QueryUserExtendValuesRequest
        @param headers: QueryUserExtendValuesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserExtendValuesResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.user_extend_key):
            body['userExtendKey'] = request.user_extend_key
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
            action='QueryUserExtendValues',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/extends/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserExtendValuesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_extend_values(
        self,
        request: dingtalkindustry__1__0_models.QueryUserExtendValuesRequest,
    ) -> dingtalkindustry__1__0_models.QueryUserExtendValuesResponse:
        """
        @summary 获取用户拓展字段
        
        @param request: QueryUserExtendValuesRequest
        @return: QueryUserExtendValuesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserExtendValuesHeaders()
        return self.query_user_extend_values_with_options(request, headers, runtime)

    async def query_user_extend_values_async(
        self,
        request: dingtalkindustry__1__0_models.QueryUserExtendValuesRequest,
    ) -> dingtalkindustry__1__0_models.QueryUserExtendValuesResponse:
        """
        @summary 获取用户拓展字段
        
        @param request: QueryUserExtendValuesRequest
        @return: QueryUserExtendValuesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserExtendValuesHeaders()
        return await self.query_user_extend_values_with_options_async(request, headers, runtime)

    def query_user_info_with_options(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.QueryUserInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserInfoResponse:
        """
        @summary 查询人员详情
        
        @param request: QueryUserInfoRequest
        @param headers: QueryUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.month_mark):
            query['monthMark'] = request.month_mark
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryUserInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_info_with_options_async(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.QueryUserInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserInfoResponse:
        """
        @summary 查询人员详情
        
        @param request: QueryUserInfoRequest
        @param headers: QueryUserInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.month_mark):
            query['monthMark'] = request.month_mark
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryUserInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_info(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.QueryUserInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryUserInfoResponse:
        """
        @summary 查询人员详情
        
        @param request: QueryUserInfoRequest
        @return: QueryUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserInfoHeaders()
        return self.query_user_info_with_options(user_id, request, headers, runtime)

    async def query_user_info_async(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.QueryUserInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryUserInfoResponse:
        """
        @summary 查询人员详情
        
        @param request: QueryUserInfoRequest
        @return: QueryUserInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserInfoHeaders()
        return await self.query_user_info_with_options_async(user_id, request, headers, runtime)

    def query_user_prob_code_dictionary_with_options(
        self,
        headers: dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse:
        """
        @summary 查询人员属性字典表
        
        @param headers: QueryUserProbCodeDictionaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserProbCodeDictionaryResponse
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
            action='QueryUserProbCodeDictionary',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/userProbCodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_prob_code_dictionary_with_options_async(
        self,
        headers: dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse:
        """
        @summary 查询人员属性字典表
        
        @param headers: QueryUserProbCodeDictionaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserProbCodeDictionaryResponse
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
            action='QueryUserProbCodeDictionary',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/userProbCodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_prob_code_dictionary(self) -> dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse:
        """
        @summary 查询人员属性字典表
        
        @return: QueryUserProbCodeDictionaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryHeaders()
        return self.query_user_prob_code_dictionary_with_options(headers, runtime)

    async def query_user_prob_code_dictionary_async(self) -> dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse:
        """
        @summary 查询人员属性字典表
        
        @return: QueryUserProbCodeDictionaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryHeaders()
        return await self.query_user_prob_code_dictionary_with_options_async(headers, runtime)

    def query_user_roles_with_options(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserRolesResponse:
        """
        @summary 查询人员权限
        
        @param headers: QueryUserRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserRolesResponse
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
            action='QueryUserRoles',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/{user_id}/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserRolesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_roles_with_options_async(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserRolesResponse:
        """
        @summary 查询人员权限
        
        @param headers: QueryUserRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserRolesResponse
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
            action='QueryUserRoles',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/{user_id}/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserRolesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_roles(
        self,
        user_id: str,
    ) -> dingtalkindustry__1__0_models.QueryUserRolesResponse:
        """
        @summary 查询人员权限
        
        @return: QueryUserRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserRolesHeaders()
        return self.query_user_roles_with_options(user_id, headers, runtime)

    async def query_user_roles_async(
        self,
        user_id: str,
    ) -> dingtalkindustry__1__0_models.QueryUserRolesResponse:
        """
        @summary 查询人员权限
        
        @return: QueryUserRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserRolesHeaders()
        return await self.query_user_roles_with_options_async(user_id, headers, runtime)

    def save_user_extend_values_with_options(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.SaveUserExtendValuesRequest,
        headers: dingtalkindustry__1__0_models.SaveUserExtendValuesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SaveUserExtendValuesResponse:
        """
        @summary 保存用户拓展字段
        
        @param request: SaveUserExtendValuesRequest
        @param headers: SaveUserExtendValuesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveUserExtendValuesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_display_name):
            query['userDisplayName'] = request.user_display_name
        if not UtilClient.is_unset(request.user_extend_key):
            query['userExtendKey'] = request.user_extend_key
        if not UtilClient.is_unset(request.user_extend_value):
            query['userExtendValue'] = request.user_extend_value
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SaveUserExtendValues',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/{user_id}/extends',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SaveUserExtendValuesResponse(),
            self.execute(params, req, runtime)
        )

    async def save_user_extend_values_with_options_async(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.SaveUserExtendValuesRequest,
        headers: dingtalkindustry__1__0_models.SaveUserExtendValuesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SaveUserExtendValuesResponse:
        """
        @summary 保存用户拓展字段
        
        @param request: SaveUserExtendValuesRequest
        @param headers: SaveUserExtendValuesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveUserExtendValuesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_display_name):
            query['userDisplayName'] = request.user_display_name
        if not UtilClient.is_unset(request.user_extend_key):
            query['userExtendKey'] = request.user_extend_key
        if not UtilClient.is_unset(request.user_extend_value):
            query['userExtendValue'] = request.user_extend_value
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SaveUserExtendValues',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/{user_id}/extends',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SaveUserExtendValuesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_user_extend_values(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.SaveUserExtendValuesRequest,
    ) -> dingtalkindustry__1__0_models.SaveUserExtendValuesResponse:
        """
        @summary 保存用户拓展字段
        
        @param request: SaveUserExtendValuesRequest
        @return: SaveUserExtendValuesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SaveUserExtendValuesHeaders()
        return self.save_user_extend_values_with_options(user_id, request, headers, runtime)

    async def save_user_extend_values_async(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.SaveUserExtendValuesRequest,
    ) -> dingtalkindustry__1__0_models.SaveUserExtendValuesResponse:
        """
        @summary 保存用户拓展字段
        
        @param request: SaveUserExtendValuesRequest
        @return: SaveUserExtendValuesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SaveUserExtendValuesHeaders()
        return await self.save_user_extend_values_with_options_async(user_id, request, headers, runtime)

    def submit_task_with_options(
        self,
        request: dingtalkindustry__1__0_models.SubmitTaskRequest,
        headers: dingtalkindustry__1__0_models.SubmitTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SubmitTaskResponse:
        """
        @summary 提交ai解析任务
        
        @param request: SubmitTaskRequest
        @param headers: SubmitTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubmitTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
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
            action='SubmitTask',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/ai/tasks/submit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SubmitTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def submit_task_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SubmitTaskRequest,
        headers: dingtalkindustry__1__0_models.SubmitTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SubmitTaskResponse:
        """
        @summary 提交ai解析任务
        
        @param request: SubmitTaskRequest
        @param headers: SubmitTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SubmitTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.biz_code):
            body['bizCode'] = request.biz_code
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
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
            action='SubmitTask',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/ai/tasks/submit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SubmitTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def submit_task(
        self,
        request: dingtalkindustry__1__0_models.SubmitTaskRequest,
    ) -> dingtalkindustry__1__0_models.SubmitTaskResponse:
        """
        @summary 提交ai解析任务
        
        @param request: SubmitTaskRequest
        @return: SubmitTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SubmitTaskHeaders()
        return self.submit_task_with_options(request, headers, runtime)

    async def submit_task_async(
        self,
        request: dingtalkindustry__1__0_models.SubmitTaskRequest,
    ) -> dingtalkindustry__1__0_models.SubmitTaskResponse:
        """
        @summary 提交ai解析任务
        
        @param request: SubmitTaskRequest
        @return: SubmitTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SubmitTaskHeaders()
        return await self.submit_task_with_options_async(request, headers, runtime)

    def suppl_add_role_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplAddRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplAddRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplAddRoleResponse:
        """
        @summary 增加角色或角色组
        
        @param request: SupplAddRoleRequest
        @param headers: SupplAddRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplAddRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.parent_role_group_id):
            query['parentRoleGroupId'] = request.parent_role_group_id
        if not UtilClient.is_unset(request.role_name):
            query['roleName'] = request.role_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplAddRole',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/roles',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplAddRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def suppl_add_role_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplAddRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplAddRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplAddRoleResponse:
        """
        @summary 增加角色或角色组
        
        @param request: SupplAddRoleRequest
        @param headers: SupplAddRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplAddRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.parent_role_group_id):
            query['parentRoleGroupId'] = request.parent_role_group_id
        if not UtilClient.is_unset(request.role_name):
            query['roleName'] = request.role_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplAddRole',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/roles',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplAddRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def suppl_add_role(
        self,
        request: dingtalkindustry__1__0_models.SupplAddRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplAddRoleResponse:
        """
        @summary 增加角色或角色组
        
        @param request: SupplAddRoleRequest
        @return: SupplAddRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplAddRoleHeaders()
        return self.suppl_add_role_with_options(request, headers, runtime)

    async def suppl_add_role_async(
        self,
        request: dingtalkindustry__1__0_models.SupplAddRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplAddRoleResponse:
        """
        @summary 增加角色或角色组
        
        @param request: SupplAddRoleRequest
        @return: SupplAddRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplAddRoleHeaders()
        return await self.suppl_add_role_with_options_async(request, headers, runtime)

    def supply_add_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddDeptRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddDeptResponse:
        """
        @summary 新增供应链节点
        
        @param request: SupplyAddDeptRequest
        @param headers: SupplyAddDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyAddDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_name):
            query['deptName'] = request.dept_name
        if not UtilClient.is_unset(request.partner_number):
            query['partnerNumber'] = request.partner_number
        if not UtilClient.is_unset(request.super_dept_id):
            query['superDeptId'] = request.super_dept_id
        if not UtilClient.is_unset(request.supply_dept_type):
            query['supplyDeptType'] = request.supply_dept_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyAddDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/departments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyAddDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_add_dept_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddDeptRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddDeptResponse:
        """
        @summary 新增供应链节点
        
        @param request: SupplyAddDeptRequest
        @param headers: SupplyAddDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyAddDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_name):
            query['deptName'] = request.dept_name
        if not UtilClient.is_unset(request.partner_number):
            query['partnerNumber'] = request.partner_number
        if not UtilClient.is_unset(request.super_dept_id):
            query['superDeptId'] = request.super_dept_id
        if not UtilClient.is_unset(request.supply_dept_type):
            query['supplyDeptType'] = request.supply_dept_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyAddDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/departments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyAddDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_add_dept(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddDeptRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddDeptResponse:
        """
        @summary 新增供应链节点
        
        @param request: SupplyAddDeptRequest
        @return: SupplyAddDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddDeptHeaders()
        return self.supply_add_dept_with_options(request, headers, runtime)

    async def supply_add_dept_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddDeptRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddDeptResponse:
        """
        @summary 新增供应链节点
        
        @param request: SupplyAddDeptRequest
        @return: SupplyAddDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddDeptHeaders()
        return await self.supply_add_dept_with_options_async(request, headers, runtime)

    def supply_add_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddMemberResponse:
        """
        @summary 添加供应商人员
        
        @param request: SupplyAddMemberRequest
        @param headers: SupplyAddMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyAddMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_partner_manager):
            query['isPartnerManager'] = request.is_partner_manager
        if not UtilClient.is_unset(request.member_mobile):
            query['memberMobile'] = request.member_mobile
        if not UtilClient.is_unset(request.member_name):
            query['memberName'] = request.member_name
        if not UtilClient.is_unset(request.member_title):
            query['memberTitle'] = request.member_title
        if not UtilClient.is_unset(request.member_work_number):
            query['memberWorkNumber'] = request.member_work_number
        if not UtilClient.is_unset(request.supply_dept_id):
            query['supplyDeptId'] = request.supply_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyAddMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyAddMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_add_member_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddMemberResponse:
        """
        @summary 添加供应商人员
        
        @param request: SupplyAddMemberRequest
        @param headers: SupplyAddMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyAddMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_partner_manager):
            query['isPartnerManager'] = request.is_partner_manager
        if not UtilClient.is_unset(request.member_mobile):
            query['memberMobile'] = request.member_mobile
        if not UtilClient.is_unset(request.member_name):
            query['memberName'] = request.member_name
        if not UtilClient.is_unset(request.member_title):
            query['memberTitle'] = request.member_title
        if not UtilClient.is_unset(request.member_work_number):
            query['memberWorkNumber'] = request.member_work_number
        if not UtilClient.is_unset(request.supply_dept_id):
            query['supplyDeptId'] = request.supply_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyAddMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyAddMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_add_member(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddMemberResponse:
        """
        @summary 添加供应商人员
        
        @param request: SupplyAddMemberRequest
        @return: SupplyAddMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddMemberHeaders()
        return self.supply_add_member_with_options(request, headers, runtime)

    async def supply_add_member_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddMemberResponse:
        """
        @summary 添加供应商人员
        
        @param request: SupplyAddMemberRequest
        @return: SupplyAddMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddMemberHeaders()
        return await self.supply_add_member_with_options_async(request, headers, runtime)

    def supply_add_partner_admins_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerAdminsRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddPartnerAdminsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerAdminsResponse:
        """
        @summary 添加伙伴负责人
        
        @param request: SupplyAddPartnerAdminsRequest
        @param headers: SupplyAddPartnerAdminsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyAddPartnerAdminsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            action='SupplyAddPartnerAdmins',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerAdministrators',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyAddPartnerAdminsResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_add_partner_admins_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerAdminsRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddPartnerAdminsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerAdminsResponse:
        """
        @summary 添加伙伴负责人
        
        @param request: SupplyAddPartnerAdminsRequest
        @param headers: SupplyAddPartnerAdminsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyAddPartnerAdminsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            action='SupplyAddPartnerAdmins',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerAdministrators',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyAddPartnerAdminsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_add_partner_admins(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerAdminsRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerAdminsResponse:
        """
        @summary 添加伙伴负责人
        
        @param request: SupplyAddPartnerAdminsRequest
        @return: SupplyAddPartnerAdminsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerAdminsHeaders()
        return self.supply_add_partner_admins_with_options(request, headers, runtime)

    async def supply_add_partner_admins_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerAdminsRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerAdminsResponse:
        """
        @summary 添加伙伴负责人
        
        @param request: SupplyAddPartnerAdminsRequest
        @return: SupplyAddPartnerAdminsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerAdminsHeaders()
        return await self.supply_add_partner_admins_with_options_async(request, headers, runtime)

    def supply_add_partner_managers_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerManagersRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddPartnerManagersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerManagersResponse:
        """
        @summary 添加伙伴的对接人或对接部门
        
        @param request: SupplyAddPartnerManagersRequest
        @param headers: SupplyAddPartnerManagersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyAddPartnerManagersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.interface_id):
            query['interfaceId'] = request.interface_id
        if not UtilClient.is_unset(request.interface_type):
            query['interfaceType'] = request.interface_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyAddPartnerManagers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerInterfaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyAddPartnerManagersResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_add_partner_managers_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerManagersRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddPartnerManagersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerManagersResponse:
        """
        @summary 添加伙伴的对接人或对接部门
        
        @param request: SupplyAddPartnerManagersRequest
        @param headers: SupplyAddPartnerManagersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyAddPartnerManagersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.interface_id):
            query['interfaceId'] = request.interface_id
        if not UtilClient.is_unset(request.interface_type):
            query['interfaceType'] = request.interface_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyAddPartnerManagers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerInterfaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyAddPartnerManagersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_add_partner_managers(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerManagersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerManagersResponse:
        """
        @summary 添加伙伴的对接人或对接部门
        
        @param request: SupplyAddPartnerManagersRequest
        @return: SupplyAddPartnerManagersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerManagersHeaders()
        return self.supply_add_partner_managers_with_options(request, headers, runtime)

    async def supply_add_partner_managers_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerManagersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerManagersResponse:
        """
        @summary 添加伙伴的对接人或对接部门
        
        @param request: SupplyAddPartnerManagersRequest
        @return: SupplyAddPartnerManagersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerManagersHeaders()
        return await self.supply_add_partner_managers_with_options_async(request, headers, runtime)

    def supply_add_partner_type_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddPartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerTypeResponse:
        """
        @summary 添加伙伴标签
        
        @param request: SupplyAddPartnerTypeRequest
        @param headers: SupplyAddPartnerTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyAddPartnerTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.super_id):
            query['superId'] = request.super_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyAddPartnerType',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerLabels',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyAddPartnerTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_add_partner_type_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddPartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerTypeResponse:
        """
        @summary 添加伙伴标签
        
        @param request: SupplyAddPartnerTypeRequest
        @param headers: SupplyAddPartnerTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyAddPartnerTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.super_id):
            query['superId'] = request.super_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyAddPartnerType',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerLabels',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyAddPartnerTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_add_partner_type(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerTypeResponse:
        """
        @summary 添加伙伴标签
        
        @param request: SupplyAddPartnerTypeRequest
        @return: SupplyAddPartnerTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerTypeHeaders()
        return self.supply_add_partner_type_with_options(request, headers, runtime)

    async def supply_add_partner_type_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerTypeResponse:
        """
        @summary 添加伙伴标签
        
        @param request: SupplyAddPartnerTypeRequest
        @return: SupplyAddPartnerTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerTypeHeaders()
        return await self.supply_add_partner_type_with_options_async(request, headers, runtime)

    def supply_chain_delete_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainDeleteDeptRequest,
        headers: dingtalkindustry__1__0_models.SupplyChainDeleteDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyChainDeleteDeptResponse:
        """
        @summary  删除上下游节点
        
        @param request: SupplyChainDeleteDeptRequest
        @param headers: SupplyChainDeleteDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyChainDeleteDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.supply_dept_id):
            query['supplyDeptId'] = request.supply_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyChainDeleteDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/departments',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyChainDeleteDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_chain_delete_dept_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainDeleteDeptRequest,
        headers: dingtalkindustry__1__0_models.SupplyChainDeleteDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyChainDeleteDeptResponse:
        """
        @summary  删除上下游节点
        
        @param request: SupplyChainDeleteDeptRequest
        @param headers: SupplyChainDeleteDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyChainDeleteDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.supply_dept_id):
            query['supplyDeptId'] = request.supply_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyChainDeleteDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/departments',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyChainDeleteDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_chain_delete_dept(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainDeleteDeptRequest,
    ) -> dingtalkindustry__1__0_models.SupplyChainDeleteDeptResponse:
        """
        @summary  删除上下游节点
        
        @param request: SupplyChainDeleteDeptRequest
        @return: SupplyChainDeleteDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainDeleteDeptHeaders()
        return self.supply_chain_delete_dept_with_options(request, headers, runtime)

    async def supply_chain_delete_dept_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainDeleteDeptRequest,
    ) -> dingtalkindustry__1__0_models.SupplyChainDeleteDeptResponse:
        """
        @summary  删除上下游节点
        
        @param request: SupplyChainDeleteDeptRequest
        @return: SupplyChainDeleteDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainDeleteDeptHeaders()
        return await self.supply_chain_delete_dept_with_options_async(request, headers, runtime)

    def supply_chain_query_dept_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoResponse:
        """
        @summary 查询上下游节点信息
        
        @param request: SupplyChainQueryDeptInfoRequest
        @param headers: SupplyChainQueryDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyChainQueryDeptInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.supply_dept_id):
            query['supplyDeptId'] = request.supply_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyChainQueryDeptInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/departments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_chain_query_dept_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoResponse:
        """
        @summary 查询上下游节点信息
        
        @param request: SupplyChainQueryDeptInfoRequest
        @param headers: SupplyChainQueryDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyChainQueryDeptInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.supply_dept_id):
            query['supplyDeptId'] = request.supply_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyChainQueryDeptInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/departments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_chain_query_dept_info(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoResponse:
        """
        @summary 查询上下游节点信息
        
        @param request: SupplyChainQueryDeptInfoRequest
        @return: SupplyChainQueryDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoHeaders()
        return self.supply_chain_query_dept_info_with_options(request, headers, runtime)

    async def supply_chain_query_dept_info_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoResponse:
        """
        @summary 查询上下游节点信息
        
        @param request: SupplyChainQueryDeptInfoRequest
        @return: SupplyChainQueryDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoHeaders()
        return await self.supply_chain_query_dept_info_with_options_async(request, headers, runtime)

    def supply_chain_update_dept_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoResponse:
        """
        @summary 更新上下游节点信息
        
        @param request: SupplyChainUpdateDeptInfoRequest
        @param headers: SupplyChainUpdateDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyChainUpdateDeptInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.partner_number):
            body['partnerNumber'] = request.partner_number
        if not UtilClient.is_unset(request.partner_type_list):
            body['partnerTypeList'] = request.partner_type_list
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
        if not UtilClient.is_unset(request.supply_dept_id):
            body['supplyDeptId'] = request.supply_dept_id
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
            action='SupplyChainUpdateDeptInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/departments',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_chain_update_dept_info_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoResponse:
        """
        @summary 更新上下游节点信息
        
        @param request: SupplyChainUpdateDeptInfoRequest
        @param headers: SupplyChainUpdateDeptInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyChainUpdateDeptInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.partner_number):
            body['partnerNumber'] = request.partner_number
        if not UtilClient.is_unset(request.partner_type_list):
            body['partnerTypeList'] = request.partner_type_list
        if not UtilClient.is_unset(request.super_id):
            body['superId'] = request.super_id
        if not UtilClient.is_unset(request.supply_dept_id):
            body['supplyDeptId'] = request.supply_dept_id
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
            action='SupplyChainUpdateDeptInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/departments',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_chain_update_dept_info(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoResponse:
        """
        @summary 更新上下游节点信息
        
        @param request: SupplyChainUpdateDeptInfoRequest
        @return: SupplyChainUpdateDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoHeaders()
        return self.supply_chain_update_dept_info_with_options(request, headers, runtime)

    async def supply_chain_update_dept_info_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoResponse:
        """
        @summary 更新上下游节点信息
        
        @param request: SupplyChainUpdateDeptInfoRequest
        @return: SupplyChainUpdateDeptInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoHeaders()
        return await self.supply_chain_update_dept_info_with_options_async(request, headers, runtime)

    def supply_delete_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeleteMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteMemberResponse:
        """
        @summary 删除伙伴成员
        
        @param request: SupplyDeleteMemberRequest
        @param headers: SupplyDeleteMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyDeleteMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='SupplyDeleteMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/members',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyDeleteMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_delete_member_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeleteMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteMemberResponse:
        """
        @summary 删除伙伴成员
        
        @param request: SupplyDeleteMemberRequest
        @param headers: SupplyDeleteMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyDeleteMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='SupplyDeleteMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/members',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyDeleteMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_delete_member(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteMemberResponse:
        """
        @summary 删除伙伴成员
        
        @param request: SupplyDeleteMemberRequest
        @return: SupplyDeleteMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeleteMemberHeaders()
        return self.supply_delete_member_with_options(request, headers, runtime)

    async def supply_delete_member_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteMemberResponse:
        """
        @summary 删除伙伴成员
        
        @param request: SupplyDeleteMemberRequest
        @return: SupplyDeleteMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeleteMemberHeaders()
        return await self.supply_delete_member_with_options_async(request, headers, runtime)

    def supply_delete_partner_admins_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsResponse:
        """
        @summary 删除伙伴负责人
        
        @param request: SupplyDeletePartnerAdminsRequest
        @param headers: SupplyDeletePartnerAdminsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyDeletePartnerAdminsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            action='SupplyDeletePartnerAdmins',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerAdministrators',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_delete_partner_admins_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsResponse:
        """
        @summary 删除伙伴负责人
        
        @param request: SupplyDeletePartnerAdminsRequest
        @param headers: SupplyDeletePartnerAdminsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyDeletePartnerAdminsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
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
            action='SupplyDeletePartnerAdmins',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerAdministrators',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_delete_partner_admins(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsResponse:
        """
        @summary 删除伙伴负责人
        
        @param request: SupplyDeletePartnerAdminsRequest
        @return: SupplyDeletePartnerAdminsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsHeaders()
        return self.supply_delete_partner_admins_with_options(request, headers, runtime)

    async def supply_delete_partner_admins_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsResponse:
        """
        @summary 删除伙伴负责人
        
        @param request: SupplyDeletePartnerAdminsRequest
        @return: SupplyDeletePartnerAdminsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsHeaders()
        return await self.supply_delete_partner_admins_with_options_async(request, headers, runtime)

    def supply_delete_partner_managers_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerManagersRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeletePartnerManagersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerManagersResponse:
        """
        @summary 移除伙伴的对接人或对接部门
        
        @param request: SupplyDeletePartnerManagersRequest
        @param headers: SupplyDeletePartnerManagersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyDeletePartnerManagersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.interface_id):
            query['interfaceId'] = request.interface_id
        if not UtilClient.is_unset(request.interface_type):
            query['interfaceType'] = request.interface_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyDeletePartnerManagers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerInterfaces',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyDeletePartnerManagersResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_delete_partner_managers_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerManagersRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeletePartnerManagersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerManagersResponse:
        """
        @summary 移除伙伴的对接人或对接部门
        
        @param request: SupplyDeletePartnerManagersRequest
        @param headers: SupplyDeletePartnerManagersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyDeletePartnerManagersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.interface_id):
            query['interfaceId'] = request.interface_id
        if not UtilClient.is_unset(request.interface_type):
            query['interfaceType'] = request.interface_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyDeletePartnerManagers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerInterfaces',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyDeletePartnerManagersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_delete_partner_managers(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerManagersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerManagersResponse:
        """
        @summary 移除伙伴的对接人或对接部门
        
        @param request: SupplyDeletePartnerManagersRequest
        @return: SupplyDeletePartnerManagersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerManagersHeaders()
        return self.supply_delete_partner_managers_with_options(request, headers, runtime)

    async def supply_delete_partner_managers_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerManagersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerManagersResponse:
        """
        @summary 移除伙伴的对接人或对接部门
        
        @param request: SupplyDeletePartnerManagersRequest
        @return: SupplyDeletePartnerManagersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerManagersHeaders()
        return await self.supply_delete_partner_managers_with_options_async(request, headers, runtime)

    def supply_delete_partner_type_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeletePartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerTypeResponse:
        """
        @summary 删除伙伴标签
        
        @param request: SupplyDeletePartnerTypeRequest
        @param headers: SupplyDeletePartnerTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyDeletePartnerTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.label_id):
            query['labelId'] = request.label_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyDeletePartnerType',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerLabels',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyDeletePartnerTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_delete_partner_type_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeletePartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerTypeResponse:
        """
        @summary 删除伙伴标签
        
        @param request: SupplyDeletePartnerTypeRequest
        @param headers: SupplyDeletePartnerTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyDeletePartnerTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.label_id):
            query['labelId'] = request.label_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyDeletePartnerType',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerLabels',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyDeletePartnerTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_delete_partner_type(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerTypeResponse:
        """
        @summary 删除伙伴标签
        
        @param request: SupplyDeletePartnerTypeRequest
        @return: SupplyDeletePartnerTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerTypeHeaders()
        return self.supply_delete_partner_type_with_options(request, headers, runtime)

    async def supply_delete_partner_type_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerTypeResponse:
        """
        @summary 删除伙伴标签
        
        @param request: SupplyDeletePartnerTypeRequest
        @return: SupplyDeletePartnerTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerTypeHeaders()
        return await self.supply_delete_partner_type_with_options_async(request, headers, runtime)

    def supply_delete_role_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeleteRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteRoleResponse:
        """
        @summary 删除角色或角色组
        
        @param request: SupplyDeleteRoleRequest
        @param headers: SupplyDeleteRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyDeleteRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_role_group):
            query['isRoleGroup'] = request.is_role_group
        if not UtilClient.is_unset(request.role_id):
            query['roleId'] = request.role_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyDeleteRole',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/roles',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyDeleteRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_delete_role_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeleteRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteRoleResponse:
        """
        @summary 删除角色或角色组
        
        @param request: SupplyDeleteRoleRequest
        @param headers: SupplyDeleteRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyDeleteRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_role_group):
            query['isRoleGroup'] = request.is_role_group
        if not UtilClient.is_unset(request.role_id):
            query['roleId'] = request.role_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyDeleteRole',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/roles',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyDeleteRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_delete_role(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteRoleResponse:
        """
        @summary 删除角色或角色组
        
        @param request: SupplyDeleteRoleRequest
        @return: SupplyDeleteRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeleteRoleHeaders()
        return self.supply_delete_role_with_options(request, headers, runtime)

    async def supply_delete_role_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteRoleResponse:
        """
        @summary 删除角色或角色组
        
        @param request: SupplyDeleteRoleRequest
        @return: SupplyDeleteRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeleteRoleHeaders()
        return await self.supply_delete_role_with_options_async(request, headers, runtime)

    def supply_get_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyGetMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyGetMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyGetMemberResponse:
        """
        @summary 获取供应链成员信息
        
        @param request: SupplyGetMemberRequest
        @param headers: SupplyGetMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyGetMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='SupplyGetMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyGetMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_get_member_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyGetMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyGetMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyGetMemberResponse:
        """
        @summary 获取供应链成员信息
        
        @param request: SupplyGetMemberRequest
        @param headers: SupplyGetMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyGetMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='SupplyGetMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyGetMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_get_member(
        self,
        request: dingtalkindustry__1__0_models.SupplyGetMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyGetMemberResponse:
        """
        @summary 获取供应链成员信息
        
        @param request: SupplyGetMemberRequest
        @return: SupplyGetMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyGetMemberHeaders()
        return self.supply_get_member_with_options(request, headers, runtime)

    async def supply_get_member_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyGetMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyGetMemberResponse:
        """
        @summary 获取供应链成员信息
        
        @param request: SupplyGetMemberRequest
        @return: SupplyGetMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyGetMemberHeaders()
        return await self.supply_get_member_with_options_async(request, headers, runtime)

    def supply_list_dept_members_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListDeptMembersRequest,
        headers: dingtalkindustry__1__0_models.SupplyListDeptMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListDeptMembersResponse:
        """
        @summary 获取供应链部门下成员
        
        @param request: SupplyListDeptMembersRequest
        @param headers: SupplyListDeptMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListDeptMembersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.supply_dept_id):
            query['supplyDeptId'] = request.supply_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListDeptMembers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/departments/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListDeptMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_list_dept_members_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListDeptMembersRequest,
        headers: dingtalkindustry__1__0_models.SupplyListDeptMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListDeptMembersResponse:
        """
        @summary 获取供应链部门下成员
        
        @param request: SupplyListDeptMembersRequest
        @param headers: SupplyListDeptMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListDeptMembersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.supply_dept_id):
            query['supplyDeptId'] = request.supply_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListDeptMembers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/departments/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListDeptMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_list_dept_members(
        self,
        request: dingtalkindustry__1__0_models.SupplyListDeptMembersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListDeptMembersResponse:
        """
        @summary 获取供应链部门下成员
        
        @param request: SupplyListDeptMembersRequest
        @return: SupplyListDeptMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListDeptMembersHeaders()
        return self.supply_list_dept_members_with_options(request, headers, runtime)

    async def supply_list_dept_members_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListDeptMembersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListDeptMembersResponse:
        """
        @summary 获取供应链部门下成员
        
        @param request: SupplyListDeptMembersRequest
        @return: SupplyListDeptMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListDeptMembersHeaders()
        return await self.supply_list_dept_members_with_options_async(request, headers, runtime)

    def supply_list_partner_admins_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerAdminsRequest,
        headers: dingtalkindustry__1__0_models.SupplyListPartnerAdminsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerAdminsResponse:
        """
        @summary 获取伙伴负责人列表
        
        @param request: SupplyListPartnerAdminsRequest
        @param headers: SupplyListPartnerAdminsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListPartnerAdminsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListPartnerAdmins',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerAdministrators',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListPartnerAdminsResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_list_partner_admins_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerAdminsRequest,
        headers: dingtalkindustry__1__0_models.SupplyListPartnerAdminsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerAdminsResponse:
        """
        @summary 获取伙伴负责人列表
        
        @param request: SupplyListPartnerAdminsRequest
        @param headers: SupplyListPartnerAdminsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListPartnerAdminsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListPartnerAdmins',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerAdministrators',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListPartnerAdminsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_list_partner_admins(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerAdminsRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerAdminsResponse:
        """
        @summary 获取伙伴负责人列表
        
        @param request: SupplyListPartnerAdminsRequest
        @return: SupplyListPartnerAdminsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerAdminsHeaders()
        return self.supply_list_partner_admins_with_options(request, headers, runtime)

    async def supply_list_partner_admins_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerAdminsRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerAdminsResponse:
        """
        @summary 获取伙伴负责人列表
        
        @param request: SupplyListPartnerAdminsRequest
        @return: SupplyListPartnerAdminsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerAdminsHeaders()
        return await self.supply_list_partner_admins_with_options_async(request, headers, runtime)

    def supply_list_partner_managers_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerManagersRequest,
        headers: dingtalkindustry__1__0_models.SupplyListPartnerManagersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerManagersResponse:
        """
        @summary 获取伙伴的对接人/对接部门
        
        @param request: SupplyListPartnerManagersRequest
        @param headers: SupplyListPartnerManagersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListPartnerManagersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListPartnerManagers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerInterfaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListPartnerManagersResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_list_partner_managers_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerManagersRequest,
        headers: dingtalkindustry__1__0_models.SupplyListPartnerManagersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerManagersResponse:
        """
        @summary 获取伙伴的对接人/对接部门
        
        @param request: SupplyListPartnerManagersRequest
        @param headers: SupplyListPartnerManagersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListPartnerManagersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListPartnerManagers',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerInterfaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListPartnerManagersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_list_partner_managers(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerManagersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerManagersResponse:
        """
        @summary 获取伙伴的对接人/对接部门
        
        @param request: SupplyListPartnerManagersRequest
        @return: SupplyListPartnerManagersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerManagersHeaders()
        return self.supply_list_partner_managers_with_options(request, headers, runtime)

    async def supply_list_partner_managers_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerManagersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerManagersResponse:
        """
        @summary 获取伙伴的对接人/对接部门
        
        @param request: SupplyListPartnerManagersRequest
        @return: SupplyListPartnerManagersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerManagersHeaders()
        return await self.supply_list_partner_managers_with_options_async(request, headers, runtime)

    def supply_list_partner_type_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyListPartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerTypeResponse:
        """
        @summary 查询下级伙伴标签
        
        @param request: SupplyListPartnerTypeRequest
        @param headers: SupplyListPartnerTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListPartnerTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.label_id):
            query['labelId'] = request.label_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListPartnerType',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerLabels/subLabels',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListPartnerTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_list_partner_type_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyListPartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerTypeResponse:
        """
        @summary 查询下级伙伴标签
        
        @param request: SupplyListPartnerTypeRequest
        @param headers: SupplyListPartnerTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListPartnerTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.label_id):
            query['labelId'] = request.label_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListPartnerType',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerLabels/subLabels',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListPartnerTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_list_partner_type(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerTypeResponse:
        """
        @summary 查询下级伙伴标签
        
        @param request: SupplyListPartnerTypeRequest
        @return: SupplyListPartnerTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerTypeHeaders()
        return self.supply_list_partner_type_with_options(request, headers, runtime)

    async def supply_list_partner_type_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerTypeResponse:
        """
        @summary 查询下级伙伴标签
        
        @param request: SupplyListPartnerTypeRequest
        @return: SupplyListPartnerTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerTypeHeaders()
        return await self.supply_list_partner_type_with_options_async(request, headers, runtime)

    def supply_list_role_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplyListRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListRoleResponse:
        """
        @summary 查询角色组或角色
        
        @param request: SupplyListRoleRequest
        @param headers: SupplyListRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.parent_role_id):
            query['parentRoleId'] = request.parent_role_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListRole',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_list_role_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplyListRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListRoleResponse:
        """
        @summary 查询角色组或角色
        
        @param request: SupplyListRoleRequest
        @param headers: SupplyListRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.parent_role_id):
            query['parentRoleId'] = request.parent_role_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListRole',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_list_role(
        self,
        request: dingtalkindustry__1__0_models.SupplyListRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListRoleResponse:
        """
        @summary 查询角色组或角色
        
        @param request: SupplyListRoleRequest
        @return: SupplyListRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListRoleHeaders()
        return self.supply_list_role_with_options(request, headers, runtime)

    async def supply_list_role_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListRoleResponse:
        """
        @summary 查询角色组或角色
        
        @param request: SupplyListRoleRequest
        @return: SupplyListRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListRoleHeaders()
        return await self.supply_list_role_with_options_async(request, headers, runtime)

    def supply_list_sub_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListSubDeptRequest,
        headers: dingtalkindustry__1__0_models.SupplyListSubDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListSubDeptResponse:
        """
        @summary 查询下级节点列表
        
        @param request: SupplyListSubDeptRequest
        @param headers: SupplyListSubDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListSubDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.supply_dept_id):
            query['supplyDeptId'] = request.supply_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListSubDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/subDepartments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListSubDeptResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_list_sub_dept_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListSubDeptRequest,
        headers: dingtalkindustry__1__0_models.SupplyListSubDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListSubDeptResponse:
        """
        @summary 查询下级节点列表
        
        @param request: SupplyListSubDeptRequest
        @param headers: SupplyListSubDeptHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyListSubDeptResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.supply_dept_id):
            query['supplyDeptId'] = request.supply_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyListSubDept',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/subDepartments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyListSubDeptResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_list_sub_dept(
        self,
        request: dingtalkindustry__1__0_models.SupplyListSubDeptRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListSubDeptResponse:
        """
        @summary 查询下级节点列表
        
        @param request: SupplyListSubDeptRequest
        @return: SupplyListSubDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListSubDeptHeaders()
        return self.supply_list_sub_dept_with_options(request, headers, runtime)

    async def supply_list_sub_dept_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListSubDeptRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListSubDeptResponse:
        """
        @summary 查询下级节点列表
        
        @param request: SupplyListSubDeptRequest
        @return: SupplyListSubDeptResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListSubDeptHeaders()
        return await self.supply_list_sub_dept_with_options_async(request, headers, runtime)

    def supply_query_partner_type_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyQueryPartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyQueryPartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyQueryPartnerTypeResponse:
        """
        @summary 查询伙伴标签
        
        @param request: SupplyQueryPartnerTypeRequest
        @param headers: SupplyQueryPartnerTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyQueryPartnerTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.label_id):
            query['labelId'] = request.label_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyQueryPartnerType',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerLabels',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyQueryPartnerTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_query_partner_type_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyQueryPartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyQueryPartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyQueryPartnerTypeResponse:
        """
        @summary 查询伙伴标签
        
        @param request: SupplyQueryPartnerTypeRequest
        @param headers: SupplyQueryPartnerTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyQueryPartnerTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.label_id):
            query['labelId'] = request.label_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyQueryPartnerType',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerLabels',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyQueryPartnerTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_query_partner_type(
        self,
        request: dingtalkindustry__1__0_models.SupplyQueryPartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyQueryPartnerTypeResponse:
        """
        @summary 查询伙伴标签
        
        @param request: SupplyQueryPartnerTypeRequest
        @return: SupplyQueryPartnerTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyQueryPartnerTypeHeaders()
        return self.supply_query_partner_type_with_options(request, headers, runtime)

    async def supply_query_partner_type_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyQueryPartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyQueryPartnerTypeResponse:
        """
        @summary 查询伙伴标签
        
        @param request: SupplyQueryPartnerTypeRequest
        @return: SupplyQueryPartnerTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyQueryPartnerTypeHeaders()
        return await self.supply_query_partner_type_with_options_async(request, headers, runtime)

    def supply_update_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyUpdateMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateMemberResponse:
        """
        @summary 更新供应商人员信息
        
        @param request: SupplyUpdateMemberRequest
        @param headers: SupplyUpdateMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyUpdateMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.is_copy_dept):
            body['isCopyDept'] = request.is_copy_dept
        if not UtilClient.is_unset(request.member_title):
            body['memberTitle'] = request.member_title
        if not UtilClient.is_unset(request.member_work_number):
            body['memberWorkNumber'] = request.member_work_number
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.new_dept_id):
            body['newDeptId'] = request.new_dept_id
        if not UtilClient.is_unset(request.old_dept_id):
            body['oldDeptId'] = request.old_dept_id
        if not UtilClient.is_unset(request.role_id_list):
            body['roleIdList'] = request.role_id_list
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='SupplyUpdateMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyUpdateMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_update_member_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyUpdateMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateMemberResponse:
        """
        @summary 更新供应商人员信息
        
        @param request: SupplyUpdateMemberRequest
        @param headers: SupplyUpdateMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyUpdateMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.is_copy_dept):
            body['isCopyDept'] = request.is_copy_dept
        if not UtilClient.is_unset(request.member_title):
            body['memberTitle'] = request.member_title
        if not UtilClient.is_unset(request.member_work_number):
            body['memberWorkNumber'] = request.member_work_number
        if not UtilClient.is_unset(request.mobile):
            body['mobile'] = request.mobile
        if not UtilClient.is_unset(request.new_dept_id):
            body['newDeptId'] = request.new_dept_id
        if not UtilClient.is_unset(request.old_dept_id):
            body['oldDeptId'] = request.old_dept_id
        if not UtilClient.is_unset(request.role_id_list):
            body['roleIdList'] = request.role_id_list
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='SupplyUpdateMember',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyUpdateMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_update_member(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateMemberResponse:
        """
        @summary 更新供应商人员信息
        
        @param request: SupplyUpdateMemberRequest
        @return: SupplyUpdateMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyUpdateMemberHeaders()
        return self.supply_update_member_with_options(request, headers, runtime)

    async def supply_update_member_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateMemberResponse:
        """
        @summary 更新供应商人员信息
        
        @param request: SupplyUpdateMemberRequest
        @return: SupplyUpdateMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyUpdateMemberHeaders()
        return await self.supply_update_member_with_options_async(request, headers, runtime)

    def supply_update_partner_type_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeResponse:
        """
        @summary 更新伙伴标签
        
        @param request: SupplyUpdatePartnerTypeRequest
        @param headers: SupplyUpdatePartnerTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyUpdatePartnerTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.label_id):
            query['labelId'] = request.label_id
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.super_id):
            query['superId'] = request.super_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyUpdatePartnerType',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerLabels',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_update_partner_type_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeResponse:
        """
        @summary 更新伙伴标签
        
        @param request: SupplyUpdatePartnerTypeRequest
        @param headers: SupplyUpdatePartnerTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyUpdatePartnerTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.label_id):
            query['labelId'] = request.label_id
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.super_id):
            query['superId'] = request.super_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyUpdatePartnerType',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/partnerLabels',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_update_partner_type(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeResponse:
        """
        @summary 更新伙伴标签
        
        @param request: SupplyUpdatePartnerTypeRequest
        @return: SupplyUpdatePartnerTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeHeaders()
        return self.supply_update_partner_type_with_options(request, headers, runtime)

    async def supply_update_partner_type_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeResponse:
        """
        @summary 更新伙伴标签
        
        @param request: SupplyUpdatePartnerTypeRequest
        @return: SupplyUpdatePartnerTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeHeaders()
        return await self.supply_update_partner_type_with_options_async(request, headers, runtime)

    def supply_update_role_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplyUpdateRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateRoleResponse:
        """
        @summary 更新角色或角色组
        
        @param request: SupplyUpdateRoleRequest
        @param headers: SupplyUpdateRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyUpdateRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_role_group):
            query['isRoleGroup'] = request.is_role_group
        if not UtilClient.is_unset(request.role_id):
            query['roleId'] = request.role_id
        if not UtilClient.is_unset(request.role_name):
            query['roleName'] = request.role_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyUpdateRole',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/roles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyUpdateRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def supply_update_role_with_options_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplyUpdateRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateRoleResponse:
        """
        @summary 更新角色或角色组
        
        @param request: SupplyUpdateRoleRequest
        @param headers: SupplyUpdateRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SupplyUpdateRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_role_group):
            query['isRoleGroup'] = request.is_role_group
        if not UtilClient.is_unset(request.role_id):
            query['roleId'] = request.role_id
        if not UtilClient.is_unset(request.role_name):
            query['roleName'] = request.role_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SupplyUpdateRole',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/supplyChains/roles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SupplyUpdateRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def supply_update_role(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateRoleResponse:
        """
        @summary 更新角色或角色组
        
        @param request: SupplyUpdateRoleRequest
        @return: SupplyUpdateRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyUpdateRoleHeaders()
        return self.supply_update_role_with_options(request, headers, runtime)

    async def supply_update_role_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateRoleResponse:
        """
        @summary 更新角色或角色组
        
        @param request: SupplyUpdateRoleRequest
        @return: SupplyUpdateRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyUpdateRoleHeaders()
        return await self.supply_update_role_with_options_async(request, headers, runtime)

    def update_user_extend_info_with_options(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.UpdateUserExtendInfoRequest,
        headers: dingtalkindustry__1__0_models.UpdateUserExtendInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.UpdateUserExtendInfoResponse:
        """
        @summary 更新医疗用户扩展信息
        
        @param request: UpdateUserExtendInfoRequest
        @param headers: UpdateUserExtendInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUserExtendInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.comments):
            body['comments'] = request.comments
        if not UtilClient.is_unset(request.job_code):
            body['jobCode'] = request.job_code
        if not UtilClient.is_unset(request.job_status_code):
            body['jobStatusCode'] = request.job_status_code
        if not UtilClient.is_unset(request.user_prob_code):
            body['userProbCode'] = request.user_prob_code
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
            action='UpdateUserExtendInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/{user_id}/extInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.UpdateUserExtendInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def update_user_extend_info_with_options_async(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.UpdateUserExtendInfoRequest,
        headers: dingtalkindustry__1__0_models.UpdateUserExtendInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.UpdateUserExtendInfoResponse:
        """
        @summary 更新医疗用户扩展信息
        
        @param request: UpdateUserExtendInfoRequest
        @param headers: UpdateUserExtendInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUserExtendInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.comments):
            body['comments'] = request.comments
        if not UtilClient.is_unset(request.job_code):
            body['jobCode'] = request.job_code
        if not UtilClient.is_unset(request.job_status_code):
            body['jobStatusCode'] = request.job_status_code
        if not UtilClient.is_unset(request.user_prob_code):
            body['userProbCode'] = request.user_prob_code
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
            action='UpdateUserExtendInfo',
            version='industry_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/industry/medicals/users/{user_id}/extInfos',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.UpdateUserExtendInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_user_extend_info(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.UpdateUserExtendInfoRequest,
    ) -> dingtalkindustry__1__0_models.UpdateUserExtendInfoResponse:
        """
        @summary 更新医疗用户扩展信息
        
        @param request: UpdateUserExtendInfoRequest
        @return: UpdateUserExtendInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.UpdateUserExtendInfoHeaders()
        return self.update_user_extend_info_with_options(user_id, request, headers, runtime)

    async def update_user_extend_info_async(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.UpdateUserExtendInfoRequest,
    ) -> dingtalkindustry__1__0_models.UpdateUserExtendInfoResponse:
        """
        @summary 更新医疗用户扩展信息
        
        @param request: UpdateUserExtendInfoRequest
        @return: UpdateUserExtendInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.UpdateUserExtendInfoHeaders()
        return await self.update_user_extend_info_with_options_async(user_id, request, headers, runtime)
