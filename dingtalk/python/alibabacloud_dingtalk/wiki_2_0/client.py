# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.wiki_2_0 import models as dingtalkwiki__2__0_models
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

    def add_team_with_options(
        self,
        request: dingtalkwiki__2__0_models.AddTeamRequest,
        headers: dingtalkwiki__2__0_models.AddTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.AddTeamResponse:
        """
        @summary 新建知识小组
        
        @param request: AddTeamRequest
        @param headers: AddTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddTeamResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='AddTeam',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/teams',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.AddTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def add_team_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.AddTeamRequest,
        headers: dingtalkwiki__2__0_models.AddTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.AddTeamResponse:
        """
        @summary 新建知识小组
        
        @param request: AddTeamRequest
        @param headers: AddTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddTeamResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='AddTeam',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/teams',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.AddTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_team(
        self,
        request: dingtalkwiki__2__0_models.AddTeamRequest,
    ) -> dingtalkwiki__2__0_models.AddTeamResponse:
        """
        @summary 新建知识小组
        
        @param request: AddTeamRequest
        @return: AddTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.AddTeamHeaders()
        return self.add_team_with_options(request, headers, runtime)

    async def add_team_async(
        self,
        request: dingtalkwiki__2__0_models.AddTeamRequest,
    ) -> dingtalkwiki__2__0_models.AddTeamResponse:
        """
        @summary 新建知识小组
        
        @param request: AddTeamRequest
        @return: AddTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.AddTeamHeaders()
        return await self.add_team_with_options_async(request, headers, runtime)

    def add_workspace_with_options(
        self,
        request: dingtalkwiki__2__0_models.AddWorkspaceRequest,
        headers: dingtalkwiki__2__0_models.AddWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.AddWorkspaceResponse:
        """
        @summary 新建知识库
        
        @param request: AddWorkspaceRequest
        @param headers: AddWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddWorkspaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='AddWorkspace',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/workspaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.AddWorkspaceResponse(),
            self.execute(params, req, runtime)
        )

    async def add_workspace_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.AddWorkspaceRequest,
        headers: dingtalkwiki__2__0_models.AddWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.AddWorkspaceResponse:
        """
        @summary 新建知识库
        
        @param request: AddWorkspaceRequest
        @param headers: AddWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddWorkspaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='AddWorkspace',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/workspaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.AddWorkspaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_workspace(
        self,
        request: dingtalkwiki__2__0_models.AddWorkspaceRequest,
    ) -> dingtalkwiki__2__0_models.AddWorkspaceResponse:
        """
        @summary 新建知识库
        
        @param request: AddWorkspaceRequest
        @return: AddWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.AddWorkspaceHeaders()
        return self.add_workspace_with_options(request, headers, runtime)

    async def add_workspace_async(
        self,
        request: dingtalkwiki__2__0_models.AddWorkspaceRequest,
    ) -> dingtalkwiki__2__0_models.AddWorkspaceResponse:
        """
        @summary 新建知识库
        
        @param request: AddWorkspaceRequest
        @return: AddWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.AddWorkspaceHeaders()
        return await self.add_workspace_with_options_async(request, headers, runtime)

    def delete_team_with_options(
        self,
        team_id: str,
        request: dingtalkwiki__2__0_models.DeleteTeamRequest,
        headers: dingtalkwiki__2__0_models.DeleteTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.DeleteTeamResponse:
        """
        @summary 删除知识小组
        
        @param request: DeleteTeamRequest
        @param headers: DeleteTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTeamResponse
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
            action='DeleteTeam',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/teams/{team_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.DeleteTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_team_with_options_async(
        self,
        team_id: str,
        request: dingtalkwiki__2__0_models.DeleteTeamRequest,
        headers: dingtalkwiki__2__0_models.DeleteTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.DeleteTeamResponse:
        """
        @summary 删除知识小组
        
        @param request: DeleteTeamRequest
        @param headers: DeleteTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTeamResponse
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
            action='DeleteTeam',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/teams/{team_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.DeleteTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_team(
        self,
        team_id: str,
        request: dingtalkwiki__2__0_models.DeleteTeamRequest,
    ) -> dingtalkwiki__2__0_models.DeleteTeamResponse:
        """
        @summary 删除知识小组
        
        @param request: DeleteTeamRequest
        @return: DeleteTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.DeleteTeamHeaders()
        return self.delete_team_with_options(team_id, request, headers, runtime)

    async def delete_team_async(
        self,
        team_id: str,
        request: dingtalkwiki__2__0_models.DeleteTeamRequest,
    ) -> dingtalkwiki__2__0_models.DeleteTeamResponse:
        """
        @summary 删除知识小组
        
        @param request: DeleteTeamRequest
        @return: DeleteTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.DeleteTeamHeaders()
        return await self.delete_team_with_options_async(team_id, request, headers, runtime)

    def get_default_hand_over_user_with_options(
        self,
        request: dingtalkwiki__2__0_models.GetDefaultHandOverUserRequest,
        headers: dingtalkwiki__2__0_models.GetDefaultHandOverUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetDefaultHandOverUserResponse:
        """
        @summary 查询员工离职时知识库默认转交人
        
        @param request: GetDefaultHandOverUserRequest
        @param headers: GetDefaultHandOverUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDefaultHandOverUserResponse
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
            action='GetDefaultHandOverUser',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/managementSettings/defaultHandOverUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetDefaultHandOverUserResponse(),
            self.execute(params, req, runtime)
        )

    async def get_default_hand_over_user_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.GetDefaultHandOverUserRequest,
        headers: dingtalkwiki__2__0_models.GetDefaultHandOverUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetDefaultHandOverUserResponse:
        """
        @summary 查询员工离职时知识库默认转交人
        
        @param request: GetDefaultHandOverUserRequest
        @param headers: GetDefaultHandOverUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDefaultHandOverUserResponse
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
            action='GetDefaultHandOverUser',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/managementSettings/defaultHandOverUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetDefaultHandOverUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_default_hand_over_user(
        self,
        request: dingtalkwiki__2__0_models.GetDefaultHandOverUserRequest,
    ) -> dingtalkwiki__2__0_models.GetDefaultHandOverUserResponse:
        """
        @summary 查询员工离职时知识库默认转交人
        
        @param request: GetDefaultHandOverUserRequest
        @return: GetDefaultHandOverUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetDefaultHandOverUserHeaders()
        return self.get_default_hand_over_user_with_options(request, headers, runtime)

    async def get_default_hand_over_user_async(
        self,
        request: dingtalkwiki__2__0_models.GetDefaultHandOverUserRequest,
    ) -> dingtalkwiki__2__0_models.GetDefaultHandOverUserResponse:
        """
        @summary 查询员工离职时知识库默认转交人
        
        @param request: GetDefaultHandOverUserRequest
        @return: GetDefaultHandOverUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetDefaultHandOverUserHeaders()
        return await self.get_default_hand_over_user_with_options_async(request, headers, runtime)

    def get_mine_workspace_with_options(
        self,
        request: dingtalkwiki__2__0_models.GetMineWorkspaceRequest,
        headers: dingtalkwiki__2__0_models.GetMineWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetMineWorkspaceResponse:
        """
        @summary 获取我的文档
        
        @param request: GetMineWorkspaceRequest
        @param headers: GetMineWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMineWorkspaceResponse
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
            action='GetMineWorkspace',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/mineWorkspaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetMineWorkspaceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_mine_workspace_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.GetMineWorkspaceRequest,
        headers: dingtalkwiki__2__0_models.GetMineWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetMineWorkspaceResponse:
        """
        @summary 获取我的文档
        
        @param request: GetMineWorkspaceRequest
        @param headers: GetMineWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMineWorkspaceResponse
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
            action='GetMineWorkspace',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/mineWorkspaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetMineWorkspaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_mine_workspace(
        self,
        request: dingtalkwiki__2__0_models.GetMineWorkspaceRequest,
    ) -> dingtalkwiki__2__0_models.GetMineWorkspaceResponse:
        """
        @summary 获取我的文档
        
        @param request: GetMineWorkspaceRequest
        @return: GetMineWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetMineWorkspaceHeaders()
        return self.get_mine_workspace_with_options(request, headers, runtime)

    async def get_mine_workspace_async(
        self,
        request: dingtalkwiki__2__0_models.GetMineWorkspaceRequest,
    ) -> dingtalkwiki__2__0_models.GetMineWorkspaceResponse:
        """
        @summary 获取我的文档
        
        @param request: GetMineWorkspaceRequest
        @return: GetMineWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetMineWorkspaceHeaders()
        return await self.get_mine_workspace_with_options_async(request, headers, runtime)

    def get_node_with_options(
        self,
        node_id: str,
        request: dingtalkwiki__2__0_models.GetNodeRequest,
        headers: dingtalkwiki__2__0_models.GetNodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetNodeResponse:
        """
        @summary 获取节点
        
        @param request: GetNodeRequest
        @param headers: GetNodeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNodeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.with_permission_role):
            query['withPermissionRole'] = request.with_permission_role
        if not UtilClient.is_unset(request.with_statistical_info):
            query['withStatisticalInfo'] = request.with_statistical_info
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetNode',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/nodes/{node_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetNodeResponse(),
            self.execute(params, req, runtime)
        )

    async def get_node_with_options_async(
        self,
        node_id: str,
        request: dingtalkwiki__2__0_models.GetNodeRequest,
        headers: dingtalkwiki__2__0_models.GetNodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetNodeResponse:
        """
        @summary 获取节点
        
        @param request: GetNodeRequest
        @param headers: GetNodeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNodeResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.with_permission_role):
            query['withPermissionRole'] = request.with_permission_role
        if not UtilClient.is_unset(request.with_statistical_info):
            query['withStatisticalInfo'] = request.with_statistical_info
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetNode',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/nodes/{node_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetNodeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_node(
        self,
        node_id: str,
        request: dingtalkwiki__2__0_models.GetNodeRequest,
    ) -> dingtalkwiki__2__0_models.GetNodeResponse:
        """
        @summary 获取节点
        
        @param request: GetNodeRequest
        @return: GetNodeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetNodeHeaders()
        return self.get_node_with_options(node_id, request, headers, runtime)

    async def get_node_async(
        self,
        node_id: str,
        request: dingtalkwiki__2__0_models.GetNodeRequest,
    ) -> dingtalkwiki__2__0_models.GetNodeResponse:
        """
        @summary 获取节点
        
        @param request: GetNodeRequest
        @return: GetNodeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetNodeHeaders()
        return await self.get_node_with_options_async(node_id, request, headers, runtime)

    def get_node_by_url_with_options(
        self,
        request: dingtalkwiki__2__0_models.GetNodeByUrlRequest,
        headers: dingtalkwiki__2__0_models.GetNodeByUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetNodeByUrlResponse:
        """
        @summary 通过链接获取节点
        
        @param request: GetNodeByUrlRequest
        @param headers: GetNodeByUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNodeByUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.url):
            body['url'] = request.url
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
            action='GetNodeByUrl',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/nodes/queryByUrl',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetNodeByUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_node_by_url_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.GetNodeByUrlRequest,
        headers: dingtalkwiki__2__0_models.GetNodeByUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetNodeByUrlResponse:
        """
        @summary 通过链接获取节点
        
        @param request: GetNodeByUrlRequest
        @param headers: GetNodeByUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNodeByUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.url):
            body['url'] = request.url
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
            action='GetNodeByUrl',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/nodes/queryByUrl',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetNodeByUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_node_by_url(
        self,
        request: dingtalkwiki__2__0_models.GetNodeByUrlRequest,
    ) -> dingtalkwiki__2__0_models.GetNodeByUrlResponse:
        """
        @summary 通过链接获取节点
        
        @param request: GetNodeByUrlRequest
        @return: GetNodeByUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetNodeByUrlHeaders()
        return self.get_node_by_url_with_options(request, headers, runtime)

    async def get_node_by_url_async(
        self,
        request: dingtalkwiki__2__0_models.GetNodeByUrlRequest,
    ) -> dingtalkwiki__2__0_models.GetNodeByUrlResponse:
        """
        @summary 通过链接获取节点
        
        @param request: GetNodeByUrlRequest
        @return: GetNodeByUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetNodeByUrlHeaders()
        return await self.get_node_by_url_with_options_async(request, headers, runtime)

    def get_nodes_with_options(
        self,
        request: dingtalkwiki__2__0_models.GetNodesRequest,
        headers: dingtalkwiki__2__0_models.GetNodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetNodesResponse:
        """
        @summary 批量获取节点
        
        @param request: GetNodesRequest
        @param headers: GetNodesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNodesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.node_ids):
            body['nodeIds'] = request.node_ids
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='GetNodes',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/nodes/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetNodesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_nodes_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.GetNodesRequest,
        headers: dingtalkwiki__2__0_models.GetNodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetNodesResponse:
        """
        @summary 批量获取节点
        
        @param request: GetNodesRequest
        @param headers: GetNodesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNodesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.node_ids):
            body['nodeIds'] = request.node_ids
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='GetNodes',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/nodes/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetNodesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_nodes(
        self,
        request: dingtalkwiki__2__0_models.GetNodesRequest,
    ) -> dingtalkwiki__2__0_models.GetNodesResponse:
        """
        @summary 批量获取节点
        
        @param request: GetNodesRequest
        @return: GetNodesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetNodesHeaders()
        return self.get_nodes_with_options(request, headers, runtime)

    async def get_nodes_async(
        self,
        request: dingtalkwiki__2__0_models.GetNodesRequest,
    ) -> dingtalkwiki__2__0_models.GetNodesResponse:
        """
        @summary 批量获取节点
        
        @param request: GetNodesRequest
        @return: GetNodesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetNodesHeaders()
        return await self.get_nodes_with_options_async(request, headers, runtime)

    def get_team_with_options(
        self,
        team_id: str,
        request: dingtalkwiki__2__0_models.GetTeamRequest,
        headers: dingtalkwiki__2__0_models.GetTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetTeamResponse:
        """
        @summary 获取知识小组
        
        @param request: GetTeamRequest
        @param headers: GetTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTeamResponse
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
            action='GetTeam',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/teams/{team_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def get_team_with_options_async(
        self,
        team_id: str,
        request: dingtalkwiki__2__0_models.GetTeamRequest,
        headers: dingtalkwiki__2__0_models.GetTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetTeamResponse:
        """
        @summary 获取知识小组
        
        @param request: GetTeamRequest
        @param headers: GetTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTeamResponse
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
            action='GetTeam',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/teams/{team_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_team(
        self,
        team_id: str,
        request: dingtalkwiki__2__0_models.GetTeamRequest,
    ) -> dingtalkwiki__2__0_models.GetTeamResponse:
        """
        @summary 获取知识小组
        
        @param request: GetTeamRequest
        @return: GetTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetTeamHeaders()
        return self.get_team_with_options(team_id, request, headers, runtime)

    async def get_team_async(
        self,
        team_id: str,
        request: dingtalkwiki__2__0_models.GetTeamRequest,
    ) -> dingtalkwiki__2__0_models.GetTeamResponse:
        """
        @summary 获取知识小组
        
        @param request: GetTeamRequest
        @return: GetTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetTeamHeaders()
        return await self.get_team_with_options_async(team_id, request, headers, runtime)

    def get_workspace_with_options(
        self,
        workspace_id: str,
        request: dingtalkwiki__2__0_models.GetWorkspaceRequest,
        headers: dingtalkwiki__2__0_models.GetWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetWorkspaceResponse:
        """
        @summary 获取知识库
        
        @param request: GetWorkspaceRequest
        @param headers: GetWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWorkspaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.with_permission_role):
            query['withPermissionRole'] = request.with_permission_role
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetWorkspace',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/workspaces/{workspace_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetWorkspaceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_workspace_with_options_async(
        self,
        workspace_id: str,
        request: dingtalkwiki__2__0_models.GetWorkspaceRequest,
        headers: dingtalkwiki__2__0_models.GetWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetWorkspaceResponse:
        """
        @summary 获取知识库
        
        @param request: GetWorkspaceRequest
        @param headers: GetWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWorkspaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.with_permission_role):
            query['withPermissionRole'] = request.with_permission_role
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetWorkspace',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/workspaces/{workspace_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetWorkspaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_workspace(
        self,
        workspace_id: str,
        request: dingtalkwiki__2__0_models.GetWorkspaceRequest,
    ) -> dingtalkwiki__2__0_models.GetWorkspaceResponse:
        """
        @summary 获取知识库
        
        @param request: GetWorkspaceRequest
        @return: GetWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetWorkspaceHeaders()
        return self.get_workspace_with_options(workspace_id, request, headers, runtime)

    async def get_workspace_async(
        self,
        workspace_id: str,
        request: dingtalkwiki__2__0_models.GetWorkspaceRequest,
    ) -> dingtalkwiki__2__0_models.GetWorkspaceResponse:
        """
        @summary 获取知识库
        
        @param request: GetWorkspaceRequest
        @return: GetWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetWorkspaceHeaders()
        return await self.get_workspace_with_options_async(workspace_id, request, headers, runtime)

    def get_workspaces_with_options(
        self,
        request: dingtalkwiki__2__0_models.GetWorkspacesRequest,
        headers: dingtalkwiki__2__0_models.GetWorkspacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetWorkspacesResponse:
        """
        @summary 批量获取知识库
        
        @param request: GetWorkspacesRequest
        @param headers: GetWorkspacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWorkspacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.workspace_ids):
            body['workspaceIds'] = request.workspace_ids
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
            action='GetWorkspaces',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/workspaces/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetWorkspacesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_workspaces_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.GetWorkspacesRequest,
        headers: dingtalkwiki__2__0_models.GetWorkspacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.GetWorkspacesResponse:
        """
        @summary 批量获取知识库
        
        @param request: GetWorkspacesRequest
        @param headers: GetWorkspacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWorkspacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.workspace_ids):
            body['workspaceIds'] = request.workspace_ids
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
            action='GetWorkspaces',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/workspaces/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.GetWorkspacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_workspaces(
        self,
        request: dingtalkwiki__2__0_models.GetWorkspacesRequest,
    ) -> dingtalkwiki__2__0_models.GetWorkspacesResponse:
        """
        @summary 批量获取知识库
        
        @param request: GetWorkspacesRequest
        @return: GetWorkspacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetWorkspacesHeaders()
        return self.get_workspaces_with_options(request, headers, runtime)

    async def get_workspaces_async(
        self,
        request: dingtalkwiki__2__0_models.GetWorkspacesRequest,
    ) -> dingtalkwiki__2__0_models.GetWorkspacesResponse:
        """
        @summary 批量获取知识库
        
        @param request: GetWorkspacesRequest
        @return: GetWorkspacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.GetWorkspacesHeaders()
        return await self.get_workspaces_with_options_async(request, headers, runtime)

    def hand_over_workspace_with_options(
        self,
        request: dingtalkwiki__2__0_models.HandOverWorkspaceRequest,
        headers: dingtalkwiki__2__0_models.HandOverWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.HandOverWorkspaceResponse:
        """
        @summary 转交知识库
        
        @param request: HandOverWorkspaceRequest
        @param headers: HandOverWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HandOverWorkspaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.source_owner_id):
            body['sourceOwnerId'] = request.source_owner_id
        if not UtilClient.is_unset(request.target_owner_id):
            body['targetOwnerId'] = request.target_owner_id
        if not UtilClient.is_unset(request.workspace_id):
            body['workspaceId'] = request.workspace_id
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
            action='HandOverWorkspace',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/managementOperations/workspaces/handOver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.HandOverWorkspaceResponse(),
            self.execute(params, req, runtime)
        )

    async def hand_over_workspace_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.HandOverWorkspaceRequest,
        headers: dingtalkwiki__2__0_models.HandOverWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.HandOverWorkspaceResponse:
        """
        @summary 转交知识库
        
        @param request: HandOverWorkspaceRequest
        @param headers: HandOverWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HandOverWorkspaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.source_owner_id):
            body['sourceOwnerId'] = request.source_owner_id
        if not UtilClient.is_unset(request.target_owner_id):
            body['targetOwnerId'] = request.target_owner_id
        if not UtilClient.is_unset(request.workspace_id):
            body['workspaceId'] = request.workspace_id
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
            action='HandOverWorkspace',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/managementOperations/workspaces/handOver',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.HandOverWorkspaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def hand_over_workspace(
        self,
        request: dingtalkwiki__2__0_models.HandOverWorkspaceRequest,
    ) -> dingtalkwiki__2__0_models.HandOverWorkspaceResponse:
        """
        @summary 转交知识库
        
        @param request: HandOverWorkspaceRequest
        @return: HandOverWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.HandOverWorkspaceHeaders()
        return self.hand_over_workspace_with_options(request, headers, runtime)

    async def hand_over_workspace_async(
        self,
        request: dingtalkwiki__2__0_models.HandOverWorkspaceRequest,
    ) -> dingtalkwiki__2__0_models.HandOverWorkspaceResponse:
        """
        @summary 转交知识库
        
        @param request: HandOverWorkspaceRequest
        @return: HandOverWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.HandOverWorkspaceHeaders()
        return await self.hand_over_workspace_with_options_async(request, headers, runtime)

    def list_nodes_with_options(
        self,
        request: dingtalkwiki__2__0_models.ListNodesRequest,
        headers: dingtalkwiki__2__0_models.ListNodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.ListNodesResponse:
        """
        @summary 获取节点列表
        
        @param request: ListNodesRequest
        @param headers: ListNodesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListNodesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.parent_node_id):
            query['parentNodeId'] = request.parent_node_id
        if not UtilClient.is_unset(request.with_permission_role):
            query['withPermissionRole'] = request.with_permission_role
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListNodes',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/nodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.ListNodesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_nodes_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.ListNodesRequest,
        headers: dingtalkwiki__2__0_models.ListNodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.ListNodesResponse:
        """
        @summary 获取节点列表
        
        @param request: ListNodesRequest
        @param headers: ListNodesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListNodesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.parent_node_id):
            query['parentNodeId'] = request.parent_node_id
        if not UtilClient.is_unset(request.with_permission_role):
            query['withPermissionRole'] = request.with_permission_role
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListNodes',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/nodes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.ListNodesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_nodes(
        self,
        request: dingtalkwiki__2__0_models.ListNodesRequest,
    ) -> dingtalkwiki__2__0_models.ListNodesResponse:
        """
        @summary 获取节点列表
        
        @param request: ListNodesRequest
        @return: ListNodesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.ListNodesHeaders()
        return self.list_nodes_with_options(request, headers, runtime)

    async def list_nodes_async(
        self,
        request: dingtalkwiki__2__0_models.ListNodesRequest,
    ) -> dingtalkwiki__2__0_models.ListNodesResponse:
        """
        @summary 获取节点列表
        
        @param request: ListNodesRequest
        @return: ListNodesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.ListNodesHeaders()
        return await self.list_nodes_with_options_async(request, headers, runtime)

    def list_teams_with_options(
        self,
        request: dingtalkwiki__2__0_models.ListTeamsRequest,
        headers: dingtalkwiki__2__0_models.ListTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.ListTeamsResponse:
        """
        @summary 获取知识小组列表
        
        @param request: ListTeamsRequest
        @param headers: ListTeamsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTeamsResponse
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
            action='ListTeams',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/teams',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.ListTeamsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_teams_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.ListTeamsRequest,
        headers: dingtalkwiki__2__0_models.ListTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.ListTeamsResponse:
        """
        @summary 获取知识小组列表
        
        @param request: ListTeamsRequest
        @param headers: ListTeamsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTeamsResponse
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
            action='ListTeams',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/teams',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.ListTeamsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_teams(
        self,
        request: dingtalkwiki__2__0_models.ListTeamsRequest,
    ) -> dingtalkwiki__2__0_models.ListTeamsResponse:
        """
        @summary 获取知识小组列表
        
        @param request: ListTeamsRequest
        @return: ListTeamsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.ListTeamsHeaders()
        return self.list_teams_with_options(request, headers, runtime)

    async def list_teams_async(
        self,
        request: dingtalkwiki__2__0_models.ListTeamsRequest,
    ) -> dingtalkwiki__2__0_models.ListTeamsResponse:
        """
        @summary 获取知识小组列表
        
        @param request: ListTeamsRequest
        @return: ListTeamsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.ListTeamsHeaders()
        return await self.list_teams_with_options_async(request, headers, runtime)

    def list_workspaces_with_options(
        self,
        request: dingtalkwiki__2__0_models.ListWorkspacesRequest,
        headers: dingtalkwiki__2__0_models.ListWorkspacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.ListWorkspacesResponse:
        """
        @summary 获取知识库列表
        
        @param request: ListWorkspacesRequest
        @param headers: ListWorkspacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListWorkspacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.order_by):
            query['orderBy'] = request.order_by
        if not UtilClient.is_unset(request.team_id):
            query['teamId'] = request.team_id
        if not UtilClient.is_unset(request.with_permission_role):
            query['withPermissionRole'] = request.with_permission_role
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListWorkspaces',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/workspaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.ListWorkspacesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_workspaces_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.ListWorkspacesRequest,
        headers: dingtalkwiki__2__0_models.ListWorkspacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.ListWorkspacesResponse:
        """
        @summary 获取知识库列表
        
        @param request: ListWorkspacesRequest
        @param headers: ListWorkspacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListWorkspacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.order_by):
            query['orderBy'] = request.order_by
        if not UtilClient.is_unset(request.team_id):
            query['teamId'] = request.team_id
        if not UtilClient.is_unset(request.with_permission_role):
            query['withPermissionRole'] = request.with_permission_role
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListWorkspaces',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/workspaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.ListWorkspacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_workspaces(
        self,
        request: dingtalkwiki__2__0_models.ListWorkspacesRequest,
    ) -> dingtalkwiki__2__0_models.ListWorkspacesResponse:
        """
        @summary 获取知识库列表
        
        @param request: ListWorkspacesRequest
        @return: ListWorkspacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.ListWorkspacesHeaders()
        return self.list_workspaces_with_options(request, headers, runtime)

    async def list_workspaces_async(
        self,
        request: dingtalkwiki__2__0_models.ListWorkspacesRequest,
    ) -> dingtalkwiki__2__0_models.ListWorkspacesResponse:
        """
        @summary 获取知识库列表
        
        @param request: ListWorkspacesRequest
        @return: ListWorkspacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.ListWorkspacesHeaders()
        return await self.list_workspaces_with_options_async(request, headers, runtime)

    def set_default_hand_over_user_with_options(
        self,
        request: dingtalkwiki__2__0_models.SetDefaultHandOverUserRequest,
        headers: dingtalkwiki__2__0_models.SetDefaultHandOverUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.SetDefaultHandOverUserResponse:
        """
        @summary 设置员工离职时知识库默认转交人
        
        @param request: SetDefaultHandOverUserRequest
        @param headers: SetDefaultHandOverUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetDefaultHandOverUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.default_handover_user_id):
            body['defaultHandoverUserId'] = request.default_handover_user_id
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
            action='SetDefaultHandOverUser',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/managementSettings/defaultHandOverUsers/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.SetDefaultHandOverUserResponse(),
            self.execute(params, req, runtime)
        )

    async def set_default_hand_over_user_with_options_async(
        self,
        request: dingtalkwiki__2__0_models.SetDefaultHandOverUserRequest,
        headers: dingtalkwiki__2__0_models.SetDefaultHandOverUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkwiki__2__0_models.SetDefaultHandOverUserResponse:
        """
        @summary 设置员工离职时知识库默认转交人
        
        @param request: SetDefaultHandOverUserRequest
        @param headers: SetDefaultHandOverUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetDefaultHandOverUserResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.default_handover_user_id):
            body['defaultHandoverUserId'] = request.default_handover_user_id
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
            action='SetDefaultHandOverUser',
            version='wiki_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/wiki/managementSettings/defaultHandOverUsers/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkwiki__2__0_models.SetDefaultHandOverUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_default_hand_over_user(
        self,
        request: dingtalkwiki__2__0_models.SetDefaultHandOverUserRequest,
    ) -> dingtalkwiki__2__0_models.SetDefaultHandOverUserResponse:
        """
        @summary 设置员工离职时知识库默认转交人
        
        @param request: SetDefaultHandOverUserRequest
        @return: SetDefaultHandOverUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.SetDefaultHandOverUserHeaders()
        return self.set_default_hand_over_user_with_options(request, headers, runtime)

    async def set_default_hand_over_user_async(
        self,
        request: dingtalkwiki__2__0_models.SetDefaultHandOverUserRequest,
    ) -> dingtalkwiki__2__0_models.SetDefaultHandOverUserResponse:
        """
        @summary 设置员工离职时知识库默认转交人
        
        @param request: SetDefaultHandOverUserRequest
        @return: SetDefaultHandOverUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkwiki__2__0_models.SetDefaultHandOverUserHeaders()
        return await self.set_default_hand_over_user_with_options_async(request, headers, runtime)
