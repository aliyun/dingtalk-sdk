# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.resident_1_0 import models as dingtalkresident__1__0_models
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

    def add_point_with_options(
        self,
        request: dingtalkresident__1__0_models.AddPointRequest,
        headers: dingtalkresident__1__0_models.AddPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.AddPointResponse:
        """
        @summary 增加积分
        
        @param request: AddPointRequest
        @param headers: AddPointHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddPointResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.action_time):
            query['actionTime'] = request.action_time
        if not UtilClient.is_unset(request.is_circle):
            query['isCircle'] = request.is_circle
        if not UtilClient.is_unset(request.rule_code):
            query['ruleCode'] = request.rule_code
        if not UtilClient.is_unset(request.rule_name):
            query['ruleName'] = request.rule_name
        if not UtilClient.is_unset(request.score):
            query['score'] = request.score
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.uuid):
            query['uuid'] = request.uuid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AddPoint',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/points',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.AddPointResponse(),
            self.execute(params, req, runtime)
        )

    async def add_point_with_options_async(
        self,
        request: dingtalkresident__1__0_models.AddPointRequest,
        headers: dingtalkresident__1__0_models.AddPointHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.AddPointResponse:
        """
        @summary 增加积分
        
        @param request: AddPointRequest
        @param headers: AddPointHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddPointResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.action_time):
            query['actionTime'] = request.action_time
        if not UtilClient.is_unset(request.is_circle):
            query['isCircle'] = request.is_circle
        if not UtilClient.is_unset(request.rule_code):
            query['ruleCode'] = request.rule_code
        if not UtilClient.is_unset(request.rule_name):
            query['ruleName'] = request.rule_name
        if not UtilClient.is_unset(request.score):
            query['score'] = request.score
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.uuid):
            query['uuid'] = request.uuid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AddPoint',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/points',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.AddPointResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_point(
        self,
        request: dingtalkresident__1__0_models.AddPointRequest,
    ) -> dingtalkresident__1__0_models.AddPointResponse:
        """
        @summary 增加积分
        
        @param request: AddPointRequest
        @return: AddPointResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.AddPointHeaders()
        return self.add_point_with_options(request, headers, runtime)

    async def add_point_async(
        self,
        request: dingtalkresident__1__0_models.AddPointRequest,
    ) -> dingtalkresident__1__0_models.AddPointResponse:
        """
        @summary 增加积分
        
        @param request: AddPointRequest
        @return: AddPointResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.AddPointHeaders()
        return await self.add_point_with_options_async(request, headers, runtime)

    def add_resident_department_with_options(
        self,
        request: dingtalkresident__1__0_models.AddResidentDepartmentRequest,
        headers: dingtalkresident__1__0_models.AddResidentDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.AddResidentDepartmentResponse:
        """
        @summary 增加组户
        
        @param request: AddResidentDepartmentRequest
        @param headers: AddResidentDepartmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddResidentDepartmentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_name):
            query['departmentName'] = request.department_name
        if not UtilClient.is_unset(request.is_residence_group):
            query['isResidenceGroup'] = request.is_residence_group
        if not UtilClient.is_unset(request.parent_department_id):
            query['parentDepartmentId'] = request.parent_department_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AddResidentDepartment',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/departments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.AddResidentDepartmentResponse(),
            self.execute(params, req, runtime)
        )

    async def add_resident_department_with_options_async(
        self,
        request: dingtalkresident__1__0_models.AddResidentDepartmentRequest,
        headers: dingtalkresident__1__0_models.AddResidentDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.AddResidentDepartmentResponse:
        """
        @summary 增加组户
        
        @param request: AddResidentDepartmentRequest
        @param headers: AddResidentDepartmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddResidentDepartmentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_name):
            query['departmentName'] = request.department_name
        if not UtilClient.is_unset(request.is_residence_group):
            query['isResidenceGroup'] = request.is_residence_group
        if not UtilClient.is_unset(request.parent_department_id):
            query['parentDepartmentId'] = request.parent_department_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AddResidentDepartment',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/departments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.AddResidentDepartmentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_resident_department(
        self,
        request: dingtalkresident__1__0_models.AddResidentDepartmentRequest,
    ) -> dingtalkresident__1__0_models.AddResidentDepartmentResponse:
        """
        @summary 增加组户
        
        @param request: AddResidentDepartmentRequest
        @return: AddResidentDepartmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.AddResidentDepartmentHeaders()
        return self.add_resident_department_with_options(request, headers, runtime)

    async def add_resident_department_async(
        self,
        request: dingtalkresident__1__0_models.AddResidentDepartmentRequest,
    ) -> dingtalkresident__1__0_models.AddResidentDepartmentResponse:
        """
        @summary 增加组户
        
        @param request: AddResidentDepartmentRequest
        @return: AddResidentDepartmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.AddResidentDepartmentHeaders()
        return await self.add_resident_department_with_options_async(request, headers, runtime)

    def add_resident_member_with_options(
        self,
        request: dingtalkresident__1__0_models.AddResidentMemberRequest,
        headers: dingtalkresident__1__0_models.AddResidentMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.AddResidentMemberResponse:
        """
        @summary 添加小区成员
        
        @param request: AddResidentMemberRequest
        @param headers: AddResidentMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddResidentMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.resident_add_info):
            body['residentAddInfo'] = request.resident_add_info
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddResidentMember',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.AddResidentMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def add_resident_member_with_options_async(
        self,
        request: dingtalkresident__1__0_models.AddResidentMemberRequest,
        headers: dingtalkresident__1__0_models.AddResidentMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.AddResidentMemberResponse:
        """
        @summary 添加小区成员
        
        @param request: AddResidentMemberRequest
        @param headers: AddResidentMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddResidentMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.resident_add_info):
            body['residentAddInfo'] = request.resident_add_info
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddResidentMember',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.AddResidentMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_resident_member(
        self,
        request: dingtalkresident__1__0_models.AddResidentMemberRequest,
    ) -> dingtalkresident__1__0_models.AddResidentMemberResponse:
        """
        @summary 添加小区成员
        
        @param request: AddResidentMemberRequest
        @return: AddResidentMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.AddResidentMemberHeaders()
        return self.add_resident_member_with_options(request, headers, runtime)

    async def add_resident_member_async(
        self,
        request: dingtalkresident__1__0_models.AddResidentMemberRequest,
    ) -> dingtalkresident__1__0_models.AddResidentMemberResponse:
        """
        @summary 添加小区成员
        
        @param request: AddResidentMemberRequest
        @return: AddResidentMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.AddResidentMemberHeaders()
        return await self.add_resident_member_with_options_async(request, headers, runtime)

    def add_resident_users_with_options(
        self,
        request: dingtalkresident__1__0_models.AddResidentUsersRequest,
        headers: dingtalkresident__1__0_models.AddResidentUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.AddResidentUsersResponse:
        """
        @summary 新增居民
        
        @param request: AddResidentUsersRequest
        @param headers: AddResidentUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddResidentUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.address):
            query['address'] = request.address
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.ext_field):
            query['extField'] = request.ext_field
        if not UtilClient.is_unset(request.is_leaseholder):
            query['isLeaseholder'] = request.is_leaseholder
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        if not UtilClient.is_unset(request.relate_type):
            query['relateType'] = request.relate_type
        if not UtilClient.is_unset(request.user_name):
            query['userName'] = request.user_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AddResidentUsers',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.AddResidentUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def add_resident_users_with_options_async(
        self,
        request: dingtalkresident__1__0_models.AddResidentUsersRequest,
        headers: dingtalkresident__1__0_models.AddResidentUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.AddResidentUsersResponse:
        """
        @summary 新增居民
        
        @param request: AddResidentUsersRequest
        @param headers: AddResidentUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddResidentUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.address):
            query['address'] = request.address
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.ext_field):
            query['extField'] = request.ext_field
        if not UtilClient.is_unset(request.is_leaseholder):
            query['isLeaseholder'] = request.is_leaseholder
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        if not UtilClient.is_unset(request.relate_type):
            query['relateType'] = request.relate_type
        if not UtilClient.is_unset(request.user_name):
            query['userName'] = request.user_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AddResidentUsers',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/users',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.AddResidentUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_resident_users(
        self,
        request: dingtalkresident__1__0_models.AddResidentUsersRequest,
    ) -> dingtalkresident__1__0_models.AddResidentUsersResponse:
        """
        @summary 新增居民
        
        @param request: AddResidentUsersRequest
        @return: AddResidentUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.AddResidentUsersHeaders()
        return self.add_resident_users_with_options(request, headers, runtime)

    async def add_resident_users_async(
        self,
        request: dingtalkresident__1__0_models.AddResidentUsersRequest,
    ) -> dingtalkresident__1__0_models.AddResidentUsersResponse:
        """
        @summary 新增居民
        
        @param request: AddResidentUsersRequest
        @return: AddResidentUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.AddResidentUsersHeaders()
        return await self.add_resident_users_with_options_async(request, headers, runtime)

    def create_resident_black_board_with_options(
        self,
        request: dingtalkresident__1__0_models.CreateResidentBlackBoardRequest,
        headers: dingtalkresident__1__0_models.CreateResidentBlackBoardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.CreateResidentBlackBoardResponse:
        """
        @summary 创建小区公告
        
        @param request: CreateResidentBlackBoardRequest
        @param headers: CreateResidentBlackBoardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateResidentBlackBoardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.context):
            body['context'] = request.context
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.send_time):
            body['sendTime'] = request.send_time
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
            action='CreateResidentBlackBoard',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/blackboards',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.CreateResidentBlackBoardResponse(),
            self.execute(params, req, runtime)
        )

    async def create_resident_black_board_with_options_async(
        self,
        request: dingtalkresident__1__0_models.CreateResidentBlackBoardRequest,
        headers: dingtalkresident__1__0_models.CreateResidentBlackBoardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.CreateResidentBlackBoardResponse:
        """
        @summary 创建小区公告
        
        @param request: CreateResidentBlackBoardRequest
        @param headers: CreateResidentBlackBoardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateResidentBlackBoardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.context):
            body['context'] = request.context
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
        if not UtilClient.is_unset(request.send_time):
            body['sendTime'] = request.send_time
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
            action='CreateResidentBlackBoard',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/blackboards',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.CreateResidentBlackBoardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_resident_black_board(
        self,
        request: dingtalkresident__1__0_models.CreateResidentBlackBoardRequest,
    ) -> dingtalkresident__1__0_models.CreateResidentBlackBoardResponse:
        """
        @summary 创建小区公告
        
        @param request: CreateResidentBlackBoardRequest
        @return: CreateResidentBlackBoardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.CreateResidentBlackBoardHeaders()
        return self.create_resident_black_board_with_options(request, headers, runtime)

    async def create_resident_black_board_async(
        self,
        request: dingtalkresident__1__0_models.CreateResidentBlackBoardRequest,
    ) -> dingtalkresident__1__0_models.CreateResidentBlackBoardResponse:
        """
        @summary 创建小区公告
        
        @param request: CreateResidentBlackBoardRequest
        @return: CreateResidentBlackBoardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.CreateResidentBlackBoardHeaders()
        return await self.create_resident_black_board_with_options_async(request, headers, runtime)

    def create_space_with_options(
        self,
        request: dingtalkresident__1__0_models.CreateSpaceRequest,
        headers: dingtalkresident__1__0_models.CreateSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.CreateSpaceResponse:
        """
        @summary 创建小区空间，含分区，楼栋，单元，房屋等
        
        @param request: CreateSpaceRequest
        @param headers: CreateSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.billing_area):
            body['billingArea'] = request.billing_area
        if not UtilClient.is_unset(request.building_area):
            body['buildingArea'] = request.building_area
        if not UtilClient.is_unset(request.floor):
            body['floor'] = request.floor
        if not UtilClient.is_unset(request.house_state):
            body['houseState'] = request.house_state
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.parent_dept_id):
            body['parentDeptId'] = request.parent_dept_id
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
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
            action='CreateSpace',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.CreateSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_space_with_options_async(
        self,
        request: dingtalkresident__1__0_models.CreateSpaceRequest,
        headers: dingtalkresident__1__0_models.CreateSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.CreateSpaceResponse:
        """
        @summary 创建小区空间，含分区，楼栋，单元，房屋等
        
        @param request: CreateSpaceRequest
        @param headers: CreateSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.billing_area):
            body['billingArea'] = request.billing_area
        if not UtilClient.is_unset(request.building_area):
            body['buildingArea'] = request.building_area
        if not UtilClient.is_unset(request.floor):
            body['floor'] = request.floor
        if not UtilClient.is_unset(request.house_state):
            body['houseState'] = request.house_state
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.parent_dept_id):
            body['parentDeptId'] = request.parent_dept_id
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
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
            action='CreateSpace',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.CreateSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_space(
        self,
        request: dingtalkresident__1__0_models.CreateSpaceRequest,
    ) -> dingtalkresident__1__0_models.CreateSpaceResponse:
        """
        @summary 创建小区空间，含分区，楼栋，单元，房屋等
        
        @param request: CreateSpaceRequest
        @return: CreateSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.CreateSpaceHeaders()
        return self.create_space_with_options(request, headers, runtime)

    async def create_space_async(
        self,
        request: dingtalkresident__1__0_models.CreateSpaceRequest,
    ) -> dingtalkresident__1__0_models.CreateSpaceResponse:
        """
        @summary 创建小区空间，含分区，楼栋，单元，房屋等
        
        @param request: CreateSpaceRequest
        @return: CreateSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.CreateSpaceHeaders()
        return await self.create_space_with_options_async(request, headers, runtime)

    def delete_resident_black_board_with_options(
        self,
        request: dingtalkresident__1__0_models.DeleteResidentBlackBoardRequest,
        headers: dingtalkresident__1__0_models.DeleteResidentBlackBoardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.DeleteResidentBlackBoardResponse:
        """
        @summary 删除小区公告
        
        @param request: DeleteResidentBlackBoardRequest
        @param headers: DeleteResidentBlackBoardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteResidentBlackBoardResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.blackboard_id):
            query['blackboardId'] = request.blackboard_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteResidentBlackBoard',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/blackboards',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.DeleteResidentBlackBoardResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_resident_black_board_with_options_async(
        self,
        request: dingtalkresident__1__0_models.DeleteResidentBlackBoardRequest,
        headers: dingtalkresident__1__0_models.DeleteResidentBlackBoardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.DeleteResidentBlackBoardResponse:
        """
        @summary 删除小区公告
        
        @param request: DeleteResidentBlackBoardRequest
        @param headers: DeleteResidentBlackBoardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteResidentBlackBoardResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.blackboard_id):
            query['blackboardId'] = request.blackboard_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteResidentBlackBoard',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/blackboards',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.DeleteResidentBlackBoardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_resident_black_board(
        self,
        request: dingtalkresident__1__0_models.DeleteResidentBlackBoardRequest,
    ) -> dingtalkresident__1__0_models.DeleteResidentBlackBoardResponse:
        """
        @summary 删除小区公告
        
        @param request: DeleteResidentBlackBoardRequest
        @return: DeleteResidentBlackBoardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.DeleteResidentBlackBoardHeaders()
        return self.delete_resident_black_board_with_options(request, headers, runtime)

    async def delete_resident_black_board_async(
        self,
        request: dingtalkresident__1__0_models.DeleteResidentBlackBoardRequest,
    ) -> dingtalkresident__1__0_models.DeleteResidentBlackBoardResponse:
        """
        @summary 删除小区公告
        
        @param request: DeleteResidentBlackBoardRequest
        @return: DeleteResidentBlackBoardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.DeleteResidentBlackBoardHeaders()
        return await self.delete_resident_black_board_with_options_async(request, headers, runtime)

    def delete_resident_department_with_options(
        self,
        request: dingtalkresident__1__0_models.DeleteResidentDepartmentRequest,
        headers: dingtalkresident__1__0_models.DeleteResidentDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.DeleteResidentDepartmentResponse:
        """
        @summary 删除组户信息
        
        @param request: DeleteResidentDepartmentRequest
        @param headers: DeleteResidentDepartmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteResidentDepartmentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteResidentDepartment',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/departments',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.DeleteResidentDepartmentResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_resident_department_with_options_async(
        self,
        request: dingtalkresident__1__0_models.DeleteResidentDepartmentRequest,
        headers: dingtalkresident__1__0_models.DeleteResidentDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.DeleteResidentDepartmentResponse:
        """
        @summary 删除组户信息
        
        @param request: DeleteResidentDepartmentRequest
        @param headers: DeleteResidentDepartmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteResidentDepartmentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteResidentDepartment',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/departments',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.DeleteResidentDepartmentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_resident_department(
        self,
        request: dingtalkresident__1__0_models.DeleteResidentDepartmentRequest,
    ) -> dingtalkresident__1__0_models.DeleteResidentDepartmentResponse:
        """
        @summary 删除组户信息
        
        @param request: DeleteResidentDepartmentRequest
        @return: DeleteResidentDepartmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.DeleteResidentDepartmentHeaders()
        return self.delete_resident_department_with_options(request, headers, runtime)

    async def delete_resident_department_async(
        self,
        request: dingtalkresident__1__0_models.DeleteResidentDepartmentRequest,
    ) -> dingtalkresident__1__0_models.DeleteResidentDepartmentResponse:
        """
        @summary 删除组户信息
        
        @param request: DeleteResidentDepartmentRequest
        @return: DeleteResidentDepartmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.DeleteResidentDepartmentHeaders()
        return await self.delete_resident_department_with_options_async(request, headers, runtime)

    def delete_space_with_options(
        self,
        request: dingtalkresident__1__0_models.DeleteSpaceRequest,
        headers: dingtalkresident__1__0_models.DeleteSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.DeleteSpaceResponse:
        """
        @summary 删除小区空间，含分区，楼栋，单元，房屋
        
        @param request: DeleteSpaceRequest
        @param headers: DeleteSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteSpace',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.DeleteSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_space_with_options_async(
        self,
        request: dingtalkresident__1__0_models.DeleteSpaceRequest,
        headers: dingtalkresident__1__0_models.DeleteSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.DeleteSpaceResponse:
        """
        @summary 删除小区空间，含分区，楼栋，单元，房屋
        
        @param request: DeleteSpaceRequest
        @param headers: DeleteSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteSpace',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.DeleteSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_space(
        self,
        request: dingtalkresident__1__0_models.DeleteSpaceRequest,
    ) -> dingtalkresident__1__0_models.DeleteSpaceResponse:
        """
        @summary 删除小区空间，含分区，楼栋，单元，房屋
        
        @param request: DeleteSpaceRequest
        @return: DeleteSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.DeleteSpaceHeaders()
        return self.delete_space_with_options(request, headers, runtime)

    async def delete_space_async(
        self,
        request: dingtalkresident__1__0_models.DeleteSpaceRequest,
    ) -> dingtalkresident__1__0_models.DeleteSpaceResponse:
        """
        @summary 删除小区空间，含分区，楼栋，单元，房屋
        
        @param request: DeleteSpaceRequest
        @return: DeleteSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.DeleteSpaceHeaders()
        return await self.delete_space_with_options_async(request, headers, runtime)

    def get_conversation_id_with_options(
        self,
        request: dingtalkresident__1__0_models.GetConversationIdRequest,
        headers: dingtalkresident__1__0_models.GetConversationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetConversationIdResponse:
        """
        @summary 获取指定群的openConversationId
        
        @param request: GetConversationIdRequest
        @param headers: GetConversationIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConversationIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.chat_id):
            query['chatId'] = request.chat_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetConversationId',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/conversations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetConversationIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_conversation_id_with_options_async(
        self,
        request: dingtalkresident__1__0_models.GetConversationIdRequest,
        headers: dingtalkresident__1__0_models.GetConversationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetConversationIdResponse:
        """
        @summary 获取指定群的openConversationId
        
        @param request: GetConversationIdRequest
        @param headers: GetConversationIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConversationIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.chat_id):
            query['chatId'] = request.chat_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetConversationId',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/conversations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetConversationIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_conversation_id(
        self,
        request: dingtalkresident__1__0_models.GetConversationIdRequest,
    ) -> dingtalkresident__1__0_models.GetConversationIdResponse:
        """
        @summary 获取指定群的openConversationId
        
        @param request: GetConversationIdRequest
        @return: GetConversationIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetConversationIdHeaders()
        return self.get_conversation_id_with_options(request, headers, runtime)

    async def get_conversation_id_async(
        self,
        request: dingtalkresident__1__0_models.GetConversationIdRequest,
    ) -> dingtalkresident__1__0_models.GetConversationIdResponse:
        """
        @summary 获取指定群的openConversationId
        
        @param request: GetConversationIdRequest
        @return: GetConversationIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetConversationIdHeaders()
        return await self.get_conversation_id_with_options_async(request, headers, runtime)

    def get_industry_type_with_options(
        self,
        headers: dingtalkresident__1__0_models.GetIndustryTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetIndustryTypeResponse:
        """
        @summary 获取组织的行业类型
        
        @param headers: GetIndustryTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetIndustryTypeResponse
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
            action='GetIndustryType',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/organizations/industryTypes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetIndustryTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def get_industry_type_with_options_async(
        self,
        headers: dingtalkresident__1__0_models.GetIndustryTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetIndustryTypeResponse:
        """
        @summary 获取组织的行业类型
        
        @param headers: GetIndustryTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetIndustryTypeResponse
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
            action='GetIndustryType',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/organizations/industryTypes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetIndustryTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_industry_type(self) -> dingtalkresident__1__0_models.GetIndustryTypeResponse:
        """
        @summary 获取组织的行业类型
        
        @return: GetIndustryTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetIndustryTypeHeaders()
        return self.get_industry_type_with_options(headers, runtime)

    async def get_industry_type_async(self) -> dingtalkresident__1__0_models.GetIndustryTypeResponse:
        """
        @summary 获取组织的行业类型
        
        @return: GetIndustryTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetIndustryTypeHeaders()
        return await self.get_industry_type_with_options_async(headers, runtime)

    def get_property_info_with_options(
        self,
        request: dingtalkresident__1__0_models.GetPropertyInfoRequest,
        headers: dingtalkresident__1__0_models.GetPropertyInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetPropertyInfoResponse:
        """
        @summary 获取物业公司信息
        
        @param request: GetPropertyInfoRequest
        @param headers: GetPropertyInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPropertyInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.property_corp_id):
            query['propertyCorpId'] = request.property_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetPropertyInfo',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/propertyInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetPropertyInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_property_info_with_options_async(
        self,
        request: dingtalkresident__1__0_models.GetPropertyInfoRequest,
        headers: dingtalkresident__1__0_models.GetPropertyInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetPropertyInfoResponse:
        """
        @summary 获取物业公司信息
        
        @param request: GetPropertyInfoRequest
        @param headers: GetPropertyInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPropertyInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.property_corp_id):
            query['propertyCorpId'] = request.property_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetPropertyInfo',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/propertyInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetPropertyInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_property_info(
        self,
        request: dingtalkresident__1__0_models.GetPropertyInfoRequest,
    ) -> dingtalkresident__1__0_models.GetPropertyInfoResponse:
        """
        @summary 获取物业公司信息
        
        @param request: GetPropertyInfoRequest
        @return: GetPropertyInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetPropertyInfoHeaders()
        return self.get_property_info_with_options(request, headers, runtime)

    async def get_property_info_async(
        self,
        request: dingtalkresident__1__0_models.GetPropertyInfoRequest,
    ) -> dingtalkresident__1__0_models.GetPropertyInfoResponse:
        """
        @summary 获取物业公司信息
        
        @param request: GetPropertyInfoRequest
        @return: GetPropertyInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetPropertyInfoHeaders()
        return await self.get_property_info_with_options_async(request, headers, runtime)

    def get_resident_info_with_options(
        self,
        request: dingtalkresident__1__0_models.GetResidentInfoRequest,
        headers: dingtalkresident__1__0_models.GetResidentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetResidentInfoResponse:
        """
        @summary 获取小区信息
        
        @param request: GetResidentInfoRequest
        @param headers: GetResidentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetResidentInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.resident_corp_id):
            query['residentCorpId'] = request.resident_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetResidentInfo',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/residentInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetResidentInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_resident_info_with_options_async(
        self,
        request: dingtalkresident__1__0_models.GetResidentInfoRequest,
        headers: dingtalkresident__1__0_models.GetResidentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetResidentInfoResponse:
        """
        @summary 获取小区信息
        
        @param request: GetResidentInfoRequest
        @param headers: GetResidentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetResidentInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.resident_corp_id):
            query['residentCorpId'] = request.resident_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetResidentInfo',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/residentInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetResidentInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_resident_info(
        self,
        request: dingtalkresident__1__0_models.GetResidentInfoRequest,
    ) -> dingtalkresident__1__0_models.GetResidentInfoResponse:
        """
        @summary 获取小区信息
        
        @param request: GetResidentInfoRequest
        @return: GetResidentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetResidentInfoHeaders()
        return self.get_resident_info_with_options(request, headers, runtime)

    async def get_resident_info_async(
        self,
        request: dingtalkresident__1__0_models.GetResidentInfoRequest,
    ) -> dingtalkresident__1__0_models.GetResidentInfoResponse:
        """
        @summary 获取小区信息
        
        @param request: GetResidentInfoRequest
        @return: GetResidentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetResidentInfoHeaders()
        return await self.get_resident_info_with_options_async(request, headers, runtime)

    def get_resident_members_info_with_options(
        self,
        request: dingtalkresident__1__0_models.GetResidentMembersInfoRequest,
        headers: dingtalkresident__1__0_models.GetResidentMembersInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetResidentMembersInfoResponse:
        """
        @summary 获取小区人员信息，包括居民和物业人员
        
        @param request: GetResidentMembersInfoRequest
        @param headers: GetResidentMembersInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetResidentMembersInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.resident_crop_id):
            body['residentCropId'] = request.resident_crop_id
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
            action='GetResidentMembersInfo',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/residences/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetResidentMembersInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_resident_members_info_with_options_async(
        self,
        request: dingtalkresident__1__0_models.GetResidentMembersInfoRequest,
        headers: dingtalkresident__1__0_models.GetResidentMembersInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetResidentMembersInfoResponse:
        """
        @summary 获取小区人员信息，包括居民和物业人员
        
        @param request: GetResidentMembersInfoRequest
        @param headers: GetResidentMembersInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetResidentMembersInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.resident_crop_id):
            body['residentCropId'] = request.resident_crop_id
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
            action='GetResidentMembersInfo',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/residences/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetResidentMembersInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_resident_members_info(
        self,
        request: dingtalkresident__1__0_models.GetResidentMembersInfoRequest,
    ) -> dingtalkresident__1__0_models.GetResidentMembersInfoResponse:
        """
        @summary 获取小区人员信息，包括居民和物业人员
        
        @param request: GetResidentMembersInfoRequest
        @return: GetResidentMembersInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetResidentMembersInfoHeaders()
        return self.get_resident_members_info_with_options(request, headers, runtime)

    async def get_resident_members_info_async(
        self,
        request: dingtalkresident__1__0_models.GetResidentMembersInfoRequest,
    ) -> dingtalkresident__1__0_models.GetResidentMembersInfoResponse:
        """
        @summary 获取小区人员信息，包括居民和物业人员
        
        @param request: GetResidentMembersInfoRequest
        @return: GetResidentMembersInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetResidentMembersInfoHeaders()
        return await self.get_resident_members_info_with_options_async(request, headers, runtime)

    def get_space_id_by_type_with_options(
        self,
        request: dingtalkresident__1__0_models.GetSpaceIdByTypeRequest,
        headers: dingtalkresident__1__0_models.GetSpaceIdByTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetSpaceIdByTypeResponse:
        """
        @summary 根据类型获取部门id
        
        @param request: GetSpaceIdByTypeRequest
        @param headers: GetSpaceIdByTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSpaceIdByTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_type):
            query['departmentType'] = request.department_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetSpaceIdByType',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces/types',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetSpaceIdByTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def get_space_id_by_type_with_options_async(
        self,
        request: dingtalkresident__1__0_models.GetSpaceIdByTypeRequest,
        headers: dingtalkresident__1__0_models.GetSpaceIdByTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetSpaceIdByTypeResponse:
        """
        @summary 根据类型获取部门id
        
        @param request: GetSpaceIdByTypeRequest
        @param headers: GetSpaceIdByTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSpaceIdByTypeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_type):
            query['departmentType'] = request.department_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetSpaceIdByType',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces/types',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetSpaceIdByTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_space_id_by_type(
        self,
        request: dingtalkresident__1__0_models.GetSpaceIdByTypeRequest,
    ) -> dingtalkresident__1__0_models.GetSpaceIdByTypeResponse:
        """
        @summary 根据类型获取部门id
        
        @param request: GetSpaceIdByTypeRequest
        @return: GetSpaceIdByTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetSpaceIdByTypeHeaders()
        return self.get_space_id_by_type_with_options(request, headers, runtime)

    async def get_space_id_by_type_async(
        self,
        request: dingtalkresident__1__0_models.GetSpaceIdByTypeRequest,
    ) -> dingtalkresident__1__0_models.GetSpaceIdByTypeResponse:
        """
        @summary 根据类型获取部门id
        
        @param request: GetSpaceIdByTypeRequest
        @return: GetSpaceIdByTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetSpaceIdByTypeHeaders()
        return await self.get_space_id_by_type_with_options_async(request, headers, runtime)

    def get_spaces_info_with_options(
        self,
        request: dingtalkresident__1__0_models.GetSpacesInfoRequest,
        headers: dingtalkresident__1__0_models.GetSpacesInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetSpacesInfoResponse:
        """
        @summary 获取空间信息
        
        @param request: GetSpacesInfoRequest
        @param headers: GetSpacesInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSpacesInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.refer_ids):
            body['referIds'] = request.refer_ids
        if not UtilClient.is_unset(request.resident_corp_id):
            body['residentCorpId'] = request.resident_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetSpacesInfo',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetSpacesInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_spaces_info_with_options_async(
        self,
        request: dingtalkresident__1__0_models.GetSpacesInfoRequest,
        headers: dingtalkresident__1__0_models.GetSpacesInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.GetSpacesInfoResponse:
        """
        @summary 获取空间信息
        
        @param request: GetSpacesInfoRequest
        @param headers: GetSpacesInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSpacesInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.refer_ids):
            body['referIds'] = request.refer_ids
        if not UtilClient.is_unset(request.resident_corp_id):
            body['residentCorpId'] = request.resident_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetSpacesInfo',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.GetSpacesInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_spaces_info(
        self,
        request: dingtalkresident__1__0_models.GetSpacesInfoRequest,
    ) -> dingtalkresident__1__0_models.GetSpacesInfoResponse:
        """
        @summary 获取空间信息
        
        @param request: GetSpacesInfoRequest
        @return: GetSpacesInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetSpacesInfoHeaders()
        return self.get_spaces_info_with_options(request, headers, runtime)

    async def get_spaces_info_async(
        self,
        request: dingtalkresident__1__0_models.GetSpacesInfoRequest,
    ) -> dingtalkresident__1__0_models.GetSpacesInfoResponse:
        """
        @summary 获取空间信息
        
        @param request: GetSpacesInfoRequest
        @return: GetSpacesInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.GetSpacesInfoHeaders()
        return await self.get_spaces_info_with_options_async(request, headers, runtime)

    def list_industry_role_users_with_options(
        self,
        request: dingtalkresident__1__0_models.ListIndustryRoleUsersRequest,
        headers: dingtalkresident__1__0_models.ListIndustryRoleUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.ListIndustryRoleUsersResponse:
        """
        @summary 获取行业角色下的用户列表
        
        @param request: ListIndustryRoleUsersRequest
        @param headers: ListIndustryRoleUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListIndustryRoleUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tag_code):
            query['tagCode'] = request.tag_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListIndustryRoleUsers',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/industryRoles/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.ListIndustryRoleUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def list_industry_role_users_with_options_async(
        self,
        request: dingtalkresident__1__0_models.ListIndustryRoleUsersRequest,
        headers: dingtalkresident__1__0_models.ListIndustryRoleUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.ListIndustryRoleUsersResponse:
        """
        @summary 获取行业角色下的用户列表
        
        @param request: ListIndustryRoleUsersRequest
        @param headers: ListIndustryRoleUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListIndustryRoleUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.tag_code):
            query['tagCode'] = request.tag_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListIndustryRoleUsers',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/industryRoles/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.ListIndustryRoleUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_industry_role_users(
        self,
        request: dingtalkresident__1__0_models.ListIndustryRoleUsersRequest,
    ) -> dingtalkresident__1__0_models.ListIndustryRoleUsersResponse:
        """
        @summary 获取行业角色下的用户列表
        
        @param request: ListIndustryRoleUsersRequest
        @return: ListIndustryRoleUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.ListIndustryRoleUsersHeaders()
        return self.list_industry_role_users_with_options(request, headers, runtime)

    async def list_industry_role_users_async(
        self,
        request: dingtalkresident__1__0_models.ListIndustryRoleUsersRequest,
    ) -> dingtalkresident__1__0_models.ListIndustryRoleUsersResponse:
        """
        @summary 获取行业角色下的用户列表
        
        @param request: ListIndustryRoleUsersRequest
        @return: ListIndustryRoleUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.ListIndustryRoleUsersHeaders()
        return await self.list_industry_role_users_with_options_async(request, headers, runtime)

    def list_point_rules_with_options(
        self,
        request: dingtalkresident__1__0_models.ListPointRulesRequest,
        headers: dingtalkresident__1__0_models.ListPointRulesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.ListPointRulesResponse:
        """
        @summary 查询组织维度配置的的积分规则
        
        @param request: ListPointRulesRequest
        @param headers: ListPointRulesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListPointRulesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_circle):
            query['isCircle'] = request.is_circle
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListPointRules',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/points/rules',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.ListPointRulesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_point_rules_with_options_async(
        self,
        request: dingtalkresident__1__0_models.ListPointRulesRequest,
        headers: dingtalkresident__1__0_models.ListPointRulesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.ListPointRulesResponse:
        """
        @summary 查询组织维度配置的的积分规则
        
        @param request: ListPointRulesRequest
        @param headers: ListPointRulesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListPointRulesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_circle):
            query['isCircle'] = request.is_circle
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListPointRules',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/points/rules',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.ListPointRulesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_point_rules(
        self,
        request: dingtalkresident__1__0_models.ListPointRulesRequest,
    ) -> dingtalkresident__1__0_models.ListPointRulesResponse:
        """
        @summary 查询组织维度配置的的积分规则
        
        @param request: ListPointRulesRequest
        @return: ListPointRulesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.ListPointRulesHeaders()
        return self.list_point_rules_with_options(request, headers, runtime)

    async def list_point_rules_async(
        self,
        request: dingtalkresident__1__0_models.ListPointRulesRequest,
    ) -> dingtalkresident__1__0_models.ListPointRulesResponse:
        """
        @summary 查询组织维度配置的的积分规则
        
        @param request: ListPointRulesRequest
        @return: ListPointRulesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.ListPointRulesHeaders()
        return await self.list_point_rules_with_options_async(request, headers, runtime)

    def list_sub_space_with_options(
        self,
        request: dingtalkresident__1__0_models.ListSubSpaceRequest,
        headers: dingtalkresident__1__0_models.ListSubSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.ListSubSpaceResponse:
        """
        @summary 获取子空间信息
        
        @param request: ListSubSpaceRequest
        @param headers: ListSubSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSubSpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.refer_id):
            query['referId'] = request.refer_id
        if not UtilClient.is_unset(request.resident_corp_id):
            query['residentCorpId'] = request.resident_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListSubSpace',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces/subSpaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.ListSubSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def list_sub_space_with_options_async(
        self,
        request: dingtalkresident__1__0_models.ListSubSpaceRequest,
        headers: dingtalkresident__1__0_models.ListSubSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.ListSubSpaceResponse:
        """
        @summary 获取子空间信息
        
        @param request: ListSubSpaceRequest
        @param headers: ListSubSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSubSpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.refer_id):
            query['referId'] = request.refer_id
        if not UtilClient.is_unset(request.resident_corp_id):
            query['residentCorpId'] = request.resident_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListSubSpace',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces/subSpaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.ListSubSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_sub_space(
        self,
        request: dingtalkresident__1__0_models.ListSubSpaceRequest,
    ) -> dingtalkresident__1__0_models.ListSubSpaceResponse:
        """
        @summary 获取子空间信息
        
        @param request: ListSubSpaceRequest
        @return: ListSubSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.ListSubSpaceHeaders()
        return self.list_sub_space_with_options(request, headers, runtime)

    async def list_sub_space_async(
        self,
        request: dingtalkresident__1__0_models.ListSubSpaceRequest,
    ) -> dingtalkresident__1__0_models.ListSubSpaceResponse:
        """
        @summary 获取子空间信息
        
        @param request: ListSubSpaceRequest
        @return: ListSubSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.ListSubSpaceHeaders()
        return await self.list_sub_space_with_options_async(request, headers, runtime)

    def list_uncheck_users_with_options(
        self,
        request: dingtalkresident__1__0_models.ListUncheckUsersRequest,
        headers: dingtalkresident__1__0_models.ListUncheckUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.ListUncheckUsersResponse:
        """
        @summary 获取未确认加入组织的用户
        
        @param request: ListUncheckUsersRequest
        @param headers: ListUncheckUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListUncheckUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='ListUncheckUsers',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/organizations/noJoinUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.ListUncheckUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def list_uncheck_users_with_options_async(
        self,
        request: dingtalkresident__1__0_models.ListUncheckUsersRequest,
        headers: dingtalkresident__1__0_models.ListUncheckUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.ListUncheckUsersResponse:
        """
        @summary 获取未确认加入组织的用户
        
        @param request: ListUncheckUsersRequest
        @param headers: ListUncheckUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListUncheckUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='ListUncheckUsers',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/organizations/noJoinUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.ListUncheckUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_uncheck_users(
        self,
        request: dingtalkresident__1__0_models.ListUncheckUsersRequest,
    ) -> dingtalkresident__1__0_models.ListUncheckUsersResponse:
        """
        @summary 获取未确认加入组织的用户
        
        @param request: ListUncheckUsersRequest
        @return: ListUncheckUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.ListUncheckUsersHeaders()
        return self.list_uncheck_users_with_options(request, headers, runtime)

    async def list_uncheck_users_async(
        self,
        request: dingtalkresident__1__0_models.ListUncheckUsersRequest,
    ) -> dingtalkresident__1__0_models.ListUncheckUsersResponse:
        """
        @summary 获取未确认加入组织的用户
        
        @param request: ListUncheckUsersRequest
        @return: ListUncheckUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.ListUncheckUsersHeaders()
        return await self.list_uncheck_users_with_options_async(request, headers, runtime)

    def list_user_industry_roles_with_options(
        self,
        request: dingtalkresident__1__0_models.ListUserIndustryRolesRequest,
        headers: dingtalkresident__1__0_models.ListUserIndustryRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.ListUserIndustryRolesResponse:
        """
        @summary 获取用户行业化角色
        
        @param request: ListUserIndustryRolesRequest
        @param headers: ListUserIndustryRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListUserIndustryRolesResponse
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
            action='ListUserIndustryRoles',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/users/industryRoles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.ListUserIndustryRolesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_user_industry_roles_with_options_async(
        self,
        request: dingtalkresident__1__0_models.ListUserIndustryRolesRequest,
        headers: dingtalkresident__1__0_models.ListUserIndustryRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.ListUserIndustryRolesResponse:
        """
        @summary 获取用户行业化角色
        
        @param request: ListUserIndustryRolesRequest
        @param headers: ListUserIndustryRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListUserIndustryRolesResponse
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
            action='ListUserIndustryRoles',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/users/industryRoles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.ListUserIndustryRolesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_user_industry_roles(
        self,
        request: dingtalkresident__1__0_models.ListUserIndustryRolesRequest,
    ) -> dingtalkresident__1__0_models.ListUserIndustryRolesResponse:
        """
        @summary 获取用户行业化角色
        
        @param request: ListUserIndustryRolesRequest
        @return: ListUserIndustryRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.ListUserIndustryRolesHeaders()
        return self.list_user_industry_roles_with_options(request, headers, runtime)

    async def list_user_industry_roles_async(
        self,
        request: dingtalkresident__1__0_models.ListUserIndustryRolesRequest,
    ) -> dingtalkresident__1__0_models.ListUserIndustryRolesResponse:
        """
        @summary 获取用户行业化角色
        
        @param request: ListUserIndustryRolesRequest
        @return: ListUserIndustryRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.ListUserIndustryRolesHeaders()
        return await self.list_user_industry_roles_with_options_async(request, headers, runtime)

    def page_point_history_with_options(
        self,
        request: dingtalkresident__1__0_models.PagePointHistoryRequest,
        headers: dingtalkresident__1__0_models.PagePointHistoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.PagePointHistoryResponse:
        """
        @summary 查询数字区县居民积分流水
        
        @param request: PagePointHistoryRequest
        @param headers: PagePointHistoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PagePointHistoryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.is_circle):
            query['isCircle'] = request.is_circle
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='PagePointHistory',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/points/records',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.PagePointHistoryResponse(),
            self.execute(params, req, runtime)
        )

    async def page_point_history_with_options_async(
        self,
        request: dingtalkresident__1__0_models.PagePointHistoryRequest,
        headers: dingtalkresident__1__0_models.PagePointHistoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.PagePointHistoryResponse:
        """
        @summary 查询数字区县居民积分流水
        
        @param request: PagePointHistoryRequest
        @param headers: PagePointHistoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PagePointHistoryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.is_circle):
            query['isCircle'] = request.is_circle
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='PagePointHistory',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/points/records',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.PagePointHistoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def page_point_history(
        self,
        request: dingtalkresident__1__0_models.PagePointHistoryRequest,
    ) -> dingtalkresident__1__0_models.PagePointHistoryResponse:
        """
        @summary 查询数字区县居民积分流水
        
        @param request: PagePointHistoryRequest
        @return: PagePointHistoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.PagePointHistoryHeaders()
        return self.page_point_history_with_options(request, headers, runtime)

    async def page_point_history_async(
        self,
        request: dingtalkresident__1__0_models.PagePointHistoryRequest,
    ) -> dingtalkresident__1__0_models.PagePointHistoryResponse:
        """
        @summary 查询数字区县居民积分流水
        
        @param request: PagePointHistoryRequest
        @return: PagePointHistoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.PagePointHistoryHeaders()
        return await self.page_point_history_with_options_async(request, headers, runtime)

    def remove_resident_member_with_options(
        self,
        request: dingtalkresident__1__0_models.RemoveResidentMemberRequest,
        headers: dingtalkresident__1__0_models.RemoveResidentMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.RemoveResidentMemberResponse:
        """
        @summary 从空间中删除人员
        
        @param request: RemoveResidentMemberRequest
        @param headers: RemoveResidentMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveResidentMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
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
            action='RemoveResidentMember',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.RemoveResidentMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_resident_member_with_options_async(
        self,
        request: dingtalkresident__1__0_models.RemoveResidentMemberRequest,
        headers: dingtalkresident__1__0_models.RemoveResidentMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.RemoveResidentMemberResponse:
        """
        @summary 从空间中删除人员
        
        @param request: RemoveResidentMemberRequest
        @param headers: RemoveResidentMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveResidentMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
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
            action='RemoveResidentMember',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.RemoveResidentMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_resident_member(
        self,
        request: dingtalkresident__1__0_models.RemoveResidentMemberRequest,
    ) -> dingtalkresident__1__0_models.RemoveResidentMemberResponse:
        """
        @summary 从空间中删除人员
        
        @param request: RemoveResidentMemberRequest
        @return: RemoveResidentMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.RemoveResidentMemberHeaders()
        return self.remove_resident_member_with_options(request, headers, runtime)

    async def remove_resident_member_async(
        self,
        request: dingtalkresident__1__0_models.RemoveResidentMemberRequest,
    ) -> dingtalkresident__1__0_models.RemoveResidentMemberResponse:
        """
        @summary 从空间中删除人员
        
        @param request: RemoveResidentMemberRequest
        @return: RemoveResidentMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.RemoveResidentMemberHeaders()
        return await self.remove_resident_member_with_options_async(request, headers, runtime)

    def remove_resident_user_with_options(
        self,
        request: dingtalkresident__1__0_models.RemoveResidentUserRequest,
        headers: dingtalkresident__1__0_models.RemoveResidentUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.RemoveResidentUserResponse:
        """
        @summary 从户内移除居民
        
        @param request: RemoveResidentUserRequest
        @param headers: RemoveResidentUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveResidentUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
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
            action='RemoveResidentUser',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/users/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.RemoveResidentUserResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_resident_user_with_options_async(
        self,
        request: dingtalkresident__1__0_models.RemoveResidentUserRequest,
        headers: dingtalkresident__1__0_models.RemoveResidentUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.RemoveResidentUserResponse:
        """
        @summary 从户内移除居民
        
        @param request: RemoveResidentUserRequest
        @param headers: RemoveResidentUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveResidentUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
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
            action='RemoveResidentUser',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/users/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.RemoveResidentUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_resident_user(
        self,
        request: dingtalkresident__1__0_models.RemoveResidentUserRequest,
    ) -> dingtalkresident__1__0_models.RemoveResidentUserResponse:
        """
        @summary 从户内移除居民
        
        @param request: RemoveResidentUserRequest
        @return: RemoveResidentUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.RemoveResidentUserHeaders()
        return self.remove_resident_user_with_options(request, headers, runtime)

    async def remove_resident_user_async(
        self,
        request: dingtalkresident__1__0_models.RemoveResidentUserRequest,
    ) -> dingtalkresident__1__0_models.RemoveResidentUserResponse:
        """
        @summary 从户内移除居民
        
        @param request: RemoveResidentUserRequest
        @return: RemoveResidentUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.RemoveResidentUserHeaders()
        return await self.remove_resident_user_with_options_async(request, headers, runtime)

    def search_resident_with_options(
        self,
        request: dingtalkresident__1__0_models.SearchResidentRequest,
        headers: dingtalkresident__1__0_models.SearchResidentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.SearchResidentResponse:
        """
        @summary 搜索指定人员
        
        @param request: SearchResidentRequest
        @param headers: SearchResidentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchResidentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.resident_crop_id):
            query['residentCropId'] = request.resident_crop_id
        if not UtilClient.is_unset(request.search_word):
            query['searchWord'] = request.search_word
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SearchResident',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/residences',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.SearchResidentResponse(),
            self.execute(params, req, runtime)
        )

    async def search_resident_with_options_async(
        self,
        request: dingtalkresident__1__0_models.SearchResidentRequest,
        headers: dingtalkresident__1__0_models.SearchResidentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.SearchResidentResponse:
        """
        @summary 搜索指定人员
        
        @param request: SearchResidentRequest
        @param headers: SearchResidentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchResidentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.resident_crop_id):
            query['residentCropId'] = request.resident_crop_id
        if not UtilClient.is_unset(request.search_word):
            query['searchWord'] = request.search_word
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='SearchResident',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/residences',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.SearchResidentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_resident(
        self,
        request: dingtalkresident__1__0_models.SearchResidentRequest,
    ) -> dingtalkresident__1__0_models.SearchResidentResponse:
        """
        @summary 搜索指定人员
        
        @param request: SearchResidentRequest
        @return: SearchResidentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.SearchResidentHeaders()
        return self.search_resident_with_options(request, headers, runtime)

    async def search_resident_async(
        self,
        request: dingtalkresident__1__0_models.SearchResidentRequest,
    ) -> dingtalkresident__1__0_models.SearchResidentResponse:
        """
        @summary 搜索指定人员
        
        @param request: SearchResidentRequest
        @return: SearchResidentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.SearchResidentHeaders()
        return await self.search_resident_with_options_async(request, headers, runtime)

    def update_residece_group_with_options(
        self,
        request: dingtalkresident__1__0_models.UpdateResideceGroupRequest,
        headers: dingtalkresident__1__0_models.UpdateResideceGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResideceGroupResponse:
        """
        @summary 更新组信息
        
        @param request: UpdateResideceGroupRequest
        @param headers: UpdateResideceGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResideceGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.department_name):
            query['departmentName'] = request.department_name
        if not UtilClient.is_unset(request.manager_user_id):
            query['managerUserId'] = request.manager_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateResideceGroup',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/departments/updateResideceGroup',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResideceGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def update_residece_group_with_options_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResideceGroupRequest,
        headers: dingtalkresident__1__0_models.UpdateResideceGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResideceGroupResponse:
        """
        @summary 更新组信息
        
        @param request: UpdateResideceGroupRequest
        @param headers: UpdateResideceGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResideceGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.department_name):
            query['departmentName'] = request.department_name
        if not UtilClient.is_unset(request.manager_user_id):
            query['managerUserId'] = request.manager_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateResideceGroup',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/departments/updateResideceGroup',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResideceGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_residece_group(
        self,
        request: dingtalkresident__1__0_models.UpdateResideceGroupRequest,
    ) -> dingtalkresident__1__0_models.UpdateResideceGroupResponse:
        """
        @summary 更新组信息
        
        @param request: UpdateResideceGroupRequest
        @return: UpdateResideceGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResideceGroupHeaders()
        return self.update_residece_group_with_options(request, headers, runtime)

    async def update_residece_group_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResideceGroupRequest,
    ) -> dingtalkresident__1__0_models.UpdateResideceGroupResponse:
        """
        @summary 更新组信息
        
        @param request: UpdateResideceGroupRequest
        @return: UpdateResideceGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResideceGroupHeaders()
        return await self.update_residece_group_with_options_async(request, headers, runtime)

    def update_residence_with_options(
        self,
        request: dingtalkresident__1__0_models.UpdateResidenceRequest,
        headers: dingtalkresident__1__0_models.UpdateResidenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResidenceResponse:
        """
        @summary 更新户信息
        
        @param request: UpdateResidenceRequest
        @param headers: UpdateResidenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResidenceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.department_name):
            query['departmentName'] = request.department_name
        if not UtilClient.is_unset(request.destitute):
            query['destitute'] = request.destitute
        if not UtilClient.is_unset(request.grid):
            query['grid'] = request.grid
        if not UtilClient.is_unset(request.home_tel):
            query['homeTel'] = request.home_tel
        if not UtilClient.is_unset(request.manager_user_id):
            query['managerUserId'] = request.manager_user_id
        if not UtilClient.is_unset(request.parent_department_id):
            query['parentDepartmentId'] = request.parent_department_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateResidence',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/departments/updateResidece',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResidenceResponse(),
            self.execute(params, req, runtime)
        )

    async def update_residence_with_options_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResidenceRequest,
        headers: dingtalkresident__1__0_models.UpdateResidenceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResidenceResponse:
        """
        @summary 更新户信息
        
        @param request: UpdateResidenceRequest
        @param headers: UpdateResidenceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResidenceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.department_name):
            query['departmentName'] = request.department_name
        if not UtilClient.is_unset(request.destitute):
            query['destitute'] = request.destitute
        if not UtilClient.is_unset(request.grid):
            query['grid'] = request.grid
        if not UtilClient.is_unset(request.home_tel):
            query['homeTel'] = request.home_tel
        if not UtilClient.is_unset(request.manager_user_id):
            query['managerUserId'] = request.manager_user_id
        if not UtilClient.is_unset(request.parent_department_id):
            query['parentDepartmentId'] = request.parent_department_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateResidence',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/departments/updateResidece',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResidenceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_residence(
        self,
        request: dingtalkresident__1__0_models.UpdateResidenceRequest,
    ) -> dingtalkresident__1__0_models.UpdateResidenceResponse:
        """
        @summary 更新户信息
        
        @param request: UpdateResidenceRequest
        @return: UpdateResidenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResidenceHeaders()
        return self.update_residence_with_options(request, headers, runtime)

    async def update_residence_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResidenceRequest,
    ) -> dingtalkresident__1__0_models.UpdateResidenceResponse:
        """
        @summary 更新户信息
        
        @param request: UpdateResidenceRequest
        @return: UpdateResidenceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResidenceHeaders()
        return await self.update_residence_with_options_async(request, headers, runtime)

    def update_resident_black_board_with_options(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentBlackBoardRequest,
        headers: dingtalkresident__1__0_models.UpdateResidentBlackBoardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResidentBlackBoardResponse:
        """
        @summary 更新小区公告
        
        @param request: UpdateResidentBlackBoardRequest
        @param headers: UpdateResidentBlackBoardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResidentBlackBoardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.blackboard_id):
            body['blackboardId'] = request.blackboard_id
        if not UtilClient.is_unset(request.context):
            body['context'] = request.context
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            action='UpdateResidentBlackBoard',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/blackboards',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResidentBlackBoardResponse(),
            self.execute(params, req, runtime)
        )

    async def update_resident_black_board_with_options_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentBlackBoardRequest,
        headers: dingtalkresident__1__0_models.UpdateResidentBlackBoardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResidentBlackBoardResponse:
        """
        @summary 更新小区公告
        
        @param request: UpdateResidentBlackBoardRequest
        @param headers: UpdateResidentBlackBoardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResidentBlackBoardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.blackboard_id):
            body['blackboardId'] = request.blackboard_id
        if not UtilClient.is_unset(request.context):
            body['context'] = request.context
        if not UtilClient.is_unset(request.media_id):
            body['mediaId'] = request.media_id
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
            action='UpdateResidentBlackBoard',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/blackboards',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResidentBlackBoardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_resident_black_board(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentBlackBoardRequest,
    ) -> dingtalkresident__1__0_models.UpdateResidentBlackBoardResponse:
        """
        @summary 更新小区公告
        
        @param request: UpdateResidentBlackBoardRequest
        @return: UpdateResidentBlackBoardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResidentBlackBoardHeaders()
        return self.update_resident_black_board_with_options(request, headers, runtime)

    async def update_resident_black_board_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentBlackBoardRequest,
    ) -> dingtalkresident__1__0_models.UpdateResidentBlackBoardResponse:
        """
        @summary 更新小区公告
        
        @param request: UpdateResidentBlackBoardRequest
        @return: UpdateResidentBlackBoardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResidentBlackBoardHeaders()
        return await self.update_resident_black_board_with_options_async(request, headers, runtime)

    def update_resident_info_with_options(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentInfoRequest,
        headers: dingtalkresident__1__0_models.UpdateResidentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResidentInfoResponse:
        """
        @summary 更新小区信息
        
        @param request: UpdateResidentInfoRequest
        @param headers: UpdateResidentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResidentInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.building_area):
            body['buildingArea'] = request.building_area
        if not UtilClient.is_unset(request.city_name):
            body['cityName'] = request.city_name
        if not UtilClient.is_unset(request.community_type):
            body['communityType'] = request.community_type
        if not UtilClient.is_unset(request.county_name):
            body['countyName'] = request.county_name
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.prov_name):
            body['provName'] = request.prov_name
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
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
            action='UpdateResidentInfo',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/residences',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResidentInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def update_resident_info_with_options_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentInfoRequest,
        headers: dingtalkresident__1__0_models.UpdateResidentInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResidentInfoResponse:
        """
        @summary 更新小区信息
        
        @param request: UpdateResidentInfoRequest
        @param headers: UpdateResidentInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResidentInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.address):
            body['address'] = request.address
        if not UtilClient.is_unset(request.building_area):
            body['buildingArea'] = request.building_area
        if not UtilClient.is_unset(request.city_name):
            body['cityName'] = request.city_name
        if not UtilClient.is_unset(request.community_type):
            body['communityType'] = request.community_type
        if not UtilClient.is_unset(request.county_name):
            body['countyName'] = request.county_name
        if not UtilClient.is_unset(request.location):
            body['location'] = request.location
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.prov_name):
            body['provName'] = request.prov_name
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
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
            action='UpdateResidentInfo',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/residences',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResidentInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_resident_info(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentInfoRequest,
    ) -> dingtalkresident__1__0_models.UpdateResidentInfoResponse:
        """
        @summary 更新小区信息
        
        @param request: UpdateResidentInfoRequest
        @return: UpdateResidentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResidentInfoHeaders()
        return self.update_resident_info_with_options(request, headers, runtime)

    async def update_resident_info_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentInfoRequest,
    ) -> dingtalkresident__1__0_models.UpdateResidentInfoResponse:
        """
        @summary 更新小区信息
        
        @param request: UpdateResidentInfoRequest
        @return: UpdateResidentInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResidentInfoHeaders()
        return await self.update_resident_info_with_options_async(request, headers, runtime)

    def update_resident_member_with_options(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentMemberRequest,
        headers: dingtalkresident__1__0_models.UpdateResidentMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResidentMemberResponse:
        """
        @summary 更新小区成员
        
        @param request: UpdateResidentMemberRequest
        @param headers: UpdateResidentMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResidentMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.resident_update_info):
            body['residentUpdateInfo'] = request.resident_update_info
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
            action='UpdateResidentMember',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResidentMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def update_resident_member_with_options_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentMemberRequest,
        headers: dingtalkresident__1__0_models.UpdateResidentMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResidentMemberResponse:
        """
        @summary 更新小区成员
        
        @param request: UpdateResidentMemberRequest
        @param headers: UpdateResidentMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResidentMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.resident_update_info):
            body['residentUpdateInfo'] = request.resident_update_info
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
            action='UpdateResidentMember',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResidentMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_resident_member(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentMemberRequest,
    ) -> dingtalkresident__1__0_models.UpdateResidentMemberResponse:
        """
        @summary 更新小区成员
        
        @param request: UpdateResidentMemberRequest
        @return: UpdateResidentMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResidentMemberHeaders()
        return self.update_resident_member_with_options(request, headers, runtime)

    async def update_resident_member_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentMemberRequest,
    ) -> dingtalkresident__1__0_models.UpdateResidentMemberResponse:
        """
        @summary 更新小区成员
        
        @param request: UpdateResidentMemberRequest
        @return: UpdateResidentMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResidentMemberHeaders()
        return await self.update_resident_member_with_options_async(request, headers, runtime)

    def update_resident_user_with_options(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentUserRequest,
        headers: dingtalkresident__1__0_models.UpdateResidentUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResidentUserResponse:
        """
        @summary 更新居民信息
        
        @param request: UpdateResidentUserRequest
        @param headers: UpdateResidentUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResidentUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.address):
            query['address'] = request.address
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.ext_field):
            query['extField'] = request.ext_field
        if not UtilClient.is_unset(request.is_retain_old_dept):
            query['isRetainOldDept'] = request.is_retain_old_dept
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        if not UtilClient.is_unset(request.old_department_id):
            query['oldDepartmentId'] = request.old_department_id
        if not UtilClient.is_unset(request.relate_type):
            query['relateType'] = request.relate_type
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_name):
            query['userName'] = request.user_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateResidentUser',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/users',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResidentUserResponse(),
            self.execute(params, req, runtime)
        )

    async def update_resident_user_with_options_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentUserRequest,
        headers: dingtalkresident__1__0_models.UpdateResidentUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateResidentUserResponse:
        """
        @summary 更新居民信息
        
        @param request: UpdateResidentUserRequest
        @param headers: UpdateResidentUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateResidentUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.address):
            query['address'] = request.address
        if not UtilClient.is_unset(request.department_id):
            query['departmentId'] = request.department_id
        if not UtilClient.is_unset(request.ext_field):
            query['extField'] = request.ext_field
        if not UtilClient.is_unset(request.is_retain_old_dept):
            query['isRetainOldDept'] = request.is_retain_old_dept
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
        if not UtilClient.is_unset(request.old_department_id):
            query['oldDepartmentId'] = request.old_department_id
        if not UtilClient.is_unset(request.relate_type):
            query['relateType'] = request.relate_type
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_name):
            query['userName'] = request.user_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='UpdateResidentUser',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/users',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateResidentUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_resident_user(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentUserRequest,
    ) -> dingtalkresident__1__0_models.UpdateResidentUserResponse:
        """
        @summary 更新居民信息
        
        @param request: UpdateResidentUserRequest
        @return: UpdateResidentUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResidentUserHeaders()
        return self.update_resident_user_with_options(request, headers, runtime)

    async def update_resident_user_async(
        self,
        request: dingtalkresident__1__0_models.UpdateResidentUserRequest,
    ) -> dingtalkresident__1__0_models.UpdateResidentUserResponse:
        """
        @summary 更新居民信息
        
        @param request: UpdateResidentUserRequest
        @return: UpdateResidentUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateResidentUserHeaders()
        return await self.update_resident_user_with_options_async(request, headers, runtime)

    def update_space_with_options(
        self,
        request: dingtalkresident__1__0_models.UpdateSpaceRequest,
        headers: dingtalkresident__1__0_models.UpdateSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateSpaceResponse:
        """
        @summary 更新小区空间，含分区，楼栋，单元，房屋等信息
        
        @param request: UpdateSpaceRequest
        @param headers: UpdateSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.space_info_volist):
            body['spaceInfoVOList'] = request.space_info_volist
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateSpace',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def update_space_with_options_async(
        self,
        request: dingtalkresident__1__0_models.UpdateSpaceRequest,
        headers: dingtalkresident__1__0_models.UpdateSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkresident__1__0_models.UpdateSpaceResponse:
        """
        @summary 更新小区空间，含分区，楼栋，单元，房屋等信息
        
        @param request: UpdateSpaceRequest
        @param headers: UpdateSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.space_info_volist):
            body['spaceInfoVOList'] = request.space_info_volist
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateSpace',
            version='resident_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/resident/spaces',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkresident__1__0_models.UpdateSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_space(
        self,
        request: dingtalkresident__1__0_models.UpdateSpaceRequest,
    ) -> dingtalkresident__1__0_models.UpdateSpaceResponse:
        """
        @summary 更新小区空间，含分区，楼栋，单元，房屋等信息
        
        @param request: UpdateSpaceRequest
        @return: UpdateSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateSpaceHeaders()
        return self.update_space_with_options(request, headers, runtime)

    async def update_space_async(
        self,
        request: dingtalkresident__1__0_models.UpdateSpaceRequest,
    ) -> dingtalkresident__1__0_models.UpdateSpaceResponse:
        """
        @summary 更新小区空间，含分区，楼栋，单元，房屋等信息
        
        @param request: UpdateSpaceRequest
        @return: UpdateSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkresident__1__0_models.UpdateSpaceHeaders()
        return await self.update_space_with_options_async(request, headers, runtime)
