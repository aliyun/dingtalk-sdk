# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
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

    def campus_add_renter_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusAddRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusAddRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusAddRenterMemberResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusAddRenterMemberHeaders()
        return self.campus_add_renter_member_with_options(request, headers, runtime)

    async def campus_add_renter_member_async(
        self,
        request: dingtalkindustry__1__0_models.CampusAddRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusAddRenterMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusAddRenterMemberHeaders()
        return await self.campus_add_renter_member_with_options_async(request, headers, runtime)

    def campus_create_campus_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusCreateCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateCampusHeaders()
        return self.campus_create_campus_with_options(request, headers, runtime)

    async def campus_create_campus_async(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateCampusHeaders()
        return await self.campus_create_campus_with_options_async(request, headers, runtime)

    def campus_create_campus_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusCreateCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusGroupResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateCampusGroupHeaders()
        return self.campus_create_campus_group_with_options(request, headers, runtime)

    async def campus_create_campus_group_async(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusCreateCampusGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateCampusGroupHeaders()
        return await self.campus_create_campus_group_with_options_async(request, headers, runtime)

    def campus_create_renter_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusCreateRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusCreateRenterResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateRenterHeaders()
        return self.campus_create_renter_with_options(request, headers, runtime)

    async def campus_create_renter_async(
        self,
        request: dingtalkindustry__1__0_models.CampusCreateRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusCreateRenterResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusCreateRenterHeaders()
        return await self.campus_create_renter_with_options_async(request, headers, runtime)

    def campus_del_renter_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusDelRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusDelRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusDelRenterMemberResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDelRenterMemberHeaders()
        return self.campus_del_renter_member_with_options(request, headers, runtime)

    async def campus_del_renter_member_async(
        self,
        request: dingtalkindustry__1__0_models.CampusDelRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusDelRenterMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDelRenterMemberHeaders()
        return await self.campus_del_renter_member_with_options_async(request, headers, runtime)

    def campus_delete_campus_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusDeleteCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusDeleteCampusGroupResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDeleteCampusGroupHeaders()
        return self.campus_delete_campus_group_with_options(request, headers, runtime)

    async def campus_delete_campus_group_async(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusDeleteCampusGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDeleteCampusGroupHeaders()
        return await self.campus_delete_campus_group_with_options_async(request, headers, runtime)

    def campus_delete_renter_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusDeleteRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusDeleteRenterResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDeleteRenterHeaders()
        return self.campus_delete_renter_with_options(request, headers, runtime)

    async def campus_delete_renter_async(
        self,
        request: dingtalkindustry__1__0_models.CampusDeleteRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusDeleteRenterResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusDeleteRenterHeaders()
        return await self.campus_delete_renter_with_options_async(request, headers, runtime)

    def campus_get_campus_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusGetCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetCampusHeaders()
        return self.campus_get_campus_with_options(request, headers, runtime)

    async def campus_get_campus_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetCampusHeaders()
        return await self.campus_get_campus_with_options_async(request, headers, runtime)

    def campus_get_campus_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusGetCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusGroupResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetCampusGroupHeaders()
        return self.campus_get_campus_group_with_options(request, headers, runtime)

    async def campus_get_campus_group_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetCampusGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetCampusGroupHeaders()
        return await self.campus_get_campus_group_with_options_async(request, headers, runtime)

    def campus_get_renter_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusGetRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetRenterHeaders()
        return self.campus_get_renter_with_options(request, headers, runtime)

    async def campus_get_renter_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetRenterHeaders()
        return await self.campus_get_renter_with_options_async(request, headers, runtime)

    def campus_get_renter_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusGetRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterMemberResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetRenterMemberHeaders()
        return self.campus_get_renter_member_with_options(request, headers, runtime)

    async def campus_get_renter_member_async(
        self,
        request: dingtalkindustry__1__0_models.CampusGetRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusGetRenterMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusGetRenterMemberHeaders()
        return await self.campus_get_renter_member_with_options_async(request, headers, runtime)

    def campus_list_campus_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusListCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusListCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListCampusResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListCampusHeaders()
        return self.campus_list_campus_with_options(request, headers, runtime)

    async def campus_list_campus_async(
        self,
        request: dingtalkindustry__1__0_models.CampusListCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusListCampusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListCampusHeaders()
        return await self.campus_list_campus_with_options_async(request, headers, runtime)

    def campus_list_campus_group_with_options(
        self,
        headers: dingtalkindustry__1__0_models.CampusListCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListCampusGroupResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListCampusGroupHeaders()
        return self.campus_list_campus_group_with_options(headers, runtime)

    async def campus_list_campus_group_async(self) -> dingtalkindustry__1__0_models.CampusListCampusGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListCampusGroupHeaders()
        return await self.campus_list_campus_group_with_options_async(headers, runtime)

    def campus_list_renter_with_options(
        self,
        headers: dingtalkindustry__1__0_models.CampusListRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListRenterResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListRenterHeaders()
        return self.campus_list_renter_with_options(headers, runtime)

    async def campus_list_renter_async(self) -> dingtalkindustry__1__0_models.CampusListRenterResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListRenterHeaders()
        return await self.campus_list_renter_with_options_async(headers, runtime)

    def campus_list_renter_members_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusListRenterMembersRequest,
        headers: dingtalkindustry__1__0_models.CampusListRenterMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusListRenterMembersResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListRenterMembersHeaders()
        return self.campus_list_renter_members_with_options(request, headers, runtime)

    async def campus_list_renter_members_async(
        self,
        request: dingtalkindustry__1__0_models.CampusListRenterMembersRequest,
    ) -> dingtalkindustry__1__0_models.CampusListRenterMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListRenterMembersHeaders()
        return await self.campus_list_renter_members_with_options_async(request, headers, runtime)

    def campus_update_campus_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateCampusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateCampusHeaders()
        return self.campus_update_campus_with_options(request, headers, runtime)

    async def campus_update_campus_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateCampusHeaders()
        return await self.campus_update_campus_with_options_async(request, headers, runtime)

    def campus_update_campus_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusGroupRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateCampusGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusGroupResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateCampusGroupHeaders()
        return self.campus_update_campus_group_with_options(request, headers, runtime)

    async def campus_update_campus_group_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateCampusGroupRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateCampusGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateCampusGroupHeaders()
        return await self.campus_update_campus_group_with_options_async(request, headers, runtime)

    def campus_update_renter_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateRenterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateRenterHeaders()
        return self.campus_update_renter_with_options(request, headers, runtime)

    async def campus_update_renter_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateRenterHeaders()
        return await self.campus_update_renter_with_options_async(request, headers, runtime)

    def campus_update_renter_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterMemberRequest,
        headers: dingtalkindustry__1__0_models.CampusUpdateRenterMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterMemberResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateRenterMemberHeaders()
        return self.campus_update_renter_member_with_options(request, headers, runtime)

    async def campus_update_renter_member_async(
        self,
        request: dingtalkindustry__1__0_models.CampusUpdateRenterMemberRequest,
    ) -> dingtalkindustry__1__0_models.CampusUpdateRenterMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusUpdateRenterMemberHeaders()
        return await self.campus_update_renter_member_with_options_async(request, headers, runtime)

    def college_active_college_dept_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupRequest,
        headers: dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupHeaders()
        return self.college_active_college_dept_group_with_options(request, headers, runtime)

    async def college_active_college_dept_group_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupRequest,
    ) -> dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeActiveCollegeDeptGroupHeaders()
        return await self.college_active_college_dept_group_with_options_async(request, headers, runtime)

    def college_add_college_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddCollegeDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeAddCollegeDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeAddCollegeDeptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddCollegeDeptHeaders()
        return self.college_add_college_dept_with_options(request, headers, runtime)

    async def college_add_college_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddCollegeDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeAddCollegeDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddCollegeDeptHeaders()
        return await self.college_add_college_dept_with_options_async(request, headers, runtime)

    def college_add_manager_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddManagerRequest,
        headers: dingtalkindustry__1__0_models.CollegeAddManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeAddManagerResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddManagerHeaders()
        return self.college_add_manager_with_options(request, headers, runtime)

    async def college_add_manager_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddManagerRequest,
    ) -> dingtalkindustry__1__0_models.CollegeAddManagerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddManagerHeaders()
        return await self.college_add_manager_with_options_async(request, headers, runtime)

    def college_add_student_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddStudentRequest,
        headers: dingtalkindustry__1__0_models.CollegeAddStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeAddStudentResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddStudentHeaders()
        return self.college_add_student_with_options(request, headers, runtime)

    async def college_add_student_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeAddStudentRequest,
    ) -> dingtalkindustry__1__0_models.CollegeAddStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeAddStudentHeaders()
        return await self.college_add_student_with_options_async(request, headers, runtime)

    def college_change_student_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeChangeStudentDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeChangeStudentDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeChangeStudentDeptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeChangeStudentDeptHeaders()
        return self.college_change_student_dept_with_options(request, headers, runtime)

    async def college_change_student_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeChangeStudentDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeChangeStudentDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeChangeStudentDeptHeaders()
        return await self.college_change_student_dept_with_options_async(request, headers, runtime)

    def college_delete_college_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptHeaders()
        return self.college_delete_college_dept_with_options(request, headers, runtime)

    async def college_delete_college_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeDeleteCollegeDeptHeaders()
        return await self.college_delete_college_dept_with_options_async(request, headers, runtime)

    def college_list_college_sub_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeListCollegeSubDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeListCollegeSubDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListCollegeSubDeptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListCollegeSubDeptHeaders()
        return self.college_list_college_sub_dept_with_options(request, headers, runtime)

    async def college_list_college_sub_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListCollegeSubDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListCollegeSubDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListCollegeSubDeptHeaders()
        return await self.college_list_college_sub_dept_with_options_async(request, headers, runtime)

    def college_list_dept_manager_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeListDeptManagerRequest,
        headers: dingtalkindustry__1__0_models.CollegeListDeptManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListDeptManagerResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListDeptManagerHeaders()
        return self.college_list_dept_manager_with_options(request, headers, runtime)

    async def college_list_dept_manager_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListDeptManagerRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListDeptManagerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListDeptManagerHeaders()
        return await self.college_list_dept_manager_with_options_async(request, headers, runtime)

    def college_list_student_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeListStudentInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeListStudentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListStudentInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListStudentInfoHeaders()
        return self.college_list_student_info_with_options(request, headers, runtime)

    async def college_list_student_info_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListStudentInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListStudentInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListStudentInfoHeaders()
        return await self.college_list_student_info_with_options_async(request, headers, runtime)

    def college_list_unchecked_student_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeListUncheckedStudentRequest,
        headers: dingtalkindustry__1__0_models.CollegeListUncheckedStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeListUncheckedStudentResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListUncheckedStudentHeaders()
        return self.college_list_unchecked_student_with_options(request, headers, runtime)

    async def college_list_unchecked_student_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeListUncheckedStudentRequest,
    ) -> dingtalkindustry__1__0_models.CollegeListUncheckedStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeListUncheckedStudentHeaders()
        return await self.college_list_unchecked_student_with_options_async(request, headers, runtime)

    def college_query_college_dept_group_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoHeaders()
        return self.college_query_college_dept_group_info_with_options(request, headers, runtime)

    async def college_query_college_dept_group_info_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryCollegeDeptGroupInfoHeaders()
        return await self.college_query_college_dept_group_info_with_options_async(request, headers, runtime)

    def college_query_college_dept_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoHeaders()
        return self.college_query_college_dept_info_with_options(request, headers, runtime)

    async def college_query_college_dept_info_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryCollegeDeptInfoHeaders()
        return await self.college_query_college_dept_info_with_options_async(request, headers, runtime)

    def college_query_student_info_by_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptHeaders()
        return self.college_query_student_info_by_dept_with_options(request, headers, runtime)

    async def college_query_student_info_by_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByDeptHeaders()
        return await self.college_query_student_info_by_dept_with_options_async(request, headers, runtime)

    def college_query_student_info_by_mobile_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileHeaders()
        return self.college_query_student_info_by_mobile_with_options(request, headers, runtime)

    async def college_query_student_info_by_mobile_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByMobileHeaders()
        return await self.college_query_student_info_by_mobile_with_options_async(request, headers, runtime)

    def college_query_student_info_by_student_id_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdRequest,
        headers: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdHeaders()
        return self.college_query_student_info_by_student_id_with_options(request, headers, runtime)

    async def college_query_student_info_by_student_id_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdRequest,
    ) -> dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeQueryStudentInfoByStudentIdHeaders()
        return await self.college_query_student_info_by_student_id_with_options_async(request, headers, runtime)

    def college_remove_manager_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveManagerRequest,
        headers: dingtalkindustry__1__0_models.CollegeRemoveManagerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveManagerResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeRemoveManagerHeaders()
        return self.college_remove_manager_with_options(request, headers, runtime)

    async def college_remove_manager_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveManagerRequest,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveManagerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeRemoveManagerHeaders()
        return await self.college_remove_manager_with_options_async(request, headers, runtime)

    def college_remove_student_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveStudentRequest,
        headers: dingtalkindustry__1__0_models.CollegeRemoveStudentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveStudentResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeRemoveStudentHeaders()
        return self.college_remove_student_with_options(request, headers, runtime)

    async def college_remove_student_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeRemoveStudentRequest,
    ) -> dingtalkindustry__1__0_models.CollegeRemoveStudentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeRemoveStudentHeaders()
        return await self.college_remove_student_with_options_async(request, headers, runtime)

    def college_update_college_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptHeaders()
        return self.college_update_college_dept_with_options(request, headers, runtime)

    async def college_update_college_dept_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateCollegeDeptHeaders()
        return await self.college_update_college_dept_with_options_async(request, headers, runtime)

    def college_update_student_dept_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoHeaders()
        return self.college_update_student_dept_info_with_options(request, headers, runtime)

    async def college_update_student_dept_info_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentDeptInfoHeaders()
        return await self.college_update_student_dept_info_with_options_async(request, headers, runtime)

    def college_update_student_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentInfoRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateStudentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentInfoHeaders()
        return self.college_update_student_info_with_options(request, headers, runtime)

    async def college_update_student_info_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentInfoRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentInfoHeaders()
        return await self.college_update_student_info_with_options_async(request, headers, runtime)

    def college_update_student_moblie_with_options(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieRequest,
        headers: dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieHeaders()
        return self.college_update_student_moblie_with_options(request, headers, runtime)

    async def college_update_student_moblie_async(
        self,
        request: dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieRequest,
    ) -> dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CollegeUpdateStudentMoblieHeaders()
        return await self.college_update_student_moblie_with_options_async(request, headers, runtime)

    def customize_contact_create_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactCreateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactCreateResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactCreateHeaders()
        return self.customize_contact_create_with_options(request, headers, runtime)

    async def customize_contact_create_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactCreateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactCreateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactCreateHeaders()
        return await self.customize_contact_create_with_options_async(request, headers, runtime)

    def customize_contact_delete_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeleteRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeleteResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeleteHeaders()
        return self.customize_contact_delete_with_options(request, headers, runtime)

    async def customize_contact_delete_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeleteRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeleteResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeleteHeaders()
        return await self.customize_contact_delete_with_options_async(request, headers, runtime)

    def customize_contact_dept_create_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptCreateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptCreateResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptCreateHeaders()
        return self.customize_contact_dept_create_with_options(request, headers, runtime)

    async def customize_contact_dept_create_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptCreateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptCreateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptCreateHeaders()
        return await self.customize_contact_dept_create_with_options_async(request, headers, runtime)

    def customize_contact_dept_delete_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptDeleteRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptDeleteResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptDeleteHeaders()
        return self.customize_contact_dept_delete_with_options(request, headers, runtime)

    async def customize_contact_dept_delete_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptDeleteRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptDeleteResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptDeleteHeaders()
        return await self.customize_contact_dept_delete_with_options_async(request, headers, runtime)

    def customize_contact_dept_group_create_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateHeaders()
        return self.customize_contact_dept_group_create_with_options(request, headers, runtime)

    async def customize_contact_dept_group_create_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptGroupCreateHeaders()
        return await self.customize_contact_dept_group_create_with_options_async(request, headers, runtime)

    def customize_contact_dept_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptInfoHeaders()
        return self.customize_contact_dept_info_with_options(request, headers, runtime)

    async def customize_contact_dept_info_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptInfoHeaders()
        return await self.customize_contact_dept_info_with_options_async(request, headers, runtime)

    def customize_contact_dept_list_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptListRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptListResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptListHeaders()
        return self.customize_contact_dept_list_with_options(request, headers, runtime)

    async def customize_contact_dept_list_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptListRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptListHeaders()
        return await self.customize_contact_dept_list_with_options_async(request, headers, runtime)

    def customize_contact_dept_update_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptUpdateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactDeptUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptUpdateResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptUpdateHeaders()
        return self.customize_contact_dept_update_with_options(request, headers, runtime)

    async def customize_contact_dept_update_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactDeptUpdateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactDeptUpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactDeptUpdateHeaders()
        return await self.customize_contact_dept_update_with_options_async(request, headers, runtime)

    def customize_contact_emp_add_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpAddRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactEmpAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpAddResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpAddHeaders()
        return self.customize_contact_emp_add_with_options(request, headers, runtime)

    async def customize_contact_emp_add_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpAddRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpAddResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpAddHeaders()
        return await self.customize_contact_emp_add_with_options_async(request, headers, runtime)

    def customize_contact_emp_delete_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpDeleteRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactEmpDeleteHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpDeleteResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpDeleteHeaders()
        return self.customize_contact_emp_delete_with_options(request, headers, runtime)

    async def customize_contact_emp_delete_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpDeleteRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpDeleteResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpDeleteHeaders()
        return await self.customize_contact_emp_delete_with_options_async(request, headers, runtime)

    def customize_contact_emp_list_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpListRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactEmpListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpListResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpListHeaders()
        return self.customize_contact_emp_list_with_options(request, headers, runtime)

    async def customize_contact_emp_list_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactEmpListRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactEmpListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactEmpListHeaders()
        return await self.customize_contact_emp_list_with_options_async(request, headers, runtime)

    def customize_contact_list_with_options(
        self,
        headers: dingtalkindustry__1__0_models.CustomizeContactListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactListResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactListHeaders()
        return self.customize_contact_list_with_options(headers, runtime)

    async def customize_contact_list_async(self) -> dingtalkindustry__1__0_models.CustomizeContactListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactListHeaders()
        return await self.customize_contact_list_with_options_async(headers, runtime)

    def customize_contact_update_with_options(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactUpdateRequest,
        headers: dingtalkindustry__1__0_models.CustomizeContactUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.CustomizeContactUpdateResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactUpdateHeaders()
        return self.customize_contact_update_with_options(request, headers, runtime)

    async def customize_contact_update_async(
        self,
        request: dingtalkindustry__1__0_models.CustomizeContactUpdateRequest,
    ) -> dingtalkindustry__1__0_models.CustomizeContactUpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactUpdateHeaders()
        return await self.customize_contact_update_with_options_async(request, headers, runtime)

    def d_igital_store_message_push_with_options(
        self,
        tmp_req: dingtalkindustry__1__0_models.DIgitalStoreMessagePushRequest,
        headers: dingtalkindustry__1__0_models.DIgitalStoreMessagePushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DIgitalStoreMessagePushResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DIgitalStoreMessagePushHeaders()
        return self.d_igital_store_message_push_with_options(request, headers, runtime)

    async def d_igital_store_message_push_async(
        self,
        request: dingtalkindustry__1__0_models.DIgitalStoreMessagePushRequest,
    ) -> dingtalkindustry__1__0_models.DIgitalStoreMessagePushResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DIgitalStoreMessagePushHeaders()
        return await self.d_igital_store_message_push_with_options_async(request, headers, runtime)

    def digital_store_contact_info_with_options(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreContactInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreContactInfoHeaders()
        return self.digital_store_contact_info_with_options(headers, runtime)

    async def digital_store_contact_info_async(self) -> dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreContactInfoHeaders()
        return await self.digital_store_contact_info_with_options_async(headers, runtime)

    def digital_store_conversations_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreConversationsRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreConversationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreConversationsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreConversationsHeaders()
        return self.digital_store_conversations_with_options(request, headers, runtime)

    async def digital_store_conversations_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreConversationsRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreConversationsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreConversationsHeaders()
        return await self.digital_store_conversations_with_options_async(request, headers, runtime)

    def digital_store_group_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreGroupInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreGroupInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreGroupInfoHeaders()
        return self.digital_store_group_info_with_options(request, headers, runtime)

    async def digital_store_group_info_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreGroupInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreGroupInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreGroupInfoHeaders()
        return await self.digital_store_group_info_with_options_async(request, headers, runtime)

    def digital_store_groups_with_options(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreGroupsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreGroupsHeaders()
        return self.digital_store_groups_with_options(headers, runtime)

    async def digital_store_groups_async(self) -> dingtalkindustry__1__0_models.DigitalStoreGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreGroupsHeaders()
        return await self.digital_store_groups_with_options_async(headers, runtime)

    def digital_store_node_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreNodeInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreNodeInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreNodeInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreNodeInfoHeaders()
        return self.digital_store_node_info_with_options(request, headers, runtime)

    async def digital_store_node_info_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreNodeInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreNodeInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreNodeInfoHeaders()
        return await self.digital_store_node_info_with_options_async(request, headers, runtime)

    def digital_store_rights_info_with_options(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreRightsInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRightsInfoHeaders()
        return self.digital_store_rights_info_with_options(headers, runtime)

    async def digital_store_rights_info_async(self) -> dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRightsInfoHeaders()
        return await self.digital_store_rights_info_with_options_async(headers, runtime)

    def digital_store_roles_with_options(
        self,
        headers: dingtalkindustry__1__0_models.DigitalStoreRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreRolesResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRolesHeaders()
        return self.digital_store_roles_with_options(headers, runtime)

    async def digital_store_roles_async(self) -> dingtalkindustry__1__0_models.DigitalStoreRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRolesHeaders()
        return await self.digital_store_roles_with_options_async(headers, runtime)

    def digital_store_scene_scope_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSceneScopeRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreSceneScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSceneScopeResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreSceneScopeHeaders()
        return self.digital_store_scene_scope_with_options(request, headers, runtime)

    async def digital_store_scene_scope_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSceneScopeRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSceneScopeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreSceneScopeHeaders()
        return await self.digital_store_scene_scope_with_options_async(request, headers, runtime)

    def digital_store_store_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreStoreInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreStoreInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreStoreInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreStoreInfoHeaders()
        return self.digital_store_store_info_with_options(request, headers, runtime)

    async def digital_store_store_info_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreStoreInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreStoreInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreStoreInfoHeaders()
        return await self.digital_store_store_info_with_options_async(request, headers, runtime)

    def digital_store_sub_nodes_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSubNodesRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreSubNodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSubNodesResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreSubNodesHeaders()
        return self.digital_store_sub_nodes_with_options(request, headers, runtime)

    async def digital_store_sub_nodes_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreSubNodesRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreSubNodesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreSubNodesHeaders()
        return await self.digital_store_sub_nodes_with_options_async(request, headers, runtime)

    def digital_store_update_auth_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoHeaders()
        return self.digital_store_update_auth_info_with_options(request, headers, runtime)

    async def digital_store_update_auth_info_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUpdateAuthInfoHeaders()
        return await self.digital_store_update_auth_info_with_options_async(request, headers, runtime)

    def digital_store_user_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUserInfoRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUserInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUserInfoHeaders()
        return self.digital_store_user_info_with_options(request, headers, runtime)

    async def digital_store_user_info_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUserInfoRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUserInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUserInfoHeaders()
        return await self.digital_store_user_info_with_options_async(request, headers, runtime)

    def digital_store_users_with_options(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUsersRequest,
        headers: dingtalkindustry__1__0_models.DigitalStoreUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUsersResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUsersHeaders()
        return self.digital_store_users_with_options(request, headers, runtime)

    async def digital_store_users_async(
        self,
        request: dingtalkindustry__1__0_models.DigitalStoreUsersRequest,
    ) -> dingtalkindustry__1__0_models.DigitalStoreUsersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreUsersHeaders()
        return await self.digital_store_users_with_options_async(request, headers, runtime)

    def external_query_external_app_orgs_with_options(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsRequest,
        headers: dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsHeaders()
        return self.external_query_external_app_orgs_with_options(request, headers, runtime)

    async def external_query_external_app_orgs_async(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsRequest,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalAppOrgsHeaders()
        return await self.external_query_external_app_orgs_with_options_async(request, headers, runtime)

    def external_query_external_belong_main_org_with_options(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgRequest,
        headers: dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgHeaders()
        return self.external_query_external_belong_main_org_with_options(request, headers, runtime)

    async def external_query_external_belong_main_org_async(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgRequest,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalBelongMainOrgHeaders()
        return await self.external_query_external_belong_main_org_with_options_async(request, headers, runtime)

    def external_query_external_orgs_with_options(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalOrgsRequest,
        headers: dingtalkindustry__1__0_models.ExternalQueryExternalOrgsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalOrgsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalOrgsHeaders()
        return self.external_query_external_orgs_with_options(request, headers, runtime)

    async def external_query_external_orgs_async(
        self,
        request: dingtalkindustry__1__0_models.ExternalQueryExternalOrgsRequest,
    ) -> dingtalkindustry__1__0_models.ExternalQueryExternalOrgsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.ExternalQueryExternalOrgsHeaders()
        return await self.external_query_external_orgs_with_options_async(request, headers, runtime)

    def hospital_data_check_with_options(
        self,
        request: dingtalkindustry__1__0_models.HospitalDataCheckRequest,
        headers: dingtalkindustry__1__0_models.HospitalDataCheckHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.HospitalDataCheckResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.HospitalDataCheckHeaders()
        return self.hospital_data_check_with_options(request, headers, runtime)

    async def hospital_data_check_async(
        self,
        request: dingtalkindustry__1__0_models.HospitalDataCheckRequest,
    ) -> dingtalkindustry__1__0_models.HospitalDataCheckResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.HospitalDataCheckHeaders()
        return await self.hospital_data_check_with_options_async(request, headers, runtime)

    def industry_manufacture_common_event_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCommonEventRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureCommonEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCommonEventResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureCommonEventHeaders()
        return self.industry_manufacture_common_event_with_options(request, headers, runtime)

    async def industry_manufacture_common_event_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCommonEventRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCommonEventResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureCommonEventHeaders()
        return await self.industry_manufacture_common_event_with_options_async(request, headers, runtime)

    def industry_manufacture_cost_record_list_get_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetHeaders()
        return self.industry_manufacture_cost_record_list_get_with_options(request, headers, runtime)

    async def industry_manufacture_cost_record_list_get_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetHeaders()
        return await self.industry_manufacture_cost_record_list_get_with_options_async(request, headers, runtime)

    def industry_manufacture_fee_list_get_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureFeeListGetRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureFeeListGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureFeeListGetResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureFeeListGetHeaders()
        return self.industry_manufacture_fee_list_get_with_options(request, headers, runtime)

    async def industry_manufacture_fee_list_get_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureFeeListGetRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureFeeListGetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureFeeListGetHeaders()
        return await self.industry_manufacture_fee_list_get_with_options_async(request, headers, runtime)

    def industry_manufacture_labour_cost_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureLabourCostRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureLabourCostHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureLabourCostResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureLabourCostHeaders()
        return self.industry_manufacture_labour_cost_with_options(request, headers, runtime)

    async def industry_manufacture_labour_cost_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureLabourCostRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureLabourCostResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureLabourCostHeaders()
        return await self.industry_manufacture_labour_cost_with_options_async(request, headers, runtime)

    def industry_manufacture_material_list_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMaterialListRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMaterialListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMaterialListResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMaterialListHeaders()
        return self.industry_manufacture_material_list_with_options(request, headers, runtime)

    async def industry_manufacture_material_list_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMaterialListRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMaterialListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMaterialListHeaders()
        return await self.industry_manufacture_material_list_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_dispatch_task_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskHeaders()
        return self.industry_manufacture_mes_dispatch_task_with_options(request, headers, runtime)

    async def industry_manufacture_mes_dispatch_task_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesDispatchTaskHeaders()
        return await self.industry_manufacture_mes_dispatch_task_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_material_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesMaterialRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesMaterialHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesMaterialResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesMaterialHeaders()
        return self.industry_manufacture_mes_material_with_options(request, headers, runtime)

    async def industry_manufacture_mes_material_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesMaterialRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesMaterialResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesMaterialHeaders()
        return await self.industry_manufacture_mes_material_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_out_plan_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanHeaders()
        return self.industry_manufacture_mes_out_plan_with_options(request, headers, runtime)

    async def industry_manufacture_mes_out_plan_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesOutPlanHeaders()
        return await self.industry_manufacture_mes_out_plan_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_output_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutputRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesOutputHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutputResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesOutputHeaders()
        return self.industry_manufacture_mes_output_with_options(request, headers, runtime)

    async def industry_manufacture_mes_output_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesOutputRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesOutputResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesOutputHeaders()
        return await self.industry_manufacture_mes_output_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_process_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProcessRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesProcessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProcessResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesProcessHeaders()
        return self.industry_manufacture_mes_process_with_options(request, headers, runtime)

    async def industry_manufacture_mes_process_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProcessRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProcessResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesProcessHeaders()
        return await self.industry_manufacture_mes_process_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_production_plan_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanHeaders()
        return self.industry_manufacture_mes_production_plan_with_options(request, headers, runtime)

    async def industry_manufacture_mes_production_plan_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesProductionPlanHeaders()
        return await self.industry_manufacture_mes_production_plan_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_sub_cooperation_team_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamHeaders()
        return self.industry_manufacture_mes_sub_cooperation_team_with_options(request, headers, runtime)

    async def industry_manufacture_mes_sub_cooperation_team_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesSubCooperationTeamHeaders()
        return await self.industry_manufacture_mes_sub_cooperation_team_with_options_async(request, headers, runtime)

    def industry_manufacture_mes_team_mgmt_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtRequest,
        headers: dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtHeaders()
        return self.industry_manufacture_mes_team_mgmt_with_options(request, headers, runtime)

    async def industry_manufacture_mes_team_mgmt_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtRequest,
    ) -> dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtHeaders()
        return await self.industry_manufacture_mes_team_mgmt_with_options_async(request, headers, runtime)

    def industry_mmanufacture_material_cost_get_with_options(
        self,
        request: dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetRequest,
        headers: dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetHeaders()
        return self.industry_mmanufacture_material_cost_get_with_options(request, headers, runtime)

    async def industry_mmanufacture_material_cost_get_async(
        self,
        request: dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetRequest,
    ) -> dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetHeaders()
        return await self.industry_mmanufacture_material_cost_get_with_options_async(request, headers, runtime)

    def push_ding_message_with_options(
        self,
        request: dingtalkindustry__1__0_models.PushDingMessageRequest,
        headers: dingtalkindustry__1__0_models.PushDingMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.PushDingMessageResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.PushDingMessageHeaders()
        return self.push_ding_message_with_options(request, headers, runtime)

    async def push_ding_message_async(
        self,
        request: dingtalkindustry__1__0_models.PushDingMessageRequest,
    ) -> dingtalkindustry__1__0_models.PushDingMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.PushDingMessageHeaders()
        return await self.push_ding_message_with_options_async(request, headers, runtime)

    def query_all_department_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDepartmentRequest,
        headers: dingtalkindustry__1__0_models.QueryAllDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllDepartmentResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllDepartmentHeaders()
        return self.query_all_department_with_options(request, headers, runtime)

    async def query_all_department_async(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDepartmentRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllDepartmentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllDepartmentHeaders()
        return await self.query_all_department_with_options_async(request, headers, runtime)

    def query_all_doctors_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDoctorsRequest,
        headers: dingtalkindustry__1__0_models.QueryAllDoctorsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllDoctorsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllDoctorsHeaders()
        return self.query_all_doctors_with_options(request, headers, runtime)

    async def query_all_doctors_async(
        self,
        request: dingtalkindustry__1__0_models.QueryAllDoctorsRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllDoctorsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllDoctorsHeaders()
        return await self.query_all_doctors_with_options_async(request, headers, runtime)

    def query_all_group_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryAllGroupRequest,
        headers: dingtalkindustry__1__0_models.QueryAllGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllGroupHeaders()
        return self.query_all_group_with_options(request, headers, runtime)

    async def query_all_group_async(
        self,
        request: dingtalkindustry__1__0_models.QueryAllGroupRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllGroupsInDeptHeaders()
        return self.query_all_groups_in_dept_with_options(dept_id, request, headers, runtime)

    async def query_all_groups_in_dept_async(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllGroupsInDeptRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupsInDeptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllMemberByDeptHeaders()
        return self.query_all_member_by_dept_with_options(dept_id, request, headers, runtime)

    async def query_all_member_by_dept_async(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByDeptRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByDeptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllMemberByGroupHeaders()
        return self.query_all_member_by_group_with_options(group_id, request, headers, runtime)

    async def query_all_member_by_group_async(
        self,
        group_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByGroupRequest,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryAllMemberByGroupHeaders()
        return await self.query_all_member_by_group_with_options_async(group_id, request, headers, runtime)

    def query_biz_opt_log_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryBizOptLogRequest,
        headers: dingtalkindustry__1__0_models.QueryBizOptLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryBizOptLogResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryBizOptLogHeaders()
        return self.query_biz_opt_log_with_options(request, headers, runtime)

    async def query_biz_opt_log_async(
        self,
        request: dingtalkindustry__1__0_models.QueryBizOptLogRequest,
    ) -> dingtalkindustry__1__0_models.QueryBizOptLogResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryBizOptLogHeaders()
        return await self.query_biz_opt_log_with_options_async(request, headers, runtime)

    def query_department_extend_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryDepartmentExtendInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryDepartmentExtendInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentExtendInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryDepartmentExtendInfoHeaders()
        return self.query_department_extend_info_with_options(request, headers, runtime)

    async def query_department_extend_info_async(
        self,
        request: dingtalkindustry__1__0_models.QueryDepartmentExtendInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentExtendInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryDepartmentExtendInfoHeaders()
        return await self.query_department_extend_info_with_options_async(request, headers, runtime)

    def query_department_info_with_options(
        self,
        dept_id: str,
        headers: dingtalkindustry__1__0_models.QueryDepartmentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryDepartmentInfoHeaders()
        return self.query_department_info_with_options(dept_id, headers, runtime)

    async def query_department_info_async(
        self,
        dept_id: str,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberHeaders()
        return self.query_doctor_details_by_job_number_with_options(job_number, request, headers, runtime)

    async def query_doctor_details_by_job_number_async(
        self,
        job_number: str,
        request: dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberRequest,
    ) -> dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryDoctorDetailsByJobNumberHeaders()
        return await self.query_doctor_details_by_job_number_with_options_async(job_number, request, headers, runtime)

    def query_group_info_with_options(
        self,
        group_id: str,
        headers: dingtalkindustry__1__0_models.QueryGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryGroupInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryGroupInfoHeaders()
        return self.query_group_info_with_options(group_id, headers, runtime)

    async def query_group_info_async(
        self,
        group_id: str,
    ) -> dingtalkindustry__1__0_models.QueryGroupInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryGroupInfoHeaders()
        return await self.query_group_info_with_options_async(group_id, headers, runtime)

    def query_hospital_district_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalDistrictInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryHospitalDistrictInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryHospitalDistrictInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalDistrictInfoHeaders()
        return self.query_hospital_district_info_with_options(request, headers, runtime)

    async def query_hospital_district_info_async(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalDistrictInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryHospitalDistrictInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalDistrictInfoHeaders()
        return await self.query_hospital_district_info_with_options_async(request, headers, runtime)

    def query_hospital_role_user_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoRequest,
        headers: dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoHeaders()
        return self.query_hospital_role_user_info_with_options(request, headers, runtime)

    async def query_hospital_role_user_info_async(
        self,
        request: dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoHeaders()
        return await self.query_hospital_role_user_info_with_options_async(request, headers, runtime)

    def query_hospital_roles_with_options(
        self,
        headers: dingtalkindustry__1__0_models.QueryHospitalRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryHospitalRolesResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalRolesHeaders()
        return self.query_hospital_roles_with_options(headers, runtime)

    async def query_hospital_roles_async(self) -> dingtalkindustry__1__0_models.QueryHospitalRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalRolesHeaders()
        return await self.query_hospital_roles_with_options_async(headers, runtime)

    def query_job_code_dictionary_with_options(
        self,
        headers: dingtalkindustry__1__0_models.QueryJobCodeDictionaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobCodeDictionaryHeaders()
        return self.query_job_code_dictionary_with_options(headers, runtime)

    async def query_job_code_dictionary_async(self) -> dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobCodeDictionaryHeaders()
        return await self.query_job_code_dictionary_with_options_async(headers, runtime)

    def query_job_status_code_dictionary_with_options(
        self,
        headers: dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryHeaders()
        return self.query_job_status_code_dictionary_with_options(headers, runtime)

    async def query_job_status_code_dictionary_async(self) -> dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryHeaders()
        return await self.query_job_status_code_dictionary_with_options_async(headers, runtime)

    def query_medical_events_with_options(
        self,
        headers: dingtalkindustry__1__0_models.QueryMedicalEventsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryMedicalEventsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryMedicalEventsHeaders()
        return self.query_medical_events_with_options(headers, runtime)

    async def query_medical_events_async(self) -> dingtalkindustry__1__0_models.QueryMedicalEventsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryMedicalEventsHeaders()
        return await self.query_medical_events_with_options_async(headers, runtime)

    def query_user_credentials_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryUserCredentialsRequest,
        headers: dingtalkindustry__1__0_models.QueryUserCredentialsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserCredentialsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserCredentialsHeaders()
        return self.query_user_credentials_with_options(request, headers, runtime)

    async def query_user_credentials_async(
        self,
        request: dingtalkindustry__1__0_models.QueryUserCredentialsRequest,
    ) -> dingtalkindustry__1__0_models.QueryUserCredentialsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserCredentialsHeaders()
        return await self.query_user_credentials_with_options_async(request, headers, runtime)

    def query_user_ext_info_with_options(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserExtInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserExtInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserExtInfoHeaders()
        return self.query_user_ext_info_with_options(user_id, headers, runtime)

    async def query_user_ext_info_async(
        self,
        user_id: str,
    ) -> dingtalkindustry__1__0_models.QueryUserExtInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserExtInfoHeaders()
        return await self.query_user_ext_info_with_options_async(user_id, headers, runtime)

    def query_user_extend_values_with_options(
        self,
        request: dingtalkindustry__1__0_models.QueryUserExtendValuesRequest,
        headers: dingtalkindustry__1__0_models.QueryUserExtendValuesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserExtendValuesResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserExtendValuesHeaders()
        return self.query_user_extend_values_with_options(request, headers, runtime)

    async def query_user_extend_values_async(
        self,
        request: dingtalkindustry__1__0_models.QueryUserExtendValuesRequest,
    ) -> dingtalkindustry__1__0_models.QueryUserExtendValuesResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserInfoHeaders()
        return self.query_user_info_with_options(user_id, request, headers, runtime)

    async def query_user_info_async(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.QueryUserInfoRequest,
    ) -> dingtalkindustry__1__0_models.QueryUserInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserInfoHeaders()
        return await self.query_user_info_with_options_async(user_id, request, headers, runtime)

    def query_user_prob_code_dictionary_with_options(
        self,
        headers: dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryHeaders()
        return self.query_user_prob_code_dictionary_with_options(headers, runtime)

    async def query_user_prob_code_dictionary_async(self) -> dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryHeaders()
        return await self.query_user_prob_code_dictionary_with_options_async(headers, runtime)

    def query_user_roles_with_options(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserRolesResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserRolesHeaders()
        return self.query_user_roles_with_options(user_id, headers, runtime)

    async def query_user_roles_async(
        self,
        user_id: str,
    ) -> dingtalkindustry__1__0_models.QueryUserRolesResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SaveUserExtendValuesHeaders()
        return self.save_user_extend_values_with_options(user_id, request, headers, runtime)

    async def save_user_extend_values_async(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.SaveUserExtendValuesRequest,
    ) -> dingtalkindustry__1__0_models.SaveUserExtendValuesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SaveUserExtendValuesHeaders()
        return await self.save_user_extend_values_with_options_async(user_id, request, headers, runtime)

    def suppl_add_role_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplAddRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplAddRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplAddRoleResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplAddRoleHeaders()
        return self.suppl_add_role_with_options(request, headers, runtime)

    async def suppl_add_role_async(
        self,
        request: dingtalkindustry__1__0_models.SupplAddRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplAddRoleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplAddRoleHeaders()
        return await self.suppl_add_role_with_options_async(request, headers, runtime)

    def supply_add_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddDeptRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddDeptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddDeptHeaders()
        return self.supply_add_dept_with_options(request, headers, runtime)

    async def supply_add_dept_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddDeptRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddDeptHeaders()
        return await self.supply_add_dept_with_options_async(request, headers, runtime)

    def supply_add_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddMemberResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddMemberHeaders()
        return self.supply_add_member_with_options(request, headers, runtime)

    async def supply_add_member_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddMemberHeaders()
        return await self.supply_add_member_with_options_async(request, headers, runtime)

    def supply_add_partner_admins_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerAdminsRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddPartnerAdminsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerAdminsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerAdminsHeaders()
        return self.supply_add_partner_admins_with_options(request, headers, runtime)

    async def supply_add_partner_admins_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerAdminsRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerAdminsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerAdminsHeaders()
        return await self.supply_add_partner_admins_with_options_async(request, headers, runtime)

    def supply_add_partner_managers_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerManagersRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddPartnerManagersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerManagersResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerManagersHeaders()
        return self.supply_add_partner_managers_with_options(request, headers, runtime)

    async def supply_add_partner_managers_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerManagersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerManagersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerManagersHeaders()
        return await self.supply_add_partner_managers_with_options_async(request, headers, runtime)

    def supply_add_partner_type_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyAddPartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerTypeResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerTypeHeaders()
        return self.supply_add_partner_type_with_options(request, headers, runtime)

    async def supply_add_partner_type_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyAddPartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyAddPartnerTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyAddPartnerTypeHeaders()
        return await self.supply_add_partner_type_with_options_async(request, headers, runtime)

    def supply_chain_delete_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainDeleteDeptRequest,
        headers: dingtalkindustry__1__0_models.SupplyChainDeleteDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyChainDeleteDeptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainDeleteDeptHeaders()
        return self.supply_chain_delete_dept_with_options(request, headers, runtime)

    async def supply_chain_delete_dept_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainDeleteDeptRequest,
    ) -> dingtalkindustry__1__0_models.SupplyChainDeleteDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainDeleteDeptHeaders()
        return await self.supply_chain_delete_dept_with_options_async(request, headers, runtime)

    def supply_chain_query_dept_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoHeaders()
        return self.supply_chain_query_dept_info_with_options(request, headers, runtime)

    async def supply_chain_query_dept_info_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainQueryDeptInfoHeaders()
        return await self.supply_chain_query_dept_info_with_options_async(request, headers, runtime)

    def supply_chain_update_dept_info_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoRequest,
        headers: dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoHeaders()
        return self.supply_chain_update_dept_info_with_options(request, headers, runtime)

    async def supply_chain_update_dept_info_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoRequest,
    ) -> dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyChainUpdateDeptInfoHeaders()
        return await self.supply_chain_update_dept_info_with_options_async(request, headers, runtime)

    def supply_delete_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeleteMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteMemberResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeleteMemberHeaders()
        return self.supply_delete_member_with_options(request, headers, runtime)

    async def supply_delete_member_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeleteMemberHeaders()
        return await self.supply_delete_member_with_options_async(request, headers, runtime)

    def supply_delete_partner_admins_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsHeaders()
        return self.supply_delete_partner_admins_with_options(request, headers, runtime)

    async def supply_delete_partner_admins_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerAdminsHeaders()
        return await self.supply_delete_partner_admins_with_options_async(request, headers, runtime)

    def supply_delete_partner_managers_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerManagersRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeletePartnerManagersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerManagersResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerManagersHeaders()
        return self.supply_delete_partner_managers_with_options(request, headers, runtime)

    async def supply_delete_partner_managers_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerManagersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerManagersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerManagersHeaders()
        return await self.supply_delete_partner_managers_with_options_async(request, headers, runtime)

    def supply_delete_partner_type_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeletePartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerTypeResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerTypeHeaders()
        return self.supply_delete_partner_type_with_options(request, headers, runtime)

    async def supply_delete_partner_type_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeletePartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeletePartnerTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeletePartnerTypeHeaders()
        return await self.supply_delete_partner_type_with_options_async(request, headers, runtime)

    def supply_delete_role_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplyDeleteRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteRoleResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeleteRoleHeaders()
        return self.supply_delete_role_with_options(request, headers, runtime)

    async def supply_delete_role_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyDeleteRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplyDeleteRoleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyDeleteRoleHeaders()
        return await self.supply_delete_role_with_options_async(request, headers, runtime)

    def supply_get_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyGetMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyGetMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyGetMemberResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyGetMemberHeaders()
        return self.supply_get_member_with_options(request, headers, runtime)

    async def supply_get_member_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyGetMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyGetMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyGetMemberHeaders()
        return await self.supply_get_member_with_options_async(request, headers, runtime)

    def supply_list_dept_members_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListDeptMembersRequest,
        headers: dingtalkindustry__1__0_models.SupplyListDeptMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListDeptMembersResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListDeptMembersHeaders()
        return self.supply_list_dept_members_with_options(request, headers, runtime)

    async def supply_list_dept_members_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListDeptMembersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListDeptMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListDeptMembersHeaders()
        return await self.supply_list_dept_members_with_options_async(request, headers, runtime)

    def supply_list_partner_admins_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerAdminsRequest,
        headers: dingtalkindustry__1__0_models.SupplyListPartnerAdminsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerAdminsResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerAdminsHeaders()
        return self.supply_list_partner_admins_with_options(request, headers, runtime)

    async def supply_list_partner_admins_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerAdminsRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerAdminsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerAdminsHeaders()
        return await self.supply_list_partner_admins_with_options_async(request, headers, runtime)

    def supply_list_partner_managers_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerManagersRequest,
        headers: dingtalkindustry__1__0_models.SupplyListPartnerManagersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerManagersResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerManagersHeaders()
        return self.supply_list_partner_managers_with_options(request, headers, runtime)

    async def supply_list_partner_managers_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerManagersRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerManagersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerManagersHeaders()
        return await self.supply_list_partner_managers_with_options_async(request, headers, runtime)

    def supply_list_partner_type_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyListPartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerTypeResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerTypeHeaders()
        return self.supply_list_partner_type_with_options(request, headers, runtime)

    async def supply_list_partner_type_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListPartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListPartnerTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListPartnerTypeHeaders()
        return await self.supply_list_partner_type_with_options_async(request, headers, runtime)

    def supply_list_role_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplyListRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListRoleResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListRoleHeaders()
        return self.supply_list_role_with_options(request, headers, runtime)

    async def supply_list_role_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListRoleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListRoleHeaders()
        return await self.supply_list_role_with_options_async(request, headers, runtime)

    def supply_list_sub_dept_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyListSubDeptRequest,
        headers: dingtalkindustry__1__0_models.SupplyListSubDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyListSubDeptResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListSubDeptHeaders()
        return self.supply_list_sub_dept_with_options(request, headers, runtime)

    async def supply_list_sub_dept_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyListSubDeptRequest,
    ) -> dingtalkindustry__1__0_models.SupplyListSubDeptResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyListSubDeptHeaders()
        return await self.supply_list_sub_dept_with_options_async(request, headers, runtime)

    def supply_query_partner_type_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyQueryPartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyQueryPartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyQueryPartnerTypeResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyQueryPartnerTypeHeaders()
        return self.supply_query_partner_type_with_options(request, headers, runtime)

    async def supply_query_partner_type_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyQueryPartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyQueryPartnerTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyQueryPartnerTypeHeaders()
        return await self.supply_query_partner_type_with_options_async(request, headers, runtime)

    def supply_update_member_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateMemberRequest,
        headers: dingtalkindustry__1__0_models.SupplyUpdateMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateMemberResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyUpdateMemberHeaders()
        return self.supply_update_member_with_options(request, headers, runtime)

    async def supply_update_member_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateMemberRequest,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyUpdateMemberHeaders()
        return await self.supply_update_member_with_options_async(request, headers, runtime)

    def supply_update_partner_type_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeRequest,
        headers: dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeHeaders()
        return self.supply_update_partner_type_with_options(request, headers, runtime)

    async def supply_update_partner_type_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeRequest,
    ) -> dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyUpdatePartnerTypeHeaders()
        return await self.supply_update_partner_type_with_options_async(request, headers, runtime)

    def supply_update_role_with_options(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateRoleRequest,
        headers: dingtalkindustry__1__0_models.SupplyUpdateRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateRoleResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.SupplyUpdateRoleHeaders()
        return self.supply_update_role_with_options(request, headers, runtime)

    async def supply_update_role_async(
        self,
        request: dingtalkindustry__1__0_models.SupplyUpdateRoleRequest,
    ) -> dingtalkindustry__1__0_models.SupplyUpdateRoleResponse:
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
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.UpdateUserExtendInfoHeaders()
        return self.update_user_extend_info_with_options(user_id, request, headers, runtime)

    async def update_user_extend_info_async(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.UpdateUserExtendInfoRequest,
    ) -> dingtalkindustry__1__0_models.UpdateUserExtendInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.UpdateUserExtendInfoHeaders()
        return await self.update_user_extend_info_with_options_async(user_id, request, headers, runtime)
