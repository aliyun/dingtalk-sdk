# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusAddRenterMemberResponse(),
            self.do_roarequest('CampusAddRenterMember', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/campuses/renters/members', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusAddRenterMemberResponse(),
            await self.do_roarequest_async('CampusAddRenterMember', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/campuses/renters/members', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateCampusResponse(),
            self.do_roarequest('CampusCreateCampus', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/campuses/projects', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateCampusResponse(),
            await self.do_roarequest_async('CampusCreateCampus', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/campuses/projects', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateCampusGroupResponse(),
            self.do_roarequest('CampusCreateCampusGroup', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/campuses/projects/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateCampusGroupResponse(),
            await self.do_roarequest_async('CampusCreateCampusGroup', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/campuses/projects/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateRenterResponse(),
            self.do_roarequest('CampusCreateRenter', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/campuses/renters', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusCreateRenterResponse(),
            await self.do_roarequest_async('CampusCreateRenter', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/campuses/renters', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDelRenterMemberResponse(),
            self.do_roarequest('CampusDelRenterMember', 'industry_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/industry/campuses/renters/members', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDelRenterMemberResponse(),
            await self.do_roarequest_async('CampusDelRenterMember', 'industry_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/industry/campuses/renters/members', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDeleteCampusGroupResponse(),
            self.do_roarequest('CampusDeleteCampusGroup', 'industry_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/industry/campuses/projects/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDeleteCampusGroupResponse(),
            await self.do_roarequest_async('CampusDeleteCampusGroup', 'industry_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/industry/campuses/projects/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDeleteRenterResponse(),
            self.do_roarequest('CampusDeleteRenter', 'industry_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/industry/campuses/renters', 'none', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusDeleteRenterResponse(),
            await self.do_roarequest_async('CampusDeleteRenter', 'industry_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/industry/campuses/renters', 'none', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetCampusResponse(),
            self.do_roarequest('CampusGetCampus', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/projectInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetCampusResponse(),
            await self.do_roarequest_async('CampusGetCampus', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/projectInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetCampusGroupResponse(),
            self.do_roarequest('CampusGetCampusGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/projects/groupInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetCampusGroupResponse(),
            await self.do_roarequest_async('CampusGetCampusGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/projects/groupInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetRenterResponse(),
            self.do_roarequest('CampusGetRenter', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/renterInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetRenterResponse(),
            await self.do_roarequest_async('CampusGetRenter', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/renterInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetRenterMemberResponse(),
            self.do_roarequest('CampusGetRenterMember', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/renters/memberInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusGetRenterMemberResponse(),
            await self.do_roarequest_async('CampusGetRenterMember', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/renters/memberInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListCampusResponse(),
            self.do_roarequest('CampusListCampus', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/projects', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListCampusResponse(),
            await self.do_roarequest_async('CampusListCampus', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/projects', 'json', req, runtime)
        )

    def campus_list_campus_group(self) -> dingtalkindustry__1__0_models.CampusListCampusGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListCampusGroupHeaders()
        return self.campus_list_campus_group_with_options(headers, runtime)

    async def campus_list_campus_group_async(self) -> dingtalkindustry__1__0_models.CampusListCampusGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListCampusGroupHeaders()
        return await self.campus_list_campus_group_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListCampusGroupResponse(),
            self.do_roarequest('CampusListCampusGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/projects/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListCampusGroupResponse(),
            await self.do_roarequest_async('CampusListCampusGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/projects/groups', 'json', req, runtime)
        )

    def campus_list_renter(self) -> dingtalkindustry__1__0_models.CampusListRenterResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListRenterHeaders()
        return self.campus_list_renter_with_options(headers, runtime)

    async def campus_list_renter_async(self) -> dingtalkindustry__1__0_models.CampusListRenterResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CampusListRenterHeaders()
        return await self.campus_list_renter_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListRenterResponse(),
            self.do_roarequest('CampusListRenter', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/renters', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListRenterResponse(),
            await self.do_roarequest_async('CampusListRenter', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/renters', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListRenterMembersResponse(),
            self.do_roarequest('CampusListRenterMembers', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/renters/members', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusListRenterMembersResponse(),
            await self.do_roarequest_async('CampusListRenterMembers', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/campuses/renters/members', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateCampusResponse(),
            self.do_roarequest('CampusUpdateCampus', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/campuses/projects', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateCampusResponse(),
            await self.do_roarequest_async('CampusUpdateCampus', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/campuses/projects', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateCampusGroupResponse(),
            self.do_roarequest('CampusUpdateCampusGroup', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/campuses/projects/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateCampusGroupResponse(),
            await self.do_roarequest_async('CampusUpdateCampusGroup', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/campuses/projects/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateRenterResponse(),
            self.do_roarequest('CampusUpdateRenter', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/campuses/renters', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateRenterResponse(),
            await self.do_roarequest_async('CampusUpdateRenter', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/campuses/renters', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateRenterMemberResponse(),
            self.do_roarequest('CampusUpdateRenterMember', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/campuses/renters/members', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CampusUpdateRenterMemberResponse(),
            await self.do_roarequest_async('CampusUpdateRenterMember', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/campuses/renters/members', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactCreateResponse(),
            self.do_roarequest('CustomizeContactCreate', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/customizations/contacts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactCreateResponse(),
            await self.do_roarequest_async('CustomizeContactCreate', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/customizations/contacts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeleteResponse(),
            self.do_roarequest('CustomizeContactDelete', 'industry_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/industry/customizations/contacts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeleteResponse(),
            await self.do_roarequest_async('CustomizeContactDelete', 'industry_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/industry/customizations/contacts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptCreateResponse(),
            self.do_roarequest('CustomizeContactDeptCreate', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/customizations/departments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptCreateResponse(),
            await self.do_roarequest_async('CustomizeContactDeptCreate', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/customizations/departments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptDeleteResponse(),
            self.do_roarequest('CustomizeContactDeptDelete', 'industry_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/industry/customizations/departments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptDeleteResponse(),
            await self.do_roarequest_async('CustomizeContactDeptDelete', 'industry_1.0', 'HTTP', 'DELETE', 'AK', f'/v1.0/industry/customizations/departments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptInfoResponse(),
            self.do_roarequest('CustomizeContactDeptInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/customizations/departments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptInfoResponse(),
            await self.do_roarequest_async('CustomizeContactDeptInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/customizations/departments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptListResponse(),
            self.do_roarequest('CustomizeContactDeptList', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/customizations/subsidiaryDepartments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptListResponse(),
            await self.do_roarequest_async('CustomizeContactDeptList', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/customizations/subsidiaryDepartments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptUpdateResponse(),
            self.do_roarequest('CustomizeContactDeptUpdate', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/customizations/departments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactDeptUpdateResponse(),
            await self.do_roarequest_async('CustomizeContactDeptUpdate', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/customizations/departments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpAddResponse(),
            self.do_roarequest('CustomizeContactEmpAdd', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/customizations/users', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpAddResponse(),
            await self.do_roarequest_async('CustomizeContactEmpAdd', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/customizations/users', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpDeleteResponse(),
            self.do_roarequest('CustomizeContactEmpDelete', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/customizations/users/remove', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpDeleteResponse(),
            await self.do_roarequest_async('CustomizeContactEmpDelete', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/customizations/users/remove', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpListResponse(),
            self.do_roarequest('CustomizeContactEmpList', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/customizations/users', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactEmpListResponse(),
            await self.do_roarequest_async('CustomizeContactEmpList', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/customizations/users', 'json', req, runtime)
        )

    def customize_contact_list(self) -> dingtalkindustry__1__0_models.CustomizeContactListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactListHeaders()
        return self.customize_contact_list_with_options(headers, runtime)

    async def customize_contact_list_async(self) -> dingtalkindustry__1__0_models.CustomizeContactListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.CustomizeContactListHeaders()
        return await self.customize_contact_list_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactListResponse(),
            self.do_roarequest('CustomizeContactList', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/customizations/contacts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactListResponse(),
            await self.do_roarequest_async('CustomizeContactList', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/customizations/contacts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactUpdateResponse(),
            self.do_roarequest('CustomizeContactUpdate', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/customizations/contacts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.CustomizeContactUpdateResponse(),
            await self.do_roarequest_async('CustomizeContactUpdate', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/customizations/contacts', 'json', req, runtime)
        )

    def digital_store_contact_info(self) -> dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreContactInfoHeaders()
        return self.digital_store_contact_info_with_options(headers, runtime)

    async def digital_store_contact_info_async(self) -> dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreContactInfoHeaders()
        return await self.digital_store_contact_info_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse(),
            self.do_roarequest('DigitalStoreContactInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/contactInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreContactInfoResponse(),
            await self.do_roarequest_async('DigitalStoreContactInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/contactInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreGroupInfoResponse(),
            self.do_roarequest('DigitalStoreGroupInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/groupInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreGroupInfoResponse(),
            await self.do_roarequest_async('DigitalStoreGroupInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/groupInfos', 'json', req, runtime)
        )

    def digital_store_groups(self) -> dingtalkindustry__1__0_models.DigitalStoreGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreGroupsHeaders()
        return self.digital_store_groups_with_options(headers, runtime)

    async def digital_store_groups_async(self) -> dingtalkindustry__1__0_models.DigitalStoreGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreGroupsHeaders()
        return await self.digital_store_groups_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreGroupsResponse(),
            self.do_roarequest('DigitalStoreGroups', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreGroupsResponse(),
            await self.do_roarequest_async('DigitalStoreGroups', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreNodeInfoResponse(),
            self.do_roarequest('DigitalStoreNodeInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/nodeInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreNodeInfoResponse(),
            await self.do_roarequest_async('DigitalStoreNodeInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/nodeInfos', 'json', req, runtime)
        )

    def digital_store_rights_info(self) -> dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRightsInfoHeaders()
        return self.digital_store_rights_info_with_options(headers, runtime)

    async def digital_store_rights_info_async(self) -> dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRightsInfoHeaders()
        return await self.digital_store_rights_info_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse(),
            self.do_roarequest('DigitalStoreRightsInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/rightsInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreRightsInfoResponse(),
            await self.do_roarequest_async('DigitalStoreRightsInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/rightsInfos', 'json', req, runtime)
        )

    def digital_store_roles(self) -> dingtalkindustry__1__0_models.DigitalStoreRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRolesHeaders()
        return self.digital_store_roles_with_options(headers, runtime)

    async def digital_store_roles_async(self) -> dingtalkindustry__1__0_models.DigitalStoreRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.DigitalStoreRolesHeaders()
        return await self.digital_store_roles_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreRolesResponse(),
            self.do_roarequest('DigitalStoreRoles', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/roles', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreRolesResponse(),
            await self.do_roarequest_async('DigitalStoreRoles', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/roles', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreStoreInfoResponse(),
            self.do_roarequest('DigitalStoreStoreInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/storeInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreStoreInfoResponse(),
            await self.do_roarequest_async('DigitalStoreStoreInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/storeInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreSubNodesResponse(),
            self.do_roarequest('DigitalStoreSubNodes', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/subsidiaryNodes', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreSubNodesResponse(),
            await self.do_roarequest_async('DigitalStoreSubNodes', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/subsidiaryNodes', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreUserInfoResponse(),
            self.do_roarequest('DigitalStoreUserInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/userInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreUserInfoResponse(),
            await self.do_roarequest_async('DigitalStoreUserInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/userInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreUsersResponse(),
            self.do_roarequest('DigitalStoreUsers', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/nodes/users', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.DigitalStoreUsersResponse(),
            await self.do_roarequest_async('DigitalStoreUsers', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/digitalStores/nodes/users', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureCommonEventResponse(),
            self.do_roarequest('IndustryManufactureCommonEvent', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufacturing/bases/commons/events', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureCommonEventResponse(),
            await self.do_roarequest_async('IndustryManufactureCommonEvent', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufacturing/bases/commons/events', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetResponse(),
            self.do_roarequest('IndustryManufactureCostRecordListGet', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufactures/materialCostRecords/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureCostRecordListGetResponse(),
            await self.do_roarequest_async('IndustryManufactureCostRecordListGet', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufactures/materialCostRecords/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureFeeListGetResponse(),
            self.do_roarequest('IndustryManufactureFeeListGet', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufactures/fees/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureFeeListGetResponse(),
            await self.do_roarequest_async('IndustryManufactureFeeListGet', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufactures/fees/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureLabourCostResponse(),
            self.do_roarequest('IndustryManufactureLabourCost', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufactures/labourCosts/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureLabourCostResponse(),
            await self.do_roarequest_async('IndustryManufactureLabourCost', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufactures/labourCosts/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMaterialListResponse(),
            self.do_roarequest('IndustryManufactureMaterialList', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufactures/materials/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMaterialListResponse(),
            await self.do_roarequest_async('IndustryManufactureMaterialList', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufactures/materials/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtResponse(),
            self.do_roarequest('IndustryManufactureMesTeamMgmt', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufacturing/base/data/team', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryManufactureMesTeamMgmtResponse(),
            await self.do_roarequest_async('IndustryManufactureMesTeamMgmt', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufacturing/base/data/team', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetResponse(),
            self.do_roarequest('IndustryMmanufactureMaterialCostGet', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufactures/base/materialCosts/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.IndustryMmanufactureMaterialCostGetResponse(),
            await self.do_roarequest_async('IndustryMmanufactureMaterialCostGet', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/manufactures/base/materialCosts/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.PushDingMessageResponse(),
            self.do_roarequest('PushDingMessage', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/works/notice', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.PushDingMessageResponse(),
            await self.do_roarequest_async('PushDingMessage', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/works/notice', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllDepartmentResponse(),
            self.do_roarequest('QueryAllDepartment', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/departments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllDepartmentResponse(),
            await self.do_roarequest_async('QueryAllDepartment', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/departments', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllDoctorsResponse(),
            self.do_roarequest('QueryAllDoctors', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/doctors', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllDoctorsResponse(),
            await self.do_roarequest_async('QueryAllDoctors', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/doctors', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllGroupResponse(),
            self.do_roarequest('QueryAllGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/groups', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllGroupResponse(),
            await self.do_roarequest_async('QueryAllGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/groups', 'json', req, runtime)
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

    def query_all_groups_in_dept_with_options(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllGroupsInDeptRequest,
        headers: dingtalkindustry__1__0_models.QueryAllGroupsInDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupsInDeptResponse:
        UtilClient.validate_model(request)
        dept_id = OpenApiUtilClient.get_encode_param(dept_id)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllGroupsInDeptResponse(),
            self.do_roarequest('QueryAllGroupsInDept', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/departments/{dept_id}/groups', 'json', req, runtime)
        )

    async def query_all_groups_in_dept_with_options_async(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllGroupsInDeptRequest,
        headers: dingtalkindustry__1__0_models.QueryAllGroupsInDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllGroupsInDeptResponse:
        UtilClient.validate_model(request)
        dept_id = OpenApiUtilClient.get_encode_param(dept_id)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllGroupsInDeptResponse(),
            await self.do_roarequest_async('QueryAllGroupsInDept', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/departments/{dept_id}/groups', 'json', req, runtime)
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

    def query_all_member_by_dept_with_options(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByDeptRequest,
        headers: dingtalkindustry__1__0_models.QueryAllMemberByDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByDeptResponse:
        UtilClient.validate_model(request)
        dept_id = OpenApiUtilClient.get_encode_param(dept_id)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllMemberByDeptResponse(),
            self.do_roarequest('QueryAllMemberByDept', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/departments/{dept_id}/members', 'json', req, runtime)
        )

    async def query_all_member_by_dept_with_options_async(
        self,
        dept_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByDeptRequest,
        headers: dingtalkindustry__1__0_models.QueryAllMemberByDeptHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByDeptResponse:
        UtilClient.validate_model(request)
        dept_id = OpenApiUtilClient.get_encode_param(dept_id)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllMemberByDeptResponse(),
            await self.do_roarequest_async('QueryAllMemberByDept', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/departments/{dept_id}/members', 'json', req, runtime)
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

    def query_all_member_by_group_with_options(
        self,
        group_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByGroupRequest,
        headers: dingtalkindustry__1__0_models.QueryAllMemberByGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByGroupResponse:
        UtilClient.validate_model(request)
        group_id = OpenApiUtilClient.get_encode_param(group_id)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllMemberByGroupResponse(),
            self.do_roarequest('QueryAllMemberByGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/groups/{group_id}/members', 'json', req, runtime)
        )

    async def query_all_member_by_group_with_options_async(
        self,
        group_id: str,
        request: dingtalkindustry__1__0_models.QueryAllMemberByGroupRequest,
        headers: dingtalkindustry__1__0_models.QueryAllMemberByGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryAllMemberByGroupResponse:
        UtilClient.validate_model(request)
        group_id = OpenApiUtilClient.get_encode_param(group_id)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryAllMemberByGroupResponse(),
            await self.do_roarequest_async('QueryAllMemberByGroup', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/groups/{group_id}/members', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryBizOptLogResponse(),
            self.do_roarequest('QueryBizOptLog', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/bizOptLogs', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryBizOptLogResponse(),
            await self.do_roarequest_async('QueryBizOptLog', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/bizOptLogs', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryDepartmentExtendInfoResponse(),
            self.do_roarequest('QueryDepartmentExtendInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/departments/extensions/infos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryDepartmentExtendInfoResponse(),
            await self.do_roarequest_async('QueryDepartmentExtendInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/departments/extensions/infos', 'json', req, runtime)
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

    def query_department_info_with_options(
        self,
        dept_id: str,
        headers: dingtalkindustry__1__0_models.QueryDepartmentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentInfoResponse:
        dept_id = OpenApiUtilClient.get_encode_param(dept_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryDepartmentInfoResponse(),
            self.do_roarequest('QueryDepartmentInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/departments/{dept_id}', 'json', req, runtime)
        )

    async def query_department_info_with_options_async(
        self,
        dept_id: str,
        headers: dingtalkindustry__1__0_models.QueryDepartmentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryDepartmentInfoResponse:
        dept_id = OpenApiUtilClient.get_encode_param(dept_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryDepartmentInfoResponse(),
            await self.do_roarequest_async('QueryDepartmentInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/departments/{dept_id}', 'json', req, runtime)
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

    def query_group_info_with_options(
        self,
        group_id: str,
        headers: dingtalkindustry__1__0_models.QueryGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryGroupInfoResponse:
        group_id = OpenApiUtilClient.get_encode_param(group_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryGroupInfoResponse(),
            self.do_roarequest('QueryGroupInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/groups/{group_id}', 'json', req, runtime)
        )

    async def query_group_info_with_options_async(
        self,
        group_id: str,
        headers: dingtalkindustry__1__0_models.QueryGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryGroupInfoResponse:
        group_id = OpenApiUtilClient.get_encode_param(group_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryGroupInfoResponse(),
            await self.do_roarequest_async('QueryGroupInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/groups/{group_id}', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalDistrictInfoResponse(),
            self.do_roarequest('QueryHospitalDistrictInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/districts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalDistrictInfoResponse(),
            await self.do_roarequest_async('QueryHospitalDistrictInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/districts', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoResponse(),
            self.do_roarequest('QueryHospitalRoleUserInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/roles/userInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalRoleUserInfoResponse(),
            await self.do_roarequest_async('QueryHospitalRoleUserInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/roles/userInfos', 'json', req, runtime)
        )

    def query_hospital_roles(self) -> dingtalkindustry__1__0_models.QueryHospitalRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalRolesHeaders()
        return self.query_hospital_roles_with_options(headers, runtime)

    async def query_hospital_roles_async(self) -> dingtalkindustry__1__0_models.QueryHospitalRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryHospitalRolesHeaders()
        return await self.query_hospital_roles_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalRolesResponse(),
            self.do_roarequest('QueryHospitalRoles', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/roles', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryHospitalRolesResponse(),
            await self.do_roarequest_async('QueryHospitalRoles', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/roles', 'json', req, runtime)
        )

    def query_job_code_dictionary(self) -> dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobCodeDictionaryHeaders()
        return self.query_job_code_dictionary_with_options(headers, runtime)

    async def query_job_code_dictionary_async(self) -> dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobCodeDictionaryHeaders()
        return await self.query_job_code_dictionary_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse(),
            self.do_roarequest('QueryJobCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/jobCodes', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryJobCodeDictionaryResponse(),
            await self.do_roarequest_async('QueryJobCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/jobCodes', 'json', req, runtime)
        )

    def query_job_status_code_dictionary(self) -> dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryHeaders()
        return self.query_job_status_code_dictionary_with_options(headers, runtime)

    async def query_job_status_code_dictionary_async(self) -> dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryHeaders()
        return await self.query_job_status_code_dictionary_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse(),
            self.do_roarequest('QueryJobStatusCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/jobStatusCodes', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryJobStatusCodeDictionaryResponse(),
            await self.do_roarequest_async('QueryJobStatusCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/jobStatusCodes', 'json', req, runtime)
        )

    def query_medical_events(self) -> dingtalkindustry__1__0_models.QueryMedicalEventsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryMedicalEventsHeaders()
        return self.query_medical_events_with_options(headers, runtime)

    async def query_medical_events_async(self) -> dingtalkindustry__1__0_models.QueryMedicalEventsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryMedicalEventsHeaders()
        return await self.query_medical_events_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryMedicalEventsResponse(),
            self.do_roarequest('QueryMedicalEvents', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/events', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryMedicalEventsResponse(),
            await self.do_roarequest_async('QueryMedicalEvents', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/events', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserCredentialsResponse(),
            self.do_roarequest('QueryUserCredentials', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/medicals/users/credentials/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserCredentialsResponse(),
            await self.do_roarequest_async('QueryUserCredentials', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/medicals/users/credentials/query', 'json', req, runtime)
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

    def query_user_ext_info_with_options(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserExtInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserExtInfoResponse:
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserExtInfoResponse(),
            self.do_roarequest('QueryUserExtInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/users/{user_id}/extInfos', 'json', req, runtime)
        )

    async def query_user_ext_info_with_options_async(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserExtInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserExtInfoResponse:
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserExtInfoResponse(),
            await self.do_roarequest_async('QueryUserExtInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/users/{user_id}/extInfos', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserExtendValuesResponse(),
            self.do_roarequest('QueryUserExtendValues', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/medicals/users/extends/query', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserExtendValuesResponse(),
            await self.do_roarequest_async('QueryUserExtendValues', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/medicals/users/extends/query', 'json', req, runtime)
        )

    def query_user_info(
        self,
        user_id: str,
    ) -> dingtalkindustry__1__0_models.QueryUserInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserInfoHeaders()
        return self.query_user_info_with_options(user_id, headers, runtime)

    async def query_user_info_async(
        self,
        user_id: str,
    ) -> dingtalkindustry__1__0_models.QueryUserInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserInfoHeaders()
        return await self.query_user_info_with_options_async(user_id, headers, runtime)

    def query_user_info_with_options(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserInfoResponse:
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserInfoResponse(),
            self.do_roarequest('QueryUserInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/users/{user_id}', 'json', req, runtime)
        )

    async def query_user_info_with_options_async(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserInfoResponse:
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserInfoResponse(),
            await self.do_roarequest_async('QueryUserInfo', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/users/{user_id}', 'json', req, runtime)
        )

    def query_user_prob_code_dictionary(self) -> dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryHeaders()
        return self.query_user_prob_code_dictionary_with_options(headers, runtime)

    async def query_user_prob_code_dictionary_async(self) -> dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryHeaders()
        return await self.query_user_prob_code_dictionary_with_options_async(headers, runtime)

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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse(),
            self.do_roarequest('QueryUserProbCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/userProbCodes', 'json', req, runtime)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserProbCodeDictionaryResponse(),
            await self.do_roarequest_async('QueryUserProbCodeDictionary', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/userProbCodes', 'json', req, runtime)
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

    def query_user_roles_with_options(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserRolesResponse:
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserRolesResponse(),
            self.do_roarequest('QueryUserRoles', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/users/{user_id}/roles', 'json', req, runtime)
        )

    async def query_user_roles_with_options_async(
        self,
        user_id: str,
        headers: dingtalkindustry__1__0_models.QueryUserRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.QueryUserRolesResponse:
        user_id = OpenApiUtilClient.get_encode_param(user_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.QueryUserRolesResponse(),
            await self.do_roarequest_async('QueryUserRoles', 'industry_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/industry/medicals/users/{user_id}/roles', 'json', req, runtime)
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

    def save_user_extend_values_with_options(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.SaveUserExtendValuesRequest,
        headers: dingtalkindustry__1__0_models.SaveUserExtendValuesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SaveUserExtendValuesResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SaveUserExtendValuesResponse(),
            self.do_roarequest('SaveUserExtendValues', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/medicals/users/{user_id}/extends', 'json', req, runtime)
        )

    async def save_user_extend_values_with_options_async(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.SaveUserExtendValuesRequest,
        headers: dingtalkindustry__1__0_models.SaveUserExtendValuesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.SaveUserExtendValuesResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.SaveUserExtendValuesResponse(),
            await self.do_roarequest_async('SaveUserExtendValues', 'industry_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/industry/medicals/users/{user_id}/extends', 'json', req, runtime)
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

    def update_user_extend_info_with_options(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.UpdateUserExtendInfoRequest,
        headers: dingtalkindustry__1__0_models.UpdateUserExtendInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.UpdateUserExtendInfoResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.UpdateUserExtendInfoResponse(),
            self.do_roarequest('UpdateUserExtendInfo', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/medicals/users/{user_id}/extInfos', 'none', req, runtime)
        )

    async def update_user_extend_info_with_options_async(
        self,
        user_id: str,
        request: dingtalkindustry__1__0_models.UpdateUserExtendInfoRequest,
        headers: dingtalkindustry__1__0_models.UpdateUserExtendInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkindustry__1__0_models.UpdateUserExtendInfoResponse:
        UtilClient.validate_model(request)
        user_id = OpenApiUtilClient.get_encode_param(user_id)
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
        return TeaCore.from_map(
            dingtalkindustry__1__0_models.UpdateUserExtendInfoResponse(),
            await self.do_roarequest_async('UpdateUserExtendInfo', 'industry_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/industry/medicals/users/{user_id}/extInfos', 'none', req, runtime)
        )
