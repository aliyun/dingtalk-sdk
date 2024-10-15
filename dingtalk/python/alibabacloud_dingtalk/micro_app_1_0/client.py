# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore
from typing import Dict

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.micro_app_1_0 import models as dingtalkmicro_app__1__0_models
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
        self._signature_algorithm = 'v2'
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def add_app_roles_to_member_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppRolesToMemberRequest,
        headers: dingtalkmicro_app__1__0_models.AddAppRolesToMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AddAppRolesToMemberResponse:
        """
        @summary 给指定成员添加角色
        
        @param request: AddAppRolesToMemberRequest
        @param headers: AddAppRolesToMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddAppRolesToMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.member_id):
            body['memberId'] = request.member_id
        if not UtilClient.is_unset(request.member_type):
            body['memberType'] = request.member_type
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role_list):
            body['roleList'] = request.role_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddAppRolesToMember',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/members/roles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AddAppRolesToMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def add_app_roles_to_member_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppRolesToMemberRequest,
        headers: dingtalkmicro_app__1__0_models.AddAppRolesToMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AddAppRolesToMemberResponse:
        """
        @summary 给指定成员添加角色
        
        @param request: AddAppRolesToMemberRequest
        @param headers: AddAppRolesToMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddAppRolesToMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.member_id):
            body['memberId'] = request.member_id
        if not UtilClient.is_unset(request.member_type):
            body['memberType'] = request.member_type
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role_list):
            body['roleList'] = request.role_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddAppRolesToMember',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/members/roles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AddAppRolesToMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_app_roles_to_member(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppRolesToMemberRequest,
    ) -> dingtalkmicro_app__1__0_models.AddAppRolesToMemberResponse:
        """
        @summary 给指定成员添加角色
        
        @param request: AddAppRolesToMemberRequest
        @return: AddAppRolesToMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.AddAppRolesToMemberHeaders()
        return self.add_app_roles_to_member_with_options(agent_id, request, headers, runtime)

    async def add_app_roles_to_member_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppRolesToMemberRequest,
    ) -> dingtalkmicro_app__1__0_models.AddAppRolesToMemberResponse:
        """
        @summary 给指定成员添加角色
        
        @param request: AddAppRolesToMemberRequest
        @return: AddAppRolesToMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.AddAppRolesToMemberHeaders()
        return await self.add_app_roles_to_member_with_options_async(agent_id, request, headers, runtime)

    def add_app_to_work_bench_group_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupRequest,
        headers: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse:
        """
        @summary 添加应用到工作台分组
        
        @param request: AddAppToWorkBenchGroupRequest
        @param headers: AddAppToWorkBenchGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddAppToWorkBenchGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.component_id):
            body['componentId'] = request.component_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            body['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddAppToWorkBenchGroup',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/addToWorkBenchGroup',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def add_app_to_work_bench_group_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupRequest,
        headers: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse:
        """
        @summary 添加应用到工作台分组
        
        @param request: AddAppToWorkBenchGroupRequest
        @param headers: AddAppToWorkBenchGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddAppToWorkBenchGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.component_id):
            body['componentId'] = request.component_id
        if not UtilClient.is_unset(request.ecological_corp_id):
            body['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddAppToWorkBenchGroup',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/addToWorkBenchGroup',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_app_to_work_bench_group(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupRequest,
    ) -> dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse:
        """
        @summary 添加应用到工作台分组
        
        @param request: AddAppToWorkBenchGroupRequest
        @return: AddAppToWorkBenchGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupHeaders()
        return self.add_app_to_work_bench_group_with_options(agent_id, request, headers, runtime)

    async def add_app_to_work_bench_group_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupRequest,
    ) -> dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupResponse:
        """
        @summary 添加应用到工作台分组
        
        @param request: AddAppToWorkBenchGroupRequest
        @return: AddAppToWorkBenchGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.AddAppToWorkBenchGroupHeaders()
        return await self.add_app_to_work_bench_group_with_options_async(agent_id, request, headers, runtime)

    def add_member_to_app_role_with_options(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.AddMemberToAppRoleRequest,
        headers: dingtalkmicro_app__1__0_models.AddMemberToAppRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AddMemberToAppRoleResponse:
        """
        @summary 给指定角色添加人员
        
        @param request: AddMemberToAppRoleRequest
        @param headers: AddMemberToAppRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddMemberToAppRoleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.scope_version):
            body['scopeVersion'] = request.scope_version
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
            action='AddMemberToAppRole',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AddMemberToAppRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def add_member_to_app_role_with_options_async(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.AddMemberToAppRoleRequest,
        headers: dingtalkmicro_app__1__0_models.AddMemberToAppRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AddMemberToAppRoleResponse:
        """
        @summary 给指定角色添加人员
        
        @param request: AddMemberToAppRoleRequest
        @param headers: AddMemberToAppRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddMemberToAppRoleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.scope_version):
            body['scopeVersion'] = request.scope_version
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
            action='AddMemberToAppRole',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AddMemberToAppRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_member_to_app_role(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.AddMemberToAppRoleRequest,
    ) -> dingtalkmicro_app__1__0_models.AddMemberToAppRoleResponse:
        """
        @summary 给指定角色添加人员
        
        @param request: AddMemberToAppRoleRequest
        @return: AddMemberToAppRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.AddMemberToAppRoleHeaders()
        return self.add_member_to_app_role_with_options(agent_id, role_id, request, headers, runtime)

    async def add_member_to_app_role_async(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.AddMemberToAppRoleRequest,
    ) -> dingtalkmicro_app__1__0_models.AddMemberToAppRoleResponse:
        """
        @summary 给指定角色添加人员
        
        @param request: AddMemberToAppRoleRequest
        @return: AddMemberToAppRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.AddMemberToAppRoleHeaders()
        return await self.add_member_to_app_role_with_options_async(agent_id, role_id, request, headers, runtime)

    def anhei_pwith_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AnheiPResponse:
        """
        @summary AnheiP
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnheiPResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AnheiP',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/anheiP',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AnheiPResponse(),
            self.execute(params, req, runtime)
        )

    async def anhei_pwith_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AnheiPResponse:
        """
        @summary AnheiP
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnheiPResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AnheiP',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/anheiP',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AnheiPResponse(),
            await self.execute_async(params, req, runtime)
        )

    def anhei_p(self) -> dingtalkmicro_app__1__0_models.AnheiPResponse:
        """
        @summary AnheiP
        
        @return: AnheiPResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.anhei_pwith_options(headers, runtime)

    async def anhei_p_async(self) -> dingtalkmicro_app__1__0_models.AnheiPResponse:
        """
        @summary AnheiP
        
        @return: AnheiPResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.anhei_pwith_options_async(headers, runtime)

    def anhei_test_888with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AnheiTest888Response:
        """
        @summary AnheiTest888
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnheiTest888Response
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AnheiTest888',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/anheiTest888',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AnheiTest888Response(),
            self.execute(params, req, runtime)
        )

    async def anhei_test_888with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AnheiTest888Response:
        """
        @summary AnheiTest888
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnheiTest888Response
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AnheiTest888',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/anheiTest888',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AnheiTest888Response(),
            await self.execute_async(params, req, runtime)
        )

    def anhei_test_888(self) -> dingtalkmicro_app__1__0_models.AnheiTest888Response:
        """
        @summary AnheiTest888
        
        @return: AnheiTest888Response
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.anhei_test_888with_options(headers, runtime)

    async def anhei_test_888_async(self) -> dingtalkmicro_app__1__0_models.AnheiTest888Response:
        """
        @summary AnheiTest888
        
        @return: AnheiTest888Response
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.anhei_test_888with_options_async(headers, runtime)

    def anhei_test_bwith_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AnheiTestBResponse:
        """
        @summary AnheiTestB
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnheiTestBResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AnheiTestB',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/anheiTestB',
            method='PUT',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AnheiTestBResponse(),
            self.execute(params, req, runtime)
        )

    async def anhei_test_bwith_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AnheiTestBResponse:
        """
        @summary AnheiTestB
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnheiTestBResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AnheiTestB',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/anheiTestB',
            method='PUT',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AnheiTestBResponse(),
            await self.execute_async(params, req, runtime)
        )

    def anhei_test_b(self) -> dingtalkmicro_app__1__0_models.AnheiTestBResponse:
        """
        @summary AnheiTestB
        
        @return: AnheiTestBResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.anhei_test_bwith_options(headers, runtime)

    async def anhei_test_b_async(self) -> dingtalkmicro_app__1__0_models.AnheiTestBResponse:
        """
        @summary AnheiTestB
        
        @return: AnheiTestBResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.anhei_test_bwith_options_async(headers, runtime)

    def anhei_test_nine_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AnheiTestNineResponse:
        """
        @summary 暗黑测试
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnheiTestNineResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AnheiTestNine',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/anheiTestNine',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AnheiTestNineResponse(),
            self.execute(params, req, runtime)
        )

    async def anhei_test_nine_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AnheiTestNineResponse:
        """
        @summary 暗黑测试
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnheiTestNineResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AnheiTestNine',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/anheiTestNine',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AnheiTestNineResponse(),
            await self.execute_async(params, req, runtime)
        )

    def anhei_test_nine(self) -> dingtalkmicro_app__1__0_models.AnheiTestNineResponse:
        """
        @summary 暗黑测试
        
        @return: AnheiTestNineResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.anhei_test_nine_with_options(headers, runtime)

    async def anhei_test_nine_async(self) -> dingtalkmicro_app__1__0_models.AnheiTestNineResponse:
        """
        @summary 暗黑测试
        
        @return: AnheiTestNineResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.anhei_test_nine_with_options_async(headers, runtime)

    def app_status_manager_test_with_options(
        self,
        request: dingtalkmicro_app__1__0_models.AppStatusManagerTestRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AppStatusManagerTestResponse:
        """
        @summary 应用状态管理测试
        
        @param request: AppStatusManagerTestRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppStatusManagerTestResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.request_id):
            query['requestId'] = request.request_id
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AppStatusManagerTest',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/manager/test',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AppStatusManagerTestResponse(),
            self.execute(params, req, runtime)
        )

    async def app_status_manager_test_with_options_async(
        self,
        request: dingtalkmicro_app__1__0_models.AppStatusManagerTestRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AppStatusManagerTestResponse:
        """
        @summary 应用状态管理测试
        
        @param request: AppStatusManagerTestRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AppStatusManagerTestResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.request_id):
            query['requestId'] = request.request_id
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='AppStatusManagerTest',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/manager/test',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AppStatusManagerTestResponse(),
            await self.execute_async(params, req, runtime)
        )

    def app_status_manager_test(
        self,
        request: dingtalkmicro_app__1__0_models.AppStatusManagerTestRequest,
    ) -> dingtalkmicro_app__1__0_models.AppStatusManagerTestResponse:
        """
        @summary 应用状态管理测试
        
        @param request: AppStatusManagerTestRequest
        @return: AppStatusManagerTestResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.app_status_manager_test_with_options(request, headers, runtime)

    async def app_status_manager_test_async(
        self,
        request: dingtalkmicro_app__1__0_models.AppStatusManagerTestRequest,
    ) -> dingtalkmicro_app__1__0_models.AppStatusManagerTestResponse:
        """
        @summary 应用状态管理测试
        
        @param request: AppStatusManagerTestRequest
        @return: AppStatusManagerTestResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.app_status_manager_test_with_options_async(request, headers, runtime)

    def ayun_test_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AyunTestResponse:
        """
        @summary 能力开放中心录入测试数据
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AyunTestResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AyunTest',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/ayun/test',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AyunTestResponse(),
            self.execute(params, req, runtime)
        )

    async def ayun_test_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AyunTestResponse:
        """
        @summary 能力开放中心录入测试数据
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AyunTestResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AyunTest',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/ayun/test',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AyunTestResponse(),
            await self.execute_async(params, req, runtime)
        )

    def ayun_test(self) -> dingtalkmicro_app__1__0_models.AyunTestResponse:
        """
        @summary 能力开放中心录入测试数据
        
        @return: AyunTestResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.ayun_test_with_options(headers, runtime)

    async def ayun_test_async(self) -> dingtalkmicro_app__1__0_models.AyunTestResponse:
        """
        @summary 能力开放中心录入测试数据
        
        @return: AyunTestResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.ayun_test_with_options_async(headers, runtime)

    def ayun_test_online_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AyunTestOnlineResponse:
        """
        @summary openAPI录入上线后的测试
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AyunTestOnlineResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AyunTestOnline',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/ayunTest',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AyunTestOnlineResponse(),
            self.execute(params, req, runtime)
        )

    async def ayun_test_online_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.AyunTestOnlineResponse:
        """
        @summary openAPI录入上线后的测试
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: AyunTestOnlineResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='AyunTestOnline',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/ayunTest',
            method='GET',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.AyunTestOnlineResponse(),
            await self.execute_async(params, req, runtime)
        )

    def ayun_test_online(self) -> dingtalkmicro_app__1__0_models.AyunTestOnlineResponse:
        """
        @summary openAPI录入上线后的测试
        
        @return: AyunTestOnlineResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.ayun_test_online_with_options(headers, runtime)

    async def ayun_test_online_async(self) -> dingtalkmicro_app__1__0_models.AyunTestOnlineResponse:
        """
        @summary openAPI录入上线后的测试
        
        @return: AyunTestOnlineResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.ayun_test_online_with_options_async(headers, runtime)

    def create_apaas_app_with_options(
        self,
        request: dingtalkmicro_app__1__0_models.CreateApaasAppRequest,
        headers: dingtalkmicro_app__1__0_models.CreateApaasAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.CreateApaasAppResponse:
        """
        @summary 创建Apaas应用
        
        @param request: CreateApaasAppRequest
        @param headers: CreateApaasAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateApaasAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_desc):
            body['appDesc'] = request.app_desc
        if not UtilClient.is_unset(request.app_icon):
            body['appIcon'] = request.app_icon
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.biz_app_id):
            body['bizAppId'] = request.biz_app_id
        if not UtilClient.is_unset(request.homepage_edit_link):
            body['homepageEditLink'] = request.homepage_edit_link
        if not UtilClient.is_unset(request.homepage_link):
            body['homepageLink'] = request.homepage_link
        if not UtilClient.is_unset(request.is_short_cut):
            body['isShortCut'] = request.is_short_cut
        if not UtilClient.is_unset(request.omp_link):
            body['ompLink'] = request.omp_link
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.pc_homepage_edit_link):
            body['pcHomepageEditLink'] = request.pc_homepage_edit_link
        if not UtilClient.is_unset(request.pc_homepage_link):
            body['pcHomepageLink'] = request.pc_homepage_link
        if not UtilClient.is_unset(request.template_key):
            body['templateKey'] = request.template_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateApaasApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apaasApps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.CreateApaasAppResponse(),
            self.execute(params, req, runtime)
        )

    async def create_apaas_app_with_options_async(
        self,
        request: dingtalkmicro_app__1__0_models.CreateApaasAppRequest,
        headers: dingtalkmicro_app__1__0_models.CreateApaasAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.CreateApaasAppResponse:
        """
        @summary 创建Apaas应用
        
        @param request: CreateApaasAppRequest
        @param headers: CreateApaasAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateApaasAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_desc):
            body['appDesc'] = request.app_desc
        if not UtilClient.is_unset(request.app_icon):
            body['appIcon'] = request.app_icon
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.biz_app_id):
            body['bizAppId'] = request.biz_app_id
        if not UtilClient.is_unset(request.homepage_edit_link):
            body['homepageEditLink'] = request.homepage_edit_link
        if not UtilClient.is_unset(request.homepage_link):
            body['homepageLink'] = request.homepage_link
        if not UtilClient.is_unset(request.is_short_cut):
            body['isShortCut'] = request.is_short_cut
        if not UtilClient.is_unset(request.omp_link):
            body['ompLink'] = request.omp_link
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.pc_homepage_edit_link):
            body['pcHomepageEditLink'] = request.pc_homepage_edit_link
        if not UtilClient.is_unset(request.pc_homepage_link):
            body['pcHomepageLink'] = request.pc_homepage_link
        if not UtilClient.is_unset(request.template_key):
            body['templateKey'] = request.template_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateApaasApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apaasApps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.CreateApaasAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_apaas_app(
        self,
        request: dingtalkmicro_app__1__0_models.CreateApaasAppRequest,
    ) -> dingtalkmicro_app__1__0_models.CreateApaasAppResponse:
        """
        @summary 创建Apaas应用
        
        @param request: CreateApaasAppRequest
        @return: CreateApaasAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.CreateApaasAppHeaders()
        return self.create_apaas_app_with_options(request, headers, runtime)

    async def create_apaas_app_async(
        self,
        request: dingtalkmicro_app__1__0_models.CreateApaasAppRequest,
    ) -> dingtalkmicro_app__1__0_models.CreateApaasAppResponse:
        """
        @summary 创建Apaas应用
        
        @param request: CreateApaasAppRequest
        @return: CreateApaasAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.CreateApaasAppHeaders()
        return await self.create_apaas_app_with_options_async(request, headers, runtime)

    def create_inner_app_with_options(
        self,
        request: dingtalkmicro_app__1__0_models.CreateInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.CreateInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.CreateInnerAppResponse:
        """
        @summary 创建企业内部应用
        
        @param request: CreateInnerAppRequest
        @param headers: CreateInnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateInnerAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.develop_type):
            body['developType'] = request.develop_type
        if not UtilClient.is_unset(request.homepage_link):
            body['homepageLink'] = request.homepage_link
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.ip_white_list):
            body['ipWhiteList'] = request.ip_white_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.omp_link):
            body['ompLink'] = request.omp_link
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.pc_homepage_link):
            body['pcHomepageLink'] = request.pc_homepage_link
        if not UtilClient.is_unset(request.scope_type):
            body['scopeType'] = request.scope_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateInnerApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.CreateInnerAppResponse(),
            self.execute(params, req, runtime)
        )

    async def create_inner_app_with_options_async(
        self,
        request: dingtalkmicro_app__1__0_models.CreateInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.CreateInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.CreateInnerAppResponse:
        """
        @summary 创建企业内部应用
        
        @param request: CreateInnerAppRequest
        @param headers: CreateInnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateInnerAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.develop_type):
            body['developType'] = request.develop_type
        if not UtilClient.is_unset(request.homepage_link):
            body['homepageLink'] = request.homepage_link
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.ip_white_list):
            body['ipWhiteList'] = request.ip_white_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.omp_link):
            body['ompLink'] = request.omp_link
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.pc_homepage_link):
            body['pcHomepageLink'] = request.pc_homepage_link
        if not UtilClient.is_unset(request.scope_type):
            body['scopeType'] = request.scope_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateInnerApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.CreateInnerAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_inner_app(
        self,
        request: dingtalkmicro_app__1__0_models.CreateInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.CreateInnerAppResponse:
        """
        @summary 创建企业内部应用
        
        @param request: CreateInnerAppRequest
        @return: CreateInnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.CreateInnerAppHeaders()
        return self.create_inner_app_with_options(request, headers, runtime)

    async def create_inner_app_async(
        self,
        request: dingtalkmicro_app__1__0_models.CreateInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.CreateInnerAppResponse:
        """
        @summary 创建企业内部应用
        
        @param request: CreateInnerAppRequest
        @return: CreateInnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.CreateInnerAppHeaders()
        return await self.create_inner_app_with_options_async(request, headers, runtime)

    def delete_app_role_with_options(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteAppRoleRequest,
        headers: dingtalkmicro_app__1__0_models.DeleteAppRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.DeleteAppRoleResponse:
        """
        @summary 删除应用角色
        
        @param request: DeleteAppRoleRequest
        @param headers: DeleteAppRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteAppRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteAppRole',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.DeleteAppRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_app_role_with_options_async(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteAppRoleRequest,
        headers: dingtalkmicro_app__1__0_models.DeleteAppRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.DeleteAppRoleResponse:
        """
        @summary 删除应用角色
        
        @param request: DeleteAppRoleRequest
        @param headers: DeleteAppRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteAppRoleResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_user_id):
            query['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteAppRole',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.DeleteAppRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_app_role(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteAppRoleRequest,
    ) -> dingtalkmicro_app__1__0_models.DeleteAppRoleResponse:
        """
        @summary 删除应用角色
        
        @param request: DeleteAppRoleRequest
        @return: DeleteAppRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.DeleteAppRoleHeaders()
        return self.delete_app_role_with_options(agent_id, role_id, request, headers, runtime)

    async def delete_app_role_async(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteAppRoleRequest,
    ) -> dingtalkmicro_app__1__0_models.DeleteAppRoleResponse:
        """
        @summary 删除应用角色
        
        @param request: DeleteAppRoleRequest
        @return: DeleteAppRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.DeleteAppRoleHeaders()
        return await self.delete_app_role_with_options_async(agent_id, role_id, request, headers, runtime)

    def delete_inner_app_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.DeleteInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.DeleteInnerAppResponse:
        """
        @summary 删除企业内部应用
        
        @param request: DeleteInnerAppRequest
        @param headers: DeleteInnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteInnerAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_union_id):
            query['opUnionId'] = request.op_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteInnerApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.DeleteInnerAppResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_inner_app_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.DeleteInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.DeleteInnerAppResponse:
        """
        @summary 删除企业内部应用
        
        @param request: DeleteInnerAppRequest
        @param headers: DeleteInnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteInnerAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.op_union_id):
            query['opUnionId'] = request.op_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='DeleteInnerApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.DeleteInnerAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_inner_app(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.DeleteInnerAppResponse:
        """
        @summary 删除企业内部应用
        
        @param request: DeleteInnerAppRequest
        @return: DeleteInnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.DeleteInnerAppHeaders()
        return self.delete_inner_app_with_options(agent_id, request, headers, runtime)

    async def delete_inner_app_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.DeleteInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.DeleteInnerAppResponse:
        """
        @summary 删除企业内部应用
        
        @param request: DeleteInnerAppRequest
        @return: DeleteInnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.DeleteInnerAppHeaders()
        return await self.delete_inner_app_with_options_async(agent_id, request, headers, runtime)

    def get_apaas_app_with_options(
        self,
        biz_app_id: str,
        headers: dingtalkmicro_app__1__0_models.GetApaasAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetApaasAppResponse:
        """
        @summary 查询Apaas应用
        
        @param headers: GetApaasAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetApaasAppResponse
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
            action='GetApaasApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apaasApps/{biz_app_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetApaasAppResponse(),
            self.execute(params, req, runtime)
        )

    async def get_apaas_app_with_options_async(
        self,
        biz_app_id: str,
        headers: dingtalkmicro_app__1__0_models.GetApaasAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetApaasAppResponse:
        """
        @summary 查询Apaas应用
        
        @param headers: GetApaasAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetApaasAppResponse
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
            action='GetApaasApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apaasApps/{biz_app_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetApaasAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_apaas_app(
        self,
        biz_app_id: str,
    ) -> dingtalkmicro_app__1__0_models.GetApaasAppResponse:
        """
        @summary 查询Apaas应用
        
        @return: GetApaasAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetApaasAppHeaders()
        return self.get_apaas_app_with_options(biz_app_id, headers, runtime)

    async def get_apaas_app_async(
        self,
        biz_app_id: str,
    ) -> dingtalkmicro_app__1__0_models.GetApaasAppResponse:
        """
        @summary 查询Apaas应用
        
        @return: GetApaasAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetApaasAppHeaders()
        return await self.get_apaas_app_with_options_async(biz_app_id, headers, runtime)

    def get_app_resource_use_info_with_options(
        self,
        request: dingtalkmicro_app__1__0_models.GetAppResourceUseInfoRequest,
        headers: dingtalkmicro_app__1__0_models.GetAppResourceUseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetAppResourceUseInfoResponse:
        """
        @summary 获取应用资源用量信息
        
        @param request: GetAppResourceUseInfoRequest
        @param headers: GetAppResourceUseInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAppResourceUseInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.benefit_code):
            query['benefitCode'] = request.benefit_code
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.period_type):
            query['periodType'] = request.period_type
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetAppResourceUseInfo',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/resources/useInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='array'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetAppResourceUseInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_app_resource_use_info_with_options_async(
        self,
        request: dingtalkmicro_app__1__0_models.GetAppResourceUseInfoRequest,
        headers: dingtalkmicro_app__1__0_models.GetAppResourceUseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetAppResourceUseInfoResponse:
        """
        @summary 获取应用资源用量信息
        
        @param request: GetAppResourceUseInfoRequest
        @param headers: GetAppResourceUseInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAppResourceUseInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.benefit_code):
            query['benefitCode'] = request.benefit_code
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.period_type):
            query['periodType'] = request.period_type
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetAppResourceUseInfo',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/resources/useInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='array'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetAppResourceUseInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_app_resource_use_info(
        self,
        request: dingtalkmicro_app__1__0_models.GetAppResourceUseInfoRequest,
    ) -> dingtalkmicro_app__1__0_models.GetAppResourceUseInfoResponse:
        """
        @summary 获取应用资源用量信息
        
        @param request: GetAppResourceUseInfoRequest
        @return: GetAppResourceUseInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetAppResourceUseInfoHeaders()
        return self.get_app_resource_use_info_with_options(request, headers, runtime)

    async def get_app_resource_use_info_async(
        self,
        request: dingtalkmicro_app__1__0_models.GetAppResourceUseInfoRequest,
    ) -> dingtalkmicro_app__1__0_models.GetAppResourceUseInfoResponse:
        """
        @summary 获取应用资源用量信息
        
        @param request: GetAppResourceUseInfoRequest
        @return: GetAppResourceUseInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetAppResourceUseInfoHeaders()
        return await self.get_app_resource_use_info_with_options_async(request, headers, runtime)

    def get_app_role_scope_by_role_id_with_options(
        self,
        agent_id: str,
        role_id: str,
        headers: dingtalkmicro_app__1__0_models.GetAppRoleScopeByRoleIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetAppRoleScopeByRoleIdResponse:
        """
        @summary 查询指定角色的角色范围
        
        @param headers: GetAppRoleScopeByRoleIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAppRoleScopeByRoleIdResponse
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
            action='GetAppRoleScopeByRoleId',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}/scopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetAppRoleScopeByRoleIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_app_role_scope_by_role_id_with_options_async(
        self,
        agent_id: str,
        role_id: str,
        headers: dingtalkmicro_app__1__0_models.GetAppRoleScopeByRoleIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetAppRoleScopeByRoleIdResponse:
        """
        @summary 查询指定角色的角色范围
        
        @param headers: GetAppRoleScopeByRoleIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAppRoleScopeByRoleIdResponse
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
            action='GetAppRoleScopeByRoleId',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}/scopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetAppRoleScopeByRoleIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_app_role_scope_by_role_id(
        self,
        agent_id: str,
        role_id: str,
    ) -> dingtalkmicro_app__1__0_models.GetAppRoleScopeByRoleIdResponse:
        """
        @summary 查询指定角色的角色范围
        
        @return: GetAppRoleScopeByRoleIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetAppRoleScopeByRoleIdHeaders()
        return self.get_app_role_scope_by_role_id_with_options(agent_id, role_id, headers, runtime)

    async def get_app_role_scope_by_role_id_async(
        self,
        agent_id: str,
        role_id: str,
    ) -> dingtalkmicro_app__1__0_models.GetAppRoleScopeByRoleIdResponse:
        """
        @summary 查询指定角色的角色范围
        
        @return: GetAppRoleScopeByRoleIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetAppRoleScopeByRoleIdHeaders()
        return await self.get_app_role_scope_by_role_id_with_options_async(agent_id, role_id, headers, runtime)

    def get_inner_app_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.GetInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.GetInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetInnerAppResponse:
        """
        @summary 获取企业内部H5应用
        
        @param request: GetInnerAppRequest
        @param headers: GetInnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInnerAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.op_union_id):
            query['opUnionId'] = request.op_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetInnerApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetInnerAppResponse(),
            self.execute(params, req, runtime)
        )

    async def get_inner_app_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.GetInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.GetInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetInnerAppResponse:
        """
        @summary 获取企业内部H5应用
        
        @param request: GetInnerAppRequest
        @param headers: GetInnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInnerAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        if not UtilClient.is_unset(request.op_union_id):
            query['opUnionId'] = request.op_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetInnerApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetInnerAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_inner_app(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.GetInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.GetInnerAppResponse:
        """
        @summary 获取企业内部H5应用
        
        @param request: GetInnerAppRequest
        @return: GetInnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetInnerAppHeaders()
        return self.get_inner_app_with_options(agent_id, request, headers, runtime)

    async def get_inner_app_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.GetInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.GetInnerAppResponse:
        """
        @summary 获取企业内部H5应用
        
        @param request: GetInnerAppRequest
        @return: GetInnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetInnerAppHeaders()
        return await self.get_inner_app_with_options_async(agent_id, request, headers, runtime)

    def get_micro_app_scope_with_options(
        self,
        agent_id: str,
        headers: dingtalkmicro_app__1__0_models.GetMicroAppScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetMicroAppScopeResponse:
        """
        @summary 获取应用可见范围
        
        @param headers: GetMicroAppScopeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMicroAppScopeResponse
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
            action='GetMicroAppScope',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/scopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetMicroAppScopeResponse(),
            self.execute(params, req, runtime)
        )

    async def get_micro_app_scope_with_options_async(
        self,
        agent_id: str,
        headers: dingtalkmicro_app__1__0_models.GetMicroAppScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetMicroAppScopeResponse:
        """
        @summary 获取应用可见范围
        
        @param headers: GetMicroAppScopeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMicroAppScopeResponse
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
            action='GetMicroAppScope',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/scopes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetMicroAppScopeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_micro_app_scope(
        self,
        agent_id: str,
    ) -> dingtalkmicro_app__1__0_models.GetMicroAppScopeResponse:
        """
        @summary 获取应用可见范围
        
        @return: GetMicroAppScopeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetMicroAppScopeHeaders()
        return self.get_micro_app_scope_with_options(agent_id, headers, runtime)

    async def get_micro_app_scope_async(
        self,
        agent_id: str,
    ) -> dingtalkmicro_app__1__0_models.GetMicroAppScopeResponse:
        """
        @summary 获取应用可见范围
        
        @return: GetMicroAppScopeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetMicroAppScopeHeaders()
        return await self.get_micro_app_scope_with_options_async(agent_id, headers, runtime)

    def get_micro_app_user_access_with_options(
        self,
        agent_id: str,
        user_id: str,
        headers: dingtalkmicro_app__1__0_models.GetMicroAppUserAccessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetMicroAppUserAccessResponse:
        """
        @summary 获取用户对应用的管理权限
        
        @param headers: GetMicroAppUserAccessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMicroAppUserAccessResponse
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
            action='GetMicroAppUserAccess',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/users/{user_id}/adminAccess',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetMicroAppUserAccessResponse(),
            self.execute(params, req, runtime)
        )

    async def get_micro_app_user_access_with_options_async(
        self,
        agent_id: str,
        user_id: str,
        headers: dingtalkmicro_app__1__0_models.GetMicroAppUserAccessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetMicroAppUserAccessResponse:
        """
        @summary 获取用户对应用的管理权限
        
        @param headers: GetMicroAppUserAccessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMicroAppUserAccessResponse
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
            action='GetMicroAppUserAccess',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/users/{user_id}/adminAccess',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetMicroAppUserAccessResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_micro_app_user_access(
        self,
        agent_id: str,
        user_id: str,
    ) -> dingtalkmicro_app__1__0_models.GetMicroAppUserAccessResponse:
        """
        @summary 获取用户对应用的管理权限
        
        @return: GetMicroAppUserAccessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetMicroAppUserAccessHeaders()
        return self.get_micro_app_user_access_with_options(agent_id, user_id, headers, runtime)

    async def get_micro_app_user_access_async(
        self,
        agent_id: str,
        user_id: str,
    ) -> dingtalkmicro_app__1__0_models.GetMicroAppUserAccessResponse:
        """
        @summary 获取用户对应用的管理权限
        
        @return: GetMicroAppUserAccessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetMicroAppUserAccessHeaders()
        return await self.get_micro_app_user_access_with_options_async(agent_id, user_id, headers, runtime)

    def get_user_app_dev_access_with_options(
        self,
        user_id: str,
        headers: dingtalkmicro_app__1__0_models.GetUserAppDevAccessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetUserAppDevAccessResponse:
        """
        @summary 用户是否拥有开发者权限
        
        @param headers: GetUserAppDevAccessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserAppDevAccessResponse
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
            action='GetUserAppDevAccess',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/users/{user_id}/devAccesses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetUserAppDevAccessResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_app_dev_access_with_options_async(
        self,
        user_id: str,
        headers: dingtalkmicro_app__1__0_models.GetUserAppDevAccessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.GetUserAppDevAccessResponse:
        """
        @summary 用户是否拥有开发者权限
        
        @param headers: GetUserAppDevAccessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserAppDevAccessResponse
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
            action='GetUserAppDevAccess',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/users/{user_id}/devAccesses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.GetUserAppDevAccessResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_app_dev_access(
        self,
        user_id: str,
    ) -> dingtalkmicro_app__1__0_models.GetUserAppDevAccessResponse:
        """
        @summary 用户是否拥有开发者权限
        
        @return: GetUserAppDevAccessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetUserAppDevAccessHeaders()
        return self.get_user_app_dev_access_with_options(user_id, headers, runtime)

    async def get_user_app_dev_access_async(
        self,
        user_id: str,
    ) -> dingtalkmicro_app__1__0_models.GetUserAppDevAccessResponse:
        """
        @summary 用户是否拥有开发者权限
        
        @return: GetUserAppDevAccessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.GetUserAppDevAccessHeaders()
        return await self.get_user_app_dev_access_with_options_async(user_id, headers, runtime)

    def list_all_app_with_options(
        self,
        headers: dingtalkmicro_app__1__0_models.ListAllAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListAllAppResponse:
        """
        @summary 获取企业所有应用列表
        
        @param headers: ListAllAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAllAppResponse
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
            action='ListAllApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/allApps',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListAllAppResponse(),
            self.execute(params, req, runtime)
        )

    async def list_all_app_with_options_async(
        self,
        headers: dingtalkmicro_app__1__0_models.ListAllAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListAllAppResponse:
        """
        @summary 获取企业所有应用列表
        
        @param headers: ListAllAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAllAppResponse
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
            action='ListAllApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/allApps',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListAllAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_all_app(self) -> dingtalkmicro_app__1__0_models.ListAllAppResponse:
        """
        @summary 获取企业所有应用列表
        
        @return: ListAllAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListAllAppHeaders()
        return self.list_all_app_with_options(headers, runtime)

    async def list_all_app_async(self) -> dingtalkmicro_app__1__0_models.ListAllAppResponse:
        """
        @summary 获取企业所有应用列表
        
        @return: ListAllAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListAllAppHeaders()
        return await self.list_all_app_with_options_async(headers, runtime)

    def list_all_inner_apps_with_options(
        self,
        headers: dingtalkmicro_app__1__0_models.ListAllInnerAppsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListAllInnerAppsResponse:
        """
        @summary 获取企业所有内部应用列表
        
        @param headers: ListAllInnerAppsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAllInnerAppsResponse
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
            action='ListAllInnerApps',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/allInnerApps',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListAllInnerAppsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_all_inner_apps_with_options_async(
        self,
        headers: dingtalkmicro_app__1__0_models.ListAllInnerAppsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListAllInnerAppsResponse:
        """
        @summary 获取企业所有内部应用列表
        
        @param headers: ListAllInnerAppsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAllInnerAppsResponse
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
            action='ListAllInnerApps',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/allInnerApps',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListAllInnerAppsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_all_inner_apps(self) -> dingtalkmicro_app__1__0_models.ListAllInnerAppsResponse:
        """
        @summary 获取企业所有内部应用列表
        
        @return: ListAllInnerAppsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListAllInnerAppsHeaders()
        return self.list_all_inner_apps_with_options(headers, runtime)

    async def list_all_inner_apps_async(self) -> dingtalkmicro_app__1__0_models.ListAllInnerAppsResponse:
        """
        @summary 获取企业所有内部应用列表
        
        @return: ListAllInnerAppsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListAllInnerAppsHeaders()
        return await self.list_all_inner_apps_with_options_async(headers, runtime)

    def list_app_role_scopes_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.ListAppRoleScopesRequest,
        headers: dingtalkmicro_app__1__0_models.ListAppRoleScopesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListAppRoleScopesResponse:
        """
        @summary 获取企业应用的角色完整信息
        
        @param request: ListAppRoleScopesRequest
        @param headers: ListAppRoleScopesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAppRoleScopesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListAppRoleScopes',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListAppRoleScopesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_app_role_scopes_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.ListAppRoleScopesRequest,
        headers: dingtalkmicro_app__1__0_models.ListAppRoleScopesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListAppRoleScopesResponse:
        """
        @summary 获取企业应用的角色完整信息
        
        @param request: ListAppRoleScopesRequest
        @param headers: ListAppRoleScopesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAppRoleScopesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListAppRoleScopes',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListAppRoleScopesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_app_role_scopes(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.ListAppRoleScopesRequest,
    ) -> dingtalkmicro_app__1__0_models.ListAppRoleScopesResponse:
        """
        @summary 获取企业应用的角色完整信息
        
        @param request: ListAppRoleScopesRequest
        @return: ListAppRoleScopesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListAppRoleScopesHeaders()
        return self.list_app_role_scopes_with_options(agent_id, request, headers, runtime)

    async def list_app_role_scopes_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.ListAppRoleScopesRequest,
    ) -> dingtalkmicro_app__1__0_models.ListAppRoleScopesResponse:
        """
        @summary 获取企业应用的角色完整信息
        
        @param request: ListAppRoleScopesRequest
        @return: ListAppRoleScopesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListAppRoleScopesHeaders()
        return await self.list_app_role_scopes_with_options_async(agent_id, request, headers, runtime)

    def list_inner_app_with_options(
        self,
        request: dingtalkmicro_app__1__0_models.ListInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.ListInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppResponse:
        """
        @summary 列出企业内部H5应用
        
        @param request: ListInnerAppRequest
        @param headers: ListInnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListInnerAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListInnerApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListInnerAppResponse(),
            self.execute(params, req, runtime)
        )

    async def list_inner_app_with_options_async(
        self,
        request: dingtalkmicro_app__1__0_models.ListInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.ListInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppResponse:
        """
        @summary 列出企业内部H5应用
        
        @param request: ListInnerAppRequest
        @param headers: ListInnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListInnerAppResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ecological_corp_id):
            query['ecologicalCorpId'] = request.ecological_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListInnerApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListInnerAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_inner_app(
        self,
        request: dingtalkmicro_app__1__0_models.ListInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppResponse:
        """
        @summary 列出企业内部H5应用
        
        @param request: ListInnerAppRequest
        @return: ListInnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListInnerAppHeaders()
        return self.list_inner_app_with_options(request, headers, runtime)

    async def list_inner_app_async(
        self,
        request: dingtalkmicro_app__1__0_models.ListInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppResponse:
        """
        @summary 列出企业内部H5应用
        
        @param request: ListInnerAppRequest
        @return: ListInnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListInnerAppHeaders()
        return await self.list_inner_app_with_options_async(request, headers, runtime)

    def list_inner_app_version_with_options(
        self,
        agent_id: str,
        headers: dingtalkmicro_app__1__0_models.ListInnerAppVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppVersionResponse:
        """
        @summary 获取企业内部小程序的版本列表
        
        @param headers: ListInnerAppVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListInnerAppVersionResponse
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
            action='ListInnerAppVersion',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/innerMiniApps/{agent_id}/versions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListInnerAppVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def list_inner_app_version_with_options_async(
        self,
        agent_id: str,
        headers: dingtalkmicro_app__1__0_models.ListInnerAppVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppVersionResponse:
        """
        @summary 获取企业内部小程序的版本列表
        
        @param headers: ListInnerAppVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListInnerAppVersionResponse
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
            action='ListInnerAppVersion',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/innerMiniApps/{agent_id}/versions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListInnerAppVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_inner_app_version(
        self,
        agent_id: str,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppVersionResponse:
        """
        @summary 获取企业内部小程序的版本列表
        
        @return: ListInnerAppVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListInnerAppVersionHeaders()
        return self.list_inner_app_version_with_options(agent_id, headers, runtime)

    async def list_inner_app_version_async(
        self,
        agent_id: str,
    ) -> dingtalkmicro_app__1__0_models.ListInnerAppVersionResponse:
        """
        @summary 获取企业内部小程序的版本列表
        
        @return: ListInnerAppVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListInnerAppVersionHeaders()
        return await self.list_inner_app_version_with_options_async(agent_id, headers, runtime)

    def list_role_info_by_user_with_options(
        self,
        agent_id: str,
        user_id: str,
        headers: dingtalkmicro_app__1__0_models.ListRoleInfoByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListRoleInfoByUserResponse:
        """
        @summary 获取用户在应用中的角色信息列表
        
        @param headers: ListRoleInfoByUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRoleInfoByUserResponse
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
            action='ListRoleInfoByUser',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/users/{user_id}/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListRoleInfoByUserResponse(),
            self.execute(params, req, runtime)
        )

    async def list_role_info_by_user_with_options_async(
        self,
        agent_id: str,
        user_id: str,
        headers: dingtalkmicro_app__1__0_models.ListRoleInfoByUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListRoleInfoByUserResponse:
        """
        @summary 获取用户在应用中的角色信息列表
        
        @param headers: ListRoleInfoByUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRoleInfoByUserResponse
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
            action='ListRoleInfoByUser',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/users/{user_id}/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListRoleInfoByUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_role_info_by_user(
        self,
        agent_id: str,
        user_id: str,
    ) -> dingtalkmicro_app__1__0_models.ListRoleInfoByUserResponse:
        """
        @summary 获取用户在应用中的角色信息列表
        
        @return: ListRoleInfoByUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListRoleInfoByUserHeaders()
        return self.list_role_info_by_user_with_options(agent_id, user_id, headers, runtime)

    async def list_role_info_by_user_async(
        self,
        agent_id: str,
        user_id: str,
    ) -> dingtalkmicro_app__1__0_models.ListRoleInfoByUserResponse:
        """
        @summary 获取用户在应用中的角色信息列表
        
        @return: ListRoleInfoByUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListRoleInfoByUserHeaders()
        return await self.list_role_info_by_user_with_options_async(agent_id, user_id, headers, runtime)

    def list_user_vileble_app_with_options(
        self,
        user_id: str,
        headers: dingtalkmicro_app__1__0_models.ListUserVilebleAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListUserVilebleAppResponse:
        """
        @summary 列出用户可见的企业应用
        
        @param headers: ListUserVilebleAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListUserVilebleAppResponse
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
            action='ListUserVilebleApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/users/{user_id}/apps',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListUserVilebleAppResponse(),
            self.execute(params, req, runtime)
        )

    async def list_user_vileble_app_with_options_async(
        self,
        user_id: str,
        headers: dingtalkmicro_app__1__0_models.ListUserVilebleAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.ListUserVilebleAppResponse:
        """
        @summary 列出用户可见的企业应用
        
        @param headers: ListUserVilebleAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListUserVilebleAppResponse
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
            action='ListUserVilebleApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/users/{user_id}/apps',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.ListUserVilebleAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_user_vileble_app(
        self,
        user_id: str,
    ) -> dingtalkmicro_app__1__0_models.ListUserVilebleAppResponse:
        """
        @summary 列出用户可见的企业应用
        
        @return: ListUserVilebleAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListUserVilebleAppHeaders()
        return self.list_user_vileble_app_with_options(user_id, headers, runtime)

    async def list_user_vileble_app_async(
        self,
        user_id: str,
    ) -> dingtalkmicro_app__1__0_models.ListUserVilebleAppResponse:
        """
        @summary 列出用户可见的企业应用
        
        @return: ListUserVilebleAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.ListUserVilebleAppHeaders()
        return await self.list_user_vileble_app_with_options_async(user_id, headers, runtime)

    def page_inner_app_history_version_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionRequest,
        headers: dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionResponse:
        """
        @summary 获取企业内部小程序历史版本列表
        
        @param request: PageInnerAppHistoryVersionRequest
        @param headers: PageInnerAppHistoryVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageInnerAppHistoryVersionResponse
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
            action='PageInnerAppHistoryVersion',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/innerMiniApps/{agent_id}/historyVersions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def page_inner_app_history_version_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionRequest,
        headers: dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionResponse:
        """
        @summary 获取企业内部小程序历史版本列表
        
        @param request: PageInnerAppHistoryVersionRequest
        @param headers: PageInnerAppHistoryVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PageInnerAppHistoryVersionResponse
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
            action='PageInnerAppHistoryVersion',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/innerMiniApps/{agent_id}/historyVersions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def page_inner_app_history_version(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionRequest,
    ) -> dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionResponse:
        """
        @summary 获取企业内部小程序历史版本列表
        
        @param request: PageInnerAppHistoryVersionRequest
        @return: PageInnerAppHistoryVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionHeaders()
        return self.page_inner_app_history_version_with_options(agent_id, request, headers, runtime)

    async def page_inner_app_history_version_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionRequest,
    ) -> dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionResponse:
        """
        @summary 获取企业内部小程序历史版本列表
        
        @param request: PageInnerAppHistoryVersionRequest
        @return: PageInnerAppHistoryVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.PageInnerAppHistoryVersionHeaders()
        return await self.page_inner_app_history_version_with_options_async(agent_id, request, headers, runtime)

    def publish_inner_app_version_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.PublishInnerAppVersionRequest,
        headers: dingtalkmicro_app__1__0_models.PublishInnerAppVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.PublishInnerAppVersionResponse:
        """
        @summary 发布企业内部小程序版本
        
        @param request: PublishInnerAppVersionRequest
        @param headers: PublishInnerAppVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PublishInnerAppVersionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_version_id):
            body['appVersionId'] = request.app_version_id
        if not UtilClient.is_unset(request.mini_app_on_pc):
            body['miniAppOnPc'] = request.mini_app_on_pc
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.publish_type):
            body['publishType'] = request.publish_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='PublishInnerAppVersion',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/innerMiniApps/{agent_id}/versions/publish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.PublishInnerAppVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def publish_inner_app_version_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.PublishInnerAppVersionRequest,
        headers: dingtalkmicro_app__1__0_models.PublishInnerAppVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.PublishInnerAppVersionResponse:
        """
        @summary 发布企业内部小程序版本
        
        @param request: PublishInnerAppVersionRequest
        @param headers: PublishInnerAppVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PublishInnerAppVersionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_version_id):
            body['appVersionId'] = request.app_version_id
        if not UtilClient.is_unset(request.mini_app_on_pc):
            body['miniAppOnPc'] = request.mini_app_on_pc
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.publish_type):
            body['publishType'] = request.publish_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='PublishInnerAppVersion',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/innerMiniApps/{agent_id}/versions/publish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.PublishInnerAppVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def publish_inner_app_version(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.PublishInnerAppVersionRequest,
    ) -> dingtalkmicro_app__1__0_models.PublishInnerAppVersionResponse:
        """
        @summary 发布企业内部小程序版本
        
        @param request: PublishInnerAppVersionRequest
        @return: PublishInnerAppVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.PublishInnerAppVersionHeaders()
        return self.publish_inner_app_version_with_options(agent_id, request, headers, runtime)

    async def publish_inner_app_version_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.PublishInnerAppVersionRequest,
    ) -> dingtalkmicro_app__1__0_models.PublishInnerAppVersionResponse:
        """
        @summary 发布企业内部小程序版本
        
        @param request: PublishInnerAppVersionRequest
        @return: PublishInnerAppVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.PublishInnerAppVersionHeaders()
        return await self.publish_inner_app_version_with_options_async(agent_id, request, headers, runtime)

    def rebuild_role_scope_for_app_role_with_options(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleRequest,
        headers: dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleResponse:
        """
        @summary 重设角色范围
        
        @param request: RebuildRoleScopeForAppRoleRequest
        @param headers: RebuildRoleScopeForAppRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RebuildRoleScopeForAppRoleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.scope_type):
            body['scopeType'] = request.scope_type
        if not UtilClient.is_unset(request.scope_version):
            body['scopeVersion'] = request.scope_version
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
            action='RebuildRoleScopeForAppRole',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}/scopes/rebuild',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def rebuild_role_scope_for_app_role_with_options_async(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleRequest,
        headers: dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleResponse:
        """
        @summary 重设角色范围
        
        @param request: RebuildRoleScopeForAppRoleRequest
        @param headers: RebuildRoleScopeForAppRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RebuildRoleScopeForAppRoleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.scope_type):
            body['scopeType'] = request.scope_type
        if not UtilClient.is_unset(request.scope_version):
            body['scopeVersion'] = request.scope_version
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
            action='RebuildRoleScopeForAppRole',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}/scopes/rebuild',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def rebuild_role_scope_for_app_role(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleRequest,
    ) -> dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleResponse:
        """
        @summary 重设角色范围
        
        @param request: RebuildRoleScopeForAppRoleRequest
        @return: RebuildRoleScopeForAppRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleHeaders()
        return self.rebuild_role_scope_for_app_role_with_options(agent_id, role_id, request, headers, runtime)

    async def rebuild_role_scope_for_app_role_async(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleRequest,
    ) -> dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleResponse:
        """
        @summary 重设角色范围
        
        @param request: RebuildRoleScopeForAppRoleRequest
        @return: RebuildRoleScopeForAppRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.RebuildRoleScopeForAppRoleHeaders()
        return await self.rebuild_role_scope_for_app_role_with_options_async(agent_id, role_id, request, headers, runtime)

    def register_custom_app_role_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.RegisterCustomAppRoleRequest,
        headers: dingtalkmicro_app__1__0_models.RegisterCustomAppRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.RegisterCustomAppRoleResponse:
        """
        @summary 注册自定义应用角色
        
        @param request: RegisterCustomAppRoleRequest
        @param headers: RegisterCustomAppRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterCustomAppRoleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.can_manage_role):
            body['canManageRole'] = request.can_manage_role
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role_name):
            body['roleName'] = request.role_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RegisterCustomAppRole',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.RegisterCustomAppRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def register_custom_app_role_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.RegisterCustomAppRoleRequest,
        headers: dingtalkmicro_app__1__0_models.RegisterCustomAppRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.RegisterCustomAppRoleResponse:
        """
        @summary 注册自定义应用角色
        
        @param request: RegisterCustomAppRoleRequest
        @param headers: RegisterCustomAppRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterCustomAppRoleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.can_manage_role):
            body['canManageRole'] = request.can_manage_role
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.role_name):
            body['roleName'] = request.role_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RegisterCustomAppRole',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.RegisterCustomAppRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def register_custom_app_role(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.RegisterCustomAppRoleRequest,
    ) -> dingtalkmicro_app__1__0_models.RegisterCustomAppRoleResponse:
        """
        @summary 注册自定义应用角色
        
        @param request: RegisterCustomAppRoleRequest
        @return: RegisterCustomAppRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.RegisterCustomAppRoleHeaders()
        return self.register_custom_app_role_with_options(agent_id, request, headers, runtime)

    async def register_custom_app_role_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.RegisterCustomAppRoleRequest,
    ) -> dingtalkmicro_app__1__0_models.RegisterCustomAppRoleResponse:
        """
        @summary 注册自定义应用角色
        
        @param request: RegisterCustomAppRoleRequest
        @return: RegisterCustomAppRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.RegisterCustomAppRoleHeaders()
        return await self.register_custom_app_role_with_options_async(agent_id, request, headers, runtime)

    def remove_apaas_app_with_options(
        self,
        request: dingtalkmicro_app__1__0_models.RemoveApaasAppRequest,
        headers: dingtalkmicro_app__1__0_models.RemoveApaasAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.RemoveApaasAppResponse:
        """
        @summary 删除apaas应用
        
        @param request: RemoveApaasAppRequest
        @param headers: RemoveApaasAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveApaasAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_app_id):
            body['bizAppId'] = request.biz_app_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RemoveApaasApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apaasApps/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.RemoveApaasAppResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_apaas_app_with_options_async(
        self,
        request: dingtalkmicro_app__1__0_models.RemoveApaasAppRequest,
        headers: dingtalkmicro_app__1__0_models.RemoveApaasAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.RemoveApaasAppResponse:
        """
        @summary 删除apaas应用
        
        @param request: RemoveApaasAppRequest
        @param headers: RemoveApaasAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveApaasAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_app_id):
            body['bizAppId'] = request.biz_app_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RemoveApaasApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apaasApps/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.RemoveApaasAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_apaas_app(
        self,
        request: dingtalkmicro_app__1__0_models.RemoveApaasAppRequest,
    ) -> dingtalkmicro_app__1__0_models.RemoveApaasAppResponse:
        """
        @summary 删除apaas应用
        
        @param request: RemoveApaasAppRequest
        @return: RemoveApaasAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.RemoveApaasAppHeaders()
        return self.remove_apaas_app_with_options(request, headers, runtime)

    async def remove_apaas_app_async(
        self,
        request: dingtalkmicro_app__1__0_models.RemoveApaasAppRequest,
    ) -> dingtalkmicro_app__1__0_models.RemoveApaasAppResponse:
        """
        @summary 删除apaas应用
        
        @param request: RemoveApaasAppRequest
        @return: RemoveApaasAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.RemoveApaasAppHeaders()
        return await self.remove_apaas_app_with_options_async(request, headers, runtime)

    def remove_member_for_app_role_with_options(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleRequest,
        headers: dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleResponse:
        """
        @summary 删除指定角色下的成员
        
        @param request: RemoveMemberForAppRoleRequest
        @param headers: RemoveMemberForAppRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveMemberForAppRoleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.scope_version):
            body['scopeVersion'] = request.scope_version
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
            action='RemoveMemberForAppRole',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}/members/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_member_for_app_role_with_options_async(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleRequest,
        headers: dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleResponse:
        """
        @summary 删除指定角色下的成员
        
        @param request: RemoveMemberForAppRoleRequest
        @param headers: RemoveMemberForAppRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveMemberForAppRoleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id_list):
            body['deptIdList'] = request.dept_id_list
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.scope_version):
            body['scopeVersion'] = request.scope_version
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
            action='RemoveMemberForAppRole',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}/members/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_member_for_app_role(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleRequest,
    ) -> dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleResponse:
        """
        @summary 删除指定角色下的成员
        
        @param request: RemoveMemberForAppRoleRequest
        @return: RemoveMemberForAppRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleHeaders()
        return self.remove_member_for_app_role_with_options(agent_id, role_id, request, headers, runtime)

    async def remove_member_for_app_role_async(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleRequest,
    ) -> dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleResponse:
        """
        @summary 删除指定角色下的成员
        
        @param request: RemoveMemberForAppRoleRequest
        @return: RemoveMemberForAppRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.RemoveMemberForAppRoleHeaders()
        return await self.remove_member_for_app_role_with_options_async(agent_id, role_id, request, headers, runtime)

    def rollback_inner_app_version_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.RollbackInnerAppVersionRequest,
        headers: dingtalkmicro_app__1__0_models.RollbackInnerAppVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.RollbackInnerAppVersionResponse:
        """
        @summary 回滚企业内部小程序版本
        
        @param request: RollbackInnerAppVersionRequest
        @param headers: RollbackInnerAppVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RollbackInnerAppVersionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_version_id):
            body['appVersionId'] = request.app_version_id
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RollbackInnerAppVersion',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/innerMiniApps/{agent_id}/versions/rollback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.RollbackInnerAppVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def rollback_inner_app_version_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.RollbackInnerAppVersionRequest,
        headers: dingtalkmicro_app__1__0_models.RollbackInnerAppVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.RollbackInnerAppVersionResponse:
        """
        @summary 回滚企业内部小程序版本
        
        @param request: RollbackInnerAppVersionRequest
        @param headers: RollbackInnerAppVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RollbackInnerAppVersionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_version_id):
            body['appVersionId'] = request.app_version_id
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RollbackInnerAppVersion',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/innerMiniApps/{agent_id}/versions/rollback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.RollbackInnerAppVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def rollback_inner_app_version(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.RollbackInnerAppVersionRequest,
    ) -> dingtalkmicro_app__1__0_models.RollbackInnerAppVersionResponse:
        """
        @summary 回滚企业内部小程序版本
        
        @param request: RollbackInnerAppVersionRequest
        @return: RollbackInnerAppVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.RollbackInnerAppVersionHeaders()
        return self.rollback_inner_app_version_with_options(agent_id, request, headers, runtime)

    async def rollback_inner_app_version_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.RollbackInnerAppVersionRequest,
    ) -> dingtalkmicro_app__1__0_models.RollbackInnerAppVersionResponse:
        """
        @summary 回滚企业内部小程序版本
        
        @param request: RollbackInnerAppVersionRequest
        @return: RollbackInnerAppVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.RollbackInnerAppVersionHeaders()
        return await self.rollback_inner_app_version_with_options_async(agent_id, request, headers, runtime)

    def set_micro_app_scope_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.SetMicroAppScopeRequest,
        headers: dingtalkmicro_app__1__0_models.SetMicroAppScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.SetMicroAppScopeResponse:
        """
        @summary 设置应用可见范围
        
        @param request: SetMicroAppScopeRequest
        @param headers: SetMicroAppScopeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetMicroAppScopeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_dept_ids):
            body['addDeptIds'] = request.add_dept_ids
        if not UtilClient.is_unset(request.add_role_ids):
            body['addRoleIds'] = request.add_role_ids
        if not UtilClient.is_unset(request.add_user_ids):
            body['addUserIds'] = request.add_user_ids
        if not UtilClient.is_unset(request.del_dept_ids):
            body['delDeptIds'] = request.del_dept_ids
        if not UtilClient.is_unset(request.del_role_ids):
            body['delRoleIds'] = request.del_role_ids
        if not UtilClient.is_unset(request.del_user_ids):
            body['delUserIds'] = request.del_user_ids
        if not UtilClient.is_unset(request.only_admin_visible):
            body['onlyAdminVisible'] = request.only_admin_visible
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetMicroAppScope',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/scopes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.SetMicroAppScopeResponse(),
            self.execute(params, req, runtime)
        )

    async def set_micro_app_scope_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.SetMicroAppScopeRequest,
        headers: dingtalkmicro_app__1__0_models.SetMicroAppScopeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.SetMicroAppScopeResponse:
        """
        @summary 设置应用可见范围
        
        @param request: SetMicroAppScopeRequest
        @param headers: SetMicroAppScopeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetMicroAppScopeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.add_dept_ids):
            body['addDeptIds'] = request.add_dept_ids
        if not UtilClient.is_unset(request.add_role_ids):
            body['addRoleIds'] = request.add_role_ids
        if not UtilClient.is_unset(request.add_user_ids):
            body['addUserIds'] = request.add_user_ids
        if not UtilClient.is_unset(request.del_dept_ids):
            body['delDeptIds'] = request.del_dept_ids
        if not UtilClient.is_unset(request.del_role_ids):
            body['delRoleIds'] = request.del_role_ids
        if not UtilClient.is_unset(request.del_user_ids):
            body['delUserIds'] = request.del_user_ids
        if not UtilClient.is_unset(request.only_admin_visible):
            body['onlyAdminVisible'] = request.only_admin_visible
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetMicroAppScope',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/scopes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.SetMicroAppScopeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_micro_app_scope(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.SetMicroAppScopeRequest,
    ) -> dingtalkmicro_app__1__0_models.SetMicroAppScopeResponse:
        """
        @summary 设置应用可见范围
        
        @param request: SetMicroAppScopeRequest
        @return: SetMicroAppScopeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.SetMicroAppScopeHeaders()
        return self.set_micro_app_scope_with_options(agent_id, request, headers, runtime)

    async def set_micro_app_scope_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.SetMicroAppScopeRequest,
    ) -> dingtalkmicro_app__1__0_models.SetMicroAppScopeResponse:
        """
        @summary 设置应用可见范围
        
        @param request: SetMicroAppScopeRequest
        @return: SetMicroAppScopeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.SetMicroAppScopeHeaders()
        return await self.set_micro_app_scope_with_options_async(agent_id, request, headers, runtime)

    def update_apaas_app_with_options(
        self,
        request: dingtalkmicro_app__1__0_models.UpdateApaasAppRequest,
        headers: dingtalkmicro_app__1__0_models.UpdateApaasAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.UpdateApaasAppResponse:
        """
        @summary 更新apaas应用
        
        @param request: UpdateApaasAppRequest
        @param headers: UpdateApaasAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateApaasAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_icon):
            body['appIcon'] = request.app_icon
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.app_status):
            body['appStatus'] = request.app_status
        if not UtilClient.is_unset(request.biz_app_id):
            body['bizAppId'] = request.biz_app_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateApaasApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apaasApps',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.UpdateApaasAppResponse(),
            self.execute(params, req, runtime)
        )

    async def update_apaas_app_with_options_async(
        self,
        request: dingtalkmicro_app__1__0_models.UpdateApaasAppRequest,
        headers: dingtalkmicro_app__1__0_models.UpdateApaasAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.UpdateApaasAppResponse:
        """
        @summary 更新apaas应用
        
        @param request: UpdateApaasAppRequest
        @param headers: UpdateApaasAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateApaasAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_icon):
            body['appIcon'] = request.app_icon
        if not UtilClient.is_unset(request.app_name):
            body['appName'] = request.app_name
        if not UtilClient.is_unset(request.app_status):
            body['appStatus'] = request.app_status
        if not UtilClient.is_unset(request.biz_app_id):
            body['bizAppId'] = request.biz_app_id
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateApaasApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apaasApps',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.UpdateApaasAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_apaas_app(
        self,
        request: dingtalkmicro_app__1__0_models.UpdateApaasAppRequest,
    ) -> dingtalkmicro_app__1__0_models.UpdateApaasAppResponse:
        """
        @summary 更新apaas应用
        
        @param request: UpdateApaasAppRequest
        @return: UpdateApaasAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.UpdateApaasAppHeaders()
        return self.update_apaas_app_with_options(request, headers, runtime)

    async def update_apaas_app_async(
        self,
        request: dingtalkmicro_app__1__0_models.UpdateApaasAppRequest,
    ) -> dingtalkmicro_app__1__0_models.UpdateApaasAppResponse:
        """
        @summary 更新apaas应用
        
        @param request: UpdateApaasAppRequest
        @return: UpdateApaasAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.UpdateApaasAppHeaders()
        return await self.update_apaas_app_with_options_async(request, headers, runtime)

    def update_app_role_info_with_options(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateAppRoleInfoRequest,
        headers: dingtalkmicro_app__1__0_models.UpdateAppRoleInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.UpdateAppRoleInfoResponse:
        """
        @summary 更新应用角色信息
        
        @param request: UpdateAppRoleInfoRequest
        @param headers: UpdateAppRoleInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateAppRoleInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.can_manage_role):
            body['canManageRole'] = request.can_manage_role
        if not UtilClient.is_unset(request.new_role_name):
            body['newRoleName'] = request.new_role_name
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateAppRoleInfo',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.UpdateAppRoleInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def update_app_role_info_with_options_async(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateAppRoleInfoRequest,
        headers: dingtalkmicro_app__1__0_models.UpdateAppRoleInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.UpdateAppRoleInfoResponse:
        """
        @summary 更新应用角色信息
        
        @param request: UpdateAppRoleInfoRequest
        @param headers: UpdateAppRoleInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateAppRoleInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.can_manage_role):
            body['canManageRole'] = request.can_manage_role
        if not UtilClient.is_unset(request.new_role_name):
            body['newRoleName'] = request.new_role_name
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateAppRoleInfo',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}/roles/{role_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.UpdateAppRoleInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_app_role_info(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateAppRoleInfoRequest,
    ) -> dingtalkmicro_app__1__0_models.UpdateAppRoleInfoResponse:
        """
        @summary 更新应用角色信息
        
        @param request: UpdateAppRoleInfoRequest
        @return: UpdateAppRoleInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.UpdateAppRoleInfoHeaders()
        return self.update_app_role_info_with_options(agent_id, role_id, request, headers, runtime)

    async def update_app_role_info_async(
        self,
        agent_id: str,
        role_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateAppRoleInfoRequest,
    ) -> dingtalkmicro_app__1__0_models.UpdateAppRoleInfoResponse:
        """
        @summary 更新应用角色信息
        
        @param request: UpdateAppRoleInfoRequest
        @return: UpdateAppRoleInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.UpdateAppRoleInfoHeaders()
        return await self.update_app_role_info_with_options_async(agent_id, role_id, request, headers, runtime)

    def update_inner_app_with_options(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.UpdateInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.UpdateInnerAppResponse:
        """
        @summary 更新企业内部应用
        
        @param request: UpdateInnerAppRequest
        @param headers: UpdateInnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInnerAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.homepage_link):
            body['homepageLink'] = request.homepage_link
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.ip_white_list):
            body['ipWhiteList'] = request.ip_white_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.omp_link):
            body['ompLink'] = request.omp_link
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.pc_homepage_link):
            body['pcHomepageLink'] = request.pc_homepage_link
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInnerApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.UpdateInnerAppResponse(),
            self.execute(params, req, runtime)
        )

    async def update_inner_app_with_options_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateInnerAppRequest,
        headers: dingtalkmicro_app__1__0_models.UpdateInnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmicro_app__1__0_models.UpdateInnerAppResponse:
        """
        @summary 更新企业内部应用
        
        @param request: UpdateInnerAppRequest
        @param headers: UpdateInnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInnerAppResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.desc):
            body['desc'] = request.desc
        if not UtilClient.is_unset(request.homepage_link):
            body['homepageLink'] = request.homepage_link
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.ip_white_list):
            body['ipWhiteList'] = request.ip_white_list
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.omp_link):
            body['ompLink'] = request.omp_link
        if not UtilClient.is_unset(request.op_union_id):
            body['opUnionId'] = request.op_union_id
        if not UtilClient.is_unset(request.pc_homepage_link):
            body['pcHomepageLink'] = request.pc_homepage_link
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInnerApp',
            version='microApp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/microApp/apps/{agent_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmicro_app__1__0_models.UpdateInnerAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_inner_app(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.UpdateInnerAppResponse:
        """
        @summary 更新企业内部应用
        
        @param request: UpdateInnerAppRequest
        @return: UpdateInnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.UpdateInnerAppHeaders()
        return self.update_inner_app_with_options(agent_id, request, headers, runtime)

    async def update_inner_app_async(
        self,
        agent_id: str,
        request: dingtalkmicro_app__1__0_models.UpdateInnerAppRequest,
    ) -> dingtalkmicro_app__1__0_models.UpdateInnerAppResponse:
        """
        @summary 更新企业内部应用
        
        @param request: UpdateInnerAppRequest
        @return: UpdateInnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmicro_app__1__0_models.UpdateInnerAppHeaders()
        return await self.update_inner_app_with_options_async(agent_id, request, headers, runtime)
