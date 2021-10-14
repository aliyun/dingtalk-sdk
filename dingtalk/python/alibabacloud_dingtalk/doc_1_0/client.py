# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.doc_1_0 import models as dingtalkdoc__1__0_models
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

    def delete_workspace_members(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteWorkspaceMembersHeaders()
        return self.delete_workspace_members_with_options(workspace_id, request, headers, runtime)

    async def delete_workspace_members_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteWorkspaceMembersHeaders()
        return await self.delete_workspace_members_with_options_async(workspace_id, request, headers, runtime)

    def delete_workspace_members_with_options(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.DeleteWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse(),
            self.do_roarequest('DeleteWorkspaceMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/members/remove', 'none', req, runtime)
        )

    async def delete_workspace_members_with_options_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.DeleteWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteWorkspaceMembersResponse(),
            await self.do_roarequest_async('DeleteWorkspaceMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/members/remove', 'none', req, runtime)
        )

    def add_workspace_doc_members(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AddWorkspaceDocMembersHeaders()
        return self.add_workspace_doc_members_with_options(workspace_id, node_id, request, headers, runtime)

    async def add_workspace_doc_members_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AddWorkspaceDocMembersHeaders()
        return await self.add_workspace_doc_members_with_options_async(workspace_id, node_id, request, headers, runtime)

    def add_workspace_doc_members_with_options(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.AddWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse(),
            self.do_roarequest('AddWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members', 'none', req, runtime)
        )

    async def add_workspace_doc_members_with_options_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.AddWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AddWorkspaceDocMembersResponse(),
            await self.do_roarequest_async('AddWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members', 'none', req, runtime)
        )

    def update_workspace_members(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateWorkspaceMembersHeaders()
        return self.update_workspace_members_with_options(workspace_id, request, headers, runtime)

    async def update_workspace_members_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateWorkspaceMembersHeaders()
        return await self.update_workspace_members_with_options_async(workspace_id, request, headers, runtime)

    def update_workspace_members_with_options(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.UpdateWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse(),
            self.do_roarequest('UpdateWorkspaceMembers', 'doc_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/members', 'none', req, runtime)
        )

    async def update_workspace_members_with_options_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.UpdateWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateWorkspaceMembersResponse(),
            await self.do_roarequest_async('UpdateWorkspaceMembers', 'doc_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/members', 'none', req, runtime)
        )

    def update_workspace_doc_members(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersHeaders()
        return self.update_workspace_doc_members_with_options(workspace_id, node_id, request, headers, runtime)

    async def update_workspace_doc_members_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersHeaders()
        return await self.update_workspace_doc_members_with_options_async(workspace_id, node_id, request, headers, runtime)

    def update_workspace_doc_members_with_options(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse(),
            self.do_roarequest('UpdateWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members', 'none', req, runtime)
        )

    async def update_workspace_doc_members_with_options_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.UpdateWorkspaceDocMembersResponse(),
            await self.do_roarequest_async('UpdateWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members', 'none', req, runtime)
        )

    def create_workspace_doc(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.CreateWorkspaceDocRequest,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceDocResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateWorkspaceDocHeaders()
        return self.create_workspace_doc_with_options(workspace_id, request, headers, runtime)

    async def create_workspace_doc_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.CreateWorkspaceDocRequest,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceDocResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateWorkspaceDocHeaders()
        return await self.create_workspace_doc_with_options_async(workspace_id, request, headers, runtime)

    def create_workspace_doc_with_options(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.CreateWorkspaceDocRequest,
        headers: dingtalkdoc__1__0_models.CreateWorkspaceDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceDocResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.doc_type):
            body['docType'] = request.doc_type
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateWorkspaceDocResponse(),
            self.do_roarequest('CreateWorkspaceDoc', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/docs', 'json', req, runtime)
        )

    async def create_workspace_doc_with_options_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.CreateWorkspaceDocRequest,
        headers: dingtalkdoc__1__0_models.CreateWorkspaceDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceDocResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.doc_type):
            body['docType'] = request.doc_type
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateWorkspaceDocResponse(),
            await self.do_roarequest_async('CreateWorkspaceDoc', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/docs', 'json', req, runtime)
        )

    def add_workspace_members(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AddWorkspaceMembersHeaders()
        return self.add_workspace_members_with_options(workspace_id, request, headers, runtime)

    async def add_workspace_members_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceMembersRequest,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.AddWorkspaceMembersHeaders()
        return await self.add_workspace_members_with_options_async(workspace_id, request, headers, runtime)

    def add_workspace_members_with_options(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.AddWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AddWorkspaceMembersResponse(),
            self.do_roarequest('AddWorkspaceMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/members', 'json', req, runtime)
        )

    async def add_workspace_members_with_options_async(
        self,
        workspace_id: str,
        request: dingtalkdoc__1__0_models.AddWorkspaceMembersRequest,
        headers: dingtalkdoc__1__0_models.AddWorkspaceMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.AddWorkspaceMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.AddWorkspaceMembersResponse(),
            await self.do_roarequest_async('AddWorkspaceMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/members', 'json', req, runtime)
        )

    def create_workspace(
        self,
        request: dingtalkdoc__1__0_models.CreateWorkspaceRequest,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateWorkspaceHeaders()
        return self.create_workspace_with_options(request, headers, runtime)

    async def create_workspace_async(
        self,
        request: dingtalkdoc__1__0_models.CreateWorkspaceRequest,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.CreateWorkspaceHeaders()
        return await self.create_workspace_with_options_async(request, headers, runtime)

    def create_workspace_with_options(
        self,
        request: dingtalkdoc__1__0_models.CreateWorkspaceRequest,
        headers: dingtalkdoc__1__0_models.CreateWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_uid):
            body['dingUid'] = request.ding_uid
        if not UtilClient.is_unset(request.ding_access_token_type):
            body['dingAccessTokenType'] = request.ding_access_token_type
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateWorkspaceResponse(),
            self.do_roarequest('CreateWorkspace', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces', 'json', req, runtime)
        )

    async def create_workspace_with_options_async(
        self,
        request: dingtalkdoc__1__0_models.CreateWorkspaceRequest,
        headers: dingtalkdoc__1__0_models.CreateWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.CreateWorkspaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_uid):
            body['dingUid'] = request.ding_uid
        if not UtilClient.is_unset(request.ding_access_token_type):
            body['dingAccessTokenType'] = request.ding_access_token_type
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.CreateWorkspaceResponse(),
            await self.do_roarequest_async('CreateWorkspace', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces', 'json', req, runtime)
        )

    def delete_workspace_doc_members(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersHeaders()
        return self.delete_workspace_doc_members_with_options(workspace_id, node_id, request, headers, runtime)

    async def delete_workspace_doc_members_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersRequest,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersHeaders()
        return await self.delete_workspace_doc_members_with_options_async(workspace_id, node_id, request, headers, runtime)

    def delete_workspace_doc_members_with_options(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse(),
            self.do_roarequest('DeleteWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members/remove', 'none', req, runtime)
        )

    async def delete_workspace_doc_members_with_options_async(
        self,
        workspace_id: str,
        node_id: str,
        request: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersRequest,
        headers: dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.DeleteWorkspaceDocMembersResponse(),
            await self.do_roarequest_async('DeleteWorkspaceDocMembers', 'doc_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/doc/workspaces/{workspace_id}/docs/{node_id}/members/remove', 'none', req, runtime)
        )

    def get_workspace(
        self,
        workspace_id: str,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetWorkspaceHeaders()
        return self.get_workspace_with_options(workspace_id, headers, runtime)

    async def get_workspace_async(
        self,
        workspace_id: str,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__1__0_models.GetWorkspaceHeaders()
        return await self.get_workspace_with_options_async(workspace_id, headers, runtime)

    def get_workspace_with_options(
        self,
        workspace_id: str,
        headers: dingtalkdoc__1__0_models.GetWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetWorkspaceResponse(),
            self.do_roarequest('GetWorkspace', 'doc_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/doc/workspaces/{workspace_id}', 'json', req, runtime)
        )

    async def get_workspace_with_options_async(
        self,
        workspace_id: str,
        headers: dingtalkdoc__1__0_models.GetWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__1__0_models.GetWorkspaceResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkdoc__1__0_models.GetWorkspaceResponse(),
            await self.do_roarequest_async('GetWorkspace', 'doc_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/doc/workspaces/{workspace_id}', 'json', req, runtime)
        )
