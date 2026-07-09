# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.notable_1_0 import models as dingtalknotable__1__0_models
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

    def add_role_member_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.AddRoleMemberRequest,
        headers: dingtalknotable__1__0_models.AddRoleMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.AddRoleMemberResponse:
        """
        @summary 添加角色成员
        
        @param request: AddRoleMemberRequest
        @param headers: AddRoleMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddRoleMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.role_member_list):
            body['roleMemberList'] = request.role_member_list
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
            action='AddRoleMember',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/member/{base_id}',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.AddRoleMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def add_role_member_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.AddRoleMemberRequest,
        headers: dingtalknotable__1__0_models.AddRoleMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.AddRoleMemberResponse:
        """
        @summary 添加角色成员
        
        @param request: AddRoleMemberRequest
        @param headers: AddRoleMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddRoleMemberResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.role_member_list):
            body['roleMemberList'] = request.role_member_list
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
            action='AddRoleMember',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/member/{base_id}',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.AddRoleMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_role_member(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.AddRoleMemberRequest,
    ) -> dingtalknotable__1__0_models.AddRoleMemberResponse:
        """
        @summary 添加角色成员
        
        @param request: AddRoleMemberRequest
        @return: AddRoleMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.AddRoleMemberHeaders()
        return self.add_role_member_with_options(base_id, request, headers, runtime)

    async def add_role_member_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.AddRoleMemberRequest,
    ) -> dingtalknotable__1__0_models.AddRoleMemberResponse:
        """
        @summary 添加角色成员
        
        @param request: AddRoleMemberRequest
        @return: AddRoleMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.AddRoleMemberHeaders()
        return await self.add_role_member_with_options_async(base_id, request, headers, runtime)

    def change_switch_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ChangeSwitchRequest,
        headers: dingtalknotable__1__0_models.ChangeSwitchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.ChangeSwitchResponse:
        """
        @summary 修改高级权限设置开关
        
        @param request: ChangeSwitchRequest
        @param headers: ChangeSwitchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChangeSwitchResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.value):
            body['value'] = request.value
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
            action='ChangeSwitch',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/{base_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.ChangeSwitchResponse(),
            self.execute(params, req, runtime)
        )

    async def change_switch_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ChangeSwitchRequest,
        headers: dingtalknotable__1__0_models.ChangeSwitchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.ChangeSwitchResponse:
        """
        @summary 修改高级权限设置开关
        
        @param request: ChangeSwitchRequest
        @param headers: ChangeSwitchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChangeSwitchResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.value):
            body['value'] = request.value
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
            action='ChangeSwitch',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/{base_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.ChangeSwitchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def change_switch(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ChangeSwitchRequest,
    ) -> dingtalknotable__1__0_models.ChangeSwitchResponse:
        """
        @summary 修改高级权限设置开关
        
        @param request: ChangeSwitchRequest
        @return: ChangeSwitchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.ChangeSwitchHeaders()
        return self.change_switch_with_options(base_id, request, headers, runtime)

    async def change_switch_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ChangeSwitchRequest,
    ) -> dingtalknotable__1__0_models.ChangeSwitchResponse:
        """
        @summary 修改高级权限设置开关
        
        @param request: ChangeSwitchRequest
        @return: ChangeSwitchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.ChangeSwitchHeaders()
        return await self.change_switch_with_options_async(base_id, request, headers, runtime)

    def create_field_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.CreateFieldRequest,
        headers: dingtalknotable__1__0_models.CreateFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.CreateFieldResponse:
        """
        @summary 新增数据表字段
        
        @param request: CreateFieldRequest
        @param headers: CreateFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateFieldResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.property):
            body['property'] = request.property
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.CreateFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def create_field_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.CreateFieldRequest,
        headers: dingtalknotable__1__0_models.CreateFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.CreateFieldResponse:
        """
        @summary 新增数据表字段
        
        @param request: CreateFieldRequest
        @param headers: CreateFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateFieldResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.property):
            body['property'] = request.property
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
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
            action='CreateField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.CreateFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_field(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.CreateFieldRequest,
    ) -> dingtalknotable__1__0_models.CreateFieldResponse:
        """
        @summary 新增数据表字段
        
        @param request: CreateFieldRequest
        @return: CreateFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.CreateFieldHeaders()
        return self.create_field_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def create_field_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.CreateFieldRequest,
    ) -> dingtalknotable__1__0_models.CreateFieldResponse:
        """
        @summary 新增数据表字段
        
        @param request: CreateFieldRequest
        @return: CreateFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.CreateFieldHeaders()
        return await self.create_field_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def create_role_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateRoleRequest,
        headers: dingtalknotable__1__0_models.CreateRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.CreateRoleResponse:
        """
        @summary 创建角色
        
        @param request: CreateRoleRequest
        @param headers: CreateRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.flow_type):
            body['flowType'] = request.flow_type
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.role_type):
            body['roleType'] = request.role_type
        if not UtilClient.is_unset(request.sub_roles):
            body['subRoles'] = request.sub_roles
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
            action='CreateRole',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/{base_id}',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.CreateRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def create_role_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateRoleRequest,
        headers: dingtalknotable__1__0_models.CreateRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.CreateRoleResponse:
        """
        @summary 创建角色
        
        @param request: CreateRoleRequest
        @param headers: CreateRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.flow_type):
            body['flowType'] = request.flow_type
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.role_type):
            body['roleType'] = request.role_type
        if not UtilClient.is_unset(request.sub_roles):
            body['subRoles'] = request.sub_roles
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
            action='CreateRole',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/{base_id}',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.CreateRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_role(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateRoleRequest,
    ) -> dingtalknotable__1__0_models.CreateRoleResponse:
        """
        @summary 创建角色
        
        @param request: CreateRoleRequest
        @return: CreateRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.CreateRoleHeaders()
        return self.create_role_with_options(base_id, request, headers, runtime)

    async def create_role_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateRoleRequest,
    ) -> dingtalknotable__1__0_models.CreateRoleResponse:
        """
        @summary 创建角色
        
        @param request: CreateRoleRequest
        @return: CreateRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.CreateRoleHeaders()
        return await self.create_role_with_options_async(base_id, request, headers, runtime)

    def create_sheet_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateSheetRequest,
        headers: dingtalknotable__1__0_models.CreateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.CreateSheetResponse:
        """
        @summary 创建数据表
        
        @param request: CreateSheetRequest
        @param headers: CreateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.fields):
            body['fields'] = request.fields
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='CreateSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.CreateSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def create_sheet_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateSheetRequest,
        headers: dingtalknotable__1__0_models.CreateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.CreateSheetResponse:
        """
        @summary 创建数据表
        
        @param request: CreateSheetRequest
        @param headers: CreateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.fields):
            body['fields'] = request.fields
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='CreateSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.CreateSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_sheet(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateSheetRequest,
    ) -> dingtalknotable__1__0_models.CreateSheetResponse:
        """
        @summary 创建数据表
        
        @param request: CreateSheetRequest
        @return: CreateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.CreateSheetHeaders()
        return self.create_sheet_with_options(base_id, request, headers, runtime)

    async def create_sheet_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.CreateSheetRequest,
    ) -> dingtalknotable__1__0_models.CreateSheetResponse:
        """
        @summary 创建数据表
        
        @param request: CreateSheetRequest
        @return: CreateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.CreateSheetHeaders()
        return await self.create_sheet_with_options_async(base_id, request, headers, runtime)

    def delete_field_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteFieldRequest,
        headers: dingtalknotable__1__0_models.DeleteFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteFieldResponse:
        """
        @summary 删除数据表字段
        
        @param request: DeleteFieldRequest
        @param headers: DeleteFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteFieldResponse
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
            action='DeleteField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields/{field_id_or_name}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_field_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteFieldRequest,
        headers: dingtalknotable__1__0_models.DeleteFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteFieldResponse:
        """
        @summary 删除数据表字段
        
        @param request: DeleteFieldRequest
        @param headers: DeleteFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteFieldResponse
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
            action='DeleteField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields/{field_id_or_name}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_field(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteFieldRequest,
    ) -> dingtalknotable__1__0_models.DeleteFieldResponse:
        """
        @summary 删除数据表字段
        
        @param request: DeleteFieldRequest
        @return: DeleteFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteFieldHeaders()
        return self.delete_field_with_options(base_id, sheet_id_or_name, field_id_or_name, request, headers, runtime)

    async def delete_field_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteFieldRequest,
    ) -> dingtalknotable__1__0_models.DeleteFieldResponse:
        """
        @summary 删除数据表字段
        
        @param request: DeleteFieldRequest
        @return: DeleteFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteFieldHeaders()
        return await self.delete_field_with_options_async(base_id, sheet_id_or_name, field_id_or_name, request, headers, runtime)

    def delete_records_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteRecordsRequest,
        headers: dingtalknotable__1__0_models.DeleteRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteRecordsResponse:
        """
        @summary 删除数据表多行记录
        
        @param request: DeleteRecordsRequest
        @param headers: DeleteRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.record_ids):
            body['recordIds'] = request.record_ids
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
            action='DeleteRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/delete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_records_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteRecordsRequest,
        headers: dingtalknotable__1__0_models.DeleteRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteRecordsResponse:
        """
        @summary 删除数据表多行记录
        
        @param request: DeleteRecordsRequest
        @param headers: DeleteRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.record_ids):
            body['recordIds'] = request.record_ids
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
            action='DeleteRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/delete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_records(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteRecordsRequest,
    ) -> dingtalknotable__1__0_models.DeleteRecordsResponse:
        """
        @summary 删除数据表多行记录
        
        @param request: DeleteRecordsRequest
        @return: DeleteRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteRecordsHeaders()
        return self.delete_records_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def delete_records_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteRecordsRequest,
    ) -> dingtalknotable__1__0_models.DeleteRecordsResponse:
        """
        @summary 删除数据表多行记录
        
        @param request: DeleteRecordsRequest
        @return: DeleteRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteRecordsHeaders()
        return await self.delete_records_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def delete_role_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.DeleteRoleRequest,
        headers: dingtalknotable__1__0_models.DeleteRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteRoleResponse:
        """
        @summary 删除角色
        
        @param request: DeleteRoleRequest
        @param headers: DeleteRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.role_id):
            body['roleId'] = request.role_id
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
            action='DeleteRole',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/{base_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_role_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.DeleteRoleRequest,
        headers: dingtalknotable__1__0_models.DeleteRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteRoleResponse:
        """
        @summary 删除角色
        
        @param request: DeleteRoleRequest
        @param headers: DeleteRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.role_id):
            body['roleId'] = request.role_id
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
            action='DeleteRole',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/{base_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_role(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.DeleteRoleRequest,
    ) -> dingtalknotable__1__0_models.DeleteRoleResponse:
        """
        @summary 删除角色
        
        @param request: DeleteRoleRequest
        @return: DeleteRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteRoleHeaders()
        return self.delete_role_with_options(base_id, request, headers, runtime)

    async def delete_role_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.DeleteRoleRequest,
    ) -> dingtalknotable__1__0_models.DeleteRoleResponse:
        """
        @summary 删除角色
        
        @param request: DeleteRoleRequest
        @return: DeleteRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteRoleHeaders()
        return await self.delete_role_with_options_async(base_id, request, headers, runtime)

    def delete_sheet_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteSheetRequest,
        headers: dingtalknotable__1__0_models.DeleteSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteSheetResponse:
        """
        @summary 删除数据表
        
        @param request: DeleteSheetRequest
        @param headers: DeleteSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSheetResponse
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
            action='DeleteSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_sheet_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteSheetRequest,
        headers: dingtalknotable__1__0_models.DeleteSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.DeleteSheetResponse:
        """
        @summary 删除数据表
        
        @param request: DeleteSheetRequest
        @param headers: DeleteSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteSheetResponse
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
            action='DeleteSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.DeleteSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_sheet(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteSheetRequest,
    ) -> dingtalknotable__1__0_models.DeleteSheetResponse:
        """
        @summary 删除数据表
        
        @param request: DeleteSheetRequest
        @return: DeleteSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteSheetHeaders()
        return self.delete_sheet_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def delete_sheet_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.DeleteSheetRequest,
    ) -> dingtalknotable__1__0_models.DeleteSheetResponse:
        """
        @summary 删除数据表
        
        @param request: DeleteSheetRequest
        @return: DeleteSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.DeleteSheetHeaders()
        return await self.delete_sheet_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def enable_workflow_with_options(
        self,
        base_id: str,
        flow_id: str,
        request: dingtalknotable__1__0_models.EnableWorkflowRequest,
        headers: dingtalknotable__1__0_models.EnableWorkflowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.EnableWorkflowResponse:
        """
        @summary 启动单个工作流
        
        @param request: EnableWorkflowRequest
        @param headers: EnableWorkflowHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EnableWorkflowResponse
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
            action='EnableWorkflow',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/workflows/{flow_id}/enable',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.EnableWorkflowResponse(),
            self.execute(params, req, runtime)
        )

    async def enable_workflow_with_options_async(
        self,
        base_id: str,
        flow_id: str,
        request: dingtalknotable__1__0_models.EnableWorkflowRequest,
        headers: dingtalknotable__1__0_models.EnableWorkflowHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.EnableWorkflowResponse:
        """
        @summary 启动单个工作流
        
        @param request: EnableWorkflowRequest
        @param headers: EnableWorkflowHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EnableWorkflowResponse
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
            action='EnableWorkflow',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/workflows/{flow_id}/enable',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.EnableWorkflowResponse(),
            await self.execute_async(params, req, runtime)
        )

    def enable_workflow(
        self,
        base_id: str,
        flow_id: str,
        request: dingtalknotable__1__0_models.EnableWorkflowRequest,
    ) -> dingtalknotable__1__0_models.EnableWorkflowResponse:
        """
        @summary 启动单个工作流
        
        @param request: EnableWorkflowRequest
        @return: EnableWorkflowResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.EnableWorkflowHeaders()
        return self.enable_workflow_with_options(base_id, flow_id, request, headers, runtime)

    async def enable_workflow_async(
        self,
        base_id: str,
        flow_id: str,
        request: dingtalknotable__1__0_models.EnableWorkflowRequest,
    ) -> dingtalknotable__1__0_models.EnableWorkflowResponse:
        """
        @summary 启动单个工作流
        
        @param request: EnableWorkflowRequest
        @return: EnableWorkflowResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.EnableWorkflowHeaders()
        return await self.enable_workflow_with_options_async(base_id, flow_id, request, headers, runtime)

    def execute_import_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ExecuteImportRequest,
        headers: dingtalknotable__1__0_models.ExecuteImportHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.ExecuteImportResponse:
        """
        @summary 触发加密导入
        
        @param request: ExecuteImportRequest
        @param headers: ExecuteImportHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecuteImportResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.append_config):
            body['appendConfig'] = request.append_config
        if not UtilClient.is_unset(request.encryption):
            body['encryption'] = request.encryption
        if not UtilClient.is_unset(request.import_id):
            body['importId'] = request.import_id
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
            action='ExecuteImport',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/import/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.ExecuteImportResponse(),
            self.execute(params, req, runtime)
        )

    async def execute_import_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ExecuteImportRequest,
        headers: dingtalknotable__1__0_models.ExecuteImportHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.ExecuteImportResponse:
        """
        @summary 触发加密导入
        
        @param request: ExecuteImportRequest
        @param headers: ExecuteImportHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExecuteImportResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.append_config):
            body['appendConfig'] = request.append_config
        if not UtilClient.is_unset(request.encryption):
            body['encryption'] = request.encryption
        if not UtilClient.is_unset(request.import_id):
            body['importId'] = request.import_id
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
            action='ExecuteImport',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/import/execute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.ExecuteImportResponse(),
            await self.execute_async(params, req, runtime)
        )

    def execute_import(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ExecuteImportRequest,
    ) -> dingtalknotable__1__0_models.ExecuteImportResponse:
        """
        @summary 触发加密导入
        
        @param request: ExecuteImportRequest
        @return: ExecuteImportResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.ExecuteImportHeaders()
        return self.execute_import_with_options(base_id, request, headers, runtime)

    async def execute_import_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ExecuteImportRequest,
    ) -> dingtalknotable__1__0_models.ExecuteImportResponse:
        """
        @summary 触发加密导入
        
        @param request: ExecuteImportRequest
        @return: ExecuteImportResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.ExecuteImportHeaders()
        return await self.execute_import_with_options_async(base_id, request, headers, runtime)

    def get_all_fields_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetAllFieldsRequest,
        headers: dingtalknotable__1__0_models.GetAllFieldsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetAllFieldsResponse:
        """
        @summary 获取所有字段
        
        @param request: GetAllFieldsRequest
        @param headers: GetAllFieldsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllFieldsResponse
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
            action='GetAllFields',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetAllFieldsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_all_fields_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetAllFieldsRequest,
        headers: dingtalknotable__1__0_models.GetAllFieldsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetAllFieldsResponse:
        """
        @summary 获取所有字段
        
        @param request: GetAllFieldsRequest
        @param headers: GetAllFieldsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllFieldsResponse
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
            action='GetAllFields',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetAllFieldsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_all_fields(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetAllFieldsRequest,
    ) -> dingtalknotable__1__0_models.GetAllFieldsResponse:
        """
        @summary 获取所有字段
        
        @param request: GetAllFieldsRequest
        @return: GetAllFieldsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetAllFieldsHeaders()
        return self.get_all_fields_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def get_all_fields_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetAllFieldsRequest,
    ) -> dingtalknotable__1__0_models.GetAllFieldsResponse:
        """
        @summary 获取所有字段
        
        @param request: GetAllFieldsRequest
        @return: GetAllFieldsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetAllFieldsHeaders()
        return await self.get_all_fields_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def get_all_sheets_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetAllSheetsRequest,
        headers: dingtalknotable__1__0_models.GetAllSheetsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有数据表
        
        @param request: GetAllSheetsRequest
        @param headers: GetAllSheetsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllSheetsResponse
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
            action='GetAllSheets',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetAllSheetsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_all_sheets_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetAllSheetsRequest,
        headers: dingtalknotable__1__0_models.GetAllSheetsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有数据表
        
        @param request: GetAllSheetsRequest
        @param headers: GetAllSheetsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllSheetsResponse
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
            action='GetAllSheets',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetAllSheetsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_all_sheets(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetAllSheetsRequest,
    ) -> dingtalknotable__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有数据表
        
        @param request: GetAllSheetsRequest
        @return: GetAllSheetsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetAllSheetsHeaders()
        return self.get_all_sheets_with_options(base_id, request, headers, runtime)

    async def get_all_sheets_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetAllSheetsRequest,
    ) -> dingtalknotable__1__0_models.GetAllSheetsResponse:
        """
        @summary 获取所有数据表
        
        @param request: GetAllSheetsRequest
        @return: GetAllSheetsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetAllSheetsHeaders()
        return await self.get_all_sheets_with_options_async(base_id, request, headers, runtime)

    def get_import_encrypt_public_key_with_options(
        self,
        request: dingtalknotable__1__0_models.GetImportEncryptPublicKeyRequest,
        headers: dingtalknotable__1__0_models.GetImportEncryptPublicKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetImportEncryptPublicKeyResponse:
        """
        @summary 获取加密导入 RSA 公钥
        
        @param request: GetImportEncryptPublicKeyRequest
        @param headers: GetImportEncryptPublicKeyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetImportEncryptPublicKeyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.key_version):
            query['keyVersion'] = request.key_version
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
            action='GetImportEncryptPublicKey',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/import/encryptPublicKey',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetImportEncryptPublicKeyResponse(),
            self.execute(params, req, runtime)
        )

    async def get_import_encrypt_public_key_with_options_async(
        self,
        request: dingtalknotable__1__0_models.GetImportEncryptPublicKeyRequest,
        headers: dingtalknotable__1__0_models.GetImportEncryptPublicKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetImportEncryptPublicKeyResponse:
        """
        @summary 获取加密导入 RSA 公钥
        
        @param request: GetImportEncryptPublicKeyRequest
        @param headers: GetImportEncryptPublicKeyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetImportEncryptPublicKeyResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.key_version):
            query['keyVersion'] = request.key_version
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
            action='GetImportEncryptPublicKey',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/import/encryptPublicKey',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetImportEncryptPublicKeyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_import_encrypt_public_key(
        self,
        request: dingtalknotable__1__0_models.GetImportEncryptPublicKeyRequest,
    ) -> dingtalknotable__1__0_models.GetImportEncryptPublicKeyResponse:
        """
        @summary 获取加密导入 RSA 公钥
        
        @param request: GetImportEncryptPublicKeyRequest
        @return: GetImportEncryptPublicKeyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetImportEncryptPublicKeyHeaders()
        return self.get_import_encrypt_public_key_with_options(request, headers, runtime)

    async def get_import_encrypt_public_key_async(
        self,
        request: dingtalknotable__1__0_models.GetImportEncryptPublicKeyRequest,
    ) -> dingtalknotable__1__0_models.GetImportEncryptPublicKeyResponse:
        """
        @summary 获取加密导入 RSA 公钥
        
        @param request: GetImportEncryptPublicKeyRequest
        @return: GetImportEncryptPublicKeyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetImportEncryptPublicKeyHeaders()
        return await self.get_import_encrypt_public_key_with_options_async(request, headers, runtime)

    def get_record_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        record_id: str,
        request: dingtalknotable__1__0_models.GetRecordRequest,
        headers: dingtalknotable__1__0_models.GetRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetRecordResponse:
        """
        @summary 获取记录
        
        @param request: GetRecordRequest
        @param headers: GetRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecordResponse
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
            action='GetRecord',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/{record_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def get_record_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        record_id: str,
        request: dingtalknotable__1__0_models.GetRecordRequest,
        headers: dingtalknotable__1__0_models.GetRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetRecordResponse:
        """
        @summary 获取记录
        
        @param request: GetRecordRequest
        @param headers: GetRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecordResponse
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
            action='GetRecord',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/{record_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_record(
        self,
        base_id: str,
        sheet_id_or_name: str,
        record_id: str,
        request: dingtalknotable__1__0_models.GetRecordRequest,
    ) -> dingtalknotable__1__0_models.GetRecordResponse:
        """
        @summary 获取记录
        
        @param request: GetRecordRequest
        @return: GetRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetRecordHeaders()
        return self.get_record_with_options(base_id, sheet_id_or_name, record_id, request, headers, runtime)

    async def get_record_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        record_id: str,
        request: dingtalknotable__1__0_models.GetRecordRequest,
    ) -> dingtalknotable__1__0_models.GetRecordResponse:
        """
        @summary 获取记录
        
        @param request: GetRecordRequest
        @return: GetRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetRecordHeaders()
        return await self.get_record_with_options_async(base_id, sheet_id_or_name, record_id, request, headers, runtime)

    def get_records_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetRecordsRequest,
        headers: dingtalknotable__1__0_models.GetRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetRecordsResponse:
        """
        @summary 获取多行记录
        
        @param request: GetRecordsRequest
        @param headers: GetRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='GetRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_records_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetRecordsRequest,
        headers: dingtalknotable__1__0_models.GetRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetRecordsResponse:
        """
        @summary 获取多行记录
        
        @param request: GetRecordsRequest
        @param headers: GetRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='GetRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_records(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetRecordsRequest,
    ) -> dingtalknotable__1__0_models.GetRecordsResponse:
        """
        @summary 获取多行记录
        
        @param request: GetRecordsRequest
        @return: GetRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetRecordsHeaders()
        return self.get_records_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def get_records_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetRecordsRequest,
    ) -> dingtalknotable__1__0_models.GetRecordsResponse:
        """
        @summary 获取多行记录
        
        @param request: GetRecordsRequest
        @return: GetRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetRecordsHeaders()
        return await self.get_records_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def get_sheet_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetSheetRequest,
        headers: dingtalknotable__1__0_models.GetSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetSheetResponse:
        """
        @summary 获取数据表
        
        @param request: GetSheetRequest
        @param headers: GetSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSheetResponse
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
            action='GetSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def get_sheet_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetSheetRequest,
        headers: dingtalknotable__1__0_models.GetSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetSheetResponse:
        """
        @summary 获取数据表
        
        @param request: GetSheetRequest
        @param headers: GetSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSheetResponse
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
            action='GetSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_sheet(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetSheetRequest,
    ) -> dingtalknotable__1__0_models.GetSheetResponse:
        """
        @summary 获取数据表
        
        @param request: GetSheetRequest
        @return: GetSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetSheetHeaders()
        return self.get_sheet_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def get_sheet_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.GetSheetRequest,
    ) -> dingtalknotable__1__0_models.GetSheetResponse:
        """
        @summary 获取数据表
        
        @param request: GetSheetRequest
        @return: GetSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetSheetHeaders()
        return await self.get_sheet_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def get_switch_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetSwitchRequest,
        headers: dingtalknotable__1__0_models.GetSwitchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetSwitchResponse:
        """
        @summary 获取高级权限设置开关
        
        @param request: GetSwitchRequest
        @param headers: GetSwitchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSwitchResponse
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
            action='GetSwitch',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/{base_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetSwitchResponse(),
            self.execute(params, req, runtime)
        )

    async def get_switch_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetSwitchRequest,
        headers: dingtalknotable__1__0_models.GetSwitchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetSwitchResponse:
        """
        @summary 获取高级权限设置开关
        
        @param request: GetSwitchRequest
        @param headers: GetSwitchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSwitchResponse
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
            action='GetSwitch',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/{base_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetSwitchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_switch(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetSwitchRequest,
    ) -> dingtalknotable__1__0_models.GetSwitchResponse:
        """
        @summary 获取高级权限设置开关
        
        @param request: GetSwitchRequest
        @return: GetSwitchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetSwitchHeaders()
        return self.get_switch_with_options(base_id, request, headers, runtime)

    async def get_switch_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetSwitchRequest,
    ) -> dingtalknotable__1__0_models.GetSwitchResponse:
        """
        @summary 获取高级权限设置开关
        
        @param request: GetSwitchRequest
        @return: GetSwitchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetSwitchHeaders()
        return await self.get_switch_with_options_async(base_id, request, headers, runtime)

    def get_user_doc_roles_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetUserDocRolesRequest,
        headers: dingtalknotable__1__0_models.GetUserDocRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetUserDocRolesResponse:
        """
        @summary 获取指定用户的高级权限角色配置列表
        
        @param request: GetUserDocRolesRequest
        @param headers: GetUserDocRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserDocRolesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetUserDocRoles',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/{base_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetUserDocRolesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_doc_roles_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetUserDocRolesRequest,
        headers: dingtalknotable__1__0_models.GetUserDocRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.GetUserDocRolesResponse:
        """
        @summary 获取指定用户的高级权限角色配置列表
        
        @param request: GetUserDocRolesRequest
        @param headers: GetUserDocRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserDocRolesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetUserDocRoles',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/{base_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.GetUserDocRolesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_doc_roles(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetUserDocRolesRequest,
    ) -> dingtalknotable__1__0_models.GetUserDocRolesResponse:
        """
        @summary 获取指定用户的高级权限角色配置列表
        
        @param request: GetUserDocRolesRequest
        @return: GetUserDocRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetUserDocRolesHeaders()
        return self.get_user_doc_roles_with_options(base_id, request, headers, runtime)

    async def get_user_doc_roles_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.GetUserDocRolesRequest,
    ) -> dingtalknotable__1__0_models.GetUserDocRolesResponse:
        """
        @summary 获取指定用户的高级权限角色配置列表
        
        @param request: GetUserDocRolesRequest
        @return: GetUserDocRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.GetUserDocRolesHeaders()
        return await self.get_user_doc_roles_with_options_async(base_id, request, headers, runtime)

    def insert_records_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.InsertRecordsRequest,
        headers: dingtalknotable__1__0_models.InsertRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.InsertRecordsResponse:
        """
        @summary 新增记录
        
        @param request: InsertRecordsRequest
        @param headers: InsertRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.client_token):
            query['clientToken'] = request.client_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.records):
            body['records'] = request.records
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
            action='InsertRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.InsertRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def insert_records_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.InsertRecordsRequest,
        headers: dingtalknotable__1__0_models.InsertRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.InsertRecordsResponse:
        """
        @summary 新增记录
        
        @param request: InsertRecordsRequest
        @param headers: InsertRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InsertRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.client_token):
            query['clientToken'] = request.client_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.records):
            body['records'] = request.records
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
            action='InsertRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.InsertRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def insert_records(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.InsertRecordsRequest,
    ) -> dingtalknotable__1__0_models.InsertRecordsResponse:
        """
        @summary 新增记录
        
        @param request: InsertRecordsRequest
        @return: InsertRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.InsertRecordsHeaders()
        return self.insert_records_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def insert_records_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.InsertRecordsRequest,
    ) -> dingtalknotable__1__0_models.InsertRecordsResponse:
        """
        @summary 新增记录
        
        @param request: InsertRecordsRequest
        @return: InsertRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.InsertRecordsHeaders()
        return await self.insert_records_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def list_records_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.ListRecordsRequest,
        headers: dingtalknotable__1__0_models.ListRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.ListRecordsResponse:
        """
        @summary 列出多行记录
        
        @param request: ListRecordsRequest
        @param headers: ListRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.field_id_or_names):
            body['fieldIdOrNames'] = request.field_id_or_names
        if not UtilClient.is_unset(request.filter):
            body['filter'] = request.filter
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
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
            action='ListRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.ListRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_records_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.ListRecordsRequest,
        headers: dingtalknotable__1__0_models.ListRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.ListRecordsResponse:
        """
        @summary 列出多行记录
        
        @param request: ListRecordsRequest
        @param headers: ListRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.field_id_or_names):
            body['fieldIdOrNames'] = request.field_id_or_names
        if not UtilClient.is_unset(request.filter):
            body['filter'] = request.filter
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
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
            action='ListRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/list',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.ListRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_records(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.ListRecordsRequest,
    ) -> dingtalknotable__1__0_models.ListRecordsResponse:
        """
        @summary 列出多行记录
        
        @param request: ListRecordsRequest
        @return: ListRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.ListRecordsHeaders()
        return self.list_records_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def list_records_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.ListRecordsRequest,
    ) -> dingtalknotable__1__0_models.ListRecordsResponse:
        """
        @summary 列出多行记录
        
        @param request: ListRecordsRequest
        @return: ListRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.ListRecordsHeaders()
        return await self.list_records_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def list_workflows_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ListWorkflowsRequest,
        headers: dingtalknotable__1__0_models.ListWorkflowsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.ListWorkflowsResponse:
        """
        @summary 查询自动化工作流列表
        
        @param request: ListWorkflowsRequest
        @param headers: ListWorkflowsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListWorkflowsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.limit):
            body['limit'] = request.limit
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
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
            action='ListWorkflows',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/workflows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.ListWorkflowsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_workflows_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ListWorkflowsRequest,
        headers: dingtalknotable__1__0_models.ListWorkflowsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.ListWorkflowsResponse:
        """
        @summary 查询自动化工作流列表
        
        @param request: ListWorkflowsRequest
        @param headers: ListWorkflowsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListWorkflowsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.limit):
            body['limit'] = request.limit
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
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
            action='ListWorkflows',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/workflows',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.ListWorkflowsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_workflows(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ListWorkflowsRequest,
    ) -> dingtalknotable__1__0_models.ListWorkflowsResponse:
        """
        @summary 查询自动化工作流列表
        
        @param request: ListWorkflowsRequest
        @return: ListWorkflowsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.ListWorkflowsHeaders()
        return self.list_workflows_with_options(base_id, request, headers, runtime)

    async def list_workflows_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.ListWorkflowsRequest,
    ) -> dingtalknotable__1__0_models.ListWorkflowsResponse:
        """
        @summary 查询自动化工作流列表
        
        @param request: ListWorkflowsRequest
        @return: ListWorkflowsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.ListWorkflowsHeaders()
        return await self.list_workflows_with_options_async(base_id, request, headers, runtime)

    def mark_external_auth_controlled_sheet_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.MarkExternalAuthControlledSheetRequest,
        headers: dingtalknotable__1__0_models.MarkExternalAuthControlledSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.MarkExternalAuthControlledSheetResponse:
        """
        @summary 标记外部权限受控 Sheet
        
        @param request: MarkExternalAuthControlledSheetRequest
        @param headers: MarkExternalAuthControlledSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MarkExternalAuthControlledSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.client_token):
            query['clientToken'] = request.client_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.external_auth_type):
            body['externalAuthType'] = request.external_auth_type
        if not UtilClient.is_unset(request.external_config):
            body['externalConfig'] = request.external_config
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
            action='MarkExternalAuthControlledSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/externalAuth/mark',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.MarkExternalAuthControlledSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def mark_external_auth_controlled_sheet_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.MarkExternalAuthControlledSheetRequest,
        headers: dingtalknotable__1__0_models.MarkExternalAuthControlledSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.MarkExternalAuthControlledSheetResponse:
        """
        @summary 标记外部权限受控 Sheet
        
        @param request: MarkExternalAuthControlledSheetRequest
        @param headers: MarkExternalAuthControlledSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MarkExternalAuthControlledSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.client_token):
            query['clientToken'] = request.client_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.external_auth_type):
            body['externalAuthType'] = request.external_auth_type
        if not UtilClient.is_unset(request.external_config):
            body['externalConfig'] = request.external_config
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
            action='MarkExternalAuthControlledSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/externalAuth/mark',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.MarkExternalAuthControlledSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def mark_external_auth_controlled_sheet(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.MarkExternalAuthControlledSheetRequest,
    ) -> dingtalknotable__1__0_models.MarkExternalAuthControlledSheetResponse:
        """
        @summary 标记外部权限受控 Sheet
        
        @param request: MarkExternalAuthControlledSheetRequest
        @return: MarkExternalAuthControlledSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.MarkExternalAuthControlledSheetHeaders()
        return self.mark_external_auth_controlled_sheet_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def mark_external_auth_controlled_sheet_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.MarkExternalAuthControlledSheetRequest,
    ) -> dingtalknotable__1__0_models.MarkExternalAuthControlledSheetResponse:
        """
        @summary 标记外部权限受控 Sheet
        
        @param request: MarkExternalAuthControlledSheetRequest
        @return: MarkExternalAuthControlledSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.MarkExternalAuthControlledSheetHeaders()
        return await self.mark_external_auth_controlled_sheet_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def prepare_import_upload_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareImportUploadRequest,
        headers: dingtalknotable__1__0_models.PrepareImportUploadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.PrepareImportUploadResponse:
        """
        @summary 申请加密导入上传链接
        
        @param request: PrepareImportUploadRequest
        @param headers: PrepareImportUploadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PrepareImportUploadResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.file_extension):
            body['fileExtension'] = request.file_extension
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.table_names):
            body['tableNames'] = request.table_names
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
            action='PrepareImportUpload',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/import/uploadUrl',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.PrepareImportUploadResponse(),
            self.execute(params, req, runtime)
        )

    async def prepare_import_upload_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareImportUploadRequest,
        headers: dingtalknotable__1__0_models.PrepareImportUploadHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.PrepareImportUploadResponse:
        """
        @summary 申请加密导入上传链接
        
        @param request: PrepareImportUploadRequest
        @param headers: PrepareImportUploadHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PrepareImportUploadResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.file_extension):
            body['fileExtension'] = request.file_extension
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.table_names):
            body['tableNames'] = request.table_names
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
            action='PrepareImportUpload',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/import/uploadUrl',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.PrepareImportUploadResponse(),
            await self.execute_async(params, req, runtime)
        )

    def prepare_import_upload(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareImportUploadRequest,
    ) -> dingtalknotable__1__0_models.PrepareImportUploadResponse:
        """
        @summary 申请加密导入上传链接
        
        @param request: PrepareImportUploadRequest
        @return: PrepareImportUploadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.PrepareImportUploadHeaders()
        return self.prepare_import_upload_with_options(base_id, request, headers, runtime)

    async def prepare_import_upload_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareImportUploadRequest,
    ) -> dingtalknotable__1__0_models.PrepareImportUploadResponse:
        """
        @summary 申请加密导入上传链接
        
        @param request: PrepareImportUploadRequest
        @return: PrepareImportUploadResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.PrepareImportUploadHeaders()
        return await self.prepare_import_upload_with_options_async(base_id, request, headers, runtime)

    def prepare_set_rich_text_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareSetRichTextRequest,
        headers: dingtalknotable__1__0_models.PrepareSetRichTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.PrepareSetRichTextResponse:
        """
        @summary 富文本值预处理
        
        @param request: PrepareSetRichTextRequest
        @param headers: PrepareSetRichTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PrepareSetRichTextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.markdown):
            body['markdown'] = request.markdown
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
            action='PrepareSetRichText',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/prepareSetRichText',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.PrepareSetRichTextResponse(),
            self.execute(params, req, runtime)
        )

    async def prepare_set_rich_text_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareSetRichTextRequest,
        headers: dingtalknotable__1__0_models.PrepareSetRichTextHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.PrepareSetRichTextResponse:
        """
        @summary 富文本值预处理
        
        @param request: PrepareSetRichTextRequest
        @param headers: PrepareSetRichTextHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PrepareSetRichTextResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.markdown):
            body['markdown'] = request.markdown
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
            action='PrepareSetRichText',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/prepareSetRichText',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.PrepareSetRichTextResponse(),
            await self.execute_async(params, req, runtime)
        )

    def prepare_set_rich_text(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareSetRichTextRequest,
    ) -> dingtalknotable__1__0_models.PrepareSetRichTextResponse:
        """
        @summary 富文本值预处理
        
        @param request: PrepareSetRichTextRequest
        @return: PrepareSetRichTextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.PrepareSetRichTextHeaders()
        return self.prepare_set_rich_text_with_options(base_id, request, headers, runtime)

    async def prepare_set_rich_text_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.PrepareSetRichTextRequest,
    ) -> dingtalknotable__1__0_models.PrepareSetRichTextResponse:
        """
        @summary 富文本值预处理
        
        @param request: PrepareSetRichTextRequest
        @return: PrepareSetRichTextResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.PrepareSetRichTextHeaders()
        return await self.prepare_set_rich_text_with_options_async(base_id, request, headers, runtime)

    def query_changed_record_ids_by_client_token_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenRequest,
        headers: dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenResponse:
        """
        @summary 根据 clientToken 查询变更记录 ID
        
        @param request: QueryChangedRecordIdsByClientTokenRequest
        @param headers: QueryChangedRecordIdsByClientTokenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryChangedRecordIdsByClientTokenResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.client_token):
            body['clientToken'] = request.client_token
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
            action='QueryChangedRecordIdsByClientToken',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/changedRecordIds/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenResponse(),
            self.execute(params, req, runtime)
        )

    async def query_changed_record_ids_by_client_token_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenRequest,
        headers: dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenResponse:
        """
        @summary 根据 clientToken 查询变更记录 ID
        
        @param request: QueryChangedRecordIdsByClientTokenRequest
        @param headers: QueryChangedRecordIdsByClientTokenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryChangedRecordIdsByClientTokenResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.client_token):
            body['clientToken'] = request.client_token
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
            action='QueryChangedRecordIdsByClientToken',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/changedRecordIds/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_changed_record_ids_by_client_token(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenRequest,
    ) -> dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenResponse:
        """
        @summary 根据 clientToken 查询变更记录 ID
        
        @param request: QueryChangedRecordIdsByClientTokenRequest
        @return: QueryChangedRecordIdsByClientTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenHeaders()
        return self.query_changed_record_ids_by_client_token_with_options(base_id, request, headers, runtime)

    async def query_changed_record_ids_by_client_token_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenRequest,
    ) -> dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenResponse:
        """
        @summary 根据 clientToken 查询变更记录 ID
        
        @param request: QueryChangedRecordIdsByClientTokenRequest
        @return: QueryChangedRecordIdsByClientTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.QueryChangedRecordIdsByClientTokenHeaders()
        return await self.query_changed_record_ids_by_client_token_with_options_async(base_id, request, headers, runtime)

    def query_doc_all_roles_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryDocAllRolesRequest,
        headers: dingtalknotable__1__0_models.QueryDocAllRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.QueryDocAllRolesResponse:
        """
        @summary 查询文档所有角色和角色成员
        
        @param request: QueryDocAllRolesRequest
        @param headers: QueryDocAllRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDocAllRolesResponse
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
            action='QueryDocAllRoles',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/member/{base_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.QueryDocAllRolesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_doc_all_roles_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryDocAllRolesRequest,
        headers: dingtalknotable__1__0_models.QueryDocAllRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.QueryDocAllRolesResponse:
        """
        @summary 查询文档所有角色和角色成员
        
        @param request: QueryDocAllRolesRequest
        @param headers: QueryDocAllRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDocAllRolesResponse
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
            action='QueryDocAllRoles',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/member/{base_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.QueryDocAllRolesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_doc_all_roles(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryDocAllRolesRequest,
    ) -> dingtalknotable__1__0_models.QueryDocAllRolesResponse:
        """
        @summary 查询文档所有角色和角色成员
        
        @param request: QueryDocAllRolesRequest
        @return: QueryDocAllRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.QueryDocAllRolesHeaders()
        return self.query_doc_all_roles_with_options(base_id, request, headers, runtime)

    async def query_doc_all_roles_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryDocAllRolesRequest,
    ) -> dingtalknotable__1__0_models.QueryDocAllRolesResponse:
        """
        @summary 查询文档所有角色和角色成员
        
        @param request: QueryDocAllRolesRequest
        @return: QueryDocAllRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.QueryDocAllRolesHeaders()
        return await self.query_doc_all_roles_with_options_async(base_id, request, headers, runtime)

    def query_external_auth_controlled_sheets_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsRequest,
        headers: dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsResponse:
        """
        @summary 查询外部权限受控 Sheet 列表
        
        @param request: QueryExternalAuthControlledSheetsRequest
        @param headers: QueryExternalAuthControlledSheetsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryExternalAuthControlledSheetsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.external_auth_type):
            query['externalAuthType'] = request.external_auth_type
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='QueryExternalAuthControlledSheets',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/externalAuth/sheets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_external_auth_controlled_sheets_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsRequest,
        headers: dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsResponse:
        """
        @summary 查询外部权限受控 Sheet 列表
        
        @param request: QueryExternalAuthControlledSheetsRequest
        @param headers: QueryExternalAuthControlledSheetsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryExternalAuthControlledSheetsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.external_auth_type):
            query['externalAuthType'] = request.external_auth_type
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='QueryExternalAuthControlledSheets',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/externalAuth/sheets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_external_auth_controlled_sheets(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsRequest,
    ) -> dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsResponse:
        """
        @summary 查询外部权限受控 Sheet 列表
        
        @param request: QueryExternalAuthControlledSheetsRequest
        @return: QueryExternalAuthControlledSheetsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsHeaders()
        return self.query_external_auth_controlled_sheets_with_options(base_id, request, headers, runtime)

    async def query_external_auth_controlled_sheets_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsRequest,
    ) -> dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsResponse:
        """
        @summary 查询外部权限受控 Sheet 列表
        
        @param request: QueryExternalAuthControlledSheetsRequest
        @return: QueryExternalAuthControlledSheetsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.QueryExternalAuthControlledSheetsHeaders()
        return await self.query_external_auth_controlled_sheets_with_options_async(base_id, request, headers, runtime)

    def query_import_status_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryImportStatusRequest,
        headers: dingtalknotable__1__0_models.QueryImportStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.QueryImportStatusResponse:
        """
        @summary 查询导入会话状态
        
        @param request: QueryImportStatusRequest
        @param headers: QueryImportStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryImportStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.import_id):
            query['importId'] = request.import_id
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
            action='QueryImportStatus',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/import/status',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.QueryImportStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def query_import_status_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryImportStatusRequest,
        headers: dingtalknotable__1__0_models.QueryImportStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.QueryImportStatusResponse:
        """
        @summary 查询导入会话状态
        
        @param request: QueryImportStatusRequest
        @param headers: QueryImportStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryImportStatusResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.import_id):
            query['importId'] = request.import_id
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
            action='QueryImportStatus',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/import/status',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.QueryImportStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_import_status(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryImportStatusRequest,
    ) -> dingtalknotable__1__0_models.QueryImportStatusResponse:
        """
        @summary 查询导入会话状态
        
        @param request: QueryImportStatusRequest
        @return: QueryImportStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.QueryImportStatusHeaders()
        return self.query_import_status_with_options(base_id, request, headers, runtime)

    async def query_import_status_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.QueryImportStatusRequest,
    ) -> dingtalknotable__1__0_models.QueryImportStatusResponse:
        """
        @summary 查询导入会话状态
        
        @param request: QueryImportStatusRequest
        @return: QueryImportStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.QueryImportStatusHeaders()
        return await self.query_import_status_with_options_async(base_id, request, headers, runtime)

    def rebuild_role_members_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.RebuildRoleMembersRequest,
        headers: dingtalknotable__1__0_models.RebuildRoleMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.RebuildRoleMembersResponse:
        """
        @summary 重建角色成员
        
        @param request: RebuildRoleMembersRequest
        @param headers: RebuildRoleMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RebuildRoleMembersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.default_role_dto):
            body['defaultRoleDTO'] = request.default_role_dto
        if not UtilClient.is_unset(request.to_role_member_dtomap):
            body['toRoleMemberDTOMap'] = request.to_role_member_dtomap
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
            action='RebuildRoleMembers',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/member/{base_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.RebuildRoleMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def rebuild_role_members_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.RebuildRoleMembersRequest,
        headers: dingtalknotable__1__0_models.RebuildRoleMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.RebuildRoleMembersResponse:
        """
        @summary 重建角色成员
        
        @param request: RebuildRoleMembersRequest
        @param headers: RebuildRoleMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RebuildRoleMembersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.default_role_dto):
            body['defaultRoleDTO'] = request.default_role_dto
        if not UtilClient.is_unset(request.to_role_member_dtomap):
            body['toRoleMemberDTOMap'] = request.to_role_member_dtomap
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
            action='RebuildRoleMembers',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/member/{base_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.RebuildRoleMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def rebuild_role_members(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.RebuildRoleMembersRequest,
    ) -> dingtalknotable__1__0_models.RebuildRoleMembersResponse:
        """
        @summary 重建角色成员
        
        @param request: RebuildRoleMembersRequest
        @return: RebuildRoleMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.RebuildRoleMembersHeaders()
        return self.rebuild_role_members_with_options(base_id, request, headers, runtime)

    async def rebuild_role_members_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.RebuildRoleMembersRequest,
    ) -> dingtalknotable__1__0_models.RebuildRoleMembersResponse:
        """
        @summary 重建角色成员
        
        @param request: RebuildRoleMembersRequest
        @return: RebuildRoleMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.RebuildRoleMembersHeaders()
        return await self.rebuild_role_members_with_options_async(base_id, request, headers, runtime)

    def truncate_sheet_records_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.TruncateSheetRecordsRequest,
        headers: dingtalknotable__1__0_models.TruncateSheetRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.TruncateSheetRecordsResponse:
        """
        @summary 清空表格记录
        
        @param request: TruncateSheetRecordsRequest
        @param headers: TruncateSheetRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TruncateSheetRecordsResponse
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
            action='TruncateSheetRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/truncate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.TruncateSheetRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def truncate_sheet_records_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.TruncateSheetRecordsRequest,
        headers: dingtalknotable__1__0_models.TruncateSheetRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.TruncateSheetRecordsResponse:
        """
        @summary 清空表格记录
        
        @param request: TruncateSheetRecordsRequest
        @param headers: TruncateSheetRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TruncateSheetRecordsResponse
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
            action='TruncateSheetRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records/truncate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.TruncateSheetRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def truncate_sheet_records(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.TruncateSheetRecordsRequest,
    ) -> dingtalknotable__1__0_models.TruncateSheetRecordsResponse:
        """
        @summary 清空表格记录
        
        @param request: TruncateSheetRecordsRequest
        @return: TruncateSheetRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.TruncateSheetRecordsHeaders()
        return self.truncate_sheet_records_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def truncate_sheet_records_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.TruncateSheetRecordsRequest,
    ) -> dingtalknotable__1__0_models.TruncateSheetRecordsResponse:
        """
        @summary 清空表格记录
        
        @param request: TruncateSheetRecordsRequest
        @return: TruncateSheetRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.TruncateSheetRecordsHeaders()
        return await self.truncate_sheet_records_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def unmark_external_auth_controlled_sheet_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetRequest,
        headers: dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetResponse:
        """
        @summary 取消标记外部权限受控 Sheet
        
        @param request: UnmarkExternalAuthControlledSheetRequest
        @param headers: UnmarkExternalAuthControlledSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnmarkExternalAuthControlledSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.client_token):
            query['clientToken'] = request.client_token
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
            action='UnmarkExternalAuthControlledSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/externalAuth/mark',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def unmark_external_auth_controlled_sheet_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetRequest,
        headers: dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetResponse:
        """
        @summary 取消标记外部权限受控 Sheet
        
        @param request: UnmarkExternalAuthControlledSheetRequest
        @param headers: UnmarkExternalAuthControlledSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnmarkExternalAuthControlledSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.client_token):
            query['clientToken'] = request.client_token
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
            action='UnmarkExternalAuthControlledSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/externalAuth/mark',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def unmark_external_auth_controlled_sheet(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetRequest,
    ) -> dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetResponse:
        """
        @summary 取消标记外部权限受控 Sheet
        
        @param request: UnmarkExternalAuthControlledSheetRequest
        @return: UnmarkExternalAuthControlledSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetHeaders()
        return self.unmark_external_auth_controlled_sheet_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def unmark_external_auth_controlled_sheet_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetRequest,
    ) -> dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetResponse:
        """
        @summary 取消标记外部权限受控 Sheet
        
        @param request: UnmarkExternalAuthControlledSheetRequest
        @return: UnmarkExternalAuthControlledSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UnmarkExternalAuthControlledSheetHeaders()
        return await self.unmark_external_auth_controlled_sheet_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def update_field_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateFieldRequest,
        headers: dingtalknotable__1__0_models.UpdateFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateFieldResponse:
        """
        @summary 更新数据表字段
        
        @param request: UpdateFieldRequest
        @param headers: UpdateFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateFieldResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.property):
            body['property'] = request.property
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
            action='UpdateField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields/{field_id_or_name}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateFieldResponse(),
            self.execute(params, req, runtime)
        )

    async def update_field_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateFieldRequest,
        headers: dingtalknotable__1__0_models.UpdateFieldHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateFieldResponse:
        """
        @summary 更新数据表字段
        
        @param request: UpdateFieldRequest
        @param headers: UpdateFieldHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateFieldResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.property):
            body['property'] = request.property
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
            action='UpdateField',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/fields/{field_id_or_name}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateFieldResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_field(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateFieldRequest,
    ) -> dingtalknotable__1__0_models.UpdateFieldResponse:
        """
        @summary 更新数据表字段
        
        @param request: UpdateFieldRequest
        @return: UpdateFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateFieldHeaders()
        return self.update_field_with_options(base_id, sheet_id_or_name, field_id_or_name, request, headers, runtime)

    async def update_field_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        field_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateFieldRequest,
    ) -> dingtalknotable__1__0_models.UpdateFieldResponse:
        """
        @summary 更新数据表字段
        
        @param request: UpdateFieldRequest
        @return: UpdateFieldResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateFieldHeaders()
        return await self.update_field_with_options_async(base_id, sheet_id_or_name, field_id_or_name, request, headers, runtime)

    def update_records_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateRecordsRequest,
        headers: dingtalknotable__1__0_models.UpdateRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateRecordsResponse:
        """
        @summary 更新数据表多行记录
        
        @param request: UpdateRecordsRequest
        @param headers: UpdateRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.records):
            body['records'] = request.records
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
            action='UpdateRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def update_records_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateRecordsRequest,
        headers: dingtalknotable__1__0_models.UpdateRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateRecordsResponse:
        """
        @summary 更新数据表多行记录
        
        @param request: UpdateRecordsRequest
        @param headers: UpdateRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.records):
            body['records'] = request.records
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
            action='UpdateRecords',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}/records',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_records(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateRecordsRequest,
    ) -> dingtalknotable__1__0_models.UpdateRecordsResponse:
        """
        @summary 更新数据表多行记录
        
        @param request: UpdateRecordsRequest
        @return: UpdateRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateRecordsHeaders()
        return self.update_records_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def update_records_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateRecordsRequest,
    ) -> dingtalknotable__1__0_models.UpdateRecordsResponse:
        """
        @summary 更新数据表多行记录
        
        @param request: UpdateRecordsRequest
        @return: UpdateRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateRecordsHeaders()
        return await self.update_records_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)

    def update_role_with_options(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.UpdateRoleRequest,
        headers: dingtalknotable__1__0_models.UpdateRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateRoleResponse:
        """
        @summary 更新角色
        
        @param request: UpdateRoleRequest
        @param headers: UpdateRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.flow_type):
            body['flowType'] = request.flow_type
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.role_type):
            body['roleType'] = request.role_type
        if not UtilClient.is_unset(request.sub_roles):
            body['subRoles'] = request.sub_roles
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
            action='UpdateRole',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/{base_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def update_role_with_options_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.UpdateRoleRequest,
        headers: dingtalknotable__1__0_models.UpdateRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateRoleResponse:
        """
        @summary 更新角色
        
        @param request: UpdateRoleRequest
        @param headers: UpdateRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.flow_type):
            body['flowType'] = request.flow_type
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.role_type):
            body['roleType'] = request.role_type
        if not UtilClient.is_unset(request.sub_roles):
            body['subRoles'] = request.sub_roles
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
            action='UpdateRole',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/auth/role/{base_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_role(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.UpdateRoleRequest,
    ) -> dingtalknotable__1__0_models.UpdateRoleResponse:
        """
        @summary 更新角色
        
        @param request: UpdateRoleRequest
        @return: UpdateRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateRoleHeaders()
        return self.update_role_with_options(base_id, request, headers, runtime)

    async def update_role_async(
        self,
        base_id: str,
        request: dingtalknotable__1__0_models.UpdateRoleRequest,
    ) -> dingtalknotable__1__0_models.UpdateRoleResponse:
        """
        @summary 更新角色
        
        @param request: UpdateRoleRequest
        @return: UpdateRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateRoleHeaders()
        return await self.update_role_with_options_async(base_id, request, headers, runtime)

    def update_sheet_with_options(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateSheetRequest,
        headers: dingtalknotable__1__0_models.UpdateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateSheetResponse:
        """
        @summary 更新数据表
        
        @param request: UpdateSheetRequest
        @param headers: UpdateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='UpdateSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateSheetResponse(),
            self.execute(params, req, runtime)
        )

    async def update_sheet_with_options_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateSheetRequest,
        headers: dingtalknotable__1__0_models.UpdateSheetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalknotable__1__0_models.UpdateSheetResponse:
        """
        @summary 更新数据表
        
        @param request: UpdateSheetRequest
        @param headers: UpdateSheetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSheetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='UpdateSheet',
            version='notable_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/notable/bases/{base_id}/sheets/{sheet_id_or_name}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalknotable__1__0_models.UpdateSheetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_sheet(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateSheetRequest,
    ) -> dingtalknotable__1__0_models.UpdateSheetResponse:
        """
        @summary 更新数据表
        
        @param request: UpdateSheetRequest
        @return: UpdateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateSheetHeaders()
        return self.update_sheet_with_options(base_id, sheet_id_or_name, request, headers, runtime)

    async def update_sheet_async(
        self,
        base_id: str,
        sheet_id_or_name: str,
        request: dingtalknotable__1__0_models.UpdateSheetRequest,
    ) -> dingtalknotable__1__0_models.UpdateSheetResponse:
        """
        @summary 更新数据表
        
        @param request: UpdateSheetRequest
        @return: UpdateSheetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalknotable__1__0_models.UpdateSheetHeaders()
        return await self.update_sheet_with_options_async(base_id, sheet_id_or_name, request, headers, runtime)
